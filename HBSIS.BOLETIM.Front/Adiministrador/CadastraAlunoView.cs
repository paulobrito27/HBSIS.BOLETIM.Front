using Newtonsoft.Json;
using PROJETO_HBSIS.BOLETIM.MODELS;
using PROJETO_HBSIS.BOLETIM.MODELS.RESULTS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBSIS.BOLETIM.Front.Adiministrador
{
    public partial class CadastraAlunoView : Form
    {
        public CadastraAlunoView()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            lbl_ok.Text = "";
            lbl_erro1.Text = "";
            lbl_erro2.Text = "";
            lbl_erro3.Text = "";

            Aluno aluno = new Aluno() {
                Nome = txt_nome.Text,
                Sobrenome = txt_sobrenome.Text,
                Cpf = txt_cpf.Text,
                DataNascimento = calendar.SelectionStart.Date
            };
            

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44303/");
            var request = client.PostAsync("Alunos/Cadastrar", new StringContent(JsonConvert.SerializeObject(aluno), System.Text.Encoding.UTF8, "application/json"));
            request.Wait();
            var result = request.Result.Content.ReadAsStringAsync();
            var resultado = JsonConvert.DeserializeObject<PadraoResult<Aluno>>(result.Result);

            if (resultado.Error)
            {
                lbl_erro1.Text = resultado.Message[0];
                lbl_erro2.Text = resultado.Message.Count > 1 ? resultado.Message[1] : "";
                lbl_erro3.Text = resultado.Message.Count > 2 ? resultado.Message[2] : "";
            }
            else
            {
                lbl_ok.Text = $"Curso {aluno.Nome} cadastrado!";
                lbl_erro1.Text = $"Login e senha padrão gerados automaticamente:";
                lbl_erro2.Text = $"Login: {resultado.Data[0].Login}";
                lbl_erro3.Text = $"Senha: {resultado.Data[0].Password}";
            }
        }
    }
}
