using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CrossApp
{
    public class AppViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region MainPage

        private List<AppModel> creditManagers;
        public List<AppModel> CreditManagers
        {
            get { return creditManagers; }
            set
            {
                creditManagers = value;
                OnPropertyChanged();
            }
        }

        public void Init()
        {
            creditManagers = new List<AppModel>();
            creditManagers.Add(new AppModel { ID = 1, Name = "秦惠王", Organization = "大秦帝国", PhoneNo = "13410108008", InterestRate = "10%", MaxAmount = "200", LoanTypes = "秦时明月汉时关", Distance = "西北" });
            creditManagers.Add(new AppModel { ID = 2, Name = "赵惠文王", Organization = "赵国", PhoneNo = "10086", InterestRate = "20%", MaxAmount = "100", LoanTypes = "赵氏孤儿", Distance = "中北" });
            creditManagers.Add(new AppModel { ID = 3, Name = "齐威王", Organization = "齐国", PhoneNo = "1008611", InterestRate = "25%", MaxAmount = "120", LoanTypes = "凡有地牧民者，务在四时，守在仓廪。", Distance = "东方" });
            creditManagers.Add(new AppModel { ID = 4, Name = "楚武王", Organization = "楚国", PhoneNo = "13813801380", InterestRate = "15%", MaxAmount = "300", LoanTypes = "楚庄王 一鸣惊人", Distance = "南方" });
            creditManagers.Add(new AppModel { ID = 5, Name = "燕昭王", Organization = "燕国", PhoneNo = "10000", InterestRate = "20%", MaxAmount = "150", LoanTypes = "风萧萧兮易水寒", Distance = "北方" });
            creditManagers.Add(new AppModel { ID = 6, Name = "韩襄王", Organization = "韩国", PhoneNo = "10010", InterestRate = "20%", MaxAmount = "30", LoanTypes = "", Distance = "中原" });
            creditManagers.Add(new AppModel { ID = 7, Name = "魏惠王", Organization = "魏国", PhoneNo = "1008611", InterestRate = "25%", MaxAmount = "50", LoanTypes = "魏国人商鞅变法", Distance = "中原" });
            creditManagers.Add(new AppModel { ID = 8, Name = "宋微子", Organization = "宋国", PhoneNo = "1008611", InterestRate = "25%", MaxAmount = "10", LoanTypes = "宋乃商汤之后", Distance = "中原" });
            creditManagers.Add(new AppModel { ID = 9, Name = "中山文公", Organization = "中山国", PhoneNo = "1008611", InterestRate = "20%", MaxAmount = "5", LoanTypes = "", Distance = "中原" });
            creditManagers.Add(new AppModel { ID = 9, Name = "鲁公伯禽", Organization = "鲁国", PhoneNo = "1008611", InterestRate = "20%", MaxAmount = "15", LoanTypes = "", Distance = "东方" });
        }

        #endregion

        #region DetailPage

        private double total;
        public double Total
        {
            set
            {
                if (total != value)
                {
                    total = value;
                    OnPropertyChanged();
                    Recalculate();
                }
            }
            get
            {
                return total;
            }
        }

        private double nums;
        public double Nums
        {
            set
            {
                if (nums != value)
                {
                    nums = value;
                    OnPropertyChanged();
                    Recalculate();
                }
            }
            get
            {
                return nums;
            }
        }

        private double percent;
        public double Percent
        {
            set
            {
                if (percent != value)
                {
                    percent = value;
                    OnPropertyChanged();
                    Recalculate();
                }
            }
            get
            {
                return percent;
            }
        }

        private double result;
        public double Result
        {
            set
            {
                if (result != value)
                {
                    result = value;
                    OnPropertyChanged();
                }
            }
            get
            {
                return result;
            }
        }
        

        void Recalculate()
        {
            //this.Total = Math.Round(4 * (this.PostTaxTotal + this.TipAmount)) / 4;
            Result = Total * (1 + Percent/100) / Nums;
        }

        #endregion
    }
}
