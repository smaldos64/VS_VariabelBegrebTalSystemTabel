using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using VariabelBegreb.NumberSystems;
using System.Collections.ObjectModel;

namespace VariabelBegreb.Tools
{
    public enum RadixNumber_ENUM
    {
        BINARY_NUMBER,
        OCTAL_NUMBER,
        DECIMAL_NUMBER,
        HEXADECIMAL_NUMBER,
        RADIX24_NUMBER,
        RADIX32_NUMBER,
        ROMER_NUMBER,
    }

    public class ConstRadixSystem
    {
        public RadixNumber_ENUM RadixNumber { get; set; }
        public int RadixValue { get; set; }
        public int RadixSpaceCounter { get; set; }
        public char RadixSpaceCharacter { get; set; }
        public Key[] ValidKeysArray;

        public ConstRadixSystem(RadixNumber_ENUM RadixNumber, int RadixValue, int RadixSpaceCounter, 
                                char RadixSpaceCharacter, Key[] ValidKeysArray)
        {
            this.RadixNumber = RadixNumber;
            this.RadixValue = RadixValue;
            this.RadixSpaceCounter = RadixSpaceCounter;
            this.RadixSpaceCharacter = RadixSpaceCharacter;
            this.ValidKeysArray = ValidKeysArray;
        }
    }

    public delegate string ConvertFromRadix10Int(int Radix10Number, char CharacterToInsert, int CharacterToInsertCouner);
    public delegate int ConvertToRadix10Int(string Radix10String, char CharacterToRemove);

    public class ConstRadixSystemAndDelegates
    {
        public ConstRadixSystem ConstRadixSystem_Object { get; set; }
        public ConvertToRadix10Int FunctionPointerToRadix10 { get; set; }
        public ConvertFromRadix10Int FunctionPointerFromRadix10 { get; set; }
        public TextBox TextBox_Object { get; set; }
        public string TextBox_Object_Name { get; set; }
        public string Label_Object_Name { get; set; } 
        public string Label_Object_Text { get; set; }

        public ConstRadixSystemAndDelegates(ConstRadixSystem ConstRadixSystem_Object,
                                            TextBox TextBox_Object,
                                            string TextBox_Object_Name,
                                            string Label_Object_Name,
                                            string Label_Object_Text,
                                            ConvertToRadix10Int FunctionPointerToRadix10,
                                            ConvertFromRadix10Int FunctionPointerFromRadix10)
        {
            this.ConstRadixSystem_Object = ConstRadixSystem_Object;
            this.TextBox_Object = TextBox_Object;
            this.TextBox_Object_Name = TextBox_Object_Name;
            this.Label_Object_Name = Label_Object_Name;
            this.Label_Object_Text = Label_Object_Text;
            this.FunctionPointerToRadix10 = FunctionPointerToRadix10;
            this.FunctionPointerFromRadix10 = FunctionPointerFromRadix10;
        }
    }

    public class ConstRadixSystemAndDelegatesExtended
    {
        public ConstRadixSystemAndDelegates ConstRadixSystemAndDelegates_Object { get; set; }
        public RadixNumber RadixNumber_Object { get; set; }

        public ConstRadixSystemAndDelegatesExtended(ConstRadixSystemAndDelegates ConstRadixSystemAndDelegates_Object,
                                                    RadixNumber RadixNumber_Object)
        {
            this.ConstRadixSystemAndDelegates_Object = ConstRadixSystemAndDelegates_Object;
            this.RadixNumber_Object = RadixNumber_Object;
        }
    }

    public class Const
    {
        #region TalSystemer
        public static readonly int GridStartNumberSystemRow = 5;
        public static readonly int LabelColumnPosition = 0;
        public static readonly int LabelColumnSpan = 2;
        public static readonly int TextBoxColumnPosition = 2;
        public static readonly int TextBoxColumnSpan = 4;
        public static readonly int TextBoxWidth = 240;
        public static readonly int TextBoxHeight = 23;

