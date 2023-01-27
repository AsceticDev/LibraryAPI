namespace LibraryAPI.Contracts
{
    public interface IRepositoryManager
    {
        ICompanyRepository Company { get; }
        void Save();
    }
}
