Üdvözlök mindenkit a Beam Statements pénzügyi kimutatáskezelõ alkalmazásban. A program fõ célja, funkciója, hogy grafikusan, illetve listázva megmutassa az adott személynek / vállalatnak,
hogy az adott évben mennyit költött, mennyi pénzt keresett. A tranzakciókat tartalmazó csv fájlt bárhogyan el lehet nevezni, lényeg, hogy a bevételeket a C:\temp\Incomes,
a kiadásokat C:\temp\Expenses mappába rakjuk, hiszen innen tudja kiolvasni a szoftver az adatokat. 
A solutionben van egy mappa "CSVs" néven, ebben bennevan 2-2 példa csv. Ha a mappában lévõ 2 mappát: Incomes, Expenses betesszük a C:\temp -be már mûködni is fog.
A csv-knek szigorú formátumot kell követni:
az "A" oszlopba kerül egy egész szám 1-12 között, ez lesz az adott hónap indexe, amikor a tranzakció megtörtént. 
A második, "B" oszlopba kerülnek a bevétel, vagy kiadás típusai.
Ha bevételi csv-t csinálunk: 
1 - Értékesítés
2 - Pénzügyi
3 - Egyéb
Ha kiadási csv-t csinálunk:
1 - Közvetlen
2 - Pénzügyi
3 - Adminisztratív
4 - Értékesítés
5 - Egyéb
A harmadik, azaz "C" oszlopba pedig az adott tranzakció értéke kerül.
Miután kitöltöttük a csv-t és elmentettük a megfelelõ helyre el is kezdhetjük használni az alkalmazást.
Az alkalmazás 2 fõ formból és egy kezdõlapból áll. 
A GraphView formban grafikus módon láthatjuk az adott évek tranzakcióit összegezve. Ha szeretnénk kitörölhetünk olyan hónapokat, amiket nem szeretnénk látni a checkedBoxList segítségével, 
valamint screenshotot is készíthetünk, ami a C:\temp mappába fog kerülni screenshot.png néven. Személyre is szabhatjuk az adott grafikont. 
A ListView formon listázva láthatjuk az adott év tranzakcióit. Ezen az oldalon már nem csak hónapokat, hanem tranzakció típusokat is törölhetünk az adott év listájából. 