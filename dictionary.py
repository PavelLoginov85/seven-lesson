
def filling(person):
    with open ('numbers.txt' , 'a' , encoding='utf-8') as numbers:
        for el in person:
            numbers.write(el + "\n")
        numbers.write("\n")

def poisk(telo):
     with open ('numbers.txt' , 'r' , encoding='utf-8') as numbers:
          while True:
               line = numbers.readline()
               if not line:
                    break
               if line[:-1] == telo:
                    print(line[:-1])
                    print(numbers.readline()[:-1])
                    print(numbers.readline()[:-1])
                    print(numbers.readline()[:-1])
                    print()      

        
                

     