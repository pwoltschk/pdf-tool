  �        ARBETSDAGAR   �        ÅRDEL    �        EDATUM    �        VECKONR   �        SLUTMÅNAD    �     "   "NETTOARBETSDAGAR    �        ÄRJÄMN    �        ÄRUDDA   �        MULTINOMIAL   �        SERIESUMMA    �        KVOT    �        MAVRUNDA    �        ROTPI   �        SLUMP.MELLAN    �        SGD   �        MGM   �        BESSELI   �        BESSELJ   �        BESSELK   �        BESSELY   �        BIN.TILL.OKT    �        BIN.TILL.DEC    �        BIN.TIll.HEX    �        OKT.TILL.BIN    �        OKT.TILL.DEC    �        OKT.TILL.HEX    �        DEC.TILL.BIN    �        DEC.TILL.HEX    �        DEC.TILL.OKT    �        HEX.TILL.BIN    �        HEX.TILL.DEC    �        HEX.TILL.OKT    �        DELTA   �        FELF    �        FELFK   �        SLSTEG    �          DUBBELFAKULTET    �        IMABS   �        IMAGINÄR   �        IMUPPHÖJT    �        IMARGUMENT    �        IMCOS   �        IMDIV   �        IMEUPPHÖJT   �        IMKONJUGAT    �        IMLN    �        IMLOG10   �        IMLOG2    �        IMPRODUKT   �        IMREAL    �        IMSIN   �        IMDIFF    �        IMROT   �        IMSUM   �        KOMPLEX   �        KONVERTERA    �        AMORDEGRC   �        AMORLINC    �        UPPLRÄNTA    �        UPPLOBLRÄNTA   �        BELOPP    �        DISK    �        LÖPTID   �        EFFRÄNTA   �        KUMPRIS   �        KUMRÄNTA   �        PRIS    �        PRISDISK    �        PRISFÖRF   �        MLÖPTID    �        NOMRÄNTA   �        BRÅK            DECTAL            NOMAVK            NOMAVKDISK            NOMAVKFÖRF           SSVXEKV           SSVXPRIS            SSVXRÄNTA            UDDAFPRIS             UDDAFAVKASTNING   	        UDDASPRIS   
          UDDASAVKASTNING           XIRR            XNUVÄRDE           ÅRSRÄNTA            KUPNKD            KUPDAGB           KUPDAGNK            KUPDAGBB            KUPFKD            KUPANT            FÖRRÄNTNING           IMTAN           IMSEC           IMCSC           IMCOT           IMSINH            IMCOSH            IMSECH            IMCSCH    �  y  6  6   Returnerar serienumret för datumet som ligger före eller efter ett visst antal arbetsdagar.     Startdatum      Startdatum      Dagar     Antalet arbetsdagar före eller efter startdatumet.     Lediga dagar      Lista med datumvärden för lediga dagar (semester, helgdagar o.s.v.).        �  y   �   �   Returnerar antal år (samt delar av ett år) mellan två datum      Startdatum      Startdatum      Slutdatum     Slutdatum     Bas     Bas anger vilken konvention som ska användas för att räkna dagar       �  y   �   �   Returnerar serienumret för det datum som ligger ett visst antal månader före resp. efter startdatumet.     Startdatum      Startdatum      Månader      Antal månader före eller efter startdatum.        �  y  b  b   Returns the number of the calendar week in which the specified date occurs.
