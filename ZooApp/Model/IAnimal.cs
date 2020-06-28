using ZooApp.Enums;


namespace ZooApp
{
    interface IAnimal
    {
        public string Name { get; set; }
        public KindType Kind { get; set; }
        public void Rename(string name);
        public void GetInfo();
    }

}
