--execute this script to create the procedure and function dependences
USE [aspnet-EasyLearning.Service-20170203071243]
GO
--this function returns the first contentn of a lesson
CREATE FUNCTION [dbo].GetFirstIdByLesson
(
	@LessonId int
)
RETURNS int AS 
BEGIN
	return (SELECT Top(1)  lc.LessonContentId
	from LessonContents lc
	where lc.Lesson_LessonId = @LessonId
	order by lc.[Order]);
END
go
--this is the function that analyze witch is the next exercise contentId
CREATE FUNCTION [dbo].GetNextIdOfLesson
(
	@CurrentContentLessonId int
)
RETURNS int AS 
Begin
Declare @CurrentLessonId int, @CurrentOrder int;
		select @CurrentLessonId = lc.Lesson_LessonId, @CurrentOrder = lc.[Order]
		from LessonContents lc 
		where lc.LessonContentId = @CurrentContentLessonId
return(
	select Top(1) lc.LessonContentId
		from LessonContents lc 
		where lc.Lesson_LessonId = @CurrentLessonId and
			lc.[Order] > @CurrentOrder
		order by lc.[Order]
);

End
go
--this function return the lessonContentId that  the procedure will analizy to get the attributes
--if lessonId is not null that means taht will return the first lessonContentId,and if the lessonContentId 
--is not null the function will return the content that follows the currentContentLessonId
CREATE FUNCTION [dbo].[GetLessonContentId]
(
	@CurrentContentLessonId int,
	@LessonId int
)
RETURNS int  
BEGIN
	DECLARE @LessonContentId int = NULL;

	if(@CurrentContentLessonId IS NOT NULL) BEGIN
		exec @LessonContentId = dbo.GetNextIdOfLesson
								@CurrentContentLessonId = @CurrentContentLessonId
	END
	else if(@LessonId IS NOT NULL) BEGIN
		exec @LessonContentId =  dbo.GetFirstIdByLesson 
									@LessonId = @LessonId;
	END
	return @LessonContentId;
END
go
--This function return the exercise type Id of a lesson content, this are the values 
--for each type: 
--SimpleExerciseNameId int = 1;
--TrueFalseExerciseNameId int = 2;
--ListeningTipNameId int = 3;
--GrammarTipNameId int = 4;
CREATE FUNCTION [dbo].[GetContentTypeName]
(
	@LessonContentId int
)
RETURNS int AS
BEGIN
	RETURN (select lc.[Type]
	from LessonContents lc 
	where lc.LessonContentId = @LessonContentId);
END
go
--This funtion returns { ExerciseId, Enunciate, ImagePath, ContentType, LessonContentId, affirmation } 
-- of the lesson content 
CREATE FUNCTION [dbo].[GetTrueFalseContent]
(
	@LessonContentId int
)
RETURNS TABLE AS RETURN
(
	select tf.TF_ExerciseId, e.GrammarOfEnunciate as Enunciate, ts.ImagePath, 
			2 as ContentType, @LessonContentId as LessonContentId, tf.Puntuation
	from TF_Exercise tf, Enunciates e, Sentences s, TranslationSets ts
	where tf.LessonContent_LessonContentId = @LessonContentId and
		tf.Enunciate_EnunciateId = e.EnunciateId and
		ts.TranslationSetId = s.TranslationSet_TranslationSetId
)
go

Create Procedure [dbo].[GetTrueFalseAffirmation]
(
	@ExerciseId int
)As
BEGIN
	select s.GrammarOfSentence as Affirmation
	from TF_Exercise tf, Sentences s
	where tf.TF_ExerciseId = @ExerciseId and tf.Affirmation_SentenceId = s.SentenceId
END
go

--This funtion returns { imagePath } the image path represent the path of the correct answer option
--for a simpleselection entity, 
CREATE FUNCTION [dbo].[GetImagenPathOfSE]
(
	@SExerciseId int
)
RETURNS NVARCHAR(255) 
BEGIN

return (select ts.ImagePath
	from S_Exercise se, S_ExerciseAnswer sea, Answers a, 
			Sentences s, TranslationSets ts
	where se.S_ExerciseId = @SExerciseId and
			se.S_ExerciseId = sea.S_Exercise_S_ExerciseId and
			sea.Answer_AnswerId =a.AnswerId and
			a.Sentence_SentenceId = s.SentenceId and
			s.TranslationSet_TranslationSetId = ts.TranslationSetId and 
			a.[State] = 1 );

