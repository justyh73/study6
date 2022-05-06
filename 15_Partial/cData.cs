using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Partial
{

    public enum EnumItem
    {
        고기 = 10000,
        과자 = 3000,
        계란 = 5000,
        물 = 800,
        라면 = 3500,
        즉석식품 = 6500,
        냉동식품 = 8500,
    }

    public enum EnumRate
    {
        할인_3 = 3,
        할인_5 = 5,
        할인_10 = 10,
        할인_20 = 20,
        사장할인_80 = 80,
    }
    partial class cData
    {
        private double _dTotalPrice = 0.0;
        public double DTotalPrice
        {
            get => _dTotalPrice;
            set
            {
                _dTotalPrice = _dTotalPrice + value;
            }
        }

        private string _strItem = string.Empty;
        public string StrItem
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _strErrorName = "물건이 선택되지 않았습니다.";
                }
                else
                {
                    _strItem = value;
                }
            }
        }

        private int _iRate = 0;
        public int IRate
        {
            set
            {
                if (value > 20)
                {
                    _strErrorName = "사장님 할인";
                }
                else
                {
                    _iRate = value;
                }
            }
        }

        private int _iCount = 0;
        public int ICount
        {
            set
            {
                if (value > 5)
                {
                    _strErrorName = "개별 물품은 5개이상 살수 없습니다.";
                }else if (value == 0)
                {
                    _strErrorName = "물품의 개수가 0개 입니다.";
                }
                else
                {
                    _iCount = value;
                }
            }
        }

        private string _strErrorName = string.Empty;
        public string StrErrorName
        {
            get => _strErrorName;
        }
    }


    partial class cData
    {
        public double fItemPrice()
        {
            double dPrice = 0;

            int iItemPrice = 0;

            if (string.IsNullOrEmpty(_strErrorName))
            {
                iItemPrice = (int)Enum.Parse(typeof(EnumItem), _strItem);

                dPrice = iItemPrice - Math.Round((double)iItemPrice * (double)_iRate / 100, 2);            
            }

            return dPrice * _iCount;
        }
    }

    partial class cData
    {
        public string fResult(double dPrice)
        {
            if (_iRate == 0)
            {
                return string.Format("{0} x {1} : {2}원", _strItem, _iCount, dPrice);
            }
            else
            {
                return string.Format("{0} X {1} : {2}원 (할인율 : {3}%)", _strItem, _iCount, dPrice, _iRate);

            }
        }

        public void fDataResult()
        {
            _strErrorName = string.Empty;
            _strItem = string.Empty;
            _iRate = 0;
            _iCount = 0;
        }
    }
         
}
