USE [aspnet-EasyLearning.Service-20170203071243]
GO
--To execut the storage procedure that will return the attributes for a exercises or tips 
--that have the lesson, with the attributes @CUrrentCOntentLessonID (int) to get the content that follo this,
--LessonId to get the fist lesson content 
EXEC	[dbo].[GetContentLesson]
		@LessonId =NULL,
		@CurrentContentLessonId = 1

GO
