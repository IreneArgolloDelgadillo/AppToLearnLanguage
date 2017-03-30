--This script is to fill data on database
--USE [EasyLearning.Models.EasyLearningDB]--if the database is on sqlserver management uncomment this

--Insert basic language
insert into dbo.Languages(Name) values('Ingles')--id1 for language
insert into dbo.Languages(Name) values('Español')--id2
insert into dbo.Languages(Name) values('Italiano')--id3

--Insert Level 1
insert into dbo.Levels(Title, OrderByDifficulty, BelongsLanguage_LanguageId, LanguageToLearn_LanguageId) 
values('Basico A1', 1, 2, 1)--id1 first level in spanish to english

insert into dbo.Levels(Title, OrderByDifficulty, BelongsLanguage_LanguageId, LanguageToLearn_LanguageId) 
values('Basico A1', 1, 2, 3)--id1 first level in spanish to italian

--English
--Insert Lesson 1 to Lesson 3 for Level 1
insert into dbo.Lessons(Title, Level_LevelId, OrderByLevel)--id1
values('Hello!', 1, 1)
insert into dbo.Lessons(Title, Level_LevelId, OrderByLevel)--id2
values('About me', 1, 2) 
insert into dbo.Lessons(Title, Level_LevelId, OrderByLevel)--id2
values('How are you?', 1, 3)
 

--Italian
--Insert Lesson 1 to Lesson 3 for Level 1
insert into dbo.Lessons(Title, Level_LevelId, OrderByLevel)--id10
values('Ciao!', 2, 1)
insert into dbo.Lessons(Title, Level_LevelId, OrderByLevel)--id11
values('A proposito di me', 2, 2) 
insert into dbo.Lessons(Title, Level_LevelId, OrderByLevel)--id12
values('Come stai?', 2, 3)

DECLARE @SimpleExerciseNameId int = 1;
DECLARE @TrueFalseExerciseNameId int = 2;
DECLARE @ListeningTipNameId int = 3;
DECLARE @GrammarTipNameId int = 4;

