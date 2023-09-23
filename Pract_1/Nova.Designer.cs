namespace Pract_1
{
    partial class Nova
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ImageBox = new PictureBox();
            text1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            PanelButton = new FlowLayoutPanel();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            textPerson = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            PanelButton.SuspendLayout();
            SuspendLayout();
            // 
            // ImageBox
            // 
            ImageBox.BackColor = Color.Transparent;
            ImageBox.Location = new Point(1, 1);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(1505, 862);
            ImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            ImageBox.TabIndex = 0;
            ImageBox.TabStop = false;
            ImageBox.Click += pictureBox1_Click;
            // 
            // text1
            // 
            text1.BackColor = Color.Transparent;
            text1.Dock = DockStyle.Fill;
            text1.Font = new Font("Franklin Gothic Book", 18F, FontStyle.Regular, GraphicsUnit.Point);
            text1.ForeColor = Color.White;
            text1.Location = new Point(103, 0);
            text1.Name = "text1";
            text1.Size = new Size(800, 170);
            text1.TabIndex = 1;
            text1.TextAlign = ContentAlignment.MiddleCenter;
            text1.Click += text1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(PanelButton, 0, 0);
            tableLayoutPanel1.Controls.Add(text1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 656);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.92683F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.0731716F));
            tableLayoutPanel1.Size = new Size(1008, 205);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // PanelButton
            // 
            PanelButton.BackColor = Color.Transparent;
            PanelButton.Controls.Add(btn1);
            PanelButton.Controls.Add(btn2);
            PanelButton.Controls.Add(btn3);
            PanelButton.Location = new Point(3, 3);
            PanelButton.Name = "PanelButton";
            PanelButton.Size = new Size(92, 164);
            PanelButton.TabIndex = 2;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Black;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(3, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(90, 40);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Visible = false;
            btn1.Click += btn_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Black;
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(3, 49);
            btn2.Name = "btn2";
            btn2.Size = new Size(90, 40);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Visible = false;
            btn2.Click += btn_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Black;
            btn3.FlatStyle = FlatStyle.Popup;
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(3, 95);
            btn3.Name = "btn3";
            btn3.Size = new Size(90, 40);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Visible = false;
            btn3.Click += btn_Click;
            // 
            // textPerson
            // 
            textPerson.BackColor = Color.Transparent;
            textPerson.ForeColor = Color.White;
            textPerson.Location = new Point(113, 588);
            textPerson.Name = "textPerson";
            textPerson.Size = new Size(287, 53);
            textPerson.TabIndex = 3;
            textPerson.TextAlign = ContentAlignment.TopCenter;
            // 
            // Nova
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1008, 861);
            Controls.Add(textPerson);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(ImageBox);
            Name = "Nova";
            Text = "Novela";
            Load += Nova_Load;
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            PanelButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ImageBox;
        private Label text1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel PanelButton;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Label textPerson;
        private System.Windows.Forms.Timer timer1;
    }
}