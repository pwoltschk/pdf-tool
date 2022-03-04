  �        WORKDAY   �        YEARFRAC    �        EDATE   �        WEEKNUM   �        EOMONTH   �        NETWORKDAYS   �        ISEVEN    �        ISODD   �        MULTINOMIAL   �        SERIESSUM   �        QUOTIENT    �        MROUND    �        SQRTPI    �        RANDBETWEEN   �        GCD   �        LCM   �        BESSELI   �        BESSELJ   �        BESSELK   �        BESSELY   �        BIN2OCT   �        BIN2DEC   �        BIN2HEX   �        OCT2BIN   �        OCT2DEC   �        OCT2HEX   �        DEC2BIN   �        DEC2HEX   �        DEC2OCT   �        HEX2BIN   �        HEX2DEC   �        HEX2OCT   �        DELTA   �        ERF   �        ERFC    �        GESTEP    �        FACTDOUBLE    �        IMABS   �        IMAGINARY   �        IMPOWER   �        IMARGUMENT    �        IMCOS   �        IMDIV   �        IMEXP   �        IMCONJUGATE   �        IMLN    �        IMLOG10   �        IMLOG2    �        IMPRODUCT   �        IMREAL    �        IMSIN   �        IMSUB   �        IMSQRT    �        IMSUM   �        COMPLEX   �        CONVERT   �        AMORDEGRC   �        AMORLINC    �        ACCRINT   �        ACCRINTM    �        RECEIVED    �        DISC    �        DURATION    �        EFFECT    �        CUMPRINC    �        CUMIPMT   �        PRICE   �        PRICEDISC   �        PRICEMAT    �        MDURATION   �        NOMINAL   �        DOLLARFR             DOLLARDE            YIELD           YIELDDISC           YIELDMAT            TBILLEQ           TBILLPRICE            TBILLYIELD            ODDFPRICE           ODDFYIELD   	        ODDLPRICE   
        ODDLYIELD           XIRR            XNPV            INTRATE           COUPNCD           COUPDAYS            COUPDAYSNC            COUPDAYBS           COUPPCD           COUPNUM           FVSCHEDULE            IMTAN           IMSEC           IMCSC           IMCOT           IMSINH            IMCOSH            IMSECH            IMCSCH    �  y  8  8   Vrne zaporedno število datuma, ki je navedeno število delovnih dni pred ali za začetnim datumom      Začetni datum      Začetni datum      Dni     Število delovnih dni pred ali za začetnim datumom     Prazniki      Seznam datumskih vrednosti prostih dni (dopusti, prazniki, ipd.)        �  y       Vrne število let (vključno z neceloštevilskim delom) med dvema datumoma      Začetni datum      Začetni datum      Končni datum     Končni datum     Osnova      Osnova predstavlja konvencijo štetja dni, ki jo bo upošteval izračun       �  y   �   �   Vrne zaporedno število za datum, ki je navedeno število mesecev pred ali za začetnim datumom     Začetni datum      Začetni datum      Meseci      Število mesecev pred ali za začetnim datumom        �  y  `  `   Returns the number of the calendar week in which the specified date occurs.
