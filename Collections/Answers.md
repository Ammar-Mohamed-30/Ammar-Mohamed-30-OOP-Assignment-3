# Collections — Answers

---

## Task 2.1 — Research

### IReadOnlyDictionary<TKey, TValue>

`IReadOnlyDictionary<TKey, TValue>` is a read-only view of key/value pairs. It allows the caller to read values by key, check keys, and enumerate the collection, but it does not expose methods for adding or removing items.

A `Dictionary<TKey, TValue>` is a concrete mutable collection. It allows code that has the dictionary to add, remove, and change entries.

A public method can return `IReadOnlyDictionary<TKey, TValue>` instead of `Dictionary<TKey, TValue>` when callers should only be able to read the data. This protects the collection's modification operations and makes the public API clearer.

`IReadOnlyDictionary` does not guarantee a specific ordering.

---

### SortedDictionary<TKey, TValue>

`SortedDictionary<TKey, TValue>` stores key/value pairs and keeps its keys sorted according to its comparer.

A normal `Dictionary<TKey, TValue>` is mainly optimized for fast key lookup and does not provide sorted-key enumeration.

`SortedDictionary` uses a sorted structure, so lookup is generally O(log n), while a `Dictionary` provides average O(1) lookup.

I would choose `SortedDictionary` when I need dictionary-style key lookup and also need the entries to always be enumerated in sorted key order.

---

## Task 2.2 — Pick the Collection

### S1 — Find a student by national ID

**Dictionary**

A Dictionary is the best choice because the national ID can be used as the key and lookup is very fast on average.

### S2 — Course tags with no duplicates

**HashSet**

A HashSet is designed for unique values, so the same tag cannot be stored twice.

### S3 — Student grades in entered order

**List**

A List preserves insertion order and allows duplicate values, so the same grade can appear more than once.

### S4 — Public course price list that callers can only read

**IReadOnlyDictionary**

It allows callers to read the prices by key without exposing add and remove operations.

### S5 — Timetable keyed by session start time and always printed in time order

**SortedDictionary**

It keeps the session start times sorted automatically while still allowing lookup by the key.

### S6 — Results that the caller loops over once and may stop early

**IEnumerable**

IEnumerable is suitable because it can provide the results lazily and allows the caller to stop enumeration early.

---

## Sources

* Microsoft Learn — IReadOnlyDictionary<TKey,TValue>
* Microsoft Learn — SortedDictionary<TKey,TValue>
