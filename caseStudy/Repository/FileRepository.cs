using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using caseStudy.Model;

namespace caseStudy.Infrastructure
{

     
    public class FileRepository
    {
        public static List<Festival> festivales;
        public List<Stock> TodoStock = new List<Stock>();
        public CompraResponse response = new CompraResponse();



        public Festival GetFestivalPorNombre(string nombre_festival)

        {
            Festival festival;
            CargarFestivales();
            festival = festivales.Find(festival => festival.Nombre == nombre_festival);
            return festival;


        }
                 
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

        public void CargarFestivales()
        {
          
                var jsonString = File.ReadAllText("festivales.json");
                festivales = JsonSerializer.Deserialize<List<Festival>>(jsonString);
        }

        public Boolean FestivalesVacio()
        {
            if (festivales == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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
