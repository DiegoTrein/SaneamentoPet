namespace SaneamentoPet.Models
{
    public class Pet
    {
        public int chip_id { get; set; }
        public string nome { get; set; }
        public int idade_aproximada { get; set; }
        public string tipo_pet { get; set; }
        public string sexo { get; set; }
        public bool vacinado { get; set; }
        public bool castrado { get; set; }
        public string caixa_texto { get; set; }
    }
}
