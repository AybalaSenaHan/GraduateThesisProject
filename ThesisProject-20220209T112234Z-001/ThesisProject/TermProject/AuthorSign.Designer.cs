namespace TermProject
{
    partial class AuthorSign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorSign));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAuthorSign = new System.Windows.Forms.TextBox();
            this.TxtSupervisorSign = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCoSupervisorSign = new System.Windows.Forms.TextBox();
            this.BtnAddAuthorSign = new System.Windows.Forms.Button();
            this.BtnAddSupervisorSign = new System.Windows.Forms.Button();
            this.BtnNextPage = new System.Windows.Forms.Button();
            this.BtnBackAuthorSign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supervisor :";
            // 
            // TxtAuthorSign
            // 
            this.TxtAuthorSign.Location = new System.Drawing.Point(315, 70);
            this.TxtAuthorSign.Name = "TxtAuthorSign";
            this.TxtAuthorSign.Size = new System.Drawing.Size(175, 32);
            this.TxtAuthorSign.TabIndex = 2;
            // 
            // TxtSupervisorSign
            // 
            this.TxtSupervisorSign.Location = new System.Drawing.Point(315, 181);
            this.TxtSupervisorSign.Name = "TxtSupervisorSign";
            this.TxtSupervisorSign.Size = new System.Drawing.Size(175, 32);
            this.TxtSupervisorSign.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Co-Supervisor :";
            // 
            // TxtCoSupervisorSign
            // 
            this.TxtCoSupervisorSign.Location = new System.Drawing.Point(315, 294);
            this.TxtCoSupervisorSign.Name = "TxtCoSupervisorSign";
            this.TxtCoSupervisorSign.Size = new System.Drawing.Size(175, 32);
            this.TxtCoSupervisorSign.TabIndex = 5;
            // 
            // BtnAddAuthorSign
            // 
            this.BtnAddAuthorSign.Location = new System.Drawing.Point(608, 67);
            this.BtnAddAuthorSign.Name = "BtnAddAuthorSign";
            this.BtnAddAuthorSign.Size = new System.Drawing.Size(272, 37);
            this.BtnAddAuthorSign.TabIndex = 6;
            this.BtnAddAuthorSign.Text = "Add - Author";
            this.BtnAddAuthorSign.UseVisualStyleBackColor = true;
            this.BtnAddAuthorSign.Click += new System.EventHandler(this.BtnAddAuthorSign_Click);
            // 
            // BtnAddSupervisorSign
            // 
            this.BtnAddSupervisorSign.Location = new System.Drawing.Point(608, 234);
            this.BtnAddSupervisorSign.Name = "BtnAddSupervisorSign";
            this.BtnAddSupervisorSign.Size = new System.Drawing.Size(272, 37);
            this.BtnAddSupervisorSign.TabIndex = 7;
            this.BtnAddSupervisorSign.Text = "Add - Supervisors";
            this.BtnAddSupervisorSign.UseVisualStyleBackColor = true;
            this.BtnAddSupervisorSign.Click += new System.EventHandler(this.BtnAddSupervisorSign_Click);
            // 
            // BtnNextPage
            // 
            this.BtnNextPage.Location = new System.Drawing.Point(386, 425);
            this.BtnNextPage.Name = "BtnNextPage";
            this.BtnNextPage.Size = new System.Drawing.Size(415, 52);
            this.BtnNextPage.TabIndex = 9;
            this.BtnNextPage.Text = "Author Interface";
            this.BtnNextPage.UseVisualStyleBackColor = true;
            this.BtnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // BtnBackAuthorSign
            // 
            this.BtnBackAuthorSign.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackAuthorSign.Image")));
            this.BtnBackAuthorSign.Location = new System.Drawing.Point(38, 12);
            this.BtnBackAuthorSign.Name = "BtnBackAuthorSign";
            this.BtnBackAuthorSign.Size = new System.Drawing.Size(59, 53);
            this.BtnBackAuthorSign.TabIndex = 10;
            this.BtnBackAuthorSign.UseVisualStyleBackColor = true;
            this.BtnBackAuthorSign.Click += new System.EventHandler(this.BtnBackAuthorSign_Click);
            // 
            // AuthorSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 555);
            this.Controls.Add(this.BtnBackAuthorSign);
            this.Controls.Add(this.BtnNextPage);
            this.Controls.Add(this.BtnAddSupervisorSign);
            this.Controls.Add(this.BtnAddAuthorSign);
            this.Controls.Add(this.TxtCoSupervisorSign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSupervisorSign);
            this.Controls.Add(this.TxtAuthorSign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AuthorSign";
            this.Text = "AuthorSign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAuthorSign;
        private System.Windows.Forms.TextBox TxtSupervisorSign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCoSupervisorSign;
        private System.Windows.Forms.Button BtnAddAuthorSign;
        private System.Windows.Forms.Button BtnAddSupervisorSign;
        private System.Windows.Forms.Button BtnNextPage;
        private System.Windows.Forms.Button BtnBackAuthorSign;
    }
}