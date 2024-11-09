namespace GOF.Behaviorals._ChainOfResponsability.RealWorld
{
    public abstract class Approver
    {
        public EventHandler<PurchaseEventArgs> Purchase;

        public abstract void PurchaseHandler(object sender, PurchaseEventArgs e);

        protected Approver()
        {
            Purchase += PurchaseHandler!;
        }


        public void ProcessRequest(Purchase purchase)
        {
            OnPurchase(new PurchaseEventArgs { Purchase = purchase });
        }

        public virtual void OnPurchase(PurchaseEventArgs e)
        {
            Purchase?.Invoke(this, e);
        }

        public Approver Successor { get; set; } = null;
    }

    public record Purchase
    {
        public required double Amount { get; init; }
        public required string Purpose { get; init; }
        public required int Number { get; init; }
    }

    public class PurchaseEventArgs : EventArgs
    {
        internal Purchase Purchase { get; init; } = null!;
    }    
}
