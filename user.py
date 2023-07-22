def choose_mode():
   mode = input("Выбирите режим. Запись или Поиск: ")
   if mode == "запись":
      person = fill_person()
   elif mode == "поиск":
      person = poisk()
   else:
        print("Такого режима нет")
        choose_mode()
   return person, mode


def fill_person():
    surname = input ("Введите фамилию ")
    name = input ("Введите имя ")
    father = input ("Введите отчество ")
    number = input ("Номер телефона ")
    return surname, name,father,number

def poisk():
     telo = input ("Введите фамилию поиска:  ")
     return telo


    







    
   
