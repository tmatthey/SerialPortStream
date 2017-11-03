namespace RJCP.IO.Ports
{
    using System;
    using System.Diagnostics;
    using System.Text;
    using System.IO;
    using Native;

#if !NETSTANDARD15
    using System.Management;
    using System.Runtime.Remoting.Messaging;
#else
    using System.Reflection;
#endif

#pragma warning disable 1591
    public class SerialPortStreamFakeBase : ISerialPortStream
    {
        private string m_Version;

        public string Version
        {
            get
            {
                if (m_Version != null) return m_Version;

#if NETSTANDARD15
                var assembly = typeof(WinNativeSerial).GetTypeInfo().Assembly;
#else
                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
#endif
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                m_Version = fvi.FileVersion;
                return m_Version;
            }
        }
        public string PortName { get; set; }
        public bool IsOpen { get; }
        public Encoding Encoding { get; set; }
        public string NewLine { get; set; }
        public int DriverInQueue { get; set; }
        public int DriverOutQueue { get; set; }
        public bool CanTimeout { get; }
        public bool CanRead { get; }
        public int ReadTimeout { get; set; }
        public int ReadBufferSize { get; set; }
        public int ReceivedBytesThreshold { get; set; }
        public int BytesToRead { get; }
        public bool CanWrite { get; }
        public int WriteTimeout { get; set; }
        public int WriteBufferSize { get; set; }
        public int BytesToWrite { get; }
        public bool CDHolding { get; }
        public bool CtsHolding { get; }
        public bool DsrHolding { get; }
        public bool RingHolding { get; }
        public int BaudRate { get; set; }
        public int DataBits { get; set; }
        public StopBits StopBits { get; set; }
        public Parity Parity { get; set; }
        public byte ParityReplace { get; set; }
        public bool DiscardNull { get; set; }
        public bool DtrEnable { get; set; }
        public bool RtsEnable { get; set; }
        public Handshake Handshake { get; set; }
        public int XOnLimit { get; set; }
        public int XOffLimit { get; set; }
        public bool TxContinueOnXOff { get; set; }
        public bool BreakState { get; set; }
        public bool CanSeek { get; }
        public long Length { get; }
        public long Position { get; set; }
        public bool IsDisposed { get; set; }
        public void GetPortSettings()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }

        public void OpenDirect()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public int Read(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

#if !NETSTANDARD15
        public IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public int EndRead(IAsyncResult asyncResult)
        {
            throw new NotImplementedException();
        }
#endif
        public int ReadByte()
        {
            throw new NotImplementedException();
        }

        public int Read(char[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public int ReadChar()
        {
            throw new NotImplementedException();
        }

        public string ReadLine()
        {
            throw new NotImplementedException();
        }

        public string ReadTo(string text)
        {
            throw new NotImplementedException();
        }

        public string ReadExisting()
        {
            throw new NotImplementedException();
        }

        public void DiscardInBuffer()
        {
            throw new NotImplementedException();
        }

        public void Flush()
        {
            throw new NotImplementedException();
        }

        public void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

#if !NETSTANDARD15
        public IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public void EndWrite(IAsyncResult asyncResult)
        {
            throw new NotImplementedException();
        }
#endif
        public void Write(char[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public void Write(string text)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(string text)
        {
            throw new NotImplementedException();
        }

        public void DiscardOutBuffer()
        {
            throw new NotImplementedException();
        }

        public long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

        public void SetLength(long value)
        {
            throw new NotImplementedException();
        }

        public event EventHandler<SerialDataReceivedEventArgs> DataReceived;
        public event EventHandler<SerialErrorReceivedEventArgs> ErrorReceived;
        public event EventHandler<SerialPinChangedEventArgs> PinChanged;
    }
#pragma warning restore 1591
}
