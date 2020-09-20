using Newtonsoft.Json;
using PROJETO_HBSIS.BOLETIM.MODELS;
using PROJETO_HBSIS.BOLETIM.MODELS.ClassesAssociativas;
using PROJETO_HBSIS.BOLETIM.MODELS.RESULTS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBSIS.BOLETIM.Front
{
    public partial class AlunoView : Form
    {

        Thread t1;
        public AlunoView(Usuario user)
        {
            InitializeComponent();

            PopularDados(user);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(JanelaLogin);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void PopularDados(Usuario usuario)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44303/");
            var request = client.PostAsync("Alunos/ListarNotaAluno", new StringContent(JsonConvert.SerializeObject(usuario), System.Text.Encoding.UTF8, "application/json"));
            request.Wait();
            var result = request.Result.Content.ReadAsStringAsync();
            var resultado = JsonConvert.DeserializeObject<PadraoResult<AlunoMateria>>(result.Result);

            if (!resultado.Error)
            {
                list_notas.Items.Clear();
                
                foreach (var item in resultado.Data)
                {
                   list_notas.Items.Add($"{item.Materia.Nome}   =>  {item.Nota} ");
                }

                lblNome.Text = "Nome: "+ usuario.Nome;
                lblSobrenome.Text = "Sobrenome: " + usuario.Sobrenome;
                lblCpf.Text = "Cpf: " + usuario.Cpf;

                lblLogin.Text = "Login: " + usuario.Login;
                lblSenha.Text = "Senha: " + usuario.Password;
            }
            else
            {
                list_notas.Items.Add("O aluno não esta matriculado em nenhuma disciplina");
            }
        }

        private void JanelaLogin(object obj)
        {
            Application.Run(new LoginView());
        }
    }
}
