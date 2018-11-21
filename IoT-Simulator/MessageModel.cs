using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoT_Simulator
{
    public class MessageModel
    {
        public long eventTime { get; set; } //Epoch Unhix TimeStamp(milseconds
        public string uid { get; set; }
        public string systemtype { get; set; }
        public string devtype { get; set; }
        public string devname { get; set; }
        public string unit { get; set; }
        public string describe { get; set; }
        public string value { get; set; }

    }

    public class CallMethodModel
    {
        public string DeviceId { get; set; }
        public string Status { get; set; }
        public int OperationMinutes { get; set; }
    }
}