using UnityEngine;

namespace Stategy
{
    public class Context : MonoBehaviour
    {
        Strategy strategy;

        public void ShowStrategyAlgorithm()
        {
            if (this.strategy == null)
            {
                Debug.Log("strategy is null");
            }
            else
            {
                this.strategy.algorithm();
            }
        }

        public void SetStrategy(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStragtegyOne()
        {
            this.SetStrategy(new Strategy1());
        }

        public void SetStragtegyTwo()
        {
            this.SetStrategy(new Strategy2());
        }
    }
}
