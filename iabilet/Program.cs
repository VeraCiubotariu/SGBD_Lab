using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using iabilet.repository;
using iabilet.service;

namespace iabilet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBRepository repository = new DBRepository();
            

            Service service = new Service(repository);
            foreach (var genre in service.GetAllGenres())
            {
                Console.WriteLine(genre);
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            form1.SetService(service);
            Application.Run(form1);
        }
    }
}