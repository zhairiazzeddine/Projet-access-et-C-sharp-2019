﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_access_103
{
  public   class Class_Conversio_monnaie
    {
      //methode
      public string converti(Double chiffre)
      {
          int centaine, dizaine, unite, reste, y;
          bool dix = false;
          string lettre = "";
          //strcpy(lettre, "");

          reste = (int)chiffre / 1;

          for (int i = 1000000000; i >= 1; i /= 1000)
          {
              y = reste / i;
              if (y != 0)
              {
                  centaine = y / 100;
                  dizaine = (y - centaine * 100) / 10;
                  unite = y - (centaine * 100) - (dizaine * 10);
                  switch (centaine)
                  {
                      case 0:
                          break;
                      case 1:
                          lettre += "cent ";
                          break;
                      case 2:
                          if ((dizaine == 0) && (unite == 0)) lettre += "deux cents ";
                          else lettre += "deux cent ";
                          break;
                      case 3:
                          if ((dizaine == 0) && (unite == 0)) lettre += "trois cents ";
                          else lettre += "trois cent ";
                          break;
                      case 4:
                          if ((dizaine == 0) && (unite == 0)) lettre += "quatre cents ";
                          else lettre += "quatre cent ";
                          break;
                      case 5:
                          if ((dizaine == 0) && (unite == 0)) lettre += "cinq cents ";
                          else lettre += "cinq cent ";
                          break;
                      case 6:
                          if ((dizaine == 0) && (unite == 0)) lettre += "six cents ";
                          else lettre += "six cent ";
                          break;
                      case 7:
                          if ((dizaine == 0) && (unite == 0)) lettre += "sept cents ";
                          else lettre += "sept cent ";
                          break;
                      case 8:
                          if ((dizaine == 0) && (unite == 0)) lettre += "huit cents ";
                          else lettre += "huit cent ";
                          break;
                      case 9:
                          if ((dizaine == 0) && (unite == 0)) lettre += "neuf cents ";
                          else lettre += "neuf cent ";
                          break;
                  }// endSwitch(centaine)

                  switch (dizaine)
                  {
                      case 0:
                          break;
                      case 1:
                          dix = true;
                          break;
                      case 2:
                          lettre += "vingt ";
                          break;
                      case 3:
                          lettre += "trente ";
                          break;
                      case 4:
                          lettre += "quarante ";
                          break;
                      case 5:
                          lettre += "cinquante ";
                          break;
                      case 6:
                          lettre += "soixante ";
                          break;
                      case 7:
                          dix = true;
                          lettre += "soixante ";
                          break;
                      case 8:
                          lettre += "quatre-vingt ";
                          break;
                      case 9:
                          dix = true;
                          lettre += "quatre-vingt ";
                          break;
                  } // endSwitch(dizaine)

                  switch (unite)
                  {
                      case 0:
                          if (dix) lettre += "dix ";
                          break;
                      case 1:
                          if (dix) lettre += "onze ";
                          else lettre += "un ";
                          break;
                      case 2:
                          if (dix) lettre += "douze ";
                          else lettre += "deux ";
                          break;
                      case 3:
                          if (dix) lettre += "treize ";
                          else lettre += "trois ";
                          break;
                      case 4:
                          if (dix) lettre += "quatorze ";
                          else lettre += "quatre ";
                          break;
                      case 5:
                          if (dix) lettre += "quinze ";
                          else lettre += "cinq ";
                          break;
                      case 6:
                          if (dix) lettre += "seize ";
                          else lettre += "six ";
                          break;
                      case 7:
                          if (dix) lettre += "dix-sept ";
                          else lettre += "sept ";
                          break;
                      case 8:
                          if (dix) lettre += "dix-huit ";
                          else lettre += "huit ";
                          break;
                      case 9:
                          if (dix) lettre += "dix-neuf ";
                          else lettre += "neuf ";
                          break;
                  } // endSwitch(unite)

                  switch (i)
                  {
                      case 1000000000:
                          if (y > 1) lettre += "milliards ";
                          else lettre += "milliard ";
                          break;
                      case 1000000:
                          if (y > 1) lettre += "millions ";
                          else lettre += "million ";
                          break;
                      case 1000:
                          lettre += "mille ";
                          break;
                  }
              } // end if(y!=0)
              reste -= y * i;
              dix = false;
          } // end for
          if (lettre.Length == 0) lettre += "zero";

          return lettre;
      }
      public String convertir_chiffre_en_lettre(String montant)
      {
          string dh, cts;
          montant = arrondie(montant);
          int n = montant.Length;
          dh = montant.Substring(0, n - 3);
          cts = montant.Substring(n - 2, 2);
          Double Sdh, Scts;
          Sdh = Convert.ToDouble(dh);
          Scts = Convert.ToDouble(cts);
          String conversion = converti(Sdh) + " Dh et " + converti(Scts) + " Cts";
          //if (conversion.Length > 5)
          //{
          if (conversion.Substring(0, 2).ToLower().Equals("un") && !conversion.Substring(4, 2).ToLower().Equals("dh"))
              conversion = conversion.Substring(3, conversion.Length - 3).Trim();
          //}
          return conversion;
      }
      public String arrondie(String nbre)
      {
          string x;
          int pos;
          if (nbre != "")
          {
              nbre = nbre.Replace(".", ",");
              Double d = Convert.ToDouble(nbre);
              d = Math.Round(d, 2);
              x = Convert.ToString(d);
              x = x.Replace(",", ".");
              pos = 0;
              for (int k = 0; k < x.Length; k++)
              {
                  if (x.Substring(k, 1) == ".")
                  {
                      pos = k;
                  }
              }
              if (pos == 0)
                  x = x + ".00";
              if (pos == x.Length - 2)
                  x = x + "0";
          }
          else
              x = "";

          return x;
      }
    }
}
