namespace EventManagmentSystem.View
{
    partial class EventsParticipants
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView_events = new DataGridView();
            EventName = new Label();
            add = new Button();
            clear = new Button();
            textEventID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_events).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_events
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new Font("Arial Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.YellowGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_events.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_events.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_events.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_events.Location = new Point(0, 0);
            dataGridView_events.Name = "dataGridView_events";
            dataGridView_events.RowHeadersWidth = 82;
            dataGridView_events.Size = new Size(1294, 386);
            dataGridView_events.TabIndex = 1;
            dataGridView_events.CellClick += dataGridView_events_CellClick;
            dataGridView_events.CellContentClick += dataGridView_events_CellContentClick;
            // 
            // EventName
            // 
            EventName.BackColor = Color.Transparent;
            EventName.Font = new Font("Arial Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EventName.ForeColor = SystemColors.ActiveCaptionText;
            EventName.Location = new Point(14, 504);
            EventName.Name = "EventName";
            EventName.Size = new Size(679, 120);
            EventName.TabIndex = 6;
            EventName.Text = "To register for an event,Please slsect an event from the above table :";
            // 
            // add
            // 
            add.BackColor = Color.YellowGreen;
            add.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.ForeColor = SystemColors.ButtonHighlight;
            add.Location = new Point(827, 540);
            add.Name = "add";
            add.Size = new Size(342, 84);
            add.TabIndex = 24;
            add.Text = "Book Now ";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // clear
            // 
            clear.BackColor = SystemColors.ControlDarkDark;
            clear.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear.ForeColor = SystemColors.ButtonHighlight;
            clear.Location = new Point(1418, 769);
            clear.Name = "clear";
            clear.Size = new Size(10, 13);
            clear.TabIndex = 25;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // textEventID
            // 
            textEventID.BackColor = SystemColors.Window;
            textEventID.Location = new Point(446, 547);
            textEventID.Name = "textEventID";
            textEventID.ReadOnly = true;
            textEventID.Size = new Size(172, 39);
            textEventID.TabIndex = 26;
            // 
            // EventsParticipants
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            Controls.Add(textEventID);
            Controls.Add(clear);
            Controls.Add(add);
            Controls.Add(EventName);
            Controls.Add(dataGridView_events);
            Name = "EventsParticipants";
            Size = new Size(1428, 762);
            Load += EventsParticipants_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_events).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_events;
        private Label EventName;
        private Button add;
        private Button clear;
        private TextBox textEventID;
    }
}
