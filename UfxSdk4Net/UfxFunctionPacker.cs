
using System;
using hundsun.t2sdk;

namespace QuantBox.XApi
{
    /// <summary>
    /// 功能号: 10000
    /// 功能名称: 心跳功能,该功能用于刷新令牌活跃时间,以避免令牌过期.
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx10000 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 10000;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        public Ufx10000(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 10001
    /// 功能名称: 建立与投资管理系统的连接,UFX系统中做其他操作前必须先进行登陆.
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx10001 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 10001;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="operatorNo">操作员编号(投资系统操作员编号,要求在投资系统的登陆模式或该操作员的登陆模式为操作员编号登陆.)</param>
        /// <param name="password">操作员密码</param>
        /// <param name="macAddress">登录机器MAC地址(MAC信息要输入标准的12位,否则站点控制不生效)</param>
        /// <param name="ipAddress">登录机器IP地址</param>
        /// <param name="opStation">登录站点</param>
        /// <param name="authorizationId">开发者授权编号(联系恒生获取.(注:现已经接入的系统请于2014年12月31号前获取授权并完成程序更新.联系方式:o3kffb@hundsun.com))</param>
        public Ufx10001(string operatorNo, string password, string macAddress, string ipAddress, string opStation, string authorizationId)
        {
            OperatorNo = operatorNo;
            Password = password;
            MacAddress = macAddress;
            IpAddress = ipAddress;
            OpStation = opStation;
            AuthorizationId = authorizationId;
        }

        private string _operatorNo;
        private bool _operatorNoChanged;
        /// <summary>
        /// 操作员编号(投资系统操作员编号,要求在投资系统的登陆模式或该操作员的登陆模式为操作员编号登陆.)
        /// </summary>
        public string OperatorNo
        {
            get => _operatorNo;
            set {
                _operatorNoChanged = true;
                _operatorNo = value;
            }
        }

        private string _password;
        private bool _passwordChanged;
        /// <summary>
        /// 操作员密码
        /// </summary>
        public string Password
        {
            get => _password;
            set {
                _passwordChanged = true;
                _password = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址(MAC信息要输入标准的12位,否则站点控制不生效)
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx10001 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx10001 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }

        private string _authorizationId;
        private bool _authorizationIdChanged;
        /// <summary>
        /// 开发者授权编号(联系恒生获取.(注:现已经接入的系统请于2014年12月31号前获取授权并完成程序更新.联系方式:o3kffb@hundsun.com))
        /// </summary>
        public string AuthorizationId
        {
            get => _authorizationId;
            set {
                _authorizationIdChanged = true;
                _authorizationId = value;
            }
        }

        private string _appId;
        private bool _appIdChanged;
        /// <summary>
        /// 客户端ID(仅对期货终端信息采集有效,通过PB前台获取,请联系管理员)
        /// </summary>
        public string AppId
        {
            get => _appId;
            set {
                _appIdChanged = true;
                _appId = value;
            }
        }
        public Ufx10001 SetAppId(string value)
        {
            AppId = value;
            return this;
        }

        private string _authorizeCode;
        private bool _authorizeCodeChanged;
        /// <summary>
        /// 终端授权码(仅对期货终端信息采集有效,通过PB前台获取,请联系管理员)
        /// </summary>
        public string AuthorizeCode
        {
            get => _authorizeCode;
            set {
                _authorizeCodeChanged = true;
                _authorizeCode = value;
            }
        }
        public Ufx10001 SetAuthorizeCode(string value)
        {
            AuthorizeCode = value;
            return this;
        }

        private int _portId;
        private bool _portIdChanged;
        /// <summary>
        /// 接入端口(仅对期货终端信息采集有效,接入程序的tcp端口)
        /// </summary>
        public int PortId
        {
            get => _portId;
            set {
                _portIdChanged = true;
                _portId = value;
            }
        }
        public Ufx10001 SetPortId(int value)
        {
            PortId = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_operatorNoChanged)
            {
                packer.AddField("operator_no", (sbyte)'S', 16, 4);
            }
            if (_passwordChanged)
            {
                packer.AddField("password", (sbyte)'S', 16, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_authorizationIdChanged)
            {
                packer.AddField("authorization_id", (sbyte)'S', 64, 4);
            }
            if (_appIdChanged)
            {
                packer.AddField("app_id", (sbyte)'S', 32, 4);
            }
            if (_authorizeCodeChanged)
            {
                packer.AddField("authorize_code", (sbyte)'S', 16, 4);
            }
            if (_portIdChanged)
            {
                packer.AddField("port_id", (sbyte)'I', 8, 4);
            }
            if (_operatorNoChanged)
            {
                packer.AddStr(_operatorNo);
            }
            if (_passwordChanged)
            {
                packer.AddStr(_password);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            if (_authorizationIdChanged)
            {
                packer.AddStr(_authorizationId);
            }
            if (_appIdChanged)
            {
                packer.AddStr(_appId);
            }
            if (_authorizeCodeChanged)
            {
                packer.AddStr(_authorizeCode);
            }
            if (_portIdChanged)
            {
                packer.AddInt(_portId);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 10002
    /// 功能名称: 断开与UFX服务器的连接,令牌号失效,释放连接数.
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx10002 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 10002;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        public Ufx10002(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 10003
    /// 功能名称: 修改操作员密码
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx10003 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 10003;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="oldPassword">原密码</param>
        /// <param name="newPassword">新密码</param>
        public Ufx10003(string userToken, string oldPassword, string newPassword)
        {
            UserToken = userToken;
            OldPassword = oldPassword;
            NewPassword = newPassword;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _oldPassword;
        private bool _oldPasswordChanged;
        /// <summary>
        /// 原密码
        /// </summary>
        public string OldPassword
        {
            get => _oldPassword;
            set {
                _oldPasswordChanged = true;
                _oldPassword = value;
            }
        }

        private string _newPassword;
        private bool _newPasswordChanged;
        /// <summary>
        /// 新密码
        /// </summary>
        public string NewPassword
        {
            get => _newPassword;
            set {
                _newPasswordChanged = true;
                _newPassword = value;
            }
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_oldPasswordChanged)
            {
                packer.AddField("old_password", (sbyte)'S', 16, 4);
            }
            if (_newPasswordChanged)
            {
                packer.AddField("new_password", (sbyte)'S', 16, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_oldPasswordChanged)
            {
                packer.AddStr(_oldPassword);
            }
            if (_newPasswordChanged)
            {
                packer.AddStr(_newPassword);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 30001
    /// 功能名称: 支持查询登陆操作员有操作权限的有效账户列表
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx30001 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 30001;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        public Ufx30001(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx30001 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 30002
    /// 功能名称: 支持查询登陆操作员有操作权限的资产单元列表
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx30002 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 30002;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        public Ufx30002(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _capitalAccount;
        private bool _capitalAccountChanged;
        /// <summary>
        /// 资金账号(现货,期权资金账号;)
        /// </summary>
        public string CapitalAccount
        {
            get => _capitalAccount;
            set {
                _capitalAccountChanged = true;
                _capitalAccount = value;
            }
        }
        public Ufx30002 SetCapitalAccount(string value)
        {
            CapitalAccount = value;
            return this;
        }

        private string _capitalAccountQh;
        private bool _capitalAccountQhChanged;
        /// <summary>
        /// 期货营业部资金账号(期货资金账号)
        /// </summary>
        public string CapitalAccountQh
        {
            get => _capitalAccountQh;
            set {
                _capitalAccountQhChanged = true;
                _capitalAccountQh = value;
            }
        }
        public Ufx30002 SetCapitalAccountQh(string value)
        {
            CapitalAccountQh = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx30002 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx30002 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_capitalAccountChanged)
            {
                packer.AddField("capital_account", (sbyte)'S', 16, 4);
            }
            if (_capitalAccountQhChanged)
            {
                packer.AddField("capital_account_qh", (sbyte)'S', 16, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_capitalAccountChanged)
            {
                packer.AddStr(_capitalAccount);
            }
            if (_capitalAccountQhChanged)
            {
                packer.AddStr(_capitalAccountQh);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 30003
    /// 功能名称: 支持查询登陆操作员有操作权限且状态为有效的组合列表
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx30003 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 30003;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        public Ufx30003(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx30003 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx30003 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx30003 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 30004
    /// 功能名称: 支持查询交易股东信息
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx30004 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 30004;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        public Ufx30004(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx30004 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx30004 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx30004 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx30004 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx30004 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx30004 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 30005
    /// 功能名称: 支持批量查询股东信息
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx30005 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 30005;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="assetNoList">资产单元编号(如果传入资产单元不能确定唯一的资产单元,则返回错误,批量,逗号隔开,不超过300个)</param>
        public Ufx30005(string userToken, string assetNoList)
        {
            UserToken = userToken;
            AssetNoList = assetNoList;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _assetNoList;
        private bool _assetNoListChanged;
        /// <summary>
        /// 资产单元编号(如果传入资产单元不能确定唯一的资产单元,则返回错误,批量,逗号隔开,不超过300个)
        /// </summary>
        public string AssetNoList
        {
            get => _assetNoList;
            set {
                _assetNoListChanged = true;
                _assetNoList = value;
            }
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx30005 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(传入股东代码必须传入市场)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx30005 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx30005 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx30005 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_assetNoListChanged)
            {
                packer.AddField("asset_no_list", (sbyte)'S', 512, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_assetNoListChanged)
            {
                packer.AddStr(_assetNoList);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 30007
    /// 功能名称: 支持查询账户清算状态,期现货可以分开查询(OPLUS专用).
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx30007 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 30007;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        public Ufx30007(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx30007 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx30007 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private int _marketGroupNo;
        private bool _marketGroupNoChanged;
        /// <summary>
        /// 市场组编号(1:现货市场;2:期货市场)
        /// </summary>
        public int MarketGroupNo
        {
            get => _marketGroupNo;
            set {
                _marketGroupNoChanged = true;
                _marketGroupNo = value;
            }
        }
        public Ufx30007 SetMarketGroupNo(int value)
        {
            MarketGroupNo = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx30007 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx30007 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_marketGroupNoChanged)
            {
                packer.AddField("market_group_no", (sbyte)'I', 8, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_marketGroupNoChanged)
            {
                packer.AddInt(_marketGroupNo);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 35003
    /// 功能名称: 支持查询账户资产信息
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35003 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 35003;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="accountCode">账户编号</param>
        public Ufx35003(string userToken, string accountCode)
        {
            UserToken = userToken;
            AccountCode = accountCode;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _currencyCode;
        private bool _currencyCodeChanged;
        /// <summary>
        /// 币种(限定 <see cref="UfxCurrencyCode"/> 中定义的常量)
        /// </summary>
        public string CurrencyCode
        {
            get => _currencyCode;
            set {
                _currencyCodeChanged = true;
                _currencyCode = value;
            }
        }
        public Ufx35003 SetCurrencyCode(string value)
        {
            CurrencyCode = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_currencyCodeChanged)
            {
                packer.AddField("currency_code", (sbyte)'S', 3, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_currencyCodeChanged)
            {
                packer.AddStr(_currencyCode);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 35010
    /// 功能名称: 支持查询账户资产信息(本币汇总)
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35010 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 35010;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="accountCode">账户编号</param>
        public Ufx35010(string userToken, string accountCode)
        {
            UserToken = userToken;
            AccountCode = accountCode;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 35011
    /// 功能名称: 支持查询资产单元资产信息
    /// 业务范围: 账户
    /// </summary>
    [Obsolete("不维护")]
    public sealed class Ufx35011 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 35011;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        public Ufx35011(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx35011 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx35011 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx35011 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _currencyCode;
        private bool _currencyCodeChanged;
        /// <summary>
        /// 币种(限定 <see cref="UfxCurrencyCode"/> 中定义的常量)
        /// </summary>
        public string CurrencyCode
        {
            get => _currencyCode;
            set {
                _currencyCodeChanged = true;
                _currencyCode = value;
            }
        }
        public Ufx35011 SetCurrencyCode(string value)
        {
            CurrencyCode = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_currencyCodeChanged)
            {
                packer.AddField("currency_code", (sbyte)'S', 3, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_currencyCodeChanged)
            {
                packer.AddStr(_currencyCode);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 35024
    /// 功能名称: 支持查询资产单元资产信息,查询结果为按照本币汇总后的数据
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35024 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 35024;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="accountCode">账户编号</param>
        public Ufx35024(string userToken, string accountCode)
        {
            UserToken = userToken;
            AccountCode = accountCode;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx35024 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 35025
    /// 功能名称: 支持查询期货账户盈亏信息
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35025 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 35025;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="accountCode">账户编号</param>
        /// <param name="assetNo">资产单元编号</param>
        public Ufx35025(string userToken, string accountCode, string assetNo)
        {
            UserToken = userToken;
            AccountCode = accountCode;
            AssetNo = assetNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 35012
    /// 功能名称: 支持查询当日清算流水
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35012 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 35012;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        public Ufx35012(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx35012 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx35012 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx35012 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx35012 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx35012 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx35012 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 36012
    /// 功能名称: 支持查询历史清算流水,只能查询一天的历史记录
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx36012 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 36012;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="startDate">起始日期(查询起始日期,仅能查询传入日期当天的记录)</param>
        public Ufx36012(string userToken, int startDate)
        {
            UserToken = userToken;
            StartDate = startDate;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _startDate;
        private bool _startDateChanged;
        /// <summary>
        /// 起始日期(查询起始日期,仅能查询传入日期当天的记录)
        /// </summary>
        public int StartDate
        {
            get => _startDate;
            set {
                _startDateChanged = true;
                _startDate = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx36012 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx36012 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx36012 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx36012 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx36012 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx36012 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_startDateChanged)
            {
                packer.AddField("start_date", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_startDateChanged)
            {
                packer.AddInt(_startDate);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 35013
    /// 功能名称: 支持查询可期货保证金比例信息
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35013 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 35013;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        public Ufx35013(string userToken, string marketNo)
        {
            UserToken = userToken;
            MarketNo = marketNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx35013 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx35013 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx35013 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx35013 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 35015
    /// 功能名称: 支持资金调增\资金调减\保证金调增\保证金调减\资金投入\资金支取业务
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35015 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 35015;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="accountCode">账户编号</param>
        /// <param name="assetNo">资产单元编号</param>
        /// <param name="adjustMode">调整类型(限定 <see cref="UfxAdjustMode"/> 中定义的常量)</param>
        /// <param name="businessBalance">调整金额</param>
        /// <param name="enableDate">生效时间</param>
        /// <param name="remark">备注</param>
        public Ufx35015(string userToken, string accountCode, string assetNo, sbyte adjustMode, double businessBalance, int enableDate, string remark)
        {
            UserToken = userToken;
            AccountCode = accountCode;
            AssetNo = assetNo;
            AdjustMode = adjustMode;
            BusinessBalance = businessBalance;
            EnableDate = enableDate;
            Remark = remark;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }

        private sbyte _adjustMode;
        private bool _adjustModeChanged;
        /// <summary>
        /// 调整类型(限定 <see cref="UfxAdjustMode"/> 中定义的常量)
        /// </summary>
        public sbyte AdjustMode
        {
            get => _adjustMode;
            set {
                _adjustModeChanged = true;
                _adjustMode = value;
            }
        }

        private double _businessBalance;
        private bool _businessBalanceChanged;
        /// <summary>
        /// 调整金额
        /// </summary>
        public double BusinessBalance
        {
            get => _businessBalance;
            set {
                _businessBalanceChanged = true;
                _businessBalance = value;
            }
        }

        private int _enableDate;
        private bool _enableDateChanged;
        /// <summary>
        /// 生效时间
        /// </summary>
        public int EnableDate
        {
            get => _enableDate;
            set {
                _enableDateChanged = true;
                _enableDate = value;
            }
        }

        private string _remark;
        private bool _remarkChanged;
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            get => _remark;
            set {
                _remarkChanged = true;
                _remark = value;
            }
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_adjustModeChanged)
            {
                packer.AddField("adjust_mode", (sbyte)'C', 1, 4);
            }
            if (_businessBalanceChanged)
            {
                packer.AddField("business_balance", (sbyte)'D', 16, 4);
            }
            if (_enableDateChanged)
            {
                packer.AddField("enable_date", (sbyte)'I', 8, 4);
            }
            if (_remarkChanged)
            {
                packer.AddField("remark", (sbyte)'S', 256, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_adjustModeChanged)
            {
                packer.AddChar(_adjustMode);
            }
            if (_businessBalanceChanged)
            {
                packer.AddDouble(_businessBalance);
            }
            if (_enableDateChanged)
            {
                packer.AddInt(_enableDate);
            }
            if (_remarkChanged)
            {
                packer.AddStr(_remark);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 35017
    /// 功能名称: 支持资金冻结,资金解冻
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35017 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 35017;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="accountCode">账户编号</param>
        /// <param name="assetNo">资产单元编号</param>
        /// <param name="fundOpFlag">资金操作类型(1资金冻结;2资金解冻)</param>
        /// <param name="occurBalance">发生金额</param>
        /// <param name="currencyCode">币种代码(限定 <see cref="UfxCurrencyCode"/> 中定义的常量)</param>
        /// <param name="enableDate">生效日期(非远期传系统当日)</param>
        /// <param name="expireDate">到期日期(冻结到期日期,永久传入99991231.生效日期和到期日期可相等,表示当日日终失效)</param>
        public Ufx35017(string userToken, string accountCode, string assetNo, int fundOpFlag, double occurBalance, string currencyCode, int enableDate, int expireDate)
        {
            UserToken = userToken;
            AccountCode = accountCode;
            AssetNo = assetNo;
            FundOpFlag = fundOpFlag;
            OccurBalance = occurBalance;
            CurrencyCode = currencyCode;
            EnableDate = enableDate;
            ExpireDate = expireDate;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }

        private int _fundOpFlag;
        private bool _fundOpFlagChanged;
        /// <summary>
        /// 资金操作类型(1资金冻结;2资金解冻)
        /// </summary>
        public int FundOpFlag
        {
            get => _fundOpFlag;
            set {
                _fundOpFlagChanged = true;
                _fundOpFlag = value;
            }
        }

        private double _occurBalance;
        private bool _occurBalanceChanged;
        /// <summary>
        /// 发生金额
        /// </summary>
        public double OccurBalance
        {
            get => _occurBalance;
            set {
                _occurBalanceChanged = true;
                _occurBalance = value;
            }
        }

        private string _currencyCode;
        private bool _currencyCodeChanged;
        /// <summary>
        /// 币种代码(限定 <see cref="UfxCurrencyCode"/> 中定义的常量)
        /// </summary>
        public string CurrencyCode
        {
            get => _currencyCode;
            set {
                _currencyCodeChanged = true;
                _currencyCode = value;
            }
        }

        private int _enableDate;
        private bool _enableDateChanged;
        /// <summary>
        /// 生效日期(非远期传系统当日)
        /// </summary>
        public int EnableDate
        {
            get => _enableDate;
            set {
                _enableDateChanged = true;
                _enableDate = value;
            }
        }

        private int _expireDate;
        private bool _expireDateChanged;
        /// <summary>
        /// 到期日期(冻结到期日期,永久传入99991231.生效日期和到期日期可相等,表示当日日终失效)
        /// </summary>
        public int ExpireDate
        {
            get => _expireDate;
            set {
                _expireDateChanged = true;
                _expireDate = value;
            }
        }

        private sbyte _matureEnableFlag;
        private bool _matureEnableFlagChanged;
        /// <summary>
        /// 到期后影响可用标识(0-到期后不影响可用1-到期后影响可用.不传默认为0)
        /// </summary>
        public sbyte MatureEnableFlag
        {
            get => _matureEnableFlag;
            set {
                _matureEnableFlagChanged = true;
                _matureEnableFlag = value;
            }
        }
        public Ufx35017 SetMatureEnableFlag(sbyte value)
        {
            MatureEnableFlag = value;
            return this;
        }

        private string _remark;
        private bool _remarkChanged;
        /// <summary>
        /// 备注(当前仅64位有效,超过64位会进行截位处理.)
        /// </summary>
        public string Remark
        {
            get => _remark;
            set {
                _remarkChanged = true;
                _remark = value;
            }
        }
        public Ufx35017 SetRemark(string value)
        {
            Remark = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_fundOpFlagChanged)
            {
                packer.AddField("fund_op_flag", (sbyte)'I', 8, 4);
            }
            if (_occurBalanceChanged)
            {
                packer.AddField("occur_balance", (sbyte)'D', 16, 4);
            }
            if (_currencyCodeChanged)
            {
                packer.AddField("currency_code", (sbyte)'S', 3, 4);
            }
            if (_enableDateChanged)
            {
                packer.AddField("enable_date", (sbyte)'I', 8, 4);
            }
            if (_expireDateChanged)
            {
                packer.AddField("expire_date", (sbyte)'I', 8, 4);
            }
            if (_matureEnableFlagChanged)
            {
                packer.AddField("mature_enable_flag", (sbyte)'C', 1, 4);
            }
            if (_remarkChanged)
            {
                packer.AddField("remark", (sbyte)'S', 256, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_fundOpFlagChanged)
            {
                packer.AddInt(_fundOpFlag);
            }
            if (_occurBalanceChanged)
            {
                packer.AddDouble(_occurBalance);
            }
            if (_currencyCodeChanged)
            {
                packer.AddStr(_currencyCode);
            }
            if (_enableDateChanged)
            {
                packer.AddInt(_enableDate);
            }
            if (_expireDateChanged)
            {
                packer.AddInt(_expireDate);
            }
            if (_matureEnableFlagChanged)
            {
                packer.AddChar(_matureEnableFlag);
            }
            if (_remarkChanged)
            {
                packer.AddStr(_remark);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 35018
    /// 功能名称: 支持取消资金冻结,取消资金解冻
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35018 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 35018;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="frozenSerialNo">冻结解冻序号(该字段值可以从35019接口获取)</param>
        public Ufx35018(string userToken, int frozenSerialNo)
        {
            UserToken = userToken;
            FrozenSerialNo = frozenSerialNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _frozenSerialNo;
        private bool _frozenSerialNoChanged;
        /// <summary>
        /// 冻结解冻序号(该字段值可以从35019接口获取)
        /// </summary>
        public int FrozenSerialNo
        {
            get => _frozenSerialNo;
            set {
                _frozenSerialNoChanged = true;
                _frozenSerialNo = value;
            }
        }

        private string _remark;
        private bool _remarkChanged;
        /// <summary>
        /// 备注(当前仅64位有效,超过64位会进行截位处理.)
        /// </summary>
        public string Remark
        {
            get => _remark;
            set {
                _remarkChanged = true;
                _remark = value;
            }
        }
        public Ufx35018 SetRemark(string value)
        {
            Remark = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_frozenSerialNoChanged)
            {
                packer.AddField("frozen_serial_no", (sbyte)'I', 12, 4);
            }
            if (_remarkChanged)
            {
                packer.AddField("remark", (sbyte)'S', 256, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_frozenSerialNoChanged)
            {
                packer.AddInt(_frozenSerialNo);
            }
            if (_remarkChanged)
            {
                packer.AddStr(_remark);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 35019
    /// 功能名称: 支持查询资金冻结解冻明细
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35019 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 35019;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="startDate">起始日期(查询起始日期,查询历史记录日期不能大于等于当前日期)</param>
        /// <param name="endDate">结束日期(查询结束日期,查询历史记录日期不能大于等于当前日期)</param>
        public Ufx35019(string userToken, int startDate, int endDate)
        {
            UserToken = userToken;
            StartDate = startDate;
            EndDate = endDate;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _startDate;
        private bool _startDateChanged;
        /// <summary>
        /// 起始日期(查询起始日期,查询历史记录日期不能大于等于当前日期)
        /// </summary>
        public int StartDate
        {
            get => _startDate;
            set {
                _startDateChanged = true;
                _startDate = value;
            }
        }

        private int _endDate;
        private bool _endDateChanged;
        /// <summary>
        /// 结束日期(查询结束日期,查询历史记录日期不能大于等于当前日期)
        /// </summary>
        public int EndDate
        {
            get => _endDate;
            set {
                _endDateChanged = true;
                _endDate = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx35019 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx35019 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _currencyCode;
        private bool _currencyCodeChanged;
        /// <summary>
        /// 币种代码(限定 <see cref="UfxCurrencyCode"/> 中定义的常量)
        /// </summary>
        public string CurrencyCode
        {
            get => _currencyCode;
            set {
                _currencyCodeChanged = true;
                _currencyCode = value;
            }
        }
        public Ufx35019 SetCurrencyCode(string value)
        {
            CurrencyCode = value;
            return this;
        }

        private sbyte _frozenFlag;
        private bool _frozenFlagChanged;
        /// <summary>
        /// 冻结解冻类型(1:冻结;2:解冻)
        /// </summary>
        public sbyte FrozenFlag
        {
            get => _frozenFlag;
            set {
                _frozenFlagChanged = true;
                _frozenFlag = value;
            }
        }
        public Ufx35019 SetFrozenFlag(sbyte value)
        {
            FrozenFlag = value;
            return this;
        }

        private sbyte _frozenStatus;
        private bool _frozenStatusChanged;
        /// <summary>
        /// 冻结解冻状态(1-有效2-已取消)
        /// </summary>
        public sbyte FrozenStatus
        {
            get => _frozenStatus;
            set {
                _frozenStatusChanged = true;
                _frozenStatus = value;
            }
        }
        public Ufx35019 SetFrozenStatus(sbyte value)
        {
            FrozenStatus = value;
            return this;
        }

        private int _expireDateBegin;
        private bool _expireDateBeginChanged;
        /// <summary>
        /// 到期开始日期
        /// </summary>
        public int ExpireDateBegin
        {
            get => _expireDateBegin;
            set {
                _expireDateBeginChanged = true;
                _expireDateBegin = value;
            }
        }
        public Ufx35019 SetExpireDateBegin(int value)
        {
            ExpireDateBegin = value;
            return this;
        }

        private int _expireDateEnd;
        private bool _expireDateEndChanged;
        /// <summary>
        /// 到期结束日期
        /// </summary>
        public int ExpireDateEnd
        {
            get => _expireDateEnd;
            set {
                _expireDateEndChanged = true;
                _expireDateEnd = value;
            }
        }
        public Ufx35019 SetExpireDateEnd(int value)
        {
            ExpireDateEnd = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx35019 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx35019 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_startDateChanged)
            {
                packer.AddField("start_date", (sbyte)'I', 8, 4);
            }
            if (_endDateChanged)
            {
                packer.AddField("end_date", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_currencyCodeChanged)
            {
                packer.AddField("currency_code", (sbyte)'S', 3, 4);
            }
            if (_frozenFlagChanged)
            {
                packer.AddField("frozen_flag", (sbyte)'C', 1, 4);
            }
            if (_frozenStatusChanged)
            {
                packer.AddField("frozen_status", (sbyte)'C', 1, 4);
            }
            if (_expireDateBeginChanged)
            {
                packer.AddField("expire_date_begin", (sbyte)'I', 8, 4);
            }
            if (_expireDateEndChanged)
            {
                packer.AddField("expire_date_end", (sbyte)'I', 8, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_startDateChanged)
            {
                packer.AddInt(_startDate);
            }
            if (_endDateChanged)
            {
                packer.AddInt(_endDate);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_currencyCodeChanged)
            {
                packer.AddStr(_currencyCode);
            }
            if (_frozenFlagChanged)
            {
                packer.AddChar(_frozenFlag);
            }
            if (_frozenStatusChanged)
            {
                packer.AddChar(_frozenStatus);
            }
            if (_expireDateBeginChanged)
            {
                packer.AddInt(_expireDateBegin);
            }
            if (_expireDateEndChanged)
            {
                packer.AddInt(_expireDateEnd);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 35021
    /// 功能名称: 支持资金划转,支持批量传入,最大1000条.
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35021 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 35021;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="accountCode">账户编号</param>
        /// <param name="assetNo">资产单元编号</param>
        /// <param name="targetAccountCode">目标账户编号</param>
        /// <param name="targetAssetNo">目标资产单元编号</param>
        /// <param name="occurBalance">发生金额</param>
        /// <param name="enableDate">生效日期(非远期传系统当日)</param>
        public Ufx35021(string userToken, string accountCode, string assetNo, string targetAccountCode, string targetAssetNo, double occurBalance, int enableDate)
        {
            UserToken = userToken;
            AccountCode = accountCode;
            AssetNo = assetNo;
            TargetAccountCode = targetAccountCode;
            TargetAssetNo = targetAssetNo;
            OccurBalance = occurBalance;
            EnableDate = enableDate;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }

        private string _targetAccountCode;
        private bool _targetAccountCodeChanged;
        /// <summary>
        /// 目标账户编号
        /// </summary>
        public string TargetAccountCode
        {
            get => _targetAccountCode;
            set {
                _targetAccountCodeChanged = true;
                _targetAccountCode = value;
            }
        }

        private string _targetAssetNo;
        private bool _targetAssetNoChanged;
        /// <summary>
        /// 目标资产单元编号
        /// </summary>
        public string TargetAssetNo
        {
            get => _targetAssetNo;
            set {
                _targetAssetNoChanged = true;
                _targetAssetNo = value;
            }
        }

        private string _currencyCode;
        private bool _currencyCodeChanged;
        /// <summary>
        /// 币种(限定 <see cref="UfxCurrencyCode"/> 中定义的常量)
        /// </summary>
        public string CurrencyCode
        {
            get => _currencyCode;
            set {
                _currencyCodeChanged = true;
                _currencyCode = value;
            }
        }
        public Ufx35021 SetCurrencyCode(string value)
        {
            CurrencyCode = value;
            return this;
        }

        private double _occurBalance;
        private bool _occurBalanceChanged;
        /// <summary>
        /// 发生金额
        /// </summary>
        public double OccurBalance
        {
            get => _occurBalance;
            set {
                _occurBalanceChanged = true;
                _occurBalance = value;
            }
        }

        private int _enableDate;
        private bool _enableDateChanged;
        /// <summary>
        /// 生效日期(非远期传系统当日)
        /// </summary>
        public int EnableDate
        {
            get => _enableDate;
            set {
                _enableDateChanged = true;
                _enableDate = value;
            }
        }

        private sbyte _enablePoint;
        private bool _enablePointChanged;
        /// <summary>
        /// 生效时点(0-立即,1-日初,2-日终.不传默认立即生效)
        /// </summary>
        public sbyte EnablePoint
        {
            get => _enablePoint;
            set {
                _enablePointChanged = true;
                _enablePoint = value;
            }
        }
        public Ufx35021 SetEnablePoint(sbyte value)
        {
            EnablePoint = value;
            return this;
        }

        private string _remark;
        private bool _remarkChanged;
        /// <summary>
        /// 备注(当前仅64位有效,超过64位会进行截位处理.)
        /// </summary>
        public string Remark
        {
            get => _remark;
            set {
                _remarkChanged = true;
                _remark = value;
            }
        }
        public Ufx35021 SetRemark(string value)
        {
            Remark = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_targetAccountCodeChanged)
            {
                packer.AddField("target_account_code", (sbyte)'S', 32, 4);
            }
            if (_targetAssetNoChanged)
            {
                packer.AddField("target_asset_no", (sbyte)'S', 16, 4);
            }
            if (_currencyCodeChanged)
            {
                packer.AddField("currency_code", (sbyte)'S', 3, 4);
            }
            if (_occurBalanceChanged)
            {
                packer.AddField("occur_balance", (sbyte)'D', 16, 4);
            }
            if (_enableDateChanged)
            {
                packer.AddField("enable_date", (sbyte)'I', 8, 4);
            }
            if (_enablePointChanged)
            {
                packer.AddField("enable_point", (sbyte)'C', 1, 4);
            }
            if (_remarkChanged)
            {
                packer.AddField("remark", (sbyte)'S', 256, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_targetAccountCodeChanged)
            {
                packer.AddStr(_targetAccountCode);
            }
            if (_targetAssetNoChanged)
            {
                packer.AddStr(_targetAssetNo);
            }
            if (_currencyCodeChanged)
            {
                packer.AddStr(_currencyCode);
            }
            if (_occurBalanceChanged)
            {
                packer.AddDouble(_occurBalance);
            }
            if (_enableDateChanged)
            {
                packer.AddInt(_enableDate);
            }
            if (_enablePointChanged)
            {
                packer.AddChar(_enablePoint);
            }
            if (_remarkChanged)
            {
                packer.AddStr(_remark);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 35022
    /// 功能名称: 支持现货,期货划转,支持批量传入,最大1000条.不支持批量跨基金证券划转
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35022 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 35022;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="accountCode">账户编号</param>
        /// <param name="combiNo">组合编号</param>
        /// <param name="stockholderId">股东代码(划转源和划转目标股东相同)</param>
        /// <param name="holdSeat">持仓席位(划转源和划转目标席位相同)</param>
        /// <param name="positionFlag">多空标志(限定 <see cref="UfxPositionFlag"/> 中定义的常量)</param>
        /// <param name="marketNo">交易市场</param>
        /// <param name="stockCode">证券代码</param>
        /// <param name="targetAccountCode">目标账户编号</param>
        /// <param name="targetCombiNo">目标组合编号</param>
        /// <param name="secutransPrice">划转价格(港股通业务填港币价格)</param>
        /// <param name="secutransAmount">划转数量(单位为股(份\张).)</param>
        /// <param name="enableDate">生效日期(非远期传系统当日)</param>
        public Ufx35022(string userToken, string accountCode, string combiNo, string stockholderId, string holdSeat, sbyte positionFlag, string marketNo, string stockCode, string targetAccountCode, string targetCombiNo, double secutransPrice, int secutransAmount, int enableDate)
        {
            UserToken = userToken;
            AccountCode = accountCode;
            CombiNo = combiNo;
            StockholderId = stockholderId;
            HoldSeat = holdSeat;
            PositionFlag = positionFlag;
            MarketNo = marketNo;
            StockCode = stockCode;
            TargetAccountCode = targetAccountCode;
            TargetCombiNo = targetCombiNo;
            SecutransPrice = secutransPrice;
            SecutransAmount = secutransAmount;
            EnableDate = enableDate;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码(划转源和划转目标股东相同)
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }

        private string _holdSeat;
        private bool _holdSeatChanged;
        /// <summary>
        /// 持仓席位(划转源和划转目标席位相同)
        /// </summary>
        public string HoldSeat
        {
            get => _holdSeat;
            set {
                _holdSeatChanged = true;
                _holdSeat = value;
            }
        }

        private sbyte _positionFlag;
        private bool _positionFlagChanged;
        /// <summary>
        /// 多空标志(限定 <see cref="UfxPositionFlag"/> 中定义的常量)
        /// </summary>
        public sbyte PositionFlag
        {
            get => _positionFlag;
            set {
                _positionFlagChanged = true;
                _positionFlag = value;
            }
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }

        private string _targetAccountCode;
        private bool _targetAccountCodeChanged;
        /// <summary>
        /// 目标账户编号
        /// </summary>
        public string TargetAccountCode
        {
            get => _targetAccountCode;
            set {
                _targetAccountCodeChanged = true;
                _targetAccountCode = value;
            }
        }

        private string _targetCombiNo;
        private bool _targetCombiNoChanged;
        /// <summary>
        /// 目标组合编号
        /// </summary>
        public string TargetCombiNo
        {
            get => _targetCombiNo;
            set {
                _targetCombiNoChanged = true;
                _targetCombiNo = value;
            }
        }

        private string _currencyCode;
        private bool _currencyCodeChanged;
        /// <summary>
        /// 币种(限定 <see cref="UfxCurrencyCode"/> 中定义的常量)
        /// </summary>
        public string CurrencyCode
        {
            get => _currencyCode;
            set {
                _currencyCodeChanged = true;
                _currencyCode = value;
            }
        }
        public Ufx35022 SetCurrencyCode(string value)
        {
            CurrencyCode = value;
            return this;
        }

        private int _stockOpenDate;
        private bool _stockOpenDateChanged;
        /// <summary>
        /// 开仓日期(期货必须传入源持仓明细信息,通过31013接口可获取)
        /// </summary>
        public int StockOpenDate
        {
            get => _stockOpenDate;
            set {
                _stockOpenDateChanged = true;
                _stockOpenDate = value;
            }
        }
        public Ufx35022 SetStockOpenDate(int value)
        {
            StockOpenDate = value;
            return this;
        }

        private string _dealNo;
        private bool _dealNoChanged;
        /// <summary>
        /// 成交编号(期货必须传入源持仓明细信息,通过31013接口可获取)
        /// </summary>
        public string DealNo
        {
            get => _dealNo;
            set {
                _dealNoChanged = true;
                _dealNo = value;
            }
        }
        public Ufx35022 SetDealNo(string value)
        {
            DealNo = value;
            return this;
        }

        private double _secutransPrice;
        private bool _secutransPriceChanged;
        /// <summary>
        /// 划转价格(港股通业务填港币价格)
        /// </summary>
        public double SecutransPrice
        {
            get => _secutransPrice;
            set {
                _secutransPriceChanged = true;
                _secutransPrice = value;
            }
        }

        private int _secutransAmount;
        private bool _secutransAmountChanged;
        /// <summary>
        /// 划转数量(单位为股(份\张).)
        /// </summary>
        public int SecutransAmount
        {
            get => _secutransAmount;
            set {
                _secutransAmountChanged = true;
                _secutransAmount = value;
            }
        }

        private double _occurProfit;
        private bool _occurProfitChanged;
        /// <summary>
        /// 发生收益(港股通业务填港币收益(非必填),默认传0)
        /// </summary>
        public double OccurProfit
        {
            get => _occurProfit;
            set {
                _occurProfitChanged = true;
                _occurProfit = value;
            }
        }
        public Ufx35022 SetOccurProfit(double value)
        {
            OccurProfit = value;
            return this;
        }

        private int _enableDate;
        private bool _enableDateChanged;
        /// <summary>
        /// 生效日期(非远期传系统当日)
        /// </summary>
        public int EnableDate
        {
            get => _enableDate;
            set {
                _enableDateChanged = true;
                _enableDate = value;
            }
        }

        private sbyte _enablePoint;
        private bool _enablePointChanged;
        /// <summary>
        /// 生效时点(0-立即,1-日初,2-日终.不传默认立即生效)
        /// </summary>
        public sbyte EnablePoint
        {
            get => _enablePoint;
            set {
                _enablePointChanged = true;
                _enablePoint = value;
            }
        }
        public Ufx35022 SetEnablePoint(sbyte value)
        {
            EnablePoint = value;
            return this;
        }

        private string _remark;
        private bool _remarkChanged;
        /// <summary>
        /// 备注(当前仅64位有效,超过64位会进行截位处理.)
        /// </summary>
        public string Remark
        {
            get => _remark;
            set {
                _remarkChanged = true;
                _remark = value;
            }
        }
        public Ufx35022 SetRemark(string value)
        {
            Remark = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_holdSeatChanged)
            {
                packer.AddField("hold_seat", (sbyte)'S', 6, 4);
            }
            if (_positionFlagChanged)
            {
                packer.AddField("position_flag", (sbyte)'C', 1, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_targetAccountCodeChanged)
            {
                packer.AddField("target_account_code", (sbyte)'S', 32, 4);
            }
            if (_targetCombiNoChanged)
            {
                packer.AddField("target_combi_no", (sbyte)'S', 16, 4);
            }
            if (_currencyCodeChanged)
            {
                packer.AddField("currency_code", (sbyte)'S', 3, 4);
            }
            if (_stockOpenDateChanged)
            {
                packer.AddField("stock_open_date", (sbyte)'I', 8, 4);
            }
            if (_dealNoChanged)
            {
                packer.AddField("deal_no", (sbyte)'S', 64, 4);
            }
            if (_secutransPriceChanged)
            {
                packer.AddField("secutrans_price", (sbyte)'D', 9, 4);
            }
            if (_secutransAmountChanged)
            {
                packer.AddField("secutrans_amount", (sbyte)'I', 12, 4);
            }
            if (_occurProfitChanged)
            {
                packer.AddField("occur_profit", (sbyte)'D', 16, 4);
            }
            if (_enableDateChanged)
            {
                packer.AddField("enable_date", (sbyte)'I', 8, 4);
            }
            if (_enablePointChanged)
            {
                packer.AddField("enable_point", (sbyte)'C', 1, 4);
            }
            if (_remarkChanged)
            {
                packer.AddField("remark", (sbyte)'S', 256, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_holdSeatChanged)
            {
                packer.AddStr(_holdSeat);
            }
            if (_positionFlagChanged)
            {
                packer.AddChar(_positionFlag);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_targetAccountCodeChanged)
            {
                packer.AddStr(_targetAccountCode);
            }
            if (_targetCombiNoChanged)
            {
                packer.AddStr(_targetCombiNo);
            }
            if (_currencyCodeChanged)
            {
                packer.AddStr(_currencyCode);
            }
            if (_stockOpenDateChanged)
            {
                packer.AddInt(_stockOpenDate);
            }
            if (_dealNoChanged)
            {
                packer.AddStr(_dealNo);
            }
            if (_secutransPriceChanged)
            {
                packer.AddDouble(_secutransPrice);
            }
            if (_secutransAmountChanged)
            {
                packer.AddInt(_secutransAmount);
            }
            if (_occurProfitChanged)
            {
                packer.AddDouble(_occurProfit);
            }
            if (_enableDateChanged)
            {
                packer.AddInt(_enableDate);
            }
            if (_enablePointChanged)
            {
                packer.AddChar(_enablePoint);
            }
            if (_remarkChanged)
            {
                packer.AddStr(_remark);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91001
    /// 功能名称: 支持沪深股票\基金买卖\债券买卖,新股申购\可转债申购\质押式回购\债转股\债回售\基金认购\配股认购\配债认购\债券认购业务.(不含固定收益和大宗交易).支持CDR存托凭证业务,支持沪伦通业务.
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91001 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91001;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        /// <param name="stockCode">证券代码(对于质押式回购业务,传对应的挂单代码,如:上海出入库用质押券代码,深圳出入库用债券代码.)</param>
        /// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
        /// <param name="priceType">委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)</param>
        /// <param name="entrustPrice">委托价格(1,当价格类型为市价时,头寸和风控控制买入按涨停价控.;2,债券回购业务价格传回购利率,如3.5%填入3.5.;3,提交质押\回转质押\基金认购\债转股\配股认购业务,价格字段无效,系统自动按交易所规则申报)</param>
        /// <param name="entrustAmount">委托数量(单位为股(份\张).)</param>
        public Ufx91001(string userToken, string marketNo, string stockCode, string entrustDirection, sbyte priceType, double entrustPrice, int entrustAmount)
        {
            UserToken = userToken;
            MarketNo = marketNo;
            StockCode = stockCode;
            EntrustDirection = entrustDirection;
            PriceType = priceType;
            EntrustPrice = entrustPrice;
            EntrustAmount = entrustAmount;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号(用户可自行指定委托批号,表示多笔委托属于同一批次.)
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }
        public Ufx91001 SetBatchNo(int value)
        {
            BatchNo = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号(账户编号\资产单元编号\组合编号三者至少要传入一项,如资产单元编号或组合编号未传入则取默认资产单元或默认组合.)
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx91001 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx91001 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx91001 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码(一般情况下无需传入股东,系统根据组合自动获取,只有一个组合存在多个股东时需要指定.)
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx91001 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _reportSeat;
        private bool _reportSeatChanged;
        /// <summary>
        /// 申报席位(一般情况下无需传入申报席位,系统根据组合自动获取.如需多席位报盘时可传入相应席位号.)
        /// </summary>
        public string ReportSeat
        {
            get => _reportSeat;
            set {
                _reportSeatChanged = true;
                _reportSeat = value;
            }
        }
        public Ufx91001 SetReportSeat(string value)
        {
            ReportSeat = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(对于质押式回购业务,传对应的挂单代码,如:上海出入库用质押券代码,深圳出入库用债券代码.)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }

        private sbyte _priceType;
        private bool _priceTypeChanged;
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType
        {
            get => _priceType;
            set {
                _priceTypeChanged = true;
                _priceType = value;
            }
        }

        private double _entrustPrice;
        private bool _entrustPriceChanged;
        /// <summary>
        /// 委托价格(1,当价格类型为市价时,头寸和风控控制买入按涨停价控.;2,债券回购业务价格传回购利率,如3.5%填入3.5.;3,提交质押\回转质押\基金认购\债转股\配股认购业务,价格字段无效,系统自动按交易所规则申报)
        /// </summary>
        public double EntrustPrice
        {
            get => _entrustPrice;
            set {
                _entrustPriceChanged = true;
                _entrustPrice = value;
            }
        }

        private int _entrustAmount;
        private bool _entrustAmountChanged;
        /// <summary>
        /// 委托数量(单位为股(份\张).)
        /// </summary>
        public int EntrustAmount
        {
            get => _entrustAmount;
            set {
                _entrustAmountChanged = true;
                _entrustAmount = value;
            }
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx91001 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx91001 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91001 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91001 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91001 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91001 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91001 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_reportSeatChanged)
            {
                packer.AddField("report_seat", (sbyte)'S', 6, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_priceTypeChanged)
            {
                packer.AddField("price_type", (sbyte)'C', 1, 4);
            }
            if (_entrustPriceChanged)
            {
                packer.AddField("entrust_price", (sbyte)'D', 11, 4);
            }
            if (_entrustAmountChanged)
            {
                packer.AddField("entrust_amount", (sbyte)'I', 12, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_reportSeatChanged)
            {
                packer.AddStr(_reportSeat);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_priceTypeChanged)
            {
                packer.AddChar(_priceType);
            }
            if (_entrustPriceChanged)
            {
                packer.AddDouble(_entrustPrice);
            }
            if (_entrustAmountChanged)
            {
                packer.AddInt(_entrustAmount);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91011
    /// 功能名称: 支持股转市场做市业务
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91011 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91011;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="stockCode">证券代码</param>
        public Ufx91011(string userToken, string stockCode)
        {
            UserToken = userToken;
            StockCode = stockCode;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号(账户编号\资产单元编号\组合编号三者至少要传入一项,如资产单元编号或组合编号未传入则取默认资产单元或默认组合.)
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx91011 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx91011 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx91011 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码(为空则取默认股东)
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx91011 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _reportSeat;
        private bool _reportSeatChanged;
        /// <summary>
        /// 申报席位(为空则取默认席位)
        /// </summary>
        public string ReportSeat
        {
            get => _reportSeat;
            set {
                _reportSeatChanged = true;
                _reportSeat = value;
            }
        }
        public Ufx91011 SetReportSeat(string value)
        {
            ReportSeat = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }

        private double _buyPrice;
        private bool _buyPriceChanged;
        /// <summary>
        /// 买入价格(买入价格\买入数量为一对,表示买入;;卖出价格\卖出数量为一对,表示卖出.;买入\卖出方向两者至少传入一方)
        /// </summary>
        public double BuyPrice
        {
            get => _buyPrice;
            set {
                _buyPriceChanged = true;
                _buyPrice = value;
            }
        }
        public Ufx91011 SetBuyPrice(double value)
        {
            BuyPrice = value;
            return this;
        }

        private int _buyAmount;
        private bool _buyAmountChanged;
        /// <summary>
        /// 买入数量
        /// </summary>
        public int BuyAmount
        {
            get => _buyAmount;
            set {
                _buyAmountChanged = true;
                _buyAmount = value;
            }
        }
        public Ufx91011 SetBuyAmount(int value)
        {
            BuyAmount = value;
            return this;
        }

        private double _sellPrice;
        private bool _sellPriceChanged;
        /// <summary>
        /// 卖出价格(买入价格\买入数量为一对,表示买入;;卖出价格\卖出数量为一对,表示卖出.;买入\卖出方向两者至少传入一方)
        /// </summary>
        public double SellPrice
        {
            get => _sellPrice;
            set {
                _sellPriceChanged = true;
                _sellPrice = value;
            }
        }
        public Ufx91011 SetSellPrice(double value)
        {
            SellPrice = value;
            return this;
        }

        private int _sellAmount;
        private bool _sellAmountChanged;
        /// <summary>
        /// 卖出数量
        /// </summary>
        public int SellAmount
        {
            get => _sellAmount;
            set {
                _sellAmountChanged = true;
                _sellAmount = value;
            }
        }
        public Ufx91011 SetSellAmount(int value)
        {
            SellAmount = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx91011 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx91011 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91011 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91011 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91011 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91011 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91011 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_reportSeatChanged)
            {
                packer.AddField("report_seat", (sbyte)'S', 6, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_buyPriceChanged)
            {
                packer.AddField("buy_price", (sbyte)'D', 11, 4);
            }
            if (_buyAmountChanged)
            {
                packer.AddField("buy_amount", (sbyte)'I', 12, 4);
            }
            if (_sellPriceChanged)
            {
                packer.AddField("sell_price", (sbyte)'D', 11, 4);
            }
            if (_sellAmountChanged)
            {
                packer.AddField("sell_amount", (sbyte)'I', 12, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_reportSeatChanged)
            {
                packer.AddStr(_reportSeat);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_buyPriceChanged)
            {
                packer.AddDouble(_buyPrice);
            }
            if (_buyAmountChanged)
            {
                packer.AddInt(_buyAmount);
            }
            if (_sellPriceChanged)
            {
                packer.AddDouble(_sellPrice);
            }
            if (_sellAmountChanged)
            {
                packer.AddInt(_sellAmount);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91115
    /// 功能名称: 支持按委托序号撤销股转做市委托.
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91115 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91115;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="accountCode">账户编号</param>
        /// <param name="combiNo">组合编号</param>
        /// <param name="entrustNo">委托序号</param>
        public Ufx91115(string userToken, string accountCode, string combiNo, int entrustNo)
        {
            UserToken = userToken;
            AccountCode = accountCode;
            CombiNo = combiNo;
            EntrustNo = entrustNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91115 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91115 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91115 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91115 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91115 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91113
    /// 功能名称: 支持按委托序号撤销股转做市委托.
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91113 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91113;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="entrustNo">委托序号()</param>
        public Ufx91113(string userToken, int entrustNo)
        {
            UserToken = userToken;
            EntrustNo = entrustNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号()
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91113 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91113 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91113 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91113 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91113 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91090
    /// 功能名称: 支持沪深股票\基金\债券买卖和股指期货\国债期货\商品期货\股票期权业务.支持CDR存托凭证业务,支持沪伦通业务
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91090 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91090;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        /// <param name="stockCode">证券代码</param>
        /// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
        /// <param name="priceType">委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)</param>
        /// <param name="entrustPrice">委托价格</param>
        /// <param name="entrustAmount">委托数量</param>
        public Ufx91090(string userToken, string marketNo, string stockCode, string entrustDirection, sbyte priceType, double entrustPrice, int entrustAmount)
        {
            UserToken = userToken;
            MarketNo = marketNo;
            StockCode = stockCode;
            EntrustDirection = entrustDirection;
            PriceType = priceType;
            EntrustPrice = entrustPrice;
            EntrustAmount = entrustAmount;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号(账户编号\资产单元编号\组合编号三者至少要传入一项,如资产单元编号或组合编号未传入则取默认资产单元或默认组合.账户编号建议传入,否则将影响性能.)
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx91090 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx91090 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx91090 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码(一般情况下无需传入股东,系统根据组合自动获取,只有一个组合存在多个股东时需要指定.PB用户请查看'PB用户须知'标签页.)
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx91090 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _reportSeat;
        private bool _reportSeatChanged;
        /// <summary>
        /// 申报席位(一般情况下无需传入申报席位,系统根据组合自动获取.如需多席位报盘时可传入相应席位号.该字段对期货无效!)
        /// </summary>
        public string ReportSeat
        {
            get => _reportSeat;
            set {
                _reportSeatChanged = true;
                _reportSeat = value;
            }
        }
        public Ufx91090 SetReportSeat(string value)
        {
            ReportSeat = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }

        private sbyte _futuresDirection;
        private bool _futuresDirectionChanged;
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;对期货期权有效.)
        /// </summary>
        public sbyte FuturesDirection
        {
            get => _futuresDirection;
            set {
                _futuresDirectionChanged = true;
                _futuresDirection = value;
            }
        }
        public Ufx91090 SetFuturesDirection(sbyte value)
        {
            FuturesDirection = value;
            return this;
        }

        private sbyte _closeDirection;
        private bool _closeDirectionChanged;
        /// <summary>
        /// 平仓类型(对上期所,能源期货交易所有效,'0'-不区分;'1'-平今;'2'-平昨.默认为'0'.期货'0'表示优先平今.)
        /// </summary>
        public sbyte CloseDirection
        {
            get => _closeDirection;
            set {
                _closeDirectionChanged = true;
                _closeDirection = value;
            }
        }
        public Ufx91090 SetCloseDirection(sbyte value)
        {
            CloseDirection = value;
            return this;
        }

        private sbyte _coveredFlag;
        private bool _coveredFlagChanged;
        /// <summary>
        /// 备兑标志(仅对股票期权有效.1:备兑,0:非备兑,默认为0.)
        /// </summary>
        public sbyte CoveredFlag
        {
            get => _coveredFlag;
            set {
                _coveredFlagChanged = true;
                _coveredFlag = value;
            }
        }
        public Ufx91090 SetCoveredFlag(sbyte value)
        {
            CoveredFlag = value;
            return this;
        }

        private sbyte _priceType;
        private bool _priceTypeChanged;
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType
        {
            get => _priceType;
            set {
                _priceTypeChanged = true;
                _priceType = value;
            }
        }

        private double _entrustPrice;
        private bool _entrustPriceChanged;
        /// <summary>
        /// 委托价格
        /// </summary>
        public double EntrustPrice
        {
            get => _entrustPrice;
            set {
                _entrustPriceChanged = true;
                _entrustPrice = value;
            }
        }

        private int _entrustAmount;
        private bool _entrustAmountChanged;
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount
        {
            get => _entrustAmount;
            set {
                _entrustAmountChanged = true;
                _entrustAmount = value;
            }
        }

        private double _limitEntrustRatio;
        private bool _limitEntrustRatioChanged;
        /// <summary>
        /// 现货最小委托比例(用于控制篮子委托中,如果有部分现货触发风控\可用不足,其他券是否要继续下达.如果可委托的券总市值占篮子现货总市值的比例小于设定值,则取消本次操作,否则下达可委托的证券.该字段只取第一行记录.默认为100,即所有证券可委托时方可下达委托.多行数据时取第一行.如要设为80%时,则传入80.;(注:O30116G(不含)之前的版本服务只支持部分'风控禁止'的情况,对于'可用'和'其他原因'不能下达的情况,整个篮子被禁止.))
        /// </summary>
        public double LimitEntrustRatio
        {
            get => _limitEntrustRatio;
            set {
                _limitEntrustRatioChanged = true;
                _limitEntrustRatio = value;
            }
        }
        public Ufx91090 SetLimitEntrustRatio(double value)
        {
            LimitEntrustRatio = value;
            return this;
        }

        private double _ftrLimitEntrustRatio;
        private bool _ftrLimitEntrustRatioChanged;
        /// <summary>
        /// 期货最小委托比例(用于控制篮子委托中,如果有部分期货触发风控\可用不足,其他券是否要继续下达.如果可委托的券总市值占篮子期货总市值的比例小于设定值,则取消本次操作,否则下达可委托的证券.该字段只取第一行记录.默认为100,即所有证券可委托时方可下达委托.多行数据时取第一行.如要设为80%时,则传入80.;(注:O30116G(不含)之前的版本服务只支持部分'风控禁止'的情况,对于'可用'和'其他原因'不能下达的情况,整个篮子被禁止.)(注:该字段在O30116I之后的版本有效))
        /// </summary>
        public double FtrLimitEntrustRatio
        {
            get => _ftrLimitEntrustRatio;
            set {
                _ftrLimitEntrustRatioChanged = true;
                _ftrLimitEntrustRatio = value;
            }
        }
        public Ufx91090 SetFtrLimitEntrustRatio(double value)
        {
            FtrLimitEntrustRatio = value;
            return this;
        }

        private double _optLimitEntrustRatio;
        private bool _optLimitEntrustRatioChanged;
        /// <summary>
        /// 期权最小委托比例(用于控制篮子委托中,如果有部分期权触发风控\可用不足,其他券是否要继续下达.如果可委托的券总市值占篮子期货总市值的比例小于设定值,则取消本次操作,否则下达可委托的证券.该字段只取第一行记录.默认为100,即所有证券可委托时方可下达委托.多行数据时取第一行.如要设为80%时,则传入80.;(注:O30116G(不含)之前的版本服务只支持部分'风控禁止'的情况,对于'可用'和'其他原因'不能下达的情况,整个篮子被禁止.)(注:该字段在O30116I之后的版本有效))
        /// </summary>
        public double OptLimitEntrustRatio
        {
            get => _optLimitEntrustRatio;
            set {
                _optLimitEntrustRatioChanged = true;
                _optLimitEntrustRatio = value;
            }
        }
        public Ufx91090 SetOptLimitEntrustRatio(double value)
        {
            OptLimitEntrustRatio = value;
            return this;
        }

        private int _limitDealAmount;
        private bool _limitDealAmountChanged;
        /// <summary>
        /// 最小成交量(仅对商品期货有效,如果可成数量小于该值,交易所不会成交.)
        /// </summary>
        public int LimitDealAmount
        {
            get => _limitDealAmount;
            set {
                _limitDealAmountChanged = true;
                _limitDealAmount = value;
            }
        }
        public Ufx91090 SetLimitDealAmount(int value)
        {
            LimitDealAmount = value;
            return this;
        }

        private sbyte _investType;
        private bool _investTypeChanged;
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType
        {
            get => _investType;
            set {
                _investTypeChanged = true;
                _investType = value;
            }
        }
        public Ufx91090 SetInvestType(sbyte value)
        {
            InvestType = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx91090 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(外部系统传入,委托查询\委托确认\成交返回数据中原样返回,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx91090 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91090 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91090 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91090 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91090 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91090 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_reportSeatChanged)
            {
                packer.AddField("report_seat", (sbyte)'S', 6, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddField("futures_direction", (sbyte)'C', 1, 4);
            }
            if (_closeDirectionChanged)
            {
                packer.AddField("close_direction", (sbyte)'C', 1, 4);
            }
            if (_coveredFlagChanged)
            {
                packer.AddField("covered_flag", (sbyte)'C', 1, 4);
            }
            if (_priceTypeChanged)
            {
                packer.AddField("price_type", (sbyte)'C', 1, 4);
            }
            if (_entrustPriceChanged)
            {
                packer.AddField("entrust_price", (sbyte)'D', 11, 4);
            }
            if (_entrustAmountChanged)
            {
                packer.AddField("entrust_amount", (sbyte)'I', 12, 4);
            }
            if (_limitEntrustRatioChanged)
            {
                packer.AddField("limit_entrust_ratio", (sbyte)'D', 9, 4);
            }
            if (_ftrLimitEntrustRatioChanged)
            {
                packer.AddField("ftr_limit_entrust_ratio", (sbyte)'D', 9, 4);
            }
            if (_optLimitEntrustRatioChanged)
            {
                packer.AddField("opt_limit_entrust_ratio", (sbyte)'D', 9, 4);
            }
            if (_limitDealAmountChanged)
            {
                packer.AddField("limit_deal_amount", (sbyte)'I', 12, 4);
            }
            if (_investTypeChanged)
            {
                packer.AddField("invest_type", (sbyte)'C', 1, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_reportSeatChanged)
            {
                packer.AddStr(_reportSeat);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddChar(_futuresDirection);
            }
            if (_closeDirectionChanged)
            {
                packer.AddChar(_closeDirection);
            }
            if (_coveredFlagChanged)
            {
                packer.AddChar(_coveredFlag);
            }
            if (_priceTypeChanged)
            {
                packer.AddChar(_priceType);
            }
            if (_entrustPriceChanged)
            {
                packer.AddDouble(_entrustPrice);
            }
            if (_entrustAmountChanged)
            {
                packer.AddInt(_entrustAmount);
            }
            if (_limitEntrustRatioChanged)
            {
                packer.AddDouble(_limitEntrustRatio);
            }
            if (_ftrLimitEntrustRatioChanged)
            {
                packer.AddDouble(_ftrLimitEntrustRatio);
            }
            if (_optLimitEntrustRatioChanged)
            {
                packer.AddDouble(_optLimitEntrustRatio);
            }
            if (_limitDealAmountChanged)
            {
                packer.AddInt(_limitDealAmount);
            }
            if (_investTypeChanged)
            {
                packer.AddChar(_investType);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91114
    /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91114 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91114;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="accountCode">账户编号</param>
        /// <param name="combiNo">组合编号</param>
        /// <param name="entrustNo">委托序号</param>
        public Ufx91114(string userToken, string accountCode, string combiNo, int entrustNo)
        {
            UserToken = userToken;
            AccountCode = accountCode;
            CombiNo = combiNo;
            EntrustNo = entrustNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91114 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91114 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91114 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91114 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91114 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91101
    /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91101 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91101;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="entrustNo">委托序号()</param>
        public Ufx91101(string userToken, int entrustNo)
        {
            UserToken = userToken;
            EntrustNo = entrustNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号()
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91101 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91101 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91101 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91101 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91101 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91102
    /// 功能名称: 支持按委托批号撤单,支持对证券\期货\期权\策略等业务按委托批号撤单
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91102 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91102;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="batchNo">委托批号</param>
        public Ufx91102(string userToken, int batchNo)
        {
            UserToken = userToken;
            BatchNo = batchNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91102 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91102 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91102 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91102 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91102 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 31001
    /// 功能名称: 支持查询沪深及股转市场的股票\基金\债券的持仓信息
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx31001 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 31001;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        public Ufx31001(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx31001 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx31001 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx31001 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx31001 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx31001 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx31001 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _holdSeat;
        private bool _holdSeatChanged;
        /// <summary>
        /// 持仓席位
        /// </summary>
        public string HoldSeat
        {
            get => _holdSeat;
            set {
                _holdSeatChanged = true;
                _holdSeat = value;
            }
        }
        public Ufx31001 SetHoldSeat(string value)
        {
            HoldSeat = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_holdSeatChanged)
            {
                packer.AddField("hold_seat", (sbyte)'S', 6, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_holdSeatChanged)
            {
                packer.AddStr(_holdSeat);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 31002
    /// 功能名称: 支持查询提交\转回质押的质押券数量明细(OPLUS专用)
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx31002 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 31002;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="assetNo">资产单元编号</param>
        public Ufx31002(string userToken, string assetNo)
        {
            UserToken = userToken;
            AssetNo = assetNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx31002 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx31002 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 30011
    /// 功能名称: 支持查询现货,期货,期权的证券资料信息.
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx30011 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 30011;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        public Ufx30011(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _stockType;
        private bool _stockTypeChanged;
        /// <summary>
        /// 证券类型(限定 <see cref="UfxStockType"/> 中定义的常量)
        /// </summary>
        public string StockType
        {
            get => _stockType;
            set {
                _stockTypeChanged = true;
                _stockType = value;
            }
        }
        public Ufx30011 SetStockType(string value)
        {
            StockType = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx30011 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码必须传入市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx30011 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx30011 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx30011 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_stockTypeChanged)
            {
                packer.AddField("stock_type", (sbyte)'S', 4, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_stockTypeChanged)
            {
                packer.AddStr(_stockType);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 32001
    /// 功能名称: 支持查询当日普通买卖委托流水,包含沪深股票\基金买卖\债券买卖,新股申购\可转债申购\质押式回购\债转股\债回售\基金认购\配股认购\配债认购\债券认购\股转市场业务
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx32001 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 32001;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        public Ufx32001(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号(按委托批号查询)
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }
        public Ufx32001 SetBatchNo(int value)
        {
            BatchNo = value;
            return this;
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号(按委托序号查询)
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }
        public Ufx32001 SetEntrustNo(int value)
        {
            EntrustNo = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx32001 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx32001 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx32001 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx32001 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx32001 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx32001 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }
        public Ufx32001 SetEntrustDirection(string value)
        {
            EntrustDirection = value;
            return this;
        }

        private string _entrustStateList;
        private bool _entrustStateListChanged;
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public string EntrustStateList
        {
            get => _entrustStateList;
            set {
                _entrustStateListChanged = true;
                _entrustStateList = value;
            }
        }
        public Ufx32001 SetEntrustStateList(string value)
        {
            EntrustStateList = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx32001 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx32001 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx32001 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx32001 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_entrustStateListChanged)
            {
                packer.AddField("entrust_state_list", (sbyte)'S', 256, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_entrustStateListChanged)
            {
                packer.AddStr(_entrustStateList);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 32101
    /// 功能名称: 支持查询历史普通买卖委托流水
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx32101 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 32101;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        /// <param name="startDate">起始日期(查询起始日期)</param>
        /// <param name="endDate">结束日期(查询结束日期)</param>
        /// <param name="accountCode">账户编号</param>
        public Ufx32101(string userToken, int startDate, int endDate, string accountCode)
        {
            UserToken = userToken;
            StartDate = startDate;
            EndDate = endDate;
            AccountCode = accountCode;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _startDate;
        private bool _startDateChanged;
        /// <summary>
        /// 起始日期(查询起始日期)
        /// </summary>
        public int StartDate
        {
            get => _startDate;
            set {
                _startDateChanged = true;
                _startDate = value;
            }
        }

        private int _endDate;
        private bool _endDateChanged;
        /// <summary>
        /// 结束日期(查询结束日期)
        /// </summary>
        public int EndDate
        {
            get => _endDate;
            set {
                _endDateChanged = true;
                _endDate = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号(按委托批号查询)
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }
        public Ufx32101 SetBatchNo(int value)
        {
            BatchNo = value;
            return this;
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号(按委托序号查询)
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }
        public Ufx32101 SetEntrustNo(int value)
        {
            EntrustNo = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx32101 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元和组合二选一必传.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx32101 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx32101 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx32101 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx32101 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }
        public Ufx32101 SetEntrustDirection(string value)
        {
            EntrustDirection = value;
            return this;
        }

        private string _entrustStateList;
        private bool _entrustStateListChanged;
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public string EntrustStateList
        {
            get => _entrustStateList;
            set {
                _entrustStateListChanged = true;
                _entrustStateList = value;
            }
        }
        public Ufx32101 SetEntrustStateList(string value)
        {
            EntrustStateList = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx32101 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx32101 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx32101 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx32101 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_startDateChanged)
            {
                packer.AddField("start_date", (sbyte)'I', 8, 4);
            }
            if (_endDateChanged)
            {
                packer.AddField("end_date", (sbyte)'I', 8, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_entrustStateListChanged)
            {
                packer.AddField("entrust_state_list", (sbyte)'S', 256, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_startDateChanged)
            {
                packer.AddInt(_startDate);
            }
            if (_endDateChanged)
            {
                packer.AddInt(_endDate);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_entrustStateListChanged)
            {
                packer.AddStr(_entrustStateList);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 32006
    /// 功能名称: 支持查询当日股转做市委托
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx32006 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 32006;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="accountCode">账户编号</param>
        public Ufx32006(string userToken, string accountCode)
        {
            UserToken = userToken;
            AccountCode = accountCode;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号(按委托批号查询)
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }
        public Ufx32006 SetBatchNo(int value)
        {
            BatchNo = value;
            return this;
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }
        public Ufx32006 SetEntrustNo(int value)
        {
            EntrustNo = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx32006 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元和组合二选一必传.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx32006 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx32006 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx32006 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _entrustStateList;
        private bool _entrustStateListChanged;
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public string EntrustStateList
        {
            get => _entrustStateList;
            set {
                _entrustStateListChanged = true;
                _entrustStateList = value;
            }
        }
        public Ufx32006 SetEntrustStateList(string value)
        {
            EntrustStateList = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx32006 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx32006 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx32006 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx32006 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustStateListChanged)
            {
                packer.AddField("entrust_state_list", (sbyte)'S', 256, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustStateListChanged)
            {
                packer.AddStr(_entrustStateList);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 33001
    /// 功能名称: 支持查询当日普通买卖委托以及当日股转做市委托对应的成交流水
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx33001 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 33001;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        public Ufx33001(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx33001 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx33001 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx33001 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号()
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }
        public Ufx33001 SetEntrustNo(int value)
        {
            EntrustNo = value;
            return this;
        }

        private string _dealNo;
        private bool _dealNoChanged;
        /// <summary>
        /// 成交编号
        /// </summary>
        public string DealNo
        {
            get => _dealNo;
            set {
                _dealNoChanged = true;
                _dealNo = value;
            }
        }
        public Ufx33001 SetDealNo(string value)
        {
            DealNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx33001 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx33001 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx33001 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }
        public Ufx33001 SetEntrustDirection(string value)
        {
            EntrustDirection = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx33001 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx33001 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx33001 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx33001 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_dealNoChanged)
            {
                packer.AddField("deal_no", (sbyte)'S', 64, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_dealNoChanged)
            {
                packer.AddStr(_dealNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 33101
    /// 功能名称: 支持查询历史普通买卖成交流水
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx33101 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 33101;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        /// <param name="startDate">起始日期(查询起始日期格式YYYYMMDD)</param>
        /// <param name="endDate">结束日期(查询结束日期格式YYYYMMDD)</param>
        /// <param name="accountCode">账户编号</param>
        public Ufx33101(string userToken, int startDate, int endDate, string accountCode)
        {
            UserToken = userToken;
            StartDate = startDate;
            EndDate = endDate;
            AccountCode = accountCode;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _startDate;
        private bool _startDateChanged;
        /// <summary>
        /// 起始日期(查询起始日期格式YYYYMMDD)
        /// </summary>
        public int StartDate
        {
            get => _startDate;
            set {
                _startDateChanged = true;
                _startDate = value;
            }
        }

        private int _endDate;
        private bool _endDateChanged;
        /// <summary>
        /// 结束日期(查询结束日期格式YYYYMMDD)
        /// </summary>
        public int EndDate
        {
            get => _endDate;
            set {
                _endDateChanged = true;
                _endDate = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx33101 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx33101 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _entrustSerialList;
        private bool _entrustSerialListChanged;
        /// <summary>
        /// 委托序号串(以逗号分隔)
        /// </summary>
        public string EntrustSerialList
        {
            get => _entrustSerialList;
            set {
                _entrustSerialListChanged = true;
                _entrustSerialList = value;
            }
        }
        public Ufx33101 SetEntrustSerialList(string value)
        {
            EntrustSerialList = value;
            return this;
        }

        private string _dealNo;
        private bool _dealNoChanged;
        /// <summary>
        /// 成交编号
        /// </summary>
        public string DealNo
        {
            get => _dealNo;
            set {
                _dealNoChanged = true;
                _dealNo = value;
            }
        }
        public Ufx33101 SetDealNo(string value)
        {
            DealNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx33101 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx33101 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx33101 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }
        public Ufx33101 SetEntrustDirection(string value)
        {
            EntrustDirection = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx33101 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx33101 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx33101 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx33101 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_startDateChanged)
            {
                packer.AddField("start_date", (sbyte)'I', 8, 4);
            }
            if (_endDateChanged)
            {
                packer.AddField("end_date", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_entrustSerialListChanged)
            {
                packer.AddField("entrust_serial_list", (sbyte)'S', 512, 4);
            }
            if (_dealNoChanged)
            {
                packer.AddField("deal_no", (sbyte)'S', 64, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_startDateChanged)
            {
                packer.AddInt(_startDate);
            }
            if (_endDateChanged)
            {
                packer.AddInt(_endDate);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_entrustSerialListChanged)
            {
                packer.AddStr(_entrustSerialList);
            }
            if (_dealNoChanged)
            {
                packer.AddStr(_dealNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 34001
    /// 功能名称: 支持查询沪深A股及股转市场资金账户的资金可用,支持批量传入.
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx34001 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 34001;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        public Ufx34001(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx34001 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx34001 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx34001 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91051
    /// 功能名称: 支持股转市场协议转让交易业务.
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91051 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91051;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="stockCode">证券代码</param>
        /// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
        /// <param name="priceType">委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)</param>
        /// <param name="entrustPrice">委托价格(当价格类型为市价时,头寸和风控控制买入按涨停价控.)</param>
        /// <param name="entrustAmount">委托数量(单位为股.)</param>
        public Ufx91051(string userToken, string stockCode, string entrustDirection, sbyte priceType, double entrustPrice, int entrustAmount)
        {
            UserToken = userToken;
            StockCode = stockCode;
            EntrustDirection = entrustDirection;
            PriceType = priceType;
            EntrustPrice = entrustPrice;
            EntrustAmount = entrustAmount;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号(用户可自行指定委托批号,表示多笔委托属于同一批次.)
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }
        public Ufx91051 SetBatchNo(int value)
        {
            BatchNo = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号(;账户编号\资产单元编号\组合编号三者至少要传入一项,如资产单元编号或组合编号未传入则取默认资产单元或默认组合.;)
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx91051 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx91051 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx91051 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码(一般情况下无需传入股东,系统根据组合自动获取,只有一个组合存在多个股东时需要指定.)
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx91051 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _reportSeat;
        private bool _reportSeatChanged;
        /// <summary>
        /// 申报席位(一般情况下无需传入申报席位,系统根据组合自动获取.如需多席位报盘时可传入相应席位号.)
        /// </summary>
        public string ReportSeat
        {
            get => _reportSeat;
            set {
                _reportSeatChanged = true;
                _reportSeat = value;
            }
        }
        public Ufx91051 SetReportSeat(string value)
        {
            ReportSeat = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }

        private sbyte _priceType;
        private bool _priceTypeChanged;
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType
        {
            get => _priceType;
            set {
                _priceTypeChanged = true;
                _priceType = value;
            }
        }

        private double _entrustPrice;
        private bool _entrustPriceChanged;
        /// <summary>
        /// 委托价格(当价格类型为市价时,头寸和风控控制买入按涨停价控.)
        /// </summary>
        public double EntrustPrice
        {
            get => _entrustPrice;
            set {
                _entrustPriceChanged = true;
                _entrustPrice = value;
            }
        }

        private int _entrustAmount;
        private bool _entrustAmountChanged;
        /// <summary>
        /// 委托数量(单位为股.)
        /// </summary>
        public int EntrustAmount
        {
            get => _entrustAmount;
            set {
                _entrustAmountChanged = true;
                _entrustAmount = value;
            }
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx91051 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx91051 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _rivalHoldid;
        private bool _rivalHoldidChanged;
        /// <summary>
        /// 对方股东代码(委托价格类型为'm(协议转让互报成交确认申报)'时必输,委托价格类型为其他值时忽略)
        /// </summary>
        public string RivalHoldid
        {
            get => _rivalHoldid;
            set {
                _rivalHoldidChanged = true;
                _rivalHoldid = value;
            }
        }
        public Ufx91051 SetRivalHoldid(string value)
        {
            RivalHoldid = value;
            return this;
        }

        private string _rivalSeat;
        private bool _rivalSeatChanged;
        /// <summary>
        /// 对方席位号(委托价格类型为'm(协议转让互报成交确认申报)'时必输,委托价格类型为其他值时忽略)
        /// </summary>
        public string RivalSeat
        {
            get => _rivalSeat;
            set {
                _rivalSeatChanged = true;
                _rivalSeat = value;
            }
        }
        public Ufx91051 SetRivalSeat(string value)
        {
            RivalSeat = value;
            return this;
        }

        private string _engagedNo;
        private bool _engagedNoChanged;
        /// <summary>
        /// 约定号(委托价格类型为'l(协议转让成交确认申报),m(协议转让互报成交确认申报)'时必输,委托价格类型为其他值时忽略)
        /// </summary>
        public string EngagedNo
        {
            get => _engagedNo;
            set {
                _engagedNoChanged = true;
                _engagedNo = value;
            }
        }
        public Ufx91051 SetEngagedNo(string value)
        {
            EngagedNo = value;
            return this;
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91051 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91051 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91051 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91051 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91051 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_reportSeatChanged)
            {
                packer.AddField("report_seat", (sbyte)'S', 6, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_priceTypeChanged)
            {
                packer.AddField("price_type", (sbyte)'C', 1, 4);
            }
            if (_entrustPriceChanged)
            {
                packer.AddField("entrust_price", (sbyte)'D', 11, 4);
            }
            if (_entrustAmountChanged)
            {
                packer.AddField("entrust_amount", (sbyte)'I', 12, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_rivalHoldidChanged)
            {
                packer.AddField("rival_holdid", (sbyte)'S', 20, 4);
            }
            if (_rivalSeatChanged)
            {
                packer.AddField("rival_seat", (sbyte)'S', 6, 4);
            }
            if (_engagedNoChanged)
            {
                packer.AddField("engaged_no", (sbyte)'S', 10, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_reportSeatChanged)
            {
                packer.AddStr(_reportSeat);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_priceTypeChanged)
            {
                packer.AddChar(_priceType);
            }
            if (_entrustPriceChanged)
            {
                packer.AddDouble(_entrustPrice);
            }
            if (_entrustAmountChanged)
            {
                packer.AddInt(_entrustAmount);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_rivalHoldidChanged)
            {
                packer.AddStr(_rivalHoldid);
            }
            if (_rivalSeatChanged)
            {
                packer.AddStr(_rivalSeat);
            }
            if (_engagedNoChanged)
            {
                packer.AddStr(_engagedNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91116
    /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91116 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91116;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="accountCode">账户编号</param>
        /// <param name="combiNo">组合编号</param>
        /// <param name="entrustNo">委托序号</param>
        public Ufx91116(string userToken, string accountCode, string combiNo, int entrustNo)
        {
            UserToken = userToken;
            AccountCode = accountCode;
            CombiNo = combiNo;
            EntrustNo = entrustNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91116 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91116 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91116 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91116 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91116 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91151
    /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91151 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91151;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="entrustNo">委托序号</param>
        public Ufx91151(string userToken, int entrustNo)
        {
            UserToken = userToken;
            EntrustNo = entrustNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91151 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91151 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91151 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91151 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91151 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91003
    /// 功能名称: 支持沪深ETF\沪深跨市场ETF\沪深跨境ETF申赎业务
    /// 业务范围: 基金
    /// </summary>
    [Obsolete("不维护")]
    public sealed class Ufx91003 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91003;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        /// <param name="stockCode">证券代码</param>
        /// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
        /// <param name="entrustAmount">委托数量(申赎数量单位为篮子数.如最小申购单位是100万份,要申赎200万,该字段填2.)</param>
        public Ufx91003(string userToken, string marketNo, string stockCode, string entrustDirection, int entrustAmount)
        {
            UserToken = userToken;
            MarketNo = marketNo;
            StockCode = stockCode;
            EntrustDirection = entrustDirection;
            EntrustAmount = entrustAmount;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号(账户编号\资产单元编号\组合编号三者至少要传入一项,如资产单元编号或组合编号未传入则取默认资产单元或默认组合.)
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx91003 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx91003 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx91003 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码(一般情况下无需传入股东,系统根据组合自动获取,只有一个组合存在多个股东时需要指定.)
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx91003 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _reportSeat;
        private bool _reportSeatChanged;
        /// <summary>
        /// 申报席位(一般情况下无需传入申报席位,系统根据组合自动获取.如需多席位报盘时可传入相应席位号.)
        /// </summary>
        public string ReportSeat
        {
            get => _reportSeat;
            set {
                _reportSeatChanged = true;
                _reportSeat = value;
            }
        }
        public Ufx91003 SetReportSeat(string value)
        {
            ReportSeat = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }

        private int _entrustAmount;
        private bool _entrustAmountChanged;
        /// <summary>
        /// 委托数量(申赎数量单位为篮子数.如最小申购单位是100万份,要申赎200万,该字段填2.)
        /// </summary>
        public int EntrustAmount
        {
            get => _entrustAmount;
            set {
                _entrustAmountChanged = true;
                _entrustAmount = value;
            }
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx91003 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx91003 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91003 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91003 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91003 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91003 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91003 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_reportSeatChanged)
            {
                packer.AddField("report_seat", (sbyte)'S', 6, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_entrustAmountChanged)
            {
                packer.AddField("entrust_amount", (sbyte)'I', 12, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_reportSeatChanged)
            {
                packer.AddStr(_reportSeat);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_entrustAmountChanged)
            {
                packer.AddInt(_entrustAmount);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91008
    /// 功能名称: 支持ETF(股票型ETF\债券型ETF\华宝兴业交易型货币基金\沪深跨境ETF\沪深黄金ETF\深交所交易型货币基金)\场内开放式基金申赎(LOF)\LOF基金分拆合并\转托管.基金买卖委托请用91001接口
    /// 业务范围: 基金
    /// </summary>
    public sealed class Ufx91008 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91008;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        /// <param name="stockCode">证券代码</param>
        /// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
        public Ufx91008(string userToken, string marketNo, string stockCode, string entrustDirection)
        {
            UserToken = userToken;
            MarketNo = marketNo;
            StockCode = stockCode;
            EntrustDirection = entrustDirection;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号(账户编号\资产单元编号\组合编号三者至少要传入一项,如资产单元编号或组合编号未传入则取默认资产单元或默认组合.)
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx91008 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx91008 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx91008 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码(一般情况下无需传入股东,系统根据组合自动获取,只有一个组合存在多个股东时需要指定.)
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx91008 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _reportSeat;
        private bool _reportSeatChanged;
        /// <summary>
        /// 申报席位(一般情况下无需传入申报席位,系统根据组合自动获取.如需多席位报盘时可传入相应席位号.)
        /// </summary>
        public string ReportSeat
        {
            get => _reportSeat;
            set {
                _reportSeatChanged = true;
                _reportSeat = value;
            }
        }
        public Ufx91008 SetReportSeat(string value)
        {
            ReportSeat = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }

        private int _entrustAmount;
        private bool _entrustAmountChanged;
        /// <summary>
        /// 委托数量(申赎数量单位为篮子数.如最小申购单位是100万份,要申赎200万,该字段填2.;该字段对ETF申赎\LOF基金赎回\基金分拆合并业务必传\转托管业务必传,LOF申购无效.)
        /// </summary>
        public int EntrustAmount
        {
            get => _entrustAmount;
            set {
                _entrustAmountChanged = true;
                _entrustAmount = value;
            }
        }
        public Ufx91008 SetEntrustAmount(int value)
        {
            EntrustAmount = value;
            return this;
        }

        private double _entrustPrice;
        private bool _entrustPriceChanged;
        /// <summary>
        /// 委托价格(转托管时该字段表示对方机构代码.该字段对转托管业务必传,其他业务无效.)
        /// </summary>
        public double EntrustPrice
        {
            get => _entrustPrice;
            set {
                _entrustPriceChanged = true;
                _entrustPrice = value;
            }
        }
        public Ufx91008 SetEntrustPrice(double value)
        {
            EntrustPrice = value;
            return this;
        }

        private double _entrustBalance;
        private bool _entrustBalanceChanged;
        /// <summary>
        /// 委托金额(LOF基金申购必填,其他业务该字段无效.)
        /// </summary>
        public double EntrustBalance
        {
            get => _entrustBalance;
            set {
                _entrustBalanceChanged = true;
                _entrustBalance = value;
            }
        }
        public Ufx91008 SetEntrustBalance(double value)
        {
            EntrustBalance = value;
            return this;
        }

        private sbyte _purchaseWay;
        private bool _purchaseWayChanged;
        /// <summary>
        /// 申赎方式(限定 <see cref="UfxPurchaseWay"/> 中定义的常量)
        /// </summary>
        public sbyte PurchaseWay
        {
            get => _purchaseWay;
            set {
                _purchaseWayChanged = true;
                _purchaseWay = value;
            }
        }
        public Ufx91008 SetPurchaseWay(sbyte value)
        {
            PurchaseWay = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx91008 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx91008 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91008 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91008 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91008 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91008 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91008 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_reportSeatChanged)
            {
                packer.AddField("report_seat", (sbyte)'S', 6, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_entrustAmountChanged)
            {
                packer.AddField("entrust_amount", (sbyte)'I', 12, 4);
            }
            if (_entrustPriceChanged)
            {
                packer.AddField("entrust_price", (sbyte)'D', 11, 4);
            }
            if (_entrustBalanceChanged)
            {
                packer.AddField("entrust_balance", (sbyte)'D', 16, 4);
            }
            if (_purchaseWayChanged)
            {
                packer.AddField("purchase_way", (sbyte)'C', 1, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_reportSeatChanged)
            {
                packer.AddStr(_reportSeat);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_entrustAmountChanged)
            {
                packer.AddInt(_entrustAmount);
            }
            if (_entrustPriceChanged)
            {
                packer.AddDouble(_entrustPrice);
            }
            if (_entrustBalanceChanged)
            {
                packer.AddDouble(_entrustBalance);
            }
            if (_purchaseWayChanged)
            {
                packer.AddChar(_purchaseWay);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 32002
    /// 功能名称: 支持查询当日基金一级市场委托流水.
    /// 业务范围: 基金
    /// </summary>
    public sealed class Ufx32002 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 32002;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        public Ufx32002(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号(按委托批号查询)
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }
        public Ufx32002 SetBatchNo(int value)
        {
            BatchNo = value;
            return this;
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号(按委托序号查询)
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }
        public Ufx32002 SetEntrustNo(int value)
        {
            EntrustNo = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx32002 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx32002 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx32002 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx32002 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx32002 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx32002 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }
        public Ufx32002 SetEntrustDirection(string value)
        {
            EntrustDirection = value;
            return this;
        }

        private string _entrustStateList;
        private bool _entrustStateListChanged;
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public string EntrustStateList
        {
            get => _entrustStateList;
            set {
                _entrustStateListChanged = true;
                _entrustStateList = value;
            }
        }
        public Ufx32002 SetEntrustStateList(string value)
        {
            EntrustStateList = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx32002 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx32002 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx32002 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx32002 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_entrustStateListChanged)
            {
                packer.AddField("entrust_state_list", (sbyte)'S', 256, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_entrustStateListChanged)
            {
                packer.AddStr(_entrustStateList);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 32005
    /// 功能名称: 支持查询ETF申赎时的成份股和资金代码委托明细信息.
    /// 业务范围: 基金
    /// </summary>
    public sealed class Ufx32005 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 32005;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        /// <param name="entrustNo">委托序号(按委托序号查询)</param>
        public Ufx32005(string userToken, int entrustNo)
        {
            UserToken = userToken;
            EntrustNo = entrustNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号(按委托序号查询)
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx32005 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx32005 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 33002
    /// 功能名称: 支持查询当日基金一级市场委托成交流水
    /// 业务范围: 基金
    /// </summary>
    public sealed class Ufx33002 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 33002;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        public Ufx33002(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx33002 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx33002 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx33002 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号()
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }
        public Ufx33002 SetEntrustNo(int value)
        {
            EntrustNo = value;
            return this;
        }

        private string _dealNo;
        private bool _dealNoChanged;
        /// <summary>
        /// 成交编号
        /// </summary>
        public string DealNo
        {
            get => _dealNo;
            set {
                _dealNoChanged = true;
                _dealNo = value;
            }
        }
        public Ufx33002 SetDealNo(string value)
        {
            DealNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx33002 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx33002 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx33002 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }
        public Ufx33002 SetEntrustDirection(string value)
        {
            EntrustDirection = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx33002 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx33002 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx33002 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx33002 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_dealNoChanged)
            {
                packer.AddField("deal_no", (sbyte)'S', 64, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_dealNoChanged)
            {
                packer.AddStr(_dealNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 33005
    /// 功能名称: 支持查询ETF申赎时的成份股和资金代码成交明细信息.
    /// 业务范围: 基金
    /// </summary>
    public sealed class Ufx33005 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 33005;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="entrustNo">委托序号()</param>
        public Ufx33005(string userToken, int entrustNo)
        {
            UserToken = userToken;
            EntrustNo = entrustNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号()
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx33005 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx33005 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 35014
    /// 功能名称: 支持查询沪深ETF成份股信息
    /// 业务范围: 基金
    /// </summary>
    public sealed class Ufx35014 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 35014;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        /// <param name="etfCode">ETF代码（二级市场）()</param>
        public Ufx35014(string userToken, string marketNo, string etfCode)
        {
            UserToken = userToken;
            MarketNo = marketNo;
            EtfCode = etfCode;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _etfCode;
        private bool _etfCodeChanged;
        /// <summary>
        /// ETF代码（二级市场）()
        /// </summary>
        public string EtfCode
        {
            get => _etfCode;
            set {
                _etfCodeChanged = true;
                _etfCode = value;
            }
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_etfCodeChanged)
            {
                packer.AddField("etf_code", (sbyte)'S', 16, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_etfCodeChanged)
            {
                packer.AddStr(_etfCode);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 35020
    /// 功能名称: 支持沪深查询ETF基础信息
    /// 业务范围: 基金
    /// </summary>
    public sealed class Ufx35020 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 35020;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        public Ufx35020(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx35020 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private sbyte _etfType;
        private bool _etfTypeChanged;
        /// <summary>
        /// ETF分类(1股票ETF;2债券ETF;3交易型货币基金;4黄金ETF;5货币市场基金)
        /// </summary>
        public sbyte EtfType
        {
            get => _etfType;
            set {
                _etfTypeChanged = true;
                _etfType = value;
            }
        }
        public Ufx35020 SetEtfType(sbyte value)
        {
            EtfType = value;
            return this;
        }

        private string _etfCode;
        private bool _etfCodeChanged;
        /// <summary>
        /// ETF代码（二级市场）(传入证券代码请同时传入交易市场)
        /// </summary>
        public string EtfCode
        {
            get => _etfCode;
            set {
                _etfCodeChanged = true;
                _etfCode = value;
            }
        }
        public Ufx35020 SetEtfCode(string value)
        {
            EtfCode = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_etfTypeChanged)
            {
                packer.AddField("etf_type", (sbyte)'C', 1, 4);
            }
            if (_etfCodeChanged)
            {
                packer.AddField("etf_code", (sbyte)'S', 16, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_etfTypeChanged)
            {
                packer.AddChar(_etfType);
            }
            if (_etfCodeChanged)
            {
                packer.AddStr(_etfCode);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 30010
    /// 功能名称: 支持查询期货市场未过期的期货信息.
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx30010 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 30010;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        public Ufx30010(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx30010 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx30010 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91004
    /// 功能名称: 支持中金所股指期货\国债期货和上期所\大商所\郑商所\能源交易所的商品期货业务
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx91004 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91004;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        /// <param name="stockCode">证券代码</param>
        /// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
        /// <param name="futuresDirection">开平方向('1'-开仓;'2'-平仓;对上期所,能源期货交易所平仓委托,优先平今仓,今仓不足,自动拆分成两笔委托.)</param>
        /// <param name="priceType">委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)</param>
        /// <param name="entrustPrice">委托价格(委托价格需要注意最小价差,需要传入方自行控制,传入不符合规则要求,则返回失败.)</param>
        /// <param name="entrustAmount">委托数量(委托数量需要注意最小买卖单位,需要传入方自行控制,传入不符合规则要求,则返回失败.)</param>
        public Ufx91004(string userToken, string marketNo, string stockCode, string entrustDirection, sbyte futuresDirection, sbyte priceType, double entrustPrice, int entrustAmount)
        {
            UserToken = userToken;
            MarketNo = marketNo;
            StockCode = stockCode;
            EntrustDirection = entrustDirection;
            FuturesDirection = futuresDirection;
            PriceType = priceType;
            EntrustPrice = entrustPrice;
            EntrustAmount = entrustAmount;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号(用户可自行指定委托批号,表示多笔委托属于同一批次.)
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }
        public Ufx91004 SetBatchNo(int value)
        {
            BatchNo = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号(账户编号\资产单元编号\组合编号三者至少要传入一项,如资产单元编号或组合编号未传入则取默认资产单元或默认组合.)
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx91004 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx91004 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx91004 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码(一般情况下无需传入股东,系统根据组合自动获取,只有一个组合存在多个股东时需要指定.PB用户请查看'PB用户须知'标签页.)
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx91004 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }

        private sbyte _futuresDirection;
        private bool _futuresDirectionChanged;
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;对上期所,能源期货交易所平仓委托,优先平今仓,今仓不足,自动拆分成两笔委托.)
        /// </summary>
        public sbyte FuturesDirection
        {
            get => _futuresDirection;
            set {
                _futuresDirectionChanged = true;
                _futuresDirection = value;
            }
        }

        private sbyte _closeDirection;
        private bool _closeDirectionChanged;
        /// <summary>
        /// 平仓类型(对上期所,能源期货交易所有效,'0'-不区分;'1'-平今;'2'-平昨.默认为'0'.期货'0'表示优先平今.)
        /// </summary>
        public sbyte CloseDirection
        {
            get => _closeDirection;
            set {
                _closeDirectionChanged = true;
                _closeDirection = value;
            }
        }
        public Ufx91004 SetCloseDirection(sbyte value)
        {
            CloseDirection = value;
            return this;
        }

        private sbyte _priceType;
        private bool _priceTypeChanged;
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType
        {
            get => _priceType;
            set {
                _priceTypeChanged = true;
                _priceType = value;
            }
        }

        private double _entrustPrice;
        private bool _entrustPriceChanged;
        /// <summary>
        /// 委托价格(委托价格需要注意最小价差,需要传入方自行控制,传入不符合规则要求,则返回失败.)
        /// </summary>
        public double EntrustPrice
        {
            get => _entrustPrice;
            set {
                _entrustPriceChanged = true;
                _entrustPrice = value;
            }
        }

        private int _entrustAmount;
        private bool _entrustAmountChanged;
        /// <summary>
        /// 委托数量(委托数量需要注意最小买卖单位,需要传入方自行控制,传入不符合规则要求,则返回失败.)
        /// </summary>
        public int EntrustAmount
        {
            get => _entrustAmount;
            set {
                _entrustAmountChanged = true;
                _entrustAmount = value;
            }
        }

        private int _limitDealAmount;
        private bool _limitDealAmountChanged;
        /// <summary>
        /// 最小成交量(仅对商品期货有效,如果可成数量小于该值,交易所不会成交.)
        /// </summary>
        public int LimitDealAmount
        {
            get => _limitDealAmount;
            set {
                _limitDealAmountChanged = true;
                _limitDealAmount = value;
            }
        }
        public Ufx91004 SetLimitDealAmount(int value)
        {
            LimitDealAmount = value;
            return this;
        }

        private sbyte _investType;
        private bool _investTypeChanged;
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType
        {
            get => _investType;
            set {
                _investTypeChanged = true;
                _investType = value;
            }
        }
        public Ufx91004 SetInvestType(sbyte value)
        {
            InvestType = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx91004 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx91004 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91004 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91004 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91004 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91004 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91004 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddField("futures_direction", (sbyte)'C', 1, 4);
            }
            if (_closeDirectionChanged)
            {
                packer.AddField("close_direction", (sbyte)'C', 1, 4);
            }
            if (_priceTypeChanged)
            {
                packer.AddField("price_type", (sbyte)'C', 1, 4);
            }
            if (_entrustPriceChanged)
            {
                packer.AddField("entrust_price", (sbyte)'D', 11, 4);
            }
            if (_entrustAmountChanged)
            {
                packer.AddField("entrust_amount", (sbyte)'I', 12, 4);
            }
            if (_limitDealAmountChanged)
            {
                packer.AddField("limit_deal_amount", (sbyte)'I', 12, 4);
            }
            if (_investTypeChanged)
            {
                packer.AddField("invest_type", (sbyte)'C', 1, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddChar(_futuresDirection);
            }
            if (_closeDirectionChanged)
            {
                packer.AddChar(_closeDirection);
            }
            if (_priceTypeChanged)
            {
                packer.AddChar(_priceType);
            }
            if (_entrustPriceChanged)
            {
                packer.AddDouble(_entrustPrice);
            }
            if (_entrustAmountChanged)
            {
                packer.AddInt(_entrustAmount);
            }
            if (_limitDealAmountChanged)
            {
                packer.AddInt(_limitDealAmount);
            }
            if (_investTypeChanged)
            {
                packer.AddChar(_investType);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91013
    /// 功能名称: 支持商品期货标准套利单\互换单业务.
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx91013 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91013;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        /// <param name="stockCode">证券代码(商品期货组合代码.)</param>
        /// <param name="entrustDirection">委托方向(控委托方向'1'-买入;'2'卖出)</param>
        /// <param name="futuresDirection">开平方向('1'-开仓;'2'-平仓;对上期所平仓委托,优先平今仓,今仓不足,自动拆分成两笔委托.)</param>
        /// <param name="priceType">委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)</param>
        /// <param name="entrustAmount">委托数量</param>
        public Ufx91013(string userToken, string marketNo, string stockCode, string entrustDirection, sbyte futuresDirection, sbyte priceType, int entrustAmount)
        {
            UserToken = userToken;
            MarketNo = marketNo;
            StockCode = stockCode;
            EntrustDirection = entrustDirection;
            FuturesDirection = futuresDirection;
            PriceType = priceType;
            EntrustAmount = entrustAmount;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号(账户编号\资产单元编号\组合编号三者至少要传入一项,如资产单元编号或组合编号未传入则取默认资产单元或默认组合.)
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx91013 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx91013 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx91013 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码(一般情况下无需传入股东,系统根据组合自动获取,只有一个组合存在多个股东时需要指定.)
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx91013 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(商品期货组合代码.)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(控委托方向'1'-买入;'2'卖出)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }

        private sbyte _futuresDirection;
        private bool _futuresDirectionChanged;
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;对上期所平仓委托,优先平今仓,今仓不足,自动拆分成两笔委托.)
        /// </summary>
        public sbyte FuturesDirection
        {
            get => _futuresDirection;
            set {
                _futuresDirectionChanged = true;
                _futuresDirection = value;
            }
        }

        private sbyte _priceType;
        private bool _priceTypeChanged;
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType
        {
            get => _priceType;
            set {
                _priceTypeChanged = true;
                _priceType = value;
            }
        }

        private double _entrustPrice;
        private bool _entrustPriceChanged;
        /// <summary>
        /// 委托价格（价差）(缺省传0,代表价差为0)
        /// </summary>
        public double EntrustPrice
        {
            get => _entrustPrice;
            set {
                _entrustPriceChanged = true;
                _entrustPrice = value;
            }
        }
        public Ufx91013 SetEntrustPrice(double value)
        {
            EntrustPrice = value;
            return this;
        }

        private int _entrustAmount;
        private bool _entrustAmountChanged;
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount
        {
            get => _entrustAmount;
            set {
                _entrustAmountChanged = true;
                _entrustAmount = value;
            }
        }

        private int _limitDealAmount;
        private bool _limitDealAmountChanged;
        /// <summary>
        /// 最小成交量(仅对FAK委托有效,如果可成数量小于该值,交易所不会成交.)
        /// </summary>
        public int LimitDealAmount
        {
            get => _limitDealAmount;
            set {
                _limitDealAmountChanged = true;
                _limitDealAmount = value;
            }
        }
        public Ufx91013 SetLimitDealAmount(int value)
        {
            LimitDealAmount = value;
            return this;
        }

        private sbyte _investType;
        private bool _investTypeChanged;
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType
        {
            get => _investType;
            set {
                _investTypeChanged = true;
                _investType = value;
            }
        }
        public Ufx91013 SetInvestType(sbyte value)
        {
            InvestType = value;
            return this;
        }

        private sbyte _portfolioType;
        private bool _portfolioTypeChanged;
        /// <summary>
        /// 组合单类型(1:套利单,2:互换单,默认为1.)
        /// </summary>
        public sbyte PortfolioType
        {
            get => _portfolioType;
            set {
                _portfolioTypeChanged = true;
                _portfolioType = value;
            }
        }
        public Ufx91013 SetPortfolioType(sbyte value)
        {
            PortfolioType = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx91013 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx91013 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91013 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91013 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91013 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91013 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91013 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddField("futures_direction", (sbyte)'C', 1, 4);
            }
            if (_priceTypeChanged)
            {
                packer.AddField("price_type", (sbyte)'C', 1, 4);
            }
            if (_entrustPriceChanged)
            {
                packer.AddField("entrust_price", (sbyte)'D', 11, 4);
            }
            if (_entrustAmountChanged)
            {
                packer.AddField("entrust_amount", (sbyte)'I', 12, 4);
            }
            if (_limitDealAmountChanged)
            {
                packer.AddField("limit_deal_amount", (sbyte)'I', 12, 4);
            }
            if (_investTypeChanged)
            {
                packer.AddField("invest_type", (sbyte)'C', 1, 4);
            }
            if (_portfolioTypeChanged)
            {
                packer.AddField("portfolio_type", (sbyte)'C', 1, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddChar(_futuresDirection);
            }
            if (_priceTypeChanged)
            {
                packer.AddChar(_priceType);
            }
            if (_entrustPriceChanged)
            {
                packer.AddDouble(_entrustPrice);
            }
            if (_entrustAmountChanged)
            {
                packer.AddInt(_entrustAmount);
            }
            if (_limitDealAmountChanged)
            {
                packer.AddInt(_limitDealAmount);
            }
            if (_investTypeChanged)
            {
                packer.AddChar(_investType);
            }
            if (_portfolioTypeChanged)
            {
                packer.AddChar(_portfolioType);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91119
    /// 功能名称: 支持按委托序号撤单,支持多条委托批量撤单
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx91119 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91119;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="accountCode">账户编号</param>
        /// <param name="combiNo">组合编号</param>
        /// <param name="entrustNo">委托序号</param>
        public Ufx91119(string userToken, string accountCode, string combiNo, int entrustNo)
        {
            UserToken = userToken;
            AccountCode = accountCode;
            CombiNo = combiNo;
            EntrustNo = entrustNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91119 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91119 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91119 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91119 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91119 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91105
    /// 功能名称: 支持按委托序号撤单,支持多条委托批量撤单
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx91105 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91105;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="entrustNo">委托序号()</param>
        public Ufx91105(string userToken, int entrustNo)
        {
            UserToken = userToken;
            EntrustNo = entrustNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号()
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91105 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91105 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91105 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91105 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91105 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91121
    /// 功能名称: 支持商品期货组合单撤单
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx91121 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91121;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="accountCode">账户编号</param>
        /// <param name="combiNo">组合编号</param>
        /// <param name="entrustNo">委托序号</param>
        public Ufx91121(string userToken, string accountCode, string combiNo, int entrustNo)
        {
            UserToken = userToken;
            AccountCode = accountCode;
            CombiNo = combiNo;
            EntrustNo = entrustNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91121 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91121 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91121 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91121 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91121 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91107
    /// 功能名称: 支持商品期货组合单撤单
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx91107 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91107;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="entrustNo">委托序号</param>
        public Ufx91107(string userToken, int entrustNo)
        {
            UserToken = userToken;
            EntrustNo = entrustNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91107 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91107 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91107 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91107 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91107 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 31003
    /// 功能名称: 支持查询期货持仓
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx31003 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 31003;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        public Ufx31003(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx31003 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx31003 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx31003 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx31003 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx31003 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx31003 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _holdSeat;
        private bool _holdSeatChanged;
        /// <summary>
        /// 持仓席位
        /// </summary>
        public string HoldSeat
        {
            get => _holdSeat;
            set {
                _holdSeatChanged = true;
                _holdSeat = value;
            }
        }
        public Ufx31003 SetHoldSeat(string value)
        {
            HoldSeat = value;
            return this;
        }

        private sbyte _investType;
        private bool _investTypeChanged;
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType
        {
            get => _investType;
            set {
                _investTypeChanged = true;
                _investType = value;
            }
        }
        public Ufx31003 SetInvestType(sbyte value)
        {
            InvestType = value;
            return this;
        }

        private sbyte _positionFlag;
        private bool _positionFlagChanged;
        /// <summary>
        /// 多空标志(限定 <see cref="UfxPositionFlag"/> 中定义的常量)
        /// </summary>
        public sbyte PositionFlag
        {
            get => _positionFlag;
            set {
                _positionFlagChanged = true;
                _positionFlag = value;
            }
        }
        public Ufx31003 SetPositionFlag(sbyte value)
        {
            PositionFlag = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_holdSeatChanged)
            {
                packer.AddField("hold_seat", (sbyte)'S', 6, 4);
            }
            if (_investTypeChanged)
            {
                packer.AddField("invest_type", (sbyte)'C', 1, 4);
            }
            if (_positionFlagChanged)
            {
                packer.AddField("position_flag", (sbyte)'C', 1, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_holdSeatChanged)
            {
                packer.AddStr(_holdSeat);
            }
            if (_investTypeChanged)
            {
                packer.AddChar(_investType);
            }
            if (_positionFlagChanged)
            {
                packer.AddChar(_positionFlag);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 31013
    /// 功能名称: 支持查询期货持仓明细
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx31013 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 31013;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        public Ufx31013(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx31013 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx31013 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx31013 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx31013 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx31013 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx31013 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private sbyte _investType;
        private bool _investTypeChanged;
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType
        {
            get => _investType;
            set {
                _investTypeChanged = true;
                _investType = value;
            }
        }
        public Ufx31013 SetInvestType(sbyte value)
        {
            InvestType = value;
            return this;
        }

        private sbyte _positionFlag;
        private bool _positionFlagChanged;
        /// <summary>
        /// 多空标志(限定 <see cref="UfxPositionFlag"/> 中定义的常量)
        /// </summary>
        public sbyte PositionFlag
        {
            get => _positionFlag;
            set {
                _positionFlagChanged = true;
                _positionFlag = value;
            }
        }
        public Ufx31013 SetPositionFlag(sbyte value)
        {
            PositionFlag = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_investTypeChanged)
            {
                packer.AddField("invest_type", (sbyte)'C', 1, 4);
            }
            if (_positionFlagChanged)
            {
                packer.AddField("position_flag", (sbyte)'C', 1, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_investTypeChanged)
            {
                packer.AddChar(_investType);
            }
            if (_positionFlagChanged)
            {
                packer.AddChar(_positionFlag);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 32003
    /// 功能名称: 支持查询当日期货委托流水
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx32003 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 32003;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        public Ufx32003(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号(按委托批号查询)
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }
        public Ufx32003 SetBatchNo(int value)
        {
            BatchNo = value;
            return this;
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号(按委托序号查询)
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }
        public Ufx32003 SetEntrustNo(int value)
        {
            EntrustNo = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx32003 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx32003 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx32003 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx32003 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx32003 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx32003 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }
        public Ufx32003 SetEntrustDirection(string value)
        {
            EntrustDirection = value;
            return this;
        }

        private sbyte _futuresDirection;
        private bool _futuresDirectionChanged;
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection
        {
            get => _futuresDirection;
            set {
                _futuresDirectionChanged = true;
                _futuresDirection = value;
            }
        }
        public Ufx32003 SetFuturesDirection(sbyte value)
        {
            FuturesDirection = value;
            return this;
        }

        private string _entrustStateList;
        private bool _entrustStateListChanged;
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public string EntrustStateList
        {
            get => _entrustStateList;
            set {
                _entrustStateListChanged = true;
                _entrustStateList = value;
            }
        }
        public Ufx32003 SetEntrustStateList(string value)
        {
            EntrustStateList = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx32003 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx32003 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx32003 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx32003 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddField("futures_direction", (sbyte)'C', 1, 4);
            }
            if (_entrustStateListChanged)
            {
                packer.AddField("entrust_state_list", (sbyte)'S', 256, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddChar(_futuresDirection);
            }
            if (_entrustStateListChanged)
            {
                packer.AddStr(_entrustStateList);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 32103
    /// 功能名称: 支持查询期货历史普通买卖委托流水
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx32103 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 32103;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        /// <param name="startDate">起始日期(查询起始日期)</param>
        /// <param name="endDate">结束日期(查询结束日期)</param>
        /// <param name="accountCode">账户编号</param>
        public Ufx32103(string userToken, int startDate, int endDate, string accountCode)
        {
            UserToken = userToken;
            StartDate = startDate;
            EndDate = endDate;
            AccountCode = accountCode;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _startDate;
        private bool _startDateChanged;
        /// <summary>
        /// 起始日期(查询起始日期)
        /// </summary>
        public int StartDate
        {
            get => _startDate;
            set {
                _startDateChanged = true;
                _startDate = value;
            }
        }

        private int _endDate;
        private bool _endDateChanged;
        /// <summary>
        /// 结束日期(查询结束日期)
        /// </summary>
        public int EndDate
        {
            get => _endDate;
            set {
                _endDateChanged = true;
                _endDate = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号(按委托批号查询)
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }
        public Ufx32103 SetBatchNo(int value)
        {
            BatchNo = value;
            return this;
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号(按委托序号查询)
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }
        public Ufx32103 SetEntrustNo(int value)
        {
            EntrustNo = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx32103 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元和组合二选一必传.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx32103 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx32103 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx32103 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx32103 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }
        public Ufx32103 SetEntrustDirection(string value)
        {
            EntrustDirection = value;
            return this;
        }

        private sbyte _futuresDirection;
        private bool _futuresDirectionChanged;
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection
        {
            get => _futuresDirection;
            set {
                _futuresDirectionChanged = true;
                _futuresDirection = value;
            }
        }
        public Ufx32103 SetFuturesDirection(sbyte value)
        {
            FuturesDirection = value;
            return this;
        }

        private string _entrustStateList;
        private bool _entrustStateListChanged;
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public string EntrustStateList
        {
            get => _entrustStateList;
            set {
                _entrustStateListChanged = true;
                _entrustStateList = value;
            }
        }
        public Ufx32103 SetEntrustStateList(string value)
        {
            EntrustStateList = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx32103 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx32103 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx32103 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx32103 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_startDateChanged)
            {
                packer.AddField("start_date", (sbyte)'I', 8, 4);
            }
            if (_endDateChanged)
            {
                packer.AddField("end_date", (sbyte)'I', 8, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddField("futures_direction", (sbyte)'C', 1, 4);
            }
            if (_entrustStateListChanged)
            {
                packer.AddField("entrust_state_list", (sbyte)'S', 256, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_startDateChanged)
            {
                packer.AddInt(_startDate);
            }
            if (_endDateChanged)
            {
                packer.AddInt(_endDate);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddChar(_futuresDirection);
            }
            if (_entrustStateListChanged)
            {
                packer.AddStr(_entrustStateList);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 32008
    /// 功能名称: 支持查询当日商品期货组合委托流水
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx32008 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 32008;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        public Ufx32008(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号(按委托批号查询)
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }
        public Ufx32008 SetBatchNo(int value)
        {
            BatchNo = value;
            return this;
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号(按委托序号查询)
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }
        public Ufx32008 SetEntrustNo(int value)
        {
            EntrustNo = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx32008 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx32008 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx32008 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx32008 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx32008 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx32008 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }
        public Ufx32008 SetEntrustDirection(string value)
        {
            EntrustDirection = value;
            return this;
        }

        private sbyte _futuresDirection;
        private bool _futuresDirectionChanged;
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection
        {
            get => _futuresDirection;
            set {
                _futuresDirectionChanged = true;
                _futuresDirection = value;
            }
        }
        public Ufx32008 SetFuturesDirection(sbyte value)
        {
            FuturesDirection = value;
            return this;
        }

        private string _entrustStateList;
        private bool _entrustStateListChanged;
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public string EntrustStateList
        {
            get => _entrustStateList;
            set {
                _entrustStateListChanged = true;
                _entrustStateList = value;
            }
        }
        public Ufx32008 SetEntrustStateList(string value)
        {
            EntrustStateList = value;
            return this;
        }

        private sbyte _portfolioType;
        private bool _portfolioTypeChanged;
        /// <summary>
        /// 组合单类型(1:套利单,2:互换单.)
        /// </summary>
        public sbyte PortfolioType
        {
            get => _portfolioType;
            set {
                _portfolioTypeChanged = true;
                _portfolioType = value;
            }
        }
        public Ufx32008 SetPortfolioType(sbyte value)
        {
            PortfolioType = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx32008 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx32008 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx32008 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx32008 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddField("futures_direction", (sbyte)'C', 1, 4);
            }
            if (_entrustStateListChanged)
            {
                packer.AddField("entrust_state_list", (sbyte)'S', 256, 4);
            }
            if (_portfolioTypeChanged)
            {
                packer.AddField("portfolio_type", (sbyte)'C', 1, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddChar(_futuresDirection);
            }
            if (_entrustStateListChanged)
            {
                packer.AddStr(_entrustStateList);
            }
            if (_portfolioTypeChanged)
            {
                packer.AddChar(_portfolioType);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 33003
    /// 功能名称: 支持查询当日期货成交流水
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx33003 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 33003;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        public Ufx33003(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx33003 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx33003 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx33003 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号()
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }
        public Ufx33003 SetEntrustNo(int value)
        {
            EntrustNo = value;
            return this;
        }

        private string _dealNo;
        private bool _dealNoChanged;
        /// <summary>
        /// 成交编号
        /// </summary>
        public string DealNo
        {
            get => _dealNo;
            set {
                _dealNoChanged = true;
                _dealNo = value;
            }
        }
        public Ufx33003 SetDealNo(string value)
        {
            DealNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx33003 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx33003 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx33003 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }
        public Ufx33003 SetEntrustDirection(string value)
        {
            EntrustDirection = value;
            return this;
        }

        private sbyte _futuresDirection;
        private bool _futuresDirectionChanged;
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection
        {
            get => _futuresDirection;
            set {
                _futuresDirectionChanged = true;
                _futuresDirection = value;
            }
        }
        public Ufx33003 SetFuturesDirection(sbyte value)
        {
            FuturesDirection = value;
            return this;
        }

        private sbyte _closeType;
        private bool _closeTypeChanged;
        /// <summary>
        /// 平仓类型(用于期货的平仓业务;0:开仓;1:普通平仓;2:强制平仓;3:到期交割;4:平昨仓;5:平今仓)
        /// </summary>
        public sbyte CloseType
        {
            get => _closeType;
            set {
                _closeTypeChanged = true;
                _closeType = value;
            }
        }
        public Ufx33003 SetCloseType(sbyte value)
        {
            CloseType = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx33003 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx33003 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx33003 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx33003 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_dealNoChanged)
            {
                packer.AddField("deal_no", (sbyte)'S', 64, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddField("futures_direction", (sbyte)'C', 1, 4);
            }
            if (_closeTypeChanged)
            {
                packer.AddField("close_type", (sbyte)'C', 1, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_dealNoChanged)
            {
                packer.AddStr(_dealNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddChar(_futuresDirection);
            }
            if (_closeTypeChanged)
            {
                packer.AddChar(_closeType);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 33103
    /// 功能名称: 支持查询期货历史期货成交流水
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx33103 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 33103;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="startDate">起始日期(查询起始日期)</param>
        /// <param name="endDate">结束日期(查询结束日期)</param>
        /// <param name="accountCode">账户编号</param>
        public Ufx33103(string userToken, int startDate, int endDate, string accountCode)
        {
            UserToken = userToken;
            StartDate = startDate;
            EndDate = endDate;
            AccountCode = accountCode;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _startDate;
        private bool _startDateChanged;
        /// <summary>
        /// 起始日期(查询起始日期)
        /// </summary>
        public int StartDate
        {
            get => _startDate;
            set {
                _startDateChanged = true;
                _startDate = value;
            }
        }

        private int _endDate;
        private bool _endDateChanged;
        /// <summary>
        /// 结束日期(查询结束日期)
        /// </summary>
        public int EndDate
        {
            get => _endDate;
            set {
                _endDateChanged = true;
                _endDate = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx33103 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx33103 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _entrustSerialList;
        private bool _entrustSerialListChanged;
        /// <summary>
        /// 委托序号串(以逗号分隔)
        /// </summary>
        public string EntrustSerialList
        {
            get => _entrustSerialList;
            set {
                _entrustSerialListChanged = true;
                _entrustSerialList = value;
            }
        }
        public Ufx33103 SetEntrustSerialList(string value)
        {
            EntrustSerialList = value;
            return this;
        }

        private string _dealNo;
        private bool _dealNoChanged;
        /// <summary>
        /// 成交编号
        /// </summary>
        public string DealNo
        {
            get => _dealNo;
            set {
                _dealNoChanged = true;
                _dealNo = value;
            }
        }
        public Ufx33103 SetDealNo(string value)
        {
            DealNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx33103 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx33103 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx33103 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }
        public Ufx33103 SetEntrustDirection(string value)
        {
            EntrustDirection = value;
            return this;
        }

        private sbyte _futuresDirection;
        private bool _futuresDirectionChanged;
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection
        {
            get => _futuresDirection;
            set {
                _futuresDirectionChanged = true;
                _futuresDirection = value;
            }
        }
        public Ufx33103 SetFuturesDirection(sbyte value)
        {
            FuturesDirection = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx33103 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx33103 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx33103 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx33103 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_startDateChanged)
            {
                packer.AddField("start_date", (sbyte)'I', 8, 4);
            }
            if (_endDateChanged)
            {
                packer.AddField("end_date", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_entrustSerialListChanged)
            {
                packer.AddField("entrust_serial_list", (sbyte)'S', 512, 4);
            }
            if (_dealNoChanged)
            {
                packer.AddField("deal_no", (sbyte)'S', 64, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddField("futures_direction", (sbyte)'C', 1, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_startDateChanged)
            {
                packer.AddInt(_startDate);
            }
            if (_endDateChanged)
            {
                packer.AddInt(_endDate);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_entrustSerialListChanged)
            {
                packer.AddStr(_entrustSerialList);
            }
            if (_dealNoChanged)
            {
                packer.AddStr(_dealNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddChar(_futuresDirection);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 34003
    /// 功能名称: 支持查询期货保证金账户的资金可用信息,可查询期货\股指期权\商品期权可用保证金,支持批量传入.
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx34003 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 34003;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        public Ufx34003(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx34003 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx34003 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx34003 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 35023
    /// 功能名称: 支持期货费率查询,支持中金所股指期货\国债期货和上期所\大商所\郑商所\能源交易所的商品期货业务
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx35023 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 35023;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        /// <param name="accountCode">账户编号</param>
        /// <param name="assetNo">资产单元编号</param>
        public Ufx35023(string userToken, string accountCode, string assetNo)
        {
            UserToken = userToken;
            AccountCode = accountCode;
            AssetNo = assetNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx35023 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }
        public Ufx35023 SetEntrustDirection(string value)
        {
            EntrustDirection = value;
            return this;
        }

        private sbyte _futuresDirection;
        private bool _futuresDirectionChanged;
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection
        {
            get => _futuresDirection;
            set {
                _futuresDirectionChanged = true;
                _futuresDirection = value;
            }
        }
        public Ufx35023 SetFuturesDirection(sbyte value)
        {
            FuturesDirection = value;
            return this;
        }

        private string _stockType;
        private bool _stockTypeChanged;
        /// <summary>
        /// 证券类别('0v'-商品期货;'0W'-国债期货;'0R'-股指期货)
        /// </summary>
        public string StockType
        {
            get => _stockType;
            set {
                _stockTypeChanged = true;
                _stockType = value;
            }
        }
        public Ufx35023 SetStockType(string value)
        {
            StockType = value;
            return this;
        }

        private int _futureKindId;
        private bool _futureKindIdChanged;
        /// <summary>
        /// 期货品种序号(限定 <see cref="UfxFutureKindId"/> 中定义的常量)
        /// </summary>
        public int FutureKindId
        {
            get => _futureKindId;
            set {
                _futureKindIdChanged = true;
                _futureKindId = value;
            }
        }
        public Ufx35023 SetFutureKindId(int value)
        {
            FutureKindId = value;
            return this;
        }

        private sbyte _feeType;
        private bool _feeTypeChanged;
        /// <summary>
        /// 费用类别('a'-结算费;'b'-交割费;'e'-期货公司结算费)
        /// </summary>
        public sbyte FeeType
        {
            get => _feeType;
            set {
                _feeTypeChanged = true;
                _feeType = value;
            }
        }
        public Ufx35023 SetFeeType(sbyte value)
        {
            FeeType = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认从0开始,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx35023 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx35023 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddField("futures_direction", (sbyte)'C', 1, 4);
            }
            if (_stockTypeChanged)
            {
                packer.AddField("stock_type", (sbyte)'S', 4, 4);
            }
            if (_futureKindIdChanged)
            {
                packer.AddField("future_kind_id", (sbyte)'I', 8, 4);
            }
            if (_feeTypeChanged)
            {
                packer.AddField("fee_type", (sbyte)'C', 1, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddChar(_futuresDirection);
            }
            if (_stockTypeChanged)
            {
                packer.AddStr(_stockType);
            }
            if (_futureKindIdChanged)
            {
                packer.AddInt(_futureKindId);
            }
            if (_feeTypeChanged)
            {
                packer.AddChar(_feeType);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 30012
    /// 功能名称: 支持查询期权信息.
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx30012 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 30012;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        public Ufx30012(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private sbyte _optionType;
        private bool _optionTypeChanged;
        /// <summary>
        /// 期权类型(限定 <see cref="UfxOptionType"/> 中定义的常量)
        /// </summary>
        public sbyte OptionType
        {
            get => _optionType;
            set {
                _optionTypeChanged = true;
                _optionType = value;
            }
        }
        public Ufx30012 SetOptionType(sbyte value)
        {
            OptionType = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx30012 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(如果传入代码,那么必须传入市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx30012 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx30012 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx30012 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_optionTypeChanged)
            {
                packer.AddField("option_type", (sbyte)'C', 1, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_optionTypeChanged)
            {
                packer.AddChar(_optionType);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91005
    /// 功能名称: 支持沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权交易业务
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91005 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91005;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        /// <param name="stockCode">证券代码</param>
        /// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
        /// <param name="futuresDirection">开平方向('1'-开仓;'2'-平仓.)</param>
        /// <param name="priceType">委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)</param>
        /// <param name="entrustPrice">委托价格(委托价格需要注意最小价差,需要传入方自行控制,传入不符合规则要求,则返回失败.)</param>
        /// <param name="entrustAmount">委托数量(委托数量需要注意最小买卖单位,需要传入方自行控制,传入不符合规则要求,则返回失败.)</param>
        public Ufx91005(string userToken, string marketNo, string stockCode, string entrustDirection, sbyte futuresDirection, sbyte priceType, double entrustPrice, int entrustAmount)
        {
            UserToken = userToken;
            MarketNo = marketNo;
            StockCode = stockCode;
            EntrustDirection = entrustDirection;
            FuturesDirection = futuresDirection;
            PriceType = priceType;
            EntrustPrice = entrustPrice;
            EntrustAmount = entrustAmount;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号(用户可自行指定委托批号,表示多笔委托属于同一批次.)
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }
        public Ufx91005 SetBatchNo(int value)
        {
            BatchNo = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号(账户编号\资产单元编号\组合编号三者至少要传入一项,如资产单元编号或组合编号未传入则取默认资产单元或默认组合.)
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx91005 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx91005 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx91005 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码(一般情况下无需传入股东,系统根据组合自动获取,只有一个组合存在多个股东时需要指定.PB用户请查看'PB用户须知'标签页.)
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx91005 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _reportSeat;
        private bool _reportSeatChanged;
        /// <summary>
        /// 申报席位(一般情况下无需传入申报席位,系统根据组合自动获取.如需多席位报盘时可传入相应席位号.股指期权,商品期权席位字段无效)
        /// </summary>
        public string ReportSeat
        {
            get => _reportSeat;
            set {
                _reportSeatChanged = true;
                _reportSeat = value;
            }
        }
        public Ufx91005 SetReportSeat(string value)
        {
            ReportSeat = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }

        private sbyte _futuresDirection;
        private bool _futuresDirectionChanged;
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓.)
        /// </summary>
        public sbyte FuturesDirection
        {
            get => _futuresDirection;
            set {
                _futuresDirectionChanged = true;
                _futuresDirection = value;
            }
        }

        private sbyte _closeDirection;
        private bool _closeDirectionChanged;
        /// <summary>
        /// 平仓类型(对上期所有效:'0'-不区分;'1'-平今;'2'-平昨;默认传'0'.期权'0'表示优先平昨.)
        /// </summary>
        public sbyte CloseDirection
        {
            get => _closeDirection;
            set {
                _closeDirectionChanged = true;
                _closeDirection = value;
            }
        }
        public Ufx91005 SetCloseDirection(sbyte value)
        {
            CloseDirection = value;
            return this;
        }

        private sbyte _priceType;
        private bool _priceTypeChanged;
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType
        {
            get => _priceType;
            set {
                _priceTypeChanged = true;
                _priceType = value;
            }
        }

        private double _entrustPrice;
        private bool _entrustPriceChanged;
        /// <summary>
        /// 委托价格(委托价格需要注意最小价差,需要传入方自行控制,传入不符合规则要求,则返回失败.)
        /// </summary>
        public double EntrustPrice
        {
            get => _entrustPrice;
            set {
                _entrustPriceChanged = true;
                _entrustPrice = value;
            }
        }

        private int _entrustAmount;
        private bool _entrustAmountChanged;
        /// <summary>
        /// 委托数量(委托数量需要注意最小买卖单位,需要传入方自行控制,传入不符合规则要求,则返回失败.)
        /// </summary>
        public int EntrustAmount
        {
            get => _entrustAmount;
            set {
                _entrustAmountChanged = true;
                _entrustAmount = value;
            }
        }

        private sbyte _coveredFlag;
        private bool _coveredFlagChanged;
        /// <summary>
        /// 备兑标志(仅对个股(股票)期权的认购期权卖出开仓和买入平仓有效.1:备兑,0:非备兑,默认为0.)
        /// </summary>
        public sbyte CoveredFlag
        {
            get => _coveredFlag;
            set {
                _coveredFlagChanged = true;
                _coveredFlag = value;
            }
        }
        public Ufx91005 SetCoveredFlag(sbyte value)
        {
            CoveredFlag = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx91005 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx91005 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91005 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91005 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91005 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91005 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91005 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_reportSeatChanged)
            {
                packer.AddField("report_seat", (sbyte)'S', 6, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddField("futures_direction", (sbyte)'C', 1, 4);
            }
            if (_closeDirectionChanged)
            {
                packer.AddField("close_direction", (sbyte)'C', 1, 4);
            }
            if (_priceTypeChanged)
            {
                packer.AddField("price_type", (sbyte)'C', 1, 4);
            }
            if (_entrustPriceChanged)
            {
                packer.AddField("entrust_price", (sbyte)'D', 11, 4);
            }
            if (_entrustAmountChanged)
            {
                packer.AddField("entrust_amount", (sbyte)'I', 12, 4);
            }
            if (_coveredFlagChanged)
            {
                packer.AddField("covered_flag", (sbyte)'C', 1, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_reportSeatChanged)
            {
                packer.AddStr(_reportSeat);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddChar(_futuresDirection);
            }
            if (_closeDirectionChanged)
            {
                packer.AddChar(_closeDirection);
            }
            if (_priceTypeChanged)
            {
                packer.AddChar(_priceType);
            }
            if (_entrustPriceChanged)
            {
                packer.AddDouble(_entrustPrice);
            }
            if (_entrustAmountChanged)
            {
                packer.AddInt(_entrustAmount);
            }
            if (_coveredFlagChanged)
            {
                packer.AddChar(_coveredFlag);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91006
    /// 功能名称: 支持上海股票期权保证券的锁定与解锁业务
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91006 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91006;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        /// <param name="stockCode">证券代码</param>
        /// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
        /// <param name="entrustAmount">委托数量(委托数量需要注意最小买卖单位,需要传入方自行控制,传入不符合规则要求,则返回失败.)</param>
        public Ufx91006(string userToken, string marketNo, string stockCode, string entrustDirection, int entrustAmount)
        {
            UserToken = userToken;
            MarketNo = marketNo;
            StockCode = stockCode;
            EntrustDirection = entrustDirection;
            EntrustAmount = entrustAmount;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号(用户可自行指定委托批号,表示多笔委托属于同一批次.)
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }
        public Ufx91006 SetBatchNo(int value)
        {
            BatchNo = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号(账户编号\资产单元编号\组合编号三者至少要传入一项,如资产单元编号或组合编号未传入则取默认资产单元或默认组合.)
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx91006 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx91006 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx91006 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码(一般情况下无需传入股东,系统根据组合自动获取,只有一个组合存在多个股东时需要指定.)
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx91006 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _reportSeat;
        private bool _reportSeatChanged;
        /// <summary>
        /// 申报席位(一般情况下无需传入申报席位,系统根据组合自动获取.如需多席位报盘时可传入相应席位号.)
        /// </summary>
        public string ReportSeat
        {
            get => _reportSeat;
            set {
                _reportSeatChanged = true;
                _reportSeat = value;
            }
        }
        public Ufx91006 SetReportSeat(string value)
        {
            ReportSeat = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }

        private int _entrustAmount;
        private bool _entrustAmountChanged;
        /// <summary>
        /// 委托数量(委托数量需要注意最小买卖单位,需要传入方自行控制,传入不符合规则要求,则返回失败.)
        /// </summary>
        public int EntrustAmount
        {
            get => _entrustAmount;
            set {
                _entrustAmountChanged = true;
                _entrustAmount = value;
            }
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx91006 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx91006 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91006 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91006 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91006 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91006 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91006 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_reportSeatChanged)
            {
                packer.AddField("report_seat", (sbyte)'S', 6, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_entrustAmountChanged)
            {
                packer.AddField("entrust_amount", (sbyte)'I', 12, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_reportSeatChanged)
            {
                packer.AddStr(_reportSeat);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_entrustAmountChanged)
            {
                packer.AddInt(_entrustAmount);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91007
    /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权业务
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91007 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91007;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        /// <param name="stockCode">证券代码</param>
        /// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
        public Ufx91007(string userToken, string marketNo, string stockCode, string entrustDirection)
        {
            UserToken = userToken;
            MarketNo = marketNo;
            StockCode = stockCode;
            EntrustDirection = entrustDirection;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号(用户可自行指定委托批号,表示多笔委托属于同一批次.)
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }
        public Ufx91007 SetBatchNo(int value)
        {
            BatchNo = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号(账户编号\资产单元编号\组合编号三者至少要传入一项,如资产单元编号或组合编号未传入则取默认资产单元或默认组合.)
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx91007 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx91007 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx91007 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码(一般情况下无需传入股东,系统根据组合自动获取,只有一个组合存在多个股东时需要指定.)
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx91007 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _reportSeat;
        private bool _reportSeatChanged;
        /// <summary>
        /// 申报席位(一般情况下无需传入申报席位,系统根据组合自动获取.如需多席位报盘时可传入相应席位号.商品期权席位字段无效)
        /// </summary>
        public string ReportSeat
        {
            get => _reportSeat;
            set {
                _reportSeatChanged = true;
                _reportSeat = value;
            }
        }
        public Ufx91007 SetReportSeat(string value)
        {
            ReportSeat = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }

        private int _entrustAmount;
        private bool _entrustAmountChanged;
        /// <summary>
        /// 委托数量(取消期权对冲\取消期货对冲时,该字段无效;其他委托方向,该字段必传)
        /// </summary>
        public int EntrustAmount
        {
            get => _entrustAmount;
            set {
                _entrustAmountChanged = true;
                _entrustAmount = value;
            }
        }
        public Ufx91007 SetEntrustAmount(int value)
        {
            EntrustAmount = value;
            return this;
        }

        private sbyte _autoDropFlag;
        private bool _autoDropFlagChanged;
        /// <summary>
        /// 自动平仓标志(上期所,大商所商品期权行权有效,期权行权后得到的期货是否与原有期货持仓对冲.0\不自动平仓;1\自动平仓.默认不自动平仓.)
        /// </summary>
        public sbyte AutoDropFlag
        {
            get => _autoDropFlag;
            set {
                _autoDropFlagChanged = true;
                _autoDropFlag = value;
            }
        }
        public Ufx91007 SetAutoDropFlag(sbyte value)
        {
            AutoDropFlag = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx91007 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx91007 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91007 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91007 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91007 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91007 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91007 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_reportSeatChanged)
            {
                packer.AddField("report_seat", (sbyte)'S', 6, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_entrustAmountChanged)
            {
                packer.AddField("entrust_amount", (sbyte)'I', 12, 4);
            }
            if (_autoDropFlagChanged)
            {
                packer.AddField("auto_drop_flag", (sbyte)'C', 1, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_reportSeatChanged)
            {
                packer.AddStr(_reportSeat);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_entrustAmountChanged)
            {
                packer.AddInt(_entrustAmount);
            }
            if (_autoDropFlagChanged)
            {
                packer.AddChar(_autoDropFlag);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91025
    /// 功能名称: 支持上交所股票期权合并行权业务
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91025 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91025;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        /// <param name="stockCode">证券代码(认购期权合约代码)</param>
        /// <param name="stockCode2">证券代码2(认沽期权合约代码)</param>
        /// <param name="entrustAmount">委托数量(行权数量)</param>
        public Ufx91025(string userToken, string marketNo, string stockCode, string stockCode2, int entrustAmount)
        {
            UserToken = userToken;
            MarketNo = marketNo;
            StockCode = stockCode;
            StockCode2 = stockCode2;
            EntrustAmount = entrustAmount;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号(账户编号\资产单元编号\组合编号三者至少要传入一项,如资产单元编号或组合编号未传入则取默认资产单元或默认组合.)
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx91025 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx91025 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx91025 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx91025 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _reportSeat;
        private bool _reportSeatChanged;
        /// <summary>
        /// 申报席位(一般情况下无需传入申报席位,系统根据组合自动获取.如需多席位报盘时可传入相应席位号.)
        /// </summary>
        public string ReportSeat
        {
            get => _reportSeat;
            set {
                _reportSeatChanged = true;
                _reportSeat = value;
            }
        }
        public Ufx91025 SetReportSeat(string value)
        {
            ReportSeat = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(认购期权合约代码)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }

        private string _stockCode2;
        private bool _stockCode2Changed;
        /// <summary>
        /// 证券代码2(认沽期权合约代码)
        /// </summary>
        public string StockCode2
        {
            get => _stockCode2;
            set {
                _stockCode2Changed = true;
                _stockCode2 = value;
            }
        }

        private int _entrustAmount;
        private bool _entrustAmountChanged;
        /// <summary>
        /// 委托数量(行权数量)
        /// </summary>
        public int EntrustAmount
        {
            get => _entrustAmount;
            set {
                _entrustAmountChanged = true;
                _entrustAmount = value;
            }
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx91025 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.避免使用"|".)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx91025 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91025 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91025 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91025 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91025 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91025 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 32, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_reportSeatChanged)
            {
                packer.AddField("report_seat", (sbyte)'S', 6, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_stockCode2Changed)
            {
                packer.AddField("stock_code2", (sbyte)'S', 16, 4);
            }
            if (_entrustAmountChanged)
            {
                packer.AddField("entrust_amount", (sbyte)'I', 12, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_reportSeatChanged)
            {
                packer.AddStr(_reportSeat);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_stockCode2Changed)
            {
                packer.AddStr(_stockCode2);
            }
            if (_entrustAmountChanged)
            {
                packer.AddInt(_entrustAmount);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91126
    /// 功能名称: 支持上交所期权合并行权撤单,可传入多条委托序号进行批量撤单.最多支持1000笔
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91126 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91126;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="accountCode">账户编号</param>
        /// <param name="combiNo">组合编号</param>
        /// <param name="entrustNo">委托序号</param>
        public Ufx91126(string userToken, string accountCode, string combiNo, int entrustNo)
        {
            UserToken = userToken;
            AccountCode = accountCode;
            CombiNo = combiNo;
            EntrustNo = entrustNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91126 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91126 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91126 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91126 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91126 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 32017
    /// 功能名称: 支持查询当日上交所合并行权委托
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx32017 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 32017;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="accountCode">账户编号</param>
        public Ufx32017(string userToken, string accountCode)
        {
            UserToken = userToken;
            AccountCode = accountCode;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号(按委托批号查询)
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }
        public Ufx32017 SetBatchNo(int value)
        {
            BatchNo = value;
            return this;
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }
        public Ufx32017 SetEntrustNo(int value)
        {
            EntrustNo = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx32017 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元和组合二选一必传.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx32017 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx32017 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx32017 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(认购期权合约代码,传入合约代码必须同时传入市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx32017 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _stockCode2;
        private bool _stockCode2Changed;
        /// <summary>
        /// 证券代码2(认沽期权合约代码,传入合约代码必须同时传入市场)
        /// </summary>
        public string StockCode2
        {
            get => _stockCode2;
            set {
                _stockCode2Changed = true;
                _stockCode2 = value;
            }
        }
        public Ufx32017 SetStockCode2(string value)
        {
            StockCode2 = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx32017 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.避免使用"|".)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx32017 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx32017 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx32017 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 32, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_stockCode2Changed)
            {
                packer.AddField("stock_code2", (sbyte)'S', 16, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_stockCode2Changed)
            {
                packer.AddStr(_stockCode2);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91012
    /// 功能名称: 支持股指期权做市业务
    /// 业务范围: 期权
    /// </summary>
    [Obsolete("不维护")]
    public sealed class Ufx91012 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91012;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        /// <param name="stockCode">证券代码</param>
        public Ufx91012(string userToken, string marketNo, string stockCode)
        {
            UserToken = userToken;
            MarketNo = marketNo;
            StockCode = stockCode;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号(账户编号\资产单元编号\组合编号三者至少要传入一项,如资产单元编号或组合编号未传入则取默认资产单元或默认组合.)
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx91012 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx91012 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx91012 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码(为空则取默认股东)
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx91012 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _reportSeat;
        private bool _reportSeatChanged;
        /// <summary>
        /// 申报席位(为空则取默认席位)
        /// </summary>
        public string ReportSeat
        {
            get => _reportSeat;
            set {
                _reportSeatChanged = true;
                _reportSeat = value;
            }
        }
        public Ufx91012 SetReportSeat(string value)
        {
            ReportSeat = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }

        private sbyte _buyDirection;
        private bool _buyDirectionChanged;
        /// <summary>
        /// 买入开平方向 
        /// </summary>
        public sbyte BuyDirection
        {
            get => _buyDirection;
            set {
                _buyDirectionChanged = true;
                _buyDirection = value;
            }
        }
        public Ufx91012 SetBuyDirection(sbyte value)
        {
            BuyDirection = value;
            return this;
        }

        private double _buyPrice;
        private bool _buyPriceChanged;
        /// <summary>
        /// 买入价格(买入开平方向\买入价格\买入数量为一对,表示买入;;卖出开平方向\格\卖出数量为一对,表示卖出.;买入\卖出方向两者至少传入一方)
        /// </summary>
        public double BuyPrice
        {
            get => _buyPrice;
            set {
                _buyPriceChanged = true;
                _buyPrice = value;
            }
        }
        public Ufx91012 SetBuyPrice(double value)
        {
            BuyPrice = value;
            return this;
        }

        private int _buyAmount;
        private bool _buyAmountChanged;
        /// <summary>
        /// 买入数量
        /// </summary>
        public int BuyAmount
        {
            get => _buyAmount;
            set {
                _buyAmountChanged = true;
                _buyAmount = value;
            }
        }
        public Ufx91012 SetBuyAmount(int value)
        {
            BuyAmount = value;
            return this;
        }

        private sbyte _sellDirection;
        private bool _sellDirectionChanged;
        /// <summary>
        /// 卖出开平方向 
        /// </summary>
        public sbyte SellDirection
        {
            get => _sellDirection;
            set {
                _sellDirectionChanged = true;
                _sellDirection = value;
            }
        }
        public Ufx91012 SetSellDirection(sbyte value)
        {
            SellDirection = value;
            return this;
        }

        private double _sellPrice;
        private bool _sellPriceChanged;
        /// <summary>
        /// 卖出价格(买入开平方向\买入价格\买入数量为一对,表示买入;;卖出开平方向\格\卖出数量为一对,表示卖出.;买入\卖出方向两者至少传入一方)
        /// </summary>
        public double SellPrice
        {
            get => _sellPrice;
            set {
                _sellPriceChanged = true;
                _sellPrice = value;
            }
        }
        public Ufx91012 SetSellPrice(double value)
        {
            SellPrice = value;
            return this;
        }

        private int _sellAmount;
        private bool _sellAmountChanged;
        /// <summary>
        /// 卖出数量
        /// </summary>
        public int SellAmount
        {
            get => _sellAmount;
            set {
                _sellAmountChanged = true;
                _sellAmount = value;
            }
        }
        public Ufx91012 SetSellAmount(int value)
        {
            SellAmount = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx91012 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91012 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91012 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91012 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91012 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91012 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_reportSeatChanged)
            {
                packer.AddField("report_seat", (sbyte)'S', 6, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_buyDirectionChanged)
            {
                packer.AddField("buy_direction", (sbyte)'C', 1, 4);
            }
            if (_buyPriceChanged)
            {
                packer.AddField("buy_price", (sbyte)'D', 11, 4);
            }
            if (_buyAmountChanged)
            {
                packer.AddField("buy_amount", (sbyte)'I', 12, 4);
            }
            if (_sellDirectionChanged)
            {
                packer.AddField("sell_direction", (sbyte)'C', 1, 4);
            }
            if (_sellPriceChanged)
            {
                packer.AddField("sell_price", (sbyte)'D', 11, 4);
            }
            if (_sellAmountChanged)
            {
                packer.AddField("sell_amount", (sbyte)'I', 12, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_reportSeatChanged)
            {
                packer.AddStr(_reportSeat);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_buyDirectionChanged)
            {
                packer.AddChar(_buyDirection);
            }
            if (_buyPriceChanged)
            {
                packer.AddDouble(_buyPrice);
            }
            if (_buyAmountChanged)
            {
                packer.AddInt(_buyAmount);
            }
            if (_sellDirectionChanged)
            {
                packer.AddChar(_sellDirection);
            }
            if (_sellPriceChanged)
            {
                packer.AddDouble(_sellPrice);
            }
            if (_sellAmountChanged)
            {
                packer.AddInt(_sellAmount);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91014
    /// 功能名称: 支持深交所股票期权,中金所股指期权做市业务,支持批量传入
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91014 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91014;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        /// <param name="stockCode">证券代码</param>
        public Ufx91014(string userToken, string marketNo, string stockCode)
        {
            UserToken = userToken;
            MarketNo = marketNo;
            StockCode = stockCode;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号(账户编号\资产单元编号\组合编号三者至少要传入一项,如资产单元编号或组合编号未传入则取默认资产单元或默认组合.)
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx91014 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx91014 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx91014 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码(为空则取默认股东.)
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx91014 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _reportSeat;
        private bool _reportSeatChanged;
        /// <summary>
        /// 申报席位(为空则取默认席位)
        /// </summary>
        public string ReportSeat
        {
            get => _reportSeat;
            set {
                _reportSeatChanged = true;
                _reportSeat = value;
            }
        }
        public Ufx91014 SetReportSeat(string value)
        {
            ReportSeat = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }

        private sbyte _buyDirection;
        private bool _buyDirectionChanged;
        /// <summary>
        /// 买入开平方向 ('1'-开仓;'2'-平仓.)
        /// </summary>
        public sbyte BuyDirection
        {
            get => _buyDirection;
            set {
                _buyDirectionChanged = true;
                _buyDirection = value;
            }
        }
        public Ufx91014 SetBuyDirection(sbyte value)
        {
            BuyDirection = value;
            return this;
        }

        private double _buyPrice;
        private bool _buyPriceChanged;
        /// <summary>
        /// 买入价格(买入开平方向\买入价格\买入数量三个字段为一组(卖出同上),买入和卖出至少填入一方.根据交易所规则,同一个代码同一买卖方向只能有一个有效挂单,如有新委托,原委托会自动撤单.如果新委托只报了买卖中的一方(另一方委托价格数量为0),原委托也只撤报单的一方.例子见业务说明.)
        /// </summary>
        public double BuyPrice
        {
            get => _buyPrice;
            set {
                _buyPriceChanged = true;
                _buyPrice = value;
            }
        }
        public Ufx91014 SetBuyPrice(double value)
        {
            BuyPrice = value;
            return this;
        }

        private int _buyAmount;
        private bool _buyAmountChanged;
        /// <summary>
        /// 买入数量
        /// </summary>
        public int BuyAmount
        {
            get => _buyAmount;
            set {
                _buyAmountChanged = true;
                _buyAmount = value;
            }
        }
        public Ufx91014 SetBuyAmount(int value)
        {
            BuyAmount = value;
            return this;
        }

        private sbyte _sellDirection;
        private bool _sellDirectionChanged;
        /// <summary>
        /// 卖出开平方向 ('1'-开仓;'2'-平仓.)
        /// </summary>
        public sbyte SellDirection
        {
            get => _sellDirection;
            set {
                _sellDirectionChanged = true;
                _sellDirection = value;
            }
        }
        public Ufx91014 SetSellDirection(sbyte value)
        {
            SellDirection = value;
            return this;
        }

        private double _sellPrice;
        private bool _sellPriceChanged;
        /// <summary>
        /// 卖出价格
        /// </summary>
        public double SellPrice
        {
            get => _sellPrice;
            set {
                _sellPriceChanged = true;
                _sellPrice = value;
            }
        }
        public Ufx91014 SetSellPrice(double value)
        {
            SellPrice = value;
            return this;
        }

        private int _sellAmount;
        private bool _sellAmountChanged;
        /// <summary>
        /// 卖出数量
        /// </summary>
        public int SellAmount
        {
            get => _sellAmount;
            set {
                _sellAmountChanged = true;
                _sellAmount = value;
            }
        }
        public Ufx91014 SetSellAmount(int value)
        {
            SellAmount = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx91014 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx91014 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91014 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91014 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91014 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91014 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91014 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_reportSeatChanged)
            {
                packer.AddField("report_seat", (sbyte)'S', 6, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_buyDirectionChanged)
            {
                packer.AddField("buy_direction", (sbyte)'C', 1, 4);
            }
            if (_buyPriceChanged)
            {
                packer.AddField("buy_price", (sbyte)'D', 11, 4);
            }
            if (_buyAmountChanged)
            {
                packer.AddField("buy_amount", (sbyte)'I', 12, 4);
            }
            if (_sellDirectionChanged)
            {
                packer.AddField("sell_direction", (sbyte)'C', 1, 4);
            }
            if (_sellPriceChanged)
            {
                packer.AddField("sell_price", (sbyte)'D', 11, 4);
            }
            if (_sellAmountChanged)
            {
                packer.AddField("sell_amount", (sbyte)'I', 12, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_reportSeatChanged)
            {
                packer.AddStr(_reportSeat);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_buyDirectionChanged)
            {
                packer.AddChar(_buyDirection);
            }
            if (_buyPriceChanged)
            {
                packer.AddDouble(_buyPrice);
            }
            if (_buyAmountChanged)
            {
                packer.AddInt(_buyAmount);
            }
            if (_sellDirectionChanged)
            {
                packer.AddChar(_sellDirection);
            }
            if (_sellPriceChanged)
            {
                packer.AddDouble(_sellPrice);
            }
            if (_sellAmountChanged)
            {
                packer.AddInt(_sellAmount);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91091
    /// 功能名称: 支持上交所股票期权篮子委托业务,用于股票期权批量下单和做市委托.
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91091 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91091;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        /// <param name="stockCode">证券代码</param>
        /// <param name="entrustDirection">买卖方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
        /// <param name="futuresDirection">开平方向('1'-开仓;'2'-平仓;仅对期权有效.)</param>
        /// <param name="priceType">委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)</param>
        /// <param name="entrustPrice">委托价格(当价格类型为市价时,价格传0)</param>
        /// <param name="entrustAmount">委托数量</param>
        public Ufx91091(string userToken, string marketNo, string stockCode, string entrustDirection, sbyte futuresDirection, sbyte priceType, double entrustPrice, int entrustAmount)
        {
            UserToken = userToken;
            MarketNo = marketNo;
            StockCode = stockCode;
            EntrustDirection = entrustDirection;
            FuturesDirection = futuresDirection;
            PriceType = priceType;
            EntrustPrice = entrustPrice;
            EntrustAmount = entrustAmount;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号(账户编号\资产单元编号\组合编号三者至少要传入一项,如资产单元编号或组合编号未传入则取默认资产单元或默认组合.账户编号建议传入,否则将影响性能.)
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx91091 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx91091 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx91091 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码(为空,取默认股东)
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx91091 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _reportSeat;
        private bool _reportSeatChanged;
        /// <summary>
        /// 申报席位(为空,取默认席位)
        /// </summary>
        public string ReportSeat
        {
            get => _reportSeat;
            set {
                _reportSeatChanged = true;
                _reportSeat = value;
            }
        }
        public Ufx91091 SetReportSeat(string value)
        {
            ReportSeat = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 买卖方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }

        private sbyte _futuresDirection;
        private bool _futuresDirectionChanged;
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;仅对期权有效.)
        /// </summary>
        public sbyte FuturesDirection
        {
            get => _futuresDirection;
            set {
                _futuresDirectionChanged = true;
                _futuresDirection = value;
            }
        }

        private sbyte _priceType;
        private bool _priceTypeChanged;
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType
        {
            get => _priceType;
            set {
                _priceTypeChanged = true;
                _priceType = value;
            }
        }

        private double _entrustPrice;
        private bool _entrustPriceChanged;
        /// <summary>
        /// 委托价格(当价格类型为市价时,价格传0)
        /// </summary>
        public double EntrustPrice
        {
            get => _entrustPrice;
            set {
                _entrustPriceChanged = true;
                _entrustPrice = value;
            }
        }

        private int _entrustAmount;
        private bool _entrustAmountChanged;
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount
        {
            get => _entrustAmount;
            set {
                _entrustAmountChanged = true;
                _entrustAmount = value;
            }
        }

        private sbyte _coveredFlag;
        private bool _coveredFlagChanged;
        /// <summary>
        /// 备兑标志(仅对股票期权有效.1:备兑,0:非备兑,默认为0.)
        /// </summary>
        public sbyte CoveredFlag
        {
            get => _coveredFlag;
            set {
                _coveredFlagChanged = true;
                _coveredFlag = value;
            }
        }
        public Ufx91091 SetCoveredFlag(sbyte value)
        {
            CoveredFlag = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx91091 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx91091 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91091 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91091 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91091 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91091 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91091 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_reportSeatChanged)
            {
                packer.AddField("report_seat", (sbyte)'S', 6, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddField("futures_direction", (sbyte)'C', 1, 4);
            }
            if (_priceTypeChanged)
            {
                packer.AddField("price_type", (sbyte)'C', 1, 4);
            }
            if (_entrustPriceChanged)
            {
                packer.AddField("entrust_price", (sbyte)'D', 11, 4);
            }
            if (_entrustAmountChanged)
            {
                packer.AddField("entrust_amount", (sbyte)'I', 12, 4);
            }
            if (_coveredFlagChanged)
            {
                packer.AddField("covered_flag", (sbyte)'C', 1, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_reportSeatChanged)
            {
                packer.AddStr(_reportSeat);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddChar(_futuresDirection);
            }
            if (_priceTypeChanged)
            {
                packer.AddChar(_priceType);
            }
            if (_entrustPriceChanged)
            {
                packer.AddDouble(_entrustPrice);
            }
            if (_entrustAmountChanged)
            {
                packer.AddInt(_entrustAmount);
            }
            if (_coveredFlagChanged)
            {
                packer.AddChar(_coveredFlag);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91016
    /// 功能名称: 支持上交所股票期权询价
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91016 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91016;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        /// <param name="stockCode">证券代码</param>
        public Ufx91016(string userToken, string marketNo, string stockCode)
        {
            UserToken = userToken;
            MarketNo = marketNo;
            StockCode = stockCode;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号(账户编号\资产单元编号\组合编号三者至少要传入一项,如资产单元编号或组合编号未传入则取默认资产单元或默认组合.)
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx91016 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx91016 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx91016 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码(一般情况下无需传入股东,系统根据组合自动获取,只有一个组合存在多个股东时需要指定.)
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx91016 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _reportSeat;
        private bool _reportSeatChanged;
        /// <summary>
        /// 申报席位(一般情况下无需传入申报席位,系统根据组合自动获取.如需多席位报盘时可传入相应席位号.)
        /// </summary>
        public string ReportSeat
        {
            get => _reportSeat;
            set {
                _reportSeatChanged = true;
                _reportSeat = value;
            }
        }
        public Ufx91016 SetReportSeat(string value)
        {
            ReportSeat = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91016 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91016 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91016 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91016 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91016 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx91016 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx91016 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_reportSeatChanged)
            {
                packer.AddField("report_seat", (sbyte)'S', 6, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_reportSeatChanged)
            {
                packer.AddStr(_reportSeat);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91017
    /// 功能名称: 支持上交所股票期权回应报价,回应报价修改,支持批量传入
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91017 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91017;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        /// <param name="stockCode">证券代码</param>
        /// <param name="quoteMark">报价标识(上交所股票期权回应报价业务时必传,,'02'-回应报价,'03'-回应报价修改)</param>
        /// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
        /// <param name="futuresDirection">开平方向('1'-开仓;'2'-平仓.)</param>
        /// <param name="priceType">委托价格类型(只支持限价:0)</param>
        /// <param name="entrustPrice">委托价格(委托价格需要注意最小价差,需要传入方自行控制,传入不符合规则要求,则返回失败.)</param>
        public Ufx91017(string userToken, string marketNo, string stockCode, string quoteMark, string entrustDirection, sbyte futuresDirection, sbyte priceType, double entrustPrice)
        {
            UserToken = userToken;
            MarketNo = marketNo;
            StockCode = stockCode;
            QuoteMark = quoteMark;
            EntrustDirection = entrustDirection;
            FuturesDirection = futuresDirection;
            PriceType = priceType;
            EntrustPrice = entrustPrice;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号(账户编号\资产单元编号\组合编号三者至少要传入一项,如资产单元编号或组合编号未传入则取默认资产单元或默认组合.)
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx91017 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx91017 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx91017 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码(一般情况下无需传入股东,系统根据组合自动获取,只有一个组合存在多个股东时需要指定.PB用户请查看'PB用户须知'标签页.)
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx91017 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _reportSeat;
        private bool _reportSeatChanged;
        /// <summary>
        /// 申报席位(一般情况下无需传入申报席位,系统根据组合自动获取.如需多席位报盘时可传入相应席位号.)
        /// </summary>
        public string ReportSeat
        {
            get => _reportSeat;
            set {
                _reportSeatChanged = true;
                _reportSeat = value;
            }
        }
        public Ufx91017 SetReportSeat(string value)
        {
            ReportSeat = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }

        private string _quoteMark;
        private bool _quoteMarkChanged;
        /// <summary>
        /// 报价标识(上交所股票期权回应报价业务时必传,,'02'-回应报价,'03'-回应报价修改)
        /// </summary>
        public string QuoteMark
        {
            get => _quoteMark;
            set {
                _quoteMarkChanged = true;
                _quoteMark = value;
            }
        }

        private int _cancelEntrustNo;
        private bool _cancelEntrustNoChanged;
        /// <summary>
        /// 委托序号(被修改的回应报价委托序号,报价标识为'回应报价修改'时必传)
        /// </summary>
        public int CancelEntrustNo
        {
            get => _cancelEntrustNo;
            set {
                _cancelEntrustNoChanged = true;
                _cancelEntrustNo = value;
            }
        }
        public Ufx91017 SetCancelEntrustNo(int value)
        {
            CancelEntrustNo = value;
            return this;
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }

        private sbyte _futuresDirection;
        private bool _futuresDirectionChanged;
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓.)
        /// </summary>
        public sbyte FuturesDirection
        {
            get => _futuresDirection;
            set {
                _futuresDirectionChanged = true;
                _futuresDirection = value;
            }
        }

        private sbyte _priceType;
        private bool _priceTypeChanged;
        /// <summary>
        /// 委托价格类型(只支持限价:0)
        /// </summary>
        public sbyte PriceType
        {
            get => _priceType;
            set {
                _priceTypeChanged = true;
                _priceType = value;
            }
        }

        private double _entrustPrice;
        private bool _entrustPriceChanged;
        /// <summary>
        /// 委托价格(委托价格需要注意最小价差,需要传入方自行控制,传入不符合规则要求,则返回失败.)
        /// </summary>
        public double EntrustPrice
        {
            get => _entrustPrice;
            set {
                _entrustPriceChanged = true;
                _entrustPrice = value;
            }
        }

        private int _entrustAmount;
        private bool _entrustAmountChanged;
        /// <summary>
        /// 委托数量(委托数量需要注意最小买卖单位,需要传入方自行控制,传入不符合规则要求,则返回失败.回应报价修改,数量字段无效,回应报价,该字段必传)
        /// </summary>
        public int EntrustAmount
        {
            get => _entrustAmount;
            set {
                _entrustAmountChanged = true;
                _entrustAmount = value;
            }
        }
        public Ufx91017 SetEntrustAmount(int value)
        {
            EntrustAmount = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx91017 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx91017 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91017 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91017 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91017 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91017 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91017 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_reportSeatChanged)
            {
                packer.AddField("report_seat", (sbyte)'S', 6, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_quoteMarkChanged)
            {
                packer.AddField("quote_mark", (sbyte)'S', 2, 4);
            }
            if (_cancelEntrustNoChanged)
            {
                packer.AddField("cancel_entrust_no", (sbyte)'I', 8, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddField("futures_direction", (sbyte)'C', 1, 4);
            }
            if (_priceTypeChanged)
            {
                packer.AddField("price_type", (sbyte)'C', 1, 4);
            }
            if (_entrustPriceChanged)
            {
                packer.AddField("entrust_price", (sbyte)'D', 11, 4);
            }
            if (_entrustAmountChanged)
            {
                packer.AddField("entrust_amount", (sbyte)'I', 12, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_reportSeatChanged)
            {
                packer.AddStr(_reportSeat);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_quoteMarkChanged)
            {
                packer.AddStr(_quoteMark);
            }
            if (_cancelEntrustNoChanged)
            {
                packer.AddInt(_cancelEntrustNo);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddChar(_futuresDirection);
            }
            if (_priceTypeChanged)
            {
                packer.AddChar(_priceType);
            }
            if (_entrustPriceChanged)
            {
                packer.AddDouble(_entrustPrice);
            }
            if (_entrustAmountChanged)
            {
                packer.AddInt(_entrustAmount);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91120
    /// 功能名称: 支持按委托序号撤销期权(股票期权\股指期权\商品期权)委托,可传入多个委托序号进行批量撤单
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91120 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91120;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="accountCode">账户编号</param>
        /// <param name="combiNo">组合编号</param>
        /// <param name="entrustNo">委托序号</param>
        public Ufx91120(string userToken, string accountCode, string combiNo, int entrustNo)
        {
            UserToken = userToken;
            AccountCode = accountCode;
            CombiNo = combiNo;
            EntrustNo = entrustNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91120 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91120 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91120 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91120 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91120 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91106
    /// 功能名称: 支持按委托序号撤销期权(股票期权\股指期权\商品期权)委托,可传入多个委托序号进行批量撤单
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91106 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91106;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="entrustNo">委托序号()</param>
        public Ufx91106(string userToken, int entrustNo)
        {
            UserToken = userToken;
            EntrustNo = entrustNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号()
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91106 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91106 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91106 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91106 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91106 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91108
    /// 功能名称: 支持按委托批号撤销股指期权委托
    /// 业务范围: 期权
    /// </summary>
    [Obsolete("不维护")]
    public sealed class Ufx91108 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91108;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="batchNo">委托批号</param>
        public Ufx91108(string userToken, int batchNo)
        {
            UserToken = userToken;
            BatchNo = batchNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91108 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91108 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91108 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91108 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91108 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91122
    /// 功能名称: 支持撤销深交所股票期权做市委托,中金所股指期权做市委托
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91122 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91122;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="accountCode">账户编号</param>
        /// <param name="combiNo">组合编号</param>
        /// <param name="entrustNo">委托序号(注意:撤单将会撤掉与该委托所包括的期权代码的所有做市委托.详见下方业务说明.)</param>
        public Ufx91122(string userToken, string accountCode, string combiNo, int entrustNo)
        {
            UserToken = userToken;
            AccountCode = accountCode;
            CombiNo = combiNo;
            EntrustNo = entrustNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号(注意:撤单将会撤掉与该委托所包括的期权代码的所有做市委托.详见下方业务说明.)
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91122 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91122 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91122 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91122 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91122 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91109
    /// 功能名称: 支持撤销深交所股票期权做市委托,中金所股指期权做市委托
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91109 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91109;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="entrustNo">委托序号(注意:撤单将会撤掉与该委托所包括的期权代码的所有做市委托.详见下方业务说明.)</param>
        public Ufx91109(string userToken, int entrustNo)
        {
            UserToken = userToken;
            EntrustNo = entrustNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号(注意:撤单将会撤掉与该委托所包括的期权代码的所有做市委托.详见下方业务说明.)
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91109 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91109 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91109 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91109 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91109 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91123
    /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权撤单,可传入多条委托序号进行批量撤单.
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91123 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91123;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="accountCode">账户编号</param>
        /// <param name="combiNo">组合编号</param>
        /// <param name="entrustNo">委托序号</param>
        public Ufx91123(string userToken, string accountCode, string combiNo, int entrustNo)
        {
            UserToken = userToken;
            AccountCode = accountCode;
            CombiNo = combiNo;
            EntrustNo = entrustNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91123 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91123 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91123 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91123 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91123 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91111
    /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权撤单,可传入多条委托序号进行批量撤单.
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91111 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91111;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="entrustNo">委托序号</param>
        public Ufx91111(string userToken, int entrustNo)
        {
            UserToken = userToken;
            EntrustNo = entrustNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91111 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91111 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91111 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91111 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91111 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91112
    /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权按委托批号撤单.
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91112 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91112;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="batchNo">委托批号</param>
        public Ufx91112(string userToken, int batchNo)
        {
            UserToken = userToken;
            BatchNo = batchNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91112 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91112 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91112 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91112 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91112 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 31004
    /// 功能名称: 支持查询沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权持仓信息
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx31004 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 31004;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        public Ufx31004(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx31004 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx31004 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx31004 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx31004 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx31004 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx31004 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _holdSeat;
        private bool _holdSeatChanged;
        /// <summary>
        /// 持仓席位
        /// </summary>
        public string HoldSeat
        {
            get => _holdSeat;
            set {
                _holdSeatChanged = true;
                _holdSeat = value;
            }
        }
        public Ufx31004 SetHoldSeat(string value)
        {
            HoldSeat = value;
            return this;
        }

        private sbyte _optionType;
        private bool _optionTypeChanged;
        /// <summary>
        /// 期权类型(限定 <see cref="UfxOptionType"/> 中定义的常量)
        /// </summary>
        public sbyte OptionType
        {
            get => _optionType;
            set {
                _optionTypeChanged = true;
                _optionType = value;
            }
        }
        public Ufx31004 SetOptionType(sbyte value)
        {
            OptionType = value;
            return this;
        }

        private sbyte _positionFlag;
        private bool _positionFlagChanged;
        /// <summary>
        /// 多空标志(限定 <see cref="UfxPositionFlag"/> 中定义的常量)
        /// </summary>
        public sbyte PositionFlag
        {
            get => _positionFlag;
            set {
                _positionFlagChanged = true;
                _positionFlag = value;
            }
        }
        public Ufx31004 SetPositionFlag(sbyte value)
        {
            PositionFlag = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_holdSeatChanged)
            {
                packer.AddField("hold_seat", (sbyte)'S', 6, 4);
            }
            if (_optionTypeChanged)
            {
                packer.AddField("option_type", (sbyte)'C', 1, 4);
            }
            if (_positionFlagChanged)
            {
                packer.AddField("position_flag", (sbyte)'C', 1, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_holdSeatChanged)
            {
                packer.AddStr(_holdSeat);
            }
            if (_optionTypeChanged)
            {
                packer.AddChar(_optionType);
            }
            if (_positionFlagChanged)
            {
                packer.AddChar(_positionFlag);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 32004
    /// 功能名称: 支持查询沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权当日委托流水(除备兑锁定解锁)
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx32004 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 32004;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        public Ufx32004(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号(按委托批号查询)
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }
        public Ufx32004 SetBatchNo(int value)
        {
            BatchNo = value;
            return this;
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号(按委托序号查询)
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }
        public Ufx32004 SetEntrustNo(int value)
        {
            EntrustNo = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx32004 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx32004 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx32004 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx32004 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx32004 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx32004 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }
        public Ufx32004 SetEntrustDirection(string value)
        {
            EntrustDirection = value;
            return this;
        }

        private sbyte _futuresDirection;
        private bool _futuresDirectionChanged;
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;查询委托方向为行权认购\行权认沽\放弃行权\期权期货自对冲该字段不做必传非必传控制)
        /// </summary>
        public sbyte FuturesDirection
        {
            get => _futuresDirection;
            set {
                _futuresDirectionChanged = true;
                _futuresDirection = value;
            }
        }
        public Ufx32004 SetFuturesDirection(sbyte value)
        {
            FuturesDirection = value;
            return this;
        }

        private sbyte _optionType;
        private bool _optionTypeChanged;
        /// <summary>
        /// 期权类型(限定 <see cref="UfxOptionType"/> 中定义的常量)
        /// </summary>
        public sbyte OptionType
        {
            get => _optionType;
            set {
                _optionTypeChanged = true;
                _optionType = value;
            }
        }
        public Ufx32004 SetOptionType(sbyte value)
        {
            OptionType = value;
            return this;
        }

        private string _entrustStateList;
        private bool _entrustStateListChanged;
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public string EntrustStateList
        {
            get => _entrustStateList;
            set {
                _entrustStateListChanged = true;
                _entrustStateList = value;
            }
        }
        public Ufx32004 SetEntrustStateList(string value)
        {
            EntrustStateList = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx32004 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx32004 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx32004 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx32004 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }

        private string _entrustSerialList;
        private bool _entrustSerialListChanged;
        /// <summary>
        /// 委托序号串(以逗号分隔的委托序号串,如果该字段外部没传,继续以委托序号为准,如果外部传了该字段,以该字段为准)
        /// </summary>
        public string EntrustSerialList
        {
            get => _entrustSerialList;
            set {
                _entrustSerialListChanged = true;
                _entrustSerialList = value;
            }
        }
        public Ufx32004 SetEntrustSerialList(string value)
        {
            EntrustSerialList = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddField("futures_direction", (sbyte)'C', 1, 4);
            }
            if (_optionTypeChanged)
            {
                packer.AddField("option_type", (sbyte)'C', 1, 4);
            }
            if (_entrustStateListChanged)
            {
                packer.AddField("entrust_state_list", (sbyte)'S', 256, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_entrustSerialListChanged)
            {
                packer.AddField("entrust_serial_list", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddChar(_futuresDirection);
            }
            if (_optionTypeChanged)
            {
                packer.AddChar(_optionType);
            }
            if (_entrustStateListChanged)
            {
                packer.AddStr(_entrustStateList);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            if (_entrustSerialListChanged)
            {
                packer.AddStr(_entrustSerialList);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 32007
    /// 功能名称: 支持查询当日股指期权\深交所股票期权做市委托
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx32007 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 32007;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        /// <param name="accountCode">账户编号</param>
        public Ufx32007(string userToken, string accountCode)
        {
            UserToken = userToken;
            AccountCode = accountCode;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号(按委托批号查询)
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }
        public Ufx32007 SetBatchNo(int value)
        {
            BatchNo = value;
            return this;
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }
        public Ufx32007 SetEntrustNo(int value)
        {
            EntrustNo = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx32007 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元和组合二选一必传.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx32007 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx32007 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx32007 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx32007 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _entrustStateList;
        private bool _entrustStateListChanged;
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public string EntrustStateList
        {
            get => _entrustStateList;
            set {
                _entrustStateListChanged = true;
                _entrustStateList = value;
            }
        }
        public Ufx32007 SetEntrustStateList(string value)
        {
            EntrustStateList = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx32007 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx32007 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx32007 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx32007 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustStateListChanged)
            {
                packer.AddField("entrust_state_list", (sbyte)'S', 256, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustStateListChanged)
            {
                packer.AddStr(_entrustStateList);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 33004
    /// 功能名称: 支持查询沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权当日成交流水
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx33004 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 33004;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        public Ufx33004(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx33004 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx33004 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx33004 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号()
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }
        public Ufx33004 SetEntrustNo(int value)
        {
            EntrustNo = value;
            return this;
        }

        private string _dealNo;
        private bool _dealNoChanged;
        /// <summary>
        /// 成交编号
        /// </summary>
        public string DealNo
        {
            get => _dealNo;
            set {
                _dealNoChanged = true;
                _dealNo = value;
            }
        }
        public Ufx33004 SetDealNo(string value)
        {
            DealNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx33004 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx33004 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx33004 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }
        public Ufx33004 SetEntrustDirection(string value)
        {
            EntrustDirection = value;
            return this;
        }

        private sbyte _futuresDirection;
        private bool _futuresDirectionChanged;
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection
        {
            get => _futuresDirection;
            set {
                _futuresDirectionChanged = true;
                _futuresDirection = value;
            }
        }
        public Ufx33004 SetFuturesDirection(sbyte value)
        {
            FuturesDirection = value;
            return this;
        }

        private sbyte _optionType;
        private bool _optionTypeChanged;
        /// <summary>
        /// 期权类型(限定 <see cref="UfxOptionType"/> 中定义的常量)
        /// </summary>
        public sbyte OptionType
        {
            get => _optionType;
            set {
                _optionTypeChanged = true;
                _optionType = value;
            }
        }
        public Ufx33004 SetOptionType(sbyte value)
        {
            OptionType = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx33004 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx33004 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx33004 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx33004 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }

        private string _entrustSerialList;
        private bool _entrustSerialListChanged;
        /// <summary>
        /// 委托序号串(以逗号分隔的委托序号串,如果该字段外部没传,继续以委托序号为准,如果外部传了该字段,以该字段为准)
        /// </summary>
        public string EntrustSerialList
        {
            get => _entrustSerialList;
            set {
                _entrustSerialListChanged = true;
                _entrustSerialList = value;
            }
        }
        public Ufx33004 SetEntrustSerialList(string value)
        {
            EntrustSerialList = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_dealNoChanged)
            {
                packer.AddField("deal_no", (sbyte)'S', 64, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddField("futures_direction", (sbyte)'C', 1, 4);
            }
            if (_optionTypeChanged)
            {
                packer.AddField("option_type", (sbyte)'C', 1, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_entrustSerialListChanged)
            {
                packer.AddField("entrust_serial_list", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_dealNoChanged)
            {
                packer.AddStr(_dealNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddChar(_futuresDirection);
            }
            if (_optionTypeChanged)
            {
                packer.AddChar(_optionType);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            if (_entrustSerialListChanged)
            {
                packer.AddStr(_entrustSerialList);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 34004
    /// 功能名称: 支持沪深衍生品保证金账户查询(股指期权,商品期权保证金账户请使用34003接口查询).
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx34004 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 34004;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        public Ufx34004(string userToken, string marketNo)
        {
            UserToken = userToken;
            MarketNo = marketNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx34004 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx34004 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx34004 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91015
    /// 功能名称: 支持上交所股票期权组合策略保证金交易业务
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91015 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91015;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="combistrategyCode">组合策略代码</param>
        /// <param name="combiDirection">组合方向(B-组合,C-拆分,D-转备兑,E-备兑转保证金)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        /// <param name="entrustAmount">委托数量</param>
        public Ufx91015(string userToken, string combistrategyCode, sbyte combiDirection, string marketNo, int entrustAmount)
        {
            UserToken = userToken;
            CombistrategyCode = combistrategyCode;
            CombiDirection = combiDirection;
            MarketNo = marketNo;
            EntrustAmount = entrustAmount;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号(用户可自行指定委托批号,表示多笔委托属于同一批次.)
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }
        public Ufx91015 SetBatchNo(int value)
        {
            BatchNo = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号(账户编号\资产单元编号\组合编号三者至少要传入一项,如资产单元编号或组合编号未传入则取默认资产单元或默认组合.)
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx91015 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx91015 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx91015 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _combistrategyCode;
        private bool _combistrategyCodeChanged;
        /// <summary>
        /// 组合策略代码
        /// </summary>
        public string CombistrategyCode
        {
            get => _combistrategyCode;
            set {
                _combistrategyCodeChanged = true;
                _combistrategyCode = value;
            }
        }

        private string _combistrategyId;
        private bool _combistrategyIdChanged;
        /// <summary>
        /// 组合策略持仓编号(组合拆分时必传)
        /// </summary>
        public string CombistrategyId
        {
            get => _combistrategyId;
            set {
                _combistrategyIdChanged = true;
                _combistrategyId = value;
            }
        }
        public Ufx91015 SetCombistrategyId(string value)
        {
            CombistrategyId = value;
            return this;
        }

        private sbyte _combiDirection;
        private bool _combiDirectionChanged;
        /// <summary>
        /// 组合方向(B-组合,C-拆分,D-转备兑,E-备兑转保证金)
        /// </summary>
        public sbyte CombiDirection
        {
            get => _combiDirection;
            set {
                _combiDirectionChanged = true;
                _combiDirection = value;
            }
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码(一般情况下无需传入股东,系统根据组合自动获取,只有一个组合存在多个股东时需要指定.)
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx91015 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _reportSeat;
        private bool _reportSeatChanged;
        /// <summary>
        /// 申报席位(一般情况下无需传入申报席位,系统根据组合自动获取.如需多席位报盘时可传入相应席位号.)
        /// </summary>
        public string ReportSeat
        {
            get => _reportSeat;
            set {
                _reportSeatChanged = true;
                _reportSeat = value;
            }
        }
        public Ufx91015 SetReportSeat(string value)
        {
            ReportSeat = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _stockCode1;
        private bool _stockCode1Changed;
        /// <summary>
        /// 证券代码1(组合方向为组合\转备兑\备兑转保证金时必传,为拆分时此字段忽略)
        /// </summary>
        public string StockCode1
        {
            get => _stockCode1;
            set {
                _stockCode1Changed = true;
                _stockCode1 = value;
            }
        }
        public Ufx91015 SetStockCode1(string value)
        {
            StockCode1 = value;
            return this;
        }

        private string _stockCode2;
        private bool _stockCode2Changed;
        /// <summary>
        /// 证券代码2(组合方向为组合时必传,拆分\转备兑\备兑转保证金时此字段忽略)
        /// </summary>
        public string StockCode2
        {
            get => _stockCode2;
            set {
                _stockCode2Changed = true;
                _stockCode2 = value;
            }
        }
        public Ufx91015 SetStockCode2(string value)
        {
            StockCode2 = value;
            return this;
        }

        private string _stockCode3;
        private bool _stockCode3Changed;
        /// <summary>
        /// 证券代码3(交易所目前只支持两只券,此字段忽略)
        /// </summary>
        public string StockCode3
        {
            get => _stockCode3;
            set {
                _stockCode3Changed = true;
                _stockCode3 = value;
            }
        }
        public Ufx91015 SetStockCode3(string value)
        {
            StockCode3 = value;
            return this;
        }

        private string _stockCode4;
        private bool _stockCode4Changed;
        /// <summary>
        /// 证券代码4(交易所目前只支持两只券,此字段忽略)
        /// </summary>
        public string StockCode4
        {
            get => _stockCode4;
            set {
                _stockCode4Changed = true;
                _stockCode4 = value;
            }
        }
        public Ufx91015 SetStockCode4(string value)
        {
            StockCode4 = value;
            return this;
        }

        private int _entrustAmount;
        private bool _entrustAmountChanged;
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount
        {
            get => _entrustAmount;
            set {
                _entrustAmountChanged = true;
                _entrustAmount = value;
            }
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx91015 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx91015 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91015 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91015 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91015 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91015 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91015 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_combistrategyCodeChanged)
            {
                packer.AddField("combistrategy_code", (sbyte)'S', 32, 4);
            }
            if (_combistrategyIdChanged)
            {
                packer.AddField("combistrategy_id", (sbyte)'S', 64, 4);
            }
            if (_combiDirectionChanged)
            {
                packer.AddField("combi_direction", (sbyte)'C', 1, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_reportSeatChanged)
            {
                packer.AddField("report_seat", (sbyte)'S', 6, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCode1Changed)
            {
                packer.AddField("stock_code1", (sbyte)'S', 16, 4);
            }
            if (_stockCode2Changed)
            {
                packer.AddField("stock_code2", (sbyte)'S', 16, 4);
            }
            if (_stockCode3Changed)
            {
                packer.AddField("stock_code3", (sbyte)'S', 16, 4);
            }
            if (_stockCode4Changed)
            {
                packer.AddField("stock_code4", (sbyte)'S', 16, 4);
            }
            if (_entrustAmountChanged)
            {
                packer.AddField("entrust_amount", (sbyte)'I', 12, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_combistrategyCodeChanged)
            {
                packer.AddStr(_combistrategyCode);
            }
            if (_combistrategyIdChanged)
            {
                packer.AddStr(_combistrategyId);
            }
            if (_combiDirectionChanged)
            {
                packer.AddChar(_combiDirection);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_reportSeatChanged)
            {
                packer.AddStr(_reportSeat);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCode1Changed)
            {
                packer.AddStr(_stockCode1);
            }
            if (_stockCode2Changed)
            {
                packer.AddStr(_stockCode2);
            }
            if (_stockCode3Changed)
            {
                packer.AddStr(_stockCode3);
            }
            if (_stockCode4Changed)
            {
                packer.AddStr(_stockCode4);
            }
            if (_entrustAmountChanged)
            {
                packer.AddInt(_entrustAmount);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 31015
    /// 功能名称: 支持查询上交所股票期权组合策略保证金持仓信息
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx31015 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 31015;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        public Ufx31015(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx31015 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx31015 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx31015 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx31015 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _combistrategyCode;
        private bool _combistrategyCodeChanged;
        /// <summary>
        /// 组合策略代码
        /// </summary>
        public string CombistrategyCode
        {
            get => _combistrategyCode;
            set {
                _combistrategyCodeChanged = true;
                _combistrategyCode = value;
            }
        }
        public Ufx31015 SetCombistrategyCode(string value)
        {
            CombistrategyCode = value;
            return this;
        }

        private string _stockCode1;
        private bool _stockCode1Changed;
        /// <summary>
        /// 证券代码1(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode1
        {
            get => _stockCode1;
            set {
                _stockCode1Changed = true;
                _stockCode1 = value;
            }
        }
        public Ufx31015 SetStockCode1(string value)
        {
            StockCode1 = value;
            return this;
        }

        private string _stockCode2;
        private bool _stockCode2Changed;
        /// <summary>
        /// 证券代码2(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode2
        {
            get => _stockCode2;
            set {
                _stockCode2Changed = true;
                _stockCode2 = value;
            }
        }
        public Ufx31015 SetStockCode2(string value)
        {
            StockCode2 = value;
            return this;
        }

        private string _stockCode3;
        private bool _stockCode3Changed;
        /// <summary>
        /// 证券代码3(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode3
        {
            get => _stockCode3;
            set {
                _stockCode3Changed = true;
                _stockCode3 = value;
            }
        }
        public Ufx31015 SetStockCode3(string value)
        {
            StockCode3 = value;
            return this;
        }

        private string _stockCode4;
        private bool _stockCode4Changed;
        /// <summary>
        /// 证券代码4(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode4
        {
            get => _stockCode4;
            set {
                _stockCode4Changed = true;
                _stockCode4 = value;
            }
        }
        public Ufx31015 SetStockCode4(string value)
        {
            StockCode4 = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx31015 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _holdSeat;
        private bool _holdSeatChanged;
        /// <summary>
        /// 持仓席位
        /// </summary>
        public string HoldSeat
        {
            get => _holdSeat;
            set {
                _holdSeatChanged = true;
                _holdSeat = value;
            }
        }
        public Ufx31015 SetHoldSeat(string value)
        {
            HoldSeat = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_combistrategyCodeChanged)
            {
                packer.AddField("combistrategy_code", (sbyte)'S', 32, 4);
            }
            if (_stockCode1Changed)
            {
                packer.AddField("stock_code1", (sbyte)'S', 16, 4);
            }
            if (_stockCode2Changed)
            {
                packer.AddField("stock_code2", (sbyte)'S', 16, 4);
            }
            if (_stockCode3Changed)
            {
                packer.AddField("stock_code3", (sbyte)'S', 16, 4);
            }
            if (_stockCode4Changed)
            {
                packer.AddField("stock_code4", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_holdSeatChanged)
            {
                packer.AddField("hold_seat", (sbyte)'S', 6, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_combistrategyCodeChanged)
            {
                packer.AddStr(_combistrategyCode);
            }
            if (_stockCode1Changed)
            {
                packer.AddStr(_stockCode1);
            }
            if (_stockCode2Changed)
            {
                packer.AddStr(_stockCode2);
            }
            if (_stockCode3Changed)
            {
                packer.AddStr(_stockCode3);
            }
            if (_stockCode4Changed)
            {
                packer.AddStr(_stockCode4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_holdSeatChanged)
            {
                packer.AddStr(_holdSeat);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 32015
    /// 功能名称: 支持查询上交所股票期权组合策略保证金委托信息
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx32015 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 32015;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        public Ufx32015(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号(按委托批号查询)
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }
        public Ufx32015 SetBatchNo(int value)
        {
            BatchNo = value;
            return this;
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号(按委托序号查询)
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }
        public Ufx32015 SetEntrustNo(int value)
        {
            EntrustNo = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx32015 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx32015 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx32015 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx32015 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx32015 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _combistrategyCode;
        private bool _combistrategyCodeChanged;
        /// <summary>
        /// 组合策略代码
        /// </summary>
        public string CombistrategyCode
        {
            get => _combistrategyCode;
            set {
                _combistrategyCodeChanged = true;
                _combistrategyCode = value;
            }
        }
        public Ufx32015 SetCombistrategyCode(string value)
        {
            CombistrategyCode = value;
            return this;
        }

        private string _stockCode1;
        private bool _stockCode1Changed;
        /// <summary>
        /// 证券代码1(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode1
        {
            get => _stockCode1;
            set {
                _stockCode1Changed = true;
                _stockCode1 = value;
            }
        }
        public Ufx32015 SetStockCode1(string value)
        {
            StockCode1 = value;
            return this;
        }

        private string _stockCode2;
        private bool _stockCode2Changed;
        /// <summary>
        /// 证券代码2(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode2
        {
            get => _stockCode2;
            set {
                _stockCode2Changed = true;
                _stockCode2 = value;
            }
        }
        public Ufx32015 SetStockCode2(string value)
        {
            StockCode2 = value;
            return this;
        }

        private string _stockCode3;
        private bool _stockCode3Changed;
        /// <summary>
        /// 证券代码3(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode3
        {
            get => _stockCode3;
            set {
                _stockCode3Changed = true;
                _stockCode3 = value;
            }
        }
        public Ufx32015 SetStockCode3(string value)
        {
            StockCode3 = value;
            return this;
        }

        private string _stockCode4;
        private bool _stockCode4Changed;
        /// <summary>
        /// 证券代码4(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode4
        {
            get => _stockCode4;
            set {
                _stockCode4Changed = true;
                _stockCode4 = value;
            }
        }
        public Ufx32015 SetStockCode4(string value)
        {
            StockCode4 = value;
            return this;
        }

        private sbyte _combiDirection;
        private bool _combiDirectionChanged;
        /// <summary>
        /// 组合方向(B-组合,C-拆分,D-转备兑,E-备兑转保证金)
        /// </summary>
        public sbyte CombiDirection
        {
            get => _combiDirection;
            set {
                _combiDirectionChanged = true;
                _combiDirection = value;
            }
        }
        public Ufx32015 SetCombiDirection(sbyte value)
        {
            CombiDirection = value;
            return this;
        }

        private string _entrustStateList;
        private bool _entrustStateListChanged;
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public string EntrustStateList
        {
            get => _entrustStateList;
            set {
                _entrustStateListChanged = true;
                _entrustStateList = value;
            }
        }
        public Ufx32015 SetEntrustStateList(string value)
        {
            EntrustStateList = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx32015 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx32015 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx32015 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx32015 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_combistrategyCodeChanged)
            {
                packer.AddField("combistrategy_code", (sbyte)'S', 32, 4);
            }
            if (_stockCode1Changed)
            {
                packer.AddField("stock_code1", (sbyte)'S', 16, 4);
            }
            if (_stockCode2Changed)
            {
                packer.AddField("stock_code2", (sbyte)'S', 16, 4);
            }
            if (_stockCode3Changed)
            {
                packer.AddField("stock_code3", (sbyte)'S', 16, 4);
            }
            if (_stockCode4Changed)
            {
                packer.AddField("stock_code4", (sbyte)'S', 16, 4);
            }
            if (_combiDirectionChanged)
            {
                packer.AddField("combi_direction", (sbyte)'C', 1, 4);
            }
            if (_entrustStateListChanged)
            {
                packer.AddField("entrust_state_list", (sbyte)'S', 256, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_combistrategyCodeChanged)
            {
                packer.AddStr(_combistrategyCode);
            }
            if (_stockCode1Changed)
            {
                packer.AddStr(_stockCode1);
            }
            if (_stockCode2Changed)
            {
                packer.AddStr(_stockCode2);
            }
            if (_stockCode3Changed)
            {
                packer.AddStr(_stockCode3);
            }
            if (_stockCode4Changed)
            {
                packer.AddStr(_stockCode4);
            }
            if (_combiDirectionChanged)
            {
                packer.AddChar(_combiDirection);
            }
            if (_entrustStateListChanged)
            {
                packer.AddStr(_entrustStateList);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 33015
    /// 功能名称: 支持查询上交所股票期权组合策略保证金成交信息
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx33015 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 33015;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        public Ufx33015(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx33015 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx33015 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx33015 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号()
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }
        public Ufx33015 SetEntrustNo(int value)
        {
            EntrustNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx33015 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx33015 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _combistrategyCode;
        private bool _combistrategyCodeChanged;
        /// <summary>
        /// 组合策略代码
        /// </summary>
        public string CombistrategyCode
        {
            get => _combistrategyCode;
            set {
                _combistrategyCodeChanged = true;
                _combistrategyCode = value;
            }
        }
        public Ufx33015 SetCombistrategyCode(string value)
        {
            CombistrategyCode = value;
            return this;
        }

        private string _stockCode1;
        private bool _stockCode1Changed;
        /// <summary>
        /// 证券代码1(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode1
        {
            get => _stockCode1;
            set {
                _stockCode1Changed = true;
                _stockCode1 = value;
            }
        }
        public Ufx33015 SetStockCode1(string value)
        {
            StockCode1 = value;
            return this;
        }

        private string _stockCode2;
        private bool _stockCode2Changed;
        /// <summary>
        /// 证券代码2(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode2
        {
            get => _stockCode2;
            set {
                _stockCode2Changed = true;
                _stockCode2 = value;
            }
        }
        public Ufx33015 SetStockCode2(string value)
        {
            StockCode2 = value;
            return this;
        }

        private string _stockCode3;
        private bool _stockCode3Changed;
        /// <summary>
        /// 证券代码3(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode3
        {
            get => _stockCode3;
            set {
                _stockCode3Changed = true;
                _stockCode3 = value;
            }
        }
        public Ufx33015 SetStockCode3(string value)
        {
            StockCode3 = value;
            return this;
        }

        private string _stockCode4;
        private bool _stockCode4Changed;
        /// <summary>
        /// 证券代码4(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode4
        {
            get => _stockCode4;
            set {
                _stockCode4Changed = true;
                _stockCode4 = value;
            }
        }
        public Ufx33015 SetStockCode4(string value)
        {
            StockCode4 = value;
            return this;
        }

        private sbyte _combiDirection;
        private bool _combiDirectionChanged;
        /// <summary>
        /// 组合方向(B-组合,C-拆分,D-转备兑,E-备兑转保证金)
        /// </summary>
        public sbyte CombiDirection
        {
            get => _combiDirection;
            set {
                _combiDirectionChanged = true;
                _combiDirection = value;
            }
        }
        public Ufx33015 SetCombiDirection(sbyte value)
        {
            CombiDirection = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx33015 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx33015 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx33015 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx33015 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_combistrategyCodeChanged)
            {
                packer.AddField("combistrategy_code", (sbyte)'S', 32, 4);
            }
            if (_stockCode1Changed)
            {
                packer.AddField("stock_code1", (sbyte)'S', 16, 4);
            }
            if (_stockCode2Changed)
            {
                packer.AddField("stock_code2", (sbyte)'S', 16, 4);
            }
            if (_stockCode3Changed)
            {
                packer.AddField("stock_code3", (sbyte)'S', 16, 4);
            }
            if (_stockCode4Changed)
            {
                packer.AddField("stock_code4", (sbyte)'S', 16, 4);
            }
            if (_combiDirectionChanged)
            {
                packer.AddField("combi_direction", (sbyte)'C', 1, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_combistrategyCodeChanged)
            {
                packer.AddStr(_combistrategyCode);
            }
            if (_stockCode1Changed)
            {
                packer.AddStr(_stockCode1);
            }
            if (_stockCode2Changed)
            {
                packer.AddStr(_stockCode2);
            }
            if (_stockCode3Changed)
            {
                packer.AddStr(_stockCode3);
            }
            if (_stockCode4Changed)
            {
                packer.AddStr(_stockCode4);
            }
            if (_combiDirectionChanged)
            {
                packer.AddChar(_combiDirection);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 91018
    /// 功能名称: 支持郑商所商品期权套利单业务.
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91018 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 91018;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        /// <param name="specialFlag">特殊业务标志('7'-郑商所跨式组合单;'8'-郑商所宽跨式组合单)</param>
        /// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        /// <param name="stockCode">证券代码(一腿代码)</param>
        /// <param name="stockCode2">证券代码2(二腿代码)</param>
        /// <param name="entrustDirection">委托方向('1'-买入;'2'-卖出)</param>
        /// <param name="futuresDirection">开平方向('1'-开仓;'2'-平仓)</param>
        /// <param name="priceType">委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)</param>
        /// <param name="entrustPrice">委托价格</param>
        /// <param name="entrustAmount">委托数量</param>
        public Ufx91018(string userToken, sbyte specialFlag, string marketNo, string stockCode, string stockCode2, string entrustDirection, sbyte futuresDirection, sbyte priceType, double entrustPrice, int entrustAmount)
        {
            UserToken = userToken;
            SpecialFlag = specialFlag;
            MarketNo = marketNo;
            StockCode = stockCode;
            StockCode2 = stockCode2;
            EntrustDirection = entrustDirection;
            FuturesDirection = futuresDirection;
            PriceType = priceType;
            EntrustPrice = entrustPrice;
            EntrustAmount = entrustAmount;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号(账户编号\资产单元编号\组合编号三者至少要传入一项,如资产单元编号或组合编号未传入则取默认资产单元或默认组合.)
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx91018 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx91018 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx91018 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码(一般情况下无需传入股东,系统根据组合自动获取,只有一个组合存在多个股东时需要指定.)
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx91018 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private sbyte _specialFlag;
        private bool _specialFlagChanged;
        /// <summary>
        /// 特殊业务标志('7'-郑商所跨式组合单;'8'-郑商所宽跨式组合单)
        /// </summary>
        public sbyte SpecialFlag
        {
            get => _specialFlag;
            set {
                _specialFlagChanged = true;
                _specialFlag = value;
            }
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(一腿代码)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }

        private string _stockCode2;
        private bool _stockCode2Changed;
        /// <summary>
        /// 证券代码2(二腿代码)
        /// </summary>
        public string StockCode2
        {
            get => _stockCode2;
            set {
                _stockCode2Changed = true;
                _stockCode2 = value;
            }
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向('1'-买入;'2'-卖出)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }

        private sbyte _futuresDirection;
        private bool _futuresDirectionChanged;
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓)
        /// </summary>
        public sbyte FuturesDirection
        {
            get => _futuresDirection;
            set {
                _futuresDirectionChanged = true;
                _futuresDirection = value;
            }
        }

        private sbyte _priceType;
        private bool _priceTypeChanged;
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType
        {
            get => _priceType;
            set {
                _priceTypeChanged = true;
                _priceType = value;
            }
        }

        private double _entrustPrice;
        private bool _entrustPriceChanged;
        /// <summary>
        /// 委托价格
        /// </summary>
        public double EntrustPrice
        {
            get => _entrustPrice;
            set {
                _entrustPriceChanged = true;
                _entrustPrice = value;
            }
        }

        private int _entrustAmount;
        private bool _entrustAmountChanged;
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount
        {
            get => _entrustAmount;
            set {
                _entrustAmountChanged = true;
                _entrustAmount = value;
            }
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号,外部系统传入,仅供外部系统使用,必须大于0,委托查询\成交查询时原样返回.)
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx91018 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx91018 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _macAddress;
        private bool _macAddressChanged;
        /// <summary>
        /// 登录机器MAC地址
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set {
                _macAddressChanged = true;
                _macAddress = value;
            }
        }
        public Ufx91018 SetMacAddress(string value)
        {
            MacAddress = value;
            return this;
        }

        private string _ipAddress;
        private bool _ipAddressChanged;
        /// <summary>
        /// 登录机器IP地址
        /// </summary>
        public string IpAddress
        {
            get => _ipAddress;
            set {
                _ipAddressChanged = true;
                _ipAddress = value;
            }
        }
        public Ufx91018 SetIpAddress(string value)
        {
            IpAddress = value;
            return this;
        }

        private string _hdVolserial;
        private bool _hdVolserialChanged;
        /// <summary>
        /// 登录机器硬盘序列号
        /// </summary>
        public string HdVolserial
        {
            get => _hdVolserial;
            set {
                _hdVolserialChanged = true;
                _hdVolserial = value;
            }
        }
        public Ufx91018 SetHdVolserial(string value)
        {
            HdVolserial = value;
            return this;
        }

        private string _opStation;
        private bool _opStationChanged;
        /// <summary>
        /// 登录站点
        /// </summary>
        public string OpStation
        {
            get => _opStation;
            set {
                _opStationChanged = true;
                _opStation = value;
            }
        }
        public Ufx91018 SetOpStation(string value)
        {
            OpStation = value;
            return this;
        }

        private string _terminalInfo;
        private bool _terminalInfoChanged;
        /// <summary>
        /// 终端信息(传入时请按如下字段格式:;cpuid;内网ip;手机号;手机设备号;计算机名;GUID)
        /// </summary>
        public string TerminalInfo
        {
            get => _terminalInfo;
            set {
                _terminalInfoChanged = true;
                _terminalInfo = value;
            }
        }
        public Ufx91018 SetTerminalInfo(string value)
        {
            TerminalInfo = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_specialFlagChanged)
            {
                packer.AddField("special_flag", (sbyte)'C', 1, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_stockCode2Changed)
            {
                packer.AddField("stock_code2", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddField("futures_direction", (sbyte)'C', 1, 4);
            }
            if (_priceTypeChanged)
            {
                packer.AddField("price_type", (sbyte)'C', 1, 4);
            }
            if (_entrustPriceChanged)
            {
                packer.AddField("entrust_price", (sbyte)'D', 11, 4);
            }
            if (_entrustAmountChanged)
            {
                packer.AddField("entrust_amount", (sbyte)'I', 12, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_macAddressChanged)
            {
                packer.AddField("mac_address", (sbyte)'S', 20, 4);
            }
            if (_ipAddressChanged)
            {
                packer.AddField("ip_address", (sbyte)'S', 15, 4);
            }
            if (_hdVolserialChanged)
            {
                packer.AddField("hd_volserial", (sbyte)'S', 128, 4);
            }
            if (_opStationChanged)
            {
                packer.AddField("op_station", (sbyte)'S', 256, 4);
            }
            if (_terminalInfoChanged)
            {
                packer.AddField("terminal_info", (sbyte)'S', 512, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_specialFlagChanged)
            {
                packer.AddChar(_specialFlag);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_stockCode2Changed)
            {
                packer.AddStr(_stockCode2);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddChar(_futuresDirection);
            }
            if (_priceTypeChanged)
            {
                packer.AddChar(_priceType);
            }
            if (_entrustPriceChanged)
            {
                packer.AddDouble(_entrustPrice);
            }
            if (_entrustAmountChanged)
            {
                packer.AddInt(_entrustAmount);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_macAddressChanged)
            {
                packer.AddStr(_macAddress);
            }
            if (_ipAddressChanged)
            {
                packer.AddStr(_ipAddress);
            }
            if (_hdVolserialChanged)
            {
                packer.AddStr(_hdVolserial);
            }
            if (_opStationChanged)
            {
                packer.AddStr(_opStation);
            }
            if (_terminalInfoChanged)
            {
                packer.AddStr(_terminalInfo);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 32016
    /// 功能名称: 支持查询当日郑商所商品期权套利单委托
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx32016 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 32016;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        public Ufx32016(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private int _batchNo;
        private bool _batchNoChanged;
        /// <summary>
        /// 委托批号(按委托批号查询)
        /// </summary>
        public int BatchNo
        {
            get => _batchNo;
            set {
                _batchNoChanged = true;
                _batchNo = value;
            }
        }
        public Ufx32016 SetBatchNo(int value)
        {
            BatchNo = value;
            return this;
        }

        private int _entrustNo;
        private bool _entrustNoChanged;
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo
        {
            get => _entrustNo;
            set {
                _entrustNoChanged = true;
                _entrustNo = value;
            }
        }
        public Ufx32016 SetEntrustNo(int value)
        {
            EntrustNo = value;
            return this;
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx32016 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx32016 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元和组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx32016 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _entrustDirection;
        private bool _entrustDirectionChanged;
        /// <summary>
        /// 委托方向('1'-买入;'2'-卖出)
        /// </summary>
        public string EntrustDirection
        {
            get => _entrustDirection;
            set {
                _entrustDirectionChanged = true;
                _entrustDirection = value;
            }
        }
        public Ufx32016 SetEntrustDirection(string value)
        {
            EntrustDirection = value;
            return this;
        }

        private sbyte _futuresDirection;
        private bool _futuresDirectionChanged;
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓,委托方向和开平方向必须都传入或者都不传)
        /// </summary>
        public sbyte FuturesDirection
        {
            get => _futuresDirection;
            set {
                _futuresDirectionChanged = true;
                _futuresDirection = value;
            }
        }
        public Ufx32016 SetFuturesDirection(sbyte value)
        {
            FuturesDirection = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx32016 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx32016 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(一腿代码,传入代码必须传入市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx32016 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _stockCode2;
        private bool _stockCode2Changed;
        /// <summary>
        /// 证券代码2(二腿代码,两腿代码必须都传入或者都不传)
        /// </summary>
        public string StockCode2
        {
            get => _stockCode2;
            set {
                _stockCode2Changed = true;
                _stockCode2 = value;
            }
        }
        public Ufx32016 SetStockCode2(string value)
        {
            StockCode2 = value;
            return this;
        }

        private string _entrustStateList;
        private bool _entrustStateListChanged;
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public string EntrustStateList
        {
            get => _entrustStateList;
            set {
                _entrustStateListChanged = true;
                _entrustStateList = value;
            }
        }
        public Ufx32016 SetEntrustStateList(string value)
        {
            EntrustStateList = value;
            return this;
        }

        private int _extsystemId;
        private bool _extsystemIdChanged;
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId
        {
            get => _extsystemId;
            set {
                _extsystemIdChanged = true;
                _extsystemId = value;
            }
        }
        public Ufx32016 SetExtsystemId(int value)
        {
            ExtsystemId = value;
            return this;
        }

        private string _thirdReff;
        private bool _thirdReffChanged;
        /// <summary>
        /// 第三方系统自定义说明(供外部系统使用,格式及用法自定义.)
        /// </summary>
        public string ThirdReff
        {
            get => _thirdReff;
            set {
                _thirdReffChanged = true;
                _thirdReff = value;
            }
        }
        public Ufx32016 SetThirdReff(string value)
        {
            ThirdReff = value;
            return this;
        }

        private string _positionStr;
        private bool _positionStrChanged;
        /// <summary>
        /// 定位串(定位串,默认传入0,查询时,返回大于传入定位串的记录.)
        /// </summary>
        public string PositionStr
        {
            get => _positionStr;
            set {
                _positionStrChanged = true;
                _positionStr = value;
            }
        }
        public Ufx32016 SetPositionStr(string value)
        {
            PositionStr = value;
            return this;
        }

        private int _requestNum;
        private bool _requestNumChanged;
        /// <summary>
        /// 请求数(默认1000,最大为10000.)
        /// </summary>
        public int RequestNum
        {
            get => _requestNum;
            set {
                _requestNumChanged = true;
                _requestNum = value;
            }
        }
        public Ufx32016 SetRequestNum(int value)
        {
            RequestNum = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_batchNoChanged)
            {
                packer.AddField("batch_no", (sbyte)'I', 8, 4);
            }
            if (_entrustNoChanged)
            {
                packer.AddField("entrust_no", (sbyte)'I', 8, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddField("entrust_direction", (sbyte)'S', 4, 4);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddField("futures_direction", (sbyte)'C', 1, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_stockCode2Changed)
            {
                packer.AddField("stock_code2", (sbyte)'S', 16, 4);
            }
            if (_entrustStateListChanged)
            {
                packer.AddField("entrust_state_list", (sbyte)'S', 256, 4);
            }
            if (_extsystemIdChanged)
            {
                packer.AddField("extsystem_id", (sbyte)'I', 8, 4);
            }
            if (_thirdReffChanged)
            {
                packer.AddField("third_reff", (sbyte)'S', 256, 4);
            }
            if (_positionStrChanged)
            {
                packer.AddField("position_str", (sbyte)'S', 32, 4);
            }
            if (_requestNumChanged)
            {
                packer.AddField("request_num", (sbyte)'I', 8, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_batchNoChanged)
            {
                packer.AddInt(_batchNo);
            }
            if (_entrustNoChanged)
            {
                packer.AddInt(_entrustNo);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_entrustDirectionChanged)
            {
                packer.AddStr(_entrustDirection);
            }
            if (_futuresDirectionChanged)
            {
                packer.AddChar(_futuresDirection);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_stockCode2Changed)
            {
                packer.AddStr(_stockCode2);
            }
            if (_entrustStateListChanged)
            {
                packer.AddStr(_entrustStateList);
            }
            if (_extsystemIdChanged)
            {
                packer.AddInt(_extsystemId);
            }
            if (_thirdReffChanged)
            {
                packer.AddStr(_thirdReff);
            }
            if (_positionStrChanged)
            {
                packer.AddStr(_positionStr);
            }
            if (_requestNumChanged)
            {
                packer.AddInt(_requestNum);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 31005
    /// 功能名称: 支持查询现货\期货\期权持仓信息
    /// 业务范围: 标准
    /// </summary>
    public sealed class Ufx31005 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 31005;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        public Ufx31005(string userToken)
        {
            UserToken = userToken;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 令牌号(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }
        public Ufx31005 SetAccountCode(string value)
        {
            AccountCode = value;
            return this;
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        public Ufx31005 SetAssetNo(string value)
        {
            AssetNo = value;
            return this;
        }

        private string _combiNo;
        private bool _combiNoChanged;
        /// <summary>
        /// 组合编号(资产单元组合二选一必传,如果传入的组合或资产单元不能确定唯一组合或资产单元,则返回错误.)
        /// </summary>
        public string CombiNo
        {
            get => _combiNo;
            set {
                _combiNoChanged = true;
                _combiNo = value;
            }
        }
        public Ufx31005 SetCombiNo(string value)
        {
            CombiNo = value;
            return this;
        }

        private string _marketNo;
        private bool _marketNoChanged;
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo
        {
            get => _marketNo;
            set {
                _marketNoChanged = true;
                _marketNo = value;
            }
        }
        public Ufx31005 SetMarketNo(string value)
        {
            MarketNo = value;
            return this;
        }

        private string _stockCode;
        private bool _stockCodeChanged;
        /// <summary>
        /// 证券代码(传入证券代码请同时传入交易市场)
        /// </summary>
        public string StockCode
        {
            get => _stockCode;
            set {
                _stockCodeChanged = true;
                _stockCode = value;
            }
        }
        public Ufx31005 SetStockCode(string value)
        {
            StockCode = value;
            return this;
        }

        private string _stockholderId;
        private bool _stockholderIdChanged;
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId
        {
            get => _stockholderId;
            set {
                _stockholderIdChanged = true;
                _stockholderId = value;
            }
        }
        public Ufx31005 SetStockholderId(string value)
        {
            StockholderId = value;
            return this;
        }

        private string _holdSeat;
        private bool _holdSeatChanged;
        /// <summary>
        /// 持仓席位
        /// </summary>
        public string HoldSeat
        {
            get => _holdSeat;
            set {
                _holdSeatChanged = true;
                _holdSeat = value;
            }
        }
        public Ufx31005 SetHoldSeat(string value)
        {
            HoldSeat = value;
            return this;
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_combiNoChanged)
            {
                packer.AddField("combi_no", (sbyte)'S', 16, 4);
            }
            if (_marketNoChanged)
            {
                packer.AddField("market_no", (sbyte)'S', 3, 4);
            }
            if (_stockCodeChanged)
            {
                packer.AddField("stock_code", (sbyte)'S', 16, 4);
            }
            if (_stockholderIdChanged)
            {
                packer.AddField("stockholder_id", (sbyte)'S', 20, 4);
            }
            if (_holdSeatChanged)
            {
                packer.AddField("hold_seat", (sbyte)'S', 6, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            if (_combiNoChanged)
            {
                packer.AddStr(_combiNo);
            }
            if (_marketNoChanged)
            {
                packer.AddStr(_marketNo);
            }
            if (_stockCodeChanged)
            {
                packer.AddStr(_stockCode);
            }
            if (_stockholderIdChanged)
            {
                packer.AddStr(_stockholderId);
            }
            if (_holdSeatChanged)
            {
                packer.AddStr(_holdSeat);
            }
            packer.EndPack();
            return packer;
        }
    }
    /// <summary>
    /// 功能号: 35008
    /// 功能名称: 支持获取当前可用的委托批号
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35008 : IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        public int FunctionId => 35008;
        /// <summary>
        /// 包含必选项的构造函数
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        /// <param name="accountCode">账户编号</param>
        /// <param name="assetNo">资产单元编号</param>
        public Ufx35008(string userToken, string accountCode, string assetNo)
        {
            UserToken = userToken;
            AccountCode = accountCode;
            AssetNo = assetNo;
        }

        private string _userToken;
        private bool _userTokenChanged;
        /// <summary>
        /// 用户口令(取登陆成功返回的令牌号.)
        /// </summary>
        public string UserToken
        {
            get => _userToken;
            set {
                _userTokenChanged = true;
                _userToken = value;
            }
        }

        private string _accountCode;
        private bool _accountCodeChanged;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode
        {
            get => _accountCode;
            set {
                _accountCodeChanged = true;
                _accountCode = value;
            }
        }

        private string _assetNo;
        private bool _assetNoChanged;
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo
        {
            get => _assetNo;
            set {
                _assetNoChanged = true;
                _assetNo = value;
            }
        }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        public CT2Packer Pack()
        {
            var packer = new CT2Packer(2);
            packer.BeginPack();
            if (_userTokenChanged)
            {
                packer.AddField("user_token", (sbyte)'S', 512, 4);
            }
            if (_accountCodeChanged)
            {
                packer.AddField("account_code", (sbyte)'S', 32, 4);
            }
            if (_assetNoChanged)
            {
                packer.AddField("asset_no", (sbyte)'S', 16, 4);
            }
            if (_userTokenChanged)
            {
                packer.AddStr(_userToken);
            }
            if (_accountCodeChanged)
            {
                packer.AddStr(_accountCode);
            }
            if (_assetNoChanged)
            {
                packer.AddStr(_assetNo);
            }
            packer.EndPack();
            return packer;
        }
    }
}
