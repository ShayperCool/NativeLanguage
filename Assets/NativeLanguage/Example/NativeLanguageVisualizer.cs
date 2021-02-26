using System;
using UnityEngine;
using UnityEngine.UI;

namespace NativeLanguage.Example {
	public class NativeLanguageVisualizer : MonoBehaviour {
		public Text text;
		
		public void Start() {
			text.text = NativeLanguage.GetLanguage();
		}
	}
}