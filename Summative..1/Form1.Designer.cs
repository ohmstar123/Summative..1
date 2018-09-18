namespace Summative._._1
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
            this.Image_button = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Image_button
            // 
            this.Image_button.BackgroundImage = global::Summative._1.Properties.Resources.lion_king_wd070;
            this.Image_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Image_button.CausesValidation = false;
            this.Image_button.FlatAppearance.BorderSize = 0;
            this.Image_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Image_button.Location = new System.Drawing.Point(12, 0);
            this.Image_button.Name = "Image_button";
            this.Image_button.Size = new System.Drawing.Size(759, 452);
            this.Image_button.TabIndex = 0;
            this.Image_button.UseVisualStyleBackColor = true;
            this.Image_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Ivory;
            this.Title.Font = new System.Drawing.Font("Prestige Elite Std", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(538, 316);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(62, 31);
            this.Title.TabIndex = 1;
            this.Title.Text = "LEO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Image_button);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Image_button;
        private System.Windows.Forms.Label Title;
    }
}

