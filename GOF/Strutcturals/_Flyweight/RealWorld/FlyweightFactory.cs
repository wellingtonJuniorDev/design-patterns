namespace GOF.Strutcturals._Flyweight.RealWorld
{
    public class CharacterFactory
    {
        private readonly Dictionary<char, Character> characters = [];

        public Character GetCharacter(char key)
        {
            Character character;
            if (characters.TryGetValue(key, out Character value))
            {
                character = value;
            }
            else
            {
                character = key switch
                {
                    'A' => new CharacterA(),
                    'B' => new CharacterB(),
                    'Z' => new CharacterZ(),
                    _ => null!
                };
            }

            return character;
        }
    }
}
