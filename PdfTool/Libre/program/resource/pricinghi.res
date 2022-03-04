  �        OPT_BARRIER   �        OPT_TOUCH   �        OPT_PROB_HIT    �     "   "OPT_PROB_INMONEY    �  y  �  �   Pricing of a barrier option     स्पॉट     Price/value of the underlying asset     आयतन      Annual volatility of the underlying asset     r     Interest rate (continuously compounded)     आरएफ      Foreign interest rate (continuously compounded)     T     Time to maturity of the option in years     लिखकर काटें     Strike level of the option      barrier_low     Lower barrier (set to 0 for no lower barrier)     barrier_up      Upper barrier (set to 0 for no upper barrier)     छूट     Amount of money paid at maturity if barrier was hit     put/call      String to define if the option is a (p)ut or a (c)all     नॉक इन/आउट      String to define if the option is of type knock-(i)n or knock-(o)ut     barrier_type      String to define whether the barrier is observed (c)ontinuously or only at the (e)nd/maturity     ग्रीक     Optional parameter, if left out then the function simply returns the option price; if set, the function returns price sensitivities (Greeks) to one of the input parameters; possible values are (d)elta, (g)amma, (t)heta, v(e)ga, v(o)lga, v(a)nna, (r)ho, rho(f)       �  y  �  �   Pricing of a touch/no-touch option      स्पॉट     Price/value of the underlying asset     आयतन      Annual volatility of the underlying asset     r     Interest rate (continuously compounded)     आरएफ      Foreign interest rate (continuously compounded)     T     Time to maturity of the option in years     barrier_low     Lower barrier (set to 0 for no lower barrier)     barrier_up      Upper barrier (set to 0 for no upper barrier)     विदेश/घरेलू     String to define if the option pays one unit of (d)omestic currency (cash or nothing) or (f)oreign currency (asset or nothing)      नॉक इन/आउट      String to define if the option is of type knock-(i)n (touch) or knock-(o)ut (no-touch)      barrier_type      String to define whether the barrier is observed (c)ontinuously or only at the (e)nd/maturity     ग्रीक     Optional parameter, if left out then the function simply returns the option price; if set, the function returns price sensitivities (Greeks) to one of the input parameters; possible values are (d)elta, (g)amma, (t)heta, v(e)ga, v(o)lga, v(a)nna, (r)ho, rho(f)       �  y  �  �   Probability that an asset hits a barrier assuming it follows dS/S = mu dt + vol dW      स्पॉट     Price/value S of the underlying asset     आयतन      Annual volatility of the underlying asset     बहाव      Parameter mu in dS/S = mu dt + vol dW     T     Time to maturity      barrier_low     Lower barrier (set to 0 for no lower barrier)     barrier_up      Upper barrier (set to 0 for no upper barrier)       �  y       Probability that an asset will at maturity end up between two barrier levels, assuming it follows dS/S = mu dt + vol dW (if the last two optional parameters (strike, put/call) are specified, the probability of S_T in [strike, upper barrier] for a call and S_T in [lower barrier, strike] for a put will be returned)      स्पॉट     Price/value of the asset      आयतन      Annual volatility of the asset      बहाव      Parameter mu from dS/S = mu dt + vol dW     T     Time to maturity in years     barrier_low     Lower barrier (set to 0 for no lower barrier)     barrier_up      Upper barrier (set to 0 for no upper barrier)     put/call      Optional (p)ut/(c)all indicator     लिखकर काटें     Optional strike level       �  y   $   $   OPT_BARRIER       �  y   "   "   OPT_TOUCH       �  y   &   &   OPT_PROB_HIT        �  y   *   *   OPT_PROB_INMONEY         �                �  &    �        �       �   6    �   T  y  �   v  y  �    y  �  	�  y  �  ~  y  �  �  y  �  �  y  �  �  y  �  �   