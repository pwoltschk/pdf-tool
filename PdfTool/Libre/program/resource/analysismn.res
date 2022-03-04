  �        WORKDAY   �        YEARFRAC    �        EDATE   �        WEEKNUM   �        EOMONTH   �        NETWORKDAYS   �        ISEVEN    �        ISODD   �        MULTINOMIAL   �        SERIESSUM   �        QUOTIENT    �        MROUND    �        SQRTPI    �        RANDBETWEEN   �        GCD   �        LCM   �        BESSELI   �        BESSELJ   �        BESSELK   �        BESSELY   �        BIN2OCT   �        BIN2DEC   �        BIN2HEX   �        OCT2BIN   �        OCT2DEC   �        OCT2HEX   �        DEC2BIN   �        DEC2HEX   �        DEC2OCT   �        HEX2BIN   �        HEX2DEC   �        HEX2OCT   �        DELTA   �        ERF   �        ERFC    �        GESTEP    �        FACTDOUBLE    �        IMABS   �        IMAGINARY   �        IMPOWER   �        IMARGUMENT    �        IMCOS   �        IMDIV   �        IMEXP   �        IMCONJUGATE   �        IMLN    �        IMLOG10   �        IMLOG2    �        IMPRODUCT   �        IMREAL    �        IMSIN   �        IMSUB   �        IMSQRT    �        IMSUM   �        COMPLEX   �        CONVERT   �        AMORDEGRC   �        AMORLINC    �        ACCRINT   �        ACCRINTM    �        RECEIVED    �        DISC    �        DURATION    �        EFFECT    �        CUMPRINC    �        CUMIPMT   �        PRICE   �        PRICEDISC   �        PRICEMAT    �        MDURATION   �        NOMINAL   �        DOLLARFR             DOLLARDE            YIELD           YIELDDISC           YIELDMAT            TBILLEQ           TBILLPRICE            TBILLYIELD            ODDFPRICE           ODDFYIELD   	        ODDLPRICE   
        ODDLYIELD           XIRR            XNPV            INTRATE           COUPNCD           COUPDAYS            COUPDAYSNC            COUPDAYBS           COUPPCD           COUPNUM           FVSCHEDULE            IMTAN           IMSEC           IMCSC           IMCOT           IMSINH            IMCOSH            IMSECH            IMCSCH    �  y  �  �   Тодорхой тооны ажлын өдрийн дараах эсвэл өмнөх огнооны тоог нийлүүлнэ.      Эхлэл огноо     Эхлэл огноо     Өдөр      Эхлэл огнооны дараах эсвэл өмнөх ажлын өдрийн тоо     Баярын өдрүүд     Чөлөөтэй өдрийн огноог жагсаа (Амралт, Баярын өдөр гэх мэт).        �  y  *  *   Returns the number of years (including fractional part) between two dates     Эхлэл огноо     Эхлэл огноо     Төгсгөл огноо     Төгсгөл огноо     Суурь      Basis indicates the day-count convention to use in the calculation        �  y  D  D   Эхлэл огнооноос тодорхой тооны сарын дараах эсвэл өмнөх огнооны тоог нийлүүлнэ.     Эхлэл огноо     Эхлэл огноо     Сар      Эхлэл огнооноос өмнөх эсвэл дараах сарын тоо        �  y  n  n   Returns the number of the calendar week in which the specified date occurs.
