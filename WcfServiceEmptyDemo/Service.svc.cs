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
                throw new FaultException("user can't be null!");
            }
            else if (user.firstName == null || user.surname == null)
            {
                throw new FaultException("user name and surname can't be null!");
            }
            return $"{user.firstName} {user.surname} is {user.age} years old";
        }
    }
}