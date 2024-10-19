namespace EventManagmentSystem.View
{
    partial class ManageBookings
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
            dataGridView_book = new DataGridView();
            cancel_booking = new Button();
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_book).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_book
            // 
            dataGridView_book.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_book.Location = new Point(218, 106);
            dataGridView_book.Name = "dataGridView_book";
            dataGridView_book.RowHeadersWidth = 82;
            dataGridView_book.Size = new Size(886, 466);
            dataGridView_book.TabIndex = 0;
            dataGridView_book.CellContentClick += dataGridView_book_CellContentClick;
            // 
            // cancel_booking
            // 
            cancel_booking.BackColor = Color.Firebrick;
            cancel_booking.Font = new Font("Arial Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel_booking.ForeColor = SystemColors.ButtonHighlight;
            cancel_booking.Location = new Point(46, 716);
            cancel_booking.Name = "cancel_booking";
            cancel_booking.Size = new Size(333, 64);
            cancel_booking.TabIndex = 4;
            cancel_booking.Text = "Cancel Booking";
            cancel_booking.UseVisualStyleBackColor = false;
            cancel_booking.Click += cancel_booking_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(46, 614);
            label1.Name = "label1";
            label1.Size = new Size(897, 33);
            label1.TabIndex = 5;
            label1.Text = "Select a booked event from the above table to cancle any bookings";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(519, 24);
            label4.Name = "label4";
            label4.Size = new Size(243, 60);
            label4.TabIndex = 8;
            label4.Text = "Bookings";
            // 
            // ManageBookings
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(cancel_booking);
            Controls.Add(dataGridView_book);
            Name = "ManageBookings";
            Size = new Size(1380, 878);
            Load += ManageBookings_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_book).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_book;
        private Button cancel_booking;
        private Label label1;
        private Label label4;
    }
}
