namespace GOF.Strutcturals._Adapter.RealWorld
{
    public class ChemicalDatabank
    {
        public float GetCriticalPoint(Chemical compound, State point)
        {
            if (point == State.Melting)
            {
                return compound switch
                {
                    Chemical.Water => 0.0f,
                    Chemical.Benzene => 5.5f,
                    Chemical.Ethanol => -114.1f,
                };
            }

            return compound switch
            {
                Chemical.Water => 100.0f,
                Chemical.Benzene => 80.1f,
                Chemical.Ethanol => 78.3f,
            };
        }

        public string GetMolecularStructure(Chemical compound)
        {
            return compound switch
            {
                Chemical.Water => "H2O",
                Chemical.Benzene => "C6H6",
                Chemical.Ethanol => "C2H5OH",
            };
        }

        public double GetMolecularWeight(Chemical compound)
        {
            return compound switch
            {
                Chemical.Water => 18.015d,
                Chemical.Benzene => 78.1134d,
                Chemical.Ethanol => 46.0688d,
                _ => 0d
            };
        }
    }
}
