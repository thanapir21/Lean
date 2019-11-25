﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using System.Runtime.CompilerServices;
using Python.Runtime;
using QuantConnect.Python;


namespace QuantConnect.Report.ReportElements
{
    internal abstract class ChartReportElement : ReportElement
    {
        internal static dynamic Charting;

        /// <summary>
        /// Charting base class report element
        /// </summary>
        protected ChartReportElement()
        {
            PythonInitializer.Initialize();

            using (Py.GIL())
            {
                dynamic module = PythonEngine.ImportModule("ReportCharts");

                var classObj = module.ReportCharts;

                Charting = classObj.Invoke();
            }
        }

        public PyConverter DictionaryConverter()
        {
            using (Py.GIL())
            {
                var converter = new PyConverter();  //create a instance of PyConverter
                converter.AddListType();
                converter.Add(new StringType());
                converter.Add(new Int64Type());
                converter.Add(new Int32Type());
                converter.Add(new FloatType());
                converter.Add(new PyListType<double>(DoubleListConverter()));
                converter.AddDictType<string, object>();
                return converter;
            }
        }

        public PyConverter DoubleListConverter()
        {
            using (Py.GIL())
            {
                var converter = new PyConverter();
                converter.AddListType();
                converter.Add(new DoubleType());
                return converter;
            }
        }
    }
}