This function exists for interoperability with older Microsoft Excel documents, for new documents use WEEKNUM instead.      Datum     Datumet eller datumets serienummer      Returtyp      Definierar den första dagen i veckan (1 = söndag, 2 = måndag)        �  y       Returnerar ett serienummer för det datum som representerar den sista dagen i månaden som ligger ett visst antal månader före eller efter startdatumet.      Startdatum      Startdatum      Månader      Antal månader före eller efter startdatum.        �  y  l  l   Returns the number of workdays between two dates.
This function exists for interoperability with older Microsoft Excel documents, for new documents use NETWORKDAYS instead.      Startdatum      Startdatum      Slutdatum     Slutdatum     Lediga dagar      Lista med datumvärden som representerar lediga dagar (semester, helgdagar o.s.v.).       �  y   V   V   Returnerar värdet SANT om talet är jämnt.      Tal     Tal       �  y   T   T   Returnerar värdet SANT om talet är udda.      Tal     Tal       �  y   �   �   Beräknar multinomialkoefficienten för en grupp av tal.      Tal     Tal eller lista med tal vars multinomialkoefficienter ska bestämmas.       �  y  N  N   	Beräknar summan av en potensserie.     X     Oberoende variabel i potensserien.      N     Initialpotens som x ska upphöjas till.     M     Steg med vilket n ska ökas i varje term i serien.      Koefficienter     Grupp av koefficienter som varje efterföljande potens av variabeln x ska multipliceras med.        �  y   �   �   Returnerar heltalsdelen av en division.     Täljare      Täljare (dividend)     Nämnare      Nämnare (divisor)        �  y   �   �   Returnerar ett tal avrundat till en multipel.     Tal     Talet som ska avrundas      Multipel      Värdet vars multipel talet ska avrundas till.        �  y   `   `   Beräknar kvadratroten ur ett tal multiplicerat med pi.     Tal     Tal       �  y   �   �   Returnerar ett slumptal mellan de tal som du anger.     Minsta tal      Det minsta talet som ska returneras.      Största tal      Det största talet som ska returneras.        �  y   �   �   Returns the greatest common divisor.
This function exists for interoperability with older Microsoft Excel documents, for new documents use GCD instead.     Tal     Tal eller lista med tal       �  y   �   �   Returns the least common multiple.
This function exists for interoperability with older Microsoft Excel documents, for new documents use LCM instead.     Tal     Tal eller lista med tal       �  y   �   �   Beräknar den modifierade Bessel-funktionen In(x).      X     Värdet som funktionen ska beräknas för.      N     Ordningstalet för Bessel-funktionen        �  y   �   �   Beräknar Bessel-funktionen Jn(x).      X     Värdet som funktionen ska beräknas för.      N     Ordningstalet för Bessel-funktionen        �  y   �   �   Beräknar den modifierade Bessel-funktionen Kn(x).      X     Värdet som funktionen ska beräknas för.      N     Ordningstalet för Bessel-funktionen        �  y   �   �   Beräknar Bessel-funktionen Yn(x).      X     Värdet som funktionen ska beräknas för.      N     Ordningstalet för Bessel-funktionen        �  y   �   �   Omvandlar ett binärt tal till ett oktalt.      Tal     Binärt tal (som text)      Antal siffror     Antal använda siffror.       �  y   j   j   Omvandlar ett binärt tal till ett decimalt.      Tal     Binärt tal (som text)        �  y   �   �   Omvandlar ett binärt tal till ett hexadecimalt.      Tal     Binärt tal (som text)      Antal siffror     Antal använda siffror.       �  y   �   �   Omvandlar ett oktalt tal till ett binärt.      Tal     Oktalt tal (som text)     Antal siffror     Antal använda siffror.          y   f   f   Omvandlar ett oktalt tal till ett decimalt.     Tal     Oktalt tal (som text)         y   �   �   Omvandlar ett oktalt tal till ett hexadecimalt.     Tal     Oktalt tal (som text)     Antal siffror     Antal använda siffror.         y   �   �   Omvandlar ett decimalt tal till ett binärt.      Tal     Decimaltal      Antal siffror     Antal använda siffror.         y   �   �   Omvandlar ett decimalt tal till ett hexadecimalt.     Tal     Decimaltal      Antal siffror     Antal använda siffror.         y   �   �   Omvandlar ett decimalt tal till ett oktalt.     Tal     Decimaltal      Antal siffror     Antal använda siffror.         y   �   �   Omvandlar ett hexadecimalt tal till ett binärt.      Tal     Hexadecimalt tal (som text)     Antal siffror     Antal använda siffror.         y   r   r   Omvandlar ett hexadecimalt tal till ett decimalt.     Tal     Hexadecimalt tal (som text)         y   �   �   Omvandlar ett hexadecimalt tal till ett oktalt.     Tal     Hexadecimalt tal (som text)     Antal siffror     Antal använda siffror.         y   v   v   Kontrollerar om två värden är lika.      Tal 1     Första talet     Tal 2     Andra talet       	  y   �   �   Returnerar felfunktionen.     Undre gräns      Undre gräns för integration.      Övre gräns      Övre gräns för integration.        
  y   |   |   Returnerar den komplementära felfunktionen.      Undre gräns      Undre gräns för integration.          y   �   �   Kontrollerar om ett tal är större än ett tröskelvärde.     Tal     Värde som ska kontrolleras mot tröskelvärde.     Tröskelvärde      Tröskelvärde          y   R   R   Returnerar dubbelfakulteten för ett tal.     Tal     Tal         y   l   l   Returnerar absolutvärdet av ett komplext tal.      Komplext tal      Komplext tal          y   z   z   Returnerar den imaginära koefficienten av ett komplext tal.      Komplext tal      Komplext tal          y   �   �   Returnerar ett komplext tal upphöjt med ett heltal     Komplext tal      Komplext tal      Tal     Exponent som det komplexa talet upphöjs med.         y   �   �   Returnerar en vinkel uttryckt i radianer för visning av ett komplext tal med trigonometriskt skrivsätt.     Komplext tal      Komplext tal          y   d   d   Returnerar cosinus av ett komplext tal.     Komplext tal      Komplext tal          y   �   �   Returnerar kvoten av två komplexa tal.     Täljare      Täljare (dividend)     Nämnare      Nämnare (divisor)          y   �   �   Returnerar den algebraiska formen av ett komplext tal i exponentiell visning.     Komplext tal      Komplext tal          y   v   v   Returnerar det komplexa konjugatet till ett komplext tal.     Komplext tal      Komplext tal          y   v   v   Returnerar den naturliga logaritmen av ett komplext tal.      Komplext tal      Komplext tal          y   j   j   Returnerar 10-logaritmen av ett komplext tal.     Komplext tal      Komplext tal          y   h   h   Returnerar 2-logaritmen av ett komplext tal     Komplext tal      Komplext tal          y   �   �   Returnerar produkten av flera komplexa tal      Complex number      Första komplexa talet      Complex number      Ytterligare komplext tal          y   n   n   Returnerar realkoefficienten av ett komplext tal.     Komplext tal      Komplext tal          y   b   b   Returnerar sinus av ett komplext tal.     Komplext tal      Komplext tal          y   �   �   Returnerar differensen mellan två komplexa tal.      Complex number 1      Complex number 1      Complex number 2      Complex number 2          y   j   j   Returnerar kvadratroten ur ett komplext tal.      Komplext tal      Komplext tal          y   ^   ^   Returnerar summan av komplexa tal     Komplext tal      Komplext tal          y   �   �   Omvandlar en real- och en imaginärkoefficient till ett komplext tal.     Realdel     Realdel     Imaginärdel      Imaginärdel      Suffix      Suffix          y   �   �   Omvandlar ett tal från ett måttsystem till ett annat.     Tal     Tal     Ursprungsenhet      Måttenhet för tal.      Ny enhet      Resultatets måttenhet.          y  �  �   Returnerar avskrivningsbeloppet för en redovisningsperiod enligt det franska bokföringssystemet.      Kostnader     Anskaffningskostnader för tillgången.     Datum     Anskaffningsdatum för tillgången      Första period      Datum för slutet på den första perioden.     Restvärde      Restvärdet för tillgången i slutet av livslängden.      Period      Period      Ränta      Avskrivningssats      Bas     Årsbas som ska användas.        !  y  �  �   Returnerar avskrivningsbeloppet för en redovisningsperiod enligt det franska bokföringssystemet.      Kostnader     Anskaffningskostnader för tillgången.     Datum     Anskaffningsdatum för tillgången      Första period      Datum för slutet på den första perioden.     Restvärde      Restvärde för tillgången i slutet av livslängden.     Period      Period      Ränta      Avskrivningssats      Bas     Årsbas som ska användas.        "  y  |  |   Returnerar de upplupna räntorna för ett värdepapper med periodisk räntebetalning.     Emission      Datum för värdepappersemission.     Första kupongdatum     Första räntedatum för värdepapperet.      Betalning     Betalning     Ränta      Nominell ränta     Nominellt värde      Nominellt värde      Frekvens      Frekvens      Bas     Bas       #  y   �   �   Returnerar ett värdepappers upplupna räntor som betalas ut på förfallodagen.      Emission      Emission      Betalning     Betalning     Ränta      Nominell ränta     Nominellt värde      Nominellt värde      Bas     Bas       $  y       Returnerar beloppet som utbetalas på förfallodagen för ett fullinvesterat värdepapper.      Betalning     Betalning     Förfallodag      Förfallodag      Investering     Investering     Diskonteringsränta     Diskonteringsränta     Bas     Bas       %  y   �   �   Returnerar diskonteringsräntan för ett värdepapper     Betalning     Betalning     Förfallodag      Förfallodag      Pris      Pris      Inlösningsvärde     Inlösningsvärde     Bas     Bas       &  y  ,  ,   Returnerar den årliga Macauley-löptiden för ett värdepapper med periodisk räntebetalning.      Betalning     Betalning     Förfallodag      Förfallodag      Nominell ränta     Nominell ränta     Avkastning      Avkastning      Frekvens      Frekvens      Bas     Bas       '  y   �   �   Returnerar den årliga effektiva räntan.     Nominell ränta     Nominell ränta     Perioder      Perioder        (  y  N  N   Returnerar den ackumulerade amorteringen som har betalats på ett lån som ska betalas mellan två perioder.      Ränta      Nominell ränta     Perioder      Antal betalningsperioder.     Nuvärde      Nuvärde      Startperiod     Startperiod     Slutperiod      Slutperiod      Typ     Typ av förfallodag       )  y  (  (   Returnerar den ackumulerade räntan som betalats mellan två perioder.      Ränta      Nominell ränta     Perioder      Antal betalningsperioder.     Nuvärde      Nuvärde      Startperiod     Startperiod     Slutperiod      Slutperiod      Typ     Typ av förfallodag       *  y  \  \   Returnerar priset per 100 valutaenheter nominellt värde för ett värdepapper som ger periodiska räntor.      Betalning     Betalning     Förfallodag      Förfallodag      Ränta      Nominell ränta     Avkastning      Avkastning      Inlösningsvärde     Inlösningsvärde     Frekvens      Frekvens      Bas     Bas       +  y         Returnerar priset per 100 valutaenheter nominellt värde för ett diskonterat värdepapper.     Betalning     Betalning     Förfallodag      Förfallodag      Diskonteringsränta     Diskonteringsränta     Inlösningsvärde     Inlösningsvärde     Bas     Bas       ,  y  8  8   Returnerar priset per 100 valutaenheter nominellt värde för ett värdepapper som ger räntor på förfallodagen.      Betalning     Betalning     Förfallodag      Förfallodag      Emission      Emission      Ränta      Nominell ränta     Avkastning      Avkastning      Bas     Bas       -  y  @  @   Returnerar den modifierade Macauley-löptiden för ett värdepapper med ett nominellt värde på 100 valutaenheter.     Betalning     Betalning     Förfallodag      Förfallodag      Nominell ränta     Nominell ränta     Avkastning      Avkastning      Frekvens      Frekvens      Bas     Bas       .  y   �   �   Returnerar den årliga nominella räntesatsen.      Effektiv ränta     Effektiv ränta     Perioder      Perioder        /  y   �   �   Konverterar en notering uttryckt som ett decimaltal till en notering uttryckt som ett bråk.      Tal     Decimaltal      Nämnare      Nämnare (divisor)        0  y   �   �   Konverterar en notering uttryckt som ett bråk till ett decimaltal.     Tal     Tal     Nämnare      Nämnare (divisor)        1  y  4  4   Returnerar avkastningen på ett värdepapper som betalar ut räntor periodiskt.     Betalning     Betalning     Förfallodag      Förfallodag      Ränta      Nominell ränta     Pris      Pris      Inlösningsvärde     Inlösningsvärde     Frekvens      Frekvens      Bas     Bas       2  y   �   �   Returnerar den årliga avkastningen för ett diskonterat värdepapper.      Betalning     Betalning     Förfallodag      Förfallodag      Pris      Pris      Inlösningsvärde     Inlösningsvärde     Bas     Bas       3  y       Returnerar den årliga avkastningen för ett värdepapper som ger ränta på förfallodagen.      Betalning     Betalning     Förfallodag      Förfallodag      Emission      Emission      Ränta      Nominell ränta     Pris      Pris      Bas     Bas       4  y   �   �   Räknar om räntan på en statsskuldsväxel till den årliga ränta som obligationer brukar ha.     Betalning     Betalning     Förfallodag      Förfallodag      Diskonteringsränta     Diskonteringsränta       5  y   �   �   Returnerar priset per 100 valutaenheter nominellt värde för en statsskuldväxel.      Betalning     Betalning     Förfallodag      Förfallodag      Diskonteringsränta     Diskonteringsränta       6  y   �   �   Returnerar avkastningen för en statsskuldväxel.     Betalning     Betalning     Förfallodag      Förfallodag      Pris      Pris        7  y  �  �   Returnerar priset per 100 valutaenheter nominellt värde för ett värdepapper med en udda första period     Betalning     Betalning     Förfallodag      Förfallodag      Emission      Emission      Första kupongdatum     Första kupongdatum     Ränta      Nominell ränta     Avkastning      Avkastning      Inlösningsvärde     Inlösningsvärde     Frekvens      Frekvens      Bas     Bas       8  y  z  z   Returnerar avkastningen för ett värdepapper med en udda första period.     Betalning     Betalning     Förfallodag      Förfallodag      Emission      Emission      Första kupongdatum     Första kupongdatum     Ränta      Nominell ränta     Pris      Pris      Inlösningsvärde     Inlösningsvärde     Frekvens      Frekvens      Bas     Bas       9  y  �  �   Returnerar priset per 100 valutaenheter nominellt värde för ett värdepapper med en udda sista period     Betalning     Betalning     Förfallodag      Förfallodag      Sista kupongdatum     Sista kupongdatum     Ränta      Nominell ränta     Avkastning      Avkastning      Inlösningsvärde     Inlösningsvärde     Frekvens      Frekvens      Bas     Bas       :  y  X  X   Returnerar avkastningen för ett värdepapper med en udda sista period.     Betalning     Betalning     Förfallodag      Förfallodag      Sista kupongdatum     Sista kupongdatum     Ränta      Nominell ränta     Pris      Pris      Inlösningsvärde     Inlösningsvärde     Frekvens      Frekvens      Bas     Bas       ;  y   �   �   Returnerar internräntan för en serie betalningar som inte är periodiska.     Värden     Värden     Tidpunkter      Tidpunkter      Gissning      Gissning        <  y   �   �   Returnerar nettonuvärdet (kapitalvärde) för en rad betalningar som inte är periodiska.      Ränta      Nominell ränta     Värden     Värden     Tidpunkter      Tidpunkter        =  y   �   �   Returnerar räntesatsen för ett fullinvesterat värdepapper.     Betalning     Betalning     Förfallodag      Förfallodag      Investering     Investering     Inlösningsvärde     Inlösningsvärde     Bas     Bas       >  y   �   �   	Returnerar första kupongdatum efter likviddagen.     Betalning     Betalning     Förfallodag      Förfallodag      Frekvens      Frekvens      Bas     Bas       ?  y   �   �   	Returnerar antalet dagar i ränteperioden som innehåller likviddagen.      Betalning     Betalning     Förfallodag      Förfallodag      Frekvens      Frekvens      Bas     Bas       @  y   �   �   	Returnerar antalet dagar från likviddatum till nästa kupongdatum.     Betalning     Betalning     Förfallodag      Förfallodag      Frekvens      Frekvens      Bas     Bas       A  y   �   �   	Returnerar antalet dagar från början av kupongperioden till likviddatum.      Betalning     Betalning     Förfallodag      Förfallodag      Frekvens      Frekvens      Bas     Bas       B  y   �   �   	Returnerar senste kupongdatum före likviddatum.      Betalning     Betalning     Förfallodag      Förfallodag      Frekvens      Frekvens      Bas     Bas       C  y   �   �   	Returnerar antalet kuponger mellan likvid- och förfallodatum.      Betalning     Betalning     Förfallodag      Förfallodag      Frekvens      Frekvens      Bas     Bas       D  y   �   �   Returnerar ett framtida värde av ett begynnelsekapital för en rad periodiskt olika räntesatser.      Kapital     Kapital     Räntor     Räntor       E  y   f   f   Returnerar tangensen av ett komplext tal      Komplext tal      Komplext tal        F  y   d   d   Returnerar sekanten av ett komplext tal     Komplext tal      Komplext tal        G  y   f   f   Returnerar cosekanten av ett komplext tal     Komplext tal      Komplext tal        H  y   h   h   Returnerar cotangensen av ett komplext tal      Komplext tal      Komplext tal        I  y   p   p   Returnerar hyperbolisk sinus för ett komplext tal      Komplext tal      Komplext tal        J  y   r   r   Returnerar hyperbolisk cosinus för ett komplext tal      Komplext tal      Komplext tal        K  y   v   v   Returnerar den hyperboliska sekanten av ett komplext tal      Komplext tal      Komplext tal        L  y   x   x   Returnerar den hyperboliska cosekanten av ett komplext tal      Komplext tal      Komplext tal         �           �     �  V�    �        �       �   4    �   L    �   d    �   �    �   �    �   �    �   �    �   �    �      �  "    �  <    �  R    �  p    �  �    �  �    �  �    �  �    �  �    �  �    �      �  4    �  R    �  p    �  �    �  �    �  �    �  �    �      �  $    �  B    �  `    �  v    �  �    �  �    �  �    �  �    �  �    �  
    �  &    �  B    �  X    �  n    �  �    �  �    �  �    �  �    �  �    �      �      �  4    �  L    �  b    �  x    �  �    �  �    �  �    �  �    �  �    �      �  2    �  H    �  `    �  z    �  �    �  �    �  �    �  �    �  �    �      �  *       @      X      p      �      �      �      �      �          	  0    
  J      j      �      �      �      �      �      	       	      	2      	J      	h      	~      	�      	�      	�      	�      	�      
  y  �  
   y  �  V  y  �  :  y  �    y  �  ~  y  �  �  y  �  �  y  �  T  y  �  �  y  �  L  y  �  �  y  �  &  y  �  �  y  �  2  y  �  �  y  �  �  y  �  �  y  �  N  y  �  �  y  �  �  y  �  D  y  �  �  y  �  D  y  �  �  y     t  y    �  y    r  y    �  y    �  y      y    �  y     *  y     �  y  	  !>  y  
  !�  y    "X  y    #  y    #b  y    #�  y    $H  y    $�  y    %�  y    %�  y    &�  y    '  y    '�  y    '�  y    (h  y    (�  y    )v  y    )�  y    *F  y    *�  y    +R  y    +�  y    ,b  y     -  y  !  .�  y  "  0�  y  #  2H  y  $  3F  y  %  4Z  y  &  58  y  '  6d  y  (  6�  y  )  88  y  *  9`  y  +  :�  y  ,  ;�  y  -  =  y  .  >T  y  /  >�  y  0  ?�  y  1  @&  y  2  AZ  y  3  BJ  y  4  C`  y  5  DH  y  6  E$  y  7  E�  y  8  Gh  y  9  H�  y  :  Jf  y  ;  K�  y  <  Lv  y  =  MB  y  >  N4  y  ?  N�  y  @  O�  y  A  P~  y  B  QN  y  C  R  y  D  R�  y  E  St  y  F  S�  y  G  T>  y  H  T�  y  I  U  y  J  U|  y  K  U�  y  L  Vd  	