This function exists for interoperability with older Microsoft Excel documents, for new documents use WEEKNUM instead.      Datum     Datum ali serijska številka datuma     Vrnitvena vrsta     Označuje prvi dan v tednu (1 = nedelja, 2 = ponedeljek).       �  y   �   �   Vrne zaporedno število za zadnji dan v mesecu, pred ali za navedenim številom mesecev     Začetni datum      Začetni datum      Meseci      Število mesecev pred ali za začetnim datumom        �  y  v  v   Returns the number of workdays between two dates.
This function exists for interoperability with older Microsoft Excel documents, for new documents use NETWORKDAYS instead.      Začetni datum      Začetni datum      Končni datum     Končni datum     Prazniki      Seznam datumskih vrednosti, ki predstavljajo proste dni (dopusti, prazniki ipd.)        �  y   b   b   Vrne vrednost »true«, če je število sodo      Število      Število        �  y   b   b   Vrne vrednost »true«, če je število liho      Število      Število        �  y   �   �   Vrne multinom množice števil      Število      Število ali seznam števil, za katera želite multinom       �  y  b  b   	Vrne vsoto potenčnega zaporedja, ki temelji na formuli     X     Neodvisna spremenljivka potenčnega zaporedja     N     Začetna potenca, s katero je potenciran X      M     Prirastek za povečanje n-ja vsakega člena vrste     Koeficienti     Nabor koeficientov, s katerim je pomnožena vsaka zaporedna potenca spremenljivke X       �  y   h   h   Vrne celi del deljenja      Števec     Deljenec      Imenovalec      Delitelj        �  y   �   �   Vrne število, zaokroženo na najbližji navedeni večkratnik     Število      Število, ki naj se zaokroži     Večkratnik     Večkratnik, na katerega naj se zaokroži število        �  y   �   �   Vrne kvadratni koren števila, pomnoženega s pi      Število      Število, s katerim je pomnožen pi       �  y   �   �   Vrne naključno celo število med navedenima številoma     Spodaj      Najmanjše vrnjeno celo število      Zgoraj      Največje vrnjeno celo število       �  y   �   �   Returns the greatest common divisor.
This function exists for interoperability with older Microsoft Excel documents, for new documents use GCD instead.     Število      Število ali seznam števil       �  y   �   �   Returns the least common multiple.
This function exists for interoperability with older Microsoft Excel documents, for new documents use LCM instead.     Število      Število ali seznam števil       �  y   �   �   Vrne prilagojeno Besselovo funkcijo In(x)     X     Vrednost, v kateri se funkcija preračunava     N     Ureditev Besselove funkcije       �  y   �   �   Vrne Besselovo funkcijo Jn(x)     X     Vrednost, v kateri se funkcija preračunava     N     Ureditev Besselove funkcije       �  y   �   �   Vrne prilagojeno Besselovo funkcijo Kn(x)     X     Vrednost, v kateri se funkcija preračunava     N     Ureditev Besselove funkcije       �  y   �   �   Vrne Besselovo funkcijo Yn(x)     X     Vrednost, v kateri se funkcija preračunava     N     Ureditev Besselove funkcije       �  y   �   �   Pretvori dvojiško število v osmiško      Število      Dvojiško število, ki se pretvori (kot besedilo)     Mesta     Število uporabljenih mest        �  y   �   �   Pretvori dvojiško število v desetiško      Število      Dvojiško število, ki se pretvori (kot besedilo)       �  y   �   �   Pretvori dvojiško število v šestnajstiško     Število      Dvojiško število, ki se pretvori (kot besedilo)     Mesta     Število uporabljenih mest.       �  y   �   �   Pretvori osmiško število v dvojiško      Število      Osmiško število, ki se pretvori (kot besedilo)      Mesta     Število uporabljenih mest           y   �   �   Pretvori osmiško število v desetiško     Število      Osmiško število, ki se pretvori (kot besedilo)          y   �   �   Pretvori osmiško število v šestnajstiško      Število      Osmiško število, ki se pretvori (kot besedilo)      Mesta     Število uporabljenih mest          y   �   �   Pretvori desetiško število v dvojiško      Število      Desetiško število, ki se pretvori     Mesta     Število uporabljenih mest          y   �   �   Pretvori desetiško število v šestnajstiško      Število      Desetiško število, ki se pretvori     Mesta     Število uporabljenih mest          y   �   �   Pretvori desetiško število v osmiško     Število      Desetiško število     Mesta     Število uporabljenih mest          y   �   �   Pretvori šestnajstiško število v dvojiško     Število      Šestnajstiško število, ki se pretvori (kot besedilo)     Mesta     Število uporabljenih mest          y   �   �   Pretvori šestnajstiško število v desetiško      Število      Šestnajstiško število, ki se pretvori (kot besedilo)         y   �   �   Pretvori šestnajstiško število v osmiško      Število      Šestnajstiško število, ki se pretvori (kot besedilo)     Mesta     Število uporabljenih mest          y   �   �   Preizkusi, ali sta dve vrednosti enaki      Število 1      Prvo število     Število 2      Drugo število        	  y   �   �   Vrne funkcijo napake      Spodnja meja      Spodnja meja za integracijo     Zgornja meja      Zgornja meja za integracijo       
  y   n   n   Vrne komplementarno funkcijo napake     Spodnja meja      Spodnja meja za integracijo         y   �   �   Preizkusi, ali je število večje od vrednosti praga      Število      Vrednost, ki se primerja s pragom     Prag      Mejna vrednost          y   T   T   Vrne dvojno fakulteto števila      Število      Število          y   ~   ~   Vrne absolutno vrednost (modul) kompleksnega števila     Kompleksno število     Kompleksno število         y   z   z   Vrne imaginarni koeficient kompleksnega števila      Kompleksno število     Kompleksno število         y   �   �   Vrne kompleksno število na realno potenco      Kompleksno število     Kompleksno število     Število      Potenca, s katero je potencirano kompleksno število          y   v   v   Vrne argument theta, kot izražen v radianih      Kompleksno število     Kompleksno število         y   l   l   Vrne kosinus kompleksnega števila      Kompleksno število     Kompleksno število         y   x   x   Vrne količnik dveh kompleksnih števil     Števec     Deljenec      Imenovalec      Delitelj          y   �   �   Vrne algebraično obliko eksponenta kompleksnega števila     Kompleksno število     Kompleksno število         y   �   �   Vrne kompleksno konjugirano število kompleksnega števila      Kompleksno število     Kompleksno število         y   v   v   Vrne naravni logaritem kompleksnega števila      Kompleksno število     Kompleksno število         y   z   z   Vrne logaritem z osnovo 10 kompleksnega števila      Kompleksno število     Kompleksno število         y   x   x   Vrne logaritem z osnovo 2 kompleksnega števila     Kompleksno število     Kompleksno število         y   �   �   Vrne zmnožek več kompleksnih števil      Kompleksno število     Prvo kompleksno število      Kompleksno število     Drugo kompleksno število         y   v   v   Vrne realni koeficiant kompleksnega števila      Kompleksno število     Kompleksno število         y   j   j   Vrne sinus kompleksnega števila      Kompleksno število     Kompleksno število         y   �   �   Vrne razliko dveh kompleksnih števil     Kompleksno število 1     Kompleksno število 1     Kompleksno število 2     Kompleksno število 2         y   t   t   Vrne kvadratni koren kompleksnega števila      Kompleksno število     Kompleksno število         y   h   h   Vrne vsoto kompleksnih števil      Kompleksno število     Kompleksno število         y   �   �   Pretvori realne in imaginarne koeficiente v kompleksno število     Realno število     Realni koeficent      Imaginarno število     Imaginarni koeficient     Pripona     Pripona         y   �   �   Pretvori število iz enega merskega sistema v drugega     Število      Število      Iz merske enote     Merska enota števila     V mersko enoto      Merska enota rezultata           y  �  �   Vrne linearno amortizacijo sredstev za vsako obračunsko obdobje      Stroški      Cena sredstva     Datum nakupa      Datum nakupa sredstva     Prvo obdobje      Datum konca prvega obdobja      Reševanje      Rešena vrednost na koncu življenjske dobe sredstva      Obdobje     Obdobje     Mera      Stopnja amortizacije      Osnova      Uporabljena letna osnova        !  y  �  �   Vrne linearno amortizacijo sredstev za vsako obračunsko obdobje      Stroški      Cena sredstva     Datum nakupa      Datum nakupa sredstva     Prvo obdobje      Datum konca prvega obdobja      Reševanje      Rešena vrednost na koncu življenjske dobe sredstva      Obdobje     Obdobje     Mera      Stopnja amortizacije      Osnova      Uporabljena letna osnova        "  y  x  x   Vrne nabrane (nezapadle) obresti za vrednostni papir, ki daje periodične obresti     Izdaja      Datum izdaje vrednostnega papirja     Prve obresti      Datum prvih obresti vrednostnega papirja      Poravnava     Poravnava     Mera      Stopnja     Imenska vrednost      Vrednost imenske vrednosti      Frekvenca     Frekvenca     Osnova      Osnova        #  y       Vrne nabrane (nezapadle) obresti za vrednostni papir, ki prinese obresti ob zapadlosti      Izdaja      Datum izdaje      Poravnava     Poravnava     Mera      Stopnja     Imenska vrednost      Vrednost imenske vrednosti      Osnova      Osnova        $  y   �   �   Vrne znesek, ki vam ga ob zapadlosti izplačajo za polno naložen vrednostni papir      Poravnava     Poravnava     Zapadlost     Zapadlost     Naložba      Naložba      Popust      Popust      Osnova      Osnova        %  y   �   �   Vrne diskontno stopnjo za vrednostni papir      Poravnava     Poravnava     Zapadlost     Zapadlost     Cena      Cena      Odkup     Odkupna vrednost      Osnova      Osnova        &  y         Vrne Macaulayevo povprečno sedanjo vrednost za vrednostni papir s periodičnimi izplačili obresti     Poravnava     Poravnava     Zapadlost     Zapadlost     Kupon     Obrestna mera kupona      Donos     Donos     Frekvenca     Frekvenca     Osnova      Osnova        '  y   �   �   Vrne efektivno letno obrestno mero      Nominalna stopnja     Nominalna obrestna mera     Npery     Obdobja       (  y  >  >   Vrne kumulativno (obrestno) glavnico za posojilo, izplačano med dvema obdobjema      Mera      Stopnja     Nper      Število obdobij za naložbo      Pv      Sedanja vrednost      Začetno obdobje      Začetno obdobje      Končno obdobje     Končno obdobje     Vrsta     Vrsta zapadlosti        )  y  &  &   Vrne kumulativne obresti, izplačane med dvema obdobjema      Mera      Stopnja     Nper      Število obdobij za naložbo      Pv      Sedanja vrednost      Začetno obdobje      Začetno obdobje      Končno obdobje     Končno obdobje     Vrsta     Vrsta zapadlosti        *  y  0  0   Vrne ceno na 100 valutnih enot imenske vrednosti za vrednostni papir, ki daje periodične obresti     Poravnava     Poravnava     Zapadlost     Zapadlost     Mera      Stopnja     Donos     Donos     Odkup     Odkupna vrednost      Frekvenca     Frekvenca     Osnova      Osnova        +  y   �   �   Vrne ceno za 100 valutnih enot imenske vrednosti za diskontirani vrednostni papir     Poravnava     Poravnava     Zapadlost     Zapadlost     Popust      Popust      Odkup     Odkupna vrednost      Osnova      Osnova        ,  y       Vrne ceno za 100 valutnih enot imenske vrednosti za vrednostni papir, ki prinese obresti ob zapadlosti      Poravnava     Poravnava     Zapadlost     Zapadlost     Izdaja      Datum izdaje      Mera      Stopnja     Donos     Donos     Osnova      Osnova        -  y  @  @   Vrne prilagojeno Macaulayevo povprečno sedanjo vrednost za vrednostni papir, katere privzeta imenska vrednost je 100 valutnih enot     Poravnava     Poravnava     Zapadlost     Zapadlost     Kupon     Obrestna mera kupona      Donos     Donos     Frekvenca     Frekvenca     Osnova      Osnova        .  y   �   �   Vrne imensko letno obrestno mero      Efektivna mera      Efektivna obrestna mera     Npery     Obdobja       /  y   �   �   Pretvori ceno, izraženo kot decimalno število, v ceno, izraženo kot ulomek     Dolar, izražen decimalno     Desetiško število     Ulomek      Delitelj        0  y   �   �   Pretvori ceno, izraženo kot ulomek, v ceno, izraženo kot decimalno število     Dolar, izražen z ulomkom     Število kot ulomek     Ulomek      Delitelj        1  y  
  
   Vrne donos za vrednostni papir, ki daje periodične obresti     Poravnava     Poravnava     Zapadlost     Zapadlost     Mera      Stopnja     Cena      Cena      Odkup     Odkupna vrednost      Frekvenca     Frekvenca     Osnova      Osnova        2  y   �   �   Vrne letni donos za diskontirani vrednostni papir     Poravnava     Poravnava     Zapadlost     Zapadlost     Cena      Cena      Odkup     Odkupna vrednost      Osnova      Osnova        3  y   �   �   Vrne letni donos za vrednostni papir, ki prinese obresti ob zapadlosti      Poravnava     Poravnava     Zapadlost     Zapadlost     Izdaja      Datum izdaje      Mera      Stopnja     Cena      Cena      Osnova      Osnova        4  y   �   �   Vrne donos za zakladno menico, kot da bi bila obveznica     Poravnava     Poravnava     Zapadlost     Zapadlost     Popust      Stopnja popusta       5  y   �   �   Vrne ceno 100 valutnih enot imenske vrednosti za zakladno menico      Poravnava     Poravnava     Zapadlost     Zapadlost     Popust      Stopnja popusta       6  y   �   �   Vrne donos za zakladno menico     Poravnava     Poravnava     Zapadlost     Zapadlost     Cena      Cena        7  y  r  r   Vrne ceno za vrednostni papir, ki ima imensko vrednost 100 valutnih enot in liho prvo obdobje     Poravnava     Poravnava     Zapadlost     Zapadlost     Izdaja      Datum izdaje      Prvi kupon      Datum prvega kupona     Mera      Stopnja     Donos     Donos     Odkup     Odkupna vrednost      Frekvenca     Frekvenca     Osnova      Osnova        8  y  N  N   Vrne donos za vrednostni papir, ki ima liho prvo obdobje      Poravnava     Poravnava     Zapadlost     Zapadlost     Izdaja      Datum izdaje      Prvi kupon      Datum prvega kupona     Mera      Stopnja     Cena      Cena      Odkup     Odkupna vrednost      Frekvenca     Frekvenca     Osnova      Osnova        9  y  \  \   Vrne ceno za vrednostni papir, ki ima imensko vrednost 100 valutnih enot in liho zadnje obdobje     Poravnava     Poravnava     Zapadlost     Zapadlost     Zadnje obresti      Datum zadnjih obresti     Mera      Stopnja     Donos     Donos     Odkup     Odkupna vrednost      Frekvenca     Frekvenca     Osnova      Osnova        :  y  8  8   Vrne donos za vrednostni papir, ki ima liho zadnje obdobje      Poravnava     Poravnava     Zapadlost     Zapadlost     Zadnje obresti      Datum zadnjih obresti     Mera      Stopnja     Cena      Cena      Odkup     Odkupna vrednost      Frekvenca     Frekvenca     Osnova      Osnova        ;  y   �   �   Vrne notranjo stopnjo donosa za časovni razpored denarnih tokov, ki ni nujno periodičen     Vrednosti     Vrednosti     Datumi      Datumi      Ocena     Ocena       <  y   �   �   Vrne čisto (neto) sedanjo vrednost za časovni razpored denarnih tokov, ki ni nujno periodičen      Mera      Stopnja     Vrednosti     Vrednosti     Datumi      Datumi        =  y   �   �   Vrne obrestno mero za polno naložen vrednostni papir     Poravnava     Poravnava     Zapadlost     Zapadlost     Naložba      Naložba      Odkup     Odkupna vrednost      Osnova      Osnova        >  y   �   �   	Vrne naslednji kuponski datum po datumu poravnave     Poravnava     Poravnava     Zapadlost     Zapadlost     Frekvenca     Frekvenca     Osnova      Osnova        ?  y   �   �   	Vrne število dni v kuponskem obdobju, ki vsebuje datum poravnave     Poravnava     Poravnava     Zapadlost     Zapadlost     Frekvenca     Frekvenca     Osnova      Osnova        @  y   �   �   	Vrne število dni od datuma poravnave do naslednjega kuponskega datuma      Poravnava     Poravnava     Zapadlost     Zapadlost     Frekvenca     Frekvenca     Osnova      Osnova        A  y   �   �   	Vrne število dni od začetka kuponskega obdobja do datuma poravnave      Poravnava     Poravnava     Zapadlost     Zapadlost     Frekvenca     Frekvenca     Osnova      Osnova        B  y   �   �   	Vrne zadnji kuponski datum pred datumom poravnave     Poravnava     Poravnava     Zapadlost     Zapadlost     Frekvenca     Frekvenca     Osnova      Osnova        C  y   �   �   	Vrne število kuponov, ki so izplačljivi med datumom poravnave in datumom zapadlosti     Poravnava     Poravnava     Zapadlost     Zapadlost     Frekvenca     Frekvenca     Osnova      Osnova        D  y   �   �   Vrne bodočo vrednost začetne glavnice po uporabi niza sestavljenih obrestnih mer      Glavnica      Glavnica      Razpored      Razpored        E  y   l   l   Vrne tangens kompleksnega števila      Kompleksno število     Kompleksno število       F  y   j   j   Vrne sekans kompleksnega števila     Kompleksno število     Kompleksno število       G  y   l   l   Vrne kosekans kompleksnega števila     Kompleksno število     Kompleksno število       H  y   n   n   Vrne kotangens kompleksnega števila      Kompleksno število     Kompleksno število       I  y   x   x   Vrne hiperbolični sinus kompleksnega števila.     Kompleksno število     Kompleksno število       J  y   z   z   Vrne hiperbolični kosinus kompleksnega števila.     Kompleksno število     Kompleksno število       K  y   z   z   Vrne hiperbolični sekans kompleksnega števila.      Kompleksno število     Kompleksno število       L  y   |   |   Vrne hiperbolični kosekans kompleksnega števila.      Kompleksno število     Kompleksno število        �           �     �  T�    �        �       �   2    �   H    �   `    �   x    �   �    �   �    �   �    �   �    �   �    �      �  *    �  B    �  ^    �  r    �  �    �  �    �  �    �  �    �  �    �  �    �      �  .    �  F    �  ^    �  v    �  �    �  �    �  �    �  �    �  �    �      �      �  0    �  F    �  ^    �  z    �  �    �  �    �  �    �  �    �  �    �  
    �       �  <    �  R    �  j    �  �    �  �    �  �    �  �    �  �    �  �    �      �  &    �  >    �  X    �  r    �  �    �  �    �  �    �  �    �  �    �      �       �  8    �  N    �  h    �  �    �  �    �  �       �      �      �            2      J      f      �      �    	  �    
  �      �                   .      F      `      |      �      �      �      �      �      	      	$      	:      	R      	j      	�  y  �  	�  y  �  
