the 'is a' relationship describes how a parent
vairables type can 'point' to a chind of that type.
The rule always flows uphill, in that a child 'is a'
parent, as in a SunbeamTiger is a Vehicle; a Person
is a Animal, and so on. But once you use the parent
variable to hold a reference to the child, there is a potential
problem: the parent variable only knows about behaviors defined
in the parent class. so even though the parent can successfully 
hold a reference to its child, it doesn't actually know of any 
of the child's specific behaviors.

But, in using this trick, we can treat any number of sub-classed child
vehicle type as the same. That's the essence of polymorphism
("Many Meanings")