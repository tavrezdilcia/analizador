namespace analizador_lexico
{
    class Class
    {
    }

    class Automata  {
        string _textoIma;
        int _edoAct;
        char SigCar(ref int i)
        {
            if (i == _textoIma.Length)
            {
                i++;
                return ' ';
            } else
                return _textoIma[i++];
        }
    public bool Reconoce(string texto, int iniToken, ref int i, int noAuto)
        {
            char c;
            _textoIma = texto;
            string lenguaje;
            switch (noAuto)
                {
                //--------------  Automata  delim--------------  
                case 0 : _edoAct = 0;
                    break;
                //--------------  Automata  id--------------  
                case 1 : _edoAct = 3;
                    break;
                //--------------  Automata  num--------------  
                case 2 : _edoAct = 6;
                    break;
                //--------------  Automata  otros--------------  
                case 3 : _edoAct = 9;
                    break;
                //--------------  Automata  cad--------------  
                case 4 : _edoAct = 11;
                    break;
            }  while(i<=_textoIma.Length)
                switch (_edoAct)
                {
                    //--------------  Automata  delim--------------  
                    case 0 : c=SigCar(ref i);
                        if ((lenguaje=" \n\r\t").IndexOf(c)>=0)
                            _edoAct =1;
                        else
                        {
                            i =iniToken;
                            return false;
                        }
                        break;
                    case 1 : c=SigCar(ref i);
                        if ((lenguaje=" \n\r\t").IndexOf(c)>=0)
                            _edoAct =1;
                        else if ((lenguaje="!\"#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_'abcdefghijklmnopqrstuvwxyz{|}~€‚ƒ„...†‡ˆ‰Š‹ŒŽ''“”•–— ̃™š›œžŸ ¡¢£¤¥¦§ ̈©ª«¬-® ̄°±²³ ́μ¶· ̧¹º»¼½¾¿\f").IndexOf(c)>=0)
                            _edoAct =2;
                        else
                        {
                            i =iniToken;
                            return false;
                        }
                        break;
                    case 2 : i--;
                        return true;
                        break;
                    //--------------  Automata  id--------------  
                    case 3 : c=SigCar(ref i);
                        if ((lenguaje="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz").IndexOf(c)>=0)
                            _edoAct =4;
                        else
                        {
                            i =iniToken;
                            return false;
                        }
                        break;
                    case 4 : c=SigCar(ref i);
                        if ((lenguaje="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz").IndexOf(c)>=0)
                            _edoAct =4;
                        else if ((lenguaje="0123456789").IndexOf(c)>=0)
                            _edoAct =4;
                        else if ((lenguaje="_").IndexOf(c)>=0)
                            _edoAct =4;
                        else if ((lenguaje=" !\"#$%&\'()*+,-./:;<=>?@[\\]^`{|}~€‚ƒ„...†‡ˆ‰Š‹ŒŽ‘’“”•–— ̃™š›œžŸ ¡¢£¤¥¦§ ̈©ª«¬-® ̄°±²³ ́μ¶· ̧¹º»¼½¾¿\n\t\r\f").IndexOf(c)>=0)
                            _edoAct =5;
                        else
                        {
                            i =iniToken;
                            return false;
                        }
                        break;
                    case 5 : i--;
                        return true;
                        break;
                    //--------------  Automata  num--------------  
                    case 6 : c=SigCar(ref i);
                        if ((lenguaje="0123456789").IndexOf(c)>=0)
                            _edoAct =7;
                        else
                        {
                            i =iniToken;
                            return false;
                        }  break;
                    case 7 : c=SigCar(ref i);
                        if ((lenguaje="0123456789").IndexOf(c)>=0)
                            _edoAct =7;
                        else if ((lenguaje=" !\"#$%&\'()*+,-./:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~€‚ƒ„...†‡ˆ‰Š‹ŒŽ‘’“”•–— ̃™š›œžŸ ¡¢£¤¥¦§ ̈©ª«¬-® ̄°±²³ ́μ¶· ̧¹º»¼½¾¿\n\t\r\f").IndexOf(c)>=0)
                            _edoAct =8;
                        else
                        {
                            i =iniToken;
                            return false;
                        }
                        break;
                    case 8 : i--;
                        return true;
                        break;
                    //--------------  Automata  otros-------------- 
                    case 9 : c=SigCar(ref i);
                        if ((lenguaje="=").IndexOf(c)>=0)
                            _edoAct =10;
                        else if ((lenguaje=";").IndexOf(c)>=0)
                            _edoAct =10;
                        else if ((lenguaje=",").IndexOf(c)>=0)
                            _edoAct =10;
                        else if ((lenguaje=".").IndexOf(c)>=0)
                            _edoAct = 10;
                        else if ((lenguaje="+").IndexOf(c)>=0)
                            _edoAct =10;
                        else if ((lenguaje="-").IndexOf(c)>=0)
                            _edoAct =10;
                        else if ((lenguaje="*").IndexOf(c)>=0)
                            _edoAct =10;
                        else if ((lenguaje="/").IndexOf(c)>=0)
                            _edoAct =10;
                        else if ((lenguaje="(").IndexOf(c)>=0)
                            _edoAct =10;
                        else if ((lenguaje=")").IndexOf(c)>=0)
                            _edoAct =10;
                        else
                        {
                            i =iniToken;
                            return false;
                        }
                        break;
                    case 10 : return true;
                        break;
                    //--------------  Automata  cad-------------- 
                    case 11 : c=SigCar(ref i);
                        if ((lenguaje="\"").IndexOf(c)>=0)
                            _edoAct =12;
                        else
                        {
                            i =iniToken;
                            return false;
                        }
                        break;
                    case 12 : c=SigCar(ref i);
                        if ((lenguaje="\"").IndexOf(c)>=0)
                            _edoAct =13;
                        else if((lenguaje= " !#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~€‚ƒ„...†‡ˆ‰Š‹ŒŽ‘’“”•–— ̃™š›œžŸ ¡¢£¤¥¦§ ̈©ª«¬-® ̄°±²³ ́μ¶· ̧¹º»¼½¾¿\n\t\r\f").IndexOf(c)>=0)
                            _edoAct =12;
                        else
                        {
                            i =iniToken;
                            return false;
                        }
                        break;
                    case 13 : return true;
                        break;
                }
            switch (_edoAct)
            {
                case 2: // Autómata  delim  
                case 5:      // Autómata  id 
                case 8:      // Autómata  num  
                    --i;
                    return true;
            }
            return false;
        }
    }//Fin de la clase Automata

    class Lexico
    { const int TOKREC = 5;
        const int MAXTOKENS = 500;
        string[] _lexemas;
        string[] _tokens;
        string _lexema;
        int _noTokens;
        int _i;
        int _iniToken;
        Automata oAFD;
        public Lexico()  // constructor por defecto 
        {
            _lexemas = new string[MAXTOKENS];
            _tokens = new string[MAXTOKENS];
            oAFD = new Automata();
            _i = 0;
            _iniToken = 0;
            _noTokens = 0;
        }
        public int NoTokens
        {
            get { return _noTokens; }
        }
        public string[] Lexema
        {
            get { return _lexemas; }
        }
        public string[] Token
        {
            get { return _tokens; }

        }
        public void Inicia()
        {
            _i = 0;
            _iniToken = 0;
            _noTokens = 0;
        }
        public void Analiza(string texto)
        {
            bool recAuto;
            int noAuto;
            while (_i < texto.Length)
            {
                recAuto = false;
                noAuto = 0;
                for (; noAuto < TOKREC && !recAuto;)
                    if (oAFD.Reconoce(texto, _iniToken, ref _i, noAuto))
                        recAuto = true;
                    else
                        noAuto++;
                if (recAuto)
                {
                    _lexema = texto.Substring(_iniToken, _i - _iniToken);
                    switch (noAuto)
                    {
                        //--------------  Automata  delim--------------  
                        case 0: // _tokens[_noTokens] = "delim";
                            break;
                        //--------------  Automata  id--------------  
                        case 1: if (EsId())
                                _tokens[_noTokens] = "id";
                            else
                                _tokens[_noTokens] = _lexema;
                            break;
                        //--------------  Automata  num--------------  
                        case 2: _tokens[_noTokens] = "num";
                            break;
                        //--------------  Automata  otros--------------  
                        case 3: _tokens[_noTokens] = _lexema;
                            break;
                        //--------------  Automata  cad--------------  
                        case 4: _tokens[_noTokens] = "cad";
                            break;
                    }
                    if (noAuto != 0)
                        _lexemas[_noTokens++] = _lexema;
                }
                else
                    _i++;
                _iniToken = _i;
            }
        }
        private bool EsId()
        {
            string[] palres = { "inicio", "fin", "const", "var", "entero", "real", "cadena", "leer", "visua" };
            for (int i = 0; i < palres.Length; i++)
                if (_lexema == palres[i])
                    return false;
            return true;
        }
    } //Fin de la clase Lexico


    }
