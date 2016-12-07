using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using B3MLib;
using Extensions;

namespace B3MControlLib
{
    public class B3MControl
    {
        SerialPort _serialPort = null;

        public B3MControl()
        {
        }

        public void setSerialPort(SerialPort serialPort)
        {
            _serialPort = serialPort;
        }

        private bool setValue(byte id, byte address, byte[] value)
        {
            byte[] cmd = B3MLib.B3MLib.WriteSingle(0, address, id, value);
            return B3MLib.B3MLib.Synchronize(_serialPort, cmd);
        }

        private bool setValue(byte id, byte address, byte value)
        {
            byte[] data = new byte[] { value };
            byte[] cmd = B3MLib.B3MLib.WriteSingle(0, address, id, new byte[1] );
            return B3MLib.B3MLib.Synchronize(_serialPort, cmd);
        }

        private bool setCharValues(byte[] id, byte address, byte[] values)
        {
            byte count = (byte)id.Count();
            byte[] data = new byte[count * 2];
            for (int i = 0; i < count; i++)
            {
                data[i * 2 + 0] = id[i];
                data[i * 2 + 1] = values[i];
            }
            byte[] cmd = B3MLib.B3MLib.Write(0, address, (byte)id.Count(), data);
            return B3MLib.B3MLib.Synchronize(_serialPort, cmd);
        }

        private bool setShortValues(byte[] id, byte address, short[] values)
        {
            byte count = (byte)id.Count();
            byte[] data = new byte[count * 3];
            for (int i = 0; i < count; i++)
            {
                data[i * 3 + 0] = id[i];
                data[i * 3 + 1] = (byte)(values[i] & 0xff);
                data[i * 3 + 2] = (byte)((values[i] >> 8) & 0xff);
            }
            byte[] cmd = B3MLib.B3MLib.Write(0, address, (byte)id.Count(), data);
            return B3MLib.B3MLib.Synchronize(_serialPort, cmd);
        }

        private bool setIntValues(byte[] id, byte address, int[] values)
        {
            byte count = (byte)id.Count();
            byte[] data = new byte[count * 5];
            for (int i = 0; i < count; i++)
            {
                data[i * 5 + 0] = id[i];
                data[i * 5 + 1] = (byte)(values[i] & 0xff);
                data[i * 5 + 2] = (byte)((values[i] >>  8) & 0xff);
                data[i * 5 + 3] = (byte)((values[i] >> 16) & 0xff);
                data[i * 5 + 4] = (byte)((values[i] >> 24) & 0xff);
            }
            byte[] cmd = B3MLib.B3MLib.Write(0, address, (byte)id.Count(), data);
            return B3MLib.B3MLib.Synchronize(_serialPort, cmd);
        }

        private bool getValue(byte id, byte address, byte[] value)
        {
            byte[] cmd = B3MLib.B3MLib.WriteSingle(0, address, id, value);
            return B3MLib.B3MLib.Synchronize(_serialPort, cmd);
        }

        public void servoOn(int id)
        {
        }
    }
}