--Insert Content to Lesson 1
SET IDENTITY_INSERT LessonContents ON
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id1
values (1, 1, 1, @ListeningTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id2
values (2, 1, 2, @GrammarTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id3
values (3, 1, 3, @TrueFalseExerciseNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id4
values (4, 1, 4, @SimpleExerciseNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id5
values (5, 1, 5, @ListeningTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id6
values (6, 1, 6, @GrammarTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id7
values (7, 1, 7, @TrueFalseExerciseNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id8
values (8, 1, 8, @SimpleExerciseNameId)

--Insert Content to Lesson 2 level 1
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id9
values (9, 2, 9, @ListeningTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id10
values (10, 2, 10, @GrammarTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id11
values (11, 2, 11, @TrueFalseExerciseNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id12
values (12, 2, 12, @SimpleExerciseNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id13
values (13, 2, 13, @ListeningTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id14
values (14, 2, 14, @GrammarTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id15
values (15, 2, 15, @TrueFalseExerciseNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id16
values (16, 2, 16, @SimpleExerciseNameId)

--Insert Content to Lesson 3 level 1
SET IDENTITY_INSERT LessonContents ON
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id17
values (17, 3, 17, @ListeningTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id18
values (18, 3, 18, @GrammarTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id19
values (19, 3, 19, @TrueFalseExerciseNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id20
values (20, 3, 20, @SimpleExerciseNameId)



--Insert in Italian lessons contents
--Insert Content to Lesson 1
SET IDENTITY_INSERT LessonContents ON
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id45
values (45, 4, 45, @ListeningTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id46
values (46, 4, 46, @GrammarTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id47
values (47, 4, 47, @TrueFalseExerciseNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id48
values (48, 4, 48, @SimpleExerciseNameId)

--Insert Content to Lesson 2 level 1
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id49
values (49, 5, 49, @ListeningTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id50
values (50, 5, 50, @GrammarTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id51
values (51, 5, 51, @TrueFalseExerciseNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id52
values (52, 5, 52, @SimpleExerciseNameId)
--Insert Content to Lesson 3 level 1
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id53
values (53, 6, 53, @ListeningTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id54
values (54, 6, 54, @GrammarTipNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id55
values (55, 6, 55, @TrueFalseExerciseNameId)
insert into dbo.LessonContents(LessonContentId, Lesson_LessonId, [Order], [Type])--id56
values (56, 6, 56, @SimpleExerciseNameId)

--Enunciates
--For the lesson one Spanihs to english for Lesson 1
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId) 
values('"Hello" y "hi" pueden decirse en cualquier momento del día. Si bien "hi" es 
ligeramente más informal que "hello", ambas se usan mucho y, en general, son intercambiables.', 2)--id1
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId) 
values('Otra manera de decir "Hello"', 2)--id2
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId) 
values('"Hi" es una forma de decir', 2)--id3
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId)
 values('"Bye" y "Goodbye" son formas de decir Adios, "Goodbye" es un poco mas formal, pero en general se usan ambas', 2)--id4
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId) 
values('Otra manera de decir "Bye"', 2)--id5
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId) 
values('"Goodbye" y "bye" son formas de decir', 2)--id6
--lesson 2 level 1
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId)
 values('En inglés, "I am..." es la forma más fácil de decir tu nombre. Significa lo mismo que "My name is...".', 2)--id7
 insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId)
 values('La forma correcta de preguntarle a alguien su nombre es y responder a esta pregunta es', 2)--id8
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId) 
values('Otra manera de decir "I am"', 2)--id9
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId) 
values('"My name is" y "I am" son formas de decir', 2)--id10
--lesson 3 level 1
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId)
 values('Es bastante común decir "Not bad thanks" en vez de "Fine thanks", como respuesta a la pregunta "How are you?"', 2)--id11
 insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId)
 values('"How are you?" es una forma de decir', 2)--id12
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId) 
values('Cual no es una forma de responder a "How are you?"', 2)--id13

--Enunciates in italian
--For the lesson one Spanihs to english for Lesson 1
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId) 
values('"Ciao" y "Pronto" se puede decir en cualquier momento del dia como saludo, 
pero "Pronto" se utiliza mas para contestar llamadas.', 2)--id14
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId) 
values('Una forma de saludar es', 3)--id15
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId) 
values('"Ciao" es', 3)--id16
--lesson 2 level 1
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId)
 values('En italiano, "Il mio nome è ..." es la forma más fácil de decir tu nombre. Significa lo mismo que "Sono...".', 3)--id17
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId) 
values('Otra manera de decir "Il mio nome è"', 3)--id18
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId) 
values('"Il mio nome è" y "Sono" son formas de decir', 3)--id19
--lesson 3 level 1
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId)
 values('Es bastante común decir "sto bene grazie" en vez de "Io non sono cattivi grazie", como respuesta a la pregunta "Come stai?"', 3)--id20
 insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId)
 values('"Come stai?" es una forma de decir', 3)--id21
insert into dbo.Enunciates(GrammarOfEnunciate, BelongsLanguage_LanguageId) 
values('Cual no es una forma de responder a "Come stai?"', 3)--id22


--Insert Translation Set
insert into dbo.TranslationSets(Imagepath) values('../Images/Hello.jpg')--id1
insert into dbo.TranslationSets(Description) values('Salutes to Sarah')--id2
insert into dbo.TranslationSets(Description) values('Salutes to Juan')--id3
insert into dbo.TranslationSets(Imagepath) values('../Images/Hi.jpg')--id4
insert into dbo.TranslationSets(Description) values('Say goodbye to everyone')--id5
insert into dbo.TranslationSets(Description) values('Say GoodBye to Juan')--id6
insert into dbo.TranslationSets(Imagepath) values('../Images/Bye.jpg')--id7
insert into dbo.TranslationSets(Imagepath) values('../Images/WhatsName.jpg')--id8
insert into dbo.TranslationSets(Description) values('My name is')--id9
insert into dbo.TranslationSets(Description) values('I am')--id10
insert into dbo.TranslationSets(Imagepath) values('../Images/IAm.jpg')--id11
insert into dbo.TranslationSets(Description) values('Whats your name')--id12
insert into dbo.TranslationSets(Imagepath) values('../Images/HowAre.jpg')--id13
insert into dbo.TranslationSets(Description) values('How are you')--id14
insert into dbo.TranslationSets(Description) values('Fine')--id15

-- insert italian
insert into dbo.TranslationSets(Description) values('Salutes to Sarah')--id16
insert into dbo.TranslationSets(Description) values('Salutes to Juan')--id17
insert into dbo.TranslationSets(Imagepath) values('../Images/WhatsName.jpg')--id18
insert into dbo.TranslationSets(Description) values('My name is')--id19
insert into dbo.TranslationSets(Description) values('I am')--id20
insert into dbo.TranslationSets(Imagepath) values('../Images/IAm.jpg')--id21


--traslation set of to say hello (will use to a listening tip)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id1
values ('Hi', 1, 1)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id2
values ('Hello', 1, 4)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id3
values ('Hola', 2, 1)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id4
values ('Ciao', 3, 4)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id5
values ('Pronto', 3, 1)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id6
values ('Hola', 2, 4)

--traslation set of to say bye (will use to a listening tip)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id7
values ('Bye', 1, 7)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id8
values ('Goodbye', 1, 7)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id9
values ('Adios', 2, 7)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id10
values ('Addio', 3, 7)

--transalation set to say hello and bye to some person its to a gramartip
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id11
values('Hello everyone.', 1, 2)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id12
values('Hola a todos.', 2, 2)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id13
values('Ciao a tutti.', 3, 2)

insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id14
values('Hi Juan!', 1, 3)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id15
values('Hola Juan!', 2, 3)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id16
values('Ciao Juan!', 3, 3)


insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id17
values ('Goodbye everybody', 1, 5)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id18
values ('Adios a todos', 2, 5)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id19
values ('Addio a tutti', 3, 5)


insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id20
values ('GoodBye Juan', 1, 6)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id21
values ('Adios Juan', 2, 6)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id22
values ('Addio Juan', 3, 6)
--lesson2 level1
--traslation set of to say hello (will use to a listening tip)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id23
values ('What is your name?', 1, 8)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id24
values ('Cual es tu nombre?', 2, 8)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id25
values ('Qual è il tuo nome?', 3, 8)

insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id26
values ('My name is', 1, 11)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id27
values ('Mi nombre es', 2, 11)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id28
values ('Il mio nome è', 3, 11)

--transalation set to say hello and bye to some person its to a gramartip
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id29
values ('What is your name?', 1, 12)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id30
values ('Cual es tu nombre?', 2, 12)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id31
values ('Qual è il tuo nome', 3, 12)

insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id32
values ('My name is', 1, 9)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id33
values ('Mi nombre es', 2, 9)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id34
values ('Il mio nome è', 3, 9)

insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id35
values ('I am', 1, 10)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id36
values ('Yo soy', 2, 10)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id37
values ('Sono', 3, 10)

--lesson3 level1
--listening
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id38
values ('How are you?', 1, 13)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id39
values ('Como estas?', 2, 13)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id40
values ('Come stai', 3, 13)

--transalation set to say hello and bye to some person its to a gramartip
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id41
values ('I am fine thanks.', 1, 14)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id42
values ('Estoy bien gracias.', 2, 14)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id43
values ('Sto bene grazie', 3, 14)

insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id44
values ('I am not bad thanks', 1, 15)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id45
values ('Estoy bien gracias', 2, 15)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id46
values ('Io non sono cattivi grazie', 3, 15)
-- italian
--inserts
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id11
values('Hello everyone.', 1, 16)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id12
values('Hola a todos.', 2, 16)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id13
values('Ciao a tutti.', 3, 16)

insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id14
values('Hi', 1, 17)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id15
values('Hola', 2, 17)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id16
values('Ciao', 3, 17)

insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id41
values ('I am fine thanks.', 1, 18)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id42
values ('Estoy bien gracias.', 2, 18)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id43
values ('Sto bene grazie', 3, 18)

insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id44
values ('I am not bad thanks', 1, 19)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id45
values ('Estoy bien gracias', 2, 19)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id46
values ('Io non sono cattivi grazie', 3, 19)

insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id23
values ('What is your name?', 1, 20)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id24
values ('Cual es tu nombre?', 2, 20)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id25
values ('Qual è il tuo nome?', 3, 20)

insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id26
values ('My name is', 1, 21)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id27
values ('Mi nombre es', 2, 21)
insert into dbo.Sentences(GrammarOfSentence, BelongsLanguage_LanguageId, TranslationSet_TranslationSetId)--id28
values ('Il mio nome è', 3, 21)

--Insert Listening Tips
insert into dbo.ListeningTips(TransaltionSetWords_TranslationSetId, LessonContent_LessonContentId) values(4, 1)--id1
insert into dbo.ListeningTips(TransaltionSetWords_TranslationSetId, LessonContent_LessonContentId) values(7, 5)--id2
insert into dbo.ListeningTips(TransaltionSetWords_TranslationSetId, LessonContent_LessonContentId) values(8, 9)--id3
insert into dbo.ListeningTips(TransaltionSetWords_TranslationSetId, LessonContent_LessonContentId) values(11, 13)--id4
insert into dbo.ListeningTips(TransaltionSetWords_TranslationSetId, LessonContent_LessonContentId) values(13, 17)--id4

--Insert Listening Tips in Italian
insert into dbo.ListeningTips(TransaltionSetWords_TranslationSetId, LessonContent_LessonContentId) values(4, 45)--id1
insert into dbo.ListeningTips(TransaltionSetWords_TranslationSetId, LessonContent_LessonContentId) values(7, 49)--id2
insert into dbo.ListeningTips(TransaltionSetWords_TranslationSetId, LessonContent_LessonContentId) values(8, 53)--id3


--Insert Grammar tip
insert into dbo.GrammarTips(TipInterpretation_EnunciateId, LessonContent_LessonContentId) values(1, 2)--id1
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(1, 2)
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(1, 3)
	
insert into dbo.GrammarTips(TipInterpretation_EnunciateId, LessonContent_LessonContentId) values(4, 6)--id2
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(2, 5)
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(2, 6)

insert into dbo.GrammarTips(TipInterpretation_EnunciateId, LessonContent_LessonContentId) values(7, 10)--id3
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(3, 9)
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(3, 10)
	
insert into dbo.GrammarTips(TipInterpretation_EnunciateId, LessonContent_LessonContentId) values(8, 14)--id4
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(4, 8)
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(4, 11)
	
insert into dbo.GrammarTips(TipInterpretation_EnunciateId, LessonContent_LessonContentId) values(11, 18)--id5
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(5, 14)
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(5, 15)	
	
--Insert grammar tip Italian
--Insert Grammar tip
insert into dbo.GrammarTips(TipInterpretation_EnunciateId, LessonContent_LessonContentId) values(14, 46)--id6
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(6, 16)
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(6, 17)
	
insert into dbo.GrammarTips(TipInterpretation_EnunciateId, LessonContent_LessonContentId) values(17, 50)--id7
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(7, 20)
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(7, 21)
	
insert into dbo.GrammarTips(TipInterpretation_EnunciateId, LessonContent_LessonContentId) values(20, 54)--id8
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(8, 18)
	insert into dbo.GrammarTipTranslationSets(GrammarTip_GrammarTipId, TranslationSet_TranslationSetId) values(8, 19)
	
	
declare @DefaultPuntuation int = 1;
--Insert True False exercises
insert into dbo.TF_Exercise(Enunciate_EnunciateId, Affirmation_SentenceId, IsTrue, LessonContent_LessonContentId, Puntuation) 
values(2, 1, 1, 3, @DefaultPuntuation)--id1
insert into dbo.TF_Exercise(Enunciate_EnunciateId, Affirmation_SentenceId, IsTrue, LessonContent_LessonContentId, Puntuation) 
values(5, 3, 0, 7, @DefaultPuntuation)--id2
insert into dbo.TF_Exercise(Enunciate_EnunciateId, Affirmation_SentenceId, IsTrue, LessonContent_LessonContentId, Puntuation) 
values(10, 27, 1, 11, @DefaultPuntuation)--id3
insert into dbo.TF_Exercise(Enunciate_EnunciateId, Affirmation_SentenceId, IsTrue, LessonContent_LessonContentId, Puntuation) 
values(9, 26, 1, 15, @DefaultPuntuation)--id4
insert into dbo.TF_Exercise(Enunciate_EnunciateId, Affirmation_SentenceId, IsTrue, LessonContent_LessonContentId, Puntuation) 
values(12, 39, 1, 19, @DefaultPuntuation)--id5

--Insert True false exercises in italian--Insert True False exercises
insert into dbo.TF_Exercise(Enunciate_EnunciateId, Affirmation_SentenceId, IsTrue, LessonContent_LessonContentId, Puntuation) 
values(15, 4, 1, 47, @DefaultPuntuation)--id1
insert into dbo.TF_Exercise(Enunciate_EnunciateId, Affirmation_SentenceId, IsTrue, LessonContent_LessonContentId, Puntuation) 
values(18, 37, 1, 51, @DefaultPuntuation)--id2
insert into dbo.TF_Exercise(Enunciate_EnunciateId, Affirmation_SentenceId, IsTrue, LessonContent_LessonContentId, Puntuation) 
values(21, 39, 1, 55, @DefaultPuntuation)--id3


--Insert Answers
insert into dbo.Answers(Sentence_SentenceId, State) values(9, 0)--id1
insert into dbo.Answers(Sentence_SentenceId, State) values(3, 1)--id2
insert into dbo.Answers(Sentence_SentenceId, State) values(7, 0)--id3

insert into dbo.Answers(Sentence_SentenceId, State) values(6, 0)--id4
insert into dbo.Answers(Sentence_SentenceId, State) values(9, 1)--id5
insert into dbo.Answers(Sentence_SentenceId, State) values(12, 0)--id6

insert into dbo.Answers(Sentence_SentenceId, State) values(29, 0)--id7
insert into dbo.Answers(Sentence_SentenceId, State) values(26, 1)--id8
insert into dbo.Answers(Sentence_SentenceId, State) values(14, 0)--id9

insert into dbo.Answers(Sentence_SentenceId, State) values(6, 0)--id10
insert into dbo.Answers(Sentence_SentenceId, State) values(24, 1)--id11
insert into dbo.Answers(Sentence_SentenceId, State) values(12, 0)--id12

insert into dbo.Answers(Sentence_SentenceId, State) values(7, 1)--id13
insert into dbo.Answers(Sentence_SentenceId, State) values(41, 0)--id14
insert into dbo.Answers(Sentence_SentenceId, State) values(44, 0)--id15

--Italian
insert into dbo.Answers(Sentence_SentenceId, State) values(3, 1)--id13
insert into dbo.Answers(Sentence_SentenceId, State) values(9, 0)--id14
insert into dbo.Answers(Sentence_SentenceId, State) values(12, 0)--id15

insert into dbo.Answers(Sentence_SentenceId, State) values(27, 1)--id16
insert into dbo.Answers(Sentence_SentenceId, State) values(10, 0)--id17
insert into dbo.Answers(Sentence_SentenceId, State) values(3, 0)--id18

insert into dbo.Answers(Sentence_SentenceId, State) values(26, 1)--id16
insert into dbo.Answers(Sentence_SentenceId, State) values(43, 0)--id17
insert into dbo.Answers(Sentence_SentenceId, State) values(46, 0)--id18


--Insert Simple Selection Exercises
insert into dbo.S_Exercise(Enunciate_EnunciateId, LessonContent_LessonContentId, Puntuation) 
values(3, 4, @DefaultPuntuation)--id1
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(1, 1)--id1
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(1, 2)--id2
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(1, 3)--id3

insert into dbo.S_Exercise(Enunciate_EnunciateId, LessonContent_LessonContentId, Puntuation)
 values(6, 8, @DefaultPuntuation)--id2
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(2, 4)--id4
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(2, 5)--id5
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(2, 6)--id6
	
insert into dbo.S_Exercise(Enunciate_EnunciateId, LessonContent_LessonContentId, Puntuation) 
values(9, 12, @DefaultPuntuation)--id3
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(3, 7)--id7
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(3, 8)--id8
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(3, 9)--id9

insert into dbo.S_Exercise(Enunciate_EnunciateId, LessonContent_LessonContentId, Puntuation)
 values(10, 16, @DefaultPuntuation)--id4
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(4, 10)--id10
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(4, 11)--id11
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(4, 12)--id12
	
insert into dbo.S_Exercise(Enunciate_EnunciateId, LessonContent_LessonContentId, Puntuation)
 values(13, 20, @DefaultPuntuation)--id5
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(5, 13)--id13
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(5, 14)--id14
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(5, 15)--id15	
	
--Insert simple exercise in italian
insert into dbo.S_Exercise(Enunciate_EnunciateId, LessonContent_LessonContentId, Puntuation)
 values(16, 48, @DefaultPuntuation)--id6
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(6, 16)--id16
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(6, 17)--id17
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(6, 18)--id18	
	
insert into dbo.S_Exercise(Enunciate_EnunciateId, LessonContent_LessonContentId, Puntuation)
 values(19, 52, @DefaultPuntuation)--id7
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(7, 19)--id19
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(7, 20)--id20
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(7, 21)--id21
	
insert into dbo.S_Exercise(Enunciate_EnunciateId, LessonContent_LessonContentId, Puntuation)
 values(22, 56, @DefaultPuntuation)--id8
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(8, 22)--id22
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(8, 23)--id23
	insert into dbo.S_ExerciseAnswer(S_Exercise_S_ExerciseId, Answer_AnswerId) values(8, 24)--id24
	
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