using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10022022
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

        private void button1_Click(object sender, EventArgs e)
        {
            #region Koleksiyonlar
            /*
            Dizilerle aynı amacı taşıyan birden fazla veri tipi tutan ve yönetmemizi sağlayan yapılardır.
            Değer olarak obje tutar.
            OOP da kullanılan veri yapılarının başını çeker.
            Dizilerde indexer içerisine dizi boyutu verirken koleksiyonlarda buna gerek yoktur. Yani sınırlılık yoktur.
            En temel farklardan birisi budur mülakatlarda çıkabilir.
            Fakat diziler daha hızlı çalışır.
            Bazı koleksiyon tipleri; ArrayList, Dictionary, HashTable, Queue, SortedList, Stack
            using System.Collections; kod parçacığı eklenmelidir.
            Çok önemli bir özelliğide koleksiyonlarda obje türünden değer atadığımızdan veri tipi vermek zorunda değiliz.
            Koleksiyonlarda boyuta length ile değil Count ile bakarız.
             */
            #endregion

            ArrayList array = new ArrayList();
            array.Add("Cemil");
            array.Add(13);
            array.Add(9f);
            array.Add(new string[] { "Arif", "Bora", "Onur" });

            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] is string)
                {
                    MessageBox.Show("Değer alfanümeriktir.");
                }else if (array[i] is int)
                {
                    MessageBox.Show("Değer sayısaldır");
                }
                else if (array[i] is float)
                {
                    MessageBox.Show("Değer float");
                }
                else
                {
                    foreach (var item in array[3].ToString())
                    {
                        MessageBox.Show(item.ToString());
                    }
                }
            }

        }
        Hashtable sehirler = new Hashtable();
        private void button2_Click(object sender, EventArgs e)
        {
            /*
            Hashtable koleksiyonundada Dictionary gibi key ve value değerleri karşımıza çıkar.
            Obje tipinde bir koleksiyondur. İstenilen her tip depolanabilir.
            Değer veya referans tip olmak üzere her türlü tip depolanır.
            Veri depolama ve sunma sırasında boxing ve unboxing gerçekleşir. Bu sebeple Dictionaryden yavaştır.
            Tip güvenli değildir.
            Verileri key-value olarak tutar.
            system.collections.generic
            Dictionaryden bir diğer farkı veri tipi belirtmek zorunda değiliz.
            Dictionaryler Generic yapılardır, system.collection den türer, çalışma zamanında gereksiz cast yani boxing unboxing kullanılmasını önlerler ve bu da performans sağlar. Hashtable generic bir yapıdır performans açısından daha dezavantajlı bir durumdadır.
            Bir diğer önemli hususta type safe durumudur, hashtable koleksiyonu nontypesafe dir yani tip güvenli değildir.
            Her ikisininde çok farklı kullanım şekilleri algoritma ve mimari açısından mevcut bu farklar detaylıca tarafınıza incelenmesi gerecek durumlar olabilir.
             */

            sehirler.Add("100","Afyon");
            sehirler.Add("200","İstanbul");
            sehirler.Add("300","Konya");
            sehirler.Add("400", "Bursa");

            foreach (string item in sehirler.Keys)
            {
                MessageBox.Show(sehirler[item].ToString());
            }
        }
    }
}
