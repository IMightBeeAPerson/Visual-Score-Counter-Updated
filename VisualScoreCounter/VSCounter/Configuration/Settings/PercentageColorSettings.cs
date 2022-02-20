﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VisualScoreCounter.VSCounter.Configuration {

    class PercentageColorSettings {

		public virtual Color Color_100 { get; set; } = DefaultColor_100;
		public virtual Color Color_99 { get; set; } = DefaultColor_99;
		public virtual Color Color_98 { get; set; } = DefaultColor_98;
		public virtual Color Color_97 { get; set; } = DefaultColor_97;
		public virtual Color Color_96 { get; set; } = DefaultColor_96;
		public virtual Color Color_95 { get; set; } = DefaultColor_95;
		public virtual Color Color_94 { get; set; } = DefaultColor_94;
		public virtual Color Color_93 { get; set; } = DefaultColor_93;
		public virtual Color Color_92 { get; set; } = DefaultColor_92;
		public virtual Color Color_91 { get; set; } = DefaultColor_91;
		public virtual Color Color_90 { get; set; } = DefaultColor_90;
		public virtual Color Color_89 { get; set; } = DefaultColor_89;
		public virtual Color Color_88 { get; set; } = DefaultColor_88;
		public virtual Color Color_80 { get; set; } = DefaultColor_80;
		public virtual Color Color_65 { get; set; } = DefaultColor_65;
		public virtual Color Color_50 { get; set; } = DefaultColor_50;
		public virtual Color Color_35 { get; set; } = DefaultColor_35;
		public virtual Color Color_20 { get; set; } = DefaultColor_20;
		public virtual Color Color_0 { get; set; } = DefaultColor_0;

        public static Color DefaultColor_100 = new Color(1.0f, 1.0f, 1.0f);
        public static Color DefaultColor_99 = new Color(1.0f, 1.0f, 0.68846f);
        public static Color DefaultColor_98 = new Color(0.1371948f, 0.9527207f, 0.250269f);
        public static Color DefaultColor_97 = new Color(0.9107788f, 1.0f, 0.0f);
        public static Color DefaultColor_96 = new Color(1.0f, 0.5137255f, 0.07058824f);
        public static Color DefaultColor_95 = new Color(0.9706014f, 0.7994141f, 0.9706014f);
        public static Color DefaultColor_94 = new Color(0.4726773f, 0.02532541f, 0.8719445f);
        public static Color DefaultColor_93 = new Color(0.9054167f, 1.0f, 0.0f);
        public static Color DefaultColor_92 = new Color(0.3497706f, 1.0f, 0.3794441f);
        public static Color DefaultColor_91 = new Color(0.4745098f, 0.6597694f, 1.0f);
        public static Color DefaultColor_90 = new Color(0.7176471f, 0.9803922f, 1.0f);
        public static Color DefaultColor_89 = Color.white;
        public static Color DefaultColor_88 = Color.white;
        public static Color DefaultColor_80 = Color.gray;
        public static Color DefaultColor_65 = Color.green;
        public static Color DefaultColor_50 = Color.yellow;
        public static Color DefaultColor_35 = new Color(1.0f, 0.5f, 0.0f);
        public static Color DefaultColor_20 = Color.red;
        public static Color DefaultColor_0 = Color.red;

	}
}
