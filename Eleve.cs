using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_GenerateurTrombinoscope
{
    public class Eleve
    {
        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Image64 { get; protected set; }

        public string NomComplet
        {
            get { return Nom + " " + Prenom; }
        }

        public string PrenomComplet
        {
            get { return Prenom + " " + Nom; }
        }

        public string LabelPhoto
        {
            get { return Nom + Environment.NewLine + Prenom; }
        }

        public string NomFichierSansExt
        {
            get { return Toolbox.getValidFileName(NomComplet); }
        }

        public Eleve(string unNomComplet)
        {
            string ch = unNomComplet.Replace(Environment.NewLine, " ");
            List<string> noms = new List<string>();
            List<string> prenoms = new List<string>();
            string[] parts = ch.Split(' ');
            foreach (string part in parts)
            {
                if (part == string.Empty) continue;
                if (part.ToUpper() == part)
                {
                    noms.Add(part);
                }
                else
                {
                    prenoms.Add(part);
                }
            }
            Nom = string.Join(" ", noms.ToArray());
            Prenom = String.Join(" ", prenoms.ToArray());
            if (( Nom == "") && (Prenom == ""))
            {
                Nom = DateTime.Now.ToString("yyyyMMdd-hhmmss");
            }
        }

        public void chargerImage(Image unePhoto)
        {
            MemoryStream ms = new MemoryStream();
            unePhoto.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] imageBytes = ms.ToArray();
            Image64 = Convert.ToBase64String(imageBytes);
        }

        //public static string ConvertirLabelPhoto(string unNomComplet)
        //{
        //    string nom = "";
        //    string[] parts = unNomComplet.Split(' ');
        //    int i = 0;
        //    while (parts[i].ToUpper() == parts[i]) { i++; }
        //    for (int x = 0; x < i; x++)
        //    {
        //        if (nom != string.Empty) nom += ' ';
        //        nom += parts[x];
        //    }
        //    nom.TrimStart(' ');
        //    string prenom = "";
        //    for (int x = i; x < parts.Count(); x++)
        //    {
        //        if (prenom != string.Empty) prenom += ' ';
        //        prenom += parts[x];
        //    }
        //    prenom.TrimStart(' ');
        //    return nom + Environment.NewLine + prenom;
        //}

        public override string ToString()
        {
            return NomComplet;
        }

    }
}
