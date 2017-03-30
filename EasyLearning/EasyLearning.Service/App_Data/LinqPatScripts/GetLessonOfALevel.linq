<Query Kind="Program">
  <Connection>
    <ID>a377a923-4e4f-4599-91a8-fe3e0169fb4f</ID>
    <Server>(LocalDb)\MSSQLLocalDB</Server>
    <Database>aspnet-EasyLearning-20170110052308</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//this function returns the levels with a difficult order 
void Main()
{
	var levelId = 1;
	var lessonsOfLevelOne = Lessons
		.Where(ls => ls.Level_LevelId == levelId)
		.OrderBy(ls => ls.OrderByLevel);
		
	Console.Write(lessonsOfLevelOne);
	
}