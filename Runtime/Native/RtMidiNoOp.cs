using System;
using System.Runtime.InteropServices;

namespace Minis.Native
{

#if UNITY_ANDROID
    internal static unsafe class RtMidi
    {
        public static void rtmidi_open_port(
            RtMidiHandle device,
            uint portNumber,
            [MarshalAs(UnmanagedType.LPStr)] string portName
        )
        {
        }

        public static void rtmidi_close_port(
            RtMidiHandle device
        )
        {
        }

        public static uint rtmidi_get_port_count(
            RtMidiHandle device
        ) =>
            0;

        [return: MarshalAs(UnmanagedType.LPStr)]
        public static string rtmidi_get_port_name(
            RtMidiHandle device,
            uint portNumber
        ) =>
            "Stub port name";

        public static RtMidiInHandle rtmidi_in_create_default() => new RtMidiInHandle();

        public static void rtmidi_in_set_callback(
            RtMidiInHandle device,
            RtMidiCCallback callback,
            void* userData
        )
        {
        }

        public static void rtmidi_in_cancel_callback(
            RtMidiInHandle device
        )
        {
        }

        public static double rtmidi_in_get_message(
            RtMidiInHandle device,
            byte* message,
            ref UIntPtr size
        ) => 0;

        public static RtMidiOutHandle rtmidi_out_create_default() => new RtMidiOutHandle();

        public static int rtmidi_out_send_message(
            RtMidiOutHandle device,
            byte* message,
            int length
        ) => 0;
    }
#endif
}