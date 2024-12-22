namespace MovieTicketManagementSystem.Controller
{
    partial class ReceiptForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.receipt_search = new System.Windows.Forms.TextBox();
            this.receipt_receiptID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.receipt_change = new System.Windows.Forms.TextBox();
            this.receipt_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.receipt_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.receipt_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.receipt_clearBtn = new System.Windows.Forms.Button();
            this.receipt_deleteBtn = new System.Windows.Forms.Button();
            this.receipt_updateBtn = new System.Windows.Forms.Button();
            this.receipt_searchBtn = new System.Windows.Forms.Button();
            this.receipt_seatNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.receipt_movieID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(1046, 962);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(28, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 34);
            this.label9.TabIndex = 5;
            this.label9.Text = "All Receipt";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(22, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 1081);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.receipt_search);
            this.panel2.Controls.Add(this.receipt_receiptID);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.receipt_change);
            this.panel2.Controls.Add(this.receipt_price);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.receipt_amount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.receipt_status);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.receipt_clearBtn);
            this.panel2.Controls.Add(this.receipt_deleteBtn);
            this.panel2.Controls.Add(this.receipt_updateBtn);
            this.panel2.Controls.Add(this.receipt_searchBtn);
            this.panel2.Controls.Add(this.receipt_seatNum);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.receipt_movieID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(1136, 23);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 1081);
            this.panel2.TabIndex = 3;
            // 
            // receipt_search
            // 
            this.receipt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt_search.Location = new System.Drawing.Point(268, 56);
            this.receipt_search.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.receipt_search.Name = "receipt_search";
            this.receipt_search.Size = new System.Drawing.Size(266, 37);
            this.receipt_search.TabIndex = 45;
            // 
            // receipt_receiptID
            // 
            this.receipt_receiptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt_receiptID.Location = new System.Drawing.Point(188, 187);
            this.receipt_receiptID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.receipt_receiptID.Name = "receipt_receiptID";
            this.receipt_receiptID.Size = new System.Drawing.Size(346, 37);
            this.receipt_receiptID.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(36, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 35);
            this.label7.TabIndex = 43;
            this.label7.Text = "Receipt ID:";
            // 
            // receipt_change
            // 
            this.receipt_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt_change.Location = new System.Drawing.Point(188, 654);
            this.receipt_change.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.receipt_change.Name = "receipt_change";
            this.receipt_change.Size = new System.Drawing.Size(346, 37);
            this.receipt_change.TabIndex = 42;
            // 
            // receipt_price
            // 
            this.receipt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt_price.Location = new System.Drawing.Point(188, 458);
            this.receipt_price.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.receipt_price.Name = "receipt_price";
            this.receipt_price.Size = new System.Drawing.Size(346, 37);
            this.receipt_price.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(94, 458);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 35);
            this.label2.TabIndex = 26;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 556);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 35);
            this.label1.TabIndex = 28;
            this.label1.Text = "Amount:";
            // 
            // receipt_amount
            // 
            this.receipt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt_amount.Location = new System.Drawing.Point(188, 552);
            this.receipt_amount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.receipt_amount.Name = "receipt_amount";
            this.receipt_amount.Size = new System.Drawing.Size(346, 37);
            this.receipt_amount.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(64, 654);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 35);
            this.label3.TabIndex = 30;
            this.label3.Text = "Change:";
            // 
            // receipt_status
            // 
            this.receipt_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt_status.FormattingEnabled = true;
            this.receipt_status.Items.AddRange(new object[] {
            "PAID",
            "UNPAID"});
            this.receipt_status.Location = new System.Drawing.Point(188, 744);
            this.receipt_status.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.receipt_status.Name = "receipt_status";
            this.receipt_status.Size = new System.Drawing.Size(346, 38);
            this.receipt_status.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(78, 752);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 35);
            this.label6.TabIndex = 40;
            this.label6.Text = "Status: ";
            // 
            // receipt_clearBtn
            // 
            this.receipt_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.receipt_clearBtn.FlatAppearance.BorderSize = 0;
            this.receipt_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.receipt_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.receipt_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receipt_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt_clearBtn.ForeColor = System.Drawing.Color.White;
            this.receipt_clearBtn.Location = new System.Drawing.Point(208, 996);
            this.receipt_clearBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.receipt_clearBtn.Name = "receipt_clearBtn";
            this.receipt_clearBtn.Size = new System.Drawing.Size(178, 62);
            this.receipt_clearBtn.TabIndex = 39;
            this.receipt_clearBtn.Text = "CLEAR";
            this.receipt_clearBtn.UseVisualStyleBackColor = false;
            this.receipt_clearBtn.Click += new System.EventHandler(this.receipt_clearBtn_Click);
            // 
            // receipt_deleteBtn
            // 
            this.receipt_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.receipt_deleteBtn.FlatAppearance.BorderSize = 0;
            this.receipt_deleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.receipt_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.receipt_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receipt_deleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.receipt_deleteBtn.Location = new System.Drawing.Point(86, 885);
            this.receipt_deleteBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.receipt_deleteBtn.Name = "receipt_deleteBtn";
            this.receipt_deleteBtn.Size = new System.Drawing.Size(178, 62);
            this.receipt_deleteBtn.TabIndex = 38;
            this.receipt_deleteBtn.Text = "DELETE";
            this.receipt_deleteBtn.UseVisualStyleBackColor = false;
            this.receipt_deleteBtn.Click += new System.EventHandler(this.receipt_deleteBtn_Click);
            // 
            // receipt_updateBtn
            // 
            this.receipt_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.receipt_updateBtn.FlatAppearance.BorderSize = 0;
            this.receipt_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.receipt_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.receipt_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receipt_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt_updateBtn.ForeColor = System.Drawing.Color.White;
            this.receipt_updateBtn.Location = new System.Drawing.Point(312, 885);
            this.receipt_updateBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.receipt_updateBtn.Name = "receipt_updateBtn";
            this.receipt_updateBtn.Size = new System.Drawing.Size(178, 62);
            this.receipt_updateBtn.TabIndex = 37;
            this.receipt_updateBtn.Text = "UPDATE";
            this.receipt_updateBtn.UseVisualStyleBackColor = false;
            this.receipt_updateBtn.Click += new System.EventHandler(this.receipt_updateBtn_Click);
            // 
            // receipt_searchBtn
            // 
            this.receipt_searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.receipt_searchBtn.FlatAppearance.BorderSize = 0;
            this.receipt_searchBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.receipt_searchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.receipt_searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receipt_searchBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt_searchBtn.ForeColor = System.Drawing.Color.White;
            this.receipt_searchBtn.Location = new System.Drawing.Point(44, 56);
            this.receipt_searchBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.receipt_searchBtn.Name = "receipt_searchBtn";
            this.receipt_searchBtn.Size = new System.Drawing.Size(194, 48);
            this.receipt_searchBtn.TabIndex = 36;
            this.receipt_searchBtn.Text = "SEARCH";
            this.receipt_searchBtn.UseVisualStyleBackColor = false;
            this.receipt_searchBtn.Click += new System.EventHandler(this.receipt_searchBtn_Click);
            // 
            // receipt_seatNum
            // 
            this.receipt_seatNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt_seatNum.Location = new System.Drawing.Point(188, 367);
            this.receipt_seatNum.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.receipt_seatNum.Name = "receipt_seatNum";
            this.receipt_seatNum.Size = new System.Drawing.Size(346, 37);
            this.receipt_seatNum.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 371);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 35);
            this.label5.TabIndex = 34;
            this.label5.Text = "Seat Number:";
            // 
            // receipt_movieID
            // 
            this.receipt_movieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt_movieID.Location = new System.Drawing.Point(188, 275);
            this.receipt_movieID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.receipt_movieID.Name = "receipt_movieID";
            this.receipt_movieID.Size = new System.Drawing.Size(346, 37);
            this.receipt_movieID.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(56, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 35);
            this.label4.TabIndex = 32;
            this.label4.Text = "Movie ID:";
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ReceiptForm";
            this.Size = new System.Drawing.Size(1726, 1129);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox receipt_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox receipt_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox receipt_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button receipt_searchBtn;
        private System.Windows.Forms.TextBox receipt_seatNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox receipt_movieID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox receipt_change;
        private System.Windows.Forms.Button receipt_clearBtn;
        private System.Windows.Forms.Button receipt_deleteBtn;
        private System.Windows.Forms.Button receipt_updateBtn;
        private System.Windows.Forms.TextBox receipt_receiptID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox receipt_search;
    }
}
