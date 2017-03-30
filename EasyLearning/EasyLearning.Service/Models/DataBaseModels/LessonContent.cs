
namespace EasyLearning.Service.Models.DataBaseModels
{
    /// <summary>
    /// Represent a component of a lesson to teach a topic of lesson
    /// </summary>
    public class LessonContent
    {
        /// <summary>
        /// Gets or sets the lesson content identifier.
        /// </summary>
        /// <value>
        /// The lesson content identifier.
        /// </value>
        public int LessonContentId { get; set; }

        /// <summary>
        /// Gets or sets the lesson.
        /// </summary>
        /// <value>
        /// The lesson.
        /// </value>
        public virtual Lesson Lesson { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        /// <value>
        /// The order.
        /// </value>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public ContentTypeName Type { get; set; }
    }
}