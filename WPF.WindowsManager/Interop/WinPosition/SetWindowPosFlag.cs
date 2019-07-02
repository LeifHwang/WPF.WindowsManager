using System;

namespace WPF.WindowsManager.Interop.WinPosition
{
    [Flags]
    public enum SetWindowPosFlag
    {
        /// <summary>
        /// 画边框
        /// </summary>
        DrawFrame = 0x0020,
        /// <summary>
        /// 强制发生WM_NCCALCSIZE消息，一般改变大小时才发送
        /// </summary>
        FrameChanged = 0x0020,
        /// <summary>
        /// 隐藏窗口
        /// </summary>
        HideWindow = 0x0080,
        /// <summary>
        /// 不激活窗口
        /// </summary>
        NoActivate = 0x0010,
        /// <summary>
        /// 清除客户区的所有内容
        /// </summary>
        NoCopyBits = 0x0100,
        /// <summary>
        /// 保持位置
        /// </summary>
        NoMove = 0x0002,
        /// <summary>
        /// 不改变Z序中的所有者窗口的位置
        /// </summary>
        NoOwnerZorder = 0x0200,
        /// <summary>
        /// 不重绘
        /// </summary>
        NoReDraw = 0x0008,
        /// <summary>
        /// 等同NoOwnerZorder
        /// </summary>
        NoRePosition = 0x0200,
        /// <summary>
        /// 防止窗口接收WM_WINDOWPOSCHANGING消息
        /// </summary>
        NoSendChanging = 0x0400,
        /// <summary>
        /// 保持大小
        /// </summary>
        NoSize = 0x0001,
        /// <summary>
        /// 保留当前排序
        /// </summary>
        NoZOrder = 0x0004,
        /// <summary>
        /// 显示窗口
        /// </summary>
        ShowWindow = 0x0040,
        /// <summary>
        /// 窗口周围画一个边框
        /// </summary>
        Defererase = 0x2000,
        /// <summary>
        /// 如果调用进程不拥有窗口，向拥有窗口的线程发出需求
        /// 防止调用线程在其他线程处理需求时发生死锁
        /// </summary>
        AsyncWindowPos = 0x4000
    }
}
