﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualScoreCounter.VSCounter.Configuration {

    class CounterSettings {
        public virtual float RingScale { get; set; } = 1.0f;
        public virtual bool BloomRing { get; set; } = true;
        public virtual bool PercentageRingShowsNextColor { get; set; } = true;
        public virtual bool HideBaseGameRankDisplay { get; set; } = true;
        public virtual CounterFontSettings CounterFontSettings { get; set; } = new CounterFontSettings();
        public virtual bool BloomFont { get; set; } = true;
        public virtual PercentageColorSettings PercentageColorSettings { get; set; } = new PercentageColorSettings();
        public virtual float CounterXOffset { get; set; } = 0.0f;
        public virtual float CounterYOffset { get; set; } = 0.0f;


    }

}
