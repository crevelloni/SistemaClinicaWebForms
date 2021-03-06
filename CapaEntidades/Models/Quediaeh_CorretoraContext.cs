﻿//// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
//using System;
//using System.Data.Entity;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

//namespace CapaApresentacao.Models
//{
//    public partial class Quediaeh_CorretoraContext : DbContext
//    {
//        public Quediaeh_CorretoraContext()
//        {
//        }

//        public Quediaeh_CorretoraContext(DbContextOptions<Quediaeh_CorretoraContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<Aseguradora> Aseguradora { get; set; }
//        public virtual DbSet<Cita> Cita { get; set; }
//        public virtual DbSet<DetalleAseguradora> DetalleAseguradora { get; set; }
//        public virtual DbSet<DiaSemana> DiaSemana { get; set; }
//        public virtual DbSet<Diagnostico> Diagnostico { get; set; }
//        public virtual DbSet<Empleado> Empleado { get; set; }
//        public virtual DbSet<Especialidad> Especialidad { get; set; }
//        public virtual DbSet<HistoriaClinica> HistoriaClinica { get; set; }
//        public virtual DbSet<Hora> Hora { get; set; }
//        public virtual DbSet<HorarioAtencion> HorarioAtencion { get; set; }
//        public virtual DbSet<Medico> Medico { get; set; }
//        public virtual DbSet<Paciente> Paciente { get; set; }
//        public virtual DbSet<TipoEmpleado> TipoEmpleado { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.HasAnnotation("Relational:DefaultSchema", "FasoGeral");

//            modelBuilder.Entity<Aseguradora>(entity =>
//            {
//                entity.HasKey(e => e.IdAseguradora);

//                entity.ToTable("Aseguradora", "dbo");

//                entity.Property(e => e.IdAseguradora).HasColumnName("idAseguradora");

//                entity.Property(e => e.Direccion)
//                    .HasColumnName("direccion")
//                    .HasMaxLength(120)
//                    .IsUnicode(false);

//                entity.Property(e => e.Estado).HasColumnName("estado");

//                entity.Property(e => e.Nombre)
//                    .HasColumnName("nombre")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Telefono)
//                    .HasColumnName("telefono")
//                    .HasMaxLength(12)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Cita>(entity =>
//            {
//                entity.HasKey(e => e.IdCita);

//                entity.ToTable("Cita", "dbo");

//                entity.Property(e => e.IdCita).HasColumnName("idCita");

//                entity.Property(e => e.Estado)
//                    .HasColumnName("estado")
//                    .HasMaxLength(1)
//                    .IsUnicode(false)
//                    .IsFixedLength();

//                entity.Property(e => e.FechaReserva)
//                    .HasColumnName("fechaReserva")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Hora)
//                    .HasColumnName("hora")
//                    .HasMaxLength(6)
//                    .IsUnicode(false);

//                entity.Property(e => e.IdMedico).HasColumnName("idMedico");

//                entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");

//                entity.Property(e => e.Observacion)
//                    .HasColumnName("observacion")
//                    .HasMaxLength(350)
//                    .IsUnicode(false);

//                entity.HasOne(d => d.IdMedicoNavigation)
//                    .WithMany(p => p.Cita)
//                    .HasForeignKey(d => d.IdMedico)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Cita_Medico");

//                entity.HasOne(d => d.IdPacienteNavigation)
//                    .WithMany(p => p.Cita)
//                    .HasForeignKey(d => d.IdPaciente)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Cita_Paciente");
//            });

//            modelBuilder.Entity<DetalleAseguradora>(entity =>
//            {
//                entity.HasKey(e => e.IdDetAseguradora);

//                entity.ToTable("DetalleAseguradora", "dbo");

//                entity.Property(e => e.IdDetAseguradora).HasColumnName("idDetAseguradora");

//                entity.Property(e => e.Estado)
//                    .HasColumnName("estado")
//                    .HasMaxLength(1)
//                    .IsUnicode(false)
//                    .IsFixedLength();

//                entity.Property(e => e.IdAseguradora).HasColumnName("idAseguradora");

//                entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");

//                entity.Property(e => e.TipoSeguroSalud)
//                    .HasColumnName("tipoSeguroSalud")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.HasOne(d => d.IdAseguradoraNavigation)
//                    .WithMany(p => p.DetalleAseguradora)
//                    .HasForeignKey(d => d.IdAseguradora)
//                    .HasConstraintName("FK_DetalleAseguradora_Aseguradora");

