namespace projectt
{
    partial class movies_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.movieIDbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.forBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.showIDcomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "MOVIES";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(553, 274);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(120, 32);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(303, 64);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(126, 61);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(171, 23);
            this.searchBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search Movies";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(76, 274);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 32);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(734, 172);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(169, 350);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(144, 23);
            this.nameBox.TabIndex = 14;
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(616, 350);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(93, 23);
            this.ageBox.TabIndex = 15;
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(419, 347);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(144, 23);
            this.minBox.TabIndex = 16;
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(419, 398);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(144, 23);
            this.genreBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(25, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Movie Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(331, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Minutes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(614, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 28);
            this.label7.TabIndex = 22;
            this.label7.Text = "Age Limit";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(331, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(25, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 28);
            this.label6.TabIndex = 24;
            this.label6.Text = "MovieID";
            // 
            // movieIDbox
            // 
            this.movieIDbox.Location = new System.Drawing.Point(169, 390);
            this.movieIDbox.Name = "movieIDbox";
            this.movieIDbox.Size = new System.Drawing.Size(144, 23);
            this.movieIDbox.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(617, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 28);
            this.label8.TabIndex = 27;
            this.label8.Text = "Category:";
            // 
            // forBox
            // 
            this.forBox.Location = new System.Drawing.Point(605, 406);
            this.forBox.Name = "forBox";
            this.forBox.Size = new System.Drawing.Size(117, 23);
            this.forBox.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(25, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 28);
            this.label9.TabIndex = 28;
            this.label9.Text = "ShowID";
            // 
            // showIDcomboBox
            // 
            this.showIDcomboBox.FormattingEnabled = true;
            this.showIDcomboBox.Location = new System.Drawing.Point(169, 430);
            this.showIDcomboBox.Name = "showIDcomboBox";
            this.showIDcomboBox.Size = new System.Drawing.Size(144, 23);
            this.showIDcomboBox.TabIndex = 29;
            // 
            // movies_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showIDcomboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.forBox);
            this.Controls.Add(this.movieIDbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label1);
            this.Name = "movies_UserControl";
            this.Size = new System.Drawing.Size(764, 466);
            this.Load += new System.EventHandler(this.movies_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label label1;
        private Button deleteButton;
        private Button searchButton;
        private TextBox searchBox;
        private Label label2;
        private Button addButton;
        private Button button2;
        private DataGridView dataGridView1;
        private TextBox nameBox;
        private TextBox ageBox;
        private TextBox minBox;
        private TextBox genreBox;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label5;
        private Label label6;
        private TextBox movieIDbox;
        private Label label8;
        private TextBox forBox;
        private Label label9;
        private ComboBox showIDcomboBox;
    }
}
