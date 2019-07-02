
namespace WPF.WindowsManager.Interop
{
    /// <summary>
    /// Windows消息详细信息
    /// </summary>
    public enum WindowsMessages
    {
        WM_NULL = 0x0000,
        /// <summary>
        /// 应用程序创建一个窗口
        /// </summary>
        WM_CREATE = 0x0001,
        /// <summary>
        /// 一个窗口被销毁
        /// </summary>
        WM_DESTROY = 0x0002,
        /// <summary>
        /// 移动一个窗口
        /// </summary>
        WM_MOVE = 0x0003,
        /// <summary>
        /// 改变一个窗口的大小
        /// </summary>
        WM_SIZE = 0x0005,
        /// <summary>
        /// 一个窗口被激活或失去激活状态；
        /// </summary>
        WM_ACTIVATE = 0x0006,
        /// <summary>
        /// 获得焦点后
        /// </summary>
        WM_SETFOCUS = 0x0007,
        /// <summary>
        /// 失去焦点
        /// </summary>
        WM_KILLFOCUS = 0x0008,
        /// <summary>
        /// 改变enable状态
        /// </summary>
        WM_ENABLE = 0x000A,
        /// <summary>
        /// 设置窗口是否能重画
        /// </summary>
        WM_SETREDRAW = 0x000B,
        /// <summary>
        /// 应用程序发送此消息来设置一个窗口的文本
        /// </summary>
        WM_SETTEXT = 0x000C,
        /// <summary>
        /// 应用程序发送此消息来复制对应窗口的文本到缓冲区
        /// </summary>
        WM_GETTEXT = 0x000D,
        /// <summary>
        /// 得到与一个窗口有关的文本的长度（不包含空字符）
        /// </summary>
        WM_GETTEXTLENGTH = 0x000E,
        /// <summary>
        /// 要求一个窗口重绘
        /// </summary>
        WM_PAINT = 0x000F,
        /// <summary>
        /// 当一个窗口或应用程序要关闭时发送一个信号
        /// </summary>
        WM_CLOSE = 0x0010,
        /// <summary>
        /// 当用户选择结束对话框或程序自己调用ExitWindows函数
        /// </summary>
        WM_QUERYENDSESSION = 0x0011,
        /// <summary>
        /// 用来结束程序运行或当程序调用postquitmessage函数
        /// </summary>
        WM_QUIT = 0x0012,
        /// <summary>
        /// 当用户窗口恢复以前的大小位置时，把此消息发送给某个图标
        /// </summary>
        WM_QUERYOPEN = 0x0013,
        /// <summary>
        /// 当窗口背景必须被擦除时（例在窗口改变大小时）
        /// </summary>
        WM_ERASEBKGND = 0x0014,
        /// <summary>
        /// 当系统颜色改变时，发送此消息给所有顶级窗口
        /// </summary>
        WM_SYSCOLORCHANGE = 0x0015,
        /// <summary>
        /// 当系统进程发出WM_QUERYENDSESSION消息后，此消息发送给应用程序，通知它对话是否结束
        /// </summary>
        WM_ENDSESSION = 0x0016,
        /// <summary>
        /// 当隐藏或显示窗口是发送此消息给这个窗口
        /// </summary>
        WM_SHOWWINDOW = 0x0018,
        WM_WININICHANGE = 0x001A,
        WM_SETTINGCHANGE = 0x001A,
        WM_DEVMODECHANGE = 0x001B,
        /// <summary>
        /// 发此消息给应用程序哪个窗口是激活的，哪个是非激活的；
        /// </summary>
        WM_ACTIVATEAPP = 0x001C,
        /// <summary>
        /// 当系统的字体资源库变化时发送此消息给所有顶级窗口
        /// </summary>
        WM_FONTCHANGE = 0x001D,
        /// <summary>
        /// 当系统的时间变化时发送此消息给所有顶级窗口
        /// </summary>
        WM_TIMECHANGE = 0x001E,
        /// <summary>
        /// 发送此消息来取消某种正在进行的摸态（操作）
        /// </summary>
        WM_CANCELMODE = 0x001F,
        /// <summary>
        /// 如果鼠标引起光标在某个窗口中移动且鼠标输入没有被捕获时，就发消息给某个窗口
        /// </summary>
        WM_SETCURSOR = 0x0020,
        /// <summary>
        /// 当光标在某个非激活的窗口中而用户正按着鼠标的某个键发送此消息给当前窗口
        /// </summary>
        WM_MOUSEACTIVATE = 0x0021,
        /// <summary>
        /// 发送此消息给MDI子窗口当用户点击此窗口的标题栏，或当窗口被激活，移动，改变大小
        /// </summary>
        WM_CHILDACTIVATE = 0x0022,
        /// <summary>
        /// 此消息由基于计算机的训练程序发送，通过WH_JOURNALPALYBACK的hook程序分离出用户输入消息
        /// </summary>
        WM_QUEUESYNC = 0x0023,
        /// <summary>
        /// 此消息发送给窗口当它将要改变大小或位置；
        /// </summary>
        WM_GETMINMAXINFO = 0x0024,
        /// <summary>
        /// 发送给最小化窗口当它图标将要被重画
        /// </summary>
        WM_PAINTICON = 0x0026,
        /// <summary>
        /// 此消息发送给某个最小化窗口，仅当它在画图标前它的背景必须被重画
        /// </summary>
        WM_ICONERASEBKGND = 0x0027,
        /// <summary>
        /// 发送此消息给一个对话框程序去更改焦点位置
        /// </summary>
        WM_NEXTDLGCTL = 0x0028,
        /// <summary>
        /// 每当打印管理列队增加或减少一条作业时发出此消息
        /// </summary>
        WM_SPOOLERSTATUS = 0x002A,
        /// <summary>
        /// 当button，combobox，listbox，menu的可视外观改变时发送此消息给这些空件的所有者
        /// </summary>
        WM_DRAWITEM = 0x002B,
        /// <summary>
        /// 当button, combo box, list box, list view control, or menu item 被创建时发送此消息给控件的所有者
        /// </summary>
        WM_MEASUREITEM = 0x002C,
        /// <summary>
        /// 当the list box 或combo box 被销毁或当某些项被删除通过LB_DELETESTRING, LB_RESETCONTENT, CB_DELETESTRING, or CB_RESETCONTENT 消息
        /// </summary>
        WM_DELETEITEM = 0x002D,
        /// <summary>
        /// 此消息有一个LBS_WANTKEYBOARDINPUT风格的发出给它的所有者来响应WM_KEYDOWN消息
        /// </summary>
        WM_VKEYTOITEM = 0x002E,
        /// <summary>
        /// 此消息由一个LBS_WANTKEYBOARDINPUT风格的列表框发送给他的所有者来响应WM_CHAR消息
        /// </summary>
        WM_CHARTOITEM = 0x002F,
        /// <summary>
        /// 当绘制文本时程序发送此消息得到控件要用的颜色
        /// </summary>
        WM_SETFONT = 0x0030,
        /// <summary>
        /// 应用程序发送此消息得到当前控件绘制文本的字体
        /// </summary>
        WM_GETFONT = 0x0031,
        /// <summary>
        /// 应用程序发送此消息让一个窗口与一个热键相关连
        /// </summary>
        WM_SETHOTKEY = 0x0032,
        /// <summary>
        /// 应用程序发送此消息来判断热键与某个窗口是否有关联
        /// </summary>
        WM_GETHOTKEY = 0x0033,
        /// <summary>
        /// 此消息发送给最小化窗口，当此窗口将要被拖放而它的类中没有定义图标，应用程序能返回一个图标或光标的句柄，当用户拖放图标时系统显示这个图标或光标
        /// </summary>
        WM_QUERYDRAGICON = 0x0037,
        /// <summary>
        /// 发送此消息来判定combobox或listbox新增加的项的相对位置
        /// </summary>
        WM_COMPAREITEM = 0x0039,
        WM_GETOBJECT = 0x003D,
        /// <summary>
        /// 显示内存已经很少了
        /// </summary>
        WM_COMPACTING = 0x0041,
        WM_COMMNOTIFY = 0x0044,
        /// <summary>
        /// 发送此消息给那个窗口的大小和位置将要被改变时，来调用setwindowpos函数或其它窗口管理函数
        /// </summary>
        WM_WINDOWPOSCHANGING = 0x0046,
        /// <summary>
        /// 发送此消息给那个窗口的大小和位置已经被改变时，来调用setwindowpos函数或其它窗口管理函数
        /// </summary>
        WM_WINDOWPOSCHANGED = 0x0047,
        /// <summary>
        /// （适用于16位的windows）当系统将要进入暂停状态时发送此消息
        /// </summary>
        WM_POWER = 0x0048,
        /// <summary>
        /// 当一个应用程序传递数据给另一个应用程序时发送此消息
        /// </summary>
        WM_COPYDATA = 0x004A,
        /// <summary>
        /// 当某个用户取消程序日志激活状态，提交此消息给程序
        /// </summary>
        WM_CANCELJOURNAL = 0x004B,
        /// <summary>
        /// 当某个控件的某个事件已经发生或这个控件需要得到一些信息时，发送此消息给它的父窗口
        /// </summary>
        WM_NOTIFY = 0x004E,
        /// <summary>
        /// 当用户选择某种输入语言，或输入语言的热键改变
        /// </summary>
        WM_INPUTLANGCHANGEREQUEST = 0x0050,
        /// <summary>
        /// 当平台现场已经被改变后发送此消息给受影响的最顶级窗口
        /// </summary>
        WM_INPUTLANGCHANGE = 0x0051,
        /// <summary>
        /// 当程序已经初始化windows帮助例程时发送此消息给应用程序
        /// </summary>
        WM_TCARD = 0x0052,
        /// <summary>
        /// 此消息显示用户按下了F1
        /// 如果某个菜单是激活的，就发送此消息个此窗口关联的菜单，否则就发送给有焦点的窗口
        /// 如果当前都没有焦点，就把此消息发送给当前激活的窗口
        /// </summary>
        WM_HELP = 0x0053,
        /// <summary>
        /// 当用户已经登入或退出后发送此消息给所有的窗口
        /// 当用户登入或退出时系统更新用户的具体设置信息，在用户更新设置时系统马上发送此消息；
        /// </summary>
        WM_USERCHANGED = 0x0054,
        /// <summary>
        /// 公用控件，自定义控件和他们的父窗口通过此消息来判断控件是使用ANSI还是UNICODE结构在WM_NOTIFY消息
        /// 使用此控件能使某个控件与它的父控件之间进行相互通信
        /// </summary>
        WM_NOTIFYFORMAT = 0x0055,
        /// <summary>
        /// 当用户某个窗口中点击了一下右键就发送此消息给这个窗口
        /// </summary>
        WM_CONTEXTMENU = 0x007B,
        /// <summary>
        /// 当调用SETWINDOWLONG函数将要改变一个或多个窗口的风格时发送此消息给那个窗口
        /// </summary>
        WM_STYLECHANGING = 0x007C,
        /// <summary>
        /// 当调用SETWINDOWLONG函数一个或多个窗口的风格后发送此消息给那个窗口
        /// </summary>
        WM_STYLECHANGED = 0x007D,
        /// <summary>
        /// 当显示器的分辨率改变后发送此消息给所有的窗口
        /// </summary>
        WM_DISPLAYCHANGE = 0x007E,
        /// <summary>
        /// 此消息发送给某个窗口来返回与某个窗口有关连的大图标或小图标的句柄；
        /// </summary>
        WM_GETICON = 0x007F,
        /// <summary>
        /// 程序发送此消息让一个新的大图标或小图标与某个窗口关联；
        /// </summary>
        WM_SETICON = 0x0080,
        /// <summary>
        /// 当某个窗口第一次被创建时，此消息在WM_CREATE消息发送前发送；
        /// </summary>
        WM_NCCREATE = 0x0081,
        /// <summary>
        /// 此消息通知某个窗口，非客户区正在销毁
        /// </summary>
        WM_NCDESTROY = 0x0082,
        /// <summary>
        /// 当某个窗口的客户区域必须被核算时发送此消息
        /// </summary>
        WM_NCCALCSIZE = 0x0083,
        /// <summary>
        /// 移动鼠标，按住或释放鼠标时发生
        /// </summary>
        WM_NCHITTEST = 0x0084,
        /// <summary>
        /// 程序发送此消息给某个窗口当它（窗口）的框架必须被绘制时；
        /// </summary>
        WM_NCPAINT = 0x0085,
        /// <summary>
        /// 此消息发送给某个窗口仅当它的非客户区需要被改变来显示是激活还是非激活状态；
        /// </summary>
        WM_NCACTIVATE = 0x0086,
        /// <summary>
        /// 发送此消息给某个与对话框程序关联的控件，widdows控制方位键和TAB键使输入进入此控件
        /// 通过响应WM_GETDLGCODE消息，应用程序可以把他当成一个特殊的输入控件并能处理它
        /// </summary>
        WM_GETDLGCODE = 0x0087,
        WM_SYNCPAINT = 0x0088,
        /// <summary>
        /// 当光标在一个窗口的非客户区内移动时发送此消息给这个窗口 
        /// 非客户区为：窗体的标题栏及窗的边框体
        /// </summary>
        WM_NCMOUSEMOVE = 0x00A0,
        /// <summary>
        /// 当光标在一个窗口的非客户区同时按下鼠标左键时提交此消息
        /// </summary>
        WM_NCLBUTTONDOWN = 0x00A1,
        /// <summary>
        /// 当用户释放鼠标左键同时光标某个窗口在非客户区十发送此消息；
        /// </summary>
        WM_NCLBUTTONUP = 0x00A2,
        /// <summary>
        /// 当用户双击鼠标左键同时光标某个窗口在非客户区十发送此消息
        /// </summary>
        WM_NCLBUTTONDBLCLK = 0x00A3,
        /// <summary>
        /// 当用户按下鼠标右键同时光标又在窗口的非客户区时发送此消息
        /// </summary>
        WM_NCRBUTTONDOWN = 0x00A4,
        /// <summary>
        /// 当用户释放鼠标右键同时光标又在窗口的非客户区时发送此消息
        /// </summary>
        WM_NCRBUTTONUP = 0x00A5,
        /// <summary>
        /// 当用户双击鼠标右键同时光标某个窗口在非客户区十发送此消息
        /// </summary>
        WM_NCRBUTTONDBLCLK = 0x00A6,
        /// <summary>
        /// 当用户按下鼠标中键同时光标又在窗口的非客户区时发送此消息
        /// </summary>
        WM_NCMBUTTONDOWN = 0x00A7,
        /// <summary>
        /// 当用户释放鼠标中键同时光标又在窗口的非客户区时发送此消息
        /// </summary>
        WM_NCMBUTTONUP = 0x00A8,
        /// <summary>
        /// 当用户双击鼠标中键同时光标又在窗口的非客户区时发送此消息
        /// </summary>
        WM_NCMBUTTONDBLCLK = 0x00A9,
        WM_NCXBUTTONDOWN = 0x00AB,
        WM_NCXBUTTONUP = 0x00AC,
        WM_NCXBUTTONDBLCLK = 0x00AD,
        WM_INPUT = 0x00FF,
        WM_KEYFIRST = 0x0100,
        /// <summary>
        /// 按下一个键
        /// </summary>
        WM_KEYDOWN = 0x0100,
        /// <summary>
        /// 释放一个键
        /// </summary>
        WM_KEYUP = 0x0101,
        /// <summary>
        /// 按下某键，并已发出WM_KEYDOWN，WM_KEYUP消息
        /// </summary>
        WM_CHAR = 0x0102,
        /// <summary>
        /// 当用translatemessage函数翻译WM_KEYUP消息时发送此消息给拥有焦点的窗口
        /// </summary>
        WM_DEADCHAR = 0x0103,
        /// <summary>
        /// 当用户按住ALT键同时按下其它键时提交此消息给拥有焦点的窗口；
        /// </summary>
        WM_SYSKEYDOWN = 0x0104,
        /// <summary>
        /// 当用户释放一个键同时ALT 键还按着时提交此消息给拥有焦点的窗口
        /// </summary>
        WM_SYSKEYUP = 0x0105,
        /// <summary>
        /// 当WM_SYSKEYDOWN消息被TRANSLATEMESSAGE函数翻译后提交此消息给拥有焦点的窗口
        /// </summary>
        WM_SYSCHAR = 0x0106,
        /// <summary>
        /// 当WM_SYSKEYDOWN消息被TRANSLATEMESSAGE函数翻译后发送此消息给拥有焦点的窗口
        /// </summary>
        WM_SYSDEADCHAR = 0x0107,
        WM_UNICHAR = 0x0109,
        WM_KEYLAST_NT501 = 0x0109,
        UNICODE_NOCHAR = 0xFFFF,
        WM_KEYLAST_PRE501 = 0x0108,
        WM_IME_STARTCOMPOSITION = 0x010D,
        WM_IME_ENDCOMPOSITION = 0x010E,
        WM_IME_COMPOSITION = 0x010F,
        WM_IME_KEYLAST = 0x010F,
        /// <summary>
        /// 在一个对话框程序被显示前发送此消息给它，通常用此消息初始化控件和执行其它任务
        /// </summary>
        WM_INITDIALOG = 0x0110,
        /// <summary>
        /// 当用户选择一条菜单命令项或当某个控件发送一条消息给它的父窗口，一个快捷键被翻译
        /// </summary>
        WM_COMMAND = 0x0111,
        /// <summary>
        /// 当用户选择窗口菜单的一条命令或当用户选择最大化或最小化时那个窗口会收到此消息
        /// </summary>
        WM_SYSCOMMAND = 0x0112,
        /// <summary>
        /// 发生了定时器事件
        /// </summary>
        WM_TIMER = 0x0113,
        /// <summary>
        /// 当一个窗口标准水平滚动条产生一个滚动事件时发送此消息给那个窗口，也发送给拥有它的控件
        /// </summary>
        WM_HSCROLL = 0x0114,
        /// <summary>
        /// 当一个窗口标准垂直滚动条产生一个滚动事件时发送此消息给那个窗口，也发送给拥有它的控件
        /// </summary>
        WM_VSCROLL = 0x0115,
        /// <summary>
        /// 当一个菜单将要被激活时发送此消息，它发生在用户菜单条中的某项或按下某个菜单键，它允许程序在显示前更改菜单
        /// </summary>
        WM_INITMENU = 0x0116,
        /// <summary>
        /// 当一个下拉菜单或子菜单将要被激活时发送此消息，它允许程序在它显示前更改菜单，而不要改变全部
        /// </summary>
        WM_INITMENUPOPUP = 0x0117,
        /// <summary>
        /// 当用户选择一条菜单项时发送此消息给菜单的所有者（一般是窗口）
        /// </summary>
        WM_MENUSELECT = 0x011F,
        /// <summary>
        /// 当菜单已被激活用户按下了某个键（不同于加速键），发送此消息给菜单的所有者；
        /// </summary>
        WM_MENUCHAR = 0x0120,
        /// <summary>
        /// 当一个模态对话框或菜单进入空载状态时发送此消息给它的所有者，一个模态对话框或菜单进入空载状态就是在处理完一条或几条先前的消息后没有消息它的列队中等待
        /// </summary>
        WM_ENTERIDLE = 0x0121,
        WM_MENURBUTTONUP = 0x0122,
        WM_MENUDRAG = 0x0123,
        WM_MENUGETOBJECT = 0x0124,
        WM_UNINITMENUPOPUP = 0x0125,
        WM_MENUCOMMAND = 0x0126,
        WM_CHANGEUISTATE = 0x0127,
        WM_UPDATEUISTATE = 0x0128,
        WM_QUERYUISTATE = 0x0129,
        /// <summary>
        /// 在windows绘制消息框前发送此消息给消息框的所有者窗口
        /// 通过响应这条消息，所有者窗口可以通过使用给定的相关显示设备的句柄来设置消息框的文本和背景颜色
        /// </summary>
        WM_CTLCOLORMSGBOX = 0x0132,
        /// <summary>
        /// 当一个编辑型控件将要被绘制时发送此消息给它的父窗口
        /// 通过响应这条消息，所有者窗口可以通过使用给定的相关显示设备的句柄来设置编辑框的文本和背景颜色
        /// </summary>
        WM_CTLCOLOREDIT = 0x0133,
        /// <summary>
        /// 当一个列表框控件将要被绘制前发送此消息给它的父窗口
        /// 通过响应这条消息，所有者窗口可以通过使用给定的相关显示设备的句柄来设置列表框的文本和背景颜色
        /// </summary>
        WM_CTLCOLORLISTBOX = 0x0134,
        /// <summary>
        /// 当一个按钮控件将要被绘制时发送此消息给它的父窗口
        /// 通过响应这条消息，所有者窗口可以通过使用给定的相关显示设备的句柄来设置按纽的文本和背景颜色
        /// </summary>
        WM_CTLCOLORBTN = 0x0135,
        /// <summary>
        /// 当一个对话框控件将要被绘制前发送此消息给它的父窗口
        /// 通过响应这条消息，所有者窗口可以通过使用给定的相关显示设备的句柄来设置对话框的文本背景颜色
        /// </summary>
        WM_CTLCOLORDLG = 0x0136,
        /// <summary>
        /// 当一个滚动条控件将要被绘制时发送此消息给它的父窗口
        /// 通过响应这条消息，所有者窗口可以通过使用给定的相关显示设备的句柄来设置滚动条的背景颜色
        /// </summary>
        WM_CTLCOLORSCROLLBAR = 0x0137,
        /// <summary>
        /// 当一个静态控件将要被绘制时发送此消息给它的父窗口
        /// 通过响应这条消息，所有者窗口可以通过使用给定的相关显示设备的句柄来设置静态控件的文本和背景颜色
        /// </summary>
        WM_CTLCOLORSTATIC = 0x0138,
        WM_MOUSEFIRST = 0x0200,
        /// <summary>
        /// 移动鼠标
        /// </summary>
        WM_MOUSEMOVE = 0x0200,
        /// <summary>
        /// 按下鼠标左键
        /// </summary>
        WM_LBUTTONDOWN = 0x0201,
        /// <summary>
        /// 释放鼠标左键
        /// </summary>
        WM_LBUTTONUP = 0x0202,
        /// <summary>
        /// 双击鼠标左键
        /// </summary>
        WM_LBUTTONDBLCLK = 0x0203,
        /// <summary>
        /// 按下鼠标右键
        /// </summary>
        WM_RBUTTONDOWN = 0x0204,
        /// <summary>
        /// 释放鼠标右键
        /// </summary>
        WM_RBUTTONUP = 0x0205,
        /// <summary>
        /// 双击鼠标右键
        /// </summary>
        WM_RBUTTONDBLCLK = 0x0206,
        /// <summary>
        /// 按下鼠标中键
        /// </summary>
        WM_MBUTTONDOWN = 0x0207,
        /// <summary>
        /// 释放鼠标中键
        /// </summary>
        WM_MBUTTONUP = 0x0208,
        /// <summary>
        /// 双击鼠标中键
        /// </summary>
        WM_MBUTTONDBLCLK = 0x0209,
        /// <summary>
        /// 当鼠标轮子转动时发送此消息个当前有焦点的控件
        /// </summary>
        WM_MOUSEWHEEL = 0x020A,
        WM_XBUTTONDOWN = 0x020B,
        WM_XBUTTONUP = 0x020C,
        WM_XBUTTONDBLCLK = 0x020D,
        WM_MOUSELAST_5 = 0x020D,
        WM_MOUSELAST_4 = 0x020A,
        WM_MOUSELAST_PRE_4 = 0x0209,
        /// <summary>
        /// 当MDI子窗口被创建或被销毁，或用户按了一下鼠标键而光标在子窗口上时发送此消息给它的父窗口
        /// </summary>
        WM_PARENTNOTIFY = 0x0210,
        /// <summary>
        /// 发送此消息通知应用程序的主窗口that已经进入了菜单循环模式
        /// </summary>
        WM_ENTERMENULOOP = 0x0211,
        /// <summary>
        /// 发送此消息通知应用程序的主窗口that已退出了菜单循环模式
        /// </summary>
        WM_EXITMENULOOP = 0x0212,
        WM_NEXTMENU = 0x0213,
        /// <summary>
        /// 当用户正在调整窗口大小时发送此消息给窗口
        /// 通过此消息应用程序可以监视窗口大小和位置也可以修改他们
        /// </summary>
        WM_SIZING = 0x0214,
        /// <summary>
        /// 发送此消息给窗口当它失去捕获的鼠标时；
        /// </summary>
        WM_CAPTURECHANGED = 0x0215,
        /// <summary>
        /// 当用户在移动窗口时发送此消息
        /// 通过此消息应用程序可以监视窗口大小和位置也可以修改他们；
        /// </summary>
        WM_MOVING = 0x0216,
        /// <summary>
        /// 此消息发送给应用程序来通知它有关电源管理事件
        /// </summary>
        WM_POWERBROADCAST = 0x0218,
        /// <summary>
        /// 当设备的硬件配置改变时发送此消息给应用程序或设备驱动程序
        /// </summary>
        WM_DEVICECHANGE = 0x0219,
        /// <summary>
        /// 应用程序发送此消息给多文档的客户窗口来创建一个MDI 子窗口
        /// </summary>
        WM_MDICREATE = 0x0220,
        /// <summary>
        /// 应用程序发送此消息给多文档的客户窗口来关闭一个MDI 子窗口
        /// </summary>
        WM_MDIDESTROY = 0x0221,
        /// <summary>
        /// 应用程序发送此消息给多文档的客户窗口通知客户窗口激活另一个MDI子窗口，当客户窗口收到此消息后，它发出WM_MDIACTIVE消息给MDI子窗口（未激活）激活它；
        /// </summary>
        WM_MDIACTIVATE = 0x0222,
        /// <summary>
        /// 程序发送此消息给MDI客户窗口让子窗口从最大最小化恢复到原来大小
        /// </summary>
        WM_MDIRESTORE = 0x0223,
        /// <summary>
        /// 程序发送此消息给MDI客户窗口激活下一个或前一个窗口
        /// </summary>
        WM_MDINEXT = 0x0224,
        /// <summary>
        /// 程序发送此消息给MDI客户窗口来最大化一个MDI子窗口；
        /// </summary>
        WM_MDIMAXIMIZE = 0x0225,
        /// <summary>
        /// 程序发送此消息给MDI客户窗口以平铺方式重新排列所有MDI子窗口
        /// </summary>
        WM_MDITILE = 0x0226,
        /// <summary>
        /// 程序发送此消息给MDI客户窗口以层叠方式重新排列所有MDI子窗口
        /// </summary>
        WM_MDICASCADE = 0x0227,
        /// <summary>
        /// 程序发送此消息给MDI客户窗口重新排列所有最小化的MDI子窗口
        /// </summary>
        WM_MDIICONARRANGE = 0x0228,
        /// <summary>
        /// 程序发送此消息给MDI客户窗口来找到激活的子窗口的句柄
        /// </summary>
        WM_MDIGETACTIVE = 0x0229,
        /// <summary>
        /// 程序发送此消息给MDI客户窗口用MDI菜单代替子窗口的菜单
        /// </summary>
        WM_MDISETMENU = 0x0230,
        WM_ENTERSIZEMOVE = 0x0231,
        WM_EXITSIZEMOVE = 0x0232,
        WM_DROPFILES = 0x0233,
        WM_MDIREFRESHMENU = 0x0234,
        WM_IME_SETCONTEXT = 0x0281,
        WM_IME_NOTIFY = 0x0282,
        WM_IME_CONTROL = 0x0283,
        WM_IME_COMPOSITIONFULL = 0x0284,
        WM_IME_SELECT = 0x0285,
        WM_IME_CHAR = 0x0286,
        WM_IME_REQUEST = 0x0288,
        WM_IME_KEYDOWN = 0x0290,
        WM_IME_KEYUP = 0x0291,
        WM_MOUSEHOVER = 0x02A1,
        WM_MOUSELEAVE = 0x02A3,
        WM_NCMOUSEHOVER = 0x02A0,
        WM_NCMOUSELEAVE = 0x02A2,
        WM_WTSSESSION_CHANGE = 0x02B1,
        WM_TABLET_FIRST = 0x02c0,
        WM_TABLET_LAST = 0x02df,
        /// <summary>
        /// 程序发送此消息给一个编辑框或combobox来删除当前选择的文本
        /// </summary>
        WM_CUT = 0x0300,
        /// <summary>
        /// 程序发送此消息给一个编辑框或combobox来复制当前选择的文本到剪贴板
        /// </summary>
        WM_COPY = 0x0301,
        /// <summary>
        /// 程序发送此消息给editcontrol或combobox从剪贴板中得到数据
        /// </summary>
        WM_PASTE = 0x0302,
        /// <summary>
        /// 程序发送此消息给editcontrol或combobox清除当前选择的内容；
        /// </summary>
        WM_CLEAR = 0x0303,
        /// <summary>
        /// 程序发送此消息给editcontrol或combobox撤消最后一次操作
        /// </summary>
        WM_UNDO = 0x0304,
        WM_RENDERFORMAT = 0x0305,
        WM_RENDERALLFORMATS = 0x0306,
        /// <summary>
        /// 当调用ENPTYCLIPBOARD函数时发送此消息给剪贴板的所有者
        /// </summary>
        WM_DESTROYCLIPBOARD = 0x0307,
        /// <summary>
        /// 当剪贴板的内容变化时发送此消息给剪贴板观察链的第一个窗口
        /// 它允许用剪贴板观察窗口来显示剪贴板的新内容
        /// </summary>
        WM_DRAWCLIPBOARD = 0x0308,
        /// <summary>
        /// 当剪贴板包含CF_OWNERDIPLAY格式的数据并且剪贴板观察窗口的客户区需要重画
        /// </summary>
        WM_PAINTCLIPBOARD = 0x0309,
        WM_VSCROLLCLIPBOARD = 0x030A,
        /// <summary>
        /// 当剪贴板包含CF_OWNERDIPLAY格式的数据并且剪贴板观察窗口的客户区域的大小已经改变
        /// 此消息通过剪贴板观察窗口发送给剪贴板的所有者
        /// </summary>
        WM_SIZECLIPBOARD = 0x030B,
        /// <summary>
        /// 通过剪贴板观察窗口发送此消息给剪贴板的所有者来请求一个CF_OWNERDISPLAY格式的剪贴板的名字
        /// </summary>
        WM_ASKCBFORMATNAME = 0x030C,
        /// <summary>
        /// 当一个窗口从剪贴板观察链中移去时发送此消息给剪贴板观察链的第一个窗口；
        /// </summary>
        WM_CHANGECBCHAIN = 0x030D,
        /// <summary>
        /// 此消息通过一个剪贴板观察窗口发送给剪贴板的所有者；
        /// 它发生在当剪贴板包含CFOWNERDISPALY格式的数据并且有个事件在剪贴板观察窗的水平滚动条上；
        /// 所有者应滚动剪贴板图象并更新滚动条的值；
        /// </summary>
        WM_HSCROLLCLIPBOARD = 0x030E,
        /// <summary>
        /// 此消息发送给将要收到焦点的窗口，此消息能使窗口在收到焦点时同时有机会实现他的逻辑调色板
        /// </summary>
        WM_QUERYNEWPALETTE = 0x030F,
        /// <summary>
        /// 当一个应用程序正要实现它的逻辑调色板时发此消息通知所有的应用程序
        /// </summary>
        WM_PALETTEISCHANGING = 0x0310,
        /// <summary>
        /// 此消息在一个拥有焦点的窗口实现它的逻辑调色板后发送此消息给所有顶级并重叠的窗口，以此来改变系统调色板
        /// </summary>
        WM_PALETTECHANGED = 0x0311,
        /// <summary>
        /// 当用户按下由REGISTERHOTKEY函数注册的热键时提交此消息
        /// </summary>
        WM_HOTKEY = 0x0312,
        /// <summary>
        /// 应用程序发送此消息仅当WINDOWS或其它应用程序发出一个请求要求绘制一个应用程序的一部分；
        /// </summary>
        WM_PRINT = 0x0317,
        WM_PRINTCLIENT = 0x0318,
        WM_APPCOMMAND = 0x0319,
        WM_THEMECHANGED = 0x031A,
        WM_HANDHELDFIRST = 0x0358,
        WM_HANDHELDLAST = 0x035F,
        WM_AFXFIRST = 0x0360,
        WM_AFXLAST = 0x037F,
        WM_PENWINFIRST = 0x0380,
        WM_PENWINLAST = 0x038F,
        WM_APP = 0x8000,
        /// <summary>
        /// 此消息能帮助应用程序自定义私有消息；
        /// </summary>
        WM_USER = 0x0400,
        EM_GETSEL = 0x00B0,
        EM_SETSEL = 0x00B1,
        EM_GETRECT = 0x00B2,
        EM_SETRECT = 0x00B3,
        EM_SETRECTNP = 0x00B4,
        EM_SCROLL = 0x00B5,
        EM_LINESCROLL = 0x00B6,
        EM_SCROLLCARET = 0x00B7,
        EM_GETMODIFY = 0x00B8,
        EM_SETMODIFY = 0x00B9,
        EM_GETLINECOUNT = 0x00BA,
        EM_LINEINDEX = 0x00BB,
        EM_SETHANDLE = 0x00BC,
        EM_GETHANDLE = 0x00BD,
        EM_GETTHUMB = 0x00BE,
        EM_LINELENGTH = 0x00C1,
        EM_REPLACESEL = 0x00C2,
        EM_GETLINE = 0x00C4,
        EM_LIMITTEXT = 0x00C5,
        EM_CANUNDO = 0x00C6,
        EM_UNDO = 0x00C7,
        EM_FMTLINES = 0x00C8,
        EM_LINEFROMCHAR = 0x00C9,
        EM_SETTABSTOPS = 0x00CB,
        EM_SETPASSWORDCHAR = 0x00CC,
        EM_EMPTYUNDOBUFFER = 0x00CD,
        EM_GETFIRSTVISIBLELINE = 0x00CE,
        EM_SETREADONLY = 0x00CF,
        EM_SETWORDBREAKPROC = 0x00D0,
        EM_GETWORDBREAKPROC = 0x00D1,
        EM_GETPASSWORDCHAR = 0x00D2,
        EM_SETMARGINS = 0x00D3,
        EM_GETMARGINS = 0x00D4,
        EM_SETLIMITTEXT = EM_LIMITTEXT,
        EM_GETLIMITTEXT = 0x00D5,
        EM_POSFROMCHAR = 0x00D6,
        EM_CHARFROMPOS = 0x00D7,
        EM_SETIMESTATUS = 0x00D8,
        EM_GETIMESTATUS = 0x00D9,
        BM_GETCHECK = 0x00F0,
        BM_SETCHECK = 0x00F1,
        BM_GETSTATE = 0x00F2,
        BM_SETSTATE = 0x00F3,
        BM_SETSTYLE = 0x00F4,
        BM_CLICK = 0x00F5,
        BM_GETIMAGE = 0x00F6,
        BM_SETIMAGE = 0x00F7,
        STM_SETICON = 0x0170,
        STM_GETICON = 0x0171,
        STM_SETIMAGE = 0x0172,
        STM_GETIMAGE = 0x0173,
        STM_MSGMAX = 0x0174,
        DM_GETDEFID = (WM_USER + 0),
        DM_SETDEFID = (WM_USER + 1),
        DM_REPOSITION = (WM_USER + 2),
        LB_ADDSTRING = 0x0180,
        LB_INSERTSTRING = 0x0181,
        LB_DELETESTRING = 0x0182,
        LB_SELITEMRANGEEX = 0x0183,
        LB_RESETCONTENT = 0x0184,
        LB_SETSEL = 0x0185,
        LB_SETCURSEL = 0x0186,
        LB_GETSEL = 0x0187,
        LB_GETCURSEL = 0x0188,
        LB_GETTEXT = 0x0189,
        LB_GETTEXTLEN = 0x018A,
        LB_GETCOUNT = 0x018B,
        LB_SELECTSTRING = 0x018C,
        LB_DIR = 0x018D,
        LB_GETTOPINDEX = 0x018E,
        LB_FINDSTRING = 0x018F,
        LB_GETSELCOUNT = 0x0190,
        LB_GETSELITEMS = 0x0191,
        LB_SETTABSTOPS = 0x0192,
        LB_GETHORIZONTALEXTENT = 0x0193,
        LB_SETHORIZONTALEXTENT = 0x0194,
        LB_SETCOLUMNWIDTH = 0x0195,
        LB_ADDFILE = 0x0196,
        LB_SETTOPINDEX = 0x0197,
        LB_GETITEMRECT = 0x0198,
        LB_GETITEMDATA = 0x0199,
        LB_SETITEMDATA = 0x019A,
        LB_SELITEMRANGE = 0x019B,
        LB_SETANCHORINDEX = 0x019C,
        LB_GETANCHORINDEX = 0x019D,
        LB_SETCARETINDEX = 0x019E,
        LB_GETCARETINDEX = 0x019F,
        LB_SETITEMHEIGHT = 0x01A0,
        LB_GETITEMHEIGHT = 0x01A1,
        LB_FINDSTRINGEXACT = 0x01A2,
        LB_SETLOCALE = 0x01A5,
        LB_GETLOCALE = 0x01A6,
        LB_SETCOUNT = 0x01A7,
        LB_INITSTORAGE = 0x01A8,
        LB_ITEMFROMPOINT = 0x01A9,
        LB_MULTIPLEADDSTRING = 0x01B1,
        LB_GETLISTBOXINFO = 0x01B2,
        LB_MSGMAX_501 = 0x01B3,
        LB_MSGMAX_WCE4 = 0x01B1,
        LB_MSGMAX_4 = 0x01B0,
        LB_MSGMAX_PRE4 = 0x01A8,
        CB_GETEDITSEL = 0x0140,
        CB_LIMITTEXT = 0x0141,
        CB_SETEDITSEL = 0x0142,
        CB_ADDSTRING = 0x0143,
        CB_DELETESTRING = 0x0144,
        CB_DIR = 0x0145,
        CB_GETCOUNT = 0x0146,
        CB_GETCURSEL = 0x0147,
        CB_GETLBTEXT = 0x0148,
        CB_GETLBTEXTLEN = 0x0149,
        CB_INSERTSTRING = 0x014A,
        CB_RESETCONTENT = 0x014B,
        CB_FINDSTRING = 0x014C,
        CB_SELECTSTRING = 0x014D,
        CB_SETCURSEL = 0x014E,
        CB_SHOWDROPDOWN = 0x014F,
        CB_GETITEMDATA = 0x0150,
        CB_SETITEMDATA = 0x0151,
        CB_GETDROPPEDCONTROLRECT = 0x0152,
        CB_SETITEMHEIGHT = 0x0153,
        CB_GETITEMHEIGHT = 0x0154,
        CB_SETEXTENDEDUI = 0x0155,
        CB_GETEXTENDEDUI = 0x0156,
        CB_GETDROPPEDSTATE = 0x0157,
        CB_FINDSTRINGEXACT = 0x0158,
        CB_SETLOCALE = 0x0159,
        CB_GETLOCALE = 0x015A,
        CB_GETTOPINDEX = 0x015B,
        CB_SETTOPINDEX = 0x015C,
        CB_GETHORIZONTALEXTENT = 0x015d,
        CB_SETHORIZONTALEXTENT = 0x015e,
        CB_GETDROPPEDWIDTH = 0x015f,
        CB_SETDROPPEDWIDTH = 0x0160,
        CB_INITSTORAGE = 0x0161,
        CB_MULTIPLEADDSTRING = 0x0163,
        CB_GETCOMBOBOXINFO = 0x0164,
        CB_MSGMAX_501 = 0x0165,
        CB_MSGMAX_WCE400 = 0x0163,
        CB_MSGMAX_400 = 0x0162,
        CB_MSGMAX_PRE400 = 0x015B,
        SBM_SETPOS = 0x00E0,
        SBM_GETPOS = 0x00E1,
        SBM_SETRANGE = 0x00E2,
        SBM_SETRANGEREDRAW = 0x00E6,
        SBM_GETRANGE = 0x00E3,
        SBM_ENABLE_ARROWS = 0x00E4,
        SBM_SETSCROLLINFO = 0x00E9,
        SBM_GETSCROLLINFO = 0x00EA,
        SBM_GETSCROLLBARINFO = 0x00EB,
        LVM_FIRST = 0x1000,// ListView messages
        TV_FIRST = 0x1100,// TreeView messages
        HDM_FIRST = 0x1200,// Header messages
        TCM_FIRST = 0x1300,// Tab control messages
        PGM_FIRST = 0x1400,// Pager control messages
        ECM_FIRST = 0x1500,// Edit control messages
        BCM_FIRST = 0x1600,// Button control messages
        CBM_FIRST = 0x1700,// Combobox control messages
        CCM_FIRST = 0x2000,// Common control shared messages
        CCM_LAST = (CCM_FIRST + 0x200),
        CCM_SETBKCOLOR = (CCM_FIRST + 1),
        CCM_SETCOLORSCHEME = (CCM_FIRST + 2),
        CCM_GETCOLORSCHEME = (CCM_FIRST + 3),
        CCM_GETDROPTARGET = (CCM_FIRST + 4),
        CCM_SETUNICODEFORMAT = (CCM_FIRST + 5),
        CCM_GETUNICODEFORMAT = (CCM_FIRST + 6),
        CCM_SETVERSION = (CCM_FIRST + 0x7),
        CCM_GETVERSION = (CCM_FIRST + 0x8),
        CCM_SETNOTIFYWINDOW = (CCM_FIRST + 0x9),
        CCM_SETWINDOWTHEME = (CCM_FIRST + 0xb),
        CCM_DPISCALE = (CCM_FIRST + 0xc),
        HDM_GETITEMCOUNT = (HDM_FIRST + 0),
        HDM_INSERTITEMA = (HDM_FIRST + 1),
        HDM_INSERTITEMW = (HDM_FIRST + 10),
        HDM_DELETEITEM = (HDM_FIRST + 2),
        HDM_GETITEMA = (HDM_FIRST + 3),
        HDM_GETITEMW = (HDM_FIRST + 11),
        HDM_SETITEMA = (HDM_FIRST + 4),
        HDM_SETITEMW = (HDM_FIRST + 12),
        HDM_LAYOUT = (HDM_FIRST + 5),
        HDM_HITTEST = (HDM_FIRST + 6),
        HDM_GETITEMRECT = (HDM_FIRST + 7),
        HDM_SETIMAGELIST = (HDM_FIRST + 8),
        HDM_GETIMAGELIST = (HDM_FIRST + 9),
        HDM_ORDERTOINDEX = (HDM_FIRST + 15),
        HDM_CREATEDRAGIMAGE = (HDM_FIRST + 16),
        HDM_GETORDERARRAY = (HDM_FIRST + 17),
        HDM_SETORDERARRAY = (HDM_FIRST + 18),
        HDM_SETHOTDIVIDER = (HDM_FIRST + 19),
        HDM_SETBITMAPMARGIN = (HDM_FIRST + 20),
        HDM_GETBITMAPMARGIN = (HDM_FIRST + 21),
        HDM_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT,
        HDM_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT,
        HDM_SETFILTERCHANGETIMEOUT = (HDM_FIRST + 22),
        HDM_EDITFILTER = (HDM_FIRST + 23),
        HDM_CLEARFILTER = (HDM_FIRST + 24),
        TB_ENABLEBUTTON = (WM_USER + 1),
        TB_CHECKBUTTON = (WM_USER + 2),
        TB_PRESSBUTTON = (WM_USER + 3),
        TB_HIDEBUTTON = (WM_USER + 4),
        TB_INDETERMINATE = (WM_USER + 5),
        TB_MARKBUTTON = (WM_USER + 6),
        TB_ISBUTTONENABLED = (WM_USER + 9),
        TB_ISBUTTONCHECKED = (WM_USER + 10),
        TB_ISBUTTONPRESSED = (WM_USER + 11),
        TB_ISBUTTONHIDDEN = (WM_USER + 12),
        TB_ISBUTTONINDETERMINATE = (WM_USER + 13),
        TB_ISBUTTONHIGHLIGHTED = (WM_USER + 14),
        TB_SETSTATE = (WM_USER + 17),
        TB_GETSTATE = (WM_USER + 18),
        TB_ADDBITMAP = (WM_USER + 19),
        TB_ADDBUTTONSA = (WM_USER + 20),
        TB_INSERTBUTTONA = (WM_USER + 21),
        TB_ADDBUTTONS = (WM_USER + 20),
        TB_INSERTBUTTON = (WM_USER + 21),
        TB_DELETEBUTTON = (WM_USER + 22),
        TB_GETBUTTON = (WM_USER + 23),
        TB_BUTTONCOUNT = (WM_USER + 24),
        TB_COMMANDTOINDEX = (WM_USER + 25),
        TB_SAVERESTOREA = (WM_USER + 26),
        TB_SAVERESTOREW = (WM_USER + 76),
        TB_CUSTOMIZE = (WM_USER + 27),
        TB_ADDSTRINGA = (WM_USER + 28),
        TB_ADDSTRINGW = (WM_USER + 77),
        TB_GETITEMRECT = (WM_USER + 29),
        TB_BUTTONSTRUCTSIZE = (WM_USER + 30),
        TB_SETBUTTONSIZE = (WM_USER + 31),
        TB_SETBITMAPSIZE = (WM_USER + 32),
        TB_AUTOSIZE = (WM_USER + 33),
        TB_GETTOOLTIPS = (WM_USER + 35),
        TB_SETTOOLTIPS = (WM_USER + 36),
        TB_SETPARENT = (WM_USER + 37),
        TB_SETROWS = (WM_USER + 39),
        TB_GETROWS = (WM_USER + 40),
        TB_SETCMDID = (WM_USER + 42),
        TB_CHANGEBITMAP = (WM_USER + 43),
        TB_GETBITMAP = (WM_USER + 44),
        TB_GETBUTTONTEXTA = (WM_USER + 45),
        TB_GETBUTTONTEXTW = (WM_USER + 75),
        TB_REPLACEBITMAP = (WM_USER + 46),
        TB_SETINDENT = (WM_USER + 47),
        TB_SETIMAGELIST = (WM_USER + 48),
        TB_GETIMAGELIST = (WM_USER + 49),
        TB_LOADIMAGES = (WM_USER + 50),
        TB_GETRECT = (WM_USER + 51),
        TB_SETHOTIMAGELIST = (WM_USER + 52),
        TB_GETHOTIMAGELIST = (WM_USER + 53),
        TB_SETDISABLEDIMAGELIST = (WM_USER + 54),
        TB_GETDISABLEDIMAGELIST = (WM_USER + 55),
        TB_SETSTYLE = (WM_USER + 56),
        TB_GETSTYLE = (WM_USER + 57),
        TB_GETBUTTONSIZE = (WM_USER + 58),
        TB_SETBUTTONWIDTH = (WM_USER + 59),
        TB_SETMAXTEXTROWS = (WM_USER + 60),
        TB_GETTEXTROWS = (WM_USER + 61),
        TB_GETOBJECT = (WM_USER + 62),
        TB_GETHOTITEM = (WM_USER + 71),
        TB_SETHOTITEM = (WM_USER + 72),
        TB_SETANCHORHIGHLIGHT = (WM_USER + 73),
        TB_GETANCHORHIGHLIGHT = (WM_USER + 74),
        TB_MAPACCELERATORA = (WM_USER + 78),
        TB_GETINSERTMARK = (WM_USER + 79),
        TB_SETINSERTMARK = (WM_USER + 80),
        TB_INSERTMARKHITTEST = (WM_USER + 81),
        TB_MOVEBUTTON = (WM_USER + 82),
        TB_GETMAXSIZE = (WM_USER + 83),
        TB_SETEXTENDEDSTYLE = (WM_USER + 84),
        TB_GETEXTENDEDSTYLE = (WM_USER + 85),
        TB_GETPADDING = (WM_USER + 86),
        TB_SETPADDING = (WM_USER + 87),
        TB_SETINSERTMARKCOLOR = (WM_USER + 88),
        TB_GETINSERTMARKCOLOR = (WM_USER + 89),
        TB_SETCOLORSCHEME = CCM_SETCOLORSCHEME,
        TB_GETCOLORSCHEME = CCM_GETCOLORSCHEME,
        TB_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT,
        TB_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT,
        TB_MAPACCELERATORW = (WM_USER + 90),
        TB_GETBITMAPFLAGS = (WM_USER + 41),
        TB_GETBUTTONINFOW = (WM_USER + 63),
        TB_SETBUTTONINFOW = (WM_USER + 64),
        TB_GETBUTTONINFOA = (WM_USER + 65),
        TB_SETBUTTONINFOA = (WM_USER + 66),
        TB_INSERTBUTTONW = (WM_USER + 67),
        TB_ADDBUTTONSW = (WM_USER + 68),
        TB_HITTEST = (WM_USER + 69),
        TB_SETDRAWTEXTFLAGS = (WM_USER + 70),
        TB_GETSTRINGW = (WM_USER + 91),
        TB_GETSTRINGA = (WM_USER + 92),
        TB_GETMETRICS = (WM_USER + 101),
        TB_SETMETRICS = (WM_USER + 102),
        TB_SETWINDOWTHEME = CCM_SETWINDOWTHEME,
        RB_INSERTBANDA = (WM_USER + 1),
        RB_DELETEBAND = (WM_USER + 2),
        RB_GETBARINFO = (WM_USER + 3),
        RB_SETBARINFO = (WM_USER + 4),
        RB_GETBANDINFO = (WM_USER + 5),
        RB_SETBANDINFOA = (WM_USER + 6),
        RB_SETPARENT = (WM_USER + 7),
        RB_HITTEST = (WM_USER + 8),
        RB_GETRECT = (WM_USER + 9),
        RB_INSERTBANDW = (WM_USER + 10),
        RB_SETBANDINFOW = (WM_USER + 11),
        RB_GETBANDCOUNT = (WM_USER + 12),
        RB_GETROWCOUNT = (WM_USER + 13),
        RB_GETROWHEIGHT = (WM_USER + 14),
        RB_IDTOINDEX = (WM_USER + 16),
        RB_GETTOOLTIPS = (WM_USER + 17),
        RB_SETTOOLTIPS = (WM_USER + 18),
        RB_SETBKCOLOR = (WM_USER + 19),
        RB_GETBKCOLOR = (WM_USER + 20),
        RB_SETTEXTCOLOR = (WM_USER + 21),
        RB_GETTEXTCOLOR = (WM_USER + 22),
        RB_SIZETORECT = (WM_USER + 23),
        RB_SETCOLORSCHEME = CCM_SETCOLORSCHEME,
        RB_GETCOLORSCHEME = CCM_GETCOLORSCHEME,
        RB_BEGINDRAG = (WM_USER + 24),
        RB_ENDDRAG = (WM_USER + 25),
        RB_DRAGMOVE = (WM_USER + 26),
        RB_GETBARHEIGHT = (WM_USER + 27),
        RB_GETBANDINFOW = (WM_USER + 28),
        RB_GETBANDINFOA = (WM_USER + 29),
        RB_MINIMIZEBAND = (WM_USER + 30),
        RB_MAXIMIZEBAND = (WM_USER + 31),
        RB_GETDROPTARGET = (CCM_GETDROPTARGET),
        RB_GETBANDBORDERS = (WM_USER + 34),
        RB_SHOWBAND = (WM_USER + 35),
        RB_SETPALETTE = (WM_USER + 37),
        RB_GETPALETTE = (WM_USER + 38),
        RB_MOVEBAND = (WM_USER + 39),
        RB_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT,
        RB_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT,
        RB_GETBANDMARGINS = (WM_USER + 40),
        RB_SETWINDOWTHEME = CCM_SETWINDOWTHEME,
        RB_PUSHCHEVRON = (WM_USER + 43),
        TTM_ACTIVATE = (WM_USER + 1),
        TTM_SETDELAYTIME = (WM_USER + 3),
        TTM_ADDTOOLA = (WM_USER + 4),
        TTM_ADDTOOLW = (WM_USER + 50),
        TTM_DELTOOLA = (WM_USER + 5),
        TTM_DELTOOLW = (WM_USER + 51),
        TTM_NEWTOOLRECTA = (WM_USER + 6),
        TTM_NEWTOOLRECTW = (WM_USER + 52),
        TTM_RELAYEVENT = (WM_USER + 7),
        TTM_GETTOOLINFOA = (WM_USER + 8),
        TTM_GETTOOLINFOW = (WM_USER + 53),
        TTM_SETTOOLINFOA = (WM_USER + 9),
        TTM_SETTOOLINFOW = (WM_USER + 54),
        TTM_HITTESTA = (WM_USER + 10),
        TTM_HITTESTW = (WM_USER + 55),
        TTM_GETTEXTA = (WM_USER + 11),
        TTM_GETTEXTW = (WM_USER + 56),
        TTM_UPDATETIPTEXTA = (WM_USER + 12),
        TTM_UPDATETIPTEXTW = (WM_USER + 57),
        TTM_GETTOOLCOUNT = (WM_USER + 13),
        TTM_ENUMTOOLSA = (WM_USER + 14),
        TTM_ENUMTOOLSW = (WM_USER + 58),
        TTM_GETCURRENTTOOLA = (WM_USER + 15),
        TTM_GETCURRENTTOOLW = (WM_USER + 59),
        TTM_WINDOWFROMPOINT = (WM_USER + 16),
        TTM_TRACKACTIVATE = (WM_USER + 17),
        TTM_TRACKPOSITION = (WM_USER + 18),
        TTM_SETTIPBKCOLOR = (WM_USER + 19),
        TTM_SETTIPTEXTCOLOR = (WM_USER + 20),
        TTM_GETDELAYTIME = (WM_USER + 21),
        TTM_GETTIPBKCOLOR = (WM_USER + 22),
        TTM_GETTIPTEXTCOLOR = (WM_USER + 23),
        TTM_SETMAXTIPWIDTH = (WM_USER + 24),
        TTM_GETMAXTIPWIDTH = (WM_USER + 25),
        TTM_SETMARGIN = (WM_USER + 26),
        TTM_GETMARGIN = (WM_USER + 27),
        TTM_POP = (WM_USER + 28),
        TTM_UPDATE = (WM_USER + 29),
        TTM_GETBUBBLESIZE = (WM_USER + 30),
        TTM_ADJUSTRECT = (WM_USER + 31),
        TTM_SETTITLEA = (WM_USER + 32),
        TTM_SETTITLEW = (WM_USER + 33),
        TTM_POPUP = (WM_USER + 34),
        TTM_GETTITLE = (WM_USER + 35),
        TTM_SETWINDOWTHEME = CCM_SETWINDOWTHEME,
        SB_SETTEXTA = (WM_USER + 1),
        SB_SETTEXTW = (WM_USER + 11),
        SB_GETTEXTA = (WM_USER + 2),
        SB_GETTEXTW = (WM_USER + 13),
        SB_GETTEXTLENGTHA = (WM_USER + 3),
        SB_GETTEXTLENGTHW = (WM_USER + 12),
        SB_SETPARTS = (WM_USER + 4),
        SB_GETPARTS = (WM_USER + 6),
        SB_GETBORDERS = (WM_USER + 7),
        SB_SETMINHEIGHT = (WM_USER + 8),
        SB_SIMPLE = (WM_USER + 9),
        SB_GETRECT = (WM_USER + 10),
        SB_ISSIMPLE = (WM_USER + 14),
        SB_SETICON = (WM_USER + 15),
        SB_SETTIPTEXTA = (WM_USER + 16),
        SB_SETTIPTEXTW = (WM_USER + 17),
        SB_GETTIPTEXTA = (WM_USER + 18),
        SB_GETTIPTEXTW = (WM_USER + 19),
        SB_GETICON = (WM_USER + 20),
        SB_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT,
        SB_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT,
        SB_SETBKCOLOR = CCM_SETBKCOLOR,
        SB_SIMPLEID = 0x00ff,
        TBM_GETPOS = (WM_USER),
        TBM_GETRANGEMIN = (WM_USER + 1),
        TBM_GETRANGEMAX = (WM_USER + 2),
        TBM_GETTIC = (WM_USER + 3),
        TBM_SETTIC = (WM_USER + 4),
        TBM_SETPOS = (WM_USER + 5),
        TBM_SETRANGE = (WM_USER + 6),
        TBM_SETRANGEMIN = (WM_USER + 7),
        TBM_SETRANGEMAX = (WM_USER + 8),
        TBM_CLEARTICS = (WM_USER + 9),
        TBM_SETSEL = (WM_USER + 10),
        TBM_SETSELSTART = (WM_USER + 11),
        TBM_SETSELEND = (WM_USER + 12),
        TBM_GETPTICS = (WM_USER + 14),
        TBM_GETTICPOS = (WM_USER + 15),
        TBM_GETNUMTICS = (WM_USER + 16),
        TBM_GETSELSTART = (WM_USER + 17),
        TBM_GETSELEND = (WM_USER + 18),
        TBM_CLEARSEL = (WM_USER + 19),
        TBM_SETTICFREQ = (WM_USER + 20),
        TBM_SETPAGESIZE = (WM_USER + 21),
        TBM_GETPAGESIZE = (WM_USER + 22),
        TBM_SETLINESIZE = (WM_USER + 23),
        TBM_GETLINESIZE = (WM_USER + 24),
        TBM_GETTHUMBRECT = (WM_USER + 25),
        TBM_GETCHANNELRECT = (WM_USER + 26),
        TBM_SETTHUMBLENGTH = (WM_USER + 27),
        TBM_GETTHUMBLENGTH = (WM_USER + 28),
        TBM_SETTOOLTIPS = (WM_USER + 29),
        TBM_GETTOOLTIPS = (WM_USER + 30),
        TBM_SETTIPSIDE = (WM_USER + 31),
        TBM_SETBUDDY = (WM_USER + 32),
        TBM_GETBUDDY = (WM_USER + 33),
        TBM_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT,
        TBM_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT,
        DL_BEGINDRAG = (WM_USER + 133),
        DL_DRAGGING = (WM_USER + 134),
        DL_DROPPED = (WM_USER + 135),
        DL_CANCELDRAG = (WM_USER + 136),
        UDM_SETRANGE = (WM_USER + 101),
        UDM_GETRANGE = (WM_USER + 102),
        UDM_SETPOS = (WM_USER + 103),
        UDM_GETPOS = (WM_USER + 104),
        UDM_SETBUDDY = (WM_USER + 105),
        UDM_GETBUDDY = (WM_USER + 106),
        UDM_SETACCEL = (WM_USER + 107),
        UDM_GETACCEL = (WM_USER + 108),
        UDM_SETBASE = (WM_USER + 109),
        UDM_GETBASE = (WM_USER + 110),
        UDM_SETRANGE32 = (WM_USER + 111),
        UDM_GETRANGE32 = (WM_USER + 112),
        UDM_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT,
        UDM_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT,
        UDM_SETPOS32 = (WM_USER + 113),
        UDM_GETPOS32 = (WM_USER + 114),
        PBM_SETRANGE = (WM_USER + 1),
        PBM_SETPOS = (WM_USER + 2),
        PBM_DELTAPOS = (WM_USER + 3),
        PBM_SETSTEP = (WM_USER + 4),
        PBM_STEPIT = (WM_USER + 5),
        PBM_SETRANGE32 = (WM_USER + 6),
        PBM_GETRANGE = (WM_USER + 7),
        PBM_GETPOS = (WM_USER + 8),
        PBM_SETBARCOLOR = (WM_USER + 9),
        PBM_SETBKCOLOR = CCM_SETBKCOLOR,
        HKM_SETHOTKEY = (WM_USER + 1),
        HKM_GETHOTKEY = (WM_USER + 2),
        HKM_SETRULES = (WM_USER + 3),
        LVM_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT,
        LVM_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT,
        LVM_GETBKCOLOR = (LVM_FIRST + 0),
        LVM_SETBKCOLOR = (LVM_FIRST + 1),
        LVM_GETIMAGELIST = (LVM_FIRST + 2),
        LVM_SETIMAGELIST = (LVM_FIRST + 3),
        LVM_GETITEMCOUNT = (LVM_FIRST + 4),
        LVM_GETITEMA = (LVM_FIRST + 5),
        LVM_GETITEMW = (LVM_FIRST + 75),
        LVM_SETITEMA = (LVM_FIRST + 6),
        LVM_SETITEMW = (LVM_FIRST + 76),
        LVM_INSERTITEMA = (LVM_FIRST + 7),
        LVM_INSERTITEMW = (LVM_FIRST + 77),
        LVM_DELETEITEM = (LVM_FIRST + 8),
        LVM_DELETEALLITEMS = (LVM_FIRST + 9),
        LVM_GETCALLBACKMASK = (LVM_FIRST + 10),
        LVM_SETCALLBACKMASK = (LVM_FIRST + 11),
        LVM_FINDITEMA = (LVM_FIRST + 13),
        LVM_FINDITEMW = (LVM_FIRST + 83),
        LVM_GETITEMRECT = (LVM_FIRST + 14),
        LVM_SETITEMPOSITION = (LVM_FIRST + 15),
        LVM_GETITEMPOSITION = (LVM_FIRST + 16),
        LVM_GETSTRINGWIDTHA = (LVM_FIRST + 17),
        LVM_GETSTRINGWIDTHW = (LVM_FIRST + 87),
        LVM_HITTEST = (LVM_FIRST + 18),
        LVM_ENSUREVISIBLE = (LVM_FIRST + 19),
        LVM_SCROLL = (LVM_FIRST + 20),
        LVM_REDRAWITEMS = (LVM_FIRST + 21),
        LVM_ARRANGE = (LVM_FIRST + 22),
        LVM_EDITLABELA = (LVM_FIRST + 23),
        LVM_EDITLABELW = (LVM_FIRST + 118),
        LVM_GETEDITCONTROL = (LVM_FIRST + 24),
        LVM_GETCOLUMNA = (LVM_FIRST + 25),
        LVM_GETCOLUMNW = (LVM_FIRST + 95),
        LVM_SETCOLUMNA = (LVM_FIRST + 26),
        LVM_SETCOLUMNW = (LVM_FIRST + 96),
        LVM_INSERTCOLUMNA = (LVM_FIRST + 27),
        LVM_INSERTCOLUMNW = (LVM_FIRST + 97),
        LVM_DELETECOLUMN = (LVM_FIRST + 28),
        LVM_GETCOLUMNWIDTH = (LVM_FIRST + 29),
        LVM_SETCOLUMNWIDTH = (LVM_FIRST + 30),
        LVM_CREATEDRAGIMAGE = (LVM_FIRST + 33),
        LVM_GETVIEWRECT = (LVM_FIRST + 34),
        LVM_GETTEXTCOLOR = (LVM_FIRST + 35),
        LVM_SETTEXTCOLOR = (LVM_FIRST + 36),
        LVM_GETTEXTBKCOLOR = (LVM_FIRST + 37),
        LVM_SETTEXTBKCOLOR = (LVM_FIRST + 38),
        LVM_GETTOPINDEX = (LVM_FIRST + 39),
        LVM_GETCOUNTPERPAGE = (LVM_FIRST + 40),
        LVM_GETORIGIN = (LVM_FIRST + 41),
        LVM_UPDATE = (LVM_FIRST + 42),
        LVM_SETITEMSTATE = (LVM_FIRST + 43),
        LVM_GETITEMSTATE = (LVM_FIRST + 44),
        LVM_GETITEMTEXTA = (LVM_FIRST + 45),
        LVM_GETITEMTEXTW = (LVM_FIRST + 115),
        LVM_SETITEMTEXTA = (LVM_FIRST + 46),
        LVM_SETITEMTEXTW = (LVM_FIRST + 116),
        LVM_SETITEMCOUNT = (LVM_FIRST + 47),
        LVM_SORTITEMS = (LVM_FIRST + 48),
        LVM_SETITEMPOSITION32 = (LVM_FIRST + 49),
        LVM_GETSELECTEDCOUNT = (LVM_FIRST + 50),
        LVM_GETITEMSPACING = (LVM_FIRST + 51),
        LVM_GETISEARCHSTRINGA = (LVM_FIRST + 52),
        LVM_GETISEARCHSTRINGW = (LVM_FIRST + 117),
        LVM_SETICONSPACING = (LVM_FIRST + 53),
        LVM_SETEXTENDEDLISTVIEWSTYLE = (LVM_FIRST + 54),
        LVM_GETEXTENDEDLISTVIEWSTYLE = (LVM_FIRST + 55),
        LVM_GETSUBITEMRECT = (LVM_FIRST + 56),
        LVM_SUBITEMHITTEST = (LVM_FIRST + 57),
        LVM_SETCOLUMNORDERARRAY = (LVM_FIRST + 58),
        LVM_GETCOLUMNORDERARRAY = (LVM_FIRST + 59),
        LVM_SETHOTITEM = (LVM_FIRST + 60),
        LVM_GETHOTITEM = (LVM_FIRST + 61),
        LVM_SETHOTCURSOR = (LVM_FIRST + 62),
        LVM_GETHOTCURSOR = (LVM_FIRST + 63),
        LVM_APPROXIMATEVIEWRECT = (LVM_FIRST + 64),
        LVM_SETWORKAREAS = (LVM_FIRST + 65),
        LVM_GETWORKAREAS = (LVM_FIRST + 70),
        LVM_GETNUMBEROFWORKAREAS = (LVM_FIRST + 73),
        LVM_GETSELECTIONMARK = (LVM_FIRST + 66),
        LVM_SETSELECTIONMARK = (LVM_FIRST + 67),
        LVM_SETHOVERTIME = (LVM_FIRST + 71),
        LVM_GETHOVERTIME = (LVM_FIRST + 72),
        LVM_SETTOOLTIPS = (LVM_FIRST + 74),
        LVM_GETTOOLTIPS = (LVM_FIRST + 78),
        LVM_SORTITEMSEX = (LVM_FIRST + 81),
        LVM_SETBKIMAGEA = (LVM_FIRST + 68),
        LVM_SETBKIMAGEW = (LVM_FIRST + 138),
        LVM_GETBKIMAGEA = (LVM_FIRST + 69),
        LVM_GETBKIMAGEW = (LVM_FIRST + 139),
        LVM_SETSELECTEDCOLUMN = (LVM_FIRST + 140),
        LVM_SETTILEWIDTH = (LVM_FIRST + 141),
        LVM_SETVIEW = (LVM_FIRST + 142),
        LVM_GETVIEW = (LVM_FIRST + 143),
        LVM_INSERTGROUP = (LVM_FIRST + 145),
        LVM_SETGROUPINFO = (LVM_FIRST + 147),
        LVM_GETGROUPINFO = (LVM_FIRST + 149),
        LVM_REMOVEGROUP = (LVM_FIRST + 150),
        LVM_MOVEGROUP = (LVM_FIRST + 151),
        LVM_MOVEITEMTOGROUP = (LVM_FIRST + 154),
        LVM_SETGROUPMETRICS = (LVM_FIRST + 155),
        LVM_GETGROUPMETRICS = (LVM_FIRST + 156),
        LVM_ENABLEGROUPVIEW = (LVM_FIRST + 157),
        LVM_SORTGROUPS = (LVM_FIRST + 158),
        LVM_INSERTGROUPSORTED = (LVM_FIRST + 159),
        LVM_REMOVEALLGROUPS = (LVM_FIRST + 160),
        LVM_HASGROUP = (LVM_FIRST + 161),
        LVM_SETTILEVIEWINFO = (LVM_FIRST + 162),
        LVM_GETTILEVIEWINFO = (LVM_FIRST + 163),
        LVM_SETTILEINFO = (LVM_FIRST + 164),
        LVM_GETTILEINFO = (LVM_FIRST + 165),
        LVM_SETINSERTMARK = (LVM_FIRST + 166),
        LVM_GETINSERTMARK = (LVM_FIRST + 167),
        LVM_INSERTMARKHITTEST = (LVM_FIRST + 168),
        LVM_GETINSERTMARKRECT = (LVM_FIRST + 169),
        LVM_SETINSERTMARKCOLOR = (LVM_FIRST + 170),
        LVM_GETINSERTMARKCOLOR = (LVM_FIRST + 171),
        LVM_SETINFOTIP = (LVM_FIRST + 173),
        LVM_GETSELECTEDCOLUMN = (LVM_FIRST + 174),
        LVM_ISGROUPVIEWENABLED = (LVM_FIRST + 175),
        LVM_GETOUTLINECOLOR = (LVM_FIRST + 176),
        LVM_SETOUTLINECOLOR = (LVM_FIRST + 177),
        LVM_CANCELEDITLABEL = (LVM_FIRST + 179),
        LVM_MAPINDEXTOID = (LVM_FIRST + 180),
        LVM_MAPIDTOINDEX = (LVM_FIRST + 181),
        TVM_INSERTITEMA = (TV_FIRST + 0),
        TVM_INSERTITEMW = (TV_FIRST + 50),
        TVM_DELETEITEM = (TV_FIRST + 1),
        TVM_EXPAND = (TV_FIRST + 2),
        TVM_GETITEMRECT = (TV_FIRST + 4),
        TVM_GETCOUNT = (TV_FIRST + 5),
        TVM_GETINDENT = (TV_FIRST + 6),
        TVM_SETINDENT = (TV_FIRST + 7),
        TVM_GETIMAGELIST = (TV_FIRST + 8),
        TVM_SETIMAGELIST = (TV_FIRST + 9),
        TVM_GETNEXTITEM = (TV_FIRST + 10),
        TVM_SELECTITEM = (TV_FIRST + 11),
        TVM_GETITEMA = (TV_FIRST + 12),
        TVM_GETITEMW = (TV_FIRST + 62),
        TVM_SETITEMA = (TV_FIRST + 13),
        TVM_SETITEMW = (TV_FIRST + 63),
        TVM_EDITLABELA = (TV_FIRST + 14),
        TVM_EDITLABELW = (TV_FIRST + 65),
        TVM_GETEDITCONTROL = (TV_FIRST + 15),
        TVM_GETVISIBLECOUNT = (TV_FIRST + 16),
        TVM_HITTEST = (TV_FIRST + 17),
        TVM_CREATEDRAGIMAGE = (TV_FIRST + 18),
        TVM_SORTCHILDREN = (TV_FIRST + 19),
        TVM_ENSUREVISIBLE = (TV_FIRST + 20),
        TVM_SORTCHILDRENCB = (TV_FIRST + 21),
        TVM_ENDEDITLABELNOW = (TV_FIRST + 22),
        TVM_GETISEARCHSTRINGA = (TV_FIRST + 23),
        TVM_GETISEARCHSTRINGW = (TV_FIRST + 64),
        TVM_SETTOOLTIPS = (TV_FIRST + 24),
        TVM_GETTOOLTIPS = (TV_FIRST + 25),
        TVM_SETINSERTMARK = (TV_FIRST + 26),
        TVM_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT,
        TVM_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT,
        TVM_SETITEMHEIGHT = (TV_FIRST + 27),
        TVM_GETITEMHEIGHT = (TV_FIRST + 28),
        TVM_SETBKCOLOR = (TV_FIRST + 29),
        TVM_SETTEXTCOLOR = (TV_FIRST + 30),
        TVM_GETBKCOLOR = (TV_FIRST + 31),
        TVM_GETTEXTCOLOR = (TV_FIRST + 32),
        TVM_SETSCROLLTIME = (TV_FIRST + 33),
        TVM_GETSCROLLTIME = (TV_FIRST + 34),
        TVM_SETINSERTMARKCOLOR = (TV_FIRST + 37),
        TVM_GETINSERTMARKCOLOR = (TV_FIRST + 38),
        TVM_GETITEMSTATE = (TV_FIRST + 39),
        TVM_SETLINECOLOR = (TV_FIRST + 40),
        TVM_GETLINECOLOR = (TV_FIRST + 41),
        TVM_MAPACCIDTOHTREEITEM = (TV_FIRST + 42),
        TVM_MAPHTREEITEMTOACCID = (TV_FIRST + 43),
        CBEM_INSERTITEMA = (WM_USER + 1),
        CBEM_SETIMAGELIST = (WM_USER + 2),
        CBEM_GETIMAGELIST = (WM_USER + 3),
        CBEM_GETITEMA = (WM_USER + 4),
        CBEM_SETITEMA = (WM_USER + 5),
        CBEM_DELETEITEM = CB_DELETESTRING,
        CBEM_GETCOMBOCONTROL = (WM_USER + 6),
        CBEM_GETEDITCONTROL = (WM_USER + 7),
        CBEM_SETEXTENDEDSTYLE = (WM_USER + 14),
        CBEM_GETEXTENDEDSTYLE = (WM_USER + 9),
        CBEM_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT,
        CBEM_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT,
        CBEM_SETEXSTYLE = (WM_USER + 8),
        CBEM_GETEXSTYLE = (WM_USER + 9),
        CBEM_HASEDITCHANGED = (WM_USER + 10),
        CBEM_INSERTITEMW = (WM_USER + 11),
        CBEM_SETITEMW = (WM_USER + 12),
        CBEM_GETITEMW = (WM_USER + 13),
        TCM_GETIMAGELIST = (TCM_FIRST + 2),
        TCM_SETIMAGELIST = (TCM_FIRST + 3),
        TCM_GETITEMCOUNT = (TCM_FIRST + 4),
        TCM_GETITEMA = (TCM_FIRST + 5),
        TCM_GETITEMW = (TCM_FIRST + 60),
        TCM_SETITEMA = (TCM_FIRST + 6),
        TCM_SETITEMW = (TCM_FIRST + 61),
        TCM_INSERTITEMA = (TCM_FIRST + 7),
        TCM_INSERTITEMW = (TCM_FIRST + 62),
        TCM_DELETEITEM = (TCM_FIRST + 8),
        TCM_DELETEALLITEMS = (TCM_FIRST + 9),
        TCM_GETITEMRECT = (TCM_FIRST + 10),
        TCM_GETCURSEL = (TCM_FIRST + 11),
        TCM_SETCURSEL = (TCM_FIRST + 12),
        TCM_HITTEST = (TCM_FIRST + 13),
        TCM_SETITEMEXTRA = (TCM_FIRST + 14),
        TCM_ADJUSTRECT = (TCM_FIRST + 40),
        TCM_SETITEMSIZE = (TCM_FIRST + 41),
        TCM_REMOVEIMAGE = (TCM_FIRST + 42),
        TCM_SETPADDING = (TCM_FIRST + 43),
        TCM_GETROWCOUNT = (TCM_FIRST + 44),
        TCM_GETTOOLTIPS = (TCM_FIRST + 45),
        TCM_SETTOOLTIPS = (TCM_FIRST + 46),
        TCM_GETCURFOCUS = (TCM_FIRST + 47),
        TCM_SETCURFOCUS = (TCM_FIRST + 48),
        TCM_SETMINTABWIDTH = (TCM_FIRST + 49),
        TCM_DESELECTALL = (TCM_FIRST + 50),
        TCM_HIGHLIGHTITEM = (TCM_FIRST + 51),
        TCM_SETEXTENDEDSTYLE = (TCM_FIRST + 52),
        TCM_GETEXTENDEDSTYLE = (TCM_FIRST + 53),
        TCM_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT,
        TCM_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT,
        ACM_OPENA = (WM_USER + 100),
        ACM_OPENW = (WM_USER + 103),
        ACM_PLAY = (WM_USER + 101),
        ACM_STOP = (WM_USER + 102),
        MCM_FIRST = 0x1000,
        MCM_GETCURSEL = (MCM_FIRST + 1),
        MCM_SETCURSEL = (MCM_FIRST + 2),
        MCM_GETMAXSELCOUNT = (MCM_FIRST + 3),
        MCM_SETMAXSELCOUNT = (MCM_FIRST + 4),
        MCM_GETSELRANGE = (MCM_FIRST + 5),
        MCM_SETSELRANGE = (MCM_FIRST + 6),
        MCM_GETMONTHRANGE = (MCM_FIRST + 7),
        MCM_SETDAYSTATE = (MCM_FIRST + 8),
        MCM_GETMINREQRECT = (MCM_FIRST + 9),
        MCM_SETCOLOR = (MCM_FIRST + 10),
        MCM_GETCOLOR = (MCM_FIRST + 11),
        MCM_SETTODAY = (MCM_FIRST + 12),
        MCM_GETTODAY = (MCM_FIRST + 13),
        MCM_HITTEST = (MCM_FIRST + 14),
        MCM_SETFIRSTDAYOFWEEK = (MCM_FIRST + 15),
        MCM_GETFIRSTDAYOFWEEK = (MCM_FIRST + 16),
        MCM_GETRANGE = (MCM_FIRST + 17),
        MCM_SETRANGE = (MCM_FIRST + 18),
        MCM_GETMONTHDELTA = (MCM_FIRST + 19),
        MCM_SETMONTHDELTA = (MCM_FIRST + 20),
        MCM_GETMAXTODAYWIDTH = (MCM_FIRST + 21),
        MCM_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT,
        MCM_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT,
        DTM_FIRST = 0x1000,
        DTM_GETSYSTEMTIME = (DTM_FIRST + 1),
        DTM_SETSYSTEMTIME = (DTM_FIRST + 2),
        DTM_GETRANGE = (DTM_FIRST + 3),
        DTM_SETRANGE = (DTM_FIRST + 4),
        DTM_SETFORMATA = (DTM_FIRST + 5),
        DTM_SETFORMATW = (DTM_FIRST + 50),
        DTM_SETMCCOLOR = (DTM_FIRST + 6),
        DTM_GETMCCOLOR = (DTM_FIRST + 7),
        DTM_GETMONTHCAL = (DTM_FIRST + 8),
        DTM_SETMCFONT = (DTM_FIRST + 9),
        DTM_GETMCFONT = (DTM_FIRST + 10),
        PGM_SETCHILD = (PGM_FIRST + 1),
        PGM_RECALCSIZE = (PGM_FIRST + 2),
        PGM_FORWARDMOUSE = (PGM_FIRST + 3),
        PGM_SETBKCOLOR = (PGM_FIRST + 4),
        PGM_GETBKCOLOR = (PGM_FIRST + 5),
        PGM_SETBORDER = (PGM_FIRST + 6),
        PGM_GETBORDER = (PGM_FIRST + 7),
        PGM_SETPOS = (PGM_FIRST + 8),
        PGM_GETPOS = (PGM_FIRST + 9),
        PGM_SETBUTTONSIZE = (PGM_FIRST + 10),
        PGM_GETBUTTONSIZE = (PGM_FIRST + 11),
        PGM_GETBUTTONSTATE = (PGM_FIRST + 12),
        PGM_GETDROPTARGET = CCM_GETDROPTARGET,
        BCM_GETIDEALSIZE = (BCM_FIRST + 0x0001),
        BCM_SETIMAGELIST = (BCM_FIRST + 0x0002),
        BCM_GETIMAGELIST = (BCM_FIRST + 0x0003),
        BCM_SETTEXTMARGIN = (BCM_FIRST + 0x0004),
        BCM_GETTEXTMARGIN = (BCM_FIRST + 0x0005),
        EM_SETCUEBANNER = (ECM_FIRST + 1),
        EM_GETCUEBANNER = (ECM_FIRST + 2),
        EM_SHOWBALLOONTIP = (ECM_FIRST + 3),
        EM_HIDEBALLOONTIP = (ECM_FIRST + 4),
        CB_SETMINVISIBLE = (CBM_FIRST + 1),
        CB_GETMINVISIBLE = (CBM_FIRST + 2),
        LM_HITTEST = (WM_USER + 0x300),
        LM_GETIDEALHEIGHT = (WM_USER + 0x301),
        LM_SETITEM = (WM_USER + 0x302),
        LM_GETITEM = (WM_USER + 0x303)
    }
	
