﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atcFtableBuilder
{
    class FTableCalcOCWeirRectangular : FTableCalculator, IFTableOperationsOC
    {
        public double WeirWidth = -999;
        public double Height = -999;
        private double pWeirInvert = -999;
        public double WeirInvert
        {
            get { return pWeirInvert; }
            set { pWeirInvert = value; }
        }
        int pExit;
        public override int myExit
        {
            get { return pExit; }
            set { pExit = value; }
        }
        public double DischargeCoefficient = -999;
        private string[] gOCWeirRectLbl = { "Weir Crest Length", "Invert Height above Channel Bottom", "Discharge Coefficient" };
        private double[] DefaultsWeirRect = { 10, 5, 3.33 }; // Need to check this value
        public override ControlDeviceType ControlDevice
        {
            get
            {
                return ControlDeviceType.WeirRectangular;
            }
        }

        public FTableCalcOCWeirRectangular()
        {
            vectorColNames.Clear();
            vectorColNames.Add("DEPTH");
            vectorColNames.Add("AREA");
            vectorColNames.Add("VOLUME");
            vectorColNames.Add("OUTFLOW");
        }

        public Dictionary<string, double> ParamValueDefaults()
        {
            Dictionary<string, double> defaults = new Dictionary<string, double>();
            for (int i = 0; i <= gOCWeirRectLbl.Length - 1; i++)
            {
                defaults.Add(gOCWeirRectLbl[i], DefaultsWeirRect[i]);
            }
            return defaults;
        }
        public override Dictionary<string, double> ParamValues()
        {
            double[] CurrentParamValues = { WeirWidth, WeirInvert, DischargeCoefficient };
            Dictionary<string, double> lParams = new Dictionary<string, double>();
            for (int i = 0; i <= gOCWeirRectLbl.Length - 1; i++)
            {
                lParams.Add(gOCWeirRectLbl[i], CurrentParamValues[i]);
            }
            return lParams;
        }

        public override bool SetParamValues(Dictionary<string, double> aParams)
        {
            int lUpdateCtr = 0;
            double lValue = 0;
            foreach (string lKey in aParams.Keys)
            {
                if (lKey == gOCWeirRectLbl[0])
                {
                    if (aParams.TryGetValue(lKey, out lValue))
                    {
                        WeirWidth = lValue;
                        lUpdateCtr += 1;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (lKey == gOCWeirRectLbl[1])
                {
                    if (aParams.TryGetValue(lKey, out lValue))
                    {
                        WeirInvert = lValue;
                        lUpdateCtr += 1;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (lKey == gOCWeirRectLbl[2])
                {
                    if (aParams.TryGetValue(lKey, out lValue))
                    {
                        DischargeCoefficient = lValue;
                        lUpdateCtr += 1;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (lUpdateCtr == gOCWeirRectLbl.Length)
                return true;
            else
                return false;
        }

        public override FTableCalculator Clone()
        {
            FTableCalcOCWeirRectangular lClone = new FTableCalcOCWeirRectangular();
            lClone.myExit = this.myExit;
            lClone.WeirWidth = this.WeirWidth;
            lClone.WeirInvert = this.WeirInvert;
            lClone.DischargeCoefficient = this.DischargeCoefficient;
            return lClone;
        }

        public override ArrayList GenerateFTableOC()
        {
            return GenerateFTable(WeirWidth, Height, WeirInvert, DischargeCoefficient);
        }
        public ArrayList GenerateFTable(double aChannelLength, double aHeight, double aChannelManningsValue, double aDischargeCoefficient)
        {
            ArrayList vectorRowData = new ArrayList();
            //Flow Area Calculations
            double L = aChannelLength;
            double N = aChannelManningsValue;
            double DT = aHeight;
            //double S = longitudalChannelSlope;
            //double w = topChannelWidth;		      
            double Cw = aDischargeCoefficient;

            ArrayList row = new ArrayList();

            double QC = 0.0;
            double acr = 0.0;
            double stot = 0.0;

            double prevAcr = 0.0; ;
            double prevStot = 0.0;
            double R1 = 0.0;

            string sDepth = "";
            string sArea = "";
            string sVolume = "";
            string sOutFlow = "";
            string lFormat = "{0:0.00000}";
            for (double g = N; g < 1000.0; g += FTableCalculatorConstants.calculatorIncrement)
            {
                if (g >= N)
                {
                    R1 = g - N;
                }

                //QC = 3.21 * Math.pow(R1,1.5) * (L-0.2*R1); 
                //Cw  = US(3.21), SI
                //Qmaz = (L/(R1*.2)-1.666);
                //if(Qmaz < 0.001) {
                //   Qmax = Cw * Math.pow(R1,1.5) * (L-0.2*R1);
                //}

                //    with full contraction
                QC = Cw * Math.Pow(R1, 1.5) * (L - 0.2 * R1);
                //} else {
                //   QC =0;
                //} 
                //System.out.print(Qmax);
                //System.out.println("      ");  

                prevStot = stot;
                prevAcr = acr;

                row = new ArrayList();

                sDepth = string.Format(lFormat, (object)g);
                sArea = string.Format(lFormat, (object)acr);
                sVolume = string.Format(lFormat, (object)stot);
                sOutFlow = string.Format(lFormat, (object)QC);
                row.Add(sDepth);
                row.Add(sArea);
                row.Add(sVolume);
                row.Add(sOutFlow);

                vectorRowData.Add(row);
            }
            return vectorRowData;
        }
    }
}
