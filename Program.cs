using System;
using System.Collections.Generic;
using System.Text;
using SuperHeroP.Models;

Console.WriteLine("SUPER HEROES INFO");

// Creación de los super poderes:

var canFly = new SuperPower();
canFly.Name = "Fly";
canFly.Description = "Capacity to fly";
canFly.Level = LevelPower.LevelTwo;

var superStrength = new SuperPower();
superStrength.Name = "Super strength";
superStrength.Description = "Super strength capacity";
superStrength.Level = LevelPower.LevelThree;

var mindControl = new SuperPower();
mindControl.Name = "Mind control";
mindControl.Description = "Capacity to control minds of others living beings";
mindControl.Level = LevelPower.LevelThree;

// Creación de los super héroes:
// Superman (DC) hero
var superman = new SuperHero();

superman.Id = Guid.NewGuid();
superman.Name = "   Superman   ";
superman.SecretIdentity = "Clark Ken";
superman.City = "Metropolis";

List<SuperPower> powersSuperman = new List<SuperPower>();
powersSuperman.Add(canFly);
powersSuperman.Add(superStrength);
superman.SuperPowers = powersSuperman; // Se agregan los super poderes al objeto superman
string resultSuperPowers = superman.UseSuperPower(); // Se llama al método UseSuperPower para que el héroe use sus super poderes
Console.WriteLine(resultSuperPowers);

// Professor X (Marvel) hero
var professorX = new SuperHero();

professorX.Id = Guid.NewGuid();
professorX.Name = "   Yuri  ";
professorX.SecretIdentity = "Charles Xavier";
professorX.City = "New York City";

List<SuperPower> powersProfessorX = new List<SuperPower>();
powersProfessorX.Add(mindControl);
professorX.SuperPowers = powersProfessorX;

string resultProfessorXPowers = professorX.UseSuperPower(); // Se llama al método UseSuperPower para que el héroe use sus super poderes
Console.WriteLine(resultProfessorXPowers);

// AntiHero
var wolverine =  new AntiHero();
wolverine.Id = Guid.NewGuid();
wolverine.Name = "Wolverine";
wolverine.SecretIdentity = "Logan";
wolverine.City = "Albert, CAD";

List<SuperPower> powersWolverine = new List<SuperPower>();
powersWolverine.Add(superStrength);
wolverine.SuperPowers = powersWolverine;
string resultWolverinePowers = wolverine.UseSuperPower(); // Se llama al método UseSuperPower para que el héroe use sus super poderes
Console.WriteLine(wolverine.UseSuperPower());

string AccionOfAntiHero = wolverine.AccionOfAntiHero("Atack the police");
Console.WriteLine(AccionOfAntiHero);

// Enumeración nivel de poder
enum LevelPower
{
    LevelOne,
    LevelTwo,
    LevelThree
}