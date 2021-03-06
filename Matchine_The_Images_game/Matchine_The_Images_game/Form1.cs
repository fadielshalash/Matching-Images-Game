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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Image> Images = new List<Image>();
        List<PictureBox> pic_box = new List<PictureBox>();
        int score = 0;
        int Count_Clicks = 1;
        PictureBox imgg1;
        PictureBox imgg2;
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To Matching Images Game,Good Luck\nGame Has Two Levesl\n first level contains 12 pic 6 are similar\n second level contains 30 pic 15 are similar\n");
            MessageBox.Show("You Need 4 Points At Least To Pass To level One\nYou Have 35 Second For First Level\nRemember You Have Only 5 minutes To Pass The Two Levels\n good luck");
            Images.Add(Properties.Resources._1);
            Images.Add(Properties.Resources._2);
            Images.Add(Properties.Resources._3);
            Images.Add(Properties.Resources._4);
            Images.Add(Properties.Resources._5);
            Images.Add(Properties.Resources._6);
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
            fill_picture_box(pic_box, Images);
            groupBox1.Hide();
        }
        Level2 secfr = new Level2();
        private void Start_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            timer1.Start();
            timer2.Start();
        }
        private void fill_picture_box(List<PictureBox> pic_box, List<Image> Images)
        {
            Random rnd = new Random();
            int y = 0;
            y = rnd.Next(pic_box.Count());
            for (int i = 0; i <Images.Count(); i++)
            {
                pic_box[y].Image = Images[i ];
                pic_box[y].Tag = i;
                Images[i ].Tag = i;
                pic_box.RemoveAt(y);
                y = rnd.Next(pic_box.Count());
                pic_box[y].Image = Images[i];
                pic_box[y].Tag = i;
                Images[i ].Tag = i;
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
                for (int sec1 = 0; sec1 < Images.Count(); sec1++)
                    {
                        if (sec1 == (int)((PictureBox)((object)sender)).Tag)
                        {
                            ((PictureBox)((object)sender)).Image = Images[sec1];
                        
                        Count_Clicks++;
                        }
                    }
                }
                else if (Count_Clicks == 2)
            {  
                imgg2 = ((PictureBox)((object)sender));
                imgg2.Enabled = false;
                for (int sec2 = 0; sec2 < Images.Count(); sec2++)
                {
                        if (sec2 == (int)((PictureBox)((object)sender)).Tag)
                        {
                            ((PictureBox)((object)sender)).Image = Images[sec2];
                        
                        Count_Clicks = 1;
                        }
                }
                    if ((int)imgg1.Tag== (int)imgg2.Tag)
                    {
                        imgg1 = null;
                        imgg2 = null;
                        score++;
                    }
                        else if ((int)imgg1.Tag != (int)imgg2.Tag)
                        {
                         timer3.Start();
                         score--;
                        }
                }
        }
            private void Finish_click(object sender, EventArgs e)
        {
            timer2.Stop();
            textBox2.Text = score + " ";
            MessageBox.Show("your score is \n" + score);
            DialogResult result = MessageBox.Show("Do You Want To Go To Another Level? Yes ,No ", "Next Level", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                if (score > 4 || score == 4)
                {
                    secfr.ShowDialog();
                }
                else if (score < 3 || score == 3)
                {
                    MessageBox.Show("no enough score");
                    Application.Exit();
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            First_Picture.Image=null;
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
        }
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            MessageBox.Show("Time Is Done For The First Level,You Lose And Out");
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