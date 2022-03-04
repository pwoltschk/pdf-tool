  �        WORKDAY   �        YEARFRAC    �        EDATE   �        WEEKNUM   �        EOMONTH   �        NETWORKDAYS   �        ISEVEN    �        ISODD   �        MULTINOMIAL   �        SERIESSUM   �        QUOTIENT    �        MROUND    �        SQRTPI    �        RANDBETWEEN   �        GCD   �        LCM   �        BESSELI   �        BESSELJ   �        BESSELK   �        BESSELY   �        BIN2OCT   �        BIN2DEC   �        BIN2HEX   �        OCT2BIN   �        OCT2DEC   �        OCT2HEX   �        DEC2BIN   �        DEC2HEX   �        DEC2OCT   �        HEX2BIN   �        HEX2DEC   �        HEX2OCT   �        DELTA   �        ERF   �        ERFC    �        GESTEP    �        FACTDOUBLE    �        IMABS   �        IMAGINARY   �        IMPOWER   �        IMARGUMENT    �        IMCOS   �        IMDIV   �        IMEXP   �        IMCONJUGATE   �        IMLN    �        IMLOG10   �        IMLOG2    �        IMPRODUCT   �        IMREAL    �        IMSIN   �        IMSUB   �        IMSQRT    �        IMSUM   �        COMPLEX   �        CONVERT   �        AMORDEGRC   �        AMORLINC    �        ACCRINT   �        ACCRINTM    �        RECEIVED    �        DISC    �        DURATION    �        EFFECT    �        CUMPRINC    �        CUMIPMT   �        PRICE   �        PRICEDISC   �        PRICEMAT    �        MDURATION   �        NOMINAL   �        DOLLARFR             DOLLARDE            YIELD           YIELDDISC           YIELDMAT            TBILLEQ           TBILLPRICE            TBILLYIELD            ODDFPRICE           ODDFYIELD   	        ODDLPRICE   
        ODDLYIELD           XIRR            XNPV            INTRATE           COUPNCD           COUPDAYS            COUPDAYSNC            COUPDAYBS           COUPPCD           COUPNUM           FVSCHEDULE            IMTAN           IMSEC           IMCSC           IMCOS           IMSIN           IMCOS           IMSECH            IMCSCH    �  y  b  b   Trả về số thứ tự cho ngày tháng trước hoặc sau một số ngày làm việc được chỉ định     Ngày đầu      Ngày bắt đầu      Ngày     Số ngày làm việc trước hoặc sau ngày bắt đầu     Ngày nghỉ      Danh sách ngày tháng là ngày nghỉ (ngày lễ, ngày nghỉ, v.v.)       �  y  
  
   Returns the number of years (including fractional part) between two dates     Ngày đầu      Ngày bắt đầu      Ngày cuối      Ngày kết thúc     Cơ bản     Basis indicates the day-count convention to use in the calculation        �  y   �   �   Trả về số thứ tự cho ngày tháng là số tháng trước hoặc sau ngày bắt đầu      Ngày đầu      Ngày bắt đầu      Tháng      Số tháng nằm trước hay sau ngày bắt đầu.        �  y  b  b   Returns the number of the calendar week in which the specified date occurs.
