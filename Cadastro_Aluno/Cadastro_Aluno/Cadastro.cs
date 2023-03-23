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
    public partial class Cadastro : Form
    {
        public void initAluno()
        {
            CadAluno alunoForm = new CadAluno();
            alunoForm.Show();
            this.Hide();
        }

        public void initProfessor()
        {
            CadProfessor profForm = new CadProfessor();
            profForm.Show();
            this.Hide();
        }

        public Cadastro()
        {
            InitializeComponent();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            initAluno();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initAluno();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            initProfessor();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initProfessor();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = DateTime.Now.ToString();
        }
    }
}
