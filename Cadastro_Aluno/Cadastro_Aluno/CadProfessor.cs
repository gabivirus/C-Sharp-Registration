using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Aluno
{
    public partial class CadProfessor : Form
    {
        public CadProfessor()
        {
            InitializeComponent();
        }

        public void showPerson()
        {
            System.Windows.Forms.MessageBox.Show("Nome: " + nameBox.Text + "\nIdade: " + ageBox.Text + "\nSalário: " + wageBox.Text + "\nMatéria: " + matterBox.Text);
        }

        private void Register_Click(object sender, EventArgs e)
        {
            {
                Professor student = new Professor();

                student.name = nameBox.Text;
                student.age = Convert.ToInt32(ageBox.Text);
                student.wage = Convert.ToDouble(wageBox.Text);
                student.matter = matterBox.Text;

                showPerson();
            }
        }
    }
}
