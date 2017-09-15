using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{

    [ServiceContract(Namespace = "http://www.portocred.com.br")]
    public interface IService1
    {
        [OperationContract]
        string GetData(Parametro param);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TESTANDO...
    }

    [DataContract(Namespace = "http://www.portocred.com.br")]
    public class Parametro
    {
        public int cod { get; set; }
        public string msg { get; set; }
    }

    // Use um contrato de dados como ilustrado no exemplo abaixo para adicionar tipos compostos a operações de serviço.
    [DataContract(Namespace = "http://www.portocred.com.br")]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
