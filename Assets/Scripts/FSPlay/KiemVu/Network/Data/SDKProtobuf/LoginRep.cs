using ProtoBuf;

namespace FSPlay.GameEngine.SDK.ProtoModel
{
    /// <summary>
    /// Đối tượng phản hồi từ SDK về login
    /// </summary>
    [ProtoContract]
    public class LoginRep
    {
        /// <summary>
        /// Mã lỗi
        /// </summary>
        [ProtoMember(1)]
        public bool status = true;

        /// <summary>
        /// Mô tả
        /// </summary>
        [ProtoMember(2)]
        public string msg = "";

        /// <summary>
        /// User ID
        /// </summary>
        [ProtoMember(3)]
        public string user_id = "";

        /// <summary>
        /// User Name
        /// </summary>
        [ProtoMember(4)]
        public string user_name = "";

        /// <summary>
        /// Thời gian đăng nhập
        /// </summary>
        [ProtoMember(5)]
        public long lTime = 0;

        /// <summary>
        /// WTF
        /// </summary>
        [ProtoMember(6)]
        public string strCM = "1";

        /// <summary>
        /// Chuỗi Token
        /// </summary>
        [ProtoMember(7)]
        public string strToken = "";
    }
}
