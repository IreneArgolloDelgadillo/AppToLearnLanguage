--This script is to fill data on database
--USE [EasyLearning.Models.EasyLearningDB]--if the database is on sqlserver management uncomment this

--Insert basic language
insert into dbo.Languages(Name) values('English')--id1 for language
insert into dbo.Languages(Name) values('Spanish')--id2
insert into dbo.Languages(Name) values('Italian')--id3

--Insert Levels 
insert into dbo.Levels(Title, OrderByDifficulty, BelongsLanguage_LanguageId, LanguageToLearn_LanguageId) 
values('Basico A1', 1, 2, 1)--id1 first level in spanish to english
insert into dbo.Levels(Title, OrderByDifficulty, BelongsLanguage_LanguageId, LanguageToLearn_LanguageId) 
values('Elemental A2', 2, 2, 1)--id2 second level in spanish to english
insert into dbo.Levels(Title, OrderByDifficulty, BelongsLanguage_LanguageId, LanguageToLearn_LanguageId) 
values('Intermedio B1', 3, 2, 1)--id3 3ro level in spanish to english
insert into dbo.Levels(Title, OrderByDifficulty, BelongsLanguage_LanguageId, LanguageToLearn_LanguageId) 
values('Intermedio Alto B2', 4, 2, 1)--id4 4t level in spanish to english

insert into dbo.Levels(Title, OrderByDifficulty, BelongsLanguage_LanguageId, LanguageToLearn_LanguageId) 
values('Basico A1', 1, 2, 3)--id5 first level in spanish to italian
insert into dbo.Levels(Title, OrderByDifficulty, BelongsLanguage_LanguageId, LanguageToLearn_LanguageId) 
values('Elemental A2', 2, 2, 3)--id6 second level in spanish to italian
insert into dbo.Levels(Title, OrderByDifficulty, BelongsLanguage_LanguageId, LanguageToLearn_LanguageId) 
values('Intermedio B1', 3, 2, 3)--id7 3ro level in spanish to italian
insert into dbo.Levels(Title, OrderByDifficulty, BelongsLanguage_LanguageId, LanguageToLearn_LanguageId) 
values('Intermedio Alto B2', 4, 2, 3)--id8 4t level in spanish to italian

insert into dbo.Levels(Title, OrderByDifficulty, BelongsLanguage_LanguageId, LanguageToLearn_LanguageId) 
values('Basic A1', 1, 1, 2)--id9 5t level in english to spanish
insert into dbo.Levels(Title, OrderByDifficulty, BelongsLanguage_LanguageId, LanguageToLearn_LanguageId) 
values('Elementary A2', 2, 1, 2)--id10 5t level in english to spanish
insert into dbo.Levels(Title, OrderByDifficulty, BelongsLanguage_LanguageId, LanguageToLearn_LanguageId) 
values('Intermediate B1', 3, 1, 2)--id11 5t level in english to spanish
insert into dbo.Levels(Title, OrderByDifficulty, BelongsLanguage_LanguageId, LanguageToLearn_LanguageId) 
values('Intermediate High B2', 4, 1, 2)--id12 5t level in english to spanish

--Insert Lessons is not more necesary the belong language attribute because the level has the belongs languge for the title sentence reference
insert into dbo.Lessons(Title, Level_LevelId, OrderByLevel)--id1
values('Hello!', 1, 1)
insert into dbo.Lessons(Title, Level_LevelId, OrderByLevel)--id2
values('About me', 1, 2)
insert into dbo.Lessons(Title, Level_LevelId, OrderByLevel)--id3
values('How are you?', 1, 3)

insert into dbo.Lessons(Title, Level_LevelId, OrderByLevel)--id4
values('Saluti', 5, 1)
insert into dbo.Lessons(Title, Level_LevelId, OrderByLevel)--id5
values('Presentate', 5, 2)
insert into dbo.Lessons(Title, Level_LevelId, OrderByLevel)--id6
values('Que tal?', 5, 3)

DECLARE @SimpleExerciseNameId int = 1;
DECLARE @TrueFalseExerciseNameId int = 2;
DECLARE @ListeningTipNameId int = 3;
DECLARE @GrammarTipNameId int = 4;
--Insert Content
SET IDENTITY_INSERT LessonContents ON
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id1
values (1, 1, 4, @ListeningTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id2
values (2, 1, 3, @GrammarTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id3
values (3, 1, 1, @TrueFalseExerciseNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id4
values (4, 1, 2, @SimpleExerciseNameId)

insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id5
values (5, 4, 1, @ListeningTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id6
values (6, 4, 2, @ListeningTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id7
values (7, 4, 3, @ListeningTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id8
values (8, 4, 4, @SimpleExerciseNameId)


--Enunciates
--For the lesson one Spanihs to english
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId) values('"Hello" y "hi" pueden decirse en cualquier momento del día. Si bien "hi" es 
ligeramente más informal que "hello", ambas se usan mucho y, en general, son intercambiables.', 2)--id1
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId) values('Otra manera de decir "Hello"', 2)--id2
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId) values('Traduccion de "Hi" en español', 2)--id3
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId) values('Traduccion de "Hola" en italiano', 2)--id4

--Insert Translation Set
insert into dbo.TranslationSets(Imagepath) values('../Images/Hello.jpg')--id1
insert into dbo.TranslationSets(Description) values('Salutes to Sarah')--id2
insert into dbo.TranslationSets(Description) values('Salutes to Juan')--id3
insert into dbo.TranslationSets(ImagePath) values('../Images/Thanks.jpg')--id4
insert into dbo.TranslationSets(ImagePath) values('../Images/Sorry.jpg')--id5
insert into dbo.TranslationSets(ImagePath) values('../Images/GodMorning.jpg')--id6 
insert into dbo.TranslationSets(ImagePath) values('../Images/Goodnight.jpg')--id7

--below this will insert some Sentences 
--traslation set of to say hello (will use to a listening tip)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id1
values ('Hi', 1, 1)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id2
values ('Hello', 1, 1)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id3
values ('Hola', 2, 1)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id4
values ('Ciao', 3, 1)

insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id5
values ('Buenos días', 2, 6)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id6
values ('Buongiorno', 3, 6)

insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id7
values ('Buenos noches', 2, 7)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id8
values ('Buonanotte', 3, 7)

--transalation set to say hello to some person its to a gramartip
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)values('Hello Sarah.', 1, 2)--id9
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)values('Hola, Sarah.', 2, 2)--id10
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)values('Hi Juan!', 1, 3)--id11
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)values('Hola, Juan!', 2, 3)--id12

insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)values ('Thaks', 1, 4)--id13
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)values ('Gracias', 2, 4)--id14

insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)values ('Sorry', 1, 5)--id15
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)values ('Lo Siento', 2, 5)--id16

--Insert Listening Tips
insert into dbo.ListeningTips(TransaltionSetWords_TranslationSetId, LessonContent_LessonContentId) values(1, 1)--id1

insert into dbo.ListeningTips(TransaltionSetWords_TranslationSetId, LessonContent_LessonContentId) values(1, 5)--id2
insert into dbo.ListeningTips(TransaltionSetWords_TranslationSetId, LessonContent_LessonContentId) values(6, 6)--id3
insert into dbo.ListeningTips(TransaltionSetWords_TranslationSetId, LessonContent_LessonContentId) values(7, 7)--id3

--Insert Grammar tip
insert into dbo.GrammarTips(TipInterpretation_EnunciateId, LessonContent_LessonContentId) values(1, 2)--id1
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(1, 2)
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(1, 3)

declare @DefaultPuntuation int = 1;
--Insert True False exercises
insert into dbo.TF_Exercise(Enunciate_EnunciateId, Affirmation_SentenceId, IsTrue, LessonContent_LessonContentId, Puntuation) 
values(2, 1, 1, 3, @DefaultPuntuation)--id1

--Insert Answers
insert into dbo.Answers(Sentence_SentenceId, State) values(3, 1)--id1
insert into dbo.Answers(Sentence_SentenceId, State) values(14, 0)--id2
insert into dbo.Answers(Sentence_SentenceId, State) values(16, 0)--id3

insert into dbo.Answers(Sentence_SentenceId, State) values(4, 1)--id4
insert into dbo.Answers(Sentence_SentenceId, State) values(6, 0)--id5
insert into dbo.Answers(Sentence_SentenceId, State) values(8, 0)--id6

--Insert Simple Selection Exercises
insert into dbo.S_Exercise(Enunciate_EnunciateId, LessonContent_LessonContentId, Puntuation) values(3, 4, @DefaultPuntuation)--id1
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(1, 2)--id1
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(1, 3)--id2
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(1, 1)--id3

insert into dbo.S_Exercise(Enunciate_EnunciateId, LessonContent_LessonContentId, Puntuation) values(4, 8, @DefaultPuntuation)--id2
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(2, 4)--id4
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(2, 6)--id5
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(2, 5)--id6

--Insert User data
Declare @EnglishId int = 1, @SpanishId int = 2;
insert into dbo.AspNetUsers(AccessFailedCount,Email, EmailConfirmed,PasswordHash,
						Id, LockoutEnabled, PhoneNumberConfirmed,  TwoFactorEnabled, UserName)
values(1,'irene@fundacion-jala.org', 1,'Softure05.irene' ,'irene892',1, 1, 1, 'irene' );

insert into dbo.AspNetUsers(AccessFailedCount,Email, EmailConfirmed,PasswordHash,
						Id, LockoutEnabled, PhoneNumberConfirmed,  TwoFactorEnabled, UserName)
values(1,'maria@fundacion-jala.org', 1,'Softure05.maria' ,'maria123',1, 1, 1, 'maria' );

--Insert User Languages
insert into dbo.UserLanguages(User_Id, NativeLanguage_LanguageId, LanguageToLearn_LanguageId) values('irene892', 2, 1)
insert into dbo.UserLanguages(User_Id, NativeLanguage_LanguageId, LanguageToLearn_LanguageId) values('maria123', 2, 1)

--A exercise solved with score is introduced to only to prove that the data base funtion to save data
insert into ExerciseSolveds(Exercise_LessonContentId, LastProgressDate, Score, User_Id) values(1, getdate(), 1, 'maria123')
insert into ExerciseSolveds(Exercise_LessonContentId, LastProgressDate, Score, User_Id) values(1, getdate(), 1, 'irene892')
insert into ExerciseSolveds(Exercise_LessonContentId, LastProgressDate, Score, User_Id) values(2, getdate(), 0, 'irene892')