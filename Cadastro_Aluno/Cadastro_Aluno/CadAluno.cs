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
    public partial class CadAluno : Form
    {
        public CadAluno()
        {
            InitializeComponent();
        }

        public void showPerson()
        {
            System.Windows.Forms.MessageBox.Show("Nome: " + nameBox.Text + "\nIdade: " + ageBox.Text + "\nMatrícula: " + registerBox.Text + "\nCurso: " + courseBox.Text);
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Aluno student = new Aluno();

            student.name = nameBox.Text;
            student.age = Convert.ToInt32(ageBox.Text);
            student.regs = Convert.ToInt32(registerBox.Text);
            student.course = courseBox.Text;

            showPerson();
        }
    }
}
