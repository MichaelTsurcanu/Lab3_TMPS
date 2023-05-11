# Lab3_TMPS
Design patterns:
Composite
Decorator
Facade
Flyweight

1.Pattern-ul Composite:
Pattern-ul Composite este un pattern de proiectare structural care îți permite să tratezi obiectele individuale și compozițiile de obiecte în mod uniform. El compune obiectele în structuri de tip arbore pentru a reprezenta ierarhii de tip parte-întreg. Acest pattern permite clienților să lucreze cu obiecte individuale și grupuri de obiecte într-un mod consistent. Ideea principală este că un component poate fi fie o frunză (fără componente copil), fie un compozit (care conține unul sau mai multe componente copil). Acesta ajută la simplificarea codului clientului și oferă o modalitate transparentă de manipulare a structurilor complexe de obiecte.

2.Pattern-ul Decorator:
Pattern-ul Decorator este un pattern de proiectare structural care permite adăugarea dinamică a unui comportament sau a unor responsabilități noi la un obiect fără a modifica structura acestuia. Acesta implică încapsularea unui obiect într-un alt obiect și furnizarea de funcționalități suplimentare prin împilarea decoratoarelor în mod dinamic. Fiecare decorator din stivă adaugă propriul său comportament, iar combinația de decoratoare îmbunătățește capacitățile obiectului. Acest pattern urmează principiul "deschis-închis", deoarece permite extinderea comportamentului obiectelor fără a modifica direct codul acestora.

3.Pattern-ul Facade:
Pattern-ul Facade este un pattern de proiectare structural care oferă o interfață simplificată către un subsistem complex de clase, facilitând utilizarea acestuia. El acționează ca o interfață la un nivel superior care ascunde complexitățile sistemului subiacent, oferind o interfață mai convenabilă și unificată pentru clienți. Pattern-ul Facade promovează cuplarea slabă prin reducerea dependențelor directe dintre codul clientului și subsistem, rezultând un cod mai ușor de întreținut și de reutilizat.

4.Pattern-ul Flyweight:
Pattern-ul Flyweight este un pattern de proiectare structural care minimizează utilizarea memoriei prin partajarea datelor comune între mai multe obiecte similare. Scopul său este de a obține eficiență atunci când se lucrează cu un număr mare de obiecte care au caracteristici comune, prin stocarea datelor comune într-un loc extern și partajarea acestora între obiecte. Datele unice specifice fiecărui obiect, cunoscute sub denumirea de stare intrinsecă, sunt stocate intern. Prin separarea stărilor intrinseci și extrinseci, pattern-ul Flyweight reduce consumul de memorie și îmbunătățește performanța.


Concluzie : 
Pattern-urile de proiectare descrise anterior sunt instrumente valoroase în dezvoltarea software-ului, deoarece oferă soluții la problemele comune de proiectare și promovează principii de proiectare eficiente. Ele ne permit să creăm sisteme flexibile, reutilizabile și ușor de întreținut. Utilizarea acestor pattern-uri poate conduce la cod mai clar, modular și extensibil, precum și la o separare mai bună a responsabilităților în cadrul aplicațiilor. Prin aplicarea adecvată a acestor pattern-uri, putem construi aplicații mai robuste, mai scalabile și mai ușor de înțeles și de modificat în viitor.
