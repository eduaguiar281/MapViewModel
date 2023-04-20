using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorAdapter
{
    public class ConsoleWriter : TextWriter
    {
        private RichTextBox _output;

        public ConsoleWriter(RichTextBox output)
        {
            _output = output;
        }

        public override void Write(char value)
        {
            base.Write(value);
            _output.AppendText(value.ToString());
        }

        public override Encoding Encoding
        {
            get { return Encoding.ASCII; }
        }
    }
}
