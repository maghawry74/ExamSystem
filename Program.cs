using ExamSystem.Models;

namespace ExamSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ExamSystemContext context = new ExamSystemContext();
            var ins = context.Users.FirstOrDefault(ins=>ins.Ssn== "29704071701079");
            var Std = context.Users.FirstOrDefault(ins => ins.Ssn == "29704071701073");

            //Application.Run(new LoginForm());
            Application.Run(new StudentWelcome(Std));
        }
    }
}