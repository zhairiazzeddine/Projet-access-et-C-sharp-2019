using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Projet_access_103
{
   public  class Client
    {
        private String _code;
       private String _nom;
       private String _prénom;

       private   Connexion con_client;

       public Connexion Con_client
       {
           get { return con_client; }
      }
       public String  Code
       {
           get { return _code ; }
       }
       //pour le select: select * from client
       public Client(Connexion con_client)
       {
           this.con_client = con_client;
       }
       //pour le delete: delete from client where désignation=_code
       public Client(Connexion con_client, String _code)
       {
           this.con_client = con_client;
           this._code = _code;
       }
       //pour le insert et update: insert into client values(_code,_nom,_prénom)
       public Client(Connexion con_client, String _code, String _nom, String _prénom)
       {
           this.con_client = con_client;
           this._code = _code;
           this._nom = _nom;
           this._prénom = _prénom;

       }
       public DataTable Rechercher_par_nom(String nom_recherché)
       {
           return con_client.Executer_Liste("select * from client where nom like '"+nom_recherché +"%'");
       }
     
       public DataTable lister()
       {
         return   con_client.Executer_Liste("select * from client");
       }

       public int Ajouter_un_client()
       {
           if (Existence_client() == true)
               throw new Exception(" Ce client existe ");
           else
           {
                return con_client.Executer("insert into client  values('" + _code + "', '" + _nom + "','" + _prénom + "')");
           }
       }
       //verifier si le client existe
       public Boolean Existence_client()
       {

           if (con_client.Executer_valeur("select count(*) from client where code='" + _code + "'") == "0")
               return false;
           else
               return true;
       }


       //verifier si le client a des ventes
       public Boolean Existence_vente()
       {
          
           if (con_client.Executer_valeur("select count(*) from vente where code_client='" + _code + "'") == "0")
               return false;
           else
               return true;
       }

       public int  Supprimer_un_client()
       {
           if (Existence_client() == false)
               throw new Exception("Ce client n'existe pas");
           else
           {
               if (Existence_vente() == true)
                   throw new Exception("Ce client ne peut être supprimé car il a des ventes");
               else
                   return con_client.Executer("delete from client  where code='" + _code + "'");
           }
           }

       public int Modifier_un_client()
       {
           if (Existence_client() == false)
               throw new Exception("Ce client n'existe pas");
           else
           {
             
               return con_client.Executer("update client  set  nom= '" + _nom + "',prénom='" + _prénom + "' where code='" + _code + "'");
           }
        }

       public DataTable  Information_client()
       {
           return con_client.Executer_Liste("select code+' & '+nom+' & '+prénom as identif from client");
       }
       public String Renvoyer_Code_client(String identification)
       {
           return con_client.Executer_valeur("select code from client where code+' & '+nom+' & '+prénom='"+identification+"'");
       }
    }
}
