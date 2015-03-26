using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace binary
{
 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] adress = new int[307];
        int[] sayilar=new int[300];
        ArrayList lstNumbers = new ArrayList();
        ArrayList binary;

        public void numbergenerate()
        {
            Random rndNumber = new Random();
            int number = rndNumber.Next(1, 100000);
            lstNumbers.Add(number);
           
            int count = 0;
            do
            {
                number = rndNumber.Next(1, 100000);
                if (!lstNumbers.Contains(number))
                {
                    lstNumbers.Add(number);
                    count++;
                }
            } while (count < 299); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true; 
            oku();
            for (int i = 0; i < 300; i++)
                numbox.Text += sayilar[i] + "\n";
            button1.Visible = false;
        }
        public int homeadress(int key)
        {
            return key % 307;
        }
        public int increment(int key)
        {
            return (key / 307) % 307;
        }
        
        public void DosyayaYaz()
        {
            numbergenerate();
            StreamWriter dosya = new StreamWriter("kayit.txt");
            for (int i = 0; i < 300; i++)
                dosya.WriteLine(lstNumbers[i]);
            dosya.Close();
        }

        public void insert(int key)
        {
            binary = new ArrayList();
            if (adress[homeadress(key)] == -1)
                adress[homeadress(key)] = key;
            else
            {
                binary.Add(key);
                binary.Add(homeadress(key));
                tree(key);
                yerlestir(key);
            }
        }
        public void tree(int key)// tree oluşturacak
        {
            int i = 1;
            while (true)
            {
                i++;
               if(i==2 || i==4 || i==8 || i==16 ||i==32 ||i==64||i==128||i==256 ||i==512 ||i==1024 ||i==2048 ||i==4096 || i==8192 || i==16384 || i== 32768)
                    binary.Add(   ((int)binary[parent(i)]  +increment(key))   %307      );
               else
                   binary.Add(((int)binary[parent(i)] + increment(adress[(int)binary[parent(parent(i))]]))%307   );

                if(adress[((int)binary[i])]==-1)
                    break;
                i++;
                binary.Add(((int)binary[parent(i)] + increment(adress[(int)binary[parent(i)]]) ) %307
                    );
                if (adress[((int)binary[i])] == -1)
                    break;
            }

        }
        public int parent(int i)
        {
            return i / 2;
        }
        public int left(int i)
        {
            return i*2;
        }
        public int right(int i)
        {
            return (i * 2) + 1;
        }

        public void yerlestir(int key)
        {
            int temp=binary.Count-1;//ağaçtaki boşyer
            
            while (true)
            {
                if (parent(temp) == 0)
                    break;
                else if (temp % 2 == 0) //boş yer sol çocukta
                {
                    temp = parent(temp);
                    if (parent(temp) != 0)
                    {
                        if (temp % 2 == 1)//sağın solu
                        {
                            adress[(int)binary[left(temp)]] = adress[(int)binary[parent(temp)]];
                            adress[(int)binary[parent(temp)]] = key;
                            break;
                        }
                        else
                        {
                        }
                    }
                }
                else if (temp % 2 == 1)//boş yer sağ çocukta
                {
                    adress[(int)binary[temp]] = adress[(int)binary[parent(temp)]];
                    adress[(int)binary[parent(temp)]] = key;
                    temp = parent(temp);
                }
            }
            if (adress[(int)binary[binary.Count - 1]] == -1)
                adress[(int)binary[binary.Count - 1]] = key;
        }

        public void oku()
        { 
            StreamReader dosyaOku;
            dosyaOku=File.OpenText("kayit.txt");
            for (int i = 0; i < 300; i++)
                sayilar[i] = Convert.ToInt32(dosyaOku.ReadLine());
            dosyaOku.Close();
        } 
        
        private void button2_Click(object sender, EventArgs e)
        {
            //DosyayaYaz();
            for (int i = 0; i < 307; i++)
            {
                adresbox.Text += i + "\n";
            }
            for (int i = 0; i < 307; i++)
                adress[i] = -1;
            for (int i = 0; i < 300; i++)
                insert(sayilar[i]);

            for (int i = 0; i < adress.Length; i++)
                printbox.Text += adress[i] + "\n";
        }
    }
}
