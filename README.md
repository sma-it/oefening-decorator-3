# oefening-decorator-3

In deze oefening heb je een player die je kan beschieten. Dat gebeurt door een projectiel te maken, en dat af te vuren op de player (via de functie `AttackWith`, met het projectiel as argument). Je ziet dat in actie in de eerste optie van het menu in program.cs. Nadat de player beschoten is, tonen we de status van de player op het scherm via `PrintStatus`.

In het tweede deel van de oefening zullen we de player *shielden* via het decorator pattern.

## Opdracht 1 - Projectiles

Wanneer je de code bekijkt in `Program.cs` zie je dat de player enkel aangevallen wordt als er een projectiel is (`projectile != null`). Op dit moment kan dat niet, want we hebben enkel een `IProjectile` interface, geen class.

1. Voeg in de folder **Projectiles** de class `Projectile`. Deze class moet de interface `IProjectile` implementeren.
2. De interface verplicht je om een property `Damagetype Type` te voorzien. De waarde daarvan stel je in via een argument in de constructor.
3. Voeg ook een private variable `int strength` toe. Ook deze waarde moet ingesteld worden via een constructor argument.
4. Je moet ook de functie `Damage` uitwerken. Daarin zet je deze code:

```
strength -= target.DoDamage(strength);
```

We geven dus de strength van het projectiel door aan het target. Het target geeft dan als resultaat hoeveel van die waarde geabsorbeerd kon worden. Die waarde trek je af van de strength van het projectiel, zodat dit later (na het toevoegen van shields) een deel van zijn kracht kan verliezen.

Voorlopig vuren we het projectiel rechtstreeks op de player af, dus alle strength van het projectiel komt rechtstreeks bij de player terecht.

5. In `Program.cs` kan je nu een projectiel toevoegen. Je kan zelf een `DamageType` en een waarde voor `strength` kiezen.
6. Test je programma.

## Opdracht 2 - Meer Projectiles

1. Kan nu een projectiel maken via constructor arugmenten. Om dit te vereenvoudigen maken we nu 4 afgeleide classes van `Projectile`: Arrow, FireArrow, Stone en Spell. Die classes hebben enkel een constructor zonder argumenten. Via de base constructor stel je de argumenten voor `Projectile` in. Je kiest zelf welke het meest geschikt zijn.
2. Nu je deze 4 afgeleide classes hebt, is het maken van projectielen veel eenvoudiger:

```
switch(random.Next(4))
{
    case 0:
        projectile = new Stone();
        Console.WriteLine("Trowing a stone...");
        break;
    case 1:
        // ...
}
```

## Opdracht 3 - Shield

1. Voeg een class `Shield` to in de folder **Shields**. Deze class implementeert `IDamageTaker`, net zoals de player. Er zijn ook 3 private variabelen nodig:

```
IDamageTaker child;
DamageType absorbedDamageType;
int strength;
```

Deze variabelen stel je in via de constructor. `strength` staat voor de initieële sterkte van het schild. AbsorbedDamageType staat voor het damage type dat dit schild kan absorberen. En omdat we het *Decorator Pattern* toepassen, moet een wrapper natuurlijk ook zijn *child object* kennen.

2. Implementeer de functie `Child()`. Deze functie moet het child object als resultaat geven.
3. Implementeer de functie `IsDepleted()`. Deze functie moet aangeven of het schild al dan niet uitgeput is.
4. Implementeer de functie `PrintStatus()`. Hier toon je de huidige sterkte van het schild op het scherm. Daarna roep je gelijknamige functie van het child object op. (Ja, hier zie je weer het decorator pattern in aktie!)
5. Implementeer de functie `DoDamage`. Deze functie wordt uitgevoerd door het aanvallende projectiel. Je krijgt als argument binnen hoeveel damage dit projectiel kan doen. Normaalgezien strek je die damage dus van de strength van het schild af. Tenzij het schild natuurlijk niet zoveel kan absorberen. Als functieresultaat geef je hoeveel damage er nu werkelijk geabsorbeerd werd. (Het projectiel gebruikt die waarde om te zien hoeveel kracht er nog over is).
6. Implementeer de functie `AttackWith`. Hier komt een projectiel binnen als argument. Je moet hier verschillende zaken achtereenvolgens laten gebeuren:
        - Laat het projectiel damage op dit schild uitvoeren, maar enkel wanneer het type van het schild gelijk is aan dat van het projectiel.
        - Geef het projectiel door aan het child object, zodat het ook daar damage kan uitvoeren. (Decorator pattern in aktie!!)
        - Kijk na of het child object *depleted* is. In dat geval vraag je het child object van dat child object op, en stel je dat in als het nieuwe child object van dit schild. Op deze manier verwijder je als het ware de lege schilden uit de verzameling.

7. Je class is nu klaar. Je zou nu rechtstreeks schilden kunnen maken in het programma, maar we gaan nog een stap verder. Net zoals bij de projectielen maken we nu ook specifieke `Shield` classes: BasicShield, FireShield en ArcaneShield. Ook nu weer bevatten die classes enkel constructors, waarmee je de argumenten van de base constructor instelt.
8. Pas daarna het programma aan, zodat je de opties 2 tot 4 de player verpakt in de correcte decorator (een shield).  
9. Test je programma.

## Opdracht 4 - Super Shield

Je zou ook een algemeen schild kunnen maken dat alle soorten damage tegenhoudt. Maar je zal enkele problemen moeten oplossen. Probeer het eens!

