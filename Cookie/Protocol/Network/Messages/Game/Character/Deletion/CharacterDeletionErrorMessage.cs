//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Character.Deletion
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class CharacterDeletionErrorMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 166;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_reason;
        
        public virtual byte Reason
        {
            get
            {
                return m_reason;
            }
            set
            {
                m_reason = value;
            }
        }
        
        public CharacterDeletionErrorMessage(byte reason)
        {
            m_reason = reason;
        }
        
        public CharacterDeletionErrorMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteByte(m_reason);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_reason = reader.ReadByte();
        }
    }
}
