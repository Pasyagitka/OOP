namespace Builder
{
    class Master
    {
        public Flat Build(FlatBuilder flatBuilder)
        {
            flatBuilder.CreateFlat();
            flatBuilder.SetFloor();
            flatBuilder.SetWalls();
            flatBuilder.SetCeiling();
            return flatBuilder.Flat;
        }
    }

    public abstract class FlatBuilder
    {
        public Flat Flat { get; private set; }
        public void CreateFlat()
        {
            Flat = new Flat();
        }
        public abstract void SetFloor();
        public abstract void SetWalls();
        public abstract void SetCeiling();
    }

    class CheapFLatBuilder : FlatBuilder
    {
        public override void SetFloor()
        {
            this.Flat.Floor = new Floor { Material = "Линолеум" };
        }
 
        public override void SetWalls()
        {
            this.Flat.Walls = new Walls { Color = "Белый" };
        }
 
        public override void SetCeiling()
        {
            // не используется
        }
    }
    
    class MediumFlatBuilder : FlatBuilder
    {
        public override void SetFloor()
        {
            this.Flat.Floor = new Floor { Material = "Плитка" };
        }
 
        public override void SetWalls()
        {
            this.Flat.Walls = new Walls { Color = "Красный" };
        }
 
        public override void SetCeiling()
        {
            this.Flat.Ceiling = new Ceiling() { Material = "Краска" };
        }
    }
    
    class ExpensiveFlatBuilder : FlatBuilder
    {
        public override void SetFloor()
        {
            this.Flat.Floor = new Floor { Material = "Паркет" };
        }
 
        public override void SetWalls()
        {
            this.Flat.Walls = new Walls { Color = "Зеленый" };
        }
 
        public override void SetCeiling()
        {
            this.Flat.Ceiling = new Ceiling() { Material = "Натяжной потолок" };
        }
    }
}