namespace Test.Classes
{
    internal class Redonly : IRedonly
    {
        public readonly string Name;
        public int TugilganYil {  get; set; }

        public Redonly(string name,int tugilganYil)
        {
            Name = name;
            TugilganYil = tugilganYil;
        }

        public void OutName()=>
            Console.WriteLine($"Sizning ismingiz: {Name}");
        
        public int CalculateAge(int tugilganYil)
        {
            int age;
            return age=2024-tugilganYil;
        }

        public void OutAge()=>
            Console.WriteLine($"Sizning yoshingiz: {CalculateAge(TugilganYil)}");
    }
}
