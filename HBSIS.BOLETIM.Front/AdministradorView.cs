using HBSIS.BOLETIM.Front.Adiministrador;
using PROJETO_HBSIS.BOLETIM.MODELS;
using System;
using System.Threading;
using System.Windows.Forms;

namespace HBSIS.BOLETIM.Front
{
    public partial class AdministradorView : Form
    {
        Thread t1;
        public AdministradorView(Usuario user)
        {
            InitializeComponent();
            PopularItens();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            string texto = "";
            if (comboBox.SelectedItem != null)
            {
               texto = comboBox.SelectedItem.ToString();
            }
            if(texto == "Cadastrar Curso")
            {
                CadastroCursoView cad = new CadastroCursoView();
                cad.Show();
            }
            if (texto == "Cadastrar Materia")
            {
                CadastraMateriaView cad = new CadastraMateriaView();
                cad.Show();
            }
            if (texto == "Cadastrar Aluno")
            {
                CadastraAlunoView cad = new CadastraAlunoView();
                cad.Show();
            }
            if (texto == "Matricular Aluno em Curso")
            {
                MatAlunoCursoView  cad= new MatAlunoCursoView();
                cad.Show();
            }
            if (texto == "Matricular Aluno em Materia")
            {
                MatAlunoMateriaView cad = new MatAlunoMateriaView();
                cad.Show();
            }
           
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(JanelaLogin);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void JanelaLogin(object obj)
        {
            Application.Run(new LoginView());
        }


        private void PopularItens()
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("Cadastrar Curso");
            comboBox.Items.Add("Cadastrar Materia");
            comboBox.Items.Add("Cadastrar Aluno");
            comboBox.Items.Add("Matricular Aluno em Curso");
            comboBox.Items.Add("Matricular Aluno em Materia");
        }
    }
}
