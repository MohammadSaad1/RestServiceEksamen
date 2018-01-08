using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestServiceEksamen
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRestServiceImpl" in both code and config file together.
    [ServiceContract]
    public interface IRestServiceImpl
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "catch")]
        IList<Catch> GetCatches();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "catch/{id}")]
        Catch GetCatch(string id);

        [OperationContract]
        [WebInvoke(Method = "POST",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "catch")]
        Catch AddCatch(Catch catchs);

        [OperationContract]
        [WebInvoke(Method = "PUT",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "catch/{id}")]
        Catch UpdateCatch(string id, Catch catchs);
        [OperationContract]
        [WebInvoke(Method = "DELETE",
       //RequestFormat = WebMessageFormat.Json,
       ResponseFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "catch/{id}")]
        Catch DeleteCatch(string id);
    
}
}
