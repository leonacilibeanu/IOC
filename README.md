IOC - Etapa 3 Proiect

Echipa Next: 	Bejgu Andreea
				Cilibeanu Leona
				Sevastian Emma
Grupa 341C4
-------------------------------


GiftPlanner

Libaje de programare:
	-	Aplicatia este implementata in C# (folosind Visual C# 2010) (partea de Server, Client si Interfata grafica),
	iar baza de date a fost implementata in MySql (folosind conectorii din C#).

Implementare:
	- Proiectul este o aplicatie client-server prin care se stocheaza datele aferente intr-o baze de date 
	(Database.mdf) la care accesul se face prin intermediul Serverului.

Server:
	-	Modulul are rolul de a pastra informatii despre toti utilizatorii activi precum si de a pastra si 
	gestiona o baza de date cu informatii despre toti utilizatorii din sistem. 
	-	Toti clientii activi vor trebuii sa fie conectati la un server pentru a putea sa functioneze. 
	-	Serverul poate comunica cu toti clientii conectati.
	-	Modulul server este o clasa care contine metode necesare pentru a stabili conexiuni cu clienti noi si de a raspunde la cererile acestora. 
	-	Serverul are o lista de conexiuni active. 	
	-	El are o conexiune pe care asculta noi cereri de la clienti care vor sa se conecteze. 
	-	Cand primeste o cerere de conectare, serverul va stabili o noua conexiune cu un client, 
		conexiune care va fi valabila pe durata intregii sesiuni si care este folosita pentru a 
		primi cereri de la client si a trimite raspunsuri, precum si pentru update-uri periodice. 
	-	Aceste conexiuni sunt inchise numai daca clientul se delogheaza.

Baza de Date:
	-	Acest modul are rolul de a gestiona baza de date a serverului, baza de date care contine 
		informatii despre utilizatori si parole, precum si profilurile si listele de prieteni si de grupuri ale utilizatorilor.
	-	Acest modul este o clasa care contine metode pentru a gestiona o baza de date SQL. 
	-	La prima initializare a serverului se va crea aceasta baza de date, urmand ca aceasta sa fie completata cu date 
		de catre utilizatori pe parcursul rularii serverului. Informatiile sunt modificate pe baza comenzilor dare de catre server,
		comenzi care sunt primite da catre acesta de la clienti. 
	-	Baza de date pastraza informatiile chiar si daca serverul este repornit si poate de asemenea fi copiata in caz ca serverul
		trebuie mutat. Modulul ofera un set de metode pentru a modifica corespunzator datele pentru fiecare utilizator.

Client:
	-	Acest modul are rolul de a trimite si primi mesaje de la server, clientul si serverul fiind pe calculatoare 
		diferite (sau procese independente pe acelasi calculator). El trimite mesajele in functie de comenzile date de 
		utilizator prin intermediul interfetei grafice.
	-	Modulul client este o clasa care contine metode necesare pentru a comunica cu serverul si cu alti clienti. 
	-	O clasa client contine implicit o clasa UserInterface asociata. Cele doua ruleaza in cadrul aceluiasi program, dar in threaduri diferite.

Clientul foloseste Interfata Grafica pentru a edita profiluri, 
		a adauga evenimente sau pentru a putea vedea evenimentele la care a fost invitat. 
Pentru fiecare eveniment exista o lista de cadouri si invitati, posibilitatea crearii de grupuri si editarii cadourilor.

Interfata Grafica:
	- este user-friendly
	- va fi prezentata mai pe larg in Prezentare.ppt
