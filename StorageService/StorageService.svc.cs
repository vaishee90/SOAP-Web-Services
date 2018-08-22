using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StorageService
{
    public class StorageService : IStorageService
    {
        public string storeFile(string fileName)
        {
            // get full server path for storing the file
            string fullPath = System.Web.HttpContext.Current.Server.MapPath(@"~\") + fileName;
            return fullPath;
        }
    }
}
