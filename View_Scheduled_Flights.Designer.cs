
namespace AirlineReservationSystemCollegeProject
{
    partial class View_Scheduled_Flights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Scheduled_Flights));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.destcb = new System.Windows.Forms.ComboBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.sourcecb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Airlname = new System.Windows.Forms.TextBox();
            this.Fid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.pricetb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.faretb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flightNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFlightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.login_DatabaseDataSet6 = new AirlineReservationSystemCollegeProject.Login_DatabaseDataSet6();
            this.tblFlightTableAdapter = new AirlineReservationSystemCollegeProject.Login_DatabaseDataSet6TableAdapters.TblFlightTableAdapter();
            this.seats = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFlightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_DatabaseDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 136);
            this.panel2.TabIndex = 41;
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.Black;
            this.ExitBtn.Location = new System.Drawing.Point(901, 9);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(25, 24);
            this.ExitBtn.TabIndex = 33;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(181, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(477, 59);
            this.label6.TabIndex = 0;
            this.label6.Text = "View Scheduled Flight ";
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(203, 387);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(109, 47);
            this.update_btn.TabIndex = 57;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(346, 387);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(106, 47);
            this.delete_btn.TabIndex = 56;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(598, 232);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 24);
            this.label16.TabIndex = 55;
            this.label16.Text = "Arrival Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(717, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 29);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(73, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 53;
            this.label4.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(73, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 52;
            this.label3.Text = "Source";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(207, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // destcb
            // 
            this.destcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destcb.FormattingEnabled = true;
            this.destcb.Items.AddRange(new object[] {
            "\tBangalore",
            "\tChennai",
            "\tKolkata",
            "\tHyderabad",
            "\tDelhi",
            "\tGoa",
            "\tBangkok",
            "\tNew York",
            "\tKathmandu",
            "\tDubai",
            "\tSingapore",
            "\tKuala Lumpur (KUL)",
            "\tLondon"});
            this.destcb.Location = new System.Drawing.Point(203, 322);
            this.destcb.Name = "destcb";
            this.destcb.Size = new System.Drawing.Size(273, 32);
            this.destcb.TabIndex = 50;
            this.destcb.Text = "            Type Destination City";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.White;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(207, 274);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(43, 24);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 49;
            this.pictureBox13.TabStop = false;
            // 
            // sourcecb
            // 
            this.sourcecb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourcecb.FormattingEnabled = true;
            this.sourcecb.Items.AddRange(new object[] {
            "\tBangalore",
            "\tChennai",
            "\tKolkata",
            "\tHyderabad",
            "\tDelhi",
            "\tGoa",
            "\tBangkok",
            "\tNew York",
            "\tKathmandu",
            "\tDubai",
            "\tSingapore",
            "\tKuala Lumpur (KUL)",
            "\tLondon"});
            this.sourcecb.Location = new System.Drawing.Point(203, 271);
            this.sourcecb.Name = "sourcecb";
            this.sourcecb.Size = new System.Drawing.Size(273, 32);
            this.sourcecb.TabIndex = 48;
            this.sourcecb.Text = "            Type Departure City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(598, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 46;
            this.label5.Text = "No. of Seats";
            // 
            // Airlname
            // 
            this.Airlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Airlname.Location = new System.Drawing.Point(203, 221);
            this.Airlname.Name = "Airlname";
            this.Airlname.Size = new System.Drawing.Size(273, 29);
            this.Airlname.TabIndex = 45;
            // 
            // Fid
            // 
            this.Fid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fid.Location = new System.Drawing.Point(203, 174);
            this.Fid.Name = "Fid";
            this.Fid.Size = new System.Drawing.Size(270, 29);
            this.Fid.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(73, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Airline Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(73, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Flight ID";
            // 
            // Reset_btn
            // 
            this.Reset_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_btn.ForeColor = System.Drawing.Color.White;
            this.Reset_btn.Location = new System.Drawing.Point(477, 387);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(109, 47);
            this.Reset_btn.TabIndex = 59;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = false;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.Color.White;
            this.Back_btn.Location = new System.Drawing.Point(611, 387);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(106, 47);
            this.Back_btn.TabIndex = 58;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // pricetb
            // 
            this.pricetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetb.Location = new System.Drawing.Point(717, 322);
            this.pricetb.Name = "pricetb";
            this.pricetb.Size = new System.Drawing.Size(170, 29);
            this.pricetb.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(598, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 60;
            this.label7.Text = "Price";
            // 
            // faretb
            // 
            this.faretb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faretb.Location = new System.Drawing.Point(717, 179);
            this.faretb.Name = "faretb";
            this.faretb.Size = new System.Drawing.Size(170, 29);
            this.faretb.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(598, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 24);
            this.label8.TabIndex = 62;
            this.label8.Text = "Fare";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightNumberDataGridViewTextBoxColumn,
            this.airlineNameDataGridViewTextBoxColumn,
            this.aFromDataGridViewTextBoxColumn,
            this.aToDataGridViewTextBoxColumn,
            this.fareDataGridViewTextBoxColumn,
            this.arrivalDateDataGridViewTextBoxColumn,
            this.seatsDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblFlightBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 458);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(762, 238);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            // 
            // flightNumberDataGridViewTextBoxColumn
            // 
            this.flightNumberDataGridViewTextBoxColumn.DataPropertyName = "Flight_Number";
            this.flightNumberDataGridViewTextBoxColumn.FillWeight = 89.38548F;
            this.flightNumberDataGridViewTextBoxColumn.HeaderText = "Flight_Number";
            this.flightNumberDataGridViewTextBoxColumn.Name = "flightNumberDataGridViewTextBoxColumn";
            this.flightNumberDataGridViewTextBoxColumn.Width = 129;
            // 
            // airlineNameDataGridViewTextBoxColumn
            // 
            this.airlineNameDataGridViewTextBoxColumn.DataPropertyName = "Airline_Name";
            this.airlineNameDataGridViewTextBoxColumn.FillWeight = 93.15232F;
            this.airlineNameDataGridViewTextBoxColumn.HeaderText = "Airline_Name";
            this.airlineNameDataGridViewTextBoxColumn.Name = "airlineNameDataGridViewTextBoxColumn";
            this.airlineNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // aFromDataGridViewTextBoxColumn
            // 
            this.aFromDataGridViewTextBoxColumn.DataPropertyName = "A_From";
            this.aFromDataGridViewTextBoxColumn.FillWeight = 96.4983F;
            this.aFromDataGridViewTextBoxColumn.HeaderText = "A_From";
            this.aFromDataGridViewTextBoxColumn.Name = "aFromDataGridViewTextBoxColumn";
            this.aFromDataGridViewTextBoxColumn.Width = 86;
            // 
            // aToDataGridViewTextBoxColumn
            // 
            this.aToDataGridViewTextBoxColumn.DataPropertyName = "A_To";
            this.aToDataGridViewTextBoxColumn.FillWeight = 99.47043F;
            this.aToDataGridViewTextBoxColumn.HeaderText = "A_To";
            this.aToDataGridViewTextBoxColumn.Name = "aToDataGridViewTextBoxColumn";
            this.aToDataGridViewTextBoxColumn.Width = 68;
            // 
            // fareDataGridViewTextBoxColumn
            // 
            this.fareDataGridViewTextBoxColumn.DataPropertyName = "Fare";
            this.fareDataGridViewTextBoxColumn.FillWeight = 102.1105F;
            this.fareDataGridViewTextBoxColumn.HeaderText = "Fare";
            this.fareDataGridViewTextBoxColumn.Name = "fareDataGridViewTextBoxColumn";
            this.fareDataGridViewTextBoxColumn.Width = 63;
            // 
            // arrivalDateDataGridViewTextBoxColumn
            // 
            this.arrivalDateDataGridViewTextBoxColumn.DataPropertyName = "Arrival_Date";
            this.arrivalDateDataGridViewTextBoxColumn.FillWeight = 104.4555F;
            this.arrivalDateDataGridViewTextBoxColumn.HeaderText = "Arrival_Date";
            this.arrivalDateDataGridViewTextBoxColumn.Name = "arrivalDateDataGridViewTextBoxColumn";
            this.arrivalDateDataGridViewTextBoxColumn.Width = 112;
            // 
            // seatsDataGridViewTextBoxColumn
            // 
            this.seatsDataGridViewTextBoxColumn.DataPropertyName = "Seats";
            this.seatsDataGridViewTextBoxColumn.FillWeight = 106.5386F;
            this.seatsDataGridViewTextBoxColumn.HeaderText = "Seats";
            this.seatsDataGridViewTextBoxColumn.Name = "seatsDataGridViewTextBoxColumn";
            this.seatsDataGridViewTextBoxColumn.Width = 71;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.FillWeight = 108.3889F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 67;
            // 
            // tblFlightBindingSource
            // 
            this.tblFlightBindingSource.DataMember = "TblFlight";
            this.tblFlightBindingSource.DataSource = this.login_DatabaseDataSet6;
            // 
            // login_DatabaseDataSet6
            // 
            this.login_DatabaseDataSet6.DataSetName = "Login_DatabaseDataSet6";
            this.login_DatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFlightTableAdapter
            // 
            this.tblFlightTableAdapter.ClearBeforeFill = true;
            // 
            // seats
            // 
            this.seats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seats.Location = new System.Drawing.Point(717, 271);
            this.seats.Name = "seats";
            this.seats.Size = new System.Drawing.Size(170, 29);
            this.seats.TabIndex = 65;
            // 
            // View_Scheduled_Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 749);
            this.Controls.Add(this.seats);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.faretb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pricetb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.destcb);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.sourcecb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Airlname);
            this.Controls.Add(this.Fid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View_Scheduled_Flights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Scheduled_Flights";
            this.Load += new System.EventHandler(this.View_Scheduled_Flights_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFlightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_DatabaseDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox destcb;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.ComboBox sourcecb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Airlname;
        private System.Windows.Forms.TextBox Fid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.TextBox pricetb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox faretb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Login_DatabaseDataSet6 login_DatabaseDataSet6;
        private System.Windows.Forms.BindingSource tblFlightBindingSource;
        private Login_DatabaseDataSet6TableAdapters.TblFlightTableAdapter tblFlightTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airlineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox seats;
        private System.Windows.Forms.Label ExitBtn;
    }
}