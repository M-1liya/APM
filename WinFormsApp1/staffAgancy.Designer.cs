namespace WinFormsApp1
{
    partial class staffAgancy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffAgancy));
            this.Действия = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСоискателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нанятьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.штатСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddWorker = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Действия
            // 
            this.Действия.Name = "Действия";
            this.Действия.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.штатСотрудниковToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСоискателяToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.обновитьТаблицуToolStripMenuItem,
            this.нанятьToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // добавитьСоискателяToolStripMenuItem
            // 
            this.добавитьСоискателяToolStripMenuItem.Name = "добавитьСоискателяToolStripMenuItem";
            this.добавитьСоискателяToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.добавитьСоискателяToolStripMenuItem.Text = "Добавить соискателя";
            this.добавитьСоискателяToolStripMenuItem.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // обновитьТаблицуToolStripMenuItem
            // 
            this.обновитьТаблицуToolStripMenuItem.Name = "обновитьТаблицуToolStripMenuItem";
            this.обновитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.обновитьТаблицуToolStripMenuItem.Text = "Обновить таблицу";
            this.обновитьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.обновитьТаблицуToolStripMenuItem_Click);
            // 
            // нанятьToolStripMenuItem
            // 
            this.нанятьToolStripMenuItem.Name = "нанятьToolStripMenuItem";
            this.нанятьToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.нанятьToolStripMenuItem.Text = "Нанять соискателя";
            this.нанятьToolStripMenuItem.Click += new System.EventHandler(this.buttonAddWorker_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // штатСотрудниковToolStripMenuItem
            // 
            this.штатСотрудниковToolStripMenuItem.Name = "штатСотрудниковToolStripMenuItem";
            this.штатСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.штатСотрудниковToolStripMenuItem.Text = "Штат сотрудников";
            this.штатСотрудниковToolStripMenuItem.Click += new System.EventHandler(this.штатСотрудниковToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonEdit);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDelete);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddWorker);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAdd);
            this.splitContainer1.Size = new System.Drawing.Size(954, 537);
            this.splitContainer1.SplitterDistance = 790;
            this.splitContainer1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(207)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this._Name,
            this.Age,
            this.exp,
            this.contact,
            this.profesion});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(786, 533);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 49;
            // 
            // _Name
            // 
            this._Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._Name.HeaderText = "Ф.И.О.";
            this._Name.Name = "_Name";
            this._Name.Width = 79;
            // 
            // Age
            // 
            this.Age.HeaderText = "Год рождения";
            this.Age.Name = "Age";
            // 
            // exp
            // 
            this.exp.HeaderText = "Стаж работы";
            this.exp.Name = "exp";
            // 
            // contact
            // 
            this.contact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.contact.HeaderText = "Контакты";
            this.contact.Name = "contact";
            // 
            // profesion
            // 
            this.profesion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.profesion.HeaderText = "Профессия";
            this.profesion.Name = "profesion";
            this.profesion.Width = 113;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.Location = new System.Drawing.Point(3, 405);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(153, 128);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Редактировать данные";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(3, 271);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(153, 128);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить соискателя";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddWorker
            // 
            this.buttonAddWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddWorker.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonAddWorker.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddWorker.Image")));
            this.buttonAddWorker.Location = new System.Drawing.Point(3, 137);
            this.buttonAddWorker.Name = "buttonAddWorker";
            this.buttonAddWorker.Size = new System.Drawing.Size(153, 128);
            this.buttonAddWorker.TabIndex = 1;
            this.buttonAddWorker.Text = "Нанять  соискателя";
            this.buttonAddWorker.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddWorker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddWorker.UseVisualStyleBackColor = true;
            this.buttonAddWorker.Click += new System.EventHandler(this.buttonAddWorker_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(153, 128);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить соискателя";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // staffAgancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "staffAgancy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Кадровое агенство";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.staffAgancy_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip Действия;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem действияToolStripMenuItem;
        private ToolStripMenuItem добавитьСоискателяToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem обновитьТаблицуToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem штатСотрудниковToolStripMenuItem;
        private SplitContainer splitContainer1;
        private Button buttonAdd;
        private ToolStripMenuItem нанятьToolStripMenuItem;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonAddWorker;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn _Name;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn exp;
        private DataGridViewTextBoxColumn contact;
        private DataGridViewTextBoxColumn profesion;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
    }
}