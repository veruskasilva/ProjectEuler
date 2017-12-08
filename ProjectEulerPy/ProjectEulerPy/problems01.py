class Problems01():

    def problem1(self):
        soma = 0
        for x in range(0,1000):
            if (x % 3 == 0) or (x % 5 == 0):
                soma += x
        print(soma)

