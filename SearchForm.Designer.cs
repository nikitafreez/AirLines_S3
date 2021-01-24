namespace AirLines_S3
{
    partial class SearchForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutboundsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FromComboBox = new System.Windows.Forms.ComboBox();
            this.ToComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReturnRadio = new System.Windows.Forms.RadioButton();
            this.OneWayRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.OutbondDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ReturnDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteFromButton = new System.Windows.Forms.Button();
            this.DeleteToButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CheckDateBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReturnGridView = new System.Windows.Forms.DataGridView();
            this.BookFlightButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OutboundsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OutboundsGridView
            // 
            this.OutboundsGridView.AllowUserToAddRows = false;
            this.OutboundsGridView.AllowUserToDeleteRows = false;
            this.OutboundsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutboundsGridView.Location = new System.Drawing.Point(15, 131);
            this.OutboundsGridView.MultiSelect = false;
            this.OutboundsGridView.Name = "OutboundsGridView";
            this.OutboundsGridView.ReadOnly = true;
            this.OutboundsGridView.RowHeadersWidth = 51;
            this.OutboundsGridView.RowTemplate.Height = 24;
            this.OutboundsGridView.Size = new System.Drawing.Size(776, 271);
            this.OutboundsGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // FromComboBox
            // 
            this.FromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromComboBox.FormattingEnabled = true;
            this.FromComboBox.Location = new System.Drawing.Point(58, 6);
            this.FromComboBox.Name = "FromComboBox";
            this.FromComboBox.Size = new System.Drawing.Size(122, 24);
            this.FromComboBox.TabIndex = 3;
            // 
            // ToComboBox
            // 
            this.ToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToComboBox.FormattingEnabled = true;
            this.ToComboBox.Location = new System.Drawing.Point(294, 6);
            this.ToComboBox.Name = "ToComboBox";
            this.ToComboBox.Size = new System.Drawing.Size(122, 24);
            this.ToComboBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // ReturnRadio
            // 
            this.ReturnRadio.AutoSize = true;
            this.ReturnRadio.Location = new System.Drawing.Point(15, 44);
            this.ReturnRadio.Name = "ReturnRadio";
            this.ReturnRadio.Size = new System.Drawing.Size(72, 21);
            this.ReturnRadio.TabIndex = 6;
            this.ReturnRadio.Text = "Return";
            this.ReturnRadio.UseVisualStyleBackColor = true;
            this.ReturnRadio.CheckedChanged += new System.EventHandler(this.ReturnRadio_CheckedChanged);
            // 
            // OneWayRadio
            // 
            this.OneWayRadio.AutoSize = true;
            this.OneWayRadio.Checked = true;
            this.OneWayRadio.Location = new System.Drawing.Point(115, 44);
            this.OneWayRadio.Name = "OneWayRadio";
            this.OneWayRadio.Size = new System.Drawing.Size(84, 21);
            this.OneWayRadio.TabIndex = 7;
            this.OneWayRadio.TabStop = true;
            this.OneWayRadio.Text = "One way";
            this.OneWayRadio.UseVisualStyleBackColor = true;
            this.OneWayRadio.CheckedChanged += new System.EventHandler(this.OneWayRadio_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Outbound";
            // 
            // OutbondDatePicker
            // 
            this.OutbondDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.OutbondDatePicker.Location = new System.Drawing.Point(312, 43);
            this.OutbondDatePicker.Name = "OutbondDatePicker";
            this.OutbondDatePicker.Size = new System.Drawing.Size(107, 22);
            this.OutbondDatePicker.TabIndex = 9;
            this.OutbondDatePicker.Value = new System.DateTime(2017, 10, 4, 16, 50, 0, 0);
            // 
            // ReturnDatePicker
            // 
            this.ReturnDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnDatePicker.Location = new System.Drawing.Point(515, 43);
            this.ReturnDatePicker.Name = "ReturnDatePicker";
            this.ReturnDatePicker.Size = new System.Drawing.Size(107, 22);
            this.ReturnDatePicker.TabIndex = 11;
            this.ReturnDatePicker.Value = new System.DateTime(2017, 10, 12, 16, 50, 0, 0);
            this.ReturnDatePicker.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Return";
            this.label4.Visible = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(593, 81);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(96, 37);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Outbound flight details:\r\n";
            // 
            // DeleteFromButton
            // 
            this.DeleteFromButton.Location = new System.Drawing.Point(186, 6);
            this.DeleteFromButton.Name = "DeleteFromButton";
            this.DeleteFromButton.Size = new System.Drawing.Size(24, 24);
            this.DeleteFromButton.TabIndex = 14;
            this.DeleteFromButton.Text = "X";
            this.DeleteFromButton.UseVisualStyleBackColor = true;
            this.DeleteFromButton.Click += new System.EventHandler(this.DeleteFromButton_Click);
            // 
            // DeleteToButton
            // 
            this.DeleteToButton.Location = new System.Drawing.Point(422, 6);
            this.DeleteToButton.Name = "DeleteToButton";
            this.DeleteToButton.Size = new System.Drawing.Size(24, 24);
            this.DeleteToButton.TabIndex = 15;
            this.DeleteToButton.Text = "X";
            this.DeleteToButton.UseVisualStyleBackColor = true;
            this.DeleteToButton.Click += new System.EventHandler(this.DeleteToButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(695, 81);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(96, 37);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "All Routs";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CheckDateBox
            // 
            this.CheckDateBox.AutoSize = true;
            this.CheckDateBox.Location = new System.Drawing.Point(312, 72);
            this.CheckDateBox.Name = "CheckDateBox";
            this.CheckDateBox.Size = new System.Drawing.Size(129, 21);
            this.CheckDateBox.TabIndex = 17;
            this.CheckDateBox.Text = "Check with date";
            this.CheckDateBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Return flight details:\r\n";
            this.label6.Visible = false;
            // 
            // ReturnGridView
            // 
            this.ReturnGridView.AllowUserToAddRows = false;
            this.ReturnGridView.AllowUserToDeleteRows = false;
            this.ReturnGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnGridView.Location = new System.Drawing.Point(15, 458);
            this.ReturnGridView.MultiSelect = false;
            this.ReturnGridView.Name = "ReturnGridView";
            this.ReturnGridView.ReadOnly = true;
            this.ReturnGridView.RowHeadersWidth = 51;
            this.ReturnGridView.RowTemplate.Height = 24;
            this.ReturnGridView.Size = new System.Drawing.Size(776, 271);
            this.ReturnGridView.TabIndex = 18;
            this.ReturnGridView.Visible = false;
            // 
            // BookFlightButton
            // 
            this.BookFlightButton.Location = new System.Drawing.Point(312, 781);
            this.BookFlightButton.Name = "BookFlightButton";
            this.BookFlightButton.Size = new System.Drawing.Size(169, 37);
            this.BookFlightButton.TabIndex = 20;
            this.BookFlightButton.Text = "Book Flight";
            this.BookFlightButton.UseVisualStyleBackColor = true;
            this.BookFlightButton.Click += new System.EventHandler(this.BookFlightButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(714, 791);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(77, 37);
            this.ExitButton.TabIndex = 21;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 840);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BookFlightButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ReturnGridView);
            this.Controls.Add(this.CheckDateBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteToButton);
            this.Controls.Add(this.DeleteFromButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ReturnDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OutbondDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OneWayRadio);
            this.Controls.Add(this.ReturnRadio);
            this.Controls.Add(this.ToComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FromComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutboundsGridView);
            this.Name = "SearchForm";
            this.Text = "Search for flights";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OutboundsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OutboundsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FromComboBox;
        private System.Windows.Forms.ComboBox ToComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ReturnRadio;
        private System.Windows.Forms.RadioButton OneWayRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker OutbondDatePicker;
        private System.Windows.Forms.DateTimePicker ReturnDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DeleteFromButton;
        private System.Windows.Forms.Button DeleteToButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.CheckBox CheckDateBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ReturnGridView;
        private System.Windows.Forms.Button BookFlightButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

