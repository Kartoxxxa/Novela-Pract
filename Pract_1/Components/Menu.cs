using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract_1.Components
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        public event EventHandler StartClicked;
        public event EventHandler ExitClicked;

        public void startButton_Click(object sender, EventArgs e)
        {
            // При нажатии кнопки "Старт", вызываем событие StartClicked
            StartClicked?.Invoke(this, EventArgs.Empty);
        }

        public void exitButton_Click(object sender, EventArgs e)
        {
            // При нажатии кнопки "Выйти", вызываем событие ExitClicked
            ExitClicked?.Invoke(this, EventArgs.Empty);
        }

        public void settingButton_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "Настройки")
            {
                tableLayoutPanel1.Visible = !tableLayoutPanel1.Visible;
            }

        }



        private void Menu_Load(object sender, EventArgs e)
        {

            title.Font = new Font("Georgia", 36, FontStyle.Regular);
            title.ForeColor = Color.White;
            title.TextAlign = ContentAlignment.MiddleCenter;
            this.BackgroundImage = Properties.Resources.Туман;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.Visible = false;


        }

        private void UserSelect_MouseLeave(object sender, EventArgs e)
        {
            if (btn1.Text == "Старт" || btn2.Text == "Настройки" || btn3.Text == "Выход")
                btn1.BackColor = Color.Transparent;
            btn2.BackColor = Color.Transparent;
            btn3.BackColor = Color.Transparent;
            btn3.Text = "Выход";
            btn3.ForeColor = Color.White;
        }

        private void btn1_MouseMove(object sender, MouseEventArgs e)
        {
            if (btn1.Text == "Старт")
                btn1.BackColor = Color.Silver;
        }

        private void btn2_MouseMove(object sender, MouseEventArgs e)
        {
            if (btn2.Text == "Настройки")
                btn2.BackColor = Color.Silver;
        }

        private void btn3_MouseMove(object sender, MouseEventArgs e)
        {
            if (btn3.Text == "Выход")
                btn3.Text = "Really??";
            btn3.ForeColor = Color.DarkRed;
            btn3.BackColor = Color.Black;
        }
    }
}
