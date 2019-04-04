using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FTPClient
{
    class Client
    {
        private string _Host = "10.7.180.101:21";
        private string _UserName = "test_user";
        private string _Password = "1234567890";

        //объект для запроса данных
        FtpWebRequest ftpRequest;

        //объект для получения данных
        FtpWebResponse ftpResponse;

        //флаг использования SSL
        private bool _UseSSL = false;
        public FileStruct[] ListDirectory(string path)
        {
            if (path == null || path == "")
            {
                path = "/";
            }
            //Создаем объект запроса
            ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + _Host + path);
            //логин и пароль
            ftpRequest.Credentials = new NetworkCredential(_UserName, _Password);
            //команда фтп LIST
            ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            ftpRequest.EnableSsl = _UseSSL;
            //Получаем входящий поток
            ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();

            //переменная для хранения всей полученной информации
            string content = "";

            StreamReader sr = new StreamReader(ftpResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            content = sr.ReadToEnd();
            sr.Close();
            ftpResponse.Close();

            DirectoryListParser parser = new DirectoryListParser(content);
            return parser.FullListing;
        }

        //метод протокола FTP RETR для загрузки файла с FTP-сервера
        public void DownloadFile(string path, string fileName)
        {

            ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + _Host + path + "/" + fileName);

            ftpRequest.Credentials = new NetworkCredential(_UserName, _Password);
            //команда фтп RETR
            ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;

            ftpRequest.EnableSsl = _UseSSL;
            //Файлы будут копироваться в кталог программы
            FileStream downloadedFile = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);

            ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
            //Получаем входящий поток
            Stream responseStream = ftpResponse.GetResponseStream();

            //Буфер для считываемых данных
            byte[] buffer = new byte[1024];
            int size = 0;

            while ((size = responseStream.Read(buffer, 0, 1024)) > 0)
            {
                downloadedFile.Write(buffer, 0, size);

            }
            ftpResponse.Close();
            downloadedFile.Close();
            responseStream.Close();
        }
        
    }
}
