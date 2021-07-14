using System;
using System.Collections;

namespace LinqBackgroundKnowledge.EnumeratorDemos {
    public class ItalianDays : IEnumerable {
        public IEnumerator GetEnumerator() {
            return new ItalianDaysEnumerator();
        }

        private class ItalianDaysEnumerator : IEnumerator {

            private int index = -1;

            public object Current => index switch {
                0 => "lunedi",
                1 => "martedi",
                2 => "mercoledi",
                3 => "giovedi",
                4 => "venerdi",
                5 => "sabato",
                6 => "domenica",
                _ => null
            };

            public bool MoveNext() {
                Console.WriteLine("The MoveNext has been invoked");
                index++;
                if (index >= 7) { return false; } else { return true; }
            }

            public void Reset() {
                index = -1;
            }
        }

    }
}
