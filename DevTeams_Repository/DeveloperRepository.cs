using DevTeams_POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Repository
{
    public class DeveloperRepository 
    {
        private readonly List<Developer> _developerContext = new List<Developer>();
        private int _count;

        // Create
        public bool AddContentToDirectory(Developer content)
        {
            if (content == null)
            {
                return false;
            }
            else
            {
                _count++;
                content.ID = _count;
                _developerContext.Add(content);
                return true;
            }
        }

        // Read
        public List<Developer> GetDevelopers()
        {
            return _developerContext;
        }

        public List<Developer> GetAllDevelopersByHasPluralSight()
        {
            List<Developer> hasPluralSight = new List<Developer>();
            foreach (Developer content in _developerContext)
            {
                if (content.HasPluralSight)
                {
                    hasPluralSight.Add(content);
                }
            }
            return hasPluralSight;
            
        }

        // Read Helper method
        public Developer GetDeveloperByID(int id)
        {
            foreach (Developer developer in _developerContext)
            {
                if (developer.ID == id)
                {
                    return developer;
                }
            }
            return null;
        }

        // Update
        public bool UpdateDeveloper(int id, Developer developer)
        {
            Developer developer1 = GetDeveloperByID(id);

            if (developer1 != null)
            {
                developer1.FirstName = developer.FirstName;
                developer1.LastName = developer.LastName;
                developer1.HasPluralSight = developer.HasPluralSight;
                return true;
            }
            else
            {
                return false;
            }
        }
        // Delete
        public bool DeleteDeveloper(int id) 
        {
            Developer developer1 = GetDeveloperByID(id);
            if (developer1 != null)
            {
                _developerContext.Remove(developer1);
                return true;
            }
            return false;
        }
    }
}
