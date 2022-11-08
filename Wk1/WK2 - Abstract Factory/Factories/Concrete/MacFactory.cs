using WK2___Abstract_Factory.Products;
using WK2___Abstract_Factory.Products.Concrete;

namespace WK2___Abstract_Factory.Factories.Concrete;

public class MacFactory : IFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacCheckbox();
    }
}