
using System;
using System.Collections.Generic;
using hundsun.t2sdk;

namespace QuantBox.XApi
{
    /// <summary>
    /// 功能回报
    /// </summary>
    public class UfxCallbackInterface : CT2CallbackInterface
    {
        public override void OnConnect(CT2Connection lpConnection)
        {
        }

        public override void OnSafeConnect(CT2Connection lpConnection)
        {
        }

        public override void OnRegister(CT2Connection lpConnection)
        {
        }

        public override void OnClose(CT2Connection lpConnection)
        {
        }

        public override unsafe void OnSent(CT2Connection lpConnection, int hSend, void* lpData, int nLength, int nQueuingData)
        {
        }

        public override void OnReceivedBiz(CT2Connection lpConnection, int hSend, string lppStr, CT2UnPacker lppUnPacker, int nResult)
        {

        }

        public override void OnReceivedBizEx(CT2Connection lpConnection, int hSend, CT2RespondData lpRetData, string lppStr, CT2UnPacker lppUnPacker, int nResult)
        {

        }

        public override void OnReceivedBizMsg(CT2Connection lpConnection, int hSend, CT2BizMessage lpMsg)
        {
            
        }

        public virtual void OnError(int errCode, string errMsg)
        {

        }

        public virtual void OnCallback(CT2Connection lpConnection, int hSend, int functionId, CT2UnPacker unPacker, int dataIndex = 1)
        {
            switch (functionId)
            {
                case 10001:                    
                    OnReceived10001(lpConnection, hSend, functionId, Ufx10001Result.ReadAll(unPacker, dataIndex));
                    break;
                case 30001:                    
                    OnReceived30001(lpConnection, hSend, functionId, Ufx30001Result.ReadAll(unPacker, dataIndex));
                    break;
                case 30002:                    
                    OnReceived30002(lpConnection, hSend, functionId, Ufx30002Result.ReadAll(unPacker, dataIndex));
                    break;
                case 30003:                    
                    OnReceived30003(lpConnection, hSend, functionId, Ufx30003Result.ReadAll(unPacker, dataIndex));
                    break;
                case 30004:                    
                    OnReceived30004(lpConnection, hSend, functionId, Ufx30004Result.ReadAll(unPacker, dataIndex));
                    break;
                case 30005:                    
                    OnReceived30005(lpConnection, hSend, functionId, Ufx30005Result.ReadAll(unPacker, dataIndex));
                    break;
                case 30007:                    
                    OnReceived30007(lpConnection, hSend, functionId, Ufx30007Result.ReadAll(unPacker, dataIndex));
                    break;
                case 35003:                    
                    OnReceived35003(lpConnection, hSend, functionId, Ufx35003Result.ReadAll(unPacker, dataIndex));
                    break;
                case 35010:                    
                    OnReceived35010(lpConnection, hSend, functionId, Ufx35010Result.ReadAll(unPacker, dataIndex));
                    break;
                case 35011:                    
                    OnReceived35011(lpConnection, hSend, functionId, Ufx35011Result.ReadAll(unPacker, dataIndex));
                    break;
                case 35024:                    
                    OnReceived35024(lpConnection, hSend, functionId, Ufx35024Result.ReadAll(unPacker, dataIndex));
                    break;
                case 35025:                    
                    OnReceived35025(lpConnection, hSend, functionId, Ufx35025Result.ReadAll(unPacker, dataIndex));
                    break;
                case 35012:                    
                    OnReceived35012(lpConnection, hSend, functionId, Ufx35012Result.ReadAll(unPacker, dataIndex));
                    break;
                case 36012:                    
                    OnReceived36012(lpConnection, hSend, functionId, Ufx36012Result.ReadAll(unPacker, dataIndex));
                    break;
                case 35013:                    
                    OnReceived35013(lpConnection, hSend, functionId, Ufx35013Result.ReadAll(unPacker, dataIndex));
                    break;
                case 35015:                    
                    OnReceived35015(lpConnection, hSend, functionId, Ufx35015Result.ReadAll(unPacker, dataIndex));
                    break;
                case 35021:                    
                    OnReceived35021(lpConnection, hSend, functionId, Ufx35021Result.ReadAll(unPacker, dataIndex));
                    break;
                case 35022:                    
                    OnReceived35022(lpConnection, hSend, functionId, Ufx35022Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91001:                    
                    OnReceived91001(lpConnection, hSend, functionId, Ufx91001Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91011:                    
                    OnReceived91011(lpConnection, hSend, functionId, Ufx91011Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91115:                    
                    OnReceived91115(lpConnection, hSend, functionId, Ufx91115Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91113:                    
                    OnReceived91113(lpConnection, hSend, functionId, Ufx91113Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91090:                    
                    OnReceived91090(lpConnection, hSend, functionId, Ufx91090Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91114:                    
                    OnReceived91114(lpConnection, hSend, functionId, Ufx91114Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91101:                    
                    OnReceived91101(lpConnection, hSend, functionId, Ufx91101Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91102:                    
                    OnReceived91102(lpConnection, hSend, functionId, Ufx91102Result.ReadAll(unPacker, dataIndex));
                    break;
                case 31001:                    
                    OnReceived31001(lpConnection, hSend, functionId, Ufx31001Result.ReadAll(unPacker, dataIndex));
                    break;
                case 31002:                    
                    OnReceived31002(lpConnection, hSend, functionId, Ufx31002Result.ReadAll(unPacker, dataIndex));
                    break;
                case 30011:                    
                    OnReceived30011(lpConnection, hSend, functionId, Ufx30011Result.ReadAll(unPacker, dataIndex));
                    break;
                case 32001:                    
                    OnReceived32001(lpConnection, hSend, functionId, Ufx32001Result.ReadAll(unPacker, dataIndex));
                    break;
                case 32101:                    
                    OnReceived32101(lpConnection, hSend, functionId, Ufx32101Result.ReadAll(unPacker, dataIndex));
                    break;
                case 32006:                    
                    OnReceived32006(lpConnection, hSend, functionId, Ufx32006Result.ReadAll(unPacker, dataIndex));
                    break;
                case 33001:                    
                    OnReceived33001(lpConnection, hSend, functionId, Ufx33001Result.ReadAll(unPacker, dataIndex));
                    break;
                case 33101:                    
                    OnReceived33101(lpConnection, hSend, functionId, Ufx33101Result.ReadAll(unPacker, dataIndex));
                    break;
                case 34001:                    
                    OnReceived34001(lpConnection, hSend, functionId, Ufx34001Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91051:                    
                    OnReceived91051(lpConnection, hSend, functionId, Ufx91051Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91116:                    
                    OnReceived91116(lpConnection, hSend, functionId, Ufx91116Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91151:                    
                    OnReceived91151(lpConnection, hSend, functionId, Ufx91151Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91003:                    
                    OnReceived91003(lpConnection, hSend, functionId, Ufx91003Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91008:                    
                    OnReceived91008(lpConnection, hSend, functionId, Ufx91008Result.ReadAll(unPacker, dataIndex));
                    break;
                case 32002:                    
                    OnReceived32002(lpConnection, hSend, functionId, Ufx32002Result.ReadAll(unPacker, dataIndex));
                    break;
                case 32005:                    
                    OnReceived32005(lpConnection, hSend, functionId, Ufx32005Result.ReadAll(unPacker, dataIndex));
                    break;
                case 33002:                    
                    OnReceived33002(lpConnection, hSend, functionId, Ufx33002Result.ReadAll(unPacker, dataIndex));
                    break;
                case 33005:                    
                    OnReceived33005(lpConnection, hSend, functionId, Ufx33005Result.ReadAll(unPacker, dataIndex));
                    break;
                case 35014:                    
                    OnReceived35014(lpConnection, hSend, functionId, Ufx35014Result.ReadAll(unPacker, dataIndex));
                    break;
                case 35020:                    
                    OnReceived35020(lpConnection, hSend, functionId, Ufx35020Result.ReadAll(unPacker, dataIndex));
                    break;
                case 30010:                    
                    OnReceived30010(lpConnection, hSend, functionId, Ufx30010Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91004:                    
                    OnReceived91004(lpConnection, hSend, functionId, Ufx91004Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91013:                    
                    OnReceived91013(lpConnection, hSend, functionId, Ufx91013Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91119:                    
                    OnReceived91119(lpConnection, hSend, functionId, Ufx91119Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91105:                    
                    OnReceived91105(lpConnection, hSend, functionId, Ufx91105Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91121:                    
                    OnReceived91121(lpConnection, hSend, functionId, Ufx91121Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91107:                    
                    OnReceived91107(lpConnection, hSend, functionId, Ufx91107Result.ReadAll(unPacker, dataIndex));
                    break;
                case 31003:                    
                    OnReceived31003(lpConnection, hSend, functionId, Ufx31003Result.ReadAll(unPacker, dataIndex));
                    break;
                case 31013:                    
                    OnReceived31013(lpConnection, hSend, functionId, Ufx31013Result.ReadAll(unPacker, dataIndex));
                    break;
                case 32003:                    
                    OnReceived32003(lpConnection, hSend, functionId, Ufx32003Result.ReadAll(unPacker, dataIndex));
                    break;
                case 32103:                    
                    OnReceived32103(lpConnection, hSend, functionId, Ufx32103Result.ReadAll(unPacker, dataIndex));
                    break;
                case 32008:                    
                    OnReceived32008(lpConnection, hSend, functionId, Ufx32008Result.ReadAll(unPacker, dataIndex));
                    break;
                case 33003:                    
                    OnReceived33003(lpConnection, hSend, functionId, Ufx33003Result.ReadAll(unPacker, dataIndex));
                    break;
                case 33103:                    
                    OnReceived33103(lpConnection, hSend, functionId, Ufx33103Result.ReadAll(unPacker, dataIndex));
                    break;
                case 34003:                    
                    OnReceived34003(lpConnection, hSend, functionId, Ufx34003Result.ReadAll(unPacker, dataIndex));
                    break;
                case 35023:                    
                    OnReceived35023(lpConnection, hSend, functionId, Ufx35023Result.ReadAll(unPacker, dataIndex));
                    break;
                case 30012:                    
                    OnReceived30012(lpConnection, hSend, functionId, Ufx30012Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91005:                    
                    OnReceived91005(lpConnection, hSend, functionId, Ufx91005Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91006:                    
                    OnReceived91006(lpConnection, hSend, functionId, Ufx91006Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91007:                    
                    OnReceived91007(lpConnection, hSend, functionId, Ufx91007Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91025:                    
                    OnReceived91025(lpConnection, hSend, functionId, Ufx91025Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91126:                    
                    OnReceived91126(lpConnection, hSend, functionId, Ufx91126Result.ReadAll(unPacker, dataIndex));
                    break;
                case 32017:                    
                    OnReceived32017(lpConnection, hSend, functionId, Ufx32017Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91012:                    
                    OnReceived91012(lpConnection, hSend, functionId, Ufx91012Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91014:                    
                    OnReceived91014(lpConnection, hSend, functionId, Ufx91014Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91091:                    
                    OnReceived91091(lpConnection, hSend, functionId, Ufx91091Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91016:                    
                    OnReceived91016(lpConnection, hSend, functionId, Ufx91016Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91017:                    
                    OnReceived91017(lpConnection, hSend, functionId, Ufx91017Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91120:                    
                    OnReceived91120(lpConnection, hSend, functionId, Ufx91120Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91106:                    
                    OnReceived91106(lpConnection, hSend, functionId, Ufx91106Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91108:                    
                    OnReceived91108(lpConnection, hSend, functionId, Ufx91108Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91122:                    
                    OnReceived91122(lpConnection, hSend, functionId, Ufx91122Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91109:                    
                    OnReceived91109(lpConnection, hSend, functionId, Ufx91109Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91123:                    
                    OnReceived91123(lpConnection, hSend, functionId, Ufx91123Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91111:                    
                    OnReceived91111(lpConnection, hSend, functionId, Ufx91111Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91112:                    
                    OnReceived91112(lpConnection, hSend, functionId, Ufx91112Result.ReadAll(unPacker, dataIndex));
                    break;
                case 31004:                    
                    OnReceived31004(lpConnection, hSend, functionId, Ufx31004Result.ReadAll(unPacker, dataIndex));
                    break;
                case 32004:                    
                    OnReceived32004(lpConnection, hSend, functionId, Ufx32004Result.ReadAll(unPacker, dataIndex));
                    break;
                case 32007:                    
                    OnReceived32007(lpConnection, hSend, functionId, Ufx32007Result.ReadAll(unPacker, dataIndex));
                    break;
                case 33004:                    
                    OnReceived33004(lpConnection, hSend, functionId, Ufx33004Result.ReadAll(unPacker, dataIndex));
                    break;
                case 34004:                    
                    OnReceived34004(lpConnection, hSend, functionId, Ufx34004Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91015:                    
                    OnReceived91015(lpConnection, hSend, functionId, Ufx91015Result.ReadAll(unPacker, dataIndex));
                    break;
                case 31015:                    
                    OnReceived31015(lpConnection, hSend, functionId, Ufx31015Result.ReadAll(unPacker, dataIndex));
                    break;
                case 32015:                    
                    OnReceived32015(lpConnection, hSend, functionId, Ufx32015Result.ReadAll(unPacker, dataIndex));
                    break;
                case 33015:                    
                    OnReceived33015(lpConnection, hSend, functionId, Ufx33015Result.ReadAll(unPacker, dataIndex));
                    break;
                case 91018:                    
                    OnReceived91018(lpConnection, hSend, functionId, Ufx91018Result.ReadAll(unPacker, dataIndex));
                    break;
                case 32016:                    
                    OnReceived32016(lpConnection, hSend, functionId, Ufx32016Result.ReadAll(unPacker, dataIndex));
                    break;
                case 31005:                    
                    OnReceived31005(lpConnection, hSend, functionId, Ufx31005Result.ReadAll(unPacker, dataIndex));
                    break;
                case 35008:                    
                    OnReceived35008(lpConnection, hSend, functionId, Ufx35008Result.ReadAll(unPacker, dataIndex));
                    break;
            }
        }

        /// <summary>
        /// 业务范围: 账户
        /// 功能名称: 建立与投资管理系统的连接,UFX系统中做其他操作前必须先进行登陆.
        /// </summary>
        protected virtual void OnReceived10001(CT2Connection lpConnection, int hSend, int functionId, Ufx10001Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 账户
        /// 功能名称: 支持查询登陆操作员有操作权限的有效账户列表
        /// </summary>
        protected virtual void OnReceived30001(CT2Connection lpConnection, int hSend, int functionId, Ufx30001Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 账户
        /// 功能名称: 支持查询登陆操作员有操作权限的资产单元列表
        /// </summary>
        protected virtual void OnReceived30002(CT2Connection lpConnection, int hSend, int functionId, Ufx30002Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 账户
        /// 功能名称: 支持查询登陆操作员有操作权限且状态为有效的组合列表
        /// </summary>
        protected virtual void OnReceived30003(CT2Connection lpConnection, int hSend, int functionId, Ufx30003Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 账户
        /// 功能名称: 支持查询交易股东信息
        /// </summary>
        protected virtual void OnReceived30004(CT2Connection lpConnection, int hSend, int functionId, Ufx30004Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 账户
        /// 功能名称: 支持批量查询股东信息
        /// </summary>
        protected virtual void OnReceived30005(CT2Connection lpConnection, int hSend, int functionId, Ufx30005Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 账户
        /// 功能名称: 支持查询账户清算状态,期现货可以分开查询(OPLUS专用).
        /// </summary>
        protected virtual void OnReceived30007(CT2Connection lpConnection, int hSend, int functionId, Ufx30007Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 账户
        /// 功能名称: 支持查询账户资产信息
        /// </summary>
        protected virtual void OnReceived35003(CT2Connection lpConnection, int hSend, int functionId, Ufx35003Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 账户
        /// 功能名称: 支持查询账户资产信息(本币汇总)
        /// </summary>
        protected virtual void OnReceived35010(CT2Connection lpConnection, int hSend, int functionId, Ufx35010Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 账户
        /// 功能名称: 支持查询资产单元资产信息
        /// </summary>
        protected virtual void OnReceived35011(CT2Connection lpConnection, int hSend, int functionId, Ufx35011Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 账户
        /// 功能名称: 支持查询资产单元资产信息,查询结果为按照本币汇总后的数据
        /// </summary>
        protected virtual void OnReceived35024(CT2Connection lpConnection, int hSend, int functionId, Ufx35024Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 账户
        /// 功能名称: 支持查询期货账户盈亏信息
        /// </summary>
        protected virtual void OnReceived35025(CT2Connection lpConnection, int hSend, int functionId, Ufx35025Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 账户
        /// 功能名称: 支持查询当日清算流水
        /// </summary>
        protected virtual void OnReceived35012(CT2Connection lpConnection, int hSend, int functionId, Ufx35012Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 账户
        /// 功能名称: 支持查询历史清算流水,只能查询一天的历史记录
        /// </summary>
        protected virtual void OnReceived36012(CT2Connection lpConnection, int hSend, int functionId, Ufx36012Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 账户
        /// 功能名称: 支持查询可期货保证金比例信息
        /// </summary>
        protected virtual void OnReceived35013(CT2Connection lpConnection, int hSend, int functionId, Ufx35013Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 账户
        /// 功能名称: 支持资金调增\资金调减\保证金调增\保证金调减\资金投入\资金支取业务
        /// </summary>
        protected virtual void OnReceived35015(CT2Connection lpConnection, int hSend, int functionId, Ufx35015Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 账户
        /// 功能名称: 支持资金划转,支持批量传入,最大1000条.
        /// </summary>
        protected virtual void OnReceived35021(CT2Connection lpConnection, int hSend, int functionId, Ufx35021Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 账户
        /// 功能名称: 支持现货,期货划转,支持批量传入,最大1000条.不支持批量跨基金证券划转
        /// </summary>
        protected virtual void OnReceived35022(CT2Connection lpConnection, int hSend, int functionId, Ufx35022Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持沪深股票\基金买卖\债券买卖,新股申购\可转债申购\质押式回购\债转股\债回售\基金认购\配股认购\配债认购\债券认购业务.(不含固定收益和大宗交易).支持CDR存托凭证业务,支持沪伦通业务.
        /// </summary>
        protected virtual void OnReceived91001(CT2Connection lpConnection, int hSend, int functionId, Ufx91001Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持股转市场做市业务
        /// </summary>
        protected virtual void OnReceived91011(CT2Connection lpConnection, int hSend, int functionId, Ufx91011Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持按委托序号撤销股转做市委托.
        /// </summary>
        protected virtual void OnReceived91115(CT2Connection lpConnection, int hSend, int functionId, Ufx91115Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持按委托序号撤销股转做市委托.
        /// </summary>
        protected virtual void OnReceived91113(CT2Connection lpConnection, int hSend, int functionId, Ufx91113Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持沪深股票\基金\债券买卖和股指期货\国债期货\商品期货\股票期权业务.支持CDR存托凭证业务,支持沪伦通业务
        /// </summary>
        protected virtual void OnReceived91090(CT2Connection lpConnection, int hSend, int functionId, Ufx91090Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
        /// </summary>
        protected virtual void OnReceived91114(CT2Connection lpConnection, int hSend, int functionId, Ufx91114Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
        /// </summary>
        protected virtual void OnReceived91101(CT2Connection lpConnection, int hSend, int functionId, Ufx91101Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持按委托批号撤单,支持对证券\期货\期权\策略等业务按委托批号撤单
        /// </summary>
        protected virtual void OnReceived91102(CT2Connection lpConnection, int hSend, int functionId, Ufx91102Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持查询沪深及股转市场的股票\基金\债券的持仓信息
        /// </summary>
        protected virtual void OnReceived31001(CT2Connection lpConnection, int hSend, int functionId, Ufx31001Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持查询提交\转回质押的质押券数量明细(OPLUS专用)
        /// </summary>
        protected virtual void OnReceived31002(CT2Connection lpConnection, int hSend, int functionId, Ufx31002Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持查询现货,期货,期权的证券资料信息.
        /// </summary>
        protected virtual void OnReceived30011(CT2Connection lpConnection, int hSend, int functionId, Ufx30011Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持查询当日普通买卖委托流水,包含沪深股票\基金买卖\债券买卖,新股申购\可转债申购\质押式回购\债转股\债回售\基金认购\配股认购\配债认购\债券认购\股转市场业务
        /// </summary>
        protected virtual void OnReceived32001(CT2Connection lpConnection, int hSend, int functionId, Ufx32001Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持查询历史普通买卖委托流水
        /// </summary>
        protected virtual void OnReceived32101(CT2Connection lpConnection, int hSend, int functionId, Ufx32101Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持查询当日股转做市委托
        /// </summary>
        protected virtual void OnReceived32006(CT2Connection lpConnection, int hSend, int functionId, Ufx32006Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持查询当日普通买卖委托以及当日股转做市委托对应的成交流水
        /// </summary>
        protected virtual void OnReceived33001(CT2Connection lpConnection, int hSend, int functionId, Ufx33001Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持查询历史普通买卖成交流水
        /// </summary>
        protected virtual void OnReceived33101(CT2Connection lpConnection, int hSend, int functionId, Ufx33101Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持查询沪深A股及股转市场资金账户的资金可用,支持批量传入.
        /// </summary>
        protected virtual void OnReceived34001(CT2Connection lpConnection, int hSend, int functionId, Ufx34001Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持股转市场协议转让交易业务.
        /// </summary>
        protected virtual void OnReceived91051(CT2Connection lpConnection, int hSend, int functionId, Ufx91051Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
        /// </summary>
        protected virtual void OnReceived91116(CT2Connection lpConnection, int hSend, int functionId, Ufx91116Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 证券
        /// 功能名称: 支持按委托序号撤单,可传入多个委托序号进行批量撤单
        /// </summary>
        protected virtual void OnReceived91151(CT2Connection lpConnection, int hSend, int functionId, Ufx91151Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 基金
        /// 功能名称: 支持沪深ETF\沪深跨市场ETF\沪深跨境ETF申赎业务
        /// </summary>
        protected virtual void OnReceived91003(CT2Connection lpConnection, int hSend, int functionId, Ufx91003Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 基金
        /// 功能名称: 支持ETF(股票型ETF\债券型ETF\华宝兴业交易型货币基金\沪深跨境ETF\沪深黄金ETF\深交所交易型货币基金)\场内开放式基金申赎(LOF)\LOF基金分拆合并\转托管.基金买卖委托请用91001接口
        /// </summary>
        protected virtual void OnReceived91008(CT2Connection lpConnection, int hSend, int functionId, Ufx91008Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 基金
        /// 功能名称: 支持查询当日基金一级市场委托流水.
        /// </summary>
        protected virtual void OnReceived32002(CT2Connection lpConnection, int hSend, int functionId, Ufx32002Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 基金
        /// 功能名称: 支持查询ETF申赎时的成份股和资金代码委托明细信息.
        /// </summary>
        protected virtual void OnReceived32005(CT2Connection lpConnection, int hSend, int functionId, Ufx32005Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 基金
        /// 功能名称: 支持查询当日基金一级市场委托成交流水
        /// </summary>
        protected virtual void OnReceived33002(CT2Connection lpConnection, int hSend, int functionId, Ufx33002Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 基金
        /// 功能名称: 支持查询ETF申赎时的成份股和资金代码成交明细信息.
        /// </summary>
        protected virtual void OnReceived33005(CT2Connection lpConnection, int hSend, int functionId, Ufx33005Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 基金
        /// 功能名称: 支持查询沪深ETF成份股信息
        /// </summary>
        protected virtual void OnReceived35014(CT2Connection lpConnection, int hSend, int functionId, Ufx35014Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 基金
        /// 功能名称: 支持沪深查询ETF基础信息
        /// </summary>
        protected virtual void OnReceived35020(CT2Connection lpConnection, int hSend, int functionId, Ufx35020Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期货
        /// 功能名称: 支持查询期货市场未过期的期货信息.
        /// </summary>
        protected virtual void OnReceived30010(CT2Connection lpConnection, int hSend, int functionId, Ufx30010Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期货
        /// 功能名称: 支持中金所股指期货\国债期货和上期所\大商所\郑商所\能源交易所的商品期货业务
        /// </summary>
        protected virtual void OnReceived91004(CT2Connection lpConnection, int hSend, int functionId, Ufx91004Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期货
        /// 功能名称: 支持商品期货标准套利单\互换单业务.
        /// </summary>
        protected virtual void OnReceived91013(CT2Connection lpConnection, int hSend, int functionId, Ufx91013Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期货
        /// 功能名称: 支持按委托序号撤单,支持多条委托批量撤单
        /// </summary>
        protected virtual void OnReceived91119(CT2Connection lpConnection, int hSend, int functionId, Ufx91119Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期货
        /// 功能名称: 支持按委托序号撤单,支持多条委托批量撤单
        /// </summary>
        protected virtual void OnReceived91105(CT2Connection lpConnection, int hSend, int functionId, Ufx91105Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期货
        /// 功能名称: 支持商品期货组合单撤单
        /// </summary>
        protected virtual void OnReceived91121(CT2Connection lpConnection, int hSend, int functionId, Ufx91121Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期货
        /// 功能名称: 支持商品期货组合单撤单
        /// </summary>
        protected virtual void OnReceived91107(CT2Connection lpConnection, int hSend, int functionId, Ufx91107Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期货
        /// 功能名称: 支持查询期货持仓
        /// </summary>
        protected virtual void OnReceived31003(CT2Connection lpConnection, int hSend, int functionId, Ufx31003Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期货
        /// 功能名称: 支持查询期货持仓明细
        /// </summary>
        protected virtual void OnReceived31013(CT2Connection lpConnection, int hSend, int functionId, Ufx31013Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期货
        /// 功能名称: 支持查询当日期货委托流水
        /// </summary>
        protected virtual void OnReceived32003(CT2Connection lpConnection, int hSend, int functionId, Ufx32003Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期货
        /// 功能名称: 支持查询期货历史普通买卖委托流水
        /// </summary>
        protected virtual void OnReceived32103(CT2Connection lpConnection, int hSend, int functionId, Ufx32103Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期货
        /// 功能名称: 支持查询当日商品期货组合委托流水
        /// </summary>
        protected virtual void OnReceived32008(CT2Connection lpConnection, int hSend, int functionId, Ufx32008Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期货
        /// 功能名称: 支持查询当日期货成交流水
        /// </summary>
        protected virtual void OnReceived33003(CT2Connection lpConnection, int hSend, int functionId, Ufx33003Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期货
        /// 功能名称: 支持查询期货历史期货成交流水
        /// </summary>
        protected virtual void OnReceived33103(CT2Connection lpConnection, int hSend, int functionId, Ufx33103Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期货
        /// 功能名称: 支持查询期货保证金账户的资金可用信息,可查询期货\股指期权\商品期权可用保证金,支持批量传入.
        /// </summary>
        protected virtual void OnReceived34003(CT2Connection lpConnection, int hSend, int functionId, Ufx34003Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期货
        /// 功能名称: 支持期货费率查询,支持中金所股指期货\国债期货和上期所\大商所\郑商所\能源交易所的商品期货业务
        /// </summary>
        protected virtual void OnReceived35023(CT2Connection lpConnection, int hSend, int functionId, Ufx35023Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持查询期权信息.
        /// </summary>
        protected virtual void OnReceived30012(CT2Connection lpConnection, int hSend, int functionId, Ufx30012Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权交易业务
        /// </summary>
        protected virtual void OnReceived91005(CT2Connection lpConnection, int hSend, int functionId, Ufx91005Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持上海股票期权保证券的锁定与解锁业务
        /// </summary>
        protected virtual void OnReceived91006(CT2Connection lpConnection, int hSend, int functionId, Ufx91006Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权业务
        /// </summary>
        protected virtual void OnReceived91007(CT2Connection lpConnection, int hSend, int functionId, Ufx91007Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持上交所股票期权合并行权业务
        /// </summary>
        protected virtual void OnReceived91025(CT2Connection lpConnection, int hSend, int functionId, Ufx91025Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持上交所期权合并行权撤单,可传入多条委托序号进行批量撤单.最多支持1000笔
        /// </summary>
        protected virtual void OnReceived91126(CT2Connection lpConnection, int hSend, int functionId, Ufx91126Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持查询当日上交所合并行权委托
        /// </summary>
        protected virtual void OnReceived32017(CT2Connection lpConnection, int hSend, int functionId, Ufx32017Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持股指期权做市业务
        /// </summary>
        protected virtual void OnReceived91012(CT2Connection lpConnection, int hSend, int functionId, Ufx91012Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持深交所股票期权,中金所股指期权做市业务,支持批量传入
        /// </summary>
        protected virtual void OnReceived91014(CT2Connection lpConnection, int hSend, int functionId, Ufx91014Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持上交所股票期权篮子委托业务,用于股票期权批量下单和做市委托.
        /// </summary>
        protected virtual void OnReceived91091(CT2Connection lpConnection, int hSend, int functionId, Ufx91091Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持上交所股票期权询价
        /// </summary>
        protected virtual void OnReceived91016(CT2Connection lpConnection, int hSend, int functionId, Ufx91016Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持上交所股票期权回应报价,回应报价修改,支持批量传入
        /// </summary>
        protected virtual void OnReceived91017(CT2Connection lpConnection, int hSend, int functionId, Ufx91017Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持按委托序号撤销期权(股票期权\股指期权\商品期权)委托,可传入多个委托序号进行批量撤单
        /// </summary>
        protected virtual void OnReceived91120(CT2Connection lpConnection, int hSend, int functionId, Ufx91120Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持按委托序号撤销期权(股票期权\股指期权\商品期权)委托,可传入多个委托序号进行批量撤单
        /// </summary>
        protected virtual void OnReceived91106(CT2Connection lpConnection, int hSend, int functionId, Ufx91106Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持按委托批号撤销股指期权委托
        /// </summary>
        protected virtual void OnReceived91108(CT2Connection lpConnection, int hSend, int functionId, Ufx91108Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持撤销深交所股票期权做市委托,中金所股指期权做市委托
        /// </summary>
        protected virtual void OnReceived91122(CT2Connection lpConnection, int hSend, int functionId, Ufx91122Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持撤销深交所股票期权做市委托,中金所股指期权做市委托
        /// </summary>
        protected virtual void OnReceived91109(CT2Connection lpConnection, int hSend, int functionId, Ufx91109Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权撤单,可传入多条委托序号进行批量撤单.
        /// </summary>
        protected virtual void OnReceived91123(CT2Connection lpConnection, int hSend, int functionId, Ufx91123Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权撤单,可传入多条委托序号进行批量撤单.
        /// </summary>
        protected virtual void OnReceived91111(CT2Connection lpConnection, int hSend, int functionId, Ufx91111Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持沪深股票期权\大商所,郑商所,上期所商品期权行权按委托批号撤单.
        /// </summary>
        protected virtual void OnReceived91112(CT2Connection lpConnection, int hSend, int functionId, Ufx91112Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持查询沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权持仓信息
        /// </summary>
        protected virtual void OnReceived31004(CT2Connection lpConnection, int hSend, int functionId, Ufx31004Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持查询沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权当日委托流水(除备兑锁定解锁)
        /// </summary>
        protected virtual void OnReceived32004(CT2Connection lpConnection, int hSend, int functionId, Ufx32004Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持查询当日股指期权\深交所股票期权做市委托
        /// </summary>
        protected virtual void OnReceived32007(CT2Connection lpConnection, int hSend, int functionId, Ufx32007Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持查询沪深股票期权\中金所股指期权\大商所,郑商所,上期所商品期权当日成交流水
        /// </summary>
        protected virtual void OnReceived33004(CT2Connection lpConnection, int hSend, int functionId, Ufx33004Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持沪深衍生品保证金账户查询(股指期权,商品期权保证金账户请使用34003接口查询).
        /// </summary>
        protected virtual void OnReceived34004(CT2Connection lpConnection, int hSend, int functionId, Ufx34004Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持上交所股票期权组合策略保证金交易业务
        /// </summary>
        protected virtual void OnReceived91015(CT2Connection lpConnection, int hSend, int functionId, Ufx91015Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持查询上交所股票期权组合策略保证金持仓信息
        /// </summary>
        protected virtual void OnReceived31015(CT2Connection lpConnection, int hSend, int functionId, Ufx31015Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持查询上交所股票期权组合策略保证金委托信息
        /// </summary>
        protected virtual void OnReceived32015(CT2Connection lpConnection, int hSend, int functionId, Ufx32015Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持查询上交所股票期权组合策略保证金成交信息
        /// </summary>
        protected virtual void OnReceived33015(CT2Connection lpConnection, int hSend, int functionId, Ufx33015Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持郑商所商品期权套利单业务.
        /// </summary>
        protected virtual void OnReceived91018(CT2Connection lpConnection, int hSend, int functionId, Ufx91018Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 支持查询当日郑商所商品期权套利单委托
        /// </summary>
        protected virtual void OnReceived32016(CT2Connection lpConnection, int hSend, int functionId, Ufx32016Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 标准
        /// 功能名称: 支持查询现货\期货\期权持仓信息
        /// </summary>
        protected virtual void OnReceived31005(CT2Connection lpConnection, int hSend, int functionId, Ufx31005Result[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 账户
        /// 功能名称: 支持获取当前可用的委托批号
        /// </summary>
        protected virtual void OnReceived35008(CT2Connection lpConnection, int hSend, int functionId, Ufx35008Result[] data)
        {
            
        }        
    }
}