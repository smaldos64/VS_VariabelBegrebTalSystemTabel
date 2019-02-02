using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using VariabelBegreb.Tools;

namespace VariabelBegreb.NumberSystems
{
    public class RadixNumber : NumberSystem
    {
        public ConstRadixSystemAndDelegates ConstRadixSystemAndDelegates_Object { get; set; }

        public RadixNumber(ConstRadixSystemAndDelegates ConstRadixSystemAndDelegates_Object)
        {
            this.ConstRadixSystemAndDelegates_Object = ConstRadixSystemAndDelegates_Object;
        }

        public override bool IsKeyValid(Key ThisKey)
        {
            return (this.ConstRadixSystemAndDelegates_Object.ConstRadixSystem_Object.ValidKeysArray.Contains(ThisKey) ||
                    KeyHelper.IsKeyPressedValicControlKey(ThisKey));
            //return (this.ValidKeysArray.Contains(ThisKey) || KeyHelper.IsKeyPressedValicControlKey(ThisKey));
        }

        public override string ConvertFromRadix10(int Radix10Number)
        {
            string ReturnString = " ";

            if (null == this.ConstRadixSystemAndDelegates_Object.FunctionPointerFromRadix10)
            {
                ReturnString = base.ConvertFromRadix10(Radix10Number,
                    (int)this.ConstRadixSystemAndDelegates_Object.ConstRadixSystem_Object.RadixNumber,
                    this.ConstRadixSystemAndDelegates_Object.ConstRadixSystem_Object.RadixSpaceCounter,
                    this.ConstRadixSystemAndDelegates_Object.ConstRadixSystem_Object.RadixSpaceCharacter);
            }
            else
            {
                ReturnString = this.ConstRadixSystemAndDelegates_Object.FunctionPointerFromRadix10(Radix10Number);
            }

            //ConstRadixSystem ConstRadixSystem_Object = Const.FindRadixSystem(RadixNumber_ENUM.HEXADECIMAL_NUMBER);

            //if (null != ConstRadixSystem_Object)
            //{
            //    ReturnString = base.ConvertFromRadix10(Radix10Number, (int)RadixNumber_ENUM.HEXADECIMAL_NUMBER,
            //        ConstRadixSystem_Object.RadixSpaceCounter, ConstRadixSystem_Object.RadixSpaceCharacter);
            //}
            //else
            //{
            //    MessageBox.Show("Der er vist en SW bug her !!!");
            //}

            return (ReturnString);
        }

        public override int ConvertToRadix10(string RadixStringToConvert)
        {
            int Radix10Value = -1;

            if (null == this.ConstRadixSystemAndDelegates_Object.FunctionPointerToRadix10)
            {
                Radix10Value = base.ConvertToRadix10(RadixStringToConvert, 
                                                     this.ConstRadixSystemAndDelegates_Object.ConstRadixSystem_Object.RadixNumber);
            }
            else
            {
                Radix10Value = this.ConstRadixSystemAndDelegates_Object.FunctionPointerToRadix10(RadixStringToConvert);
            }

            return (Radix10Value);
        }
    }
}
