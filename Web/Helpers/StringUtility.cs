﻿using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;


/// <summary>
/// 表示层帮助通用类
/// </summary>
public static class StringUtility
{
    /// <summary>
    /// 截断字符串
    /// </summary>
    /// <param name="content"></param>
    /// <param name="num"></param>
    /// <returns></returns>
    public static string CutString(object content, int num)
    {
        if (content.ToString().Length > num - 2)
            return content.ToString().Substring(0, num - 2) + "...";
        else
            return content.ToString();
    }
    /// <summary>
    /// 货币
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static string ToMoney(object obj)
    {
        return String.Format("{0:C}", obj);
    }
    /// <summary>
    /// 短日期
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static string ToShortDate(object obj)
    {
        return Convert.ToDateTime(obj).ToShortDateString();
    }

}

