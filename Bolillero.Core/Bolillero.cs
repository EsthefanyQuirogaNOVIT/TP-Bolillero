namespace Bolillero.Core;
public class Bolillero 
{
    public List<int>? Bolillas { get; set; }
    public List<int>? Afuera { get; set; }
    public IAleatorio Aleatorio{ get; set; } 
    public List<int>? Jugada { get; set; }

    public Bolillero(int bolillas, IAleatorio aleatorio)
    {
        this.Bolillas = new List<int>();
        this.Afuera = new List<int>();
        this.Jugada = new List<int>();
        this.Aleatorio = aleatorio;
    }

    public int SacarBolilla()
    {
        var = Random.IndiceAleatorio();
    }
    public bool Jugar(List<int> jugada)
    {
        for (int i = 0; i <= jugada.Count; i++)
        {
            if ()
        }
            return true;
    }

    public void MeterBolilla(int afuera)
    {

    }

    public void JugarNVeces()
    {

    }
}
