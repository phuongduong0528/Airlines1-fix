using Airlines.FormApplication.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airlines.FormApplication
{
    public class Program
    {
        private UserController _userController;
        public UserController UserController => _userController ??
            (_userController = new UserController());

        private UserActivityController _activityController;
        public UserActivityController UserActivityController => _activityController ??
            (_activityController = new UserActivityController());

        public static Program Instance { get; set; }

        public Program()
        {
            _userController = new UserController();
            _activityController = new UserActivityController();
        }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Instance = new Program();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
