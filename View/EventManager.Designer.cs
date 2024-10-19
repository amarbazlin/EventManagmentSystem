namespace EventManagmentSystem.View
{
    partial class EventManager
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
            add = new Button();
            edit = new Button();
            delete = new Button();
            clear = new Button();
            EventName = new Label();
            Description = new Label();
            Venue = new Label();
            MaxParticipants = new Label();
            OrganizerID = new Label();
            EventDate = new Label();
            OrganizerName = new Label();
            textEventName = new TextBox();
            textDescription = new TextBox();
            textVenue = new TextBox();
            textMaxParticipants = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textOID = new ComboBox();
            eventID = new TextBox();
            textOrganizerID = new TextBox();
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
            dataGridView_events.Size = new Size(1364, 386);
            dataGridView_events.TabIndex = 0;
            dataGridView_events.CellClick += dataGridView_events_CellClick;
            dataGridView_events.CellContentClick += dataGridView_events_CellContentClick_1;
            dataGridView_events.Click += dataGridView_events_Click;
            // 
            // add
            // 
            add.BackColor = Color.YellowGreen;
            add.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.ForeColor = SystemColors.ButtonHighlight;
            add.Location = new Point(836, 502);
            add.Name = "add";
            add.Size = new Size(218, 84);
            add.TabIndex = 1;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // edit
            // 
            edit.BackColor = Color.YellowGreen;
            edit.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit.ForeColor = SystemColors.ButtonHighlight;
            edit.Location = new Point(1094, 502);
            edit.Name = "edit";
            edit.Size = new Size(222, 84);
            edit.TabIndex = 2;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = false;
            edit.Click += edit_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Firebrick;
            delete.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete.ForeColor = SystemColors.ButtonHighlight;
            delete.Location = new Point(836, 654);
            delete.Name = "delete";
            delete.Size = new Size(218, 85);
            delete.TabIndex = 3;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // clear
            // 
            clear.BackColor = SystemColors.ControlDarkDark;
            clear.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear.ForeColor = SystemColors.ButtonHighlight;
            clear.Location = new Point(1094, 654);
            clear.Name = "clear";
            clear.Size = new Size(222, 85);
            clear.TabIndex = 4;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // EventName
            // 
            EventName.AutoSize = true;
            EventName.BackColor = Color.Transparent;
            EventName.Font = new Font("Arial Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EventName.ForeColor = SystemColors.ActiveCaptionText;
            EventName.Location = new Point(24, 426);
            EventName.Name = "EventName";
            EventName.Size = new Size(213, 38);
            EventName.TabIndex = 5;
            EventName.Text = "Event Name :";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.BackColor = Color.Transparent;
            Description.Font = new Font("Arial Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Description.ForeColor = SystemColors.ActiveCaptionText;
            Description.Location = new Point(24, 564);
            Description.Name = "Description";
            Description.Size = new Size(205, 38);
            Description.TabIndex = 6;
            Description.Text = "Description :";
            // 
            // Venue
            // 
            Venue.AutoSize = true;
            Venue.BackColor = Color.Transparent;
            Venue.Font = new Font("Arial Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Venue.ForeColor = SystemColors.ActiveCaptionText;
            Venue.Location = new Point(24, 707);
            Venue.Name = "Venue";
            Venue.Size = new Size(127, 38);
            Venue.TabIndex = 7;
            Venue.Text = "Venue :";
            // 
            // MaxParticipants
            // 
            MaxParticipants.AutoSize = true;
            MaxParticipants.BackColor = Color.Transparent;
            MaxParticipants.Font = new Font("Arial Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaxParticipants.ForeColor = SystemColors.ActiveCaptionText;
            MaxParticipants.Location = new Point(416, 426);
            MaxParticipants.Name = "MaxParticipants";
            MaxParticipants.Size = new Size(219, 38);
            MaxParticipants.TabIndex = 8;
            MaxParticipants.Text = "Organizer ID :";
            // 
            // OrganizerID
            // 
            OrganizerID.AutoSize = true;
            OrganizerID.BackColor = Color.Transparent;
            OrganizerID.Font = new Font("Arial Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrganizerID.ForeColor = SystemColors.ActiveCaptionText;
            OrganizerID.Location = new Point(416, 564);
            OrganizerID.Name = "OrganizerID";
            OrganizerID.Size = new Size(368, 38);
            OrganizerID.TabIndex = 9;
            OrganizerID.Text = "Maximum Participants :";
            // 
            // EventDate
            // 
            EventDate.AutoSize = true;
            EventDate.BackColor = Color.Transparent;
            EventDate.Font = new Font("Arial Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EventDate.ForeColor = SystemColors.ActiveCaptionText;
            EventDate.Location = new Point(416, 707);
            EventDate.Name = "EventDate";
            EventDate.Size = new Size(197, 38);
            EventDate.TabIndex = 10;
            EventDate.Text = "Event Date :";
            // 
            // OrganizerName
            // 
            OrganizerName.AutoSize = true;
            OrganizerName.Location = new Point(746, 419);
            OrganizerName.Name = "OrganizerName";
            OrganizerName.Size = new Size(0, 32);
            OrganizerName.TabIndex = 11;
            // 
            // textEventName
            // 
            textEventName.BackColor = SystemColors.Window;
            textEventName.ForeColor = SystemColors.WindowText;
            textEventName.Location = new Point(36, 483);
            textEventName.Name = "textEventName";
            textEventName.Size = new Size(314, 39);
            textEventName.TabIndex = 12;
            // 
            // textDescription
            // 
            textDescription.BackColor = SystemColors.Window;
            textDescription.Location = new Point(36, 620);
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(314, 39);
            textDescription.TabIndex = 13;
            // 
            // textVenue
            // 
            textVenue.BackColor = SystemColors.Window;
            textVenue.Location = new Point(36, 758);
            textVenue.Name = "textVenue";
            textVenue.Size = new Size(314, 39);
            textVenue.TabIndex = 14;
            // 
            // textMaxParticipants
            // 
            textMaxParticipants.BackColor = SystemColors.Window;
            textMaxParticipants.Location = new Point(416, 620);
            textMaxParticipants.Name = "textMaxParticipants";
            textMaxParticipants.Size = new Size(384, 39);
            textMaxParticipants.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.CalendarMonthBackground = Color.LemonChiffon;
            dateTimePicker1.CalendarTitleBackColor = Color.PaleTurquoise;
            dateTimePicker1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(416, 758);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(404, 35);
            dateTimePicker1.TabIndex = 17;
            // 
            // textOID
            // 
            textOID.BackColor = SystemColors.Window;
            textOID.FormattingEnabled = true;
            textOID.Location = new Point(1444, 427);
            textOID.Name = "textOID";
            textOID.Size = new Size(34, 40);
            textOID.TabIndex = 18;
            textOID.SelectedIndexChanged += textOID_SelectedIndexChanged;
            // 
            // eventID
            // 
            eventID.Location = new Point(1574, 454);
            eventID.Name = "eventID";
            eventID.Size = new Size(46, 39);
            eventID.TabIndex = 19;
            // 
            // textOrganizerID
            // 
            textOrganizerID.BackColor = SystemColors.Window;
            textOrganizerID.Location = new Point(416, 483);
            textOrganizerID.Name = "textOrganizerID";
            textOrganizerID.Size = new Size(384, 39);
            textOrganizerID.TabIndex = 20;
            textOrganizerID.TextChanged += textOrganizerID_TextChanged;
            // 
            // EventManager
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            Controls.Add(textOrganizerID);
            Controls.Add(eventID);
            Controls.Add(textOID);
            Controls.Add(dateTimePicker1);
            Controls.Add(textMaxParticipants);
            Controls.Add(textVenue);
            Controls.Add(textDescription);
            Controls.Add(textEventName);
            Controls.Add(OrganizerName);
            Controls.Add(EventDate);
            Controls.Add(OrganizerID);
            Controls.Add(MaxParticipants);
            Controls.Add(Venue);
            Controls.Add(Description);
            Controls.Add(EventName);
            Controls.Add(clear);
            Controls.Add(delete);
            Controls.Add(edit);
            Controls.Add(add);
            Controls.Add(dataGridView_events);
            Name = "EventManager";
            Size = new Size(1538, 800);
            Load += EventManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_events).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_events;
        private Button add;
        private Button edit;
        private Button delete;
        private Button clear;
        private Label EventName;
        private Label Description;
        private Label Venue;
        private Label MaxParticipants;
        private Label OrganizerID;
        private Label EventDate;
        private Label OrganizerName;
        private TextBox textEventName;
        private TextBox textDescription;
        private TextBox textVenue;
        private TextBox textMaxParticipants;
        private DateTimePicker dateTimePicker1;
        private ComboBox textOID;
        private TextBox eventID;
        private TextBox textOrganizerID;
    }
}