This function exists for interoperability with older Microsoft Excel documents, for new documents use WEEKNUM instead.      Огноо      The date or date serial number      Буцаах төрөл     Indicates the first day of the week (1 = Sunday, 2 = Monday)        �  y  �  �   Эхлэл огнооноос тодорхой тооны сарын өмнө эсвэл дараа буй сарын сүүлийн өдрийг илэрхийлэх огнооны дэс тоог буцаана.     Эхлэл огноо     Эхлэл огноо     Сар      Эхлэл огнооноос өмнөх эсвэл дараах сарын тоо        �  y  �  �   Returns the number of workdays between two dates.
This function exists for interoperability with older Microsoft Excel documents, for new documents use NETWORKDAYS instead.      Эхлэл огноо     Эхлэл огноо     Төгсгөл огноо     Төгсгөл огноо     Баярын өдөр     Амралтын өдрүүдийн жагсаалт        �  y   r   r   Хэрэв тэгш тоо бол 'true' утга буцаана      Тоо      Тоо        �  y   x   x   Хэрэв сондгой тоо бол 'true' утга буцаана      Тоо      Тоо        �  y   �   �   Тоон олонлогийн полиномиаль коэффициентыг буцаана      Number      полиномиаль коэффициентыг олох ёстой тоо эсвэл тоон цуваа.        �  y  D  D   	Зэрэгт цувааны нийлбэрийг буцаана     X     Зэрэгт цувааны үл хамаарах хувьсагч      N     x-ийн эхний зэрэг      M     n-ийг ихэсгэх алхам      Коэффициент      x-ийн коэффициентууд       �  y   �   �   Бүхлээр хуваана     Хүртвэр      Хуваагдагч      Хуваарь      Хуваагч        �  y   �   �   Олон дахин бүхэлтгэсэн тоог буцаана      Тоо      Бүхэлтгэх тоо     Хуваагдагч      Олон дахин бүхэлтгэх утга       �  y   �   �   Пи-гээр үржүүлээд квадрат язгуур авна     Тоо      Пи-гээр үржүүлэх тоо       �  y  &  &   Өгөгдсөн тоонуудын хооронд орших санамсаргүй бүхэл тоо буцаана     Доод      Хамгийн бага бүхэл тоог буцаана      Дээд      Хамгийн их бүхэл тоог буцаана        �  y   �   �   Returns the greatest common divisor.
This function exists for interoperability with older Microsoft Excel documents, for new documents use GCD instead.     Number      Тоо эсвэл тоон жагсаалт       �  y   �   �   Returns the least common multiple.
This function exists for interoperability with older Microsoft Excel documents, for new documents use LCM instead.     Number      Тоо эсвэл тоон жагсаалт       �  y   �   �   Бессель функц In(x)     X     Аргументын утга     N     Бессель функцийн эрэмбэ        �  y   �   �   Бессель функц Jn(x)     X     Аргументын утга     N     Бессель функцийн эрэмбэ        �  y   �   �   Бессель функц Kn(x)     X     Аргументын утга     N     Бессель функцийн эрэмбэ        �  y   �   �   Бессель функц Yn(x)     X     Аргументын утга     N     Бессель функцийн эрэмбэ        �  y   �   �   Хоёртын системээс наймтынхад шилжүүлнэ     Тоо      Тооны хоёртын бичлэг      Орон      Оронгийн тоо       �  y   �   �   Хоёртын системээс аравтынхад шилжүүлнэ     Тоо      Тооны хоёртын бичлэг        �  y   �   �   Хоёртын системээс арван зургаатынхад шилжүүлнэ      Тоо      Тооны хоёртын бичлэг      Орон      Оронгийн тоо       �  y   �   �   Наймтын системээс хоёртын тоололд шилжүүлнэ      Тоо      Тооны наймтын бичлэг      Орон      Оронгийн тоо          y   �   �   Наймтын системээс аравтынхад шилжүүлнэ     Тоо      Тооны наймтын бичлэг          y   �   �   Наймтын системээс арван зургаатынхад шилжүүлнэ      Тоо      Тооны наймтын бичлэг      Орон      Оронгийн тоо         y   �   �   Аравтын системээс хоёртын тоололд шилжүүлнэ      Тоо      Тооны аравтын бичлэг      Орон      Оронгийн тоо         y   �   �   Аравтын системээс арван зургаатынхад шилжүүлнэ      Тоо      Тооны аравтын бичлэг      Орон      Оронгийн тоо         y   �   �   Аравтын системээс наймтынхад шилжүүлнэ     Тоо      Аравтын тоо     Орон      Оронгийн тоо         y   �   �   Арван зургаатын системээс хоёртын тоололд шилжүүлнэ     Тоо      Арван зургаатын тоо (бичвэрээр)     Орон      Оронгийн тоо         y   �   �   Арван зургаатын системээс аравтынхад шилжүүлнэ      Тоо      Арван зургаатын тоо (бичвэрээр)         y   �   �   Арван зургаатын системээс наймтынхад шилжүүлнэ      Тоо      Арван зургаатын тоо (бичвэрээр)     Орон      Оронгийн тоо         y   �   �   Хоёр утгыг хоорондоо тэнцүү эсэхийг шинжинэ     Тоо 1      Эхний тоо     Тоо 1      Хоёрдах тоо       	  y   �   �   Гауссын алдааны функцийг буцаана     Доод хязгаар     Интегралын доод хязгаар      Дээд хязгаар     Интегралын дээд хязгаар        
  y   �   �   Гауссын алдааны функцийн нэмэлтийг буцаана.     Доод хязгаар     Интегралын доод хязгаар          y   �   �   Тоог босгын утгаас их эсэхийг шинжинэ     Тоо      Босго утганд шалгах утга     Алхам      The threshold value         y   n   n   Тооны давхар факториалыг буцаана     Тоо      Тоо          y   �   �   Комплекс тооны абсолют утгыг буцаана      Комплекс тоо     Комплекс тоо         y   �   �   Комплекс тооны хуурмаг хэсгийг буцаана      Комплекс тоо     Комплекс тоо         y   �   �   Returns a complex number raised to a real power     Комплекс тоо     Комплекс тоо     Тоо      Комплекс тоог дэвшүүлэх зэрэг         y   �   �   Комплекс тооны аргументыг буцаана     Комплекс тоо     Комплекс тоо         y   �   �   Комплекс тооны косинусийг буцаана     Комплекс тоо     Комплекс тоо         y   �   �   Комплекс тоонуудын харьцааг буцаана     Тоолуур      Хуваагдагч      Хуваарь      Хуваагч          y   �   �   Комплекс тооны экспоненциалыг алгебрын хэлбэрт буцаана     Комплекс тоо     Комплекс тоо         y   �   �   Комплекс тооны хосмогийг буцаана     Комплекс тоо     Комплекс тоо         y   �   �   Комплекс тооны натурал логарифмыг буцаана      Комплекс тоо     Комплекс тоо         y   �   �   Комплекс тооны 10 суурьтай логарифмыг буцаана     Комплекс тоо     Комплекс тоо         y   �   �   Комплекс тооны 2 суурьтай логарифмыг буцаана      Комплекс тоо     Комплекс тоо         y   �   �   Комплекс тоонуудын үржвэрийг буцаана     Complex number      Эхний комплекс тоо      Complex number      Өөр комплекс тоо          y   �   �   Комплекс тооны бодит хэсгийг буцаана      Комплекс тоо     Комплекс тоо         y   �   �   Комплекс тооны синусийг буцаана     Комплекс тоо     Комплекс тоо         y   �   �   Комплекс тоонуудын ялгаврыг буцаана     Complex number 1      Complex number 1      Complex number 2      Complex number 2          y   �   �   Комплекс тооны квадратыг буцаана     Комплекс тоо     Комплекс тоо         y   �   �   Комплекс тоонуудын нийлбэрийг буцаана     Комплекс тоо     Комплекс тоо         y   �   �   Бодит ба хуурмаг хэсгийг комплекс тоонд хөрвүүлнэ      Бодит тоо     Бодит хэсэг     i тоо      Хуурмаг хэсэг     Дагавар      Дагавар          y  ,  ,   Нэг нэгжийн системээс нөгөөд хөрвүүлнэ      Тоо      Тоо      Хэмжүүрийн нэгжээс     Тооны хэмжүүрийн нэгж      Хэмжүүрийн нэгжид     Үр дүнгийн хэмжүүрийн нэгж          y  �  �   Тайлант тооцооны нэг үед тулгасан элэгдлийн нийт дүнг францын нягтлан бодох систем дээр суурилан буцаана.     Үнэ      Хөрөнгийн худалдан авах үнэ     Огноо      Хөрөнгийн худалдан авсан огноо     Эхний үе     Эхний үеийн төгсгөлийн огноо     Үлдэгдэл      Хэрэглээний төгсгөл дэх хөрөнгийн үлдэгдэл      Үе      Үе      Хүү      Элэгдлийн норм     Суурь      Хэрэглэх жилийн суурь        !  y  �  �   Тайлант тооцооны нэг үед тулгасан элэгдлийн нийт дүнг францын нягтлан бодох систем дээр суурилан буцаана.     Үнэ      Хөрөнгийн худалдан авах үнэ     Огноо      Хөрөнгийн худалдан авсан огноо     Эхний үе     Эхний үеийн төгсгөлийн огноо     Үлдэгдэл      Хэрэглэх хугацааны төгсгөл дэх хөрөнгийн үлдэгдэл     Үе      Үе      Хүү      Элэгдлийн норм     Суурь      Хэрэглэх жилийн суурь        "  y  �  �   Хүүний үечлэлтэй үнэт цаасны хуримтлагдсан хүүг буцаана.     Гаргалт      Үнэт цаас гаргалтын огноо     Эхний хүүгийн хугацаа      Үнэт цаасны эхний хүүгийн хугацаа      Тооцоо      Тооцоо      Хүү      Хүү      Нэрлэсэн үнэ     Нэрлэсэн үнэ     Давтамж      Давтамж      Суурь      Суурь        #  y  d  d   Төлбөрийн хугацаанд төлөгдөх үнэт цаасны хуримтлагдсан хүүг буцаана.      Гаргалт      Гаргалтын огноо     Тооцоо      Тооцоо      Хүү      Хүү      Нэрлэсэн үнэ     Нэрлэсэн үнэ     Суурь      Суурь        $  y  �  �   Үнэт цаас болгосон хөрөнгө төлбөрийн хугацааны дараа буцааж худалдаад олж авах үнийг буцаана      Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Хавсралт      Хавсралт      Хөнгөлөлт      Хөнгөлөлт      Суурь      Суурь        %  y  H  H   Үнэт цаасны хөнгөлөлтийн хувь (Disagio) буцаана      Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Ханш      Үнэ      Буцаалт      Буцаалтын утга     Суурь      Суурь        &  y  �  �   Хүүний үечлэлтэй үнэт цаасны жилийн Macaulay хугацааг буцаана     Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Нэрийдсэн хүү     Нэрийдсэн хүү     Орлого      Орлого      Давтамж      Давтамж      Суурь      Суурь        '  y   �   �   Жилийн үр ашигт хүүг буцаана      Нэрийдсэн хүү     Нэрийдсэн хүү     Үе      Үе        (  y  �  �   Хоёр үеийн хооронд төлөгдөх ёстой зээлийн хуримтлагдсан төлбөрийг буцаана      Хүү      Хүү      Үе      Төлбөрийн үеийн тоо      Оу      Одоогийн үнэ     Эхлэл үе     Эхлэл үе     Төгсгөл үе     Төгсгөл үе     Төрөл      Төлбөрийн хугацааны төрөл        )  y  �  �   Хоёр үеийн хооронд төлөгдөх ёстой хуримтлагдсан хүүг буцаана     Хүү      Хүү      Ү      Төлбөрийн хугацааны үеийн тоо     О      Одоогийн үнэ     Эхлэл үе     Эхлэл үе     Төгсгөл үе     Төгсгөл үе     Төрөл      Төлбөрийн хугацааны төрөл        *  y  �  �   Хүүний үечлэлтэй үнэт цаасны нэрлэсэн үнийн 100 валютын нэгж тутам дахь хүүг буцаана.      Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Хүү      Хүү      Орлого      Орлого      Буцаалт      Буцаалтын утга     Давтамж      Давтамж      Суурь      Суурь        +  y  �  �   Хүүгүй үнэт цаасны нэрлэсэн үнийн 100 валютын нэгж тутам дахь хүүг буцаана.     Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Хөнгөлөлт      Хөнгөлөлт      Буцаалт      Буцаалтын утга     Суурь      Суурь        ,  y  �  �   Төлбөрийн хугацаанд төлөгдөх хүүтэй үнэт цаасны нэрлэсэн үнийн 100 валютын нэгж тутам дахь хүүг буцаана.      Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Гаргалт      Гаргалтын огноо     Хүү      Хүү      Орлого      Орлого      Суурь      Суурь        -  y  �  �   100 валютын нэгжтэй нэрлэсэн үнэтэй үнэт цаасны өөрчлөгдсөн Macaulay-Duration -г буцаана.      Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Нэрийдсэн хүү     Нэрийдсэн хүү     Орлого      Орлого      Давтамж      Давтамж      Суурь      Суурь        .  y   �   �   Жилийн нэрлэсэн хүүгийн төвшинг буцаана      Зах зээлийн ханш      Зах зээлийн хүүгийн төвшин     Мөчлөг      Мөчлөг        /  y   �   �   Аравтын бичлэгээр илэрхийлэгдсэн тэмдэглэгээг аравтын бутархай руу хөрвүүлнэ     Тоо      Аравтын тоо     Бутархай      Хуваагч        0  y   �   �   Аравтын бутархайгаар илэрхийлэгдсэн тэмдэглэгээг аравтын тоо руу хөрвүүлнэ     Тоо      Тоо      Бутархай      Хуваагч        1  y  �  �   Хүүний үечлэлтэй үнэт цаасны өгөөжийг буцаана.      Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Хүү      Хүү      Ханш      Үнэ      Буцаалт      Буцаалтын утга     Давтамж      Давтамж      Суурь      Суурь        2  y  N  N   Хөнгөлөлттэй үнэт цаасны жилийн ашгийг буцаана     Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Ханш      Үнэ      Буцаалт      Буцаалтын утга     Суурь      Суурь        3  y  �  �   Төлбөрийн хугацаанд төлөгдөх хүүтэй үнэт цаасны жил тутмын өгөөжийг буцаана.      Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Гаргалт      Гаргалтын огноо     Хүү      Хүү      Ханш      Үнэ      Суурь      Суурь        4  y  T  T   Сангийн яамны боловсруулсан үнэд тохирох орлогын бонд-эквивалент (bond-equivalent) буцаана      Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Хөнгөлөлт      Хөнгөлөлт        5  y  8  8   Сан яамны векселийн 100 валютын нэгж тутам дах нэрлэсэн үнийг буцаана.      Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Хөнгөлөлт      Хөнгөлөлт        6  y  $  $   Сангийн яамны боловсруулсан үнэд тохирох векселийн өгөөжийг буцаана.      Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Ханш      Үнэ        7  y  �  �   Валютын $100 нэгж тутам дахь үнэт цаасны нэрлэсэн үнийн тогтмол бус анхны хүүний дүнг харуулна      Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Гаргалт      Гаргалтын огноо     Анхны нэрийдсэн хүү      Анхны нэрийдсэн хүүгийн хугацаа     Хүү      Хүү      Орлого      Орлого      Буцаалт      Буцаалтын утга     Давтамж      Давтамж      Суурь      Суурь        8  y  @  @   Тогтмол бус анхны үечлэлтэй үнэт цаасны орлогыг буцаана.      Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Гаргалт      Гаргалтын огноо     Анхны нэрийдсэн хүү      Анхны нэрийдсэн хүүгийн хугацаа     Хүү      Хүү      Ханш      Үнэ      Буцаалт      Буцаалтын утга     Давтамж      Давтамж      Суурь      Суурь        9  y  .  .   Валютын $100 нэгж тутам дахь үнэт цаасны нэрлэсэн үнийн тогтмол бус сүүлийн хүүний дүнг харуулна      Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Сүүлийн хүү     Хүү дуусах огноо      Хүү      Хүү      Орлого      Орлого      Буцаалт      Буцаалтын утга     Давтамж      Давтамж      Суурь      Суурь        :  y  �  �   Тогтмол бус эцсийн (хүүний) үечлэлтэй үнэт цаасны ашгийг буцаана.     Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Сүүлийн хүү     Сүүлийн хүүний огноо      Хүү      Хүү      Ханш      Үнэ      Буцаалт      Буцаалтын утга     Давтамж      Давтамж      Суурь      Суурь        ;  y         Тогтмол үетэй бус төлбөрийн хугацааны хөрөнгө оруулалтын өгөөжийг буцаана.     Утга      Утга      Огноо      Огноо      Тооцоолсон үнэ     Тооцоолсон үнэ       <  y   �   �   Тогтмол үетэй бус төлбөрийн одоогийн цэвэр үнийг (капитал үнэ) буцаана.      Хүү      Хүү      Утга      Утга      Огноо      Огноо        =  y  j  j   Үнэт цаас болгосон хөрөнгийн хүүний төвшинг буцаана      Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Хавсралт      Хавсралт      Буцаалт      Буцаалтын утга     Суурь      Суурь        >  y  J  J   	Тооцооны хугацааны дараах эхний хүүний хугацааны огноог буцаана.      Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Давтамж      Давтамж      Суурь      Суурь        ?  y  <  <   	Тооцооны хугацааны хүүгийн мөчлөгийн өдрийн тоог буцаана.     Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Давтамж      Давтамж      Суурь      Суурь        @  y  \  \   	Тооцооны хугацаанаас дараагийн хүүний хугацаа хүртэлх өдрийн тоог буцаана.     Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Давтамж      Давтамж      Суурь      Суурь        A  y  R  R   	Хүүний хугацааны эхнээс тооцооны хугацаа хүртэлх өдрийн тоог буцаана.     Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Давтамж      Давтамж      Суурь      Суурь        B  y  N  N   	Тооцооны хугацааны өмнөх сүүлчийн хүүний хугацааны огноог буцаана.      Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Давтамж      Давтамж      Суурь      Суурь        C  y  T  T   	Тооцооны ба төлбөрийн хугацааны хооронд хүүний мөчлөгийн тоог буцаана.     Тооцоо      Тооцоо      Төлбөрийн хугацаа     Төлбөрийн хугацаа     Давтамж      Давтамж      Суурь      Суурь        D  y       Хэд хэдэн хүүний хүү төвшинг тогтоолгосны дараа анхны хөрөнгийн ирээдүйн өртгийг буцаана.      Үндсэн хөрөнгө     Үндсэн хөрөнгө     Хүү      Хүү        E  y   x   x   Returns the tangent of a complex number     Комплекс тоо     Комплекс тоо       F  y   x   x   Returns the secant of a complex number      Комплекс тоо     Комплекс тоо       G  y   z   z   Returns the cosecant of a complex number      Комплекс тоо     Комплекс тоо       H  y   z   z   Returns the cotangent of a complex number     Комплекс тоо     Комплекс тоо       I  y   �   �   Returns the hyperbolic sine of a complex number     Комплекс тоо     Комплекс тоо       J  y   �   �   Returns the hyperbolic cosine of a complex number     Комплекс тоо     Комплекс тоо       K  y   �   �   Returns the hyperbolic secant of a complex number     Комплекс тоо     Комплекс тоо       L  y   �   �   Returns the hyperbolic cosecant of a complex number     Комплекс тоо     Комплекс тоо        �           �     �  s    �        �       �   2    �   H    �   `    �   x    �   �    �   �    �   �    �   �    �   �    �      �  *    �  B    �  ^    �  r    �  �    �  �    �  �    �  �    �  �    �  �    �      �  .    �  F    �  ^    �  v    �  �    �  �    �  �    �  �    �  �    �      �      �  0    �  F    �  ^    �  z    �  �    �  �    �  �    �  �    �  �    �  
    �       �  <    �  R    �  j    �  �    �  �    �  �    �  �    �  �    �  �    �      �  &    �  >    �  X    �  r    �  �    �  �    �  �    �  �    �  �    �      �       �  8    �  N    �  h    �  �    �  �    �  �       �      �      �            2      J      f      �      �    	  �    
  �      �                   .      F      `      |      �      �      �      �      �      	      	$      	:      	R      	j      	�  y  �  	�  y  �  h  y  �  �  y  �  �  y  �  D  y  �  �  y  �  T  y  �  �  y  �  >  y  �  4  y  �  x  y  �    y  �  �  y  �  l  y  �  �  y  �  ~  y  �  h  y  �     y  �  �  y  �  0  y  �  �  y  �  �  y  �  &  y  �  �  y     �  y     b  y    !6  y    "  y    "�  y    #�  y    $x  y    %4  y    &  y  	  &�  y  
  '�  y    (z  y    )>  y    )�  y    *B  y    *�  y    +�  y    ,4  y    ,�  y    -v  y    ..  y    .�  y    /\  y    0   y    0�  y    1v  y    2  y    2�  y    3L  y    3�  y    4r  y    5l  y     6�  y  !  9>  y  "  ;�  y  #  =�  y  $  ?L  y  %  @�  y  &  BF  y  '  C�  y  (  D�  y  )  F4  y  *  G�  y  +  I�  y  ,  KL  y  -  M&  y  .  N�  y  /  O�  y  0  P�  y  1  Q�  y  2  S<  y  3  T�  y  4  V*  y  5  W~  y  6  X�  y  7  Y�  y  8  \f  y  9  ^�  y  :  `�  y  ;  b�  y  <  c�  y  =  d�  y  >  fB  y  ?  g�  y  @  h�  y  A  j$  y  B  kv  y  C  l�  y  D  n  y  E  o0  y  F  o�  y  G  p   y  H  p�  y  I  q  y  J  q�  y  K  r  y  L  r�  	