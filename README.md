**Условие итоговой задачи**
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

**Описание решения**

1. Создать новый репозиторий на GitHub, сопоставить его с созданной папкой на ПК.
2. Спроектировать блок-схему алгоритма программы в draw.io, скрин блок-схемы сохранить в папке с кодом.
3. Создать описание решения в файле README.md.
4. Алгоритм работы программы:

    4.1 программа просит пользователя ввести данные через запятую и пробел и сохраняет их в переменной типа string;

    4.2 программа просит пользователя ввести искомую длину строки сохраняет значение в переменную типа int;

    4.3 создаем строчный массив, формируемый из введенной в п.4.1 строки по разделителю ", ";
    
    4.4 метод CountArray осуществляет подсчет элементов заданной пользователем в п.4.2 длины. Принимает массив строк, возвращает целое число;

    4.5 метод ReduceArray принимает строковый массив, осуществляет просмотр элементов введенных данных и записывает элементы, удовлетворяющие условию, в новый массив. Возвращает новый строковый массив;

    4.6 вывод строкового массива на печать.