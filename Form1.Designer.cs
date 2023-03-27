namespace assigment1
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
            this.components = new System.ComponentModel.Container();
            this.imgRedCard = new System.Windows.Forms.PictureBox();
            this.imgBlackCard = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgRedCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBlackCard)).BeginInit();
            this.SuspendLayout();
            // 
            // imgRedCard
            // 
            this.imgRedCard.Image = global::assigment1.Properties.Resources._71e5ff875ee1cae7a15d300a26ee7f57__red_chiffon_design_art;
            this.imgRedCard.Location = new System.Drawing.Point(348, 162);
            this.imgRedCard.Name = "imgRedCard";
            this.imgRedCard.Size = new System.Drawing.Size(82, 126);
            this.imgRedCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRedCard.TabIndex = 0;
            this.imgRedCard.TabStop = false;
            this.imgRedCard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgRedCard_MoseDown);
            this.imgRedCard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgRedCard_MouseMove);
            this.imgRedCard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imgRedCard_MoseUp);
            // 
            // imgBlackCard
            // 
            this.imgBlackCard.Image = global::assigment1.Properties.Resources.s_l500;
            this.imgBlackCard.Location = new System.Drawing.Point(84, 119);
            this.imgBlackCard.Name = "imgBlackCard";
            this.imgBlackCard.Size = new System.Drawing.Size(82, 125);
            this.imgBlackCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBlackCard.TabIndex = 1;
            this.imgBlackCard.TabStop = false;
            this.imgBlackCard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgBlackCard_MoseDown);
            this.imgBlackCard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgBlackCard_MouseMove);
            this.imgBlackCard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imgBlackCard_MoseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 35;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 456);
            this.Controls.Add(this.imgBlackCard);
            this.Controls.Add(this.imgRedCard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imgRedCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBlackCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox imgRedCard;
        private PictureBox imgBlackCard;
        private System.Windows.Forms.Timer timer1;
    }
}