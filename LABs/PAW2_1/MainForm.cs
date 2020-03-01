using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAW2_1
{
    public partial class SumatorSiAtat : Form //partial spune ca declararea clasei e impartita in mai multe fisiere
    {
        public SumatorSiAtat()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //in momentul in care se deschide formul se ruleaza codul din metoda
        {

        }

        private void btnAdunare_Click(object sender, EventArgs e)
        {
            int t1 = int.Parse(tbTermen1.Text);  
            //se face referinta la valoarea din text box dupa numele text boxului. Textul e string default, trebuie convertit la int
            int t2 = int.Parse(tb_Termen2.Text);
            int suma = t1 + t2;
            tbRezultat.Text = suma.ToString(); 
            //se face conversia la string pentru a putea afisa valoarea in text boxul suma

        }

        private void tbTermen1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbTermen1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar)==false && e.KeyChar!= (char)Keys.Back)  //compara caracterul introdus si cu backspace folosing cast la char. Keys. listeaza caracterele speciale
            {
                e.Handled = true; //handled = true nu permite scrierea in casuta. 
            }
        }
    }
}
