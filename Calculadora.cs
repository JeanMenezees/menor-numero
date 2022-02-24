namespace calc;

public class Calculadora 
{
    public decimal CacularMmc(List<decimal> numeros)
    {
        decimal mmc = 1;

        numeros.ForEach(numero => {{
            decimal minimoDivisorAtual = (mmc * numero / CalcularMdc(mmc, numero));

            mmc = Math.Round(minimoDivisorAtual);
        }});

        return mmc;
    }

    // Para cada numero da lista, sempre é calculado o mdc entre o número com o mmc atual
    public static decimal CalcularMdc(decimal mmcAtual, decimal numero){     
        while(numero != 0){
            decimal mdc = mmcAtual % numero;
            mmcAtual = numero;
            numero = mdc;
        }
        return mmcAtual;
    }
}