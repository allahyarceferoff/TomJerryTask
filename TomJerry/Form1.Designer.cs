namespace TomJerry
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

       
        private void InitializeComponent()
        {
            this.jerryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
           
            this.jerryBtn.AutoSize = true;
            this.jerryBtn.BackColor = System.Drawing.Color.Transparent;
            this.jerryBtn.BackgroundImage = global::TomJerry.Properties.Resources.jerry22__3_;
            this.jerryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.jerryBtn.FlatAppearance.BorderSize = 0;
            this.jerryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.jerryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.jerryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jerryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jerryBtn.ForeColor = System.Drawing.Color.Transparent;
            this.jerryBtn.Location = new System.Drawing.Point(326, 403);
            this.jerryBtn.Name = "jerryBtn";
            this.jerryBtn.Size = new System.Drawing.Size(100, 100);
            this.jerryBtn.TabIndex = 0;
            this.jerryBtn.UseVisualStyleBackColor = false;
            this.jerryBtn.Click += new System.EventHandler(this.jerryBtn_Click);
            this.jerryBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.jerryBtn_MouseMove);
             
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TomJerry.Properties.Resources.tom1;
            this.ClientSize = new System.Drawing.Size(884, 628);
            this.Controls.Add(this.jerryBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jerryBtn;
    }
}

