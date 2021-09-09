using Domain.Domain;
using Microsoft.EntityFrameworkCore;


namespace Data
{
    public class SqlContext : DbContext
    {

        public SqlContext()
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"data source=homologacao;initial catalog=MDR_lifecycle_new;persist security info=True;user id=user_sistema;password=B2Card@2018;MultipleActiveResultSets=True");
            //optionsBuilder.UseNpgsql(@"User ID=postgres;Password=91994467;Host=myzap.cntiofgraolr.sa-east-1.rds.amazonaws.com;Port=5432;Database=postgres;Pooling=true");
            optionsBuilder.UseNpgsql(@"User ID=iponvtrcywdqab;Password=a66426060562a657822746990d5567a27b8b5b92bc9b45f23e65b9a1b40f7e7f;Host=ec2-52-0-67-144.compute-1.amazonaws.com;Port=5432;Database=dbpiensig3o05q;Pooling=true");
            //optionsBuilder.UseSqlServer(@"data source=B2CBHDEV;initial catalog=MDR_lifecycle_new;persist security info=True;user id=sa;password=B2Card@2020");
        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
        //public DbSet<cmcconciliamastercredito> cmcconciliamastercredito { get; set; }
        //public DbSet<tbPlano> tbPlano { get; set; }
        public DbSet<exame> exame { get; set; }

        public DbSet<laboratorio> laboratorio { get; set; }
        public DbSet<laboratorioExame> laboratorioExame { get; set; }


    }
}
