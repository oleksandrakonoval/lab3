namespace SimCorp.IMS.UnderstandingOOP.Provider {
    public class SMSProvider {

        public delegate void SMSRecievedDelegate(string message);

        public event SMSRecievedDelegate SMSReceived;

        public void RaiseSMSReceivedEvent(string message) {
            SMSReceived?.Invoke(message);
        }
    }
}
