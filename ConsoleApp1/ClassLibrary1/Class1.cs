namespace ClassLibrary1
{
    public class Class1
    {
        public int id { get; set; }
        public string name { get; set; }
       public Class1(int _id,string _name)
        {
            id = _id;
            name = _name;
           
        }

        public override string ToString()
        {
            return $"{id} and {name}";
        }
    }
}