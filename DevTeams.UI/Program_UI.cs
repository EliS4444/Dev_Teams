using DevTeams_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DevTeams.UI
{
    public class Program_UI
    {
        private readonly DeveloperRepository _devRepo;
        private readonly DeveloperTeamRepository _devTeamRepo;

        public Program_UI()
        {
            _devRepo = new DeveloperRepository();
            _devTeamRepo = new DeveloperTeamRepository(_devRepo);
        }

        public void Run()
        {
            Seed();
            RunApplication();
        }

        private void RunApplication()
        {
            bool isRunning = true;
            while (isRunning)
            {
                    WriteLine("Welcome to dev Teams\n" +
                    "1. Add a developer\n" +
                    "2. View all existing developers\n" +
                    "3. View an existing developer\n" +
                    "4. Update an existing developer\n" +
                    "5. Delete an exisiting developer\n");

                string userInput = ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddADeveloper();
                        break;
                    case "2":
                        AddAllExistingDevelopers();
                        break;
                    case "3":
                        ViewAnExistingDeveloper();
                        break;
                    case "4":
                        UpdateAnExistingDeveloper();
                        break;
                    case "5":
                        DeleteAnExistingDeveloper();
                        break;
                    default:
                        WriteLine("Invalid selection");
                        WaitForKey();
                        break;
                }
                Clear();
            }
        }
        private void ViewAnExistingDeveloper()
        {
            throw new NotImplementedException();
        }

        private void DeleteAnExistingDeveloper()
        {
            throw new NotImplementedException();
        }

        private void UpdateAnExistingDeveloper()
        {
            throw new NotImplementedException();
        }

        private void AddAllExistingDevelopers()
        {
            throw new NotImplementedException();
        }

        private void AddADeveloper()
        {
            throw new NotImplementedException();
        }

        private void WaitForKey()
        {
            ReadKey();
        }
        private void Seed()
        {
            
        }
    }
}
