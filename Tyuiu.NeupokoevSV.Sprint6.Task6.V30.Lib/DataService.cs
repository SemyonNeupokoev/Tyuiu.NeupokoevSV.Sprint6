using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NeupokoevSV.Sprint6.Task6.V30.Lib
{
    public class DataService : ISprint6Task6V30
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";

            using (StreamReader reader = new StreamReader(path))
            { 
                string line;
                bool firstWord = true; // Флаг для первого слова (чтобы не ставить пробел перед ним)

                while ((line = reader.ReadLine()) != null)
                {
                    // Разбиваем строку на слова, удаляя пустые элементы
                    string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t',
                                                             '(', ')', '[', ']', '"', '-', '—' },
                                               StringSplitOptions.RemoveEmptyEntries);

                    // Проверяем, есть ли в строке хотя бы 4 слова
                    if (words.Length >= 4)
                    {
                        // Берем 4-е слово (индекс 3, так как индексация с 0)
                        string fourthWord = words[3];

                        // Добавляем к результату
                        if (!firstWord)
                        {
                            result += " ";
                        }
                        result += fourthWord;
                        firstWord = false;
                    }
                    // Если в строке меньше 4 слов, можно пропустить или обработать иначе
                    // Например, можно добавить пустую строку или ничего не делать
                }
            }

            return result;
        }
    }
}
