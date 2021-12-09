# CarreMagique
programme interactif de jeu de carré magique en mode console
sauvegarde oui
*** implémenté
Le programme fonctionne en mode console avec un damier de cellules.
Les cellules contiennent des entiers (coordonnées et valeur).
              

              
## Mise à jour en cours

la migration du projet vers .Net 5.0 pose deux difficultés:
1. Il faut changer de bibliothèque pour traiter la sérialisation et déserialisation en JSON
  * Newtonsoft.Json le supportait sous .Net 2.1
  * Mais Newtonsoft.Json n'est pas mis à jour pour .Net 5.0
2. Cette bibliothèque doit savoir traiter les tableaux à deux dimensions de la forme [,]
  * System.Text.Json ne sait pas le faire
  * ou alors modifier le code du projet sous une forme acceptée par cette bibliothèque