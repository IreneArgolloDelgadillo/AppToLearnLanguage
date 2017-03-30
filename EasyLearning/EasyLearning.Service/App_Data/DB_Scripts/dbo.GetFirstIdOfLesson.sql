CREATE FUNCTION [dbo].GetFirstIdOfLesson
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