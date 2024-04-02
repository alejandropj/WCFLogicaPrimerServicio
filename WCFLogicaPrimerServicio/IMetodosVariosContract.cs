using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFLogicaPrimerServicio
{
    [ServiceContract]
    public interface IMetodosVariosContract
    {
        [OperationContract]
        string GetSaludo(string nombre);
        [OperationContract]
        int GetNumeroDoble(int numero);

        string MetodoInvisible();

    }
}
