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
            linkLabel1.Text = "SONRAK�";

            soruno++;
            this.Text = soruno.ToString();

            if (soruno == 1) //A
            {
                richTextBox1.Text = "�lkemizin g�ney k�sm�ndaki k�y� b�lgesi?";
                A.BackColor = Color.Yellow;
            }
            if (soruno == 2)//B
            {
                richTextBox1.Text = "Ye�illi�i ile �nl� bir ilimiz";
                button1.BackColor = Color.Yellow;
            }
            if (soruno == 3)//C
            {
                richTextBox1.Text = "�nsan v�cudundaki en b�y�k organ hangisidir?";
                button2.BackColor = Color.Yellow;
            }
            if (soruno == 4)//D
            {
                richTextBox1.Text = "Hangi element periyodik tabloda 'Fe' sembol� ile g�sterilir?";
                button3.BackColor = Color.Yellow;
            }
            if (soruno == 5)//E
            {
                richTextBox1.Text = "Hangi meyve 'Granny Smith' ve 'Golden Delicious' t�rleriyle bilinir?";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 6)//F
            {
                richTextBox1.Text = "Hangi yazar 'Karamazov Karde�ler' adl� eseri yazm��t�r?";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 7)//G
            {
                richTextBox1.Text = "Hangi �i�ek genellikle a�k�n sembol� olarak kabul edilir?";
                button6.BackColor = Color.Yellow;
            }
            if (soruno == 8)//H
            {
                richTextBox1.Text = "Hava ara�lar�n�n ini� yapmak i�in kulland��� alan?";
                button7.BackColor = Color.Yellow;
            }
            if (soruno == 9)//I
            {
                richTextBox1.Text = "Hangi �nl� bilim insan� 'Principia' adl� eseriyle �nl�d�r?";
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 10)//J
            {
                richTextBox1.Text = "Bob marley nereli ?";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 11)//K
            {
                richTextBox1.Text = "Yaz� yazmak i�in kullan�lan ara�?";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 12)//L
            {
                richTextBox1.Text = "Gemirlerin yana�t��� yer?";
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 13)//M
            {
                richTextBox1.Text = "Askeri kara tuza��?";
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 14)//N
            {
                richTextBox1.Text = "Pozitifin kar��t�?";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 15)//O
            {
                richTextBox1.Text = "�lk okuldan sonra gelen e�itim seviyesi nedir ?";
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 16)//P
            {
                richTextBox1.Text = "Haftan�n ilk g�n�";
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
                richTextBox1.Text = "�stanbulda �nl� bir meydan";
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 20)//U
            {
                richTextBox1.Text = "Gezegenlerin bulundu�u alan";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 21)//V
            {
                richTextBox1.Text = "T�rkiyenin en b�y�k g�l�n�n bulundu�u il";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 22)//Y
            {
                richTextBox1.Text = "�lk bahardan sonra gelen mevsim";
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