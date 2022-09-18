# Festivals API
Simple api to organize the posters, the purchase of tickets and the stock of different festivals.

### How to test
 
 
 1. CREATE NEW FESTIVAL.
 ### REQUEST (GET)
 
 http://localhost:5002/Cartel/{festivalName}
 
 2. RETURN THE STOCK OF TICKETS.
 ### REQUEST (GET)
 
 http://localhost:5002/Stock 
 
 3. BUY A TICKET.
 ### REQUEST (GET)
 
 http://localhost:5002/Comprar

BODY:

```
 {
<CompraRequest>
	<Festival>{festivalName}</Festival>
	<Entradas>{numberOfTickets}</Entradas> 
</CompraRequest>
}
```

### RESPONSE 
```
{
    "costeTotal": 54360,
    "fechaCompra": "2020-02-20T19:45:17.857874+01:00"
}
```

