# Part 03 — answers

---

## Blocked Users

- Before time complexity: O(n × m)
- Before time: 25 ms
- Before found: 5000

- What was the problem?
  CountBlocked used List.Contains for every request ID. List.Contains performs a linear search, so the method became slow when the lists were large.

- What did you change?
  I created a HashSet<int> from the blocked IDs and used HashSet.Contains to check each request ID.

- After time complexity: O(n + m)
- After time: 1 ms
- After found: 5000

---

## Students

- What was the problem?
  StudentCatalog created one million Student objects and stored them in a List even though Program.cs only printed the first three students.

- What did you change?
  I changed GetAllStudents to return IEnumerable<Student> and used yield return so students are created lazily, one at a time, only when requested.

- Result:
  The program still prints the first three students, but it does not create all one million students before the foreach starts.