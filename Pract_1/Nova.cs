
using Pract_1.Components;
using Pract_1.Models;
using System.Diagnostics.Eventing.Reader;
using System.Media;



namespace Pract_1
{
    public partial class Nova : Form
    {

        #region Переменные и инициализация

        int story = -1;
        int click;
        
        bool isPlaying = false;
        private SoundPlayer soundPlayer;

        public Nova()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer(); ;
            GlobalMenu.StartClicked += MenuControl_StartClicked;
            GlobalMenu.ExitClicked += MenuControl_ExitClicked;

        }

        #endregion

        #region Button and Click
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Right:
                    btnNext_Click(this, EventArgs.Empty);
                    return true;
                case Keys.Left:
                    btnPrevious_Click(this, EventArgs.Empty);
                    return true;
                case Keys.Escape:
                    if (story >= 2)
                    {
                        MusicFromResource();
                        GlobalMenu.Visible = true;
                        GlobalMenu.TextButtonStart = "Продолжить";
                    }
                    return true;
                case Keys.Space:
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {

            Button clickButton = (Button)sender;
            if (clickButton.Name == "btn1")
            {
                click = 1;
                TextAnimation(sender, e);
            }
            else if (clickButton.Name == "btn2")
            {
                click = 2;
                TextAnimation(sender, e);
            }
            else if (clickButton.Name == "btn3")
            {
                click = 3;
                TextAnimation(sender, e);
            }
            NeGlavStory();
            TextAnimation(sender, e);
            click = 0;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Увеличиваем значение story
            if (story == 8)
            {
                return;
            }
            else if (story == 16)
            {
                return;
            }
            story++;
            NeGlavStory();
            TextAnimation(sender, e);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // Уменьшаем значение story
            if (story == 1000 || story == 201 || story == 2)
            {
                return;
            }
            else if (story == 101)
            {
                story = 9;
            }
            else if (story == 19)
            {
                story = 17;
            }
            story--;
            NeGlavStory();
            TextAnimation(sender, e);
        }

        private void ClickBox(object sender, EventArgs e)
        {
            if (story == 8)
            {
                return;
            }
            else if (story == 16)
            {
                return;
            }
            story++;
            NeGlavStory();
            TextAnimation(sender, e);
        }

            private void MenuControl_StartClicked(object sender, EventArgs e)
        {
            if (GlobalMenu.TextButtonStart == "Старт")
            {
                GlobalMenu.Visible = false;
                story = 1;
                TextAnimation(sender, e);
                NeGlavStory();
            }
            else if (GlobalMenu.TextButtonStart == "Продолжить")
            {
                GlobalMenu.Visible = false;
            }                       
        }
        private void MenuControl_ExitClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Story Swich

