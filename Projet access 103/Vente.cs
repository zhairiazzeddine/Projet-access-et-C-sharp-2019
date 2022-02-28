using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data ;
namespace Projet_access_103
{
    public   class Vente
    {
          private int _nvente;// compteur access
          private DateTime _datevente;
          private Client _client;

          private Connexion con_vente;

          public int Nvente
          {
              get { return _nvente; }
          }
          public DateTime  Date_Vente
          {
              get { return _datevente ; }
          }
          public Vente(Connexion con_vente)
          {
              this.con_vente = con_vente;
          }

          public Vente(Connexion con_vente, int _nvente)
          {
              this._nvente = _nvente;
              this.con_vente = con_vente;
          }      
       public Vente(Connexion con_vente, int _nvente,DateTime _datevente, Client _client)
       {          
              this._nvente = _nvente;
             this ._datevente=_datevente ;
              this ._client =_client ;
              this.con_vente = con_vente;
       }
       public Vente(Connexion con_vente, int _nvente, DateTime _datevente)
       {
           this._nvente = _nvente;
           this._datevente = _datevente;
          this.con_vente = con_vente;
       }
   
       public DataTable Rechercher_par_code_client(String  code_client)
       {
           return con_vente.Executer_Liste("select * from vente where code_client = '"+code_client +"'");
       }
        //  03/09/2020
       public DataTable Rechercher_par_dates(DateTime  date1,DateTime  date2)
       {
           String sdate1 = date1.ToString().Substring(3, 2) + "/" + date1.ToString().Substring(0, 2) + "/" + date1.ToString().Substring(6, 4);
           String sdate2 = date2.ToString().Substring(3, 2) + "/" + date2.ToString().Substring(0, 2) + "/" + date2.ToString().Substring(6, 4);

           return con_vente.Executer_Liste("select * from vente where date_vente between #" + sdate1 + "# and #" + sdate2 + "#");
       }
       public DataTable lister()
       {
         return   con_vente.Executer_Liste("select * from vente");
       }
        //on n'ajoute pas une vente pour un client qui n'existe pas
       public int Ajouter_une_vente()
       {
           if (_client.Existence_client()==false  )
               throw new Exception(" Ce client n'existe pas  ");
           else
           {
                  return con_vente.Executer("insert into vente(date_vente,code_client)  values('" + _datevente  + "','" + _client .Code + "')");
           }
       }
       
       //verifier si la vente a des produits vendues
        //on supprime pas une vente qui contient des produits
       public Boolean Existence_Prduit_vendu()
       {
          
           if (con_vente.Executer_valeur("select count(*) from produit_vendu where nvente=" + _nvente  + "") == "0")
               return false;
           else
               return true;
       }

       public int  Supprimer_une_vente()
       {        
               if ( Existence_Prduit_vendu() == true)
                   throw new Exception("Cette vente ne peut être supprimée car il contient des produits");
               else
                   return con_vente.Executer("delete from vente   where nvente=" + _nvente  + "") ;
        }

       public int Modifier_une_vente()
       {
                 return con_vente.Executer("update vente  set  date_vente= '" + _datevente + "' where nvente=" + _nvente  + "") ;
           
        }

       public int Numvente()//compteur
       {
           if (con_vente.Executer_valeur("SELECT count(*) FROM vente") == "0")//si la table est vide
               return 1;
           else
              return   Convert.ToInt16(con_vente.Executer_valeur("SELECT max(nvente)+1 FROM vente"));
       }
       public DateTime  Rechercher_Date_Vente()//compteur
       {
            return Convert.ToDateTime( con_vente.Executer_valeur("SELECT date_vente FROM vente where nvente=" + _nvente  + "") );
            
       }
       public String  Rechercher_Client_Vente()//compteur
       {
           return con_vente.Executer_valeur("SELECT code_client FROM vente where nvente=" + _nvente + "");

       }
    }
}
