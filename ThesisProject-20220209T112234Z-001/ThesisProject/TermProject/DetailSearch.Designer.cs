namespace TermProject
{
    partial class DetailSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailSearch));
            this.TxtAbstract = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtSupervisor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.DtpSubmissionDate = new System.Windows.Forms.DateTimePicker();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.TxtAuthor = new System.Windows.Forms.TextBox();
            this.TxtNumberOfPages = new System.Windows.Forms.TextBox();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbLanguage = new System.Windows.Forms.ComboBox();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.CmbInstituteName = new System.Windows.Forms.ComboBox();
            this.CmbUniversityName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtKeyword = new System.Windows.Forms.TextBox();
            this.BtnFind = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.term_ProjectDataSet = new TermProject.Term_ProjectDataSet();
            this.termProjectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmbSubject = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtCoSupervisor = new System.Windows.Forms.TextBox();
            this.term_ProjectDataSet3 = new TermProject.Term_ProjectDataSet3();
            this.thesisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thesisTableAdapter = new TermProject.Term_ProjectDataSet3TableAdapters.ThesisTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.keywordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submissionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfPagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abstractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınstituteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thesisIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpBxThesis = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.term_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termProjectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.term_ProjectDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thesisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GrpBxThesis.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtAbstract
            // 
            this.TxtAbstract.Location = new System.Drawing.Point(1182, 237);
            this.TxtAbstract.Name = "TxtAbstract";
            this.TxtAbstract.Size = new System.Drawing.Size(174, 32);
            this.TxtAbstract.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1065, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 24);
            this.label12.TabIndex = 50;
            this.label12.Text = "Abstract :";
            // 
            // TxtSupervisor
            // 
            this.TxtSupervisor.Location = new System.Drawing.Point(1182, 139);
            this.TxtSupervisor.Name = "TxtSupervisor";
            this.TxtSupervisor.Size = new System.Drawing.Size(174, 32);
            this.TxtSupervisor.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1048, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 24);
            this.label11.TabIndex = 48;
            this.label11.Text = "Supervisor :";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(1153, 377);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(109, 44);
            this.BtnClear.TabIndex = 47;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // DtpSubmissionDate
            // 
            this.DtpSubmissionDate.Location = new System.Drawing.Point(1182, 289);
            this.DtpSubmissionDate.Name = "DtpSubmissionDate";
            this.DtpSubmissionDate.Size = new System.Drawing.Size(238, 32);
            this.DtpSubmissionDate.TabIndex = 46;
            // 
            // TxtYear
            // 
            this.TxtYear.Location = new System.Drawing.Point(1182, 40);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(174, 32);
            this.TxtYear.TabIndex = 45;
            // 
            // TxtAuthor
            // 
            this.TxtAuthor.Location = new System.Drawing.Point(655, 99);
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.Size = new System.Drawing.Size(174, 32);
            this.TxtAuthor.TabIndex = 43;
            // 
            // TxtNumberOfPages
            // 
            this.TxtNumberOfPages.Location = new System.Drawing.Point(655, 168);
            this.TxtNumberOfPages.Name = "TxtNumberOfPages";
            this.TxtNumberOfPages.Size = new System.Drawing.Size(174, 32);
            this.TxtNumberOfPages.TabIndex = 42;
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(655, 39);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(174, 32);
            this.TxtTitle.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1074, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 24);
            this.label10.TabIndex = 40;
            this.label10.Text = "Subject :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1100, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 24);
            this.label9.TabIndex = 39;
            this.label9.Text = "Year :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(996, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "Submission Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 24);
            this.label7.TabIndex = 37;
            this.label7.Text = "Number of Pages :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "Author :";
            // 
            // CmbLanguage
            // 
            this.CmbLanguage.FormattingEnabled = true;
            this.CmbLanguage.Location = new System.Drawing.Point(265, 244);
            this.CmbLanguage.Name = "CmbLanguage";
            this.CmbLanguage.Size = new System.Drawing.Size(174, 32);
            this.CmbLanguage.TabIndex = 35;
            // 
            // CmbType
            // 
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Location = new System.Drawing.Point(265, 176);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(174, 32);
            this.CmbType.TabIndex = 34;
            // 
            // CmbInstituteName
            // 
            this.CmbInstituteName.FormattingEnabled = true;
            this.CmbInstituteName.Location = new System.Drawing.Point(265, 99);
            this.CmbInstituteName.Name = "CmbInstituteName";
            this.CmbInstituteName.Size = new System.Drawing.Size(174, 32);
            this.CmbInstituteName.TabIndex = 33;
            // 
            // CmbUniversityName
            // 
            this.CmbUniversityName.FormattingEnabled = true;
            this.CmbUniversityName.Location = new System.Drawing.Point(265, 37);
            this.CmbUniversityName.Name = "CmbUniversityName";
            this.CmbUniversityName.Size = new System.Drawing.Size(174, 32);
            this.CmbUniversityName.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Title :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Language :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Type : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Institute Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "University Name :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(529, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 24);
            this.label14.TabIndex = 53;
            this.label14.Text = "Keyword :";
            // 
            // TxtKeyword
            // 
            this.TxtKeyword.Location = new System.Drawing.Point(655, 237);
            this.TxtKeyword.Name = "TxtKeyword";
            this.TxtKeyword.Size = new System.Drawing.Size(324, 32);
            this.TxtKeyword.TabIndex = 54;
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(1311, 377);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(109, 44);
            this.BtnFind.TabIndex = 55;
            this.BtnFind.Text = "Find";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 52);
            this.button3.TabIndex = 58;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // term_ProjectDataSet
            // 
            this.term_ProjectDataSet.DataSetName = "Term_ProjectDataSet";
            this.term_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // termProjectDataSetBindingSource
            // 
            this.termProjectDataSetBindingSource.DataSource = this.term_ProjectDataSet;
            this.termProjectDataSetBindingSource.Position = 0;
            // 
            // CmbSubject
            // 
            this.CmbSubject.FormattingEnabled = true;
            this.CmbSubject.Location = new System.Drawing.Point(1182, 96);
            this.CmbSubject.Name = "CmbSubject";
            this.CmbSubject.Size = new System.Drawing.Size(174, 32);
            this.CmbSubject.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1025, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 24);
            this.label15.TabIndex = 61;
            this.label15.Text = "CoSupervisor :";
            // 
            // TxtCoSupervisor
            // 
            this.TxtCoSupervisor.Location = new System.Drawing.Point(1182, 194);
            this.TxtCoSupervisor.Name = "TxtCoSupervisor";
            this.TxtCoSupervisor.Size = new System.Drawing.Size(174, 32);
            this.TxtCoSupervisor.TabIndex = 62;
            // 
            // term_ProjectDataSet3
            // 
            this.term_ProjectDataSet3.DataSetName = "Term_ProjectDataSet3";
            this.term_ProjectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thesisBindingSource
            // 
            this.thesisBindingSource.DataMember = "Thesis";
            this.thesisBindingSource.DataSource = this.term_ProjectDataSet3;
            // 
            // thesisTableAdapter
            // 
            this.thesisTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thesisIDDataGridViewTextBoxColumn,
            this.typeIDDataGridViewTextBoxColumn,
            this.languageIDDataGridViewTextBoxColumn,
            this.universityIDDataGridViewTextBoxColumn,
            this.ınstituteIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.abstractDataGridViewTextBoxColumn,
            this.numberOfPagesDataGridViewTextBoxColumn,
            this.submissionDateDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.subjectIDDataGridViewTextBoxColumn,
            this.authorIDDataGridViewTextBoxColumn,
            this.supervisorIDDataGridViewTextBoxColumn,
            this.keywordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.thesisBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1457, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // keywordDataGridViewTextBoxColumn
            // 
            this.keywordDataGridViewTextBoxColumn.DataPropertyName = "Keyword";
            this.keywordDataGridViewTextBoxColumn.HeaderText = "Keyword";
            this.keywordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.keywordDataGridViewTextBoxColumn.Name = "keywordDataGridViewTextBoxColumn";
            this.keywordDataGridViewTextBoxColumn.Width = 125;
            // 
            // supervisorIDDataGridViewTextBoxColumn
            // 
            this.supervisorIDDataGridViewTextBoxColumn.DataPropertyName = "SupervisorID";
            this.supervisorIDDataGridViewTextBoxColumn.HeaderText = "SupervisorID";
            this.supervisorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supervisorIDDataGridViewTextBoxColumn.Name = "supervisorIDDataGridViewTextBoxColumn";
            this.supervisorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            this.authorIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.HeaderText = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            this.authorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectIDDataGridViewTextBoxColumn
            // 
            this.subjectIDDataGridViewTextBoxColumn.DataPropertyName = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn.HeaderText = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectIDDataGridViewTextBoxColumn.Name = "subjectIDDataGridViewTextBoxColumn";
            this.subjectIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // submissionDateDataGridViewTextBoxColumn
            // 
            this.submissionDateDataGridViewTextBoxColumn.DataPropertyName = "SubmissionDate";
            this.submissionDateDataGridViewTextBoxColumn.HeaderText = "SubmissionDate";
            this.submissionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.submissionDateDataGridViewTextBoxColumn.Name = "submissionDateDataGridViewTextBoxColumn";
            this.submissionDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOfPagesDataGridViewTextBoxColumn
            // 
            this.numberOfPagesDataGridViewTextBoxColumn.DataPropertyName = "NumberOfPages";
            this.numberOfPagesDataGridViewTextBoxColumn.HeaderText = "NumberOfPages";
            this.numberOfPagesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfPagesDataGridViewTextBoxColumn.Name = "numberOfPagesDataGridViewTextBoxColumn";
            this.numberOfPagesDataGridViewTextBoxColumn.Width = 125;
            // 
            // abstractDataGridViewTextBoxColumn
            // 
            this.abstractDataGridViewTextBoxColumn.DataPropertyName = "Abstract";
            this.abstractDataGridViewTextBoxColumn.HeaderText = "Abstract";
            this.abstractDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.abstractDataGridViewTextBoxColumn.Name = "abstractDataGridViewTextBoxColumn";
            this.abstractDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // ınstituteIDDataGridViewTextBoxColumn
            // 
            this.ınstituteIDDataGridViewTextBoxColumn.DataPropertyName = "InstituteID";
            this.ınstituteIDDataGridViewTextBoxColumn.HeaderText = "InstituteID";
            this.ınstituteIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ınstituteIDDataGridViewTextBoxColumn.Name = "ınstituteIDDataGridViewTextBoxColumn";
            this.ınstituteIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // universityIDDataGridViewTextBoxColumn
            // 
            this.universityIDDataGridViewTextBoxColumn.DataPropertyName = "UniversityID";
            this.universityIDDataGridViewTextBoxColumn.HeaderText = "UniversityID";
            this.universityIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.universityIDDataGridViewTextBoxColumn.Name = "universityIDDataGridViewTextBoxColumn";
            this.universityIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // languageIDDataGridViewTextBoxColumn
            // 
            this.languageIDDataGridViewTextBoxColumn.DataPropertyName = "LanguageID";
            this.languageIDDataGridViewTextBoxColumn.HeaderText = "LanguageID";
            this.languageIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.languageIDDataGridViewTextBoxColumn.Name = "languageIDDataGridViewTextBoxColumn";
            this.languageIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeIDDataGridViewTextBoxColumn
            // 
            this.typeIDDataGridViewTextBoxColumn.DataPropertyName = "TypeID";
            this.typeIDDataGridViewTextBoxColumn.HeaderText = "TypeID";
            this.typeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeIDDataGridViewTextBoxColumn.Name = "typeIDDataGridViewTextBoxColumn";
            this.typeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // thesisIDDataGridViewTextBoxColumn
            // 
            this.thesisIDDataGridViewTextBoxColumn.DataPropertyName = "ThesisID";
            this.thesisIDDataGridViewTextBoxColumn.HeaderText = "ThesisID";
            this.thesisIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thesisIDDataGridViewTextBoxColumn.Name = "thesisIDDataGridViewTextBoxColumn";
            this.thesisIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.thesisIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // GrpBxThesis
            // 
            this.GrpBxThesis.Controls.Add(this.dataGridView1);
            this.GrpBxThesis.Location = new System.Drawing.Point(12, 448);
            this.GrpBxThesis.Name = "GrpBxThesis";
            this.GrpBxThesis.Size = new System.Drawing.Size(1463, 245);
            this.GrpBxThesis.TabIndex = 63;
            this.GrpBxThesis.TabStop = false;
            this.GrpBxThesis.Text = "Thesis";
            // 
            // DetailSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 705);
            this.Controls.Add(this.GrpBxThesis);
            this.Controls.Add(this.TxtCoSupervisor);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CmbSubject);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.TxtKeyword);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtAbstract);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtSupervisor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.DtpSubmissionDate);
            this.Controls.Add(this.TxtYear);
            this.Controls.Add(this.TxtAuthor);
            this.Controls.Add(this.TxtNumberOfPages);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbLanguage);
            this.Controls.Add(this.CmbType);
            this.Controls.Add(this.CmbInstituteName);
            this.Controls.Add(this.CmbUniversityName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DetailSearch";
            this.Load += new System.EventHandler(this.DetailSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.term_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termProjectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.term_ProjectDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thesisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GrpBxThesis.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAbstract;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtSupervisor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.DateTimePicker DtpSubmissionDate;
        private System.Windows.Forms.TextBox TxtYear;
        private System.Windows.Forms.TextBox TxtAuthor;
        private System.Windows.Forms.TextBox TxtNumberOfPages;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbLanguage;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.ComboBox CmbInstituteName;
        private System.Windows.Forms.ComboBox CmbUniversityName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtKeyword;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource termProjectDataSetBindingSource;
        private Term_ProjectDataSet term_ProjectDataSet;
        private System.Windows.Forms.ComboBox CmbSubject;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtCoSupervisor;
        private Term_ProjectDataSet3 term_ProjectDataSet3;
        private System.Windows.Forms.BindingSource thesisBindingSource;
        private Term_ProjectDataSet3TableAdapters.ThesisTableAdapter thesisTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn thesisIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınstituteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abstractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submissionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keywordDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox GrpBxThesis;
    }
}