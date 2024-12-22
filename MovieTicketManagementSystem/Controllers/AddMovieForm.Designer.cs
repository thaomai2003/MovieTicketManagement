namespace MovieTicketManagementSystem
{
    partial class AddMovieForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.addMovie_search = new System.Windows.Forms.TextBox();
            this.addMovie_searchBtn = new System.Windows.Forms.Button();
            this.addMovie_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addMovie_clearBtn = new System.Windows.Forms.Button();
            this.addMovie_deleteBtn = new System.Windows.Forms.Button();
            this.addMovie_updateBtn = new System.Windows.Forms.Button();
            this.addMovie_addBtn = new System.Windows.Forms.Button();
            this.addMovie_capacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addMovie_importBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addMovie_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addMovie_genre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addMovie_movieName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addMovie_movieID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.addMovie_search);
            this.panel2.Controls.Add(this.addMovie_searchBtn);
            this.panel2.Controls.Add(this.addMovie_status);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addMovie_clearBtn);
            this.panel2.Controls.Add(this.addMovie_deleteBtn);
            this.panel2.Controls.Add(this.addMovie_updateBtn);
            this.panel2.Controls.Add(this.addMovie_addBtn);
            this.panel2.Controls.Add(this.addMovie_capacity);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addMovie_importBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.addMovie_price);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addMovie_genre);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addMovie_movieName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.addMovie_movieID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(28, 531);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1680, 571);
            this.panel2.TabIndex = 1;
            // 
            // addMovie_search
            // 
            this.addMovie_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_search.Location = new System.Drawing.Point(604, 45);
            this.addMovie_search.Margin = new System.Windows.Forms.Padding(6);
            this.addMovie_search.Name = "addMovie_search";
            this.addMovie_search.Size = new System.Drawing.Size(492, 37);
            this.addMovie_search.TabIndex = 47;
            // 
            // addMovie_searchBtn
            // 
            this.addMovie_searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.addMovie_searchBtn.FlatAppearance.BorderSize = 0;
            this.addMovie_searchBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addMovie_searchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addMovie_searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMovie_searchBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_searchBtn.ForeColor = System.Drawing.Color.White;
            this.addMovie_searchBtn.Location = new System.Drawing.Point(381, 39);
            this.addMovie_searchBtn.Margin = new System.Windows.Forms.Padding(6);
            this.addMovie_searchBtn.Name = "addMovie_searchBtn";
            this.addMovie_searchBtn.Size = new System.Drawing.Size(194, 48);
            this.addMovie_searchBtn.TabIndex = 46;
            this.addMovie_searchBtn.Text = "SEARCH";
            this.addMovie_searchBtn.UseVisualStyleBackColor = false;
            this.addMovie_searchBtn.Click += new System.EventHandler(this.addMovie_searchBtn_Click);
            // 
            // addMovie_status
            // 
            this.addMovie_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_status.FormattingEnabled = true;
            this.addMovie_status.Items.AddRange(new object[] {
            "Available",
            "Unavailable",
            "Deleted"});
            this.addMovie_status.Location = new System.Drawing.Point(861, 335);
            this.addMovie_status.Margin = new System.Windows.Forms.Padding(6);
            this.addMovie_status.Name = "addMovie_status";
            this.addMovie_status.Size = new System.Drawing.Size(346, 38);
            this.addMovie_status.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(751, 342);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 35);
            this.label6.TabIndex = 24;
            this.label6.Text = "Status: ";
            // 
            // addMovie_clearBtn
            // 
            this.addMovie_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.addMovie_clearBtn.FlatAppearance.BorderSize = 0;
            this.addMovie_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addMovie_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addMovie_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMovie_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_clearBtn.ForeColor = System.Drawing.Color.White;
            this.addMovie_clearBtn.Location = new System.Drawing.Point(1029, 437);
            this.addMovie_clearBtn.Margin = new System.Windows.Forms.Padding(6);
            this.addMovie_clearBtn.Name = "addMovie_clearBtn";
            this.addMovie_clearBtn.Size = new System.Drawing.Size(178, 62);
            this.addMovie_clearBtn.TabIndex = 23;
            this.addMovie_clearBtn.Text = "CLEAR";
            this.addMovie_clearBtn.UseVisualStyleBackColor = false;
            this.addMovie_clearBtn.Click += new System.EventHandler(this.addMovie_clearBtn_Click);
            // 
            // addMovie_deleteBtn
            // 
            this.addMovie_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.addMovie_deleteBtn.FlatAppearance.BorderSize = 0;
            this.addMovie_deleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addMovie_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addMovie_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMovie_deleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.addMovie_deleteBtn.Location = new System.Drawing.Point(777, 437);
            this.addMovie_deleteBtn.Margin = new System.Windows.Forms.Padding(6);
            this.addMovie_deleteBtn.Name = "addMovie_deleteBtn";
            this.addMovie_deleteBtn.Size = new System.Drawing.Size(178, 62);
            this.addMovie_deleteBtn.TabIndex = 22;
            this.addMovie_deleteBtn.Text = "DELETE";
            this.addMovie_deleteBtn.UseVisualStyleBackColor = false;
            this.addMovie_deleteBtn.Click += new System.EventHandler(this.addMovie_deleteBtn_Click);
            // 
            // addMovie_updateBtn
            // 
            this.addMovie_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.addMovie_updateBtn.FlatAppearance.BorderSize = 0;
            this.addMovie_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addMovie_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addMovie_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMovie_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_updateBtn.ForeColor = System.Drawing.Color.White;
            this.addMovie_updateBtn.Location = new System.Drawing.Point(515, 437);
            this.addMovie_updateBtn.Margin = new System.Windows.Forms.Padding(6);
            this.addMovie_updateBtn.Name = "addMovie_updateBtn";
            this.addMovie_updateBtn.Size = new System.Drawing.Size(178, 62);
            this.addMovie_updateBtn.TabIndex = 21;
            this.addMovie_updateBtn.Text = "UPDATE";
            this.addMovie_updateBtn.UseVisualStyleBackColor = false;
            this.addMovie_updateBtn.Click += new System.EventHandler(this.addMovie_updateBtn_Click);
            // 
            // addMovie_addBtn
            // 
            this.addMovie_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.addMovie_addBtn.FlatAppearance.BorderSize = 0;
            this.addMovie_addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addMovie_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addMovie_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMovie_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_addBtn.ForeColor = System.Drawing.Color.White;
            this.addMovie_addBtn.Location = new System.Drawing.Point(259, 437);
            this.addMovie_addBtn.Margin = new System.Windows.Forms.Padding(6);
            this.addMovie_addBtn.Name = "addMovie_addBtn";
            this.addMovie_addBtn.Size = new System.Drawing.Size(178, 62);
            this.addMovie_addBtn.TabIndex = 20;
            this.addMovie_addBtn.Text = "ADD";
            this.addMovie_addBtn.UseVisualStyleBackColor = false;
            this.addMovie_addBtn.Click += new System.EventHandler(this.addMovie_addBtn_Click);
            // 
            // addMovie_capacity
            // 
            this.addMovie_capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_capacity.Location = new System.Drawing.Point(861, 240);
            this.addMovie_capacity.Margin = new System.Windows.Forms.Padding(6);
            this.addMovie_capacity.Name = "addMovie_capacity";
            this.addMovie_capacity.Size = new System.Drawing.Size(346, 37);
            this.addMovie_capacity.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(729, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 35);
            this.label5.TabIndex = 18;
            this.label5.Text = "Capacity:";
            // 
            // addMovie_importBtn
            // 
            this.addMovie_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.addMovie_importBtn.FlatAppearance.BorderSize = 0;
            this.addMovie_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMovie_importBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_importBtn.ForeColor = System.Drawing.Color.White;
            this.addMovie_importBtn.Location = new System.Drawing.Point(1310, 459);
            this.addMovie_importBtn.Margin = new System.Windows.Forms.Padding(6);
            this.addMovie_importBtn.Name = "addMovie_importBtn";
            this.addMovie_importBtn.Size = new System.Drawing.Size(321, 60);
            this.addMovie_importBtn.TabIndex = 17;
            this.addMovie_importBtn.Text = "Import";
            this.addMovie_importBtn.UseVisualStyleBackColor = false;
            this.addMovie_importBtn.Click += new System.EventHandler(this.addMovie_importBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(1310, 69);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 379);
            this.panel3.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // addMovie_price
            // 
            this.addMovie_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_price.Location = new System.Drawing.Point(861, 148);
            this.addMovie_price.Margin = new System.Windows.Forms.Padding(6);
            this.addMovie_price.Name = "addMovie_price";
            this.addMovie_price.Size = new System.Drawing.Size(346, 37);
            this.addMovie_price.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(767, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 35);
            this.label4.TabIndex = 14;
            this.label4.Text = "Price:";
            // 
            // addMovie_genre
            // 
            this.addMovie_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_genre.FormattingEnabled = true;
            this.addMovie_genre.Items.AddRange(new object[] {
            "Educational",
            "Comedy",
            "Drama",
            "Action",
            "Horror",
            "Fiction",
            "Anime"});
            this.addMovie_genre.Location = new System.Drawing.Point(333, 343);
            this.addMovie_genre.Margin = new System.Windows.Forms.Padding(6);
            this.addMovie_genre.Name = "addMovie_genre";
            this.addMovie_genre.Size = new System.Drawing.Size(346, 38);
            this.addMovie_genre.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(227, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 35);
            this.label3.TabIndex = 12;
            this.label3.Text = "Genre:";
            // 
            // addMovie_movieName
            // 
            this.addMovie_movieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_movieName.Location = new System.Drawing.Point(333, 244);
            this.addMovie_movieName.Margin = new System.Windows.Forms.Padding(6);
            this.addMovie_movieName.Name = "addMovie_movieName";
            this.addMovie_movieName.Size = new System.Drawing.Size(346, 37);
            this.addMovie_movieName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(157, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Movie Name:";
            // 
            // addMovie_movieID
            // 
            this.addMovie_movieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_movieID.Location = new System.Drawing.Point(333, 152);
            this.addMovie_movieID.Margin = new System.Windows.Forms.Padding(6);
            this.addMovie_movieID.Name = "addMovie_movieID";
            this.addMovie_movieID.Size = new System.Drawing.Size(346, 37);
            this.addMovie_movieID.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(201, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Movie ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(28, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 34);
            this.label9.TabIndex = 5;
            this.label9.Text = "All Movies";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(28, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1680, 498);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridView1.Location = new System.Drawing.Point(34, 77);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(1620, 390);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddMovieForm";
            this.Size = new System.Drawing.Size(1726, 1129);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox addMovie_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addMovie_clearBtn;
        private System.Windows.Forms.Button addMovie_deleteBtn;
        private System.Windows.Forms.Button addMovie_updateBtn;
        private System.Windows.Forms.Button addMovie_addBtn;
        private System.Windows.Forms.TextBox addMovie_capacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addMovie_importBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox addMovie_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox addMovie_genre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addMovie_movieName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addMovie_movieID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox addMovie_search;
        private System.Windows.Forms.Button addMovie_searchBtn;
    }
}
