namespace WinFormsApp1
{
    partial class staffForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уволитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кадровоеАгенствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewSF = new System.Windows.Forms.DataGridView();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSF)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.кадровоеАгенствоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.уволитьToolStripMenuItem,
            this.обновитьТаблицуToolStripMenuItem,
            this.редактироватьToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // уволитьToolStripMenuItem
            // 
            this.уволитьToolStripMenuItem.Name = "уволитьToolStripMenuItem";
            this.уволитьToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.уволитьToolStripMenuItem.Text = "Уволить сотрудника";
            this.уволитьToolStripMenuItem.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // обновитьТаблицуToolStripMenuItem
            // 
            this.обновитьТаблицуToolStripMenuItem.Name = "обновитьТаблицуToolStripMenuItem";
            this.обновитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.обновитьТаблицуToolStripMenuItem.Text = "Обновить таблицу";
            this.обновитьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // кадровоеАгенствоToolStripMenuItem
            // 
            this.кадровоеАгенствоToolStripMenuItem.Name = "кадровоеАгенствоToolStripMenuItem";
            this.кадровоеАгенствоToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.кадровоеАгенствоToolStripMenuItem.Text = "Кадровое агенство";
            this.кадровоеАгенствоToolStripMenuItem.Click += new System.EventHandler(this.кадровоеАгенствоToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewSF);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonReload);
            this.splitContainer1.Panel2.Controls.Add(this.buttonEdit);
            this.splitContainer1.Panel2.Controls.Add(this.buttonRemove);
            this.splitContainer1.Size = new System.Drawing.Size(954, 537);
            this.splitContainer1.SplitterDistance = 790;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridViewSF
            // 
            this.dataGridViewSF.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(207)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSF.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.age,
            this.salary,
            this.prof,
            this.contact});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSF.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSF.EnableHeadersVisualStyles = false;
            this.dataGridViewSF.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSF.Name = "dataGridViewSF";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSF.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSF.RowTemplate.Height = 25;
            this.dataGridViewSF.Size = new System.Drawing.Size(786, 533);
            this.dataGridViewSF.TabIndex = 0;
            // 
            // buttonReload
            // 
            this.buttonReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReload.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonReload.Image = ((System.Drawing.Image)(resources.GetObject("buttonReload.Image")));
            this.buttonReload.Location = new System.Drawing.Point(3, 271);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(153, 128);
            this.buttonReload.TabIndex = 3;
            this.buttonReload.Text = "Обновить   таблицу";
            this.buttonReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.Location = new System.Drawing.Point(3, 137);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(153, 128);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Редактировать данные";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemove.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonRemove.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemove.Image")));
            this.buttonRemove.Location = new System.Drawing.Point(3, 3);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(153, 128);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Уволить сотрудника";
            this.buttonRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 49;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "Ф.И.О";
            this.name.Name = "name";
            this.name.Width = 76;
            // 
            // age
            // 
            this.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.age.DefaultCellStyle = dataGridViewCellStyle2;
            this.age.HeaderText = "Год рождения";
            this.age.Name = "age";
            this.age.Width = 135;
            // 
            // salary
            // 
            this.salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.salary.DefaultCellStyle = dataGridViewCellStyle3;
            this.salary.HeaderText = "Оклад";
            this.salary.Name = "salary";
            this.salary.Width = 78;
            // 
            // prof
            // 
            this.prof.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prof.HeaderText = "Должность";
            this.prof.Name = "prof";
            this.prof.Width = 113;
            // 
            // contact
            // 
            this.contact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.contact.HeaderText = "Контакты";
            this.contact.Name = "contact";
            // 
            // staffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "staffForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Штат сотрудников";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStripMenuItem действияToolStripMenuItem;
        private ToolStripMenuItem уволитьToolStripMenuItem;
        private ToolStripMenuItem обновитьТаблицуToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem кадровоеАгенствоToolStripMenuItem;
        private MenuStrip menuStrip1;
        private SplitContainer splitContainer1;
        private DataGridView dataGridViewSF;
        private Button buttonRemove;
        private Button buttonReload;
        private Button buttonEdit;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn salary;
        private DataGridViewTextBoxColumn prof;
        private DataGridViewTextBoxColumn contact;
    }
}