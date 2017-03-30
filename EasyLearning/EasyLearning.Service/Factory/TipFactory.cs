using EasyLearning.Service.Models.ServiceModels;
using System.Collections.Generic;

namespace EasyLearning.Service.Factory
{
    public class TipFactory
    {
        /// <summary>
        /// Gets or sets the examples.
        /// </summary>
        /// <value>
        /// The examples.
        /// </value>
        public IList<ExampleModel> Examples { get; private set; } = new List<ExampleModel>();

        /// <summary>
        /// Creates the grammar tip.
        /// </summary>
        /// <param name="ennunciate">The ennunciate.</param>
        /// <param name="lessonContentId">The lesson content identifier.</param>
        /// <param name="tipId">The tip identifier.</param>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public void CreateExampleModel(string example, string significate)
        {
            ExampleModel exampleModel = new ExampleModel()
            {
                ExampleOnNativeLanguage = example,
                ExampleOnLanguageToLearn = significate
            };
            Examples.Add(exampleModel);
        }
    }
}