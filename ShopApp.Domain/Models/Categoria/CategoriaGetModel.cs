

using ShopApp.Domain.Models.Categoria.BaseModel;

namespace ShopApp.Domain.Models.Categoria
{
    public record CategoriaGetModel : CategoriaModel
    {
        public DateTime Create_date { get; set; }
    }
}
