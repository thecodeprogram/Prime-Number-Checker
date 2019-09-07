/*
 This program built to show how to create and start multiple threads for multiple events.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Asalci
{
    public partial class Form1 : Form
    {
        //this area is starting of the program
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            refresh_form();
            
        }

        //We do not know how many threads will to be needed. So we need a thread array like this.
        Thread[] treads = { };
        bool contunie = true;
        bool should_check = true;

        //From this class we will use the check function
        fonksiyonlar function = new fonksiyonlar();

        //All thread's startings and endings
        int[] startings = { };
        int[] endings = { };


        //setting up on start
        public void refresh_form()
        {
            count_db();
            starting_from();
            count_thread();
            kontrol_aralik();
            max_value();
            set_threads();
        }

        //How many prime number recorded on DB
        public void count_db()
        {
            using (linqDataContext linq = new linqDataContext())
            {
                int value = (from p in linq.sayilars select p).Count();
                lblPrimeNumberCounter.Text = value.ToString();
            }
        }

        //Fetch the starting number from DB
        public void starting_from()
        {
            using (linqDataContext linq = new linqDataContext())
            {
                var query = (from p in linq.sayilars orderby p.sayi descending select p).First();
                lblChecked.Text = (Convert.ToInt32(query.sayi) + 2).ToString();
            }
        }

        //How many threads we need to make checking easier
        public void count_thread()
        {
            using (linqDataContext linq = new linqDataContext())
            {
                int value = (from p in linq.sayilars select p).Count();
                lblThreadsNeed.Text = (value < 100 ? 2 : ((value / 100) + 1)).ToString();
            }
        }

        //Thread to set range of numbers to check
        public void kontrol_aralik()
        {
            int value = (Convert.ToInt32(Math.Sqrt((Convert.ToInt32(lblChecked.Text))) - 2) / Convert.ToInt32(lblThreadsNeed.Text));
            lblThreadCheckBetween.Text = value.ToString();
        }

        public void max_value()
        {
            lblMaxValue.Text = Convert.ToInt32(Math.Sqrt(Convert.ToInt32(lblChecked.Text))).ToString();
        }

        //Prepare the threads to check prime numbers
        public void set_threads()
        {
            string log = "";
            txtLog.Text = "";
            int starting = 2;
            int counter = 0;
        baslangic:
            log += "Thread " + counter.ToString() + " => Starting : " + Convert.ToInt32(starting).ToString() + " ; Ending : " + (starting + Convert.ToInt32(lblThreadCheckBetween.Text)).ToString() + Environment.NewLine;
        
        using (linqDataContext linq = new linqDataContext())
        {
            temp tmp = new temp();
            {
                tmp.th = counter;
                tmp.bas = starting;
                tmp.son = starting + Convert.ToInt32(lblThreadCheckBetween.Text);
            }
            linq.temps.InsertOnSubmit(tmp);
            linq.SubmitChanges();
        }
        starting += Convert.ToInt32(lblThreadCheckBetween.Text);
        counter++;

            if(counter < Convert.ToInt32(lblThreadsNeed.Text)) goto baslangic;

            if (starting < int.Parse(lblMaxValue.Text))
            {
                log += "Thread " + counter.ToString() + " => Starting : " + Convert.ToInt32(starting).ToString() + " ; Ending : " + (Convert.ToInt32(lblMaxValue.Text)).ToString() + Environment.NewLine;
                using (linqDataContext linq = new linqDataContext())
                {
                    temp tmp = new temp();
                    {
                        tmp.th = counter;
                        tmp.bas = starting;
                        tmp.son = starting + Convert.ToInt32(lblThreadCheckBetween.Text);
                    }
                    linq.temps.InsertOnSubmit(tmp);
                    linq.SubmitChanges();
                }
            }


             
            txtLog.Text = log;
        }

        //control the numbers
        public void control_prime_numbers(int bas, int son)
        {
            try
            {
                for (int i = bas; i < son; i++)
                {
                    if (function.isPrime(i))
                    {
                        lblPrimeState.Text = "Prime Number";
                        using (linqDataContext linq = new linqDataContext())
                        {
                            var query = (from p in linq.sayilars where p.sayi < Convert.ToInt32(lblMaxValue.Text) select p);
                            int result = 0;
                            foreach (var item in query)
                            {
                                if (Convert.ToInt32(lblChecked.Text) % Convert.ToInt32(item.sayi.ToString()) == 0) result++;
                            }

                            if (should_check && result == 0)
                            {
                                should_check = false;

                                sayilar primes = new sayilar();
                                {
                                    primes.sayi = Convert.ToInt32(lblChecked.Text);
                                }
                                linq.sayilars.InsertOnSubmit(primes);
                                linq.SubmitChanges();

                                lblChecked.Text = (Convert.ToInt32(lblChecked.Text) + 2).ToString();

                                break;
                            }
                            else
                            {

                                result = 0;
                                lblChecked.Text = (Convert.ToInt32(lblChecked.Text) + 2).ToString();
                                break;
                            }
                        }
                    }
                    else lblPrimeState.Text = "Not Prime";
                }
            }
            catch { }
            finally { }
        }

        //main function of the program
        public bool main_function()
        {
            if (contunie)
            {
                using (linqDataContext linq = new linqDataContext())
                {
                    var sorgu = (from p in linq.temps select p);
                    foreach (var item in sorgu)
                    {
                        Thread th = new Thread(() => control_prime_numbers(Convert.ToInt32(item.bas), Convert.ToInt32(item.son)));
                        th.Start();
                    }

                    temp tmp = new temp();
                    linq.ExecuteCommand("delete from temp");

                }
                return true;
            }
            else
            {
                backgroundWorker1.CancelAsync();
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (linqDataContext linq = new linqDataContext())
            {
                temp tmp = new temp();
                linq.ExecuteCommand("delete from temp");

            }
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {

            contunie = true;
            backgroundWorker1.RunWorkerAsync();
        }

        void Application_Idle(object sender, EventArgs e)
        {
            
                
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (main_function())
            {
                main_function();
                count_db();
                //baslanacak_sayi();
                count_thread();
                kontrol_aralik();
                max_value();
                set_threads();
                should_check = true;
                
            }
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            contunie = false;
            backgroundWorker1.CancelAsync();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
