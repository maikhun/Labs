using SharpWasher;
void Demonstration()
{
    var dirtyCar = new Car();
    dirtyCar.IsDirty = true;
    var garage = new Garage();
    garage.Cars.Add(dirtyCar);
    var washer = new Washer();
    Action<IWashable> washDelegate = washer.Wash;
    foreach (var car in garage.Cars)
        washDelegate((IWashable)car);
}