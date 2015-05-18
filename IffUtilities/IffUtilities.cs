using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waverunner.SIE.IFF
{
    public class IffUtilities
    {
    }

    public class Chunk
    {
        public Chunk(byte[] data) { this.Data = data; }
        public byte[] Data { get; set; }
    }

    public class Node
    {
        public Node(byte[] data) { this.Data = data; }
        public byte[] Data { get; set; }
    }
}
