namespace Pract_1.Components
{
    partial class Menu
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            title = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            Setting1 = new Label();
            Setting2 = new Label();
            Setting3 = new Label();
            ButtonRight = new Label();
            ButtonLeft = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = Color.Transparent;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(540, 444);
            btn1.Margin = new Padding(3, 5, 3, 5);
            btn1.Name = "btn1";
            btn1.Size = new Size(450, 90);
            btn1.TabIndex = 0;
            btn1.Text = "Старт";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += startButton_Click;
            btn1.MouseLeave += UserSelect_MouseLeave;
            btn1.MouseMove += btn1_MouseMove;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Transparent;
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(540, 544);
            btn2.Margin = new Padding(3, 5, 3, 5);
            btn2.Name = "btn2";
            btn2.Size = new Size(450, 90);
            btn2.TabIndex = 1;
            btn2.Text = "Настройки";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += settingButton_Click;
            btn2.MouseLeave += UserSelect_MouseLeave;
            btn2.MouseMove += btn2_MouseMove;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Transparent;
            btn3.FlatStyle = FlatStyle.Popup;
            btn3.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(540, 644);
            btn3.Margin = new Padding(3, 5, 3, 5);
            btn3.Name = "btn3";
            btn3.Size = new Size(450, 90);
            btn3.TabIndex = 2;
            btn3.Text = "Выход";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += exitButton_Click;
            btn3.MouseLeave += UserSelect_MouseLeave;
            btn3.MouseMove += btn3_MouseMove;
            // 
            // title
            // 
            title.BackColor = Color.Transparent;
            title.Font = new Font("Jokerman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            title.ForeColor = Color.White;
            title.Location = new Point(68, 169);
            title.Name = "title";
            title.Size = new Size(639, 113);
            title.TabIndex = 4;
            title.Text = "Пока не придумал";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.81663F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.1833744F));
            tableLayoutPanel1.Controls.Add(Setting1, 0, 0);
            tableLayoutPanel1.Controls.Add(Setting2, 0, 1);
            tableLayoutPanel1.Controls.Add(Setting3, 0, 2);
            tableLayoutPanel1.Controls.Add(ButtonRight, 1, 1);
            tableLayoutPanel1.Controls.Add(ButtonLeft, 1, 2);
            tableLayoutPanel1.Location = new Point(68, 444);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(409, 290);
            tableLayoutPanel1.TabIndex = 5;
            tableLayoutPanel1.Visible = false;
            // 
            // Setting1
            // 
            Setting1.Dock = DockStyle.Fill;
            Setting1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Setting1.ForeColor = Color.White;
            Setting1.Location = new Point(3, 0);
            Setting1.Name = "Setting1";
            Setting1.Size = new Size(300, 72);
            Setting1.TabIndex = 4;
            Setting1.Text = "Управление";
            Setting1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Setting2
            // 
            Setting2.Dock = DockStyle.Fill;
            Setting2.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Setting2.ForeColor = Color.White;
            Setting2.Location = new Point(3, 72);
            Setting2.Name = "Setting2";
            Setting2.Size = new Size(300, 72);
            Setting2.TabIndex = 0;
            Setting2.Text = "Вправо";
            Setting2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Setting3
            // 
            Setting3.Dock = DockStyle.Fill;
            Setting3.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Setting3.ForeColor = Color.White;
            Setting3.Location = new Point(3, 144);
            Setting3.Name = "Setting3";
            Setting3.Size = new Size(300, 72);
            Setting3.TabIndex = 1;
            Setting3.Text = "Влево";
            Setting3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonRight
            // 
            ButtonRight.AutoSize = true;
            ButtonRight.Dock = DockStyle.Fill;
            ButtonRight.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonRight.ForeColor = Color.White;
            ButtonRight.Location = new Point(309, 72);
            ButtonRight.Name = "ButtonRight";
            ButtonRight.Size = new Size(97, 72);
            ButtonRight.TabIndex = 2;
            ButtonRight.Text = "-->";
            ButtonRight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonLeft
            // 
            ButtonLeft.AutoSize = true;
            ButtonLeft.Dock = DockStyle.Fill;
            ButtonLeft.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonLeft.ForeColor = Color.White;
            ButtonLeft.Location = new Point(309, 144);
            ButtonLeft.Name = "ButtonLeft";
            ButtonLeft.Size = new Size(97, 72);
            ButtonLeft.TabIndex = 3;
            ButtonLeft.Text = "<--";
            ButtonLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(title);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Menu";
            Size = new Size(1008, 884);
            Load += Menu_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Label title;
        private TableLayoutPanel tableLayoutPanel1;
        private Label Setting2;
        private Label Setting3;
        private Label ButtonRight;
        private Label ButtonLeft;
        private Label Setting1;
    }
}
