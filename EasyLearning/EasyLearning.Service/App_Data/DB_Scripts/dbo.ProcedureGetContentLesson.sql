CREATE PROCEDURE [dbo].[GetContentLesson] 
	@CurrentLessonContent int = 1
AS
DECLARE @SimpleExerciseNameId int = 1;
DECLARE @TrueFalseExerciseNameId int = 2;
DECLARE @ListeningTipNameId int = 3;
DECLARE @GrammarTipNameId int = 4;

Declare @CurrentLessonOrder int;

Set @CurrentLessonOrder = ( select lc.[Order]
							from LessonContents lc
							where lc.LessonContentId = @CurrentLessonContent and lc.LessonContentId is not null);


Declare @NextLessonContentId int;

Set @NextLessonContentId = (Select lc.LessonContentId
							from LessonContents lc
							where lc.[Order] = @CurrentLessonOrder + 1);

select @NextLessonContentId;

if(@NextLessonContentId IS NULL) begin 
	Declare @MessageNoMoreContent nvarchar(50) = 'There are no more content for this lesson';
	select @MessageNoMoreContent;
end

--The required parameter to get exercises or tips is a LessonContentId
DECLARE @LessonContentId int = @NextLessonContentId;
DECLARE @ContentNameId int ; 

SET @ContentNameId = ( select ct.Name 
						from LessonContents lc, ContentTypes ct
						where lc.Type_ContentTypeId = ct.ContentTypeId and 
									lc.LessonContentId = @LessonContentId ); 

if(@ContentNameId = @SimpleExerciseNameId)
Begin
	select e.GrammarOfEnunciate as Enunciate, s.GrammarOfSentence as AnswerOption, a.State as IsCorrect, ts.ImagePath
	from S_Exercise se, Enunciates e, Sentences s, S_ExerciseAnswer sa, Answers a, TranslationSets ts
	where se.LessonContent_LessonContentId = @LessonContentId and
			se.Enunciate_EnunciateId = e.EnunciateId and
			sa.Answer_AnswerId = a.AnswerId and
			sa.S_Exercise_S_ExerciseId = se.S_ExerciseId and
			a.Sentence_SentenceId = s.SentenceId and
			ts.TranslationSetId = s.TranslationSet_TranslationSetId

End 
else if(@ContentNameId = @TrueFalseExerciseNameId)Begin

	select e.GrammarOfEnunciate as Enunciate, s.GrammarOfSentence as SentenceToEvaluate, tf.IsTrue as Answer, ts.ImagePath
	from TF_Exercise tf, Enunciates e, Sentences s, TranslationSets ts
	where tf.LessonContent_LessonContentId = @LessonContentId and
		tf.Enunciate_EnunciateId = e.EnunciateId and
		TF.Sentence_SentenceId = s.SentenceId and
		ts.TranslationSetId = s.TranslationSet_TranslationSetId
End 
else if(@ContentNameId = @ListeningTipNameId)Begin
	
	select ts.ImagePath, s.GrammarOfSentence, s.SentenceId, s.BelongsLanguage_LanguageId
	from ListeningTips lt, TranslationSets ts, Sentences s
	where lt.LessonContent_LessonContentId = @LessonContentId and 
						lt.TransaltionSetWords_TranslationSetId = ts.TranslationSetId and
						s.TranslationSet_TranslationSetId = ts.TranslationSetId
End 
else if(@ContentNameId = @GrammarTipNameId)Begin
	select e.GrammarOfEnunciate as Enunciate, s.GrammarOfSentence as Examples
	from GrammarTips gt, Enunciates e, Sentences s, GrammarTipSentences gts
	where gt.LessonContent_LessonContentId = @LessonContentId and  
			gt.GrammarTipId = gts.GrammarTip_GrammarTipId and
			gts.Sentence_SentenceId = s.SentenceId and
			gt.TipInterpretation_EnunciateId = e.EnunciateId

End 

