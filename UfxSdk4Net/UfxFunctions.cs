
using System;
using hundsun.t2sdk;

namespace QuantBox.XApi
{    
    /// <summary>
    /// Account功能类型
    /// </summary>
    public static class UfxAccountFunction
    {
                /// <summary>
        /// 功能名称: 心跳功能,该功能用于刷新令牌活跃时间,以避免令牌过期.
        /// </summary>
        public const int F10000 = 10000;
        /// <summary>
        /// 功能名称: 心跳功能,该功能用于刷新令牌活跃时间,以避免令牌过期.
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        
        public static Ufx10000 Make10000(string userToken)
        {
            return new Ufx10000(userToken);
        }
                /// <summary>
        /// 功能名称: 建立与投资管理系统的连接,UFX系统中做其他操作前必须先进行登陆.
        /// </summary>
        public const int F10001 = 10001;
        /// <summary>
        /// 功能名称: 建立与投资管理系统的连接,UFX系统中做其他操作前必须先进行登陆.
        /// </summary>
        /// <param name="operatorNo">操作员编号(投资系统操作员编号,要求在投资系统的登陆模式或该操作员的登陆模式为操作员编号登陆.)</param>
/// <param name="password">操作员密码</param>
/// <param name="macAddress">登录机器MAC地址(MAC信息要输入标准的12位,否则站点控制不生效)</param>
/// <param name="ipAddress">登录机器IP地址</param>
/// <param name="opStation">登录站点</param>
/// <param name="authorizationId">开发者授权编号(联系恒生获取.(注:现已经接入的系统请于2014年12月31号前获取授权并完成程序更新.联系方式:o3kffb@hundsun.com))</param>
        
        public static Ufx10001 Make10001(string operatorNo, string password, string macAddress, string ipAddress, string opStation, string authorizationId)
        {
            return new Ufx10001(operatorNo, password, macAddress, ipAddress, opStation, authorizationId);
        }
                /// <summary>
        /// 功能名称: 断开与UFX服务器的连接,令牌号失效,释放连接数.
        /// </summary>
        public const int F10002 = 10002;
        /// <summary>
        /// 功能名称: 断开与UFX服务器的连接,令牌号失效,释放连接数.
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        
        public static Ufx10002 Make10002(string userToken)
        {
            return new Ufx10002(userToken);
        }
                /// <summary>
        /// 功能名称: 修改操作员密码
        /// </summary>
        public const int F10003 = 10003;
        /// <summary>
        /// 功能名称: 修改操作员密码
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="oldPassword">原密码</param>
/// <param name="newPassword">新密码</param>
        
