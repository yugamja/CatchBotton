namespace CatchBotton
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
            RunningBotton = new Button();
            SuspendLayout();
            // 
            // RunningBotton
            // 
            RunningBotton.BackColor = Color.RosyBrown;
            RunningBotton.Font = new Font("궁서체", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            RunningBotton.ForeColor = SystemColors.ButtonFace;
            RunningBotton.Location = new Point(141, 147);
            RunningBotton.Name = "RunningBotton";
            RunningBotton.Size = new Size(233, 126);
            RunningBotton.TabIndex = 0;
            RunningBotton.Text = "나를 잡아봐";
            RunningBotton.UseVisualStyleBackColor = false;
            RunningBotton.Click += button1_Click;
            RunningBotton.MouseClick += RunningBotton_MouseClick;
            RunningBotton.MouseEnter += RunningBotton_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(RunningBotton);
            Name = "Form1";
            Text = "버튼 잡기 게임";
            ResumeLayout(false);
        }

        #endregion

        private Button RunningBotton;
    }
}
