using WK2___Abstract_Factory.Products;
using WK2___Abstract_Factory.Products.Concrete;

namespace WK2___Abstract_Factory.Factories.Concrete;

public class WinFactory : IFactory
{
    public IButton CreateButton()
    {
        return new WinButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WinCheckbox();
    }
}