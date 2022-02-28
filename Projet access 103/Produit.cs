using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Projet_access_103
{
   public  class Produit
    {
       private String _désignation;
       private Double _pu;
       private int _stock;

       private   Connexion con_produit;

       public Connexion Con_produit
       {
           get { return con_produit; }
      }

       public String Désignation
       {
           get { return _désignation; }
       }
       public int Stock 
       {
           get { return _stock ; }
       }
       public Double  Pu
       {
           get { return _pu; }
       }
       //pour le select: select * from produit
       public Produit(Connexion con_produit)
       {
           this.con_produit = con_produit;
       }
       //pour le delete: delete from produit where désignation=_désignation
       public Produit(Connexion con_produit, String _désignation)
       {
           this.con_produit = con_produit;
           this._désignation = _désignation;
       }
       //pour le insert et update: insert into produit values(_désignation,_pu,_stock)
       public Produit(Connexion con_produit, String _désignation, Double _pu, int _stock)
       {
           this.con_produit = con_produit;
           this._désignation = _désignation;
           this._pu = _pu;
           this._stock = _stock;

       }
       public DataTable Rechercher_par_désignation(String désignation_recherchée)
       {
           return con_produit.Executer_Liste("select * from produit where désignation like '"+désignation_recherchée +"%'");
       }
       public DataTable Rechercher_par_prix(Double prix1,Double prix2)
       {
           return con_produit.Executer_Liste("select * from produit where pu between " + prix1 + " and " + prix2 + "");
       }
       public DataTable lister()
       {
         return   con_produit.Executer_Liste("select * from produit");
       }

       public int Ajouter_un_produit()
       {
           if (Existence_Produit() == true)
               throw new Exception(" Ce produit existe ");
           else
           {
               // il faut remplacer , par . pour la conversion
               String prix = _pu.ToString().Replace(",", ".");
               con_produit.Executer("insert into table_statistique_mois(produit,mois,année,entré,sortie) values('" + _désignation + "'," + DateTime.Today.Month + "," + DateTime.Today.Year + "," + _stock + ",0)");
               return con_produit.Executer("insert into produit  values('" + _désignation + "', " + prix + "," + _stock + ")");
           }
       }
       //verifier si le produit existe
       public Boolean Existence_Produit()
       {

           if (con_produit.Executer_valeur("select count(*) from produit where Désignation='" + _désignation + "'") == "0")
               return false;
           else
               return true;
       }


       //verifier si le produit a des ventes
       public Boolean Existence_vente()
       {
          
           if (con_produit.Executer_valeur("select count(*) from produit_vendu where Désignation='" + _désignation + "'") == "0")
               return false;
           else
               return true;
       }

       public int  Supprimer_un_produit()
       {
           if (Existence_Produit() == false)
               throw new Exception("Ce produit n'existe pas");
           else
           {
               if (Existence_vente() == true)
                   throw new Exception("Ce produit ne peut être supprimé car il a des ventes");
               else
               {
                   con_produit.Executer("delete from table_statistique_mois where produit='" + _désignation + "'");
                   return con_produit.Executer("delete from produit  where Désignation='" + _désignation + "'");
               }
           }
           }

       public int Modifier_un_produit()
       {
           if (Existence_Produit() == false)
               throw new Exception("Ce produit n'existe pas");
           else
           {
               // il faut remplacer , par . pour la conversion
               String prix = _pu.ToString().Replace(",", ".");
               int ancien_stock = Rechercher_Stock_par_désignation();
               con_produit.Executer("insert into table_statistique_mois(produit,mois,année,entré,sortie) values('" + _désignation + "'," + DateTime.Today.Month + "," + DateTime.Today.Year + "," + _stock + ","+ancien_stock+")");
               return con_produit.Executer("update produit  set  pu= " + prix + ",stock=" + _stock + " where Désignation='" + _désignation + "'");
           }
              
       }
       //total des ventes du produit
       public Double Valeur_Stock_Produit()
       {
           String S = con_produit.Executer_valeur("select sum(pu*stock) from produit where Désignation='" + _désignation + "'");
           if (S == "")
               return 0;
           else
              return  Convert .ToDouble ( S);
       }

       //total des ventes du produit
       public Double Valeur_Stock_Globale()
       {
           String S = con_produit.Executer_valeur("select sum(pu*stock) from produit");
           if (S == "")
               return 0;
           else
               return Convert.ToDouble(S);
       }

       
       public Double Rechercher_Prix_par_désignation()
       {
         return Convert .ToDouble (  con_produit.Executer_valeur("select pu from produit where désignation='"+_désignation +"'"));
          
       }
       public int Rechercher_Stock_par_désignation()
       {
           return Convert.ToInt16(con_produit.Executer_valeur("select stock from produit where désignation='" + _désignation + "'"));

       }
    }
}
