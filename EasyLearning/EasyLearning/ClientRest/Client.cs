using System.Collections.Generic;
using RestSharp;
using EasyLearning.Models.ViewModel;
using EasyLearning.Models;
using RestSharp.Authenticators;
using System.Web.Mvc;

namespace EasyLearning.ClientRest
{
    /// <summary>
    /// Rest client for account controller to make login and register.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// The rest client
        /// </summary>
        private RestClient client;

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        public Client()
        {
            client = new RestClient("http://localhost:1893");
        }

        public bool IsAutentification()
        {
            var request = new RestRequest("api/Account/IsAuthenticated", Method.GET);
            var response = client.Execute(request);
            if (response.Content == "true")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Registers the specified new user.
        /// </summary>
        /// <param name="newUser">The new user.</param>
        public void Register(RegisterViewModel newUser)
        {
            var request = new RestRequest("api/Account/Register", Method.POST);
            var userObject = new RegisterViewModel

            {
                Name = newUser.Name,
                Nativelanguage = newUser.Nativelanguage,
                Learnlanguage = newUser.Learnlanguage,
                Email = newUser.Email,
                Password = newUser.Password,
                ConfirmPassword = newUser.ConfirmPassword
            };
            var json = request.JsonSerializer.Serialize(userObject);
            request.Parameters.Clear();
            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);

            client.Execute(request);

        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        public List<SelectListItem> GetListLanguages()
        {
            List<SelectListItem> ListLanguages = new List<SelectListItem>();
            RestRequest request = new RestRequest("api/Languages", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.Parameters.Clear();
            IRestResponse<List<LanguageViewModel>> response = client.Execute<List<LanguageViewModel>>(request);
            foreach (var language in response.Data)
            {
                ListLanguages.Add(new SelectListItem() { Value = language.LanguageId.ToString(), Text = language.Name });
            }
            return ListLanguages;
        }

        /// <summary>
        /// Logins with a email and password
        /// </summary>
        /// <param name="login">The login.</param>
        public void LogIn(LoginViewModel login)
        {
            var client = new RestClient("http://localhost:1893");
            client.Authenticator = new SimpleAuthenticator("username", login.Email.ToString(), "password", login.Password.ToString());

            var request = new RestRequest("Token", Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");
            request.AddParameter("grant_type", "password");

            var response = client.Execute(request);

            var token = response.Content;
        }

        /// <summary>
        /// Saves the user language change.
        /// </summary>
        /// <param name="newLanguage">The user languages.</param>
        /// <returns></returns>
        public string SaveUserLanguageChange(UserLanguagesModel newLanguage)
        {
            var request = new RestRequest("api/UserLanguages/", Method.POST);
            request.AddParameter("user", newLanguage.User);
            request.AddParameter("languageToLearnId", newLanguage.LanguageTolearnId);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute<UserLanguagesModel>(request);
            return response.Content;
        }

        /// <summary>
        /// Gets the user languages.
        /// </summary>
        /// <returns></returns>
        public UserLanguagesModel GetUserLanguages(string user)
        {
            var request = new RestRequest("api/UserLanguages", Method.GET);
            request.AddParameter("userId", user);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse<UserLanguagesModel> response = client.Execute<UserLanguagesModel>(request);
            return response.Data;

        }

        /// <summary>
        /// Gets the languages.
        /// </summary>
        /// <returns></returns>
        public IList<LanguageViewModel> GetLanguagesToLearn(string user)
        {
            IList<LanguageViewModel> languages = new List<LanguageViewModel>();
            var request = new RestRequest("api/Languages", Method.GET);
            request.AddParameter("user", user);
            IRestResponse<List<LanguageViewModel>> response = client.Execute<List<LanguageViewModel>>(request);
            return response.Data;
        }
    }
}