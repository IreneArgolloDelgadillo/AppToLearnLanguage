using System.Collections.Generic;

namespace EasyLearning.Service.Models.ServiceModels
{
    public class GrammarTipModel
    {
        /// <summary>
        /// Gets or sets the grammar tip identifier.
        /// </summary>
        /// <value>
        /// The grammar tip identifier.
        /// </value>
        public int GrammarTipId { get; set; }

        /// <summary>
        /// Gets or sets the tip.
        /// </summary>
        /// <value>
        /// The tip.
        /// </value>
        public string Tip { get; set; }

        /// <summary>
        /// Gets or sets the examples.
        /// </summary>
        /// <value>
        /// The examples.
        /// </value>
        public IList<ExampleModel> Examples { get; set; } = new List<ExampleModel>();

        /// <summary>
        /// Gets or sets the lesson content identifier.
        /// </summary>
        /// <value>
        /// The lesson content identifier.
        /// </value>
        public int LessonContentId { get; set; }
    }
}