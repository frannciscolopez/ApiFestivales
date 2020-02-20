using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using caseStudy.Model;

namespace caseStudy.Infrastructure
{


    public class FileRepository
    {
        public static List<Festival> festivales;
        public List<Stock> TodoStock = new List<Stock>();
        public CompraResponse response = new CompraResponse();


        /// <summary>
        /// A partir de un nombre de un festival, te coge
        /// todos los datos del festival de entre todos los festivales
        /// </summary>
        /// <param name="nombre_festival"></param>
        /// <returns></returns>
        public Festival GetFestivalPorNombre(string nombre_festival)

        {
            Festival festival;
            CargarFestivales();
            festival = festivales.Find(festival => festival.Nombre == nombre_festival);
            return festival;


        }
        /// <summary>
        /// A partir de la petición de compra, se devuelve la respuesta
        /// actualizando la cantidad tontal de entradas y calculando el precio de
        /// las entradas compradas
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CompraResponse GetResponse(CompraRequest request)
        {

            Festival festivalCompra;
            if (FestivalesVacio())
            {
                CargarFestivales();
            }
            festivalCompra = GetFestivalPorNombre(request.Festival);
            foreach (var festival in festivales)
            {
                if (festival.Nombre == festivalCompra.Nombre)
                {
                    festival.Cantidad = (festivalCompra.Cantidad - request.Entradas);
                }
            }
            response.CosteTotal = (festivalCompra.Precio * request.Entradas);
            return response;

        }
        /// <summary>
        /// Devuelve el stock de todos los festivales.
        /// </summary>
        /// <returns></returns>
        public List<Stock> GetStock()
        {
            Stock stock;
            if (FestivalesVacio())
            {
                CargarFestivales();
            }
            foreach (var festival in festivales)
            {
                stock = new Stock();
                stock.NombreFestival = festival.Nombre;
                stock.PrecioActual = festival.Precio;
                stock.CantidadRestante = festival.Cantidad;
                stock.CosteSiguienteBloque = getCosteSiguienteBloque(festival.Precio);
                TodoStock.Add(stock);
            }
            return TodoStock;
        }

        /// <summary>
        /// Si los festivales no están cargados del archivo en la lista,
        /// se cargan.
        /// </summary>
        public void CargarFestivales()
        {

            var jsonString = File.ReadAllText("festivales.txt");
            festivales = JsonSerializer.Deserialize<List<Festival>>(jsonString);
        }

        public Boolean FestivalesVacio()
        {
            return festivales == null;
        }
        /// <summary>
        /// Calcula el precio del siguiente bloque de datos
        /// </summary>
        /// <param name="PrecioActual"></param>
        /// <returns></returns>
        public int getCosteSiguienteBloque(int PrecioActual)
        {
            if (PrecioActual == 200)
            {
                return 600;
            }
            else
            {
                return 1000;
            }

        }



    }
}