        private static Key[] Radix2ValidKeysArray = { Key.D0, Key.D1 };
        private static Key[] Radix8ValidKeysArray = { Key.D0, Key.D1, Key.D2, Key.D3, Key.D4, Key.D5, Key.D6, Key.D7};
        private static Key[] Radix10ValidKeysArray = { Key.D0, Key.D1, Key.D2, Key.D2, Key.D3, Key.D4,
                                                       Key.D5, Key.D6, Key.D7, Key.D8, Key.D9};
        private static Key[] Radix16ValidKeysArray = { Key.D0, Key.D1, Key.D2, Key.D3, Key.D4, Key.D5, Key.D6, Key.D7,
                                                       Key.D8, Key.D9, Key.A, Key.B, Key.C, Key.D, Key.E, Key.F};
        private static Key[] Radix24ValidKeysArray = { Key.D0, Key.D1, Key.D2, Key.D3, Key.D4, Key.D5, Key.D6, Key.D7,
                                                       Key.D8, Key.D9, Key.A, Key.B, Key.C, Key.D, Key.E, Key.F,
                                                       Key.G, Key.H, Key.I, Key.J, Key.L, Key.M, Key.N, Key.O};
        private static Key[] Radix32ValidKeysArray = { Key.D0, Key.D1, Key.D2, Key.D3, Key.D4, Key.D5, Key.D6, Key.D7,
                                                       Key.D8, Key.D9, Key.A, Key.B, Key.C, Key.D, Key.E, Key.F,
                                                       Key.G, Key.H, Key.I, Key.J, Key.K, Key.L, Key.M, Key.N,
                                                       Key.O, Key.P, Key.Q, Key.R, Key.S, Key.T, Key.U, Key.V};

        public static readonly ConstRadixSystem[] RadixSystemArray =
        {
            new ConstRadixSystem(RadixNumber : RadixNumber_ENUM.BINARY_NUMBER, RadixValue : 2, RadixSpaceCounter : 4, RadixSpaceCharacter : ' ', ValidKeysArray : Radix2ValidKeysArray),
            new ConstRadixSystem(RadixNumber : RadixNumber_ENUM.OCTAL_NUMBER, RadixValue : 8, RadixSpaceCounter : 3, RadixSpaceCharacter : ' ', ValidKeysArray : Radix8ValidKeysArray),
            new ConstRadixSystem(RadixNumber : RadixNumber_ENUM.DECIMAL_NUMBER, RadixValue : 10, RadixSpaceCounter : 3, RadixSpaceCharacter : '.', ValidKeysArray : Radix10ValidKeysArray),
            new ConstRadixSystem(RadixNumber : RadixNumber_ENUM.HEXADECIMAL_NUMBER, RadixValue : 16, RadixSpaceCounter : 4, RadixSpaceCharacter : ' ', ValidKeysArray : Radix16ValidKeysArray),
            new ConstRadixSystem(RadixNumber : RadixNumber_ENUM.RADIX24_NUMBER, RadixValue : 24, RadixSpaceCounter : 4, RadixSpaceCharacter : ' ', ValidKeysArray : Radix24ValidKeysArray),
            new ConstRadixSystem(RadixNumber : RadixNumber_ENUM.RADIX32_NUMBER, RadixValue : 32, RadixSpaceCounter : 4, RadixSpaceCharacter : ' ', ValidKeysArray : Radix32ValidKeysArray)
        };

