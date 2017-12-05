using ARZwebAppScores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARZwebAppScores.Helper
{
    public interface IServerDataRestClient
    {
        AllSessionsRoot GetSessionRoot();
        AllSessionsRoot GetSessionRootByIP(int ip);
        void Update(AllSessionsRoot argSessionsRoot);
    }
}