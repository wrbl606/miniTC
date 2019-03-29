using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTCApp
{
    public enum DirectoryElementType { DIRECTORY, FILE };

    public class DirectoryElement
    {
        public DirectoryElementType Type { get; set; }
        public string Name { get; set; }

        public DirectoryElement(DirectoryElementType type, string name)
        {
            Type = type;
            Name = name;
        }

        public override string ToString()
        {
            return $"{ ((Type == DirectoryElementType.DIRECTORY) ? "<DIR>" : "") } { Name }";
        }
    }
}
