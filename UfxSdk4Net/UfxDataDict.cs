
namespace QuantBox.XApi
{
    /// <summary>
    /// UFX功能消息名称
    /// </summary>
    public static class UfxNames
    {
        /// <summary>
        /// UFX功能名称
        /// </summary>    
        public static string GetFunctionName(int functionId)
        {
            switch(functionId)
            {
                case 10000:
                    return "心跳";
                case 10001:
                    return "登录";
                case 10002:
                    return "退出登录";
                case 10003:
                    return "密码修改";
                case 30001:
                    return "账户查询";
                case 30002:
                    return "资产单元查询";
                case 30003:
                    return "组合查询";
                case 30004:
                    return "交易股东查询";
                case 30005:
                    return "股东查询";
                case 30007:
                    return "账户清算状态查询";
                case 35003:
                    return "账户资产查询";
                case 35010:
                    return "账户资产查询";
                case 35011:
                    return "资产单元资产查询";
                case 35024:
                    return "资产单元资产查询(新)";
                case 35025:
                    return "期货账户盈亏查询";
                case 35012:
                    return "清算流水查询";
                case 36012:
                    return "历史清算流水查询";
                case 35013:
                    return "保证金比例查询";
                case 35015:
                    return "资金调整";
                case 35017:
                    return "资金冻结解冻";
                case 35018:
                    return "取消资金冻结解冻";
                case 35019:
                    return "资金冻结解冻明细查询";
                case 35021:
                    return "资金划转";
                case 35022:
                    return "证券划转";
                case 91001:
                    return "普通买卖委托";
                case 91011:
                    return "股转做市委托";
                case 91115:
                    return "股转做市委托撤单（按委托序号）(新)";
                case 91113:
                    return "股转做市委托撤单（按委托序号）";
                case 91090:
                    return "篮子委托";
                case 91114:
                    return "委托撤单(新)";
                case 91101:
                    return "委托撤单";
                case 91102:
                    return "委托撤单（按委托批号撤单）";
                case 31001:
                    return "证券持仓查询";
                case 31002:
                    return "质押债券明细查询";
                case 30011:
                    return "证券信息查询";
                case 32001:
                    return "证券委托查询";
                case 32101:
                    return "证券历史委托查询";
                case 32006:
                    return "股转做市委托查询";
                case 33001:
                    return "证券成交查询";
                case 33101:
                    return "证券历史成交查询";
                case 34001:
                    return "账户资金查询";
                case 91051:
                    return "股转市场协议转让委托";
                case 91116:
                    return "股转市场协议转让委托撤单(新)";
                case 91151:
                    return "股转市场协议转让委托撤单";
                case 91003:
                    return "基金申赎";
                case 91008:
                    return "基金申赎委托";
                case 32002:
                    return "基金委托查询";
                case 32005:
                    return "ETF申赎委托明细查询";
                case 33002:
                    return "基金成交查询";
                case 33005:
                    return "ETF申赎成交明细查询";
                case 35014:
                    return "ETF成份股信息查询";
                case 35020:
                    return "ETF基础信息查询";
                case 30010:
                    return "期货信息查询";
                case 91004:
                    return "期货委托";
                case 91013:
                    return "商品期货组合单委托";
                case 91119:
                    return "期货委托撤单(新)";
                case 91105:
                    return "期货委托撤单";
                case 91121:
                    return "商品期货组合单委托撤单(新)";
                case 91107:
                    return "商品期货组合单委托撤单";
                case 31003:
                    return "期货持仓查询";
                case 31013:
                    return "期货持仓明细查询";
                case 32003:
                    return "期货委托查询";
                case 32103:
                    return "期货历史委托查询";
                case 32008:
                    return "商品期货组合委托查询";
                case 33003:
                    return "期货成交查询";
                case 33103:
                    return "期货历史成交查询";
                case 34003:
                    return "期货保证金账户查询";
                case 35023:
                    return "期货费率查询";
                case 30012:
                    return "期权信息查询";
                case 91005:
                    return "期权委托";
                case 91006:
                    return "备兑锁定与解锁";
                case 91007:
                    return "期权行权";
                case 91025:
                    return "上交所股票期权合并行权";
                case 91126:
                    return "股票期权合并行权撤单";
                case 32017:
                    return "上交所合并行权委托查询";
                case 91012:
                    return "股指期权做市委托";
                case 91014:
                    return "期权做市合笔委托";
                case 91091:
                    return "期权篮子委托";
                case 91016:
                    return "上交所股票期权询价委托";
                case 91017:
                    return "上交所股票期权回应报价委托";
                case 91120:
                    return "期权委托撤单(新)";
                case 91106:
                    return "期权委托撤单";
                case 91108:
                    return "股指期权做市委托撤单";
                case 91122:
                    return "期权做市合笔委托撤单(新)";
                case 91109:
                    return "期权做市合笔委托撤单";
                case 91123:
                    return "期权行权撤单(新)";
                case 91111:
                    return "期权行权撤单";
                case 91112:
                    return "期权行权撤单(按委托批号撤单)";
                case 31004:
                    return "期权持仓查询";
                case 32004:
                    return "期权委托查询";
                case 32007:
                    return "期权做市委托查询";
                case 33004:
                    return "期权成交查询";
                case 34004:
                    return "期权保证金账户查询";
                case 91015:
                    return "上交所股票期权组合保证金委托";
                case 31015:
                    return "上交所股票期权组合保证金持仓查询";
                case 32015:
                    return "上交所股票期权组合保证金委托查询";
                case 33015:
                    return "上交所股票期权组合保证金成交查询";
                case 91018:
                    return "商品期权套利单委托";
                case 32016:
                    return "商品期权套利单委托查询";
                case 31005:
                    return "多业务持仓查询";
                case 35008:
                    return "委托批号查询";
                default:
                    return "未知功能号";
            }              
        }
        /// <summary>
        /// UFX消息名称
        /// </summary>   
        public static string GetMessageName(sbyte msgType)
        {
            switch(msgType)
            {
                case (sbyte)'a':
                    return "委托下达";
                case (sbyte)'b':
                    return "委托确认";
                case (sbyte)'c':
                    return "委托废单";
                case (sbyte)'d':
                    return "委托撤单";
                case (sbyte)'e':
                    return "委托撤成";
                case (sbyte)'f':
                    return "委托撤废";
                case (sbyte)'g':
                    return "委托成交";
                case (sbyte)'h':
                    return "合笔委托下达";
                case (sbyte)'i':
                    return "合笔委托确认";
                case (sbyte)'j':
                    return "合笔委托废单";
                case (sbyte)'k':
                    return "合笔委托撤单";
                case (sbyte)'l':
                    return "合笔委托撤成";
                case (sbyte)'m':
                    return "合笔委托撤废";
                case (sbyte)'n':
                    return "股票期权组合保证金委托下达";
                case (sbyte)'o':
                    return "股票期权组合保证金委托确认";
                case (sbyte)'p':
                    return "股票期权组合保证金委托废单";
                case (sbyte)'q':
                    return "股票期权组合委托成交";
                case (sbyte)'r':
                    return "股票期权组合委托撤成";
                case (sbyte)'s':
                    return "委托待审批";
                case (sbyte)'u':
                    return "委托撤单待审批";
                case (sbyte)'v':
                    return "商品期权组合单委托下达";
                case (sbyte)'w':
                    return "商品期权组合单委托确认";
                case (sbyte)'x':
                    return "商品期权组合单委托废单";
                case (sbyte)'y':
                    return "商品期权组合单委托撤成";
                case (sbyte)'z':
                    return "商品期权组合单委托审批";
                case (sbyte)'A':
                    return "上交所合并行权委托下达";
                case (sbyte)'B':
                    return "上交所合并行权委托确认";
                case (sbyte)'C':
                    return "上交所合并行权委托废单";
                case (sbyte)'D':
                    return "上交所合并行权委托撤成";
                case (sbyte)'E':
                    return "上交所合并行权委托撤废";
                case (sbyte)'F':
                    return "上交所合并行权委托审批";
                case (sbyte)'G':
                    return "上交所合并行权委托撤单";
                case (sbyte)'H':
                    return "上交所合并行权撤单审批";
                default:
                    return "未知消息";
            }            
        }
    }