//                entity.HasOne(d => d.IdPacienteNavigation)
//                    .WithMany(p => p.DetalleAseguradora)
//                    .HasForeignKey(d => d.IdPaciente)
//                    .HasConstraintName("FK_DetalleAseguradora_Paciente");
//            });

//            modelBuilder.Entity<DiaSemana>(entity =>
//            {
//                entity.HasKey(e => e.IdDiaSemana);

//                entity.ToTable("DiaSemana", "dbo");

//                entity.Property(e => e.IdDiaSemana).HasColumnName("idDiaSemana");

//                entity.Property(e => e.NombreDiaSemana)
//                    .HasColumnName("nombreDiaSemana")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Diagnostico>(entity =>
//            {
//                entity.HasKey(e => e.IdDiagnostico);

//                entity.ToTable("Diagnostico", "dbo");

//                entity.Property(e => e.IdDiagnostico).HasColumnName("idDiagnostico");

//                entity.Property(e => e.Estado).HasColumnName("estado");

//                entity.Property(e => e.FechaEmision)
//                    .HasColumnName("fechaEmision")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.IdHistoriaClinica).HasColumnName("idHistoriaClinica");

//                entity.Property(e => e.Observacion)
//                    .HasColumnName("observacion")
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.HasOne(d => d.IdHistoriaClinicaNavigation)
//                    .WithMany(p => p.Diagnostico)
//                    .HasForeignKey(d => d.IdHistoriaClinica)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Diagnostico_HistoriaClinica");
//            });

//            modelBuilder.Entity<Empleado>(entity =>
//            {
//                entity.HasKey(e => e.IdEmpleado);

//                entity.ToTable("Empleado", "dbo");

//                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

//                entity.Property(e => e.ApMaterno)
//                    .HasColumnName("apMaterno")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.ApPaterno)
//                    .HasColumnName("apPaterno")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Clave)
//                    .HasColumnName("clave")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Estado).HasColumnName("estado");

//                entity.Property(e => e.IdTipoEmpleado).HasColumnName("idTipoEmpleado");

//                entity.Property(e => e.Imagen)
//                    .HasColumnName("imagen")
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.Nombres)
//                    .HasColumnName("nombres")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.NroDocumento)
//                    .HasColumnName("nroDocumento")
//                    .HasMaxLength(8)
//                    .IsUnicode(false);

//                entity.Property(e => e.Usuario)
//                    .HasColumnName("usuario")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.HasOne(d => d.IdTipoEmpleadoNavigation)
//                    .WithMany(p => p.Empleado)
//                    .HasForeignKey(d => d.IdTipoEmpleado)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Empleado_TipoEmpleado");
//            });

//            modelBuilder.Entity<Especialidad>(entity =>
//            {
//                entity.HasKey(e => e.IdEspecialidad);

//                entity.ToTable("Especialidad", "dbo");

//                entity.Property(e => e.IdEspecialidad).HasColumnName("idEspecialidad");

//                entity.Property(e => e.Descripcion)
//                    .HasColumnName("descripcion")
//                    .HasMaxLength(25)
//                    .IsUnicode(false);

//                entity.Property(e => e.Estado).HasColumnName("estado");
//            });

//            modelBuilder.Entity<HistoriaClinica>(entity =>
//            {
//                entity.HasKey(e => e.IdHistoriaClinica);

//                entity.ToTable("HistoriaClinica", "dbo");

//                entity.Property(e => e.IdHistoriaClinica).HasColumnName("idHistoriaClinica");

//                entity.Property(e => e.Estado).HasColumnName("estado");

//                entity.Property(e => e.FechaApertura)
//                    .HasColumnName("fechaApertura")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");

//                entity.HasOne(d => d.IdPacienteNavigation)
//                    .WithMany(p => p.HistoriaClinica)
//                    .HasForeignKey(d => d.IdPaciente)
//                    .HasConstraintName("FK_HistoriaClinica_Paciente");
//            });

//            modelBuilder.Entity<Hora>(entity =>
//            {
//                entity.HasKey(e => e.IdHora);

//                entity.ToTable("Hora", "dbo");

