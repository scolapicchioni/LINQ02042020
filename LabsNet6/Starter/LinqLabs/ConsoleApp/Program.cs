namespace ConsoleApp;

class Program {
    static void Main() {
        AggregateOperatorsExercises();

        //QuantifierExercises();
        //ElementOperationExercises();
        //SetOperationExercises();
        //SequenceOperationExercises();

        //ProjectionExercises();
        //GroupingExercises();
        //GroupingIntoExercises();

        //SelectManyExercises();
        //JoinExercises();
        //LeftJoinExercises();

        //MegaChallenge.OMG();

        //FoodForThoughtQueries

        //AdventOfCode2022

        //ExtraOpdrachten

        Console.ReadLine();
    }

    private static void LeftJoinExercises() {
        LeftJoin.LeftJoinQquery();
        LeftJoin.LeftJoinQqueryWithDefaultBuilding();
        LeftJoin.GroupJoinQquery();
        LeftJoin.LeftOuterJoin();
    }

    private static void JoinExercises() {
        JoinOperations.InnerJoinQuery();
        JoinOperations.ProductsWithPrices();
        JoinOperations.ProductVendorOfferings();
        JoinOperations.ProductVendorOfferingsGrouped();
    }

    private static void SelectManyExercises() {
        SelectManyOperations.Where_SevenEleven1();
        SelectManyOperations.Where_SevenEleven2();
        SelectManyOperations.SelectFromChildSequence();
        SelectManyOperations.SelectManyWithWhere();
        SelectManyOperations.SelectMultipleWhereClauses();
    }

    private static void GroupingIntoExercises() {
        GroupingInto.MaxGrouped();
        GroupingInto.AverageGrouped();
        GroupingInto.GroupedCount();
        GroupingInto.SumGrouped();
        GroupingInto.GroupedAnyMatchedElements();
        GroupingInto.GroupedAllMatchedElements();
        GroupingInto.GroupByProperty();
        GroupingInto.GroupByCategory();
        GroupingInto.NestedGrouBy();
    }

    private static void GroupingExercises() {
        Groupings.GroupEmployeeByGender();
        Groupings.GroupByCategory();
        Groupings.Group_Vendor_With_Bike_Or_Bycicle_In_Its_Name();
        Groupings.GroupByProperty();
    }

    private static void ProjectionExercises() {
        Projections.SelectProperty();
        Projections.SelectProperty2();
        Projections.TransformWithSelect();
        Projections.SelectByCaseAnonymous();
        Projections.SelectByCaseTuple();
        Projections.SelectNewAnonymous();
        Projections.SelectTuple();
        Projections.SelectPropertySubset();
        Projections.SelectWithIndex();
        Projections.LowestScoreOfEachPlayer();
        Projections.Single_EmployeesWithManager();
    }

    private static void SequenceOperationExercises() {
        SequenceOperations.EqualSequence();
        SequenceOperations.ConcatProjection();
        SequenceOperations.Zip();
    }

    private static void SetOperationExercises() {
        SetOperations.DistinctSyntax();
        SetOperations.DistinctPropertyValues();
        SetOperations.DistinctBy();
        SetOperations.UnionSyntax();
        SetOperations.UnionBy();
        SetOperations.IntersectSynxtax();
        SetOperations.IntersectBy();
        SetOperations.DifferenceOfSets();
        SetOperations.ExceptBy();
    }

    private static void ElementOperationExercises() {
        ElementOperations.FirstElement();
        ElementOperations.FirstMatchingElement();
        ElementOperations.MaybeFirstElement();
        ElementOperations.MaybeFirstMatchingElement();
        ElementOperations.FirstMatchingElementOrNewBuilding();
        ElementOperations.ElementAtPosition();
        ElementOperations.ElementAtFromEnd();
    }

    private static void QuantifierExercises() {
        Quantifiers.AnyMatchingElements();
        Quantifiers.SickLeaveHoursLessThan21();
        Quantifiers.AllMatchedElements();
    }

    private static void AggregateOperatorsExercises() {
        AggregateOperators.CountSyntax();
        AggregateOperators.CountConditional();
        AggregateOperators.SickLeaveHours();
        AggregateOperators.SumSyntax();
        AggregateOperators.SumProjection();
        AggregateOperators.MinSyntax();
        AggregateOperators.MinProjection();
        AggregateOperators.MaxSyntax();
        AggregateOperators.MaxProjection();
        AggregateOperators.AverageSyntax();
        AggregateOperators.AverageProjection();
        AggregateOperators.SeededAggregate();
        AggregateOperators.NestedCount();
    }


}
