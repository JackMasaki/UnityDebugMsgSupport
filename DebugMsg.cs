using System.Diagnostics;

namespace DebugMsgSupport
{
    static class DebugMsg 
    {
        /// <summary>
        /// Display Error, Log, Warning.
        /// </summary>
        /// <param name="str">Display Message</param>
        /// <param name="num">Error,Log,Warning</param>
        public static void Text(string str, MessageType num = MessageType.Log)
        {
            var message = GetPrefix((int)num);

            StackFrame callerFrame = new StackFrame(1);

            var methodName = callerFrame.GetMethod().Name;
            var className = callerFrame.GetMethod().ReflectedType.FullName;

            message += string.Format("[{0}.{1}] {2}", className, methodName, str);

            switch ((int)num)
            {
                case -1:
                    UnityEngine.Debug.LogError(message);
                    break;

                case 1:
                    UnityEngine.Debug.LogWarning(message);
                    break;

                default:
                    UnityEngine.Debug.Log(message);
                    break;
            }

        }

        private static string GetPrefix(int num)
        {
            switch (num)
            {
                case -1:
                    return string.Format("<color=Red>[{0}]</color> ", "E");

                case 1:
                    return string.Format("<color=Yellow>[{0}]</color> ", "W");

                default:
                    return string.Format("[{0}]", "LOG");
            }
        }

        public enum MessageType
        {
            Error = -1,
            Log = 0,
            Warning = 1
        }
    }

}
