using System;
using System.ComponentModel.DataAnnotations;

namespace FundamentosBlazorServerForms.Modelos
{
	public class Producto
	{
		[Required(ErrorMessage = "El nombre es obligatorio")]
		[StringLength(10, MinimumLength =5, ErrorMessage = "El nombre debe estar entre 5 y 10 caracteres")]
		public string Nombre { get; set; }
        [Required(ErrorMessage = "La descripción es obligatoria")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "La descripción debe estar entre 5 y 10 caracteres")]
        public string Descripcion { get; set; }
		[Range(1, 20, ErrorMessage = "La cantidad debe estar entre 1 y 20")]
		public int Cantidad { get; set; }
		[Required(ErrorMessage = "El producto es obligatorio")]
		[Range(typeof(bool), "true", "true", ErrorMessage = "El producto debe estar activo")]
		public bool Activo { get; set; }
	}
}

	