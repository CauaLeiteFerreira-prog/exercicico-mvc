namespace exercicico_mvc.Models
{
    public class Televisor : Eletrodomestico
    {
        public int TamanhoTela { get; set; }
        public bool EhSmart { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Consumo: {ConsumoEnergetico} Kwh, tamanho da tela: {TamanhoTela} polegadas, é Smart: {(EhSmart ? "Sim" : "Não")}";
        }
    }
}
