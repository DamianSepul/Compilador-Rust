using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compi_1
{
    
    public class Error
    {
        private int codigo;
        private string mensajeError;
        private TipoError tipo;
        private int linea;

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;  
            }
        }

        public string MensajeError
        {
            get
            {
                return mensajeError;
            }

            set
            {
                mensajeError = value;
            }
        }

        public TipoError Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public int Linea
        {
            get
            {
                return linea;
            }
            set
            {
                linea = value;
            }
        }

    }

    public class Token
    {
        private TipoToken tipoToken;
        private int valorToken;
        private string lexema;
        private int linea;

        public TipoToken TipoToken
        {
            get
            {
                return tipoToken;
            }
            set
            {
                tipoToken = value;
            }
        }

        public int ValorToken
        {
            get
            {
                return valorToken;
            }
            set 
            {
                valorToken = value;
            }
        }

        public string Lexema
        {
            get
            {
                return lexema;
            }
            set
            {
                lexema = value;
            }
        }

        public int Linea
        {
            get
            {
                return linea;
            }
            set
            {
                linea = value;
            }
        }
    }

    public class Varia
    {
        private string id;
        private  TipoVariable tipovariable;
        
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public  TipoVariable TipoVariable
        {
            get
            {
                return tipovariable;

            }
            set
            {
                tipovariable = value;
            }
        }

        
    }

    

    public enum TipoToken
    {
        Simbolo_Simple,
        Operador_Aritmetico,
        Operador_Logico,
        Operador_Asignacion,
        Palabra_Reservada,
        Simbolo_Doble,
        Identificador,
        Numero_Entero,
        Numero_Decimal,
        Cadena,
        Caracter,
        OperadorRelacional
    }
    public enum TipoError
    {
        Lexico,Sintatico,Semantico,Ejecucion
    }

    public enum TipoVariable
    {
        Entero, String, Real
    }

    public class Lexico
    {
        public List<Token> ListaToken;
        private string codigoFuente;
        public List<Error> ListaError;
        private int linea;
        private int[,] matrizTransacion =
        {
            //  0   ||  1   ||  2   ||  3   ||  4   ||  5   ||  6   ||  7   ||  8   ||  9   ||  10  ||  11  ||  12  ||  13  ||  14  ||  15  ||  16  ||  17  ||  18  ||  19  ||  20  ||  21  ||  22  ||  23  ||  24  ||  25  ||  26  ||  27  ||  28  ||  29  ||  30  ||  31  ||  32  ||
            //  Let ||  Dig ||  (   ||  )   ||  ;   ||  .   ||  [   ||  ]   ||  {   ||  }   ||  ,   ||  +   ||  -   ||  *   ||  =   ||  /   ||  |   ||  &   ||  <   ||  >   ||  !   ||  %   ||  ¡   ||  :   ||  ^   ||  "   ||  '   ||  _   ||  esp ||  ent ||  tab ||  eof ||  oc  ||
       /*0*/{    1   ,   3   ,  -5   ,  -6   ,  -7   ,  -8   ,  -9   ,  -10  , -11  , -12    , -13   ,  9    ,  10   ,  11   ,  13   ,  12   ,  14   ,  15   ,  16   ,  17   ,  18   , -36   , -37   , 19    , 20    ,  6    ,  7   ,  -500  ,    0  ,   0   ,   0   ,   0   ,   0   },
       /*1*/{    1   ,   1   ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   ,  -1  ,  -1    ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   ,  1    ,  -500 ,  -500 ,  -1   , -1    ,  -1   ,  -1  ,   2    ,    -1 ,  -1   ,  -1   ,  -1   , -500    },
       /*2*/{    1   ,   1   , -500  , -500  , -500  , -500  , -500  , -500  , -500 , -500   , -500  , -500  , -500  , -500  , -500  , -500  , -500  , -500  , -500  , -500  , 500   , -500  , -500  , -500  ,-500   , -500  , -500 , -500   ,    -1 ,  -1   ,   -1  , -1    ,  -500   },
       /*3*/{  -501  ,   3   , -501  ,  -2   ,  -2   ,   4   , -501  ,  -2   , -501 , -501   ,  -2   ,  -2   ,  -2   ,  -2   ,  -2   ,  -2   ,  -2   ,  -2   ,  -2   ,  -2   ,  -2   ,  -2   , -501  , -2    , -501  , -501  , -501 , -501   ,    -2 ,  -2   ,   -2  ,  -2   ,  -500   },
       /*4*/{  -502  ,   5   , -502  , -502  , -502  , -502  , -502  , -502  , -502 , -502   , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502 , -502   ,  -502 , -502  ,  -502 , -502  , -502  },
       /*5*/{  -502  ,   5   , -502  ,  -3   ,  -3   ,  -502 , -502  ,  -3   , -502 , -502   ,  -3   ,  -3   ,  -3   ,  -3   ,  -3   ,  -3   ,  -3   ,  -3   ,  -3   ,  -3   ,  -3   ,  -3   ,  -3   ,  -3   ,  -3   , -502  , -502 , -502   ,    -3 ,  -3   ,   -3  ,  -3   ,  -500   },
       /*6*/{    6   ,   6   ,  6    ,   6   ,   6   ,   6   ,   6   ,   6   ,   6  ,   6    ,   6   ,   6   ,  6    ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,  -4   ,  6   ,  6     ,    6  ,-500   ,    6  ,  -507 , -500  },
       /*7*/{    8   ,   8   ,  8    ,   8   ,   8   ,   8   ,   8   ,   8   ,   8  ,   8    ,   8   ,   8   ,   8   ,   8   ,   8   ,   8   ,   8   ,   8   ,   8   ,   8   ,   8   ,   8   ,   8   ,   8   ,   8   ,   8   , -14  ,  8     ,    8  ,   8   ,    8  ,  -503 ,  -500   },
       /*8*/{  -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504 , -504   , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -14  , -504   ,  -504 , -504  ,  -504 ,  -504 , -504  },
       /*9*/{   -15  ,  -15  ,  -15  ,  -15  ,  -15  ,  -15  ,  -15  ,  -15  ,  -15 ,  -15   ,  -15  ,  -27  , -15   , -15   ,  -20  ,  -15  ,  -15  , -15   ,  -15  ,  -15  ,  -15  ,  -15  ,  -15  ,  -15  ,  -15  ,  -15  , -15  ,  -15   ,  -15  ,  -15  ,  -15  ,  -15  ,  -500  },
      /*10*/{   -16  ,  -16  ,  -16  ,  -16  ,  -16  ,  -16  ,  -16  ,  -16  ,  -16 ,  -16   ,  -16  ,  -16  , -28   , -16   ,  -35  ,  -16  ,  -16  , -16   ,  -16  ,  -16  ,  -16  ,  -16  ,  -16  ,  -16  ,  -16  ,  -16  , -16  ,  -16   ,  -16  ,  -16  ,  -16  ,  -16  ,  -500  },
      /*11*/{   -17  ,  -17  ,  -17  ,  -17  ,  -17  ,  -17  ,  -17  ,  -17  ,  -17 ,  -17   ,  -17  ,  -17  , -17   , -17   ,  -21  ,  -17  ,  -17  , -17   ,  -17  ,  -17  ,  -17  ,  -17  ,  -17  ,  -17  ,  -17  ,  -17  , -17  ,  -17   ,  -17  ,  -17  ,  -17  ,  -17  ,  -500  },
      /*12*/{   -18  ,  -18  ,  -18  ,  -18  ,  -18  ,  -18  ,  -18  ,  -18  ,  -18 ,  -18   ,  -18  ,  -18  , -18   , -18   ,  -22  ,   21  ,  -18  , -18   ,  -18  ,  -18  ,  -18  ,  -18  ,  -18  ,  -18  ,  -18  ,  -18  , -18  ,  -18   ,  -18  ,  -18  ,  -18  ,  -18  ,  -500  },
      /*13*/{   -19  ,  -19  ,  -19  ,  -19  ,  -19  ,  -19  ,  -19  ,  -19  ,  -19 ,  -19   ,  -19  ,  -19  , -19   , -19   ,  -39  ,  -14  ,  -19  , -19   ,  -19  ,  -19  ,  -19  ,  -19  ,  -19  ,  -19  ,  -19  ,  -19  , -19  ,  -19   ,  -19  ,  -19  ,  -19  ,  -19  ,  -500  },
      /*14*/{   -25  ,  -25  ,  -25  ,  -25  ,  -25  ,  -25  ,  -25  ,  -25  ,  -25 ,  -25   ,  -25  ,  -25  , -25   , -25   ,  -89  ,  -25  ,  -23  , -25   ,  -25  ,  -25  ,  -25  ,  -25  ,  -25  ,  -25  ,  -25  ,  -25  , -25  ,  -25   ,  -25  ,  -25  ,  -25  ,  -25  ,  -500  },
      /*15*/{   -26  ,  -26  ,  -26  ,  -26  ,  -26  ,  -26  ,  -26  ,  -26  ,  -26 ,  -26   ,  -26  ,  -26  , -26   , -26   ,  -26  ,  -26  ,  -26  , -24   ,  -26  ,  -26  ,  -26  ,  -26  ,  -26  ,  -26  ,  -26  ,  -26  , -26  ,  -26   ,  -26  ,  -26  ,  -26  ,  -26  ,  -500  },
      /*16*/{   -29  ,  -29  ,  -29  ,  -29  ,  -29  ,  -29  ,  -29  ,  -29  ,  -29 ,  -29   ,  -29  ,  -29  , -29   , -29   ,  -32  ,  -29  ,  -29  ,  -29  ,   23  ,  -29  ,  -29  ,  -29  ,  -29  ,  -29  ,  -29  ,  -29  , -29  ,  -29   ,  -29  ,  -29  ,  -29  ,  -29  ,  -500  },
      /*17*/{   -30  ,  -30  ,  -30  ,  -30  ,  -30  ,  -30  ,  -30  ,  -30  ,  -30 ,  -30   ,  -30  ,  -30  , -30   , -30   ,  -31  ,  -30  ,  -30  ,  -30  ,  -30  ,   24  ,  -30  ,  -30  ,  -30  ,  -30  ,  -30  ,  -30  , -30  ,  -30   ,  -30  ,  -30  ,  -30  ,  -30  ,  -500  },
      /*18*/{   -96  ,  -96  ,  -96  ,  -96  ,  -96  ,  -96  ,  -96  ,  -96  ,  -96 ,  -96   ,  -96  ,  -96  , -96   , -96   ,  -33  ,  -96  ,  -96  ,  -96  ,  -96  ,  -96  ,  -96  ,  -96  ,  -96  ,  -96  ,  -96  ,  -96  , -96  ,  -96   ,  -96  ,  -96  ,  -96  ,  -96  ,  -500  },
      /*19*/{   -38  ,  -38  ,  -38  ,  -38  ,  -38  ,  -38  ,  -38  ,  -38  ,  -38 ,  -38   ,  -38  ,  -38  , -38   , -38   ,  -38  ,  -38  ,  -38  ,  -38  ,  -38  ,  -38  ,  -38  ,  -38  ,  -38  ,  -39  ,  -38  ,  -38  , -38  ,  -38   ,  -38  ,  -38  ,  -38  ,  -38  ,  -500  },
      /*20*/{   -84  ,  -84  ,  -84  ,  -84  ,  -84  ,  -84  ,  -84  ,  -84  ,  -84 ,  -84   ,  -84  ,  -84  , -84   , -84   ,  -85  ,  -85  ,  -85  ,  -85  ,  -85  ,  -85  ,  -85  ,  -85  ,  -85  ,  -85  ,  -85  ,  -85  , -85  ,  -85   ,  -85  ,  -85  ,  -85  ,  -85  ,  -500  },
      /*21*/{  -505  , -505  , -505  , -505  , -505  , -505  , -505  , -505  , -505 , -505   , -505  , -505  , -505  , -505  , -505  ,   22  , -505  ,  -505 ,  -505 , -505  , -505  , -505  , -505  , -505  , -505  , -505  , -505 , -505   , -505  , -505  , -505  , -505  , -505  },
      /*22*/{   22   ,  22   ,   22  ,   22  ,   22  ,   22  ,   22  ,   22  ,   22 ,   22   ,   22  ,   22  ,  22   ,  22   ,   22  ,   22  ,   22  ,   22  ,   22  ,   22  ,   22  ,   22  ,   22  ,   22  ,   22  ,   22  ,  22  ,   22   ,   22  ,   0   ,   22  ,    0  ,   500  },
      /*23*/{   -506 , -506  , -506  , -506  , -506  , -506  , -506  , -506  , -506 , -506   , -506  , -506  , -506  , -506  ,  -93  , -506  , -506  ,  -506 ,  -506 , -506  , -506  , -506  , -506  , -506  , -506  , -506  , -506 , -506   , -506  , -506  , -506  , -506  , -506  },
      /*24*/{   -506 , -506  , -506  , -506  , -506  , -506  , -506  , -506  , -506 , -506   , -506  , -506  , -506  , -506  ,  -94  , -506  , -506  ,  -506 ,  -506 , -506  , -506  , -506  , -506  , -506  , -506  , -506  , -506 , -506   , -506  , -506  , -506  , -506  , -506  },


        };

        //Constructor
        public Lexico(string codigofuente)
        {
            codigoFuente = codigofuente + " ";
            ListaToken = new List<Token>();
            ListaError = new List<Error>();
        }

        private int PalabraReservada(string lexema)
        {
            switch (lexema)
            {
                case "as":
                    return -40;
                case "break":
                    return -41;
                case "const":
                    return -42;
                case "continue":
                    return -43;
                case "crate":
                    return -44;
                case "else":
                    return -45;
                case "enum":
                    return -46;
                case "extern":
                    return -47;
                case "false":
                    return -48;
                case "fn":
                    return -49;
                case "for":
                    return -50;
                case "if":
                    return -51;
                case "impl":
                    return -52;
                case "in":
                    return -53;
                case "let":
                    return -54;
                case "loop":
                    return -55;
                case "match":
                    return -56;
                case "mod":
                    return -57;
                case "move":
                    return -58;
                case "mut":
                    return -59;
                case "pub":
                    return -60;
                case "ref":
                    return -61;
                case "return":
                    return -62;
                case "self":
                    return -63;
                case "static":
                    return -64;
                case "struct":
                    return -65;
                case "super":
                    return -66;
                case "trait":
                    return -67;
                case "true":
                    return -68;
                case "type":
                    return -69;
                case "use":
                    return -70;
                case "where":
                    return -71;
                case "while":
                    return -72;
                case "become":
                    return -73;
                case "std":
                    return -74;
                case "do":
                    return -75;
                case "final":
                    return -76;
                case "override":
                    return -77;
                case "priv":
                    return -78;
                case "typeof":
                    return -79;
                case "unsized":
                    return -80;
                case "virtual":
                    return -81;
                case "try":
                    return -82;
                case "auto":
                    return -83;
                case "catch":
                    return -86;
                case "default":
                    return -87;
                case "new":
                    return -88;
                case "String":
                    return -95;
                case "main":
                    return -97;
                case "print":
                    return -98;
                case "println!":
                    return -99;
                case "i32":
                    return -100;
                case "str":
                    return -101;
                case "u8":
                    return -102;
                case "f32":
                    return -103;
                case "f64":
                    return -104;
                            
                    
                default:
                    return -1;
            }
        }

        private char SiguienteCaracter(int i)
        {
            return Convert.ToChar(codigoFuente.Substring(i, 1));
        }
        
        private int Regresarcolumna (char caracter)
        {
            if (char.IsLetter(caracter))
                return 0;

            else if (char.IsDigit(caracter))
                return 1;

            else if (caracter.Equals('('))
                return 2;

            else if (caracter.Equals(')'))
                return 3;

            else if (caracter.Equals(';'))
                return 4;

            else if (caracter.Equals('.'))
                return 5;

            else if (caracter.Equals('['))
                return 6;

            else if (caracter.Equals(']'))
                return 7;

            else if (caracter.Equals('{'))
                return 8;

            else if (caracter.Equals('}'))
                return 9;

            else if (caracter.Equals(','))
                return 10;

            else if (caracter.Equals('+'))
                return 11;

            else if (caracter.Equals('-'))
                return 12;

            else if (caracter.Equals('*'))
                return 13;

            else if (caracter.Equals('='))
                return 14;

            else if (caracter.Equals('/'))
                return 15;

            else if (caracter.Equals('|'))
                return 16;

            else if (caracter.Equals('&'))
                return 17;

            else if (caracter.Equals('<'))
                return 18;

            else if (caracter.Equals('>'))
                return 19;

            else if (caracter.Equals('!'))
                return 20;

            else if (caracter.Equals('%'))
                return 21;

            else if (caracter.Equals('¡'))
                return 22;

            else if (caracter.Equals(':'))
                return 23;

            else if (caracter.Equals('^'))
                return 24;

            else if (caracter.Equals('"'))
                return 25;

            else if (caracter == Convert.ToChar("'"))
                return 26;

            else if (caracter.Equals('_'))
                return 27;

            else if (caracter.Equals(' '))
                return 28;

            else if (caracter.Equals('\n'))
                return 29;

            else if (caracter.Equals('\t'))
                return 30;
           
            else if (caracter.Equals('\r'))
                return 31;

            else return 32;
       



        }

        private TipoToken Tipo(int estado)
        {
            switch (estado)
            {
                case -1:
                    return TipoToken.Identificador;
                case -2:
                    return TipoToken.Numero_Entero;
                case -3:
                    return TipoToken.Numero_Decimal;
                case -4:
                    return TipoToken.Cadena;
                case -5:
                    return TipoToken.Simbolo_Simple;
                case -6:
                    return TipoToken.Simbolo_Simple;
                case -7:
                    return TipoToken.Simbolo_Simple;
                case -8:
                    return TipoToken.Simbolo_Simple;
                case -9:
                    return TipoToken.Simbolo_Simple;
                case -10:
                    return TipoToken.Simbolo_Simple;
                case -11:
                    return TipoToken.Simbolo_Simple;
                case -12:
                    return TipoToken.Simbolo_Simple;
                case -13:
                    return TipoToken.Simbolo_Simple;
                case -14:
                    return TipoToken.Caracter;
                case -15:
                    return TipoToken.Operador_Aritmetico;
                case -16:
                    return TipoToken.Operador_Aritmetico;
                case -17:
                    return TipoToken.Operador_Aritmetico;
                case -18:
                    return TipoToken.Operador_Aritmetico;
                case -19:
                    return TipoToken.Operador_Asignacion;
                case -20:
                    return TipoToken.Operador_Asignacion;
                case -21:
                    return TipoToken.Operador_Asignacion;
                case -22:
                    return TipoToken.Operador_Asignacion;
                case -23:
                    return TipoToken.Operador_Logico;
                case -24:
                    return TipoToken.Operador_Logico;
                case -25:
                    return TipoToken.Simbolo_Simple;
                case -26:
                    return TipoToken.Simbolo_Simple;
                case -27:
                    return TipoToken.Simbolo_Doble;
                case -28:
                    return TipoToken.Simbolo_Doble;
                case -29:
                    return TipoToken.OperadorRelacional;
                case -30:
                    return TipoToken.OperadorRelacional;
                case -31:
                    return TipoToken.OperadorRelacional;
                case -32:
                    return TipoToken.OperadorRelacional;
                case -33:
                    return TipoToken.OperadorRelacional;
                case -34:
                    return TipoToken.Operador_Asignacion;
                case -35:
                    return TipoToken.Operador_Asignacion;
                case -36:
                    return TipoToken.Simbolo_Simple;
                case -37:
                    return TipoToken.Simbolo_Simple;
                case -38:
                    return TipoToken.Simbolo_Simple;
                case -39:
                    return TipoToken.Simbolo_Doble;
                case -40:
                    return TipoToken.Palabra_Reservada;
                case -41:
                    return TipoToken.Palabra_Reservada;
                case -42:
                    return TipoToken.Palabra_Reservada;
                case -43:
                    return TipoToken.Palabra_Reservada;
                case -44:
                    return TipoToken.Palabra_Reservada;
                case -45:
                    return TipoToken.Palabra_Reservada;
                case -46:
                    return TipoToken.Palabra_Reservada;
                case -47:
                    return TipoToken.Palabra_Reservada;
                case -48:
                    return TipoToken.Palabra_Reservada;
                case -49:
                    return TipoToken.Palabra_Reservada;
                case -50:
                    return TipoToken.Palabra_Reservada;
                case -51:
                    return TipoToken.Palabra_Reservada;
                case -52:
                    return TipoToken.Palabra_Reservada;
                case -53:
                    return TipoToken.Palabra_Reservada;
                case -54:
                    return TipoToken.Palabra_Reservada;
                case -55:
                    return TipoToken.Palabra_Reservada;
                case -56:
                    return TipoToken.Palabra_Reservada;
                case -57:
                    return TipoToken.Palabra_Reservada;
                case -58:
                    return TipoToken.Palabra_Reservada;
                case -59:
                    return TipoToken.Palabra_Reservada;
                case -60:
                    return TipoToken.Palabra_Reservada;
                case -61:
                    return TipoToken.Palabra_Reservada;
                case -62:
                    return TipoToken.Palabra_Reservada;
                case -63:
                    return TipoToken.Palabra_Reservada;
                case -64:
                    return TipoToken.Palabra_Reservada;
                case -65:
                    return TipoToken.Palabra_Reservada;
                case -66:
                    return TipoToken.Palabra_Reservada;
                case -67:
                    return TipoToken.Palabra_Reservada;
                case -68:
                    return TipoToken.Palabra_Reservada;
                case -69:
                    return TipoToken.Palabra_Reservada;
                case -70:
                    return TipoToken.Palabra_Reservada;
                case -71:
                    return TipoToken.Palabra_Reservada;
                case -72:
                    return TipoToken.Palabra_Reservada;
                case -73:
                    return TipoToken.Palabra_Reservada;
                case -74:
                    return TipoToken.Palabra_Reservada;
                case -75:
                    return TipoToken.Palabra_Reservada;
                case -76:
                    return TipoToken.Palabra_Reservada;
                case -77:
                    return TipoToken.Palabra_Reservada;
                case -78:
                    return TipoToken.Palabra_Reservada;
                case -79:
                    return TipoToken.Palabra_Reservada;
                case -80:
                    return TipoToken.Palabra_Reservada;
                case -81:
                    return TipoToken.Palabra_Reservada;
                case -82:
                    return TipoToken.Palabra_Reservada;
                case -83:
                    return TipoToken.Palabra_Reservada;
                case -84:
                    return TipoToken.Simbolo_Simple;
                case -85:
                    return TipoToken.Simbolo_Doble;
                case -86:
                    return TipoToken.Palabra_Reservada;
                case -87:
                    return TipoToken.Palabra_Reservada;
                case -88:
                    return TipoToken.Palabra_Reservada;
                case -89:
                    return TipoToken.Simbolo_Doble;
                case -90:
                    return TipoToken.Palabra_Reservada;
                case -91:
                    return TipoToken.Simbolo_Doble;
                case -92:
                    return TipoToken.Palabra_Reservada;
                case -93:
                    return TipoToken.Simbolo_Doble;
                case -94:
                    return TipoToken.Simbolo_Doble;
                case -95:
                    return TipoToken.Palabra_Reservada;
                case -96:
                    return TipoToken.Operador_Logico;
                default:
                    return TipoToken.Palabra_Reservada;

            }
        }

        private Error Errores (int estado)
        {
            string mensaje_error;
            switch (estado)
            {
                case -500:
                    mensaje_error = "Esperaba otro caracter";
                    break;
                case -501:
                    mensaje_error = "Se esperaba un numero";
                    break;
                case -502:
                    mensaje_error = "Se esperaba un decimal";
                    break;
                case -503:
                    mensaje_error = "Se esperaba un caracter";
                    break;
                case -504:
                    mensaje_error = "Se esperaba un ' ";
                    break;
                case -505:
                    mensaje_error = "Se esperaba otro / ";
                    break;
                case -506:
                    mensaje_error = "Se esperaba un =";
                    break;
                case -507:
                    mensaje_error = "Se esperaba el cierre de la cadena";
                    break;
                default:
                    mensaje_error = "Error inesperado";
                    break;
            }
            return new Error()
            {
                Codigo = estado,
                MensajeError = mensaje_error,
                Tipo = TipoError.Lexico,
                Linea = linea
            };

            
        }

       

        public List<Token> EjecutadorLexico()
        {
            int estado = 0;
            int columna = 0;

            char caracterActual;
            string lexema = string.Empty;
            linea = 1;

            for (int puntero = 0; puntero < codigoFuente.ToCharArray().Length; puntero++)
            {
                caracterActual = SiguienteCaracter(puntero);
                if (caracterActual.Equals('\n'))
                {
                    linea++;
                }
                lexema += caracterActual;

                columna = Regresarcolumna(caracterActual);
                estado = matrizTransacion[estado, columna];
                if (estado<0 && estado > -500) 
                {
                    if (lexema.Length > 1)
                    {
                        lexema = lexema.Remove(lexema.Length - 1);
                        puntero--; 
                    }

                    
                    Token nuevoToken = new Token() { ValorToken = estado, Lexema = lexema, Linea = linea };
                    //Cadena
                    if (estado==-4)
                    {
                        nuevoToken.Lexema += '"';
                        puntero++;
                    }

                    
                    //Caracter 
                    if (estado == -14)
                    {
                        nuevoToken.Lexema += "'";
                        puntero++;
                    }
                    //Simbolos dobles 

                    if (estado == -27)
                    {
                        nuevoToken.Lexema = "++";
                        puntero++;    
                    }
                    if (estado == -20)
                    {
                        nuevoToken.Lexema = "+=";
                        puntero++;
                    }
                    if (estado == -21)
                    {
                        nuevoToken.Lexema = "*=";
                        puntero++;
                    }
                    if (estado == -22)
                    {
                        nuevoToken.Lexema = "/=";
                        puntero++;
                    }
                    if (estado == -23)
                    {
                        nuevoToken.Lexema = "||";
                        puntero++;
                    }
                    if (estado == -24)
                    {
                        nuevoToken.Lexema = "&&";
                        puntero++;
                    }
                    if (estado == -28)
                    {
                        nuevoToken.Lexema = "--";
                        puntero++;
                    }
                    if (estado == -31)
                    {
                        nuevoToken.Lexema = ">=";
                        puntero++;
                    }
                    if (estado == -32)
                    {
                        nuevoToken.Lexema = "<=";
                        puntero++;
                    }
                    if (estado == -34)
                    {
                        nuevoToken.Lexema = "==";
                        puntero++;
                    }
                    if (estado == -35)
                    {
                        nuevoToken.Lexema = "-=";
                        puntero++;
                    }
                    if (estado == -39)
                    {
                        nuevoToken.Lexema = "::";
                        puntero++;
                    }
                    if (estado == -85)
                    {
                        nuevoToken.Lexema = "^=";
                        puntero++;
                    }
                    if (estado == -89)
                    {
                        nuevoToken.Lexema = "|=";
                        puntero++;
                    }
                    if (estado == -90)
                    {
                        nuevoToken.Lexema = "->";
                        puntero++;
                    }
                    if (estado == -91)
                    {
                        nuevoToken.Lexema = ">>";
                        puntero++;
                    }
                    if (estado == -92)
                    {
                        nuevoToken.Lexema = "<<";
                        puntero++;
                    }
                    if (estado == -93)
                    {
                        nuevoToken.Lexema = "<<=";
                        puntero++;
                        puntero++;
                    }
                    if (estado == -94)
                    {
                        nuevoToken.Lexema = ">>=";
                        puntero++;
                        puntero++;
                    }



                    if (estado == -1)
                        nuevoToken.ValorToken = PalabraReservada(nuevoToken.Lexema);      
                    nuevoToken.TipoToken = Tipo(nuevoToken.ValorToken);

                    ListaToken.Add(nuevoToken);
                    estado = 0;
                    columna = 0;
                    lexema = string.Empty;

                }
                else if (estado<= -500 )
                {
                    do
                    {
                        puntero++;
                        caracterActual = SiguienteCaracter(puntero);
                        if (caracterActual == ' ' || caracterActual=='\n')
                            break;
                    } while (true);

                    ListaError.Add(Errores(estado));

                    estado = 0;
                    columna = 0;
                    lexema = string.Empty;
                }
                else if (estado == 0)
                {
                    columna = 0;
                    lexema = string.Empty;
                }
                

            }
            return ListaToken;

        }

    }
}
