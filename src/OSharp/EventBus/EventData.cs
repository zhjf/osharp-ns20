﻿// -----------------------------------------------------------------------
//  <copyright file="EventData.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2017-09-18 12:40</last-date>
// -----------------------------------------------------------------------

using System;


namespace OSharp.EventBus
{
    /// <summary>
    /// 事件源数据信息
    /// </summary>
    public class EventData : IEventData
    {
        /// <summary>
        /// 初始化一个<see cref="EventData"/>类型的新实例
        /// </summary>
        public EventData()
        {
            EventTime = DateTime.Now;
        }

        /// <summary>
        /// 获取 事件发生时间
        /// </summary>
        public DateTime EventTime { get; }

        /// <summary>
        /// 获取或设置 触发事件的对象
        /// </summary>
        public object EventSource { get; set; }
    }
}