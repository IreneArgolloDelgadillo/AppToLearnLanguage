using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using EasyLearning.Service.Models.DataBaseModels;

namespace EasyLearning.Service.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

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
        public DbSet<Level> Levels { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Enunciate> Enunciates { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Sentence> Sentences { get; set; }
        public DbSet<TranslationSet> TransacionSets { get; set; }
        public DbSet<LearningHistory> LearningHistories { get; set; }
        public DbSet<S_Exercise> S_Exercies { get; set; }
        public DbSet<TF_Exercise> TF_Exercises { get; set; }
        public DbSet<GrammarTip> GrammarTips { get; set; }
        public DbSet<ListeningTip> ListeningTips { get; set; }
        public DbSet<LessonContent> LessonContents { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<UserLanguages> UsersLanguages { get; set; }
        public DbSet<ExerciseSolved> ExercisesSolved { get; set; }
        public DbSet<LessonProgress> ProgressByLessons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserLanguages>().HasOptional(u => u.NativeLanguage);

            modelBuilder.Entity<UserLanguages>().HasOptional(u => u.LanguageToLearn);

            modelBuilder.Entity<Level>().HasOptional(l => l.BelongsLanguage);

            modelBuilder.Entity<Level>().HasOptional(l => l.LanguageToLearn);

            modelBuilder.Entity<Enunciate>().HasRequired(a => a.BelongsLanguage);

            modelBuilder.Entity<Lesson>().HasRequired(ls => ls.Level);

            modelBuilder.Entity<Lesson>().HasMany(l => l.Contents).WithRequired(c => c.Lesson);

            modelBuilder.Entity<Sentence>().HasRequired(s => s.BelongsLanguage);

            modelBuilder.Entity<Sentence>().HasOptional(s => s.TranslationSet).WithMany(ts => ts.Sentences);

            modelBuilder.Entity<Answer>().HasRequired(a => a.Sentence);

            modelBuilder.Entity<S_Exercise>().HasOptional(se => se.Enunciate);

            modelBuilder.Entity<S_Exercise>().HasMany(se => se.Answers).WithMany(a => a.S_Exercises);

            modelBuilder.Entity<S_Exercise>().HasRequired(se => se.LessonContent);

            modelBuilder.Entity<TF_Exercise>().HasOptional(tfe => tfe.Enunciate);

            modelBuilder.Entity<TF_Exercise>().HasRequired(tfe => tfe.Affirmation);

            modelBuilder.Entity<TF_Exercise>().HasRequired(tfe => tfe.LessonContent);

            modelBuilder.Entity<GrammarTip>().HasOptional(gt => gt.TipInterpretation);

            modelBuilder.Entity<GrammarTip>().HasMany(gt => gt.TranslationSets).WithMany(ts => ts.GrammarTips);

            modelBuilder.Entity<GrammarTip>().HasRequired(gt => gt.LessonContent);

            modelBuilder.Entity<ListeningTip>().HasRequired(lt => lt.TransaltionSetWords);

            modelBuilder.Entity<ListeningTip>().HasRequired(lt => lt.LessonContent);

            modelBuilder.Entity<ExerciseSolved>().HasRequired(es => es.User);

            modelBuilder.Entity<ExerciseSolved>().HasRequired(es => es.Exercise);

            modelBuilder.Entity<LessonProgress>().HasRequired(lp => lp.Lesson);

            modelBuilder.Entity<LessonProgress>().HasRequired(lp => lp.User);

            base.OnModelCreating(modelBuilder);
        }
    }
}
