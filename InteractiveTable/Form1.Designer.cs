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
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_everything = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_South
            // 
            this.button_South.BackColor = System.Drawing.Color.White;
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
            this.button_Nord.BackColor = System.Drawing.Color.White;
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
            this.button_Vas.BackColor = System.Drawing.Color.White;
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
            this.button_GKS3.BackColor = System.Drawing.Color.White;
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
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnAdress,
            this.columnAccident,
            this.columnTime,
            this.columnAdd});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 98);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(510, 374);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
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
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(12, 495);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(123, 31);
            this.button_Add.TabIndex = 5;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(270, 495);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(123, 31);
            this.button_Del.TabIndex = 6;
            this.button_Del.Text = "Удалить";
            this.button_Del.UseVisualStyleBackColor = true;
            // 
            // button_everything
            // 
            this.button_everything.Location = new System.Drawing.Point(399, 495);
            this.button_everything.Name = "button_everything";
            this.button_everything.Size = new System.Drawing.Size(123, 31);
            this.button_everything.TabIndex = 7;
            this.button_everything.Text = "Показать все";
            this.button_everything.UseVisualStyleBackColor = true;
            this.button_everything.Visible = false;
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(141, 495);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(123, 31);
            this.button_Edit.TabIndex = 8;
            this.button_Edit.Text = "Редактировать";
            this.button_Edit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InteractiveTable.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(400, 478);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 548);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_everything);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_GKS3);
            this.Controls.Add(this.button_Vas);
            this.Controls.Add(this.button_Nord);
            this.Controls.Add(this.button_South);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Доска аварийных происшествий";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Nord;
        private System.Windows.Forms.Button button_Vas;
        private System.Windows.Forms.Button button_GKS3;
        private System.Windows.Forms.ColumnHeader columnAdress;
        private System.Windows.Forms.ColumnHeader columnAccident;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnAdd;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_everything;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnID;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button_South;
    }
}

