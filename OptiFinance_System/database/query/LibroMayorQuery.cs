using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.generalities;
using OptiFinance_System.database.generalities.parameters;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class LibroMayorQuery : IQueriesLibroMayor
{
    private static readonly Lazy<LibroMayorQuery> _instance = new(() => new());

    private readonly Connection _connectionInstance;

    private LibroMayorQuery()
    {
        _connectionInstance = Connection.Instance;
        _connectionInstance.OpenConnection();
    }

    public static LibroMayorQuery Instance => _instance.Value;
    private static LibroMayorParams Params => Queries.LibroMayorParams;


    /// <summary>
    /// Selecciona todos los registros por empresa
    /// Advertencia: Se debe de haber seleccioando una empresa antes de llamar a este método
    /// </summary>
    /// <returns> Lista de registros que servirán como libro mayor </returns>
    public List<LibroMayor> SelectAll()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSelectAll,
            Map, Params.ParametersSelectAll());
    }

    /// <summary>
    /// Selecciona todos los registros, filtrándolos por el id de la cuenta
    /// </summary>
    /// <param name="id"> Código de la cuenta porla que se filtrará </param>
    /// <returns> Lista de registros que servirán como libro mayor </returns>
    public List<LibroMayor> SelectAllByAccount(long id)
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SelectAllByCodigo,
            Map, Params.ParametersTotalByAccount(id));
    }

    /// <summary>
    /// Selecciona todos los registros, filtrándolos por la cuenta
    /// </summary>
    /// <param name="entity">objeto de tipo <see cref="Cuenta"/> que contendrá el id de la cuenta por la que se filtrará</param>
    /// <returns></returns>
    public List<LibroMayor> SelectAllByAccount(Cuenta entity)
    {
        return SelectAllByAccount(entity.Id);
    }

    /// <summary>
    /// Sirve para obtener la suma de los registros de una cuenta filtrando de manera implicita por empresa seleccionada
    /// </summary>
    /// <param name="id">Id de la cuenta por la que se filtrará</param>
    /// <returns>Retorna un objeto de tipo <see cref="LibroMayor"/> que contiene la suma de los registros de
    /// la cuenta filtrada por id
    /// </returns>
    public LibroMayor? GetSumByAccount(long id)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.TotalByAccount,
            Map, Params.ParametersTotalByAccount(id));
    }

    /// <summary>
    /// Sirve para obtener la suma de los registros de una cuenta filtrando de manera implicita por empresa seleccionada
    /// </summary>
    /// <param name="entity">Objeto de tipo <see cref="Cuenta"/> que contendrá el id de la cuenta por la que se filtrará</param>
    /// <returns>Retorna un objeto de tipo <see cref="LibroMayor"/> que contiene la suma de los registros de la cuenta filtrada por id.
    /// En sus propiedades <see cref="LibroMayor.Debe"/>, guardará la suma del debe total y en <see cref="LibroMayor.Haber"/> guardará la suma del haber total
    /// </returns>
    public LibroMayor? GetSumByAccount(Cuenta entity)
    {
        return GetSumByAccount(entity.Id);
    }

    /// <summary>
    /// Retorna la cantidad de cuentas diferentes que hay en la empresa seleccionada
    /// Suma total, tomando en cuenta todos los tipos de cuenta existentes
    /// </summary>
    public int Count => QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlCount,
        Params.MapCount,
        Params.ParametersCount());

    public LibroMayor Map(SqlDataReader reader)
    {
        return Params.Map(reader);
    }
}