using System.IO;
using System;

namespace IDisposable_Interface
{
    // The IDisposable interface in C# is used to provide a mechanism for releasing unmanaged
    // resources. Unmanaged resources are resources that the .NET runtime doesn't manage directly,
    // such as file handles, database connections, or memory allocated through the Windows API.
    // Implementing the IDisposable interface allows you to create a Dispose method, which is called
    // to free these resources when they are no longer needed.

    public class FileManager : IDisposable
    {
        private FileStream fileStream;

        public FileManager(string filePath)
        {
            fileStream = new FileStream(filePath, FileMode.OpenOrCreate);
        }

        public void WriteData(string data)
        {
            if (fileStream == null)
                throw new ObjectDisposedException("FileManager");

            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(data);
            fileStream.Write(bytes, 0, bytes.Length);
        }

        public void Dispose()
        {
            // Call Dispose(true) and suppress finalization
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Dispose managed resources
                if (fileStream != null)
                {
                    fileStream.Dispose();
                    fileStream = null;
                }
            }

            // Dispose unmanaged resources
            // (None in this example, but if there were, they'd be cleaned up here)
        }

        ~FileManager()
        {
            // Finalizer calls Dispose(false)
            Dispose(false);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            using (FileManager fileManager = new FileManager("example.txt"))
            {
                fileManager.WriteData("Hello, World!");
            } // fileManager.Dispose() is called automatically at the end of the using block
        }
    }
}
