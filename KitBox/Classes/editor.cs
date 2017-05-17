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
        public editor() { }

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

        public void PrintBill(Dictionary<string,string> infos, Dictionary<string, int> unavailabePiece, Dictionary<string , int> availabePiece)
        {
            string contentClient = "\r\n"
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
                        + "Numéro de commande:  " + infos["id"]
                        + "\r\n\r\n"
                        + "Prix:  " + infos["prix"]
                        + "\r\n\r\n"
                        + "_____________________________________________________________"
                        + "\r\n\r\n\r\n"
                        + "Signature vendeur:                   Signature client: ";

            string txt_client = "valid_client_"+infos["id"]+".txt";
            File.WriteAllText(txt_client, contentClient);

            string contentStore = "\r\n"
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
                        + "Email du client:  " + infos["num"]
                        + "\r\n\r\n"
                        + "Numéro de commande:  " + infos["id"]
                        + "\r\n\r\n"
                        + "Prix:  " + infos["prix"]
                        + "\r\n\r\n";

            contentStore += "_____________________________________________________________"
                              + "\r\n"
                              + "                        Pièces disponibles                   "
                              + "\r\n"
                              + "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯"
                              + "\r\n";

            foreach (var item in availabePiece)
            {



                contentStore += " - " + (item.Key) + " - " + (item.Value) + "\r\n";
            }

            contentStore += "_____________________________________________________________"
                              + "\r\n"
                              + "                        Pièces manquantes                    "
                              + "\r\n"
                              + "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯"
                              + "\r\n";

            foreach (var item in unavailabePiece)
            {

                contentStore += " - " + (item.Key) + " - " + (item.Value) + "\r\n";
            }
            string txt_magasin = "valid_magasin_"+infos["id"]+".txt";
            File.WriteAllText(txt_magasin, contentStore);
        }
    }     
}