using System.Collections.Generic;

namespace LinqBackgroundKnowledge.Extensions {
    public delegate bool GenericChecker<TypeOfItemToCheck>(TypeOfItemToCheck itemToCheck);
    public delegate TypeOfTheOutputSelection GenericInputAndOutputSelector<TypeOfTheInputSelection, TypeOfTheOutputSelection>(TypeOfTheInputSelection inputItem);
    public static class MyExtensions {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> collectionToFilter, GenericChecker<T> checkTheItem) {
            foreach (T item in collectionToFilter) {
                if (checkTheItem(item)) {
                    yield return item;
                }
            }
        }

        public static IEnumerable<TOut> Select<TIn, TOut>(this IEnumerable<TIn> inputCollection, GenericInputAndOutputSelector<TIn, TOut> selectTheOutput) {
            foreach (TIn item in inputCollection) {
                yield return selectTheOutput(item);
            }
        }
    }
}
