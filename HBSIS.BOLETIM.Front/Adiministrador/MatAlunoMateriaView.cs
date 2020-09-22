using Newtonsoft.Json;
using PROJETO_HBSIS.BOLETIM.MODELS;
using PROJETO_HBSIS.BOLETIM.MODELS.RESULTS;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace HBSIS.BOLETIM.Front.Adiministrador
{
    public partial class MatAlunoMateriaView : Form
    {
        public MatAlunoMateriaView()
        {
            InitializeComponent();
            Popula();
        }

        private void Popula()
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44303/");
            var request = client.GetAsync("Alunos");
            request.Wait();
            var result = request.Result.Content.ReadAsStringAsync();
            result.Wait();
            var resultado = JsonConvert.DeserializeObject<PadraoResult<Aluno>>(result.Result);

            box_Aluno.Items.Clear();
            foreach (var item in resultado.Data)
            {
                if (item.IdCurso != 0)
                {
                    box_Aluno.Items.Add($"{item.Id}: {item.Nome} {item.Sobrenome}");
                }

            }

            request = client.GetAsync("Materias");
            request.Wait();
            result = request.Result.Content.ReadAsStringAsync();
            result.Wait();
            var resultado2 = JsonConvert.DeserializeObject<PadraoResult<Materia>>(result.Result);

            box_Materia.Items.Clear();
            foreach (var item in resultado2.Data)
            {

                box_Materia.Items.Add($"{item.Id}: {item.Nome} ");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_ok.Text = "";
            lbl_erro1.Text = "";
            lbl_erro2.Text  ="";
            lbl_erro3.Text  ="";

            var id_aluno = box_Aluno.SelectedItem.ToString().Split(':');
            var id_materia = box_Materia.SelectedItem.ToString().Split(':');

            (int, int) itens = (Convert.ToInt32(id_aluno[0]), Convert.ToInt32(id_materia[0]));


            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44303/");
            var request = client.PostAsync("Alunos/MatricularAlunoEmMateria", new StringContent(JsonConvert.SerializeObject(itens), System.Text.Encoding.UTF8, "application/json"));
            request.Wait();
            var result = request.Result.Content.ReadAsStringAsync();
            result.Wait();
            var resultado = JsonConvert.DeserializeObject<PadraoResult<Aluno>>(result.Result);

            if (resultado.Error)
            {
                lbl_erro1.Text = resultado.Message[0];
                lbl_erro2.Text = resultado.Message.Count > 1 ? resultado.Message[1] : "";
                lbl_erro3.Text = resultado.Message.Count > 2 ? resultado.Message[2] : "";
            }
            else
            {
                lbl_ok.Text = $"Aluno {resultado.Data[0].Nome} matriculado!";
                
            }
        }
    }
}
