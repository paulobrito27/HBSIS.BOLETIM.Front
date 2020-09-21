namespace HBSIS.BOLETIM.Front.Adiministrador
{
    partial class CadastraMateriaView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listaMateria = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.lbl_ok = new System.Windows.Forms.Label();
            this.lbl_erro3 = new System.Windows.Forms.Label();
            this.lbl_erro2 = new System.Windows.Forms.Label();
            this.lbl_erro1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.comboCurso = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_vincula = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboMateria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(605, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de disciplinas";
            // 
            // listaMateria
            // 
            this.listaMateria.HideSelection = false;
            this.listaMateria.Location = new System.Drawing.Point(610, 95);
            this.listaMateria.Name = "listaMateria";
            this.listaMateria.Size = new System.Drawing.Size(311, 443);
            this.listaMateria.TabIndex = 1;
            this.listaMateria.UseCompatibleStateImageBehavior = false;
            this.listaMateria.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Situação";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(150, 56);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(380, 30);
            this.txt_nome.TabIndex = 6;
            // 
            // txt_descricao
            // 
            this.txt_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricao.Location = new System.Drawing.Point(150, 113);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(380, 117);
            this.txt_descricao.TabIndex = 7;
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(261, 286);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 8;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(40, 286);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(194, 33);
            this.comboBox.TabIndex = 9;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(29, 455);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(187, 38);
            this.btn_cadastrar.TabIndex = 10;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(1276, 95);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(152, 38);
            this.btn_deletar.TabIndex = 11;
            this.btn_deletar.Text = "DELETAR";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(1090, 95);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(152, 38);
            this.btn_alterar.TabIndex = 12;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // lbl_ok
            // 
            this.lbl_ok.AutoSize = true;
            this.lbl_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ok.Location = new System.Drawing.Point(146, 589);
            this.lbl_ok.Name = "lbl_ok";
            this.lbl_ok.Size = new System.Drawing.Size(0, 20);
            this.lbl_ok.TabIndex = 13;
            // 
            // lbl_erro3
            // 
            this.lbl_erro3.AutoSize = true;
            this.lbl_erro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro3.Location = new System.Drawing.Point(515, 727);
            this.lbl_erro3.Name = "lbl_erro3";
            this.lbl_erro3.Size = new System.Drawing.Size(0, 20);
            this.lbl_erro3.TabIndex = 14;
            // 
            // lbl_erro2
            // 
            this.lbl_erro2.AutoSize = true;
            this.lbl_erro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro2.Location = new System.Drawing.Point(515, 685);
            this.lbl_erro2.Name = "lbl_erro2";
            this.lbl_erro2.Size = new System.Drawing.Size(0, 20);
            this.lbl_erro2.TabIndex = 15;
            // 
            // lbl_erro1
            // 
            this.lbl_erro1.AutoSize = true;
            this.lbl_erro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro1.Location = new System.Drawing.Point(515, 648);
            this.lbl_erro1.Name = "lbl_erro1";
            this.lbl_erro1.Size = new System.Drawing.Size(0, 20);
            this.lbl_erro1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(962, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Informe Id para alterar ou deletar";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(967, 95);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(103, 30);
            this.txt_id.TabIndex = 18;
            // 
            // comboCurso
            // 
            this.comboCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCurso.FormattingEnabled = true;
            this.comboCurso.Location = new System.Drawing.Point(1094, 254);
            this.comboCurso.Name = "comboCurso";
            this.comboCurso.Size = new System.Drawing.Size(360, 33);
            this.comboCurso.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1097, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cursos";
            // 
            // btn_vincula
            // 
            this.btn_vincula.Location = new System.Drawing.Point(1302, 500);
            this.btn_vincula.Name = "btn_vincula";
            this.btn_vincula.Size = new System.Drawing.Size(152, 38);
            this.btn_vincula.TabIndex = 21;
            this.btn_vincula.Text = "VINCULAR MATERIA";
            this.btn_vincula.UseVisualStyleBackColor = true;
            this.btn_vincula.Click += new System.EventHandler(this.btn_vincula_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1097, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Materias";
            // 
            // comboMateria
            // 
            this.comboMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMateria.FormattingEnabled = true;
            this.comboMateria.Location = new System.Drawing.Point(1094, 380);
            this.comboMateria.Name = "comboMateria";
            this.comboMateria.Size = new System.Drawing.Size(360, 33);
            this.comboMateria.TabIndex = 23;
            // 
            // CadastraMateriaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 816);
            this.Controls.Add(this.comboMateria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_vincula);
            this.Controls.Add(this.comboCurso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_erro1);
            this.Controls.Add(this.lbl_erro2);
            this.Controls.Add(this.lbl_erro3);
            this.Controls.Add(this.lbl_ok);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaMateria);
            this.Controls.Add(this.label1);
            this.Name = "CadastraMateriaView";
            this.Text = "Cadastro de materias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listaMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label lbl_ok;
        private System.Windows.Forms.Label lbl_erro3;
        private System.Windows.Forms.Label lbl_erro2;
        private System.Windows.Forms.Label lbl_erro1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ComboBox comboCurso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_vincula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboMateria;
    }
}