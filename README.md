## Oppgave: Studentadministrasjonssystem ##
Din oppgave er å utvikle et enkelt studentadministrasjonssystem i C# ved hjelp av grunnleggende objektorienteringsprinsipper.

### Del 1: Klasser og Objekter ###
Lag følgende klasser:

Student:

Egenskaper: Navn, Alder, Studieprogram, StudentID.
Metode: SkrivUtInfo() som skriver ut informasjon om studenten.

Fag:

Egenskaper: Fagkode, Fagnavn, AntallStudiepoeng.
Metode: SkrivUtInfo() som skriver ut informasjon om faget.

Karakter:

Egenskaper: Student (referanse til en Student), Fag (referanse til et Fag), Karakterverdi.
Metode: SkrivUtInfo() som skriver ut informasjon om karakteren.


### Del 2: Hovedprogram (Main) ###
I hovedprogrammet, gjør følgende:

Opprett minst to instanser av hver klasse (Student, Fag, Karakter).
Sett verdier for egenskapene.
Kall SkrivUtInfo()-metoden for hver klasse for å skrive ut informasjonen.


### Del 3: Ekstra funksjonalitet ###
Legg til flere fag:

Opprett en liste av fag og legg til minst tre forskjellige fag.
Legg til disse fagene i Student-objektene som studentene tar.

Legg til karakterer:

Legg til karakterer for studentene i de forskjellige fagene de tar.
Skriv ut karakterinformasjonen.

Gjennomsnittskarakter:

Implementer en metode i Student-klassen som beregner gjennomsnittskarakteren for studenten basert på karakterene de har fått.

Studiepoeng:

Implementer en metode i Student-klassen som beregner totalt antall studiepoeng basert på fagene studenten tar.