        public static readonly ConstRadixSystemAndDelegates[] RadixSystemDelegatesAndControlsArray =
        {
            new ConstRadixSystemAndDelegates(ConstRadixSystem_Object : 
                                             RadixSystemArray[(int)RadixNumber_ENUM.BINARY_NUMBER],
                                             TextBox_Object : null,
                                             TextBox_Object_Name : "txtBinaryNumber",
                                             Label_Object_Name : "lblBinaryNumber",
                                             Label_Object_Text : "Binært tal (2 tals system) : ",
                                             FunctionPointerToRadix10 : null,
                                             FunctionPointerFromRadix10 : null),
            new ConstRadixSystemAndDelegates(ConstRadixSystem_Object :
                                             RadixSystemArray[(int)RadixNumber_ENUM.OCTAL_NUMBER],
                                             TextBox_Object : null,
                                             TextBox_Object_Name : "txtOctalNumber",
                                             Label_Object_Name : "lblOctalNumber",
                                             Label_Object_Text : "Oktalt tal (8 tals system) : ",
                                             FunctionPointerToRadix10 : null,
                                             FunctionPointerFromRadix10 : null),
            new ConstRadixSystemAndDelegates(ConstRadixSystem_Object :
                                             RadixSystemArray[(int)RadixNumber_ENUM.DECIMAL_NUMBER],
                                             TextBox_Object : null,
                                             TextBox_Object_Name : "txtDecimalNumber",
                                             Label_Object_Name : "lblDecimalNumber",
                                             Label_Object_Text : "Decimaltal (10 tals system) : ",
                                             FunctionPointerToRadix10 : MainWindow.ConvertToRadix10IntFromRadix10String,
                                             FunctionPointerFromRadix10 : MainWindow.ConvertFromRadix10IntToRadix10String),
            new ConstRadixSystemAndDelegates(ConstRadixSystem_Object :
                                             RadixSystemArray[(int)RadixNumber_ENUM.HEXADECIMAL_NUMBER],
                                             TextBox_Object : null,
                                             TextBox_Object_Name : "txtHexadecimalNumber",
                                             Label_Object_Name : "lblHexadecimalNumber",
                                             Label_Object_Text : "Hexadecimalt tal (16 tals system) : ",
                                             FunctionPointerToRadix10 : null,
                                             FunctionPointerFromRadix10 : null),
            new ConstRadixSystemAndDelegates(ConstRadixSystem_Object :
                                             RadixSystemArray[(int)RadixNumber_ENUM.RADIX24_NUMBER],
                                             TextBox_Object : null,
                                             TextBox_Object_Name : "txtRadix24Number",
                                             Label_Object_Name : "lblRadixNumber",
                                             Label_Object_Text : "Radix 24 tal (24 tals system) : ",
                                             FunctionPointerToRadix10 : null,
                                             FunctionPointerFromRadix10 : null),
            new ConstRadixSystemAndDelegates(ConstRadixSystem_Object :
                                             RadixSystemArray[(int)RadixNumber_ENUM.RADIX32_NUMBER],
                                             TextBox_Object : null,
                                             TextBox_Object_Name : "txtRadix32Number",
                                             Label_Object_Name : "lblRadix32Number",
                                             Label_Object_Text : "Radix 32 tal (32 tals system) : ",
                                             FunctionPointerToRadix10 : null,
                                             FunctionPointerFromRadix10 : null)
        };

        public static readonly ConstRadixSystemAndDelegatesExtended[] RadixSystemDelegatesAndControlsExtendedArray =
        {
            new ConstRadixSystemAndDelegatesExtended(ConstRadixSystemAndDelegates_Object : RadixSystemDelegatesAndControlsArray[(int)RadixNumber_ENUM.BINARY_NUMBER],
                                                     RadixNumber_Object : new RadixNumber(RadixSystemDelegatesAndControlsArray[(int)RadixNumber_ENUM.BINARY_NUMBER])),
            new ConstRadixSystemAndDelegatesExtended(ConstRadixSystemAndDelegates_Object : RadixSystemDelegatesAndControlsArray[(int)RadixNumber_ENUM.OCTAL_NUMBER],
                                                     RadixNumber_Object : new RadixNumber(RadixSystemDelegatesAndControlsArray[(int)RadixNumber_ENUM.OCTAL_NUMBER])),
            new ConstRadixSystemAndDelegatesExtended(ConstRadixSystemAndDelegates_Object : RadixSystemDelegatesAndControlsArray[(int)RadixNumber_ENUM.DECIMAL_NUMBER],
                                                     RadixNumber_Object : new RadixNumber(RadixSystemDelegatesAndControlsArray[(int)RadixNumber_ENUM.DECIMAL_NUMBER])),
            new ConstRadixSystemAndDelegatesExtended(ConstRadixSystemAndDelegates_Object : RadixSystemDelegatesAndControlsArray[(int)RadixNumber_ENUM.HEXADECIMAL_NUMBER],
                                                     RadixNumber_Object : new RadixNumber(RadixSystemDelegatesAndControlsArray[(int)RadixNumber_ENUM.HEXADECIMAL_NUMBER])),
            new ConstRadixSystemAndDelegatesExtended(ConstRadixSystemAndDelegates_Object : RadixSystemDelegatesAndControlsArray[(int)RadixNumber_ENUM.RADIX24_NUMBER],
                                                     RadixNumber_Object : new RadixNumber(RadixSystemDelegatesAndControlsArray[(int)RadixNumber_ENUM.RADIX24_NUMBER])),
            new ConstRadixSystemAndDelegatesExtended(ConstRadixSystemAndDelegates_Object : RadixSystemDelegatesAndControlsArray[(int)RadixNumber_ENUM.RADIX32_NUMBER],
                                                     RadixNumber_Object : new RadixNumber(RadixSystemDelegatesAndControlsArray[(int)RadixNumber_ENUM.RADIX32_NUMBER]))
        };

