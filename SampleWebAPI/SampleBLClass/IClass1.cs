using SampleModel;

namespace SampleBLClass
{
    public interface IClass1
    {
        Class1Model Return1(string name);
        Class1Model ReturnClassModel(Class1Model request);
        Class1Model? GetSingleData(int id);
        List<Class1Model>? GetAllData();

    }
}
