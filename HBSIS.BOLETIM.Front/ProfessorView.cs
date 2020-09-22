using Newtonsoft.Json;
using PROJETO_HBSIS.BOLETIM.MODELS;
using PROJETO_HBSIS.BOLETIM.MODELS.RESULTS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;

namespace HBSIS.BOLETIM.Front
{
    public partial class ProfessorView : Form
    {
        private List<Aluno> listaAlunos = new List<Aluno>();
        Thread t1;
        public ProfessorView()
        {
            InitializeComponent();
            PopularDados();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            lbl_erro1.Text = "";
            lbl_erro2.Text = "";
            lbl_erro3.Text = "";
            lbl_ok.Text = "";

            try
            {

                if (boxAluno.SelectedItem != null && boxMateria.SelectedItem != null)
                {
                    (int, int, double) dados;

                    var id_aluno = boxAluno.SelectedItem.ToString().Split(':');
                    var id_materia = boxMateria.SelectedItem.ToString().Split(':');
                    var nota = txtNota.Text;


                    dados.Item1 = Convert.ToInt32(id_aluno[0]);
                    dados.Item2 = Convert.ToInt32(id_materia[0]);
                    dados.Item3 = Convert.ToDouble(nota);

                    var client = new HttpClient();
                    client.BaseAddress = new Uri("https://localhost:44303/");
                    var request = client.PostAsync("Alunos/AtribuirNotaAluno", new StringContent(JsonConvert.SerializeObject(dados), System.Text.Encoding.UTF8, "application/json"));
                    request.Wait();
                    var result = request.Result.Content.ReadAsStringAsync();
                    result.Wait();
                    var resultado = JsonConvert.DeserializeObject<PadraoResult<Curso>>(result.Result);

                    if (resultado.Error)
                    {
                        lbl_erro1.Text = resultado.Message[0];
                        lbl_erro2.Text = resultado.Message.Count > 1 ? resultado.Message[1] : "";
                        lbl_erro3.Text = resultado.Message.Count > 2 ? resultado.Message[2] : "";
                    }
                    else
                    {
                        lbl_ok.Text = $"Nota Atribuida !";
                    }

                }
                else
                {
                    lbl_erro1.Text = "Selecione  um aluno e uma materia";
                }
            }
            catch (Exception msg)
            {
                lbl_erro1.Text = msg.Message;
            }

        }


        private void boxAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxMateria.Items.Clear();

            if (boxAluno.SelectedItem != null)
            {
                var id_aluno = boxAluno.SelectedItem.ToString().Split(':');
                int id = Convert.ToInt32(id_aluno[0]);

                Aluno aluno = listaAlunos.Where(q => q.Id == id).FirstOrDefault();

                foreach (var materia in aluno.Curso.Materias)
                {
                    boxMateria.Items.Add($"{materia.Materia.Id}: {materia.Materia.Nome}");
                }
            }
            else
            {
                lbl_erro1.Text = "Selecione um aluno";
            }

        }


        private void PopularDados()
        {
            boxAluno.Items.Clear();
            boxMateria.Items.Clear();

            //=======

            var client2 = new HttpClient();
            using (client2)
            {
                client2.BaseAddress = new Uri("https://localhost:44303/");
                var request2 = client2.GetAsync("Alunos");
                request2.Wait();
                var result2 = request2.Result.Content.ReadAsStringAsync();
                result2.Wait();
                var resultado2 = JsonConvert.DeserializeObject<PadraoResult<Aluno>>(result2.Result);

                if (!resultado2.Error)
                {
                    listaAlunos = resultado2.Data;
                    boxAluno.Items.Clear();

                    foreach (var aluno in resultado2.Data)
                    {
                        boxAluno.Items.Add($"{aluno.Id}:  {aluno.Nome}");
                    }
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
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

    }
}
