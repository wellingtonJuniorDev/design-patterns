namespace GOF.Strutcturals._Adapter.RealWorld
{
    public class RichCompound : Compound
    {
        private readonly ChemicalDatabank bank = new();

        public RichCompound(Chemical chemical)
        {
            Chemical = chemical;
        }

        public override void Display()
        {
            BoilingPoint = bank.GetCriticalPoint(Chemical, State.Boiling);
            MeltingPoint = bank.GetCriticalPoint(Chemical, State.Melting);
            MolecularWeight = bank.GetMolecularWeight(Chemical);
            MolecularFormula = bank.GetMolecularStructure(Chemical);

            Console.WriteLine($"\nCompound: {Chemical} ----- ");
            Console.WriteLine($"\nFormula: {MolecularFormula} ----- ");
            Console.WriteLine($"\nMelting Pt: {MeltingPoint} ----- ");
            Console.WriteLine($"\nBoiling Pt: {BoilingPoint} ----- ");
        }
    }
}
