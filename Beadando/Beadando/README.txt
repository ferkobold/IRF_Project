Üdvözlök mindenkit a Beam Statements pénzügyi kimutatáskezelõ alkalmazásban. A program fõ célja, funkciója, hogy grafikusan, illetve listázva megmutassa az adott személynek / vállalatnak,
hogy az adott évben mennyit költött, mennyi pénzt keresett. A tranzakciókat bárhogyan el lehet nevezni, lényeg, hogy a kiadásokat a C:\temp\Incomes vagy C:\temp\Expenses mappába rakjuk,
hiszen innen tudja kiolvasni a szoftver az adatokat. A csv-knek szigorú formátumot kell követni: az "A" oszlopba kerül egy egész szám 1-12 között, ez lesz az adott hónap indexe, amikor
a tranzakció megtörtént. A második, "B" oszlopba kerülnek a bevétel, vagy kiadás típusai.
Ha bevételi csv-t csinálunk: 
1- Értékesítés
2- Pénzügyi
3- Egyéb
Ha kiadási csv-t csinálunk:
1 - Közvetlen
2 - Pénzügyi
3 - Adminisztratív
4 - Értékesítés
5 - Egyéb
A harmadik, azaz "C" oszlopba pedig az adott tranzakció értéke kerül.
Miután kitöltöttük a csv-t és elmentettük a megfelelõ helyre el is kezdhetjük használni az alkalmazást.
Az alkalmazás 2 fõ formból és egy kezdõlapból áll. 
A GraphView formban grafikus módon láthatjuk az adott hónapok tranzakcióit összegezve. Ha szeretnénk kitörölhetünk olyan hónapokat, amiket nem szeretnénk látni a checkedBoxList segítségével, 
valamint screenshotot is készíthetünk, ami a C:\temp mappába fog kerülni screenshot.png néven. Személyre is szabhatjuk az adott grafikont. 
A ListView formon listázva láthatjuk az adott hónap tranzakcióit. Ezen az oldalon már nem csak hónapokat, hanem tranzakció típusokat is törölhetünk az adott év listájából. 