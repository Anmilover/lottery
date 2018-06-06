﻿using System.Collections.Generic;

namespace Colin.Lottery.Models
{
    /// <summary>
    /// 预测数据模型接口
    /// </summary>
    public interface IForcastModel
    {
        /// <summary>
        /// 玩法规则
        /// </summary>
        /// <value>The rule.</value>
        string Rule { get; set; }

        /// <summary>
        /// 期号范围
        /// </summary>
        string PeriodRange { get; set; }

        /// <summary>
        /// 预测号码
        /// </summary>
        string ForcastNo { get; set; }

        /// <summary>
        /// 追号次数
        /// </summary>
        int ChaseTimes { get; set; }

        /// <summary>
        /// 是否中奖
        /// </summary>
        bool? IsWin { get; set; }

        /// <summary>
        /// 截至期号
        /// </summary>
        long LastPeriod { get; set; }

        /// <summary>
        /// 开奖号码
        /// </summary>
        string DrawNo { get; set; }
        
        /// <summary>
        /// 挂-分数
        /// </summary>
        float GuaScore { get; set; }

        /// <summary>
        /// 号码重复度-分数
        /// </summary>
        float RepetitionScore { get; set; }

        /// <summary>
        /// 追号次数-分数
        /// </summary>
        float BetChaseScore { get; set; }

        /// <summary>
        /// 最新期评测分数
        /// </summary>
        float Score { get; set; }

        /// <summary>
        /// 中奖概率
        /// </summary>
        float WinProbability { get; set; }
    }

    /// <summary>
    /// 预测数据集模型接口
    /// </summary>
    public interface IForcastPlanModel
    {
        /// <summary>
        /// 预测数据
        /// </summary>
        List<IForcastModel> ForcastData { get; set; }

        /// <summary>
        /// 最新一期开奖期号
        /// </summary>
        long LastDrawedPeriod { get; set; }

        /// <summary>
        /// 最新一期开奖号码
        /// </summary>
        string LastDrawNo { get; set; }

        /// <summary>
        /// 统计有效期数
        /// </summary>
        int TotalCount { get; set; }

        /// <summary>
        /// 中奖期数
        /// </summary>
        int WinCount { get; set; }

        /// <summary>
        /// 未中奖期数
        /// </summary>
        int LoseCount { get; set; }

        /// <summary>
        /// 中奖概率
        /// </summary>
        float WinProbability { get; set; }

        /// <summary>
        /// 挂-分数
        /// </summary>
        float GuaScore { get; set; }

        /// <summary>
        /// 号码重复度-分数
        /// </summary>
        float RepetitionScore { get; set; }

        /// <summary>
        /// 追号次数-分数
        /// </summary>
        float BetChaseScore { get; set; }

        /// <summary>
        /// 最新预测评分
        /// </summary>
        float Score { get; set; }

        /// <summary>
        /// 是否处于连挂有效期内
        /// </summary>
        bool KeepGua { get; set; }

        /// <summary>
        /// 从最新期开始连挂次数
        /// </summary>
        int KeepGuaCnt { get; set; }

        /// <summary>
        /// 历史记录(不包含从最新期连挂的情况)出现连挂次数
        /// </summary>
        int KeepHisGuaCnt { get; set; }

        /// <summary>
        /// 最新预测开奖号码
        /// </summary>
        string ForcastDrawNo { get; }
    }
}
