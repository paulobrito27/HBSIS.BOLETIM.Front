﻿using PROJETO_HBSIS.BOLETIM.MODELS.ClassesAssociativas;
using PROJETO_HBSIS.BOLETIM.MODELS.Enum;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace PROJETO_HBSIS.BOLETIM.MODELS
{
    public class Materia
    {
        public int Id { get; set;}
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public StatusMateriaEnum Situacao { get; set; }
        

 
        [IgnoreDataMember]
        public  virtual ICollection<MateriaCurso> Cursos { get; set; } = new HashSet<MateriaCurso>();


        [IgnoreDataMember]
        public  virtual ICollection<ProfessorMateria> ProfessorMaterias { get; set; } = new HashSet<ProfessorMateria>();


        [IgnoreDataMember]
        public virtual ICollection<AlunoMateria> AlunoMaterias { get; set; } = new HashSet<AlunoMateria>();
    }
}
