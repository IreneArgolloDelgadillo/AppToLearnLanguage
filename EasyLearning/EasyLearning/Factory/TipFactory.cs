using EasyLearning.Models.ViewModel;

namespace EasyLearning.Factory
{
    public class TipFactory
    {
        /// <summary>
        /// Creates the grammar tip.
        /// </summary>
        /// <param name="ennunciate">The ennunciate.</param>
        /// <param name="lessonContentId">The lesson content identifier.</param>
        /// <param name="tipId">The tip identifier.</param>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public static GrammarTipModel CreateGrammarTip(int grammarTipId, string tip, int currentContentId, string example)
        {
            GrammarTipModel grammar = new GrammarTipModel()
            {
                GrammarTipId = grammarTipId,
                Tip = tip,
                LessonContentId = currentContentId
            };

            var examples = example.Split(',');
            for (int i = FirstPosition; i < ArraySize; i = i + NextPosition)
            {
                ExampleModel exampleModel = new ExampleModel();
                exampleModel.ExampleOnNativeLanguage = examples[i].ToString();
                exampleModel.ExampleOnLanguageToLearn = examples[i + 1].ToString();
                grammar.Examples.Add(exampleModel);
            }
            return grammar;
        }

        /// <summary>
        /// Creates the listenning tip.
        /// </summary>
        /// <param name="listeningTipId">The listening tip identifier.</param>
        /// <param name="pathImage">The path image.</param>
        /// <param name="lessonContentId">The lesson content identifier.</param>
        /// <param name="example">The example.</param>
        /// <returns></returns>
        public static VocabularyTipModel CreateListenningTip(int listeningTipId, string pathImage, int lessonContentId, string example)
        {
            VocabularyTipModel tip = new VocabularyTipModel()
            {
                TranslationSetId = listeningTipId,
                PathImage = pathImage,
                LessonContentId = lessonContentId
            };
            var examples = example.Split(',');
            ExampleModel exampleModel = new ExampleModel();
            exampleModel.ExampleOnNativeLanguage = examples[FirstPosition].ToString();
            exampleModel.ExampleOnLanguageToLearn = examples[SecondPosition].ToString();
            tip.Example = exampleModel;
            return tip;
        }

        /// <summary>
        /// Creates the name view.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public static string CreateNameView(int type)
        {
            switch (type)
            {
                case (int)ContentType.Vocabulary:
                    return ContentType.Vocabulary.ToString();
                case (int)ContentType.GrammarTip:
                    return ContentType.GrammarTip.ToString();
                default:
                    throw new System.NotSupportedException();
            }
        }

        private const int FirstPosition = 0;
        private const int SecondPosition = 1;
        private const int ArraySize = 4;
        private const int NextPosition = 2;
    }
}