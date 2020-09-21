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
    public partial class CadastraMateriaView : Form
    {
        public CadastraMateriaView()
        {
            InitializeComponent();
            PopularDados();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            lbl_ok.Text = "";
            lbl_erro1.Text = "";
            lbl_erro2.Text = "";
            lbl_erro3.Text = "";

            Materia materia = new Materia() { Nome = txt_nome.Text };
            materia.Descricao = txt_descricao.Text;
            materia.DataCadastro = calendar.SelectionStart.Date;

            if (comboBox.SelectedItem == "Inativo")
            {
                materia.Situacao = PROJETO_HBSIS.BOLETIM.MODELS.Enum.StatusMateriaEnum.INATIVO;
            }
            if (comboBox.SelectedItem == "Ativo")
            {
                materia.Situacao = PROJETO_HBSIS.BOLETIM.MODELS.Enum.StatusMateriaEnum.ATIVO;
            }


            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44303/");
            var request = client.PostAsync("Materias/Cadastrar", new StringContent(JsonConvert.SerializeObject(materia), System.Text.Encoding.UTF8, "application/json"));
            request.Wait();
            var result = request.Result.Content.ReadAsStringAsync();
            var resultado = JsonConvert.DeserializeObject<PadraoResult<Materia>>(result.Result);

            if (resultado.Error)
            {
                lbl_erro1.Text = resultado.Message[0];
                lbl_erro2.Text = resultado.Message.Count > 1 ? resultado.Message[1] : "";
                lbl_erro3.Text = resultado.Message.Count > 2 ? resultado.Message[2] : "";
            }
            else
            {
                lbl_ok.Text = $"Materia {materia.Nome} cadastrada!";
                PopularDados();
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            lbl_ok.Text = "";
            lbl_erro1.Text = "";
            lbl_erro2.Text = "";
            lbl_erro3.Text = "";

            Materia materia = new Materia();
            if (txt_id.Text != "")
            {
                materia.Id = Convert.ToInt32(txt_id.Text);

                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44303/");
                var request = client.PostAsync("Materias/Deletar", new StringContent(JsonConvert.SerializeObject(materia), System.Text.Encoding.UTF8, "application/json"));
                request.Wait();
                var result = request.Result.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<PadraoResult<Materia>>(result.Result);

                if (resultado.Error)
                {
                    lbl_erro1.Text = resultado.Message[0];
                    lbl_erro2.Text = resultado.Message.Count > 1 ? resultado.Message[1] : "";
                    lbl_erro3.Text = resultado.Message.Count > 2 ? resultado.Message[2] : "";
                }
                else
                {
                    lbl_ok.Text = $"Materia {materia.Nome} deletada!";
                    PopularDados();
                }
            }
            else
            {
                lbl_erro1.Text = "Informe o id";
            }

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            lbl_ok.Text = "";
            lbl_erro1.Text = "";
            lbl_erro2.Text = "";
            lbl_erro3.Text = "";

            Materia materia = new Materia() { Nome = txt_nome.Text };
            materia.Descricao = txt_descricao.Text;
            materia.DataCadastro = calendar.SelectionStart.Date;

            if (txt_id.Text != "")
            {
                materia.Id = Convert.ToInt32(txt_id.Text);

                if (comboBox.SelectedItem == "Inativo")
                {
                    materia.Situacao = PROJETO_HBSIS.BOLETIM.MODELS.Enum.StatusMateriaEnum.INATIVO;
                }
                if (comboBox.SelectedItem == "Ativo")
                {
                    materia.Situacao = PROJETO_HBSIS.BOLETIM.MODELS.Enum.StatusMateriaEnum.ATIVO;
                }


                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44303/");
                var request = client.PostAsync("Materias/Alterar", new StringContent(JsonConvert.SerializeObject(materia), System.Text.Encoding.UTF8, "application/json"));
                request.Wait();
                var result = request.Result.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<PadraoResult<Materia>>(result.Result);

                if (resultado.Error)
                {
                    lbl_erro1.Text = resultado.Message[0];
                    lbl_erro2.Text = resultado.Message.Count > 1 ? resultado.Message[1] : "";
                    lbl_erro3.Text = resultado.Message.Count > 2 ? resultado.Message[2] : "";
                }
                else
                {
                    lbl_ok.Text = $"Materia {materia.Nome} atualizada!";
                    PopularDados();
                }
            }
            else
            {
                lbl_erro1.Text = "Informe o id";
            }
        }



        private void PopularDados()
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("Inativo");
            comboBox.Items.Add("Ativo");

            //=======
            var client = new HttpClient();
            using (client)
            {
                client.BaseAddress = new Uri("https://localhost:44303/");
                var request = client.GetAsync("Materias");
                request.Wait();
                var result = request.Result.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<PadraoResult<Materia>>(result.Result);

                if (!resultado.Error)
                {
                    listaMateria.Items.Clear();
                    comboMateria.Items.Clear();
                    foreach (var item in resultado.Data)
                    {

                        listaMateria.Items.Add($"{item.Id} - {item.Nome} [{item.Situacao}]");
                        comboMateria.Items.Add(item.Nome);
                    }

                }
                else if (resultado.Data.Count == 0)
                {
                    listaMateria.Items.Add("Não existe Disciplinas cadastradas na base de dados");
                }
                else
                {
                    listaMateria.Items.Add(resultado.Message[0]);
                }

            }

            var client2 = new HttpClient();
            using (client2)
            {
                client2.BaseAddress = new Uri("https://localhost:44303/");
                var request2 = client2.GetAsync("Cursos");
                request2.Wait();
                var result2 = request2.Result.Content.ReadAsStringAsync();
                var resultado2 = JsonConvert.DeserializeObject<PadraoResult<Curso>>(result2.Result);

                if (!resultado2.Error)
                {
                    comboCurso.Items.Clear();

                    foreach (var curso in resultado2.Data)
                    {
                        comboCurso.Items.Add($"{curso.Nome}");
                    }
                }

            }  

        }

        private void btn_vincula_Click(object sender, EventArgs e)
        {
            (string, string) dados;

            dados.Item1 = comboCurso.SelectedItem.ToString();
            dados.Item2 = comboMateria.SelectedItem.ToString();

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44303/");
            var request = client.PostAsync("Cursos/AddMateria", new StringContent(JsonConvert.SerializeObject(dados), System.Text.Encoding.UTF8, "application/json"));
            request.Wait();
            var result = request.Result.Content.ReadAsStringAsync();
            var resultado = JsonConvert.DeserializeObject<PadraoResult<Curso>>(result.Result);

            if (resultado.Error)
            {
                lbl_erro1.Text = resultado.Message[0];
                lbl_erro2.Text = resultado.Message.Count > 1 ? resultado.Message[1] : "";
                lbl_erro3.Text = resultado.Message.Count > 2 ? resultado.Message[2] : "";
            }
            else
            {
                lbl_ok.Text = $"Materia  vinculada!";
                PopularDados();
            }
        }
    }
}
