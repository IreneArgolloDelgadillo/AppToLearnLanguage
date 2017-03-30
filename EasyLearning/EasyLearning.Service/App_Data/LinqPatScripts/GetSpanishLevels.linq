<Query Kind="Program">
  <Connection>
    <ID>a377a923-4e4f-4599-91a8-fe3e0169fb4f</ID>
    <Persist>true</Persist>
    <Server>(LocalDb)\MSSQLLocalDB</Server>
    <Database>aspnet-EasyLearning.Service-20170203071243</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//this function returns the levels name with a parametr that represent the languageId to see
void Main()
{
	var belongLanguageSpanish = 2;
	var levelsInSpanish = Levels.Where( l => (l.NativeLanguage_LanguageId == 2) && (l.LanguageToLearn_LanguageId == 3) );
			
	Console.Write(levelsInSpanish);
}