using Courier.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier.Model
{
    public class CargoOrder

    {
        public static int count = 0;
        public  int Id;
        public int CustomerId;
        public int CourierId;
        public int TotalPrice;
        public OrderStatus orderStatus;
        //        Id(statik olaraq artacaq şəkildə olmalıdır)
        //CustomerId(Sifarişin hansı müştəriyə getdiyi)
        //CourierId(Hansı kuryer tərəfindən çatdırıldığı)
        //Ümumi məbləğ
        //OrderStatus(enum-dır, 2-ci tapşırıqda ətraflı verilib) (default dəyəri Created olmalıdır)
        //CreatedAt(nə vaxt yarandığı, default olaraq indiki vaxtı göstərsin)
    }
}
