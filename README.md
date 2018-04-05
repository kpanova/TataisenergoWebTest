# WebEncryptor

Web-приложение для шифрование сообщений.

# База данных

База данных создается при первом запуске приложения с использованием подхода Code First в Entity Framework.

Таблица шифрование заполняется с помощью сдвига символов на N.
Используется N=10:

![Пример базы данных](https://i.imgur.com/FNI1mny.png)

# Серверная часть

Серверная часть осуществляет кодирование символов в соответствии с таблицей шифрования из базы данных.

Пример сообщения:
> Ваше сообщение теперь зашифровано.

Получим:
> Мквп ышшлгпчтп ьпщпъж сквтюъшмкчш.

Старое сообщение сохраняется в базу данных:

![Старое сообщение](https://i.imgur.com/It2ROBj.png)

# Клиентская часть

Клиентская часть сделана с использование фреймворка Bootstrap.

Вид страницы:

![Клиентская часть 1](https://i.imgur.com/X6HGUlm.png)

После ввода сообщения и нажатия кнопки отправить отправляется POST-запрос с содержимым поля ввода.

После обработки POST-запроса зашифрованное сообщение добавляется в ```textarea``` защищенное от записи.

![Клиентская часть - зашифрованное сообщение](https://i.imgur.com/laGKZSe.png)
