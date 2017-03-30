
--Get language to learn of the user whe irene892 is the User Id
Select lh.LanguageToLearn_LanguageId, l.Name
from LearningHistories lh, Languages l 
where l.LanguageId = lh.LanguageToLearn_LanguageId and lh.[dateTime] in (
							select max(lh.[dateTime])
							from LearningHistories lh
							where lh.[User_Id] = 'irene892'
						)
