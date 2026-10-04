# Generics Answers

## Step 2

The two stores are similar because both store objects in a list and provide the same four operations:
Add, GetById, GetAll, and Remove.

The difference is the type they store:
StudentStore stores Student objects, while CourseStore stores Course objects.
The code is almost identical, but it has to be duplicated for each type.

## Step 3

The compiler error is:

`CS1061: 'T' does not contain a definition for 'Id'`

The compiler rejects `item.Id` because T can be any type.
At this point, the compiler does not know that T has an Id property.

## Step 4

IHasId defines a read-only Id property.
Student and Course implement IHasId.
Store<T> uses the constraint `where T : IHasId`, so the compiler knows that T has an Id.
StudentStore and CourseStore were deleted and replaced with Store<Student> and Store<Course>.

## Step 7

`Store<string>` must not compile because Store<T> requires T to implement IHasId, and string does not implement IHasId.

The duplicate student ID throws an exception with a clear message.

`Page(2, 2)` returns the third and fourth students because page numbering starts from 1.

`FindById` can also be used with a plain `List<Course>` because the extension method works with any `IEnumerable<T>` where T implements IHasId.

## Final Question

The common name for the kind of class built in Steps 4 and 5 is a **generic repository** (or generic data store).