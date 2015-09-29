using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    public class Operation
    {
        private double _numA = 0;
        private double _numB = 0;

        public double NumA {
            get {
                return _numA;
            }
            set {
                _numA = value;
            }
        }

        public double NumB {
            get {
                return _numB;
            }
            set {
                _numB = value;
            }
        }

        public virtual double GetResult () {
            double result = 0;
            return result;
        }

    }

    class OperationAdd : Operation {
        public override double GetResult () {
            double result = 0;
            result = NumA + NumB;
            return result;
        }
    }

    class OperationSub : Operation {
        public override double GetResult () {
            double result = 0;
            result = NumA - NumB;
            return result;
        }
    }

    class OperationMul : Operation {
        public override double GetResult () {
            double result = 0;
            result = NumA * NumB;
            return result;
        }
    }

    class OperationDiv : Operation {
        public override double GetResult () {
            double result = 0;
            result = NumA / NumB;
            return result;
        }
    }

    class OperationSqrt : Operation {
        public override double GetResult () {
            double result = 0;
            if (NumB < 0)
                throw new Exception("负数不能开平方根");
            result = Math.Sqrt(NumB);
            return result;
        }
    }
    public class OperationFactory
    {
        public static Operation createOperate(string operate)
        {
            Operation oper = null;
            switch(operate)
            {
                case "+":
                    {
                        oper = new OperationAdd();
                        break;
                    }
                case "-":
                    {
                        oper = new OperationSub();
                        break;
                    }
                case "*":
                    {
                        oper = new OperationMul();
                        break;
                    }
                case "/":
                    {
                        oper = new OperationDiv();
                        break;
                    }
                case "sqrt":
                    {
                        oper = new OperationSqrt();
                        break;
                    }
            }
            return oper;
        }
    }
}
