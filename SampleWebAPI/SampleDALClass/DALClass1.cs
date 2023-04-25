using SampleModel;

namespace SampleDALClass
{
    //NOTE: THIS SHOULD ONLY GET ITEMS FROM DB, NO LOGIC SHOULD BE ADDED HERE ASIDE FROM FETCH AND PULL FROM DB.
    public class DALClass1: IDALClass1
    {
        public DALClass1(){

        }

        public Class1Model? GetSingleData(int id)
        {
            var list = Class1ModelList();

            return list.Where(x => x.Id == id).FirstOrDefault();
            
        }

        public List<Class1Model>? GetAllData()
        {
            var list = Class1ModelList();

            return list;

        }

        private List<Class1Model> Class1ModelList()
        {
            var list = new List<Class1Model>();
            list.Add(new Class1Model() { Id = 1, Name = "Knives" });
            list.Add(new Class1Model() { Id = 2, Name = "Ed" });
            list.Add(new Class1Model() { Id = 3, Name = "Bal" });
            list.Add(new Class1Model() { Id = 4, Name = "Norman" });
            list.Add(new Class1Model() { Id = 5, Name = "Gerry" });
            list.Add(new Class1Model() { Id = 1, Name = "Zaf" });

            return list;
        }
    }
}