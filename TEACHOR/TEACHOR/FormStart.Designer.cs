namespace TEACHOR
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.ButtonCab = new System.Windows.Forms.Button();
            this.TextBoxNubKab = new System.Windows.Forms.TextBox();
            this.ButtonStorage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBoxNewCab = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ButtonCab
            // 
            this.ButtonCab.Location = new System.Drawing.Point(21, 38);
            this.ButtonCab.Name = "ButtonCab";
            this.ButtonCab.Size = new System.Drawing.Size(107, 51);
            this.ButtonCab.TabIndex = 0;
            this.ButtonCab.Text = "Войти в кабинет";
            this.ButtonCab.UseVisualStyleBackColor = true;
            this.ButtonCab.Click += new System.EventHandler(this.ButtonCab_Click);
            // 
            // TextBoxNubKab
            // 
            this.TextBoxNubKab.Location = new System.Drawing.Point(134, 54);
            this.TextBoxNubKab.MaxLength = 4;
            this.TextBoxNubKab.Name = "TextBoxNubKab";
            this.TextBoxNubKab.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNubKab.TabIndex = 1;
            this.TextBoxNubKab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNubKab_KeyPress);
            // 
            // ButtonStorage
            // 
            this.ButtonStorage.Location = new System.Drawing.Point(245, 94);
            this.ButtonStorage.Name = "ButtonStorage";
            this.ButtonStorage.Size = new System.Drawing.Size(96, 37);
            this.ButtonStorage.TabIndex = 2;
            this.ButtonStorage.Text = "Склад";
            this.ButtonStorage.UseVisualStyleBackColor = true;
            this.ButtonStorage.Click += new System.EventHandler(this.ButtonStorage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер кабинета";
            // 
            // CheckBoxNewCab
            // 
            this.CheckBoxNewCab.AutoSize = true;
            this.CheckBoxNewCab.Location = new System.Drawing.Point(245, 57);
            this.CheckBoxNewCab.Name = "CheckBoxNewCab";
            this.CheckBoxNewCab.Size = new System.Drawing.Size(113, 17);
            this.CheckBoxNewCab.TabIndex = 4;
            this.CheckBoxNewCab.Text = "Новый кабинет ?";
            this.CheckBoxNewCab.UseVisualStyleBackColor = true;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 163);
            this.Controls.Add(this.CheckBoxNewCab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonStorage);
            this.Controls.Add(this.TextBoxNubKab);
            this.Controls.Add(this.ButtonCab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС \"TEACHOR\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStart_FormClosed);
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCab;
        private System.Windows.Forms.TextBox TextBoxNubKab;
        private System.Windows.Forms.Button ButtonStorage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckBoxNewCab;
    }
}