�  y  �  �  y  �  �  y  �    y  �  �  y  �  h  y  �  �  y  �  ,  y  �  �  y  �    y  �  x  y  �  F  y  �  �  y  �  x  y  �  V  y  �  2  y  �  �  y  �  b  y  �     y  �  �  y  �  @  y  �  �  y  �  z  y     (  y    �  y    `  y      y    �  y    :  y    �  y     �  y    !@  y  	  !�  y  
  "X  y    "�  y    #f  y    #�  y    $8  y    $�  y    %n  y    %�  y    &P  y    &�  y    'J  y    '�  y    (D  y    (�  y    )6  y    )�  y    *X  y    *�  y    +h  y    +�  y    ,D  y    -  y     -�  y  !  /`  y  "  0�  y  #  2`  y  $  3n  y  %  4^  y  &  5&  y  '  6F  y  (  6�  y  )  8  y  *  9.  y  +  :^  y  ,  ;P  y  -  <h  y  .  =�  y  /  >(  y  0  >�  y  1  ?�  y  2  @�  y  3  Al  y  4  Bd  y  5  C  y  6  C�  y  7  D@  y  8  E�  y  9  G   y  :  H\  y  ;  I�  y  <  JN  y  =  K  y  >  K�  y  ?  L�  y  @  Mh  y  A  N4  y  B  N�  y  C  O�  y  D  P�  y  E  Q2  y  F  Q�  y  G  R  y  H  Rt  y  I  R�  y  J  SZ  y  K  S�  y  L  TN  	