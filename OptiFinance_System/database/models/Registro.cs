namespace OptiFinance_System.database.models;

public class Registro
{
    public long Id { get; set; }
    public double Debe { get; set; }
    public double Haber { get; set; }
    public Cuenta Cuenta { get; set; } = new Cuenta();
    public Partida Partida { get; set; } = new Partida();

    public override string ToString()
    {
        return
            $"{nameof(Id)}: {Id}, {nameof(Debe)}: {Debe}, {nameof(Haber)}: {Haber}, " +
            $"{nameof(Cuenta)}: {Cuenta}, {nameof(Partida)}: {Partida}";
    }
}