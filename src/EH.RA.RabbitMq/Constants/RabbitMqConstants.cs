namespace EH.RA.RabbitMq.Constants
{
    internal class RabbitMqConstants
    {
        internal static class ReplyCode 
        {
            internal const ushort KillSession = 999;
        }
        internal static class ReplyReason
        {
            internal const string SessionForciblyEnded = "Session forcibly ended";
        }
    }
}