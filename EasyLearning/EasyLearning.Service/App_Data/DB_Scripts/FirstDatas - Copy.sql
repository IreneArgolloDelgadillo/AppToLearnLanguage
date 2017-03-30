
insert into dbo.Levels(Title, OrderByDifficulty, BelongsLanguage_LanguageId, LanguageToLearn_LanguageId) 
values('Elemental A2', 2, 2, 1)--id3 first level in spanish to english

insert into dbo.Levels(Title, OrderByDifficulty, BelongsLanguage_LanguageId, LanguageToLearn_LanguageId) 
values('Elemental A2', 2, 2, 3)--id4 first level in spanish to italian

--English
--Insert Lesson 1 to Lesson 3 for Level 1
insert into dbo.Lessons(Title, Level_LevelId, OrderByLevel)--id7
values('Salgamos', 3, 1)
insert into dbo.Lessons(Title, Level_LevelId, OrderByLevel)--id8
values('Familia y Amigos', 3, 2) 
 

--Italian
--Insert Lesson 1 to Lesson 3 for Level 1
insert into dbo.Lessons(Title, Level_LevelId, OrderByLevel)--id9
values('Salgamos!', 4, 1)
insert into dbo.Lessons(Title, Level_LevelId, OrderByLevel)--id10
values('Familia y Amigos', 4, 2) 

DECLARE @SimpleExerciseNameId int = 1;
DECLARE @TrueFalseExerciseNameId int = 2;
DECLARE @ListeningTipNameId int = 3;
DECLARE @GrammarTipNameId int = 4;
--content of lesson 2 and 3 on english
insert into dbo.LessonContents(Lesson_LessonId, [Order], [Type])--id9
values (7, 1, @ListeningTipNameId)
insert into dbo.LessonContents(Lesson_LessonId, [Order], [Type])--id10
values (7, 2, @GrammarTipNameId)
insert into dbo.LessonContents(Lesson_LessonId, [Order], [Type])--id11
values (7, 3, @TrueFalseExerciseNameId)
insert into dbo.LessonContents(Lesson_LessonId, [Order], [Type])--id12
values (7, 4, @SimpleExerciseNameId)
insert into dbo.LessonContents(Lesson_LessonId, [Order], [Type])--id9
values (8, 1, @ListeningTipNameId)
insert into dbo.LessonContents(Lesson_LessonId, [Order], [Type])--id10
values (8, 2, @GrammarTipNameId)
insert into dbo.LessonContents(Lesson_LessonId, [Order], [Type])--id11
values (8, 3, @TrueFalseExerciseNameId)
insert into dbo.LessonContents(Lesson_LessonId, [Order], [Type])--id12
values (8, 4, @SimpleExerciseNameId)
--content of lesson 2 and 3 on italian
insert into dbo.LessonContents(Lesson_LessonId, [Order], [Type])--id13
values (9, 1, @ListeningTipNameId)
insert into dbo.LessonContents(Lesson_LessonId, [Order], [Type])--id14
values (9, 2, @GrammarTipNameId)
insert into dbo.LessonContents(Lesson_LessonId, [Order], [Type])--id15
values (9, 3, @TrueFalseExerciseNameId)
insert into dbo.LessonContents(Lesson_LessonId, [Order], [Type])--id16
values (9, 4, @SimpleExerciseNameId)
insert into dbo.LessonContents(Lesson_LessonId, [Order], [Type])--id17
values (10, 1, @ListeningTipNameId)
insert into dbo.LessonContents(Lesson_LessonId, [Order], [Type])--id18
values (10, 2, @GrammarTipNameId)
insert into dbo.LessonContents(Lesson_LessonId, [Order], [Type])--id19
values (10, 3, @TrueFalseExerciseNameId)
insert into dbo.LessonContents(Lesson_LessonId, [Order], [Type])--id20
values (10, 4, @SimpleExerciseNameId)
--Enunciates
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId) 
values('"Lets go out" y "Lets meet up" son formas coloquiales de sugerir un encuentro con amigos. "To go out" y "to meet up" también son verbos preposicionales o phrasal verbs. Un verbo preposicional generalmente está formado por un "verbo de base" y una preposición y, generalmente, su significado difiere del significado del verbo de base. 
En inglés, abundan los verbos preposicionales y aprenderás algunos más en la próxima lección.', 2)--id23

insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId)
values('Significa "¡Salgamos!"', 2)--24

insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId)
values('Escoge la opción correcta: Ill pick you up.', 2)--25

--translationSet
insert into dbo.TranslationSets(Imagepath) values('../Images/letsgoout.png')--id16
insert into dbo.TranslationSets(Description) values('LetsGrammar')--id17
insert into dbo.TranslationSets(Description) values('meetUpGrammar')--id18


--traslation set of to say lets go out
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)
values ('Lets go out.', 1, 16)--28
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)
values ('¡Salgamos!', 2, 16)--29

insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)
values('Lets go out on Saturday night.', 1, 17)--30
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)
values('¿Por qué no salimos el sábado por la noche?', 2, 17)--30

insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)
values('Can we meet up?', 1, 18)--31
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)
values('¿Podemos quedar?', 2, 18)--32

--Insert Listening Tips second level first lesson to English
insert into dbo.ListeningTips(TransaltionSetWords_TranslationSetId, LessonContent_LessonContentId) 
values(16, 9)--id9

--Insert Grammar tip
insert into dbo.GrammarTips(TipInterpretation_EnunciateId, LessonContent_LessonContentId) values(23, 10)--id9
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(9, 17)
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(9, 18)
	
declare @DefaultPuntuation int = 1;
--Insert True False exercises
insert into dbo.TF_Exercise(Enunciate_EnunciateId, Affirmation_SentenceId, IsTrue, LessonContent_LessonContentId, Puntuation) 
values(24, 28, 1, 11, @DefaultPuntuation)--id9

--Answers
insert into dbo.Answers(Sentence_SentenceId, State) values(46, 0)--id18

--Insert Simple Selection Exercises
insert into dbo.S_Exercise(Enunciate_EnunciateId, LessonContent_LessonContentId, Puntuation) 
values(3, 4, @DefaultPuntuation)--id9
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(1, 1)--id1
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(1, 2)--id2
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(1, 3)--id3
