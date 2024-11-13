namespace exercicico_mvc.Models
{
    public class Geladeiras : Eletrodomestico
    {
        public int CapacidadeLitros {  get; set; } 
        public bool TemFreezer { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Consumo: {ConsumoEnergetico} Kwh, Capacidade: {CapacidadeLitros} litros, Freezer: {(TemFreezer ? "Sim" : "Não")}";
        }
    }
}
