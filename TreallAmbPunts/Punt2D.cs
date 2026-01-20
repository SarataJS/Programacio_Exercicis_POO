using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Punt2D
    {
        //Afegir atribut gruix (pot valer un valor major o igual que zero)
        #region atributs
        private double x;
        private double y;
        private int gruix;
        #endregion

        public Punt2D(double x, double y)
        {
            int z = 0;
            this.x = x;
            this.y = y;
            this.gruix = z;
            if (gruix < 0)
            {
                throw new Exception("EL GRUIX NO POT SER NEGATIU");
            }
            
            #region constructors
            // 1-modificar els contructors per poder donar gruix (int) a un punt
            // i fer saltar ArgumentException si el gruix es negatiu
            // MODIFICAR LES PROVES DEL MAIN
            // 2-Modificar el ToString per tal que es monstri (x,y): gurix per exemple: (4,2):1
            // COMPROVAR QUE EL TOSTRING TAMBE DONA EL GRUIX
            // 3-Afegir les propietats Y i Gruix pero gruix nomes de lectura
            // AFEGIR LES PROVES DLE MAIN PER LES PROPIETATS Y I Gruix
            // 4-Afegir metodes d'instància 
            // public bool IncrementaGruix()
            // que augmenta una unitat el gruix del punt
            // public bool DecrementaGruix()
            // que decrementa una unitat el gruix del punt si el gruix es major o igual que 1
            // retorna true si s'ha pogut decrementar 
            // AFEGIR LES PROVES AL MAIN DELS METODES IncrementaGruix i DecrementaGruix
            // 5-Escriu la propietat Modul (distancia de (0,0) fins al punt this.) (aquest no es pot fer set nomes get)
            // Per fer aquest exercici usar una crida al mètode Punt2D.Distancia
            // CRIDAR A LA PROPIETAT MODUL DELS 10 PUNTS DE L'ARRAY DE PUNTS DEL MAIN
        }
        public Punt2D():this(0,0)
        {

        }
        #endregion

        #region sobreescriptures

        public override string ToString()
        {
            String puntStr;
            StringBuilder punt = new StringBuilder();
            punt.Append("(");
            punt.Append(this.x);
            punt.Append(",");
            punt.Append(this.y);
            punt.Append(")");
            punt.Append(":");
            punt.Append(this.gruix);
            puntStr = punt.ToString();
            return puntStr;
        }
        #endregion

        #region metodes d'instancia 
        //es d'instancia perque no es estàtic

        public void Desplaça(double moveX, double moveY)
        {
            this.x = this.x + moveX;
            this.y = this.y + moveY;
        }

        public bool IncrementaGruix(int gruix)
        {
            if (gruix = 0)
            {
                gruix++;
            }
            
        }

        #endregion

        #region metodes estatics (tamb es diuen metodes de classe-pertanyen a una classe-)

        public static double Distancia(Punt2D primerPunt, Punt2D segonPunt)
        {
            double distancia = Math.Sqrt(Math.Pow(primerPunt.x - segonPunt.x, 2) + Math.Pow(primerPunt.y - segonPunt.y, 2));
            return distancia;
        }

        #endregion

        #region propietats
        //les propietats no tenen parametres
        public double X
        {
            //aqui es pot posar el control sobre quina manera es programa
            get //propietat lectura, en alguns casos nomes pot ser de lectura (o sigui, sense set)
            { 
                return this.x; 
            }
            set //propietat escriptura, value:el que ve de l'assignacio, si en el value posem +1 farem que aquest valor incrementi +1 (encara que en el Main no es pugui veure). Per aixo el programador te el control (pot posar resticcions, etc) 
            {
                // if (value < 0) throw new exception console.writeline("No et deixo posar negatius");
                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
        }

        public int Gruix
        {
            get
            {
                return this.gruix;
            }
        }
        
        #endregion

    }
}
