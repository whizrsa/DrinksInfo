using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using ConsoleTableExt;

namespace drinks_info
{
    public class TableVisualisationEngine
    {
        //list T is of generic type, meaning we can take in any type of list
        public static void ShowTable<T>(List<T> tableData,[AllowNull] string tableName) where T :
        class
        {
            Console.Clear();

            if(tableName == null)//prevents us into having null exceptions
                tableName = "";

            Console.WriteLine("\n\n");

            ConsoleTableBuilder
                .From(tableData)
                .WithColumn(tableName)
                .WithFormat(ConsoleTableBuilderFormat.Alternative)
                .ExportAndWriteLine(TableAligntment.Center);
            Console.WriteLine("\n\n");
        }
    }
}