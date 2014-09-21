using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Collections;
using System.Windows.Forms;
namespace 类库
{
    public class ProductInfo
    {
        const string IP = "59.66.135.77";//默认的服务器IP
        public static string connstring = String.Format("Data Source={0};Initial Catalog=ProductManagement;User ID=Rhodes;Password=123456", IP);//默认的连接字符串
        protected string firstclass = "";
        protected string secondclass = "";
        protected string id = "";
        protected string name = "";
        protected string state = "";
        protected string inprice = "";
        protected string outprice = "";
        protected string reason = "";
        protected string season = "";
        protected string num = "";
        protected string account = "";
        protected string date = "";
        protected string manufacturers = "";
        public ProductInfo() { }
        public ProductInfo(string _firstclass, string _secondclass, string _id, string _name, string _state, string _inprice, string _outprice, string _reason, string _season, string _num, string _account, string _date, string _manufacturers)
        {
            firstclass = _firstclass;
            secondclass = _secondclass;
            id = _id;
            name = _name;
            state = _state;
            inprice = _inprice;
            outprice = _outprice;
            reason = _reason;
            season = _season;
            num = _num;
            account = _account;
            date = _date;
            manufacturers = _manufacturers;
        }
    };
    public class ElectricalEquipment : ProductInfo
    {
        protected string guaranteeperiod = "";
    };
    public class GeneralMerchandise : ProductInfo
    {
        protected string targetcustomer = "";
    };
    public class Food : ProductInfo
    {
        protected string expirationdate = "";
    };
    public class Book : ProductInfo
    {
        protected string writer = "";
    }
    public class Computer : ElectricalEquipment
    {
        private string cpurank = "";
        private string memory = "";
        public void set(string _firstclass, string _secondclass, string _id, string _name, string _state, string _inprice, string _outprice, string _reason, string _season, string _num, string _account, string _date, string _manufacturers, string _guaranteeperiod, string _cpurank, string _memory)
        {
            firstclass = _firstclass;
            secondclass = _secondclass;
            id = _id;
            name = _name;
            state = _state;
            inprice = _inprice;
            outprice = _outprice;
            reason = _reason;
            season = _season;
            num = _num;
            account = _account;
            date = _date;
            manufacturers = _manufacturers;
            guaranteeperiod = _guaranteeperiod;
            cpurank = _cpurank;
            memory = _memory;
        }
        public void upload()
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            String InsertNewComm = string.Format("INSERT INTO productinfo(firstclass,secondclass,id,name,state,inprice,outprice,season,reason,num,account,date,manufacturers,firstclassfeature,secondclassfeature1,secondclassfeature2) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", firstclass, secondclass, id, name, state, inprice, outprice, season, reason, num, account, date, manufacturers, guaranteeperiod, cpurank, memory);
            SqlCommand Upload = new SqlCommand(InsertNewComm, sqlconn1);
            try
            {
                sqlconn1.Open();
                if (Upload.ExecuteNonQuery() == 1)
                {
                    Message1 msg = new Message1("");
                    msg.setmessage("上传信息成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "写入商品信息错误");
            }
        }
    };
    public class CellPhone : ElectricalEquipment
    {
        private string camerapixel = "";
        private string batteryvolume = "";
        public void set(string _firstclass, string _secondclass, string _id, string _name, string _state, string _inprice, string _outprice, string _reason, string _season, string _num, string _account, string _date, string _manufacturers, string _guaranteeperiod, string _camerapixel, string _batteryvolume)
        {
            firstclass = _firstclass;
            secondclass = _secondclass;
            id = _id;
            name = _name;
            state = _state;
            inprice = _inprice;
            outprice = _outprice;
            reason = _reason;
            season = _season;
            num = _num;
            account = _account;
            date = _date;
            manufacturers = _manufacturers;
            guaranteeperiod = _guaranteeperiod;
            camerapixel = _camerapixel;
            batteryvolume = _batteryvolume;
        }
        public void upload()
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            String InsertNewComm = string.Format("INSERT INTO productinfo(firstclass,secondclass,id,name,state,inprice,outprice,season,reason,num,account,date,manufacturers,firstclassfeature,secondclassfeature1,secondclassfeature2) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", firstclass, secondclass, id, name, state, inprice, outprice, season, reason, num, account, date, manufacturers, guaranteeperiod, camerapixel, batteryvolume);
            SqlCommand Upload = new SqlCommand(InsertNewComm, sqlconn1);
            try
            {
                sqlconn1.Open();
                if (Upload.ExecuteNonQuery() == 1)
                {
                    Message1 msg = new Message1("");
                    msg.setmessage("上传信息成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "写入商品信息错误");
            }
        }
    };
    public class HomeUseElectricalEquipment : ElectricalEquipment
    {
        private string power = "";
        private string color = "";
        public void set(string _firstclass, string _secondclass, string _id, string _name, string _state, string _inprice, string _outprice, string _reason, string _season, string _num, string _account, string _date, string _manufacturers, string _guaranteeperiod, string _power, string _color)
        {
            firstclass = _firstclass;
            secondclass = _secondclass;
            id = _id;
            name = _name;
            state = _state;
            inprice = _inprice;
            outprice = _outprice;
            reason = _reason;
            season = _season;
            num = _num;
            account = _account;
            date = _date;
            manufacturers = _manufacturers;
            guaranteeperiod = _guaranteeperiod;
            power = _power;
            color = _color;
        }
        public void upload()
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            String InsertNewComm = string.Format("INSERT INTO productinfo(firstclass,secondclass,id,name,state,inprice,outprice,season,reason,num,account,date,manufacturers,firstclassfeature,secondclassfeature1,secondclassfeature2) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", firstclass, secondclass, id, name, state, inprice, outprice, season, reason, num, account, date, manufacturers, guaranteeperiod, power, color);
            SqlCommand Upload = new SqlCommand(InsertNewComm, sqlconn1);
            try
            {
                sqlconn1.Open();
                if (Upload.ExecuteNonQuery() == 1)
                {
                    Message1 msg = new Message1("");
                    msg.setmessage("上传信息成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "写入商品信息错误");
            }
        }
    };
    public class DailyUseProduct : GeneralMerchandise
    {
        string function = "";
        string color = "";
        public void set(string _firstclass, string _secondclass, string _id, string _name, string _state, string _inprice, string _outprice, string _reason, string _season, string _num, string _account, string _date, string _manufacturers, string _targetcumstomer, string _function, string _color)
        {
            firstclass = _firstclass;
            secondclass = _secondclass;
            id = _id;
            name = _name;
            state = _state;
            inprice = _inprice;
            outprice = _outprice;
            reason = _reason;
            season = _season;
            num = _num;
            account = _account;
            date = _date;
            manufacturers = _manufacturers;
            targetcustomer = _targetcumstomer;
            function = _function;
            color = _color;
        }
        public void upload()
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            String InsertNewComm = string.Format("INSERT INTO productinfo(firstclass,secondclass,id,name,state,inprice,outprice,season,reason,num,account,date,manufacturers,firstclassfeature,secondclassfeature1,secondclassfeature2) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", firstclass, secondclass, id, name, state, inprice, outprice, season, reason, num, account, date, manufacturers, targetcustomer, function, color);
            SqlCommand Upload = new SqlCommand(InsertNewComm, sqlconn1);
            try
            {
                sqlconn1.Open();
                if (Upload.ExecuteNonQuery() == 1)
                {
                    Message1 msg = new Message1("");
                    msg.setmessage("上传信息成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "写入商品信息错误");
            }
        }
    };
    public class Toy : GeneralMerchandise
    {
        string aimingage = "";
        string material = "";
        public void set(string _firstclass, string _secondclass, string _id, string _name, string _state, string _inprice, string _outprice, string _reason, string _season, string _num, string _account, string _date, string _manufacturers, string _targetcumstomer, string _aimingage, string _material)
        {
            firstclass = _firstclass;
            secondclass = _secondclass;
            id = _id;
            name = _name;
            state = _state;
            inprice = _inprice;
            outprice = _outprice;
            reason = _reason;
            season = _season;
            num = _num;
            account = _account;
            date = _date;
            manufacturers = _manufacturers;
            targetcustomer = _targetcumstomer;
            aimingage = _aimingage;
            material = _material;
        }
        public void upload()
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            String InsertNewComm = string.Format("INSERT INTO productinfo(firstclass,secondclass,id,name,state,inprice,outprice,season,reason,num,account,date,manufacturers,firstclassfeature,secondclassfeature1,secondclassfeature2) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", firstclass, secondclass, id, name, state, inprice, outprice, season, reason, num, account, date, manufacturers, targetcustomer, aimingage, material);
            SqlCommand Upload = new SqlCommand(InsertNewComm, sqlconn1);
            try
            {
                sqlconn1.Open();
                if (Upload.ExecuteNonQuery() == 1)
                {
                    Message1 msg = new Message1("");
                    msg.setmessage("上传信息成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "写入商品信息错误");
            }
        }
    };
    public class Sports : GeneralMerchandise
    {
        string sportsevent = "";
        string professional = "";
        public void set(string _firstclass, string _secondclass, string _id, string _name, string _state, string _inprice, string _outprice, string _reason, string _season, string _num, string _account, string _date, string _manufacturers, string _targetcumstomer, string _sportsevent, string _professional)
        {
            firstclass = _firstclass;
            secondclass = _secondclass;
            id = _id;
            name = _name;
            state = _state;
            inprice = _inprice;
            outprice = _outprice;
            reason = _reason;
            season = _season;
            num = _num;
            account = _account;
            date = _date;
            manufacturers = _manufacturers;
            targetcustomer = _targetcumstomer;
            sportsevent = _sportsevent;
            professional = _professional;
        }
        public void upload()
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            String InsertNewComm = string.Format("INSERT INTO productinfo(firstclass,secondclass,id,name,state,inprice,outprice,season,reason,num,account,date,manufacturers,firstclassfeature,secondclassfeature1,secondclassfeature2) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", firstclass, secondclass, id, name, state, inprice, outprice, season, reason, num, account, date, manufacturers, targetcustomer, sportsevent, professional);
            SqlCommand Upload = new SqlCommand(InsertNewComm, sqlconn1);
            try
            {
                sqlconn1.Open();
                if (Upload.ExecuteNonQuery() == 1)
                {
                    Message1 msg = new Message1("");
                    msg.setmessage("上传信息成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "写入商品信息错误");
            }
        }
    }
    public class FreshFood : Food
    {
        string producingarea = "";
        string unit = "";
        public void set(string _firstclass, string _secondclass, string _id, string _name, string _state, string _inprice, string _outprice, string _reason, string _season, string _num, string _account, string _date, string _manufacturers, string _expirationdate, string _producingarea, string _unit)
        {
            firstclass = _firstclass;
            secondclass = _secondclass;
            id = _id;
            name = _name;
            state = _state;
            inprice = _inprice;
            outprice = _outprice;
            reason = _reason;
            season = _season;
            num = _num;
            account = _account;
            date = _date;
            manufacturers = _manufacturers;
            expirationdate = _expirationdate;
            producingarea = _producingarea;
            unit = _unit;
        }
        public void upload()
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            String InsertNewComm = string.Format("INSERT INTO productinfo(firstclass,secondclass,id,name,state,inprice,outprice,season,reason,num,account,date,manufacturers,firstclassfeature,secondclassfeature1,secondclassfeature2) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", firstclass, secondclass, id, name, state, inprice, outprice, season, reason, num, account, date, manufacturers, expirationdate, producingarea, unit);
            SqlCommand Upload = new SqlCommand(InsertNewComm, sqlconn1);
            try
            {
                sqlconn1.Open();
                if (Upload.ExecuteNonQuery() == 1)
                {
                    Message1 msg = new Message1("");
                    msg.setmessage("上传信息成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "写入商品信息错误");
            }
        }
    };
    public class Fruit : Food
    {
        string organic = "";
        string producingarea = "";
        public void set(string _firstclass, string _secondclass, string _id, string _name, string _state, string _inprice, string _outprice, string _reason, string _season, string _num, string _account, string _date, string _manufacturers, string _expirationdate, string _producingarea, string _organic)
        {
            firstclass = _firstclass;
            secondclass = _secondclass;
            id = _id;
            name = _name;
            state = _state;
            inprice = _inprice;
            outprice = _outprice;
            reason = _reason;
            season = _season;
            num = _num;
            account = _account;
            date = _date;
            manufacturers = _manufacturers;
            expirationdate = _expirationdate;
            producingarea = _producingarea;
            organic = _organic;
        }
        public void upload()
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            String InsertNewComm = string.Format("INSERT INTO productinfo(firstclass,secondclass,id,name,state,inprice,outprice,season,reason,num,account,date,manufacturers,firstclassfeature,secondclassfeature1,secondclassfeature2) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", firstclass, secondclass, id, name, state, inprice, outprice, season, reason, num, account, date, manufacturers, expirationdate, producingarea, organic);
            SqlCommand Upload = new SqlCommand(InsertNewComm, sqlconn1);
            try
            {
                sqlconn1.Open();
                if (Upload.ExecuteNonQuery() == 1)
                {
                    Message1 msg = new Message1("");
                    msg.setmessage("上传信息成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "写入商品信息错误");
            }
        }
    };
    public class DryFood : Food
    {
        string eatways = "";
        string storeways = "";
        public void set(string _firstclass, string _secondclass, string _id, string _name, string _state, string _inprice, string _outprice, string _reason, string _season, string _num, string _account, string _date, string _manufacturers, string _expirationdate, string _eatways, string _storeways)
        {
            firstclass = _firstclass;
            secondclass = _secondclass;
            id = _id;
            name = _name;
            state = _state;
            inprice = _inprice;
            outprice = _outprice;
            reason = _reason;
            season = _season;
            num = _num;
            account = _account;
            date = _date;
            manufacturers = _manufacturers;
            expirationdate = _expirationdate;
            eatways = _eatways;
            storeways = _storeways;
        }
        public void upload()
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            String InsertNewComm = string.Format("INSERT INTO productinfo(firstclass,secondclass,id,name,state,inprice,outprice,season,reason,num,account,date,manufacturers,firstclassfeature,secondclassfeature1,secondclassfeature2) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", firstclass, secondclass, id, name, state, inprice, outprice, season, reason, num, account, date, manufacturers, expirationdate, eatways, storeways);
            SqlCommand Upload = new SqlCommand(InsertNewComm, sqlconn1);
            try
            {
                sqlconn1.Open();
                if (Upload.ExecuteNonQuery() == 1)
                {
                    Message1 msg = new Message1("");
                    msg.setmessage("上传信息成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "写入商品信息错误");
            }
        }
    };
    public class BabyBook : Book
    {
        string colorful = "";
        string numberofwords = "";
        public void set(string _firstclass, string _secondclass, string _id, string _name, string _state, string _inprice, string _outprice, string _reason, string _season, string _num, string _account, string _date, string _manufacturers, string _writer, string _colorful, string _numberofwords)
        {
            firstclass = _firstclass;
            secondclass = _secondclass;
            id = _id;
            name = _name;
            state = _state;
            inprice = _inprice;
            outprice = _outprice;
            reason = _reason;
            season = _season;
            num = _num;
            account = _account;
            date = _date;
            manufacturers = _manufacturers;
            writer = _writer;
            colorful = _colorful;
            numberofwords = _numberofwords;
        }
        public void upload()
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            String InsertNewComm = string.Format("INSERT INTO productinfo(firstclass,secondclass,id,name,state,inprice,outprice,season,reason,num,account,date,manufacturers,firstclassfeature,secondclassfeature1,secondclassfeature2) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", firstclass, secondclass, id, name, state, inprice, outprice, season, reason, num, account, date, manufacturers, writer, colorful, numberofwords);
            SqlCommand Upload = new SqlCommand(InsertNewComm, sqlconn1);
            try
            {
                sqlconn1.Open();
                if (Upload.ExecuteNonQuery() == 1)
                {
                    Message1 msg = new Message1("");
                    msg.setmessage("上传信息成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "写入商品信息错误");
            }
        }
    };
    public class Beauty : Book
    {
        string gift = "";
        string numberofwords = "";
        public void set(string _firstclass, string _secondclass, string _id, string _name, string _state, string _inprice, string _outprice, string _reason, string _season, string _num, string _account, string _date, string _manufacturers, string _writer, string _gift, string _numberofwords)
        {
            firstclass = _firstclass;
            secondclass = _secondclass;
            id = _id;
            name = _name;
            state = _state;
            inprice = _inprice;
            outprice = _outprice;
            reason = _reason;
            season = _season;
            num = _num;
            account = _account;
            date = _date;
            manufacturers = _manufacturers;
            writer = _writer;
            gift = _gift;
            numberofwords = _numberofwords;
        }
        public void upload()
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            String InsertNewComm = string.Format("INSERT INTO productinfo(firstclass,secondclass,id,name,state,inprice,outprice,season,reason,num,account,date,manufacturers,firstclassfeature,secondclassfeature1,secondclassfeature2) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", firstclass, secondclass, id, name, state, inprice, outprice, season, reason, num, account, date, manufacturers, writer, gift, numberofwords);
            SqlCommand Upload = new SqlCommand(InsertNewComm, sqlconn1);
            try
            {
                sqlconn1.Open();
                if (Upload.ExecuteNonQuery() == 1)
                {
                    Message1 msg = new Message1("");
                    msg.setmessage("上传信息成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "写入商品信息错误");
            }
        }
    };
    public class Literature : Book
    {
        string country = "";
        string numberofwords = "";
        public void set(string _firstclass, string _secondclass, string _id, string _name, string _state, string _inprice, string _outprice, string _reason, string _season, string _num, string _account, string _date, string _manufacturers, string _writer, string _country, string _numberofwords)
        {
            firstclass = _firstclass;
            secondclass = _secondclass;
            id = _id;
            name = _name;
            state = _state;
            inprice = _inprice;
            outprice = _outprice;
            reason = _reason;
            season = _season;
            num = _num;
            account = _account;
            date = _date;
            manufacturers = _manufacturers;
            writer = _writer;
            country = _country;
            numberofwords = _numberofwords;
        }
        public void upload()
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            String InsertNewComm = string.Format("INSERT INTO productinfo(firstclass,secondclass,id,name,state,inprice,outprice,season,reason,num,account,date,manufacturers,firstclassfeature,secondclassfeature1,secondclassfeature2) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", firstclass, secondclass, id, name, state, inprice, outprice, season, reason, num, account, date, manufacturers, writer, country, numberofwords);
            SqlCommand Upload = new SqlCommand(InsertNewComm, sqlconn1);
            try
            {
                sqlconn1.Open();
                if (Upload.ExecuteNonQuery() == 1)
                {
                    Message1 msg = new Message1("");
                    msg.setmessage("上传信息成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "写入商品信息错误");
            }
        }
    };
    public class History : Book
    {
        string period = "";
        string numberofwords = "";
        public void set(string _firstclass, string _secondclass, string _id, string _name, string _state, string _inprice, string _outprice, string _reason, string _season, string _num, string _account, string _date, string _manufacturers, string _writer, string _period, string _numberofwords)
        {
            firstclass = _firstclass;
            secondclass = _secondclass;
            id = _id;
            name = _name;
            state = _state;
            inprice = _inprice;
            outprice = _outprice;
            reason = _reason;
            season = _season;
            num = _num;
            account = _account;
            date = _date;
            manufacturers = _manufacturers;
            writer = _writer;
            period = _period;
            numberofwords = _numberofwords;
        }
        public void upload()
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            String InsertNewComm = string.Format("INSERT INTO productinfo(firstclass,secondclass,id,name,state,inprice,outprice,season,reason,num,account,date,manufacturers,firstclassfeature,secondclassfeature1,secondclassfeature2) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", firstclass, secondclass, id, name, state, inprice, outprice, season, reason, num, account, date, manufacturers, writer, period, numberofwords);
            SqlCommand Upload = new SqlCommand(InsertNewComm, sqlconn1);
            try
            {
                sqlconn1.Open();
                if (Upload.ExecuteNonQuery() == 1)
                {
                    Message1 msg = new Message1("");
                    msg.setmessage("上传信息成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "写入商品信息错误");
            }
        }
    };
    public class GeneralProductInfo
    {
        const string IP = "59.66.135.77";//默认的服务器IP
        public static string connstring = String.Format("Data Source={0};Initial Catalog=ProductManagement;User ID=Rhodes;Password=123456", IP);//默认的连接字符串
        public string firstclass = "";
        public string secondclass = "";
        public string id = "";
        public string name = "";
        public string state = "";
        public int inprice =0;
        public int outprice =0;
        public string reason = "";
        public string season = "";
        public int num =0;
        public string account = "";
        public string date = "";
        public string manufacturers = "";
        public string firstclassfeature = "";
        public string secondclassfeature1 = "";
        public string secondclassfeature2 = "";
        public string[] data = new string[16];
        public int profit = 0;
        public int profitrate = 0;

