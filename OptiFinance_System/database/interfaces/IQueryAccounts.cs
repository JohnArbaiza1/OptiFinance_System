namespace OptiFinance_System.database.interfaces;

public interface IQueryAccounts <T>
{
    public List<T> SelectAllByTypeActivo();
    public List<T> SelectAllByTypePasivo();
    public List<T> SelectAllByTypeCapital();
    public List<T> SelectAllByTypeDeudora();
    public List<T> SelectAllByTypeAcreedora();
    public List<T> SelectAllByTypePuenteCierre();
}