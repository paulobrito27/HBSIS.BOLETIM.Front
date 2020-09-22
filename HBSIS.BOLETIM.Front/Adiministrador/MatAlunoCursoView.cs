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
    public partial class MatAlunoCursoView : Form
    {
        public MatAlunoCursoView()
        {
            InitializeComponent();
            Popula();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_ok.Text = "";
            lbl_erro1.Text = "";
            lbl_erro2.Text = "";
            lbl_erro3.Text = "";
            Aluno aluno = new Aluno();

            if(box_Alunos.Text != "" && box_Cursos.Text != "")
            {
                var id_aluno = box_Alunos.Text.Split(':');
                var id_curso = box_Cursos.Text.Split(':');
                aluno.Id = Convert.ToInt32(id_aluno[0]);
                aluno.IdCurso = Convert.ToInt32(id_curso[0]);

                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44303/");
                var request = client.PostAsync("Alunos/MatricularAlunoEmCurso", new StringContent(JsonConvert.SerializeObject(aluno), System.Text.Encoding.UTF8, "application/json"));
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
                    lbl_ok.Text = $"Curso {aluno.Nome} matriculado!";
                }
            }
            else
            {
                lbl_erro1.Text = "Informe o aluno e o curso";
            }

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
            if (resultado.Error)
            {
                lbl_erro1.Text = resultado.Message[0];
                lbl_erro2.Text = resultado.Message.Count > 1 ? resultado.Message[1] : "";
                lbl_erro3.Text = resultado.Message.Count > 2 ? resultado.Message[2] : "";
            }
            box_Alunos.Items.Clear();
            foreach (var item in resultado.Data)
            {
                box_Alunos.Items.Add($"{item.Id}: {item.Nome} {item.Sobrenome}");

            }

            request = client.GetAsync("Cursos");
            request.Wait();
            result = request.Result.Content.ReadAsStringAsync();
            result.Wait();
            var resultado2 = JsonConvert.DeserializeObject<PadraoResult<Curso>>(result.Result);
            if (resultado2.Error)
            {
                lbl_erro1.Text = resultado2.Message[0];
                lbl_erro2.Text = resultado2.Message.Count > 1 ? resultado2.Message[1] : "";
                lbl_erro3.Text = resultado2.Message.Count > 2 ? resultado2.Message[2] : "";
            }
            box_Cursos.Items.Clear();
            foreach (var item in resultado2.Data)
            {
                box_Cursos.Items.Add($"{item.Id}: {item.Nome}  [{item.Situacao}]");
            }
        }
    }
}
