using System.Text.Json;

namespace GOF.Creationals._Prototype.RealWorld
{
    public interface ICloneableObject
    {
        object Clone();
    }

    public class Color : ICloneableObject
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        
        public object Clone(bool shallow)
        {
            return shallow ? Clone() : DeepCopy();
        }

        public object Clone()
        {
            Console.WriteLine("Shallow copy of color RGB: {0,3}, {1,3}, {2,3}", Red, Green, Blue);
            return MemberwiseClone();
        }

        public object DeepCopy()
        {
            var serialized = JsonSerializer.Serialize(this);
            var copy = JsonSerializer.Deserialize<Color>(serialized);
            Console.WriteLine("*Deep* copy of color RGB: {0,3}, {1,3}, {2,3}", copy?.Red, copy?.Green, copy?.Blue);

            return copy;
        }
    }

    public record ColorManager
    {
        private readonly Dictionary<ColorType, Color> colors = [];

        public Color this[ColorType colorType]
        {
            get => colors[colorType];
            set => colors.Add(colorType, value);
        }
    }

    public enum ColorType
    {
        Red,
        Green,
        Blue,

        Angry,
        Peace,
        Flame
    }
}
