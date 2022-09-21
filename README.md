# ComicWebstoreExa
README för ComicWebstoreExa



Simple web shop
You can put items in the cart without logging in but if you try to go to the customer page or the cart you will get an error message.
When logged din you can put items in the cart, the cart will update with sum total + shipping (calculated as SEK49 for physical goods and SEK0 for digital).
Upon checkout a payment method (credit card) must exist for the logged in customer and if it goes through a reciept with information on the order plus payment details will be saved to the customer. The customer page displays previous orders and customers info.

There are no cookies and to make it all work I built a separate class to save which customer is logged in and cart info to easily move that infom between pages (I write this ReadMe about a year later and I realize that it´s not the best solution but it works in this context).

To use the webshop there are the following mock data users:

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

*Backup CustomersJson.json is under DataSource/JSONData/backup

*JSON path must be manually updated in the follosing places:

	-DataAccess.DataAccess rad 134

	-DataSource.DataSource rad 18, rad 28, rad 36 och rad 42
