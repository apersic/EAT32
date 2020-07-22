using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrijavaRegistracija
{
    class BazaPodataka
    {
        /// <summary>
        /// Upisuje ugostiteljski objekt u bazu podataka zajedno sa podacima o korisnickom racunu i podacima o objektu. 
        /// </summary> 
        public void UpisiUgostiteljskiObjekt(UgostiteljskiObjekt objekt)
        {
            using (var db = new eat32Entities())
            {
                dbKorisnickiRacun noviRacun = new dbKorisnickiRacun
                {
                    korisnicko_ime = objekt.KorisnickoIme,
                    lozinka = objekt.Lozinka,
                    email = objekt.Email,
                    adresa = objekt.Adresa,
                    broj_telefona = objekt.BrojTelefona,
                };

                db.dbKorisnickiRacun.Add(noviRacun);
                db.SaveChanges();

                int idRacuna = DohvatiIDRacuna(objekt.KorisnickoIme);

                dbUgostiteljskiObjekt noviObjekt = new dbUgostiteljskiObjekt
                {
                    id_ugostiteljskog_obrta = idRacuna,
                    naziv = objekt.Naziv,
                    radno_vrijeme_pocetak = objekt.RadnoVrijemePocetak,
                    radno_vrijeme_kraj = objekt.RadnoVrijemeKraj
                };

                db.dbUgostiteljskiObjekt.Add(noviObjekt);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Upisuje obicnog korisnika u bazu podataka zajedno sa podacima o korisnickom racunu i podacima o korisniku. 
        /// </summary> 
        public void UpisiObicnogKorisnika(ObicniKorisnik korisnik)
        {
            using (var db = new eat32Entities())
            {
                dbKorisnickiRacun noviRacun = new dbKorisnickiRacun
                {
                    korisnicko_ime = korisnik.KorisnickoIme,
                    lozinka = korisnik.Lozinka,
                    email = korisnik.Email,
                    adresa = korisnik.Adresa,
                    broj_telefona = korisnik.BrojTelefona,
                };

                db.dbKorisnickiRacun.Add(noviRacun);
                db.SaveChanges();

                int idRacuna = DohvatiIDRacuna(korisnik.KorisnickoIme);

                dbObicniKorisnik noviKorisnik = new dbObicniKorisnik
                {
                    id_obicnog_korisnika = idRacuna,
                    ime = korisnik.Ime,
                    prezime = korisnik.Prezime
                };

                db.dbObicniKorisnik.Add(noviKorisnik);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Ažurira korisnicki racun ugostiteljskog objekta i pojedine podatke o objektu. 
        /// </summary> 
        public void AzurirajUgostiteljskiObjekt(int idRacuna, string naziv, string email, string lozinka, string adresa, string brojTelefona, TimeSpan radnoVrijemePocetak, TimeSpan radnoVrijemeKraj)
        {
            using (var db = new eat32Entities())
            {
                dbUgostiteljskiObjekt odabraniObjekt = db.dbUgostiteljskiObjekt.FirstOrDefault(r => r.id_ugostiteljskog_obrta == idRacuna);
                dbKorisnickiRacun odabraniRacun = db.dbKorisnickiRacun.FirstOrDefault(r => r.id_korisnika == idRacuna);

                if (odabraniRacun != null)
                {
                    db.dbKorisnickiRacun.Attach(odabraniRacun);
                    odabraniRacun.email = email;
                    odabraniRacun.lozinka = lozinka;
                    odabraniRacun.adresa = adresa;
                    odabraniRacun.broj_telefona = brojTelefona;
                    db.SaveChanges();

                    db.dbUgostiteljskiObjekt.Attach(odabraniObjekt);
                    odabraniObjekt.naziv = naziv;
                    odabraniObjekt.radno_vrijeme_pocetak = radnoVrijemePocetak;
                    odabraniObjekt.radno_vrijeme_kraj = radnoVrijemeKraj;
                    db.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Ažurira korisnika u bazi podataka
        /// </summary> 
        public void AzurirajObicnogKorisnika(int idRacuna, string naziv, string email, string lozinka, string brojTelefona, string adresa)
        {
            using (var db = new eat32Entities())
            {
                dbObicniKorisnik odabraniKorisnik = db.dbObicniKorisnik.FirstOrDefault(r => r.id_obicnog_korisnika == idRacuna);
                dbKorisnickiRacun odabraniRacun = db.dbKorisnickiRacun.FirstOrDefault(r => r.id_korisnika == idRacuna);

                if (odabraniRacun != null)
                {
                    db.dbKorisnickiRacun.Attach(odabraniRacun);
                    odabraniRacun.korisnicko_ime = naziv;
                    odabraniRacun.email = email;
                    odabraniRacun.lozinka = lozinka;
                    odabraniRacun.broj_telefona = brojTelefona;
                    odabraniRacun.adresa = adresa; 
                    db.SaveChanges();

                    db.dbObicniKorisnik.Attach(odabraniKorisnik);
                    db.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Dohvaća ID korisnickog racuna preko njegovog korisnickog imena, a ako korisnik ne postoji vraća -1. 
        /// </summary> 
        public int DohvatiIDRacuna(string korisnickoImeRacuna)
        {
            int ID = -1;

            using (var db = new eat32Entities())
            {
                var redObjekta = db.dbKorisnickiRacun.FirstOrDefault(r => r.korisnicko_ime == korisnickoImeRacuna);
                
                if (redObjekta != null)
                {
                    ID = redObjekta.id_korisnika;
                }
            }
            return ID;
        }

        /// <summary>
        /// Dohvaća korisnicko ime racuna preko njegovog ID-a. U slucaju da ne postoji racun sa unesenim ID-em, funkcija vraća null vrijednost. 
        /// </summary> 
        public string DohvatiKorisnickoIme(int idRacuna)
        {
            string korime = null;

            using (var db = new eat32Entities())
            {
                var korisnickiRacun = db.dbKorisnickiRacun.FirstOrDefault(k => k.id_korisnika == idRacuna);

                if (korisnickiRacun != null)
                {
                    korime = korisnickiRacun.korisnicko_ime;
                }
            }

            return korime;
        }

        /// <summary>
        /// Dohvaca naziv racuna, odnosno ime i prezime korisnika ako se radi o obicnom korisniku ili naziv ugostiteljskog objekta ako se radi o objektu. Ako ne postoji racun sa unesenim ID-em, funkcija vraća null vrijednost.
        /// </summary> 
        public string DohvatiNazivRacuna(int idRacuna)
        {
            string naziv = null;

            using (var db = new eat32Entities())
            {
                var redKorisnik = db.dbKorisnickiRacun.FirstOrDefault(r => r.id_korisnika == idRacuna);

                if (redKorisnik != null)
                {
                    if (db.dbObicniKorisnik.Any(r => r.id_obicnog_korisnika == redKorisnik.id_korisnika))
                    {
                        var korisnik = db.dbObicniKorisnik.First(r => r.id_obicnog_korisnika == redKorisnik.id_korisnika);
                        naziv = korisnik.ime + " " + korisnik.prezime;
                    }
                    else
                    {
                        var objekt = db.dbUgostiteljskiObjekt.First(r => r.id_ugostiteljskog_obrta == redKorisnik.id_korisnika);
                        naziv = objekt.naziv;
                    }
                }
            }
            return naziv;
        }

        /// <summary>
        /// Izvršava autentifikaciju korisnika, odnosno provjerava da li u bazi postoji korisnicki racun sa tim korisnickim imenom i lozinkom. Ako se radi o obicnom korisniku onda vraca 1, za ugostiteljski objekt 2, a u slucaju nepostojeceg racuna vraca 0. 
        /// </summary> 
        public int Autentikacija(string username, string password)
        {
            int status = 0;

            using (var db = new eat32Entities())
            {
                var redKorisnik = db.dbKorisnickiRacun.FirstOrDefault(r => r.korisnicko_ime == username && r.lozinka == password);
                
                if (redKorisnik != null)
                {
                    if (db.dbObicniKorisnik.Any(r => r.id_obicnog_korisnika == redKorisnik.id_korisnika))
                    {
                        status = 1;
                    }
                    else
                    {
                        status = 2;
                    }
                }
            }
            return status;
        }

        /// <summary>
        /// Provjerava da li u bazi podataka već postoji korisnik sa unesenim korisnickim imenom, u slucaju postojanja vraća false a u suprotnom true. 
        /// </summary> 
        public bool DostupnoKorisnickoIme(string korisnickoIme)
        {
            bool dostupno = true;

            using (var db = new eat32Entities())
            {
                int brojRedova = db.dbKorisnickiRacun.Count(r => r.korisnicko_ime == korisnickoIme);

                if (brojRedova != 0)
                {
                    dostupno = false;
                }
            }
            return dostupno;
        }

        /// <summary>
        /// Dohvaca obicnog korisnika preko ID-a racuna, a ukoliko nije pronaden obicni korisnik sa tim ID-em funkcija ce vratiti null. 
        /// </summary> 
        public ObicniKorisnik DohvatiObicnogKorisnika(int idRacuna)
        {
            ObicniKorisnik korisnik = null;

            using (var db = new eat32Entities())
            {
                var trazeniRacun = db.dbKorisnickiRacun.FirstOrDefault(r => r.id_korisnika == idRacuna);

                if (trazeniRacun != null)
                {
                    var trazeniKorisnik = db.dbObicniKorisnik.First(r => r.id_obicnog_korisnika == idRacuna);

                    korisnik = new ObicniKorisnik(trazeniRacun.korisnicko_ime, trazeniRacun.lozinka, trazeniRacun.email, trazeniRacun.adresa, trazeniRacun.broj_telefona, trazeniKorisnik.ime, trazeniKorisnik.prezime);
                    korisnik.IDRacuna = trazeniKorisnik.id_obicnog_korisnika;
                }
            }
            return korisnik;
        }

        /// <summary>
        /// Dohvaca ugostiteljskoi objekt preko ID-a racuna, a ukoliko nije pronaden ugostiteljski objekt sa tim ID-em funkcija ce vratiti null. 
        /// </summary> 
        public UgostiteljskiObjekt DohvatiUgostiteljskiObjekt(int idRacuna)
        {
            UgostiteljskiObjekt objekt = null;

            using (var db = new eat32Entities())
            {
                var trazeniRacun = db.dbKorisnickiRacun.FirstOrDefault(r => r.id_korisnika == idRacuna);

                if (trazeniRacun != null)
                {
                    var trazeniObjekt = db.dbUgostiteljskiObjekt.First(r => r.id_ugostiteljskog_obrta == idRacuna);

                    objekt = new UgostiteljskiObjekt(trazeniRacun.korisnicko_ime, trazeniRacun.lozinka, trazeniRacun.email, trazeniRacun.adresa, trazeniRacun.broj_telefona, trazeniObjekt.naziv, (TimeSpan)trazeniObjekt.radno_vrijeme_pocetak, (TimeSpan) trazeniObjekt.radno_vrijeme_kraj);
                    objekt.IDRacuna = trazeniObjekt.id_ugostiteljskog_obrta;
                }
            }

            return objekt;
        }

        /// <summary>
        /// Dohvaća sve ugostiteljske objekte u obliku kolekcije tipa BindingList.
        /// </summary>
        public BindingList<dbUgostiteljskiObjekt> DohvatiSveUgostiteljskeObjekte()
        {
            BindingList<dbUgostiteljskiObjekt> sviObjekti = null;

            using (var db = new eat32Entities())
            {
                sviObjekti = new BindingList<dbUgostiteljskiObjekt>(db.dbUgostiteljskiObjekt.ToList());
            }

            return sviObjekti;
        }

        /// <summary>
        /// Pretrazuje ugostiteljske objekte i dohvaća sve objekte koji u sebi sadrže traženu ključnu riječ, odnosno sve objekte kojima je vrijednost bilo kojeg atributa jednaka traženoj riječi. U slučaju neuspjeha, vraća null. 
        /// </summary> 
        public BindingList<dbUgostiteljskiObjekt> PretraziUgostiteljskeObjekte(string kljucnaRijec)
        {
            BindingList<dbUgostiteljskiObjekt> nadeniObjekti = null;

            using (var db = new eat32Entities())
            {
                var objektiUpit = db.dbUgostiteljskiObjekt.Where(r => r.naziv.Contains(kljucnaRijec)).ToList();

                nadeniObjekti = new BindingList<dbUgostiteljskiObjekt>(objektiUpit);
            }

            return nadeniObjekti;
        }

        /// <summary>
        /// Dohvaća prosječnu ocjenu ugostiteljskog objekta, odnosno prosječnu ocjenu koju su korisnici ostavili na recenzijama njihovih narudžbi.
        /// </summary> 
        public double DohvatiProsjecnuOcjenuObjekta(int idObjekta)
        {
            double prosjecnaOcjena = 0;

            using (var db = new eat32Entities())
            {
                var sveNarudzbe = db.dbNarudžba.Where(r => r.ugostiteljski_obrt_id == idObjekta);
                int ukupnaOcjena = 0;
                int brojac = 0;

                foreach (var item in sveNarudzbe)
                {
                    var recenzijaNarudzbe = db.dbRecenzija.FirstOrDefault(r => r.narudzba_id == item.id_narudzbe);
                    
                    if (recenzijaNarudzbe != null)
                    {
                        ukupnaOcjena += (int) recenzijaNarudzbe.ocjena;
                        brojac += 1;
                    }
                }

                if (brojac != 0)
                {
                    prosjecnaOcjena = ukupnaOcjena / brojac;
                }
            }

            return prosjecnaOcjena;
        }

        /// <summary>
        /// Dohvaca sve narudžbe objekta sa unesenim ID-om u obliku kolekcije tipa BindingList. 
        /// </summary> 
        public BindingList<dbNarudžba> DohvatiNarudzbeObjekta(int idRacuna)
        {
            BindingList<dbNarudžba> listaNarudzbi = null;

            using (var db = new eat32Entities())
            {
                var narudzbaUpit = db.dbNarudžba.Where(r => r.ugostiteljski_obrt_id == idRacuna).ToList();

                listaNarudzbi = new BindingList<dbNarudžba>(narudzbaUpit);
            }

            return listaNarudzbi;
        }

        /// <summary>
        /// Dohvaca sve stavke narudzbe preko njenog ID-a u obliku kolekcije tipa BindingList. Ako narudzba nema stavki, funkcija vraca null vrijednost. 
        /// </summary>
        public BindingList<dbStavkaNarudzbe> DohvatiStavkeNarudzbe(int idNarudzbe)
        {
            BindingList<dbStavkaNarudzbe> listaStavki = null;

            using (var db = new eat32Entities())
            {
                var stavkeUpit = db.dbStavkaNarudzbe.Where(s => s.narudzba_id == idNarudzbe).ToList();

                if (stavkeUpit.Count != 0)
                {
                    listaStavki = new BindingList<dbStavkaNarudzbe>(stavkeUpit);
                }
            }

            return listaStavki;
        }

        /// <summary>
        /// Dohvaca artikl iz baze podataka. 
        /// </summary>
        public dbArtikl DohvatiArtikl(int idArtikla)
        {
            dbArtikl trazeniArtikl = null;

            using (var db = new eat32Entities())
            {
                trazeniArtikl = db.dbArtikl.FirstOrDefault(a => a.id_artikla == idArtikla);
            }

            return trazeniArtikl;
        }

        /// <summary>
        /// Brise artikl iz baze podataka. 
        /// </summary>
        public bool IzbrisiArtikl(int idArtikla)
        {
            dbArtikl trazeniArtikl = null;

            using (var db = new eat32Entities())
            {
                trazeniArtikl = db.dbArtikl.FirstOrDefault(a => a.id_artikla == idArtikla);

                db.dbArtikl.Attach(trazeniArtikl);
                db.dbArtikl.Remove(trazeniArtikl);

                try
                {
                    db.SaveChanges();
                    return false;
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    Notifikacija novaNotifikacija = new Notifikacija("Greska", "Nemoguce je obrisati artikl!", "upozorenje");
                    novaNotifikacija.ShowDialog();
                    return true;
                }
            }
        }

        /// <summary>
        /// Dohvaća sve recenzije ugostiteljskog objekta u listu
        /// </summary> 
        public BindingList<dbRecenzija> DohvatiSveRecenzije(int idObjekta)
        {
            int objektId = idObjekta;
            BindingList<dbRecenzija> sveRecenzije = new BindingList<dbRecenzija>();

            BindingList<dbNarudžba> listaNarudzba = DohvatiNarudzbeObjekta(objektId);

            if (listaNarudzba != null)
            {
                using (var db = new eat32Entities())
                {
                    foreach (var item in listaNarudzba)
                    {
                        dbRecenzija novaRecenzija = db.dbRecenzija.FirstOrDefault(r => r.narudzba_id == item.id_narudzbe);

                        if (novaRecenzija != null)
                        {
                            sveRecenzije.Add(novaRecenzija);
                        }
                    }
                }
            }

            return sveRecenzije;
        }

        /// <summary>
        /// Dohvaća sve narudžbe korisnika
        /// </summary> 
        public BindingList<dbNarudžba> DohvatiMojeNarudzbe(int idKorisnika)
        {
            int korisnikID = idKorisnika;
            BindingList<dbNarudžba> sveNarudzbe = null;

            using (var db = new eat32Entities())
            {
                var trenutnaNarudzba = db.dbNarudžba.Where(r => r.korisnik_id == korisnikID).ToList();
                sveNarudzbe = new BindingList<dbNarudžba>(trenutnaNarudzba);
            }

            return sveNarudzbe;
        }

        /// <summary>
        /// Dohvaća korisnicko ime prema ID-u narudžbe
        /// </summary>
        public string DohvatiImeRecenzenta(int idNarudzbe)
        {
            int posiljatelj;
            string imePosiljatelja;

            using (var db = new eat32Entities())
            {
                dbNarudžba trazenaNarudzba = db.dbNarudžba.FirstOrDefault(r => r.id_narudzbe == idNarudzbe);
                posiljatelj = trazenaNarudzba.korisnik_id;
                imePosiljatelja = DohvatiKorisnickoIme(posiljatelj);
            }

            return imePosiljatelja;
        }

        /// <summary>
        /// Salje poruku drugom korisniku, odnosno unosi novu poruku u bazu podataka.
        /// </summary> 
        public void PosaljiPoruku(int idPosiljatelja, int idPrimatelja, string header, string text)
        {
            using (var db = new eat32Entities())
            {
                dbPoruka novaPoruka = new dbPoruka
                {
                    posiljatelj_id = idPosiljatelja,
                    primatelj_id = idPrimatelja,
                    naslov = header,
                    tekst = text
                };

                db.dbPoruka.Add(novaPoruka);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Dohvaca sve primljene poruke trenutnog korisnika u obliku kolekcije poruka tipa BindingList. Ukoliko korisnik nema primljenih poruka, funkcija vraća null.
        /// </summary> 
        public BindingList<dbPoruka> DohvatiMojePrimljenePoruke(int idRacuna)
        {
            BindingList<dbPoruka> mojePrimljenePoruke = null;

            using (var db = new eat32Entities())
            {
                var porukeUpit = db.dbPoruka.Where(r => r.primatelj_id == idRacuna).ToList();

                mojePrimljenePoruke = new BindingList<dbPoruka>(porukeUpit);
            }

            return mojePrimljenePoruke;
        }

        /// <summary>
        /// Dohvaca sve poslane poruke trenutnog korisnika u obliku kolekcije poruka tipa BindingList. Ukoliko korisnik nema poslanih poruka, funkcija vraća null.
        /// </summary> 
        public BindingList<dbPoruka> DohvatiMojePoslanePoruke(int idRacuna)
        {
            BindingList<dbPoruka> mojePoslanePoruke = null;

            using (var db = new eat32Entities())
            {
                var porukeUpit = db.dbPoruka.Where(r => r.posiljatelj_id == idRacuna).ToList();

                mojePoslanePoruke = new BindingList<dbPoruka>(porukeUpit);
            }

            return mojePoslanePoruke;
        }

        /// <summary>
        /// Briše odabranu poruku iz korisnikove poste, odnosno iz baze podataka.
        /// </summary> 
        public void IzbrisiPoruku(int idPoruke)
        {
            using (var db = new eat32Entities())
            {
                dbPoruka poruka = db.dbPoruka.FirstOrDefault(r => r.id_poruke == idPoruke);

                db.dbPoruka.Attach(poruka);
                db.dbPoruka.Remove(poruka);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Dohvaća sve ponude ugostiteljskog objekta (ponude hrane, ponude pića i sl.) u obliku kolekcije tipa BindingList. Ako ugostiteljski objekt nema ponuda, funkcija vraća null vrijednost.
        /// </summary> 
        public BindingList<dbPonuda> DohvatiPonudeObjekta(int idObjekta)
        {
            BindingList<dbPonuda> listaPonuda = null;

            using (var db = new eat32Entities())
            {
                var upitPonuda = db.dbPonuda.Where(p => p.ugostiteljski_obrt_id == idObjekta).ToList();

                listaPonuda = new BindingList<dbPonuda>(upitPonuda);
            }

            return listaPonuda;
        }

        /// <summary>
        /// Dohvaća sve artikle sa ponude preko njenog ID-a u obliku kolekcije tipa BindingList. Ukoliko nema artikala u ponudi, funkcija vraća null vrijednost.
        /// </summary> 
        public BindingList<dbArtikl> DohvatiArtiklePonude(int idPonude)
        {
            BindingList<dbArtikl> listaArtikala = null;

            using (var db = new eat32Entities())
            {
                var upitArtikli = db.dbArtikl.Where(a => a.ponuda_id == idPonude).ToList();

                listaArtikala = new BindingList<dbArtikl>(upitArtikli);
            }

            return listaArtikala;
        }

        /// <summary>
        /// Upisuje artikl u bazu podataka. Potrebno je proslijediti ID ponude u koju se upisuje artikl, te njegov naziv i cijenu.
        /// </summary> 
        public void UpisiArtikl(int idPonude, string nazivVal, int cijenaVal)
        {
            using (var db = new eat32Entities())
            {
                dbArtikl noviArtikl = new dbArtikl
                {
                    ponuda_id = idPonude,
                    naziv = nazivVal,
                    cijena = cijenaVal.ToString()
                };

                db.dbArtikl.Add(noviArtikl);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Upisuje ponudu ugostiteljskog objekta u bazu podataka. Potrebno je proslijediti ID objekta kojem se pridruzuje ponuda, te opis ponude.
        /// </summary> 
        public void UpisiPonudu(int idObjekta, string opisVal)
        {
            using (var db = new eat32Entities())
            {
                dbPonuda novaPonuda = new dbPonuda
                {
                    ugostiteljski_obrt_id = idObjekta,
                    opis = opisVal
                };

                db.dbPonuda.Add(novaPonuda);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Dohvaća ukupan iznos narudzbe preko unesenog ID-a narudzbe. Ukoliko je narudzba prazna, vraća 0.
        /// </summary> 
        public int IzracunajIznosNarudzbe(int idNarudzbe)
        {
            int iznosNarudzbe = 0;

            using (var db = new eat32Entities())
            {
                var stavkeNarudzbe = DohvatiStavkeNarudzbe(idNarudzbe);

                if (stavkeNarudzbe != null)
                {
                    foreach (var stavka in stavkeNarudzbe)
                    {
                        dbArtikl artikl = DohvatiArtikl(stavka.artikl_id);
                        iznosNarudzbe += int.Parse(artikl.cijena) * stavka.kolicina;
                    }
                }
            }

            return iznosNarudzbe;
        }

        /// <summary>
        /// Kreira narudžbu korisnika za zeljeni ugostiteljski objekt.
        /// </summary> 
        public dbNarudžba KreirajNarudzbu(int idUgostiteljskogObjekta, int idKorisnika, DateTime datumVrijeme)
        {
            using (var db = new eat32Entities())
            {
                dbNarudžba novaNarudzba = new dbNarudžba
                {
                    korisnik_id = idKorisnika,
                    ugostiteljski_obrt_id = idUgostiteljskogObjekta,
                    datum = datumVrijeme
                };

                db.dbNarudžba.Add(novaNarudzba);
                db.SaveChanges();

                return novaNarudzba;
            }
        }

        // <summary>
        /// Kreira recenziju korisnika za zeljenu narudžbu.
        /// </summary>
        /// 
        public dbRecenzija KreirajRecenziju(int idNarudzbe, int ocjenaNarudzbe, string komentarNarudzbe)
        {
            using (var db =new eat32Entities())
            {
                dbRecenzija novaRecenzija = new dbRecenzija
                {
                    narudzba_id = idNarudzbe,
                    komentar = komentarNarudzbe,
                    ocjena = ocjenaNarudzbe
                };

                db.dbRecenzija.Add(novaRecenzija);
                db.SaveChanges();

                return novaRecenzija;
            }
        }

        /// <summary>
        /// Kreira stavku narudzbe i automatski ju dodaje u narudzbu.
        /// </summary> 
        public void KreirajStavkuNarudzbe(int idArtikla, int idNarudzbe, int kolicinaValue)
        {
            using (var db = new eat32Entities())
            {
                dbStavkaNarudzbe novaStavka = new dbStavkaNarudzbe
                {
                    artikl_id = idArtikla,
                    narudzba_id = idNarudzbe,
                    kolicina = kolicinaValue,
                    popust = 0
                };

                db.dbStavkaNarudzbe.Add(novaStavka);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Funkcija prvo provjerava da li je korisnik već pretplaćen na ugostiteljski objekt, i ukoliko nije upisuje pretplatu u bazu i vraća false, a u suprotnom samo vraća true.
        /// </summary> 
        public bool PretplatiKorisnika(int idKorisnika, int idObjekta)
        {
            using (var db = new eat32Entities())
            {
                var pretraziPretplatu = db.dbPretplata.FirstOrDefault(r => r.korisnik_id == idKorisnika && r.ugostiteljski_obrt_id == idObjekta);

                if (pretraziPretplatu == null)
                {
                    dbPretplata novaPretplata = new dbPretplata
                    {
                        korisnik_id = idKorisnika,
                        ugostiteljski_obrt_id = idObjekta
                    };

                    db.dbPretplata.Add(novaPretplata);
                    db.SaveChanges();

                    return false;
                }

                else
                {
                    return true;
                }
            }
        }

        /// <summary>
        /// Funkcija šalje poruku svim korisnicima koji su pretplaćeni na ugostiteljski objekt sa zadanim ID-om.
        /// </summary> 
        public void ObavijestiPretplatnike(int idObjekta, string poruka)
        {
            using (var db = new eat32Entities())
            {
                var pretplaceniKorisnici = db.dbPretplata.Where(r => r.ugostiteljski_obrt_id == idObjekta);

                if (pretplaceniKorisnici != null)
                {
                    foreach (var item in pretplaceniKorisnici)
                    {
                        PosaljiPoruku(idObjekta, (int) item.korisnik_id, "[Pretplata]", poruka);
                    }
                }
            }
        }
    }
}
