using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ARZwebAppScores.Models;
using RestSharp;
using System.Security.Cryptography;
using RestSharp.Authenticators;
using System.Configuration;

namespace ARZwebAppScores.Helper
{
    public class ServerDataRestClient : IServerDataRestClient
    {
        private readonly RestClient _client;
      //  private readonly string _url = ConfigurationManager.AppSettings["webapibaseurl"];

        public ServerDataRestClient()
        {
            _client = new RestClient("http://172.16.0.6/")
            {
                Authenticator = new HttpBasicAuthenticator("HL13", "ARZDevs")
            };
        }







        static void TryGetHLApi()
        {

            var restClient = new RestClient("http://172.16.0.6/")
            {
                Authenticator = new HttpBasicAuthenticator("HL13", "ARZDevs")
            };


            ///api/filesystem/apps/file?knownfolderid=LocalAppData&filename=ARZAllSessions.txt&packagefullname=ARZpak_0.5.0.0_x86__pzq3xp76mxafg&path=%5C%5CRoamingState
            // var request = new RestRequest("/api/holographic/os/settings/ipd", Method.GET);
            var request = new RestRequest("/api/filesystem/apps/file?knownfolderid=LocalAppData&filename=ARZAllSessions.txt&packagefullname=ARZpak_0.5.0.0_x86__pzq3xp76mxafg&path=%5C%5CRoamingState", Method.GET);

            var response = restClient.Execute(request);
            string AllSessionsStr = response.Content;
            Console.WriteLine(AllSessionsStr);

            AllSessionsRoot asr = AllSessionsRoot.FromJson(AllSessionsStr);

            Console.WriteLine(asr.ListAllSessions.FirstOrDefault().PInfo.PlayerLastName);
        }






        public AllSessionsRoot GetSessionRoot()
        {
            var request = new RestRequest("/api/filesystem/apps/file?knownfolderid=LocalAppData&filename=ARZAllSessions.txt&packagefullname=ARZpak_0.5.0.0_x86__pzq3xp76mxafg&path=%5C%5CRoamingState", Method.GET);

            var response = _client.Execute(request);
            string AllSessionsStr = response.Content;
            Console.WriteLine(AllSessionsStr);

            AllSessionsRoot asr = AllSessionsRoot.FromJson(AllSessionsStr);

            
            if (response.Content == null)
                throw new Exception(response.ErrorMessage);

            return asr;
        }

        public AllSessionsRoot GetSessionRootByIP(int ip)
        {
            throw new NotImplementedException();
        }

        public void Update(AllSessionsRoot argSessionsRoot)
        {
            throw new NotImplementedException();
        }
    }
}