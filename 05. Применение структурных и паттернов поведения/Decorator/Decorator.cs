namespace Lab05.Decorator
{
    abstract class Flat
    {
        public string Name { get; protected set; }
        public Flat(string n)
        {
            this.Name = n;
        }
        public abstract int GetCost();
    }
      
    class EmptyFlat : Flat
    {
        public EmptyFlat()
            : base("Empty flat")
        { }
        public override int GetCost()
        {
            return 200000;
        }
    }
 
    abstract class FlatDecorator : Flat
    {
        protected Flat flat;
        public FlatDecorator(string n, Flat flat) : base(n)
        {
            this.flat = flat;
        }
    }
    
    class DecoratedFlat : FlatDecorator //с отделкой
    {
        public DecoratedFlat(Flat flat) 
            : base(flat.Name + " with decoration", flat)
        { }
 
        public override int GetCost()
        {
            return flat.GetCost() + 50000;
        } 
    }
    class FurnitureFillFlat : FlatDecorator //с мебелью
    {
        public FurnitureFillFlat(Flat flat) 
            : base(flat.Name + " with furniture", flat)
        { }
 
        public override int GetCost()
        {
            return flat.GetCost() + 100000;
        } 
    }
}