class Window:
    def __init__(self, width, height):
        self.r = Rectangle(width, height)
        self.width = width
        self.height = height
    def area(self):
        return self.r.area()

class Rectangle:
    def __init__(self, width, height):
        self.width = width
        self.height = height
    def area(self):
        return self.width * self.height

w = Window(10, 20)
print(w.area())

