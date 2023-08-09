namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "SONRAKÝ";

            soruno++;
            this.Text = soruno.ToString();

            if (soruno == 1) //A
            {
                richTextBox1.Text = "Ülkemizin güney kýsmýndaki kýyý bölgesi?";
                A.BackColor = Color.Yellow;
            }
            if (soruno == 2)//B
            {
                richTextBox1.Text = "Yeþilliði ile ünlü bir ilimiz";
                button1.BackColor = Color.Yellow;
            }
            if (soruno == 3)//C
            {
                richTextBox1.Text = "Ýnsan vücudundaki en büyük organ hangisidir?";
                button2.BackColor = Color.Yellow;
            }
            if (soruno == 4)//D
            {
                richTextBox1.Text = "Hangi element periyodik tabloda 'Fe' sembolü ile gösterilir?";
                button3.BackColor = Color.Yellow;
            }
            if (soruno == 5)//E
            {
                richTextBox1.Text = "Hangi meyve 'Granny Smith' ve 'Golden Delicious' türleriyle bilinir?";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 6)//F
            {
                richTextBox1.Text = "Hangi yazar 'Karamazov Kardeþler' adlý eseri yazmýþtýr?";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 7)//G
            {
                richTextBox1.Text = "Hangi çiçek genellikle aþkýn sembolü olarak kabul edilir?";
                button6.BackColor = Color.Yellow;
            }
            if (soruno == 8)//H
            {
                richTextBox1.Text = "Hava araçlarýnýn iniþ yapmak için kullandýðý alan?";
                button7.BackColor = Color.Yellow;
            }
            if (soruno == 9)//I
            {
                richTextBox1.Text = "Hangi ünlü bilim insaný 'Principia' adlý eseriyle ünlüdür?";
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 10)//J
            {
                richTextBox1.Text = "Bob marley nereli ?";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 11)//K
            {
                richTextBox1.Text = "Yazý yazmak için kullanýlan araç?";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 12)//L
            {
                richTextBox1.Text = "Gemirlerin yanaþtýðý yer?";
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 13)//M
            {
                richTextBox1.Text = "Askeri kara tuzaðý?";
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 14)//N
            {
                richTextBox1.Text = "Pozitifin karþýtý?";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 15)//O
            {
                richTextBox1.Text = "Ýlk okuldan sonra gelen eðitim seviyesi nedir ?";
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 16)//P
            {
                richTextBox1.Text = "Haftanýn ilk günü";
                button15.BackColor = Color.Yellow;
            }
            if (soruno == 17)//R
            {
                richTextBox1.Text = "Geri vitesin harfi";
                button16.BackColor = Color.Yellow;
            }
            if (soruno == 18)//S
            {
                richTextBox1.Text = "Koyu renk";
                button17.BackColor = Color.Yellow;
            }
            if (soruno == 19)//T
            {
                richTextBox1.Text = "Ýstanbulda ünlü bir meydan";
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 20)//U
            {
                richTextBox1.Text = "Gezegenlerin bulunduðu alan";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 21)//V
            {
                richTextBox1.Text = "Türkiyenin en büyük gölünün bulunduðu il";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 22)//Y
            {
                richTextBox1.Text = "Ýlk bahardan sonra gelen mevsim";
                button21.BackColor = Color.Yellow;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz") 
                        {
                            A.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            A.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                    break;

                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            A.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            A.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    case 3:
                        if (textBox1.Text == "cilt")
                        {
                            A.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            A.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                }
            }
        }
    }
}