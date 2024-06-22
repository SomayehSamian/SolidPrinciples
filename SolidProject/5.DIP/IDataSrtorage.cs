using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidProject
{
    public interface IDataSrtorage
    {
        void SaveData(string data);
        void RetierData(string data);
    }
}
