1. Создать репозиторий на GitHub;

2. Нарисовать блок-смеху алгоритма;

3. Написать программу по ее решению.

`` Задача:

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

Примеры:

["hello", "2", "world", ":-)"]
["1234", "1567", "-2", "computer science"]
["Russia", "Denmark", "Kazan"] ``

Описание алгоритма решения задачи:

Инициализируем массив и объявляем второй массив такой же длины.

Инициализируем вспомогоательную переменную ind = 0, в которую запишем количество строк, длина которых меньше либо равна 3 символа.

Далее проходим по каждой строке массива. Внутри цикла проверяем условия (строка <=3 ), если ДА элемент первого массива вносится в элемент второго массива, если НЕТ возвращается к циклу. 

После присвоения увеличивается переменная ind на 1 и возвращается к циклу, в котором ind увеличивается на 1. И так проверяется до тех пор, пока все элементы массива не буду проверены.

Выводим результат.

ССылка на блок-схему https://app.diagrams.net/#G19KIFpoK3l5kToMh7Y0naSUDl4jZSt6-m