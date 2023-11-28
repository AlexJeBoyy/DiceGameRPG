using static System.Net.Mime.MediaTypeNames;
using System.Resources;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System;

/*dice game
random weapon making game
you get a random amount of (wood, iron, leather, stone, fabric, rope) and also get a random amount of mana which can make
your weapon less durable and strong then you get to chose which weapon (bow, sword, axe, dagger, staff, shield, armor) you want to
make and what would work best with the amount of stuf you have. you need to have a minimum of (items) to make(weapon)

we need 6 dices (or we can code it but yk thats harder)

minimum
bow: wood: 5 rope: 3 stone: 3 + damage = 5 - 7 loop = roll a 6 dice and how high you get how many times you shoot arrow (damage stays the same on every arrow)
sword: iron: 5 leather: 3 + damage = 13 - 16
axe: iron: 6 Wood: 4 + damage = 16 - 19
dagger: iron: 2 leather: 2 + damage = 7 - 12
staff: wood: 4 mana: 5 + damage = 12 - 16 loop = roll a 6 dice and how high you get how many + damage you do
shield: wood: 3 stone: 4 + block chance = 35 % (if you roll above 17) 
armor: iron: 6 fabric: 3 + protection + 6(you get 6 less damage per attack)

Bow:
Durability 8(Chance of string breaking)
Arrow count standard 25 (Get more arrows more mobs you kill) 

Sword:
Durability 10(Chance of blade shatter)

Axe:
Durability 9(Chance of axe flying off the handlebar)
Upgrade AOE magic, total mana: 30(costs 1 - 6 mana per cast)

Dagger:
Durability 6(Small, cannot deal with too many stabs over time)

Staff:
Mana usage with every cast can cost 1-6 mana points, total have 30 mana points!

Shield: 
Durability 25 (After long use it'll chip away)

Armour:
Durability 20 (Can hold off slashes but does have weak spots)

health = 100
lives = 1(you can choose more if you wanna play longer, you lose everything if you die) 

rules:
resources 6 dice
chosing resources 8 dice
damage 20 dice
each turn you can choose to either attack, roll a dice or make a new weapon
if you roll under 5 you do 0 damage
if you have a sword (13-16) and roll 18 you do 16 damage. when you roll a 20 you get +2 damage with every weapon.
if your weapon durability runs out it breaks and you need to make a new one.

mana
(with 6 mana you can upgrade your weapons, and do 3 extra damage)

1st turn: everybody rolls the dices and makes a weapon.
2th turn: p1 attacks 
p2 choses to roll for new resources: they roll a 8 and 6 dice, the 8 dice decides what resource you get: 
1 wood, 2 iron, 3 leather, 4 stone, 5 fabric, 6 rope, 7 mana, 8 nothing
and the 6 dice decides the amount of resource you get.

1 wood,
2 iron,
3 leather,
4 stone,
5 fabric,
6 rope,
7 mana,
8 double

bow: wood: 5 rope: 3 stone: 3 + damage = 6 - 8 loop = roll a 6 dice and how high you get how many times you shoot arrow (damage stays the same on every arrow)
sword: iron: 5 leather: 3 + damage = 13 - 16
axe: iron: 6 Wood: 4 + damage = 16 - 19
dagger: iron: 2 leather: 2 + damage = 7 - 12
staff: wood: 4 mana: 5 + damage = 12 - 16 loop = roll a 6 dice and how high you get how many + damage you do
shield: wood: 3 stone: 4 + block = if you roll above 16
armor: iron: 6 fabric: 3 + protection + 6(you get 6 less damage per attack)
*/

