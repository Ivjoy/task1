using System;
using System.Windows.Forms;
namespace testPL
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(n.Text, out int N) && int.TryParse(m.Text, out int M))
            {
                if (N <= 0 || M <= 0)
                {
                    MessageBox.Show("введены некоректные значения");
                    return;
                }

                int[] circArray = new int[N];
                for (int i = 0; i < N; i++)
                {
                    circArray[i] = i + 1;
                }

                listBoxResult.Items.Clear();
                int index = 0;

                do
                {
                    listBoxResult.Items.Add(circArray[index]);
                    index = (index + (M-1)) % N;
                } while (index != 0);

            }
            else
                MessageBox.Show("Vvedite correctnie dannie");
        }


        void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void n_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(sender, e);
        }
        private void m_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(sender, e);
        }

        
    }
}
