using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataAccess.Models
{
    public partial class RealEstateManagermentContext : DbContext
    {
        public RealEstateManagermentContext()
        {
        }

        public RealEstateManagermentContext(DbContextOptions<RealEstateManagermentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Citys> Citys { get; set; }
        public virtual DbSet<Communes> Communes { get; set; }
        public virtual DbSet<DetailProjects> DetailProjects { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<NewsEvent> NewsEvent { get; set; }
        public virtual DbSet<ProjectTypes> ProjectTypes { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<RealEstateTypes> RealEstateTypes { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=. ;Initial Catalog=RealEstateManagerment;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CommuneId).HasColumnName("CommuneID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDay).HasColumnType("datetime");

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Address__CityID__182C9B23");

                entity.HasOne(d => d.Commune)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CommuneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Address__Commune__1A14E395");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Address__Distric__1920BF5C");
            });

            modelBuilder.Entity<Citys>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PK__Citys__F2D21A96FF20B0A5");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDay).HasColumnType("datetime");

                entity.Property(e => e.Latitude)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Longtitude)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Communes>(entity =>
            {
                entity.HasKey(e => e.CommuneId)
                    .HasName("PK__Communes__3E2EBD72A3C1049A");

                entity.Property(e => e.CommuneId).HasColumnName("CommuneID");

                entity.Property(e => e.CommuneName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDay).HasColumnType("datetime");

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.Latitude)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Longtitude)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Communes)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Communes__Distri__15502E78");
            });

            modelBuilder.Entity<DetailProjects>(entity =>
            {
                entity.HasKey(e => e.DetailProjectId)
                    .HasName("PK__DetailPr__5F4BB5A430523674");

                entity.Property(e => e.DetailProjectId).HasColumnName("DetailProjectID");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDay).HasColumnType("datetime");

                entity.Property(e => e.DayEnd).HasColumnType("datetime");

                entity.Property(e => e.DayStart).HasColumnType("datetime");

                entity.Property(e => e.Describe)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DetailProjectType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('For Sold')");

                entity.Property(e => e.Orientation)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.TitleNews).HasMaxLength(50);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.DetailProjects)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetailPro__Proje__2C3393D0");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DetailProjects)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetailPro__UserI__2D27B809");
            });

            modelBuilder.Entity<Districts>(entity =>
            {
                entity.HasKey(e => e.DistrictId)
                    .HasName("PK__District__85FDA4A60A783196");

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDay).HasColumnType("datetime");

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Latitude)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Longtitude)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Districts__CityI__1273C1CD");
            });

            modelBuilder.Entity<NewsEvent>(entity =>
            {
                entity.Property(e => e.NewsEventId)
                    .HasColumnName("NewsEventID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.NewsEvent)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NewsEvent__Proje__3A81B327");
            });

            modelBuilder.Entity<ProjectTypes>(entity =>
            {
                entity.HasKey(e => e.ProjectTypeId)
                    .HasName("PK__ProjectT__6F245E43A881BCD4");

                entity.Property(e => e.ProjectTypeId).HasColumnName("ProjectTypeID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDay).HasColumnType("datetime");

                entity.Property(e => e.ProjectTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.HasKey(e => e.ProjectId)
                    .HasName("PK__Projects__761ABED018C7CF6C");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDay).HasColumnType("datetime");

                entity.Property(e => e.DayEnd).HasColumnType("datetime");

                entity.Property(e => e.DayStart).HasColumnType("datetime");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectTypeId).HasColumnName("ProjectTypeID");

                entity.Property(e => e.RetypeId).HasColumnName("RETypeID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Waiting')");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Projects__Addres__276EDEB3");

                entity.HasOne(d => d.ProjectType)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.ProjectTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Projects__Projec__267ABA7A");

                entity.HasOne(d => d.Retype)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.RetypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Projects__REType__25869641");
            });

            modelBuilder.Entity<RealEstateTypes>(entity =>
            {
                entity.HasKey(e => e.RetypeId)
                    .HasName("PK__RealEsta__4BB34A023A97D747");

                entity.Property(e => e.RetypeId).HasColumnName("RETypeID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDay).HasColumnType("datetime");

                entity.Property(e => e.Rename)
                    .IsRequired()
                    .HasColumnName("REName")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__1788CCACE8293D98");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.Avartar)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDay).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("phoneNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__AddressID__1CF15040");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
