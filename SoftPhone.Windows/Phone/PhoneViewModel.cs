using Prism.Commands;
using Prism.Mvvm;
using SoftPhone.Common.SipClientModels.UserAgents;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SoftPhone.Windows.Phone
{
    public class PhoneViewModel : BindableBase
    {
        SipUserAgentClient sipUAC;

        public PhoneViewModel()
        {
            DigitPressedCommand = new DelegateCommand<string>(OnDigitPressedCommand);
            BackspaceCommand = new DelegateCommand(OnBackspaceCommand);
            ClearCommand = new DelegateCommand(OnClearCommand);
            DialCommand = new DelegateCommand<string>(OnDialCommand);
            CancelCommand = new DelegateCommand(OnCancelCommand);
            AnswerCommand = new DelegateCommand(OnAnswerCommand);

            this.sipUAC = new SipUserAgentClient();
            this.sipUAC.StatusMessageUpdated += sipUAC_StatusMessageUpdated;
            this.sipUAC.IncomingCall += OnIncomingCall;
        }

        private void sipUAC_StatusMessageUpdated(SipUserAgentClient sipUaClient, string message)
        {
            Status = $"{Status}{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff")}: {sipUaClient}: {message}\r\n";
        }

        private string _cli;
        public string Cli
        {
            get { return _cli; }
            set { SetProperty(ref _cli, value); }
        }

        private bool _incomingCall;
        public bool IncomingCall
        {
            get { return _incomingCall; }
            set { SetProperty(ref _incomingCall, value); }
        }

        private string _status;
        public string Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }

        public DelegateCommand<string> DigitPressedCommand { get; private set; }
        public DelegateCommand BackspaceCommand { get; private set; }
        public DelegateCommand ClearCommand { get; private set; }
        public DelegateCommand RegisterCommand { get; private set; }
        public DelegateCommand<string> DialCommand { get; private set; }
        public DelegateCommand CancelCommand { get; private set; }
        public DelegateCommand AnswerCommand { get; private set; }

        private void OnDigitPressedCommand(string digit)
        {
            Cli = $"{Cli}{digit}";
        }

        private void OnBackspaceCommand()
        {
            Cli = Cli.Remove(Cli.Length - 1, 1);
        }

        private void OnClearCommand()
        {
            Cli = string.Empty;
        }

        private async void OnDialCommand(string cli)
        {
            await sipUAC.DialAsync(cli);
        }

        private void OnCancelCommand()
        {
            sipUAC.Cancel();
        }

        private bool OnIncomingCall(SIPRequest sipRequest)
        {
            IncomingCall = true;
            return IncomingCall;
        }

        private async void OnAnswerCommand()
        {
            await AnswerCallAsync(sipUAC);
        }

        private async Task AnswerCallAsync(SipUserAgentClient sipUaClient)
        {
            //TODO: Create GUI answer method.
            bool result = await sipUaClient.AnswerAsync();
        }
    }

}
