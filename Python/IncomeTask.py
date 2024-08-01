class Salary:
    def __init__(self,bsal):
        self.bsal=bsal
    def getsalary(self):
        return self.bsal
class Allowance(Salary):
    def __init__(self):
          self.HRA=0.20 * basesal
          self.DA=0.40 * basesal
          self.TA=0.25 * basesal
    def getallowance(self):
        #   print("HRA = ",self.HRA)
        #   print("DA = ",self.DA)
        #   print("TA = ",self.TA)        
         return self.HRA+self.DA+self.TA
    
class Deduction(Salary):
     def __init__(self, bsal):
          super().__init__(bsal)
          self.insurance=5000
          self.pf=0.12 * bsal
          self.gratuity=0.05 * bsal
     def getdeduction(self):
          return self.insurance+self.pf+self.gratuity
     
class CalculateSalarySlip(Allowance,Deduction):
     
     def __init__(self,basesal):
          self.base_salary=basesal
          Allowance.__init__(self,basesal)
          Deduction.__init__(self,basesal)
          self.grosssalary=self.base_salary+self.getallowance()
          self.netsalary=self.base_salary+self.getallowance()-self.getdeduction()
     def getsalaryslip(self):
          print("Basic Salary =",self.getsalary())
          print("Allowance = ",self.getallowance())
          print("Deduction = ",self.getdeduction())
          print("Gross Salary =",self.grosssalary)
          print("Net Salary = ",self.netsalary)

# bsal=Salary(10000)
# a=Allowance(bsal.getsalary())
# allowance=a.getallowance()
# d=Deduction(bsal.getsalary())
# deduction=d.getdeduction()
def main():
 css=CalculateSalarySlip(10000)
 css.getsalaryslip()

if __name__=="__main__":
  main()