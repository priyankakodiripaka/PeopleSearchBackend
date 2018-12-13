using PeopleSearchBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleSearchBackend.DataRepository
{
    public class PeopleRepository : IPeopleRepository
    {
        private PeopleSearchBackendContext db;
        public PeopleRepository()
        {
            db = new PeopleSearchBackendContext();
        }

        List<PeopleSearch> IPeopleRepository.getAll()
        {
            return db.PeopleSearches.Select(x => x).ToList();
        }

        List<PeopleSearch> IPeopleRepository.getDetails(string userName)
        {
            return db.PeopleSearches.Where(x => x.FirstName.Contains(userName)
                        || x.LastName.Contains(userName)).ToList();

        }
    }
}