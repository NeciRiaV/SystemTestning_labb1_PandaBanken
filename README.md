# Planera tester

### Test 1 - Överföring mellan konton
Finns ingen try-catch för att fånga upp om 2 konton delar namn, betydande, transaktionen kommer gå igenom, dock kommer den alltid att välja det kontot som håller första platsen på listan. 
Finns heller ingen try-catch för att stoppa att samma konto väljs igen. Så om man skulle överföra från konto "Spar" till konto "Spar", kommer testet att gå igenom. 


### Test 2 - Uttag
Test för att dubbelkolla så att man inte kan dra ut mer pengar än befinnande från konton. 


### Test 3 - Insättning
Finns ingen try-catch eller if-sats som begränsar minst antal peng som kan läggas in på kontot. Så vill man lägga in en krona funkar det. Funktionella banker har ett minsta belopp av 100 kr. 
