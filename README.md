# Gladiadoums

Jeu de combat de gladiateurs au tour par tour, développé en **Blazor WebAssembly** (.NET 10).

## Concept

Le joueur choisit une action à chaque tour (Attaque Rapide, Attaque Puissante ou Garde) et affronte des ennemis dans des salles successives. Le système de combat fonctionne comme un pierre-feuille-ciseaux :

- **Rapide** bat **Puissante**
- **Puissante** bat **Garde**
- **Garde** bat **Rapide**

## Fonctionnalités

- Progression de salle en salle avec score
- Types de salles variés : Combat, Boss, Infirmerie, Shop, Mystère, Repos avant Boss
- Système de **combo** (x2 dégâts au 3ème coup consécutif)
- **Esquive** : chance d'esquiver une attaque ennemie (augmentable)
- **Or** : monnaie gagnée en combat, dépensable au Shop
- Niveaux : les stats du joueur progressent tous les 5 combats gagnés

## Structure du projet

```
Models/         Entités du jeu (Combattant, Joueur, Ennemi, TypeSalle, ActionCombat)
Logic/          Logique métier (MoteurCombat, GestionnaireSalles, LogiqueSalles)
Pages/          Pages Blazor (Home.razor = page principale du jeu)
Layout/         Layout de l'application
wwwroot/        Assets statiques (CSS, Bootstrap)
```

## Lancer le projet

```bash
dotnet watch run
```

L'application est accessible sur `http://localhost:5009`.

## Prérequis

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