    /// <summary>
    /// UFX消息类型
    /// </summary>  
    public static class UfxMessageType
    {
        /// <summary>
        /// 委托下达(委托下达成功后推送本条委托信息)
        /// </summary>
        public const sbyte EntrustReceived = (sbyte)'a';
        /// <summary>
        /// 委托确认(委托确认后推送本条委托信息)
        /// </summary>
        public const sbyte EntrustConfirmed = (sbyte)'b';
        /// <summary>
        /// 委托废单()
        /// </summary>
        public const sbyte EntrustRejected = (sbyte)'c';
        /// <summary>
        /// 委托撤单(对某条委托进行撤单后推送该条委托信息)
        /// </summary>
        public const sbyte EntrustCancel = (sbyte)'d';
        /// <summary>
        /// 委托撤成(对某条委托进行撤单,撤单成功后推送该委托信息)
        /// </summary>
        public const sbyte EntrustCancelled = (sbyte)'e';
        /// <summary>
        /// 委托撤废(对某条委托进行撤单,撤单失败后推送该委托信息)
        /// </summary>
        public const sbyte EntrustCancelRejected = (sbyte)'f';
        /// <summary>
        /// 委托成交(委托有成交,成交处理完成后推送成交信息)
        /// </summary>
        public const sbyte EntrustTrade = (sbyte)'g';
        /// <summary>
        /// 合笔委托下达(委托下达成功后推送本条委托信息(支持深圳股票期权做市\股转做市业务))
        /// </summary>
        public const sbyte CombiEntrustReceived = (sbyte)'h';
        /// <summary>
        /// 合笔委托确认(委托确认后推送本条委托信息(支持深圳股票期权做市\股转做市业务))
        /// </summary>
        public const sbyte CombiEntrustConfirmed = (sbyte)'i';
        /// <summary>
        /// 合笔委托废单(支持深圳股票期权做市\股转做市业务)
        /// </summary>
        public const sbyte CombiEntrustRejected = (sbyte)'j';
        /// <summary>
        /// 合笔委托撤单(对某条委托进行撤单后推送该条委托信息(支持深圳股票期权做市\股转做市业务))
        /// </summary>
        public const sbyte CombiEntrustCancel = (sbyte)'k';
        /// <summary>
        /// 合笔委托撤成(对某条委托进行撤单,撤单成功后推送该委托信息(支持深圳股票期权做市\股转做市业务))
        /// </summary>
        public const sbyte CombiEntrustCancelled = (sbyte)'l';
        /// <summary>
        /// 合笔委托撤废(对某条委托进行撤单,撤单失败后推送该委托信息(支持深圳股票期权做市\股转做市业务))
        /// </summary>
        public const sbyte CombiEntrustCancelRejected = (sbyte)'m';
        /// <summary>
        /// 股票期权组合保证金委托下达(上交所股票期权组合保证金委托下达成功后推送本条委托信息)
        /// </summary>
        public const sbyte CombiOptionsEntrustReceived = (sbyte)'n';
        /// <summary>
        /// 股票期权组合保证金委托确认(上交所股票期权组合保证金委托确认成功后推送本条委托信息)
        /// </summary>
        public const sbyte CombiOptionsEntrustConfirmed = (sbyte)'o';
        /// <summary>
        /// 股票期权组合保证金委托废单(上交所股票期权组合保证金委托废单)
        /// </summary>
        public const sbyte CombiOptionsEntrustRejected = (sbyte)'p';
        /// <summary>
        /// 股票期权组合委托成交(上交所股票期权组合委托有成交,成交处理完成后推送成交信息)
        /// </summary>
        public const sbyte CombiOptionsEntrustTrade = (sbyte)'q';
        /// <summary>
        /// 股票期权组合委托撤成(上交所股票期权组合保证金委托撤成 )
        /// </summary>
        public const sbyte CombiOptionsEntrustCancelled = (sbyte)'r';
        /// <summary>
        /// 委托待审批(需要审批的委托,下达后状态为待审批,审批通过后状态为未报.支持审批拒绝.)
        /// </summary>
        public const sbyte EntrustApproving = (sbyte)'s';
        /// <summary>
        /// 委托撤单待审批(需要审批的撤单委托,下达后状态为待审批.)
        /// </summary>
        public const sbyte EntrustCancelApproving = (sbyte)'u';
        /// <summary>
        /// 商品期权组合单委托下达(委托下达成功后推送本条委托信息)
        /// </summary>
        public const sbyte CombiFutureOptionsEntrustReceived = (sbyte)'v';
        /// <summary>
        /// 商品期权组合单委托确认(委托确认后推送本条委托信息)
        /// </summary>
        public const sbyte CombiFutureOptionsEntrustConfirmed = (sbyte)'w';
        /// <summary>
        /// 商品期权组合单委托废单(委托废单后推送本条废单消息)
        /// </summary>
        public const sbyte CombiFutureOptionsEntrustRejected = (sbyte)'x';
        /// <summary>
        /// 商品期权组合单委托撤成(对某条委托进行撤单,撤单成功后推送该委托信息)
        /// </summary>
        public const sbyte CombiFutureOptionsEntrustCancelled = (sbyte)'y';
        /// <summary>
        /// 商品期权组合单委托审批(需要审批的委托,下达后状态为待审批,审批通过后状态为未报.支持审批拒绝.)
        /// </summary>
        public const sbyte CombiFutureOptionsEntrustApproving = (sbyte)'z';
        /// <summary>
        /// 上交所合并行权委托下达(委托下达成功后推送本条委托信息)
        /// </summary>
        public const sbyte ShCombiExerciseEntrustReceived = (sbyte)'A';
        /// <summary>
        /// 上交所合并行权委托确认(委托确认后推送本条委托信息)
        /// </summary>
        public const sbyte ShCombiExerciseEntrustConfirmed = (sbyte)'B';
        /// <summary>
        /// 上交所合并行权委托废单(委托废单后推送本条废单消息)
        /// </summary>
        public const sbyte ShCombiExerciseEntrustRejected = (sbyte)'C';
        /// <summary>
        /// 上交所合并行权委托撤成(对某条委托进行撤单,撤单成功后推送该委托信息)
        /// </summary>
        public const sbyte ShCombiExerciseEntrustCancelled = (sbyte)'D';
        /// <summary>
        /// 上交所合并行权委托撤废(对某条委托进行撤单,撤单失败后推送该委托信息)
        /// </summary>
        public const sbyte ShCombiExerciseEntrustCancelRejected = (sbyte)'E';
        /// <summary>
        /// 上交所合并行权委托审批(需要审批的委托,下达后状态为待审批,审批通过后状态为未报.支持审批拒绝.)
        /// </summary>
        public const sbyte ShCombiExerciseEntrustApproving = (sbyte)'F';
        /// <summary>
        /// 上交所合并行权委托撤单(委托撤单)
        /// </summary>
        public const sbyte ShCombiExerciseEntrustCancel = (sbyte)'G';
        /// <summary>
        /// 上交所合并行权撤单审批(需要审批的撤单委托,下达后状态为待审批,审批通过后状态为未报.支持审批拒绝.)
        /// </summary>
        public const sbyte ShCombiExerciseCancelApproving = (sbyte)'H';
    }
    /// <summary>
    /// 账户类型
    /// </summary>
    public sealed class UfxAccountType
    {
            /// <summary>
        /// 封闭式基金
        /// </summary>
        public const string V1 = "1";
            /// <summary>
        /// 开放式基金
        /// </summary>
        public const string V2 = "2";
            /// <summary>
        /// 社保基金
        /// </summary>
        public const string V3 = "3";
            /// <summary>
        /// 年金产品
        /// </summary>
        public const string V4 = "5";
            /// <summary>
        /// 专户产品
        /// </summary>
        public const string V5 = "6";
            /// <summary>
        /// 年金
        /// </summary>
        public const string V6 = "8";
            /// <summary>
        /// 专户理财
        /// </summary>
        public const string V7 = "9";
            /// <summary>
        /// 保险
        /// </summary>
        public const string V8 = "10";
            /// <summary>
        /// 一对多专户
        /// </summary>
        public const string V9 = "11";
            /// <summary>
        /// 定向理财
        /// </summary>
        public const string V10 = "12";
            /// <summary>
        /// 集合理财
        /// </summary>
        public const string V11 = "13";
            /// <summary>
        /// 自营
        /// </summary>
        public const string V12 = "14";
            /// <summary>
        /// 信托
        /// </summary>
        public const string V13 = "15";
            /// <summary>
        /// 私募
        /// </summary>
        public const string V14 = "16";
            /// <summary>
        /// 委托资产
        /// </summary>
        public const string V15 = "17";
        }
    /// <summary>
    /// 委托状态
    /// </summary>
    public sealed class UfxEntrustState
    {
            /// <summary>
        /// 未报
        /// </summary>
        public const sbyte V1 = (sbyte)'1';
            /// <summary>
        /// 待报
        /// </summary>
        public const sbyte V2 = (sbyte)'2';
            /// <summary>
        /// 正报
        /// </summary>
        public const sbyte V3 = (sbyte)'3';
            /// <summary>
        /// 已报
        /// </summary>
        public const sbyte V4 = (sbyte)'4';
            /// <summary>
        /// 废单
        /// </summary>
        public const sbyte V5 = (sbyte)'5';
            /// <summary>
        /// 部成
        /// </summary>
        public const sbyte V6 = (sbyte)'6';
            /// <summary>
        /// 已成
        /// </summary>
        public const sbyte V7 = (sbyte)'7';
            /// <summary>
        /// 部撤
        /// </summary>
        public const sbyte V8 = (sbyte)'8';
            /// <summary>
        /// 已撤
        /// </summary>
        public const sbyte V9 = (sbyte)'9';
            /// <summary>
        /// 待撤
        /// </summary>
        public const sbyte V10 = (sbyte)'a';
            /// <summary>
        /// 未审批
        /// </summary>
        public const sbyte V11 = (sbyte)'b';
            /// <summary>
        /// 审批拒绝
        /// </summary>
        public const sbyte V12 = (sbyte)'c';
            /// <summary>
        /// 未审批即撤销
        /// </summary>
        public const sbyte V13 = (sbyte)'d';
            /// <summary>
        /// 未撤(撤单委托)
        /// </summary>
        public const sbyte V14 = (sbyte)'A';
            /// <summary>
        /// 待撤(撤单委托)
        /// </summary>
        public const sbyte V15 = (sbyte)'B';
            /// <summary>
        /// 正撤(撤单委托)
        /// </summary>
        public const sbyte V16 = (sbyte)'C';
            /// <summary>
        /// 撤认(撤单委托)
        /// </summary>
        public const sbyte V17 = (sbyte)'D';
            /// <summary>
        /// 撤废(撤单委托)
        /// </summary>
        public const sbyte V18 = (sbyte)'E';
            /// <summary>
        /// 已撤(撤单委托)
        /// </summary>
        public const sbyte V19 = (sbyte)'F';
        }
    /// <summary>
    /// 交易市场
    /// </summary>
    public sealed class UfxMarketNo
    {
            /// <summary>
        /// 上交所
        /// </summary>
        public const string V1 = "1";
            /// <summary>
        /// 深交所
        /// </summary>
        public const string V2 = "2";
            /// <summary>
        /// 上期所
        /// </summary>
        public const string V3 = "3";
            /// <summary>
        /// 郑商所
        /// </summary>
        public const string V4 = "4";
            /// <summary>
        /// 场外
        /// </summary>
        public const string V5 = "6";
            /// <summary>
        /// 中金所
        /// </summary>
        public const string V6 = "7";
            /// <summary>
        /// 大商所
        /// </summary>
        public const string V7 = "9";
            /// <summary>
        /// 能源期货交易所
        /// </summary>
        public const string V8 = "k";
            /// <summary>
        /// 股转市场
        /// </summary>
        public const string V9 = "10";
            /// <summary>
        /// 港股通(沪)
        /// </summary>
        public const string V10 = "35";
            /// <summary>
        /// 港股通(深)
        /// </summary>
        public const string V11 = "o";
        }
    /// <summary>
    /// 投资类型
    /// </summary>
    public sealed class UfxInvestType
    {
            /// <summary>
        /// 不区分(期货)
        /// </summary>
        public const sbyte V1 = (sbyte)'0';
            /// <summary>
        /// 可交易
        /// </summary>
        public const sbyte V2 = (sbyte)'1';
            /// <summary>
        /// 持有到期
        /// </summary>
        public const sbyte V3 = (sbyte)'2';
            /// <summary>
        /// 可供出售
        /// </summary>
        public const sbyte V4 = (sbyte)'3';
            /// <summary>
        /// 贷款和应收款项
        /// </summary>
        public const sbyte V5 = (sbyte)'4';
            /// <summary>
        /// 投机(期货)
        /// </summary>
        public const sbyte V6 = (sbyte)'a';
            /// <summary>
        /// 套保(期货)
        /// </summary>
        public const sbyte V7 = (sbyte)'b';
            /// <summary>
        /// 套利(期货)
        /// </summary>
        public const sbyte V8 = (sbyte)'c';
        }
    /// <summary>
    /// 委托方向
    /// </summary>
    public sealed class UfxEntrustDirection
    {
            /// <summary>
        /// 买入
        /// </summary>
        public const string V1 = "1";
            /// <summary>
        /// 卖出
        /// </summary>
        public const string V2 = "2";
            /// <summary>
        /// 债券买入
        /// </summary>
        public const string V3 = "3";
            /// <summary>
        /// 债券卖出
        /// </summary>
        public const string V4 = "4";
            /// <summary>
        /// 融资(正)回购
        /// </summary>
        public const string V5 = "5";
            /// <summary>
        /// 融券(逆)回购
        /// </summary>
        public const string V6 = "6";
            /// <summary>
        /// 配股(配债)认购
        /// </summary>
        public const string V7 = "9";
            /// <summary>
        /// 债转股
        /// </summary>
        public const string V8 = "10";
            /// <summary>
        /// 债回售
        /// </summary>
        public const string V9 = "11";
            /// <summary>
        /// 申购
        /// </summary>
        public const string V10 = "12";
            /// <summary>
        /// 基金认购
        /// </summary>
        public const string V11 = "13";
            /// <summary>
        /// 转托管
        /// </summary>
        public const string V12 = "17";
            /// <summary>
        /// ETF申购
        /// </summary>
        public const string V13 = "26";
            /// <summary>
        /// ETF赎回
        /// </summary>
        public const string V14 = "27";
            /// <summary>
        /// 行权认购
        /// </summary>
        public const string V15 = "28";
            /// <summary>
        /// 行权认沽
        /// </summary>
        public const string V16 = "29";
            /// <summary>
        /// 提交质押
        /// </summary>
        public const string V17 = "30";
            /// <summary>
        /// 转回质押
        /// </summary>
        public const string V18 = "31";
            /// <summary>
        /// 沪深交易所融资融券展期
        /// </summary>
        public const string V19 = "32";
            /// <summary>
        /// 权利对冲设置
        /// </summary>
        public const string V20 = "46";
            /// <summary>
        /// 权利对冲取消
        /// </summary>
        public const string V21 = "47";
            /// <summary>
        /// 义务期货对冲设置
        /// </summary>
        public const string V22 = "48";
            /// <summary>
        /// 义务期货对冲取消
        /// </summary>
        public const string V23 = "49";
            /// <summary>
        /// 基金分拆
        /// </summary>
        public const string V24 = "50";
            /// <summary>
        /// 基金合并
        /// </summary>
        public const string V25 = "51";
            /// <summary>
        /// 开基申购
        /// </summary>
        public const string V26 = "53";
            /// <summary>
        /// 开基赎回
        /// </summary>
        public const string V27 = "54";
            /// <summary>
        /// 债券认购
        /// </summary>
        public const string V28 = "55";
            /// <summary>
        /// 保证券锁定(股票期权),担保品交存(融资融券)
        /// </summary>
        public const string V29 = "63";
            /// <summary>
        /// 保证券解锁(股票期权),担保品提取(融资融券)
        /// </summary>
        public const string V30 = "64";
            /// <summary>
        /// 融券卖出
        /// </summary>
        public const string V31 = "67";
            /// <summary>
        /// 买券还券
        /// </summary>
        public const string V32 = "68";
            /// <summary>
        /// 直接还款
        /// </summary>
        public const string V33 = "69";
            /// <summary>
        /// 直接还券
        /// </summary>
        public const string V34 = "70";
            /// <summary>
        /// 合并行权
        /// </summary>
        public const string V35 = "71";
            /// <summary>
        /// 融资买入
        /// </summary>
        public const string V36 = "75";
            /// <summary>
        /// 卖券还款
        /// </summary>
        public const string V37 = "76";
            /// <summary>
        /// 放弃行权(郑商所\大商所商品期权)
        /// </summary>
        public const string V38 = "83";
            /// <summary>
        /// 询价(上交所期权询价)
        /// </summary>
        public const string V39 = "84";
        }
    /// <summary>
    /// 价格类型
    /// </summary>
    public sealed class UfxPriceType
    {
            /// <summary>
        /// 限价
        /// </summary>
        public const sbyte V1 = (sbyte)'0';
            /// <summary>
        /// 任意价(期货,不支持中金所\上期所和能源期货交易所)
        /// </summary>
        public const sbyte V2 = (sbyte)'1';
            /// <summary>
        /// 市价剩余转限价(上交所股票期权)
        /// </summary>
        public const sbyte V3 = (sbyte)'2';
            /// <summary>
        /// 市价剩余撤消(上交所股票期权)
        /// </summary>
        public const sbyte V4 = (sbyte)'3';
            /// <summary>
        /// FOK限价(上交所股票期权)
        /// </summary>
        public const sbyte V5 = (sbyte)'4';
            /// <summary>
        /// FOK市价(上交所股票期权)
        /// </summary>
        public const sbyte V6 = (sbyte)'5';
            /// <summary>
        /// 五档即成剩撤(上交所市价)
        /// </summary>
        public const sbyte V7 = (sbyte)'a';
            /// <summary>
        /// 五档即成剩转(上交所市价)
        /// </summary>
        public const sbyte V8 = (sbyte)'b';
            /// <summary>
        /// 限价盘(零股)(港股通)
        /// </summary>
        public const sbyte V9 = (sbyte)'c';
            /// <summary>
        /// 竞价限价盘(港股通)
        /// </summary>
        public const sbyte V10 = (sbyte)'e';
            /// <summary>
        /// 增强限价盘(港股通)
        /// </summary>
        public const sbyte V11 = (sbyte)'g';
            /// <summary>
        /// 竞价限价盘FOK(港股通)
        /// </summary>
        public const sbyte V12 = (sbyte)'i';
            /// <summary>
        /// 增强限价盘FOK(港股通)(郑商所期货,期权,大商所期货FAK市价)
        /// </summary>
        public const sbyte V13 = (sbyte)'j';
            /// <summary>
        /// 定价申报(股转市场)(郑商所期权,大商所期货FOK市价)
        /// </summary>
        public const sbyte V14 = (sbyte)'k';
            /// <summary>
        /// 协议转让成交确认申报(股转市场)
        /// </summary>
        public const sbyte V15 = (sbyte)'l';
            /// <summary>
        /// 协议转让互报成交确认申报(股转市场)
        /// </summary>
        public const sbyte V16 = (sbyte)'m';
            /// <summary>
        /// 五档即成剩撤(深交所市价)
        /// </summary>
        public const sbyte V17 = (sbyte)'A';
            /// <summary>
        /// 即成剩撤(深交所市价)
        /// </summary>
        public const sbyte V18 = (sbyte)'C';
            /// <summary>
        /// 对手方最优(深交所市价)
        /// </summary>
        public const sbyte V19 = (sbyte)'D';
            /// <summary>
        /// 本方最优(深交所市价)
        /// </summary>
        public const sbyte V20 = (sbyte)'E';
            /// <summary>
        /// 全额成或撤(FOK市价)(深交所市价)
        /// </summary>
        public const sbyte V21 = (sbyte)'F';
            /// <summary>
        /// 全额成或撤(FOK限价)(上期所\中金所\深交所\能源交易所)(郑商所期权,大商所期货\期权FOK限价)
        /// </summary>
        public const sbyte V22 = (sbyte)'G';
            /// <summary>
        /// 即成剩撤(FAK)(上期所\郑商所\中金所\能源交易所)(大商所期货\期权即成剩撤(FAK))
        /// </summary>
        public const sbyte V23 = (sbyte)'K';
            /// <summary>
        /// 五档即成剩撤(中金所五档市价)
        /// </summary>
        public const sbyte V24 = (sbyte)'L';
            /// <summary>
        /// 五档即成剩转(中金所五档市价转限价)
        /// </summary>
        public const sbyte V25 = (sbyte)'M';
            /// <summary>
        /// 最优一档即成剩撤(中金所最优价)
        /// </summary>
        public const sbyte V26 = (sbyte)'N';
            /// <summary>
        /// 最优一档即成剩转(中金所最优价)
        /// </summary>
        public const sbyte V27 = (sbyte)'O';
        }
    /// <summary>
    /// 多空标志
    /// </summary>
    public sealed class UfxPositionFlag
    {
            /// <summary>
        /// 多头持仓
        /// </summary>
        public const sbyte V1 = (sbyte)'1';
            /// <summary>
        /// 空头持仓
        /// </summary>
        public const sbyte V2 = (sbyte)'2';
            /// <summary>
        /// 备兑空头持仓(股票期权)
        /// </summary>
        public const sbyte V3 = (sbyte)'b';
        }
    /// <summary>
    /// 币种
    /// </summary>
    public sealed class UfxCurrencyCode
    {
            /// <summary>
        /// 人民币
        /// </summary>
        public const string V1 = "CNY";
            /// <summary>
        /// 美元
        /// </summary>
        public const string V2 = "USD";
            /// <summary>
        /// 港币(未开通深港通)
        /// </summary>
        public const string V3 = "HKD";
            /// <summary>
        /// 港币(沪港通)(开通深港通)
        /// </summary>
        public const string V4 = "HK1";
            /// <summary>
        /// 港币(深港通)(开通深港通)
        /// </summary>
        public const string V5 = "HK2";
        }
    /// <summary>
    /// 现金替代标志
    /// </summary>
    public sealed class UfxReplaceFlag
    {
            /// <summary>
        /// 不可替代
        /// </summary>
        public const sbyte V1 = (sbyte)'0';
            /// <summary>
        /// 可以替代
        /// </summary>
        public const sbyte V2 = (sbyte)'1';
            /// <summary>
        /// 必须替代
        /// </summary>
        public const sbyte V3 = (sbyte)'2';
            /// <summary>
        /// 深市退补现金替代
        /// </summary>
        public const sbyte V4 = (sbyte)'3';
            /// <summary>
        /// 深市必须现金替代
        /// </summary>
        public const sbyte V5 = (sbyte)'4';
            /// <summary>
        /// 非沪深市场退补现金替代
        /// </summary>
        public const sbyte V6 = (sbyte)'5';
            /// <summary>
        /// 非沪深市场必须现金替代
        /// </summary>
        public const sbyte V7 = (sbyte)'6';
        }
    /// <summary>
    /// 委托失败代码
    /// </summary>
    public sealed class UfxEntrustFailCode
    {
            /// <summary>
        /// 成功
        /// </summary>
        public const int V1 = 0;
            /// <summary>
        /// 风控禁止
        /// </summary>
        public const int V2 = 1;
            /// <summary>
        /// 可用不足
        /// </summary>
        public const int V3 = 2;
            /// <summary>
        /// 其他
        /// </summary>
        public const int V4 = 3;
            /// <summary>
        /// 因为其他委托导致此笔委托失败
        /// </summary>
        public const int V5 = 99;
        }
    /// <summary>
    /// 期权类型
    /// </summary>
    public sealed class UfxOptionType
    {
            /// <summary>
        /// 认购期权
        /// </summary>
        public const sbyte V1 = (sbyte)'C';
            /// <summary>
        /// 认沽期权
        /// </summary>
        public const sbyte V2 = (sbyte)'P';
        }
    /// <summary>
    /// 申赎方式
    /// </summary>
    public sealed class UfxPurchaseWay
    {
            /// <summary>
        /// 普通申赎
        /// </summary>
        public const sbyte V1 = (sbyte)'0';
            /// <summary>
        /// 现金申赎
        /// </summary>
        public const sbyte V2 = (sbyte)'1';
            /// <summary>
        /// 实物申赎
        /// </summary>
        public const sbyte V3 = (sbyte)'2';
        }
    /// <summary>
    /// 资金调整类型
    /// </summary>
    public sealed class UfxAdjustMode
    {
            /// <summary>
        /// 资金调增
        /// </summary>
        public const sbyte V1 = (sbyte)'1';
            /// <summary>
        /// 资金调减
        /// </summary>
        public const sbyte V2 = (sbyte)'2';
            /// <summary>
        /// 保证金调增
        /// </summary>
        public const sbyte V3 = (sbyte)'3';
            /// <summary>
        /// 保证金调减
        /// </summary>
        public const sbyte V4 = (sbyte)'4';
            /// <summary>
        /// 资金投入(同步增加份额)
        /// </summary>
        public const sbyte V5 = (sbyte)'5';
            /// <summary>
        /// 资金支取(同步减少份额)
        /// </summary>
        public const sbyte V6 = (sbyte)'6';
            /// <summary>
        /// 资金拆入
        /// </summary>
        public const sbyte V7 = (sbyte)'a';
            /// <summary>
        /// 拆入到期
        /// </summary>
        public const sbyte V8 = (sbyte)'b';
            /// <summary>
        /// 资金拆出
        /// </summary>
        public const sbyte V9 = (sbyte)'c';
            /// <summary>
        /// 拆出到期
        /// </summary>
        public const sbyte V10 = (sbyte)'d';
        }
    /// <summary>
    /// 期货品种序号
    /// </summary>
    public sealed class UfxFutureKindId
    {
            /// <summary>
        /// 股指期货
        /// </summary>
        public const int V1 = 1;
            /// <summary>
        /// 铝
        /// </summary>
        public const int V2 = 6;
            /// <summary>
        /// 锌
        /// </summary>
        public const int V3 = 7;
            /// <summary>
        /// 铅
        /// </summary>
        public const int V4 = 8;
            /// <summary>
        /// 黄金
        /// </summary>
        public const int V5 = 9;
            /// <summary>
        /// 螺纹钢
        /// </summary>
        public const int V6 = 10;
            /// <summary>
        /// 线材
        /// </summary>
        public const int V7 = 11;
            /// <summary>
        /// 燃料油
        /// </summary>
        public const int V8 = 12;
            /// <summary>
        /// 天然橡胶
        /// </summary>
        public const int V9 = 13;
            /// <summary>
        /// 铜
        /// </summary>
        public const int V10 = 14;
            /// <summary>
        /// 硬麦
        /// </summary>
        public const int V11 = 15;
            /// <summary>
        /// 棉花
        /// </summary>
        public const int V12 = 16;
            /// <summary>
        /// 白糖
        /// </summary>
        public const int V13 = 17;
            /// <summary>
        /// PTA
        /// </summary>
        public const int V14 = 18;
            /// <summary>
        /// 菜籽油
        /// </summary>
        public const int V15 = 19;
            /// <summary>
        /// 早籼稻
        /// </summary>
        public const int V16 = 20;
            /// <summary>
        /// 甲醇
        /// </summary>
        public const int V17 = 21;
            /// <summary>
        /// 强麦
        /// </summary>
        public const int V18 = 22;
            /// <summary>
        /// 豆一号
        /// </summary>
        public const int V19 = 23;
            /// <summary>
        /// 豆二号
        /// </summary>
        public const int V20 = 24;
            /// <summary>
        /// 豆粕
        /// </summary>
        public const int V21 = 25;
            /// <summary>
        /// 豆油
        /// </summary>
        public const int V22 = 26;
            /// <summary>
        /// 棕榈油
        /// </summary>
        public const int V23 = 27;
            /// <summary>
        /// 聚乙烯
        /// </summary>
        public const int V24 = 28;
            /// <summary>
        /// 聚氯乙烯
        /// </summary>
        public const int V25 = 29;
            /// <summary>
        /// 焦炭
        /// </summary>
        public const int V26 = 30;
            /// <summary>
        /// 玉米
        /// </summary>
        public const int V27 = 31;
            /// <summary>
        /// 五年期国债期货
        /// </summary>
        public const int V28 = 32;
            /// <summary>
        /// 白银
        /// </summary>
        public const int V29 = 33;
            /// <summary>
        /// 玻璃
        /// </summary>
        public const int V30 = 34;
            /// <summary>
        /// 菜籽
        /// </summary>
        public const int V31 = 35;
            /// <summary>
        /// 菜粕
        /// </summary>
        public const int V32 = 36;
            /// <summary>
        /// 强麦
        /// </summary>
        public const int V33 = 37;
            /// <summary>
        /// 菜籽油
        /// </summary>
        public const int V34 = 38;
            /// <summary>
        /// 早籼稻
        /// </summary>
        public const int V35 = 39;
            /// <summary>
        /// 普麦
        /// </summary>
        public const int V36 = 40;
            /// <summary>
        /// 焦煤
        /// </summary>
        public const int V37 = 41;
            /// <summary>
        /// 石油沥青
        /// </summary>
        public const int V38 = 42;
            /// <summary>
        /// 动力煤
        /// </summary>
        public const int V39 = 43;
            /// <summary>
        /// 铁矿石
        /// </summary>
        public const int V40 = 44;
            /// <summary>
        /// 鸡蛋
        /// </summary>
        public const int V41 = 45;
            /// <summary>
        /// 粳稻
        /// </summary>
        public const int V42 = 46;
            /// <summary>
        /// 纤维板
        /// </summary>
        public const int V43 = 48;
            /// <summary>
        /// 胶合板
        /// </summary>
        public const int V44 = 49;
            /// <summary>
        /// 原油期货
        /// </summary>
        public const int V45 = 50;
            /// <summary>
        /// 聚丙烯
        /// </summary>
        public const int V46 = 51;
            /// <summary>
        /// 上证50股指期货
        /// </summary>
        public const int V47 = 52;
            /// <summary>
        /// 中证500股指期货
        /// </summary>
        public const int V48 = 53;
            /// <summary>
        /// 热轧卷板
        /// </summary>
        public const int V49 = 54;
            /// <summary>
        /// 甲醇N
        /// </summary>
        public const int V50 = 56;
            /// <summary>
        /// 晚籼稻谷
        /// </summary>
        public const int V51 = 57;
            /// <summary>
        /// 硅铁
        /// </summary>
        public const int V52 = 58;
            /// <summary>
        /// 锰硅
        /// </summary>
        public const int V53 = 59;
            /// <summary>
        /// 三年期国债期货
        /// </summary>
        public const int V54 = 60;
            /// <summary>
        /// 十年期国债期货
        /// </summary>
        public const int V55 = 61;
            /// <summary>
        /// 玉米淀粉
        /// </summary>
        public const int V56 = 62;
            /// <summary>
        /// 镍
        /// </summary>
        public const int V57 = 63;
            /// <summary>
        /// 锡
        /// </summary>
        public const int V58 = 64;
            /// <summary>
        /// 动力煤N
        /// </summary>
        public const int V59 = 65;
        }
    /// <summary>
    /// 股东指定状态
    /// </summary>
    public sealed class UfxBindStatus
    {
            /// <summary>
        /// 指定
        /// </summary>
        public const sbyte V1 = (sbyte)'0';
            /// <summary>
        /// 上交所未指定
        /// </summary>
        public const sbyte V2 = (sbyte)'1';
            /// <summary>
        /// 上交所指定
        /// </summary>
        public const sbyte V3 = (sbyte)'2';
            /// <summary>
        /// 上交所当日可卖空
        /// </summary>
        public const sbyte V4 = (sbyte)'3';
            /// <summary>
        /// 上交所回购登记
        /// </summary>
        public const sbyte V5 = (sbyte)'4';
            /// <summary>
        /// 深交所托管
        /// </summary>
        public const sbyte V6 = (sbyte)'5';
            /// <summary>
        /// 深交所指定
        /// </summary>
        public const sbyte V7 = (sbyte)'6';
        }
    /// <summary>
    /// 证券类型
    /// </summary>
    public sealed class UfxStockType
    {
            /// <summary>
        /// 股票
        /// </summary>
        public const string V1 = "01";
            /// <summary>
        /// 封闭式基金
        /// </summary>
        public const string V2 = "02";
            /// <summary>
        /// 国债
        /// </summary>
        public const string V3 = "03";
            /// <summary>
        /// 企债
        /// </summary>
        public const string V4 = "04";
            /// <summary>
        /// 可转债
        /// </summary>
        public const string V5 = "05";
            /// <summary>
        /// 政策性金融债
        /// </summary>
        public const string V6 = "06";
            /// <summary>
        /// 债券回购
        /// </summary>
        public const string V7 = "08";
            /// <summary>
        /// 股票回购
        /// </summary>
        public const string V8 = "09";
            /// <summary>
        /// 申购
        /// </summary>
        public const string V9 = "0a";
            /// <summary>
        /// 企债标准券
        /// </summary>
        public const string V10 = "0A";
            /// <summary>
        /// 申购款
        /// </summary>
        public const string V11 = "0b";
            /// <summary>
        /// 债转股
        /// </summary>
        public const string V12 = "0B";
            /// <summary>
        /// 配号
        /// </summary>
        public const string V13 = "0c";
            /// <summary>
        /// 配债
        /// </summary>
        public const string V14 = "0C";
            /// <summary>
        /// 央行票据
        /// </summary>
        public const string V15 = "0D";
            /// <summary>
        /// 增发
        /// </summary>
        public const string V16 = "0d";
            /// <summary>
        /// 增发款
        /// </summary>
        public const string V17 = "0e";
            /// <summary>
        /// 存款
        /// </summary>
        public const string V18 = "0E";
            /// <summary>
        /// 配售
        /// </summary>
        public const string V19 = "0f";
            /// <summary>
        /// 开放式基金
        /// </summary>
        public const string V20 = "0F";
            /// <summary>
        /// 关联配售
        /// </summary>
        public const string V21 = "0g";
            /// <summary>
        /// 非政策性金融债
        /// </summary>
        public const string V22 = "0G";
            /// <summary>
        /// 配股
        /// </summary>
        public const string V23 = "0h";
            /// <summary>
        /// 通用配售权证
        /// </summary>
        public const string V24 = "0H";
            /// <summary>
        /// 关联配股
        /// </summary>
        public const string V25 = "0i";
            /// <summary>
        /// 买断式回购
        /// </summary>
        public const string V26 = "0I";
            /// <summary>
        /// 投票
        /// </summary>
        public const string V27 = "0J";
            /// <summary>
        /// 债券承销
        /// </summary>
        public const string V28 = "0j";
            /// <summary>
        /// 债券申购
        /// </summary>
        public const string V29 = "0k";
            /// <summary>
        /// 次级债
        /// </summary>
        public const string V30 = "0K";
            /// <summary>
        /// 债券申购款
        /// </summary>
        public const string V31 = "0l";
            /// <summary>
        /// 次级债务
        /// </summary>
        public const string V32 = "0L";
            /// <summary>
        /// 认购权证
        /// </summary>
        public const string V33 = "0M";
            /// <summary>
        /// 类信托
        /// </summary>
        public const string V34 = "0m";
            /// <summary>
        /// 认沽权证
        /// </summary>
        public const string V35 = "0N";
            /// <summary>
        /// 债券增发
        /// </summary>
        public const string V36 = "0n";
            /// <summary>
        /// 债券增发款
        /// </summary>
        public const string V37 = "0o";
            /// <summary>
        /// 认购行权
        /// </summary>
        public const string V38 = "0O";
            /// <summary>
        /// 认沽行权
        /// </summary>
        public const string V39 = "0P";
            /// <summary>
        /// 指定登记
        /// </summary>
        public const string V40 = "0p";
            /// <summary>
        /// 撤销指定
        /// </summary>
        public const string V41 = "0q";
            /// <summary>
        /// 债券质押
        /// </summary>
        public const string V42 = "0Q";
            /// <summary>
        /// 回购登记
        /// </summary>
        public const string V43 = "0r";
            /// <summary>
        /// 股指期货
        /// </summary>
        public const string V44 = "0R";
            /// <summary>
        /// 公司债
        /// </summary>
        public const string V45 = "0S";
            /// <summary>
        /// 回购撤销
        /// </summary>
        public const string V46 = "0s";
            /// <summary>
        /// 地方债
        /// </summary>
        public const string V47 = "0T";
            /// <summary>
        /// 利率互换
        /// </summary>
        public const string V48 = "0t";
            /// <summary>
        /// 理财产品
        /// </summary>
        public const string V49 = "0U";
            /// <summary>
        /// 存托凭证
        /// </summary>
        public const string V50 = "0V";
            /// <summary>
        /// 商品期货
        /// </summary>
        public const string V51 = "0v";
            /// <summary>
        /// 国债期货
        /// </summary>
        public const string V52 = "0W";
            /// <summary>
        /// 指数
        /// </summary>
        public const string V53 = "0w";
            /// <summary>
        /// 国债标准券
        /// </summary>
        public const string V54 = "0x";
            /// <summary>
        /// 项目投资
        /// </summary>
        public const string V55 = "0X";
            /// <summary>
        /// 现金
        /// </summary>
        public const string V56 = "0Y";
            /// <summary>
        /// 债回售
        /// </summary>
        public const string V57 = "0y";
            /// <summary>
        /// 债券认购
        /// </summary>
        public const string V58 = "0Z";
            /// <summary>
        /// 信用拆借
        /// </summary>
        public const string V59 = "0z";
            /// <summary>
        /// 债券ETF质押
        /// </summary>
        public const string V60 = "0?";
            /// <summary>
        /// 占用
        /// </summary>
        public const string V61 = "0=";
            /// <summary>
        /// 占用
        /// </summary>
        public const string V62 = "0|";
            /// <summary>
        /// 占用
        /// </summary>
        public const string V63 = "0～";
            /// <summary>
        /// 信托计划
        /// </summary>
        public const string V64 = "0[";
            /// <summary>
        /// 债券预发行
        /// </summary>
        public const string V65 = "0]";
            /// <summary>
        /// 认购期权
        /// </summary>
        public const string V66 = "0(";
            /// <summary>
        /// 认沽期权
        /// </summary>
        public const string V67 = "0)";
            /// <summary>
        /// 优先股
        /// </summary>
        public const string V68 = "0{";
            /// <summary>
        /// 优先股回售
        /// </summary>
        public const string V69 = "0}";
            /// <summary>
        /// 优先股转股
        /// </summary>
        public const string V70 = "0<";
            /// <summary>
        /// 供股权
        /// </summary>
        public const string V71 = "11";
            /// <summary>
        /// 配售权
        /// </summary>
        public const string V72 = "12";
            /// <summary>
        /// 股票红利选择权
        /// </summary>
        public const string V73 = "13";
            /// <summary>
        /// 公司收购
        /// </summary>
        public const string V74 = "14";
            /// <summary>
        /// 供股权益
        /// </summary>
        public const string V75 = "15";
            /// <summary>
        /// 配售权益
        /// </summary>
        public const string V76 = "16";
            /// <summary>
        /// 其他
        /// </summary>
        public const string V77 = "!";
            /// <summary>
        /// 债券借贷
        /// </summary>
        public const string V78 = "+";
        }
}
