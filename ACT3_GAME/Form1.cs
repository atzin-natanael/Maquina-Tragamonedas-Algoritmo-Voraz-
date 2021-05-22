using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT3_GAME
{
    public partial class Form1 : Form
    {
        Thread hilo;
        Thread hilo2;
        Thread hilo3;
        public Form1()
        {
            InitializeComponent();
            SoundPlayer Player = new SoundPlayer();
            Player.SoundLocation= "C:\\Users\\Atz1NNN\\source\\repos\\ACT3_GAME\\tragamonedas\\S.wav";
            Player.Play();
            hilo = new Thread(Hilo1);
            CheckForIllegalCrossThreadCalls = false;
            hilo2 = new Thread(Hilo2);
            CheckForIllegalCrossThreadCalls = false;
            hilo3 = new Thread(Hilo3);
            CheckForIllegalCrossThreadCalls = false;
        }
        int coins, b=0, c=0;
        int contar = 0, contar10, contar5, contar2, contar1;
        List<string> imagen = new List<string> { "C:\\Users\\Atz1NNN\\Pictures\\tragamonedas\\AKGOLD.jpg", "C:\\Users\\Atz1NNN\\Pictures\\tragamonedas\\DESREAL.jpg", "C:\\Users\\Atz1NNN\\Pictures\\tragamonedas\\barr.png", "C:\\Users\\Atz1NNN\\Pictures\\tragamonedas\\KAR.jpg", "C:\\Users\\Atz1NNN\\Pictures\\tragamonedas\\AUG2.jpg", "C:\\Users\\Atz1NNN\\Pictures\\tragamonedas\\WINCHESTER.jpg" };
        bool flag = false;
        bool flag2 = false;
       
        Random random = new Random();
        int a=0;
        int i = 0, r=0, f =0;

        int h = 0, g=0;
        int z = 0;

        private void Btn20_Click(object sender, EventArgs e)
        {
            txtcoins.Clear();
            coins += 20;
            string str = Convert.ToString(coins);
            txtcoins.SelectedText = str;
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            txtcoins.Clear();
            coins += 10;
            string str = Convert.ToString(coins);
            txtcoins.SelectedText = str;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtcoins.Clear();
            coins += 5;
            string str = Convert.ToString(coins);
            txtcoins.SelectedText = str;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtcoins.Clear();
            coins += 2;
            string str = Convert.ToString(coins);
            txtcoins.SelectedText = str;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtcoins.Clear();
            coins += 1;
            string str = Convert.ToString(coins);
            txtcoins.SelectedText = str;
        }

   

        private void Btncobrar_Click(object sender, EventArgs e)
        {
            List<int> Cambio = new List<int>();
            if (txtcoins.Text != "" && txtcoins.Text != "0")
            {
                DialogResult dialog = MessageBox.Show("¿Deseas cobrar tus " + txtcoins.Text + " coins? ", "COBRAR COINS", MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.OK)
                {
                    List<int> cuantasson = new List<int>();

                    if (check20.Checked)
                    {
                        Cambio.Add(20);
                        cuantasson.Add(0);
                    }
                    if (check10.Checked)
                    {
                        Cambio.Add(10);
                        cuantasson.Add(0);
                    }
                    if (check5.Checked)
                    {
                        Cambio.Add(5);
                        cuantasson.Add(0);
                    }
                    if (check2.Checked)
                    {
                        Cambio.Add(2);
                        cuantasson.Add(0);
                    }
                    if (check1.Checked)
                    {
                        Cambio.Add(1);
                        cuantasson.Add(0);
                    }
                    int total = 0;
                    List<int> Respuesta = new List<int>();
                    int contador = 0;
                    int x = Cambio[contador];
                    while (total < coins)
                    {
                        x = Cambio[contador];
                        if ((total + x) <= coins)
                        {
                            Respuesta.Add(x);
                            total = total + x;
                            cuantasson[contador]++;
                        }
                        else
                        {       
                            x = Cambio[contador++];                            
                        }
                    }

                    txtcoins.Clear();
                    coins = 0;
                    string str = Convert.ToString(coins);
                    txtcoins.SelectedText = str;
                    string variable = "SU CAMBIO ES: \n";
                    for (int i = 0; i < Cambio.Count(); ++i)
                    {
                        if (cuantasson[i] > 0)
                        {
                            variable += "$ "+Cambio[i] + " :  " + cuantasson[i]+"\n";
                        }
                        

                    }
                    MessageBox.Show(variable);

                }
            
                


/*



                    MessageBox.Show("Tu Dinero ha sido entregado con:  " + "Billetes de 20: " + contar + "     " + "Monedas de  10: " + contar10 + "     " + "Monedas de  5: " + contar5 + "     " + "Monedas de 2 : " + contar2 + "     " + "Monedas de  1: " + contar1);

                    txtcoins.Clear();
                    contar = 0;
                    contar10 = 0;
                    contar5 = 0;
                    contar2 = 0;
                    contar1 = 0;
                    txtcoins.Text = (0).ToString()
                }*/
            }
            else
            {
                MessageBox.Show("No tienes COINS");
            }

        }
        int j = 0, k = 0, l = 0;

        void Hilo1()
        {
            
            
            
            for (i = 0; i < a; ++i)
            {
                if (i < 6)
                {
                    j = i;
                }
                else if (j == 5)
                {
                    j = 0;
                }

                else if (i > 6)
                {

                    j++;
                }
                
                jpg1.Image = Image.FromFile(imagen[j]);
                jpg1.Refresh();
                Thread.Sleep(100);
                if (i == a - 1)
                {
                   // MessageBox.Show("HILO1 J   "+ j);
                   // MessageBox.Show("HILO1 I   " + i);
                    g = j;
                    hilo.Suspend();
                }

            }
            
               
           
          
        }
        void Hilo2()
        {
           
            

            for (f = 0; f < b; ++f)
            {
                if (f < 6)
                {
                    k = f;
                }

                else if (k == 5)
                {
                    k = 0;
                }
                else if (f > 6)
                {

                    k++;
                }


                jpg2.Image = Image.FromFile(imagen[k]);
                jpg2.Refresh();
                Thread.Sleep(100);
                if(f == b - 1)
                {
                   // MessageBox.Show("HILO2 K   " + k);
                    //MessageBox.Show("HILO2 I   " + e);
                    h = k;
                    hilo2.Suspend();
                }
                
            }


           



        }
        void Hilo3()
        {
           
           
           
            
            for (r=0; r < c; ++r)
            {
                if (r < 6)
                {
                    l = r;
                }

                else if (l == 5)
                {
                    l = 0;
                }
                else if (r > 6)
                {

                    l++;
                }

                jpg3.Image = Image.FromFile(imagen[l]);
                jpg3.Refresh();
                Thread.Sleep(100);
                if (r == c - 1)
                {
                    z = l;
                    flag2 = true;
                    if (g == h && g == z)
                    {
                        MessageBox.Show("¡HAZ GANADO!" , " CREDITO OBTENIDO: 100 ");
                        txtcoins.Clear();
                        coins += 100;
                        txtcoins.SelectedText = coins.ToString();
                    }
                    else if (g == h && g != z || z==g && z!=h || h==z && h!=g)
                    {
                        MessageBox.Show("¡HAZ ACERTADO 2! "," CREDITO OBTENIDO: 15 ");
                        txtcoins.Clear();
                        coins += 15;
                        txtcoins.SelectedText = coins.ToString();
                    }
                    else if (g != h && g != z && z!=h)
                    {
                        MessageBox.Show("¡SUERTE A LA PROXIMA!" , " CREDITO OBTENIDO: 1 ");
                        txtcoins.Clear();
                        coins += 1;
                        txtcoins.SelectedText = coins.ToString();
                        
                    }

                    else
                    {
                        txtcoins.Clear();
                        string str = Convert.ToString(coins);
                        txtcoins.SelectedText = str;
                    }
                    // MessageBox.Show("HILO3 L   " + l);
                    //MessageBox.Show("HILO3 I   " + r);
                    button1.Enabled = true;
                    hilo3.Suspend();
                    
                }
            }
            
            
            

            
          






        }
        void hilos()
        {

            a = random.Next(15, 20);
            b = random.Next(25, 30);
            c = random.Next(40, 45);

            hilo.Start();
                hilo2.Start();
                hilo3.Start();
                button1.Enabled = false;
                flag = true;
            
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            
            if(flag ==true && flag2 == false)
            {
                MessageBox.Show("ESPERA QUE TERMINE", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Thread.Sleep(3000);

            }
            if (coins < 10)
            {
                MessageBox.Show("COINS INSUFICIENTES", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            coins -= 10;
            txtcoins.Clear();
            txtcoins.SelectedText = coins.ToString();
            jpg1.SizeMode = PictureBoxSizeMode.StretchImage;
            jpg2.SizeMode = PictureBoxSizeMode.StretchImage;
            jpg3.SizeMode = PictureBoxSizeMode.StretchImage;
            
            if (flag == true && flag2 == true)
            {
                
                l = 0;
                k = 0;
                j = 0;
                i = 0;
                f = 0;
                r = 0;
                a = random.Next(15, 20);
                b = random.Next(25, 30);
                c = random.Next(40, 45);
                
                hilo.Resume();
                hilo2.Resume();
                hilo3.Resume();
                button1.Enabled = false;
            }
            else
             hilos();
           
            
         
            
               

            }


        
    }
}
