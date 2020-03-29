
using System;
using System.Collections.Generic;
using hundsun.mcapi;
using hundsun.t2sdk;

namespace QuantBox.XApi
{
    public class UfxSubCallbackInterface : CT2SubCallbackInterface
    {
        public override void OnRecvTickMsg(CT2SubscribeInterface lpSub, int subscribeIndex, string tickMsgInfo)
        {

        }

        public override unsafe void OnReceived(CT2SubscribeInterface lpSub, int subscribeIndex, void* lpData, int nLength, tagSubscribeRecvData lpRecData)
        {

        }
        
        public virtual void OnError(int errCode, string errMsg)
        {

        }

        public virtual void OnCallback(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, CT2UnPacker unPacker, int dataIndex = 0)
        {
            switch (msgType)
            {
                case (sbyte)'a':                    
                    OnEntrustReceived(lpSub, subscribeIndex, UfxEntrustReceived.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'b':                    
                    OnEntrustConfirmed(lpSub, subscribeIndex, UfxEntrustConfirmed.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'c':                    
                    OnEntrustRejected(lpSub, subscribeIndex, UfxEntrustRejected.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'d':                    
                    OnEntrustCancel(lpSub, subscribeIndex, UfxEntrustCancel.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'e':                    
                    OnEntrustCancelled(lpSub, subscribeIndex, UfxEntrustCancelled.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'f':                    
                    OnEntrustCancelRejected(lpSub, subscribeIndex, UfxEntrustCancelRejected.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'g':                    
                    OnEntrustTrade(lpSub, subscribeIndex, UfxEntrustTrade.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'h':                    
                    OnCombiEntrustReceived(lpSub, subscribeIndex, UfxCombiEntrustReceived.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'i':                    
                    OnCombiEntrustConfirmed(lpSub, subscribeIndex, UfxCombiEntrustConfirmed.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'j':                    
                    OnCombiEntrustRejected(lpSub, subscribeIndex, UfxCombiEntrustRejected.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'k':                    
                    OnCombiEntrustCancel(lpSub, subscribeIndex, UfxCombiEntrustCancel.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'l':                    
                    OnCombiEntrustCancelled(lpSub, subscribeIndex, UfxCombiEntrustCancelled.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'m':                    
                    OnCombiEntrustCancelRejected(lpSub, subscribeIndex, UfxCombiEntrustCancelRejected.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'n':                    
                    OnCombiOptionsEntrustReceived(lpSub, subscribeIndex, UfxCombiOptionsEntrustReceived.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'o':                    
                    OnCombiOptionsEntrustConfirmed(lpSub, subscribeIndex, UfxCombiOptionsEntrustConfirmed.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'p':                    
                    OnCombiOptionsEntrustRejected(lpSub, subscribeIndex, UfxCombiOptionsEntrustRejected.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'q':                    
                    OnCombiOptionsEntrustTrade(lpSub, subscribeIndex, UfxCombiOptionsEntrustTrade.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'r':                    
                    OnCombiOptionsEntrustCancelled(lpSub, subscribeIndex, UfxCombiOptionsEntrustCancelled.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'s':                    
                    OnEntrustApproving(lpSub, subscribeIndex, UfxEntrustApproving.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'u':                    
                    OnEntrustCancelApproving(lpSub, subscribeIndex, UfxEntrustCancelApproving.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'v':                    
                    OnCombiFutureOptionsEntrustReceived(lpSub, subscribeIndex, UfxCombiFutureOptionsEntrustReceived.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'w':                    
                    OnCombiFutureOptionsEntrustConfirmed(lpSub, subscribeIndex, UfxCombiFutureOptionsEntrustConfirmed.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'x':                    
                    OnCombiFutureOptionsEntrustRejected(lpSub, subscribeIndex, UfxCombiFutureOptionsEntrustRejected.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'y':                    
                    OnCombiFutureOptionsEntrustCancelled(lpSub, subscribeIndex, UfxCombiFutureOptionsEntrustCancelled.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'z':                    
                    OnCombiFutureOptionsEntrustApproving(lpSub, subscribeIndex, UfxCombiFutureOptionsEntrustApproving.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'A':                    
                    OnShCombiExerciseEntrustReceived(lpSub, subscribeIndex, UfxShCombiExerciseEntrustReceived.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'B':                    
                    OnShCombiExerciseEntrustConfirmed(lpSub, subscribeIndex, UfxShCombiExerciseEntrustConfirmed.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'C':                    
                    OnShCombiExerciseEntrustRejected(lpSub, subscribeIndex, UfxShCombiExerciseEntrustRejected.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'D':                    
                    OnShCombiExerciseEntrustCancelled(lpSub, subscribeIndex, UfxShCombiExerciseEntrustCancelled.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'E':                    
                    OnShCombiExerciseEntrustCancelRejected(lpSub, subscribeIndex, UfxShCombiExerciseEntrustCancelRejected.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'F':                    
                    OnShCombiExerciseEntrustApproving(lpSub, subscribeIndex, UfxShCombiExerciseEntrustApproving.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'G':                    
                    OnShCombiExerciseEntrustCancel(lpSub, subscribeIndex, UfxShCombiExerciseEntrustCancel.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'H':                    
                    OnShCombiExerciseCancelApproving(lpSub, subscribeIndex, UfxShCombiExerciseCancelApproving.ReadAll(unPacker, dataIndex));
                    break;
            }
        }

        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 委托下达成功后推送本条委托信息
        /// </summary>
        protected virtual void OnEntrustReceived(CT2SubscribeInterface lpSub, int subscribeIndex, UfxEntrustReceived[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 委托确认后推送本条委托信息
        /// </summary>
        protected virtual void OnEntrustConfirmed(CT2SubscribeInterface lpSub, int subscribeIndex, UfxEntrustConfirmed[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 
        /// </summary>
        protected virtual void OnEntrustRejected(CT2SubscribeInterface lpSub, int subscribeIndex, UfxEntrustRejected[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 对某条委托进行撤单后推送该条委托信息
        /// </summary>
        protected virtual void OnEntrustCancel(CT2SubscribeInterface lpSub, int subscribeIndex, UfxEntrustCancel[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 对某条委托进行撤单,撤单成功后推送该委托信息
        /// </summary>
        protected virtual void OnEntrustCancelled(CT2SubscribeInterface lpSub, int subscribeIndex, UfxEntrustCancelled[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 对某条委托进行撤单,撤单失败后推送该委托信息
        /// </summary>
        protected virtual void OnEntrustCancelRejected(CT2SubscribeInterface lpSub, int subscribeIndex, UfxEntrustCancelRejected[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 委托有成交,成交处理完成后推送成交信息
        /// </summary>
        protected virtual void OnEntrustTrade(CT2SubscribeInterface lpSub, int subscribeIndex, UfxEntrustTrade[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 委托下达成功后推送本条委托信息(支持深圳股票期权做市\股转做市业务)
        /// </summary>
        protected virtual void OnCombiEntrustReceived(CT2SubscribeInterface lpSub, int subscribeIndex, UfxCombiEntrustReceived[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 委托确认后推送本条委托信息(支持深圳股票期权做市\股转做市业务)
        /// </summary>
        protected virtual void OnCombiEntrustConfirmed(CT2SubscribeInterface lpSub, int subscribeIndex, UfxCombiEntrustConfirmed[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 支持深圳股票期权做市\股转做市业务
        /// </summary>
        protected virtual void OnCombiEntrustRejected(CT2SubscribeInterface lpSub, int subscribeIndex, UfxCombiEntrustRejected[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 对某条委托进行撤单后推送该条委托信息(支持深圳股票期权做市\股转做市业务)
        /// </summary>
        protected virtual void OnCombiEntrustCancel(CT2SubscribeInterface lpSub, int subscribeIndex, UfxCombiEntrustCancel[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 对某条委托进行撤单,撤单成功后推送该委托信息(支持深圳股票期权做市\股转做市业务)
        /// </summary>
        protected virtual void OnCombiEntrustCancelled(CT2SubscribeInterface lpSub, int subscribeIndex, UfxCombiEntrustCancelled[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 对某条委托进行撤单,撤单失败后推送该委托信息(支持深圳股票期权做市\股转做市业务)
        /// </summary>
        protected virtual void OnCombiEntrustCancelRejected(CT2SubscribeInterface lpSub, int subscribeIndex, UfxCombiEntrustCancelRejected[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 上交所股票期权组合保证金委托下达成功后推送本条委托信息
        /// </summary>
        protected virtual void OnCombiOptionsEntrustReceived(CT2SubscribeInterface lpSub, int subscribeIndex, UfxCombiOptionsEntrustReceived[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 上交所股票期权组合保证金委托确认成功后推送本条委托信息
        /// </summary>
        protected virtual void OnCombiOptionsEntrustConfirmed(CT2SubscribeInterface lpSub, int subscribeIndex, UfxCombiOptionsEntrustConfirmed[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 上交所股票期权组合保证金委托废单
        /// </summary>
        protected virtual void OnCombiOptionsEntrustRejected(CT2SubscribeInterface lpSub, int subscribeIndex, UfxCombiOptionsEntrustRejected[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 上交所股票期权组合委托有成交,成交处理完成后推送成交信息
        /// </summary>
        protected virtual void OnCombiOptionsEntrustTrade(CT2SubscribeInterface lpSub, int subscribeIndex, UfxCombiOptionsEntrustTrade[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 上交所股票期权组合保证金委托撤成 
        /// </summary>
        protected virtual void OnCombiOptionsEntrustCancelled(CT2SubscribeInterface lpSub, int subscribeIndex, UfxCombiOptionsEntrustCancelled[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 需要审批的委托,下达后状态为待审批,审批通过后状态为未报.支持审批拒绝.
        /// </summary>
        protected virtual void OnEntrustApproving(CT2SubscribeInterface lpSub, int subscribeIndex, UfxEntrustApproving[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 需要审批的撤单委托,下达后状态为待审批.
        /// </summary>
        protected virtual void OnEntrustCancelApproving(CT2SubscribeInterface lpSub, int subscribeIndex, UfxEntrustCancelApproving[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 委托下达成功后推送本条委托信息
        /// </summary>
        protected virtual void OnCombiFutureOptionsEntrustReceived(CT2SubscribeInterface lpSub, int subscribeIndex, UfxCombiFutureOptionsEntrustReceived[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 委托确认后推送本条委托信息
        /// </summary>
        protected virtual void OnCombiFutureOptionsEntrustConfirmed(CT2SubscribeInterface lpSub, int subscribeIndex, UfxCombiFutureOptionsEntrustConfirmed[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 委托废单后推送本条废单消息
        /// </summary>
        protected virtual void OnCombiFutureOptionsEntrustRejected(CT2SubscribeInterface lpSub, int subscribeIndex, UfxCombiFutureOptionsEntrustRejected[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 对某条委托进行撤单,撤单成功后推送该委托信息
        /// </summary>
        protected virtual void OnCombiFutureOptionsEntrustCancelled(CT2SubscribeInterface lpSub, int subscribeIndex, UfxCombiFutureOptionsEntrustCancelled[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 需要审批的委托,下达后状态为待审批,审批通过后状态为未报.支持审批拒绝.
        /// </summary>
        protected virtual void OnCombiFutureOptionsEntrustApproving(CT2SubscribeInterface lpSub, int subscribeIndex, UfxCombiFutureOptionsEntrustApproving[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 委托下达成功后推送本条委托信息
        /// </summary>
        protected virtual void OnShCombiExerciseEntrustReceived(CT2SubscribeInterface lpSub, int subscribeIndex, UfxShCombiExerciseEntrustReceived[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 委托确认后推送本条委托信息
        /// </summary>
        protected virtual void OnShCombiExerciseEntrustConfirmed(CT2SubscribeInterface lpSub, int subscribeIndex, UfxShCombiExerciseEntrustConfirmed[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 委托废单后推送本条废单消息
        /// </summary>
        protected virtual void OnShCombiExerciseEntrustRejected(CT2SubscribeInterface lpSub, int subscribeIndex, UfxShCombiExerciseEntrustRejected[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 对某条委托进行撤单,撤单成功后推送该委托信息
        /// </summary>
        protected virtual void OnShCombiExerciseEntrustCancelled(CT2SubscribeInterface lpSub, int subscribeIndex, UfxShCombiExerciseEntrustCancelled[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 对某条委托进行撤单,撤单失败后推送该委托信息
        /// </summary>
        protected virtual void OnShCombiExerciseEntrustCancelRejected(CT2SubscribeInterface lpSub, int subscribeIndex, UfxShCombiExerciseEntrustCancelRejected[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 需要审批的委托,下达后状态为待审批,审批通过后状态为未报.支持审批拒绝.
        /// </summary>
        protected virtual void OnShCombiExerciseEntrustApproving(CT2SubscribeInterface lpSub, int subscribeIndex, UfxShCombiExerciseEntrustApproving[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 委托撤单
        /// </summary>
        protected virtual void OnShCombiExerciseEntrustCancel(CT2SubscribeInterface lpSub, int subscribeIndex, UfxShCombiExerciseEntrustCancel[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 需要审批的撤单委托,下达后状态为待审批,审批通过后状态为未报.支持审批拒绝.
        /// </summary>
        protected virtual void OnShCombiExerciseCancelApproving(CT2SubscribeInterface lpSub, int subscribeIndex, UfxShCombiExerciseCancelApproving[] data)
        {
            
        }        
    }
}