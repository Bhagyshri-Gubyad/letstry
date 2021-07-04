
namespace AirlineReservationSystemCollegeProject
{
    partial class BookingHolidayPackage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Checkindate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Passidcb = new System.Windows.Forms.ComboBox();
            this.Passname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BudgetTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pidtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.BookBtn = new System.Windows.Forms.Button();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.hidcb = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holidayIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pjdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBookHolidayPackageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.login_DatabaseDataSet9 = new AirlineReservationSystemCollegeProject.Login_DatabaseDataSet9();
            this.tblBookHolidayPackageTableAdapter = new AirlineReservationSystemCollegeProject.Login_DatabaseDataSet9TableAdapters.TblBookHolidayPackageTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookHolidayPackageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_DatabaseDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.Black;
            this.ExitBtn.Location = new System.Drawing.Point(1103, 9);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(25, 24);
            this.ExitBtn.TabIndex = 34;
            this.ExitBtn.Text = "X";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 115);
            this.panel2.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(885, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(177, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(523, 59);
            this.label10.TabIndex = 0;
            this.label10.Text = "Holiday Package Booking";
            // 
            // Checkindate
            // 
            this.Checkindate.AutoSize = true;
            this.Checkindate.BackColor = System.Drawing.Color.Transparent;
            this.Checkindate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkindate.ForeColor = System.Drawing.Color.Black;
            this.Checkindate.Location = new System.Drawing.Point(486, 194);
            this.Checkindate.Name = "Checkindate";
            this.Checkindate.Size = new System.Drawing.Size(136, 24);
            this.Checkindate.TabIndex = 70;
            this.Checkindate.Text = "Date of journey";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(646, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 29);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // Passidcb
            // 
            this.Passidcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passidcb.FormattingEnabled = true;
            this.Passidcb.Location = new System.Drawing.Point(187, 245);
            this.Passidcb.Name = "Passidcb";
            this.Passidcb.Size = new System.Drawing.Size(229, 32);
            this.Passidcb.TabIndex = 68;
            this.Passidcb.Text = "   ";
            this.Passidcb.SelectionChangeCommitted += new System.EventHandler(this.Passidcb_SelectionChangeCommitted);
            // 
            // Passname
            // 
            this.Passname.BackColor = System.Drawing.Color.White;
            this.Passname.Enabled = false;
            this.Passname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passname.ForeColor = System.Drawing.Color.Black;
            this.Passname.Location = new System.Drawing.Point(646, 142);
            this.Passname.Name = "Passname";
            this.Passname.Size = new System.Drawing.Size(234, 29);
            this.Passname.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(486, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 24);
            this.label8.TabIndex = 66;
            this.label8.Text = "Passanger Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(46, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 65;
            this.label7.Text = "Passanger ID";
            // 
            // BudgetTB
            // 
            this.BudgetTB.BackColor = System.Drawing.Color.White;
            this.BudgetTB.Enabled = false;
            this.BudgetTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetTB.Location = new System.Drawing.Point(646, 245);
            this.BudgetTB.Name = "BudgetTB";
            this.BudgetTB.Size = new System.Drawing.Size(226, 29);
            this.BudgetTB.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(486, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 75;
            this.label2.Text = "Budget";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(46, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 73;
            this.label3.Text = "Holiday Id";
            // 
            // Pidtb
            // 
            this.Pidtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pidtb.Location = new System.Drawing.Point(187, 138);
            this.Pidtb.Name = "Pidtb";
            this.Pidtb.Size = new System.Drawing.Size(226, 29);
            this.Pidtb.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 77;
            this.label4.Text = "Package Id";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(617, 315);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(135, 42);
            this.BackBtn.TabIndex = 81;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // BookBtn
            // 
            this.BookBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.BookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookBtn.ForeColor = System.Drawing.Color.White;
            this.BookBtn.Location = new System.Drawing.Point(242, 315);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(135, 42);
            this.BookBtn.TabIndex = 80;
            this.BookBtn.Text = "Book";
            this.BookBtn.UseVisualStyleBackColor = false;
            this.BookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // Resetbtn
            // 
            this.Resetbtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbtn.ForeColor = System.Drawing.Color.White;
            this.Resetbtn.Location = new System.Drawing.Point(431, 315);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(135, 42);
            this.Resetbtn.TabIndex = 79;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.UseVisualStyleBackColor = false;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // hidcb
            // 
            this.hidcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidcb.FormattingEnabled = true;
            this.hidcb.Location = new System.Drawing.Point(184, 188);
            this.hidcb.Name = "hidcb";
            this.hidcb.Size = new System.Drawing.Size(229, 32);
            this.hidcb.TabIndex = 82;
            this.hidcb.Text = "   ";
            this.hidcb.SelectionChangeCommitted += new System.EventHandler(this.Hidcb_SelectionChangeCommitted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.pidDataGridViewTextBoxColumn,
            this.holidayIdDataGridViewTextBoxColumn,
            this.passIdDataGridViewTextBoxColumn,
            this.passNameDataGridViewTextBoxColumn,
            this.pjdateDataGridViewTextBoxColumn,
            this.budgetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblBookHolidayPackageBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(157, 377);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(690, 269);
            this.dataGridView1.TabIndex = 83;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "Pid";
            this.pidDataGridViewTextBoxColumn.HeaderText = "Pid";
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            this.pidDataGridViewTextBoxColumn.Width = 107;
            // 
            // holidayIdDataGridViewTextBoxColumn
            // 
            this.holidayIdDataGridViewTextBoxColumn.DataPropertyName = "holiday_Id";
            this.holidayIdDataGridViewTextBoxColumn.HeaderText = "holiday_Id";
            this.holidayIdDataGridViewTextBoxColumn.Name = "holidayIdDataGridViewTextBoxColumn";
            this.holidayIdDataGridViewTextBoxColumn.Width = 108;
            // 
            // passIdDataGridViewTextBoxColumn
            // 
            this.passIdDataGridViewTextBoxColumn.DataPropertyName = "PassId";
            this.passIdDataGridViewTextBoxColumn.HeaderText = "PassId";
            this.passIdDataGridViewTextBoxColumn.Name = "passIdDataGridViewTextBoxColumn";
            this.passIdDataGridViewTextBoxColumn.Width = 108;
            // 
            // passNameDataGridViewTextBoxColumn
            // 
            this.passNameDataGridViewTextBoxColumn.DataPropertyName = "PassName";
            this.passNameDataGridViewTextBoxColumn.HeaderText = "PassName";
            this.passNameDataGridViewTextBoxColumn.Name = "passNameDataGridViewTextBoxColumn";
            this.passNameDataGridViewTextBoxColumn.Width = 107;
            // 
            // pjdateDataGridViewTextBoxColumn
            // 
            this.pjdateDataGridViewTextBoxColumn.DataPropertyName = "Pjdate";
            this.pjdateDataGridViewTextBoxColumn.HeaderText = "Pjdate";
            this.pjdateDataGridViewTextBoxColumn.Name = "pjdateDataGridViewTextBoxColumn";
            this.pjdateDataGridViewTextBoxColumn.Width = 108;
            // 
            // budgetDataGridViewTextBoxColumn
            // 
            this.budgetDataGridViewTextBoxColumn.DataPropertyName = "Budget";
            this.budgetDataGridViewTextBoxColumn.HeaderText = "Budget";
            this.budgetDataGridViewTextBoxColumn.Name = "budgetDataGridViewTextBoxColumn";
            this.budgetDataGridViewTextBoxColumn.Width = 109;
            // 
            // tblBookHolidayPackageBindingSource
            // 
            this.tblBookHolidayPackageBindingSource.DataMember = "TblBookHolidayPackage";
            this.tblBookHolidayPackageBindingSource.DataSource = this.login_DatabaseDataSet9;
            // 
            // login_DatabaseDataSet9
            // 
            this.login_DatabaseDataSet9.DataSetName = "Login_DatabaseDataSet9";
            this.login_DatabaseDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBookHolidayPackageTableAdapter
            // 
            this.tblBookHolidayPackageTableAdapter.ClearBeforeFill = true;
            // 
            // BookingHolidayPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 710);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.hidcb);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.BookBtn);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.Pidtb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BudgetTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Checkindate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Passidcb);
            this.Controls.Add(this.Passname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookingHolidayPackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingHolidayPackage";
            this.Load += new System.EventHandler(this.BookingHolidayPackage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookHolidayPackageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_DatabaseDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Checkindate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox Passidcb;
        private System.Windows.Forms.TextBox Passname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BudgetTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pidtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button BookBtn;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.ComboBox hidcb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Login_DatabaseDataSet9 login_DatabaseDataSet9;
        private System.Windows.Forms.BindingSource tblBookHolidayPackageBindingSource;
        private Login_DatabaseDataSet9TableAdapters.TblBookHolidayPackageTableAdapter tblBookHolidayPackageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holidayIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pjdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetDataGridViewTextBoxColumn;
    }
}