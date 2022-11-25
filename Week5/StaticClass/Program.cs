using StaticClas;

var act01 = ResultSet.Action01();
Console.WriteLine($"{act01.Status,-5} {act01.Message,10}");

var act02 = ResultSet.Action02();
Console.WriteLine($"{act02.Status,-5} {act02.Message,10}");

var act03 = ResultSet.Action03();
Console.WriteLine($"{act03.Status,-5} {act03.Message,10}");

var act04 = ResultSet.Action04();
Console.WriteLine($"{act04.Status,-5} {act04.Message,10}");
