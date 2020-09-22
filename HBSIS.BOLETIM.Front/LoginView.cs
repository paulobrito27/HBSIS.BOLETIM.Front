using Newtonsoft.Json;
using PROJETO_HBSIS.BOLETIM.MODELS;
using PROJETO_HBSIS.BOLETIM.MODELS.RESULTS;
using System;
using PROJETO_HBSIS.BOLETIM.MODELS.Enum;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;

namespace HBSIS.BOLETIM.Front
{
    public partial class LoginView : Form
    {
        public Usuario user;
        Thread t1;
        public LoginView()
        {
            InitializeComponent();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {

            try
            {
                var login = txt_login.Text;
                var password = txt_Senha.Text;
                user = new Usuario
                {
                    Login = login,
                    Password = password
                };

                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44303/");
                var request = client.PostAsync("Login/", new StringContent(JsonConvert.SerializeObject(user), System.Text.Encoding.UTF8, "application/json"));
                request.Wait();
                var result = request.Result.Content.ReadAsStringAsync();
                result.Wait();
                var resultado = JsonConvert.DeserializeObject<PadraoResult<Usuario>>(result.Result);

                if (!resultado.Error)
                {
                    user = resultado.Data[0];
                    this.Close();
                    if (user.TipoUsuario == TipoUsuarioEnum.ALUNO)
                    {
                        t1 = new Thread(JanelaAluno);
                    }
                    if (user.TipoUsuario == TipoUsuarioEnum.ADMINISTRADOR)
                    {
                        t1 = new Thread(JanelaAdministrador);
                    }
                    if (user.TipoUsuario == TipoUsuarioEnum.PROFESSOR)
                    {
                        t1 = new Thread(JanelaProfessor);
                    }

                    t1.SetApartmentState(ApartmentState.STA);
                    t1.Start();
                }
                else
                {
                    lbl_resposta.Text = resultado.Message[0];
                }
            }
            catch (Exception error)
            {
                lbl_resposta.Text = error.Message;
            }


        }

        private void JanelaAluno(object obj)
        {
            Application.Run(new AlunoView(user));
        }

        private void JanelaAdministrador(object obj)
        {
            Application.Run(new AdministradorView(user));
        }
        private void JanelaProfessor(object obj)
        {
            Application.Run(new ProfessorView());
        }
    }
}
