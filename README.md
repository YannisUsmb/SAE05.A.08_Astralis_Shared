# Astralis.Shared

## Ajouter le submodule à un autre projet.

1. Dans le terminal.  
  ```git submodule add https://github.com/YannisUsmb/SAE05.A.08_Astralis_Shared.git Shared```
2. Clique droit sur la solution.
3. Ajouter un projet existant (Shared).
4. Clique droit sur le projet (API ou Blazor).
5. Ajouter une référence de projet.
6. Cochez la case à côté de ```Astralis.Shared```.

### Si submodule introuvable.

Dans la racine du projet (solution .sln):  
```git submodule update --init --recursive```  
Puis clique droit > ```Recharger le projet```.

### Mettre à jour le submodule.

Dans la racine du projet (solution .sln):  
```git submodule update --remote --merge```
