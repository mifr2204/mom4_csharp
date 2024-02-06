using MyMLApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMLApp
{
    internal class Review
    {

        //Private properties
        private string _text = string.Empty;
        private bool _isPositive = false;

        //Public properties
        public string Text
        {
            get => _text;
            set {
                _text = value;
                this._determineSentiment();
            }
        }

        public bool IsPositive
        {
            get {
                return this._isPositive; 
            }
        }

        //Constructor
        public Review(string text)
        {
            this.Text = text;
        }

        //Determine sentiment from review text
        private void _determineSentiment()
        {
            var modelData = new SentimentModel.ModelInput()
            {
                Col0 = this.Text
            };

            //1 is "positive", 0 is "negative"
            SentimentModel.ModelOutput prediction = SentimentModel.Predict(modelData);

            if (prediction.PredictedLabel == 1) {
                this._isPositive = true;
            } else {
                this._isPositive = false;
            }
        }

    }
}
