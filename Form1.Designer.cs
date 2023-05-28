namespace BirthdayApp
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
            this.components = new System.ComponentModel.Container();
            this.user_dbDataSet = new BirthdayApp.User_dbDataSet();
            this.birthdaysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthdaysTableAdapter = new BirthdayApp.User_dbDataSetTableAdapters.BirthdaysTableAdapter();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.enterNameL = new System.Windows.Forms.Label();
            this.chooseBirthDateL = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.birthdaysPanel = new System.Windows.Forms.Panel();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.user_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdaysBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // user_dbDataSet
            // 
            this.user_dbDataSet.DataSetName = "User_dbDataSet";
            this.user_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // birthdaysBindingSource
            // 
            this.birthdaysBindingSource.DataMember = "Birthdays";
            this.birthdaysBindingSource.DataSource = this.user_dbDataSet;
            // 
            // birthdaysTableAdapter
            // 
            this.birthdaysTableAdapter.ClearBeforeFill = true;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(15, 42);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(400, 20);
            this.nameTB.TabIndex = 1;
            // 
            // enterNameL
            // 
            this.enterNameL.AutoSize = true;
            this.enterNameL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterNameL.Location = new System.Drawing.Point(15, 13);
            this.enterNameL.Name = "enterNameL";
            this.enterNameL.Size = new System.Drawing.Size(77, 19);
            this.enterNameL.TabIndex = 2;
            this.enterNameL.Text = "Enter name";
            // 
            // chooseBirthDateL
            // 
            this.chooseBirthDateL.AutoSize = true;
            this.chooseBirthDateL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseBirthDateL.Location = new System.Drawing.Point(15, 70);
            this.chooseBirthDateL.Name = "chooseBirthDateL";
            this.chooseBirthDateL.Size = new System.Drawing.Size(133, 19);
            this.chooseBirthDateL.TabIndex = 3;
            this.chooseBirthDateL.Text = "Choose date of birth";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(255, 89);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // birthdaysPanel
            // 
            this.birthdaysPanel.AutoScroll = true;
            this.birthdaysPanel.Location = new System.Drawing.Point(15, 118);
            this.birthdaysPanel.Name = "birthdaysPanel";
            this.birthdaysPanel.Size = new System.Drawing.Size(400, 184);
            this.birthdaysPanel.TabIndex = 6;
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Location = new System.Drawing.Point(15, 92);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(200, 20);
            this.birthdayPicker.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 314);
            this.Controls.Add(this.birthdayPicker);
            this.Controls.Add(this.birthdaysPanel);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.chooseBirthDateL);
            this.Controls.Add(this.enterNameL);
            this.Controls.Add(this.nameTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdaysBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private User_dbDataSet user_dbDataSet;
        private System.Windows.Forms.BindingSource birthdaysBindingSource;
        private User_dbDataSetTableAdapters.BirthdaysTableAdapter birthdaysTableAdapter;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label enterNameL;
        private System.Windows.Forms.Label chooseBirthDateL;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel birthdaysPanel;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
    }
}

