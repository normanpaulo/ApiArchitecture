using SampleDALClass;
using SampleModel;

namespace SampleBLClass
{
    public class Class1: IClass1
    {
        private readonly IDALClass1 _dal;
        public Class1()
        {
            _dal = new DALClass1();
        }

        public Class1Model Return1(string name)
        {
            return new Class1Model()
            {
                Id = 1,
                Name = name
            };
            
        }

        public Class1Model ReturnClassModel (Class1Model request)
        {
            return new Class1Model()
            {
                Id = request.Id + 1,
                Name = $"Hello {request.Name}"
            };

        }

        public Class1Model? GetSingleData(int id)
        {
            var item = _dal.GetSingleData(id);

            return item;

        }

        public List<Class1Model>? GetAllData()
        {
            var list = _dal.GetAllData();

            return list;

        }
    }
}