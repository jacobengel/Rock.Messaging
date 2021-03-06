﻿using System;

#if ROCKLIB
namespace RockLib.Messaging
#else
namespace Rock.Messaging
#endif
{
    /// <summary>
    /// Provides data for the <see cref="IReceiver.MessageReceived"/> event.
    /// </summary>
    public class MessageReceivedEventArgs : EventArgs
    {
        private readonly IReceiverMessage _message;

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageReceivedEventArgs"/> class.
        /// </summary>
        /// <param name="message">The received message.</param>
        public MessageReceivedEventArgs(IReceiverMessage message)
        {
            _message = message;
        }

        /// <summary>
        /// Gets the received message.
        /// </summary>
        public IReceiverMessage Message
        {
            get { return _message; }
        }
    }
}