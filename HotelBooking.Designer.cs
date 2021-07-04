
namespace AirlineReservationSystemCollegeProject
{
    partial class HotelBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelBooking));
            this.Passidcb = new System.Windows.Forms.ComboBox();
            this.Passname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.Checkindate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Checkoutdate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BackBtn = new System.Windows.Forms.Button();
            this.BookBtn = new System.Windows.Forms.Button();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBookHotelRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.login_DatabaseDataSet8 = new AirlineReservationSystemCollegeProject.Login_DatabaseDataSet8();
            this.label1 = new System.Windows.Forms.Label();
            this.ridtb = new System.Windows.Forms.TextBox();
            this.Ratetb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hidcb = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tblBookHotelRoomTableAdapter = new AirlineReservationSystemCollegeProject.Login_DatabaseDataSet8TableAdapters.TblBookHotelRoomTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookHotelRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_DatabaseDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Passidcb
            // 
            this.Passidcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passidcb.FormattingEnabled = true;
            this.Passidcb.Location = new System.Drawing.Point(286, 202);
            this.Passidcb.Name = "Passidcb";
            this.Passidcb.Size = new System.Drawing.Size(229, 32);
            this.Passidcb.TabIndex = 46;
            this.Passidcb.Text = "   ";
            this.Passidcb.SelectionChangeCommitted += new System.EventHandler(this.Passidcb_SelectionChangeCommitted);
            // 
            // Passname
            // 
            this.Passname.BackColor = System.Drawing.Color.White;
            this.Passname.Enabled = false;
            this.Passname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passname.ForeColor = System.Drawing.Color.DarkGray;
            this.Passname.Location = new System.Drawing.Point(286, 244);
            this.Passname.Name = "Passname";
            this.Passname.Size = new System.Drawing.Size(234, 29);
            this.Passname.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(94, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 24);
            this.label8.TabIndex = 42;
            this.label8.Text = "Passanger Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(94, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 41;
            this.label7.Text = "Passanger ID";
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.Black;
            this.ExitBtn.Location = new System.Drawing.Point(1085, 9);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(25, 24);
            this.ExitBtn.TabIndex = 34;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
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
            this.panel2.Size = new System.Drawing.Size(1079, 103);
            this.panel2.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(177, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(435, 59);
            this.label10.TabIndex = 0;
            this.label10.Text = "Hotel Room Booking";
            // 
            // Checkindate
            // 
            this.Checkindate.AutoSize = true;
            this.Checkindate.BackColor = System.Drawing.Color.Transparent;
            this.Checkindate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkindate.ForeColor = System.Drawing.Color.Black;
            this.Checkindate.Location = new System.Drawing.Point(94, 288);
            this.Checkindate.Name = "Checkindate";
            this.Checkindate.Size = new System.Drawing.Size(90, 24);
            this.Checkindate.TabIndex = 64;
            this.Checkindate.Text = "Check-in ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(286, 283);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 29);
            this.dateTimePicker1.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(94, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 88;
            this.label3.Text = "Hotel Id";
            // 
            // Checkoutdate
            // 
            this.Checkoutdate.AutoSize = true;
            this.Checkoutdate.BackColor = System.Drawing.Color.Transparent;
            this.Checkoutdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkoutdate.ForeColor = System.Drawing.Color.Black;
            this.Checkoutdate.Location = new System.Drawing.Point(94, 326);
            this.Checkoutdate.Name = "Checkoutdate";
            this.Checkoutdate.Size = new System.Drawing.Size(96, 24);
            this.Checkoutdate.TabIndex = 91;
            this.Checkoutdate.Text = "Check-out";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(286, 321);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(170, 29);
            this.dateTimePicker2.TabIndex = 90;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(477, 419);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(135, 42);
            this.BackBtn.TabIndex = 94;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // BookBtn
            // 
            this.BookBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.BookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookBtn.ForeColor = System.Drawing.Color.White;
            this.BookBtn.Location = new System.Drawing.Point(139, 419);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(135, 42);
            this.BookBtn.TabIndex = 93;
            this.BookBtn.Text = "Book";
            this.BookBtn.UseVisualStyleBackColor = false;
            this.BookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // Resetbtn
            // 
            this.Resetbtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbtn.ForeColor = System.Drawing.Color.White;
            this.Resetbtn.Location = new System.Drawing.Point(304, 419);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(135, 42);
            this.Resetbtn.TabIndex = 92;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.UseVisualStyleBackColor = false;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ridDataGridViewTextBoxColumn,
            this.hotelIdDataGridViewTextBoxColumn,
            this.passIdDataGridViewTextBoxColumn,
            this.passNameDataGridViewTextBoxColumn,
            this.checkinDataGridViewTextBoxColumn,
            this.checkoutDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblBookHotelRoomBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(98, 486);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 215);
            this.dataGridView1.TabIndex = 95;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            // 
            // ridDataGridViewTextBoxColumn
            // 
            this.ridDataGridViewTextBoxColumn.DataPropertyName = "Rid";
            this.ridDataGridViewTextBoxColumn.HeaderText = "Rid";
            this.ridDataGridViewTextBoxColumn.Name = "ridDataGridViewTextBoxColumn";
            // 
            // hotelIdDataGridViewTextBoxColumn
            // 
            this.hotelIdDataGridViewTextBoxColumn.DataPropertyName = "Hotel_Id";
            this.hotelIdDataGridViewTextBoxColumn.HeaderText = "Hotel_Id";
            this.hotelIdDataGridViewTextBoxColumn.Name = "hotelIdDataGridViewTextBoxColumn";
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
            // checkinDataGridViewTextBoxColumn
            // 
            this.checkinDataGridViewTextBoxColumn.DataPropertyName = "Checkin";
            this.checkinDataGridViewTextBoxColumn.HeaderText = "Checkin";
            this.checkinDataGridViewTextBoxColumn.Name = "checkinDataGridViewTextBoxColumn";
            // 
            // checkoutDataGridViewTextBoxColumn
            // 
            this.checkoutDataGridViewTextBoxColumn.DataPropertyName = "Checkout";
            this.checkoutDataGridViewTextBoxColumn.HeaderText = "Checkout";
            this.checkoutDataGridViewTextBoxColumn.Name = "checkoutDataGridViewTextBoxColumn";
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            // 
            // tblBookHotelRoomBindingSource
            // 
            this.tblBookHotelRoomBindingSource.DataMember = "TblBookHotelRoom";
            this.tblBookHotelRoomBindingSource.DataSource = this.login_DatabaseDataSet8;
            // 
            // login_DatabaseDataSet8
            // 
            this.login_DatabaseDataSet8.DataSetName = "Login_DatabaseDataSet8";
            this.login_DatabaseDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(94, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 96;
            this.label1.Text = "Room Id";
            // 
            // ridtb
            // 
            this.ridtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ridtb.Location = new System.Drawing.Point(286, 118);
            this.ridtb.Name = "ridtb";
            this.ridtb.Size = new System.Drawing.Size(200, 29);
            this.ridtb.TabIndex = 97;
            // 
            // Ratetb
            // 
            this.Ratetb.BackColor = System.Drawing.Color.White;
            this.Ratetb.Enabled = false;
            this.Ratetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ratetb.ForeColor = System.Drawing.Color.DarkGray;
            this.Ratetb.Location = new System.Drawing.Point(285, 356);
            this.Ratetb.Name = "Ratetb";
            this.Ratetb.Size = new System.Drawing.Size(170, 29);
            this.Ratetb.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(94, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 98;
            this.label2.Text = "Rate";
            // 
            // hidcb
            // 
            this.hidcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidcb.FormattingEnabled = true;
            this.hidcb.Location = new System.Drawing.Point(285, 159);
            this.hidcb.Name = "hidcb";
            this.hidcb.Size = new System.Drawing.Size(229, 32);
            this.hidcb.TabIndex = 100;
            this.hidcb.Text = "   ";
            this.hidcb.SelectionChangeCommitted += new System.EventHandler(this.Hidcb_SelectionChangeCommitted);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(623, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(463, 262);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 101;
            this.pictureBox2.TabStop = false;
            // 
            // tblBookHotelRoomTableAdapter
            // 
            this.tblBookHotelRoomTableAdapter.ClearBeforeFill = true;
            // 
            // HotelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 749);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.hidcb);
            this.Controls.Add(this.Ratetb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ridtb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.BookBtn);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.Checkoutdate);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Checkindate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Passidcb);
            this.Controls.Add(this.Passname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HotelBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HotelBooking";
            this.Load += new System.EventHandler(this.HotelBooking_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookHotelRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_DatabaseDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Passidcb;
        private System.Windows.Forms.TextBox Passname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Checkindate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Checkoutdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button BookBtn;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ridtb;
        private System.Windows.Forms.TextBox Ratetb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox hidcb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Login_DatabaseDataSet8 login_DatabaseDataSet8;
        private System.Windows.Forms.BindingSource tblBookHotelRoomBindingSource;
        private Login_DatabaseDataSet8TableAdapters.TblBookHotelRoomTableAdapter tblBookHotelRoomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
    }
}