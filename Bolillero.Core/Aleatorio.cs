namespace Bolillero.Core;

public class Aleatorio : IAleatorio
{
    public int IndiceAleatorio(int limite) => Random.Shared.Next(limite);
}