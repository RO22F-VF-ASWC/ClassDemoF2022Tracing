using System.Diagnostics;
using System.IO;

namespace ClassDemoF2022Tracing
{
    public class AWorker
    {
        // creating a trace source system  / object
        private TraceSource ts = new TraceSource("Peters Demo");


        public AWorker()
        {
            // setting the overall switch
            ts.Switch = new SourceSwitch("Peters Log", "All");

            // setting up listeners
            TraceListener consoleLog = new ConsoleTraceListener();
            ts.Listeners.Add(consoleLog);


            TraceListener fileLog = new TextWriterTraceListener(new StreamWriter("TraceDemo.txt"));
            fileLog.Filter = new EventTypeFilter(SourceLevels.Error);
            ts.Listeners.Add(fileLog);


            TraceListener xmlLog = new XmlWriterTraceListener(new StreamWriter("TraceDemo.xml"));
            ts.Listeners.Add(xmlLog);

            //TraceListener eventLog = new EventLogTraceListener("Application");
            //ts.Listeners.Add(eventLog);

        }

        public void Start()
        {
            // do somthing 

            // tracing
            ts.TraceEvent(TraceEventType.Information, 333, "This is just information");
            ts.TraceEvent(TraceEventType.Warning, 333, "This is a warning");
            ts.TraceEvent(TraceEventType.Error, 333, "This is an error");
            ts.TraceEvent(TraceEventType.Critical, 333, "!! Critical");

            ts.Close();
        }
    }
}