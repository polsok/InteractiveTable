namespace RegisterPhones
{
    partial class AddAccidentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_GKS3 = new System.Windows.Forms.RadioButton();
            this.radioButton_ZAO = new System.Windows.Forms.RadioButton();
            this.radioButton_North = new System.Windows.Forms.RadioButton();
            this.radioButton_South = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Адрес";
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.Location = new System.Drawing.Point(69, 81);
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(187, 20);
            this.textBox_Adress.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 144);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(243, 160);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Время работ";
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(92, 333);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(164, 20);
            this.textBox_time.TabIndex = 6;
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(142, 374);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(114, 23);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Отменить";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(11, 374);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(110, 23);
            this.button_Save.TabIndex = 0;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Опишите происшествие";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_GKS3);
            this.groupBox1.Controls.Add(this.radioButton_ZAO);
            this.groupBox1.Controls.Add(this.radioButton_North);
            this.groupBox1.Controls.Add(this.radioButton_South);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 71);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_GKS3
            // 
            this.radioButton_GKS3.AutoSize = true;
            this.radioButton_GKS3.Location = new System.Drawing.Point(160, 43);
            this.radioButton_GKS3.Name = "radioButton_GKS3";
            this.radioButton_GKS3.Size = new System.Drawing.Size(53, 17);
            this.radioButton_GKS3.TabIndex = 3;
            this.radioButton_GKS3.TabStop = true;
            this.radioButton_GKS3.Text = "GKS3";
            this.radioButton_GKS3.UseVisualStyleBackColor = true;
            // 
            // radioButton_ZAO
            // 
            this.radioButton_ZAO.AutoSize = true;
            this.radioButton_ZAO.Location = new System.Drawing.Point(160, 19);
            this.radioButton_ZAO.Name = "radioButton_ZAO";
            this.radioButton_ZAO.Size = new System.Drawing.Size(47, 17);
            this.radioButton_ZAO.TabIndex = 2;
            this.radioButton_ZAO.TabStop = true;
            this.radioButton_ZAO.Text = "ZAO";
            this.radioButton_ZAO.UseVisualStyleBackColor = true;
            // 
            // radioButton_North
            // 
            this.radioButton_North.AutoSize = true;
            this.radioButton_North.Location = new System.Drawing.Point(23, 43);
            this.radioButton_North.Name = "radioButton_North";
            this.radioButton_North.Size = new System.Drawing.Size(56, 17);
            this.radioButton_North.TabIndex = 1;
            this.radioButton_North.TabStop = true;
            this.radioButton_North.Text = "Север";
            this.radioButton_North.UseVisualStyleBackColor = true;
            // 
            // radioButton_South
            // 
            this.radioButton_South.AutoSize = true;
            this.radioButton_South.Location = new System.Drawing.Point(23, 20);
            this.radioButton_South.Name = "radioButton_South";
            this.radioButton_South.Size = new System.Drawing.Size(39, 17);
            this.radioButton_South.TabIndex = 0;
            this.radioButton_South.TabStop = true;
            this.radioButton_South.Text = "Юг";
            this.radioButton_South.UseVisualStyleBackColor = true;
            // 
            // AddAccidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 403);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Name = "AddAccidentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AddAccidentForm";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_GKS3;
        private System.Windows.Forms.RadioButton radioButton_ZAO;
        private System.Windows.Forms.RadioButton radioButton_North;
        private System.Windows.Forms.RadioButton radioButton_South;
    }
}