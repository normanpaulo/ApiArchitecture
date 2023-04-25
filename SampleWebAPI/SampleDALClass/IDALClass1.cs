using SampleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDALClass
{
    public interface IDALClass1
    {
        Class1Model? GetSingleData(int id);
        List<Class1Model>? GetAllData();
    }
}