	internal enum WinMessageFlags
    {
        Null = 0x0000,
        /// <summary>
        /// 创建窗口
        /// </summary>
        Create = 0x0001,
        /// <summary>
        /// 窗口被销毁
        /// </summary>
        Destroy = 0x0002,
        /// <summary>
        /// 移动窗口
        /// </summary>
        Move = 0x0003,
        /// <summary>
        /// 改变窗口大小
        /// </summary>
        Size = 0x0005,
        /// <summary>
        /// 窗口被激活或失去激活状态
        /// </summary>
        Activate = 0x0006,
        /// <summary>
        /// 获取焦点之后
        /// </summary>
        SetFocus = 0x0007,
        /// <summary>
        /// 失去焦点
        /// </summary>
        KillFocus = 0x0008,
        /// <summary>
        /// 可用状态改变
        /// </summary>
        Enable = 0x000A,
        /// <summary>
        /// 设置窗口是否重绘
        /// </summary>
        SetRedraw = 0x000B,
        /// <summary>
        /// 设置窗口文本
        /// </summary>
        SetText = 0x000C,
        /// <summary>
        /// 复制对应窗口的文本到缓冲区
        /// </summary>
        GetText = 0x000D,
        /// <summary>
        /// 获取窗口相关文本的长度
        /// </summary>
        GetTextlength = 0x000E,
        /// <summary>
        /// 窗口重绘
        /// </summary>
        Paint = 0x000F,
        /// <summary>
        /// 窗口要关闭时发送一个信号
        /// </summary>
        Close = 0x0010,
        /// <summary>
        /// 用户选择结束对话框或调用ExitWindow函数
        /// </summary>
        QueryEndSession = 0x0011,
        /// <summary>
        /// 结束程序运行或调用postquitmessage函数
        /// </summary>
        Quit = 0x0012,
        /// <summary>
        /// 当用户窗口恢复以前的大小位置时，发送此消息给某个图标
        /// </summary>
        QueryOpen = 0x0013,
        /// <summary>
        /// 当窗口背景必须被擦除时（例在窗口改变大小时）
        /// </summary>
        Erasebkgnd = 0x0014,
        /// <summary>
        /// 系统颜色改变时，发送给所有顶级窗口
        /// </summary>
        SysColorChange = 0x0015,
        /// <summary>
        /// 系统进程发出WM_QUERYENDSESSION消息后，此消息发送给应用程序
        /// </summary>
        EndSession = 0x0016,
        /// <summary>
        /// 显示或隐藏窗口
        /// </summary>
        ShowWindow = 0x0018,
        /// <summary>
        /// 控件绘制
        /// </summary>
        CtlColor = 0x0019,
        /// <summary>
        /// win.ini已文件更改
        /// </summary>
        WinIniChange = 0x001A,
        /// <summary>
        /// 程序修改了SystemParametersInfo设置
        /// </summary>
        SettingChange = 0x001A,
        /// <summary>
        /// 更改设备模式设置
        /// </summary>
        DevModeChange = 0x001B,
        /// <summary>
        /// 发送此消息给应用程序哪个窗口激活，哪个非激活
        /// </summary>
        ActivateApp = 0x001C,
        /// <summary>
        /// 系统的字体资源库变化时，发送此消息给所有顶级窗口
        /// </summary>
        FontChange = 0x001D,
        /// <summary>
        /// 系统时间变化时，发送此消息给所有顶级窗口
        /// </summary>
        TimeChange = 0x001E,
        /// <summary>
        /// 发送此消息来取消某种正在进行的模态（操作）
        /// </summary>
        CancelMode = 0x001F,
        /// <summary>
        /// 如果鼠标引起光标在某个窗口中移动且鼠标输入没有被捕获时，发送消息给某个窗口
        /// </summary>
        SetCursor = 0x0020,
        /// <summary>
        /// 当光标在某非激活的窗口中而用户正按着鼠标的某个键，发送此消息给某个窗口
        /// </summary>
        MouseActivate = 0x0021,
        /// <summary>
        /// 用户点击此窗口的标题栏时，发送此消息给MDI子窗口；或当窗口被激活，移动，改变大小
        /// </summary>
        ChildActivate = 0x0022,
        /// <summary>
        /// 此消息基于计算机的训练程序发送，通过WH_JOURNALPALYBACK的hook程序
        /// </summary>
        QueueSync = 0x0023,
        /// <summary>
        /// 窗口将要改变大小或位置
        /// </summary>
        GetMinMaxInfo = 0x0024,
        /// <summary>
        /// 图标将要被重绘时，发送给最小化窗口
        /// </summary>
        PaintIcon = 0x0026,
        /// <summary>
        /// 发送此消息给某最小化窗口，仅当它在画图标前背景必须被重绘
        /// </summary>
        IconErasebkgnd = 0x0027,
        /// <summary>
        /// 发送此消息给一个对话框去更改焦点位置
        /// </summary>
        NextDlgctl = 0x0028,
        /// <summary>
        /// 打印管理队列增加或减少一条作业
        /// </summary>
        SpoolerStatus = 0x002A,
        /// <summary>
        /// 控件可视外观改变
        /// </summary>
        DrawItem = 0x002B,
        /// <summary>
        /// 控件被创建
        /// </summary>
        MeasureItem = 0x002C,
        /// <summary>
        /// 控件被销毁
        /// </summary>
        DeleteItem = 0x002D,
        /// <summary>
        /// LBS_WANTKEYBOARDINPUT风格的发出给它的所有者来响应WM_KEYDOWN消息
        /// </summary>
        VkeytoItem = 0x002E,
        /// <summary>
        /// LBS_WANTKEYBOARDINPUT风格的发出给它的所有者来响应WM_CHAR消息
        /// </summary>
        ChartoItem = 0x002F,
        /// <summary>
        /// 设置控件绘制文本的字体
        /// </summary>
        SetFont = 0x0030,
        /// <summary>
        /// 得到控件绘制文本的字体
        /// </summary>
        GetFont = 0x0031,
        /// <summary>
        /// 设置热键关联
        /// </summary>
        SetHotkey = 0x0032,
        /// <summary>
        /// 判断是否有热键关联
        /// </summary>
        GetHotkey = 0x0033,
        /// <summary>
        /// 窗口被拖放时，返回一个图标或句柄
        /// </summary>
        QueryDragIcon = 0x0037,
        /// <summary>
        /// 判断ComboBox或ListBox新增项的相对位置
        /// </summary>
        CompareItem = 0x0039,
        /// <summary>
        /// 
        /// </summary>
        GetObject = 0x003D,
        /// <summary>
        /// 内存已经很少了
        /// </summary>
        Compacting = 0x0041,
        /// <summary>
        /// 通讯设备驱动的串口事件发生时
        /// </summary>
        CommNotify = 0x0044,
        /// <summary>
        /// 窗口位置或大小将要改变
        /// </summary>
        WindowPosChanging = 0x0046,
        /// <summary>
        /// 窗口位置或大小已改变
        /// </summary>
        WindowPosChanged = 0x0047,
        /// <summary>
        /// 系统将要暂停
        /// </summary>
        Power = 0x0048,
        /// <summary>
        /// 程序传递数据给另一程序
        /// </summary>
        CopyData = 0x004A,
        /// <summary>
        /// 用户取消程序日志激活状态
        /// </summary>
        CancelJournal = 0x004B,
        /// <summary>
        /// 某控件发送事件或控件需要一些信息
        /// </summary>
        Notify = 0x004E,
        /// <summary>
        /// 用户选择某种输入语言，或输入语言的热键改变
        /// </summary>
        InputLangChangeRequest = 0x0050,
        /// <summary>
        /// 输入语言改变时，发送给顶级窗口
        /// </summary>
        InputLangChange = 0x0051,
        /// <summary>
        /// 初始化windows帮助例程
        /// </summary>
        Tcard = 0x0052,
        /// <summary>
        /// 按下F1
        /// </summary>
        Help = 0x0053,
        /// <summary>
        /// 用户登入或退出
        /// </summary>
        UserChanged = 0x0054,
        /// <summary>
        /// 判断控件是使用ANSI或UNICODE
        /// </summary>
        NotifyFormat = 0x0055,
        /// <summary>
        /// 右键
        /// </summary>
        ContextMenu = 0x007B,
        /// <summary>
        /// 窗口风格将要改变
        /// </summary>
        StyleChanging = 0x007C,
        /// <summary>
        /// 窗口风格已改变
        /// </summary>
        StyleChanged = 0x007D,
        /// <summary>
        /// 显示器分辨率调整
        /// </summary>
        DisplayChange = 0x007E,
        /// <summary>
        /// 返回窗口关联图标的句柄
        /// </summary>
        GetIcon = 0x007F,
        /// <summary>
        /// 设置窗口关联图标
        /// </summary>
        SetIcon = 0x0080,
        /// <summary>
        /// 窗口被首次创建（在WM_CREATE前发送）
        /// </summary>
        NcCreate = 0x0081,
        /// <summary>
        /// 非客户区正在销毁
        /// </summary>
        NcDestroy = 0x0082,
        /// <summary>
        /// 窗口客户区大小被计算
        /// </summary>
        NcCalcSize = 0x0083,
        /// <summary>
        /// 移动，按住或释放鼠标
        /// </summary>
        NcHittest = 0x0084,
        /// <summary>
        /// 窗口框架须重绘
        /// </summary>
        NcPaint = 0x0085,
        /// <summary>
        /// 客户区被改变来显示激活或非激活状态
        /// </summary>
        NcActivate = 0x0086,
        /// <summary>
        /// 方向键和Tab键消息进入关联控件
        /// </summary>
        GetDlgCode = 0x0087,
        /// <summary>
        /// 
        /// </summary>
        SyncPaint = 0x0088,
        /// <summary>
        /// 光标在标题栏和边框上移动
        /// </summary>
        NcMouseMove = 0x00A0,
        /// <summary>
        /// 在标题栏和边框上按下鼠标左键
        /// </summary>
        NcLButtonDown = 0x00A1,
        /// <summary>
        /// 在标题栏和边框上释放鼠标左键
        /// </summary>
        NcLButtonUp = 0x00A2,
        /// <summary>
        /// 在标题栏和边框上双击鼠标左键
        /// </summary>
        NcLButtonDbllk = 0x00A3,
        /// <summary>
        /// 在标题栏和边框上按下鼠标右键
        /// </summary>
        NcRButtonDown = 0x00A4,
        /// <summary>
        /// 在标题栏和边框上释放鼠标右键
        /// </summary>
        NcRButtonUp = 0x00A5,
        /// <summary>
        /// 在标题栏和边框上双击鼠标右键
        /// </summary>
        NcRButtonDblclk = 0x00A6,
        /// <summary>
        /// 在标题栏和边框上按下鼠标滚轮
        /// </summary>
        NcMButtonDown = 0x00A7,
        /// <summary>
        /// 在标题栏和边框上释放鼠标滚轮
        /// </summary>
        NcMButtonUp = 0x00A8,
        /// <summary>
        /// 在标题栏和边框上双击鼠标滚轮
        /// </summary>
        NcMButtonDblclk = 0x00A9,
        /// <summary>
        /// 按下某键
        /// </summary>
        KeyDown = 0x0100,
        /// <summary>
        /// 释放某键
        /// </summary>
        KeyUp = 0x0101,
        /// <summary>
        /// 按下某键，并发出WM_KETDOWN和WM_KEYUP
        /// </summary>
        Char = 0x0102,
        /// <summary>
        /// 使用translatemessage函数翻译WM_KEYDOWN
        /// </summary>
        DeadChar = 0x0103,
        /// <summary>
        /// 按住Alt，同时按下其他键
        /// </summary>
        SysKeyDown = 0x0104,
        /// <summary>
        /// 按住Alt，同时释放其他键
        /// </summary>
        SysKeyUp = 0x0105,
        /// <summary>
        /// 按住Alt，按下某键，并发出WM_KETDOWN和WM_KEYUP
        /// </summary>
        SysChar = 0x0106,
        /// <summary>
        /// 使用translatemessage函数翻译WM_SYSKEYDOWN
        /// </summary>
        SysDeadChar = 0x0107,
        /// <summary>
        /// IME准备组合按键
        /// </summary>
        ImeStartComposition = 0x010D,
        /// <summary>
        /// IME完成组合键
        /// </summary>
        ImeEndComposition = 0x010E,
        /// <summary>
        /// IME根据击键情况更改按键组合状态
        /// </summary>
        ImeComposition = 0x010F,
        ImeKeyLast = 0x010F,
        /// <summary>
        /// 对话框被显示前，常用于初始化控件
        /// </summary>
        InitDialog = 0x0110,
        /// <summary>
        /// 菜单命令项或快捷键
        /// </summary>
        Command = 0x0111,
        /// <summary>
        /// 选择窗口菜单的命令或最小化，最大化窗口
        /// </summary>
        SysCommand = 0x0112,
        /// <summary>
        /// 发生了定时器
        /// </summary>
        Timer = 0x0113,
        /// <summary>
        /// 水平滚动
        /// </summary>
        Hscroll = 0x0114,
        /// <summary>
        /// 竖直滚动
        /// </summary>
        Vscroll = 0x0115,
        /// <summary>
        /// 菜单将要被激活，按下菜单项或快捷键，允许在显示前改变菜单
        /// </summary>
        InitMenu = 0x0116,
        /// <summary>
        /// 下拉菜单将要被激活，允许在显示前改变菜单
        /// </summary>
        InitMenuPopup = 0x0117,
        Gesture = 0x0119,
        GestureNotify = 0x011A,
        /// <summary>
        /// 选中菜单项
        /// </summary>
        MenuSelect = 0x011F,
        /// <summary>
        /// 按下快捷键
        /// </summary>
        MenuChar = 0x0120,
        /// <summary>
        /// 模态窗口或菜单空载
        /// </summary>
        EnterIdle = 0x0121,
        /// <summary>
        /// 
        /// </summary>
        MenuRButtonUp = 0x0122,
        /// <summary>
        /// 菜单拖拽
        /// </summary>
        MenuDrag = 0x0123,
        /// <summary>
        /// 鼠标进入或离开菜单时，本消息发送给支持施放菜单的拥有者
        /// </summary>
        MenuGetObject = 0x0124,
        /// <summary>
        /// 下拉菜单销毁
        /// </summary>
        UninitMenuPopup = 0x0125,
        /// <summary>
        /// 选中菜单项
        /// </summary>
        MenuCommand = 0x0126,
        /// <summary>
        /// 设置消息框的文本和背景颜色
        /// </summary>
        CtlColorWinMsgBox = 0x0132,
        /// <summary>
        /// 设置编辑控件的文本和背景颜色
        /// </summary>
        CtlColorEdit = 0x0133,
        /// <summary>
        /// 设置列表框控件的文本和背景颜色
        /// </summary>
        CtlColorListbox = 0x0134,
        /// <summary>
        /// 设置按钮控件的文本和背景颜色
        /// </summary>
        CtlColorBtn = 0x0135,
        /// <summary>
        /// 设置对话框的文本和背景颜色
        /// </summary>
        CtlColorDlg = 0x0136,
        /// <summary>
        /// 设置滚动条的背景颜色
        /// </summary>
        CtlColorScrollbar = 0x0137,
        /// <summary>
        /// 设置静态控件的文本和背景颜色
        /// </summary>
        CtlColorStatic = 0x0138,
        /// <summary>
        /// 移动鼠标
        /// </summary>
        MouseMove = 0x0200,
        /// <summary>
        /// 按下鼠标左键
        /// </summary>
        LButtonDown = 0x0201,
        /// <summary>
        /// 释放鼠标左键
        /// </summary>
        LButtonUp = 0x0202,
        /// <summary>
        /// 双击鼠标左键
        /// </summary>
        LButtonDblclk = 0x0203,
        /// <summary>
        /// 按下鼠标右键
        /// </summary>
        RButtonDown = 0x0204,
        /// <summary>
        /// 释放鼠标右键
        /// </summary>
        RButtonUp = 0x0205,
        /// <summary>
        /// 双击鼠标右键
        /// </summary>
        RButtonDblclk = 0x0206,
        /// <summary>
        /// 按下鼠标滚轮
        /// </summary>
        MButtonDown = 0x0207,
        /// <summary>
        /// 释放鼠标滚轮
        /// </summary>
        MButtonUp = 0x0208,
        /// <summary>
        /// 双击鼠标滚轮
        /// </summary>
        MButtonDblclk = 0x0209,
        /// <summary>
        /// 滚动鼠标滚轮
        /// </summary>
        MouseWheel = 0x020A,
        /// <summary>
        /// MDI子窗口被创建或销毁；用户在子窗口上按下鼠标
        /// </summary>
        ParentNotify = 0x0210,
        /// <summary>
        /// 主窗口进入菜单循环模式
        /// </summary>
        EnterMenuLoop = 0x0211,
        /// <summary>
        /// 主窗口退出菜单循环模式
        /// </summary>
        ExitMenuLoop = 0x0212,
        /// <summary>
        /// 
        /// </summary>
        NextMenu = 0x0213,
        /// <summary>
        /// 改变窗口大小
        /// </summary>
        Sizing = 0x0214,
        /// <summary>
        /// 窗口失去捕获的鼠标
        /// </summary>
        CaptureChanged = 0x0215,
        /// <summary>
        /// 移动窗口
        /// </summary>
        Moving = 0x0216,
        /// <summary>
        /// 硬件配置改变
        /// </summary>
        DeviceChange = 0x0219,
        /// <summary>
        /// 创建MDI子窗口
        /// </summary>
        MdiCreate = 0x0220,
        /// <summary>
        /// 关闭MDI子窗口
        /// </summary>
        MdiDestroy = 0x0221,
        /// <summary>
        /// 激活MDI子窗口
        /// </summary>
        MdiActivate = 0x0222,
        /// <summary>
        /// MDI窗口恢复原来大小
        /// </summary>
        MdiRestore = 0x0223,
        /// <summary>
        /// 激活下一个或前一个MDI子窗口
        /// </summary>
        MdiNext = 0x0224,
        /// <summary>
        /// MDI子窗口最大化
        /// </summary>
        MdiMaximize = 0x0225,
        /// <summary>
        /// 平铺排列所有MDI子窗口
        /// </summary>
        MdiTile = 0x0226,
        /// <summary>
        /// 层叠排列所有MDI子窗口
        /// </summary>
        MdiCascade = 0x0227,
        /// <summary>
        /// 重新排列所有最小化MDI子窗口
        /// </summary>
        MdiIconArrange = 0x0228,
        /// <summary>
        /// 找到激活MDI子窗口的句柄
        /// </summary>
        MdiGetActive = 0x0229,
        /// <summary>
        /// 用MID菜单代替子窗口的菜单
        /// </summary>
        MdiSetMenu = 0x0230,
        /// <summary>
        /// 窗口进入移动或调整大小的模式循环
        /// </summary>
        EnterSizeMove = 0x0231,
        /// <summary>
        /// 窗口完成移动或调整大小
        /// </summary>
        ExitSizeMove = 0x0232,
        /// <summary>
        /// 鼠标拖拽的放下时
        /// </summary>
        DropFiles = 0x0233,
        /// <summary>
        /// 更新MDI框架窗口的菜单
        /// </summary>
        MdiRefreshMenu = 0x0234,
        Touch = 0x0240,
        PointerCaptureChanged = 0x024C,
        /// <summary>
        /// 窗口激活时，发送输入法相关消息
        /// </summary>
        ImeSetContext = 0x0281,
        /// <summary>
        /// 通知关于IME窗口状态的常规改变
        /// </summary>
        ImeNotify = 0x0282,
        /// <summary>
        /// 改变字母组合窗口的位置
        /// </summary>
        ImeControl = 0x0283,
        /// <summary>
        /// 用户接口窗口不能增加编码窗口尺寸时，
        /// </summary>
        ImeCompositionFull = 0x0284,
        /// <summary>
        /// 系统当前输入法更改
        /// </summary>
        ImeSelect = 0x0285,
        /// <summary>
        /// 输入法输入文字
        /// </summary>
        ImeChar = 0x0286,
        /// <summary>
        /// 请求输入法
        /// </summary>
        ImeRequest = 0x0288,
        /// <summary>
        /// 输入法窗口按键
        /// </summary>
        ImeKeydown = 0x0290,
        /// <summary>
        /// 输入法窗口释放按键
        /// </summary>
        ImeKeyup = 0x0291,
        /// <summary>
        /// 鼠标移过控件
        /// </summary>
        MouseHover = 0x02A1,
        /// <summary>
        /// 鼠标离开控件
        /// </summary>
        MouseLeave = 0x02A3,
        TabletDefBase = 0x02C0,
        TabletQuerySystemGestureStatus = TabletDefBase + 12,
        /// <summary>
        /// 剪切当前编辑控件的文本
        /// </summary>
        Cut = 0x0300,
        /// <summary>
        /// 复制当前编辑控件的文本
        /// </summary>
        Copy = 0x0301,
        /// <summary>
        /// 粘贴到当前编辑控件的文本
        /// </summary>
        Paste = 0x0302,
        /// <summary>
        /// 清空当前编辑控件的文本
        /// </summary>
        Clear = 0x0303,
        /// <summary>
        /// 撤销当前编辑控件的最后一次操作
        /// </summary>
        Undo = 0x0304,
        /// <summary>
        /// 程序需要系统剪切板数据
        /// </summary>
        RenderFormat = 0x0305,
        /// <summary>
        /// 程序退出时，要求提供所有格式的剪切板数据，避免数据丢失
        /// </summary>
        RenderAllFormats = 0x0306,
        /// <summary>
        /// 调用ENPTYCLIPBOARD函数
        /// </summary>
        DestroyClipboard = 0x0307,
        /// <summary>
        /// 
        /// </summary>
        DrawClipboard = 0x0308,
        PaintClipboard = 0x0309,
        VscrollClipboard = 0x030A,
        SizeClipboard = 0x030B,
        AskcbFormatName = 0x030C,
        /// <summary>
        /// 剪切板观察链的第一个窗口改变
        /// </summary>
        ChangeCbChain = 0x030D,
        HscrollClipboard = 0x030E,
        /// <summary>
        /// 发送给将要获取焦点的窗口，有机会实现窗口的逻辑调色板
        /// </summary>
        QueryNewPalette = 0x030F,
        /// <summary>
        /// 程序正要实现它的逻辑调色板
        /// </summary>
        PaletteisChanging = 0x0310,
        /// <summary>
        /// 程序已实现它的逻辑调色板，发送给所有顶级并重叠的窗口，来改变系统调色板
        /// </summary>
        PaletteChanged = 0x0311,
        /// <summary>
        /// 按下已注册的热键
        /// </summary>
        Hotkey = 0x0312,
        /// <summary>
        /// 当Windows或其他程序发出绘制请求
        /// </summary>
        Print = 0x0317,
        PrintClient = 0x0318,
        HandHeldFirst = 0x0358,
        HandHeldLast = 0x035F,
        AfxFirst = 0x0360,
        AfxLast = 0x037F,
        PenWinFirst = 0x0380,
        PenWinLast = 0x038F,
        App = 0x8000,
        User = 0x0400,
        Reflect = User + 0x1c00
    }
}