        private void NeGlavStory()
        {
            switch (story)
            {
                case 0:
                    GlobalMenu.TextButtonStart = "Старт";
                    GlobalMenu.Visible = true;
                    break;
                case 1:
                    textPerson.Visible = false;
                    textPerson.Font = new Font("Georgia", 22, FontStyle.Regular);
                    textPerson.TextAlign = ContentAlignment.MiddleCenter;
                    text1.Font = new Font("Georgia", 14, FontStyle.Regular);
                    text1.ForeColor = Color.White;
                    text1.TextAlign = ContentAlignment.MiddleLeft;
                    ImageBox.SizeMode = PictureBoxSizeMode.Zoom;
                    text1.Visible = true;
                    break;
                case 2:
                    GlobalMenu.Visible = false;
                    Next.Visible = true;
                    Previous.Visible = true;
                    this.BackgroundImage = Properties.Resources.Заставка;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    text1.Image = Properties.Resources.Фон_текст;
                    break;
                case 3:
                    this.BackgroundImage = Properties.Resources.Лес_пустошь_и_завод_вдалеке;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 4:
                    this.BackgroundImage = null;
                    this.BackColor = Color.Black;
                    break;
                case 5:
                    ImageBox.Image = null;
                    this.BackgroundImage = Properties.Resources.Дом_1;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 6:
                    ImageBox.Image = Properties.Resources.Сталкер_Учёный;
                    textPerson.ImageAlign = ContentAlignment.MiddleCenter;
                    break;
                case 7:
                    btn1.Visible = false;
                    btn2.Visible = false;
                    btn3.Visible = false;
                    break;
                case 8:
                    btn1.Visible = true;
                    btn2.Visible = true;
                    btn3.Visible = true;
                    textPerson.Visible = false;
                    if (click == 1)
                    {
                        story = 101;
                        NeGlavStory();
                        btn1.Visible = false;
                        btn2.Visible = false;
                        btn3.Visible = false;
                    }
                    else if (click == 2)
                    {
                        story = 9;
                        NeGlavStory();
                        btn1.Visible = false;
                        btn2.Visible = false;
                        btn3.Visible = false;
                    }
                    else if (click == 3)
                    {
                        story = 201;
                        NeGlavStory();
                        btn1.Visible = false;
                        btn2.Visible = false;
                        btn3.Visible = false;
                    }
                    break;
                case 9:
                    ImageBox.Image = Properties.Resources.Сталкер_Учёный;
                    textPerson.Visible = true;
                    textPerson.Image = Properties.Resources.Фон_текст_персонаж;
                    textPerson.Text = "Ваня";
                    break;
                case 10:
                    textPerson.Text = "Ты";
                    ImageBox.Image = Properties.Resources.ГГ;
                    break;
                case 11:
                    this.BackgroundImage = Properties.Resources.Дом_1;
                    textPerson.Visible = false;
                    ImageBox.Image = null;
                    break;
                case 12:
                    this.BackgroundImage = Properties.Resources.Деревня_люди_костёр;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 101:
                    textPerson.Visible = true;
                    ImageBox.Image = Properties.Resources.Сталкер_Учёный;
                    break;
                case 102:
                    textPerson.Visible = false;
                    text1.Visible = true;
                    ImageBox.Image = null;
                    break;
                case 103:
                    story = 9;
                    NeGlavStory();
                    break;
                case 201:
                    ImageBox.Image = null;
                    break;
                case 202:
                    story = 1000;
                    NeGlavStory();
                    break;
                case 13:
                    textPerson.Visible = false;
                    textPerson.Image = null;
                    ImageBox.Image = null;
                    break;
                case 14:
                    textPerson.Visible = false;
                    textPerson.Image = null;
                    ImageBox.Image = null;

                    break;
                case 15:
                    textPerson.Visible = true;
                    textPerson.Image = Properties.Resources.Фон_текст_персонаж;
                    textPerson.Text = "Шрам";
                    ImageBox.Image = Properties.Resources.Персонаж_1;
                    btn1.Visible = false;
                    btn2.Visible = false;
                    break;
                case 16:
                    btn1.Visible = true;
                    btn2.Visible = true;
                    if (click == 1)
                    {
                        story = 19;
                        btn1.Visible = false;
                        btn2.Visible = false;
                        NeGlavStory();
                    }
                    else if (click == 2)
                    {
                        story = 17;
                        btn1.Visible = false;
                        btn2.Visible = false;
                        NeGlavStory();
                    }
                    break;
                case 17:
                    textPerson.Text = "Тихон";
                    ImageBox.Image = Properties.Resources.Персонаж_2;
                    break;
                case 18:
                    ImageBox.Image = null;
                    textPerson.Visible = false;
                    break;
                case 19:
                    textPerson.Visible = true;
                    textPerson.Text = "Шрам";
                    ImageBox.Image = Properties.Resources.Персонаж_1;
                    break;
                case 20:
                    textPerson.Text = "Ты";
                    ImageBox.Image = Properties.Resources.ГГ;
                    break;
                case 21:
                    textPerson.Text = "Шрам";
                    ImageBox.Image = Properties.Resources.Персонаж_1;
                    break;
                case 22:
                    textPerson.Text = "Ты";
                    ImageBox.Image = Properties.Resources.ГГ;
                    break;
                case 23:
                    textPerson.Text = "Шрам";
                    ImageBox.Image = Properties.Resources.Персонаж_1;
                    break;
                case 24:
                    textPerson.Visible = false;
                    ImageBox.Image = null;
                    break;
                case 25:
                    story = 0;


                    break;
                case 1000:
                    this.BackgroundImage = null;
                    this.BackColor = Color.Black;
                    ImageBox.Image = Properties.Resources.YQDs;
                    ImageBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    text1.Font = new Font("Georgia", 48, FontStyle.Regular);
                    text1.ForeColor = Color.DarkRed;
                    text1.TextAlign = ContentAlignment.MiddleCenter;
                    break;
                case 1001:
                    story = 0;
                    ImageBox.Image = null;
                    NeGlavStory();
                    break;
            }
        }

        #endregion

        #region Size

        #endregion





    }
}