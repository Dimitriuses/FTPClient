using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FTPClient
{
    class Program
    {
        [STAThread]

        static void Main(string[] args)
        {





            //Console.ReadLine();
            // create FtpWebRequest
            //FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://10.7.180.107:21/regex.pdf");
            //request.Method = WebRequestMethods.Ftp.DownloadFile;
            //request.Credentials = new NetworkCredential("test_user", "1234567890");
            //request.EnableSsl = true; // если используется ssl

            // get answer as FtpWebResponse
            //FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            //// get stream and save as file 
            //Stream responseStream = response.GetResponseStream();
            //FileStream fs = new FileStream("ph.jpg", FileMode.Create);
            //byte[] buffer = new byte[64];
            //int size = 0;

            //while ((size = responseStream.Read(buffer, 0, buffer.Length)) > 0)
            //{
            //    fs.Write(buffer, 0, size);
            //}
            //fs.Close();
            //response.Close();


            Client client = new Client();
            string pach = "";
            int ie = 0;
            while (true)
            {
                FileStruct[] Tmp = client.ListDirectory(pach);
                Console.Clear();
                for (int i = 0; i < Tmp.Length; i++)
                {

                    if (i == ie)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        if (Tmp[i].IsDirectory)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        if (Tmp[i].IsDirectory)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                    }
                    Console.WriteLine($"{Tmp[i].Name}");// | {item.Flags} | {item.CreateTime} \n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                //Console.ReadKey();
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        ie = (ie > 0 && ie < Tmp.Length) ? ie - 1 : Tmp.Length - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        ie = (ie != Tmp.Length - 1) ? ie + 1 : 0;
                        break;
                    case ConsoleKey.Enter:
                        if (Tmp[ie].IsDirectory)
                        {
                            pach += "/" + Tmp[ie].Name;
                            ie = 0;
                        }
                        else
                        {
                            client.DownloadFile(pach, Tmp[ie].Name);
                        }
                        break;
                    case ConsoleKey.Backspace:
                        if (pach.Length > 0 || pach != null)
                        {
                            string[] authorsList = pach.Split('/');
                            pach = "";
                            for (int i = 0; i < authorsList.Length - 1; i++)
                            {
                                pach += "/" + authorsList[i];
                            }
                        }
                        break;
                    default:
                        break;
                }

            }


            Console.WriteLine("Saving complete");
            Console.Read();



        }



        
    }
}
