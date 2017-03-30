<Query Kind="Program">
  <Connection>
    <ID>a377a923-4e4f-4599-91a8-fe3e0169fb4f</ID>
    <Server>(LocalDb)\MSSQLLocalDB</Server>
    <Database>aspnet-EasyLearning-20170110052308</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>


//This script is writed with linqpath to test how get the contents of a lessonId 
//in a order to show the exercises and tips

void Main()
{
	var lessonId = 1;
	
	var lessonContents = LessonContents
							.Where(lc => lc.Lesson_LessonId == lessonId)
							.OrderBy(lc => lc.Order);
	
	Console.Write(lessonContents);
}