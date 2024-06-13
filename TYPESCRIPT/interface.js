var Students = /** @class */ (function () {
    function Students(p, c, m) {
        this.che = c;
        this.math = m;
        this.phy = p;
    }
    Students.prototype.totalmarks = function () {
        return this.total = this.che + this.phy + this.math;
    };
    Students.prototype.percentage = function () {
        return (this.total / 300) * 100;
    };
    Students.prototype.StudentsResult = function () {
        console.log("Physics:".concat(this.phy, " Chemistry:").concat(this.che, " Math:").concat(this.math, " Total:").concat(this.totalmarks(), ",percentage:").concat(this.percentage()));
    };
    return Students;
}());
var stdObj = new Students(99, 55, 66);
stdObj.StudentsResult();
