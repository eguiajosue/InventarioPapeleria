using System.Collections.Generic;

namespace ProyectoFinal
{
    public class Primavera
    {
        private List<CamisaMangaCorta> listaCamisaMangaCorta = new List<CamisaMangaCorta>();
        private List<Shorts> listaShorts = new List<Shorts>();

        public IEnumerable<CamisaMangaCorta> ListaCamisaMangaCortas
        {
            get
            {
                foreach (var camisaMangaCorta in listaCamisaMangaCorta)
                    yield return camisaMangaCorta;
            }
        }

        public IEnumerable<Shorts> ListaShorts
        {
            get
            {
                foreach (var shorts in listaShorts)
                    yield return shorts;
            }
        }

        public void AgregarCamisaMangaCorta(CamisaMangaCorta nuevaParte)
        {
            listaCamisaMangaCorta.Add(nuevaParte);
        }

        public void AgregarShorts(Shorts nuevaParte)
        {
            listaShorts.Add(nuevaParte);
        }

        ~Primavera()
        {
            listaCamisaMangaCorta.Clear();
            listaShorts.Clear();
        }
    }

    public class Verano
    {
        private List<TrajeDeBaño> listaTrajeDeBaño = new List<TrajeDeBaño>();

        public IEnumerable<TrajeDeBaño> ListaTrajeDeBaños
        {
            get
            {
                foreach (var trajeDeBaño in listaTrajeDeBaño)
                    yield return trajeDeBaño;
            }
        }

        public void AgregarTrajeDeBaño(TrajeDeBaño nuevaParte)
        {
            listaTrajeDeBaño.Add(nuevaParte);
        }

        ~Verano()
        {
            listaTrajeDeBaño.Clear();
        }
    }

    public class Otoño
    {
        private List<CamisaMangaLarga> listaCamisaMangaLarga = new List<CamisaMangaLarga>();
        private List<Pants> listaPants = new List<Pants>();

        public IEnumerable<CamisaMangaLarga> ListaCamisaMangaLargas
        {
            get
            {
                foreach (var camisaMangaLarga in listaCamisaMangaLarga)
                    yield return camisaMangaLarga;
            }
        }

        public IEnumerable<Pants> ListaPants
        {
            get
            {
                foreach (var pants in listaPants)
                    yield return pants;
            }
        }

        public void AgregarCamisaMangaLarga(CamisaMangaLarga nuevaParte)
        {
            listaCamisaMangaLarga.Add(nuevaParte);
        }

        public void AgregarPants(Pants nuevaParte)
        {
            listaPants.Add(nuevaParte);
        }

        ~Otoño()
        {
            listaCamisaMangaLarga.Clear();
            listaPants.Clear();
        }
    }

    public class Invierno
    {
        private List<Chamarra> listaChamarra = new List<Chamarra>();
        private List<Sueter> listaSueter = new List<Sueter>();

        public IEnumerable<Chamarra> ListaChamarras
        {
            get
            {
                foreach (var chamarra in listaChamarra)
                    yield return chamarra;
            }
        }

        public IEnumerable<Sueter> ListaSueters
        {
            get
            {
                foreach (var sueter in listaSueter)
                    yield return sueter;
            }
        }

        public void AgregarSueter(Sueter nuevaParte)
        {
            listaSueter.Add(nuevaParte);
        }

        public void AgregarChamarra(Chamarra nuevaParte)
        {
            listaChamarra.Add(nuevaParte);
        }

        ~Invierno()
        {
            listaSueter.Clear();
            listaChamarra.Clear();
        }
    }
}