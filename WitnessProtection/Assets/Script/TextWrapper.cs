using System.Text;
using UnityEngine;

namespace Assets
{
    [RequireComponent(typeof(TextMesh))]
    public class TextWrapper : MonoBehaviour
    {

        public int MaxWidth = 40;

        private TextMesh _textMesh;

        public void Awake()
        {
            _textMesh = this.GetComponent<TextMesh>();
        }

        public void Wrap()
        {
            var stringBuilder = new StringBuilder();

            var words = _textMesh.text.Split(' ');

            var lineWidth = 0f;

            foreach (var word in words)
            {
                var wordWidth = word.Length + 1;

                if (lineWidth + wordWidth > this.MaxWidth)
                {
                    stringBuilder.AppendLine();
                    stringBuilder.Append(word);
                    stringBuilder.Append(" ");
                    lineWidth = word.Length;
                }
                else
                {
                    stringBuilder.Append(word);
                    stringBuilder.Append(" ");
                    lineWidth += wordWidth;
                }
            }

            _textMesh.text = stringBuilder.ToString();
        }
    }
}
