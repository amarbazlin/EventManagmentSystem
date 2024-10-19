namespace EventManagmentSystem.View
{
    partial class ManageParticipants
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
            panel1 = new Panel();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            participant_id = new TextBox();
            participant_name = new TextBox();
            participant_phone_no = new TextBox();
            remove_participant = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(18, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 784);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(169, 34);
            label5.Name = "label5";
            label5.Size = new Size(525, 78);
            label5.TabIndex = 9;
            label5.Text = "Participants";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(0, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(676, 309);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(792, 186);
            label1.Name = "label1";
            label1.Size = new Size(214, 33);
            label1.TabIndex = 1;
            label1.Text = "Participant ID :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(792, 339);
            label2.Name = "label2";
            label2.Size = new Size(262, 33);
            label2.TabIndex = 2;
            label2.Text = "Participant Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(792, 489);
            label3.Name = "label3";
            label3.Size = new Size(378, 33);
            label3.TabIndex = 3;
            label3.Text = "Participant Phone Number :";
            // 
            // participant_id
            // 
            participant_id.BackColor = SystemColors.ButtonHighlight;
            participant_id.Location = new Point(828, 238);
            participant_id.Name = "participant_id";
            participant_id.ReadOnly = true;
            participant_id.Size = new Size(436, 39);
            participant_id.TabIndex = 4;
            // 
            // participant_name
            // 
            participant_name.BackColor = SystemColors.ButtonHighlight;
            participant_name.Location = new Point(828, 381);
            participant_name.Name = "participant_name";
            participant_name.ReadOnly = true;
            participant_name.Size = new Size(436, 39);
            participant_name.TabIndex = 5;
            // 
            // participant_phone_no
            // 
            participant_phone_no.BackColor = SystemColors.ButtonHighlight;
            participant_phone_no.Location = new Point(828, 533);
            participant_phone_no.Name = "participant_phone_no";
            participant_phone_no.ReadOnly = true;
            participant_phone_no.Size = new Size(436, 39);
            participant_phone_no.TabIndex = 6;
            // 
            // remove_participant
            // 
            remove_participant.BackColor = Color.Firebrick;
            remove_participant.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remove_participant.ForeColor = SystemColors.ButtonHighlight;
            remove_participant.Location = new Point(1090, 606);
            remove_participant.Name = "remove_participant";
            remove_participant.Size = new Size(174, 68);
            remove_participant.TabIndex = 7;
            remove_participant.Text = "Remove";
            remove_participant.UseVisualStyleBackColor = false;
            remove_participant.Click += remove_participant_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(739, 40);
            label4.Name = "label4";
            label4.Size = new Size(602, 116);
            label4.TabIndex = 8;
            label4.Text = "Please click a row in the tale to view participant information ";
            // 
            // ManageParticipants
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            Controls.Add(label4);
            Controls.Add(remove_participant);
            Controls.Add(participant_phone_no);
            Controls.Add(participant_name);
            Controls.Add(participant_id);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ManageParticipants";
            Size = new Size(1344, 872);
            Load += ManageParticipants_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox participant_id;
        private TextBox participant_name;
        private TextBox participant_phone_no;
        private Button remove_participant;
        private Label label4;
        private Label label5;
    }
}
