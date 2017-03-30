CREATE FUNCTION [dbo].[GetAnswerOptions]
(
	@SExerciseId int
)
RETURNS TABLE AS RETURN
(
	SELECT a.AnswerId , s.GrammarOfSentence as AnswerOption
	from Answers a, S_ExerciseAnswer sea, S_Exercise se, Sentences s
	where se.S_ExerciseId = @SExerciseId and 
			a.AnswerId = sea.Answer_AnswerId and 
			sea.S_Exercise_S_ExerciseId = se.S_ExerciseId and 
			a.Sentence_SentenceId = s.SentenceId
)