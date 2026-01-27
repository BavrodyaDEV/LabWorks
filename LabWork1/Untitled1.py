class tests: # Тестовый метод
    __x # значения (неизменяемые)
    __y
    __z
    
    def printer(text): # тестовая функция печатает передаваемое значение
        print(text)
    
    def setX(num): # сеттеры для 3-х неизменяемых значений
        this.__x = num
        print("Изменён X")
    def setY(num):
        this.__y = num
        print("Изменён Y")
    def setZ(num):
        this.__z = num
        print("Изменён Z")

class testsChild(tests): # Дочерний метод
    def __init__(x, y, z): # Конструктор сразу задающий значения
        this.setX(x)
        this.setY(y)
        this.setZ(z)
        print("Работа конструктора завершена")


