using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinansistWF
{
    abstract class DictionaryOfWords
    {
        public const string columnNameWallet = "Кошелек";
        public const string columnNameData = "Дата";
        public const string columnNamePorpuse = "Назначение платежа";
        public const string columnNameCounterparty = "Контрагент";
        public const string columnNameSum = "Сумма";
        public const string columnNameArticle = "Статья";
        public const string columnNameKeyCounterparty = "Ключ-контрагент";
        public const string columnNameKeyDescription = "Ключ-описание";
        public const string columnNameNumberOfContract = "Ключ-номер договора";
        public const string columnNameArticleName = "Наименование статьи";
    }
}
