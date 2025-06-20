var texts = UnityEngine.Object.FindObjectsOfType<UnityEngine.UI.TextItalicAdobeStyle>();

foreach (var text in texts) {
	text.text = "Oh mah gah"; } // Change "Oh mah gah" to whatever you want lol, btw this affects EVERY text that uses "TextItalicAdobeStyle".