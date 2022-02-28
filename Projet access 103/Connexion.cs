using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;// access
using System.Data.SqlClient;
namespace Projet_access_103
{
     public  class Connexion
    {

         //attributs
         //connexion
         private OleDbConnection con;
         //un objet commande (programme sql access)
         private OleDbCommand cmd;
         //executeur
         private OleDbDataAdapter dat;
         //objet pour enregistrer les données depuis access
         private DataSet ds;
         //une table
         private   DataTable tb;

         private String mot_passe;

         public Connexion(String mot_passe)
         {
             this.mot_passe = mot_passe;
         }
         public DataTable Tb
         {
            get{ return tb;}
         }
         //methode de connexion
         public Boolean Connecter()
         {
             try
             {
                 String chaine_connexion;
                 chaine_connexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\ventes.accdb;Persist Security Info=false;Jet OLEDB:Database Password=" + mot_passe;
                 con = new OleDbConnection(chaine_connexion);
                 con.Open();//ouvrir la connexion
                 return true;
             }
             catch (Exception x)
             {
                 return false;
             }
         }
         //executer liste renvoyant plusieurs données................................
         public DataTable Executer_Liste(String programme)
         {            
                //creer une commande
                 cmd = new OleDbCommand(programme);
                 cmd.Connection = con;
                 dat = new OleDbDataAdapter(cmd);
                 ds = new DataSet();
                 dat.Fill(ds, cmd.CommandText);
                 tb = new DataTable();
                 tb = ds.Tables[0];
                 return tb;
         }

         //executer liste renvoyant une seule donnée................................
         public String  Executer_valeur(String programme)
         {
             //creer une commande
             cmd = new OleDbCommand(programme);
             cmd.Connection = con;
            return  cmd.ExecuteScalar().ToString();
         }

         //executer insert,delete et update et renvoie le nbre de lignes affectées..............................
         public int Executer(String programme)
         {
             //creer une commande
             cmd = new OleDbCommand(programme);
             cmd.Connection = con;
             return  cmd.ExecuteNonQuery();
         }
    }
}
