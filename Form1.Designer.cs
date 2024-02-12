namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BoruÜst = new PictureBox();
            FlaffyBird = new PictureBox();
            BoruAlt = new PictureBox();
            Zemin = new PictureBox();
            ScoreText = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)BoruÜst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FlaffyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BoruAlt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Zemin).BeginInit();
            SuspendLayout();
            // 
            // BoruÜst
            // 
            BoruÜst.Image = (Image)resources.GetObject("BoruÜst.Image");
            BoruÜst.Location = new Point(447, -2);
            BoruÜst.Name = "BoruÜst";
            BoruÜst.Size = new Size(85, 95);
            BoruÜst.SizeMode = PictureBoxSizeMode.StretchImage;
            BoruÜst.TabIndex = 0;
            BoruÜst.TabStop = false;
            // 
            // FlaffyBird
            // 
            FlaffyBird.Image = (Image)resources.GetObject("FlaffyBird.Image");
            FlaffyBird.Location = new Point(12, 111);
            FlaffyBird.Name = "FlaffyBird";
            FlaffyBird.Size = new Size(79, 60);
            FlaffyBird.TabIndex = 1;
            FlaffyBird.TabStop = false;
            // 
            // BoruAlt
            // 
            BoruAlt.Image = (Image)resources.GetObject("BoruAlt.Image");
            BoruAlt.Location = new Point(444, 261);
            BoruAlt.Name = "BoruAlt";
            BoruAlt.Size = new Size(88, 88);
            BoruAlt.SizeMode = PictureBoxSizeMode.StretchImage;
            BoruAlt.TabIndex = 2;
            BoruAlt.TabStop = false;
            // 
            // Zemin
            // 
            Zemin.Image = (Image)resources.GetObject("Zemin.Image");
            Zemin.Location = new Point(-12, 346);
            Zemin.Name = "Zemin";
            Zemin.Size = new Size(802, 71);
            Zemin.SizeMode = PictureBoxSizeMode.StretchImage;
            Zemin.TabIndex = 3;
            Zemin.TabStop = false;
            // 
            // ScoreText
            // 
            ScoreText.AccessibleName = "ScoreText";
            ScoreText.AutoSize = true;
            ScoreText.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ScoreText.Location = new Point(1, 409);
            ScoreText.Name = "ScoreText";
            ScoreText.Size = new Size(146, 46);
            ScoreText.TabIndex = 4;
            ScoreText.Text = "Score: 0";
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(771, 450);
            Controls.Add(FlaffyBird);
            Controls.Add(ScoreText);
            Controls.Add(Zemin);
            Controls.Add(BoruAlt);
            Controls.Add(BoruÜst);
            Name = "Form1";
            Text = "FlappyBird";
            KeyDown += gameKeyDown;
            KeyUp += gameKeyUp;
            ((System.ComponentModel.ISupportInitialize)BoruÜst).EndInit();
            ((System.ComponentModel.ISupportInitialize)FlaffyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)BoruAlt).EndInit();
            ((System.ComponentModel.ISupportInitialize)Zemin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BoruÜst;
        private PictureBox FlaffyBird;
        private PictureBox BoruAlt;
        private PictureBox Zemin;
        private Label ScoreText;
        private System.Windows.Forms.Timer GameTimer;
    }
}
