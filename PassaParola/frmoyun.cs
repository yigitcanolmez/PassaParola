using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaParola
{
    public partial class frmoyun : Form
    {
        public frmoyun()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string cevap;
        public int soru, dogru, yanlis;
        
        public void text()
        {
            string[] harfler = new string[] { "default","A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "Ü", "V", "Y", "Z" }; ;
            button25.Text = harfler[soru];
            textBox1.Text = "";
            linkLabel1.Enabled = true;
            textBox1.Focus();
        }
        private void label2_TextChanged(object sender, EventArgs e)
        {
            if(soru == 2)
            {
                richTextBox1.Text = ("Arıların peteklerinde üretmiş oldukları yenebilen sıvının adı");
                button2.BackColor = Color.Yellow;
                text();
            }
            if(soru == 3)
            {
                richTextBox1.Text = ("Fenerbahçe'de oynamış dünyaca ünlü sol bek Roberto....");
                button3.BackColor = Color.Yellow;
                text();
            }
            if(soru==4)
            {
                richTextBox1.Text=("Yıldız Teknik Üniversitesinin bulunduğu yerin adı");
                button4.BackColor = Color.Yellow;
                text();
            }  
            if(soru==5)
            {
                richTextBox1.Text=("Çocuklara matematik öğretirken kullanılan meyve adı ");
                button5.BackColor = Color.Yellow;
                text();
            }
            if (soru == 6)
            {
                richTextBox1.Text = ("Admin hangi takımlı ");
                button6.BackColor = Color.Yellow;
                text();
            }
            if (soru == 7)
            {
                richTextBox1.Text = ("Fenerbahçe'de aktif olarak oynayan Brezilyalı defansif orta saha oyuncusu LUİZZZZZ");
                button7.BackColor = Color.Yellow;
                text();
            } 
            if (soru == 8)
            {
                richTextBox1.Text = ("Danimarkalı forvet dortmunda forma giymektedir Erlinggggggggg");
                button8.BackColor = Color.Yellow;
                text();
            }
            if (soru == 9)
            {
                richTextBox1.Text = ("Warm kelimesinin Türkçe karşılığı nedir");
                button9.BackColor = Color.Yellow;
                text();
            }
            if (soru == 10)
            {
                richTextBox1.Text = ("Erkeklerin bakım için saçlarına sürdükleri değişik bir sıvı");
                button10.BackColor = Color.Yellow;
                text();
            }
            if (soru == 11)
            {
                richTextBox1.Text = ("Mabed nerde?");
                button11.BackColor = Color.Yellow;
                text();
            }
            if (soru == 12)
            {
                richTextBox1.Text = ("Fenerbahçe efsanesi");
                button12.BackColor = Color.Yellow;
                text();
            }
            if (soru == 13)
            {
                richTextBox1.Text = ("Fenerbahçede top koşturmuş M...... Valbuennaaaaa");
                button13.BackColor = Color.Yellow;
                text();
            }
            if (soru == 14)
            {
                richTextBox1.Text = ("LUUUİİİSSSSSS N.....");
                button14.BackColor = Color.Yellow;
                text();
            }
            if (soru == 15)
            {
                richTextBox1.Text = ("Tufan ... tufan oley .. tufan .. tufan oley");
                button15.BackColor = Color.Yellow;
                text();
            }
            if (soru == 16)
            {
                richTextBox1.Text = ("Fosfor elementinin sembolü");
                button16.BackColor = Color.Yellow;
                text();
            }
            if (soru == 17)
            {
                richTextBox1.Text = ("CRİİİSSSTİİİAAANNNNNOOOOOOOO");
                button17.BackColor = Color.Yellow;
                text();
            }
            if(soru == 18)
            {
                richTextBox1.Text = "Osayiii";
                button18.BackColor = Color.Yellow;
                text();
            }
            if (soru == 19)
            {
                richTextBox1.Text = (".. ŞANNLLLIIIII");
                button19.BackColor = Color.Yellow;
                text();
            }
            if (soru == 20)
            {
                richTextBox1.Text = ("SAMUEELLLLLLL");
                button20.BackColor = Color.Yellow;
                text();
            }
            if (soru == 21)
            {
                richTextBox1.Text = ("Yeşil Salkımlı meyve ");
                button21.BackColor = Color.Yellow;
                text();
            }
            if (soru == 22)
            {
                richTextBox1.Text = ("Fenerbahçede top koşturmuş V MUURRİİİQQQİİİ");
                button22.BackColor = Color.Yellow;
                text();
            }
            if (soru == 23)
            {
                richTextBox1.Text = ("Admin AD??");
                button23.BackColor = Color.Yellow;
                text();
            }
            if (soru ==24)
            {
                richTextBox1.Text = ("türkiye kupasına sponsor olan şirket");
                button24.BackColor = Color.Yellow;
                text();
            }
            if(soru == 25)
            {
                label2.Visible = false;
                label5.Visible = false;
                label3.Visible = false;
                richTextBox1.Text = "Tebrikler Bitirdiniz.";
                MessageBox.Show("Dogru Sayınız : " + dogru.ToString() + " Yanlış Sayınız : " + yanlis.ToString());


            }

        }
        public void dogrular()
        {
            dogru++;
            soru++;
            label3.Text = dogru.ToString();
            linkLabel1.Enabled = false;
            label2.Text = soru.ToString();
        }
        public void yanlislar()
        {
            yanlis++;
            label5.Text = yanlis.ToString();
            linkLabel1.Enabled = false;
            soru++;
            label2.Text = soru.ToString();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cevap = textBox1.Text;
            switch (soru)
            {
               case 1:
                    if (cevap == "Adana")
                    {
                        button1.BackColor = Color.Green;
                        dogrular();
                        
                    }
                    else
                    {
                        button1.BackColor = Color.Red;
                        yanlislar();
                    }
                    break;
                case 2:
                    if(cevap == "Bal")
                    {
                        button2.BackColor = Color.Green;
                        dogrular();   
                    }
                    else
                    {
                        yanlislar();
                        button2.BackColor = Color.Red;
                    }
                    break;
                case 3: 
                    if ( cevap == "Carlos")
                    {
                        button3.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        button3.BackColor = Color.Red;
                        yanlislar();
                    }
                    break;
                case 4:
                    if(cevap =="Davutpaşa")
                    {
                        button4.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button4.BackColor = Color.Red;
                    }
                    break;
                case 5:
                    if (cevap == "Elma")
                    {
                        button5.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button5.BackColor = Color.Red;
                    }
                    break;
                case 6:
                    if (cevap == "Fenerbahçe")
                    {
                        button6.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button6.BackColor = Color.Red;
                    }
                    break;
                case 7:
                    if (cevap == "Gustavo")
                    {
                        button7.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button7.BackColor = Color.Red;
                    }
                    break;
                case 8:
                    if (cevap == "Haaland")
                    {
                        button8.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button8.BackColor = Color.Red;
                    }
                    break;
                case 9:
                    if (cevap == "Ilık")
                    {
                        button9.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button9.BackColor = Color.Red;
                    }
                    break;
                case 10:
                    if (cevap == "Jöle")
                    {
                        button10.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button10.BackColor = Color.Red;
                    }
                    break;
                case 11:
                    if (cevap == "Kadıköy")
                    {
                        button11.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button11.BackColor = Color.Red;
                    }
                    break;
                case 12:
                    if (cevap == "Lefter")
                    {
                        button12.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button12.BackColor = Color.Red;
                    }
                    break;
                case 13:
                    if (cevap == "Mathieu")
                    {
                        button13.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button13.BackColor = Color.Red;
                    }
                    break;
                case 14:
                    if (cevap == "Nani")
                    {
                        button14.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button14.BackColor = Color.Red;
                    }
                    break;
                case 15:
                    if (cevap == "Ozan")
                    {
                        button15.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button15.BackColor = Color.Red;
                    }
                    break;
                case 16:
                    if (cevap == "P")
                    {
                        button16.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button16.BackColor = Color.Red;
                    }
                    break;
                case 17:
                    if (cevap == "Ronaldo")
                    {
                        button17.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button17.BackColor = Color.Red;
                    }
                    break;
                case 18:
                    if (cevap == "Samuel")
                    {
                        button18.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button18.BackColor = Color.Red;
                    }
                    break;
                case 19:
                    if (cevap == "Tuncay")
                    {
                        button19.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button19.BackColor = Color.Red;
                    }
                    break;
                case 20:
                    if (cevap == "Umtiti")
                    {
                        button20.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button20.BackColor = Color.Red;
                    }
                    break;
                case 21:
                    if (cevap == "Üzüm")
                    {
                        button21.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button21.BackColor = Color.Red;
                    }
                    break;
                case 22:
                    if (cevap == "Vedat")
                    {
                        button22.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button22.BackColor = Color.Red;
                    }
                    break;
                case 23:
                    if (cevap == "Yiğit")
                    {
                        button23.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button23.BackColor = Color.Red;
                    }
                    break;
                case 24:
                    if (cevap == "Ziraat")
                    {
                        button24.BackColor = Color.Green;
                        dogrular();
                    }
                    else
                    {
                        yanlislar();
                        button24.BackColor = Color.Red;
                    }
                    break;


            }
                
          
        }

       

        private void frmoyun_Load(object sender, EventArgs e)
        {
            soru = 0;
            dogru = 0;
            yanlis = 0;

            button1.BackColor = Color.Yellow;
            button25.Text = "A";
            richTextBox1.Text = "Ülkemizde güneşe ateş edenler olarak bilinen ilimiz hangisidir?";
            soru++;
            label2.Text = soru.ToString();
            
            

        }
      
    }
}
