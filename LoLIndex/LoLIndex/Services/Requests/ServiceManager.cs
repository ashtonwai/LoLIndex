using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace LoLIndex.Services.Requests
{
    class ServiceManager
    {
        public Uri RestURI { get; set; }

        public ServiceManager(Uri serviceURI)
        {
            RestURI = serviceURI;
        }

        public T CallService<T>()
        {
            try
            {
                WebRequest request = WebRequest.Create(RestURI);
                request.ContentType = "application/json; charset=utf-8";
                var response = request.GetResponse();

                string responseFromServer = string.Empty;
                using (Stream dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    responseFromServer = reader.ReadToEnd();
                }

                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(responseFromServer));

                T dataObject = (T)serializer.ReadObject(ms);

                return dataObject;
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }
    }
}