This function exists for interoperability with older Microsoft Excel documents, for new documents use WEEKNUM instead.      Ngày     The date or date serial number      Kiểu trả về     Indicates the first day of the week (1 = Sunday, 2 = Monday)        �  y         Trả về số thứ tự của ngày cuối tháng đến một số tháng trước hoặc sau ngày bắt đầu      Ngày đầu      Ngày bắt đầu      Tháng      Số tháng nằm trước hay sau ngày bắt đầu.        �  y  �  �   Returns the number of workdays between two dates.
This function exists for interoperability with older Microsoft Excel documents, for new documents use NETWORKDAYS instead.      Ngày đầu      Ngày bắt đầu      Ngày cuối      Ngày kết thúc     Ngày nghỉ      Danh sách các giá trị ngày tháng đại diện cho các ngày nghỉ (nghỉ phép, nghỉ hè,..)       �  y   p   p   Trả về giá trị « true » (đúng) nếu là số chẵn     Số      Con số        �  y   n   n   Trả về giá trị « true » (đúng) nếu là số lẻ     Số      Con số        �  y   �   �   Trả về hệ số đa thức của một tập hợp số      Number      Số hoặc danh sách các số cho chúng bạn muốn hệ số đa thức       �  y  �  �   	Trả về tổng của một cấp số luỹ thừa     X     Biến độc lập của cấp số luỹ thừa     N     Luỹ thừa đầu tiên lên đó cần tăng x     M     Lượng gia để tăng lên n cho mỗi mục trong cấp số      Hệ số     Tập hệ số với chúng mỗi luỹ thừa liên tiếp của biến x được nhân        �  y   �   �   Trả về phần số nguyên của phép chia     Tử số     Số bị chia      Mẫu số      Số chia       �  y   �   �   Trả về một số đã được làm tròn theo bội số chỉ định      Số      Số cần làm tròn     Bội số      Bội số tới đó bạn muốn làm tròn số        �  y   �   �   Trả về căn bậc hai của một số vừa nhân với PI (π)      Số      Số được nhân với PI (π)       �  y   �   �   Trả về số nguyên ngẫu nhiên giữa các số bạn chỉ định      Đáy     Số nguyên nhỏ nhất được trả về     Đỉnh     Số nguyên lớn nhất được trả về       �  y   �   �   Returns the greatest common divisor.
This function exists for interoperability with older Microsoft Excel documents, for new documents use GCD instead.     Number      Số hay danh sách các số       �  y   �   �   Returns the least common multiple.
This function exists for interoperability with older Microsoft Excel documents, for new documents use LCM instead.     Number      Số hay danh sách các số       �  y   �   �   Trả về hàm Bessel In(x) đã sửa đổi      X     Giá trị ở đó cần tính hàm.     N     Cấp của hàm Bessel.        �  y   �   �   Trả về hàm Bessel Jn(x)      X     Giá trị ở đó cần tính hàm.     N     Cấp của hàm Bessel.        �  y   �   �   Trả về hàm Bessel Kn(x)      X     Giá trị ở đó cần tính hàm.     N     Cấp của hàm Bessel.        �  y   �   �   Trả về hàm Bessel Yn(x)      X     Giá trị ở đó cần tính hàm.     N     Cấp của hàm Bessel.        �  y   �   �   Chuyển đổi số nhị phân thành số bát phân     Số      Con số nhị phân cần chuyển đổi (dạng văn bản)      Lần số      Số lần số dùng       �  y   �   �   Chuyển đổi số nhị phân thành số thập phân     Số      Con số nhị phân cần chuyển đổi (dạng văn bản)        �  y   �   �   Chuyển đổi số nhị phân thành số thập lục phân     Số      Con số nhị phân cần chuyển đổi (dạng văn bản)      Lần số      Số lần đã được dùng.       �  y   �   �   Chuyển một số bát phân thành số nhị phân      Số      Con số bát phân cần chuyển đổi (dạng văn bản)     Lần số      Số lần số dùng          y   �   �   Chuyển đổi số bát phân thành số thập phân      Số      Con số bát phân cần chuyển đổi (dạng văn bản)         y   �   �   Chuyển đổi số bát phân thành số thập lục phân      Số      Con số bát phân cần chuyển đổi (dạng văn bản)     Lần số      Số lần số dùng         y   �   �   Chuyển đổi số thập phân thành số nhị phân     Số      Số nguyên thập phân cần chuyển đổi.      Lần số      Số lần số dùng         y   �   �   Chuyển đổi số thập phân thành số thập lục phân      Số      Số nguyên thập phân cần chuyển đổi.      Lần số      Số lần số dùng         y   �   �   Chuyển đổi số thập phân thành số bát phân      Số      Số thập phân     Lần số      Số lần số dùng         y   �   �   Chuyển đổi số thập lục phân thành số nhị phân     Số      Con số lục phân cần chuyển đổi (dạng văn bản)      Lần số      Số lần số dùng         y   �   �   Chuyển đổi số thạp lục phân thành số thập phân      Số      Con số lục phân cần chuyển đổi (dạng văn bản)          y   �   �   Chuyển đổi số thập lục phân thành số bát phân      Số      Con số lục phân cần chuyển đổi (dạng văn bản)      Lần số      Số lần số dùng         y   �   �   Kiểm tra xem hai giá trị có bằng nhau không      Số 1      Số thứ nhất     Số 2      Số thứ hai        	  y   �   �   Trả về hàm lỗi     Hạn chế dưới     Hạn chế dưới khi tích phân.      Giới hạn trên      Giới hạn trên khi tích phân        
  y   t   t   Trả về hàm lỗi bù     Hạn chế dưới     Hạn chế dưới khi tích phân.          y   �   �   Kiểm tra xem một số có lớn hơn một giá trị ngưỡng không      Số      Giá trị cần kiểm tra đối với bước      Bước     The threshold value         y   d   d   Trả về giai thừa gấp đôi của một số     Số      Con số          y   v   v   Trả về giá trị tuyệt đối của một số phức      Số phức     Số phức         y   l   l   Trả về hệ số phần ảo của số phức      Số phức     Số phức         y   �   �   Returns a complex number raised to a real power     Số phức     Số phức     Số      Luỹ thừa lên đó tăng số phức          y   z   z   Trả về theta (θ) đối số, một góc dạng hệ Radian      Số phức     Số phức         y   \   \   Trả về Cosin của số phức      Số phức     Số phức         y   �   �   Trả về thương của hai số phức     Tử số     Số bị chia      Mẫu số      Số chia         y   ~   ~   Trả về biểu thức đại số của số mũ của số phức     Số phức     Số phức         y   t   t   Trả về số phức liên hợp với một số phức      Số phức     Số phức         y   l   l   Trả về Loga tự nhiên của một số phức     Số phức     Số phức         y   l   l   Trả về Loga cơ số 10 của một số phức     Số phức     Số phức         y   l   l   Trả về Loga cơ số 2 của một số phức      Số phức     Số phức         y   �   �   Trả về tích số của vài số phức      Complex number      Số phức thứ nhất      Complex number      Số phức khác         y   n   n   Trả về hệ số nguyên của một số phức      Số phức     Số phức         y   `   `   Trả về Sin của một số phức      Số phức     Số phức         y   �   �   Trả về hiệu của hai số phức     Complex number 1      Complex number 1      Complex number 2      Complex number 2          y   j   j   Trả về căn cấp hai của một số phức     Số phức     Số phức         y   b   b   Trả về tổng của các số phức      Số phức     Số phức         y   �   �   Chuyển đổi hệ số thực và ảo thành một số phức      Số thực     Hệ số thực      Số i      Hệ số ảo      Hậu tố      Hậu tố          y   �   �   Chuyển một số từ hệ đo lường này sang hệ khác     Số      Con số      Từ đơn vị     Đơn vị đo lường của số      Thành đơn vị     Đơn vị đo lường của kết quả          y  �  �   Trả lại khấu hao tuyến tính chia theo tỷ lệ của đầu tư từng kỳ kế toán.     Giá      Giá của tài sản     Ngày mua     Ngày tháng mua tài sản.      Kỳ đầu     Ngày kết thúc giai đoạn thứ nhất     Thanh lý     Giá trị của một tài sản khi hết thời gian khấu hao      Kỳ      Kỳ      Tỷ lệ     Tỷ lệ khấu hao      Cơ bản     Cơ bản nằm cần dùng       !  y  �  �   Trả lại khấu hao tuyến tính chia theo tỷ lệ của đầu tư từng kỳ kế toán.     Giá      Giá của tài sản     Ngày mua     Ngày tháng mua tài sản.      Kỳ đầu     Ngày kết thúc giai đoạn đầu tiên     Thanh lý     Giá trị của một tài sản khi hết thời gian khấu hao      Kỳ      Kỳ      Tỷ lệ     Tỷ lệ khấu hao      Cơ bản     Cơ bản nằm cần dùng       "  y  �  �   Trả về tiền lãi để dồn lại của chứng khoán trả tiền lãi theo định kỷ     Cấp     Ngày phát hành chứng khoán đó     Tiền lãi đầu      Ngày trả tiền lãi thứ nhất của chứng khoán đó      Thanh toán     Thành toán      Tỷ lệ     Tỷ lệ     Mệnh giá.      Giá trị danh nghĩa      Tần số      Tần số      Cơ bản     Cơ bản       #  y  .  .   Trả về tiền lãi để dồn lại cho chứng khoán trả tiền lãi khi đến hạn thanh toán      Cấp     Ngày tháng cấp      Thanh toán     Thành toán      Tỷ lệ     Tỷ lệ     Mệnh giá.      Giá trị danh nghĩa      Cơ bản     Cơ bản       $  y  T  T   Trả về số tiền được trả khi đến hạn thanh toán đối với một chứng khoán đầu tư đầy đủ      Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Đầu tư      Đầu tư      Hạ giá     Tỷ lệ giảm giá     Cơ bản     Cơ bản       %  y       Trả về tỷ lệ chiết khấu đối với chứng khoán đó      Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Giá      GIá      Trả hết     Giá trị tức đáo hạn.     Cơ bản     Cơ bản       &  y  f  f   Trả về khoảng thời gian Macaulay của chứng khoán trả tiền lãi theo định kỳ     Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Phiếu lãi      Lãi suất trái phiếu.      Tổng lợi      Tổng lợi      Tần số      Tần số      Cơ bản     Cơ bản       '  y   �   �   Trả về lãi xuất hàng năm hiệu dụng     Tỷ lệ danh nghĩa     Tỷ lệ trên danh nghĩa     Các kỳ     Các kỳ       (  y  H  H   Trả về tiền gốc tích luỹ của khoản vay phải trả giữa hai kỳ      Tỷ lệ     Tỷ lệ     Số kỳ     Số kỳ trả     Pv      Giá trị hiên tại      Kỳ đầu     Kỳ bắt đầu     Kỳ cuối     Kỳ kết thúc      Kiểu      Kiểu kỳ hạn thanh toán       )  y  .  .   Trả về lãi tích luỹ phải trả giữa hai kỳ      Tỷ lệ     Tỷ lệ     Số kỳ     Số kỳ trả     Pv      Giá trị hiên tại      Kỳ đầu     Kỳ bắt đầu     Kỳ cuối     Kỳ kết thúc      Kiểu      Kiểu kỳ hạn thanh toán       *  y  �  �   Trả về giá trên 100 đơn vị tiền tệ giá trị danh nghĩa của chứng khoán trả lãi kỳ      Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Tỷ lệ     Tỷ lệ     Tổng lợi      Tổng lợi      Trả hết     Giá trị tức đáo hạn.     Tần số      Tần số      Cơ bản     Cơ bản       +  y  V  V   Trả về giá trên 100 đơn vị tiền tệ giá trị danh nghĩa của chứng khoán đã giảm giá     Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Hạ giá     Tỷ lệ giảm giá     Trả hết     Giá trị tức đáo hạn.     Cơ bản     Cơ bản       ,  y  |  |   Trả về giá trên 100 đơn vị tiền tệ giá trị danh nghĩa của chứng khoán trả tiền lãi khi đến hạn thanh toán     Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Cấp     Ngày tháng cấp      Tỷ lệ     Tỷ lệ     Tổng lợi      Tổng lợi      Cơ bản     Cơ bản       -  y  �  �   Trả về khoảng thời gian bổ sung Macaulay cho chứng khoán có giá danh nghĩa giả sử trên 100 đơn vị tiền tệ      Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Phiếu lãi      Lãi suất trái phiếu.      Tổng lợi      Tổng lợi      Tần số      Tần số      Cơ bản     Cơ bản       .  y   �   �   Trả về lãi xuất danh nghĩa hàng năm     Tỷ lệ hiệu dụng     Lãi xuất hiệu dụng     Các kỳ     Các kỳ       /  y   �   �   Chuyển đổi một giá dạng thập phân thành phân số      Đồng đo-la thập phân     Số thập phân     Phân số      Số chia       0  y   �   �   Chuyển đổi giá dạng phân số về dạng thập phân     Đồng đo-la phân số     Số dạng phân số      Phân số      Số chia       1  y  R  R   Trả về lợi nhuận của chứng khoán trả lãi chu kỳ     Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Tỷ lệ     Tỷ lệ     Giá      GIá      Trả hết     Giá trị tức đáo hạn.     Tần số      Tần số      Cơ bản     Cơ bản       2  y       Trả về lợi nhuận hàng năm của chứng khoán đã giảm giá     Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Giá      GIá      Trả hết     Giá trị tức đáo hạn.     Cơ bản     Cơ bản       3  y  H  H   Trả về lợi nhuận hàng năm của chứng khoán trả tiền lãi khi đến hạn thanh toán     Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Cấp     Ngày tháng cấp      Tỷ lệ     Tỷ lệ     Giá      GIá      Cơ bản     Cơ bản       4  y   �   �   Trả về lợi nhuận tương đương với trái phiếu cho tín phiếu bộ tài chính     Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Hạ giá     Tỷ lệ giảm giá       5  y       Trả về giá của 100 đơn vị tiền tệ giá trên danh nghĩa của tín phiếu bộ tài chính     Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Hạ giá     Tỷ lệ giảm giá       6  y   �   �   Trả về lợi nhuận của tín phiếu bộ tài chính      Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Giá      GIá        7  y  �  �   Trả về giá trên $100 giá trên danh nghĩa của chứng khoán có kỳ lẻ đầu tiên     Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Cấp     Ngày tháng cấp      Phiếu lãi đầu     Ngày tháng của phiếu lãi thứ nhất      Tỷ lệ     Tỷ lệ     Tổng lợi      Tổng lợi      Trả hết     Giá trị tức đáo hạn.     Tần số      Tần số      Cơ bản     Cơ bản       8  y  �  �   Trả về lợi nhuận của chứng khoán ở kỳ lẻ đầu tiên      Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Cấp     Ngày tháng cấp      Phiếu lãi đầu     Ngày tháng của phiếu lãi thứ nhất      Tỷ lệ     Tỷ lệ     Giá      GIá      Trả hết     Giá trị tức đáo hạn.     Tần số      Tần số      Cơ bản     Cơ bản       9  y  �  �   Trả về giá trên $100 giá danh nghĩa của chứng khoán ở kỳ lẻ cuối cùng     Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Lãi cuối     Ngày tháng lãi cuối cùng      Tỷ lệ     Tỷ lệ     Tổng lợi      Tổng lợi      Trả hết     Giá trị tức đáo hạn.     Tần số      Tần số      Cơ bản     Cơ bản       :  y  �  �   Trả về lợi nhuận của chứng khoán với kỳ lẻ cuối cùng      Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Lãi cuối     Ngày tháng lãi cuối cùng      Tỷ lệ     Tỷ lệ     Giá      GIá      Trả hết     Giá trị tức đáo hạn.     Tần số      Tần số      Cơ bản     Cơ bản       ;  y   �   �   Trả về tỷ suất lợi tức cho quá hạn trả không chu kỳ     Giá trị      Các giá trị     Ngày     Các ngày tháng     Đoán      Ước đoán       <  y   �   �   Trả về giá trị hiện tại ròng cho quá hạn trả không chu kỳ     Tỷ lệ     Tỷ lệ     Giá trị      Các giá trị     Ngày     Các ngày tháng       =  y  (  (   Trả về lãi xuất cho chứng khoán đã đầu tư đầy đủ      Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Đầu tư      Đầu tư      Trả hết     Giá trị tức đáo hạn.     Cơ bản     Cơ bản       >  y   �   �   	Trả về ngày của phiếu lãi đầu tiên sau ngày thanh toán      Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Tần số      Tần số      Cơ bản     Cơ bản       ?  y   �   �   	Trả về số ngày của chu kỳ phiếu chứa ngày thanh toán     Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Tần số      Tần số      Cơ bản     Cơ bản       @  y       	Trả về số ngày từ ngày thanh toán đến ngày của phiếu lãi tiếp theo      Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Tần số      Tần số      Cơ bản     Cơ bản       A  y       	Trả về số ngày từ ngày bắt đầu chu kỳ phiếu tới ngày thanh toán      Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Tần số      Tần số      Cơ bản     Cơ bản       B  y   �   �   	Trả về ngày của phiếu lãi cuối cùng trước ngày thanh toán     Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Tần số      Tần số      Cơ bản     Cơ bản       C  y       	Trả về số phiếu lãi trả được giữa ngày thanh toán và kỳ hạn thanh toán     Thanh toán     Thành toán      Kỳ hạn thanh toán      Kỳ hạn thanh toán      Tần số      Tần số      Cơ bản     Cơ bản       D  y   �   �   Trả về giá trị tương lai của tiền gốc đầu tiên sau khi áp dụng một chuỗi lãi xuất kép     Tiền gốc      Tiền gốc      Lịch biểu     Lịch biểu       E  y   `   `   Trả về Sin của một số phức      Số phức     Số phức       F  y   `   `   Trả về Sin của một số phức      Số phức     Số phức       G  y   \   \   Trả về Cosin của số phức      Số phức     Số phức       H  y   \   \   Trả về Cosin của số phức      Số phức     Số phức       I  y   \   \   Trả về Cosin của số phức      Số phức     Số phức       J  y   \   \   Trả về Cosin của số phức      Số phức     Số phức       K  y   \   \   Trả về Cosin của số phức      Số phức     Số phức       L  y   \   \   Trả về Cosin của số phức      Số phức     Số phức        �           �     �  _*    �        �       �   2    �   H    �   `    �   x    �   �    �   �    �   �    �   �    �   �    �      �  *    �  B    �  ^    �  r    �  �    �  �    �  �    �  �    �  �    �  �    �      �  .    �  F    �  ^    �  v    �  �    �  �    �  �    �  �    �  �    �      �      �  0    �  F    �  ^    �  z    �  �    �  �    �  �    �  �    �  �    �  
    �       �  <    �  R    �  j    �  �    �  �    �  �    �  �    �  �    �  �    �      �  &    �  >    �  X    �  r    �  �    �  �    �  �    �  �    �  �    �      �       �  8    �  N    �  h    �  �    �  �    �  �       �      �      �            2      J      f      �      �    	  �    
  �      �                   .      F      `      |      �      �      �      �      �      	      	$      	:      	P      	f      	~  y  �  	�  y  �  
�  y  �    y  �  �  y  �  R  y  �  R  y  �  �  y  �  Z  y  �  �  y  �  |  y  �  �  y  �  �  y  �  V  y  �  �  y  �  �  y  �  �  y  �  |  y  �    y  �  �  y  �  ,  y  �  �  y  �  ~  y  �    y  �  �  y     �  y    \  y    *  y    �  y     �  y    !F  y    "  y    "�  y    #�  y  	  $  y  
  $�  y    %B  y    &
  y    &n  y    &�  y    'P  y    '�  y    (j  y    (�  y    )H  y    )�  y    *:  y    *�  y    +  y    +~  y    ,   y    ,�  y    ,�  y    -�  y    -�  y    .R  y    /  y     0  y  !  1�  y  "  3�  y  #  5R  y  $  6�  y  %  7�  y  &  8�  y  '  :T  y  (  :�  y  )  <:  y  *  =h  y  +  >�  y  ,  @L  y  -  A�  y  .  CT  y  /  C�  y  0  D�  y  1  EN  y  2  F�  y  3  G�  y  4  I  y  5  J   y  6  K  y  7  K�  y  8  M�  y  9  O~  y  :  Q.  y  ;  R�  y  <  S�  y  =  TF  y  >  Un  y  ?  Vd  y  @  WX  y  A  X`  y  B  Yf  y  C  Z`  y  D  [n  y  E  \B  y  F  \�  y  G  ]  y  H  ]^  y  I  ]�  y  J  ^  y  K  ^r  y  L  ^�  	