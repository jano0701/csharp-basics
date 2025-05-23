# 🧠 C# Grundlagen – Lernprojekt

Dieses Repository enthält **strukturierte und thematisch geordnete C#-Beispiele**, die zentrale Programmierkonzepte abdecken.  
Es richtet sich an **Einsteiger**, **Studierende** und alle, die ihre C#-Kenntnisse auffrischen oder praktisch anwenden möchten.

---

## 📁 Ordnerübersicht

Jeder Ordner steht für ein grundlegendes Thema der Programmiersprache C#:

| Ordner              | Thema                                               |
|---------------------|-----------------------------------------------------|
| `boolean/`          | Wahrheitswerte, logische Operatoren (`&&`, `||`, `!`) |
| `error_handling/`   | Fehlerbehandlung mit `try`, `catch` und `finally`   |
| `for_loops/`        | `for`-Schleifen, Durchlaufen von Arrays             |
| `functions_modules/`| Funktionen, Rückgabewerte und Wiederverwendung      |
| `if_statements/`    | Bedingte Verzweigungen mit `if`, `else if`, `else` |
| `lists/`            | Arbeiten mit Listen (`Add`, `Count`, `foreach`, ...) |
| `oop_basics/`       | Klassen, Konstruktoren, Methoden, OOP-Grundlagen    |
| `print_statements/` | Konsolenausgabe mit `Write` und `WriteLine`         |
| `while_loops/`      | `while`-Schleifen mit Benutzereingaben              |

---

## 💻 Projektstruktur

Jedes Unterthema enthält eigenständige Projekte, die mit  
```bash
dotnet new console
```
erstellt wurden. Der zugehörige C#-Code befindet sich immer in einer Datei namens `Program.cs`.

Beispiel:
```
boolean/
├── BooleanBasics/
│   └── Program.cs
├── LogicalOperators/
│   └── Program.cs
```

---

## ▶️ Ausführen eines Beispiels

Stelle sicher, dass das [.NET SDK](https://dotnet.microsoft.com/en-us/download) installiert ist.  
Wechsle in das entsprechende Unterverzeichnis und führe den Code mit `dotnet run` aus:

```bash
cd boolean/BooleanBasics
dotnet run
```

---

## ℹ️ Hinweise

- Alle Projekte sind Konsolenanwendungen und unabhängig ausführbar
- `bin/` und `obj/`-Verzeichnisse sind über `.gitignore` vom Repository ausgeschlossen
- Geeignet für Hochschulen, Selbststudium und Interview-Vorbereitung

---

Viel Erfolg beim Lernen! 🚀