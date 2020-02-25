namespace Library {
    partial class LibraryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.lbAuthors = new System.Windows.Forms.ListBox();
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnRemoveAuthor = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.lbBookCopies = new System.Windows.Forms.ListBox();
            this.lbBooksByAuthors = new System.Windows.Forms.ListBox();
            this.lbLoansByMember = new System.Windows.Forms.ListBox();
            this.btnAddBookCopy = new System.Windows.Forms.Button();
            this.btnRemoveBookCopy = new System.Windows.Forms.Button();
            this.btnAddLoan = new System.Windows.Forms.Button();
            this.btnRemoveLoan = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnReturnLoan = new System.Windows.Forms.Button();
            this.btnShowLoanHistory = new System.Windows.Forms.Button();
            this.gbBooks = new System.Windows.Forms.GroupBox();
            this.gbAuthors = new System.Windows.Forms.GroupBox();
            this.gbMembers = new System.Windows.Forms.GroupBox();
            this.gbBookCopies = new System.Windows.Forms.GroupBox();
            this.gbBooksByAuthors = new System.Windows.Forms.GroupBox();
            this.gbLoansByMember = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnShowAviBookCopies = new System.Windows.Forms.Button();
            this.gbBooks.SuspendLayout();
            this.gbMembers.SuspendLayout();
            this.gbBookCopies.SuspendLayout();
            this.gbBooksByAuthors.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.ItemHeight = 15;
            this.lbBooks.Location = new System.Drawing.Point(25, 28);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(248, 154);
            this.lbBooks.TabIndex = 0;
            this.lbBooks.SelectedIndexChanged += new System.EventHandler(this.lbBooks_SelectedIndexChanged);
            this.lbBooks.DoubleClick += new System.EventHandler(this.lbBooks_DoubleClick);
            // 
            // lbAuthors
            // 
            this.lbAuthors.FormattingEnabled = true;
            this.lbAuthors.ItemHeight = 15;
            this.lbAuthors.Location = new System.Drawing.Point(345, 38);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.Size = new System.Drawing.Size(321, 154);
            this.lbAuthors.TabIndex = 1;
            this.lbAuthors.SelectedIndexChanged += new System.EventHandler(this.lbAuthors_SelectedIndexChanged);
            this.lbAuthors.DoubleClick += new System.EventHandler(this.lbAuthors_DoubleClick);
            // 
            // lbMembers
            // 
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.ItemHeight = 15;
            this.lbMembers.Location = new System.Drawing.Point(725, 38);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(340, 154);
            this.lbMembers.TabIndex = 2;
            this.lbMembers.SelectedIndexChanged += new System.EventHandler(this.lbMembers_SelectedIndexChanged);
            this.lbMembers.DoubleClick += new System.EventHandler(this.lbMembers_DoubleClick);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.DeepPink;
            this.btnAddAuthor.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddAuthor.Location = new System.Drawing.Point(431, 219);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(122, 27);
            this.btnAddAuthor.TabIndex = 3;
            this.btnAddAuthor.Text = "AddAuthor";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnRemoveAuthor
            // 
            this.btnRemoveAuthor.BackColor = System.Drawing.Color.Crimson;
            this.btnRemoveAuthor.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAuthor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveAuthor.Location = new System.Drawing.Point(431, 269);
            this.btnRemoveAuthor.Name = "btnRemoveAuthor";
            this.btnRemoveAuthor.Size = new System.Drawing.Size(122, 27);
            this.btnRemoveAuthor.TabIndex = 4;
            this.btnRemoveAuthor.Text = "RemoveAuthor";
            this.btnRemoveAuthor.UseVisualStyleBackColor = false;
            this.btnRemoveAuthor.Click += new System.EventHandler(this.btnRemoveAuthor_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.DeepPink;
            this.btnAddBook.Location = new System.Drawing.Point(83, 209);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(122, 27);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "AddBook";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.BackColor = System.Drawing.Color.Crimson;
            this.btnRemoveBook.Location = new System.Drawing.Point(83, 258);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(122, 27);
            this.btnRemoveBook.TabIndex = 6;
            this.btnRemoveBook.Text = "RemoveBook";
            this.btnRemoveBook.UseVisualStyleBackColor = false;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.DeepPink;
            this.btnAddMember.Location = new System.Drawing.Point(121, 209);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(122, 27);
            this.btnAddMember.TabIndex = 7;
            this.btnAddMember.Text = "AddMember";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.BackColor = System.Drawing.Color.Crimson;
            this.btnRemoveMember.Location = new System.Drawing.Point(121, 258);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(122, 27);
            this.btnRemoveMember.TabIndex = 8;
            this.btnRemoveMember.Text = "RemoveMember";
            this.btnRemoveMember.UseVisualStyleBackColor = false;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // lbBookCopies
            // 
            this.lbBookCopies.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookCopies.FormattingEnabled = true;
            this.lbBookCopies.ItemHeight = 15;
            this.lbBookCopies.Location = new System.Drawing.Point(25, 36);
            this.lbBookCopies.Name = "lbBookCopies";
            this.lbBookCopies.Size = new System.Drawing.Size(248, 124);
            this.lbBookCopies.TabIndex = 9;
            this.lbBookCopies.DoubleClick += new System.EventHandler(this.lbBookCopies_DoubleClick);
            // 
            // lbBooksByAuthors
            // 
            this.lbBooksByAuthors.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBooksByAuthors.FormattingEnabled = true;
            this.lbBooksByAuthors.ItemHeight = 15;
            this.lbBooksByAuthors.Location = new System.Drawing.Point(20, 36);
            this.lbBooksByAuthors.Name = "lbBooksByAuthors";
            this.lbBooksByAuthors.Size = new System.Drawing.Size(321, 124);
            this.lbBooksByAuthors.TabIndex = 10;
            this.lbBooksByAuthors.DoubleClick += new System.EventHandler(this.lbBooksByAuthors_DoubleClick);
            // 
            // lbLoansByMember
            // 
            this.lbLoansByMember.FormattingEnabled = true;
            this.lbLoansByMember.ItemHeight = 15;
            this.lbLoansByMember.Location = new System.Drawing.Point(725, 358);
            this.lbLoansByMember.Name = "lbLoansByMember";
            this.lbLoansByMember.Size = new System.Drawing.Size(340, 124);
            this.lbLoansByMember.TabIndex = 11;
            this.lbLoansByMember.DoubleClick += new System.EventHandler(this.lbLoansByMember_DoubleClick);
            // 
            // btnAddBookCopy
            // 
            this.btnAddBookCopy.BackColor = System.Drawing.Color.DeepPink;
            this.btnAddBookCopy.Location = new System.Drawing.Point(84, 179);
            this.btnAddBookCopy.Name = "btnAddBookCopy";
            this.btnAddBookCopy.Size = new System.Drawing.Size(122, 27);
            this.btnAddBookCopy.TabIndex = 12;
            this.btnAddBookCopy.Text = "AddBookCopy";
            this.btnAddBookCopy.UseVisualStyleBackColor = false;
            this.btnAddBookCopy.Click += new System.EventHandler(this.btnAddBookCopy_Click);
            // 
            // btnRemoveBookCopy
            // 
            this.btnRemoveBookCopy.BackColor = System.Drawing.Color.Crimson;
            this.btnRemoveBookCopy.Location = new System.Drawing.Point(84, 233);
            this.btnRemoveBookCopy.Name = "btnRemoveBookCopy";
            this.btnRemoveBookCopy.Size = new System.Drawing.Size(122, 27);
            this.btnRemoveBookCopy.TabIndex = 13;
            this.btnRemoveBookCopy.Text = "RemoveBookCopy";
            this.btnRemoveBookCopy.UseVisualStyleBackColor = false;
            this.btnRemoveBookCopy.Click += new System.EventHandler(this.btnRemoveBookCopy_Click);
            // 
            // btnAddLoan
            // 
            this.btnAddLoan.BackColor = System.Drawing.Color.DeepPink;
            this.btnAddLoan.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLoan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddLoan.Location = new System.Drawing.Point(778, 501);
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.Size = new System.Drawing.Size(122, 27);
            this.btnAddLoan.TabIndex = 14;
            this.btnAddLoan.Text = "AddLoan";
            this.btnAddLoan.UseVisualStyleBackColor = false;
            this.btnAddLoan.Click += new System.EventHandler(this.btnAddLoan_Click);
            // 
            // btnRemoveLoan
            // 
            this.btnRemoveLoan.BackColor = System.Drawing.Color.Crimson;
            this.btnRemoveLoan.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveLoan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveLoan.Location = new System.Drawing.Point(778, 555);
            this.btnRemoveLoan.Name = "btnRemoveLoan";
            this.btnRemoveLoan.Size = new System.Drawing.Size(122, 27);
            this.btnRemoveLoan.TabIndex = 15;
            this.btnRemoveLoan.Text = "RemoveLoan";
            this.btnRemoveLoan.UseVisualStyleBackColor = false;
            this.btnRemoveLoan.Click += new System.EventHandler(this.btnRemoveLoan_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 607);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(45, 23);
            this.comboBox1.TabIndex = 16;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnChange.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChange.Location = new System.Drawing.Point(156, 607);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(61, 24);
            this.btnChange.TabIndex = 17;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnReturnLoan
            // 
            this.btnReturnLoan.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReturnLoan.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnLoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturnLoan.Location = new System.Drawing.Point(946, 501);
            this.btnReturnLoan.Name = "btnReturnLoan";
            this.btnReturnLoan.Size = new System.Drawing.Size(98, 27);
            this.btnReturnLoan.TabIndex = 18;
            this.btnReturnLoan.Text = "Return Loan";
            this.btnReturnLoan.UseVisualStyleBackColor = false;
            this.btnReturnLoan.Click += new System.EventHandler(this.btnReturnLoan_Click);
            // 
            // btnShowLoanHistory
            // 
            this.btnShowLoanHistory.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnShowLoanHistory.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLoanHistory.Location = new System.Drawing.Point(512, 590);
            this.btnShowLoanHistory.Name = "btnShowLoanHistory";
            this.btnShowLoanHistory.Size = new System.Drawing.Size(87, 55);
            this.btnShowLoanHistory.TabIndex = 20;
            this.btnShowLoanHistory.Text = "Show Loan History";
            this.btnShowLoanHistory.UseVisualStyleBackColor = false;
            this.btnShowLoanHistory.Click += new System.EventHandler(this.btnShowLoanHistory_Click);
            // 
            // gbBooks
            // 
            this.gbBooks.BackColor = System.Drawing.Color.DarkKhaki;
            this.gbBooks.Controls.Add(this.lbBooks);
            this.gbBooks.Controls.Add(this.btnAddBook);
            this.gbBooks.Controls.Add(this.btnRemoveBook);
            this.gbBooks.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBooks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbBooks.Location = new System.Drawing.Point(12, 10);
            this.gbBooks.Name = "gbBooks";
            this.gbBooks.Size = new System.Drawing.Size(297, 305);
            this.gbBooks.TabIndex = 21;
            this.gbBooks.TabStop = false;
            this.gbBooks.Text = "Books";
            // 
            // gbAuthors
            // 
            this.gbAuthors.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAuthors.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbAuthors.Location = new System.Drawing.Point(325, 10);
            this.gbAuthors.Name = "gbAuthors";
            this.gbAuthors.Size = new System.Drawing.Size(361, 305);
            this.gbAuthors.TabIndex = 22;
            this.gbAuthors.TabStop = false;
            this.gbAuthors.Text = "Authors";
            // 
            // gbMembers
            // 
            this.gbMembers.Controls.Add(this.btnAddMember);
            this.gbMembers.Controls.Add(this.btnRemoveMember);
            this.gbMembers.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMembers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbMembers.Location = new System.Drawing.Point(703, 10);
            this.gbMembers.Name = "gbMembers";
            this.gbMembers.Size = new System.Drawing.Size(384, 305);
            this.gbMembers.TabIndex = 23;
            this.gbMembers.TabStop = false;
            this.gbMembers.Text = "Members";
            // 
            // gbBookCopies
            // 
            this.gbBookCopies.Controls.Add(this.lbBookCopies);
            this.gbBookCopies.Controls.Add(this.btnAddBookCopy);
            this.gbBookCopies.Controls.Add(this.btnRemoveBookCopy);
            this.gbBookCopies.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBookCopies.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbBookCopies.Location = new System.Drawing.Point(12, 322);
            this.gbBookCopies.Name = "gbBookCopies";
            this.gbBookCopies.Size = new System.Drawing.Size(297, 347);
            this.gbBookCopies.TabIndex = 24;
            this.gbBookCopies.TabStop = false;
            this.gbBookCopies.Text = "Book Copies";
            // 
            // gbBooksByAuthors
            // 
            this.gbBooksByAuthors.Controls.Add(this.lbBooksByAuthors);
            this.gbBooksByAuthors.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBooksByAuthors.ForeColor = System.Drawing.SystemColors.Control;
            this.gbBooksByAuthors.Location = new System.Drawing.Point(325, 322);
            this.gbBooksByAuthors.Name = "gbBooksByAuthors";
            this.gbBooksByAuthors.Size = new System.Drawing.Size(361, 192);
            this.gbBooksByAuthors.TabIndex = 25;
            this.gbBooksByAuthors.TabStop = false;
            this.gbBooksByAuthors.Text = "Books By Author";
            // 
            // gbLoansByMember
            // 
            this.gbLoansByMember.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLoansByMember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbLoansByMember.Location = new System.Drawing.Point(703, 322);
            this.gbLoansByMember.Name = "gbLoansByMember";
            this.gbLoansByMember.Size = new System.Drawing.Size(384, 347);
            this.gbLoansByMember.TabIndex = 26;
            this.gbLoansByMember.TabStop = false;
            this.gbLoansByMember.Text = "Loans By Member";
            // 
            // groupBox7
            // 
            this.groupBox7.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox7.Location = new System.Drawing.Point(402, 555);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(216, 114);
            this.groupBox7.TabIndex = 27;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Show";
            // 
            // btnShowAviBookCopies
            // 
            this.btnShowAviBookCopies.BackColor = System.Drawing.Color.LightPink;
            this.btnShowAviBookCopies.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAviBookCopies.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowAviBookCopies.Location = new System.Drawing.Point(420, 590);
            this.btnShowAviBookCopies.Name = "btnShowAviBookCopies";
            this.btnShowAviBookCopies.Size = new System.Drawing.Size(86, 55);
            this.btnShowAviBookCopies.TabIndex = 19;
            this.btnShowAviBookCopies.Text = "Show Available Book copies";
            this.btnShowAviBookCopies.UseVisualStyleBackColor = false;
            this.btnShowAviBookCopies.Click += new System.EventHandler(this.btnShowAviBookCopies_Click);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1160, 698);
            this.Controls.Add(this.btnShowLoanHistory);
            this.Controls.Add(this.btnShowAviBookCopies);
            this.Controls.Add(this.btnReturnLoan);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnRemoveLoan);
            this.Controls.Add(this.btnAddLoan);
            this.Controls.Add(this.lbLoansByMember);
            this.Controls.Add(this.btnRemoveAuthor);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.lbMembers);
            this.Controls.Add(this.lbAuthors);
            this.Controls.Add(this.gbBooks);
            this.Controls.Add(this.gbAuthors);
            this.Controls.Add(this.gbMembers);
            this.Controls.Add(this.gbBookCopies);
            this.Controls.Add(this.gbBooksByAuthors);
            this.Controls.Add(this.gbLoansByMember);
            this.Controls.Add(this.groupBox7);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.gbBooks.ResumeLayout(false);
            this.gbMembers.ResumeLayout(false);
            this.gbBookCopies.ResumeLayout(false);
            this.gbBooksByAuthors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.ListBox lbAuthors;
        private System.Windows.Forms.ListBox lbMembers;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnRemoveAuthor;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.ListBox lbBookCopies;
        private System.Windows.Forms.ListBox lbBooksByAuthors;
        private System.Windows.Forms.ListBox lbLoansByMember;
        private System.Windows.Forms.Button btnAddBookCopy;
        private System.Windows.Forms.Button btnRemoveBookCopy;
        private System.Windows.Forms.Button btnAddLoan;
        private System.Windows.Forms.Button btnRemoveLoan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnReturnLoan;
        private System.Windows.Forms.Button btnShowAviBookCopies;
        private System.Windows.Forms.Button btnShowLoanHistory;
        private System.Windows.Forms.GroupBox gbBooks;
        private System.Windows.Forms.GroupBox gbAuthors;
        private System.Windows.Forms.GroupBox gbMembers;
        private System.Windows.Forms.GroupBox gbBookCopies;
        private System.Windows.Forms.GroupBox gbBooksByAuthors;
        private System.Windows.Forms.GroupBox gbLoansByMember;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}

