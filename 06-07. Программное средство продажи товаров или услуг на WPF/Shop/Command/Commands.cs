using System;
using System.Windows.Input;
using Shop.Product;

namespace Shop.Command
{
    public abstract class Command
    {
        public abstract void Execute();
    }
    public class Invoker
    {
        private Command command;
        public void SetCommand(Command c)
        {
            command = c;
        }
        public void Run()
        {
            command.Execute();
        }
    }
    
    public class AddCommand : Command
    {
        private readonly Products receiver;
        private readonly Sweetness product;
        
        public AddCommand(Sweetness product)
        {
            receiver = Products.GetInstance();
            this.product = product;
        }
        public override void Execute()
        {
            receiver.Add(product);
        }
    }

    public class DeleteCommand : Command
    {
        private readonly Products receiver;
        private readonly string product;

        public DeleteCommand(string productname)
        {
            receiver = Products.GetInstance();
            this.product = productname;
        }
        public override void Execute()
        {
            receiver.Remove(product);
        }
    }
}