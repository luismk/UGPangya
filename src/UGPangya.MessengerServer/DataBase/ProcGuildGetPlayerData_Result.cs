//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UGPangya.MessengerServer.DataBase
{
    using System;
    
    public partial class ProcGuildGetPlayerData_Result
    {
        public int GUILD_INDEX { get; set; }
        public string GUILD_NAME { get; set; }
        public string GUILD_INTRODUCING { get; set; }
        public string GUILD_NOTICE { get; set; }
        public int GUILD_LEADER_UID { get; set; }
        public Nullable<System.DateTime> GUILD_CREATE_DATE { get; set; }
        public int GUILD_TOTAL_MEMBER { get; set; }
        public string GUILD_LEADER_NICKNAME { get; set; }
        public byte GUILD_POSITION { get; set; }
        public string GUILD_IMAGE { get; set; }
    }
}