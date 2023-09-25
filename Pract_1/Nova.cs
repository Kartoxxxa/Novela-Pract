using System.Diagnostics.Eventing.Reader;
using System.Media;



namespace Pract_1
{
    public partial class Nova : Form
    {

        #region Переменные и инициализация

        int story = 0;
        int click;
        SoundPlayer player;
        bool isPlaying = false;
        private int textPosition = 0;
        private System.Windows.Forms.Timer textAnimationTimer;

 
        public Nova()
        {
            InitializeComponent();
            player = new SoundPlayer();
            textAnimationTimer = new System.Windows.Forms.Timer();
            textAnimationTimer.Interval = 50;
            textAnimationTimer.Tick += TextAnimationTimer_Tick;
            textAnimationTimer.Enabled = false;
        }
        #endregion

        //#region Story

        //private void GlavStory()
        //{

        //    if (story == 0)
        //    {
        //        textPerson.Visible = false;
        //        textPerson.Font = new Font("Georgia", 22, FontStyle.Regular);
        //        textPerson.TextAlign = ContentAlignment.MiddleCenter;
        //        text1.Visible = true;
        //        text1.Font = new Font("Georgia", 16, FontStyle.Regular);
        //        text1.ForeColor = Color.White;
        //        text1.TextAlign = ContentAlignment.MiddleCenter;
        //        story += 1;
        //    }

        //    else if (story == 1)
        //    {
        //        this.BackgroundImage = Properties.Resources.Заставка;
        //        this.BackgroundImageLayout = ImageLayout.Stretch;
        //        text1.Image = Properties.Resources.Фон_текст;
        //        story += 1;
        //    }

        //    else if (story == 2)
        //    {
        //        this.BackgroundImage = Properties.Resources.Лес_пустошь_и_завод_вдалеке;
        //        this.BackgroundImageLayout = ImageLayout.Stretch;
        //        story += 1;
        //    }

        //    else if (story == 3)
        //    {
        //        this.BackgroundImage = null;
        //        this.BackColor = Color.Black;
        //        story += 1;
        //    }
        //    else if (story == 4)
        //    {
        //        this.BackgroundImage = Properties.Resources.Дом_1;
        //        this.BackgroundImageLayout = ImageLayout.Stretch;
        //        story += 1;
        //    }
        //    else if (story == 5)
        //    {
        //        story += 1;
        //    }
        //    else if (story == 6)
        //    {
        //        ImageBox.Image = Properties.Resources.Сталкер_Учёный;
        //        textPerson.ImageAlign = ContentAlignment.MiddleCenter;
        //        story += 1;
        //    }

        //    else if (story == 7)
        //    {
        //        textPerson.Visible = false;
        //        btn1.Visible = true;
        //        btn2.Visible = true;
        //        btn3.Visible = true;
        //        story += 1;
        //    }

        //    else if (story == 8)
        //    {
        //        if (click == 1)
        //        {
        //            story = 101;
        //        }
        //        else if (click == 2)
        //        {
        //            story = 9;
        //        }
        //        else if (click == 3)
        //        {
        //            story = 201;
        //        }
        //    }
        //    else if (story == 101)
        //    {
        //        textPerson.Visible = true;
        //        ImageBox.Image = Properties.Resources.Сталкер_Учёный;
        //        story = 102;
        //    }
        //    else if (story == 102)
        //    {
        //        textPerson.Visible = false;
        //        text1.Visible = true;
        //        ImageBox.Image = null;
        //        story = 103;

        //    }
        //    else if (story == 103)
        //    {
        //        story = 9;
        //        GlavStory();
        //    }
        //    else if (story == 9)
        //    {
        //        ImageBox.Image = Properties.Resources.Сталкер_Учёный;
        //        textPerson.Visible = true;
        //        textPerson.Image = Properties.Resources.Фон_текст_персонаж;
        //        textPerson.Text = "Ваня";
        //        story += 1;
        //    }
        //    else if (story == 201)
        //    {
        //        ImageBox.Image = null;
        //        story = 202;
        //    }
        //    else if (story == 202)
        //    {
        //        story = 1000;
        //        GlavStory();
        //    }

        //    else if (story == 10)
        //    {
        //        textPerson.Text = "Ты";
        //        ImageBox.Image = Properties.Resources.ГГНаёмник;
        //        story += 1;
        //    }
        //    else if (story == 11)
        //    {
        //        textPerson.Visible = false;
        //        ImageBox.Image = null;
        //        story += 1;
        //    }

        //    else if (story == 12)
        //    {
        //        this.BackgroundImage = Properties.Resources.Деревня_люди_костёр;
        //        this.BackgroundImageLayout = ImageLayout.Stretch;
        //        story += 1;
        //    }




        //    else if (story == 1000)
        //    {
        //        this.BackgroundImage = null;
        //        this.BackColor = Color.Black;
        //        ImageBox.Image = null;
        //        text1.Font = new Font("Georgia", 48, FontStyle.Regular);
        //        text1.ForeColor = Color.DarkRed;
        //        story = 1000;
        //    }

        //}

        //#endregion

        #region Button and Click

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
            textPosition = 0;
            text1.Text = "";
            textAnimationTimer.Start();

        }

        private void btn_Click(object sender, EventArgs e)
        {

            Button clickButton = (Button)sender;
            if (clickButton.Name == "btn1")
            {
                click = 1;
            }
            else if (clickButton.Name == "btn2")
            {
                click = 2;
            }
            else if (clickButton.Name == "btn3")
            {
                click = 3;
            }
            textPosition = 0;
            text1.Text = "";
            textAnimationTimer.Start();
            NeGlavStory();
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
            textPosition = 0;
            text1.Text = "";
            textAnimationTimer.Start();
            NeGlavStory();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // Уменьшаем значение story
            if (story == 8)
            {
                return;
            }
            else if (story == 16)
            {
                return;
            }
                story--;
            textPosition = 0;
            text1.Text = "";
            textAnimationTimer.Start();
            NeGlavStory();
        }
        #endregion

        #region Story Swich

        private void NeGlavStory()
        {

            switch (story)
            {
                case 1:
                    textPerson.Visible = false;
                    textPerson.Font = new Font("Georgia", 22, FontStyle.Regular);
                    textPerson.TextAlign = ContentAlignment.MiddleCenter;
                    text1.Visible = true;
                    text1.Font = new Font("Georgia", 14, FontStyle.Regular);
                    text1.ForeColor = Color.White;
                    text1.TextAlign = ContentAlignment.MiddleLeft;
                    ImageBox.Size = new Size(1500, 860);
                    break;
                case 2:
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
                    ImageBox.Size = new Size(1100, 600);
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







    }
}