using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    public interface Operation
    {
        double NumA { get; set; }
        double NumB { get; set; }
        double GetResult();
    }

    class OperationAdd : Operation {
        private double _numA = 0;
        private double _numB = 0;

        public double NumA
        {
            get
            {
                return _numA;
            }
            set
            {
                _numA = value;
            }
        }

        public double NumB
        {
            get
            {
                return _numB;
            }
            set
            {
                _numB = value;
            }
        }
        public double GetResult () {
            double result = 0;
            result = NumA + NumB;
            return result;
        }
    }

    class OperationSub : Operation {
        private double _numA = 0;
        private double _numB = 0;

        public double NumA
        {
            get
            {
                return _numA;
            }
            set
            {
                _numA = value;
            }
        }

        public double NumB
        {
            get
            {
                return _numB;
            }
            set
            {
                _numB = value;
            }
        }
        public double GetResult () {
            double result = 0;
            result = NumA - NumB;
            return result;
        }
    }

    class OperationMul : Operation {
        private double _numA = 0;
        private double _numB = 0;

        public double NumA
        {
            get
            {
                return _numA;
            }
            set
            {
                _numA = value;
            }
        }

        public double NumB
        {
            get
            {
                return _numB;
            }
            set
            {
                _numB = value;
            }
        }
        public double GetResult () {
            double result = 0;
            result = NumA * NumB;
            return result;
        }
    }

    class OperationDiv : Operation {
        private double _numA = 0;
        private double _numB = 0;

        public double NumA
        {
            get
            {
                return _numA;
            }
            set
            {
                _numA = value;
            }
        }

        public double NumB
        {
            get
            {
                return _numB;
            }
            set
            {
                _numB = value;
            }
        }
        public double GetResult () {
            double result = 0;
            result = NumA / NumB;
            return result;
        }
    }

    class OperationSqrt : Operation {
        private double _numA = 0;
        private double _numB = 0;

        public double NumA
        {
            get
            {
                return _numA;
            }
            set
            {
                _numA = value;
            }
        }

        public double NumB
        {
            get
            {
                return _numB;
            }
            set
            {
                _numB = value;
            }
        }
        public double GetResult () {
            double result = 0;
            if (NumB < 0)
                throw new Exception("负数不能开平方根");
            result = Math.Sqrt(NumB);
            return result;
        }
    }

    interface OperationFactory {
        Operation createOperation();
    }

    public class OperationAddFactory : OperationFactory {
        public Operation createOperation() {
            return new OperationAdd();
        }
    }

    public class OperationSubFactory : OperationFactory {
        public Operation createOperation() {
            return new OperationSub();
        }
    }

    public class OperationMulFactory : OperationFactory {
        public Operation createOperation() {
            return new OperationMul();
        }
    }

    public class OperationDivFactory : OperationFactory {
        public Operation createOperation() {
            return new OperationDiv();
        }
    }

    public class OperationSqrtFactory : OperationFactory {
        public Operation createOperation() {
            return new OperationSqrt();
        }
    }

}
