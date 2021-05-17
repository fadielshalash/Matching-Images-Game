using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Matchine_The_Images_game
{
    public partial class Level2 : Form
    {
        public Level2()
        {
            InitializeComponent();
        }
        List<Image> Image = new List<Image>();
        int score2 = 0;
        List<PictureBox> pic_box = new List<PictureBox>();
        int Count_Clicks = 1;
        PictureBox imgg1;
        PictureBox imgg2;
        private void Level2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Congo you Passed level one,Good Luck At level Two\nRemember You Only Have 3 Minutes To Finish This Level");
            Image.Add(Properties.Resources.lev2_1);
            Image.Add(Properties.Resources.lev2_2);
            Image.Add(Properties.Resources.lev2_3);
            Image.Add(Properties.Resources.lev2_4);
            Image.Add(Properties.Resources.lev2_5);
            Image.Add(Properties.Resources.lev2_6);
            Image.Add(Properties.Resources.lev2_7);
            Image.Add(Properties.Resources.lev2_8);
            Image.Add(Properties.Resources.lev2_9);
            Image.Add(Properties.Resources.lev2_10);
            Image.Add(Properties.Resources.lev2_11);
            Image.Add(Properties.Resources.lev2_12);
            Image.Add(Properties.Resources.lev2_13);
            Image.Add(Properties.Resources.lev2_14);
            Image.Add(Properties.Resources.lev2_16);
            pic_box.Add(First_Picture);
            pic_box.Add(Second_Picture);
            pic_box.Add(Third_picture);
            pic_box.Add(Fourth_picture);
            pic_box.Add(fifth_picture);
            pic_box.Add(sixth_picture);
            pic_box.Add(seventh_picture);
            pic_box.Add(eighth_picture);
            pic_box.Add(nineth_picture);
            pic_box.Add(ten_picture);
            pic_box.Add(eleven_picture);
            pic_box.Add(twoelve_picture);
            pic_box.Add(therten_picture);
            pic_box.Add(fourten_picture);
            pic_box.Add(fiveten_picture);
            pic_box.Add(sixten_picture);
            pic_box.Add(seventen_picture);
            pic_box.Add(eightten_picture);
            pic_box.Add(nineten);
            pic_box.Add(twoten);
            pic_box.Add(wa7d3shren);
            pic_box.Add(thnen3shren);
            pic_box.Add(thlat3shren);
            pic_box.Add(arb3a3shren);
            pic_box.Add(khamse3shren);
            pic_box.Add(sta3shren);
            pic_box.Add(sb3a3shren);
            pic_box.Add(thmany3shren);
            pic_box.Add(ts3a3shren);
            pic_box.Add(thlathen);
            groupBox1.Hide();
            fill_picture_box(pic_box, Image);
        }
        private void fill_picture_box(List<PictureBox> pic_box, List<Image> Image)
        {
            Random rnd = new Random();
            int y = 0;
            y = rnd.Next(pic_box.Count());
            for (int i = 0; i < Image.Count(); i++)
            {
                pic_box[y].Image = Image[i];
                pic_box[y].Tag = i;
                Image[i].Tag = i;
                pic_box.RemoveAt(y);
                y = rnd.Next(pic_box.Count());
                pic_box[y].Image = Image[i];
                pic_box[y].Tag = i;
                Image[i].Tag = i;
                pic_box.RemoveAt(y);
                y = rnd.Next(pic_box.Count());
            }
        }
        private void img_click(object sender, EventArgs e)
        {
            timer3.Stop();
            timer1.Stop();
            if (Count_Clicks == 1)
            {
                imgg1 = ((PictureBox)((object)sender));
                imgg1.Enabled = false;
                for (int sec1 = 0; sec1 < Image.Count(); sec1++)
                {
                    if (sec1 == (int)((PictureBox)((object)sender)).Tag)
                    {
                        ((PictureBox)((object)sender)).Image = Image[sec1];
                        Count_Clicks++;
                    }
                }
            }
            else if (Count_Clicks == 2)
            {
                imgg2 = ((PictureBox)((object)sender));
                imgg2.Enabled = false;  
                for (int sec2 = 0; sec2 < Image.Count(); sec2++)
                {
                    if (sec2 == (int)((PictureBox)((object)sender)).Tag)
                    {
                        ((PictureBox)((object)sender)).Image = Image[sec2];

                        Count_Clicks = 1;
                    }
                }
                if ((int)imgg1.Tag == (int)imgg2.Tag)
                {
                    score2++;
                    imgg1 = null;
                    imgg2 = null;
                }
                else if ((int)imgg1.Tag != (int)imgg2.Tag)
                {
                    timer3.Start();
                    score2--;
                }
            }
        }
        private void Start_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            timer1.Start();
        }
        private void Finish_click(object sender, EventArgs e)
        {
            timer2.Stop();
            textBox2.Text = score2 + " ";
            MessageBox.Show("you score is" +" "+ score2);
            if (score2 >=9)
            {
                MessageBox.Show("Good Score\n You Won The Price\n Congo");
            }
            else if(score2<9)
                MessageBox.Show("Your Score Was  Very Bad\nYou Lose The Price,Good Luck Next Time");
            Application.Exit();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            First_Picture.Image = null;
            Second_Picture.Image = null;
            Third_picture.Image = null;
            Fourth_picture.Image = null;
            fifth_picture.Image = null;
            sixth_picture.Image = null;
            seventh_picture.Image = null;
            eighth_picture.Image = null;
            nineth_picture.Image = null;
            ten_picture.Image = null;
            eleven_picture.Image = null;
            twoelve_picture.Image = null;
            therten_picture.Image = null;
            fourten_picture.Image = null;
            fiveten_picture.Image = null;
            sixten_picture.Image = null;
            seventen_picture.Image = null;
            eightten_picture.Image = null;
            nineten.Image = null;
            twoten.Image = null;
            wa7d3shren.Image = null;
            thnen3shren.Image = null;
            thlat3shren.Image = null;
            arb3a3shren.Image = null;
            khamse3shren.Image = null;
            sta3shren.Image = null;
            sb3a3shren.Image = null;
            thmany3shren.Image = null;
            ts3a3shren.Image = null;
           thlathen.Image = null;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Time Is Off,You Are Our Of The Game");
            Application.Exit();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            imgg1.Image = null;
            imgg2.Image = null;
            imgg1.Enabled = true;
            imgg2.Enabled = true;
        }
    }
}