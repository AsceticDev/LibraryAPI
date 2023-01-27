using LibraryAPI.Entities;
using LibraryAPI.Entities.Models;

namespace LibraryAPI.Contracts
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
    }
}
