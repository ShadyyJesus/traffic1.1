using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traffic1._1
{
    public partial class Form1 : Form
    {
        private int PerehodCount = 6;
        private int SvetoforCount = 41; 
        private PictureBox clickedPerehod;
        private PictureBox clickedSvetofor;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 250;
            timer2.Interval = 250;
            timer3.Interval = 250;
            timer4.Interval = 250;
            timer5.Interval = 300;
            timer6.Interval = 200;
            timer7.Interval = 300;
            timer8.Interval = 320;
            timer9.Interval = 300;
            timer10.Interval = 280;
            timer11.Interval = 200;
            timer12.Interval = 300;
        }

        private void ResetCars()
        {
            //RedCar
            RedCar.Visible = false;
            RedCar.Location = new Point(372, 12);

            RedCar1.Visible = false;
            RedCar1.Location = new Point(372, 45);

            RedCar2.Visible = false;
            RedCar2.Location = new Point(42, 45);

            RedCar3.Visible = false;
            RedCar3.Location = new Point(42, 308);

            RedCar4.Visible = false;
            RedCar4.Location = new Point(141, 307);

            RedCar5.Visible = false;
            RedCar5.Location = new Point(141, 439);

            //PricepCar
            PricepCar1.Visible = false;
            PricepCar1.Location = new Point(504, 12);

            //RedCarLeft
            RedCarLeft1.Visible = false;
            RedCarLeft1.Location = new Point(9, 78);
            
            RedCarLeft2.Visible = false;
            RedCarLeft2.Location = new Point(42, 78);

            RedCarLeft3.Visible = false;
            RedCarLeft3.Location = new Point(42, 307);

            //Gruzovik
            GruzovikCar1.Visible = false;
            GruzovikCar1.Location = new Point(9, 308);

            //GruzovikDown
            GruzovikCarDown.Visible = false;
            GruzovikCarDown.Location = new Point(174, 632);

            GruzovikCarDown1.Visible = false;
            GruzovikCarDown1.Location = new Point(174, 439);

            //BlueCars
            BlueCar.Visible = false;
            BlueCar.Location = new Point(9, 472);

            BlueCar1.Visible = false;
            BlueCar1.Location = new Point(273, 472);

            BlueCar2.Visible = false;
            BlueCar2.Location = new Point(273, 603);

            BlueCar3.Visible = false;
            BlueCar3.Location = new Point(504, 602);

            //CarPricep
            carpricep1.Visible = false;
            carpricep1.Location = new Point(9, 602);

            carpricep2.Visible = false;
            carpricep2.Location = new Point(75, 603);

            carpricep3.Visible = false;
            carpricep3.Location = new Point(75, 472);

            carpricep4.Visible = false;
            carpricep4.Location = new Point(273, 472);

            carpricep5.Visible = false;
            carpricep5.Location = new Point(273, 602);

            //bluecardown1
            bluecardown1.Visible = false;
            bluecardown1.Location = new Point(42, 12);

            bluecardown2.Visible = false;
            bluecardown2.Location = new Point(42, 78);

            bluecardown3.Visible = false;
            bluecardown3.Location = new Point(372, 78);

            bluecardown4.Visible = false;
            bluecardown4.Location = new Point(372, 307);

            //gruz
            gruz1.Visible = false;
            gruz1.Location = new Point(636, 111);

            gruz2.Visible = false;
            gruz2.Location = new Point(504, 111);

            gruz3.Visible = false;
            gruz3.Location = new Point(504, 275);

            gruz4.Visible = false;
            gruz4.Location = new Point(75, 275);

            //RedCarRight
            RedCarRight1.Visible = false;
            RedCarRight1.Location = new Point(636, 275);

            RedCarRight2.Visible = false;
            RedCarRight2.Location = new Point(504, 275);

            RedCarRight3.Visible = false;
            RedCarRight3.Location = new Point(504, 603);

            //pricepa
            Pricepa1.Visible = false;
            Pricepa1.Location = new Point(636, 406);

            Pricepa2.Visible = false;
            Pricepa2.Location = new Point(537, 406);

            Pricepa3.Visible = false;
            Pricepa3.Location = new Point(537, 275);

            Pricepa4.Visible = false;
            Pricepa4.Location = new Point(75, 274);

            //bluecarright
            BlueCarRight1.Visible = false;
            BlueCarRight1.Location = new Point(636, 570);

            BlueCarRight2.Visible = false;
            BlueCarRight2.Location = new Point(537, 569);

            BlueCarRight3.Visible = false;
            BlueCarRight3.Location = new Point(537, 275);

            BlueCarRight4.Visible = false;
            BlueCarRight4.Location = new Point(405, 275);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            ResetCars();

            timer1.Start();
            RedCar.Visible = true;

            timer2.Start();
            PricepCar1.Visible = true;

            timer3.Start();
            RedCarLeft1.Visible = true;

            timer4.Start();
            GruzovikCar1.Visible = true;

            timer5.Start();
            GruzovikCarDown.Visible = true;

            timer6.Start();
            BlueCar.Visible = true;

            timer7.Start();
            carpricep1.Visible = true;

            timer8.Start();
            bluecardown1.Visible = true;

            timer9.Start();
            gruz1.Visible = true;

            timer10.Start();
            RedCarRight1.Visible = true;

            timer11.Start();
            Pricepa1.Visible = true;

            timer12.Start();
            BlueCarRight1.Visible = true;
        }

        private void Test_Click(object sender, EventArgs e)
        {
            ResetCars();
            timer1.Start();
            RedCar.Visible = true;
        }

        private void Perehod1_Click(object sender, EventArgs e)
        {
            clickedPerehod = (PictureBox)sender;
        }

        private void Perehod_Click(object sender, EventArgs e)
        {
            if (PerehodCount < 6)
            {
                if (clickedPerehod != null)
                {
                    if (clickedPerehod.Width > 33)
                    {
                        PerehodCount++;
                        LabelPerehod.Text = "Переходы: " + PerehodCount.ToString();
                        clickedPerehod.BackgroundImage = Properties.Resources._5;
                    }
                    else
                    {
                        PerehodCount++;
                        LabelPerehod.Text = "Переходы: " + PerehodCount.ToString();
                        clickedPerehod.BackgroundImage = Properties.Resources._5_1;
                    }

                }
            }
            else if (PerehodCount == 6)
            {
                MessageBox.Show("На дороге максимальное количество пешеходных переходов");
            }
            else
            {
                MessageBox.Show("Сначала выберите блок для установки перехода.");
            }
        }

        private void pictureBox239_Click(object sender, EventArgs e)
        {
            clickedSvetofor = (PictureBox)sender;
        }

        private void Svetofor_Click(object sender, EventArgs e)
        {
            if (SvetoforCount < 41)
            {
                if (clickedSvetofor != null)
                {
                    SvetoforCount++;
                    LabelSvetofor.Text = "Светофоры: " + SvetoforCount.ToString();
                    clickedSvetofor.BackgroundImage = Properties.Resources._4;
                }
            }
            else if (SvetoforCount == 41)
            {
                MessageBox.Show("На дороге максимальное количество светофоров");
            }
            else
            {
                MessageBox.Show("Сначала выберите блок для установки светофора.");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (clickedPerehod != null)
            {
                PerehodCount--;
                LabelPerehod.Text = "Переходы: " + PerehodCount.ToString();
                clickedPerehod.BackgroundImage = null;
            }
            if (clickedSvetofor != null)
            {
                SvetoforCount--;
                LabelSvetofor.Text = "Светофоры: " + SvetoforCount.ToString();
                clickedSvetofor.BackgroundImage = null;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RedCar.Visible == true)
            {
                RedCar.Top += 33;
            }
            if (RedCar.Top > 45)
            {
                RedCar.Visible = false;
                RedCar1.Visible = true;
                RedCar1.Left -= 33;
            }
            if (RedCar1.Left < 42)
            {
                RedCar1.Visible = false;
                RedCar2.Visible = true;
                RedCar2.Top += 33;
            }
            if (RedCar2.Top > 310)
            {
                RedCar2.Visible = false;
                RedCar3.Visible = true;
                RedCar3.Left += 33;
            }
            if (RedCar3.Left > 142)
            {
                RedCar3.Visible = false;
                RedCar4.Visible = true;
                RedCar4.Top += 33;
            }
            if (RedCar4.Top > 440)
            {
                RedCar4.Visible = false;
                RedCar5.Visible = true;
                RedCar5.Left -= 33;
            }
            if (RedCar5.Left < 9)
            {
                RedCar5.Visible = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (PricepCar1.Visible == true)
            {
                PricepCar1.Top += 33;
            }
            if (PricepCar1.Top > 665)
            {
                PricepCar1.Visible = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (RedCarLeft1.Visible == true)
            {
                RedCarLeft1.Left += 33;
            }
            if (RedCarLeft1.Left > 42)
            {
                RedCarLeft1.Visible = false;
                RedCarLeft2.Visible = true;
                RedCarLeft2.Top += 33;
            }
            if (RedCarLeft2.Top > 310)
            {
                RedCarLeft2.Visible = false;
                RedCarLeft3.Visible = true;
                RedCarLeft3.Left += 33;
            }
            if (RedCarLeft3.Left > 636)
            {
                RedCarLeft3.Visible = false;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (GruzovikCar1.Visible == true)
            {
                GruzovikCar1.Left += 33;
            }
            if (GruzovikCar1.Left > 636)
            {
                GruzovikCar1.Visible = false;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (GruzovikCarDown.Visible == true)
            {
                GruzovikCarDown.Top -= 33;
            }
            if (GruzovikCarDown.Top < 430)
            {
                GruzovikCarDown.Visible = false;
                GruzovikCarDown1.Visible = true;
                GruzovikCarDown1.Left -= 33;
            }
            if (GruzovikCarDown1.Left < 9)
            {
                GruzovikCarDown1.Visible = false;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (BlueCar.Visible == true)
            {
                BlueCar.Left += 33;
            }
            if (BlueCar.Left > 273)
            {
                BlueCar.Visible = false;
                BlueCar1.Visible = true;
                BlueCar1.Top += 33;
            }
            if (BlueCar1.Top > 603)
            {
                BlueCar1.Visible = false;
                BlueCar2.Visible = true;
                BlueCar2.Left += 33;
            }
            if (BlueCar2.Left > 504)
            {
                BlueCar2.Visible = false;
                BlueCar3.Visible = true;
                BlueCar3.Top += 33;
            }
            if (BlueCar3.Top > 635)
            {
                BlueCar3.Visible = false;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (carpricep1.Visible == true)
            {
                carpricep1.Left += 33;
            }
            if (carpricep1.Left > 75)
            {
                carpricep1.Visible = false;
                carpricep2.Visible = true;
                carpricep2.Top -= 33;
            }
            if (carpricep2.Top < 470)
            {
                carpricep2.Visible = false;
                carpricep3.Visible = true;
                carpricep3.Left += 33;
            }
            if (carpricep3.Left > 273)
            {
                carpricep3.Visible = false;
                carpricep4.Visible = true;
                carpricep4.Top += 33;
            }
            if (carpricep4.Top > 605)
            {
                carpricep4.Visible = false;
                carpricep5.Visible = true;
                carpricep5.Left += 33;
            }
            if (carpricep5.Left > 636)
            {
                carpricep5.Visible = false;
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (bluecardown1.Visible == true)
            {
                bluecardown1.Top += 33;
            }
            if (bluecardown1.Top > 78)
            {
                bluecardown1.Visible = false;
                bluecardown2.Visible = true;
                bluecardown2.Left += 33;
            }
            if (bluecardown2.Left > 372)
            {
                bluecardown2.Visible = false;
                bluecardown3.Visible = true;
                bluecardown3.Top += 33;
            }
            if (bluecardown3.Top > 310)
            {
                bluecardown3.Visible = false;
                bluecardown4.Visible = true;
                bluecardown4.Left += 33;
            }
            if (bluecardown4.Left > 636)
            {
                bluecardown4.Visible = false;
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (gruz1.Visible == true)
            {
                gruz1.Left -= 33;
            }
            if (gruz1.Left < 500)
            {
                gruz1.Visible = false;
                gruz2.Visible = true;
                gruz2.Top += 33;
            }
            if (gruz2.Top > 280)
            {
                gruz2.Visible = false;
                gruz3.Visible = true;
                gruz3.Left -= 33;
            }
            if (gruz3.Left < 75)
            {
                gruz3.Visible = false;
                gruz4.Visible = true;
                gruz4.Top -= 33;
            }
            if (gruz4.Top < 10)
            {
                gruz4.Visible = false;
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            if (RedCarRight1.Visible == true)
            {
                RedCarRight1.Left -= 33;
            }
            if (RedCarRight1.Left < 500) 
            { 
                RedCarRight1.Visible = false;
                RedCarRight2.Visible = true;
                RedCarRight2.Top += 33;
            }
            if (RedCarRight2.Top > 605)
            {
                RedCarRight2.Visible = false;
                RedCarRight3.Visible = true;
                RedCarRight3.Left += 33;
            }
            if (RedCarRight3.Left > 636)
            {
                RedCarRight3.Visible = false;
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            if (Pricepa1.Visible == true)
            {
                Pricepa1.Left -= 33;
            }
            if (Pricepa1.Left < 535)
            {
                Pricepa1.Visible = false;
                Pricepa2.Visible = true;
                Pricepa2.Top -= 33;
            }
            if (Pricepa2.Top < 270)
            {
                Pricepa2.Visible = false;
                Pricepa3.Visible = true;
                Pricepa3.Left -= 33;
            }
            if (Pricepa3.Left < 75)
            {
                Pricepa3.Visible = false;
                Pricepa4.Visible = true;
                Pricepa4.Top -= 33;
            }
            if (Pricepa4.Top < 10)
            {
                Pricepa4.Visible = false;
            }
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            if (BlueCarRight1.Visible == true)
            {
                BlueCarRight1.Left -= 33;
            }
            if (BlueCarRight1.Left < 537)
            {
                BlueCarRight1.Visible = false;
                BlueCarRight2.Visible = true;
                BlueCarRight2.Top -= 33;
            }
            if (BlueCarRight2.Top < 270)
            {
                BlueCarRight2.Visible = false;
                BlueCarRight3.Visible = true;
                BlueCarRight3.Left -= 33;
            }
            if (BlueCarRight3.Left < 405)
            {
                BlueCarRight3.Visible = false;
                BlueCarRight4.Visible = true;
                BlueCarRight4.Top -= 33;
            }
            if (BlueCarRight4.Top < 10)
            {
                BlueCarRight4.Visible = false;
            }
        }
    }
}