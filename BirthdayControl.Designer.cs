namespace BirthdayApp
{
    partial class BirthdayControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameL = new System.Windows.Forms.Label();
            this.birthdayL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameL.Location = new System.Drawing.Point(3, 0);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(42, 15);
            this.nameL.TabIndex = 0;
            this.nameL.Text = "nameL";
            // 
            // birthdayL
            // 
            this.birthdayL.AutoSize = true;
            this.birthdayL.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdayL.Location = new System.Drawing.Point(308, 0);
            this.birthdayL.Name = "birthdayL";
            this.birthdayL.Size = new System.Drawing.Size(59, 15);
            this.birthdayL.TabIndex = 1;
            this.birthdayL.Text = "birthdayL";
            // 
            // BirthdayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.birthdayL);
            this.Controls.Add(this.nameL);
            this.Name = "BirthdayControl";
            this.Size = new System.Drawing.Size(400, 22);            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Label birthdayL;
    }
}
