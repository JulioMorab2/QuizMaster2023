﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizMaster.Infra.DataAcces
{
    using QuizMaster.Dominio.Model.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuizMasterEntities1 : DbContext
    {
        public QuizMasterEntities1()
            : base("name=QuizMasterEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alumnos> Alumnos { get; set; }
        public virtual DbSet<AlumnosGrupos> AlumnosGrupos { get; set; }
        public virtual DbSet<AsignacionCuestionario> AsignacionCuestionario { get; set; }
        public virtual DbSet<Cat_TipoDocumento> Cat_TipoDocumento { get; set; }
        public virtual DbSet<Cuestionarios> Cuestionarios { get; set; }
        public virtual DbSet<Instrucciones> Instrucciones { get; set; }
        public virtual DbSet<Materias> Materias { get; set; }
        public virtual DbSet<Preguntas> Preguntas { get; set; }
        public virtual DbSet<Quimestre> Quimestre { get; set; }
        public virtual DbSet<Respuestas> Respuestas { get; set; }
        public virtual DbSet<RespuestasAlumnosCuestionarios> RespuestasAlumnosCuestionarios { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}
