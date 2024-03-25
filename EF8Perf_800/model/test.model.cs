using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crosscutting.cqrs
{
    public interface IDbRecord { }
    public interface ITopLevelDbEntity { }
    public interface IDbEntity { }
    public interface IAssortedLatestLinkTable { }
    public interface IOrderedLatestLinkTable { }
    public interface IAssortedLatestRecordLinkTable { }
    public interface ITopLevelDbRecord { }
    public interface IOrderedLatestRecordLinkTable { }
}


namespace test.model
{
    public enum tstT014State
    {
        Undefined = 0,// 0x0
        State1 = 10,// 0xA
        State2 = 20,// 0x14
    }
    public static class tstConstants
    {
        public static Guid RawId = new Guid("f5871072-975e-415b-bf5c-11a81c1964d1");
    }
}
