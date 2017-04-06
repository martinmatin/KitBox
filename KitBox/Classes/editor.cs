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
            string txt_missing ="missing" + ".txt";
            string txt_inside = "";

            File.WriteAllText(txt_missing, "");

            foreach (var item in missingPieces)
            {
                txt_inside += " - " + (item.Key) + " - " + (item.Value) + "\r\n";
            }
            File.WriteAllText(txt_missing, txt_inside);
            
        }

        public void printBill(Dictionary<string,string> infos, Dictionary<string, int> pieceManquante, Dictionary<string , int> pieceDisponible)
        {


            string content_client = "\r\n"
                        + "CLIENT"
                        + "\r\n"
                        + infos["date"]
                        + "\r\n\r\n\r\n"
                        + "______________________________________________________________"
                        + "\r\n\r\n"
                        + "                        BON DE COMMANDE                      "
                        + "\r\n"
                        + "______________________________________________________________"
                        + "\r\n\r\n\r\n"
                        + "Nom du client:  " + infos["nom"]
                        + "\r\n\r\n"
                        + "Numéro de commande:  " + infos["num"]
                        + "\r\n\r\n"
                        + "Prix:  " + infos["prix"]
                        + "\r\n\r\n"
                        + "Etat de la commande:  " + infos["etat"]
                        + "\r\n\r\n"
                        + "_____________________________________________________________"
                        + "\r\n\r\n\r\n"
                        + "Signature vendeur:                   Signature client: ";


            string txt_client = "valid1.txt";

            File.WriteAllText(txt_client, content_client);




            string content_magasin = "\r\n"
                        + "MAGASIN"
                        + "\r\n"
                        + infos["date"]
                        + "\r\n\r\n\r\n"
                        + "_____________________________________________________________"
                        + "\r\n\r\n"
                        + "                        BON DE COMMANDE                     "
                        + "\r\n"
                        + "_____________________________________________________________"
                        + "\r\n\r\n\r\n"
                        + "Nom du client:  " + infos["nom"]
                        + "\r\n\r\n"
                        + "Identifiant du client:  " + infos["id"]
                        + "\r\n\r\n"
                        + "Numéro de commande:  " + infos["num"]
                        + "\r\n\r\n"
                        + "Prix:  " + infos["prix"]
                        + "\r\n\r\n";


            content_magasin += "_____________________________________________________________"
                              + "\r\n"
                              + "                        Pièces disponibles                   "
                              + "\r\n"
                              + "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯"
                              + "\r\n";
            foreach (var item in pieceDisponible)
            {



                content_magasin += " - " + (item.Key) + " - " + (item.Value) + "\r\n";
            }


            content_magasin += "_____________________________________________________________"
                              + "\r\n"
                              + "                        Pièces manquantes                    "
                              + "\r\n"
                              + "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯"
                              + "\r\n";
            foreach (var item in pieceManquante)
            {

                content_magasin += " - " + (item.Key) + " - " + (item.Value) + "\r\n";
            }



            string txt_magasin = "valid2.txt";
            File.WriteAllText(txt_magasin, content_magasin);


        }
    }

        
}
