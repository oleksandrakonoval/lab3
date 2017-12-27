using SimCorp.IMS.MobilePhoneLibrary.General;
using System;
using System.Windows.Forms;

namespace SimCorp.IMS.MobilePhoneLibrary.General {
    public class WFAOutput : IOutput {
        private TextBox myTextBox=new TextBox();
        private RichTextBox richTextBox;

        public string Output {
            get {
                throw new NotImplementedException();
            }
        }

        public void Write(string text) {
            myTextBox.AppendText(text);
        }

        public void WriteLine(string text) {
            myTextBox.AppendText(text);
            myTextBox.AppendText(Environment.NewLine);
        }

        public WFAOutput(TextBox textBox) {
            this.myTextBox = textBox;
        }

        public WFAOutput(RichTextBox richTextBox) {
            this.richTextBox = richTextBox;
        }
    }
}
