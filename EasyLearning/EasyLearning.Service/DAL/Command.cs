using EasyLearning.Service.Factory;
using EasyLearning.Service.Models.ServiceModels;
using EasyLearning.Service.Models.ServiceModels.ExerciseModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Http;

namespace EasyLearning.Service.DAL
{
    public class Command : ApiController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAL.Command"/> class.
        /// </summary>
        /// <param name="valueParamer">The value paramer.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="storedProcedureName">Name of the stored procedure.</param>
        public Command(int valueParamer, string parameterName, string storedProcedureName)
        {
            ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            Connection = new SqlConnection(ConnectionString);
            SqlCommand = new SqlCommand(storedProcedureName, Connection);
            SqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlCommand.Parameters.Add(parameterName, SqlDbType.Int).Value = valueParamer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Command"/> class.
        /// </summary>
        /// <param name="firstValueParamer">The first value paramer.</param>
        /// <param name="secondValueParameter">The second value parameter.</param>
        /// <param name="firstParameterName">First name of the parameter.</param>
        /// <param name="secondParameterName">Name of the second parameter.</param>
        /// <param name="storedProcedureName">Name of the stored procedure.</param>
        public Command(int firstValueParamer, string secondValueParameter, string firstParameterName, string secondParameterName, string storedProcedureName)
        {
            ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            Connection = new SqlConnection(ConnectionString);
            SqlCommand = new SqlCommand(storedProcedureName, Connection);
            SqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlCommand.Parameters.Add(firstParameterName, SqlDbType.Int).Value = firstValueParamer;
            SqlCommand.Parameters.Add(secondParameterName, SqlDbType.VarChar).Value = secondValueParameter;
        }

        /// <summary>
        /// Executes the stored procedure exercise.
        /// </summary>
        /// <returns></returns>
        public IExercise ExecuteStoredProcedureExercise()
        {
            IExercise exercise;
            Connection.Open();
            Reader = SqlCommand.ExecuteReader();
            Reader.Read();
            try
            {
                if (Reader.FieldCount == Exercise)
                {
                    exercise = Factory.CreateExercise(Reader.GetInt32(0), Reader.GetString(1), Reader.GetString(2), Reader.GetInt32(3), Reader.GetInt32(4));
                }
                else if (Reader.FieldCount == ListeningTip)
                {
                    exercise = Factory.CreateExercise(Reader.GetInt32(1), null, Reader.GetString(2), Reader.GetInt32(3), Reader.GetInt32(4));
                }
                else
                {
                    exercise = Factory.CreateExercise(Reader.GetInt32(0), Reader.GetString(1), null, Reader.GetInt32(2), Reader.GetInt32(3));
                }
            }
            catch( SystemException e)
            {
                exercise = null;
            }
            Connection.Close();
            return exercise;
        }

        /// <summary>
        /// Executes the stored procedure answers.
        /// </summary>
        /// <returns></returns>
        public IList<Answer> ExecuteStoredProcedureAnswers()
        {
            Connection.Open();
            Reader = SqlCommand.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Factory.AddToAnswersList(Reader.GetInt32(0), Reader.GetString(1));
                }
                return Factory.Answers;
            }
            Connection.Close();
            return null;
        }

        /// <summary>
        /// Executes the stored procedure answer.
        /// </summary>
        /// <returns></returns>
        public Answer ExecuteStoredProcedureAnswer()
        {
            Connection.Open();
            Reader = SqlCommand.ExecuteReader();
            Reader.Read();
            Answer answer = Factory.CreateAnswer(Reader.GetString(0));
            Connection.Close();
            return answer;

        }

        /// <summary>
        /// Executes the stored procedure example tip.
        /// </summary>
        /// <returns></returns>
        public IList<ExampleModel> ExecuteStoredProcedureExampleTip()
        {
            Connection.Open();
            Reader = SqlCommand.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    TipFactory.CreateExampleModel(Reader.GetString(0), Reader.GetString(1));
                }
                return TipFactory.Examples;
            }
            Connection.Close();
            return null;
        }

        private string ConnectionString;
        private SqlConnection Connection;
        private SqlCommand SqlCommand;
        private SqlDataReader Reader;
        private ExerciseFactory Factory = new ExerciseFactory();
        private TipFactory TipFactory = new TipFactory();
        private const int Exercise = 6;
        private const int ListeningTip = 5;
        private const int GrammarTip = 4;
    }
}