END
go
--This funtion returns { ExerciseId, Enunciate, ImagePath, ContentType, LessonContentId  } 
-- of the lesson content 
CREATE FUNCTION [dbo].[GetSimpleSelectionContent]
(
	@LessonContentId int
)
RETURNS TABLE AS RETURN
(
	select se.S_ExerciseId, e.GrammarOfEnunciate as Enunciate, 
			dbo.GetImagenPathOfSE(se.S_ExerciseId) as ImagenPath, 
			1 as ExerciseType, @LessonContentId as LessonContentId, se.Puntuation
	from S_Exercise se, Enunciates e
	where se.LessonContent_LessonContentId = @LessonContentId and
			se.Enunciate_EnunciateId = e.EnunciateId  
)
go
--this store procedure returns the answer options of a simple Selection exercise 
--with this attributes: {AnswerId, AnwerOptionOrPhrace}
CREATE PROCEDURE [dbo].GetSimpleSelectionOptions
	@SExerciseId int
AS
SELECT a.AnswerId , s.GrammarOfSentence as AnswerOption
from Answers a, S_ExerciseAnswer sea, S_Exercise se, Sentences s
where se.S_ExerciseId = @SExerciseId and 
		a.AnswerId = sea.Answer_AnswerId and 
		sea.S_Exercise_S_ExerciseId = se.S_ExerciseId and 
		a.Sentence_SentenceId = s.SentenceId
go
--This funtion returns { phraseOrSentence  }  like string
-- in a specify language
CREATE FUNCTION [dbo].[GetSentenceIn]
(
	@TranslationSetId int,
	@LanguageId int
)
RETURNS nvarchar(255) As 
begin
	return (SELECT Top(1) s.GrammarOfSentence
			from TranslationSets ts, Sentences s
			where s.TranslationSet_TranslationSetId = @TranslationSetId and
					s.BelongsLanguage_LanguageId = @LanguageId);
end
go

--this function returns the languages of a specify user
--the native or origin language, and the language that user wanth to learn
CREATE FUNCTION [dbo].[GetUserLanguages]
(
	@UserId nvarchar(255)
)
RETURNS TABLE AS RETURN
(
		select u.NativeLanguage_LanguageId as Native, u.LanguageToLearn_LanguageId as ToLearn
		from UserLanguages u
		where u.User_Id = @UserId
)
go

--This funtion returns { phraseOrSentence  }  like string
-- in the user native language
CREATE FUNCTION [dbo].[GetSentenceInNative]
(
	@TranslationSetId int,
	@UserId nvarchar(255)
)
RETURNS nvarchar(255) AS 
BEGIN
	Declare @NativeLanguageId int = (select u.Native from dbo.GetUserLanguages(@UserId) u);
	DECLARE	@return_value NVarChar(255)

	EXEC	@return_value = [dbo].[GetSentenceIn]
			@TranslationSetId = @TranslationSetId,
			@LanguageId = @NativeLanguageId
	return @return_value;

END
go

--This funtion returns { phraseOrSentence  }  like string
-- in a User language to learn
CREATE FUNCTION [dbo].[GetSentenceTranslated]
(
	@TranslationSetId int,
	@UserId nvarchar(255)
)
RETURNS nvarchar(255) AS 
BEGIN
	Declare @LanguageId int = (select u.ToLearn from dbo.GetUserLanguages(@UserId) u);
	DECLARE	@return_value NVarChar(255)

	EXEC	@return_value = [dbo].[GetSentenceIn]
			@TranslationSetId = @TranslationSetId,
			@LanguageId = @LanguageId
	return @return_value;

END
go
--This funtion returns { ExerciseId, TranslationSetId, ImagePath, ContentType, LessonContentId } 
--the attributes of a Listening tip lesson
CREATE FUNCTION [dbo].[GetListeningTipContent]
(
	@LessonContentId int
)
RETURNS TABLE AS RETURN
(

	select lt.ListeningTipId, ts.TranslationSetId, ts.ImagePath,  3 as ContentType, 
			@LessonContentId  as LessonContentId
	from ListeningTips lt, TranslationSets ts
	where lt.LessonContent_LessonContentId = @LessonContentId and 
			lt.TransaltionSetWords_TranslationSetId = ts.TranslationSetId
)
go
--this store procedure returns the words for a listening tip, the function return two 
--words of a trnslation set, that will be in native and language to lear of a user
CREATE PROCEDURE [dbo].GetListeningTipWords
	@TranslationSetId int,
	@UserId nvarchar(255)
