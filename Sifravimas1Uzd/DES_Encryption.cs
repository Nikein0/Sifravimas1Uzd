using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sifravimas1Uzd
{
    /*internal class DES_ECBencryption
    {
        private string message;
        private string password;
        private string encryptedMessage;

        public string Message { get => message; set => message = value; }
        public string Password { get => password; set => password = value; }
        public string EncryptedMessage { get => encryptedMessage; set => encryptedMessage = value; }

        public DES_ECBencryption(string message, string password)
        {
            Message = message;
            Password = password;
            //Message = message;
            //Password = password;
        }

        public string Encrypt()
        {
            //Encode message and password
            byte[] messageBytes = ASCIIEncoding.UTF8.GetBytes(message);
            byte[] passwordBytes = ASCIIEncoding.UTF8.GetBytes(password);

            //Set encryption setting
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            ICryptoTransform transform = provider.CreateEncryptor(passwordBytes, passwordBytes);
            CryptoStreamMode mode = CryptoStreamMode.Write;

            //Set up streams and encrypt
            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memStream, transform, mode);
            cryptoStream.Write(messageBytes, 0, messageBytes.Length);
            cryptoStream.FlushFinalBlock();

            //Read the encrypted message from the memory stream
            byte[] encryptedMessageBytes = new byte[memStream.Length];
            memStream.Position = 0;
            memStream.Read(encryptedMessageBytes, 0, encryptedMessageBytes.Length);

            //Encode the encrypted message as base64 string
            string encryptedMessage = Convert.ToBase64String(encryptedMessageBytes);

            return encryptedMessage;
        }

        public string Decrypt()
        {
            //Convert encrypted message and password to bytes
            byte[] encryptedMessageBytes = Convert.FromBase64String(encryptedMessage);
            byte[] passwordBytes = ASCIIEncoding.ASCII.GetBytes(password);

            //Set encryption settings
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            ICryptoTransform transform = provider.CreateDecryptor(passwordBytes, passwordBytes);
            CryptoStreamMode mode = CryptoStreamMode.Write;

            //Set up streams and decrypt
            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memStream, transform, mode);
            cryptoStream.Write(encryptedMessageBytes, 0, encryptedMessageBytes.Length);
            cryptoStream.FlushFinalBlock();

            //Read decrypted message from memory stream
            byte[] decryptedMessageBytes = new byte[memStream.Position];
            memStream.Position = 0;
            memStream.Read(decryptedMessageBytes, 0, decryptedMessageBytes.Length);

            //Encode decrypted message data to base64 string
            string message = ASCIIEncoding.ASCII.GetString(decryptedMessageBytes);

            return message;
        }

        public int byteSize(string input, Encoding encoding)
        {
            byte[] bytes = encoding.GetBytes(input);

            return bytes.Length;
        }




    }
    */
    internal class DES_Encryption
    {
        private string message;
        private string password;
        private string encryptedMessage;

        public string Message { get => message; set => message = value; }
        public string Password { get => password; set => password = value; }
        public string EncryptedMessage { get => encryptedMessage; set => encryptedMessage = value; }

        public DES_Encryption(string message, string password)
        {
            Message = message;
            Password = password;
        }
        public DES_Encryption() { }

        public string Encrypt(int choice)
        {
            TripleDESCryptoServiceProvider desCryptoProvider = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();

            byte[] byteHash;
            byte[] byteBuff;

            byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(password));
            desCryptoProvider.Key = byteHash;
            desCryptoProvider.IV = UTF8Encoding.UTF8.GetBytes("ABCDEFGH");
            if (choice == 1)
            {
                desCryptoProvider.Mode = CipherMode.ECB;
            }
            else if (choice == 2)
            {
                desCryptoProvider.Mode = CipherMode.CBC;
            }
            else
            {
                desCryptoProvider.Mode = CipherMode.CFB;
            }
            byteBuff = Encoding.UTF8.GetBytes(message);

            string encoded =
                Convert.ToBase64String(desCryptoProvider.CreateEncryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
            return encoded;
        }

        public int byteSize(string input, Encoding encoding)
        {
            byte[] bytes = encoding.GetBytes(input);

            return bytes.Length;
        }
        public string Decrypt(string TextToDecrypt, string password, int choice)
        {
            byte[] MyDecryptArray = Convert.FromBase64String
               (TextToDecrypt);

            MD5CryptoServiceProvider MyMD5CryptoService = new
               MD5CryptoServiceProvider();

            byte[] MysecurityKeyArray = MyMD5CryptoService.ComputeHash
               (UTF8Encoding.UTF8.GetBytes(password));

            MyMD5CryptoService.Clear();

            var MyTripleDESCryptoService = new
               TripleDESCryptoServiceProvider();

            MyTripleDESCryptoService.Key = MysecurityKeyArray;
            MyTripleDESCryptoService.IV = UTF8Encoding.UTF8.GetBytes("ABCDEFGH");
            if (choice == 1)
            {
                MyTripleDESCryptoService.Mode = CipherMode.ECB;
            }
            else if (choice == 2)
            {
                MyTripleDESCryptoService.Mode = CipherMode.CBC;
            }
            else
            {
                MyTripleDESCryptoService.Mode = CipherMode.CFB;
            }

            MyTripleDESCryptoService.Padding = PaddingMode.PKCS7;

            var MyCrytpoTransform = MyTripleDESCryptoService
               .CreateDecryptor();

            byte[] MyresultArray = MyCrytpoTransform
               .TransformFinalBlock(MyDecryptArray, 0,
               MyDecryptArray.Length);

            MyTripleDESCryptoService.Clear();

            return UTF8Encoding.UTF8.GetString(MyresultArray);
        }

    }
}
