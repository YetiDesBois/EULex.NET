﻿//
// Copyright 2016 Bertrand Lorentz
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Xml.Serialization;

namespace EULex.Model
{
    [XmlType (Namespace="http://eur-lex.europa.eu/search")]
    public partial class Date
    {
        string date_value;

        [XmlElement ("VALUE")]
        public string Value {
            get {
                if (date_value != null) {
                    return date_value;
                } else {
                    return $"{Year}-{Month}-{Day}";
                }
            }
            set {
                date_value = value;
            }
        }

        [XmlElement ("DAY", DataType="positiveInteger")]
        public string Day { get; set; }

        [XmlElement ("MONTH", DataType="positiveInteger")]
        public string Month { get; set; }

        [XmlElement ("YEAR", DataType="gYear")]
        public string Year { get; set; }

        [XmlElement ("ANNOTATION")]
        public Annotation Annotation { get; set; }
    }
}
