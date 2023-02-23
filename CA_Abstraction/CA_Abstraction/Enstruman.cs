using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Abstraction
{
    public abstract class Enstruman:Muzisyen
    {   
        /*
         Abstraction (Soyutlama)
        - Abstract edilmis bir classtan instance alinamaz.
        - Abstract metotlar sadece abstact classlar icinde tanimlanir. Kesinlikle ezilmek zorundadir.
        - Abstract metotlar ya da propertyler virtual olarak tanimlanmazlar.
        - Abstract metotlar statik olarak tanimlanamaz.
        - Abstract metotlarin govdesi olamaz.
         */
        public string Enstruman_Ad { get; set; }
        public string Dogu_Bati { get; set; }
        public string Enstruman_Tipi { get; set; }

        public List<Enstruman> EnstrumanListesi = new List<Enstruman>();
        public virtual string Enstruman_Cal()
        {
            return "Enstruman Cal";
        }

        public void EnstrumanKayit()
        {
            Baglama baglama = new Baglama();
            baglama.Enstruman_Ad = "Baglama";
            baglama.Dogu_Bati = "Dogu";
            baglama.Enstruman_Tipi = "Telli";
            EnstrumanListesi.Add(baglama);

            Bas_Gitar basgitar = new Bas_Gitar();
            basgitar.Enstruman_Ad = "Bas Gitar";
            basgitar.Dogu_Bati = "Bati";
            basgitar.Enstruman_Tipi = "Telli";
            EnstrumanListesi.Add(basgitar);

            Bateri bateri = new Bateri();
            bateri.Enstruman_Ad = "Bateri";
            bateri.Dogu_Bati = "Bati";
            bateri.Enstruman_Tipi = "Vurmali";
            EnstrumanListesi.Add(bateri);

            Elektro_Gitar elektrogitar = new Elektro_Gitar();
            elektrogitar.Enstruman_Ad = "Elektro Gitar";
            elektrogitar.Dogu_Bati = "Bati";
            elektrogitar.Enstruman_Tipi = "Telli";
            EnstrumanListesi.Add(elektrogitar);

            Ney ney = new Ney();
            ney.Enstruman_Ad = "Ney";
            ney.Dogu_Bati = "Dogu";
            ney.Enstruman_Tipi = "Uflemeli";
            EnstrumanListesi.Add(ney);

            Piyano piyano = new Piyano();
            piyano.Enstruman_Ad = "Piyano";
            piyano.Dogu_Bati = "Bati";
            piyano.Enstruman_Tipi = "Tuslu";
            EnstrumanListesi.Add(piyano);

            Tulum tulum = new Tulum();
            tulum.Enstruman_Ad = "Tulum";
            tulum.Dogu_Bati = "Dogu";
            tulum.Enstruman_Tipi = "Uflemeli";
            EnstrumanListesi.Add(tulum);
        }
    }
}
