Элементы строкового массива вводятся пользователем с клавиатуры, размер массива заранее не определен.
Вводим переменную count = 0 для подсчета элементов массива с числом символов от 3 и менее.
Организуем цикл для прохода по каждому элементу массива с помощью счетика цикла i. Для каждого элемента проверяем выполнение условия: если количество символов в элементе 3 и менее, то count увеличиваем на единицу. Одновременно, после проверки каждого элемента, независимо от результата проверки, увелиивается на единицу счетик цикла i. Таким образом, к концу выполнения цикла в переменной count получаем количество элементов массива с числом символов 3 и менее.
Инициализируем новый строковый массив размером, равным count.
Вводим переменную j, которая будет использоваться для нумерации элементов созданного в п.4 нового массива.
Организуем цикл для прохода по каждому элементу заданного массива с помощью счетика цикла i. Для каждого элемента проверяем выполнение условия: если количество символов в элементе 3 и менее, то этот элемент отправляем в новый массив, после чего j увеличиваем на единицу. Одновременно, после проверки каждого элемента, независимо от результата проверки, увелиивается на единицу счетик цикла i. Таким образом, к концу выполнения цикла получаем массив, заполненный  элементами заданного массива с числом символов 3 и менее, в соответствии с условиями задачи.
Выводим результат (новый массив) на консоль.