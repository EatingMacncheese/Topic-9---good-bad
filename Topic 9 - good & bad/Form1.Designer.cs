namespace Topic_9___good___bad
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGood = new System.Windows.Forms.Button();
            this.btnBad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imgRickroll = new System.Windows.Forms.PictureBox();
            this.imgYippee = new System.Windows.Forms.PictureBox();
            this.lblOr = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgRickroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgYippee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGood
            // 
            this.btnGood.Location = new System.Drawing.Point(236, 166);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(75, 23);
            this.btnGood.TabIndex = 0;
            this.btnGood.Text = "Good";
            this.btnGood.UseVisualStyleBackColor = true;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnBad
            // 
            this.btnBad.Location = new System.Drawing.Point(510, 166);
            this.btnBad.Name = "btnBad";
            this.btnBad.Size = new System.Drawing.Size(75, 23);
            this.btnBad.TabIndex = 1;
            this.btnBad.Text = "Bad";
            this.btnBad.UseVisualStyleBackColor = true;
            this.btnBad.Click += new System.EventHandler(this.btnBad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "What do you choose";
            // 
            // imgRickroll
            // 
            this.imgRickroll.Image = global::Topic_9___good___bad.Properties.Resources.rickroll_4k;
            this.imgRickroll.Location = new System.Drawing.Point(297, 195);
            this.imgRickroll.Name = "imgRickroll";
            this.imgRickroll.Size = new System.Drawing.Size(225, 152);
            this.imgRickroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRickroll.TabIndex = 4;
            this.imgRickroll.TabStop = false;
            this.imgRickroll.Visible = false;
            // 
            // imgYippee
            // 
            this.imgYippee.Image = global::Topic_9___good___bad.Properties.Resources.yippee_happy;
            this.imgYippee.Location = new System.Drawing.Point(348, 213);
            this.imgYippee.Name = "imgYippee";
            this.imgYippee.Size = new System.Drawing.Size(128, 116);
            this.imgYippee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgYippee.TabIndex = 3;
            this.imgYippee.TabStop = false;
            this.imgYippee.Visible = false;
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(397, 171);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(18, 13);
            this.lblOr.TabIndex = 5;
            this.lblOr.Text = "Or";
            this.lblOr.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(713, 415);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.imgRickroll);
            this.Controls.Add(this.imgYippee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBad);
            this.Controls.Add(this.btnGood);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgRickroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgYippee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.Button btnBad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgYippee;
        private System.Windows.Forms.PictureBox imgRickroll;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Button btnQuit;
    }
}

