using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;using Zoork;

namespace Zoork
{


    internal sealed class IteratorPoints : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        [SerializeField] private TMP_InputField _inputField;
        private int amount = 0;
        private void Start()
        {
            _inputField.onValueChanged.AddListener(Interpret);
        }
        private void Interpret(string value)
        {
            if (Int64.TryParse(value, out var number))
            {
                _text.text = ToRoman(number);
            }
        }
        private string ToRoman(long number)
        {
            if ((number < 0) || (number > 3999)) throw new
                ArgumentOutOfRangeException(nameof(number),
                    "insert value betwheen 1 and 3999");
            if (number < 1000) return string.Empty;
            if (number >= 1000000)
            {
                amount++;
                ToRoman(number - 1000000);
                return amount + "M";
            }

            amount = 0;

            if (number >= 1000)
            {
                amount++;
                ToRoman(number - 1000);
                return amount + "k";
            }
            
            amount = 0;
            
            throw new ArgumentOutOfRangeException(nameof(number));
        }

    }
}
