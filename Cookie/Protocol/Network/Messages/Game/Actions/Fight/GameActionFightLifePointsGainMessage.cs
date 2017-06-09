//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Actions.Fight
{
    using Cookie.Protocol.Network.Messages.Game.Actions;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class GameActionFightLifePointsGainMessage : AbstractGameActionMessage
    {
        
        public new const uint ProtocolId = 6311;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_targetId;
        
        public virtual double TargetId
        {
            get
            {
                return m_targetId;
            }
            set
            {
                m_targetId = value;
            }
        }
        
        private uint m_delta;
        
        public virtual uint Delta
        {
            get
            {
                return m_delta;
            }
            set
            {
                m_delta = value;
            }
        }
        
        public GameActionFightLifePointsGainMessage(double targetId, uint delta)
        {
            m_targetId = targetId;
            m_delta = delta;
        }
        
        public GameActionFightLifePointsGainMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(m_targetId);
            writer.WriteVarUhInt(m_delta);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_targetId = reader.ReadDouble();
            m_delta = reader.ReadVarUhInt();
        }
    }
}