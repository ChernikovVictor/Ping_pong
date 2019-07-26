namespace Tennis
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShapeBall = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.rectangleShapeRacket = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShapeField = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.menuSpeedBall = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemSpeed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSpeedBall.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShapeBall,
            this.rectangleShapeRacket,
            this.rectangleShapeField});
            this.shapeContainer1.Size = new System.Drawing.Size(570, 369);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShapeBall
            // 
            this.ovalShapeBall.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShapeBall.Location = new System.Drawing.Point(255, 292);
            this.ovalShapeBall.Name = "ovalShapeBall";
            this.ovalShapeBall.Size = new System.Drawing.Size(25, 25);
            this.ovalShapeBall.Click += new System.EventHandler(this.ovalShapeBall_Click);
            // 
            // rectangleShapeRacket
            // 
            this.rectangleShapeRacket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rectangleShapeRacket.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShapeRacket.Location = new System.Drawing.Point(231, 318);
            this.rectangleShapeRacket.Name = "rectangleShapeRacket";
            this.rectangleShapeRacket.Size = new System.Drawing.Size(75, 11);
            this.rectangleShapeRacket.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rectangleShapeRacket_KeyDown);
            this.rectangleShapeRacket.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rectangleShapeRacket_PreviewKeyDown);
            // 
            // rectangleShapeField
            // 
            this.rectangleShapeField.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rectangleShapeField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rectangleShapeField.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShapeField.Location = new System.Drawing.Point(43, 24);
            this.rectangleShapeField.Name = "rectangleShapeField";
            this.rectangleShapeField.Size = new System.Drawing.Size(465, 304);
            this.rectangleShapeField.Click += new System.EventHandler(this.rectangleShapeField_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(212, 175);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(127, 35);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(511, 21);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(53, 42);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Счет:\n0";
            // 
            // menuSpeedBall
            // 
            this.menuSpeedBall.BackColor = System.Drawing.Color.Yellow;
            this.menuSpeedBall.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSpeed});
            this.menuSpeedBall.Location = new System.Drawing.Point(0, 0);
            this.menuSpeedBall.Name = "menuSpeedBall";
            this.menuSpeedBall.Size = new System.Drawing.Size(570, 24);
            this.menuSpeedBall.TabIndex = 3;
            this.menuSpeedBall.Text = "menuSpeedBall";
            // 
            // ToolStripMenuItemSpeed
            // 
            this.ToolStripMenuItemSpeed.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.ToolStripMenuItemSpeed.Name = "ToolStripMenuItemSpeed";
            this.ToolStripMenuItemSpeed.Size = new System.Drawing.Size(102, 20);
            this.ToolStripMenuItemSpeed.Text = "Скорость мяча";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem1.Text = "1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem2.Text = "2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem4.Text = "4";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(570, 369);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.menuSpeedBall);
            this.Controls.Add(this.shapeContainer1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра: Теннис";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.menuSpeedBall.ResumeLayout(false);
            this.menuSpeedBall.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShapeRacket;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShapeField;
        private System.Windows.Forms.Button buttonStart;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShapeBall;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.MenuStrip menuSpeedBall;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSpeed;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;

    }
}

