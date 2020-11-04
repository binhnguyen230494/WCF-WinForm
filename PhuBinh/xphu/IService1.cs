using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace xphu
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        DataSet DsAcount();
        [OperationContract]
        bool DangNhap(UserDetail userinfo);
        [OperationContract]
        bool Account(UserDetail userinfo);
        [OperationContract]
        bool Them(UserDetail userinfo);
        [OperationContract]
        bool Sua(UserDetail userinfo);
        [OperationContract]
        bool Xoa(UserDetail userinfo);
        [OperationContract]
        bool ThemContents(Option option);
        [OperationContract]
        bool XoaOption(Option xoa);
        [OperationContract]
        //DataSet DsContents();
        //[OperationContract]
        bool LoadContent(Vote vote);
        [OperationContract]
        DataSet DsOption();
        [OperationContract]
        DataSet DsCode1();
        [OperationContract]
        DataSet DsCode(string idac);
        [OperationContract]
        bool SuaVote(Vote sua);
        [OperationContract]
        bool ThemVote(Vote them);
        [OperationContract]
        bool KiemTraIdAcc(Vote Kt);
        [OperationContract]
        DataSet DsAns();
        [OperationContract]
        bool SuaAns(Option sua);
        [OperationContract]
        DataSet DsQuestion();
        [OperationContract]
        bool KiemTraContents(Option KtContents);
        [OperationContract]
        int DemAns(Vote Dem);
        [OperationContract]
        DataSet DistinctOpt();
        [OperationContract]
        int DemK(Vote Dem);
        [OperationContract]
        int DemCb(Vote Dem);
        [OperationContract]
        DataSet LuotVote();
        [OperationContract]
        bool KtSetFlag(Vote Kt);
        [OperationContract]
        bool KtActivate(UserDetail KtAc);
        [OperationContract]
        bool SuaActi(UserDetail suaacti);
        [OperationContract]
        bool RsActi(UserDetail rs);
        [OperationContract]
        bool KtDlVote(Vote Kt);
    }
    public class Option
    {
        string Contents;
        string IdOpt;
        string Code;
        DateTime DeadlineTime;
        public string code
        {
            get { return Code; }
            set { Code = value; }
        }
        public DateTime deadlinetime
        {
            get { return DeadlineTime; }
            set { DeadlineTime = value; }
        }
        public string idopt
        {
            get { return IdOpt; }
            set { IdOpt = value; }
        }

        public string contents
        {
            get { return Contents; }
            set { Contents = value; }
        }
    }
    public class UserDetail
    {
        string IdAcc;
        string Name;
        bool Role;
        string Pass;
        bool Activate;
        public string idacc
        {
            get { return IdAcc; }
            set { IdAcc = value; }
        }
        [DataMember]
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        [DataMember]
        public string pass
        {
            get { return Pass; }
            set { Pass = value; }
        }
        [DataMember]
        public bool role
        {
            get { return Role; }
            set { Role = value; }
        }
        [DataMember]
        public bool acti
        {
            get { return Activate; }
            set { Activate = value; }
        }
    }
    public class Vote
    {
        int IdVote;
        string IdAcc;
        string IdOpt;
        string Code;
        DateTime Time;
        bool SetFlag;
        [DataMember]
        public int idvote
        {
            get { return IdVote; }
            set { IdVote = value; }
        }
        [DataMember]
        public string idacc
        {
            get { return IdAcc; }
            set { IdAcc = value; }
        }
        [DataMember]
        public string idopt
        {
            get { return IdOpt; }
            set { IdOpt = value; }
        }
        [DataMember]
        public string code
        {
            get { return Code; }
            set { Code = value; }
        }
        [DataMember]
        public DateTime time
        {
            get { return Time; }
            set { Time = value; }
        }
        [DataMember]
        public bool setflag
        {
            get { return SetFlag; }
            set { SetFlag = value; }
        }
    }
}
