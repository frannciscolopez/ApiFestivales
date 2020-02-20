using System.Collections.Generic;

namespace caseStudy
{
    public class Festival
    {
        public string Nombre { get; set; }

        public IList<Artista> Artistas { get; set; }

        public int Precio
        {
            get
            {

                if (Cantidad > 1200)
                {
                    return 200;
                }
                else if (Cantidad > 1000)
                {

                    return 360;
                }
                return 500;

            }


            set { }
        }

        public int Cantidad { get; set; }


    }
}
