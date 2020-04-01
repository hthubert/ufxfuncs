
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
                    OnEntrustReceived(lpSub, subscribeIndex, msgType, UfxEntrustReceived.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'b':                    
                    OnEntrustConfirmed(lpSub, subscribeIndex, msgType, UfxEntrustConfirmed.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'c':                    
                    OnEntrustRejected(lpSub, subscribeIndex, msgType, UfxEntrustRejected.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'d':                    
                    OnEntrustCancel(lpSub, subscribeIndex, msgType, UfxEntrustCancel.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'e':                    
                    OnEntrustCancelled(lpSub, subscribeIndex, msgType, UfxEntrustCancelled.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'f':                    
                    OnEntrustCancelRejected(lpSub, subscribeIndex, msgType, UfxEntrustCancelRejected.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'g':                    
                    OnEntrustTrade(lpSub, subscribeIndex, msgType, UfxEntrustTrade.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'h':                    
                    OnCombiEntrustReceived(lpSub, subscribeIndex, msgType, UfxCombiEntrustReceived.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'i':                    
                    OnCombiEntrustConfirmed(lpSub, subscribeIndex, msgType, UfxCombiEntrustConfirmed.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'j':                    
                    OnCombiEntrustRejected(lpSub, subscribeIndex, msgType, UfxCombiEntrustRejected.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'k':                    
                    OnCombiEntrustCancel(lpSub, subscribeIndex, msgType, UfxCombiEntrustCancel.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'l':                    
                    OnCombiEntrustCancelled(lpSub, subscribeIndex, msgType, UfxCombiEntrustCancelled.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'m':                    
                    OnCombiEntrustCancelRejected(lpSub, subscribeIndex, msgType, UfxCombiEntrustCancelRejected.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'n':                    
                    OnCombiOptionsEntrustReceived(lpSub, subscribeIndex, msgType, UfxCombiOptionsEntrustReceived.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'o':                    
                    OnCombiOptionsEntrustConfirmed(lpSub, subscribeIndex, msgType, UfxCombiOptionsEntrustConfirmed.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'p':                    
                    OnCombiOptionsEntrustRejected(lpSub, subscribeIndex, msgType, UfxCombiOptionsEntrustRejected.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'q':                    
                    OnCombiOptionsEntrustTrade(lpSub, subscribeIndex, msgType, UfxCombiOptionsEntrustTrade.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'r':                    
                    OnCombiOptionsEntrustCancelled(lpSub, subscribeIndex, msgType, UfxCombiOptionsEntrustCancelled.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'s':                    
                    OnEntrustApproving(lpSub, subscribeIndex, msgType, UfxEntrustApproving.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'u':                    
                    OnEntrustCancelApproving(lpSub, subscribeIndex, msgType, UfxEntrustCancelApproving.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'v':                    
                    OnCombiFutureOptionsEntrustReceived(lpSub, subscribeIndex, msgType, UfxCombiFutureOptionsEntrustReceived.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'w':                    
                    OnCombiFutureOptionsEntrustConfirmed(lpSub, subscribeIndex, msgType, UfxCombiFutureOptionsEntrustConfirmed.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'x':                    
                    OnCombiFutureOptionsEntrustRejected(lpSub, subscribeIndex, msgType, UfxCombiFutureOptionsEntrustRejected.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'y':                    
                    OnCombiFutureOptionsEntrustCancelled(lpSub, subscribeIndex, msgType, UfxCombiFutureOptionsEntrustCancelled.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'z':                    
                    OnCombiFutureOptionsEntrustApproving(lpSub, subscribeIndex, msgType, UfxCombiFutureOptionsEntrustApproving.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'A':                    
                    OnShCombiExerciseEntrustReceived(lpSub, subscribeIndex, msgType, UfxShCombiExerciseEntrustReceived.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'B':                    
                    OnShCombiExerciseEntrustConfirmed(lpSub, subscribeIndex, msgType, UfxShCombiExerciseEntrustConfirmed.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'C':                    
                    OnShCombiExerciseEntrustRejected(lpSub, subscribeIndex, msgType, UfxShCombiExerciseEntrustRejected.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'D':                    
                    OnShCombiExerciseEntrustCancelled(lpSub, subscribeIndex, msgType, UfxShCombiExerciseEntrustCancelled.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'E':                    
                    OnShCombiExerciseEntrustCancelRejected(lpSub, subscribeIndex, msgType, UfxShCombiExerciseEntrustCancelRejected.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'F':                    
                    OnShCombiExerciseEntrustApproving(lpSub, subscribeIndex, msgType, UfxShCombiExerciseEntrustApproving.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'G':                    
                    OnShCombiExerciseEntrustCancel(lpSub, subscribeIndex, msgType, UfxShCombiExerciseEntrustCancel.ReadAll(unPacker, dataIndex));
                    break;
                case (sbyte)'H':                    
                    OnShCombiExerciseCancelApproving(lpSub, subscribeIndex, msgType, UfxShCombiExerciseCancelApproving.ReadAll(unPacker, dataIndex));
                    break;
            }
        }

        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 委托下达成功后推送本条委托信息
        /// </summary>
        protected virtual void OnEntrustReceived(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxEntrustReceived[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 委托确认后推送本条委托信息
        /// </summary>
        protected virtual void OnEntrustConfirmed(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxEntrustConfirmed[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 
        /// </summary>
        protected virtual void OnEntrustRejected(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxEntrustRejected[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 对某条委托进行撤单后推送该条委托信息
        /// </summary>
        protected virtual void OnEntrustCancel(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxEntrustCancel[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 对某条委托进行撤单,撤单成功后推送该委托信息
        /// </summary>
        protected virtual void OnEntrustCancelled(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxEntrustCancelled[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 对某条委托进行撤单,撤单失败后推送该委托信息
        /// </summary>
        protected virtual void OnEntrustCancelRejected(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxEntrustCancelRejected[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 委托有成交,成交处理完成后推送成交信息
        /// </summary>
        protected virtual void OnEntrustTrade(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxEntrustTrade[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 委托下达成功后推送本条委托信息(支持深圳股票期权做市\股转做市业务)
        /// </summary>
        protected virtual void OnCombiEntrustReceived(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxCombiEntrustReceived[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 委托确认后推送本条委托信息(支持深圳股票期权做市\股转做市业务)
        /// </summary>
        protected virtual void OnCombiEntrustConfirmed(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxCombiEntrustConfirmed[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 支持深圳股票期权做市\股转做市业务
        /// </summary>
        protected virtual void OnCombiEntrustRejected(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxCombiEntrustRejected[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 对某条委托进行撤单后推送该条委托信息(支持深圳股票期权做市\股转做市业务)
        /// </summary>
        protected virtual void OnCombiEntrustCancel(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxCombiEntrustCancel[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 对某条委托进行撤单,撤单成功后推送该委托信息(支持深圳股票期权做市\股转做市业务)
        /// </summary>
        protected virtual void OnCombiEntrustCancelled(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxCombiEntrustCancelled[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 对某条委托进行撤单,撤单失败后推送该委托信息(支持深圳股票期权做市\股转做市业务)
        /// </summary>
        protected virtual void OnCombiEntrustCancelRejected(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxCombiEntrustCancelRejected[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 上交所股票期权组合保证金委托下达成功后推送本条委托信息
        /// </summary>
        protected virtual void OnCombiOptionsEntrustReceived(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxCombiOptionsEntrustReceived[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 上交所股票期权组合保证金委托确认成功后推送本条委托信息
        /// </summary>
        protected virtual void OnCombiOptionsEntrustConfirmed(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxCombiOptionsEntrustConfirmed[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 上交所股票期权组合保证金委托废单
        /// </summary>
        protected virtual void OnCombiOptionsEntrustRejected(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxCombiOptionsEntrustRejected[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 上交所股票期权组合委托有成交,成交处理完成后推送成交信息
        /// </summary>
        protected virtual void OnCombiOptionsEntrustTrade(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxCombiOptionsEntrustTrade[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 上交所股票期权组合保证金委托撤成 
        /// </summary>
        protected virtual void OnCombiOptionsEntrustCancelled(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxCombiOptionsEntrustCancelled[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 需要审批的委托,下达后状态为待审批,审批通过后状态为未报.支持审批拒绝.
        /// </summary>
        protected virtual void OnEntrustApproving(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxEntrustApproving[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 公用
        /// 功能名称: 需要审批的撤单委托,下达后状态为待审批.
        /// </summary>
        protected virtual void OnEntrustCancelApproving(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxEntrustCancelApproving[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 委托下达成功后推送本条委托信息
        /// </summary>
        protected virtual void OnCombiFutureOptionsEntrustReceived(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxCombiFutureOptionsEntrustReceived[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 委托确认后推送本条委托信息
        /// </summary>
        protected virtual void OnCombiFutureOptionsEntrustConfirmed(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxCombiFutureOptionsEntrustConfirmed[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 委托废单后推送本条废单消息
        /// </summary>
        protected virtual void OnCombiFutureOptionsEntrustRejected(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxCombiFutureOptionsEntrustRejected[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 对某条委托进行撤单,撤单成功后推送该委托信息
        /// </summary>
        protected virtual void OnCombiFutureOptionsEntrustCancelled(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxCombiFutureOptionsEntrustCancelled[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 需要审批的委托,下达后状态为待审批,审批通过后状态为未报.支持审批拒绝.
        /// </summary>
        protected virtual void OnCombiFutureOptionsEntrustApproving(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxCombiFutureOptionsEntrustApproving[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 委托下达成功后推送本条委托信息
        /// </summary>
        protected virtual void OnShCombiExerciseEntrustReceived(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxShCombiExerciseEntrustReceived[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 委托确认后推送本条委托信息
        /// </summary>
        protected virtual void OnShCombiExerciseEntrustConfirmed(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxShCombiExerciseEntrustConfirmed[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 委托废单后推送本条废单消息
        /// </summary>
        protected virtual void OnShCombiExerciseEntrustRejected(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxShCombiExerciseEntrustRejected[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 对某条委托进行撤单,撤单成功后推送该委托信息
        /// </summary>
        protected virtual void OnShCombiExerciseEntrustCancelled(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxShCombiExerciseEntrustCancelled[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 对某条委托进行撤单,撤单失败后推送该委托信息
        /// </summary>
        protected virtual void OnShCombiExerciseEntrustCancelRejected(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxShCombiExerciseEntrustCancelRejected[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 需要审批的委托,下达后状态为待审批,审批通过后状态为未报.支持审批拒绝.
        /// </summary>
        protected virtual void OnShCombiExerciseEntrustApproving(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxShCombiExerciseEntrustApproving[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 委托撤单
        /// </summary>
        protected virtual void OnShCombiExerciseEntrustCancel(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxShCombiExerciseEntrustCancel[] data)
        {
            
        }        
        /// <summary>
        /// 业务范围: 期权
        /// 功能名称: 需要审批的撤单委托,下达后状态为待审批,审批通过后状态为未报.支持审批拒绝.
        /// </summary>
        protected virtual void OnShCombiExerciseCancelApproving(CT2SubscribeInterface lpSub, int subscribeIndex, sbyte msgType, UfxShCombiExerciseCancelApproving[] data)
        {
            
        }        
    }
}