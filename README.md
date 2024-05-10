APLICATIE DE PREVESTIRE A STARII VREMII

Proiect realizat de: Tomescu Ioana-Mihaela
Profesor coordonator: Timofte Carmen

1.Intoducere
Bun venit la WeatherNow - aplicația care vă aduce informații meteorologice în timp real, construită pe platforma Web Forms cu tehnologia C#! Cu WeatherNow, aveți acces la o gamă largă de date meteorologice pentru orice oraș din lume, livrate direct pe ecranul dispozitivului dumneavoastră.
Cum funcționează WeatherNow? E simplu! Pur și simplu introduceți numele orașului dorit în câmpul de căutare și apăsați butonul "Află Vremea". Aplicația va face apoi o cerere către OpenWeatherMap API pentru a obține cele mai recente date meteorologice pentru orașul specificat.
Ce informații puteți obține cu WeatherNow? De la temperatura actuală și umiditate până la temperatura maximă și minină pe termen scurt, așadar WeatherNow vă oferă o imagine completă a condițiilor meteorologice actuale. Puteți folosi aceste informații pentru a vă planifica activitățile în aer liber, pentru a vă decide ce să purtați sau pur și simplu pentru a fi la curent cu schimbările de vreme în timp real.
WeatherNow vă oferă o experiență simplă și intuitivă, astfel încât să puteți obține rapid informațiile de care aveți nevoie, fără a pierde timp prețios. În plus, datorită platformei Web Forms, aplicația noastră este ușor de utilizat și se poate accesa de pe orice dispozitiv conectat la internet.
Cu WeatherNow, nu trebuie să mai rămâneți niciodată în întuneric cu privire la condițiile meteorologice. Descoperiți acum cât de ușor și convenabil poate fi să vă mențineți la curent cu vremea din orașul dumneavoastră și din întreaga lume!
2.Descriere problemă
Cu această aplicație web, utilizatorii pot obține rapid informații esențiale despre vremea dintr-un anumit oraș fără a fi nevoie să caute pe mai multe site-uri sau să utilizeze mai multe aplicații. Interfața simplă și intuitivă permite introducerea rapidă a numelui orașului și afișează imediat datele meteorologice relevante, cum ar fi temperatura medie, temperatura maximă și umiditatea actuală.
Prin integrarea unei baze de date Firebase, aplicația oferă și funcționalitatea de stocare a datelor meteorologice pentru fiecare oraș căutat. Aceasta înseamnă că utilizatorii pot accesa istoricul datelor meteorologice pentru orașul lor preferat și pot urmări schimbările de vreme în timp. De asemenea, funcționalitatea de stocare în cloud oferă un avantaj suplimentar deoarece utilizatorii pot accesa datele lor de pe mai multe dispozitive fără a pierde informațiile salvate.
În plus, aplicația poate fi extinsă în viitor pentru a include și alte caracteristici utile, cum ar fi previziunile pe termen lung, avertismente meteorologice sau posibilitatea de a seta notificări personalizate pentru schimbările meteorologice importante. Este o soluție versatilă și practică pentru cei care doresc să fie mereu la curent cu condițiile meteorologice într-un anumit oraș.

