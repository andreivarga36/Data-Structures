This repository contains manual implementations of essential data structures (IntArray, SortedIntArray, List, SortedList, and ListAsReadOnly) with comprehensive unit tests, ensuring reliability. Ideal for algorithm development, data storage optimization and performance enhancement

---

## IntArray
The IntArray class provides a manual implementation of an array data structure for manipulating sequences of integers in C#. It offers essential functionalities such as adding, removing, searching, and inserting elements, along with array resizing operations

---

## SortedIntArray 
This class extends the functionality of the IntArray class by providing an implementation of an automatically sorted array. It ensures that elements are kept in sorted order immediately after their addition or insertion into the array

---

## List<T>
The List<T> class provides a manual implementation of a generic list which is compatible with the IList<T> interface. This implementation also includes exception handling to ensure proper and safe usage of list operations

---

## SortedList<T>
The SortedList<T> class extends the functionality of the List<T> class by providing a sorted collection of elements. It ensures that elements are maintained in sorted order, based on their natural ordering defined by the IComparable<T> interface. This implementation leverages the IComparable<T> interface to compare elements and enforce the sorted order efficiently

--- 

## ReadOnlyList<T>
The ReadOnlyList<T> class provides read-only access to the elements of an existing list, implementing the IList<T>. It ensures that elements cannot be modified once the list is initialized, providing a safe and immutable view of the underlying list. Also, supports efficient enumeration of elements through the IEnumerable<T> interface, allowing traversal without modification

---

## ObjectEnumerator 
The ObjectEnumerator class provides a simple implementation of an enumerator for iterating through a list of objects. This implementation is suitable for scenarios where manual enumeration of objects is required, providing a straightforward and efficient mechanism for iterating through collections

---
