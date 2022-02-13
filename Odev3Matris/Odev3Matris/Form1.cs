using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev3Matris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnIslem.Enabled = false;
            sayilar = new List<int>();
        }
        List<int> sayilar;
        int index = 0;
        int size = 0;  
        private void btnSayiEkle_Click(object sender, EventArgs e)
        {
            try
            {
                sayilar.Add(Convert.ToInt16(tbSayilar.Text));
                index++;
                if (index == size)
                {
                    MessageBox.Show("Dizi Sınırına Ulaşıldı. Artık İşlem Yapabilirsiniz.");
                    btnIslem.Enabled = true;
                    btnSayiEkle.Enabled = false;
                    tbSayilar.Clear();
                }
                tbSayilar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbBoyut_Leave(object sender, EventArgs e)
        {
            int[] boyutlar = new[] { 4,9,16,25,36,49,64,81,100,121,169};
            try
            {
                size = Convert.ToInt16(tbBoyut.Text);
                if (boyutlar.Contains(size))
                {
                    tbBoyut.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Kare matris olabilmesi için geçerli size girmelisiniz!!\nÖrn: 4 - 9 - 16 - 25");
                }                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Boyut Alanı Boş Bırakılamaz.");
            }
        }
        int counter = 0;
        int counter2 = 0;
        private void btnIslem_Click(object sender, EventArgs e)
        {
            tbBoyut.Text = "";
            int byt = Convert.ToInt32(Math.Sqrt(size));
            int[,] matrix = new int[byt,byt];
            int[] firstAxis = new int[byt];
            int[] secondAxis = new int[byt];
            string first = "";
            string second = "";
            string temp = "";

            try
            {
                for (int i = 0; i < byt; i++)
                {
                    for (int j = 0; j < byt; j++)
                    {
                        matrix[i, j] = sayilar[counter];
                        temp += matrix.GetValue(i,j).ToString() + "\t";
                        counter++;
                    }
                    lbxMatrix.Items.Add(temp + "\n");
                    temp = "";
                }

                for (int i = 0; i < byt; i++)
                {
                    firstAxis[i] = matrix[i, i];
                    first += firstAxis[i].ToString() + " - ";
                }

                for (int i = 0, j = byt - 1; i < byt && j >= 0; i++, j--)
                {
                    secondAxis[counter2] = matrix[i, j];
                    second += secondAxis[counter2].ToString() + " - ";
                    counter2++;
                }

                lblTwoAxis.Text = first + " , " + second;
                lblFirstAxis.Text = first;
                lblSecondAxis.Text = second;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbBoyut.Text = "";
            tbSayilar.Text = "";
            btnSayiEkle.Enabled = true;
            lbxMatrix.Items.Clear();
            lblTwoAxis.Text = "";
            lblFirstAxis.Text = "";
            lblSecondAxis.Text = "";
            tbBoyut.Enabled = true;
            index = 0;
            counter = 0;
            counter2 = 0;
        }
    }
}
