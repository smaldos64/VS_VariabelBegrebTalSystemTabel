using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;

namespace VariabelBegreb.Tools
{
    public class ControlTools
    {
        public static void SetComboBoxSelectedItem(ComboBox ThisComboBox, int SelectedValue)
        {
            int ComboBoxItemsCounter = 0;
            bool ComboBoxSelectedItemFound = false;

            do
            {
                if ((int)ThisComboBox.Items[ComboBoxItemsCounter] == SelectedValue)
                {
                    ComboBoxSelectedItemFound = true;
                }
                else
                {
                    ComboBoxItemsCounter++;
                }
            } while ((ComboBoxItemsCounter < ThisComboBox.Items.Count) && (false == ComboBoxSelectedItemFound));

            ThisComboBox.SelectedItem = ThisComboBox.Items.GetItemAt(ComboBoxItemsCounter);
        }

        public static int CheckTextBoxesForInformation(List<TextBox> TextBoxes)
        {
            int Counter;
            int NumberOfTextBoxesWithInfo = 0;

            for (Counter = 0; Counter < TextBoxes.Count; Counter++)
            {
                if (TextBoxes[Counter].Text.Length > 0)
                {
                    NumberOfTextBoxesWithInfo++;
                }
            }

            return (NumberOfTextBoxesWithInfo);
        }

        public static void ClearTextBoxes(List<TextBox> TextBoxes)
        {
            int Counter;

            for (Counter = 0; Counter < TextBoxes.Count; Counter++)
            {
                TextBoxes[Counter].Text = "";
            }
        }

        public static List<string> GetAllLinesInTextBlock(TextBlock ThisTextBlock)
        {
            List<string> LinesInTextBlock = new List<string>();
            string TextBloxkText;
            string SubString;
            int NewLinePosition = -1;

            TextBloxkText = ((System.Windows.Documents.Run)ThisTextBlock.Inlines.FirstInline).Text;
            TextBloxkText.Trim();

            do
            {
                NewLinePosition = TextBloxkText.IndexOf('\n');
                if (NewLinePosition > 0)
                {
                    SubString = TextBloxkText.Substring(0, NewLinePosition - 1);
                    LinesInTextBlock.Add(SubString);
                    TextBloxkText = TextBloxkText.Substring(NewLinePosition + 1);
                }
                else
                {
                    if (0 == NewLinePosition)
                    {
                        TextBloxkText = TextBloxkText.Substring(1);
                    }
                }
            } while (NewLinePosition >= 0);

            LinesInTextBlock.Add(TextBloxkText);

            return (LinesInTextBlock);
        }

        public static void InsertLabelInGrid(Grid Grid_Object, string LabelName, string LabelText,
                                             int RowPosition, int ColumnPosition, int ColumnSpan)
        {
            Label Label_Object = new Label();

            Label_Object.Name = LabelName;
            Label_Object.Content = LabelText;
            Label_Object.SetValue(Grid.ColumnSpanProperty, ColumnSpan);

            Grid_Object.Children.Add(Label_Object);
            Grid.SetColumn(Label_Object, ColumnPosition);
            Grid.SetRow(Label_Object, RowPosition);
        }
    }
}
