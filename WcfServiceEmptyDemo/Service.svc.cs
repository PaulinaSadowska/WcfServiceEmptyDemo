using System.ServiceModel;

namespace WcfServiceEmptyDemo
{
    public class Service : IService
    {
        public string PrintUserData(string firstName, string surname, int age)
        {
            return $"{firstName} {surname} is {age} years old";
        }

        public string PrintUserDataObject(UserData user)
        {
            if (user == null)
            {
                throw new FaultException("user can't be null!", new FaultCode("user null"));
            }
            else if (user.firstName == null || user.surname == null)
            {
                throw new FaultException("user name and surname can't be null!", new FaultCode("name null"));
            }
            return $"{user.firstName} {user.surname} is {user.age} years old";
        }
    }
}