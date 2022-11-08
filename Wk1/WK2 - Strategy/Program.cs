
using WK2___Strategy;

var navigator = new Navigator();
navigator.SetStrategy(new WaterStrategy());
navigator.Navigate();

navigator.SetStrategy(new RoadStrategy());
navigator.Navigate();