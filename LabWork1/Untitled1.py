class tests: # Тестовый метод
    __x = 0 # значения (неизменяемые извне)
    __y = 0
    __z = 0
    
    def printer(text): # тестовая функция печатает передаваемое значение
        print(text)
    
    def setX(num): # сеттеры для 3-х неизменяемых значений
        self.__x = num
        print("Изменён X")
    def setY(num):
        self.__y = num
        print("Изменён Y")
    def setZ(num):
        self.__z = num
        print("Изменён Z")

    def printVars():
        print(self.__x, self.__y, self.__z)

class testsChild(tests): # Дочерний класс
    def __init__(x, y, z): # Конструктор сразу задающий значения
        self.setX(x)
        self.setY(y)
        self.setZ(z)
        print("Работа конструктора завершена")


