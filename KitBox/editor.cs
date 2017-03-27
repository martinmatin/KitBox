using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KitBox
{
    class editor
    {
        public editor()
        {

        }

        public void printMissing(Dictionary<string, int> missingPieces)
        {

        }

        public void printBill(Dictionary<string,string> infos, TupleList<int, string> pieceManquante, TupleList<int, string> pieceDisponible)
        {
            /////////////////////    CODE        ///////////////

            string content_client = "\r\n"
                        + "CLIENT"
                        + "\r\n"
                        + infos["date"]
                        + "\r\n\r\n\r\n"
                        + "___________________________________________________________________"
                        + "\r\n\r\n"
                        + "                          BON DE COMMANDE                          "
                        + "\r\n"
                        + "___________________________________________________________________"
                        + "\r\n\r\n\r\n"
                        + "Nom du client:  " + infos["nom"]
                        + "\r\n\r\n"
                        + "Numéro de commande:  " + infos["num"]
                        + "\r\n\r\n"
                        + "Prix:  " + infos["prix"]
                        + "\r\n\r\n"
                        + "Etat de la commande:  " + infos["etat"]
                        + "\r\n\r\n"
                        + "___________________________________________________________________"
                        + "\r\n\r\n\r\n"
                        + "Signature vendeur:                   Signature client: ";


            string txt_client = infos["num"] + "_client" + ".txt";

            File.WriteAllText(txt_client, content_client);




            string content_magasin = "\r\n"
                        + "MAGASIN"
                        + "\r\n"
                        + infos["date"]
                        + "\r\n\r\n\r\n"
                        + "___________________________________________________________________"
                        + "\r\n\r\n"
                        + "                          BON DE COMMANDE                          "
                        + "\r\n"
                        + "___________________________________________________________________"
                        + "\r\n\r\n\r\n"
                        + "Nom du client:  " + infos["nom"]
                        + "\r\n\r\n"
                        + "Identifiant du client:  " + infos["id"]
                        + "\r\n\r\n"
                        + "Numéro de commande:  " + infos["num"]
                        + "\r\n\r\n"
                        + "Prix:  " + infos["prix"]
                        + "\r\n\r\n";


            content_magasin += "___________________________________________________________________"
                              + "\r\n"
                              + "                         Pièces disponibles                        "
                              + "\r\n"
                              + "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯"
                              + "\r\n";
            foreach (Tuple<int, String> element in pieceDisponible)
            {

                content_magasin += " - " + (element.Item2) + " - " + (element.Item1) + "\r\n";
            }


            content_magasin += "___________________________________________________________________"
                              + "\r\n"
                              + "                         Pièces manquantes                        "
                              + "\r\n"
                              + "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯"
                              + "\r\n";
            foreach (Tuple<int, String> element in pieceManquante)
            {

                content_magasin += " - " + (element.Item2) + " - " + (element.Item1) + "\r\n";
            }



            string txt_magasin = infos["num"] + "_magasin" + ".txt";

            File.WriteAllText(txt_magasin, content_magasin);


        }

        /////////////////////CLASSE POUR CONSTRUIRE LES TUPLES PROPREMENT///////////////
        public class TupleList<T1, T2> : List<Tuple<T1, T2>>
        {
            public void Add(T1 item, T2 item2)
            {
                Add(new Tuple<T1, T2>(item, item2));
            }
        }
    }
}
