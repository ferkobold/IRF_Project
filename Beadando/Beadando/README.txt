�dv�zl�k mindenkit a Beam Statements p�nz�gyi kimutat�skezel� alkalmaz�sban. A program f� c�lja, funkci�ja, hogy grafikusan, illetve list�zva megmutassa az adott szem�lynek / v�llalatnak,
hogy az adott �vben mennyit k�lt�tt, mennyi p�nzt keresett. A tranzakci�kat tartalmaz� csv f�jlt b�rhogyan el lehet nevezni, l�nyeg, hogy a bev�teleket a C:\temp\Incomes,
a kiad�sokat C:\temp\Expenses mapp�ba rakjuk, hiszen innen tudja kiolvasni a szoftver az adatokat. 
A solutionben van egy mappa "CSVs" n�ven, ebben bennevan 2-2 p�lda csv. Ha a mapp�ban l�v� 2 mapp�t: Incomes, Expenses betessz�k a C:\temp -be m�r m�k�dni is fog.
A csv-knek szigor� form�tumot kell k�vetni:
az "A" oszlopba ker�l egy eg�sz sz�m 1-12 k�z�tt, ez lesz az adott h�nap indexe, amikor a tranzakci� megt�rt�nt. 
A m�sodik, "B" oszlopba ker�lnek a bev�tel, vagy kiad�s t�pusai.
Ha bev�teli csv-t csin�lunk: 
1 - �rt�kes�t�s
2 - P�nz�gyi
3 - Egy�b
Ha kiad�si csv-t csin�lunk:
1 - K�zvetlen
2 - P�nz�gyi
3 - Adminisztrat�v
4 - �rt�kes�t�s
5 - Egy�b
A harmadik, azaz "C" oszlopba pedig az adott tranzakci� �rt�ke ker�l.
Miut�n kit�lt�tt�k a csv-t �s elmentett�k a megfelel� helyre el is kezdhetj�k haszn�lni az alkalmaz�st.
Az alkalmaz�s 2 f� formb�l �s egy kezd�lapb�l �ll. 
A GraphView formban grafikus m�don l�thatjuk az adott �vek tranzakci�it �sszegezve. Ha szeretn�nk kit�r�lhet�nk olyan h�napokat, amiket nem szeretn�nk l�tni a checkedBoxList seg�ts�g�vel, 
valamint screenshotot is k�sz�thet�nk, ami a C:\temp mapp�ba fog ker�lni screenshot.png n�ven. Szem�lyre is szabhatjuk az adott grafikont. 
A ListView formon list�zva l�thatjuk az adott �v tranzakci�it. Ezen az oldalon m�r nem csak h�napokat, hanem tranzakci� t�pusokat is t�r�lhet�nk az adott �v list�j�b�l. 