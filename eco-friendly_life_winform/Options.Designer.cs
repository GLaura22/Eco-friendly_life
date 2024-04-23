namespace eco_friendly_life_winform
{
    partial class Options
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
            this.option1pictureBox = new System.Windows.Forms.PictureBox();
            this.option1label = new System.Windows.Forms.Label();
            this.option2pictureBox = new System.Windows.Forms.PictureBox();
            this.option3pictureBox = new System.Windows.Forms.PictureBox();
            this.option2label = new System.Windows.Forms.Label();
            this.option3label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.option1pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option2pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option3pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // option1pictureBox
            // 
            this.option1pictureBox.Location = new System.Drawing.Point(41, 39);
            this.option1pictureBox.Name = "option1pictureBox";
            this.option1pictureBox.Size = new System.Drawing.Size(168, 104);
            this.option1pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.option1pictureBox.TabIndex = 0;
            this.option1pictureBox.TabStop = false;
            // 
            // option1label
            // 
            this.option1label.AutoSize = true;
            this.option1label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(143)))), ((int)(((byte)(224)))));
            this.option1label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.option1label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.option1label.Location = new System.Drawing.Point(40, 192);
            this.option1label.Name = "option1label";
            this.option1label.Size = new System.Drawing.Size(43, 17);
            this.option1label.TabIndex = 1;
            this.option1label.Text = "label1";
            // 
            // option2pictureBox
            // 
            this.option2pictureBox.Location = new System.Drawing.Point(226, 90);
            this.option2pictureBox.Name = "option2pictureBox";
            this.option2pictureBox.Size = new System.Drawing.Size(168, 104);
            this.option2pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.option2pictureBox.TabIndex = 2;
            this.option2pictureBox.TabStop = false;
            // 
            // option3pictureBox
            // 
            this.option3pictureBox.Location = new System.Drawing.Point(409, 140);
            this.option3pictureBox.Name = "option3pictureBox";
            this.option3pictureBox.Size = new System.Drawing.Size(168, 104);
            this.option3pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.option3pictureBox.TabIndex = 3;
            this.option3pictureBox.TabStop = false;
            // 
            // option2label
            // 
            this.option2label.AutoSize = true;
            this.option2label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(143)))), ((int)(((byte)(224)))));
            this.option2label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.option2label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.option2label.Location = new System.Drawing.Point(226, 227);
            this.option2label.Name = "option2label";
            this.option2label.Size = new System.Drawing.Size(43, 17);
            this.option2label.TabIndex = 4;
            this.option2label.Text = "label1";
            // 
            // option3label
            // 
            this.option3label.AutoSize = true;
            this.option3label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(143)))), ((int)(((byte)(224)))));
            this.option3label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.option3label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.option3label.Location = new System.Drawing.Point(409, 273);
            this.option3label.Name = "option3label";
            this.option3label.Size = new System.Drawing.Size(43, 17);
            this.option3label.TabIndex = 5;
            this.option3label.Text = "label1";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 299);
            this.Controls.Add(this.option3label);
            this.Controls.Add(this.option2label);
            this.Controls.Add(this.option3pictureBox);
            this.Controls.Add(this.option2pictureBox);
            this.Controls.Add(this.option1label);
            this.Controls.Add(this.option1pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Options";
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.option1pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option2pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option3pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox option1pictureBox;
        private Label option1label;
        private PictureBox option2pictureBox;
        private PictureBox option3pictureBox;
        private Label option2label;
        private Label option3label;
    }
}