//                entity.Property(e => e.IdHora).HasColumnName("idHora");

//                entity.Property(e => e.Hora1)
//                    .HasColumnName("hora")
//                    .HasMaxLength(6)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<HorarioAtencion>(entity =>
//            {
//                entity.HasKey(e => e.IdHorarioAtencion);

//                entity.ToTable("HorarioAtencion", "dbo");

//                entity.Property(e => e.IdHorarioAtencion).HasColumnName("idHorarioAtencion");

//                entity.Property(e => e.Estado).HasColumnName("estado");

//                entity.Property(e => e.Fecha)
//                    .HasColumnName("fecha")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.FechaFin)
//                    .HasColumnName("fechaFin")
//                    .HasColumnType("date");

//                entity.Property(e => e.IdDiaSemana).HasColumnName("idDiaSemana");

//                entity.Property(e => e.IdHoraInicio).HasColumnName("idHoraInicio");

//                entity.Property(e => e.IdMedico).HasColumnName("idMedico");

//                entity.HasOne(d => d.IdDiaSemanaNavigation)
//                    .WithMany(p => p.HorarioAtencion)
//                    .HasForeignKey(d => d.IdDiaSemana)
//                    .HasConstraintName("FK_HorarioAtencion_DiaSemana");

//                entity.HasOne(d => d.IdHoraInicioNavigation)
//                    .WithMany(p => p.HorarioAtencion)
//                    .HasForeignKey(d => d.IdHoraInicio)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_HorarioAtencion_Hora");

//                entity.HasOne(d => d.IdMedicoNavigation)
//                    .WithMany(p => p.HorarioAtencion)
//                    .HasForeignKey(d => d.IdMedico)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_HorarioAtencion_Medico");
//            });

//            modelBuilder.Entity<Medico>(entity =>
//            {
//                entity.HasKey(e => e.IdMedico);

//                entity.ToTable("Medico", "dbo");

//                entity.Property(e => e.IdMedico).HasColumnName("idMedico");

//                entity.Property(e => e.Estado).HasColumnName("estado");

//                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

//                entity.Property(e => e.IdEspecialidad).HasColumnName("idEspecialidad");

//                entity.HasOne(d => d.IdEmpleadoNavigation)
//                    .WithMany(p => p.Medico)
//                    .HasForeignKey(d => d.IdEmpleado)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Medico_Empleado");

//                entity.HasOne(d => d.IdEspecialidadNavigation)
//                    .WithMany(p => p.Medico)
//                    .HasForeignKey(d => d.IdEspecialidad)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Medico_Especialidad");
//            });

//            modelBuilder.Entity<Paciente>(entity =>
//            {
//                entity.HasKey(e => e.IdPaciente);

//                entity.ToTable("Paciente", "dbo");

//                entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");

//                entity.Property(e => e.ApMaterno)
//                    .HasColumnName("apMaterno")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.ApPaterno)
//                    .HasColumnName("apPaterno")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Direccion)
//                    .HasColumnName("direccion")
//                    .HasMaxLength(150)
//                    .IsUnicode(false);

//                entity.Property(e => e.Edad).HasColumnName("edad");

//                entity.Property(e => e.Estado).HasColumnName("estado");

//                entity.Property(e => e.Imagen)
//                    .HasColumnName("imagen")
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.Nombres)
//                    .HasColumnName("nombres")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.NroDocumento)
//                    .HasColumnName("nroDocumento")
//                    .HasMaxLength(8)
//                    .IsUnicode(false);

//                entity.Property(e => e.Sexo)
//                    .HasColumnName("sexo")
//                    .HasMaxLength(1)
//                    .IsUnicode(false)
//                    .IsFixedLength();

//                entity.Property(e => e.Telefono)
//                    .HasColumnName("telefono")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<TipoEmpleado>(entity =>
//            {
//                entity.HasKey(e => e.IdTipoEmpleado);

//                entity.ToTable("TipoEmpleado", "dbo");

//                entity.Property(e => e.IdTipoEmpleado).HasColumnName("idTipoEmpleado");

//                entity.Property(e => e.Descripcion)
//                    .HasColumnName("descripcion")
//                    .HasMaxLength(25)
//                    .IsUnicode(false);

//                entity.Property(e => e.Estado).HasColumnName("estado");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}