import os


def remove_file(filename):
    os.remove(filename)
    print("File removed....")




def main():
    filename = input("Enter the file_name: ")
    remove_file(filename)
if __name__ == "__main__":
    main()