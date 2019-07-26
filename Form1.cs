using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //DoubleBuffered = true; // боремся с мерцаниями
            toolStripMenuItem2.CheckState = CheckState.Checked; // скорость по умолчанию
        }

        Thread myThread; // поток для движения мяча
        private void buttonStart_Click(object sender, EventArgs e)
        {
            rectangleShapeRacket.Focus(); // фокус на ракетку
            buttonStart.Hide(); 
            //
            // инициализация потока делегатом с методом Moveball
            //
            myThread = new Thread(new ThreadStart(MoveBall));
            myThread.Start(); // запуск потока
        }

        //
        // Функция, определяющая положение и движение мяча MoveBall
        //
        private int dx = -2, dy = -2;   // смещение (скорость) мяча
        private int score = 0;          // счёт очков
        public int Score { get { return score; } }
        public void MoveBall()
        {
            while (true)    // играем, пока не проиграем
            {
                //DoubleBuffered = true;    // боремся с мерцаниями
                if (ovalShapeBall.Left <= rectangleShapeField.Left) // ударились о левую границу
                    dx = -dx;   // поменяли направление движения по горизонтали
                if (ovalShapeBall.Top <= rectangleShapeField.Top)   // ударились о верхнюю границу
                    dy = -dy;   // поменяли направление движения по вертикали
                if (ovalShapeBall.Right >= rectangleShapeField.Right)   // ударились о правую границу
                    dx = -dx;   // поменяли направление движения по горизонтали
                if (ovalShapeBall.Bottom >= rectangleShapeField.Bottom)  // ударились о нижнюю границу
                    break;      // проиграли
                //
                //  ударились о ракетку
                //
                if (ovalShapeBall.Bottom >= rectangleShapeRacket.Top && ovalShapeBall.Bottom <= rectangleShapeRacket.Bottom)
                {
                    // если ударились нижней точкой шарика
                    if (ovalShapeBall.Right <= rectangleShapeRacket.Right && ovalShapeBall.Left >= rectangleShapeRacket.Left)
                    {
                        int centerOfBall = (ovalShapeBall.Right - ovalShapeBall.Left) / 2 + ovalShapeBall.Left;
                        int centerOfRacket = (rectangleShapeRacket.Right - rectangleShapeRacket.Left) / 2 + rectangleShapeRacket.Left;
                        //
                        //  задаем направление: мяч ударился о правую половину ракетки => движение вправо
                        //  мяч ударился о левую половину ракетки => движение влево
                        //
                        if (centerOfBall < centerOfRacket && dx > 0)
                            dx = -dx;
                        if (centerOfBall > centerOfRacket && dx < 0)
                            dx = -dx;
                        dy = -dy;
                        score++;    // считаем очки
                    }
                    //
                    //  если ударились не нижней точкой шара, то смотрим, в какой угол ракетки
                    //  ударились и меняем направление движения (если нужно)
                    //
                    else if (ovalShapeBall.Left < rectangleShapeRacket.Left && ovalShapeBall.Right > rectangleShapeRacket.Left)
                    {
                        if (dx > 0)
                            dx = -dx;    
                        dy = -dy;
                        score++;
                    }
                    else if (ovalShapeBall.Left <= rectangleShapeRacket.Right && ovalShapeBall.Right > rectangleShapeRacket.Right)
                    {
                        if (dx < 0)
                            dx = -dx;
                        dy = -dy;
                        score++;
                    }
                }
                //
                //  перерисовываем мяч и графу счёта в потоке, создавшем форму
                //
                Action action = () =>
                    {
                        ovalShapeBall.Top += dy;
                        ovalShapeBall.Left += dx;
                        labelScore.Text = string.Format("Счет:\n{0}", score);
                    };
                Invoke(action);     // вызов метода action в главном (графическом) потоке
                Thread.Sleep(20);
            }
            //
            //  Игра окончена. Выводим форму, сигнализирующую об этом
            //
            FormGameOver f = new FormGameOver();
            f.SetScore = score; // передаем форме счёт игры
            if (f.ShowDialog() == DialogResult.Retry)
            {
                // запускаем игру заново
                Action action = () =>
                {
                    Application.Restart();  // Рестарт приложения
                };
                Invoke(action);
            }
            else
            {
                // конец игры
                Action action = () =>
                {
                    Close();    // завершаем приложение
                };
                Invoke(action);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // завершаем поток для мяча в случае закрытии формы во время игры
            if (myThread != null)
                if (myThread.IsAlive)
                    myThread.Abort();
        }

        //  toolStripMenuItem1..4 - скорость мяча (выбирает пользователь)
        //
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MakeAllMenuItemUnchecked(1);
            toolStripMenuItem1.CheckState = CheckState.Checked;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MakeAllMenuItemUnchecked(2);
            toolStripMenuItem2.CheckState = CheckState.Checked;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MakeAllMenuItemUnchecked(3);
            toolStripMenuItem3.CheckState = CheckState.Checked;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MakeAllMenuItemUnchecked(4);
            toolStripMenuItem4.CheckState = CheckState.Checked;
        }

        // устанавливает все пункты меню скорости "неотмеченными" и меняет скорость мяча
        private void MakeAllMenuItemUnchecked(ushort speed) // speed > 0
        {
            foreach (ToolStripMenuItem item in ToolStripMenuItemSpeed.DropDownItems)
            {
                item.CheckState = CheckState.Unchecked;
            }
            if (dx < 0)
                dx = -speed;
            else
                dx = speed;
            if (dy < 0)
                dy = -speed;
            else
                dy = speed;
        }

        // управление ракеткой
        private void rectangleShapeRacket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && rectangleShapeRacket.Left > rectangleShapeField.Left)
                rectangleShapeRacket.Left -= 5;
            if (e.KeyCode == Keys.Right && rectangleShapeRacket.Right < rectangleShapeField.Right)
                rectangleShapeRacket.Left += 5;
        }

        // событие, позволяющее приложению "адекватно" реагировать на команды управления ракеткой
        private void rectangleShapeRacket_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                e.IsInputKey = true;
        }

        // если случайно нажали курсором на поле, вернуть фокус ракетке
        private void rectangleShapeField_Click(object sender, EventArgs e)
        {
            rectangleShapeRacket.Focus();
        }

        // если случайно нажали курсором на форму, вернуть фокус ракетке
        private void Form1_Click(object sender, EventArgs e)
        {
            rectangleShapeRacket.Focus();
        }

        // если случайно нажали курсором на мяч, вернуть фокус ракетке
        private void ovalShapeBall_Click(object sender, EventArgs e)
        {
            rectangleShapeRacket.Focus();
        }
    }
}
