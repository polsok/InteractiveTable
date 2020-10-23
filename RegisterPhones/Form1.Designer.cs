using System.Security.Cryptography.X509Certificates;

namespace RegisterPhones
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
            this.components = new System.ComponentModel.Container();
            this.button_South = new System.Windows.Forms.Button();
            this.button_Nord = new System.Windows.Forms.Button();
            this.button_Vas = new System.Windows.Forms.Button();
            this.button_GKS3 = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listViewAccident = new System.Windows.Forms.ListView();
            this.buttonStory = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            // button_Add
            // 
            this.button_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.button_Del.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Del.Location = new System.Drawing.Point(270, 495);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(123, 31);
            this.button_Del.TabIndex = 6;
            this.button_Del.Text = "Удалить";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Edit.Location = new System.Drawing.Point(141, 495);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(123, 31);
            this.button_Edit.TabIndex = 8;
            this.button_Edit.Text = "Редактировать";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listViewAccident
            // 
            this.listViewAccident.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewAccident.AllowColumnReorder = true;
            this.listViewAccident.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAccident.FullRowSelect = true;
            this.listViewAccident.GridLines = true;
            this.listViewAccident.HideSelection = false;
            this.listViewAccident.HoverSelection = true;
            this.listViewAccident.Location = new System.Drawing.Point(12, 98);
            this.listViewAccident.Name = "listViewAccident";
            this.listViewAccident.Size = new System.Drawing.Size(510, 374);
            this.listViewAccident.TabIndex = 10;
            this.listViewAccident.UseCompatibleStateImageBehavior = false;
            this.listViewAccident.View = System.Windows.Forms.View.Details;
            // 
            // buttonStory
            // 
            this.buttonStory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonStory.Location = new System.Drawing.Point(402, 495);
            this.buttonStory.Name = "buttonStory";
            this.buttonStory.Size = new System.Drawing.Size(123, 31);
            this.buttonStory.TabIndex = 11;
            this.buttonStory.Text = "Показать историю";
            this.buttonStory.UseVisualStyleBackColor = true;
            this.buttonStory.Click += new System.EventHandler(this.buttonStory_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 548);
            this.Controls.Add(this.buttonStory);
            this.Controls.Add(this.listViewAccident);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_GKS3);
            this.Controls.Add(this.button_Vas);
            this.Controls.Add(this.button_Nord);
            this.Controls.Add(this.button_South);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Доска аварийных происшествий";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Nord;
        private System.Windows.Forms.Button button_Vas;
        private System.Windows.Forms.Button button_GKS3;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_South;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView listViewAccident;
        private System.Windows.Forms.Button buttonStory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

