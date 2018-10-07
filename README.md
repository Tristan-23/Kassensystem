<div align="center">
    <h1>C# Kassensystem</h1>
    <strong style="color: 90, 96, 104;">Einfaches, übersichtliches Kassensystem</strong>
</div>




## Funktionen

- [x] Prodkute der Liste hinzufügen<br>
- [x] Produkte aus der Liste entfernen<br>
- [x] Rückgeld errechnen<br>

<a>Geplante Funktionen</a>

- [] Touchscreen freundlich<br>
- [] Eigene Produkte im Programm hinzufügen<br>






## Informationen


Man kann neue Produkte ganz einfach dazu programmieren

```c# 

 [SYNTAX] addProd(String anzeigeName, String preis, float preis);

 [BEISPIEL] addProd("Laugenbrötchen", "0.80€", 0.80f);

```


## Produkt hinzufügen

1. Button im Produkte Tab erstellen (mit Namen des Produkts als Button Text)

2. Im Button_Click Event einfach die Methode addProd() aufrufen

3. Als erste Variable den Namen des Produkts eintragen. addProd("Test Produkt")

3. Als zweite Variable den Preis als String angeben (mit Eurozeichen €). addProd("Test Produkt", "1.00€")

4. Als dritte Variable den Preis als float angeben. addProd("Test Produkt", "1.00€", 1.00f)

5. Fertig!