3. Descriere API
Pentru acest proiect am folosit WeatherMap API, FireBase și pltaforma Azure de la Microsoft. 
OpenWeatherMap API este un serviciu de programare care oferă acces la date meteorologice globale în timp real și prognoze meteorologice pentru diverse locații din întreaga lume. Am integrat acest API în aplicația mea, numită WeatherNow, pentru a furniza utilizatorilor informații precise despre condițiile meteorologice într-un anumit oraș. Aplicația WeatherNow utilizează un request către OpenWeatherMap API pentru a obține datele meteorologice, cum ar fi temperatura actuală, temperatura maximă, temperatura minimă și umiditatea, pentru orașul specificat de utilizator. Aceste date sunt apoi afișate în aplicație pentru ca utilizatorii să poată fi la curent cu vremea în locațiile lor preferate. Utilizarea OpenWeatherMap API este esențială pentru funcționarea corectă și eficientă a aplicației WeatherNow și pentru a oferi o experiență de utilizare optimă utilizatorilor.
Aplicația WeatherNow oferă utilizatorilor informații actualizate despre vremea dintr-un anumit oraș. Pentru a asigura o experiență de utilizare fluentă și pentru a permite utilizatorilor să acceseze datele meteorologice anterioare, am integrat un sistem de stocare a datelor în cloud folosind baza de date Firebase. Acest serviciu de gestionare a bazelor de date oferă un API ușor de utilizat, care ne permite să stocăm și să accesăm informațiile meteorologice pentru fiecare oraș căutat de utilizatori.
Astfel, atunci când utilizatorii accesează WeatherNow pentru a verifica vremea într-un anumit oraș, datele meteorologice sunt extrase din baza de date Firebase și afișate în timp real în aplicație. De asemenea, această integrare cu Firebase ne permite să gestionăm eficient datele, să efectuăm actualizări în timp real și să oferim o experiență de utilizare coerentă și fiabilă pentru toți utilizatorii noștri. Firebase servește ca un element crucial în spatele aplicației WeatherNow, asigurându-ne că datele sunt stocate în siguranță și accesibile în orice moment.
4. Flux de date
În cadrul proiectului WeatherNow, aplicația a fost implementată și gazduită pe platforma Azure, una dintre cele mai populare platforme de cloud computing. Implementarea pe Azure oferă mai multe beneficii, cum ar fi scalabilitatea, securitatea și fiabilitatea, permițând utilizatorilor să acceseze aplicația fără întârzieri și întreruperi.
Pentru a obține date meteorologice în timp real, aplicația a folosit serviciul cloud de la OpenWeatherMap API. Acest serviciu oferă date meteorologice actuale și prognoze meteorologice pentru locații din întreaga lume și a fost integrat în aplicație pentru a furniza informații precise și actualizate despre vremea din orașul specificat de utilizator.
De asemenea, pentru stocarea datelor meteorologice și a altor informații relevante, aplicația a folosit baza de date Firebase, care este un serviciu de cloud oferit de Google. Firebase Realtime Database este un serviciu de bază de date NoSQL în timp real, care permite sincronizarea și partajarea datelor în timp real între utilizatori și dispozitive. 
Prin utilizarea acestor servicii de cloud, aplicația WeatherNow beneficiază de performanță, scalabilitate și securitate superioare, oferind utilizatorilor o experiență de utilizare fluidă și fiabilă.
În cadrul aplicației WeatherNow, fluxul de date implică preluarea datelor meteorologice de la serviciul OpenWeatherMap API și stocarea acestora în baza de date Firebase. 
Mai jos este un scurt rezumat al fluxului de date, împreună cu exemple de request-uri și response-uri și metode HTTP utilizate:
  1.Solicitarea datelor meteorologice de la OpenWeatherMap API:
•	Metoda HTTP: GET
•	Exemplu de request:
GET: https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}
Exemplu de response:
json
Copy code
{
  "name": "City Name",
  "main": {
    "temp": 293.15, // Temperatura în Kelvin
    "temp_min": 290.15, // Temperatura minimă în Kelvin
    "temp_max": 296.15, // Temperatura maximă în Kelvin
    "humidity": 70 // Umiditatea în procente
  }
}
2.Transformarea datelor meteorologice și afișarea acestora în aplicație:
•	Datele primite sunt procesate pentru a extrage informațiile necesare, cum ar fi temperatura, temperatura minimă, temperatura maximă și umiditatea.
•	Aceste date sunt afișate în interfața aplicației WeatherNow pentru a informa utilizatorii despre condițiile meteorologice curente în orașul specificat.
3.Stocarea datelor în baza de date Firebase:
•	Metoda HTTP: POST

Exemplu de request:
POST https://proiect-cloud-c2a96-default-rtdb.europe-         west1.firebasedatabase.app/Orase/{city}.json
{
  "cityJson": "City Name",
  "temperatureJson": "Temperature",
  "temperatureMin": "Minimum Temperature",
  "temperatureMax": "Maximum Temperature",
  "humidity": "Humidity"
}
Exemplu de response: Un răspuns de succes indicând că datele au fost salvate cu succes în baza de date Firebase.
Acest flux de date demonstrează cum aplicația WeatherNow utilizează API-ul OpenWeatherMap pentru a obține date meteorologice și Firebase pentru a stoca aceste date în cloud, oferind astfel o experiență completă utilizatorilor în ceea ce privește informațiile meteorologice și gestionarea acestora.
5. Capturi ecran aplicație
6. Referințe
https://openweathermap.org/api 
https://firebase.google.com/ 
https://portal.azure.com/#home 
https://www.youtube.com/watch?v=jZMwwZHJXJc&list=PLuv4McUMmyAbsNdfZ4rH_OyEM3P2MJS-F

Link YouTube: https://www.youtube.com/watch?v=yaN-IRJbiJc
Link aplicație: https://proiectcloudioanatomescu20240509234209.azurewebsites.net/WebForm1.aspx
Link repository git:
https://github.com/ioanaaaaTomescu/proiect_cloud_computing

