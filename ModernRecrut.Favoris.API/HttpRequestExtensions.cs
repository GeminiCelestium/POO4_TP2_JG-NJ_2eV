using Microsoft.Owin;
using NWebsec.AspNetCore.Core.Web;

namespace ModernRecrut.Favoris.API
{
    public static class HttpRequestExtensions
    {
        public static string GetClientIpAddress(this HttpRequestMessage request)
        {
            //if (request.Properties.ContainsKey("MS_HttpContext"))
            //{
            //    return ((HttpContextWrapper)request.Properties["MS_HttpContext"]).Request.UserHostAddress;
            //}
            //else if (request.Properties.ContainsKey("MS_OwinContext"))
            //{
            //    return ((OwinContext)request.Properties["MS_OwinContext"]).Request.RemoteIpAddress;
            //}
            //else
            //{
            //    return null;
            //}

            return null;
        }
    }
}
