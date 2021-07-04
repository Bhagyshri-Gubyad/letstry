
namespace AirlineReservationSystemCollegeProject
{
    partial class FlightBooking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Passname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Tidtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fidcb = new System.Windows.Forms.ComboBox();
            this.Passidcb = new System.Windows.Forms.ComboBox();
            this.Ppasstb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.AmtTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.BookBtn = new System.Windows.Forms.Button();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.FlightbookDGV = new System.Windows.Forms.DataGridView();
            this.tIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passPassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passNatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookFlightTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.login_DatabaseDataSet7 = new AirlineReservationSystemCollegeProject.Login_DatabaseDataSet7();
            this.Pnat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.bookFlightTicketTableAdapter = new AirlineReservationSystemCollegeProject.Login_DatabaseDataSet7TableAdapters.BookFlightTicketTableAdapter();
            this.passporttb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FlightbookDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookFlightTicketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_DatabaseDataSet7)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Passname
            // 
            this.Passname.BackColor = System.Drawing.Color.White;
            this.Passname.Enabled = false;
            this.Passname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passname.ForeColor = System.Drawing.Color.Black;
            this.Passname.Location = new System.Drawing.Point(704, 191);
            this.Passname.Name = "Passname";
            this.Passname.Size = new System.Drawing.Size(234, 29);
            this.Passname.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(532, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Passanger Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(46, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 29;
            this.label7.Text = "Passanger ID";
            // 
            // Tidtb
            // 
            this.Tidtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tidtb.Location = new System.Drawing.Point(196, 136);
            this.Tidtb.Name = "Tidtb";
            this.Tidtb.Size = new System.Drawing.Size(229, 29);
            this.Tidtb.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(532, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Flight Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ticket Id";
            // 
            // Fidcb
            // 
            this.Fidcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fidcb.FormattingEnabled = true;
            this.Fidcb.Location = new System.Drawing.Point(704, 133);
            this.Fidcb.Name = "Fidcb";
            this.Fidcb.Size = new System.Drawing.Size(229, 32);
            this.Fidcb.TabIndex = 39;
            this.Fidcb.SelectionChangeCommitted += new System.EventHandler(this.Fidcb_SelectionChangeCommitted);
            // 
            // Passidcb
            // 
            this.Passidcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passidcb.FormattingEnabled = true;
            this.Passidcb.Location = new System.Drawing.Point(196, 192);
            this.Passidcb.Name = "Passidcb";
            this.Passidcb.Size = new System.Drawing.Size(229, 32);
            this.Passidcb.TabIndex = 40;
            this.Passidcb.Text = "   ";
            this.Passidcb.SelectionChangeCommitted += new System.EventHandler(this.Passidcb_SelectionChangeCommitted);
            // 
            // Ppasstb
            // 
            this.Ppasstb.Location = new System.Drawing.Point(0, 0);
            this.Ppasstb.Name = "Ppasstb";
            this.Ppasstb.Size = new System.Drawing.Size(100, 20);
            this.Ppasstb.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(46, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "Passport";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(532, 263);
            this.label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(95, 24);
            this.label.TabIndex = 52;
            this.label.Text = "Nationality";
            // 
            // AmtTb
            // 
            this.AmtTb.BackColor = System.Drawing.Color.White;
            this.AmtTb.Enabled = false;
            this.AmtTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmtTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AmtTb.Location = new System.Drawing.Point(196, 310);
            this.AmtTb.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AmtTb.Name = "AmtTb";
            this.AmtTb.Size = new System.Drawing.Size(229, 29);
            this.AmtTb.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 54;
            this.label4.Text = "Amount";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(651, 377);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(135, 42);
            this.BackBtn.TabIndex = 58;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // BookBtn
            // 
            this.BookBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.BookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookBtn.ForeColor = System.Drawing.Color.White;
            this.BookBtn.Location = new System.Drawing.Point(276, 377);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(135, 42);
            this.BookBtn.TabIndex = 57;
            this.BookBtn.Text = "Book";
            this.BookBtn.UseVisualStyleBackColor = false;
            this.BookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // Resetbtn
            // 
            this.Resetbtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbtn.ForeColor = System.Drawing.Color.White;
            this.Resetbtn.Location = new System.Drawing.Point(465, 377);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(135, 42);
            this.Resetbtn.TabIndex = 56;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.UseVisualStyleBackColor = false;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // FlightbookDGV
            // 
            this.FlightbookDGV.AutoGenerateColumns = false;
            this.FlightbookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FlightbookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FlightbookDGV.ColumnHeadersHeight = 30;
            this.FlightbookDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIdDataGridViewTextBoxColumn,
            this.flightNumberDataGridViewTextBoxColumn,
            this.passIdDataGridViewTextBoxColumn,
            this.passNameDataGridViewTextBoxColumn,
            this.passPassportDataGridViewTextBoxColumn,
            this.passNatDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.FlightbookDGV.DataSource = this.bookFlightTicketBindingSource;
            this.FlightbookDGV.Location = new System.Drawing.Point(127, 435);
            this.FlightbookDGV.Name = "FlightbookDGV";
            this.FlightbookDGV.Size = new System.Drawing.Size(845, 251);
            this.FlightbookDGV.TabIndex = 59;
            this.FlightbookDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FlightbookDGV_RowHeaderMouseClick);
            // 
            // tIdDataGridViewTextBoxColumn
            // 
            this.tIdDataGridViewTextBoxColumn.DataPropertyName = "TId";
            this.tIdDataGridViewTextBoxColumn.HeaderText = "TId";
            this.tIdDataGridViewTextBoxColumn.Name = "tIdDataGridViewTextBoxColumn";
            // 
            // flightNumberDataGridViewTextBoxColumn
            // 
            this.flightNumberDataGridViewTextBoxColumn.DataPropertyName = "Flight_Number";
            this.flightNumberDataGridViewTextBoxColumn.HeaderText = "Flight_Number";
            this.flightNumberDataGridViewTextBoxColumn.Name = "flightNumberDataGridViewTextBoxColumn";
            // 
            // passIdDataGridViewTextBoxColumn
            // 
            this.passIdDataGridViewTextBoxColumn.DataPropertyName = "PassId";
            this.passIdDataGridViewTextBoxColumn.HeaderText = "PassId";
            this.passIdDataGridViewTextBoxColumn.Name = "passIdDataGridViewTextBoxColumn";
            // 
            // passNameDataGridViewTextBoxColumn
            // 
            this.passNameDataGridViewTextBoxColumn.DataPropertyName = "PassName";
            this.passNameDataGridViewTextBoxColumn.HeaderText = "PassName";
            this.passNameDataGridViewTextBoxColumn.Name = "passNameDataGridViewTextBoxColumn";
            // 
            // passPassportDataGridViewTextBoxColumn
            // 
            this.passPassportDataGridViewTextBoxColumn.DataPropertyName = "PassPassport";
            this.passPassportDataGridViewTextBoxColumn.HeaderText = "PassPassport";
            this.passPassportDataGridViewTextBoxColumn.Name = "passPassportDataGridViewTextBoxColumn";
            // 
            // passNatDataGridViewTextBoxColumn
            // 
            this.passNatDataGridViewTextBoxColumn.DataPropertyName = "PassNat";
            this.passNatDataGridViewTextBoxColumn.HeaderText = "PassNat";
            this.passNatDataGridViewTextBoxColumn.Name = "passNatDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // bookFlightTicketBindingSource
            // 
            this.bookFlightTicketBindingSource.DataMember = "BookFlightTicket";
            this.bookFlightTicketBindingSource.DataSource = this.login_DatabaseDataSet7;
            // 
            // login_DatabaseDataSet7
            // 
            this.login_DatabaseDataSet7.DataSetName = "Login_DatabaseDataSet7";
            this.login_DatabaseDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Pnat
            // 
            this.Pnat.BackColor = System.Drawing.Color.White;
            this.Pnat.Enabled = false;
            this.Pnat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnat.ForeColor = System.Drawing.Color.Black;
            this.Pnat.Location = new System.Drawing.Point(704, 258);
            this.Pnat.Name = "Pnat";
            this.Pnat.Size = new System.Drawing.Size(234, 29);
            this.Pnat.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(177, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(441, 59);
            this.label10.TabIndex = 0;
            this.label10.Text = "Flight Ticket Booking";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 115);
            this.panel2.TabIndex = 61;
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.Black;
            this.ExitBtn.Location = new System.Drawing.Point(1050, 9);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(25, 24);
            this.ExitBtn.TabIndex = 34;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // bookFlightTicketTableAdapter
            // 
            this.bookFlightTicketTableAdapter.ClearBeforeFill = true;
            // 
            // passporttb
            // 
            this.passporttb.BackColor = System.Drawing.Color.White;
            this.passporttb.Enabled = false;
            this.passporttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passporttb.Location = new System.Drawing.Point(196, 256);
            this.passporttb.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.passporttb.Name = "passporttb";
            this.passporttb.Size = new System.Drawing.Size(229, 29);
            this.passporttb.TabIndex = 63;
            // 
            // FlightBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 749);
            this.Controls.Add(this.passporttb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Pnat);
            this.Controls.Add(this.FlightbookDGV);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.BookBtn);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.AmtTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Ppasstb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Passidcb);
            this.Controls.Add(this.Fidcb);
            this.Controls.Add(this.Tidtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Passname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlightBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightBooking";
            this.Load += new System.EventHandler(this.FlightBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightbookDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookFlightTicketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_DatabaseDataSet7)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Passname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tidtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Fidcb;
        private System.Windows.Forms.ComboBox Passidcb;
        private System.Windows.Forms.TextBox Ppasstb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox AmtTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button BookBtn;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.DataGridView FlightbookDGV;
        private System.Windows.Forms.TextBox Pnat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private Login_DatabaseDataSet7 login_DatabaseDataSet7;
        private System.Windows.Forms.BindingSource bookFlightTicketBindingSource;
        private Login_DatabaseDataSet7TableAdapters.BookFlightTicketTableAdapter bookFlightTicketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passPassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passNatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox passporttb;
        private System.Windows.Forms.Label ExitBtn;
    }
}