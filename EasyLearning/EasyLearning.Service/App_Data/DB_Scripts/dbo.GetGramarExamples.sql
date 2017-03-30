CREATE FUNCTION [dbo].GetGramarExamples
(
	@GramarTipId int,
	@UserId nvarchar(255)
)
RETURNS TABLE AS RETURN
(
	SELECT dbo.GetSentenceTranslated(ts.TranslationSetId, @UserId) as Example,
	 dbo.GetSentenceInNative(ts.TranslationSetId, @UserId) as Significate
	from GrammarTips gt, GrammarTipTranslationSets gts, TranslationSets ts
	where gt.GrammarTipId = @GramarTipId and
			gts.GrammarTip_GrammarTipId = gt.GrammarTipId and
			gts.TranslationSet_TranslationSetId = ts.TranslationSetId 
)