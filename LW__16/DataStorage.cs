using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace LW__16
{
    class DataStorage : DataInterface
    {
        public bool IsReady
        {
            get
            {
                if (rawdata == null) return false;
                else return true;
            }
        }

        private List<RawDataItem> rawdata;
        private List<SummaryDataItem> sumdata;
        private char devider = '%';
        public DataStorage() { }

        private void BuildSummary()
        {
            Dictionary<int, float> tmp = new Dictionary<int, float>();
            foreach (var item in rawdata)
            {
                int group = -1;
                if (item.Group == "Продукты") group = 0;
                if (item.Group == "Химия") group = 1;

                if (group == 0)
                {
                    if (tmp.ContainsKey(0))
                        tmp[0] += item.PurchPrice;
                    else
                        tmp[0] = item.PurchPrice;

                    if (tmp.ContainsKey(1))
                    {
                        if (item.SellPrice > tmp[1])
                            tmp[1] = item.SellPrice;
                    }
                    else
                        tmp[1] = item.SellPrice;
                }

                if (group == 1)
                {
                    if (tmp.ContainsKey(2))
                        tmp[2] += item.PurchPrice;
                    else
                        tmp[2] = item.PurchPrice;

                    if (tmp.ContainsKey(3))
                    {
                        if (item.SellPrice > tmp[3])
                            tmp[3] = item.SellPrice;
                    }
                    else
                        tmp[3] = item.SellPrice;
                }
            }

            sumdata = new List<SummaryDataItem>();
            foreach (var item in tmp)
            {
                sumdata.Add(new SummaryDataItem()
                {
                    Task = Utils.GetGroupByNumber(item.Key),
                    Result = item.Value
                });
            }
        }

        private bool InitData(String datapath)
        {
            rawdata = new List<RawDataItem>();

            try
            {
                StreamReader sr = new StreamReader(datapath);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] items = line.Split(devider);
                    var item = new RawDataItem()
                    {
                        Product = items[0].Trim(),
                        Group = items[1].Trim(),
                        PurchPrice = Convert.ToSingle(items[2].Trim(), CultureInfo.InvariantCulture),
                        SellPrice = Convert.ToSingle(items[3].Trim(), CultureInfo.InvariantCulture)
                    };
                    rawdata.Add(item);
                }
                sr.Close();
                BuildSummary();
            }
            catch (IOException ex)
            {
                return false;
            }
            return true;
        }

        public static DataStorage DataCreator(String path)
        {
            DataStorage d = new DataStorage();
            if (d.InitData(path))
                return d;
            else
                return null;
        }

        public List<RawDataItem> GetRawData()
        {
            if (this.IsReady)
                return rawdata;
            else
                return null;
        }

        public List<SummaryDataItem> GetSummaryData()
        {
            if (this.IsReady)
                return sumdata;
            else
                return null;
        }
    }
}
