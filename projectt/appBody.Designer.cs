namespace projectt
{
    partial class appBody
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appBody));
            this.panel1 = new System.Windows.Forms.Panel();
            this.crossIcon = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.TableLayoutPanel();
            this.bookingButton = new System.Windows.Forms.Button();
            this.SeatsButton = new System.Windows.Forms.Button();
            this.ticketButton = new System.Windows.Forms.Button();
            this.movieButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.crossIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 25);
            this.panel1.TabIndex = 0;
            // 
            // crossIcon
            // 
            this.crossIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("crossIcon.BackgroundImage")));
            this.crossIcon.Location = new System.Drawing.Point(945, 0);
            this.crossIcon.Name = "crossIcon";
            this.crossIcon.Size = new System.Drawing.Size(24, 25);
            this.crossIcon.TabIndex = 0;
            this.crossIcon.UseVisualStyleBackColor = true;
            this.crossIcon.Click += new System.EventHandler(this.crossIcon_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Black;
            this.panel.ColumnCount = 2;
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel.Controls.Add(this.bookingButton, 1, 1);
            this.panel.Controls.Add(this.SeatsButton, 0, 1);
            this.panel.Controls.Add(this.ticketButton, 1, 0);
            this.panel.Controls.Add(this.movieButton, 0, 0);
            this.panel.Location = new System.Drawing.Point(0, 56);
            this.panel.Name = "panel";
            this.panel.RowCount = 3;
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel.Size = new System.Drawing.Size(205, 375);
            this.panel.TabIndex = 0;
            // 
            // bookingButton
            // 
            this.bookingButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.bookingButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookingButton.Location = new System.Drawing.Point(105, 180);
            this.bookingButton.Name = "bookingButton";
            this.bookingButton.Size = new System.Drawing.Size(97, 171);
            this.bookingButton.TabIndex = 3;
            this.bookingButton.Text = "booking";
            this.bookingButton.UseVisualStyleBackColor = false;
            this.bookingButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // SeatsButton
            // 
            this.SeatsButton.BackColor = System.Drawing.Color.Khaki;
            this.SeatsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SeatsButton.Location = new System.Drawing.Point(3, 180);
            this.SeatsButton.Name = "SeatsButton";
            this.SeatsButton.Size = new System.Drawing.Size(96, 171);
            this.SeatsButton.TabIndex = 2;
            this.SeatsButton.Text = "Seats";
            this.SeatsButton.UseVisualStyleBackColor = false;
            this.SeatsButton.Click += new System.EventHandler(this.SeatsButton_Click);
            // 
            // ticketButton
            // 
            this.ticketButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ticketButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ticketButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticketButton.Location = new System.Drawing.Point(105, 3);
            this.ticketButton.Name = "ticketButton";
            this.ticketButton.Size = new System.Drawing.Size(97, 171);
            this.ticketButton.TabIndex = 1;
            this.ticketButton.Text = "Ticket";
            this.ticketButton.UseVisualStyleBackColor = false;
            this.ticketButton.Click += new System.EventHandler(this.ticketButton_Click);
            // 
            // movieButton
            // 
            this.movieButton.BackColor = System.Drawing.Color.IndianRed;
            this.movieButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.movieButton.Location = new System.Drawing.Point(3, 3);
            this.movieButton.Name = "movieButton";
            this.movieButton.Size = new System.Drawing.Size(96, 171);
            this.movieButton.TabIndex = 0;
            this.movieButton.Text = "Movies";
            this.movieButton.UseVisualStyleBackColor = false;
            this.movieButton.Click += new System.EventHandler(this.movieButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentPanel.Location = new System.Drawing.Point(208, 25);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(764, 466);
            this.contentPanel.TabIndex = 1;
            // 
            // appBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(972, 491);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "appBody";
            this.Text = "appBody";
            this.panel1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Button crossIcon;
        private TableLayoutPanel panel;
        private Button SeatsButton;
        private Button ticketButton;
        private Button movieButton;
        private Panel contentPanel;
        private Button bookingButton;
    }
}