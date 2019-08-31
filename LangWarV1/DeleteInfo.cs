using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangWarV1
{
    public class DeleteInfo
    {
        public string TableName { get; }
        public DeleteInfo(string tableName)
        {
            TableName = tableName;
        }
    }
}
