﻿namespace HotelBookingSystem.Core.IO
{
    using System;
    using Interfaces;

    public class ConsoleReader : IInputReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
