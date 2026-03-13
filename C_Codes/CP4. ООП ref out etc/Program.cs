using CP4._ООП_ref_out_etc;

  var manager = new CollectionManager();
  var tech = new Technology("CD", "реликт прошлого", 2000, TechnologyLevel.Низкий, TechnologyPurpose.Инструмент);
  var min = new Mineral("Нефрит", "очень зеленый", 140, 10, RarityLevel.Средний);
  var min2 = new Mineral("Яшма", "очень оранжевая", 120, 1, RarityLevel.Низкий);
  var cr = new Creature("Кот", "мягенький", 3, DangerLevel.Нейтральный, "корм");
  Console.WriteLine(tech.ToString()); 
  Console.WriteLine(min.ToString());
  Console.WriteLine(manager.AddArtifact(tech));
  Console.WriteLine(manager.AddArtifact(tech));
  manager.RemoveArtifact("CD");
  manager.AddArtifact(min);
  manager.AddArtifact(min2);
  Console.WriteLine(manager.AddArtifact(tech));
  foreach (Mineral mineral in manager.GetArtifactsByType<Mineral>())
  {
    Console.WriteLine(mineral.Name);
    Console.WriteLine("-----");
  }

