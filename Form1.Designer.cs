namespace headsOrTails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.headsBox = new System.Windows.Forms.PictureBox();
            this.tailsBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.headsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headsBox
            // 
            this.headsBox.Image = ((System.Drawing.Image)(resources.GetObject("headsBox.Image")));
            this.headsBox.Location = new System.Drawing.Point(211, 116);
            this.headsBox.Name = "headsBox";
            this.headsBox.Size = new System.Drawing.Size(100, 116);
            this.headsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headsBox.TabIndex = 0;
            this.headsBox.TabStop = false;
            // 
            // tailsBox
            // 
            this.tailsBox.Image = ((System.Drawing.Image)(resources.GetObject("tailsBox.Image")));
            this.tailsBox.Location = new System.Drawing.Point(470, 115);
            this.tailsBox.Name = "tailsBox";
            this.tailsBox.Size = new System.Drawing.Size(100, 117);
            this.tailsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsBox.TabIndex = 1;
            this.tailsBox.TabStop = false;
            this.tailsBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click a button below the picture";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "SHOW HEADS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(470, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "SHOW TAILS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(350, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tailsBox);
            this.Controls.Add(this.headsBox);
            this.Name = "Form1";
            this.Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.headsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox headsBox;
        private System.Windows.Forms.PictureBox tailsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

