using WK2___Abstract_Factory.Products;

namespace WK2___Abstract_Factory.Factories;

public interface IFactory
{
    IButton CreateButton();
    
    ICheckbox CreateCheckbox();
}