using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezProject.enums;
using XadrezProject.pecas;

namespace XadrezProject.tabuleiro
{
    public class Casa
    {
        public SolidBrush Color { get; set; }
        public Rectangle Rectangle { get; set; }
        public Point PixelLocation { get; set; }
        public Point AddressLocation { get; set; }
        public int X { get => AddressLocation.X; }
        public int Y { get => AddressLocation.Y; }
        public string Name { get => $"{AddressColumnName}{AddressLineName}"; }
        public char AddressColumnName { get => cn(); }
        public string AddressLineName { get => AddressLocation.Y.ToString(); }
        public bool IsEmpty { get => (Peca == null); }
        public Peca Peca { get; set; }

        private char cn()
        {
            char c = 'a';
            if (AddressLocation.X > 0)
                return (char)(c + AddressLocation.X);
            return c;
        }
    }
}
