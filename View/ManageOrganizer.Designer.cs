namespace EventManagmentSystem.View
{
    partial class ManageOrganizer
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView_organizer = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            organizer_id = new TextBox();
            organizer_name = new TextBox();
            organizer_phone_no = new TextBox();
            remove_organizer = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_organizer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView_organizer);
            panel1.Location = new Point(20, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 782);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 48);
            label1.Name = "label1";
            label1.Size = new Size(243, 52);
            label1.TabIndex = 1;
            label1.Text = "Organizers";
            // 
            // dataGridView_organizer
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_organizer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_organizer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = Color.YellowGreen;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView_organizer.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_organizer.Location = new Point(0, 152);
            dataGridView_organizer.Name = "dataGridView_organizer";
            dataGridView_organizer.RowHeadersWidth = 82;
            dataGridView_organizer.Size = new Size(666, 300);
            dataGridView_organizer.TabIndex = 0;
            dataGridView_organizer.CellClick += dataGridView_organizer_CellClick;
            dataGridView_organizer.CellContentClick += dataGridView_organizer_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(765, 501);
            label2.Name = "label2";
            label2.Size = new Size(359, 33);
            label2.TabIndex = 2;
            label2.Text = "Organizer Phone Number :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(765, 351);
            label3.Name = "label3";
            label3.Size = new Size(265, 33);
            label3.TabIndex = 3;
            label3.Text = "Organizer's Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(765, 220);
            label4.Name = "label4";
            label4.Size = new Size(195, 33);
            label4.TabIndex = 4;
            label4.Text = "Organizer ID :";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(741, 56);
            label5.Name = "label5";
            label5.Size = new Size(590, 118);
            label5.TabIndex = 5;
            label5.Text = "Please click a row in the table to view organizer information ";
            label5.Click += label5_Click;
            // 
            // organizer_id
            // 
            organizer_id.BackColor = SystemColors.ButtonHighlight;
            organizer_id.Location = new Point(765, 266);
            organizer_id.Name = "organizer_id";
            organizer_id.ReadOnly = true;
            organizer_id.Size = new Size(469, 39);
            organizer_id.TabIndex = 6;
            // 
            // organizer_name
            // 
            organizer_name.BackColor = SystemColors.ButtonHighlight;
            organizer_name.Location = new Point(765, 401);
            organizer_name.Name = "organizer_name";
            organizer_name.ReadOnly = true;
            organizer_name.Size = new Size(469, 39);
            organizer_name.TabIndex = 7;
            organizer_name.TextChanged += textBox2_TextChanged;
            // 
            // organizer_phone_no
            // 
            organizer_phone_no.BackColor = SystemColors.ButtonHighlight;
            organizer_phone_no.Location = new Point(765, 549);
            organizer_phone_no.Name = "organizer_phone_no";
            organizer_phone_no.ReadOnly = true;
            organizer_phone_no.Size = new Size(469, 39);
            organizer_phone_no.TabIndex = 8;
            // 
            // remove_organizer
            // 
            remove_organizer.BackColor = Color.Firebrick;
            remove_organizer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remove_organizer.ForeColor = SystemColors.ButtonHighlight;
            remove_organizer.Location = new Point(1062, 632);
            remove_organizer.Name = "remove_organizer";
            remove_organizer.Size = new Size(172, 64);
            remove_organizer.TabIndex = 9;
            remove_organizer.Text = "Remove";
            remove_organizer.UseVisualStyleBackColor = false;
            remove_organizer.Click += remove_organizer_Click;
            // 
            // ManageOrganizer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            Controls.Add(remove_organizer);
            Controls.Add(organizer_phone_no);
            Controls.Add(organizer_name);
            Controls.Add(organizer_id);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "ManageOrganizer";
            Size = new Size(1330, 826);
            Load += ManageOrganizer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_organizer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView_organizer;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox organizer_id;
        private TextBox organizer_name;
        private TextBox organizer_phone_no;
        private Button remove_organizer;
    }
}
