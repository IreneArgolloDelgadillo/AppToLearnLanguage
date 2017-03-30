CREATE FUNCTION [dbo].[GetWordsOfLT]
(
	@TranslationSetId int,
	@UserId nvarchar(255)
)
RETURNS TABLE AS RETURN
(
	 select dbo.GetSentenceInNative(@TranslationSetId, @UserId) as SentenceInNative, 
			dbo.GetSentenceTranslated(@TranslationSetId, @UserId) as SentenceTranslated
)