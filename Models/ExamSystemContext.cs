using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExamSystem.Models;

public partial class ExamSystemContext : DbContext
{
    public ExamSystemContext()
    {
    }

    public ExamSystemContext(DbContextOptions<ExamSystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Answer> Answers { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CourseToic> CourseToics { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<StudentExam> StudentExams { get; set; }

    public virtual DbSet<StudentExamAnswer> StudentExamAnswers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=ExamSystem;Trusted_Connection=True;encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Answer>(entity =>
        {
            entity.HasKey(e => new { e.QuestionId, e.QuestionAnswer }).HasName("PrimaryKey");

            entity.ToTable("Answer");

            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
            entity.Property(e => e.QuestionAnswer).HasMaxLength(100);

            entity.HasOne(d => d.Question).WithMany(p => p.Answers)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ForeginKey");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.InsertUsingStoredProcedure("Course_Insert", sp =>
            {
                sp.HasParameter(crs => crs.CourseName);
                sp.HasParameter(crs => crs.Duration);
                sp.HasParameter(crs => crs.CourseId,para=>para.IsOutput());
            });
            entity.UpdateUsingStoredProcedure("Course_Update", sp =>
            {
                sp.HasOriginalValueParameter(crs => crs.CourseId);
                sp.HasParameter(crs => crs.Duration);
                sp.HasParameter(crs => crs.CourseName);
            });
            entity.DeleteUsingStoredProcedure("Course_Delete", sp =>
            {
                sp.HasOriginalValueParameter(crs=>crs.CourseId);
            });
            entity.HasKey(e => e.CourseId).HasName("PK__Course__C92D7187959CD6B2");

            entity.ToTable("Course");

            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.CourseName).HasMaxLength(40);

            entity.HasMany(d => d.Departments).WithMany(p => p.Courses)
                .UsingEntity<Dictionary<string, object>>(
                    "DepartmentCourse",
                    r => r.HasOne<Department>().WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Departmen__Depar__59063A47"),
                    l => l.HasOne<Course>().WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Departmen__Cours__5812160E"),
                    j =>
                    {
                        j.HasKey("CourseId", "DepartmentId").HasName("DepartmentCourses_PK");
                        j.ToTable("DepartmentCourses");
                        j.IndexerProperty<int>("CourseId").HasColumnName("CourseID");
                        j.IndexerProperty<int>("DepartmentId").HasColumnName("DepartmentID");
                    });

            entity.HasMany(d => d.Instructors).WithMany(p => p.Courses)
                .UsingEntity<Dictionary<string, object>>(
                    "InstructorCourse",
                    r => r.HasOne<User>().WithMany()
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Instructo__Instr__5535A963"),
                    l => l.HasOne<Course>().WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Instructo__Cours__5441852A"),
                    j =>
                    {
                        j.HasKey("CourseId", "InstructorId").HasName("InstructorCourses_PK");
                        j.ToTable("InstructorCourses");
                        j.IndexerProperty<int>("CourseId").HasColumnName("CourseID");
                        j.IndexerProperty<string>("InstructorId")
                            .HasMaxLength(14)
                            .IsUnicode(false)
                            .IsFixedLength()
                            .HasColumnName("InstructorID");
                    });

            entity.HasMany(d => d.Students).WithMany(p => p.CoursesNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "StudentCourse",
                    r => r.HasOne<User>().WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__StudentCo__Stude__5165187F"),
                    l => l.HasOne<Course>().WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__StudentCo__Cours__5070F446"),
                    j =>
                    {
                        j.HasKey("CourseId", "StudentId").HasName("StudentCourses_PK");
                        j.ToTable("StudentCourses");
                        j.IndexerProperty<int>("CourseId").HasColumnName("CourseID");
                        j.IndexerProperty<string>("StudentId")
                            .HasMaxLength(14)
                            .IsUnicode(false)
                            .IsFixedLength()
                            .HasColumnName("StudentID");
                    });
        });

        modelBuilder.Entity<CourseToic>(entity =>
        {
            entity.HasKey(e => e.TopicId).HasName("PK__CourseTo__022E0F5D1A05C68B");

            entity.ToTable("CourseToic");

            entity.Property(e => e.TopicId).ValueGeneratedNever();
            entity.Property(e => e.TopicName)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.Course).WithMany(p => p.CourseToics)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__CourseToi__Cours__1DB06A4F");
        });

