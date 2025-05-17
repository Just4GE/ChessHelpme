## Miniprojekt: ChessHelpme – AR-Schachunterstützung

**ChessHelpme** entstand im Rahmen eines **Kurses mit Schwerpunkt auf Augmented Reality** als ein zwei man Projekt. Ziel war es, innerhalb eines Monats einen **funktionalen Prototypen in Unity** zu entwickeln, der **AR- oder VR-Technologie** sinnvoll einsetzt. Die Anwendung sollte **einen praktischen Nutzen** erfüllen – kein klassisches Spiel, sondern eine Lösung mit Potenzial zur Weiterentwicklung.



## Projektidee: Augmented Reality zur Schachunterstützung

**ChessHelpme** ist eine AR-App, die genutzt werden kann, um **potenzielle Züge von Schachfiguren visuell darzustellen** – ähnlich wie in digitalen Schachprogrammen. Der Clou: Die Anwendung arbeitet mit echten Schachfiguren auf einem realen Spielbrett, erkennt deren Position mithilfe von **gedruckten Markern** und visualisiert mögliche Züge direkt im Raum.

### Funktionsweise im Überblick:

* Jede Schachfigur trägt einen eigenen, eindeutigen **Marker**, der unter ihr platziert wird.
* Die App erkennt diese Marker und **speichert die Figurenpositionen** in einer Liste.
* Berührt der Nutzer das Icon über einer Figur, werden deren **legale Züge angezeigt**:

  * **Grüne Hologramm-Sphären** markieren freie Felder, auf die sich die Figur bewegen kann.
  * **Rote Hologramm-Sphären** markieren Felder, auf denen sich **gegnerische Figuren befinden**, die geschlagen werden können.

### Spielfeld-Erkennung:

* Die **Größe des Schachbretts** wird über einen **zentral platzierten QR-Code** erkannt.
* Dieser QR-Code muss die **mittleren vier Felder** des Bretts abdecken und vor Spielbeginn gescannt werden.
* So kann die App die Dimensionen des physischen Spielfelds korrekt bestimmen.

### Technische Umsetzung:

* Die Erkennung der Marker erfolgt über eine **Raycasting-Technik**:

  * Jeder Marker wird mit einem Ray getroffen, um dessen exakte Position im Raum zu bestimmen.
* Die App läuft in Unity und verwendet die **Marker-ID**, um die Figur zu identifizieren und ihre **Bewegungslogik** zu berechnen.

---

## Potenzial zur Weiterentwicklung

Obwohl ChessHelpme als einfacher Prototyp entstand, sehen wir darin mehrere spannende **Ansätze für zukünftige Erweiterungen**:

* **Markerlose Objekterkennung**: Automatische Figurenerkennung durch Bild- oder Formanalyse
* **Zugprognosen**: Vorhersage des wahrscheinlichsten gegnerischen Zuges
* **Spielunterstützung**: Vorschläge für den **bestmöglichen Zug** auf Basis einer einfachen Schach-KI – idealerweise mit Ausblick auf mögliche Siegpfade

---

## Fun Fact: Vom „Helper“ zum „Helpme“

Ursprünglich war der Name des Projekts schlicht und funktional: **ChessHelper** – genau das, was die App tun sollte.

Im Laufe der Entwicklung kam es jedoch mehrfach zu **technischen Problemen**, die uns zwangen, immer wieder neue Unity-Projekte anzulegen. Die alten Versionen wurden aus Dokumentationsgründen nicht gelöscht, und so brauchten wir jedes Mal einen **neuen Projektnamen**.

Beim letzten Neustart – war der Frust spürbar:
Aus **ChessHelper** wurde kurzerhand **ChessHelpme** – als ironischer Hilferuf und augenzwinkernder Kommentar zur Lage:
*"Please… Help me!"*

Der Name ist geblieben – und erinnert uns bis heute daran, dass Softwareentwicklung nicht immer gradlinig verläuft, aber mit etwas Humor viel leichter wird.

---
![dfdf](https://github.com/user-attachments/assets/6e40856a-7ad2-48f9-bd30-effef17ac124)
![23](https://github.com/user-attachments/assets/ddf553ef-9bca-4cfe-8bd1-31bab50242ca)![2](https://github.com/user-attachments/assets/c8b8a765-05c6-4870-afa5-b74cad3b529d)
![Unbenannt](https://github.com/user-attachments/assets/b498573e-1113-4e79-8bb5-dbff6e3a2582)



