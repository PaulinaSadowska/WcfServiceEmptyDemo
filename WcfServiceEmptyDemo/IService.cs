using System.ServiceModel;

namespace WcfServiceEmptyDemo
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string PrintUserData(string firstName, string surname, int age);

        [OperationContract]
        string PrintUserDataObject(UserData user);
    }
}