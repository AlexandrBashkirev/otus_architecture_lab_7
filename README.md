# otus_architecture_lab_7


IIterable<T> - интерфейс итератора. Для итерирования по числам фибоначи его реализует класс FibonachiIteratorBase от которого наследуються итераторы для итерирования в прямом и обратном порядке FibonachiIteratorUp, FibonachiIteratorDown 

IFibonachiIteratorMaker представляет собой абстрактную фабрику. конкретные фабрики FibonachiIteratorUpMaker, FibonachiIteratorDownMaker реализуют данный интерфейс.

![alt text](https://github.com/AlexandrBashkirev/otus_architecture_lab_7/blob/master/class_diagram.png?raw=true)
