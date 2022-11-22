namespace WinFormsApp1
{
    partial class SaveDataDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveDataDialog));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDontSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(82, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вы хотите сохранить изменения?\nПри нажатии  \"Не сохранять\" последние изменения бу" +
    "дут утеряны!";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSave.Location = new System.Drawing.Point(131, 141);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(101, 28);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDontSave
            // 
            this.buttonDontSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDontSave.Location = new System.Drawing.Point(238, 141);
            this.buttonDontSave.Name = "buttonDontSave";
            this.buttonDontSave.Size = new System.Drawing.Size(101, 28);
            this.buttonDontSave.TabIndex = 3;
            this.buttonDontSave.Text = "Не сохранять";
            this.buttonDontSave.UseVisualStyleBackColor = false;
            this.buttonDontSave.Click += new System.EventHandler(this.buttonDontSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCancel.Location = new System.Drawing.Point(345, 141);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 28);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // SaveDataDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(564, 181);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDontSave);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveDataDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Кадровое агенство";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveDataDialog_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonSave;
        private Button buttonDontSave;
        private Button buttonCancel;
    }
}