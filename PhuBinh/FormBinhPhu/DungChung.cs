using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBinhPhu
{
    public static class Class1
    {
        private static int m_number;
        public static int Role
        {
            get
            {
                return m_number;
            }
            set
            {
                m_number = value;
            }
        }
        private static string idacc;
        public static string IdAcc
        {
            get
            {
                return idacc;
            }
            set
            {
                idacc = value;
            }
        }
        private static string name;
        public static string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private static int code;
        public static int Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        private static int setflag;
        public static int SetFlag
        {
            get
            {
                return setflag;
            }
            set
            {
                setflag = value;
            }
        }
        public delegate void EventVote(object sender, LoginSuccess e);
        public class LoginSuccess: EventArgs
        {
            public string IdUser { get; set; }
            public int Code { get; set; }
            public string IdOpt { get; set; }
        }
    }
}
