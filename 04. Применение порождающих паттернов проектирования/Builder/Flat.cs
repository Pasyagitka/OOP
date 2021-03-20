using System.Text;

namespace Builder
{
    public class Flat
    {
        public Floor Floor { get; set; }
        public Walls Walls { get; set; }
        public Ceiling Ceiling { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Floor != null)  sb.Append("Пол: " + Floor.Material + "\n");
            if (Walls != null)  sb.Append("Стены: " + Walls.Color + "\n");
            if (Ceiling != null) sb.Append("Потолок: " + Ceiling.Material + " \n");
            return sb.ToString();
        }
    }
    public class Floor
    {
        public string Material { get; set; }
    }
    
    public class Walls
    {
        public string Color { get; set; }   
    }
    public class Ceiling
    {
        public string Material { get; set; }
    }
}