using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Handiness.Winform
{



    /// <summary>
    /// 窗体动画
    /// </summary>
    public class WindowAnimation
    {
        /// <summary>
        /// 显示标志位
        /// </summary>
        public static  Int32 ShowFlag { get;private set; } = WindowsConstants.AW_ACTIVATE;
        /// <summary>
        /// 隐藏标志位
        /// </summary>
        public static  Int32 HideFlag { get;private set; } = WindowsConstants.AW_HIDE;
        /************/
        /// <summary>
        /// 是否开启窗体动画
        /// </summary>
        [Description("是否开启窗体动画，默认开启")]
        public Boolean Enabled { get; set; } = true;
        /// <summary>
        /// 窗体动画效果的持续时间，单位：us，默认 200 us。
        /// </summary>
        [Description("窗体动画效果的持续时间，单位：us，默认 200 us。")]
        public Int32 AnimationTime { get; set; } = 200;
        /// <summary>
        /// 窗体显示时动画的类型
        /// </summary>
        [Description("窗体显示时动画的类型")]
        public WindowAnimationStyle Show
        {
            get; set;
        } = WindowAnimationStyle.Center;

        /// <summary>
        /// 窗体隐藏时动画的类型
        /// </summary>
        [Description("窗体隐藏时动画的类型")]
        public WindowAnimationStyle Hide { get; set; } = WindowAnimationStyle.Center;

        public Int32 ShowAnimationFlag()
        {
            return (Int32)this.Show | ShowFlag;
        }
        public Int32 HideAnimationFlag()
        {
            return (Int32)this.Hide | HideFlag;
        }
    }
    /// <summary>
    /// 窗体动画风格
    /// </summary>
    public enum WindowAnimationStyle
    {
        /// <summary>
        /// 自左往右滑动
        /// </summary>
        LeftToRight = WindowsConstants.AW_SLIDE | WindowsConstants.AW_HOR_POSITIVE,
        /// <summary>
        /// 自右往左滑动
        /// </summary>
        RightToLeft = WindowsConstants.AW_SLIDE | WindowsConstants.AW_HOR_NEGATIVE,
        /// <summary>
        /// 淡入淡出效果
        /// </summary>
        Fade = WindowsConstants.AW_BLEND,
        /// <summary>
        ///扩散
        /// </summary>
        Center = WindowsConstants.AW_CENTER,
        /// <summary>
        /// 自上而下滑动
        /// </summary>
        TopToBottom = WindowsConstants.AW_SLIDE | WindowsConstants.AW_VER_POSITIVE,
        /// <summary>
        /// 自下而上滑动
        /// </summary>
        BottomToTop = WindowsConstants.AW_SLIDE | WindowsConstants.AW_VER_NEGATIVE

    }
}
