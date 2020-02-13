namespace InteractiveTable
{
    partial class StoryForm
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
            this.listViewAccident = new System.Windows.Forms.ListView();
            this.SuspendLayout();
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
            this.listViewAccident.Location = new System.Drawing.Point(12, 12);
            this.listViewAccident.Name = "listViewAccident";
            this.listViewAccident.Size = new System.Drawing.Size(924, 426);
            this.listViewAccident.TabIndex = 11;
            this.listViewAccident.UseCompatibleStateImageBehavior = false;
            this.listViewAccident.View = System.Windows.Forms.View.Details;
            // 
            // StoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.listViewAccident);
            this.Name = "StoryForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "StoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAccident;
    }
}