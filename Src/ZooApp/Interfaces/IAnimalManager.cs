using ZooApp.Enums;


namespace ZooApp.Interfaces
{
    interface IAnimalManager
    {
        void Rename(Animal animal,string name);
        void GetInfo(Animal animal);
        void SetPassport(Animal animal,string passport);
    }

}
