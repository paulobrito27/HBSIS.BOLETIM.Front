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
    public partial class CadastroCursoView : Form
    {
        public CadastroCursoView()
        {
            InitializeComponent();
            PopularDados();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            lbl_ok.Text = "";
            lbl_erro1.Text = "";
            lbl_erro2.Text =  "";
            lbl_erro3.Text = "";

            Curso curso = new Curso() { Nome = txt_Curso.Text };
            if(comboBox.SelectedItem == "Cancelado")
            {
                curso.Situacao = PROJETO_HBSIS.BOLETIM.MODELS.Enum.StatusCursoEnum.CANCELADO;
            }
            if (comboBox.SelectedItem == "Ativo")
            {
                curso.Situacao = PROJETO_HBSIS.BOLETIM.MODELS.Enum.StatusCursoEnum.ATIVO;
            }
            if (comboBox.SelectedItem == "Previsto")
            {
                curso.Situacao = PROJETO_HBSIS.BOLETIM.MODELS.Enum.StatusCursoEnum.PREVISTO;
            }

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44303/");
            var request = client.PostAsync("Cursos/Cadastrar", new StringContent(JsonConvert.SerializeObject(curso), System.Text.Encoding.UTF8, "application/json"));
            request.Wait();
            var result = request.Result.Content.ReadAsStringAsync();
            var resultado = JsonConvert.DeserializeObject<PadraoResult<Curso>>(result.Result);

            if (resultado.Error)
            {
                lbl_erro1.Text = resultado.Message[0];
                lbl_erro2.Text = resultado.Message.Count > 1? resultado.Message[1] : "";
                lbl_erro3.Text = resultado.Message.Count > 2 ? resultado.Message[2] : "";
            }
            else
            {
                lbl_ok.Text = $"Curso {curso.Nome} cadastrado!";
                PopularDados();
            }

        }

       private void PopularDados()
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("Cancelado");
            comboBox.Items.Add("Ativo");
            comboBox.Items.Add("Previsto");

            //=======
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44303/");
            var request = client.GetAsync("Cursos");
            request.Wait();
            var result = request.Result.Content.ReadAsStringAsync();
            var resultado = JsonConvert.DeserializeObject<PadraoResult<Curso>>(result.Result);

            if (!resultado.Error)
            {
                llist_Cursos.Items.Clear();

                foreach (var item in resultado.Data)
                {
                    llist_Cursos.Items.Add($"{item.Nome}   ({item.Situacao})");
                    
                }

            }
            else if(resultado.Data.Count == 0)
            {
                llist_Cursos.Items.Add("Não existe Cursos cadastrados na base de dados");
            }
            else
            {
                llist_Cursos.Items.Add(resultado.Message[0]);
            }
        }
    }
}
