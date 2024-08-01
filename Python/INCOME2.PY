class Salary:
    def __init__(self, bsal):
        self.bsal = bsal
    
    def getsalary(self):
        return self.bsal

class Allowance(Salary):
    HRA_rate = 0.20
    DA_rate = 0.40
    TA_rate = 0.25

    def calculate_allowance(self):
        self.HRA = self.HRA_rate * self.bsal
        self.DA = self.DA_rate * self.bsal
        self.TA = self.TA_rate * self.bsal

    def getallowance(self):
        self.calculate_allowance() 
        return self.HRA + self.DA + self.TA

class Deduction(Salary):
    insurance = 5000
    pf_rate = 0.12
    gratuity_rate = 0.05

    def calculate_deduction(self):
        self.pf = self.pf_rate * self.bsal
        self.gratuity = self.gratuity_rate * self.bsal

    def getdeduction(self):
        self.calculate_deduction()  
        return self.insurance + self.pf + self.gratuity

class CalculateSalarySlip(Allowance, Deduction):
    def __init__(self, bsal):
        Salary.__init__(self, bsal)
        self.grosssalary = self.bsal + self.getallowance()
        self.netsalary = self.bsal + self.getallowance() - self.getdeduction()

    def getsalaryslip(self):
        print("Basic Salary =", self.getsalary())
        print("Allowance =", self.getallowance())
        print("Deduction =", self.getdeduction())
        print("Gross Salary =", self.grosssalary)
        print("Net Salary =", self.netsalary)

def main():
    css = CalculateSalarySlip(10000)
    css.getsalaryslip()

if __name__ == "__main__":
    main()