        public static ConstRadixSystem FindRadixSystem(RadixNumber_ENUM RadixNumber)
        {
            int RadixSystemCounter = 0;

            do
            {
                if (RadixNumber == RadixSystemArray[RadixSystemCounter].RadixNumber)
                {
                    return (RadixSystemArray[RadixSystemCounter]);
                }
                else
                {
                    RadixSystemCounter++;
                }
            } while (RadixSystemCounter < RadixSystemArray.Length);

            return (null);
        }
        #endregion

        #region General_Stuff
        public const int NumberFormatError = -1;
        public const int RadixNumberNotFound = -1;
        #endregion

        #region Const_FirstOrderEquation
        public const string txtParametersFor1OrderLineString = "Her kommer karakteristika for den rette linje beskrevet ved de 2 punkter herover";
        #endregion

        #region Const_SecondOrderEquation
        public const string txtParametersForParabelString = "Her kommer karakteristika for parablen beskrevet ved de 3 punkter herover";
        public const string txtParametersForParabelByCoefficientsString = "Her kommer rødder og toppunkt for parablen beskrevet herover";
        #endregion

        #region Const_EquationSystem
        public const int Min_Order_Of_Equations = 2;
        public const int Max_Order_Of_Equations = 10;
        
        public const int Min_Number_Of_Decimals = 2;
        public const int Max_Number_Of_Decimals = 10;
        
        public const string EqutionSystemDirectory = "EquationSystem";
        public const string EquationSystemExtension = "equ";
        public const string EquationSystemSolvedString = "Løsning til Ligningssystem : ";
        public const string EquationSystemNotSolvedString = "Her kommer løsningen på ligningssystemet.";
        #endregion

        #region Const_PercentageCalculations
        public const string lblPercentageOfBaseAmountText = "x % af y er : ";

        public static void SetDefaultUpDownLabelContent(Label UpDownLabel)
        {
            UpDownLabel.Content = lblPercentageOfBaseAmountText;
        }
        #endregion

        #region Const_FractionCalculations
        public const string lblPlusFractionsDefaultText = "Addition af Brøker : ";
        public const string lblMinusFractionsDefaultText = "Subtraktion af Brøker : ";
        public const string lblMultiplyFractionsDefaultText = "Multiplikation af Brøker : ";
        public const string lblDivideFractionsDefaultText = "Division af Brøker : ";

        public static void SetDefaultFractionsLabelsContent(Label PlusLabel,
                                                            Label MinusLabel,
                                                            Label MultiPlyLabel,
                                                            Label DivideLabel)
        {
            PlusLabel.Content = lblPlusFractionsDefaultText;
            MinusLabel.Content = lblMinusFractionsDefaultText;
            MultiPlyLabel.Content = lblMultiplyFractionsDefaultText;
            DivideLabel.Content = lblDivideFractionsDefaultText;
        }
        #endregion

        #region Const_General_Code
        public static int DefaultNumberOfDecimals = 3;

        public static void SetDefaultNumberOfDecimals(int DefaultNumberOfDecimalsSet)
        {
            DefaultNumberOfDecimals = DefaultNumberOfDecimalsSet;
        }

        public static int GetDefaultNumberOfDecimals()
        {
            return (DefaultNumberOfDecimals);
        }
        #endregion
    }
}
