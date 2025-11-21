# Astralis.Shared

## Ajouter le submodule à un autre projet.

1. ```Affichage``` > ```Terminal```.
2. Dans la racine du projet (solution .sln): ```git submodule add https://github.com/YannisUsmb/SAE05.A.08_Astralis_Shared.git Shared```
2. Clique droit (sur la **solution**) > ```Ajouter``` > ```Projet existant```.
3. Clique droit sur le projet (**API** ou **Blazor**) > ```Ajouter``` > ```Référence de projet```.
4. Cochez la case à côté de ```Astralis.Shared```.

## Troubleshooting.

### Si submodule introuvable.

1. ```Affichage``` > ```Terminal```.
2. Dans la racine du projet (solution .sln): ```git submodule update --init --recursive```
3. Clique droit (sur le **submodule**) > ```Recharger le projet```.

### Mettre à jour le submodule.

1. ```Affichage``` > ```Terminal```.
2. Dans la racine du projet (solution .sln): ```git submodule update --remote --merge```
