  �        WORKDAY   �        YEARFRAC    �        EDATE   �        WEEKNUM   �        EOMONTH   �        NETWORKDAYS   �        ISEVEN    �        ISODD   �        MULTINOMIAL   �        SERIESSUM   �        QUOTIENT    �        MROUND    �        SQRTPI    �        RANDBETWEEN   �        GCD   �        LCM   �        BESSELI   �        BESSELJ   �        BESSELK   �        BESSELY   �        BIN2OCT   �        BIN2DEC   �        BIN2HEX   �        OCT2BIN   �        OCT2DEC   �        OCT2HEX   �        DEC2BIN   �        DEC2HEX   �        DEC2OCT   �        HEX2BIN   �        HEX2DEC   �        HEX2OCT   �        DELTA   �        ERF   �        ERFC    �        GESTEP    �        FACTDOUBLE    �        IMABS   �        IMAGINARY   �        IMPOWER   �        IMARGUMENT    �        IMCOS   �        IMDIV   �        IMEXP   �        IMCONJUGATE   �        IMLN    �        IMLOG10   �        IMLOG2    �        IMPRODUCT   �        IMREAL    �        IMSIN   �        IMSUB   �        IMSQRT    �        IMSUM   �        COMPLEX   �        CONVERT   �        AMORDEGRC   �        AMORLINC    �        ACCRINT   �        ACCRINTM    �        RECEIVED    �        DISC    �        DURATION    �        EFFECT    �        CUMPRINC    �        CUMIPMT   �        PRICE   �        PRICEDISC   �        PRICEMAT    �        MDURATION   �        NOMINAL   �        DOLLARFR             DOLLARDE            YIELD           YIELDDISC           YIELDMAT            TBILLEQ           TBILLPRICE            TBILLYIELD            ODDFPRICE           ODDFYIELD   	        ODDLPRICE   
        ODDLYIELD           XIRR            XNPV            INTRATE           COUPNCD           COUPDAYS            COUPDAYSNC            COUPDAYBS           COUPPCD           COUPNUM           FVSCHEDULE            IMTAN           IMSEC           IMCSC           IMCOT           IMSINH            IMCOSH            IMSECH            IMCSCH    �  y  �  �   Вяртае парадкавы нумар даты перад ці пасля пэўнай колькасці працоўных дзён      Start date      Пачатковая дата     Дні      Колькасць працадзён перад ці пасля пачатковай даты      Holidays      Спіс датаў, на якія прыпадаюць непрацоўныя дні (адпачынак, святы, і г.д.)       �  y  $  $   Returns the number of years (including fractional part) between two dates     Дата пачатку     Пачатковая дата     End date      Канчатковая дата     Basis     Basis indicates the day-count convention to use in the calculation        �  y  f  f   Вяртае парадкавы нумар даты, адлеглай на пэўную колькасць месяцаў ад пачатковай даты      Дата пачатку     Пачатковая дата     Месяцы      Колькасць месяцаў перад ці пасля пачатковай даты        �  y  `  `   Returns the number of the calendar week in which the specified date occurs.
