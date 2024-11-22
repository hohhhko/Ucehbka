namespace TEACHOR
{
    partial class FormStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStorage));
            this.ComboCabun = new System.Windows.Forms.ComboBox();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ComboStatus = new System.Windows.Forms.ComboBox();
            this.ComboRespond = new System.Windows.Forms.ComboBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.DataGridAll = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxCost = new System.Windows.Forms.TextBox();
            this.DateTEchn = new System.Windows.Forms.DateTimePicker();
            this.DataGridKab = new System.Windows.Forms.DataGridView();
            this.ButtonRefres = new System.Windows.Forms.Button();
            this.ContextMenus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuErase = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuChange = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuDel = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridKab)).BeginInit();
            this.ContextMenus.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboCabun
            // 
            this.ComboCabun.FormattingEnabled = true;
            this.ComboCabun.Location = new System.Drawing.Point(12, 28);
            this.ComboCabun.Name = "ComboCabun";
            this.ComboCabun.Size = new System.Drawing.Size(121, 21);
            this.ComboCabun.TabIndex = 0;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(518, 18);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(63, 38);
            this.ButtonBack.TabIndex = 1;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComboStatus
            // 
            this.ComboStatus.FormattingEnabled = true;
            this.ComboStatus.Items.AddRange(new object[] {
            "Новый",
            "Рабочий",
            "Не рабочий",
            "На ремонте",
            "Списан"});
            this.ComboStatus.Location = new System.Drawing.Point(159, 28);
            this.ComboStatus.Name = "ComboStatus";
            this.ComboStatus.Size = new System.Drawing.Size(121, 21);
            this.ComboStatus.TabIndex = 2;
            // 
            // ComboRespond
            // 
            this.ComboRespond.FormattingEnabled = true;
            this.ComboRespond.Location = new System.Drawing.Point(307, 28);
            this.ComboRespond.Name = "ComboRespond";
            this.ComboRespond.Size = new System.Drawing.Size(121, 21);
            this.ComboRespond.TabIndex = 3;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(306, 75);
            this.TextBoxName.MaxLength = 50;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(122, 20);
            this.TextBoxName.TabIndex = 6;
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.Location = new System.Drawing.Point(445, 65);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(76, 38);
            this.ButtonInsert.TabIndex = 7;
            this.ButtonInsert.Text = "Добавить на склад";
            this.ButtonInsert.UseVisualStyleBackColor = true;
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // DataGridAll
            // 
            this.DataGridAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAll.Location = new System.Drawing.Point(10, 139);
            this.DataGridAll.Name = "DataGridAll";
            this.DataGridAll.ReadOnly = true;
            this.DataGridAll.Size = new System.Drawing.Size(571, 97);
            this.DataGridAll.TabIndex = 8;
            this.DataGridAll.Click += new System.EventHandler(this.DataGridAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Кабинет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Статус";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ответсвеный";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Стоимость";
            // 
            // TextBoxCost
            // 
            this.TextBoxCost.Location = new System.Drawing.Point(158, 75);
            this.TextBoxCost.MaxLength = 10;
            this.TextBoxCost.Name = "TextBoxCost";
            this.TextBoxCost.Size = new System.Drawing.Size(122, 20);
            this.TextBoxCost.TabIndex = 14;
            this.TextBoxCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCost_KeyPress);
            // 
            // DateTEchn
            // 
            this.DateTEchn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTEchn.Location = new System.Drawing.Point(12, 75);
            this.DateTEchn.Name = "DateTEchn";
            this.DateTEchn.Size = new System.Drawing.Size(121, 20);
            this.DateTEchn.TabIndex = 15;
            // 
            // DataGridKab
            // 
            this.DataGridKab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridKab.Location = new System.Drawing.Point(12, 242);
            this.DataGridKab.Name = "DataGridKab";
            this.DataGridKab.ReadOnly = true;
            this.DataGridKab.Size = new System.Drawing.Size(569, 97);
            this.DataGridKab.TabIndex = 16;
            this.DataGridKab.Click += new System.EventHandler(this.DataGridKab_Click);
            // 
            // ButtonRefres
            // 
            this.ButtonRefres.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonRefres.BackgroundImage")));
            this.ButtonRefres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonRefres.Location = new System.Drawing.Point(460, 17);
            this.ButtonRefres.Name = "ButtonRefres";
            this.ButtonRefres.Size = new System.Drawing.Size(40, 39);
            this.ButtonRefres.TabIndex = 17;
            this.ButtonRefres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonRefres.UseVisualStyleBackColor = true;
            this.ButtonRefres.Click += new System.EventHandler(this.ButtonRefres_Click);
            // 
            // ContextMenus
            // 
            this.ContextMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuErase,
            this.ToolStripMenuChange,
            this.ToolStripMenuDel});
            this.ContextMenus.Name = "ContextMenu";
            this.ContextMenus.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ContextMenus.Size = new System.Drawing.Size(179, 70);
            // 
            // ToolStripMenuErase
            // 
            this.ToolStripMenuErase.Name = "ToolStripMenuErase";
            this.ToolStripMenuErase.Size = new System.Drawing.Size(178, 22);
            this.ToolStripMenuErase.Text = "Перевести технику";
            // 
            // ToolStripMenuChange
            // 
            this.ToolStripMenuChange.Name = "ToolStripMenuChange";
            this.ToolStripMenuChange.Size = new System.Drawing.Size(178, 22);
            this.ToolStripMenuChange.Text = "Выбрать";
            // 
            // ToolStripMenuDel
            // 
            this.ToolStripMenuDel.Name = "ToolStripMenuDel";
            this.ToolStripMenuDel.Size = new System.Drawing.Size(178, 22);
            this.ToolStripMenuDel.Text = "Удалить";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Выделеите строку для работы";
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(527, 62);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(56, 44);
            this.ButtonUpdate.TabIndex = 19;
            this.ButtonUpdate.Text = "Изменить";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpadet_Click_1);
            // 
            // FormStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 348);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtonRefres);
            this.Controls.Add(this.DataGridKab);
            this.Controls.Add(this.DateTEchn);
            this.Controls.Add(this.TextBoxCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridAll);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.ComboRespond);
            this.Controls.Add(this.ComboStatus);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ComboCabun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStorage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStorage_FormClosed);
            this.Load += new System.EventHandler(this.FormStorage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridKab)).EndInit();
            this.ContextMenus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboCabun;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.ComboBox ComboStatus;
        private System.Windows.Forms.ComboBox ComboRespond;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Button ButtonInsert;
        private System.Windows.Forms.DataGridView DataGridAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxCost;
        private System.Windows.Forms.DateTimePicker DateTEchn;
        private System.Windows.Forms.DataGridView DataGridKab;
        private System.Windows.Forms.Button ButtonRefres;
        private System.Windows.Forms.ContextMenuStrip ContextMenus;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuErase;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuChange;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuDel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonUpdate;
    }
}