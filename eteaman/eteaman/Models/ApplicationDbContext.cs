using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace eteaman.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException("modelBuilder");
            }
            configuraUsuarios(modelBuilder);
            configuraClub(modelBuilder);
            configuraCompeticion(modelBuilder);
            configuraCompeticionesClub(modelBuilder);
            configuraTemporadas(modelBuilder);
            configuraJugador(modelBuilder);
            configuraPartido(modelBuilder);
            configuraJugadorPartido(modelBuilder);
        }

        private void configuraUsuarios(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().HasRequired(z => z.Club).WithMany().HasForeignKey(z => z.IdClub).WillCascadeOnDelete(false);
        }

        private void configuraClub(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>().HasRequired(z => z.UsuarioUltMod).WithMany().HasForeignKey(z => z.IdUsuarioUltMod).WillCascadeOnDelete(false);
        }

        private void configuraCompeticion(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competicion>().HasRequired(z => z.TipoCompeticion).WithMany().HasForeignKey(z => z.IdTipoCompeticion).WillCascadeOnDelete(false);
            modelBuilder.Entity<Competicion>().HasRequired(z => z.UsuarioUltMod).WithMany().HasForeignKey(z => z.IdUsuarioUltMod).WillCascadeOnDelete(false);
        }

        private void configuraCompeticionesClub(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClubCompeticion>().HasKey(z => new { z.Club, z.Competicion });
            modelBuilder.Entity<ClubCompeticion>().HasRequired(z => z.Club).WithMany(z => z.CompeticionesClub).HasForeignKey(z => z.IdClub).WillCascadeOnDelete(false);
            modelBuilder.Entity<ClubCompeticion>().HasRequired(z => z.Competicion).WithMany(z => z.ClubesCompeticion).HasForeignKey(z => z.IdCompeticion).WillCascadeOnDelete(false);
        }

        private void configuraTemporadas(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Temporada>().HasRequired(z => z.Competicion).WithMany(z => z.Temporadas).HasForeignKey(z => z.IdCompeticion).WillCascadeOnDelete(false);
            modelBuilder.Entity<Temporada>().HasRequired(z => z.UsuarioUltMod).WithMany().HasForeignKey(z => z.IdUsuarioUltMod).WillCascadeOnDelete(false);
        }

        private void configuraJugador(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jugador>().HasRequired(z => z.Club).WithMany(z => z.Jugadores).HasForeignKey(z => z.IdClub).WillCascadeOnDelete(false);
            modelBuilder.Entity<Jugador>().HasOptional(z => z.PosicionPrincipal).WithMany().HasForeignKey(z => z.IdPosicionPrincipal).WillCascadeOnDelete(false);
            modelBuilder.Entity<Jugador>().HasOptional(z => z.PosicionSecundaria).WithMany().HasForeignKey(z => z.IdPosicionSecundaria).WillCascadeOnDelete(false);
            modelBuilder.Entity<Jugador>().HasRequired(z => z.UsuarioUltMod).WithMany().HasForeignKey(z => z.IdUsuarioUltMod).WillCascadeOnDelete(false);
        }

        private void configuraPartido(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Partido>().HasRequired(z => z.ClubLocal).WithMany(z => z.Partidos).HasForeignKey(z => z.IdClubLocal).WillCascadeOnDelete(false);
            modelBuilder.Entity<Partido>().HasRequired(z => z.ClubVisitante).WithMany(z => z.Partidos).HasForeignKey(z => z.IdClubVisitante).WillCascadeOnDelete(false);
            modelBuilder.Entity<Partido>().HasRequired(z => z.Competicion).WithMany(z => z.Partidos).HasForeignKey(z => z.IdCompeticion).WillCascadeOnDelete(false);
            modelBuilder.Entity<Partido>().HasRequired(z => z.UsuarioUltMod).WithMany().HasForeignKey(z => z.IdUsuarioUltMod).WillCascadeOnDelete(false);
        }

        private void configuraJugadorPartido(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JugadorPartido>().HasOptional(z => z.Amonestacion).WithMany().HasForeignKey(z => z.IdAmonestacion).WillCascadeOnDelete(false);
            modelBuilder.Entity<JugadorPartido>().HasRequired(z => z.Club).WithMany().HasForeignKey(z => z.IdClub).WillCascadeOnDelete(false);
            modelBuilder.Entity<JugadorPartido>().HasRequired(z => z.Partido).WithMany().HasForeignKey(z => z.IdPartido).WillCascadeOnDelete(false);
            modelBuilder.Entity<JugadorPartido>().HasRequired(z => z.UsuarioUltMod).WithMany().HasForeignKey(z => z.IdUsuarioUltMod).WillCascadeOnDelete(false);
        }
    }
}