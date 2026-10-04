Step 4

IHasId defines a read-only Id property.
Student and Course implement IHasId.
Store<T> uses the constraint where T : IHasId, so the compiler knows that T has an Id.
StudentStore and CourseStore were deleted and replaced with Store<Student> and Store<Course>.