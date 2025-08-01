namespace Testes_xUnit
{
    public class Operacoes
    {
        public float Adicao(float numero1, float numero2)
        {
            return numero1 + numero2;
        }

        public float Subtracao(float numero1, float numero2)
        {
            return numero1 - numero2;
        }

        public float Multiplicacao(float numero1, float numero2)
        {
            return numero1 * numero2;
        }

        public float Divisao(float numero1, float numero2)
        {
            if (numero2 > 0)
                return numero1 / numero2;
            else return 0;
        }
    }
}
