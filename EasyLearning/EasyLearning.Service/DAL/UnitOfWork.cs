using EasyLearning.Service.Models.DataBaseModels;
using EasyLearning.Service.Models;
using System;

namespace EasyLearning.Service.DAL
{
    /// <summary>
    /// The unit of work class coordinates the work of multiple repositories 
    /// by creating a single database context class shared by all of them.
    /// </summary>
    public class UnitOfWork : IDisposable
    {

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// Gets the level repository.
        /// </summary>
        /// <value>
        /// The level repository.
        /// </value>
        public GenericRepository<Level> LevelRepository
        {
            get
            {
                if (levelRepository == null)
                {
                    levelRepository = new GenericRepository<Level>(context);
                }
                return levelRepository;
            }
        }

        /// <summary>
        /// Gets the true false repository.
        /// </summary>
        /// <value>
        /// The true false repository.
        /// </value>
        public GenericRepository<TF_Exercise> TrueFalseRepository
        {
            get
            {
                if (trueFalseRepository == null)
                {
                    trueFalseRepository = new GenericRepository<TF_Exercise>(context);
                }
                return trueFalseRepository;
            }
        }

        /// <summary>
        /// Gets the simple selection repository.
        /// </summary>
        /// <value>
        /// The simple selection repository.
        /// </value>
        public GenericRepository<S_Exercise> SimpleSelectionRepository
        {
            get
            {
                if (simpleSelectionRepository == null)
                {
                    simpleSelectionRepository = new GenericRepository<S_Exercise>(context);
                }

                return simpleSelectionRepository;
            }
        }

        /// <summary>
        /// Gets the lesson progress repository.
        /// </summary>
        /// <value>
        /// The lesson progress repository.
        /// </value>
        public GenericRepository<LessonProgress> LessonProgressRepository
        {
            get
            {
                if (lessonProgressRepository == null)
                {
                    lessonProgressRepository = new GenericRepository<LessonProgress>(context);
                }
                return lessonProgressRepository;
            }
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            context.SaveChanges();
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
        private ApplicationDbContext context = new ApplicationDbContext();
        private GenericRepository<Level> levelRepository;
        private GenericRepository<TF_Exercise> trueFalseRepository;
        private GenericRepository<S_Exercise> simpleSelectionRepository;
        private GenericRepository<LessonProgress> lessonProgressRepository;
    }
}