        modelBuilder.Entity<Department>(entity =>
        {

            entity.InsertUsingStoredProcedure("Department_Insert", sp =>
            {
                sp.HasParameter(dept => dept.DepartmentName);
                sp.HasParameter(dept => dept.DepartmentId, para => para.IsOutput());
            });
            entity.UpdateUsingStoredProcedure("Department_Update", sp =>
            {
                sp.HasOriginalValueParameter(dept => dept.DepartmentId);
                sp.HasParameter(dept => dept.DepartmentName);
                sp.HasRowsAffectedResultColumn();
            });
            entity.DeleteUsingStoredProcedure("Department_Delete", sp =>
            {
                sp.HasOriginalValueParameter(dept => dept.DepartmentId);
                sp.HasRowsAffectedResultColumn();
            });
            entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__B2079BED57225AF8");

            entity.ToTable("Department");

            entity.Property(e => e.DepartmentName).HasMaxLength(30);
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.HasKey(e => e.ExamId).HasName("PK__Exam__297521A768A21B7C");

            entity.ToTable("Exam");

            entity.Property(e => e.ExamId).HasColumnName("ExamID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");

            entity.HasOne(d => d.Course).WithMany(p => p.Exams)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__Exam__CourseID__3E52440B");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.QuestionId).HasName("PK__Question__0DC06FAC1E318558");

            entity.ToTable("Question");

            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.ModelAnswer).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(3);

            entity.HasOne(d => d.Course).WithMany(p => p.Questions)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_Question_Course");

            entity.HasMany(d => d.Exams).WithMany(p => p.Questions)
                .UsingEntity<Dictionary<string, object>>(
                    "ExamQuestion",
                    r => r.HasOne<Exam>().WithMany()
                        .HasForeignKey("ExamId")
                        .HasConstraintName("FK__ExamQuest__ExamI__4222D4EF"),
                    l => l.HasOne<Question>().WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ExamQuest__Quest__412EB0B6"),
                    j =>
                    {
                        j.HasKey("QuestionId", "ExamId").HasName("ExamQuestions_PK");
                        j.ToTable("ExamQuestions");
                        j.IndexerProperty<int>("ExamId").HasColumnName("ExamID");
                    });
        });

        modelBuilder.Entity<StudentExam>(entity =>
        {
            entity.HasKey(e => new { e.ExamId, e.StudentId }).HasName("StudentExams_PK");

            entity.Property(e => e.ExamId).HasColumnName("ExamID");
            entity.Property(e => e.StudentId)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("StudentID");

            entity.HasOne(d => d.Exam).WithMany(p => p.StudentExams)
                .HasForeignKey(d => d.ExamId)
                .HasConstraintName("FK__StudentEx__ExamI__4CA06362");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentExams)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentEx__Stude__4D94879B");
        });

        modelBuilder.Entity<StudentExamAnswer>(entity =>
        {
            entity.HasKey(e => new { e.ExamId, e.StudentId, e.QuestionId }).HasName("PK");

            entity.ToTable("StudentExamAnswer");

            entity.Property(e => e.StudentId)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Answer)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Exam).WithMany(p => p.StudentExamAnswers)
                .HasForeignKey(d => d.ExamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentEx__ExamI__18EBB532");

            entity.HasOne(d => d.Question).WithMany(p => p.StudentExamAnswers)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentEx__Quest__1AD3FDA4");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentExamAnswers)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentEx__Stude__19DFD96B");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.InsertUsingStoredProcedure("User_Insert", sp =>
            {
                sp.HasParameter(User => User.DepartmentId);
                sp.HasParameter(user => user.FirstName);
                sp.HasParameter(user => user.LastName);
                sp.HasParameter(user => user.Ssn);
                sp.HasParameter(user => user.Role);
                sp.HasParameter(User => User.Age);
                sp.HasParameter(user => user.Password);
            });
            entity.UpdateUsingStoredProcedure("User_Update", sp =>
            {
                sp.HasParameter(User => User.DepartmentId);
                sp.HasParameter(User => User.FirstName);
                sp.HasParameter(User => User.LastName);
                sp.HasOriginalValueParameter(User => User.Ssn);
                sp.HasParameter(User => User.Role);
                sp.HasParameter(User => User.Age);
                sp.HasParameter(User => User.Password);
            });
            entity.DeleteUsingStoredProcedure("User_Delete", sp =>
            {
                sp.HasOriginalValueParameter(User => User.Ssn);
            });

            entity.HasKey(e => e.Ssn).HasName("PK__Users__CA1E8E3DE84BF71F");

            entity.Property(e => e.Ssn)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SSN");
            entity.Property(e => e.FirstName).HasMaxLength(30);
            entity.Property(e => e.LastName).HasMaxLength(30);
            entity.Property(e => e.Password).HasMaxLength(20);
            entity.Property(e => e.Role).HasMaxLength(5);

            entity.HasOne(d => d.Department).WithMany(p => p.Users)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__Users__Departmen__46E78A0C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
