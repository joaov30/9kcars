using System.ComponentModel.DataAnnotations;

namespace _9kcars.Entities
{
	public class Veiculo
	{
		public int VeiculoId { get; set; }

		[MaxLength(100)]
		[Required(ErrorMessage = "O nome da Marca é obrigatório.")]
		public string? Marca { get; set; }

		[MaxLength(100)]
		[Required(ErrorMessage = "O nome do Modelo é obrigatório.")]
		public string? Modelo { get; set; }

		[MaxLength(4)]
		[Required(ErrorMessage ="O ano do Veiculo é obrigatório")]
		public int? Ano {  get; set; }

		[MaxLength(100)]
		[Required(ErrorMessage = "O nome da Categoria é obrigatório.")]
		public string? Categoria { get; set; }

		[MaxLength(100)]
		[Required(ErrorMessage = "O nome da Cor é obrigatório.")]
		public string? Cor {  get; set; }

		[Required(ErrorMessage = "O preço é obrigatório.")]
		public decimal? Valor { get; set; }

		[MaxLength(8)]
		[Required(ErrorMessage = "A numeração da Placa é obrigatório.")]
		public string? Placa { get; set; }

		[Required(ErrorMessage = "O campo Ativo é obrigatório.")]
		public bool? Disponibilidade { get; set; }
	}
}
