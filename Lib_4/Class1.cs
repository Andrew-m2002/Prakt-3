using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_4
{
    public class Class1
    {
        public static void Proizvedenie(DataGridView table, DataGridView resultTable)
        {
            int dop, i, j, x;
            for (i = 0; i < table.ColumnCount; i++)
            {
                x = 1;
                for (j = 0; j < table.RowCount; j++)
                {//если в ячейке есть число
                    if (Int32.TryParse(Convert.ToString(table[i, j].Value), out dop))
                    {

                        x = x * dop; //ищем произведение
                      
                    }
                    else//иначе выводим сообщение об ошибке
                    {
                        MessageBox.Show("Ошибка!");
                        return;
                    }
                }
                resultTable[i, 0].Value = x;//записываем произведение в таблицу с результатом
            }
        }
    }
}