        public void set(string _firstclass, string _secondclass, string _id, string _name, string _state, string _inprice, string _outprice, string _reason, string _season, string _num, string _account, string _date, string _manufacturers, string _firstclassfeature, string _secondclassfeature1, string _secondclassfeature2)
        {
            firstclass = _firstclass;
            secondclass = _secondclass;
            id = _id;
            name = _name;
            state = _state;
            inprice = System.Int32.Parse(_inprice);
            outprice = System.Int32.Parse(_outprice);
            reason = _reason;
            season = _season;
            num = System.Int32.Parse(_num);
            account = _account;
            date = _date;
            manufacturers = _manufacturers;
            firstclassfeature = _firstclassfeature;
            secondclassfeature1 = _secondclassfeature1;
            secondclassfeature2 = _secondclassfeature2;
            profit = outprice - inprice;
            profitrate = profit /inprice;
            data[0] = firstclass;
            data[1] = secondclass;
            data[2] = id;
            data[3] = name;
            data[4] = state;
            data[5] = inprice.ToString();
            data[6] = outprice.ToString();
            data[7] = reason;
            data[8] = season;
            data[9] = num.ToString();
            data[10] = account;
            data[11] = date;
            data[12] = manufacturers;
            data[13] = firstclassfeature;
            data[14] = secondclassfeature1;
            data[15] = secondclassfeature2;
        }
        public void upload()
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            String InsertNewComm = string.Format("INSERT INTO productinfo(firstclass,secondclass,id,name,state,inprice,outprice,season,reason,num,account,date,manufacturers,firstclassfeature,secondclassfeature1,secondclassfeature2) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", firstclass, secondclass, id, name, state, inprice, outprice, season, reason, num, account, date, manufacturers, firstclassfeature, secondclassfeature1, secondclassfeature2);
            SqlCommand Upload = new SqlCommand(InsertNewComm, sqlconn1);
            try
            {
                sqlconn1.Open();
                if (Upload.ExecuteNonQuery() == 1)
                {
                    Message1 msg = new Message1("");
                    msg.setmessage("上传信息成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "写入商品信息错误");
            }
        }
    }
    public class DateUp : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            return (x.date.CompareTo(y.date));
        }
    }
    public class DateDown : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            return (y.date.CompareTo(x.date));
        }
    }
    public class DateUpNumUp : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.date == y.date)
                return (x.num.CompareTo(y.num));
            else
                return (x.date.CompareTo(y.date));
        }
    }
    public class DateUpNumDown : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.date == y.date)
                return (y.num.CompareTo(x.date));
            else
                return (x.date.CompareTo(y.date));
        }
    }
    public class DateUpPriceUp : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.date == y.date)
                return (x.outprice.CompareTo(y.outprice));
            else
                return (x.date.CompareTo(y.date));
        }
    }
    public class DateUpPriceDown : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.date == y.date)
                return (y.outprice.CompareTo(x.outprice));
            else
                return (x.date.CompareTo(y.date));
        }
    }
    public class DateDownNumUp : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.date == y.date)
                return (x.num.CompareTo(y.num));
            else
                return (y.date.CompareTo(x.date));
        }
    }
    public class DateDownNumDown : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.date == y.date)
                return (y.num.CompareTo(x.date));
            else
                return (y.date.CompareTo(x.date));
        }
    }
    public class DateDownPriceUp : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.date == y.date)
                return (x.outprice.CompareTo(y.outprice));
            else
                return (y.date.CompareTo(x.date));
        }
    }
    public class DateDownPriceDown : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.date == y.date)
                return (y.outprice.CompareTo(x.outprice));
            else
                return (y.date.CompareTo(x.date));
        }
    }
    public class NumUp : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            return (x.num.CompareTo(y.num));
        }
    }
    public class NumDown : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            return (y.num.CompareTo(x.num));
        }
    }
    public class NumUpDateUp : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.num == y.num)
                return (x.date.CompareTo(y.date));
            else
                return (x.num.CompareTo(y.num));
        }
    }
    public class NumUpDateDown : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.num == y.num)
                return (y.date.CompareTo(x.date));
            else
                return (x.num.CompareTo(y.num));
        }
    }
    public class NumUpPriceUp : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.num == y.num)
                return (x.outprice.CompareTo(y.outprice));
            else
                return (x.num.CompareTo(y.num));
        }
    }
    public class NumUpPriceDown : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.num == y.num)
                return (y.outprice.CompareTo(x.outprice));
            else
                return (x.num.CompareTo(y.num));
        }
    }
    public class NumDownDateUp : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.num == y.num)
                return (x.date.CompareTo(y.date));
            else
                return (y.num.CompareTo(x.num));
        }
    }
    public class NumDownDateDown : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.num == y.num)
                return (y.date.CompareTo(x.date));
            else
                return (y.num.CompareTo(x.num));
        }
    }
    public class NumDownPriceUp : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.num == y.num)
                return (x.outprice.CompareTo(y.outprice));
            else
                return (y.num.CompareTo(x.num));
        }
    }
    public class NumDownPriceDown : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.num == y.num)
                return (y.outprice.CompareTo(x.outprice));
            else
                return (y.num.CompareTo(x.num));
        }
    }
    public class OutPriceUp : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            return (x.outprice.CompareTo(y.outprice));
        }
    }
    public class OutPriceDown : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            return (y.outprice.CompareTo(x.outprice));
        }
    }
    public class OutPriceUpDateUp : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.outprice == y.outprice)
                return (x.date.CompareTo(y.date));
            else
                return (x.outprice.CompareTo(y.outprice));
        }
    }
    public class OutPriceUpDateDown : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.outprice == y.outprice)
                return (y.date.CompareTo(x.date));
            else
                return (y.outprice.CompareTo(x.outprice));
        }
    }
    public class OutPriceUpNumUp : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.outprice == y.outprice)
                return (x.num.CompareTo(y.num));
            else
                return (x.outprice.CompareTo(y.outprice));
        }
    }
    public class OutPriceUpNumDown : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.outprice == y.outprice)
                return (y.num.CompareTo(x.num));
            else
                return (x.outprice.CompareTo(y.outprice));
        }
    }
    public class OutPriceDownDateUp : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.outprice == y.outprice)
                return (x.date.CompareTo(y.date));
            else
                return (y.outprice.CompareTo(x.outprice));
        }
    }
    public class OutPriceDownDateDown : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.outprice == y.outprice)
                return (y.date.CompareTo(x.date));
            else
                return (x.outprice.CompareTo(y.outprice));
        }
    }
    public class OutPriceDownNumUp : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.outprice == y.outprice)
                return (x.num.CompareTo(y.num));
            else
                return (y.outprice.CompareTo(x.outprice));
        }
    }
    public class OutPriceDownNumDown : IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x, GeneralProductInfo y)
        {
            if (x.outprice == y.outprice)
                return (y.num.CompareTo(x.num));
            else
                return (y.outprice.CompareTo(x.outprice));
        }
    }
    public class InPriceDown:IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x,GeneralProductInfo y)
        {
            return (y.inprice.CompareTo(x.inprice));
        }
    }
    public class ProfitDown:IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x,GeneralProductInfo y)
        {
            return (y.profit.CompareTo(x.profit));
        }
    }
    public class ProfitRateDown:IComparer<GeneralProductInfo>
    {
        public int Compare(GeneralProductInfo x,GeneralProductInfo y)
        {
            return (y.profitrate.CompareTo(x.profitrate));
        }
    }
}
