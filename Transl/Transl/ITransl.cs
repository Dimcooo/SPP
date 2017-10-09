using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Transl
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "ITransl" в коде и файле конфигурации.
    [ServiceContract]
    public interface ITransl
    {
        [OperationContract]
        string ReadJson(string city);
    }
}
