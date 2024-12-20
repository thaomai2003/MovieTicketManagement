namespace MovieTicketManagementSystem
{
    partial class buyTicketForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buyTicketForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buyTicket_caculateBtn = new System.Windows.Forms.Button();
            this.buyTicket_clearFields = new System.Windows.Forms.Button();
            this.buyTicket_receiptBtn = new System.Windows.Forms.Button();
            this.buyTicket_buyBtn = new System.Windows.Forms.Button();
            this.buyTicket_change = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.buyTicket_amount = new System.Windows.Forms.TextBox();
            this.buyTicket_totalPrice = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.buyTicket_drinks = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buyTicket_foods = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buyTicket_availableChairs = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buyTicket_clear = new System.Windows.Forms.Button();
            this.buyTicket_selectMovie = new System.Windows.Forms.Button();
            this.buyTicket_regularPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buyTicket_genre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buyTicket_movieName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buyTicket_movieID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.buyTicket_foodNum = new System.Windows.Forms.TextBox();
            this.buyTicket_drinkNum = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(16, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 267);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(16, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(497, 210);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Available Movies";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.buyTicket_drinkNum);
            this.panel4.Controls.Add(this.buyTicket_foodNum);
            this.panel4.Controls.Add(this.buyTicket_caculateBtn);
            this.panel4.Controls.Add(this.buyTicket_clearFields);
            this.panel4.Controls.Add(this.buyTicket_receiptBtn);
            this.panel4.Controls.Add(this.buyTicket_buyBtn);
            this.panel4.Controls.Add(this.buyTicket_change);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.buyTicket_amount);
            this.panel4.Controls.Add(this.buyTicket_totalPrice);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.buyTicket_drinks);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.buyTicket_foods);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.buyTicket_availableChairs);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(562, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 556);
            this.panel4.TabIndex = 8;
            // 
            // buyTicket_caculateBtn
            // 
            this.buyTicket_caculateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_caculateBtn.FlatAppearance.BorderSize = 0;
            this.buyTicket_caculateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_caculateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_caculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_caculateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_caculateBtn.ForeColor = System.Drawing.Color.White;
            this.buyTicket_caculateBtn.Location = new System.Drawing.Point(15, 237);
            this.buyTicket_caculateBtn.Name = "buyTicket_caculateBtn";
            this.buyTicket_caculateBtn.Size = new System.Drawing.Size(243, 23);
            this.buyTicket_caculateBtn.TabIndex = 39;
            this.buyTicket_caculateBtn.Text = "CACULATE";
            this.buyTicket_caculateBtn.UseVisualStyleBackColor = false;
            this.buyTicket_caculateBtn.Click += new System.EventHandler(this.buyTicket_caculateBtn_Click);
            // 
            // buyTicket_clearFields
            // 
            this.buyTicket_clearFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_clearFields.FlatAppearance.BorderSize = 0;
            this.buyTicket_clearFields.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_clearFields.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_clearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_clearFields.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_clearFields.ForeColor = System.Drawing.Color.White;
            this.buyTicket_clearFields.Location = new System.Drawing.Point(15, 515);
            this.buyTicket_clearFields.Name = "buyTicket_clearFields";
            this.buyTicket_clearFields.Size = new System.Drawing.Size(243, 26);
            this.buyTicket_clearFields.TabIndex = 26;
            this.buyTicket_clearFields.Text = "CLEAR";
            this.buyTicket_clearFields.UseVisualStyleBackColor = false;
            this.buyTicket_clearFields.Click += new System.EventHandler(this.buyTicket_clearFields_Click);
            // 
            // buyTicket_receiptBtn
            // 
            this.buyTicket_receiptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_receiptBtn.FlatAppearance.BorderSize = 0;
            this.buyTicket_receiptBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_receiptBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_receiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_receiptBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_receiptBtn.ForeColor = System.Drawing.Color.White;
            this.buyTicket_receiptBtn.Location = new System.Drawing.Point(15, 457);
            this.buyTicket_receiptBtn.Name = "buyTicket_receiptBtn";
            this.buyTicket_receiptBtn.Size = new System.Drawing.Size(243, 27);
            this.buyTicket_receiptBtn.TabIndex = 38;
            this.buyTicket_receiptBtn.Text = "RECEIPT";
            this.buyTicket_receiptBtn.UseVisualStyleBackColor = false;
            // 
            // buyTicket_buyBtn
            // 
            this.buyTicket_buyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_buyBtn.FlatAppearance.BorderSize = 0;
            this.buyTicket_buyBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_buyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_buyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_buyBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_buyBtn.ForeColor = System.Drawing.Color.White;
            this.buyTicket_buyBtn.Location = new System.Drawing.Point(15, 426);
            this.buyTicket_buyBtn.Name = "buyTicket_buyBtn";
            this.buyTicket_buyBtn.Size = new System.Drawing.Size(243, 25);
            this.buyTicket_buyBtn.TabIndex = 25;
            this.buyTicket_buyBtn.Text = "BUY";
            this.buyTicket_buyBtn.UseVisualStyleBackColor = false;
            this.buyTicket_buyBtn.Click += new System.EventHandler(this.buyTicket_buyBtn_Click);
            // 
            // buyTicket_change
            // 
            this.buyTicket_change.AutoSize = true;
            this.buyTicket_change.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_change.ForeColor = System.Drawing.Color.Black;
            this.buyTicket_change.Location = new System.Drawing.Point(104, 384);
            this.buyTicket_change.Name = "buyTicket_change";
            this.buyTicket_change.Size = new System.Drawing.Size(40, 20);
            this.buyTicket_change.TabIndex = 37;
            this.buyTicket_change.Text = "$0.00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(42, 384);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 20);
            this.label19.TabIndex = 36;
            this.label19.Text = "Change:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(42, 328);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 20);
            this.label20.TabIndex = 35;
            this.label20.Text = "Amount:";
            // 
            // buyTicket_amount
            // 
            this.buyTicket_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_amount.Location = new System.Drawing.Point(102, 324);
            this.buyTicket_amount.Name = "buyTicket_amount";
            this.buyTicket_amount.Size = new System.Drawing.Size(141, 26);
            this.buyTicket_amount.TabIndex = 34;
            this.buyTicket_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buyTicket_amount_KeyDown);
            // 
            // buyTicket_totalPrice
            // 
            this.buyTicket_totalPrice.AutoSize = true;
            this.buyTicket_totalPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_totalPrice.ForeColor = System.Drawing.Color.Black;
            this.buyTicket_totalPrice.Location = new System.Drawing.Point(122, 292);
            this.buyTicket_totalPrice.Name = "buyTicket_totalPrice";
            this.buyTicket_totalPrice.Size = new System.Drawing.Size(49, 17);
            this.buyTicket_totalPrice.TabIndex = 32;
            this.buyTicket_totalPrice.Text = "$0.00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(20, 292);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 17);
            this.label17.TabIndex = 31;
            this.label17.Text = "Total Price: ";
            // 
            // buyTicket_drinks
            // 
            this.buyTicket_drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_drinks.FormattingEnabled = true;
            this.buyTicket_drinks.Items.AddRange(new object[] {
            "Coke",
            "Fanta",
            "Pepsi",
            "Water"});
            this.buyTicket_drinks.Location = new System.Drawing.Point(74, 187);
            this.buyTicket_drinks.Name = "buyTicket_drinks";
            this.buyTicket_drinks.Size = new System.Drawing.Size(113, 24);
            this.buyTicket_drinks.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(21, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Drinks:";
            // 
            // buyTicket_foods
            // 
            this.buyTicket_foods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_foods.FormattingEnabled = true;
            this.buyTicket_foods.Items.AddRange(new object[] {
            "Popcorn",
            "Fries"});
            this.buyTicket_foods.Location = new System.Drawing.Point(74, 130);
            this.buyTicket_foods.Name = "buyTicket_foods";
            this.buyTicket_foods.Size = new System.Drawing.Size(113, 24);
            this.buyTicket_foods.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(21, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 20);
            this.label16.TabIndex = 27;
            this.label16.Text = "Foods:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(34, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Available Foods";
            // 
            // buyTicket_availableChairs
            // 
            this.buyTicket_availableChairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_availableChairs.FormattingEnabled = true;
            this.buyTicket_availableChairs.Location = new System.Drawing.Point(118, 35);
            this.buyTicket_availableChairs.Name = "buyTicket_availableChairs";
            this.buyTicket_availableChairs.Size = new System.Drawing.Size(141, 24);
            this.buyTicket_availableChairs.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(12, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Available Chairs:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buyTicket_clear);
            this.panel2.Controls.Add(this.buyTicket_selectMovie);
            this.panel2.Controls.Add(this.buyTicket_regularPrice);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.buyTicket_genre);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.buyTicket_movieName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buyTicket_movieID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(16, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 278);
            this.panel2.TabIndex = 8;
            // 
            // buyTicket_clear
            // 
            this.buyTicket_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_clear.FlatAppearance.BorderSize = 0;
            this.buyTicket_clear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_clear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_clear.ForeColor = System.Drawing.Color.White;
            this.buyTicket_clear.Location = new System.Drawing.Point(376, 208);
            this.buyTicket_clear.Name = "buyTicket_clear";
            this.buyTicket_clear.Size = new System.Drawing.Size(124, 31);
            this.buyTicket_clear.TabIndex = 22;
            this.buyTicket_clear.Text = "CLEAR";
            this.buyTicket_clear.UseVisualStyleBackColor = false;
            this.buyTicket_clear.Click += new System.EventHandler(this.buyTicket_clear_Click);
            // 
            // buyTicket_selectMovie
            // 
            this.buyTicket_selectMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_selectMovie.FlatAppearance.BorderSize = 0;
            this.buyTicket_selectMovie.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_selectMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_selectMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_selectMovie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_selectMovie.ForeColor = System.Drawing.Color.White;
            this.buyTicket_selectMovie.Location = new System.Drawing.Point(220, 208);
            this.buyTicket_selectMovie.Name = "buyTicket_selectMovie";
            this.buyTicket_selectMovie.Size = new System.Drawing.Size(124, 31);
            this.buyTicket_selectMovie.TabIndex = 21;
            this.buyTicket_selectMovie.Text = "SELECT MOVIE";
            this.buyTicket_selectMovie.UseVisualStyleBackColor = false;
            // 
            // buyTicket_regularPrice
            // 
            this.buyTicket_regularPrice.AutoSize = true;
            this.buyTicket_regularPrice.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_regularPrice.ForeColor = System.Drawing.Color.Black;
            this.buyTicket_regularPrice.Location = new System.Drawing.Point(319, 161);
            this.buyTicket_regularPrice.Name = "buyTicket_regularPrice";
            this.buyTicket_regularPrice.Size = new System.Drawing.Size(25, 20);
            this.buyTicket_regularPrice.TabIndex = 16;
            this.buyTicket_regularPrice.Text = "----";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(225, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Regular Price:";
            // 
            // buyTicket_genre
            // 
            this.buyTicket_genre.AutoSize = true;
            this.buyTicket_genre.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_genre.ForeColor = System.Drawing.Color.Black;
            this.buyTicket_genre.Location = new System.Drawing.Point(319, 117);
            this.buyTicket_genre.Name = "buyTicket_genre";
            this.buyTicket_genre.Size = new System.Drawing.Size(25, 20);
            this.buyTicket_genre.TabIndex = 14;
            this.buyTicket_genre.Text = "----";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(266, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Genre:";
            // 
            // buyTicket_movieName
            // 
            this.buyTicket_movieName.AutoSize = true;
            this.buyTicket_movieName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_movieName.ForeColor = System.Drawing.Color.Black;
            this.buyTicket_movieName.Location = new System.Drawing.Point(319, 76);
            this.buyTicket_movieName.Name = "buyTicket_movieName";
            this.buyTicket_movieName.Size = new System.Drawing.Size(25, 20);
            this.buyTicket_movieName.TabIndex = 12;
            this.buyTicket_movieName.Text = "----";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(231, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Movie Name:";
            // 
            // buyTicket_movieID
            // 
            this.buyTicket_movieID.AutoSize = true;
            this.buyTicket_movieID.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_movieID.ForeColor = System.Drawing.Color.Black;
            this.buyTicket_movieID.Location = new System.Drawing.Point(319, 36);
            this.buyTicket_movieID.Name = "buyTicket_movieID";
            this.buyTicket_movieID.Size = new System.Drawing.Size(25, 20);
            this.buyTicket_movieID.TabIndex = 10;
            this.buyTicket_movieID.Text = "----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(253, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Movie ID:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(16, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 220);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // buyTicket_foodNum
            // 
            this.buyTicket_foodNum.Location = new System.Drawing.Point(206, 132);
            this.buyTicket_foodNum.Name = "buyTicket_foodNum";
            this.buyTicket_foodNum.Size = new System.Drawing.Size(53, 20);
            this.buyTicket_foodNum.TabIndex = 40;
            // 
            // buyTicket_drinkNum
            // 
            this.buyTicket_drinkNum.Location = new System.Drawing.Point(206, 189);
            this.buyTicket_drinkNum.Name = "buyTicket_drinkNum";
            this.buyTicket_drinkNum.Size = new System.Drawing.Size(53, 20);
            this.buyTicket_drinkNum.TabIndex = 41;
            // 
            // buyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "buyTicketForm";
            this.Size = new System.Drawing.Size(863, 587);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label buyTicket_regularPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label buyTicket_genre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label buyTicket_movieName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label buyTicket_movieID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buyTicket_clear;
        private System.Windows.Forms.Button buyTicket_selectMovie;
        private System.Windows.Forms.ComboBox buyTicket_availableChairs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox buyTicket_drinks;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox buyTicket_foods;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label buyTicket_totalPrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox buyTicket_amount;
        private System.Windows.Forms.Button buyTicket_clearFields;
        private System.Windows.Forms.Button buyTicket_receiptBtn;
        private System.Windows.Forms.Button buyTicket_buyBtn;
        private System.Windows.Forms.Label buyTicket_change;
        private System.Windows.Forms.Button buyTicket_caculateBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox buyTicket_drinkNum;
        private System.Windows.Forms.TextBox buyTicket_foodNum;
    }
}
