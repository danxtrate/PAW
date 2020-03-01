using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAW2_3
{
    public partial class MainForm : Form
    {
        private List<Participant> participants; //atribut privat - Lista de participanti
        public MainForm()
        {
            
            InitializeComponent();

            participants = new List<Participant>(); // se initializeaza lista de participants
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            string lastName = tbLastName.Text.Trim(); //Trim sterge spatiile 
            if (lastName.Length<3)
            {
                epLastName.SetError(tbLastName, "3 letters minimum, esse");
                e.Cancel = true; //utilizatorul nu poate parasi controlul pana nu pune ce trebuie
            }
        }

        private void tbLastName_Validated(object sender, EventArgs e)
        {
            epLastName.Clear(); //sterge simbolul rosu
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            string firstName = tbFirstName.Text.Trim();
            if(firstName.Length <3)
            {
                epFirstName.SetError(tbFirstName, "3 letters minimum");
                e.Cancel = true;
            }
        }

        private void tbFirstName_Validated(object sender, EventArgs e)
        {
            epFirstName.Clear();
        }

        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string lastName = tbLastName.Text.Trim();
            if (lastName.Length < 3)
            {
                epLastName.SetError(tbLastName, "3 letters minimum, esse");
                isValid = false;
            }

            string firstName = tbFirstName.Text.Trim();
            if (firstName.Length < 3)
            {
                epFirstName.SetError(tbFirstName, "3 letters minimum");
                isValid = false;
            }
            if (!isValid)
                MessageBox.Show("The Contains Errors", "Errors",MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var participant = new Participant(lastName, firstName, dtpBirthDay.Value);
                participants.Add(participant);
                DisplayParticipants(); //se apeleaza metoda de mai jos. 

                //se reseteaza valorile campurilor dupa ce se adauga o persoana
                tbLastName.Text = string.Empty;
                tbFirstName.Text = string.Empty;
                dtpBirthDay.Value = DateTime.Now;
            }

        }

        void DisplayParticipants()
        {
            lvParticipants.Items.Clear(); //sterge inregistrarile din ListView
            foreach(var participant in participants)
            {
                var lvi = new ListViewItem(participant.LastName); //list view item primeste valoare LastName
                lvi.SubItems.Add(participant.FirstName);
                lvi.SubItems.Add(participant.BirthDate.ToString());
                lvParticipants.Items.Add(lvi);
            }
        }

        private void dtpBirthDay_Validating(object sender, CancelEventArgs e)
        {
            // dtpBirthDay.Value.Year  //de terminat acasa
           // DateTime.Now.Year
        }
    }
}
