using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibMas;
using Lib_4;

namespace Практическая_работа__3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Заполнить
        private void button1_Click(object sender, EventArgs e)
        {
            //Используем функции для работы с таблицей
            Massiv.CleanMas(table);//Очищаем
            Massiv.CleanMas(resultTable);
            int randMin = Convert.ToInt32(min.Value);//получаем минимальное,
            int randMax = Convert.ToInt32(max.Value);//максимальное значение
            Massiv.InitMas(table, randMin, randMax);//Заполняем таблицу с помощью функции
        }
        //Новый
        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.ColumnCount = 5;//Столбцы
            table.RowCount = 5;//строки
            //Очищаем исходную таблицу
            for (int i = 0; i < table.ColumnCount; i++)
                for (int j = 0; j < table.RowCount; j++)
                {
                    table[i, j].Value = "";
                }
            resultTable.ColumnCount = 5;
            resultTable.RowCount = 1;
            //Очищаем таблицу с результатом
            for (int i = 0; i < resultTable.ColumnCount; i++)
                for (int j = 0; j < resultTable.RowCount; j++)
                {
                    resultTable[i, j].Value = "";
                }
        }
        //При загрузке формы устанавливаем размеры таблиц
        private void Form1_Load(object sender, EventArgs e)
        {
                table.ColumnCount = 5;
                table.RowCount = 5;
            resultTable.ColumnCount = 5;
            resultTable.RowCount = 1;
        }
        //Рассчитать
        private void button2_Click(object sender, EventArgs e)
        {
            Class1.Proizvedenie(table, resultTable);
        }
        //Очистить
        private void button3_Click(object sender, EventArgs e)
        {
            Massiv.CleanMas(table);//очищаем исх. таблицу
            Massiv.CleanMas(resultTable);//очищаем табл. с результатом
        }
        //Сохранить
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Massiv.SaveFile(table);//сохраняем таблицу в файл с помощью функции
        }
        //Открыть
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Massiv.OpenFile(table);//открываем файл с помощью функции
        }
        //изменение количества столбцов
        private void i1_ValueChanged(object sender, EventArgs e)
        {
            //устанавливаем новые значения количкества столбцов
            table.ColumnCount = Convert.ToInt32(i1.Value);
            resultTable.ColumnCount = Convert.ToInt32(i1.Value);
        }
        //изменение количества строк
        private void j1_ValueChanged(object sender, EventArgs e)
        {
            //устанавливаем новые значения количкества строк
            table.RowCount = Convert.ToInt32(j1.Value);
        }
        //О программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №3\n" +//выводим сообщение о программе
              "Монахов Андрей ИСП-31\n" +
              "Дана матрица размера M × N. Для каждого столбца матрицы найти произведение его элементов. ");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