        public static Ufx10003 Make10003(string userToken, string oldPassword, string newPassword)
        {
            return new Ufx10003(userToken, oldPassword, newPassword);
        }
                /// <summary>
        /// 功能名称: 支持查询登陆操作员有操作权限的有效账户列表
        /// </summary>
        public const int F30001 = 30001;
        /// <summary>
        /// 功能名称: 支持查询登陆操作员有操作权限的有效账户列表
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        
        public static Ufx30001 Make30001(string userToken)
        {
            return new Ufx30001(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询登陆操作员有操作权限的资产单元列表
        /// </summary>
        public const int F30002 = 30002;
        /// <summary>
        /// 功能名称: 支持查询登陆操作员有操作权限的资产单元列表
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        
        public static Ufx30002 Make30002(string userToken)
        {
            return new Ufx30002(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询登陆操作员有操作权限且状态为有效的组合列表
        /// </summary>
        public const int F30003 = 30003;
        /// <summary>
        /// 功能名称: 支持查询登陆操作员有操作权限且状态为有效的组合列表
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        
        public static Ufx30003 Make30003(string userToken)
        {
            return new Ufx30003(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询交易股东信息
        /// </summary>
        public const int F30004 = 30004;
        /// <summary>
        /// 功能名称: 支持查询交易股东信息
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        
        public static Ufx30004 Make30004(string userToken)
        {
            return new Ufx30004(userToken);
        }
                /// <summary>
        /// 功能名称: 支持批量查询股东信息
        /// </summary>
        public const int F30005 = 30005;
        /// <summary>
        /// 功能名称: 支持批量查询股东信息
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="assetNoList">资产单元编号(如果传入资产单元不能确定唯一的资产单元,则返回错误,批量,逗号隔开,不超过300个)</param>
        
        public static Ufx30005 Make30005(string userToken, string assetNoList)
        {
            return new Ufx30005(userToken, assetNoList);
        }
                /// <summary>
        /// 功能名称: 支持查询账户清算状态,期现货可以分开查询(OPLUS专用).
        /// </summary>
        public const int F30007 = 30007;
        /// <summary>
        /// 功能名称: 支持查询账户清算状态,期现货可以分开查询(OPLUS专用).
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        
        public static Ufx30007 Make30007(string userToken)
        {
            return new Ufx30007(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询账户资产信息
        /// </summary>
        public const int F35003 = 35003;
        /// <summary>
        /// 功能名称: 支持查询账户资产信息
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="accountCode">账户编号</param>
        
        public static Ufx35003 Make35003(string userToken, string accountCode)
        {
            return new Ufx35003(userToken, accountCode);
        }
                /// <summary>
        /// 功能名称: 支持查询账户资产信息(本币汇总)
        /// </summary>
        public const int F35010 = 35010;
        /// <summary>
        /// 功能名称: 支持查询账户资产信息(本币汇总)
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="accountCode">账户编号</param>
        
        public static Ufx35010 Make35010(string userToken, string accountCode)
        {
            return new Ufx35010(userToken, accountCode);
        }
                /// <summary>
        /// 功能名称: 支持查询资产单元资产信息
        /// </summary>
        public const int F35011 = 35011;
        /// <summary>
        /// 功能名称: 支持查询资产单元资产信息
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        [Obsolete("不维护")]
        
        public static Ufx35011 Make35011(string userToken)
        {
            return new Ufx35011(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询资产单元资产信息,查询结果为按照本币汇总后的数据
        /// </summary>
        public const int F35024 = 35024;
        /// <summary>
        /// 功能名称: 支持查询资产单元资产信息,查询结果为按照本币汇总后的数据
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="accountCode">账户编号</param>
        
        public static Ufx35024 Make35024(string userToken, string accountCode)
        {
            return new Ufx35024(userToken, accountCode);
        }
                /// <summary>
        /// 功能名称: 支持查询期货账户盈亏信息
        /// </summary>
        public const int F35025 = 35025;
        /// <summary>
        /// 功能名称: 支持查询期货账户盈亏信息
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="accountCode">账户编号</param>
/// <param name="assetNo">资产单元编号</param>
        
        public static Ufx35025 Make35025(string userToken, string accountCode, string assetNo)
        {
            return new Ufx35025(userToken, accountCode, assetNo);
        }
                /// <summary>
        /// 功能名称: 支持查询当日清算流水
        /// </summary>
        public const int F35012 = 35012;
        /// <summary>
        /// 功能名称: 支持查询当日清算流水
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        
        public static Ufx35012 Make35012(string userToken)
        {
            return new Ufx35012(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询历史清算流水,只能查询一天的历史记录
        /// </summary>
        public const int F36012 = 36012;
        /// <summary>
        /// 功能名称: 支持查询历史清算流水,只能查询一天的历史记录
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="startDate">起始日期(查询起始日期,仅能查询传入日期当天的记录)</param>
        
        public static Ufx36012 Make36012(string userToken, int startDate)
        {
            return new Ufx36012(userToken, startDate);
        }
                /// <summary>
        /// 功能名称: 支持查询可期货保证金比例信息
        /// </summary>
        public const int F35013 = 35013;
        /// <summary>
        /// 功能名称: 支持查询可期货保证金比例信息
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        
        public static Ufx35013 Make35013(string userToken, string marketNo)
        {
            return new Ufx35013(userToken, marketNo);
        }
                /// <summary>
        /// 功能名称: 支持资金调增\资金调减\保证金调增\保证金调减\资金投入\资金支取业务
        /// </summary>
        public const int F35015 = 35015;
        /// <summary>
        /// 功能名称: 支持资金调增\资金调减\保证金调增\保证金调减\资金投入\资金支取业务
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="accountCode">账户编号</param>
/// <param name="assetNo">资产单元编号</param>
/// <param name="adjustMode">调整类型(限定 <see cref="UfxAdjustMode"/> 中定义的常量)</param>
/// <param name="businessBalance">调整金额</param>
/// <param name="enableDate">生效时间</param>
/// <param name="remark">备注</param>
        
        public static Ufx35015 Make35015(string userToken, string accountCode, string assetNo, sbyte adjustMode, double businessBalance, int enableDate, string remark)
        {
            return new Ufx35015(userToken, accountCode, assetNo, adjustMode, businessBalance, enableDate, remark);
        }
                /// <summary>
        /// 功能名称: 支持资金冻结,资金解冻
        /// </summary>
        public const int F35017 = 35017;
        /// <summary>
        /// 功能名称: 支持资金冻结,资金解冻
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="accountCode">账户编号</param>
/// <param name="assetNo">资产单元编号</param>
/// <param name="fundOpFlag">资金操作类型(1资金冻结;2资金解冻)</param>
/// <param name="occurBalance">发生金额</param>
/// <param name="currencyCode">币种代码(限定 <see cref="UfxCurrencyCode"/> 中定义的常量)</param>
/// <param name="enableDate">生效日期(非远期传系统当日)</param>
/// <param name="expireDate">到期日期(冻结到期日期,永久传入99991231.生效日期和到期日期可相等,表示当日日终失效)</param>
        
        public static Ufx35017 Make35017(string userToken, string accountCode, string assetNo, int fundOpFlag, double occurBalance, string currencyCode, int enableDate, int expireDate)
        {
            return new Ufx35017(userToken, accountCode, assetNo, fundOpFlag, occurBalance, currencyCode, enableDate, expireDate);
        }
                /// <summary>
        /// 功能名称: 支持取消资金冻结,取消资金解冻
        /// </summary>
        public const int F35018 = 35018;
        /// <summary>
        /// 功能名称: 支持取消资金冻结,取消资金解冻
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="frozenSerialNo">冻结解冻序号(该字段值可以从35019接口获取)</param>
        
        public static Ufx35018 Make35018(string userToken, int frozenSerialNo)
        {
            return new Ufx35018(userToken, frozenSerialNo);
        }
                /// <summary>
        /// 功能名称: 支持查询资金冻结解冻明细
        /// </summary>
        public const int F35019 = 35019;
        /// <summary>
        /// 功能名称: 支持查询资金冻结解冻明细
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="startDate">起始日期(查询起始日期,查询历史记录日期不能大于等于当前日期)</param>
/// <param name="endDate">结束日期(查询结束日期,查询历史记录日期不能大于等于当前日期)</param>
        
        public static Ufx35019 Make35019(string userToken, int startDate, int endDate)
        {
            return new Ufx35019(userToken, startDate, endDate);
        }
                /// <summary>
        /// 功能名称: 支持资金划转,支持批量传入,最大1000条.
        /// </summary>
        public const int F35021 = 35021;
        /// <summary>
        /// 功能名称: 支持资金划转,支持批量传入,最大1000条.
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="accountCode">账户编号</param>
/// <param name="assetNo">资产单元编号</param>
/// <param name="targetAccountCode">目标账户编号</param>
/// <param name="targetAssetNo">目标资产单元编号</param>
/// <param name="occurBalance">发生金额</param>
/// <param name="enableDate">生效日期(非远期传系统当日)</param>
        
        public static Ufx35021 Make35021(string userToken, string accountCode, string assetNo, string targetAccountCode, string targetAssetNo, double occurBalance, int enableDate)
        {
            return new Ufx35021(userToken, accountCode, assetNo, targetAccountCode, targetAssetNo, occurBalance, enableDate);
        }
                /// <summary>
        /// 功能名称: 支持现货,期货划转,支持批量传入,最大1000条.不支持批量跨基金证券划转
        /// </summary>
        public const int F35022 = 35022;
        /// <summary>
        /// 功能名称: 支持现货,期货划转,支持批量传入,最大1000条.不支持批量跨基金证券划转
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
        
        public static Ufx35022 Make35022(string userToken, string accountCode, string combiNo, string stockholderId, string holdSeat, sbyte positionFlag, string marketNo, string stockCode, string targetAccountCode, string targetCombiNo, double secutransPrice, int secutransAmount, int enableDate)
        {
            return new Ufx35022(userToken, accountCode, combiNo, stockholderId, holdSeat, positionFlag, marketNo, stockCode, targetAccountCode, targetCombiNo, secutransPrice, secutransAmount, enableDate);
        }
                /// <summary>
        /// 功能名称: 支持查询现货\期货\期权持仓信息
        /// </summary>
        public const int F31005 = 31005;
        /// <summary>
        /// 功能名称: 支持查询现货\期货\期权持仓信息
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        
        public static Ufx31005 Make31005(string userToken)
        {
            return new Ufx31005(userToken);
        }
                /// <summary>
        /// 功能名称: 支持获取当前可用的委托批号
        /// </summary>
        public const int F35008 = 35008;
        /// <summary>
        /// 功能名称: 支持获取当前可用的委托批号
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
/// <param name="accountCode">账户编号</param>
/// <param name="assetNo">资产单元编号</param>
        
        public static Ufx35008 Make35008(string userToken, string accountCode, string assetNo)
        {
            return new Ufx35008(userToken, accountCode, assetNo);
        }
            }
        /// <summary>
    /// Securities功能类型
    /// </summary>
    public static class UfxSecuritiesFunction
    {
                /// <summary>
        /// 功能名称: 支持沪深股票\基金买卖\债券买卖,新股申购\可转债申购\质押式回购\债转股\债回售\基金认购\配股认购\配债认购\债券认购业务.(不含固定收益和大宗交易).支持CDR存托凭证业务,支持沪伦通业务.
        /// </summary>
        public const int F91001 = 91001;
        /// <summary>
        /// 功能名称: 支持沪深股票\基金买卖\债券买卖,新股申购\可转债申购\质押式回购\债转股\债回售\基金认购\配股认购\配债认购\债券认购业务.(不含固定收益和大宗交易).支持CDR存托凭证业务,支持沪伦通业务.
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
/// <param name="stockCode">证券代码(对于质押式回购业务,传对应的挂单代码,如:上海出入库用质押券代码,深圳出入库用债券代码.)</param>
/// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
/// <param name="priceType">委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)</param>
/// <param name="entrustPrice">委托价格(1,当价格类型为市价时,头寸和风控控制买入按涨停价控.;2,债券回购业务价格传回购利率,如3.5%填入3.5.;3,提交质押\回转质押\基金认购\债转股\配股认购业务,价格字段无效,系统自动按交易所规则申报)</param>
/// <param name="entrustAmount">委托数量(单位为股(份\张).)</param>
        
        public static Ufx91001 Make91001(string userToken, string marketNo, string stockCode, string entrustDirection, sbyte priceType, double entrustPrice, int entrustAmount)
        {
            return new Ufx91001(userToken, marketNo, stockCode, entrustDirection, priceType, entrustPrice, entrustAmount);
        }
                /// <summary>
        /// 功能名称: 支持股转市场做市业务
        /// </summary>
        public const int F91011 = 91011;
        /// <summary>
        /// 功能名称: 支持股转市场做市业务
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="stockCode">证券代码</param>
        
        public static Ufx91011 Make91011(string userToken, string stockCode)
        {
            return new Ufx91011(userToken, stockCode);
        }
                /// <summary>
        /// 功能名称: 支持按委托序号撤销股转做市委托.
        /// </summary>
        public const int F91115 = 91115;
        /// <summary>
        /// 功能名称: 支持按委托序号撤销股转做市委托.
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="accountCode">账户编号</param>
/// <param name="combiNo">组合编号</param>
/// <param name="entrustNo">委托序号</param>
        
        public static Ufx91115 Make91115(string userToken, string accountCode, string combiNo, int entrustNo)
        {
            return new Ufx91115(userToken, accountCode, combiNo, entrustNo);
        }
                /// <summary>
        /// 功能名称: 支持按委托序号撤销股转做市委托.
        /// </summary>
        public const int F91113 = 91113;
        /// <summary>
        /// 功能名称: 支持按委托序号撤销股转做市委托.
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="entrustNo">委托序号()</param>
        
        public static Ufx91113 Make91113(string userToken, int entrustNo)
        {
            return new Ufx91113(userToken, entrustNo);
        }
                /// <summary>
        /// 功能名称: 支持沪深股票\基金\债券买卖和股指期货\国债期货\商品期货\股票期权业务.支持CDR存托凭证业务,支持沪伦通业务
        /// </summary>
        public const int F91090 = 91090;
        /// <summary>
        /// 功能名称: 支持沪深股票\基金\债券买卖和股指期货\国债期货\商品期货\股票期权业务.支持CDR存托凭证业务,支持沪伦通业务
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
/// <param name="stockCode">证券代码</param>
/// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
/// <param name="priceType">委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)</param>
/// <param name="entrustPrice">委托价格</param>
/// <param name="entrustAmount">委托数量</param>
        
        public static Ufx91090 Make91090(string userToken, string marketNo, string stockCode, string entrustDirection, sbyte priceType, double entrustPrice, int entrustAmount)
        {
            return new Ufx91090(userToken, marketNo, stockCode, entrustDirection, priceType, entrustPrice, entrustAmount);
        }
                /// <summary>
        /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
        /// </summary>
        public const int F91114 = 91114;
        /// <summary>
        /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="accountCode">账户编号</param>
/// <param name="combiNo">组合编号</param>
/// <param name="entrustNo">委托序号</param>
        
        public static Ufx91114 Make91114(string userToken, string accountCode, string combiNo, int entrustNo)
        {
            return new Ufx91114(userToken, accountCode, combiNo, entrustNo);
        }
                /// <summary>
        /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
        /// </summary>
        public const int F91101 = 91101;
        /// <summary>
        /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="entrustNo">委托序号()</param>
        
        public static Ufx91101 Make91101(string userToken, int entrustNo)
        {
            return new Ufx91101(userToken, entrustNo);
        }
                /// <summary>
        /// 功能名称: 支持按委托批号撤单,支持对证券\期货\期权\策略等业务按委托批号撤单
        /// </summary>
        public const int F91102 = 91102;
        /// <summary>
        /// 功能名称: 支持按委托批号撤单,支持对证券\期货\期权\策略等业务按委托批号撤单
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="batchNo">委托批号</param>
        
        public static Ufx91102 Make91102(string userToken, int batchNo)
        {
            return new Ufx91102(userToken, batchNo);
        }
                /// <summary>
        /// 功能名称: 支持查询沪深及股转市场的股票\基金\债券的持仓信息
        /// </summary>
        public const int F31001 = 31001;
        /// <summary>
        /// 功能名称: 支持查询沪深及股转市场的股票\基金\债券的持仓信息
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        
        public static Ufx31001 Make31001(string userToken)
        {
            return new Ufx31001(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询提交\转回质押的质押券数量明细(OPLUS专用)
        /// </summary>
        public const int F31002 = 31002;
        /// <summary>
        /// 功能名称: 支持查询提交\转回质押的质押券数量明细(OPLUS专用)
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="assetNo">资产单元编号</param>
        
        public static Ufx31002 Make31002(string userToken, string assetNo)
        {
            return new Ufx31002(userToken, assetNo);
        }
                /// <summary>
        /// 功能名称: 支持查询现货,期货,期权的证券资料信息.
        /// </summary>
        public const int F30011 = 30011;
        /// <summary>
        /// 功能名称: 支持查询现货,期货,期权的证券资料信息.
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        
        public static Ufx30011 Make30011(string userToken)
        {
            return new Ufx30011(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询当日普通买卖委托流水,包含沪深股票\基金买卖\债券买卖,新股申购\可转债申购\质押式回购\债转股\债回售\基金认购\配股认购\配债认购\债券认购\股转市场业务
        /// </summary>
        public const int F32001 = 32001;
        /// <summary>
        /// 功能名称: 支持查询当日普通买卖委托流水,包含沪深股票\基金买卖\债券买卖,新股申购\可转债申购\质押式回购\债转股\债回售\基金认购\配股认购\配债认购\债券认购\股转市场业务
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        
        public static Ufx32001 Make32001(string userToken)
        {
            return new Ufx32001(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询历史普通买卖委托流水
        /// </summary>
        public const int F32101 = 32101;
        /// <summary>
        /// 功能名称: 支持查询历史普通买卖委托流水
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
/// <param name="startDate">起始日期(查询起始日期)</param>
/// <param name="endDate">结束日期(查询结束日期)</param>
/// <param name="accountCode">账户编号</param>
        
        public static Ufx32101 Make32101(string userToken, int startDate, int endDate, string accountCode)
        {
            return new Ufx32101(userToken, startDate, endDate, accountCode);
        }
                /// <summary>
        /// 功能名称: 支持查询当日股转做市委托
        /// </summary>
        public const int F32006 = 32006;
        /// <summary>
        /// 功能名称: 支持查询当日股转做市委托
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="accountCode">账户编号</param>
        
        public static Ufx32006 Make32006(string userToken, string accountCode)
        {
            return new Ufx32006(userToken, accountCode);
        }
                /// <summary>
        /// 功能名称: 支持查询当日普通买卖委托以及当日股转做市委托对应的成交流水
        /// </summary>
        public const int F33001 = 33001;
        /// <summary>
        /// 功能名称: 支持查询当日普通买卖委托以及当日股转做市委托对应的成交流水
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        
        public static Ufx33001 Make33001(string userToken)
        {
            return new Ufx33001(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询历史普通买卖成交流水
        /// </summary>
        public const int F33101 = 33101;
        /// <summary>
        /// 功能名称: 支持查询历史普通买卖成交流水
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
/// <param name="startDate">起始日期(查询起始日期格式YYYYMMDD)</param>
/// <param name="endDate">结束日期(查询结束日期格式YYYYMMDD)</param>
/// <param name="accountCode">账户编号</param>
        
        public static Ufx33101 Make33101(string userToken, int startDate, int endDate, string accountCode)
        {
            return new Ufx33101(userToken, startDate, endDate, accountCode);
        }
                /// <summary>
        /// 功能名称: 支持查询沪深A股及股转市场资金账户的资金可用,支持批量传入.
        /// </summary>
        public const int F34001 = 34001;
        /// <summary>
        /// 功能名称: 支持查询沪深A股及股转市场资金账户的资金可用,支持批量传入.
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        
        public static Ufx34001 Make34001(string userToken)
        {
            return new Ufx34001(userToken);
        }
                /// <summary>
        /// 功能名称: 支持股转市场协议转让交易业务.
        /// </summary>
        public const int F91051 = 91051;
        /// <summary>
        /// 功能名称: 支持股转市场协议转让交易业务.
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="stockCode">证券代码</param>
/// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
/// <param name="priceType">委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)</param>
/// <param name="entrustPrice">委托价格(当价格类型为市价时,头寸和风控控制买入按涨停价控.)</param>
/// <param name="entrustAmount">委托数量(单位为股.)</param>
        
        public static Ufx91051 Make91051(string userToken, string stockCode, string entrustDirection, sbyte priceType, double entrustPrice, int entrustAmount)
        {
            return new Ufx91051(userToken, stockCode, entrustDirection, priceType, entrustPrice, entrustAmount);
        }
                /// <summary>
        /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
        /// </summary>
        public const int F91116 = 91116;
        /// <summary>
        /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="accountCode">账户编号</param>
/// <param name="combiNo">组合编号</param>
/// <param name="entrustNo">委托序号</param>
        
        public static Ufx91116 Make91116(string userToken, string accountCode, string combiNo, int entrustNo)
        {
            return new Ufx91116(userToken, accountCode, combiNo, entrustNo);
        }
                /// <summary>
        /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
        /// </summary>
        public const int F91151 = 91151;
        /// <summary>
        /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="entrustNo">委托序号</param>
        
        public static Ufx91151 Make91151(string userToken, int entrustNo)
        {
            return new Ufx91151(userToken, entrustNo);
        }
            }
        /// <summary>
    /// Fund功能类型
    /// </summary>
    public static class UfxFundFunction
    {
                /// <summary>
        /// 功能名称: 支持沪深ETF\沪深跨市场ETF\沪深跨境ETF申赎业务
        /// </summary>
        public const int F91003 = 91003;
        /// <summary>
        /// 功能名称: 支持沪深ETF\沪深跨市场ETF\沪深跨境ETF申赎业务
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
/// <param name="stockCode">证券代码</param>
/// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
/// <param name="entrustAmount">委托数量(申赎数量单位为篮子数.如最小申购单位是100万份,要申赎200万,该字段填2.)</param>
        [Obsolete("不维护")]
        
        public static Ufx91003 Make91003(string userToken, string marketNo, string stockCode, string entrustDirection, int entrustAmount)
        {
            return new Ufx91003(userToken, marketNo, stockCode, entrustDirection, entrustAmount);
        }
                /// <summary>
        /// 功能名称: 支持ETF(股票型ETF\债券型ETF\华宝兴业交易型货币基金\沪深跨境ETF\沪深黄金ETF\深交所交易型货币基金)\场内开放式基金申赎(LOF)\LOF基金分拆合并\转托管.基金买卖委托请用91001接口
        /// </summary>
        public const int F91008 = 91008;
        /// <summary>
        /// 功能名称: 支持ETF(股票型ETF\债券型ETF\华宝兴业交易型货币基金\沪深跨境ETF\沪深黄金ETF\深交所交易型货币基金)\场内开放式基金申赎(LOF)\LOF基金分拆合并\转托管.基金买卖委托请用91001接口
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
/// <param name="stockCode">证券代码</param>
/// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
        
        public static Ufx91008 Make91008(string userToken, string marketNo, string stockCode, string entrustDirection)
        {
            return new Ufx91008(userToken, marketNo, stockCode, entrustDirection);
        }
                /// <summary>
        /// 功能名称: 支持查询当日基金一级市场委托流水.
        /// </summary>
        public const int F32002 = 32002;
        /// <summary>
        /// 功能名称: 支持查询当日基金一级市场委托流水.
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        
        public static Ufx32002 Make32002(string userToken)
        {
            return new Ufx32002(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询ETF申赎时的成份股和资金代码委托明细信息.
        /// </summary>
        public const int F32005 = 32005;
        /// <summary>
        /// 功能名称: 支持查询ETF申赎时的成份股和资金代码委托明细信息.
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
/// <param name="entrustNo">委托序号(按委托序号查询)</param>
        
        public static Ufx32005 Make32005(string userToken, int entrustNo)
        {
            return new Ufx32005(userToken, entrustNo);
        }
                /// <summary>
        /// 功能名称: 支持查询当日基金一级市场委托成交流水
        /// </summary>
        public const int F33002 = 33002;
        /// <summary>
        /// 功能名称: 支持查询当日基金一级市场委托成交流水
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        
        public static Ufx33002 Make33002(string userToken)
        {
            return new Ufx33002(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询ETF申赎时的成份股和资金代码成交明细信息.
        /// </summary>
        public const int F33005 = 33005;
        /// <summary>
        /// 功能名称: 支持查询ETF申赎时的成份股和资金代码成交明细信息.
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="entrustNo">委托序号()</param>
        
        public static Ufx33005 Make33005(string userToken, int entrustNo)
        {
            return new Ufx33005(userToken, entrustNo);
        }
                /// <summary>
        /// 功能名称: 支持查询沪深ETF成份股信息
        /// </summary>
        public const int F35014 = 35014;
        /// <summary>
        /// 功能名称: 支持查询沪深ETF成份股信息
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
/// <param name="etfCode">ETF代码（二级市场）()</param>
        
        public static Ufx35014 Make35014(string userToken, string marketNo, string etfCode)
        {
            return new Ufx35014(userToken, marketNo, etfCode);
        }
                /// <summary>
        /// 功能名称: 支持沪深查询ETF基础信息
        /// </summary>
        public const int F35020 = 35020;
        /// <summary>
        /// 功能名称: 支持沪深查询ETF基础信息
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        
        public static Ufx35020 Make35020(string userToken)
        {
            return new Ufx35020(userToken);
        }
            }
        /// <summary>
    /// Futures功能类型
    /// </summary>
    public static class UfxFuturesFunction
    {
                /// <summary>
        /// 功能名称: 支持查询期货市场未过期的期货信息.
        /// </summary>
        public const int F30010 = 30010;
        /// <summary>
        /// 功能名称: 支持查询期货市场未过期的期货信息.
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        
        public static Ufx30010 Make30010(string userToken)
        {
            return new Ufx30010(userToken);
        }
                /// <summary>
        /// 功能名称: 支持中金所股指期货\国债期货和上期所\大商所\郑商所\能源交易所的商品期货业务
        /// </summary>
        public const int F91004 = 91004;
        /// <summary>
        /// 功能名称: 支持中金所股指期货\国债期货和上期所\大商所\郑商所\能源交易所的商品期货业务
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
/// <param name="stockCode">证券代码</param>
/// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
/// <param name="futuresDirection">开平方向('1'-开仓;'2'-平仓;对上期所,能源期货交易所平仓委托,优先平今仓,今仓不足,自动拆分成两笔委托.)</param>
/// <param name="priceType">委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)</param>
/// <param name="entrustPrice">委托价格(委托价格需要注意最小价差,需要传入方自行控制,传入不符合规则要求,则返回失败.)</param>
/// <param name="entrustAmount">委托数量(委托数量需要注意最小买卖单位,需要传入方自行控制,传入不符合规则要求,则返回失败.)</param>
        
        public static Ufx91004 Make91004(string userToken, string marketNo, string stockCode, string entrustDirection, sbyte futuresDirection, sbyte priceType, double entrustPrice, int entrustAmount)
        {
            return new Ufx91004(userToken, marketNo, stockCode, entrustDirection, futuresDirection, priceType, entrustPrice, entrustAmount);
        }
                /// <summary>
        /// 功能名称: 支持商品期货标准套利单\互换单业务.
        /// </summary>
        public const int F91013 = 91013;
        /// <summary>
        /// 功能名称: 支持商品期货标准套利单\互换单业务.
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
/// <param name="stockCode">证券代码(商品期货组合代码.)</param>
/// <param name="entrustDirection">委托方向(控委托方向'1'-买入;'2'卖出)</param>
/// <param name="futuresDirection">开平方向('1'-开仓;'2'-平仓;对上期所平仓委托,优先平今仓,今仓不足,自动拆分成两笔委托.)</param>
/// <param name="priceType">委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)</param>
/// <param name="entrustAmount">委托数量</param>
        
        public static Ufx91013 Make91013(string userToken, string marketNo, string stockCode, string entrustDirection, sbyte futuresDirection, sbyte priceType, int entrustAmount)
        {
            return new Ufx91013(userToken, marketNo, stockCode, entrustDirection, futuresDirection, priceType, entrustAmount);
        }
                /// <summary>
        /// 功能名称: 支持按委托序号撤单,支持多条委托批量撤单
        /// </summary>
        public const int F91119 = 91119;
        /// <summary>
        /// 功能名称: 支持按委托序号撤单,支持多条委托批量撤单
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="accountCode">账户编号</param>
/// <param name="combiNo">组合编号</param>
/// <param name="entrustNo">委托序号</param>
        
        public static Ufx91119 Make91119(string userToken, string accountCode, string combiNo, int entrustNo)
        {
            return new Ufx91119(userToken, accountCode, combiNo, entrustNo);
        }
                /// <summary>
        /// 功能名称: 支持按委托序号撤单,支持多条委托批量撤单
        /// </summary>
        public const int F91105 = 91105;
        /// <summary>
        /// 功能名称: 支持按委托序号撤单,支持多条委托批量撤单
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="entrustNo">委托序号()</param>
        
        public static Ufx91105 Make91105(string userToken, int entrustNo)
        {
            return new Ufx91105(userToken, entrustNo);
        }
                /// <summary>
        /// 功能名称: 支持商品期货组合单撤单
        /// </summary>
        public const int F91121 = 91121;
        /// <summary>
        /// 功能名称: 支持商品期货组合单撤单
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="accountCode">账户编号</param>
/// <param name="combiNo">组合编号</param>
/// <param name="entrustNo">委托序号</param>
        
        public static Ufx91121 Make91121(string userToken, string accountCode, string combiNo, int entrustNo)
        {
            return new Ufx91121(userToken, accountCode, combiNo, entrustNo);
        }
                /// <summary>
        /// 功能名称: 支持商品期货组合单撤单
        /// </summary>
        public const int F91107 = 91107;
        /// <summary>
        /// 功能名称: 支持商品期货组合单撤单
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="entrustNo">委托序号</param>
        
        public static Ufx91107 Make91107(string userToken, int entrustNo)
        {
            return new Ufx91107(userToken, entrustNo);
        }
                /// <summary>
        /// 功能名称: 支持查询期货持仓
        /// </summary>
        public const int F31003 = 31003;
        /// <summary>
        /// 功能名称: 支持查询期货持仓
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        
        public static Ufx31003 Make31003(string userToken)
        {
            return new Ufx31003(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询期货持仓明细
        /// </summary>
        public const int F31013 = 31013;
        /// <summary>
        /// 功能名称: 支持查询期货持仓明细
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        
        public static Ufx31013 Make31013(string userToken)
        {
            return new Ufx31013(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询当日期货委托流水
        /// </summary>
        public const int F32003 = 32003;
        /// <summary>
        /// 功能名称: 支持查询当日期货委托流水
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        
        public static Ufx32003 Make32003(string userToken)
        {
            return new Ufx32003(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询期货历史普通买卖委托流水
        /// </summary>
        public const int F32103 = 32103;
        /// <summary>
        /// 功能名称: 支持查询期货历史普通买卖委托流水
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
/// <param name="startDate">起始日期(查询起始日期)</param>
/// <param name="endDate">结束日期(查询结束日期)</param>
/// <param name="accountCode">账户编号</param>
        
        public static Ufx32103 Make32103(string userToken, int startDate, int endDate, string accountCode)
        {
            return new Ufx32103(userToken, startDate, endDate, accountCode);
        }
                /// <summary>
        /// 功能名称: 支持查询当日商品期货组合委托流水
        /// </summary>
        public const int F32008 = 32008;
        /// <summary>
        /// 功能名称: 支持查询当日商品期货组合委托流水
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        
        public static Ufx32008 Make32008(string userToken)
        {
            return new Ufx32008(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询当日期货成交流水
        /// </summary>
        public const int F33003 = 33003;
        /// <summary>
        /// 功能名称: 支持查询当日期货成交流水
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        
        public static Ufx33003 Make33003(string userToken)
        {
            return new Ufx33003(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询期货历史期货成交流水
        /// </summary>
        public const int F33103 = 33103;
        /// <summary>
        /// 功能名称: 支持查询期货历史期货成交流水
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="startDate">起始日期(查询起始日期)</param>
/// <param name="endDate">结束日期(查询结束日期)</param>
/// <param name="accountCode">账户编号</param>
        
        public static Ufx33103 Make33103(string userToken, int startDate, int endDate, string accountCode)
        {
            return new Ufx33103(userToken, startDate, endDate, accountCode);
        }
                /// <summary>
        /// 功能名称: 支持查询期货保证金账户的资金可用信息,可查询期货\股指期权\商品期权可用保证金,支持批量传入.
        /// </summary>
        public const int F34003 = 34003;
        /// <summary>
        /// 功能名称: 支持查询期货保证金账户的资金可用信息,可查询期货\股指期权\商品期权可用保证金,支持批量传入.
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        
        public static Ufx34003 Make34003(string userToken)
        {
            return new Ufx34003(userToken);
        }
                /// <summary>
        /// 功能名称: 支持期货费率查询,支持中金所股指期货\国债期货和上期所\大商所\郑商所\能源交易所的商品期货业务
        /// </summary>
        public const int F35023 = 35023;
        /// <summary>
        /// 功能名称: 支持期货费率查询,支持中金所股指期货\国债期货和上期所\大商所\郑商所\能源交易所的商品期货业务
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
/// <param name="accountCode">账户编号</param>
/// <param name="assetNo">资产单元编号</param>
        
        public static Ufx35023 Make35023(string userToken, string accountCode, string assetNo)
        {
            return new Ufx35023(userToken, accountCode, assetNo);
        }
            }
        /// <summary>
    /// Options功能类型
    /// </summary>
    public static class UfxOptionsFunction
    {
                /// <summary>
        /// 功能名称: 支持查询期权信息.
        /// </summary>
        public const int F30012 = 30012;
        /// <summary>
        /// 功能名称: 支持查询期权信息.
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        
        public static Ufx30012 Make30012(string userToken)
        {
            return new Ufx30012(userToken);
        }
                /// <summary>
        /// 功能名称: 支持沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权交易业务
        /// </summary>
        public const int F91005 = 91005;
        /// <summary>
        /// 功能名称: 支持沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权交易业务
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
/// <param name="stockCode">证券代码</param>
/// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
/// <param name="futuresDirection">开平方向('1'-开仓;'2'-平仓.)</param>
/// <param name="priceType">委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)</param>
/// <param name="entrustPrice">委托价格(委托价格需要注意最小价差,需要传入方自行控制,传入不符合规则要求,则返回失败.)</param>
/// <param name="entrustAmount">委托数量(委托数量需要注意最小买卖单位,需要传入方自行控制,传入不符合规则要求,则返回失败.)</param>
        
        public static Ufx91005 Make91005(string userToken, string marketNo, string stockCode, string entrustDirection, sbyte futuresDirection, sbyte priceType, double entrustPrice, int entrustAmount)
        {
            return new Ufx91005(userToken, marketNo, stockCode, entrustDirection, futuresDirection, priceType, entrustPrice, entrustAmount);
        }
                /// <summary>
        /// 功能名称: 支持上海股票期权保证券的锁定与解锁业务
        /// </summary>
        public const int F91006 = 91006;
        /// <summary>
        /// 功能名称: 支持上海股票期权保证券的锁定与解锁业务
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
/// <param name="stockCode">证券代码</param>
/// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
/// <param name="entrustAmount">委托数量(委托数量需要注意最小买卖单位,需要传入方自行控制,传入不符合规则要求,则返回失败.)</param>
        
        public static Ufx91006 Make91006(string userToken, string marketNo, string stockCode, string entrustDirection, int entrustAmount)
        {
            return new Ufx91006(userToken, marketNo, stockCode, entrustDirection, entrustAmount);
        }
                /// <summary>
        /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权业务
        /// </summary>
        public const int F91007 = 91007;
        /// <summary>
        /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权业务
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
/// <param name="stockCode">证券代码</param>
/// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
        
        public static Ufx91007 Make91007(string userToken, string marketNo, string stockCode, string entrustDirection)
        {
            return new Ufx91007(userToken, marketNo, stockCode, entrustDirection);
        }
                /// <summary>
        /// 功能名称: 支持上交所股票期权合并行权业务
        /// </summary>
        public const int F91025 = 91025;
        /// <summary>
        /// 功能名称: 支持上交所股票期权合并行权业务
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
/// <param name="stockCode">证券代码(认购期权合约代码)</param>
/// <param name="stockCode2">证券代码2(认沽期权合约代码)</param>
/// <param name="entrustAmount">委托数量(行权数量)</param>
        
        public static Ufx91025 Make91025(string userToken, string marketNo, string stockCode, string stockCode2, int entrustAmount)
        {
            return new Ufx91025(userToken, marketNo, stockCode, stockCode2, entrustAmount);
        }
                /// <summary>
        /// 功能名称: 支持上交所期权合并行权撤单,可传入多条委托序号进行批量撤单.最多支持1000笔
        /// </summary>
        public const int F91126 = 91126;
        /// <summary>
        /// 功能名称: 支持上交所期权合并行权撤单,可传入多条委托序号进行批量撤单.最多支持1000笔
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="accountCode">账户编号</param>
/// <param name="combiNo">组合编号</param>
/// <param name="entrustNo">委托序号</param>
        
        public static Ufx91126 Make91126(string userToken, string accountCode, string combiNo, int entrustNo)
        {
            return new Ufx91126(userToken, accountCode, combiNo, entrustNo);
        }
                /// <summary>
        /// 功能名称: 支持查询当日上交所合并行权委托
        /// </summary>
        public const int F32017 = 32017;
        /// <summary>
        /// 功能名称: 支持查询当日上交所合并行权委托
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="accountCode">账户编号</param>
        
        public static Ufx32017 Make32017(string userToken, string accountCode)
        {
            return new Ufx32017(userToken, accountCode);
        }
                /// <summary>
        /// 功能名称: 支持股指期权做市业务
        /// </summary>
        public const int F91012 = 91012;
        /// <summary>
        /// 功能名称: 支持股指期权做市业务
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
/// <param name="stockCode">证券代码</param>
        [Obsolete("不维护")]
        
        public static Ufx91012 Make91012(string userToken, string marketNo, string stockCode)
        {
            return new Ufx91012(userToken, marketNo, stockCode);
        }
                /// <summary>
        /// 功能名称: 支持深交所股票期权,中金所股指期权做市业务,支持批量传入
        /// </summary>
        public const int F91014 = 91014;
        /// <summary>
        /// 功能名称: 支持深交所股票期权,中金所股指期权做市业务,支持批量传入
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
/// <param name="stockCode">证券代码</param>
        
        public static Ufx91014 Make91014(string userToken, string marketNo, string stockCode)
        {
            return new Ufx91014(userToken, marketNo, stockCode);
        }
                /// <summary>
        /// 功能名称: 支持上交所股票期权篮子委托业务,用于股票期权批量下单和做市委托.
        /// </summary>
        public const int F91091 = 91091;
        /// <summary>
        /// 功能名称: 支持上交所股票期权篮子委托业务,用于股票期权批量下单和做市委托.
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
/// <param name="stockCode">证券代码</param>
/// <param name="entrustDirection">买卖方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
/// <param name="futuresDirection">开平方向('1'-开仓;'2'-平仓;仅对期权有效.)</param>
/// <param name="priceType">委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)</param>
/// <param name="entrustPrice">委托价格(当价格类型为市价时,价格传0)</param>
/// <param name="entrustAmount">委托数量</param>
        
        public static Ufx91091 Make91091(string userToken, string marketNo, string stockCode, string entrustDirection, sbyte futuresDirection, sbyte priceType, double entrustPrice, int entrustAmount)
        {
            return new Ufx91091(userToken, marketNo, stockCode, entrustDirection, futuresDirection, priceType, entrustPrice, entrustAmount);
        }
                /// <summary>
        /// 功能名称: 支持上交所股票期权询价
        /// </summary>
        public const int F91016 = 91016;
        /// <summary>
        /// 功能名称: 支持上交所股票期权询价
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
/// <param name="stockCode">证券代码</param>
        
        public static Ufx91016 Make91016(string userToken, string marketNo, string stockCode)
        {
            return new Ufx91016(userToken, marketNo, stockCode);
        }
                /// <summary>
        /// 功能名称: 支持上交所股票期权回应报价,回应报价修改,支持批量传入
        /// </summary>
        public const int F91017 = 91017;
        /// <summary>
        /// 功能名称: 支持上交所股票期权回应报价,回应报价修改,支持批量传入
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
/// <param name="stockCode">证券代码</param>
/// <param name="quoteMark">报价标识(上交所股票期权回应报价业务时必传,,'02'-回应报价,'03'-回应报价修改)</param>
/// <param name="entrustDirection">委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)</param>
/// <param name="futuresDirection">开平方向('1'-开仓;'2'-平仓.)</param>
/// <param name="priceType">委托价格类型(只支持限价:0)</param>
/// <param name="entrustPrice">委托价格(委托价格需要注意最小价差,需要传入方自行控制,传入不符合规则要求,则返回失败.)</param>
        
        public static Ufx91017 Make91017(string userToken, string marketNo, string stockCode, string quoteMark, string entrustDirection, sbyte futuresDirection, sbyte priceType, double entrustPrice)
        {
            return new Ufx91017(userToken, marketNo, stockCode, quoteMark, entrustDirection, futuresDirection, priceType, entrustPrice);
        }
                /// <summary>
        /// 功能名称: 支持按委托序号撤销期权(股票期权\股指期权\商品期权)委托,可传入多个委托序号进行批量撤单
        /// </summary>
        public const int F91120 = 91120;
        /// <summary>
        /// 功能名称: 支持按委托序号撤销期权(股票期权\股指期权\商品期权)委托,可传入多个委托序号进行批量撤单
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="accountCode">账户编号</param>
/// <param name="combiNo">组合编号</param>
/// <param name="entrustNo">委托序号</param>
        
        public static Ufx91120 Make91120(string userToken, string accountCode, string combiNo, int entrustNo)
        {
            return new Ufx91120(userToken, accountCode, combiNo, entrustNo);
        }
                /// <summary>
        /// 功能名称: 支持按委托序号撤销期权(股票期权\股指期权\商品期权)委托,可传入多个委托序号进行批量撤单
        /// </summary>
        public const int F91106 = 91106;
        /// <summary>
        /// 功能名称: 支持按委托序号撤销期权(股票期权\股指期权\商品期权)委托,可传入多个委托序号进行批量撤单
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="entrustNo">委托序号()</param>
        
        public static Ufx91106 Make91106(string userToken, int entrustNo)
        {
            return new Ufx91106(userToken, entrustNo);
        }
                /// <summary>
        /// 功能名称: 支持按委托批号撤销股指期权委托
        /// </summary>
        public const int F91108 = 91108;
        /// <summary>
        /// 功能名称: 支持按委托批号撤销股指期权委托
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="batchNo">委托批号</param>
        [Obsolete("不维护")]
        
        public static Ufx91108 Make91108(string userToken, int batchNo)
        {
            return new Ufx91108(userToken, batchNo);
        }
                /// <summary>
        /// 功能名称: 支持撤销深交所股票期权做市委托,中金所股指期权做市委托
        /// </summary>
        public const int F91122 = 91122;
        /// <summary>
        /// 功能名称: 支持撤销深交所股票期权做市委托,中金所股指期权做市委托
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="accountCode">账户编号</param>
/// <param name="combiNo">组合编号</param>
/// <param name="entrustNo">委托序号(注意:撤单将会撤掉与该委托所包括的期权代码的所有做市委托.详见下方业务说明.)</param>
        
        public static Ufx91122 Make91122(string userToken, string accountCode, string combiNo, int entrustNo)
        {
            return new Ufx91122(userToken, accountCode, combiNo, entrustNo);
        }
                /// <summary>
        /// 功能名称: 支持撤销深交所股票期权做市委托,中金所股指期权做市委托
        /// </summary>
        public const int F91109 = 91109;
        /// <summary>
        /// 功能名称: 支持撤销深交所股票期权做市委托,中金所股指期权做市委托
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="entrustNo">委托序号(注意:撤单将会撤掉与该委托所包括的期权代码的所有做市委托.详见下方业务说明.)</param>
        
        public static Ufx91109 Make91109(string userToken, int entrustNo)
        {
            return new Ufx91109(userToken, entrustNo);
        }
                /// <summary>
        /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权撤单,可传入多条委托序号进行批量撤单.
        /// </summary>
        public const int F91123 = 91123;
        /// <summary>
        /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权撤单,可传入多条委托序号进行批量撤单.
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="accountCode">账户编号</param>
/// <param name="combiNo">组合编号</param>
/// <param name="entrustNo">委托序号</param>
        
        public static Ufx91123 Make91123(string userToken, string accountCode, string combiNo, int entrustNo)
        {
            return new Ufx91123(userToken, accountCode, combiNo, entrustNo);
        }
                /// <summary>
        /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权撤单,可传入多条委托序号进行批量撤单.
        /// </summary>
        public const int F91111 = 91111;
        /// <summary>
        /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权撤单,可传入多条委托序号进行批量撤单.
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="entrustNo">委托序号</param>
        
        public static Ufx91111 Make91111(string userToken, int entrustNo)
        {
            return new Ufx91111(userToken, entrustNo);
        }
                /// <summary>
        /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权按委托批号撤单.
        /// </summary>
        public const int F91112 = 91112;
        /// <summary>
        /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权按委托批号撤单.
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="batchNo">委托批号</param>
        
        public static Ufx91112 Make91112(string userToken, int batchNo)
        {
            return new Ufx91112(userToken, batchNo);
        }
                /// <summary>
        /// 功能名称: 支持查询沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权持仓信息
        /// </summary>
        public const int F31004 = 31004;
        /// <summary>
        /// 功能名称: 支持查询沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权持仓信息
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        
        public static Ufx31004 Make31004(string userToken)
        {
            return new Ufx31004(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权当日委托流水(除备兑锁定解锁)
        /// </summary>
        public const int F32004 = 32004;
        /// <summary>
        /// 功能名称: 支持查询沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权当日委托流水(除备兑锁定解锁)
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        
        public static Ufx32004 Make32004(string userToken)
        {
            return new Ufx32004(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询当日股指期权\深交所股票期权做市委托
        /// </summary>
        public const int F32007 = 32007;
        /// <summary>
        /// 功能名称: 支持查询当日股指期权\深交所股票期权做市委托
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
/// <param name="accountCode">账户编号</param>
        
        public static Ufx32007 Make32007(string userToken, string accountCode)
        {
            return new Ufx32007(userToken, accountCode);
        }
                /// <summary>
        /// 功能名称: 支持查询沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权当日成交流水
        /// </summary>
        public const int F33004 = 33004;
        /// <summary>
        /// 功能名称: 支持查询沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权当日成交流水
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        
        public static Ufx33004 Make33004(string userToken)
        {
            return new Ufx33004(userToken);
        }
                /// <summary>
        /// 功能名称: 支持沪深衍生品保证金账户查询(股指期权,商品期权保证金账户请使用34003接口查询).
        /// </summary>
        public const int F34004 = 34004;
        /// <summary>
        /// 功能名称: 支持沪深衍生品保证金账户查询(股指期权,商品期权保证金账户请使用34003接口查询).
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
        
        public static Ufx34004 Make34004(string userToken, string marketNo)
        {
            return new Ufx34004(userToken, marketNo);
        }
                /// <summary>
        /// 功能名称: 支持上交所股票期权组合策略保证金交易业务
        /// </summary>
        public const int F91015 = 91015;
        /// <summary>
        /// 功能名称: 支持上交所股票期权组合策略保证金交易业务
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
/// <param name="combistrategyCode">组合策略代码</param>
/// <param name="combiDirection">组合方向(B-组合,C-拆分,D-转备兑,E-备兑转保证金)</param>
/// <param name="marketNo">交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)</param>
/// <param name="entrustAmount">委托数量</param>
        
        public static Ufx91015 Make91015(string userToken, string combistrategyCode, sbyte combiDirection, string marketNo, int entrustAmount)
        {
            return new Ufx91015(userToken, combistrategyCode, combiDirection, marketNo, entrustAmount);
        }
                /// <summary>
        /// 功能名称: 支持查询上交所股票期权组合策略保证金持仓信息
        /// </summary>
        public const int F31015 = 31015;
        /// <summary>
        /// 功能名称: 支持查询上交所股票期权组合策略保证金持仓信息
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        
        public static Ufx31015 Make31015(string userToken)
        {
            return new Ufx31015(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询上交所股票期权组合策略保证金委托信息
        /// </summary>
        public const int F32015 = 32015;
        /// <summary>
        /// 功能名称: 支持查询上交所股票期权组合策略保证金委托信息
        /// </summary>
        /// <param name="userToken">用户口令(取登陆成功返回的令牌号.)</param>
        
        public static Ufx32015 Make32015(string userToken)
        {
            return new Ufx32015(userToken);
        }
                /// <summary>
        /// 功能名称: 支持查询上交所股票期权组合策略保证金成交信息
        /// </summary>
        public const int F33015 = 33015;
        /// <summary>
        /// 功能名称: 支持查询上交所股票期权组合策略保证金成交信息
        /// </summary>
        /// <param name="userToken">令牌号(取登陆成功返回的令牌号.)</param>
        
        public static Ufx33015 Make33015(string userToken)
        {
            return new Ufx33015(userToken);
        }
                /// <summary>
        /// 功能名称: 支持郑商所商品期权套利单业务.
        /// </summary>
        public const int F91018 = 91018;
        /// <summary>
        /// 功能名称: 支持郑商所商品期权套利单业务.
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
        
        public static Ufx91018 Make91018(string userToken, sbyte specialFlag, string marketNo, string stockCode, string stockCode2, string entrustDirection, sbyte futuresDirection, sbyte priceType, double entrustPrice, int entrustAmount)
        {
            return new Ufx91018(userToken, specialFlag, marketNo, stockCode, stockCode2, entrustDirection, futuresDirection, priceType, entrustPrice, entrustAmount);
        }
                /// <summary>
        /// 功能名称: 支持查询当日郑商所商品期权套利单委托
        /// </summary>
        public const int F32016 = 32016;
        /// <summary>
        /// 功能名称: 支持查询当日郑商所商品期权套利单委托
        /// </summary>
        /// <param name="userToken">用户口令(登录成功后,会返回会话令牌.后续调用其它接口函数都需要使用该令牌.)</param>
        
        public static Ufx32016 Make32016(string userToken)
        {
            return new Ufx32016(userToken);
        }
            }
    }
