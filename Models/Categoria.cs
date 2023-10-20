using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Razor.Language;

namespace projeto.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [Display(Name = "Nome da Categoria")]
        [Required(ErrorMessage = "Informe o nome da categoria")]
        public string Nome { get; set; }
        public List <Item> Itens { get; set; }
    }
}