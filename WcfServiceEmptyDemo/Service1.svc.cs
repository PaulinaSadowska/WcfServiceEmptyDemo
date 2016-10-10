namespace WcfServiceEmptyDemo
{
    public class Service : IService
    {
        public string PrintUserData(string firstName, string surname, int age)
        {
            return $"{firstName} {surname} is {age} old";
        }
    }
}