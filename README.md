# ApiFestivales
Api simple para organizar los carteles, la compra de entradas y el stock de diferentes festivales.

-Para probar la API:
  1. Arrancar el proyecto.
  2. Abrir Postman o herramienta similar para testear ApiRests.
  3. Para lanzar las llamadas:
        
3.1 (GET) ~{localDomain}/cartel/{nombre_festival}. Ejemplo: http://localhost:5002/Cartel/Lollapalooza
        Resultado:
        {
    "nombre": "Lollapalooza",
    "artistas": [
        {
            "nombre": "Mariana Grande",
            "estiloMusical": "Electronica",
            "solista": true
        },
        {
            "nombre": "The Painsmokers",
            "estiloMusical": "Rock",
            "solista": false
        },
        {
            "nombre": "Melena Gomez",
            "estiloMusical": "Rock",
            "solista": true
        }
    ],
    "precio": 200,
    "cantidad": 1350
    }
 3.2 (GET) ~{localDomain}/stock. Ejemplo: http://localhost:5002/Stock
    Resultado: 
    [
    {
        "nombreFestival": "Tomorrowland",
        "precioActual": 200,
        "cantidadRestante": 1350,
        "costeSiguienteBloque": 600
    },
    {
        "nombreFestival": "Lollapalooza",
        "precioActual": 200,
        "cantidadRestante": 1350,
        "costeSiguienteBloque": 600
    },
    {
        "nombreFestival": "Festival Paco",
        "precioActual": 200,
        "cantidadRestante": 1350,
        "costeSiguienteBloque": 600
    }
]
    
3.3 (POST){localDomain}/comprar. Ejemplo: http://localhost:5002/Comprar. Un ejemplo de body seria:
  <?xml version = "1.0" encoding = "UTF-8"?>
<CompraRequest>
	<Festival>Tomorrowland</Festival>
	<Entradas>151</Entradas> 
</CompraRequest>
Resultado: 
{
    "costeTotal": 54360,
    "fechaCompra": "2020-02-20T19:45:17.857874+01:00"
}

