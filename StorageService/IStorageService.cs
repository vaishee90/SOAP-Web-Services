using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StorageService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStorageService" in both code and config file together.
    [ServiceContract]
    public interface IStorageService
    {
        [OperationContract]
        string storeFile(string fileName);
    }
}
