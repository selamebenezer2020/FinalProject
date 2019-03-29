using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class SerialNoGenerator
    {
        private static volatile SerialNoGenerator instance;
        public static object synchronizationRoot = new object();
        private int _SmallGadgetSerial = 1245;
        private int _MediumGadgetSerial = 2356;
        private int _LargeGadgetSerial = 3467;
        private int _SmallWidgetSerial = 1346;
        private int _MediumWidgetSerial = 22457;
        private int _LargeWidgetSerial = 3568;
        

        public static SerialNoGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNoGenerator();
                        }
                    }
                }
                return instance;
            }
        }

        private SerialNoGenerator() { }

        public virtual int SmallGadgetSerial
        {
            get { return ++_SmallGadgetSerial; }
        }

        public virtual int MediumGadgetSerial
        {
            get { return ++_MediumGadgetSerial; }
        }

        public virtual int LargeGadgetSerial
        {
            get { return ++_LargeGadgetSerial; }
        }

        public virtual int SmallWidgetSerial
        {
            get { return ++_SmallWidgetSerial; }
        }

        public virtual int MediumWidgetSerial
        {
            get { return ++_MediumWidgetSerial; }
        }

        public virtual int LargeWidgetSerial
        {
            get { return ++_LargeWidgetSerial; }
        }
    }
}

