namespace TermProject
{
    partial class MainPage
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
            this.BtnAdminPanel = new System.Windows.Forms.Button();
            this.BtnAuthorInterface = new System.Windows.Forms.Button();
            this.BtnDetailSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAdminPanel
            // 
            this.BtnAdminPanel.Location = new System.Drawing.Point(200, 103);
            this.BtnAdminPanel.Name = "BtnAdminPanel";
            this.BtnAdminPanel.Size = new System.Drawing.Size(169, 143);
            this.BtnAdminPanel.TabIndex = 0;
            this.BtnAdminPanel.Text = "Admin Panel";
            this.BtnAdminPanel.UseVisualStyleBackColor = true;
            this.BtnAdminPanel.Click += new System.EventHandler(this.BtnAdminPanel_Click);
            // 
            // BtnAuthorInterface
            // 
            this.BtnAuthorInterface.Location = new System.Drawing.Point(629, 100);
            this.BtnAuthorInterface.Name = "BtnAuthorInterface";
            this.BtnAuthorInterface.Size = new System.Drawing.Size(170, 146);
            this.BtnAuthorInterface.TabIndex = 1;
            this.BtnAuthorInterface.Text = "Author Interface";
            this.BtnAuthorInterface.UseVisualStyleBackColor = true;
            this.BtnAuthorInterface.Click += new System.EventHandler(this.BtnAuthorInterface_Click);
            // 
            // BtnDetailSearch
            // 
            this.BtnDetailSearch.Location = new System.Drawing.Point(400, 305);
            this.BtnDetailSearch.Name = "BtnDetailSearch";
            this.BtnDetailSearch.Size = new System.Drawing.Size(194, 166);
            this.BtnDetailSearch.TabIndex = 2;
            this.BtnDetailSearch.Text = "Detail Search";
            this.BtnDetailSearch.UseVisualStyleBackColor = true;
            this.BtnDetailSearch.Click += new System.EventHandler(this.BtnDetailSearch_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 590);
            this.Controls.Add(this.BtnDetailSearch);
            this.Controls.Add(this.BtnAuthorInterface);
            this.Controls.Add(this.BtnAdminPanel);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPage";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdminPanel;
        private System.Windows.Forms.Button BtnAuthorInterface;
        private System.Windows.Forms.Button BtnDetailSearch;
    }
}

