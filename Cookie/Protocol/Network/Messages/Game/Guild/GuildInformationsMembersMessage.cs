//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Guild
{
    using Cookie.Protocol.Network.Types.Game.Guild;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class GuildInformationsMembersMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5558;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<GuildMember> m_members;
        
        public virtual List<GuildMember> Members
        {
            get
            {
                return m_members;
            }
            set
            {
                m_members = value;
            }
        }
        
        public GuildInformationsMembersMessage(List<GuildMember> members)
        {
            m_members = members;
        }
        
        public GuildInformationsMembersMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(((short)(m_members.Count)));
            int membersIndex;
            for (membersIndex = 0; (membersIndex < m_members.Count); membersIndex = (membersIndex + 1))
            {
                GuildMember objectToSend = m_members[membersIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int membersCount = reader.ReadUShort();
            int membersIndex;
            m_members = new System.Collections.Generic.List<GuildMember>();
            for (membersIndex = 0; (membersIndex < membersCount); membersIndex = (membersIndex + 1))
            {
                GuildMember objectToAdd = new GuildMember();
                objectToAdd.Deserialize(reader);
                m_members.Add(objectToAdd);
            }
        }
    }
}
