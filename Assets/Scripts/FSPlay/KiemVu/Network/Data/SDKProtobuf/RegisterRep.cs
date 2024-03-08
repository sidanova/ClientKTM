using ProtoBuf;

namespace FSPlay.GameEngine.SDK.ProtoModel
{
    /// <summary>
    /// Đối tượng phản hồi từ SDK đăng ký
    /// </summary>
    [ProtoContract]
    public class RegisterRep
    {
        /// <summary>
        /// Mã lỗi
        /// </summary>
        [ProtoMember(1)]
        public bool status = true;

        /// <summary>
        /// Mô tả lỗi
        /// </summary>
        [ProtoMember(2)]
        public string msg = "";
    }
}
