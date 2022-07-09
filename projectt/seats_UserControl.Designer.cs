namespace projectt
{
    partial class seats_UserControl
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Bookbutton1 = new System.Windows.Forms.Button();
            this.Bookbutton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(310, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Book Ticket";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(337, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "SEATS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(139, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "HALL NO.1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 187);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(758, 197);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07"});
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "F01",
            "F02",
            "F03",
            "F04",
            "F05",
            "F06",
            "F07"});
            this.comboBox1.Location = new System.Drawing.Point(326, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07"});
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "S01",
            "S02",
            "S03",
            "S04",
            "S05",
            "S06",
            "S07"});
            this.comboBox2.Location = new System.Drawing.Point(326, 158);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(139, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "HALL NO.2";
            // 
            // Bookbutton1
            // 
            this.Bookbutton1.BackColor = System.Drawing.Color.SteelBlue;
            this.Bookbutton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bookbutton1.Location = new System.Drawing.Point(511, 99);
            this.Bookbutton1.Name = "Bookbutton1";
            this.Bookbutton1.Size = new System.Drawing.Size(95, 33);
            this.Bookbutton1.TabIndex = 9;
            this.Bookbutton1.Text = "Book ";
            this.Bookbutton1.UseVisualStyleBackColor = false;
            this.Bookbutton1.Click += new System.EventHandler(this.Bookbutton1_Click);
            // 
            // Bookbutton2
            // 
            this.Bookbutton2.BackColor = System.Drawing.Color.SteelBlue;
            this.Bookbutton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bookbutton2.Location = new System.Drawing.Point(511, 148);
            this.Bookbutton2.Name = "Bookbutton2";
            this.Bookbutton2.Size = new System.Drawing.Size(95, 33);
            this.Bookbutton2.TabIndex = 10;
            this.Bookbutton2.Text = "Book ";
            this.Bookbutton2.UseVisualStyleBackColor = false;
            this.Bookbutton2.Click += new System.EventHandler(this.Bookbutton2_Click);
            // 
            // seats_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Bookbutton2);
            this.Controls.Add(this.Bookbutton1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "seats_UserControl";
            this.Size = new System.Drawing.Size(764, 466);
            this.Load += new System.EventHandler(this.seats_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private Button Bookbutton1;
        private Button Bookbutton2;
    }
}
