README förComicWebStoreEXA

Grundläggande Webshop
Det går att se varor utan att logga in men om man försöker gå till Customer eller
Cart så kommer man att få ett felmeddelande.
Efter inloggning kan varor läggas i kundvagnen, går kunden till Cart ser man totalsumman
på varor och frakt (frakten räknas på 49kr i fast kostnad per fysisk vara och 0 kronor per digital vara).
Väljer man att genomföra köpet kontrolleras att kreditkort finns kopplat till kunden 
och om detta finns sparas ett kvitto med kvittonummer och information om ordern sparas till kunden.
Kunden kan gå till Customersidan för att se kunduppgifter samt tidigare genomförda ordrar.


För att använda Webshoppen finns följande användare färdiga som mockadata:

Todd McFarlane 
password: spawn
customer id: 100
    
Gary Larson
passsword: farside
customer id: 201

Bill Watterson 
password: calvinhobbes
customer id: 302
  
Stan Lee
password: spiderman
customer id: 403

Katsuhiro Otomo
password: akira
customer id: 504

Sergio Argones
password: groo
customer id: 605

*Backup CustomersJson.json finns under DataSource/JSONData/backup

*JSON path måste uppdateras på följande ställen:

	-DataAccess.DataAccess rad 134

	-DataSource.DataSource rad 18, rad 28, rad 36 och rad 42

