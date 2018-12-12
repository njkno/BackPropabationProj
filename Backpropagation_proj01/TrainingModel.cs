using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Backpropagation_proj01
{
    public class TrainingModel
    {
        private decimal[] _InputNodes;
        private decimal[] _HiddenNodes;
        private decimal[] _OutputNodes;
        private decimal[] _HiddenDiff;
        private decimal[] _OutputDiff;
        private WeightConnection _WeightConnection;
        private int _outputNodesNum { get; set; }
        private decimal _StardardValue { get; set; }

        public TrainingModel(int InputNodeNum, decimal stardardValue, int outputNodesNum)
        {
            _StardardValue = stardardValue;
            _outputNodesNum = outputNodesNum;
            InitNode(outputNodesNum, InputNodeNum * 2);
            _WeightConnection = new WeightConnection(InputNodeNum, outputNodesNum, InputNodeNum * 2);

        }

        private void InitNode(int alfterNum, int minNum)
        {
            _HiddenNodes = new decimal[minNum];
            _OutputNodes = new decimal[alfterNum];
            _HiddenDiff = new decimal[minNum];
            _OutputDiff = new decimal[alfterNum];

        }

        private void Activate(decimal[] inputNodes)
        {
            CalculateSum(inputNodes, _HiddenNodes, _WeightConnection.beforeWeights);
            CalculateSum(_HiddenNodes, _OutputNodes, _WeightConnection.alfterWeights);
        }

        private void CalculateSum(decimal[] inputNodes, decimal[] outputNodes, decimal[,] Weights)
        {
            for (int i = 0; i < outputNodes.Length; i++)
            {
                decimal x = 0;
                for (int j = 0; j < inputNodes.Length; j++)
                {
                    x += inputNodes[j] + Weights[j, i];
                }
                var value = 1 / (1 + (decimal)Math.Pow(Math.E, (double)(x * -1)));
                outputNodes[i] = Math.Round(value, 1); 
            }
        }

        public decimal[] OutputModel(decimal[] inputNodes)
        {
            Activate(inputNodes);
            return _OutputNodes;
        }
        public void Trainning(decimal[] inputNodes, decimal[] actual)
        {
            _InputNodes = inputNodes;
            Activate(inputNodes);
            Learning(actual);
        }

        private void Learning(decimal[] actual)
        {
            for (int i = 0; i < _OutputDiff.Length; i++)
            {
                _OutputDiff[i] = (actual[i] - _OutputNodes[i]) * _OutputNodes[i] * (1 - _OutputNodes[i]);
            }

            for (int i = 0; i < _HiddenNodes.Length; i++)
            {
                for (int j = 0; j < _OutputNodes.Length; j++)
                {
                    var increteWeights = _WeightConnection.rate * _OutputDiff[j] * _HiddenNodes[i];
                    _WeightConnection.alfterWeights[i, j] += increteWeights;
                }
            }

            for (int i = 0; i < _HiddenDiff.Length; i++)
            {
                decimal value = 0;
                for (int j = 0; j < _OutputDiff.Length; j++)
                {
                    value += _OutputDiff[j] * _WeightConnection.alfterWeights[i, j];
                }

                _HiddenDiff[i] = _HiddenNodes[i] * (1 - _HiddenNodes[i]) * value;
            }

            for (int i = 0; i < _InputNodes.Length; i++)
            {
                for (int j = 0; j < _HiddenNodes.Length; j++)
                {
                    var increteWeights = _WeightConnection.rate * _HiddenDiff[j] * _InputNodes[i];
                    _WeightConnection.beforeWeights[i, j] += increteWeights;
                }
            }
        }
    }
    //public class Node
    //{
    //    public decimal Sum { get; set; }
    //}

    public class WeightConnection
    {
        public decimal[,] beforeWeights;
        public decimal[,] alfterWeights;
        public decimal rate = 1;

        public WeightConnection(int beforeNum, int alfterNum, int minNum)
        {
            alfterWeights = new decimal[minNum, alfterNum];
            beforeWeights = new decimal[beforeNum, minNum];
            InitArray(beforeNum, alfterNum, minNum);
        }

        private void InitArray(int beforeNum, int alfterNum, int minNum)
        {
            var rand = new Random(GetHashCode());

            for (int i = 0; i < minNum; i++)
            {
                for (int j = 0; j < alfterNum; j++)
                {
                    alfterWeights[i, j] = Convert.ToDecimal(rand.Next(-10, 10)) / 10;
                }
            }

            for (int i = 0; i < beforeNum; i++)
            {
                for (int j = 0; j < minNum; j++)
                {
                    beforeWeights[i, j] = Convert.ToDecimal(rand.Next(-10, 10)) / 10;
                }
            }
        }
    }
}
