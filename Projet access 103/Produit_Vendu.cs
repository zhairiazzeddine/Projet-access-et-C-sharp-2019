using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Projet_access_103
{
   public  class Produit_Vendu
    {
       private Produit _produit;
       private Vente _vente;
       private int _qté;

        private Connexion con_produit_vente;

        public Produit_Vendu(Connexion con_produit_vente)
          {
              this.con_produit_vente = con_produit_vente;
          }
        public Produit_Vendu(Connexion con_produit_vente,  Vente _vente)
        {      
            this._vente = _vente;
            this.con_produit_vente = con_produit_vente;
        }
        public Produit_Vendu(Connexion con_produit_vente, Produit _produit, Vente _vente)
          {
              this._produit = _produit;
              this._vente = _vente;
              this.con_produit_vente = con_produit_vente;
          }
        public Produit_Vendu(Connexion con_produit_vente, Produit  _produit, Vente _vente, int _qté)
          {
              this._produit = _produit;
              this._vente = _vente;
              this.con_produit_vente = con_produit_vente;
              this._qté = _qté;
          }      
      
   
       public DataTable lister()
       {
           return con_produit_vente.Executer_Liste("select * from produit_Vendu");
       }
       public int Diminuer_Stock_produit_vendu()
       {      

           return con_produit_vente.Executer("update produit  set  stock=stock-" + _qté  + " where Désignation='" + _produit .Désignation + "'");
       }
       public int Ajouter_au_Stock_produit_vendu()
       {

           return con_produit_vente.Executer("update produit  set  stock=stock-" + _qté + " where Désignation='" + _produit.Désignation + "'");
       }
        //on n'ajoute pas une produit_Vendu pour un client qui n'existe pas
       public int Ajouter_un_produit_a_une_vente()
       {
           if (_produit.Existence_Produit() == false)
               throw new Exception(" Ce produit existe n'existe pas dans produit ");
           else
           {
               if (_produit.Stock < _qté)
                   throw new Exception(" le stock est insuffisant ");
               else
               {
                   if (Existence_Produit_vendu() == true )
                       throw new Exception(" Ce produit existe déjà dans cette vente ");
                   else
                   {
                       Diminuer_Stock_produit_vendu();
                       con_produit_vente.Executer("insert into table_statistique_mois(produit,mois,année,entré,sortie) values('" + _produit.Désignation + "'," + _vente.Date_Vente.Month + "," + _vente.Date_Vente.Year + ",0," + _qté + ")");
                       return con_produit_vente.Executer("insert into produit_Vendu values('" + _produit.Désignation + "'," + _vente.Nvente + "," + _qté + ")");

                      
                   }
               }
           }
       }
       
       //verifier si le produit figure déjà dans la vente
       public Boolean Existence_Produit_vendu()
       {
           if (con_produit_vente.Executer_valeur("select count(*) from produit_vendu where désignation='" + _produit.Désignation + "' and nvente= " + _vente.Nvente + "") == "0")
               return false;
           else
               return true;
       }

       public int  Supprimer_un_produit_d_une_vente()//retour
       {
           Ajouter_au_Stock_produit_vendu();
           con_produit_vente.Executer("insert into table_statistique_mois(produit,mois,année,entré,sortie) values('" + _produit.Désignation + "'," + _vente.Date_Vente.Month + "," + _vente.Date_Vente.Year + "," + _qté + ",0)");
           return con_produit_vente.Executer("delete from produit_Vendu   where  désignation='" + _produit.Désignation + "' and nvente= " + _vente.Nvente + "");

        }

       public DataTable Liste_produits_vendu_pour_une_vente()
       {
           return con_produit_vente.Executer_Liste("  select produit_vendu.désignation,qté, pu, pu*qté as total from produit_vendu, produit where produit_vendu.désignation=produit.désignation and nvente="+_vente.Nvente+"");
       }

       public Double Net_une_vente()
       {
           if (con_produit_vente.Executer_valeur("  select count(*) from produit_vendu  where nvente=" + _vente.Nvente + "")=="0") 
           return 0;
           else
               return Convert .ToDouble ( con_produit_vente.Executer_valeur("  select sum(pu*qté) as net from produit_vendu, produit where produit_vendu.désignation=produit.désignation and nvente=" + _vente.Nvente + ""));
       }
     
    

    }
}
