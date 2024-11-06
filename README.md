# ProductViewerApp

VAROITUS: Muista lisätä Newtonsoft.json Nuget-paketti ensin!<br />
**Arvokkaat koodin osat (MVC)**
<br />
1)Model - Product.cs - Luokka, joka kuvaa tuotteen kokonaisuutena. Se tallentaa kaikki tuotteen kuvaamiseen tarvittavat ominaisuudet;<br />
2)View - Product.cshtm - Verkkosivu, joka näytetään käyttäjälle;<br />
3)Controller - HomeController.cs - Looginen koodiosa, joka kertoo sivulle, milloin se tulee näkyviin. Ohjaimet käsittelevät sivun tapahtumia ja navigointia.<br />
<br />
- products.json - On tietokannan testiesitys tässä esimerkissä. Tähän tiedostoon tallennetaan tiedot tuotteista 1 ja 2.
<br />
Kun käyttäjä napsauttaa Tuotteet-sivua, HomeController luo luettelon tuotteista käyttämällä funktiota GetProducts(). GetProducts-funktion sisällä ohjelma lukee tiedot products.json-tiedostosta ja luo sitten luettelon mallityypin Product mukaisista objekteista, joiden ominaisuudet on lueteltu product.json-tiedostossa. Tämän jälkeen HomeController lähettää tämän tuoteluettelon View:hen näyttääkseen sen käyttäjälle. View näyttää käyttäjälle jokaisen luettelon elementin tuotekorttina.
