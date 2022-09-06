using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoork.UI
{
    internal abstract class BaseUI : MonoBehaviour
    {
        public abstract void Execute();
        public abstract void Cancel();
    }
}
