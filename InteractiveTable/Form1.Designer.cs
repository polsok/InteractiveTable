using System.Security.Cryptography.X509Certificates;

namespace InteractiveTable
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_South = new System.Windows.Forms.Button();
            this.button_Nord = new System.Windows.Forms.Button();
            this.button_Vas = new System.Windows.Forms.Button();
            this.button_GKS3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAccident = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAdd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRemove = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_South
            // 
            this.button_South.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_South.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_South.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_South.Location = new System.Drawing.Point(12, 12);
            this.button_South.Name = "button_South";
            this.button_South.Size = new System.Drawing.Size(123, 80);
            this.button_South.TabIndex = 0;
            this.button_South.Text = "ЮГ";
            this.button_South.UseVisualStyleBackColor = false;
            this.button_South.Click += new System.EventHandler(this.ListViewCompleting);
            // 
            // button_Nord
            // 
            this.button_Nord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Nord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Nord.Location = new System.Drawing.Point(141, 12);
            this.button_Nord.Name = "button_Nord";
            this.button_Nord.Size = new System.Drawing.Size(123, 80);
            this.button_Nord.TabIndex = 1;
            this.button_Nord.Text = "СЕВЕР";
            this.button_Nord.UseVisualStyleBackColor = false;
            this.button_Nord.Click += new System.EventHandler(this.ListViewCompleting);
            // 
            // button_Vas
            // 
            this.button_Vas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Vas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Vas.Location = new System.Drawing.Point(270, 12);
            this.button_Vas.Name = "button_Vas";
            this.button_Vas.Size = new System.Drawing.Size(123, 80);
            this.button_Vas.TabIndex = 2;
            this.button_Vas.Text = "ЗАО";
            this.button_Vas.UseVisualStyleBackColor = false;
            this.button_Vas.Click += new System.EventHandler(this.ListViewCompleting);
            // 
            // button_GKS3
            // 
            this.button_GKS3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_GKS3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_GKS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_GKS3.Location = new System.Drawing.Point(399, 12);
            this.button_GKS3.Name = "button_GKS3";
            this.button_GKS3.Size = new System.Drawing.Size(123, 80);
            this.button_GKS3.TabIndex = 3;
            this.button_GKS3.Text = "ЖКС3";
            this.button_GKS3.UseVisualStyleBackColor = false;
            this.button_GKS3.Click += new System.EventHandler(this.ListViewCompleting);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnAdress,
            this.columnAccident,
            this.columnTime,
            this.columnAdd,
            this.columnRemove});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 98);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(510, 374);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 36;
            // 
            // columnAdress
            // 
            this.columnAdress.Text = "Адрес";
            this.columnAdress.Width = 96;
            // 
            // columnAccident
            // 
            this.columnAccident.Text = "Происшествие";
            this.columnAccident.Width = 115;
            // 
            // columnTime
            // 
            this.columnTime.Text = "Время работ";
            this.columnTime.Width = 106;
            // 
            // columnAdd
            // 
            this.columnAdd.Text = "Добавил";
            this.columnAdd.Width = 68;
            // 
            // columnRemove
            // 
            this.columnRemove.Text = "Удалил";
            this.columnRemove.Width = 82;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 495);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(123, 31);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(141, 495);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(123, 31);
            this.buttonDel.TabIndex = 6;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(299, 503);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Показать удаленные";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 548);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_GKS3);
            this.Controls.Add(this.button_Vas);
            this.Controls.Add(this.button_Nord);
            this.Controls.Add(this.button_South);
            this.Name = "Form1";
            this.Text = "Доска аварийных происшествий";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_South;
        private System.Windows.Forms.Button button_Nord;
        private System.Windows.Forms.Button button_Vas;
        private System.Windows.Forms.Button button_GKS3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnAdress;
        private System.Windows.Forms.ColumnHeader columnAccident;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnAdd;
        private System.Windows.Forms.ColumnHeader columnRemove;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