AS
	select dbo.GetSentenceInNative(@TranslationSetId, @UserId) as SentenceInNative, 
			dbo.GetSentenceTranslated(@TranslationSetId, @UserId) as SentenceTranslated
go
--This funtion returns { GrammarTipId, Enunciate, ContentType, LessonContentId } 
--the attributes of a grammar tip lesson
CREATE FUNCTION [dbo].[GetGrammarTipContent]
(
	@LessonContentId int
)
RETURNS TABLE AS RETURN
(
	select gt.GrammarTipId, e.GrammarOfEnunciate as Enunciate, 4 as ContentType, 
			@LessonContentId as LessonContentId
	from GrammarTips gt, Enunciates e
	where gt.LessonContent_LessonContentId = @LessonContentId and
			gt.TipInterpretation_EnunciateId = e.EnunciateId
)
go
--This is the procedure that returns the grammar tip examples, the examples are in the native
-- language and translated to the user language to learn
CREATE Procedure [dbo].[GetGrammarExamples]
(
	@GrammarTipId int,
	@UserId nvarchar(255)
)
AS 
(
	SELECT dbo.GetSentenceTranslated(ts.TranslationSetId, @UserId) as Example,
	 dbo.GetSentenceInNative(ts.TranslationSetId, @UserId) as Significate
	from GrammarTips gt, GrammarTipTranslationSets gts, TranslationSets ts
	where gt.GrammarTipId = @GrammarTipId and
			gts.GrammarTip_GrammarTipId = gt.GrammarTipId and
			gts.TranslationSet_TranslationSetId = ts.TranslationSetId 
)
go
--This Procedure proces the lesson Id to return the first content lesson, also if the lesson Id is null
-- the procedure search wich is the next content lesson to return the next content lesson attributes
--that could be a simple selection exercise, true false exercise, listening tip or grammar tip
CREATE PROCEDURE [dbo].[GetContentLesson]
	@CurrentContentLessonId int = NULL,
	@LessonId int = NULL
AS
BEGIN

DECLARE @LessonContentId int;
EXEC	@LessonContentId = [dbo].[GetLessonContentId]
							@CurrentContentLessonId = @CurrentContentLessonId, 
							@LessonId = @LessonId;

DECLARE @ContentNameId int ; 
Exec	@ContentNameId = dbo.GetContentTypeName
						 @LessonContentId = @LessonContentId;

DECLARE @SimpleExerciseNameId int = 1;
DECLARE @TrueFalseExerciseNameId int = 2;
DECLARE @ListeningTipNameId int = 3;
DECLARE @GrammarTipNameId int = 4;

if(@ContentNameId = @SimpleExerciseNameId)
Begin
	SELECT * FROM [dbo].[GetSimpleSelectionContent](@LessonContentId)
End 
else if(@ContentNameId = @TrueFalseExerciseNameId)Begin
	SELECT * FROM [dbo].[GetTrueFalseContent](@LessonContentId)
End 
else if(@ContentNameId = @ListeningTipNameId)Begin
	SELECT * FROM [dbo].[GetListeningTipContent](@LessonContentId)
End 
else if(@ContentNameId = @GrammarTipNameId)Begin
	SELECT * FROM [dbo].[GetGrammarTipContent](@LessonContentId)
End 
END
go
--This script is to create a trigger that will control that the Exercise solved will have only one exercisecontent by user
CREATE TRIGGER [UpdateExerciseSolved]
	ON [dbo].[ExerciseSolveds]
	FOR INSERT
	AS
	BEGIN
	declare @LessonContentId int, @User nvarchar(255), @ExistingId int, @ThisExerciseSolvedId int,
			@LessonId int, @NewProgress int, @ExerciseSolveds int, @TotalExercises int, @LessonProgres int;

	select @LessonContentId = i.Exercise_LessonContentId,
			@User = i.User_Id, @ThisExerciseSolvedId = i.ExerciseSolvedId
	from inserted i


	DELETE from ExerciseSolveds 
	where ExerciseSolvedId != @ThisExerciseSolvedId and 
			Exercise_LessonContentId = @LessonContentId and User_Id = @User
	END





