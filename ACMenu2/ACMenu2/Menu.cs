using ezOverLay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ACMenu2
{
    public partial class Menu : Form
    {

        ez ez2 = new ez();

        [DllImport("user32.dll")]

        static extern short GetAsyncKeyState(Keys vKey);
        public Menu()
        {
            InitializeComponent();
        }




        private void Menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
              CheckForIllegalCrossThreadCalls = false;
            //m = new methods();
            //if (m != null)
            //{
              ez2.SetInvi(this);
               ez2.StartLoop(10, "AssaultCube", this);
            //}
            Form1 formulado = new Form1();
            formulado.Show();
        }
        public int cont = 4;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
         //---------------------------------------------------------------   
            if (label2.ForeColor == Color.Gold)
            {
                if (GetAsyncKeyState(Keys.Right) < 0)
                {
                    if (label5.Text == "[ ON ]")
                    {

                    }
                    else
                    {
                        label5.ForeColor = Color.Green;
                        label5.Text = "[ ON ]";
                        variavel.ESPBOX = true;
                    }
                }
            }


            if (label2.ForeColor == Color.Gold)
            {
                if (GetAsyncKeyState(Keys.Left) < 0)
                {
                    if (label5.Text == "[ OFF ]")
                    {

                    }
                    else
                    {
                        label5.ForeColor = Color.Red;
                        label5.Text = "[ OFF ]";
                        variavel.ESPBOX = false;
                    }
                }
            }


            //-----------------------------------------------------------

            //---------------------------------------------------------------   
            if (label3.ForeColor == Color.Gold)
            {
                if (GetAsyncKeyState(Keys.Right) < 0)
                {
                    if (label6.Text == "[ ON ]")
                    {

                    }
                    else
                    {
                        label6.ForeColor = Color.Green;
                        label6.Text = "[ ON ]";
                        variavel.ESPLINE = true;
                    }
                }
            }


            if (label3.ForeColor == Color.Gold)
            {
                if (GetAsyncKeyState(Keys.Left) < 0)
                {
                    if (label6.Text == "[ OFF ]")
                    {

                    }
                    else
                    {
                        label6.ForeColor = Color.Red;
                        label6.Text = "[ OFF ]";
                        variavel.ESPLINE = false;
                    }
                }
            }




            if (label10.ForeColor == Color.Gold)
            {
                if (GetAsyncKeyState(Keys.Right) < 0)
                {
                    if (label9.Text == "[ ON ]")
                    {

                    }
                    else
                    {
                        label9.ForeColor = Color.Green;
                        label9.Text = "[ ON ]";
                        variavel.ESPAmigo = true;
                    }
                }
            }


            if (label10.ForeColor == Color.Gold)
            {
                if (GetAsyncKeyState(Keys.Left) < 0)
                {
                    if (label9.Text == "[ OFF ]")
                    {

                    }
                    else
                    {
                        label9.ForeColor = Color.Red;
                        label9.Text = "[ OFF ]";
                        variavel.ESPAmigo = false;
                    }
                }
            }


            //-----------------------------------------------------------

            //---------------------------------------------------------------   
            if (label4.ForeColor == Color.Gold)
            {
                if (GetAsyncKeyState(Keys.Right) < 0)
                {
                    if (label7.Text == "[ ON ]")
                    {

                    }
                    else
                    {
                        label7.ForeColor = Color.Green;
                        label7.Text = "[ ON ]";
                        variavel.Aimbot = true;
                        variavel.ammo = true;
                    }
                }
            }


            if (label4.ForeColor == Color.Gold)
            {
                if (GetAsyncKeyState(Keys.Left) < 0)
                {
                    if (label7.Text == "[ OFF ]")
                    {

                    }
                    else
                    {
                        label7.ForeColor = Color.Red;
                        label7.Text = "[ OFF ]";
                        variavel.Aimbot = false;
                    }
                }
            }









            if (label12.ForeColor == Color.Gold)
            {
                if (GetAsyncKeyState(Keys.Right) < 0)
                {
                    if (label11.Text == "[ ON ]")
                    {

                    }
                    else
                    {
                        label11.ForeColor = Color.Green;
                        label11.Text = "[ ON ]";
                        variavel.ammo = true;
                    }
                }
            }


            if (label12.ForeColor == Color.Gold)
            {
                if (GetAsyncKeyState(Keys.Left) < 0)
                {
                    if (label11.Text == "[ OFF ]")
                    {

                    }
                    else
                    {
                        label11.ForeColor = Color.Red;
                        label11.Text = "[ OFF ]";
                        variavel.ammo = false;
                    }
                }
            }



            if (label14.ForeColor == Color.Gold)
            {
                if (GetAsyncKeyState(Keys.Right) < 0)
                {
                    if (label13.Text == "[ ON ]")
                    {

                    }
                    else
                    {
                        label13.ForeColor = Color.Green;
                        label13.Text = "[ ON ]";
                        variavel.health = true;
                    }
                }
            }


            if (label12.ForeColor == Color.Gold)
            {
                if (GetAsyncKeyState(Keys.Left) < 0)
                {
                    if (label11.Text == "[ OFF ]")
                    {

                    }
                    else
                    {
                        label11.ForeColor = Color.Red;
                        label11.Text = "[ OFF ]";
                        variavel.ammo = false;
                    }
                }
            }




            //-----------------------------------------------------------


            //---------------------------------------------------------------   

            if (label2.ForeColor == Color.Gold)
                {
                    if (GetAsyncKeyState(Keys.Down) < 0)

                    {
                        label3.ForeColor = Color.Gold;
                        label2.ForeColor = Color.OrangeRed;
                    Thread.Sleep(20);

                    }
                }


                if (label3.ForeColor == Color.Gold)
                {
                    if (GetAsyncKeyState(Keys.Up) < 0)

                    {
                        label2.ForeColor = Color.Gold;
                        label3.ForeColor = Color.OrangeRed;
                    Thread.Sleep(20);

                }
                }



            if (label3.ForeColor == Color.Gold)
            {
                if (GetAsyncKeyState(Keys.Down) < 0)

                {
                    label10.ForeColor = Color.Gold;
                    label3.ForeColor = Color.OrangeRed;
                    Thread.Sleep(20);

                }
            }


            if (label10.ForeColor == Color.Gold)
            {
                if (GetAsyncKeyState(Keys.Up) < 0)

                {
                    label3.ForeColor = Color.Gold;
                    label10.ForeColor = Color.OrangeRed;
                    Thread.Sleep(20);

                }
            }



            //----------------------------------------------------

            if (label10.ForeColor == Color.Gold)
                {
                    if (GetAsyncKeyState(Keys.Down) < 0)

                    {
                        label4.ForeColor = Color.Gold;
                        label10.ForeColor = Color.OrangeRed;
                    Thread.Sleep(20);

                }
                }


                if (label4.ForeColor == Color.Gold)
                {
                    if (GetAsyncKeyState(Keys.Up) < 0)

                    {
                        label10.ForeColor = Color.Gold;
                        label4.ForeColor = Color.OrangeRed;
                    Thread.Sleep(20);
                }
                }


            if (label4.ForeColor == Color.Gold)
            {
                if (GetAsyncKeyState(Keys.Down) < 0)

                {
                    label12.ForeColor = Color.Gold;
                    label4.ForeColor = Color.OrangeRed;
                    Thread.Sleep(20);

                }
            }


            if (label12.ForeColor == Color.Gold)
            {
                if (GetAsyncKeyState(Keys.Up) < 0)

                {
                    label4.ForeColor = Color.Gold;
                    label12.ForeColor = Color.OrangeRed;
                    Thread.Sleep(20);
                }
            }



            if (label12.ForeColor == Color.Gold)
            {
                if (GetAsyncKeyState(Keys.Down) < 0)

                {
                    label14.ForeColor = Color.Gold;
                    label12.ForeColor = Color.OrangeRed;
                    Thread.Sleep(20);

                }
            }


            if (label14.ForeColor == Color.Gold)
            {
                if (GetAsyncKeyState(Keys.Up) < 0)

                {
                    label12.ForeColor = Color.Gold;
                    label14.ForeColor = Color.OrangeRed;
                    Thread.Sleep(20);
                }
            }



            if (GetAsyncKeyState(Keys.F8) < 0)

            {
                Menu.ActiveForm.Close();
            }


                //-----------------------------------------------------------






            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        ////{
        ////    if (checkBox1.Checked == true)
        ////    {
        ////        variavel.ESPBOX = true;
        ////    }
        ////    else
        ////    {
        ////        variavel.ESPBOX = false;
        ////    }
        //}

        //private void checkBox2_CheckedChanged(object sender, EventArgs e)
        //{
        //    //if (checkBox2.Checked == true)
        //    //{
        //    //    variavel.ESPLINE = true;
        //    //}
        //    //else
        //    //{
        //    //    variavel.ESPLINE = false;
        //    //}
        //}

        //private void checkBox3_CheckedChanged(object sender, EventArgs e)
        //{
        //    //if (checkBox3.Checked == true)
        //    //{
        //    //    variavel.Aimbot = true;
        //    //}
        //    //else
        //    //{
        //    //    variavel.Aimbot = false;
        //    //}
        //}

    }
}


