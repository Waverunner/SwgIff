using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waverunner.Swg.IO
{
    public class SwgIff
    {
        private IffDataStream _stream { get; set; }
        private string _filePath { get; set; }

        public ISwgIffHandler Handler { get; private set; }
        public byte[] Data { get; private set; }
        public bool HasLoaded { get; private set; }
        public string Type { get; private set; }
        public string CurrentForm { get; private set; }
        public string CurrentChunk { get; private set; }

        public SwgIff(string filePath) 
        {
            _filePath = filePath;
        }

        public bool Open(byte[] data, ISwgIffHandler handler)
        {
            Data = data;
            Handler = handler;
            _stream = new IffDataStream(data, false);
            return initialize();
        }

        public bool Open(ISwgIffHandler handler)
        {
            return Open(File.ReadAllBytes(_filePath), handler);
        }

        private bool initialize()
        {
            if (Handler == null || _stream == null)
                return onLoadFail();

            if (!readTypeString(_stream).Equals("FORM"))
                return onLoadFail();

            if (_stream.ReadInteger() != (Data.Length - 8))
                return onLoadFail();

            Type = readTypeString(_stream);
            if (!Handler.CanHandleType(Type))
                return onLoadFail();

            loadBlockData(_stream, Handler);

            HasLoaded = true;
            return HasLoaded;
        }

        private void loadBlockData(IffDataStream stream, ISwgIffHandler handler)
        {
            int count = 0;
            while (stream.Position < (stream.Length - 1))
            {
                string block = readTypeString(stream);
                if (block.Equals("FORM"))
                    loadFormData(stream, handler);
                else
                    loadChunkData(block, stream, handler);
                count++;
            }
        }

        private void loadFormData(IffDataStream stream, ISwgIffHandler handler)
        {
            int size = stream.ReadInteger() - 4;
            string name = readTypeString(stream);
            string old = CurrentForm;
            CurrentForm = name;

            IffDataStream formStream = getData(stream, size);

            handler.OnEnterForm(old, name, size);

            loadBlockData(formStream, handler);
        }

        private void loadChunkData(string chunk, IffDataStream stream, ISwgIffHandler handler)
        {
            int size = stream.ReadInteger();
            IffDataStream chunkStream = getData(stream, size);

            CurrentChunk = chunk;

            if (size == 0)
                return;

            handler.OnEnterChunk(chunkStream, chunk, CurrentForm, size);
        }

        private bool onLoadFail() { HasLoaded = false; Data = null; Handler = null; _stream = null; return false; }
        private void skip(long offset) { _stream.Seek(offset, SeekOrigin.Current); }


        #region Stream Helper Methods
        public string readTypeString(IffDataStream stream)
        {
            byte[] buffer = new byte[4];
            stream.Read(buffer, 0, 4);

            return Encoding.ASCII.GetString(buffer, 0, 4);
        }

        public IffDataStream getData(IffDataStream stream, int size)
        {
            IffDataStream data = new IffDataStream(size);
            data.Write(stream.ToArray(), (int) stream.Position, size);
            stream.Seek(size, SeekOrigin.Current);

            data.Seek(0, SeekOrigin.Begin);
            return data;
        }
        #endregion
    }

    public interface ISwgIffHandler
    {
        void OnEnterForm(string oldForm, string newForm, int size);
        void OnEnterChunk(IffDataStream chunkStream, string chunk, string currentForm, int size);
        bool CanHandleType(string type);
    }

#region Data

    public class IffDataStream : MemoryStream
    {
        public IffDataStream(byte[] buffer, bool canWrite)
            : base(buffer, 0, buffer.Length, true, canWrite) {}

        public IffDataStream(int capacity) 
            : base(capacity) {}

        public IffDataStream(byte[] buffer) 
            : this(buffer, false) {}


        public short ReadShort()
        {
            byte[] buffer = ReadStream(2);
            Array.Reverse(buffer);

            return BitConverter.ToInt16(buffer, 0);
        }

        public int ReadInteger()
        {
            byte[] buffer = ReadStream(4);
            Array.Reverse(buffer);

            return BitConverter.ToInt32(buffer, 0);
        }

        public uint ReadUInteger()
        {
            byte[] buffer = ReadStream(4);
            Array.Reverse(buffer);

            return BitConverter.ToUInt32(buffer, 0);
        }

        public long ReadLong()
        {
            byte[] buffer = ReadStream(8);
            Array.Reverse(buffer);

            return BitConverter.ToInt64(buffer, 0);
        }

        public ulong ReadULong()
        {
            byte[] buffer = ReadStream(8);
            Array.Reverse(buffer);

            return BitConverter.ToUInt64(buffer, 0);
        }

        public float ReadFloat()
        {
            byte[] buffer = ReadStream(4);

            return BitConverter.ToSingle(buffer, 0);
        }

        public bool ReadBool()
        {
            byte[] buffer = ReadStream(1);

            return BitConverter.ToBoolean(buffer, 0);
        }

        public byte[] ReadAsciiAsArray()
        {
            byte[] data = base.ToArray();
            byte[] buffer = new byte[data.Length];

            int asciiCount = 0;
            for (int i = 0; i < buffer.Length; i++)
            {
                if (data[i] > 0x7F) // data[i] isn't an ascii character
                    break;

                buffer[i] = data[i];
                asciiCount++;
            }

            if (buffer.Length != asciiCount)
                Array.Resize(ref buffer, asciiCount);

            base.Seek(buffer.Length, SeekOrigin.Current);
            return buffer;
        }

        public string ReadAscii()
        {
            byte[] buffer = ReadAsciiAsArray();

            return Encoding.ASCII.GetString(buffer, 0, buffer.Length);
        }

        public Color ReadArgb()
        {
            return Color.FromArgb(ReadByte(), ReadByte(), ReadByte(), ReadByte());
        }

        public Color ReadRgba()
        {
            int r = ReadByte();
            int g = ReadByte();
            int b = ReadByte();
            int a = ReadByte();

            return Color.FromArgb(a, r, g, b);
        }

        public byte[] ReadStream(int length)
        {
            byte[] buffer = new byte[length];
            base.Read(buffer, 0, length);
            return buffer;
        }
    }
#endregion
}
