from user import choose_mode
from dictionary import filling , poisk
# from for_find import poisk


def running():
    person,mode = choose_mode()
    if mode == "запись":
        filling(person)
    else:
        poisk(person)
   
