
Introduction Copied from:

https://docs.google.com/file/d/0BwhCYaYDn8EgNzAzZjA5ZmItNjU3NS00MzQ5LTkwYjMtMDJhNDU5ZTM0MTlh/edit?hl=en


My last column (Jan, 96) talked about the Open-Closed principle. 

This principle is the foundation for building code that is maintainable and reusable. 

It states that well designed code can be extended without modiﬁcation; that in a well designed program new features are added by adding new code, rather than by changing old, already working, code. 

The primary mechanisms behind the Open-Closed principle are abstraction and polymorphism. 
In statically typed languages like C++, one of the key mechanisms that supports abstraction and polymorphism is inheritance. 

It is by using inheritance that we can create derived classes that conform to the abstract polymorphic interfaces deﬁned by pure virtual functions in abstract base classes.

What are the design rules that govern this particular use of inheritance? What are the characteristics of the best inheritance hierarchies? What are the traps that will cause us to create hierarchies that do not conform to the Open-Closed principle? These are the questions that this article will address.

Formal definition for the Principle:

FUNCTIONS THAT USE POINTERS OR REFERENCES TO BASE
CLASSES MUST BE ABLE TO USE OBJECTS OF DERIVED CLASSES
WITHOUT KNOWING IT.

The above is a paraphrase of the Liskov Substitution Principle (LSP). Barbara Liskov ﬁrst
wrote it as follows nearly 8 years ago

What is wanted here is something like the following substitution property: 
for each object o1 of type S there is an object o2 of type T such that 
for all programs P deﬁned in terms of T, the behavior of P is unchanged when o1 is substituted for o2 then S is a subtype of T.
