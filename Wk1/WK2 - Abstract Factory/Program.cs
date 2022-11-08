
using WK2___Abstract_Factory.Factories;
using WK2___Abstract_Factory.Factories.Concrete;

CreateUi(new MacFactory());

Console.WriteLine();

CreateUi(new WinFactory());

void CreateUi(IFactory factory)
{
    var button = factory.CreateButton();
    var checkbox = factory.CreateCheckbox();

    Console.WriteLine(button.Click());
    Console.WriteLine(checkbox.Check());
}