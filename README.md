# ⭐task⭐
---
#### Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
## 👀examples👀
#### [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
#### [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
#### [“Russia”, “Denmark”, “Kazan”] → []
# ✔️solve✔️
---
#### Объявим переменную(anscnt) для количества найденных строк длинной <4; и массивы для: 1) входных данных(lines). 2) найденных строк длинной <4(ans). 
#### Введём входные данные lines. 
#### Объявим цикл for который работает пока i меньше чем количество подстрок lines.length массива lines, в котором объявим условие if: если длинна i-той подстроки массива lines меньше чем 4, то найденная подстрока заносится в anscnt-ый элемент массива ans, добовляем к переменной anscnt +1.
#### Объявим цикл for который работает пока i меньше чем количество элементов массива ans, в котором выводится в консоль каждая найденная строка.
## 💻programm💻
#### Код алгоритма на языке с#: Program.cs
## 🎨block diagram🎨
#### Нарисованная блок схема алгоритма: block diagram.png