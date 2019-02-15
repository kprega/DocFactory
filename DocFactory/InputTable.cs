using ExcelDataReader;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace DocFactory
{
    public class InputTable
    {
        private object[][] _Table;

        public string[] Tags
        {
            get
            {
                return this.GetRows()[0].Cast<string>().ToArray();
            }
            private set
            {
                this.Tags = value;
            }
        }

        public InputTable(string filepath)
        {
            using (var stream = File.Open(filepath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var counter = 0;
                    _Table = new object[reader.RowCount][];
                    while (reader.Read())
                    {
                        _Table[counter] = new object[reader.FieldCount];
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            _Table[counter][i] = reader.GetValue(i);
                        }
                        counter++;
                    }
                }
            }

            this.Tags = _Table[0].Cast<string>().ToArray();
        }

        public bool IsRowDataComplete(object[] row)
        {
            return row.All(n => n != null);
        }

        public List<object[]> GetRows()
        {
            return _Table.ToList();
        }
    }
}
