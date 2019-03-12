using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace BackEndAdvOnline.Models
{
    public partial class staAdvOnlineContext : DbContext
    {
        public staAdvOnlineContext()
        {
        }

        public IConfiguration Configuration { get; }

        public staAdvOnlineContext(IConfiguration configuration, DbContextOptions<staAdvOnlineContext> options)
            : base(options)
        {
            Configuration = configuration;
        }

        public virtual DbSet<TblCep> TblCep { get; set; }
        public virtual DbSet<TblEndereco> TblEndereco { get; set; }
        public virtual DbSet<TblMailPessoa> TblMailPessoa { get; set; }
        public virtual DbSet<TblPessoa> TblPessoa { get; set; }
        public virtual DbSet<TblTelefone> TblTelefone { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("staAdvOnline"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCep>(entity =>
            {
                entity.ToTable("tblCep");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblEndereco>(entity =>
            {
                entity.HasKey(e => e.NIdEndereco);

                entity.ToTable("tblEndereco");

                entity.Property(e => e.NIdEndereco).HasColumnName("nIdEndereco");

                entity.Property(e => e.NIdPessoa).HasColumnName("nIdPessoa");

                entity.Property(e => e.NNumero).HasColumnName("nNumero");

                entity.Property(e => e.SCep)
                    .IsRequired()
                    .HasColumnName("sCEP")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SComplemento)
                    .HasColumnName("sComplemento")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMailPessoa>(entity =>
            {
                entity.ToTable("tblMailPessoa");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblPessoa>(entity =>
            {
                entity.HasKey(e => e.NIdPessoa);

                entity.ToTable("tblPessoa");

                entity.Property(e => e.NIdPessoa).HasColumnName("nIdPessoa");

                entity.Property(e => e.SCpfpj)
                    .HasColumnName("sCpfpj")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.SIdentidade)
                    .HasColumnName("sIdentidade")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SLogin)
                    .HasColumnName("sLogin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMae)
                    .HasColumnName("sMae")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SNome)
                    .IsRequired()
                    .HasColumnName("sNome")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SNomeApelido)
                    .HasColumnName("sNomeApelido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSenha)
                    .HasColumnName("sSenha")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTelefone>(entity =>
            {
                entity.HasKey(e => e.NIdTelefone);

                entity.ToTable("tblTelefone");

                entity.Property(e => e.NIdTelefone).HasColumnName("nIdTelefone");

                entity.Property(e => e.NIdPessoa).HasColumnName("nIdPessoa");

                entity.Property(e => e.NTipoFone).HasColumnName("nTipoFone");

                entity.Property(e => e.SDdd)
                    .HasColumnName("sDDD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SFone)
                    .HasColumnName("sFone")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SObs)
                    .HasColumnName("sObs")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.NIdPessoaNavigation)
                    .WithMany(p => p.TblTelefone)
                    .HasForeignKey(d => d.NIdPessoa)
                    .HasConstraintName("FK_tblTelefone_tblContato");
            });
        }
    }
}