This function exists for interoperability with older Microsoft Excel documents, for new documents use WEEKNUM instead.      Дата      The date or date serial number      Return type     Indicates the first day of the week (1 = Sunday, 2 = Monday)        �  y  �  �   Вяртае парадкавы нумар апошняга дня таго месяца, які з'яўляецца адлеглым на пэўную колькасць месяцаў ад пачатковай даты      Дата пачатку     Пачатковая дата     Месяцы      Колькасць месяцаў перад ці пасля пачатковай даты        �  y  �  �   Returns the number of workdays between two dates.
This function exists for interoperability with older Microsoft Excel documents, for new documents use NETWORKDAYS instead.      Дата пачатку     Пачатковая дата     Дата канца     Канчатковая дата     Holidays      Спіс датаў, на якія прыпадаюць непрацоўныя дні (адпачынак, святы, і г.д.)       �  y   ~   ~   Вяртае значэнне "сапраўдна" калі лік цотны     Number      Лік        �  y   �   �   Вяртае значэнне "сапраўдна" калі лік няцотны     Лік      Лік        �  y   �   �   Вяртае каэфіцыенты палінома мноства лікаў      Number      Лік або спіс лікаў, для якіх патрэбны каэфіцыенты палінома       �  y  �  �   	Вяртае суму ступеневага раду     X     Незалежная зменная ступеневага раду     N     Пачатковая ступень, да якой трэба падвысіць x      M     Прырост n для кожнага элемента раду      Coefficients      Мноства каэфіцыентаў множання усіх паслядоўных ступеней x       �  y   �   �   Вяртае цэлую частку дзелі     Numerator     Дзеліва      Denominator     Дзельнік        �  y   �   �   Вяртае лік, акруглены да пэўнага кратнага      Number      Лік дзеля акруглення      Multiple      Кратны лік, да якога жадаеце акругліць        �  y   �   �   Вяртае квадратавы корань ліку памножанага на "пі"      Number      Множнік "пі"       �  y   �   �   Вяртае выпадковы лік між двума пэўнымі лікамі      Знізу      Найменшы магчымы цэлы лік     Зверху      Найбольшы магчымы цэлы лік       �  y   �   �   Returns the greatest common divisor.
This function exists for interoperability with older Microsoft Excel documents, for new documents use GCD instead.     Number      Лік або спіс лікаў       �  y   �   �   Returns the least common multiple.
This function exists for interoperability with older Microsoft Excel documents, for new documents use LCM instead.     Number      Лік або спіс лікаў       �  y   �   �   Вяртае мадыфікаваную Беселеву функцыю In(x)     X     Аргумент для вылічэння функцыі     N     Парадак Беселевай функцыі        �  y   �   �   Вяртае Беселеву функцыю Jn(x)      X     The value at which the function is to be evaluated      N     The order of the Bessel function        �  y   �   �   Вяртае Беселеву функцыю Kn(x)      X     The value at which the function is to be evaluated      N     The order of the Bessel function        �  y   �   �   Вяртае Беселеву функцыю Yn(x)      X     The value at which the function is to be evaluated      N     The order of the Bessel function        �  y       Ператварае двайковы лік у васьмярковы лік     Number      Двайковы лік для ператварэння (у выглядзе тэксту)      Places      Колькасць занятых пазіцый        �  y   �   �   Ператварае двайковы лік у дзесятковы лік     Number      Двайковы лік для ператварэння (у выглядзе тэксту)        �  y       Ператварае двайковы лік у шаснаццаткавы лік     Number      Двайковы лік для ператварэння (у выглядзе тэксту)      Places      Колькасць занятых пазіцый.       �  y   �   �   Ператварае васьмярковы лік у двайковы лік     Number      Васьмярковы лік для ператварэння (у выглядзе тэксту)      Places      Number of places used          y   �   �   Ператварае васьмярковы лік у дзесятковы лік     Number      Васьмярковы лік для ператварэння (у выглядзе тэксту)          y       Ператварае двайковы лік у шаснаццаткавы лік     Number      Васьмярковы лік для ператварэння (у выглядзе тэксту)      Places      Number of places used         y   �   �   Ператварае дзесятковы лік у двайковы лік     Number      Дзесятковы лік для ператварэння     Places      Number of places used         y   �   �   Ператварае дзесятковы лік у шаснаццаткавы лік     Лік      Дзесятковы лік для ператварэння     Places      Колькасць занятых пазіцый          y   �   �   Ператварае дзесятковы лік у васьмярковы лік     Лік      Дзесятковы лік     Places      Колькасць занятых пазіцый          y       Ператварае шаснаццаткавы лік у двайковы лік     Лік      Шаснаццаткавы лік для ператварэння (у выглядзе тэксту)      Places      Number of places used         y   �   �   Ператварае шаснаццаткавы лік у дзесятковы лік     Number      Шаснаццаткавы лік для ператварэння (у выглядзе тэксту)          y  (  (   Ператварае шаснаццаткавы лік у васьмярковы лік     Number      Шаснаццаткавы лік для ператварэння (у выглядзе тэксту)      Places      Колькасць занятых пазіцый          y   �   �   Правярае, ці роўныя два значэнні     Number 1      Першы лік     Number 2      Другі лік       	  y   �   �   Вяртае функцыю памылкі      Lower limit     Ніжняя граніца інтэгравання      Upper limit     Верхняя граніца інтэгравання        
  y   �   �   Вяртае спалучаную функцыю памылкі     Ніжняя граніца     Ніжняя граніца інтэгравання          y   �   �   Правярае, ці пэўны лік большы за парогавае значэнне      Лік      Лік, які правяраецца     Step      Парогавае значэнне         y   j   j   Вяртае падвойны фактарыял ліку     Лік      Лік          y   �   �   Вяртае абсалютнае значэнне (модуль) камплекснага ліку     Complex number      Камплексны лік         y   �   �   Вяртае ўяўны каэфіцыент камплекснага ліку      Камплексны лік     Камплексны лік         y   �   �   Returns a complex number raised to a real power     Complex number      Камплексны лік     Лік      Ступень, да якой будзе падвышаны камплексны лік         y   �   �   Вяртае тэта-функцыю, значэнне вугла ў радыянах     Complex number      Камплексны лік         y   �   �   Вяртае косінус камплекснага ліку     Complex number      Камплексны лік         y   �   �   Вяртае дзель двух камплексных лікаў      Numerator     The dividend      Denominator     The divisor         y   �   �   Вяртае алгебраічную форму ад экспаненцыйнай формы запісу камплекснага ліку      Complex number      The complex number          y   �   �   Вяртае камплексны спалучаны лік ад камплекснага ліку      Complex number      Камплексны лік         y   �   �   Вяртае натуральны лагарыфм камплекснага ліку      Камплексны лік     Камплексны лік         y   �   �   Вяртае дзесятковы лагарыфм камплекснага ліку      Камплексны лік     Камплексны лік         y   �   �   Вяртае двайковы лагарыфм камплекснага ліку      Камплексны лік     Камплексны лік         y  
  
   Вяртае здабытак некалькіх камплексных лікаў      Камплексны лік     Першы камплексны лік      Камплексны лік     Наступны камплексны лік          y   �   �   Вяртае рэчаісную частку камплекснага ліку      Камплексны лік     Камплексны лік         y   �   �   Вяртае сінус камплекснага ліку     Камплексны лік     Камплексны лік         y   �   �   Вяртае розніцу двух камплексных лікаў      Камплексны лік 1     Камплексны лік 1     Камплексны лік 2     Камплексны лік 2         y   �   �   Вяртае квадратавы корань камплекснага ліку      Камплексны лік     Камплексны лік         y   �   �   Вяртае суму камплексных лікаў     Камплексны лік     Камплексны лік         y       Ператварае рэчаісны і ўяўны каэфіцыенты ў камплексны лік     Real num      Рэчаісны каэфіцыент     I num     Уяўны каэфіцыент     Suffix      Суфікс          y       Ператварае лік з адной сістэмы вымярэння ў іншую     Лік      Лік      From unit     Адзінка вымярэння аргумента      To unit     Адзінка вымярэння выніку           y  ^  ^   Вяртае значэнне лінейнай амартызацыі актыву за пэўны перыяд     Cost      Кошт актыву     Date purchased      Дата набыцця актыву      First period      Дата заканчэння першага перыяду     Salvage     Ліквідацыйная вартасць актыву ў канцы перыяду выкарыстання      Period      Перыяд      Rate      Працэнтавая стаўка амартызацыі      Базіс      Метад лічэння гадоў        !  y  z  z   Вяртае значэнне лінейнай амартызацыі актыву за пэўны перыяд     Кошт      Кошт актыву     Date purchased      Дата набыцця актыву      Першы перыяд     Дата заканчэння першага перыяду     Salvage     Ліквідацыйная вартасць актыву ў канцы перыяду выкарыстання      Перыяд      Перыяд      Стаўка      Працэнтавая стаўка амартызацыі      Базіс      Метад лічэння гадоў        "  y  ~  ~   Вяртае налічаны працэнт па каштоўнай паперы з перыядычнай выплатай працэнта     Issue     Дата выпуску каштоўнай паперы     First interest      Першая дата выплаты працэнта па каштоўнай паперы      Settlement      Дата разліку/атрымання      Стаўка      Працэнтавая стаўка     Par     Намінальная вартасць     Frequency     Перыядычнасць      Базіс      Метад вылічэння перыяду        #  y  >  >   Вяртае налічаны працэнт па каштоўнай паперы з выплатай працэнта пры пагашэнні      Issue     Дата выпуску     Settlement      The settlement      Rate      The rate      Par     The par value     Basis     The basis       $  y  P  P   Вяртае выплату пры пагашэнні цалкам інвеставанай каштоўнай паперы     Settlement      The settlement      Maturity      Пагашэнне      Investment      Інвестыцыя      Discount      Скідка (дысконт)     Basis     The basis       %  y       Вяртае дысконтную стаўку для каштоўнай паперы     Settlement      The settlement      Maturity      The maturity      Price     Кошт      Redemption      Кошт выкупу     Basis     The basis       &  y  �  �   Вяртае сярэдне-узважаны тэрмін пагашэння каштоўнай паперы з перыядычнай выплатай працэнта (формула Маколея)      Settlement      The settlement      Maturity      The maturity      Coupon      Намінальная працэнтавая стаўка      Yield     Прыбытак (дэбіт)     Frequency     The frequency     Basis     The basis       '  y   �   �   Вяртае эфектыўную гадавую працэнтавую стаўку      Nominal rate      Намінальная стаўка     Npery     Колькасць перыядаў       (  y  �  �   Вяртае акумуляваную асноўную выплату на пазыку між двума перыядамі      Rate      The rate      Nper      Колькасць перыядаў выплат      Pv      Актуальнае значэнне     Start period      Пачатковы перыяд     End period      Канчатковы перыяд     Тып      Тып пагашэння       )  y  �  �   Вяртае акумуляваны працэнт дзеля выплаты між двума перыядамі     Rate      The rate      Nper      Колькасць перыядаў выплат      Pv      Актуальнае значэнне     Пачатковы перыяд     Пачатковы перыяд     Канцавы перыяд     Канчатковы перыяд     Тып      Тып пагашэння       *  y       Вяртае кошт на 100 грашовых адзінак намінальнай вартасці каштоўнай паперы з перыядычнай выплатай працэнта      Settlement      The settlement      Maturity      Пагашэнне      Rate      Працэнтавая стаўка     Yield     The yield     Redemption      Кошт выкупу     Частата      Перыядычнасць      Базіс      Метад вылічэння перыяду        +  y  �  �   Вяртае кошт на 100 грашовых адзінак намінальнай вартасці дысконтавай каштоўнай паперы     Settlement      Дата разліку/атрымання      Пагашэнне      Пагашэнне      Discount      The discount      Redemption      The redemption value      Basis     The basis       ,  y  �  �   Вяртае кошт на 100 грашовых адзінак намінальнай вартасці каштоўнай паперы з выплатай працэнта пры пагашэнні     Settlement      The settlement      Maturity      The maturity      Issue     Дата выпуску     Rate      The rate      Yield     The yield     Basis     The basis       -  y  �  �   Вяртае мадыфікаваны тэрмін Маколея для каштоўнай паперы з даўніманай намінальнай вартасцю 100 грашовых адзінак      Settlement      The settlement      Maturity      The maturity      Coupon      The coupon rate     Yield     The yield     Frequency     The frequency     Basis     The basis       .  y   �   �   Вяртае гадавую намінальную працэнтавую стаўку      Effective rate      Эфектыўная працэнтавая стаўка      Npery     The periods       /  y   �   �   Ператварае кошт з дзесятковага значэння ў дробавае значэнне     Decimal dollar      The decimal number      Fraction      The divisor       0  y   �   �   Ператварае кошт з дробавага значэння ў дзесятковае значэнне     Fractional dollar     Лік як дробавае значэнне     Fraction      The divisor       1  y  �  �   Вяртае прыбытак (дэбіт) па каштоўнай паперы з перыядычнай выплатай працэнта     Settlement      The settlement      Maturity      The maturity      Rate      The rate      Price     The price     Redemption      The redemption value      Frequency     Перыядычнасць      Basis     The basis       2  y  &  &   Вяртае гадавы прыбытак (дэбіт) з дысконтнай каштоўнай паперы     Settlement      The settlement      Maturity      The maturity      Price     The price     Redemption      The redemption value      Basis     The basis       3  y  �  �   Вяртае гадавы прыбытак (дэбіт) з каштоўнай паперы з выплатай працэнта пры пагашэнні     Settlement      Дата разліку/атрымання      Пагашэнне      Пагашэнне      Issue     Дата выпуску     Rate      The rate      Price     The price     Basis     The basis       4  y       Вяртае эквівалентны аблігацыі прыбытак (дэбіт) для казначэйскага вэксаля     Settlement      The settlement      Maturity      The maturity      Discount      Дысконтная стаўка       5  y       Вяртае кошт на 100 грашовых адзінак намінальнай вартасці казначэйскага вэксаля      Settlement      The settlement      Maturity      The maturity      Discount      The discount rate       6  y   �   �   Вяртае прыбытак (дэбіт) для казначэйскага вэксаля     Settlement      The settlement      Maturity      The maturity      Price     The price       7  y       Вяртае кошт на $100 грашовых адзінак намінальнай вартасці каштоўнай паперы з нерэгулярным першым перыядам     Settlement      The settlement      Maturity      The maturity      Issue     The issue date      First coupon      Першая дата налічэння працэнта     Rate      The rate      Yield     The yield     Redemption      The redemption value      Frequency     The frequency     Basis     The basis       8  y  X  X   Вяртае прыбытак (дэбіт) з каштоўнай паперы з нерэгулярным першым перыядам     Settlement      The settlement      Maturity      The maturity      Issue     Дата выпуску     Першы купон     Першая дата налічэння працэнта     Стаўка      Працэнтавая стаўка     Цана      Кошт      Выкуп      Кошт выкупу     Частата      Перыядычнасць      Базіс      Метад вылічэння перыяду        9  y       Вяртае кошт на $100 адзінак намінальнай вартасці каштоўнай паперы з нерэгулярным апошнім перыядам      Settlement      The settlement      Maturity      The maturity      Last interest     Апошняя дата налічэння працэнта     Rate      The rate      Yield     The yield     Redemption      The redemption value      Частата      Перыядычнасць      Basis     The basis       :  y  �  �   Вяртае прыбытак (дэбіт) з каштоўнай паперы з нерэгулярным апошнім перыядам     Settlement      The settlement      Maturity      The maturity      Last interest     The last interest date      Rate      The rate      Price     The price     Redemption      The redemption value      Frequency     The frequency     Basis     The basis       ;  y   �   �   Вяртае ўнутраная норма прыбытку для неперыядычнай схемы выплат     Значэнні      Вартасці      Dates     Даты      Guess     Ацэнка        <  y   �   �   Вяртае чыстую актуальную/дыскантаваную вартасць для неперыядычнай схемы выплат      Rate      The rate      Values      The values      Dates     The dates       =  y  @  @   Вяртае працэнтавую стаўку для цалкам інвеставанай каштоўнай паперы     Settlement      The settlement      Maturity      The maturity      Investment      The investment      Redemption      The redemption value      Basis     The basis       >  y       	Вяртае першую дату налічэння працэнта пасля даты разліку/атрымання      Settlement      The settlement      Maturity      The maturity      Frequency     The frequency     Basis     The basis       ?  y  6  6   	Вяртае колькасць дзён у перыядзе налічэння працэнта, які ўлучае дату разліку/атрымання      Settlement      The settlement      Maturity      The maturity      Frequency     The frequency     Basis     The basis       @  y  �  �   	Вяртае колькасць дзён ад даты разліку/атрымання да наступнай даты налічэння працэнта     Settlement      The settlement      Пагашэнне      Пагашэнне      Частата      Перыядычнасць      Базіс      Метад вылічэння перыяду        A  y  N  N   	Вяртае колькасць дзён ад пачатку перыяду налічэння працэнта да даты разліку/атрымання     Settlement      The settlement      Maturity      Пагашэнне      Частата      Перыядычнасць      Basis     The basis       B  y  :  :   	Вяртае апошнюю дату налічэння працэнта перад датай разліку/атрымання      Settlement      The settlement      Пагашэнне      Пагашэнне      Частата      Перыядычнасць      Basis     The basis       C  y  T  T   	Вяртае колькасць налічаных працэнтаў, якія могуць выплачвацца між датамі разліку/атрымання і пагашэння     Settlement      The settlement      Maturity      The maturity      Frequency     The frequency     Basis     The basis       D  y   �   �   Вяртае будучую вартасць асноўнай інвестыцыі пасля налічэння складаных працэнтаў      Principal     Інвестыцыя      Schedule      Працэнты        E  y   �   �   Вяртае тангенс камплекснага ліку     Камплексны лік     Камплексны лік       F  y   �   �   Вяртае секанс камплекснага ліку     Камплексны лік     Камплексны лік       G  y   �   �   Вяртае касеканс камплекснага ліку     Камплексны лік     Камплексны лік       H  y   �   �   Вяртае катангенс камплекснага ліку     Камплексны лік     Камплексны лік       I  y   �   �   Вяртае гіпербалічны сінус камплекснага ліку      Камплексны лік     Камплексны лік       J  y   �   �   Вяртае гіпербалічны косінус камплекснага ліку      Камплексны лік     Камплексны лік       K  y   �   �   Вяртае гіпербалічны секанс камплекснага ліку      Камплексны лік     Камплексны лік       L  y   �   �   Вяртае гіпербалічны касеканс камплекснага ліку      Камплексны лік     Камплексны лік        �           �     �  v6    �        �       �   2    �   H    �   `    �   x    �   �    �   �    �   �    �   �    �   �    �      �  *    �  B    �  ^    �  r    �  �    �  �    �  �    �  �    �  �    �  �    �      �  .    �  F    �  ^    �  v    �  �    �  �    �  �    �  �    �  �    �      �      �  0    �  F    �  ^    �  z    �  �    �  �    �  �    �  �    �  �    �  
    �       �  <    �  R    �  j    �  �    �  �    �  �    �  �    �  �    �  �    �      �  &    �  >    �  X    �  r    �  �    �  �    �  �    �  �    �  �    �      �       �  8    �  N    �  h    �  �    �  �    �  �       �      �      �            2      J      f      �      �    	  �    
  �      �                   .      F      `      |      �      �      �      �      �      	      	$      	:      	R      	j      	�  y  �  	�  y  �  t  y  �  �  y  �  �  y  �  ^  y  �    y  �  �  y  �  V  y  �  �  y  �  �  y  �  �  y  �    y  �    y  �  �  y  �  �  y  �  �  y  �  b  y  �  H  y  �  �  y  �  �  y  �  j  y  �  ~  y  �   N  y  �  !f  y     "d  y    #@  y    $B  y    %  y    &  y    &�  y    '�  y    (�  y    )�  y  	  *�  y  
  +t  y    ,&  y    -  y    -p  y    .   y    .�  y    /�  y    0N  y    0�  y    1t  y    2F  y    2�  y    3�  y    4R  y    4�  y    6  y    6�  y    7@  y    8(  y    8�  y    9b  y    :h  y     ;z  y  !  =�  y  "  @R  y  #  B�  y  $  D  y  %  E^  y  &  Fj  y  '  H@  y  (  I  y  )  J�  y  *  L�  y  +  N�  y  ,  P4  y  -  Q�  y  .  S^  y  /  T:  y  0  U  y  1  U�  y  2  W�  y  3  X�  y  4  Z8  y  5  [P  y  6  \b  y  7  ]2  y  8  _P  y  9  a�  y  :  c�  y  ;  eV  y  <  fD  y  =  g>  y  >  h~  y  ?  i�  y  @  j�  y  A  lF  y  B  m�  y  C  n�  y  D  p"  y  E  q  y  F  q�  y  G  rH  y  H  r�  y  I  sz  y  J  t&  y  K  t�  y  L  u�  	