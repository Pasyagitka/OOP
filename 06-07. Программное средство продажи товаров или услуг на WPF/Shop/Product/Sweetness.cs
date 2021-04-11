using System.Runtime.Serialization;
namespace Shop.Product
{
    //[DataContract]
    public abstract class Sweetness
    {
        protected string name;
        protected double weight;
        protected int calories;
        protected string description;
        protected string trademark;
    }
}
