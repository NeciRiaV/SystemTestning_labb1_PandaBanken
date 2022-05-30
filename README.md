# Planera tester

### Test 1 - Överföring mellan användare
Om det finns två användare med samma namn, kan programmet inte säkerställa vilken användare som överföringen ska till.

### Test 2 - Valuta ändring
Om värdet på en bara en valuta ändras, kollapsar hela räkningen, då den inte längre får in rätt räkningar. Samma händer om minsta siffra blir fel.

### Test 3 - Insättning och uttag
Om man lägger in 50 USD på ett konto som hanterar SEK, får man automatiskt in 50 SEK istället drygt 500 SEK. Samma sker med uttag.
