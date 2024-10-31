namespace OptiFinance_System.database.models;

public class LibroMayor
{
    public long Id { get; set; }
    public decimal Debe { get; set; }
    public decimal Haber { get; set; }
    public Cuenta? Cuenta { get; set; }
    public Partida? Partida { get; set; }

    public override string ToString()
    {
        return
            $"{nameof(Id)}: {Id}, {nameof(Debe)}: {Debe}, {nameof(Haber)}: {Haber}, {nameof(Cuenta)}: {Cuenta}, {nameof(Partida)}: {Partida}";
    }
}