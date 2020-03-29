
using System;
using System.Collections.Generic;
using hundsun.t2sdk;

namespace QuantBox.XApi
{
    /// <summary>
    /// 功能标识: 10001
    /// 功能名称: 建立与投资管理系统的连接,UFX系统中做其他操作前必须先进行登陆.
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx10001Result 
    {
        /// <summary>
        /// 令牌号(登陆返回令牌号,该令牌号表示用户身份,其他所有接口调用都需要该令牌,该令牌无操作情况下五分钟过期.)
        /// </summary>
        public string UserToken { get; private set; }
        /// <summary>
        /// 版本号(UFX版本号)
        /// </summary>
        public string VersionNo { get; private set; }
        /// <summary>
        /// 密码有效天数
        /// </summary>
        public int PrValidDays { get; private set; }
        public static Ufx10001Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx10001Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx10001Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx10001Result();
                    data.Add(item);
                    item.UserToken = result.GetStr("user_token");
                    item.VersionNo = result.GetStr("version_no");
                    item.PrValidDays = result.GetInt("pr_valid_days");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 30001
    /// 功能名称: 支持查询登陆操作员有操作权限的有效账户列表
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx30001Result 
    {
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 账户名称
        /// </summary>
        public string AccountName { get; private set; }
        /// <summary>
        /// 账户类型(限定 <see cref="UfxAccountType"/> 中定义的常量)
        /// </summary>
        public string AccountType { get; private set; }
        public static Ufx30001Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx30001Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx30001Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx30001Result();
                    data.Add(item);
                    item.AccountCode = result.GetStr("account_code");
                    item.AccountName = result.GetStr("account_name");
                    item.AccountType = result.GetStr("account_type");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 30002
    /// 功能名称: 支持查询登陆操作员有操作权限的资产单元列表
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx30002Result 
    {
        /// <summary>
        /// 资金账号
        /// </summary>
        public string CapitalAccount { get; private set; }
        /// <summary>
        /// 期货营业部资金账号
        /// </summary>
        public string CapitalAccountQh { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 资产单元名称
        /// </summary>
        public string AssetName { get; private set; }
        public static Ufx30002Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx30002Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx30002Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx30002Result();
                    data.Add(item);
                    item.CapitalAccount = result.GetStr("capital_account");
                    item.CapitalAccountQh = result.GetStr("capital_account_qh");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.AssetName = result.GetStr("asset_name");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 30003
    /// 功能名称: 支持查询登陆操作员有操作权限且状态为有效的组合列表
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx30003Result 
    {
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 组合名称
        /// </summary>
        public string CombiName { get; private set; }
        /// <summary>
        /// 允许的交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNoList { get; private set; }
        /// <summary>
        /// 期货投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte FutuInvestType { get; private set; }
        /// <summary>
        /// 允许的委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirectionList { get; private set; }
        public static Ufx30003Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx30003Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx30003Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx30003Result();
                    data.Add(item);
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.CombiName = result.GetStr("combi_name");
                    item.MarketNoList = result.GetStr("market_no_list");
                    item.FutuInvestType = result.GetChar("futu_invest_type");
                    item.EntrustDirectionList = result.GetStr("entrust_direction_list");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 30004
    /// 功能名称: 支持查询交易股东信息
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx30004Result 
    {
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx30004Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx30004Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx30004Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx30004Result();
                    data.Add(item);
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.MarketNo = result.GetStr("market_no");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 30005
    /// 功能名称: 支持批量查询股东信息
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx30005Result 
    {
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 股东名称
        /// </summary>
        public string StockholderName { get; private set; }
        /// <summary>
        /// 股东指定状态(限定 <see cref="UfxBindStatus"/> 中定义的常量)
        /// </summary>
        public sbyte BindStatus { get; private set; }
        /// <summary>
        /// 持仓席位
        /// </summary>
        public string HoldSeat { get; private set; }
        /// <summary>
        /// 信用股东标志('0':不是;'1':是)
        /// </summary>
        public sbyte CreditFlag { get; private set; }
        /// <summary>
        /// 信用股东对应普通股东
        /// </summary>
        public string EquStockholder { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx30005Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx30005Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx30005Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx30005Result();
                    data.Add(item);
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockholderName = result.GetStr("stockholder_name");
                    item.BindStatus = result.GetChar("bind_status");
                    item.HoldSeat = result.GetStr("hold_seat");
                    item.CreditFlag = result.GetChar("credit_flag");
                    item.EquStockholder = result.GetStr("equ_stockholder");
                    item.InvestType = result.GetChar("invest_type");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 30007
    /// 功能名称: 支持查询账户清算状态,期现货可以分开查询(OPLUS专用).
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx30007Result 
    {
        /// <summary>
        /// 系统日期
        /// </summary>
        public int SystemDate { get; private set; }
        /// <summary>
        /// 公司序号
        /// </summary>
        public int CompanyId { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 市场组编号(1:现货市场;2:期货市场)
        /// </summary>
        public int MarketGroupNo { get; private set; }
        /// <summary>
        /// 账户清算状态(1.预清算(T-1日清算没有做完整,后续还需继续清算调差);2.已正式清算)
        /// </summary>
        public sbyte FundLiquidateStatus { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx30007Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx30007Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx30007Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx30007Result();
                    data.Add(item);
                    item.SystemDate = result.GetInt("system_date");
                    item.CompanyId = result.GetInt("company_id");
                    item.AccountCode = result.GetStr("account_code");
                    item.MarketGroupNo = result.GetInt("market_group_no");
                    item.FundLiquidateStatus = result.GetChar("fund_liquidate_status");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 35003
    /// 功能名称: 支持查询账户资产信息
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35003Result 
    {
        /// <summary>
        /// 账户编号()
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 币种(限定 <see cref="UfxCurrencyCode"/> 中定义的常量)
        /// </summary>
        public string CurrencyCode { get; private set; }
        /// <summary>
        /// 总资产
        /// </summary>
        public double TotalAsset { get; private set; }
        /// <summary>
        /// 账户单位净值
        /// </summary>
        public double Nav { get; private set; }
        /// <summary>
        /// 昨日单位净值
        /// </summary>
        public double YesterdayNav { get; private set; }
        /// <summary>
        /// 当前资金余额
        /// </summary>
        public double CurrentBalance { get; private set; }
        /// <summary>
        /// 期初资金余额
        /// </summary>
        public double BeginBalance { get; private set; }
        /// <summary>
        /// 期货保证金账户余额
        /// </summary>
        public double FutuDepositBalance { get; private set; }
        /// <summary>
        /// 期货占用保证金
        /// </summary>
        public double OccupyDepositBalance { get; private set; }
        /// <summary>
        /// 期货资产(期货盈亏(在日终结算时,浮动盈亏要结转成资金))
        /// </summary>
        public double FutuAsset { get; private set; }
        /// <summary>
        /// 股票资产
        /// </summary>
        public double StockAsset { get; private set; }
        /// <summary>
        /// 债券资产
        /// </summary>
        public double BondAsset { get; private set; }
        /// <summary>
        /// 基金资产
        /// </summary>
        public double FundAsset { get; private set; }
        /// <summary>
        /// 期权资产
        /// </summary>
        public double OptionAsset { get; private set; }
        /// <summary>
        /// 回购资产
        /// </summary>
        public double RepoAsset { get; private set; }
        /// <summary>
        /// 其他资产
        /// </summary>
        public double OtherAsset { get; private set; }
        /// <summary>
        /// 基金总份额
        /// </summary>
        public double FundShare { get; private set; }
        /// <summary>
        /// 基金净资产
        /// </summary>
        public double FundNetAsset { get; private set; }
        /// <summary>
        /// 应付款
        /// </summary>
        public double PayableBalance { get; private set; }
        /// <summary>
        /// 应收款
        /// </summary>
        public double ReceivableBalance { get; private set; }
        public static Ufx35003Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx35003Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx35003Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx35003Result();
                    data.Add(item);
                    item.AccountCode = result.GetStr("account_code");
                    item.CurrencyCode = result.GetStr("currency_code");
                    item.TotalAsset = result.GetDouble("total_asset");
                    item.Nav = result.GetDouble("nav");
                    item.YesterdayNav = result.GetDouble("yesterday_nav");
                    item.CurrentBalance = result.GetDouble("current_balance");
                    item.BeginBalance = result.GetDouble("begin_balance");
                    item.FutuDepositBalance = result.GetDouble("futu_deposit_balance");
                    item.OccupyDepositBalance = result.GetDouble("occupy_deposit_balance");
                    item.FutuAsset = result.GetDouble("futu_asset");
                    item.StockAsset = result.GetDouble("stock_asset");
                    item.BondAsset = result.GetDouble("bond_asset");
                    item.FundAsset = result.GetDouble("fund_asset");
                    item.OptionAsset = result.GetDouble("option_asset");
                    item.RepoAsset = result.GetDouble("repo_asset");
                    item.OtherAsset = result.GetDouble("other_asset");
                    item.FundShare = result.GetDouble("fund_share");
                    item.FundNetAsset = result.GetDouble("fund_net_asset");
                    item.PayableBalance = result.GetDouble("payable_balance");
                    item.ReceivableBalance = result.GetDouble("receivable_balance");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 35010
    /// 功能名称: 支持查询账户资产信息(本币汇总)
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35010Result 
    {
        /// <summary>
        /// 账户编号()
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 币种(限定 <see cref="UfxCurrencyCode"/> 中定义的常量)
        /// </summary>
        public string CurrencyCode { get; private set; }
        /// <summary>
        /// 总资产
        /// </summary>
        public double TotalAsset { get; private set; }
        /// <summary>
        /// 账户单位净值
        /// </summary>
        public double Nav { get; private set; }
        /// <summary>
        /// 昨日单位净值
        /// </summary>
        public double YesterdayNav { get; private set; }
        /// <summary>
        /// 当前资金余额
        /// </summary>
        public double CurrentBalance { get; private set; }
        /// <summary>
        /// 期初资金余额
        /// </summary>
        public double BeginBalance { get; private set; }
        /// <summary>
        /// 期货保证金账户余额
        /// </summary>
        public double FutuDepositBalance { get; private set; }
        /// <summary>
        /// 期货占用保证金
        /// </summary>
        public double OccupyDepositBalance { get; private set; }
        /// <summary>
        /// 期货资产(期货盈亏(在日终结算时,浮动盈亏要结转成资金))
        /// </summary>
        public double FutuAsset { get; private set; }
        /// <summary>
        /// 股票资产
        /// </summary>
        public double StockAsset { get; private set; }
        /// <summary>
        /// 债券资产
        /// </summary>
        public double BondAsset { get; private set; }
        /// <summary>
        /// 基金资产
        /// </summary>
        public double FundAsset { get; private set; }
        /// <summary>
        /// 期权资产
        /// </summary>
        public double OptionAsset { get; private set; }
        /// <summary>
        /// 回购资产
        /// </summary>
        public double RepoAsset { get; private set; }
        /// <summary>
        /// 其他资产
        /// </summary>
        public double OtherAsset { get; private set; }
        /// <summary>
        /// 基金总份额
        /// </summary>
        public double FundShare { get; private set; }
        /// <summary>
        /// 基金净资产
        /// </summary>
        public double FundNetAsset { get; private set; }
        /// <summary>
        /// 应付款
        /// </summary>
        public double PayableBalance { get; private set; }
        /// <summary>
        /// 应收款
        /// </summary>
        public double ReceivableBalance { get; private set; }
        public static Ufx35010Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx35010Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx35010Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx35010Result();
                    data.Add(item);
                    item.AccountCode = result.GetStr("account_code");
                    item.CurrencyCode = result.GetStr("currency_code");
                    item.TotalAsset = result.GetDouble("total_asset");
                    item.Nav = result.GetDouble("nav");
                    item.YesterdayNav = result.GetDouble("yesterday_nav");
                    item.CurrentBalance = result.GetDouble("current_balance");
                    item.BeginBalance = result.GetDouble("begin_balance");
                    item.FutuDepositBalance = result.GetDouble("futu_deposit_balance");
                    item.OccupyDepositBalance = result.GetDouble("occupy_deposit_balance");
                    item.FutuAsset = result.GetDouble("futu_asset");
                    item.StockAsset = result.GetDouble("stock_asset");
                    item.BondAsset = result.GetDouble("bond_asset");
                    item.FundAsset = result.GetDouble("fund_asset");
                    item.OptionAsset = result.GetDouble("option_asset");
                    item.RepoAsset = result.GetDouble("repo_asset");
                    item.OtherAsset = result.GetDouble("other_asset");
                    item.FundShare = result.GetDouble("fund_share");
                    item.FundNetAsset = result.GetDouble("fund_net_asset");
                    item.PayableBalance = result.GetDouble("payable_balance");
                    item.ReceivableBalance = result.GetDouble("receivable_balance");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 35011
    /// 功能名称: 支持查询资产单元资产信息
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35011Result 
    {
        /// <summary>
        /// 业务日期
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 币种(限定 <see cref="UfxCurrencyCode"/> 中定义的常量)
        /// </summary>
        public string CurrencyCode { get; private set; }
        /// <summary>
        /// 当前资金余额
        /// </summary>
        public double CurrentBalance { get; private set; }
        /// <summary>
        /// 期初资金余额
        /// </summary>
        public double BeginBalance { get; private set; }
        /// <summary>
        /// 期货保证金账户余额
        /// </summary>
        public double FutuDepositBalance { get; private set; }
        /// <summary>
        /// 期货资产(盯市赢亏)
        /// </summary>
        public double FutuAsset { get; private set; }
        /// <summary>
        /// 股票资产
        /// </summary>
        public double StockAsset { get; private set; }
        /// <summary>
        /// 债券资产
        /// </summary>
        public double BondAsset { get; private set; }
        /// <summary>
        /// 基金资产
        /// </summary>
        public double FundAsset { get; private set; }
        /// <summary>
        /// 回购资产
        /// </summary>
        public double RepoAsset { get; private set; }
        /// <summary>
        /// 期权资产
        /// </summary>
        public double OptionAsset { get; private set; }
        /// <summary>
        /// 其他资产
        /// </summary>
        public double OtherAsset { get; private set; }
        /// <summary>
        /// 应付款
        /// </summary>
        public double PayableBalance { get; private set; }
        /// <summary>
        /// 应收款
        /// </summary>
        public double ReceivableBalance { get; private set; }
        /// <summary>
        /// 期货盯市盈亏
        /// </summary>
        public double FutuTodayProfit { get; private set; }
        /// <summary>
        /// 期货浮动盈亏
        /// </summary>
        public double FutuFloatProfit { get; private set; }
        /// <summary>
        /// 期货平仓盈亏
        /// </summary>
        public double FutuCloseProfit { get; private set; }
        /// <summary>
        /// 期货买卖费用(只对期货有效)
        /// </summary>
        public double FutuFee { get; private set; }
        /// <summary>
        /// 现货累计实现盈亏(现货包含(股票,基金,债券,回购))
        /// </summary>
        public double SpotAccumulateProfit { get; private set; }
        public static Ufx35011Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx35011Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx35011Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx35011Result();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CurrencyCode = result.GetStr("currency_code");
                    item.CurrentBalance = result.GetDouble("current_balance");
                    item.BeginBalance = result.GetDouble("begin_balance");
                    item.FutuDepositBalance = result.GetDouble("futu_deposit_balance");
                    item.FutuAsset = result.GetDouble("futu_asset");
                    item.StockAsset = result.GetDouble("stock_asset");
                    item.BondAsset = result.GetDouble("bond_asset");
                    item.FundAsset = result.GetDouble("fund_asset");
                    item.RepoAsset = result.GetDouble("repo_asset");
                    item.OptionAsset = result.GetDouble("option_asset");
                    item.OtherAsset = result.GetDouble("other_asset");
                    item.PayableBalance = result.GetDouble("payable_balance");
                    item.ReceivableBalance = result.GetDouble("receivable_balance");
                    item.FutuTodayProfit = result.GetDouble("futu_today_profit");
                    item.FutuFloatProfit = result.GetDouble("futu_float_profit");
                    item.FutuCloseProfit = result.GetDouble("futu_close_profit");
                    item.FutuFee = result.GetDouble("futu_fee");
                    item.SpotAccumulateProfit = result.GetDouble("spot_accumulate_profit");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 35024
    /// 功能名称: 支持查询资产单元资产信息,查询结果为按照本币汇总后的数据
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35024Result 
    {
        /// <summary>
        /// 业务日期
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 币种(限定 <see cref="UfxCurrencyCode"/> 中定义的常量)
        /// </summary>
        public string CurrencyCode { get; private set; }
        /// <summary>
        /// 当前资金余额
        /// </summary>
        public double CurrentBalance { get; private set; }
        /// <summary>
        /// 期初资金余额
        /// </summary>
        public double BeginBalance { get; private set; }
        /// <summary>
        /// 总资产(资产单元总资产)
        /// </summary>
        public double TotalAsset { get; private set; }
        /// <summary>
        /// 净资产(资产单元净资产)
        /// </summary>
        public double NetAsset { get; private set; }
        /// <summary>
        /// 期货资产（合约价值）
        /// </summary>
        public double FutuAsset { get; private set; }
        /// <summary>
        /// 股票资产
        /// </summary>
        public double StockAsset { get; private set; }
        /// <summary>
        /// 债券资产
        /// </summary>
        public double BondAsset { get; private set; }
        /// <summary>
        /// 基金资产
        /// </summary>
        public double FundAsset { get; private set; }
        /// <summary>
        /// 回购资产
        /// </summary>
        public double RepoAsset { get; private set; }
        /// <summary>
        /// 期权资产
        /// </summary>
        public double OptionAsset { get; private set; }
        /// <summary>
        /// 其他资产
        /// </summary>
        public double OtherAsset { get; private set; }
        public static Ufx35024Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx35024Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx35024Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx35024Result();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CurrencyCode = result.GetStr("currency_code");
                    item.CurrentBalance = result.GetDouble("current_balance");
                    item.BeginBalance = result.GetDouble("begin_balance");
                    item.TotalAsset = result.GetDouble("total_asset");
                    item.NetAsset = result.GetDouble("net_asset");
                    item.FutuAsset = result.GetDouble("futu_asset");
                    item.StockAsset = result.GetDouble("stock_asset");
                    item.BondAsset = result.GetDouble("bond_asset");
                    item.FundAsset = result.GetDouble("fund_asset");
                    item.RepoAsset = result.GetDouble("repo_asset");
                    item.OptionAsset = result.GetDouble("option_asset");
                    item.OtherAsset = result.GetDouble("other_asset");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 35025
    /// 功能名称: 支持查询期货账户盈亏信息
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35025Result 
    {
        /// <summary>
        /// 业务日期
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 币种(限定 <see cref="UfxCurrencyCode"/> 中定义的常量)
        /// </summary>
        public string CurrencyCode { get; private set; }
        /// <summary>
        /// 期货保证金账户余额
        /// </summary>
        public double FutuDepositBalance { get; private set; }
        /// <summary>
        /// 期货占用保证金
        /// </summary>
        public double OccupyDepositBalance { get; private set; }
        /// <summary>
        /// 期货可用保证金
        /// </summary>
        public double EnableDepositBalance { get; private set; }
        /// <summary>
        /// 期货挂单占用保证金
        /// </summary>
        public double FutuTempOccupyDeposit { get; private set; }
        /// <summary>
        /// 期货盯市盈亏
        /// </summary>
        public double FutuTodayProfit { get; private set; }
        /// <summary>
        /// 期货浮动盈亏
        /// </summary>
        public double FutuFloatProfit { get; private set; }
        /// <summary>
        /// 期货平仓盈亏
        /// </summary>
        public double FutuCloseProfit { get; private set; }
        /// <summary>
        /// 期货买卖费用
        /// </summary>
        public double FutuFee { get; private set; }
        public static Ufx35025Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx35025Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx35025Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx35025Result();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CurrencyCode = result.GetStr("currency_code");
                    item.FutuDepositBalance = result.GetDouble("futu_deposit_balance");
                    item.OccupyDepositBalance = result.GetDouble("occupy_deposit_balance");
                    item.EnableDepositBalance = result.GetDouble("enable_deposit_balance");
                    item.FutuTempOccupyDeposit = result.GetDouble("futu_temp_occupy_deposit");
                    item.FutuTodayProfit = result.GetDouble("futu_today_profit");
                    item.FutuFloatProfit = result.GetDouble("futu_float_profit");
                    item.FutuCloseProfit = result.GetDouble("futu_close_profit");
                    item.FutuFee = result.GetDouble("futu_fee");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 35012
    /// 功能名称: 支持查询当日清算流水
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35012Result 
    {
        /// <summary>
        /// 业务日期
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 业务时间
        /// </summary>
        public int BusinessTime { get; private set; }
        /// <summary>
        /// 流水号
        /// </summary>
        public int SerialNo { get; private set; }
        /// <summary>
        /// 币种(限定 <see cref="UfxCurrencyCode"/> 中定义的常量)
        /// </summary>
        public string CurrencyCode { get; private set; }
        /// <summary>
        /// 业务类别编号
        /// </summary>
        public int BusinNo { get; private set; }
        /// <summary>
        /// 业务说明
        /// </summary>
        public string BusinCaption { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 多空标志(限定 <see cref="UfxPositionFlag"/> 中定义的常量)
        /// </summary>
        public sbyte PositionFlag { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;仅对期货期权有效.)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 发生价格
        /// </summary>
        public double BusinessPrice { get; private set; }
        /// <summary>
        /// 发生数量
        /// </summary>
        public int BusinessAmount { get; private set; }
        /// <summary>
        /// 发生金额
        /// </summary>
        public double BusinessBalance { get; private set; }
        /// <summary>
        /// 交易费
        /// </summary>
        public double TradeFee { get; private set; }
        /// <summary>
        /// 印花税
        /// </summary>
        public double StampTax { get; private set; }
        /// <summary>
        /// 过户费
        /// </summary>
        public double TransferFee { get; private set; }
        /// <summary>
        /// 佣金
        /// </summary>
        public double Commission { get; private set; }
        /// <summary>
        /// 经手费
        /// </summary>
        public double HandlingFee { get; private set; }
        /// <summary>
        /// 证管费
        /// </summary>
        public double AdminFee { get; private set; }
        /// <summary>
        /// 结算费
        /// </summary>
        public double ClearingFee { get; private set; }
        /// <summary>
        /// 交割费
        /// </summary>
        public double DeliveryFee { get; private set; }
        /// <summary>
        /// 结算风险金
        /// </summary>
        public double RiskFund { get; private set; }
        /// <summary>
        /// 其他费
        /// </summary>
        public double OtherFee { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 申报编号
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 成交编号
        /// </summary>
        public string DealNo { get; private set; }
        /// <summary>
        /// 成交时间
        /// </summary>
        public int DealTime { get; private set; }
        /// <summary>
        /// 清算速度(0表示T+0,1表示T+1,依此类推.)
        /// </summary>
        public int SettleSpeed { get; private set; }
        /// <summary>
        /// 资金变化方向('0'-不变化,'1'-增加,'2'-减少)
        /// </summary>
        public sbyte CapitalDirection { get; private set; }
        /// <summary>
        /// 证券变化方向('0'-不变化,'1'-增加,'2'-减少)
        /// </summary>
        public sbyte StockDirection { get; private set; }
        /// <summary>
        /// 平仓类型(1普通平仓;2强制平仓;3到期交割)
        /// </summary>
        public sbyte CloseType { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx35012Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx35012Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx35012Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx35012Result();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BusinessTime = result.GetInt("business_time");
                    item.SerialNo = result.GetInt("serial_no");
                    item.CurrencyCode = result.GetStr("currency_code");
                    item.BusinNo = result.GetInt("busin_no");
                    item.BusinCaption = result.GetStr("busin_caption");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.PositionFlag = result.GetChar("position_flag");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.BusinessPrice = result.GetDouble("business_price");
                    item.BusinessAmount = result.GetInt("business_amount");
                    item.BusinessBalance = result.GetDouble("business_balance");
                    item.TradeFee = result.GetDouble("trade_fee");
                    item.StampTax = result.GetDouble("stamp_tax");
                    item.TransferFee = result.GetDouble("transfer_fee");
                    item.Commission = result.GetDouble("commission");
                    item.HandlingFee = result.GetDouble("handling_fee");
                    item.AdminFee = result.GetDouble("admin_fee");
                    item.ClearingFee = result.GetDouble("clearing_fee");
                    item.DeliveryFee = result.GetDouble("delivery_fee");
                    item.RiskFund = result.GetDouble("risk_fund");
                    item.OtherFee = result.GetDouble("other_fee");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ReportNo = result.GetStr("report_no");
                    item.DealNo = result.GetStr("deal_no");
                    item.DealTime = result.GetInt("deal_time");
                    item.SettleSpeed = result.GetInt("settle_speed");
                    item.CapitalDirection = result.GetChar("capital_direction");
                    item.StockDirection = result.GetChar("stock_direction");
                    item.CloseType = result.GetChar("close_type");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 36012
    /// 功能名称: 支持查询历史清算流水,只能查询一天的历史记录
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx36012Result 
    {
        /// <summary>
        /// 业务日期
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 业务时间
        /// </summary>
        public int BusinessTime { get; private set; }
        /// <summary>
        /// 流水号
        /// </summary>
        public int SerialNo { get; private set; }
        /// <summary>
        /// 币种(限定 <see cref="UfxCurrencyCode"/> 中定义的常量)
        /// </summary>
        public string CurrencyCode { get; private set; }
        /// <summary>
        /// 业务类别编号
        /// </summary>
        public int BusinNo { get; private set; }
        /// <summary>
        /// 业务说明
        /// </summary>
        public string BusinCaption { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 多空标志(限定 <see cref="UfxPositionFlag"/> 中定义的常量)
        /// </summary>
        public sbyte PositionFlag { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;仅对期货期权有效.)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 发生价格
        /// </summary>
        public double BusinessPrice { get; private set; }
        /// <summary>
        /// 发生数量
        /// </summary>
        public int BusinessAmount { get; private set; }
        /// <summary>
        /// 发生金额
        /// </summary>
        public double BusinessBalance { get; private set; }
        /// <summary>
        /// 交易费
        /// </summary>
        public double TradeFee { get; private set; }
        /// <summary>
        /// 印花税
        /// </summary>
        public double StampTax { get; private set; }
        /// <summary>
        /// 过户费
        /// </summary>
        public double TransferFee { get; private set; }
        /// <summary>
        /// 佣金
        /// </summary>
        public double Commission { get; private set; }
        /// <summary>
        /// 经手费
        /// </summary>
        public double HandlingFee { get; private set; }
        /// <summary>
        /// 证管费
        /// </summary>
        public double AdminFee { get; private set; }
        /// <summary>
        /// 结算费
        /// </summary>
        public double ClearingFee { get; private set; }
        /// <summary>
        /// 交割费
        /// </summary>
        public double DeliveryFee { get; private set; }
        /// <summary>
        /// 结算风险金
        /// </summary>
        public double RiskFund { get; private set; }
        /// <summary>
        /// 其他费
        /// </summary>
        public double OtherFee { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 申报编号
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 成交编号
        /// </summary>
        public string DealNo { get; private set; }
        /// <summary>
        /// 成交时间
        /// </summary>
        public int DealTime { get; private set; }
        /// <summary>
        /// 清算速度(0表示T+0,1表示T+1,依此类推.)
        /// </summary>
        public int SettleSpeed { get; private set; }
        /// <summary>
        /// 资金变化方向('0'-不变化,'1'-增加,'2'-减少)
        /// </summary>
        public sbyte CapitalDirection { get; private set; }
        /// <summary>
        /// 证券变化方向('0'-不变化,'1'-增加,'2'-减少)
        /// </summary>
        public sbyte StockDirection { get; private set; }
        /// <summary>
        /// 平仓类型(1,普通平仓;2,强制平仓;3,到期交割)
        /// </summary>
        public sbyte CloseType { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx36012Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx36012Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx36012Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx36012Result();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BusinessTime = result.GetInt("business_time");
                    item.SerialNo = result.GetInt("serial_no");
                    item.CurrencyCode = result.GetStr("currency_code");
                    item.BusinNo = result.GetInt("busin_no");
                    item.BusinCaption = result.GetStr("busin_caption");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.PositionFlag = result.GetChar("position_flag");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.BusinessPrice = result.GetDouble("business_price");
                    item.BusinessAmount = result.GetInt("business_amount");
                    item.BusinessBalance = result.GetDouble("business_balance");
                    item.TradeFee = result.GetDouble("trade_fee");
                    item.StampTax = result.GetDouble("stamp_tax");
                    item.TransferFee = result.GetDouble("transfer_fee");
                    item.Commission = result.GetDouble("commission");
                    item.HandlingFee = result.GetDouble("handling_fee");
                    item.AdminFee = result.GetDouble("admin_fee");
                    item.ClearingFee = result.GetDouble("clearing_fee");
                    item.DeliveryFee = result.GetDouble("delivery_fee");
                    item.RiskFund = result.GetDouble("risk_fund");
                    item.OtherFee = result.GetDouble("other_fee");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ReportNo = result.GetStr("report_no");
                    item.DealNo = result.GetStr("deal_no");
                    item.DealTime = result.GetInt("deal_time");
                    item.SettleSpeed = result.GetInt("settle_speed");
                    item.CapitalDirection = result.GetChar("capital_direction");
                    item.StockDirection = result.GetChar("stock_direction");
                    item.CloseType = result.GetChar("close_type");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 35013
    /// 功能名称: 支持查询可期货保证金比例信息
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35013Result 
    {
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 空头保证金比例
        /// </summary>
        public double DepositRatio { get; private set; }
        /// <summary>
        /// 多头保证金比例
        /// </summary>
        public double LongDepositRatio { get; private set; }
        public static Ufx35013Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx35013Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx35013Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx35013Result();
                    data.Add(item);
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.DepositRatio = result.GetDouble("deposit_ratio");
                    item.LongDepositRatio = result.GetDouble("long_deposit_ratio");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 35015
    /// 功能名称: 支持资金调增\资金调减\保证金调增\保证金调减\资金投入\资金支取业务
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35015Result 
    {
        /// <summary>
        /// 调整结果(-1:失败,0:成功,1:需要复核)
        /// </summary>
        public sbyte AdjustResult { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx35015Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx35015Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx35015Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx35015Result();
                    data.Add(item);
                    item.AdjustResult = result.GetChar("adjust_result");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 35021
    /// 功能名称: 支持资金划转,支持批量传入,最大1000条.
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35021Result 
    {
        public static Ufx35021Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx35021Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx35021Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx35021Result();
                    data.Add(item);
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 35022
    /// 功能名称: 支持现货,期货划转,支持批量传入,最大1000条.不支持批量跨基金证券划转
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35022Result 
    {
        public static Ufx35022Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx35022Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx35022Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx35022Result();
                    data.Add(item);
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91001
    /// 功能名称: 支持沪深股票\基金买卖\债券买卖,新股申购\可转债申购\质押式回购\债转股\债回售\基金认购\配股认购\配债认购\债券认购业务.(不含固定收益和大宗交易).支持CDR存托凭证业务,支持沪伦通业务.
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91001Result 
    {
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 委托失败代码(限定 <see cref="UfxEntrustFailCode"/> 中定义的常量)
        /// </summary>
        public int EntrustFailCode { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        /// <summary>
        /// 风控判断流水号(用于关联风控信息包中的风控信息条目)
        /// </summary>
        public int RiskSerialNo { get; private set; }
        public static Ufx91001Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91001Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91001Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91001Result();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.EntrustFailCode = result.GetInt("entrust_fail_code");
                    item.FailCause = result.GetStr("fail_cause");
                    item.RiskSerialNo = result.GetInt("risk_serial_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91011
    /// 功能名称: 支持股转市场做市业务
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91011Result 
    {
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号(如委托失败,则返回0)
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 委托失败代码(限定 <see cref="UfxEntrustFailCode"/> 中定义的常量)
        /// </summary>
        public int EntrustFailCode { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        /// <summary>
        /// 风控判断流水号(用于关联风控信息包中的风控信息条目)
        /// </summary>
        public int RiskSerialNo { get; private set; }
        public static Ufx91011Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91011Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91011Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91011Result();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.EntrustFailCode = result.GetInt("entrust_fail_code");
                    item.FailCause = result.GetStr("fail_cause");
                    item.RiskSerialNo = result.GetInt("risk_serial_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91115
    /// 功能名称: 支持按委托序号撤销股转做市委托.
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91115Result 
    {
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91115Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91115Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91115Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91115Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91113
    /// 功能名称: 支持按委托序号撤销股转做市委托.
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91113Result 
    {
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91113Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91113Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91113Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91113Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91090
    /// 功能名称: 支持沪深股票\基金\债券买卖和股指期货\国债期货\商品期货\股票期权业务.支持CDR存托凭证业务,支持沪伦通业务
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91090Result 
    {
        /// <summary>
        /// 委托批号(如委托失败,则返回0)
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号(如委托失败,则返回0)
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 请求次序(输入参数批量时有效,请求次序按输入参数进行排序,从1开始)
        /// </summary>
        public string RequestOrder { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 委托失败代码(限定 <see cref="UfxEntrustFailCode"/> 中定义的常量)
        /// </summary>
        public int EntrustFailCode { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        /// <summary>
        /// 风控判断流水号(用于关联风控信息包中的风控信息条目)
        /// </summary>
        public int RiskSerialNo { get; private set; }
        public static Ufx91090Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91090Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91090Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91090Result();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.RequestOrder = result.GetStr("request_order");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.EntrustFailCode = result.GetInt("entrust_fail_code");
                    item.FailCause = result.GetStr("fail_cause");
                    item.RiskSerialNo = result.GetInt("risk_serial_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91114
    /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91114Result 
    {
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91114Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91114Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91114Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91114Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91101
    /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91101Result 
    {
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91101Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91101Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91101Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91101Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91102
    /// 功能名称: 支持按委托批号撤单,支持对证券\期货\期权\策略等业务按委托批号撤单
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91102Result 
    {
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91102Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91102Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91102Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91102Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 31001
    /// 功能名称: 支持查询沪深及股转市场的股票\基金\债券的持仓信息
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx31001Result 
    {
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 持仓席位
        /// </summary>
        public string HoldSeat { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 当前数量
        /// </summary>
        public int CurrentAmount { get; private set; }
        /// <summary>
        /// 可用数量
        /// </summary>
        public int EnableAmount { get; private set; }
        /// <summary>
        /// 期初数量
        /// </summary>
        public int BeginAmount { get; private set; }
        /// <summary>
        /// 可赎回数量(仅对ETF有效)
        /// </summary>
        public int RedeemableAmount { get; private set; }
        /// <summary>
        /// 期初成本
        /// </summary>
        public double BeginCost { get; private set; }
        /// <summary>
        /// 当前成本
        /// </summary>
        public double CurrentCost { get; private set; }
        /// <summary>
        /// 买挂单数量
        /// </summary>
        public int PreBuyAmount { get; private set; }
        /// <summary>
        /// 卖挂单数量
        /// </summary>
        public int PreSellAmount { get; private set; }
        /// <summary>
        /// 买挂单金额
        /// </summary>
        public double PreBuyBalance { get; private set; }
        /// <summary>
        /// 卖挂单金额
        /// </summary>
        public double PreSellBalance { get; private set; }
        /// <summary>
        /// 当日买入数量
        /// </summary>
        public int TodayBuyAmount { get; private set; }
        /// <summary>
        /// 当日卖出数量
        /// </summary>
        public int TodaySellAmount { get; private set; }
        /// <summary>
        /// 当日买入金额
        /// </summary>
        public double TodayBuyBalance { get; private set; }
        /// <summary>
        /// 当日卖出金额
        /// </summary>
        public double TodaySellBalance { get; private set; }
        /// <summary>
        /// 当日买费用
        /// </summary>
        public double TodayBuyFee { get; private set; }
        /// <summary>
        /// 当日卖费用
        /// </summary>
        public double TodaySellFee { get; private set; }
        public static Ufx31001Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx31001Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx31001Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx31001Result();
                    data.Add(item);
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.HoldSeat = result.GetStr("hold_seat");
                    item.InvestType = result.GetChar("invest_type");
                    item.CurrentAmount = result.GetInt("current_amount");
                    item.EnableAmount = result.GetInt("enable_amount");
                    item.BeginAmount = result.GetInt("begin_amount");
                    item.RedeemableAmount = result.GetInt("redeemable_amount");
                    item.BeginCost = result.GetDouble("begin_cost");
                    item.CurrentCost = result.GetDouble("current_cost");
                    item.PreBuyAmount = result.GetInt("pre_buy_amount");
                    item.PreSellAmount = result.GetInt("pre_sell_amount");
                    item.PreBuyBalance = result.GetDouble("pre_buy_balance");
                    item.PreSellBalance = result.GetDouble("pre_sell_balance");
                    item.TodayBuyAmount = result.GetInt("today_buy_amount");
                    item.TodaySellAmount = result.GetInt("today_sell_amount");
                    item.TodayBuyBalance = result.GetDouble("today_buy_balance");
                    item.TodaySellBalance = result.GetDouble("today_sell_balance");
                    item.TodayBuyFee = result.GetDouble("today_buy_fee");
                    item.TodaySellFee = result.GetDouble("today_sell_fee");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 31002
    /// 功能名称: 支持查询提交\转回质押的质押券数量明细(OPLUS专用)
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx31002Result 
    {
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 期初质押数量
        /// </summary>
        public int BeginImpawnAmount { get; private set; }
        /// <summary>
        /// 当日质押数量
        /// </summary>
        public int ImpawnAmount { get; private set; }
        /// <summary>
        /// 当日转回数量
        /// </summary>
        public int ReturnAmount { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx31002Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx31002Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx31002Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx31002Result();
                    data.Add(item);
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.BeginImpawnAmount = result.GetInt("begin_impawn_amount");
                    item.ImpawnAmount = result.GetInt("impawn_amount");
                    item.ReturnAmount = result.GetInt("return_amount");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 30011
    /// 功能名称: 支持查询现货,期货,期权的证券资料信息.
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx30011Result 
    {
        /// <summary>
        /// 业务日期
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 网上上市日期
        /// </summary>
        public int ListingDate { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券名称
        /// </summary>
        public string StockName { get; private set; }
        /// <summary>
        /// 证券类型(限定 <see cref="UfxStockType"/> 中定义的常量)
        /// </summary>
        public string StockType { get; private set; }
        /// <summary>
        /// 总股本
        /// </summary>
        public double TotalShare { get; private set; }
        /// <summary>
        /// 流通股本
        /// </summary>
        public double CirculateAmount { get; private set; }
        /// <summary>
        /// 涨停板价格
        /// </summary>
        public double UplimitedPrice { get; private set; }
        /// <summary>
        /// 跌停板价格
        /// </summary>
        public double DownlimitedPrice { get; private set; }
        /// <summary>
        /// 最小买单位
        /// </summary>
        public double BuyUnit { get; private set; }
        /// <summary>
        /// 最小卖单位
        /// </summary>
        public double SaleUnit { get; private set; }
        /// <summary>
        /// 昨收盘价
        /// </summary>
        public double YesterdayClosePrice { get; private set; }
        /// <summary>
        /// 停牌标志(1:停牌;2:正常交易)
        /// </summary>
        public sbyte StopFlag { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx30011Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx30011Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx30011Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx30011Result();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.ListingDate = result.GetInt("listing_date");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockName = result.GetStr("stock_name");
                    item.StockType = result.GetStr("stock_type");
                    item.TotalShare = result.GetDouble("total_share");
                    item.CirculateAmount = result.GetDouble("circulate_amount");
                    item.UplimitedPrice = result.GetDouble("uplimited_price");
                    item.DownlimitedPrice = result.GetDouble("downlimited_price");
                    item.BuyUnit = result.GetDouble("buy_unit");
                    item.SaleUnit = result.GetDouble("sale_unit");
                    item.YesterdayClosePrice = result.GetDouble("yesterday_close_price");
                    item.StopFlag = result.GetChar("stop_flag");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 32001
    /// 功能名称: 支持查询当日普通买卖委托流水,包含沪深股票\基金买卖\债券买卖,新股申购\可转债申购\质押式回购\债转股\债回售\基金认购\配股认购\配债认购\债券认购\股转市场业务
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx32001Result 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int EntrustDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int EntrustTime { get; private set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OperatorNo { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号()
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报号,用于日终时关联清算流水.)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType { get; private set; }
        /// <summary>
        /// 委托价格
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 预买冻结金额(有持仓增加(现货买入或期货期权开仓)的挂单时需要冻结的资金.)
        /// </summary>
        public double PreBuyFrozenBalance { get; private set; }
        /// <summary>
        /// 预卖金额(有资金增加(现货卖出或期货期权平仓)的挂单时预期会增加的资金.)
        /// </summary>
        public double PreSellBalance { get; private set; }
        /// <summary>
        /// 委托确认号
        /// </summary>
        public string ConfirmNo { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 首次成交时间(HHMMSS格式)
        /// </summary>
        public int FirstDealTime { get; private set; }
        /// <summary>
        /// 成交数量(累计成交数量)
        /// </summary>
        public int DealAmount { get; private set; }
        /// <summary>
        /// 成交金额(累计成交金额)
        /// </summary>
        public double DealBalance { get; private set; }
        /// <summary>
        /// 成交均价(成交的平均价格)
        /// </summary>
        public double DealPrice { get; private set; }
        /// <summary>
        /// 分笔成交次数(一笔委托可能分多次成交,该字段表示成交次数.)
        /// </summary>
        public int DealTimes { get; private set; }
        /// <summary>
        /// 撤单数量
        /// </summary>
        public int WithdrawAmount { get; private set; }
        /// <summary>
        /// 撤单原因
        /// </summary>
        public string WithdrawCause { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        /// <summary>
        /// 交易所申报编号(直连时为申报编号,分仓时为分仓申报编号)
        /// </summary>
        public string ExchangeReportNo { get; private set; }
        public static Ufx32001Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx32001Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx32001Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx32001Result();
                    data.Add(item);
                    item.EntrustDate = result.GetInt("entrust_date");
                    item.EntrustTime = result.GetInt("entrust_time");
                    item.OperatorNo = result.GetStr("operator_no");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ReportNo = result.GetStr("report_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.PriceType = result.GetChar("price_type");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.PreBuyFrozenBalance = result.GetDouble("pre_buy_frozen_balance");
                    item.PreSellBalance = result.GetDouble("pre_sell_balance");
                    item.ConfirmNo = result.GetStr("confirm_no");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.FirstDealTime = result.GetInt("first_deal_time");
                    item.DealAmount = result.GetInt("deal_amount");
                    item.DealBalance = result.GetDouble("deal_balance");
                    item.DealPrice = result.GetDouble("deal_price");
                    item.DealTimes = result.GetInt("deal_times");
                    item.WithdrawAmount = result.GetInt("withdraw_amount");
                    item.WithdrawCause = result.GetStr("withdraw_cause");
                    item.PositionStr = result.GetStr("position_str");
                    item.ExchangeReportNo = result.GetStr("exchange_report_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 32101
    /// 功能名称: 支持查询历史普通买卖委托流水
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx32101Result 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int EntrustDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int EntrustTime { get; private set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OperatorNo { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号()
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报号,用于日终时关联清算流水.)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType { get; private set; }
        /// <summary>
        /// 委托价格
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 委托确认号
        /// </summary>
        public string ConfirmNo { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 首次成交时间(HHMMSS格式)
        /// </summary>
        public int FirstDealTime { get; private set; }
        /// <summary>
        /// 成交数量(累计成交数量)
        /// </summary>
        public int DealAmount { get; private set; }
        /// <summary>
        /// 成交金额(累计成交金额)
        /// </summary>
        public double DealBalance { get; private set; }
        /// <summary>
        /// 成交均价(成交的平均价格)
        /// </summary>
        public double DealPrice { get; private set; }
        /// <summary>
        /// 分笔成交次数(一笔委托可能分多次成交,该字段表示成交次数.)
        /// </summary>
        public int DealTimes { get; private set; }
        /// <summary>
        /// 撤单数量
        /// </summary>
        public int WithdrawAmount { get; private set; }
        /// <summary>
        /// 撤单原因
        /// </summary>
        public string WithdrawCause { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx32101Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx32101Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx32101Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx32101Result();
                    data.Add(item);
                    item.EntrustDate = result.GetInt("entrust_date");
                    item.EntrustTime = result.GetInt("entrust_time");
                    item.OperatorNo = result.GetStr("operator_no");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ReportNo = result.GetStr("report_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.PriceType = result.GetChar("price_type");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.ConfirmNo = result.GetStr("confirm_no");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.FirstDealTime = result.GetInt("first_deal_time");
                    item.DealAmount = result.GetInt("deal_amount");
                    item.DealBalance = result.GetDouble("deal_balance");
                    item.DealPrice = result.GetDouble("deal_price");
                    item.DealTimes = result.GetInt("deal_times");
                    item.WithdrawAmount = result.GetInt("withdraw_amount");
                    item.WithdrawCause = result.GetStr("withdraw_cause");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 32006
    /// 功能名称: 支持查询当日股转做市委托
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx32006Result 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int EntrustDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int EntrustTime { get; private set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OperatorNo { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 买入价格
        /// </summary>
        public double BuyPrice { get; private set; }
        /// <summary>
        /// 买入数量
        /// </summary>
        public int BuyAmount { get; private set; }
        /// <summary>
        /// 卖出价格
        /// </summary>
        public double SellPrice { get; private set; }
        /// <summary>
        /// 卖出数量
        /// </summary>
        public int SellAmount { get; private set; }
        /// <summary>
        /// 委托确认号
        /// </summary>
        public string ConfirmNo { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 买入成交数量
        /// </summary>
        public int BuyDealAmount { get; private set; }
        /// <summary>
        /// 买入成交金额
        /// </summary>
        public double BuyDealBalance { get; private set; }
        /// <summary>
        /// 卖出成交数量
        /// </summary>
        public int SellDealAmount { get; private set; }
        /// <summary>
        /// 卖出成交金额
        /// </summary>
        public double SellDealBalance { get; private set; }
        /// <summary>
        /// 买入方向撤单数量
        /// </summary>
        public int BuyCancelAmount { get; private set; }
        /// <summary>
        /// 卖出方向撤单数量
        /// </summary>
        public int SellCancelAmount { get; private set; }
        /// <summary>
        /// 撤单原因
        /// </summary>
        public string WithdrawCause { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx32006Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx32006Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx32006Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx32006Result();
                    data.Add(item);
                    item.EntrustDate = result.GetInt("entrust_date");
                    item.EntrustTime = result.GetInt("entrust_time");
                    item.OperatorNo = result.GetStr("operator_no");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.BuyPrice = result.GetDouble("buy_price");
                    item.BuyAmount = result.GetInt("buy_amount");
                    item.SellPrice = result.GetDouble("sell_price");
                    item.SellAmount = result.GetInt("sell_amount");
                    item.ConfirmNo = result.GetStr("confirm_no");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.BuyDealAmount = result.GetInt("buy_deal_amount");
                    item.BuyDealBalance = result.GetDouble("buy_deal_balance");
                    item.SellDealAmount = result.GetInt("sell_deal_amount");
                    item.SellDealBalance = result.GetDouble("sell_deal_balance");
                    item.BuyCancelAmount = result.GetInt("buy_cancel_amount");
                    item.SellCancelAmount = result.GetInt("sell_cancel_amount");
                    item.WithdrawCause = result.GetStr("withdraw_cause");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 33001
    /// 功能名称: 支持查询当日普通买卖委托以及当日股转做市委托对应的成交流水
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx33001Result 
    {
        /// <summary>
        /// 成交日期(YYYYMMDD格式)
        /// </summary>
        public int DealDate { get; private set; }
        /// <summary>
        /// 成交编号
        /// </summary>
        public string DealNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 交易实例编号
        /// </summary>
        public string InstanceNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 成交数量
        /// </summary>
        public int DealAmount { get; private set; }
        /// <summary>
        /// 成交价格
        /// </summary>
        public double DealPrice { get; private set; }
        /// <summary>
        /// 成交金额
        /// </summary>
        public double DealBalance { get; private set; }
        /// <summary>
        /// 总费用
        /// </summary>
        public double TotalFee { get; private set; }
        /// <summary>
        /// 成交时间(HHMMSS格式)
        /// </summary>
        public int DealTime { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx33001Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx33001Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx33001Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx33001Result();
                    data.Add(item);
                    item.DealDate = result.GetInt("deal_date");
                    item.DealNo = result.GetStr("deal_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.InstanceNo = result.GetStr("instance_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.DealAmount = result.GetInt("deal_amount");
                    item.DealPrice = result.GetDouble("deal_price");
                    item.DealBalance = result.GetDouble("deal_balance");
                    item.TotalFee = result.GetDouble("total_fee");
                    item.DealTime = result.GetInt("deal_time");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 33101
    /// 功能名称: 支持查询历史普通买卖成交流水
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx33101Result 
    {
        /// <summary>
        /// 成交日期(YYYYMMDD格式)
        /// </summary>
        public int DealDate { get; private set; }
        /// <summary>
        /// 成交编号
        /// </summary>
        public string DealNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 成交数量(累计成交数量)
        /// </summary>
        public int DealAmount { get; private set; }
        /// <summary>
        /// 成交价格
        /// </summary>
        public double DealPrice { get; private set; }
        /// <summary>
        /// 成交金额(累计成交金额)
        /// </summary>
        public double DealBalance { get; private set; }
        /// <summary>
        /// 总费用
        /// </summary>
        public double TotalFee { get; private set; }
        /// <summary>
        /// 成交时间(HHMMSS格式)
        /// </summary>
        public int DealTime { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx33101Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx33101Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx33101Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx33101Result();
                    data.Add(item);
                    item.DealDate = result.GetInt("deal_date");
                    item.DealNo = result.GetStr("deal_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.DealAmount = result.GetInt("deal_amount");
                    item.DealPrice = result.GetDouble("deal_price");
                    item.DealBalance = result.GetDouble("deal_balance");
                    item.TotalFee = result.GetDouble("total_fee");
                    item.DealTime = result.GetInt("deal_time");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 34001
    /// 功能名称: 支持查询沪深A股及股转市场资金账户的资金可用,支持批量传入.
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx34001Result 
    {
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// T+0可用资金(交易所T+0业务(如债券买入)可用资金)
        /// </summary>
        public double EnableBalanceT0 { get; private set; }
        /// <summary>
        /// T+1可用资金(交易所T+1业务(如股票买入)可用资金)
        /// </summary>
        public double EnableBalanceT1 { get; private set; }
        /// <summary>
        /// 当前资金余额(该余额不包含期货保证金)
        /// </summary>
        public double CurrentBalance { get; private set; }
        public static Ufx34001Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx34001Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx34001Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx34001Result();
                    data.Add(item);
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.EnableBalanceT0 = result.GetDouble("enable_balance_t0");
                    item.EnableBalanceT1 = result.GetDouble("enable_balance_t1");
                    item.CurrentBalance = result.GetDouble("current_balance");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91051
    /// 功能名称: 支持股转市场协议转让交易业务.
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91051Result 
    {
        /// <summary>
        /// 委托批号(如委托失败,则返回0)
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号(如委托失败,则返回0)
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 委托失败代码(限定 <see cref="UfxEntrustFailCode"/> 中定义的常量)
        /// </summary>
        public int EntrustFailCode { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        /// <summary>
        /// 风控判断流水号(用于关联风控信息包中的风控信息条目)
        /// </summary>
        public int RiskSerialNo { get; private set; }
        public static Ufx91051Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91051Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91051Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91051Result();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.EntrustFailCode = result.GetInt("entrust_fail_code");
                    item.FailCause = result.GetStr("fail_cause");
                    item.RiskSerialNo = result.GetInt("risk_serial_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91116
    /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91116Result 
    {
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91116Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91116Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91116Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91116Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91151
    /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
    /// 业务范围: 证券
    /// </summary>
    public sealed class Ufx91151Result 
    {
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91151Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91151Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91151Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91151Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91003
    /// 功能名称: 支持沪深ETF\沪深跨市场ETF\沪深跨境ETF申赎业务
    /// 业务范围: 基金
    /// </summary>
    public sealed class Ufx91003Result 
    {
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        public static Ufx91003Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91003Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91003Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91003Result();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91008
    /// 功能名称: 支持ETF(股票型ETF\债券型ETF\华宝兴业交易型货币基金\沪深跨境ETF\沪深黄金ETF\深交所交易型货币基金)\场内开放式基金申赎(LOF)\LOF基金分拆合并\转托管.基金买卖委托请用91001接口
    /// 业务范围: 基金
    /// </summary>
    public sealed class Ufx91008Result 
    {
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 委托失败代码(限定 <see cref="UfxEntrustFailCode"/> 中定义的常量)
        /// </summary>
        public int EntrustFailCode { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        /// <summary>
        /// 风控判断流水号(用于关联风控信息包中的风控信息条目)
        /// </summary>
        public int RiskSerialNo { get; private set; }
        public static Ufx91008Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91008Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91008Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91008Result();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.EntrustFailCode = result.GetInt("entrust_fail_code");
                    item.FailCause = result.GetStr("fail_cause");
                    item.RiskSerialNo = result.GetInt("risk_serial_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 32002
    /// 功能名称: 支持查询当日基金一级市场委托流水.
    /// 业务范围: 基金
    /// </summary>
    public sealed class Ufx32002Result 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int EntrustDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int EntrustTime { get; private set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OperatorNo { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号()
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报号,用于日终时关联清算流水.)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType { get; private set; }
        /// <summary>
        /// 委托价格(转托管时该字段表示对方机构代码)
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 委托金额
        /// </summary>
        public double EntrustBalance { get; private set; }
        /// <summary>
        /// 申赎方式(限定 <see cref="UfxPurchaseWay"/> 中定义的常量)
        /// </summary>
        public sbyte PurchaseWay { get; private set; }
        /// <summary>
        /// 预买冻结金额(有持仓增加(现货买入或期货期权开仓)的挂单时需要冻结的资金.)
        /// </summary>
        public double PreBuyFrozenBalance { get; private set; }
        /// <summary>
        /// 预卖金额(有资金增加(现货卖出或期货期权平仓)的挂单时预期会增加的资金.)
        /// </summary>
        public double PreSellBalance { get; private set; }
        /// <summary>
        /// 委托确认号
        /// </summary>
        public string ConfirmNo { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 首次成交时间(HHMMSS格式)
        /// </summary>
        public int FirstDealTime { get; private set; }
        /// <summary>
        /// 成交数量(累计成交数量)
        /// </summary>
        public int DealAmount { get; private set; }
        /// <summary>
        /// 成交金额(累计成交金额)
        /// </summary>
        public double DealBalance { get; private set; }
        /// <summary>
        /// 成交均价(成交的平均价格)
        /// </summary>
        public double DealPrice { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        /// <summary>
        /// 交易所申报编号(直连时为申报编号,分仓时为分仓申报编号)
        /// </summary>
        public string ExchangeReportNo { get; private set; }
        public static Ufx32002Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx32002Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx32002Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx32002Result();
                    data.Add(item);
                    item.EntrustDate = result.GetInt("entrust_date");
                    item.EntrustTime = result.GetInt("entrust_time");
                    item.OperatorNo = result.GetStr("operator_no");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ReportNo = result.GetStr("report_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.PriceType = result.GetChar("price_type");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.EntrustBalance = result.GetDouble("entrust_balance");
                    item.PurchaseWay = result.GetChar("purchase_way");
                    item.PreBuyFrozenBalance = result.GetDouble("pre_buy_frozen_balance");
                    item.PreSellBalance = result.GetDouble("pre_sell_balance");
                    item.ConfirmNo = result.GetStr("confirm_no");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.FirstDealTime = result.GetInt("first_deal_time");
                    item.DealAmount = result.GetInt("deal_amount");
                    item.DealBalance = result.GetDouble("deal_balance");
                    item.DealPrice = result.GetDouble("deal_price");
                    item.PositionStr = result.GetStr("position_str");
                    item.ExchangeReportNo = result.GetStr("exchange_report_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 32005
    /// 功能名称: 支持查询ETF申赎时的成份股和资金代码委托明细信息.
    /// 业务范围: 基金
    /// </summary>
    public sealed class Ufx32005Result 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int EntrustDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int EntrustTime { get; private set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OperatorNo { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号(编号查询)
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// ETF委托序号(明细委托号)
        /// </summary>
        public int DetailEntrustNo { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报号,用于日终时关联清算流水.)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 委托价格
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        public static Ufx32005Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx32005Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx32005Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx32005Result();
                    data.Add(item);
                    item.EntrustDate = result.GetInt("entrust_date");
                    item.EntrustTime = result.GetInt("entrust_time");
                    item.OperatorNo = result.GetStr("operator_no");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.DetailEntrustNo = result.GetInt("detail_entrust_no");
                    item.ReportNo = result.GetStr("report_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.EntrustState = result.GetChar("entrust_state");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 33002
    /// 功能名称: 支持查询当日基金一级市场委托成交流水
    /// 业务范围: 基金
    /// </summary>
    public sealed class Ufx33002Result 
    {
        /// <summary>
        /// 成交日期(YYYYMMDD格式)
        /// </summary>
        public int DealDate { get; private set; }
        /// <summary>
        /// 成交编号
        /// </summary>
        public string DealNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 成交数量
        /// </summary>
        public int DealAmount { get; private set; }
        /// <summary>
        /// 成交价格
        /// </summary>
        public double DealPrice { get; private set; }
        /// <summary>
        /// 成交金额
        /// </summary>
        public double DealBalance { get; private set; }
        /// <summary>
        /// 总费用
        /// </summary>
        public double TotalFee { get; private set; }
        /// <summary>
        /// 成交时间(HHMMSS格式)
        /// </summary>
        public int DealTime { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx33002Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx33002Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx33002Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx33002Result();
                    data.Add(item);
                    item.DealDate = result.GetInt("deal_date");
                    item.DealNo = result.GetStr("deal_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.DealAmount = result.GetInt("deal_amount");
                    item.DealPrice = result.GetDouble("deal_price");
                    item.DealBalance = result.GetDouble("deal_balance");
                    item.TotalFee = result.GetDouble("total_fee");
                    item.DealTime = result.GetInt("deal_time");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 33005
    /// 功能名称: 支持查询ETF申赎时的成份股和资金代码成交明细信息.
    /// 业务范围: 基金
    /// </summary>
    public sealed class Ufx33005Result 
    {
        /// <summary>
        /// 成交日期(YYYYMMDD格式)
        /// </summary>
        public int DealDate { get; private set; }
        /// <summary>
        /// 成交时间(HHMMSS格式)
        /// </summary>
        public int DealTime { get; private set; }
        /// <summary>
        /// 成交编号
        /// </summary>
        public string DealNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报号,用于日终时关联清算流水.)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 成交数量
        /// </summary>
        public int DealAmount { get; private set; }
        /// <summary>
        /// 成交价格
        /// </summary>
        public double DealPrice { get; private set; }
        /// <summary>
        /// 成交金额
        /// </summary>
        public double DealBalance { get; private set; }
        /// <summary>
        /// 总费用
        /// </summary>
        public double TotalFee { get; private set; }
        /// <summary>
        /// 申报方向(KB:实物成份股买;;KS:实物成份股卖;;ZB:现金替代买;;ZS:现金替代卖;;其他值无效)
        /// </summary>
        public string ReportDirection { get; private set; }
        public static Ufx33005Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx33005Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx33005Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx33005Result();
                    data.Add(item);
                    item.DealDate = result.GetInt("deal_date");
                    item.DealTime = result.GetInt("deal_time");
                    item.DealNo = result.GetStr("deal_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ReportNo = result.GetStr("report_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.DealAmount = result.GetInt("deal_amount");
                    item.DealPrice = result.GetDouble("deal_price");
                    item.DealBalance = result.GetDouble("deal_balance");
                    item.TotalFee = result.GetDouble("total_fee");
                    item.ReportDirection = result.GetStr("report_direction");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 35014
    /// 功能名称: 支持查询沪深ETF成份股信息
    /// 业务范围: 基金
    /// </summary>
    public sealed class Ufx35014Result 
    {
        /// <summary>
        /// 业务日期
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券数量
        /// </summary>
        public int StockAmount { get; private set; }
        /// <summary>
        /// 现金替代标志(限定 <see cref="UfxReplaceFlag"/> 中定义的常量)
        /// </summary>
        public sbyte ReplaceFlag { get; private set; }
        /// <summary>
        /// 溢价比率(小数显示,比如10%显示为0.1)
        /// </summary>
        public double ReplaceRatio { get; private set; }
        /// <summary>
        /// 替代金额(对于深圳跨市场ETF,表示申购替代金额.)
        /// </summary>
        public double ReplaceBalance { get; private set; }
        /// <summary>
        /// 赎回替代金额(该字段仅对深圳跨市场ETF有效,对于单市场ETF,等同于替代金额字段.)
        /// </summary>
        public double RedeemReplaceBalance { get; private set; }
        public static Ufx35014Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx35014Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx35014Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx35014Result();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockAmount = result.GetInt("stock_amount");
                    item.ReplaceFlag = result.GetChar("replace_flag");
                    item.ReplaceRatio = result.GetDouble("replace_ratio");
                    item.ReplaceBalance = result.GetDouble("replace_balance");
                    item.RedeemReplaceBalance = result.GetDouble("redeem_replace_balance");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 35020
    /// 功能名称: 支持沪深查询ETF基础信息
    /// 业务范围: 基金
    /// </summary>
    public sealed class Ufx35020Result 
    {
        /// <summary>
        /// 业务日期
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// ETF代码（二级市场）
        /// </summary>
        public string EtfCode { get; private set; }
        /// <summary>
        /// 证券名称
        /// </summary>
        public string StockName { get; private set; }
        /// <summary>
        /// 证券代码(一级市场代码)
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 成分股数量
        /// </summary>
        public int StockNum { get; private set; }
        /// <summary>
        /// 当天状态(0:不允许进行申购和赎回,1:允许申购和赎回,2:允许申购不允许赎回,3:不允许申购允许赎回)
        /// </summary>
        public sbyte CreationRedeemType { get; private set; }
        /// <summary>
        /// ETF市场类型(1本市场ETF;2跨境ETF;3跨市场ETF(交易所);4跨市场ETF(中登,交易所))
        /// </summary>
        public sbyte EtfMarketType { get; private set; }
        /// <summary>
        /// 对方市场(跨市场ETF\跨境ETF,该字段表示跟踪标的所在市场,本市场ETF填空)
        /// </summary>
        public string RivalMarket { get; private set; }
        /// <summary>
        /// ETF分类(1股票ETF;2债券ETF;3交易型货币基金;4黄金ETF;5货币市场基金)
        /// </summary>
        public sbyte EtfType { get; private set; }
        /// <summary>
        /// 现金替代比例上限(小数显示,比如10%显示为0.1)
        /// </summary>
        public double MaxCashRatio { get; private set; }
        /// <summary>
        /// 申报单位(ETF最小申赎单位对应份数)
        /// </summary>
        public double ReportUnit { get; private set; }
        /// <summary>
        /// T－1日申购赎回基准单位的现金余额
        /// </summary>
        public double YesterdayCash { get; private set; }
        /// <summary>
        /// 昨日单位净值(T－1日单位净值)
        /// </summary>
        public double YesterdayNav { get; private set; }
        /// <summary>
        /// 预估现金差额
        /// </summary>
        public double EstimateCash { get; private set; }
        /// <summary>
        /// 拟合指数代码
        /// </summary>
        public string UnderlyingIndex { get; private set; }
        public static Ufx35020Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx35020Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx35020Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx35020Result();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.MarketNo = result.GetStr("market_no");
                    item.EtfCode = result.GetStr("etf_code");
                    item.StockName = result.GetStr("stock_name");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockNum = result.GetInt("stock_num");
                    item.CreationRedeemType = result.GetChar("creation_redeem_type");
                    item.EtfMarketType = result.GetChar("etf_market_type");
                    item.RivalMarket = result.GetStr("rival_market");
                    item.EtfType = result.GetChar("etf_type");
                    item.MaxCashRatio = result.GetDouble("max_cash_ratio");
                    item.ReportUnit = result.GetDouble("report_unit");
                    item.YesterdayCash = result.GetDouble("yesterday_cash");
                    item.YesterdayNav = result.GetDouble("yesterday_nav");
                    item.EstimateCash = result.GetDouble("estimate_cash");
                    item.UnderlyingIndex = result.GetStr("underlying_index");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 30010
    /// 功能名称: 支持查询期货市场未过期的期货信息.
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx30010Result 
    {
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券名称
        /// </summary>
        public string StockName { get; private set; }
        /// <summary>
        /// 期货品种名 (期货品种名,如:豆粕\五年期国债期货)
        /// </summary>
        public string FutureKindName { get; private set; }
        /// <summary>
        /// 合约月份(YYYYMM格式,如201407.)
        /// </summary>
        public int SettlementMonth { get; private set; }
        /// <summary>
        /// 标的物市场(限定 <see cref="UfxTargetMarketNo"/> 中定义的常量)
        /// </summary>
        public string TargetMarketNo { get; private set; }
        /// <summary>
        /// 标的物代码
        /// </summary>
        public string TargetStockCode { get; private set; }
        /// <summary>
        /// 合约乘数
        /// </summary>
        public int Multiple { get; private set; }
        /// <summary>
        /// 最后交易日
        /// </summary>
        public int LastTradeDate { get; private set; }
        /// <summary>
        /// 最后交易时间
        /// </summary>
        public int LastTradeTime { get; private set; }
        /// <summary>
        /// 交割日
        /// </summary>
        public int SettlementDate { get; private set; }
        /// <summary>
        /// 结算价(日间结算价为0,只有日终清算后才有准确的值.)
        /// </summary>
        public double SettlementPrice { get; private set; }
        /// <summary>
        /// 前结算价
        /// </summary>
        public double PreSettlementPrice { get; private set; }
        /// <summary>
        /// 市场持仓量
        /// </summary>
        public double MarketPosition { get; private set; }
        /// <summary>
        /// 前市场持仓量
        /// </summary>
        public double PreMarketPosition { get; private set; }
        /// <summary>
        /// 市价申报许可(1:允许,2:不允许)
        /// </summary>
        public sbyte MarketPricePermit { get; private set; }
        /// <summary>
        /// 涨停板价格
        /// </summary>
        public double UplimitedPrice { get; private set; }
        /// <summary>
        /// 跌停板价格
        /// </summary>
        public double DownlimitedPrice { get; private set; }
        /// <summary>
        /// 期货最小价差
        /// </summary>
        public double PriceInterval { get; private set; }
        public static Ufx30010Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx30010Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx30010Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx30010Result();
                    data.Add(item);
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockName = result.GetStr("stock_name");
                    item.FutureKindName = result.GetStr("future_kind_name");
                    item.SettlementMonth = result.GetInt("settlement_month");
                    item.TargetMarketNo = result.GetStr("target_market_no");
                    item.TargetStockCode = result.GetStr("target_stock_code");
                    item.Multiple = result.GetInt("multiple");
                    item.LastTradeDate = result.GetInt("last_trade_date");
                    item.LastTradeTime = result.GetInt("last_trade_time");
                    item.SettlementDate = result.GetInt("settlement_date");
                    item.SettlementPrice = result.GetDouble("settlement_price");
                    item.PreSettlementPrice = result.GetDouble("pre_settlement_price");
                    item.MarketPosition = result.GetDouble("market_position");
                    item.PreMarketPosition = result.GetDouble("pre_market_position");
                    item.MarketPricePermit = result.GetChar("market_price_permit");
                    item.UplimitedPrice = result.GetDouble("uplimited_price");
                    item.DownlimitedPrice = result.GetDouble("downlimited_price");
                    item.PriceInterval = result.GetDouble("price_interval");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91004
    /// 功能名称: 支持中金所股指期货\国债期货和上期所\大商所\郑商所\能源交易所的商品期货业务
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx91004Result 
    {
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 委托失败代码(限定 <see cref="UfxEntrustFailCode"/> 中定义的常量)
        /// </summary>
        public int EntrustFailCode { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        /// <summary>
        /// 风控判断流水号(用于关联风控信息包中的风控信息条目)
        /// </summary>
        public int RiskSerialNo { get; private set; }
        public static Ufx91004Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91004Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91004Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91004Result();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.EntrustFailCode = result.GetInt("entrust_fail_code");
                    item.FailCause = result.GetStr("fail_cause");
                    item.RiskSerialNo = result.GetInt("risk_serial_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91013
    /// 功能名称: 支持商品期货标准套利单\互换单业务.
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx91013Result 
    {
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 委托失败代码(限定 <see cref="UfxEntrustFailCode"/> 中定义的常量)
        /// </summary>
        public int EntrustFailCode { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        /// <summary>
        /// 风控判断流水号(用于关联风控信息包中的风控信息条目)
        /// </summary>
        public int RiskSerialNo { get; private set; }
        public static Ufx91013Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91013Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91013Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91013Result();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.EntrustFailCode = result.GetInt("entrust_fail_code");
                    item.FailCause = result.GetStr("fail_cause");
                    item.RiskSerialNo = result.GetInt("risk_serial_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91119
    /// 功能名称: 支持按委托序号撤单,支持多条委托批量撤单
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx91119Result 
    {
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91119Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91119Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91119Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91119Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91105
    /// 功能名称: 支持按委托序号撤单,支持多条委托批量撤单
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx91105Result 
    {
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91105Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91105Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91105Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91105Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91121
    /// 功能名称: 支持商品期货组合单撤单
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx91121Result 
    {
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91121Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91121Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91121Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91121Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91107
    /// 功能名称: 支持商品期货组合单撤单
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx91107Result 
    {
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91107Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91107Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91107Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91107Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 31003
    /// 功能名称: 支持查询期货持仓
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx31003Result 
    {
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 持仓席位
        /// </summary>
        public string HoldSeat { get; private set; }
        /// <summary>
        /// 多空标志(限定 <see cref="UfxPositionFlag"/> 中定义的常量)
        /// </summary>
        public sbyte PositionFlag { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 当前数量
        /// </summary>
        public int CurrentAmount { get; private set; }
        /// <summary>
        /// 期初数量
        /// </summary>
        public int BeginAmount { get; private set; }
        /// <summary>
        /// 今日数量(今仓数量,支持上期所平今仓需求.)
        /// </summary>
        public int TodayAmount { get; private set; }
        /// <summary>
        /// 昨仓数量(昨仓数量,支持上期所平昨仓需求.)
        /// </summary>
        public int LastdayAmount { get; private set; }
        /// <summary>
        /// 可用数量
        /// </summary>
        public int EnableAmount { get; private set; }
        /// <summary>
        /// 今日可用数量(今仓可用数量,支持上期所平今仓需求.)
        /// </summary>
        public int TodayEnableAmount { get; private set; }
        /// <summary>
        /// 昨仓可用数量(昨仓可用数量,支持上期所平昨仓需求.)
        /// </summary>
        public int LastdayEnableAmount { get; private set; }
        /// <summary>
        /// 期初成本
        /// </summary>
        public double BeginCost { get; private set; }
        /// <summary>
        /// 当前成本
        /// </summary>
        public double CurrentCost { get; private set; }
        /// <summary>
        /// 当前成本价
        /// </summary>
        public double CurrentCostPrice { get; private set; }
        /// <summary>
        /// 开仓挂单数量
        /// </summary>
        public int PreBuyAmount { get; private set; }
        /// <summary>
        /// 平仓挂单数量
        /// </summary>
        public int PreSellAmount { get; private set; }
        /// <summary>
        /// 开仓挂单金额
        /// </summary>
        public double PreBuyBalance { get; private set; }
        /// <summary>
        /// 平仓挂单金额
        /// </summary>
        public double PreSellBalance { get; private set; }
        /// <summary>
        /// 当日买入数量
        /// </summary>
        public int TodayBuyAmount { get; private set; }
        /// <summary>
        /// 当日卖出数量
        /// </summary>
        public int TodaySellAmount { get; private set; }
        /// <summary>
        /// 当日买入金额
        /// </summary>
        public double TodayBuyBalance { get; private set; }
        /// <summary>
        /// 当日卖出金额
        /// </summary>
        public double TodaySellBalance { get; private set; }
        /// <summary>
        /// 当日买费用
        /// </summary>
        public double TodayBuyFee { get; private set; }
        /// <summary>
        /// 当日卖费用
        /// </summary>
        public double TodaySellFee { get; private set; }
        public static Ufx31003Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx31003Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx31003Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx31003Result();
                    data.Add(item);
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.HoldSeat = result.GetStr("hold_seat");
                    item.PositionFlag = result.GetChar("position_flag");
                    item.InvestType = result.GetChar("invest_type");
                    item.CurrentAmount = result.GetInt("current_amount");
                    item.BeginAmount = result.GetInt("begin_amount");
                    item.TodayAmount = result.GetInt("today_amount");
                    item.LastdayAmount = result.GetInt("lastday_amount");
                    item.EnableAmount = result.GetInt("enable_amount");
                    item.TodayEnableAmount = result.GetInt("today_enable_amount");
                    item.LastdayEnableAmount = result.GetInt("lastday_enable_amount");
                    item.BeginCost = result.GetDouble("begin_cost");
                    item.CurrentCost = result.GetDouble("current_cost");
                    item.CurrentCostPrice = result.GetDouble("current_cost_price");
                    item.PreBuyAmount = result.GetInt("pre_buy_amount");
                    item.PreSellAmount = result.GetInt("pre_sell_amount");
                    item.PreBuyBalance = result.GetDouble("pre_buy_balance");
                    item.PreSellBalance = result.GetDouble("pre_sell_balance");
                    item.TodayBuyAmount = result.GetInt("today_buy_amount");
                    item.TodaySellAmount = result.GetInt("today_sell_amount");
                    item.TodayBuyBalance = result.GetDouble("today_buy_balance");
                    item.TodaySellBalance = result.GetDouble("today_sell_balance");
                    item.TodayBuyFee = result.GetDouble("today_buy_fee");
                    item.TodaySellFee = result.GetDouble("today_sell_fee");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 31013
    /// 功能名称: 支持查询期货持仓明细
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx31013Result 
    {
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 多空标志(限定 <see cref="UfxPositionFlag"/> 中定义的常量)
        /// </summary>
        public sbyte PositionFlag { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 开仓日期
        /// </summary>
        public int StockOpenDate { get; private set; }
        /// <summary>
        /// 成交编号
        /// </summary>
        public string DealNo { get; private set; }
        /// <summary>
        /// 开仓数量
        /// </summary>
        public int OpenAmount { get; private set; }
        /// <summary>
        /// 当前数量(当前持仓数量)
        /// </summary>
        public int CurrentAmount { get; private set; }
        /// <summary>
        /// 平仓数量(平仓数量=开仓数量-当前持仓数量)
        /// </summary>
        public int DropAmount { get; private set; }
        /// <summary>
        /// 占用保证金(期货占用保证金,动态保证金,用最新价计算.该条明细的占用保证金,不包含优惠)
        /// </summary>
        public double OccupyDepositBalance { get; private set; }
        /// <summary>
        /// 开仓价
        /// </summary>
        public double OpenPrice { get; private set; }
        /// <summary>
        /// 平仓收益(老仓用昨结算价,今仓用开仓价计算出来的平仓收益)
        /// </summary>
        public double DropIncome { get; private set; }
        /// <summary>
        /// 总费用
        /// </summary>
        public double TotalFee { get; private set; }
        /// <summary>
        /// 前结算价(昨结算价)
        /// </summary>
        public double PreSettlementPrice { get; private set; }
        /// <summary>
        /// 合约乘数
        /// </summary>
        public int Multiple { get; private set; }
        public static Ufx31013Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx31013Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx31013Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx31013Result();
                    data.Add(item);
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.PositionFlag = result.GetChar("position_flag");
                    item.InvestType = result.GetChar("invest_type");
                    item.StockOpenDate = result.GetInt("stock_open_date");
                    item.DealNo = result.GetStr("deal_no");
                    item.OpenAmount = result.GetInt("open_amount");
                    item.CurrentAmount = result.GetInt("current_amount");
                    item.DropAmount = result.GetInt("drop_amount");
                    item.OccupyDepositBalance = result.GetDouble("occupy_deposit_balance");
                    item.OpenPrice = result.GetDouble("open_price");
                    item.DropIncome = result.GetDouble("drop_income");
                    item.TotalFee = result.GetDouble("total_fee");
                    item.PreSettlementPrice = result.GetDouble("pre_settlement_price");
                    item.Multiple = result.GetInt("multiple");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 32003
    /// 功能名称: 支持查询当日期货委托流水
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx32003Result 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int EntrustDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int EntrustTime { get; private set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OperatorNo { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号()
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报号,用于日终时关联清算流水.)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 平仓类型(对上期所有效,'1'-平今;'2'-平昨.)
        /// </summary>
        public sbyte CloseDirection { get; private set; }
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType { get; private set; }
        /// <summary>
        /// 委托价格
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 预买冻结金额(有持仓增加(现货买入或期货期权开仓)的挂单时需要冻结的资金.)
        /// </summary>
        public double PreBuyFrozenBalance { get; private set; }
        /// <summary>
        /// 预卖金额(有资金增加(现货卖出或期货期权平仓)的挂单时预期会增加的资金.)
        /// </summary>
        public double PreSellBalance { get; private set; }
        /// <summary>
        /// 委托确认号
        /// </summary>
        public string ConfirmNo { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 首次成交时间(HHMMSS格式)
        /// </summary>
        public int FirstDealTime { get; private set; }
        /// <summary>
        /// 成交数量(累计成交数量)
        /// </summary>
        public int DealAmount { get; private set; }
        /// <summary>
        /// 成交金额(累计成交金额)
        /// </summary>
        public double DealBalance { get; private set; }
        /// <summary>
        /// 成交均价(成交的平均价格)
        /// </summary>
        public double DealPrice { get; private set; }
        /// <summary>
        /// 分笔成交次数(一笔委托可能分多次成交,该字段表示成交次数.)
        /// </summary>
        public int DealTimes { get; private set; }
        /// <summary>
        /// 撤单数量
        /// </summary>
        public int WithdrawAmount { get; private set; }
        /// <summary>
        /// 撤单原因
        /// </summary>
        public string WithdrawCause { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        /// <summary>
        /// 交易所申报编号(直连时为申报编号,分仓时为分仓申报编号)
        /// </summary>
        public string ExchangeReportNo { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        public static Ufx32003Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx32003Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx32003Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx32003Result();
                    data.Add(item);
                    item.EntrustDate = result.GetInt("entrust_date");
                    item.EntrustTime = result.GetInt("entrust_time");
                    item.OperatorNo = result.GetStr("operator_no");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ReportNo = result.GetStr("report_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.CloseDirection = result.GetChar("close_direction");
                    item.PriceType = result.GetChar("price_type");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.PreBuyFrozenBalance = result.GetDouble("pre_buy_frozen_balance");
                    item.PreSellBalance = result.GetDouble("pre_sell_balance");
                    item.ConfirmNo = result.GetStr("confirm_no");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.FirstDealTime = result.GetInt("first_deal_time");
                    item.DealAmount = result.GetInt("deal_amount");
                    item.DealBalance = result.GetDouble("deal_balance");
                    item.DealPrice = result.GetDouble("deal_price");
                    item.DealTimes = result.GetInt("deal_times");
                    item.WithdrawAmount = result.GetInt("withdraw_amount");
                    item.WithdrawCause = result.GetStr("withdraw_cause");
                    item.PositionStr = result.GetStr("position_str");
                    item.ExchangeReportNo = result.GetStr("exchange_report_no");
                    item.InvestType = result.GetChar("invest_type");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 32103
    /// 功能名称: 支持查询期货历史普通买卖委托流水
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx32103Result 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int EntrustDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int EntrustTime { get; private set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OperatorNo { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号()
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报号,用于日终时关联清算流水.)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType { get; private set; }
        /// <summary>
        /// 委托价格
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 预买冻结金额(有持仓增加(现货买入或期货期权开仓)的挂单时需要冻结的资金.)
        /// </summary>
        public double PreBuyFrozenBalance { get; private set; }
        /// <summary>
        /// 预卖金额(有资金增加(现货卖出或期货期权平仓)的挂单时预期会增加的资金.)
        /// </summary>
        public double PreSellBalance { get; private set; }
        /// <summary>
        /// 委托确认号
        /// </summary>
        public string ConfirmNo { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 首次成交时间(HHMMSS格式)
        /// </summary>
        public int FirstDealTime { get; private set; }
        /// <summary>
        /// 成交数量(累计成交数量)
        /// </summary>
        public int DealAmount { get; private set; }
        /// <summary>
        /// 成交金额(累计成交金额)
        /// </summary>
        public double DealBalance { get; private set; }
        /// <summary>
        /// 成交均价(成交的平均价格)
        /// </summary>
        public double DealPrice { get; private set; }
        /// <summary>
        /// 分笔成交次数(一笔委托可能分多次成交,该字段表示成交次数.)
        /// </summary>
        public int DealTimes { get; private set; }
        /// <summary>
        /// 撤单数量
        /// </summary>
        public int WithdrawAmount { get; private set; }
        /// <summary>
        /// 撤单原因
        /// </summary>
        public string WithdrawCause { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx32103Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx32103Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx32103Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx32103Result();
                    data.Add(item);
                    item.EntrustDate = result.GetInt("entrust_date");
                    item.EntrustTime = result.GetInt("entrust_time");
                    item.OperatorNo = result.GetStr("operator_no");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ReportNo = result.GetStr("report_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.PriceType = result.GetChar("price_type");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.PreBuyFrozenBalance = result.GetDouble("pre_buy_frozen_balance");
                    item.PreSellBalance = result.GetDouble("pre_sell_balance");
                    item.ConfirmNo = result.GetStr("confirm_no");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.FirstDealTime = result.GetInt("first_deal_time");
                    item.DealAmount = result.GetInt("deal_amount");
                    item.DealBalance = result.GetDouble("deal_balance");
                    item.DealPrice = result.GetDouble("deal_price");
                    item.DealTimes = result.GetInt("deal_times");
                    item.WithdrawAmount = result.GetInt("withdraw_amount");
                    item.WithdrawCause = result.GetStr("withdraw_cause");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 32008
    /// 功能名称: 支持查询当日商品期货组合委托流水
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx32008Result 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int EntrustDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int EntrustTime { get; private set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OperatorNo { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号()
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报号,用于日终时关联清算流水.)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 组合单类型(1:套利单,2:互换单.)
        /// </summary>
        public sbyte PortfolioType { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 委托价格
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 最小成交量
        /// </summary>
        public int LimitDealAmount { get; private set; }
        /// <summary>
        /// 委托确认号
        /// </summary>
        public string ConfirmNo { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 首次成交时间(HHMMSS格式)
        /// </summary>
        public int FirstDealTime { get; private set; }
        /// <summary>
        /// 成交数量(累计成交数量)
        /// </summary>
        public int DealAmount { get; private set; }
        /// <summary>
        /// 买方向成交金额(买方向累计成交金额)
        /// </summary>
        public double BuyDealBalance { get; private set; }
        /// <summary>
        /// 买方向成交均价(买方向成交的平均价格)
        /// </summary>
        public double BuyDealPrice { get; private set; }
        /// <summary>
        /// 卖方向成交金额(卖方向累计成交金额)
        /// </summary>
        public double SellDealBalance { get; private set; }
        /// <summary>
        /// 卖方向成交均价(卖方向成交的平均价格)
        /// </summary>
        public double SellDealPrice { get; private set; }
        /// <summary>
        /// 分笔成交次数(一笔委托可能分多次成交,该字段表示成交次数.)
        /// </summary>
        public int DealTimes { get; private set; }
        /// <summary>
        /// 撤单数量
        /// </summary>
        public int WithdrawAmount { get; private set; }
        /// <summary>
        /// 撤单原因
        /// </summary>
        public string WithdrawCause { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx32008Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx32008Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx32008Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx32008Result();
                    data.Add(item);
                    item.EntrustDate = result.GetInt("entrust_date");
                    item.EntrustTime = result.GetInt("entrust_time");
                    item.OperatorNo = result.GetStr("operator_no");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ReportNo = result.GetStr("report_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.PortfolioType = result.GetChar("portfolio_type");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.LimitDealAmount = result.GetInt("limit_deal_amount");
                    item.ConfirmNo = result.GetStr("confirm_no");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.FirstDealTime = result.GetInt("first_deal_time");
                    item.DealAmount = result.GetInt("deal_amount");
                    item.BuyDealBalance = result.GetDouble("buy_deal_balance");
                    item.BuyDealPrice = result.GetDouble("buy_deal_price");
                    item.SellDealBalance = result.GetDouble("sell_deal_balance");
                    item.SellDealPrice = result.GetDouble("sell_deal_price");
                    item.DealTimes = result.GetInt("deal_times");
                    item.WithdrawAmount = result.GetInt("withdraw_amount");
                    item.WithdrawCause = result.GetStr("withdraw_cause");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 33003
    /// 功能名称: 支持查询当日期货成交流水
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx33003Result 
    {
        /// <summary>
        /// 成交日期(YYYYMMDD格式)
        /// </summary>
        public int DealDate { get; private set; }
        /// <summary>
        /// 成交编号
        /// </summary>
        public string DealNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 交易实例编号
        /// </summary>
        public string InstanceNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 成交数量
        /// </summary>
        public int DealAmount { get; private set; }
        /// <summary>
        /// 成交价格
        /// </summary>
        public double DealPrice { get; private set; }
        /// <summary>
        /// 成交金额
        /// </summary>
        public double DealBalance { get; private set; }
        /// <summary>
        /// 总费用
        /// </summary>
        public double TotalFee { get; private set; }
        /// <summary>
        /// 成交时间(HHMMSS格式)
        /// </summary>
        public int DealTime { get; private set; }
        /// <summary>
        /// 平仓类型(用于期货的平仓业务;0:开仓;1:普通平仓;2:强制平仓;3:到期交割;4:平昨仓;5:平今仓)
        /// </summary>
        public sbyte CloseType { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        public static Ufx33003Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx33003Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx33003Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx33003Result();
                    data.Add(item);
                    item.DealDate = result.GetInt("deal_date");
                    item.DealNo = result.GetStr("deal_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.InstanceNo = result.GetStr("instance_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.DealAmount = result.GetInt("deal_amount");
                    item.DealPrice = result.GetDouble("deal_price");
                    item.DealBalance = result.GetDouble("deal_balance");
                    item.TotalFee = result.GetDouble("total_fee");
                    item.DealTime = result.GetInt("deal_time");
                    item.CloseType = result.GetChar("close_type");
                    item.PositionStr = result.GetStr("position_str");
                    item.InvestType = result.GetChar("invest_type");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 33103
    /// 功能名称: 支持查询期货历史期货成交流水
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx33103Result 
    {
        /// <summary>
        /// 成交日期(YYYYMMDD格式)
        /// </summary>
        public int DealDate { get; private set; }
        /// <summary>
        /// 成交编号
        /// </summary>
        public string DealNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 交易实例编号
        /// </summary>
        public string InstanceNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 成交数量
        /// </summary>
        public int DealAmount { get; private set; }
        /// <summary>
        /// 成交价格
        /// </summary>
        public double DealPrice { get; private set; }
        /// <summary>
        /// 成交金额
        /// </summary>
        public double DealBalance { get; private set; }
        /// <summary>
        /// 总费用
        /// </summary>
        public double TotalFee { get; private set; }
        /// <summary>
        /// 成交时间(HHMMSS格式)
        /// </summary>
        public int DealTime { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx33103Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx33103Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx33103Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx33103Result();
                    data.Add(item);
                    item.DealDate = result.GetInt("deal_date");
                    item.DealNo = result.GetStr("deal_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.InstanceNo = result.GetStr("instance_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.DealAmount = result.GetInt("deal_amount");
                    item.DealPrice = result.GetDouble("deal_price");
                    item.DealBalance = result.GetDouble("deal_balance");
                    item.TotalFee = result.GetDouble("total_fee");
                    item.DealTime = result.GetInt("deal_time");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 34003
    /// 功能名称: 支持查询期货保证金账户的资金可用信息,可查询期货\股指期权\商品期权可用保证金,支持批量传入.
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx34003Result 
    {
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 期货占用保证金
        /// </summary>
        public double OccupyDepositBalance { get; private set; }
        /// <summary>
        /// 期货可用保证金
        /// </summary>
        public double EnableDepositBalance { get; private set; }
        /// <summary>
        /// 期货保证金账户余额
        /// </summary>
        public double FutuDepositBalance { get; private set; }
        /// <summary>
        /// 期货挂单占用保证金
        /// </summary>
        public double FutuTempOccupyDeposit { get; private set; }
        public static Ufx34003Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx34003Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx34003Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx34003Result();
                    data.Add(item);
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.OccupyDepositBalance = result.GetDouble("occupy_deposit_balance");
                    item.EnableDepositBalance = result.GetDouble("enable_deposit_balance");
                    item.FutuDepositBalance = result.GetDouble("futu_deposit_balance");
                    item.FutuTempOccupyDeposit = result.GetDouble("futu_temp_occupy_deposit");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 35023
    /// 功能名称: 支持期货费率查询,支持中金所股指期货\国债期货和上期所\大商所\郑商所\能源交易所的商品期货业务
    /// 业务范围: 期货
    /// </summary>
    public sealed class Ufx35023Result 
    {
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向(1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 证券类别('0v'-商品期货;'0W'-国债期货;'0R'-股指期货)
        /// </summary>
        public string StockType { get; private set; }
        /// <summary>
        /// 期货品种序号(限定 <see cref="UfxFutureKindId"/> 中定义的常量)
        /// </summary>
        public int FutureKindId { get; private set; }
        /// <summary>
        /// 费用类别('a'-结算费;'b'-交割费;'e'-期货公司结算费)
        /// </summary>
        public sbyte FeeType { get; private set; }
        /// <summary>
        /// 费用计算方式('1'-按数量计算;'2'-按金额计算)
        /// </summary>
        public sbyte FeeCalcType { get; private set; }
        /// <summary>
        /// 费率
        /// </summary>
        public double FeeRatio { get; private set; }
        /// <summary>
        /// 短线优惠费率(期货短线优惠费率,存在平今仓优惠的情况,今天开的仓,平掉,开仓与平仓的费用都是优惠的.)
        /// </summary>
        public double FeeRatioShort { get; private set; }
        /// <summary>
        /// 定位串(返回本条记录的定位串,下次查询时可取本次查询返回的最大定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx35023Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx35023Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx35023Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx35023Result();
                    data.Add(item);
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.StockType = result.GetStr("stock_type");
                    item.FutureKindId = result.GetInt("future_kind_id");
                    item.FeeType = result.GetChar("fee_type");
                    item.FeeCalcType = result.GetChar("fee_calc_type");
                    item.FeeRatio = result.GetDouble("fee_ratio");
                    item.FeeRatioShort = result.GetDouble("fee_ratio_short");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 30012
    /// 功能名称: 支持查询期权信息.
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx30012Result 
    {
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券名称
        /// </summary>
        public string StockName { get; private set; }
        /// <summary>
        /// 标的券类型(01-ETF;02-A股;IO-沪深300;HO-上证50;SR-白糖;m-豆粕)
        /// </summary>
        public string TargetType { get; private set; }
        /// <summary>
        /// 标的物代码
        /// </summary>
        public string TargetStockCode { get; private set; }
        /// <summary>
        /// 交易代码
        /// </summary>
        public string OptcontractId { get; private set; }
        /// <summary>
        /// 行权方式(1-欧式;2-美式;3-百慕大;)
        /// </summary>
        public sbyte ApplyStyle { get; private set; }
        /// <summary>
        /// 期权类型(限定 <see cref="UfxOptionType"/> 中定义的常量)
        /// </summary>
        public sbyte OptionType { get; private set; }
        /// <summary>
        /// 合约乘数
        /// </summary>
        public int Multiple { get; private set; }
        /// <summary>
        /// 行权价
        /// </summary>
        public double ExercisePrice { get; private set; }
        /// <summary>
        /// 首交易日
        /// </summary>
        public int FirstTradeDate { get; private set; }
        /// <summary>
        /// 最后交易日
        /// </summary>
        public int LastTradeDate { get; private set; }
        /// <summary>
        /// 行权日
        /// </summary>
        public int ExerciseDate { get; private set; }
        /// <summary>
        /// 行权到期日
        /// </summary>
        public int EndDateOfExercise { get; private set; }
        /// <summary>
        /// 合约版本号
        /// </summary>
        public string ContractVersion { get; private set; }
        /// <summary>
        /// 合约状态(0:不限制开仓;1:限制备兑开仓;2:限制卖出开仓;3:限制卖出开仓\备兑开仓;4:限制买入开仓;5:限制买入开仓\备兑开仓;6:限制买入开仓\卖出开仓;7限制买入开仓\卖出开仓\备兑开仓)
        /// </summary>
        public sbyte CompactStatus { get; private set; }
        /// <summary>
        /// 涨停板价格
        /// </summary>
        public double UplimitedPrice { get; private set; }
        /// <summary>
        /// 跌停板价格
        /// </summary>
        public double DownlimitedPrice { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        /// <summary>
        /// 最小价差
        /// </summary>
        public double PriceInterval { get; private set; }
        public static Ufx30012Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx30012Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx30012Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx30012Result();
                    data.Add(item);
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockName = result.GetStr("stock_name");
                    item.TargetType = result.GetStr("target_type");
                    item.TargetStockCode = result.GetStr("target_stock_code");
                    item.OptcontractId = result.GetStr("optcontract_id");
                    item.ApplyStyle = result.GetChar("apply_style");
                    item.OptionType = result.GetChar("option_type");
                    item.Multiple = result.GetInt("multiple");
                    item.ExercisePrice = result.GetDouble("exercise_price");
                    item.FirstTradeDate = result.GetInt("first_trade_date");
                    item.LastTradeDate = result.GetInt("last_trade_date");
                    item.ExerciseDate = result.GetInt("exercise_date");
                    item.EndDateOfExercise = result.GetInt("end_date_of_exercise");
                    item.ContractVersion = result.GetStr("contract_version");
                    item.CompactStatus = result.GetChar("compact_status");
                    item.UplimitedPrice = result.GetDouble("uplimited_price");
                    item.DownlimitedPrice = result.GetDouble("downlimited_price");
                    item.PositionStr = result.GetStr("position_str");
                    item.PriceInterval = result.GetDouble("price_interval");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91005
    /// 功能名称: 支持沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权交易业务
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91005Result 
    {
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 委托失败代码(限定 <see cref="UfxEntrustFailCode"/> 中定义的常量)
        /// </summary>
        public int EntrustFailCode { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        /// <summary>
        /// 风控判断流水号(用于关联风控信息包中的风控信息条目)
        /// </summary>
        public int RiskSerialNo { get; private set; }
        public static Ufx91005Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91005Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91005Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91005Result();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.EntrustFailCode = result.GetInt("entrust_fail_code");
                    item.FailCause = result.GetStr("fail_cause");
                    item.RiskSerialNo = result.GetInt("risk_serial_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91006
    /// 功能名称: 支持上海股票期权保证券的锁定与解锁业务
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91006Result 
    {
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        public static Ufx91006Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91006Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91006Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91006Result();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91007
    /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权业务
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91007Result 
    {
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        public static Ufx91007Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91007Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91007Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91007Result();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91025
    /// 功能名称: 支持上交所股票期权合并行权业务
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91025Result 
    {
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        public static Ufx91025Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91025Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91025Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91025Result();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91126
    /// 功能名称: 支持上交所期权合并行权撤单,可传入多条委托序号进行批量撤单.最多支持1000笔
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91126Result 
    {
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码(认购期权合约代码)
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券代码2(认沽期权合约代码)
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91126Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91126Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91126Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91126Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 32017
    /// 功能名称: 支持查询当日上交所合并行权委托
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx32017Result 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int EntrustDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int EntrustTime { get; private set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OperatorNo { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码(认购期权合约代码)
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券代码2(认沽期权合约代码)
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 委托确认号
        /// </summary>
        public string ConfirmNo { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 撤单原因
        /// </summary>
        public string WithdrawCause { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx32017Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx32017Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx32017Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx32017Result();
                    data.Add(item);
                    item.EntrustDate = result.GetInt("entrust_date");
                    item.EntrustTime = result.GetInt("entrust_time");
                    item.OperatorNo = result.GetStr("operator_no");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.ConfirmNo = result.GetStr("confirm_no");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.WithdrawCause = result.GetStr("withdraw_cause");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91012
    /// 功能名称: 支持股指期权做市业务
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91012Result 
    {
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        public static Ufx91012Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91012Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91012Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91012Result();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91014
    /// 功能名称: 支持深交所股票期权,中金所股指期权做市业务,支持批量传入
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91014Result 
    {
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号(如委托失败,则返回0)
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 委托失败代码(限定 <see cref="UfxEntrustFailCode"/> 中定义的常量)
        /// </summary>
        public int EntrustFailCode { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        /// <summary>
        /// 风控判断流水号(用于关联风控信息包中的风控信息条目)
        /// </summary>
        public int RiskSerialNo { get; private set; }
        public static Ufx91014Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91014Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91014Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91014Result();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.EntrustFailCode = result.GetInt("entrust_fail_code");
                    item.FailCause = result.GetStr("fail_cause");
                    item.RiskSerialNo = result.GetInt("risk_serial_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91091
    /// 功能名称: 支持上交所股票期权篮子委托业务,用于股票期权批量下单和做市委托.
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91091Result 
    {
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号(由于O32篮子委托不返回编号和明细信息,编号只在对接UFT时有效,对接O32时,该字段无效.)
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        public static Ufx91091Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91091Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91091Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91091Result();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91016
    /// 功能名称: 支持上交所股票期权询价
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91016Result 
    {
        /// <summary>
        /// 委托序号(如委托失败,则返回0)
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 委托失败代码(限定 <see cref="UfxEntrustFailCode"/> 中定义的常量)
        /// </summary>
        public int EntrustFailCode { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        public static Ufx91016Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91016Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91016Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91016Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.EntrustFailCode = result.GetInt("entrust_fail_code");
                    item.FailCause = result.GetStr("fail_cause");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91017
    /// 功能名称: 支持上交所股票期权回应报价,回应报价修改,支持批量传入
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91017Result 
    {
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 委托失败代码(限定 <see cref="UfxEntrustFailCode"/> 中定义的常量)
        /// </summary>
        public int EntrustFailCode { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        /// <summary>
        /// 风控判断流水号(用于关联风控信息包中的风控信息条目)
        /// </summary>
        public int RiskSerialNo { get; private set; }
        public static Ufx91017Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91017Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91017Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91017Result();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.EntrustFailCode = result.GetInt("entrust_fail_code");
                    item.FailCause = result.GetStr("fail_cause");
                    item.RiskSerialNo = result.GetInt("risk_serial_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91120
    /// 功能名称: 支持按委托序号撤销期权(股票期权\股指期权\商品期权)委托,可传入多个委托序号进行批量撤单
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91120Result 
    {
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91120Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91120Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91120Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91120Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91106
    /// 功能名称: 支持按委托序号撤销期权(股票期权\股指期权\商品期权)委托,可传入多个委托序号进行批量撤单
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91106Result 
    {
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91106Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91106Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91106Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91106Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91108
    /// 功能名称: 支持按委托批号撤销股指期权委托
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91108Result 
    {
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 撤单失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91108Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91108Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91108Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91108Result();
                    data.Add(item);
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91122
    /// 功能名称: 支持撤销深交所股票期权做市委托,中金所股指期权做市委托
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91122Result 
    {
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91122Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91122Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91122Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91122Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91109
    /// 功能名称: 支持撤销深交所股票期权做市委托,中金所股指期权做市委托
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91109Result 
    {
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91109Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91109Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91109Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91109Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91123
    /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权撤单,可传入多条委托序号进行批量撤单.
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91123Result 
    {
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91123Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91123Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91123Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91123Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91111
    /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权撤单,可传入多条委托序号进行批量撤单.
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91111Result 
    {
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91111Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91111Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91111Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91111Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91112
    /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权按委托批号撤单.
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91112Result 
    {
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 撤单成功标志('1'-成功'2'-失败)
        /// </summary>
        public sbyte SuccessFlag { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        public static Ufx91112Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91112Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91112Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91112Result();
                    data.Add(item);
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.SuccessFlag = result.GetChar("success_flag");
                    item.FailCause = result.GetStr("fail_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 31004
    /// 功能名称: 支持查询沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权持仓信息
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx31004Result 
    {
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 期权类型(限定 <see cref="UfxOptionType"/> 中定义的常量)
        /// </summary>
        public sbyte OptionType { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 持仓席位
        /// </summary>
        public string HoldSeat { get; private set; }
        /// <summary>
        /// 多空标志(限定 <see cref="UfxPositionFlag"/> 中定义的常量)
        /// </summary>
        public sbyte PositionFlag { get; private set; }
        /// <summary>
        /// 当前数量
        /// </summary>
        public int CurrentAmount { get; private set; }
        /// <summary>
        /// 今日数量(今仓数量,支持上期所平今仓需求.)
        /// </summary>
        public int TodayAmount { get; private set; }
        /// <summary>
        /// 昨仓数量(昨仓数量,支持上期所平昨仓需求.)
        /// </summary>
        public int LastdayAmount { get; private set; }
        /// <summary>
        /// 可用数量
        /// </summary>
        public int EnableAmount { get; private set; }
        /// <summary>
        /// 今日可用数量(今仓可用数量,支持上期所平今仓需求.)
        /// </summary>
        public int TodayEnableAmount { get; private set; }
        /// <summary>
        /// 昨仓可用数量(昨仓可用数量,支持上期所平昨仓需求.)
        /// </summary>
        public int LastdayEnableAmount { get; private set; }
        /// <summary>
        /// 期初成本
        /// </summary>
        public double BeginCost { get; private set; }
        /// <summary>
        /// 当前成本
        /// </summary>
        public double CurrentCost { get; private set; }
        /// <summary>
        /// 开仓挂单数量
        /// </summary>
        public int PreBuyAmount { get; private set; }
        /// <summary>
        /// 平仓挂单数量
        /// </summary>
        public int PreSellAmount { get; private set; }
        /// <summary>
        /// 开仓挂单金额
        /// </summary>
        public double PreBuyBalance { get; private set; }
        /// <summary>
        /// 平仓挂单金额
        /// </summary>
        public double PreSellBalance { get; private set; }
        /// <summary>
        /// 当日开仓数量
        /// </summary>
        public int TodayBuyAmount { get; private set; }
        /// <summary>
        /// 当日平仓数量
        /// </summary>
        public int TodaySellAmount { get; private set; }
        /// <summary>
        /// 当日开仓金额
        /// </summary>
        public double TodayBuyBalance { get; private set; }
        /// <summary>
        /// 当日平仓金额
        /// </summary>
        public double TodaySellBalance { get; private set; }
        /// <summary>
        /// 当日开仓费用
        /// </summary>
        public double TodayBuyFee { get; private set; }
        /// <summary>
        /// 当日平仓费用
        /// </summary>
        public double TodaySellFee { get; private set; }
        public static Ufx31004Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx31004Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx31004Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx31004Result();
                    data.Add(item);
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.OptionType = result.GetChar("option_type");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.HoldSeat = result.GetStr("hold_seat");
                    item.PositionFlag = result.GetChar("position_flag");
                    item.CurrentAmount = result.GetInt("current_amount");
                    item.TodayAmount = result.GetInt("today_amount");
                    item.LastdayAmount = result.GetInt("lastday_amount");
                    item.EnableAmount = result.GetInt("enable_amount");
                    item.TodayEnableAmount = result.GetInt("today_enable_amount");
                    item.LastdayEnableAmount = result.GetInt("lastday_enable_amount");
                    item.BeginCost = result.GetDouble("begin_cost");
                    item.CurrentCost = result.GetDouble("current_cost");
                    item.PreBuyAmount = result.GetInt("pre_buy_amount");
                    item.PreSellAmount = result.GetInt("pre_sell_amount");
                    item.PreBuyBalance = result.GetDouble("pre_buy_balance");
                    item.PreSellBalance = result.GetDouble("pre_sell_balance");
                    item.TodayBuyAmount = result.GetInt("today_buy_amount");
                    item.TodaySellAmount = result.GetInt("today_sell_amount");
                    item.TodayBuyBalance = result.GetDouble("today_buy_balance");
                    item.TodaySellBalance = result.GetDouble("today_sell_balance");
                    item.TodayBuyFee = result.GetDouble("today_buy_fee");
                    item.TodaySellFee = result.GetDouble("today_sell_fee");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 32004
    /// 功能名称: 支持查询沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权当日委托流水(除备兑锁定解锁)
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx32004Result 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int EntrustDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int EntrustTime { get; private set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OperatorNo { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号()
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报号,用于日终时关联清算流水.)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 报价标识(仅对上交所股票期权回应报价和回应报价修改业务有效,'02'-回应报价,'03'-回应报价修改)
        /// </summary>
        public string QuoteMark { get; private set; }
        /// <summary>
        /// 委托序号(被修改的回应报价委托序号,报价标识为'回应报价修改'时有效)
        /// </summary>
        public int CancelEntrustNo { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType { get; private set; }
        /// <summary>
        /// 委托价格
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 预开仓冻结金额(期权开仓挂单时需要冻结的资金.)
        /// </summary>
        public double PreBuyFrozenBalance { get; private set; }
        /// <summary>
        /// 预平仓金额(期权平仓挂单时预期会增加的资金.)
        /// </summary>
        public double PreSellBalance { get; private set; }
        /// <summary>
        /// 委托确认号
        /// </summary>
        public string ConfirmNo { get; private set; }
        /// <summary>
        /// 备兑标志(仅对股票期权有效.1:备兑,0:非备兑,默认为0.)
        /// </summary>
        public sbyte CoveredFlag { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 首次成交时间(HHMMSS格式)
        /// </summary>
        public int FirstDealTime { get; private set; }
        /// <summary>
        /// 成交数量(累计成交数量)
        /// </summary>
        public int DealAmount { get; private set; }
        /// <summary>
        /// 成交金额(累计成交金额)
        /// </summary>
        public double DealBalance { get; private set; }
        /// <summary>
        /// 成交均价(成交的平均价格)
        /// </summary>
        public double DealPrice { get; private set; }
        /// <summary>
        /// 分笔成交次数(一笔委托可能分多次成交,该字段表示成交次数.)
        /// </summary>
        public int DealTimes { get; private set; }
        /// <summary>
        /// 撤单数量
        /// </summary>
        public int WithdrawAmount { get; private set; }
        /// <summary>
        /// 撤单原因
        /// </summary>
        public string WithdrawCause { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        /// <summary>
        /// 交易所申报编号(直连时为申报编号,分仓时为分仓申报编号)
        /// </summary>
        public string ExchangeReportNo { get; private set; }
        /// <summary>
        /// 是否做市报价(做市报价返回1,否则返回空,上交所该字段无效)
        /// </summary>
        public sbyte MktQuote { get; private set; }
        /// <summary>
        /// 平仓类型(0:不区分方向1:平今2:平昨)
        /// </summary>
        public sbyte CloseDirection { get; private set; }
        public static Ufx32004Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx32004Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx32004Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx32004Result();
                    data.Add(item);
                    item.EntrustDate = result.GetInt("entrust_date");
                    item.EntrustTime = result.GetInt("entrust_time");
                    item.OperatorNo = result.GetStr("operator_no");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ReportNo = result.GetStr("report_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.QuoteMark = result.GetStr("quote_mark");
                    item.CancelEntrustNo = result.GetInt("cancel_entrust_no");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.PriceType = result.GetChar("price_type");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.PreBuyFrozenBalance = result.GetDouble("pre_buy_frozen_balance");
                    item.PreSellBalance = result.GetDouble("pre_sell_balance");
                    item.ConfirmNo = result.GetStr("confirm_no");
                    item.CoveredFlag = result.GetChar("covered_flag");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.FirstDealTime = result.GetInt("first_deal_time");
                    item.DealAmount = result.GetInt("deal_amount");
                    item.DealBalance = result.GetDouble("deal_balance");
                    item.DealPrice = result.GetDouble("deal_price");
                    item.DealTimes = result.GetInt("deal_times");
                    item.WithdrawAmount = result.GetInt("withdraw_amount");
                    item.WithdrawCause = result.GetStr("withdraw_cause");
                    item.PositionStr = result.GetStr("position_str");
                    item.ExchangeReportNo = result.GetStr("exchange_report_no");
                    item.MktQuote = result.GetChar("mkt_quote");
                    item.CloseDirection = result.GetChar("close_direction");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 32007
    /// 功能名称: 支持查询当日股指期权\深交所股票期权做市委托
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx32007Result 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int EntrustDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int EntrustTime { get; private set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OperatorNo { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 买入开平方向 
        /// </summary>
        public sbyte BuyDirection { get; private set; }
        /// <summary>
        /// 买入价格
        /// </summary>
        public double BuyPrice { get; private set; }
        /// <summary>
        /// 买入数量
        /// </summary>
        public int BuyAmount { get; private set; }
        /// <summary>
        /// 卖出开平方向 
        /// </summary>
        public sbyte SellDirection { get; private set; }
        /// <summary>
        /// 卖出价格
        /// </summary>
        public double SellPrice { get; private set; }
        /// <summary>
        /// 卖出数量
        /// </summary>
        public int SellAmount { get; private set; }
        /// <summary>
        /// 委托确认号
        /// </summary>
        public string ConfirmNo { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 买入委托状态(限定 <see cref="UfxBuyEntrustStatus"/> 中定义的常量)
        /// </summary>
        public sbyte BuyEntrustStatus { get; private set; }
        /// <summary>
        /// 卖出委托状态(限定 <see cref="UfxSaleEntrustStatus"/> 中定义的常量)
        /// </summary>
        public sbyte SaleEntrustStatus { get; private set; }
        /// <summary>
        /// 买入成交数量
        /// </summary>
        public int BuyDealAmount { get; private set; }
        /// <summary>
        /// 买入成交金额
        /// </summary>
        public double BuyDealBalance { get; private set; }
        /// <summary>
        /// 卖出成交数量
        /// </summary>
        public int SellDealAmount { get; private set; }
        /// <summary>
        /// 卖出成交金额
        /// </summary>
        public double SellDealBalance { get; private set; }
        /// <summary>
        /// 买入方向撤单数量
        /// </summary>
        public int BuyCancelAmount { get; private set; }
        /// <summary>
        /// 卖出方向撤单数量
        /// </summary>
        public int SellCancelAmount { get; private set; }
        /// <summary>
        /// 撤单原因
        /// </summary>
        public string WithdrawCause { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx32007Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx32007Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx32007Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx32007Result();
                    data.Add(item);
                    item.EntrustDate = result.GetInt("entrust_date");
                    item.EntrustTime = result.GetInt("entrust_time");
                    item.OperatorNo = result.GetStr("operator_no");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.BuyDirection = result.GetChar("buy_direction");
                    item.BuyPrice = result.GetDouble("buy_price");
                    item.BuyAmount = result.GetInt("buy_amount");
                    item.SellDirection = result.GetChar("sell_direction");
                    item.SellPrice = result.GetDouble("sell_price");
                    item.SellAmount = result.GetInt("sell_amount");
                    item.ConfirmNo = result.GetStr("confirm_no");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.BuyEntrustStatus = result.GetChar("buy_entrust_status");
                    item.SaleEntrustStatus = result.GetChar("sale_entrust_status");
                    item.BuyDealAmount = result.GetInt("buy_deal_amount");
                    item.BuyDealBalance = result.GetDouble("buy_deal_balance");
                    item.SellDealAmount = result.GetInt("sell_deal_amount");
                    item.SellDealBalance = result.GetDouble("sell_deal_balance");
                    item.BuyCancelAmount = result.GetInt("buy_cancel_amount");
                    item.SellCancelAmount = result.GetInt("sell_cancel_amount");
                    item.WithdrawCause = result.GetStr("withdraw_cause");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 33004
    /// 功能名称: 支持查询沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权当日成交流水
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx33004Result 
    {
        /// <summary>
        /// 成交日期(YYYYMMDD格式)
        /// </summary>
        public int DealDate { get; private set; }
        /// <summary>
        /// 成交编号
        /// </summary>
        public string DealNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 交易实例编号
        /// </summary>
        public string InstanceNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 成交数量
        /// </summary>
        public int DealAmount { get; private set; }
        /// <summary>
        /// 成交价格
        /// </summary>
        public double DealPrice { get; private set; }
        /// <summary>
        /// 成交金额
        /// </summary>
        public double DealBalance { get; private set; }
        /// <summary>
        /// 总费用
        /// </summary>
        public double TotalFee { get; private set; }
        /// <summary>
        /// 成交时间(HHMMSS格式)
        /// </summary>
        public int DealTime { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        /// <summary>
        /// 平仓类型(用于期权的平仓业务;0:开仓;1:普通平仓;2:强制平仓;3:到期交割;4:平昨仓;5:平今仓)
        /// </summary>
        public sbyte CloseType { get; private set; }
        public static Ufx33004Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx33004Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx33004Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx33004Result();
                    data.Add(item);
                    item.DealDate = result.GetInt("deal_date");
                    item.DealNo = result.GetStr("deal_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.InstanceNo = result.GetStr("instance_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.DealAmount = result.GetInt("deal_amount");
                    item.DealPrice = result.GetDouble("deal_price");
                    item.DealBalance = result.GetDouble("deal_balance");
                    item.TotalFee = result.GetDouble("total_fee");
                    item.DealTime = result.GetInt("deal_time");
                    item.PositionStr = result.GetStr("position_str");
                    item.CloseType = result.GetChar("close_type");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 34004
    /// 功能名称: 支持沪深衍生品保证金账户查询(股指期权,商品期权保证金账户请使用34003接口查询).
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx34004Result 
    {
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 占用保证金
        /// </summary>
        public double OccupyDepositBalance { get; private set; }
        /// <summary>
        /// 可用保证金
        /// </summary>
        public double EnableDepositBalance { get; private set; }
        /// <summary>
        /// 期权保证金账户余额
        /// </summary>
        public double OptionDepositBalance { get; private set; }
        public static Ufx34004Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx34004Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx34004Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx34004Result();
                    data.Add(item);
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.OccupyDepositBalance = result.GetDouble("occupy_deposit_balance");
                    item.EnableDepositBalance = result.GetDouble("enable_deposit_balance");
                    item.OptionDepositBalance = result.GetDouble("option_deposit_balance");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91015
    /// 功能名称: 支持上交所股票期权组合策略保证金交易业务
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91015Result 
    {
        /// <summary>
        /// 委托批号(如委托失败,则返回0)
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号(如委托失败,则返回0)
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 委托失败代码(限定 <see cref="UfxEntrustFailCode"/> 中定义的常量)
        /// </summary>
        public int EntrustFailCode { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        /// <summary>
        /// 风控判断流水号(用于关联风控信息包中的风控信息条目)
        /// </summary>
        public int RiskSerialNo { get; private set; }
        public static Ufx91015Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91015Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91015Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91015Result();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.EntrustFailCode = result.GetInt("entrust_fail_code");
                    item.FailCause = result.GetStr("fail_cause");
                    item.RiskSerialNo = result.GetInt("risk_serial_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 31015
    /// 功能名称: 支持查询上交所股票期权组合策略保证金持仓信息
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx31015Result 
    {
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 组合策略代码
        /// </summary>
        public string CombistrategyCode { get; private set; }
        /// <summary>
        /// 组合策略持仓编号
        /// </summary>
        public string CombistrategyId { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 持仓席位
        /// </summary>
        public string HoldSeat { get; private set; }
        /// <summary>
        /// 证券代码1
        /// </summary>
        public string StockCode1 { get; private set; }
        /// <summary>
        /// 多空标志1(限定 <see cref="UfxPositionFlag1"/> 中定义的常量)
        /// </summary>
        public sbyte PositionFlag1 { get; private set; }
        /// <summary>
        /// 证券代码2
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 多空标志2(限定 <see cref="UfxPositionFlag2"/> 中定义的常量)
        /// </summary>
        public sbyte PositionFlag2 { get; private set; }
        /// <summary>
        /// 证券代码3
        /// </summary>
        public string StockCode3 { get; private set; }
        /// <summary>
        /// 多空标志3(限定 <see cref="UfxPositionFlag3"/> 中定义的常量)
        /// </summary>
        public sbyte PositionFlag3 { get; private set; }
        /// <summary>
        /// 证券代码4
        /// </summary>
        public string StockCode4 { get; private set; }
        /// <summary>
        /// 多空标志4(限定 <see cref="UfxPositionFlag4"/> 中定义的常量)
        /// </summary>
        public sbyte PositionFlag4 { get; private set; }
        /// <summary>
        /// 当前数量
        /// </summary>
        public int CurrentAmount { get; private set; }
        /// <summary>
        /// 冻结数量(组合拆分未成交数量)
        /// </summary>
        public int FrozenAmount { get; private set; }
        /// <summary>
        /// 组合前占用保证金
        /// </summary>
        public double CombiDepositPre { get; private set; }
        /// <summary>
        /// 组合后占用保证金
        /// </summary>
        public double CombiDepositNow { get; private set; }
        public static Ufx31015Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx31015Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx31015Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx31015Result();
                    data.Add(item);
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.CombistrategyCode = result.GetStr("combistrategy_code");
                    item.CombistrategyId = result.GetStr("combistrategy_id");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.HoldSeat = result.GetStr("hold_seat");
                    item.StockCode1 = result.GetStr("stock_code1");
                    item.PositionFlag1 = result.GetChar("position_flag1");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.PositionFlag2 = result.GetChar("position_flag2");
                    item.StockCode3 = result.GetStr("stock_code3");
                    item.PositionFlag3 = result.GetChar("position_flag3");
                    item.StockCode4 = result.GetStr("stock_code4");
                    item.PositionFlag4 = result.GetChar("position_flag4");
                    item.CurrentAmount = result.GetInt("current_amount");
                    item.FrozenAmount = result.GetInt("frozen_amount");
                    item.CombiDepositPre = result.GetDouble("combi_deposit_pre");
                    item.CombiDepositNow = result.GetDouble("combi_deposit_now");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 32015
    /// 功能名称: 支持查询上交所股票期权组合策略保证金委托信息
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx32015Result 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int EntrustDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int EntrustTime { get; private set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OperatorNo { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号()
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报号,用于日终时关联清算流水.)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 组合策略代码
        /// </summary>
        public string CombistrategyCode { get; private set; }
        /// <summary>
        /// 证券代码1
        /// </summary>
        public string StockCode1 { get; private set; }
        /// <summary>
        /// 证券代码2
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 证券代码3
        /// </summary>
        public string StockCode3 { get; private set; }
        /// <summary>
        /// 证券代码4
        /// </summary>
        public string StockCode4 { get; private set; }
        /// <summary>
        /// 组合策略持仓编号
        /// </summary>
        public string CombistrategyId { get; private set; }
        /// <summary>
        /// 组合方向(B-组合,C-拆分,D-转备兑,E-备兑转保证金)
        /// </summary>
        public sbyte CombiDirection { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 委托确认号
        /// </summary>
        public string ConfirmNo { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 撤单原因
        /// </summary>
        public string WithdrawCause { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx32015Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx32015Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx32015Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx32015Result();
                    data.Add(item);
                    item.EntrustDate = result.GetInt("entrust_date");
                    item.EntrustTime = result.GetInt("entrust_time");
                    item.OperatorNo = result.GetStr("operator_no");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ReportNo = result.GetStr("report_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.CombistrategyCode = result.GetStr("combistrategy_code");
                    item.StockCode1 = result.GetStr("stock_code1");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.StockCode3 = result.GetStr("stock_code3");
                    item.StockCode4 = result.GetStr("stock_code4");
                    item.CombistrategyId = result.GetStr("combistrategy_id");
                    item.CombiDirection = result.GetChar("combi_direction");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.ConfirmNo = result.GetStr("confirm_no");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.WithdrawCause = result.GetStr("withdraw_cause");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 33015
    /// 功能名称: 支持查询上交所股票期权组合策略保证金成交信息
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx33015Result 
    {
        /// <summary>
        /// 成交日期(YYYYMMDD格式)
        /// </summary>
        public int DealDate { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 组合策略代码
        /// </summary>
        public string CombistrategyCode { get; private set; }
        /// <summary>
        /// 证券代码1
        /// </summary>
        public string StockCode1 { get; private set; }
        /// <summary>
        /// 证券代码2
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 证券代码3
        /// </summary>
        public string StockCode3 { get; private set; }
        /// <summary>
        /// 证券代码4
        /// </summary>
        public string StockCode4 { get; private set; }
        /// <summary>
        /// 组合策略持仓编号
        /// </summary>
        public string CombistrategyId { get; private set; }
        /// <summary>
        /// 组合方向(B-组合,C-拆分,D-转备兑,E-备兑转保证金)
        /// </summary>
        public sbyte CombiDirection { get; private set; }
        /// <summary>
        /// 成交数量
        /// </summary>
        public int DealAmount { get; private set; }
        /// <summary>
        /// 成交时间(HHMMSS格式)
        /// </summary>
        public int DealTime { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx33015Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx33015Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx33015Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx33015Result();
                    data.Add(item);
                    item.DealDate = result.GetInt("deal_date");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.MarketNo = result.GetStr("market_no");
                    item.CombistrategyCode = result.GetStr("combistrategy_code");
                    item.StockCode1 = result.GetStr("stock_code1");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.StockCode3 = result.GetStr("stock_code3");
                    item.StockCode4 = result.GetStr("stock_code4");
                    item.CombistrategyId = result.GetStr("combistrategy_id");
                    item.CombiDirection = result.GetChar("combi_direction");
                    item.DealAmount = result.GetInt("deal_amount");
                    item.DealTime = result.GetInt("deal_time");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 91018
    /// 功能名称: 支持郑商所商品期权套利单业务.
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx91018Result 
    {
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 委托失败代码(限定 <see cref="UfxEntrustFailCode"/> 中定义的常量)
        /// </summary>
        public int EntrustFailCode { get; private set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string FailCause { get; private set; }
        /// <summary>
        /// 风控判断流水号(用于关联风控信息包中的风控信息条目)
        /// </summary>
        public int RiskSerialNo { get; private set; }
        public static Ufx91018Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx91018Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx91018Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx91018Result();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.EntrustFailCode = result.GetInt("entrust_fail_code");
                    item.FailCause = result.GetStr("fail_cause");
                    item.RiskSerialNo = result.GetInt("risk_serial_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 32016
    /// 功能名称: 支持查询当日郑商所商品期权套利单委托
    /// 业务范围: 期权
    /// </summary>
    public sealed class Ufx32016Result 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int EntrustDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int EntrustTime { get; private set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OperatorNo { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托序号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 第三方系统自定义号
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码(一腿代码)
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券代码2(二腿代码)
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 委托方向('1'-买入;'2'-卖出)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType { get; private set; }
        /// <summary>
        /// 委托价格
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 委托确认号
        /// </summary>
        public string ConfirmNo { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 特殊业务标志('7'-郑商所跨式组合单;'8'-郑商所宽跨式组合单)
        /// </summary>
        public sbyte SpecialFlag { get; private set; }
        /// <summary>
        /// 首次成交时间(HHMMSS格式)
        /// </summary>
        public int FirstDealTime { get; private set; }
        /// <summary>
        /// 成交数量(累计成交数量)
        /// </summary>
        public int DealAmount { get; private set; }
        /// <summary>
        /// 成交金额(累计成交金额)
        /// </summary>
        public double DealBalance { get; private set; }
        /// <summary>
        /// 废单原因
        /// </summary>
        public string WithdrawCause { get; private set; }
        /// <summary>
        /// 定位串(返回记录中值最大的定位串,做为所有记录的定位串,下;次查询时可取本次查询返回的定位串作为查询条件传入.)
        /// </summary>
        public string PositionStr { get; private set; }
        public static Ufx32016Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx32016Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx32016Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx32016Result();
                    data.Add(item);
                    item.EntrustDate = result.GetInt("entrust_date");
                    item.EntrustTime = result.GetInt("entrust_time");
                    item.OperatorNo = result.GetStr("operator_no");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.PriceType = result.GetChar("price_type");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.ConfirmNo = result.GetStr("confirm_no");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.SpecialFlag = result.GetChar("special_flag");
                    item.FirstDealTime = result.GetInt("first_deal_time");
                    item.DealAmount = result.GetInt("deal_amount");
                    item.DealBalance = result.GetDouble("deal_balance");
                    item.WithdrawCause = result.GetStr("withdraw_cause");
                    item.PositionStr = result.GetStr("position_str");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 31005
    /// 功能名称: 支持查询现货\期货\期权持仓信息
    /// 业务范围: 标准
    /// </summary>
    public sealed class Ufx31005Result 
    {
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 资产单元编号
        /// </summary>
        public string AssetNo { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 持仓席位
        /// </summary>
        public string HoldSeat { get; private set; }
        /// <summary>
        /// 多空标志(限定 <see cref="UfxPositionFlag"/> 中定义的常量)
        /// </summary>
        public sbyte PositionFlag { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 当前数量
        /// </summary>
        public int CurrentAmount { get; private set; }
        /// <summary>
        /// 可用数量
        /// </summary>
        public int EnableAmount { get; private set; }
        /// <summary>
        /// 当前成本
        /// </summary>
        public double CurrentCost { get; private set; }
        public static Ufx31005Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx31005Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx31005Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx31005Result();
                    data.Add(item);
                    item.AccountCode = result.GetStr("account_code");
                    item.AssetNo = result.GetStr("asset_no");
                    item.CombiNo = result.GetStr("combi_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.HoldSeat = result.GetStr("hold_seat");
                    item.PositionFlag = result.GetChar("position_flag");
                    item.InvestType = result.GetChar("invest_type");
                    item.CurrentAmount = result.GetInt("current_amount");
                    item.EnableAmount = result.GetInt("enable_amount");
                    item.CurrentCost = result.GetDouble("current_cost");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: 35008
    /// 功能名称: 支持获取当前可用的委托批号
    /// 业务范围: 账户
    /// </summary>
    public sealed class Ufx35008Result 
    {
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        public static Ufx35008Result ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static Ufx35008Result[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<Ufx35008Result>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new Ufx35008Result();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: a
    /// 功能名称: 委托下达成功后推送本条委托信息
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxEntrustReceived 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int BusinessTime { get; private set; }
        /// <summary>
        /// 报价标识(仅对上交所股票期权回应报价和回应报价修改业务有效,'02'-回应报价,'03'-回应报价修改)
        /// </summary>
        public string QuoteMark { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 委托编号(被修改委托)(报价标识为'回应报价修改'时有效)
        /// </summary>
        public int CancelEntrustNo { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报编号,和晚上清算流水)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 交易实例编号(不涉及交易实例时,交易实例编号为空.)
        /// </summary>
        public string InstanceNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 平仓类型(仅对上期所,能源期货交易所有效,'1'-平今;'2'-平昨.)
        /// </summary>
        public sbyte CloseDirection { get; private set; }
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType { get; private set; }
        /// <summary>
        /// 委托价格
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustStatus"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustStatus { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        public static UfxEntrustReceived ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxEntrustReceived[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxEntrustReceived>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxEntrustReceived();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BusinessTime = result.GetInt("business_time");
                    item.QuoteMark = result.GetStr("quote_mark");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.CancelEntrustNo = result.GetInt("cancel_entrust_no");
                    item.ReportNo = result.GetStr("report_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.InstanceNo = result.GetStr("instance_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.CloseDirection = result.GetChar("close_direction");
                    item.PriceType = result.GetChar("price_type");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.EntrustStatus = result.GetChar("entrust_status");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: b
    /// 功能名称: 委托确认后推送本条委托信息
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxEntrustConfirmed 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int BusinessTime { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 交易实例编号(不涉及交易实例时,交易实例编号为空.)
        /// </summary>
        public string InstanceNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 平仓类型(仅对上期所,能源期货交易所有效,'1'-平今;'2'-平昨.)
        /// </summary>
        public sbyte CloseDirection { get; private set; }
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType { get; private set; }
        /// <summary>
        /// 委托价格
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 委托数量('期权回应报价修改'为被修改委托剩余未成交数量)
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustStatus"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustStatus { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 委托确认号
        /// </summary>
        public string ConfirmNo { get; private set; }
        public static UfxEntrustConfirmed ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxEntrustConfirmed[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxEntrustConfirmed>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxEntrustConfirmed();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BusinessTime = result.GetInt("business_time");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.InstanceNo = result.GetStr("instance_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.CloseDirection = result.GetChar("close_direction");
                    item.PriceType = result.GetChar("price_type");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.EntrustStatus = result.GetChar("entrust_status");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.ConfirmNo = result.GetStr("confirm_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: c
    /// 功能名称: 
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxEntrustRejected 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustStatus"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustStatus { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 废单原因
        /// </summary>
        public string RevokeCause { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        public static UfxEntrustRejected ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxEntrustRejected[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxEntrustRejected>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxEntrustRejected();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.EntrustStatus = result.GetChar("entrust_status");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.RevokeCause = result.GetStr("revoke_cause");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: d
    /// 功能名称: 对某条委托进行撤单后推送该条委托信息
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxEntrustCancel 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托批号(撤单委托和被撤委托用相同委托批号)
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号(撤单委托)
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 委托编号(被撤委托)
        /// </summary>
        public int CancelEntrustNo { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustStatus"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustStatus { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 撤单原因
        /// </summary>
        public string RevokeCause { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        public static UfxEntrustCancel ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxEntrustCancel[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxEntrustCancel>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxEntrustCancel();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.CancelEntrustNo = result.GetInt("cancel_entrust_no");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.EntrustStatus = result.GetChar("entrust_status");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.RevokeCause = result.GetStr("revoke_cause");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: e
    /// 功能名称: 对某条委托进行撤单,撤单成功后推送该委托信息
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxEntrustCancelled 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int BusinessTime { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号(撤单委托)
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 原委托编号(被撤委托)
        /// </summary>
        public int CancelEntrustNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 交易实例编号(不涉及交易实例时,交易实例编号为空.)
        /// </summary>
        public string InstanceNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 撤销数量
        /// </summary>
        public int CancelAmount { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustStatus"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustStatus { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        public static UfxEntrustCancelled ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxEntrustCancelled[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxEntrustCancelled>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxEntrustCancelled();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BusinessTime = result.GetInt("business_time");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.CancelEntrustNo = result.GetInt("cancel_entrust_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.InstanceNo = result.GetStr("instance_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.CancelAmount = result.GetInt("cancel_amount");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.EntrustStatus = result.GetChar("entrust_status");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: f
    /// 功能名称: 对某条委托进行撤单,撤单失败后推送该委托信息
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxEntrustCancelRejected 
    {
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号(撤单委托)
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 原委托编号(被撤委托)
        /// </summary>
        public int CancelEntrustNo { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustStatus"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustStatus { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 废单原因
        /// </summary>
        public string RevokeCause { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        public static UfxEntrustCancelRejected ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxEntrustCancelRejected[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxEntrustCancelRejected>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxEntrustCancelRejected();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.CancelEntrustNo = result.GetInt("cancel_entrust_no");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.EntrustStatus = result.GetChar("entrust_status");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.RevokeCause = result.GetStr("revoke_cause");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: g
    /// 功能名称: 委托有成交,成交处理完成后推送成交信息
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxEntrustTrade 
    {
        /// <summary>
        /// 成交日期
        /// </summary>
        public int DealDate { get; private set; }
        /// <summary>
        /// 成交时间
        /// </summary>
        public int DealTime { get; private set; }
        /// <summary>
        /// 成交编号
        /// </summary>
        public string DealNo { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 交易实例编号(不涉及交易实例时,交易实例编号为空.)
        /// </summary>
        public string InstanceNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustStatus"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustStatus { get; private set; }
        /// <summary>
        /// 本次成交数量
        /// </summary>
        public int DealAmount { get; private set; }
        /// <summary>
        /// 本次成交价格
        /// </summary>
        public double DealPrice { get; private set; }
        /// <summary>
        /// 本次成交金额
        /// </summary>
        public double DealBalance { get; private set; }
        /// <summary>
        /// 本次费用
        /// </summary>
        public double DealFee { get; private set; }
        /// <summary>
        /// 累计成交数量
        /// </summary>
        public int TotalDealAmount { get; private set; }
        /// <summary>
        /// 累计成交金额
        /// </summary>
        public double TotalDealBalance { get; private set; }
        /// <summary>
        /// 撤销数量
        /// </summary>
        public int CancelAmount { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 平仓类型(用于期货的平仓业务;0:开仓;1:普通平仓;2:强制平仓;3:到期交割;4:平昨仓;5:平今仓)
        /// </summary>
        public sbyte CloseType { get; private set; }
        /// <summary>
        /// 申报方向(KB:实物成份股买;;KS:实物成份股卖;;ZB:现金替代买;;ZS:现金替代卖;;其他值无效;仅对ETF业务有效,其他业务无效)
        /// </summary>
        public string ReportDirection { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        public static UfxEntrustTrade ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxEntrustTrade[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxEntrustTrade>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxEntrustTrade();
                    data.Add(item);
                    item.DealDate = result.GetInt("deal_date");
                    item.DealTime = result.GetInt("deal_time");
                    item.DealNo = result.GetStr("deal_no");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.InstanceNo = result.GetStr("instance_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.EntrustStatus = result.GetChar("entrust_status");
                    item.DealAmount = result.GetInt("deal_amount");
                    item.DealPrice = result.GetDouble("deal_price");
                    item.DealBalance = result.GetDouble("deal_balance");
                    item.DealFee = result.GetDouble("deal_fee");
                    item.TotalDealAmount = result.GetInt("total_deal_amount");
                    item.TotalDealBalance = result.GetDouble("total_deal_balance");
                    item.CancelAmount = result.GetInt("cancel_amount");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.CloseType = result.GetChar("close_type");
                    item.ReportDirection = result.GetStr("report_direction");
                    item.InvestType = result.GetChar("invest_type");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: h
    /// 功能名称: 委托下达成功后推送本条委托信息(支持深圳股票期权做市\股转做市业务)
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxCombiEntrustReceived 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int BusinessTime { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报编号,和晚上清算流水)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType { get; private set; }
        /// <summary>
        /// 买入开平方向 ('1'-开仓;'2'-平仓.)
        /// </summary>
        public sbyte BuyDirection { get; private set; }
        /// <summary>
        /// 买入价格
        /// </summary>
        public double BuyPrice { get; private set; }
        /// <summary>
        /// 买入数量
        /// </summary>
        public int BuyAmount { get; private set; }
        /// <summary>
        /// 卖出开平方向 ('1'-开仓;'2'-平仓.)
        /// </summary>
        public sbyte SellDirection { get; private set; }
        /// <summary>
        /// 卖出价格
        /// </summary>
        public double SellPrice { get; private set; }
        /// <summary>
        /// 卖出数量
        /// </summary>
        public int SellAmount { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        public static UfxCombiEntrustReceived ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxCombiEntrustReceived[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxCombiEntrustReceived>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxCombiEntrustReceived();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BusinessTime = result.GetInt("business_time");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ReportNo = result.GetStr("report_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.PriceType = result.GetChar("price_type");
                    item.BuyDirection = result.GetChar("buy_direction");
                    item.BuyPrice = result.GetDouble("buy_price");
                    item.BuyAmount = result.GetInt("buy_amount");
                    item.SellDirection = result.GetChar("sell_direction");
                    item.SellPrice = result.GetDouble("sell_price");
                    item.SellAmount = result.GetInt("sell_amount");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: i
    /// 功能名称: 委托确认后推送本条委托信息(支持深圳股票期权做市\股转做市业务)
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxCombiEntrustConfirmed 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int BusinessTime { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType { get; private set; }
        /// <summary>
        /// 买入开平方向 ('1'-开仓;'2'-平仓.)
        /// </summary>
        public sbyte BuyDirection { get; private set; }
        /// <summary>
        /// 买入价格
        /// </summary>
        public double BuyPrice { get; private set; }
        /// <summary>
        /// 买入数量
        /// </summary>
        public int BuyAmount { get; private set; }
        /// <summary>
        /// 卖出开平方向 ('1'-开仓;'2'-平仓.)
        /// </summary>
        public sbyte SellDirection { get; private set; }
        /// <summary>
        /// 卖出价格
        /// </summary>
        public double SellPrice { get; private set; }
        /// <summary>
        /// 卖出数量
        /// </summary>
        public int SellAmount { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 委托确认号
        /// </summary>
        public string ConfirmNo { get; private set; }
        public static UfxCombiEntrustConfirmed ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxCombiEntrustConfirmed[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxCombiEntrustConfirmed>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxCombiEntrustConfirmed();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BusinessTime = result.GetInt("business_time");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.PriceType = result.GetChar("price_type");
                    item.BuyDirection = result.GetChar("buy_direction");
                    item.BuyPrice = result.GetDouble("buy_price");
                    item.BuyAmount = result.GetInt("buy_amount");
                    item.SellDirection = result.GetChar("sell_direction");
                    item.SellPrice = result.GetDouble("sell_price");
                    item.SellAmount = result.GetInt("sell_amount");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.ConfirmNo = result.GetStr("confirm_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: j
    /// 功能名称: 支持深圳股票期权做市\股转做市业务
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxCombiEntrustRejected 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 废单原因
        /// </summary>
        public string RevokeCause { get; private set; }
        public static UfxCombiEntrustRejected ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxCombiEntrustRejected[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxCombiEntrustRejected>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxCombiEntrustRejected();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.RevokeCause = result.GetStr("revoke_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: k
    /// 功能名称: 对某条委托进行撤单后推送该条委托信息(支持深圳股票期权做市\股转做市业务)
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxCombiEntrustCancel 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托批号(撤单委托和被撤委托用相同委托批号)
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号(撤单委托)
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 委托编号(被撤委托)
        /// </summary>
        public int CancelEntrustNo { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 撤单原因
        /// </summary>
        public string RevokeCause { get; private set; }
        public static UfxCombiEntrustCancel ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxCombiEntrustCancel[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxCombiEntrustCancel>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxCombiEntrustCancel();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.CancelEntrustNo = result.GetInt("cancel_entrust_no");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.RevokeCause = result.GetStr("revoke_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: l
    /// 功能名称: 对某条委托进行撤单,撤单成功后推送该委托信息(支持深圳股票期权做市\股转做市业务)
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxCombiEntrustCancelled 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号(撤单委托)
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 原委托编号(被撤委托)
        /// </summary>
        public int CancelEntrustNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 买入开平方向 ('1'-开仓;'2'-平仓.)
        /// </summary>
        public sbyte BuyDirection { get; private set; }
        /// <summary>
        /// 买入数量
        /// </summary>
        public int BuyAmount { get; private set; }
        /// <summary>
        /// 买入方向撤单数量
        /// </summary>
        public int BuyCancelAmount { get; private set; }
        /// <summary>
        /// 卖出开平方向 ('1'-开仓;'2'-平仓.)
        /// </summary>
        public sbyte SellDirection { get; private set; }
        /// <summary>
        /// 卖出数量
        /// </summary>
        public int SellAmount { get; private set; }
        /// <summary>
        /// 卖出方向撤单数量
        /// </summary>
        public int SellCancelAmount { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        public static UfxCombiEntrustCancelled ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxCombiEntrustCancelled[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxCombiEntrustCancelled>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxCombiEntrustCancelled();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.CancelEntrustNo = result.GetInt("cancel_entrust_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.BuyDirection = result.GetChar("buy_direction");
                    item.BuyAmount = result.GetInt("buy_amount");
                    item.BuyCancelAmount = result.GetInt("buy_cancel_amount");
                    item.SellDirection = result.GetChar("sell_direction");
                    item.SellAmount = result.GetInt("sell_amount");
                    item.SellCancelAmount = result.GetInt("sell_cancel_amount");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: m
    /// 功能名称: 对某条委托进行撤单,撤单失败后推送该委托信息(支持深圳股票期权做市\股转做市业务)
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxCombiEntrustCancelRejected 
    {
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号(撤单委托)
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 原委托编号(被撤委托)
        /// </summary>
        public int CancelEntrustNo { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 废单原因
        /// </summary>
        public string RevokeCause { get; private set; }
        public static UfxCombiEntrustCancelRejected ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxCombiEntrustCancelRejected[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxCombiEntrustCancelRejected>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxCombiEntrustCancelRejected();
                    data.Add(item);
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.CancelEntrustNo = result.GetInt("cancel_entrust_no");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.RevokeCause = result.GetStr("revoke_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: n
    /// 功能名称: 上交所股票期权组合保证金委托下达成功后推送本条委托信息
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxCombiOptionsEntrustReceived 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int BusinessTime { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报编号,和晚上清算流水)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 组合方向(B-组合,C-拆分,D-转备兑,E-备兑转保证金)
        /// </summary>
        public sbyte CombiDirection { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 组合策略代码
        /// </summary>
        public string CombistrategyCode { get; private set; }
        /// <summary>
        /// 组合策略持仓编号
        /// </summary>
        public string CombistrategyId { get; private set; }
        /// <summary>
        /// 证券代码1
        /// </summary>
        public string StockCode1 { get; private set; }
        /// <summary>
        /// 证券代码2
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 证券代码3
        /// </summary>
        public string StockCode3 { get; private set; }
        /// <summary>
        /// 证券代码4
        /// </summary>
        public string StockCode4 { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        public static UfxCombiOptionsEntrustReceived ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxCombiOptionsEntrustReceived[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxCombiOptionsEntrustReceived>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxCombiOptionsEntrustReceived();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BusinessTime = result.GetInt("business_time");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ReportNo = result.GetStr("report_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.CombiDirection = result.GetChar("combi_direction");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.CombistrategyCode = result.GetStr("combistrategy_code");
                    item.CombistrategyId = result.GetStr("combistrategy_id");
                    item.StockCode1 = result.GetStr("stock_code1");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.StockCode3 = result.GetStr("stock_code3");
                    item.StockCode4 = result.GetStr("stock_code4");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: o
    /// 功能名称: 上交所股票期权组合保证金委托确认成功后推送本条委托信息
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxCombiOptionsEntrustConfirmed 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int BusinessTime { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 组合方向(B-组合,C-拆分,D-转备兑,E-备兑转保证金)
        /// </summary>
        public sbyte CombiDirection { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 组合策略代码
        /// </summary>
        public string CombistrategyCode { get; private set; }
        /// <summary>
        /// 组合策略持仓编号
        /// </summary>
        public string CombistrategyId { get; private set; }
        /// <summary>
        /// 证券代码1
        /// </summary>
        public string StockCode1 { get; private set; }
        /// <summary>
        /// 证券代码2
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 证券代码3
        /// </summary>
        public string StockCode3 { get; private set; }
        /// <summary>
        /// 证券代码4
        /// </summary>
        public string StockCode4 { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 委托确认号
        /// </summary>
        public string ConfirmNo { get; private set; }
        public static UfxCombiOptionsEntrustConfirmed ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxCombiOptionsEntrustConfirmed[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxCombiOptionsEntrustConfirmed>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxCombiOptionsEntrustConfirmed();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BusinessTime = result.GetInt("business_time");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.CombiDirection = result.GetChar("combi_direction");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.CombistrategyCode = result.GetStr("combistrategy_code");
                    item.CombistrategyId = result.GetStr("combistrategy_id");
                    item.StockCode1 = result.GetStr("stock_code1");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.StockCode3 = result.GetStr("stock_code3");
                    item.StockCode4 = result.GetStr("stock_code4");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.ConfirmNo = result.GetStr("confirm_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: p
    /// 功能名称: 上交所股票期权组合保证金委托废单
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxCombiOptionsEntrustRejected 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 废单原因
        /// </summary>
        public string RevokeCause { get; private set; }
        public static UfxCombiOptionsEntrustRejected ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxCombiOptionsEntrustRejected[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxCombiOptionsEntrustRejected>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxCombiOptionsEntrustRejected();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.RevokeCause = result.GetStr("revoke_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: q
    /// 功能名称: 上交所股票期权组合委托有成交,成交处理完成后推送成交信息
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxCombiOptionsEntrustTrade 
    {
        /// <summary>
        /// 成交日期
        /// </summary>
        public int DealDate { get; private set; }
        /// <summary>
        /// 成交时间
        /// </summary>
        public int DealTime { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 组合方向(B-组合,C-拆分,D-转备兑,E-备兑转保证金)
        /// </summary>
        public sbyte CombiDirection { get; private set; }
        /// <summary>
        /// 组合策略代码
        /// </summary>
        public string CombistrategyCode { get; private set; }
        /// <summary>
        /// 组合策略持仓编号
        /// </summary>
        public string CombistrategyId { get; private set; }
        /// <summary>
        /// 证券代码1
        /// </summary>
        public string StockCode1 { get; private set; }
        /// <summary>
        /// 证券代码2
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 证券代码3
        /// </summary>
        public string StockCode3 { get; private set; }
        /// <summary>
        /// 证券代码4
        /// </summary>
        public string StockCode4 { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 成交数量
        /// </summary>
        public int DealAmount { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        public static UfxCombiOptionsEntrustTrade ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxCombiOptionsEntrustTrade[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxCombiOptionsEntrustTrade>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxCombiOptionsEntrustTrade();
                    data.Add(item);
                    item.DealDate = result.GetInt("deal_date");
                    item.DealTime = result.GetInt("deal_time");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.CombiDirection = result.GetChar("combi_direction");
                    item.CombistrategyCode = result.GetStr("combistrategy_code");
                    item.CombistrategyId = result.GetStr("combistrategy_id");
                    item.StockCode1 = result.GetStr("stock_code1");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.StockCode3 = result.GetStr("stock_code3");
                    item.StockCode4 = result.GetStr("stock_code4");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.DealAmount = result.GetInt("deal_amount");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: r
    /// 功能名称: 上交所股票期权组合保证金委托撤成 
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxCombiOptionsEntrustCancelled 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号(撤单委托)
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 原委托编号(被撤委托)
        /// </summary>
        public int CancelEntrustNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 组合策略代码
        /// </summary>
        public string CombistrategyCode { get; private set; }
        /// <summary>
        /// 组合策略编号
        /// </summary>
        public string CombistrategyId { get; private set; }
        /// <summary>
        /// 证券代码1
        /// </summary>
        public string StockCode1 { get; private set; }
        /// <summary>
        /// 证券代码2
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 证券代码3
        /// </summary>
        public string StockCode3 { get; private set; }
        /// <summary>
        /// 证券代码4
        /// </summary>
        public string StockCode4 { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 组合方向(B-组合,C-拆分,D-转备兑,E-备兑转保证金)
        /// </summary>
        public sbyte CombiDirection { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 撤销数量
        /// </summary>
        public int CancelAmount { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        public static UfxCombiOptionsEntrustCancelled ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxCombiOptionsEntrustCancelled[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxCombiOptionsEntrustCancelled>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxCombiOptionsEntrustCancelled();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.CancelEntrustNo = result.GetInt("cancel_entrust_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.CombistrategyCode = result.GetStr("combistrategy_code");
                    item.CombistrategyId = result.GetStr("combistrategy_id");
                    item.StockCode1 = result.GetStr("stock_code1");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.StockCode3 = result.GetStr("stock_code3");
                    item.StockCode4 = result.GetStr("stock_code4");
                    item.MarketNo = result.GetStr("market_no");
                    item.CombiDirection = result.GetChar("combi_direction");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.CancelAmount = result.GetInt("cancel_amount");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: s
    /// 功能名称: 需要审批的委托,下达后状态为待审批,审批通过后状态为未报.支持审批拒绝.
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxEntrustApproving 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int BusinessTime { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报编号,和晚上清算流水)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 委托价格
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 审批顺序(目前需要审批的步骤,1:第一级审批人员;999:最后一级审批人员.)
        /// </summary>
        public int ApproveOrder { get; private set; }
        /// <summary>
        /// 审批结果(2-审批拒绝;3-待审批)
        /// </summary>
        public sbyte ApproveResult { get; private set; }
        public static UfxEntrustApproving ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxEntrustApproving[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxEntrustApproving>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxEntrustApproving();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BusinessTime = result.GetInt("business_time");
                    item.ReportNo = result.GetStr("report_no");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.PriceType = result.GetChar("price_type");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.ApproveOrder = result.GetInt("approve_order");
                    item.ApproveResult = result.GetChar("approve_result");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: u
    /// 功能名称: 需要审批的撤单委托,下达后状态为待审批.
    /// 业务范围: 公用
    /// </summary>
    public sealed class UfxEntrustCancelApproving 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报编号,和晚上清算流水)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号(撤单委托)
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 原委托编号(被撤委托)
        /// </summary>
        public int CancelEntrustNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 委托价格
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 审批顺序(目前需要审批的步骤,1:第一级审批人员;999:最后一级审批人员.)
        /// </summary>
        public int ApproveOrder { get; private set; }
        /// <summary>
        /// 审批结果(2-审批拒绝;3-待审批)
        /// </summary>
        public sbyte ApproveResult { get; private set; }
        public static UfxEntrustCancelApproving ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxEntrustCancelApproving[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxEntrustCancelApproving>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxEntrustCancelApproving();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.ReportNo = result.GetStr("report_no");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.CancelEntrustNo = result.GetInt("cancel_entrust_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.PriceType = result.GetChar("price_type");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.ApproveOrder = result.GetInt("approve_order");
                    item.ApproveResult = result.GetChar("approve_result");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: v
    /// 功能名称: 委托下达成功后推送本条委托信息
    /// 业务范围: 期权
    /// </summary>
    public sealed class UfxCombiFutureOptionsEntrustReceived 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int BusinessTime { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报编号,和晚上清算流水)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码(一腿代码)
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券代码2(二腿代码)
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType { get; private set; }
        /// <summary>
        /// 委托价格
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 特殊业务标志('7'-郑商所跨式组合单;'8'-郑商所宽跨式组合单)
        /// </summary>
        public sbyte SpecialFlag { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        public static UfxCombiFutureOptionsEntrustReceived ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxCombiFutureOptionsEntrustReceived[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxCombiFutureOptionsEntrustReceived>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxCombiFutureOptionsEntrustReceived();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BusinessTime = result.GetInt("business_time");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ReportNo = result.GetStr("report_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.PriceType = result.GetChar("price_type");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.SpecialFlag = result.GetChar("special_flag");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: w
    /// 功能名称: 委托确认后推送本条委托信息
    /// 业务范围: 期权
    /// </summary>
    public sealed class UfxCombiFutureOptionsEntrustConfirmed 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int BusinessTime { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码(一腿代码)
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券代码2(二腿代码)
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType { get; private set; }
        /// <summary>
        /// 委托价格
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 特殊业务标志('7'-郑商所跨式组合单;'8'-郑商所宽跨式组合单)
        /// </summary>
        public sbyte SpecialFlag { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 委托确认号
        /// </summary>
        public string ConfirmNo { get; private set; }
        public static UfxCombiFutureOptionsEntrustConfirmed ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxCombiFutureOptionsEntrustConfirmed[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxCombiFutureOptionsEntrustConfirmed>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxCombiFutureOptionsEntrustConfirmed();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BusinessTime = result.GetInt("business_time");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.PriceType = result.GetChar("price_type");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.SpecialFlag = result.GetChar("special_flag");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.ConfirmNo = result.GetStr("confirm_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: x
    /// 功能名称: 委托废单后推送本条废单消息
    /// 业务范围: 期权
    /// </summary>
    public sealed class UfxCombiFutureOptionsEntrustRejected 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码(一腿代码)
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券代码2(二腿代码)
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 撤单原因(废单原因)
        /// </summary>
        public string WithdrawCause { get; private set; }
        public static UfxCombiFutureOptionsEntrustRejected ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxCombiFutureOptionsEntrustRejected[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxCombiFutureOptionsEntrustRejected>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxCombiFutureOptionsEntrustRejected();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.WithdrawCause = result.GetStr("withdraw_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: y
    /// 功能名称: 对某条委托进行撤单,撤单成功后推送该委托信息
    /// 业务范围: 期权
    /// </summary>
    public sealed class UfxCombiFutureOptionsEntrustCancelled 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托批号(被撤委托)
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 原委托编号(被撤委托)
        /// </summary>
        public int CancelEntrustNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码(一腿代码)
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券代码2(二腿代码)
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 撤销数量
        /// </summary>
        public int CancelAmount { get; private set; }
        /// <summary>
        /// 委托价格
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 特殊业务标志('7'-郑商所跨式组合单;'8'-郑商所宽跨式组合单)
        /// </summary>
        public sbyte SpecialFlag { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        public static UfxCombiFutureOptionsEntrustCancelled ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxCombiFutureOptionsEntrustCancelled[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxCombiFutureOptionsEntrustCancelled>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxCombiFutureOptionsEntrustCancelled();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BatchNo = result.GetInt("batch_no");
                    item.CancelEntrustNo = result.GetInt("cancel_entrust_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.CancelAmount = result.GetInt("cancel_amount");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.SpecialFlag = result.GetChar("special_flag");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: z
    /// 功能名称: 需要审批的委托,下达后状态为待审批,审批通过后状态为未报.支持审批拒绝.
    /// 业务范围: 期权
    /// </summary>
    public sealed class UfxCombiFutureOptionsEntrustApproving 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int BusinessTime { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报编号,和晚上清算流水)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码(一腿代码)
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券代码2(二腿代码)
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 开平方向('1'-开仓;'2'-平仓;)
        /// </summary>
        public sbyte FuturesDirection { get; private set; }
        /// <summary>
        /// 委托价格类型(限定 <see cref="UfxPriceType"/> 中定义的常量)
        /// </summary>
        public sbyte PriceType { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 委托价格
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 审批顺序(目前需要审批的步骤,1:第一级审批人员;999:最后一级审批人员.)
        /// </summary>
        public int ApproveOrder { get; private set; }
        /// <summary>
        /// 审批结果(2-审批拒绝;3-待审批)
        /// </summary>
        public sbyte ApproveResult { get; private set; }
        /// <summary>
        /// 特殊业务标志('7'-郑商所跨式组合单;'8'-郑商所宽跨式组合单)
        /// </summary>
        public sbyte SpecialFlag { get; private set; }
        public static UfxCombiFutureOptionsEntrustApproving ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxCombiFutureOptionsEntrustApproving[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxCombiFutureOptionsEntrustApproving>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxCombiFutureOptionsEntrustApproving();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BusinessTime = result.GetInt("business_time");
                    item.ReportNo = result.GetStr("report_no");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.FuturesDirection = result.GetChar("futures_direction");
                    item.PriceType = result.GetChar("price_type");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.ApproveOrder = result.GetInt("approve_order");
                    item.ApproveResult = result.GetChar("approve_result");
                    item.SpecialFlag = result.GetChar("special_flag");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: A
    /// 功能名称: 委托下达成功后推送本条委托信息
    /// 业务范围: 期权
    /// </summary>
    public sealed class UfxShCombiExerciseEntrustReceived 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int BusinessTime { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报编号,和晚上清算流水)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码(一腿代码)
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券代码2(二腿代码)
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 委托价格(价差)
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        public static UfxShCombiExerciseEntrustReceived ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxShCombiExerciseEntrustReceived[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxShCombiExerciseEntrustReceived>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxShCombiExerciseEntrustReceived();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BusinessTime = result.GetInt("business_time");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.ReportNo = result.GetStr("report_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: B
    /// 功能名称: 委托确认后推送本条委托信息
    /// 业务范围: 期权
    /// </summary>
    public sealed class UfxShCombiExerciseEntrustConfirmed 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int BusinessTime { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码(一腿代码)
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券代码2(二腿代码)
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 委托价格(价差)
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 委托确认号
        /// </summary>
        public string ConfirmNo { get; private set; }
        public static UfxShCombiExerciseEntrustConfirmed ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxShCombiExerciseEntrustConfirmed[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxShCombiExerciseEntrustConfirmed>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxShCombiExerciseEntrustConfirmed();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BusinessTime = result.GetInt("business_time");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.ConfirmNo = result.GetStr("confirm_no");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: C
    /// 功能名称: 委托废单后推送本条废单消息
    /// 业务范围: 期权
    /// </summary>
    public sealed class UfxShCombiExerciseEntrustRejected 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码(一腿代码)
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券代码2(二腿代码)
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 撤单原因(废单原因)
        /// </summary>
        public string WithdrawCause { get; private set; }
        public static UfxShCombiExerciseEntrustRejected ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxShCombiExerciseEntrustRejected[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxShCombiExerciseEntrustRejected>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxShCombiExerciseEntrustRejected();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.WithdrawCause = result.GetStr("withdraw_cause");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: D
    /// 功能名称: 对某条委托进行撤单,撤单成功后推送该委托信息
    /// 业务范围: 期权
    /// </summary>
    public sealed class UfxShCombiExerciseEntrustCancelled 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托批号(被撤委托)
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 原委托编号(被撤委托)
        /// </summary>
        public int CancelEntrustNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码(一腿代码)
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券代码2(二腿代码)
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 撤销数量
        /// </summary>
        public int CancelAmount { get; private set; }
        /// <summary>
        /// 委托价格(价差)
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        public static UfxShCombiExerciseEntrustCancelled ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxShCombiExerciseEntrustCancelled[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxShCombiExerciseEntrustCancelled>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxShCombiExerciseEntrustCancelled();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BatchNo = result.GetInt("batch_no");
                    item.CancelEntrustNo = result.GetInt("cancel_entrust_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.CancelAmount = result.GetInt("cancel_amount");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: E
    /// 功能名称: 对某条委托进行撤单,撤单失败后推送该委托信息
    /// 业务范围: 期权
    /// </summary>
    public sealed class UfxShCombiExerciseEntrustCancelRejected 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托批号(被撤委托)
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 原委托编号(被撤委托)
        /// </summary>
        public int CancelEntrustNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码(一腿代码)
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券代码2(二腿代码)
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 撤销数量
        /// </summary>
        public int CancelAmount { get; private set; }
        /// <summary>
        /// 委托价格(价差)
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        public static UfxShCombiExerciseEntrustCancelRejected ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxShCombiExerciseEntrustCancelRejected[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxShCombiExerciseEntrustCancelRejected>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxShCombiExerciseEntrustCancelRejected();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BatchNo = result.GetInt("batch_no");
                    item.CancelEntrustNo = result.GetInt("cancel_entrust_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.CancelAmount = result.GetInt("cancel_amount");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: F
    /// 功能名称: 需要审批的委托,下达后状态为待审批,审批通过后状态为未报.支持审批拒绝.
    /// 业务范围: 期权
    /// </summary>
    public sealed class UfxShCombiExerciseEntrustApproving 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托时间(HHMMSS格式)
        /// </summary>
        public int BusinessTime { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报编号,和晚上清算流水)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccountCode { get; private set; }
        /// <summary>
        /// 组合编号
        /// </summary>
        public string CombiNo { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码(一腿代码)
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券代码2(二腿代码)
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 委托价格(差价)
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 审批顺序(目前需要审批的步骤,1:第一级审批人员;999:最后一级审批人员.)
        /// </summary>
        public int ApproveOrder { get; private set; }
        /// <summary>
        /// 审批结果(2-审批拒绝;3-待审批)
        /// </summary>
        public sbyte ApproveResult { get; private set; }
        public static UfxShCombiExerciseEntrustApproving ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxShCombiExerciseEntrustApproving[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxShCombiExerciseEntrustApproving>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxShCombiExerciseEntrustApproving();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BusinessTime = result.GetInt("business_time");
                    item.ReportNo = result.GetStr("report_no");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.AccountCode = result.GetStr("account_code");
                    item.CombiNo = result.GetStr("combi_no");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.ApproveOrder = result.GetInt("approve_order");
                    item.ApproveResult = result.GetChar("approve_result");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: G
    /// 功能名称: 委托撤单
    /// 业务范围: 期权
    /// </summary>
    public sealed class UfxShCombiExerciseEntrustCancel 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 委托批号(撤单委托和被撤委托用相同委托批号)
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号(撤单委托)
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 委托编号(被撤委托)
        /// </summary>
        public int CancelEntrustNo { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 撤单原因
        /// </summary>
        public string RevokeCause { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券代码2
        /// </summary>
        public string StockCode2 { get; private set; }
        public static UfxShCombiExerciseEntrustCancel ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxShCombiExerciseEntrustCancel[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxShCombiExerciseEntrustCancel>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxShCombiExerciseEntrustCancel();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.CancelEntrustNo = result.GetInt("cancel_entrust_no");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.RevokeCause = result.GetStr("revoke_cause");
                    item.MarketNo = result.GetStr("market_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockCode2 = result.GetStr("stock_code2");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
    /// <summary>
    /// 功能标识: H
    /// 功能名称: 需要审批的撤单委托,下达后状态为待审批,审批通过后状态为未报.支持审批拒绝.
    /// 业务范围: 期权
    /// </summary>
    public sealed class UfxShCombiExerciseCancelApproving 
    {
        /// <summary>
        /// 委托日期(YYYYMMDD格式)
        /// </summary>
        public int BusinessDate { get; private set; }
        /// <summary>
        /// 申报编号(委托申报到交易所时的申报编号,和晚上清算流水)
        /// </summary>
        public string ReportNo { get; private set; }
        /// <summary>
        /// 委托批号
        /// </summary>
        public int BatchNo { get; private set; }
        /// <summary>
        /// 委托编号(撤单委托)
        /// </summary>
        public int EntrustNo { get; private set; }
        /// <summary>
        /// 原委托编号(被撤委托)
        /// </summary>
        public int CancelEntrustNo { get; private set; }
        /// <summary>
        /// 证券代码
        /// </summary>
        public string StockCode { get; private set; }
        /// <summary>
        /// 证券代码2
        /// </summary>
        public string StockCode2 { get; private set; }
        /// <summary>
        /// 股东代码
        /// </summary>
        public string StockholderId { get; private set; }
        /// <summary>
        /// 申报席位
        /// </summary>
        public string ReportSeat { get; private set; }
        /// <summary>
        /// 交易市场(限定 <see cref="UfxMarketNo"/> 中定义的常量)
        /// </summary>
        public string MarketNo { get; private set; }
        /// <summary>
        /// 委托方向(限定 <see cref="UfxEntrustDirection"/> 中定义的常量)
        /// </summary>
        public string EntrustDirection { get; private set; }
        /// <summary>
        /// 委托数量
        /// </summary>
        public int EntrustAmount { get; private set; }
        /// <summary>
        /// 委托价格
        /// </summary>
        public double EntrustPrice { get; private set; }
        /// <summary>
        /// 投资类型(限定 <see cref="UfxInvestType"/> 中定义的常量)
        /// </summary>
        public sbyte InvestType { get; private set; }
        /// <summary>
        /// 委托状态(限定 <see cref="UfxEntrustState"/> 中定义的常量)
        /// </summary>
        public sbyte EntrustState { get; private set; }
        /// <summary>
        /// 第三方系统自定义号(外部系统委托号.)
        /// </summary>
        public int ExtsystemId { get; private set; }
        /// <summary>
        /// 第三方系统自定义说明
        /// </summary>
        public string ThirdReff { get; private set; }
        /// <summary>
        /// 审批顺序(目前需要审批的步骤,1:第一级审批人员;999:最后一级审批人员.)
        /// </summary>
        public int ApproveOrder { get; private set; }
        /// <summary>
        /// 审批结果(2-审批拒绝;3-待审批)
        /// </summary>
        public sbyte ApproveResult { get; private set; }
        public static UfxShCombiExerciseCancelApproving ReadOne(CT2UnPacker result, int dataIndex = 0)
        {
            var data = ReadAll(result, dataIndex, true);
            if (data != null && data.Length > 0)
            {
                return data[0];
            }
            return null;
        }

        public static UfxShCombiExerciseCancelApproving[] ReadAll(CT2UnPacker result, int dataIndex = 0, bool firstOnly = false)
        {
            var data = new List<UfxShCombiExerciseCancelApproving>();
            if (result != null){
                result.SetCurrentDatasetByIndex(dataIndex);
                while (result.IsEOF() == 0) {
                    var item = new UfxShCombiExerciseCancelApproving();
                    data.Add(item);
                    item.BusinessDate = result.GetInt("business_date");
                    item.ReportNo = result.GetStr("report_no");
                    item.BatchNo = result.GetInt("batch_no");
                    item.EntrustNo = result.GetInt("entrust_no");
                    item.CancelEntrustNo = result.GetInt("cancel_entrust_no");
                    item.StockCode = result.GetStr("stock_code");
                    item.StockCode2 = result.GetStr("stock_code2");
                    item.StockholderId = result.GetStr("stockholder_id");
                    item.ReportSeat = result.GetStr("report_seat");
                    item.MarketNo = result.GetStr("market_no");
                    item.EntrustDirection = result.GetStr("entrust_direction");
                    item.EntrustAmount = result.GetInt("entrust_amount");
                    item.EntrustPrice = result.GetDouble("entrust_price");
                    item.InvestType = result.GetChar("invest_type");
                    item.EntrustState = result.GetChar("entrust_state");
                    item.ExtsystemId = result.GetInt("extsystem_id");
                    item.ThirdReff = result.GetStr("third_reff");
                    item.ApproveOrder = result.GetInt("approve_order");
                    item.ApproveResult = result.GetChar("approve_result");
                        if (firstOnly)
                    {
                        break;
                    }
                }
            }
            return data.ToArray();
        }
    }
}
