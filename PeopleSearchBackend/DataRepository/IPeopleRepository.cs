using PeopleSearchBackend.Models;
using System.Collections.Generic;
using System.Linq;

namespace PeopleSearchBackend.DataRepository
{
    public interface IPeopleRepository
    {
        List<PeopleSearch> getAll();
        List<PeopleSearch> getDetails(string userName);
    }
    
}
