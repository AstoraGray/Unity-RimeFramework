using System;
using RimeFramework.Tool;

namespace RimeFramework.Core
{
    /// <summary>
    /// 最上层，游戏管理器
    /// </summary>
    /// <remarks>Author: AstoraGray</remarks>
    public class RimeManager : Singleton<RimeManager>
    {
        public bool consoles = true;
        public bool controls = true;
        public bool states = true;
        public bool cycles = true;
        public bool pools = true;
        public bool navigations = true;
        public bool scenes = true;
        public bool animators = true;
        public bool audios = true;
        public bool observers = true;

        protected override void Awake()
        {
            base.Awake();
            Init();
        }

        private void Init()
        {
            Consoles.Print(nameof(RimeManager),$"{Environment.UserName}, 欢迎回来!");
            if(consoles) Consoles.Instance.transform.SetParent(transform);
            if(controls) Controls.Instance.transform.SetParent(transform);
            if(states) States.Instance.transform.SetParent(transform);
            if(cycles) Cycles.Instance.transform.SetParent(transform);
            if(pools) Pools.Instance.transform.SetParent(transform);
            if(navigations) Navigations.Instance.transform.SetParent(transform);
            if(scenes) Scenes.Instance.transform.SetParent(transform);
            if(animators) Animators.Instance.transform.SetParent(transform);
            if(audios) Audios.Instance.transform.SetParent(transform);
            if(observers) Observers.Instance.transform.SetParent(transform);
        }
    }
}