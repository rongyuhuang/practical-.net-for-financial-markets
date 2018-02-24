# 第九章 .NET 2.0
Writing is a hard thing, but it is only through writing we come to know how far we can stretch our
imagination.
This chapter is unlike the other chapters where the main theme was mixing business case studies
with technical implementations. The main focus of this chapter is to highlight the new wealth of
technical features introduced in .NET 2.0. Although you can find enhancements in every nook and
cranny of the framework, in this chapter we will address only the major enhancements.
Language Improvements
In .NET 2.0, you will discover language-level improvements such as generics, anonymous methods, and
partial classes that provide ways to increase development productivity. These enhancements can be
generally classified into two levels: compiler-driven features and run-time features. Compiler-driven
features are those that are solely implemented by compilers. A classic example of a compiler-driven fea-
ture is the lock keyword used in C# to achieve thread synchronization; the real magic is performed
by the compiler, which interprets the keyword and accordingly emits Monitor.Enter and Monitor.Exit
statements. Similarly, in .NET 2.0, anonymous methods, partial classes, and iterators are compiler-
driven features aimed at providing greater functionality with less code. On the other hand, generics
are run-time features that have a deep impact on both the IL instruction set and the CLR system. They
are aimed at improving application performance, which is absolutely true in the case of generics.
Generics
With generics in place, the CLR provides the powerful concept of parametric polymorphism, which
has been popular in the object-oriented community. Parametric polymorphism provides a mecha-
nism to parameterize the data types declared inside classes, interfaces, and structures. For example,
using parametric polymorphism, an array can be declared to hold any type of object without know-
ing its actual type; it can store an array of integers, an array of strings, and so on. This provides an
opportunity to write code in a generic and reusable manner without binding it to any specific data
type. As you might have guessed, the name generic was coined because of its capability to write code
without committing to an actual data type and, more important, not compromising the type-safety
feature provided by the CLR. To further illustrate generics, Listing 9-1 demonstrates some serious
problems that have plagued software developers without the support of generics.
447448C H A P T E R 9 ■ . N E T 2 . 0
Listing 9-1. Order Container
using System;
using System.Collections;
class NonGenericOrderContainer
{
//reference type order
public class OrderObj
{
public string Instrument;
public double Quantity;
}
//value type order
public struct OrderStruct
{
public string Instrument;
public double Quantity;
}
static void Main(string[] args)
{
//create order container to store reference type orders
OrderContainer orderObjContainer = new OrderContainer(10);
//Adding orders of reference type
orderObjContainer.AddOrder(new OrderObj());
//Cast Operation
OrderObj orderObj = orderObjContainer.GetOrder(0) as OrderObj;
//create order container to store value type orders
OrderContainer orderStructContainer = new OrderContainer(10);
//Adding orders of value type
//Boxing Cost
orderStructContainer.AddOrder(new OrderStruct());
//Unboxing Cost
OrderStruct orderStruct = orderStructContainer.GetOrder(0)
as OrderStruct;
}
}
public class OrderContainer
{
object[] dataContainers;
int ctr = 0;
//allocate array elements with specified capacity
public OrderContainer(int orderCapacity)
{
dataContainers = new object[orderCapacity];
}
//Add a new Order
public void AddOrder(object order)
{
dataContainers[ctr] = order;
ctr++;
}//Retrieve a specific order
public object GetOrder(int index)
{
return dataContainers[index];
}
}
As you recall from Chapter 2, we discussed how you can use various types of collections to
implement an order container. The container adds an extra layer of abstraction over the internal
data structure used to store orders, thereby providing freedom to tweak the storage implementation
when needed. To examine how this is done, take another look at Listing 9-1, which shows the partial
implementation of an order container. This container is capable of storing any order type. The code
is pretty straightforward and begins with a declaration of a System.Object array. The reason we chose
System.Object was because it is the base class from which both reference and value type classes are
derived.
From a functionality perspective, the code achieves its goal of providing a common order
container for storing all types of orders; however, when looked at from a performance viewpoint,
you will find some serious problems. The first problem is the performance penalty incurred as a result
of the boxing and unboxing operations. For example, OrderStruct is a value type, and when an instance
of it is passed to the Add method of OrderContainer, it first needs to be boxed in order to be stored in
an array of the System.Object type. Similarly, to retrieve an instance of OrderStruct from the order
container, it needs to be unboxed. Both boxing and unboxing are expensive operations that involve
memory allocation resulting in frequent garbage collections. Certainly, to avoid the performance tax
associated with value types, you can use reference types. But with reference types, you lose compile-
time type-safety features; therefore, type mismatch errors that are detected early during the compilation
phase can be traced only at runtime. Second, a performance penalty is incurred as a result of the cast
operation that occurs when System.Object is assigned to an actual reference type. Unfortunately,
you do not have an easy way to create a type-specific data structure that provides compile-time
type safety without jeopardizing performance.
However, with the advent of generics in .NET 2.0, developers do not need to worry about type
safety and performance issues and can achieve the long-dreamed-of task of creating type-specific
data structures. Generics are first-class citizens of the CLR, and they allow developers to parameter-
ize classes based on the type of data they store. The parameterization is dictated by the consumer
code, and to show how to incorporate this new language feature, we will build a generic version of
the order container example, as shown in Listing 9-2.
Listing 9-2. Order Container (Using Generics)
public class OrderContainer<T>
{
T[] dataContainers;
int ctr = 0;
//allocate array elements with specified capacity
public OrderContainer(int orderCapacity)
{
dataContainers = new T[orderCapacity];
}
//Add a new Order
public void AddOrder(T order)
{
dataContainers[ctr] = order;
ctr++;
}
C H A P T E R 9 ■ . N E T 2 . 0 449//Retrieve a specific order
public T GetOrder(int index)
{
return dataContainers[index];
}
}
At first glance, the code for OrderContainer looks similar to its predecessor, but the important
element that is missing is that the details of the data type used to hold orders; instead, the data type
is represented by T. The character T in generics is known as a type parameter and is enclosed in angle
brackets. The type parameter acts as a placeholder for the data type that is filled later by the consumer
code. The presence of angle brackets immediately after the class name makes it easy to recognize
a generic type versus its nongeneric counterpart. Additionally, angle brackets enclose multiple type
parameters whose details are unspecified and are referenced all over the code. For instance, you will
notice that in the generic version of OrderContainer, the role played by System.Object is taken over
by type parameter T. Another important note about naming conventions of type parameters is that
they can be any valid C# identifier.
OrderContainer<T> is known as a generic type because it contains code about the functionality
it is going to provide, but what is not known is the kind of data on which it intends to execute its
logic. This missing information is filled by the consumer of the generics and is demonstrated in the
next code example:
class GenericOrderContainer
{
//reference type order
public class OrderObj
{
public string Instrument;
public double Quantity;
}
//value type order
public struct OrderStruct
{
public string Instrument;
public double Quantity;
}
static void Main(string[] args)
{
//Generic type instantiation using reference type
OrderContainer<OrderObj> orderObjContainer = new
OrderContainer<OrderObj>(10);
//Add and retrieve reference type order
orderObjContainer.AddOrder(new OrderObj());
OrderObj orderObj = orderObjContainer.GetOrder(0);
//Generic type instantiation using value type
OrderContainer<OrderStruct> orderStructContainer =
new OrderContainer<OrderStruct>(10);
//Add and retrieve value type order
orderStructContainer.AddOrder(new OrderStruct());
OrderStruct orderStruct = orderStructContainer.GetOrder(0);
}
}
}
450C H A P T E R 9 ■ . N E T 2 . 0To create an instance of a generic type, the consumer must supply the list of concrete data
types that need to be substituted for the type parameters defined. For example, by instantiating
OrderContainer<OrderObj>, which is also called the closed constructed type, every occurrence of type
parameter T is replaced with OrderObj, which is a concrete type. This action immediately gives new
life to the order container, because it knows the concrete data type it intends to store and operate.
Similarly, the instantiation of OrderContainer<OrderStruct> allows the storage of only value types.
You can easily see the power behind generics from the generic version of the order container
code where both reference and value types are instantiated without incurring any kind of perfor-
mance penalty. Both the compiler and runtime provide a necessary type-safety guarantee to an instance
of a generic type. In this way, any attempt to add orders to OrderContainer<OrderStruct> other than
OrderStruct will not be allowed. Additionally, generics bring higher productivity to both the producer
and consumer of the generic type because, along with code clarity, generics provide the opportunity
to design types in a completely generic fashion by offloading most of the internal data type details
to the consumer.
Inheritance on Generic Types
Generics in .NET are not restricted to just pure types; they can be applied to interfaces and abstract
types and also participate in forming a generic-based inheritance chain. By default, the base class
of a generic type is System.Object, but the truth of the matter is a generic type can also be derived
from a base generic type or closed constructed type. In either of these cases, the type parameters
declared in the derived class can be propagated to its base class. For example, if you look at the follow-
ing code, we declared Order<T>, which forms the base type for DayOrder<T> and LimitOrder<T>. The
only difference is that LimitOrder<T> is extended from a concrete type, unlike DayOrder<T>, which
propagates the subclass type parameter to its generic base class.
public class Order<T>
{
public T OrderID;
}
public class DayOrder<T> : Order<T>
{}
public class LimitOrder<T> : Order<string>
{}
When a subclass is a generic type and is derived from a generic interface or generic abstract
classes, then an abstract or virtual method declared in a base type can be overridden in the derived
class. In these cases, the signature of the overridden method must match its base type or interface.
For example, let’s assume you have been given a new requirement to implement comparison func-
tionality between two orders; the most ideal way is to subclass the order generic type from the
IComparable interface:
public interface IComparable<T>
{
int CompareTo(T other);
}
Currently, there are two version of the IComparable interface. The original version is a nongeneric
type, but the new version is meant to handle the generic requirement:
public class OrderObj : IComparable<OrderObj>
{
public string Instrument;
public double Quantity;
C H A P T E R 9 ■ . N E T 2 . 0 451int IComparable<OrderObj>.CompareTo(OrderObj x)
{
return x.Quantity.CompareTo(this.Quantity);
}
}
public struct OrderStruct : IComparable<OrderStruct>
{
public string Instrument;
public double Quantity;
int IComparable<OrderStruct>.CompareTo(OrderStruct x)
{
return x.Quantity.CompareTo(this.Quantity);
}
}
Constraints on Generic Types
Generic constraints permit you to associate rules with the generic type parameter. The rules help
you further narrow down the list of possible types an individual generic type parameter can use. By
default, a generic type parameter with no constraints is known as an unbounded type, and it restricts
generic code to use only methods and properties defined in System.Object. As a result, any attempt
to invoke methods or properties not supported by System.Object will result in compile-time errors.
This behavior is completely acceptable because if you look at it from a compiler point of view, it has
no additional information to ensure compile-time type safety:
//Compile-time error
public class OrderContainer<T>
{
public void AddOrder(T order)
{
//Quantity cannot be negative
if (order.Quantity < 0)
throw new ApplicationException("Quantity cannot be negative");
}
}
Constraints are additional inputs to compilers, and based on this information, they expand the
reach of generic code to invoke methods or properties of different types. Without constraints, the only
possible way to incorporate this feature is to perform a run-time cast, but that leads to performance
overhead. Additionally, if a cast operation is unsuccessful, then it throws a run-time exception. To
address these problems, constraints were incorporated into generics; to use them, you need to first
understand various types of constraints.
Class/Interface Constraint
The code syntax of constraints are specified using the where keyword, which is followed by a generic
type parameter and colon. Given this declaration, a constraint can be classified as a class type or
interface type. Class type constraints define a list of types that a type parameter can support. Simi-
larly, interface type constraints define a list of interfaces that a type parameter can implement. For
example, in following code by constraining OrderContainer<T>, you are allowed to access members
of OrderObj inside generic code:
//Compiles successfully
public class OrderContainer<T> where T:OrderObj
452C H A P T E R 9 ■ . N E T 2 . 0{
public void AddOrder(T order)
{
//Quantity cannot be negative
if (order.Quantity < 0)
throw new ApplicationException("Quantity cannot be negative"); successfully
}
}
Similarly, by applying interface type constraints, you can enforce a rule that any item added in
OrderContainer<T> must implement the IComparable<T> interface:
public class OrderContainer<T> where T : IComparable<T>
{
//....
}
Furthermore, it is also possible to associate multiple constraints on a generic type parameter;
for example, OrderContainer<T> is tagged with both class and interface type constraints:
public class OrderContainer<T> where T : OrderObj,IComparable<T>
{
//....
}
Reference/Value Type Constraint
Using this type of constraint, it is possible to specify that a generic type parameter must be of
a reference type (such as class, delegate, or interface) or value type (such as int, double, or enum):
//Allow only reference type
public class OrderContainer<T> where T : class
{
//....
}
//Allow only value type
public class OrderContainer<T> where T : struct
{
//....
}
Parameterless Constructor Constraint
This constraint enforces a rule that a generic type parameter must have a public parameterless con-
structor. As a result, code inside a generic class can instantiate a new generic object of a generic
parameter type:
public class OrderContainer<T> where T: OrderObj,new()
{
public T CreateNewOrder()
{
//This line compiles because OrderObj has a default public constructor
T newOrder = new T();
//Assign Default Value
newOrder.Quantity = 10;
return newOrder;
}
}
C H A P T E R 9 ■ . N E T 2 . 0 453Inheritance Constraint
This is not a new constraint but must be considered as a mandatory step that needs to be followed
in establishing a constraint-enabled, generics-based inheritance chain. When a generic type is
derived from a base generic type, then generic constraints declared at a base type must be repeated
at a subclass level. Failing to honor this rule will result in compile-time errors:
public class Order<T> where T:IComparable<T>
{
//unique order identifier
public T OrderID;
}
//Constraints needs to be repeated
public class DayOrder<T> : Order<T> where T:IComparable<T>
{
}
//Constraints are not repeated because it is derived from the closed constructed
//type
//but the compiler will ensure that the concrete type specified in the closed
//constructed type
//implements the IComparable interface
public class LimitOrder<T> : Order<string>
{
}
//This will result into compilation error, because we are trying to
//use the byte array as the underlying data type to identify unique order,
//and the byte array doesn't implement the IComparable interface
public class IOCOrder<T> : Order<byte[]>
{
}
Generic Methods and Delegates
A generic method is a method that parameterizes both input and output arguments. It is syntactically
similar to a generic class with the only difference being that access to the type parameter defined at
the generic method level is limited to its execution scope. Using a generic method, it is possible to
sprinkle generic ingredients inside a nongeneric class. Additionally, it enjoys the same benefit of
a generic class.
To demonstrate how powerful a generic method is, we will incorporate sort functionality inside
the generic version of the order container. Instead of hard-coding this functionality, it is delegated
to consumer code that then dictates the sorting behavior using the generic method, as shown in
Listing 9-3.
Listing 9-3. Generic Method
using System;
using System.Collections.Generic;
using System.Text;
public class Order
{
public string OrderID;
public string Instrument;
}
454C H A P T E R 9 ■ . N E T 2 . 0public class SortByOrderID<T> : IComparer<T> where T: Order
{
int IComparer<T>.Compare(T x,T y)
{ return x.OrderID.CompareTo(y.OrderID);}
}
public class SortByInstrument<T> : IComparer<T> where T : Order
{
int IComparer<T>.Compare(T x, T y)
{ return x.Instrument.CompareTo(y.Instrument);}
}
public class OrderContainer<T>
{
//Customize the Sorting behavior using the generic method
public void SortOrder<U>(U orderComparer) where U:IComparer<Order>
{
//....
}
}
In Listing 9-3, we presented multiple ways to sort a list of orders, either by instrument name or
by order ID. SortByOrderID<T> and SortByInstrument<T> provide this functionality. To integrate this
sort feature with OrderContainer<T>, we defined a generic method, SortOrder<U>, that is declared
with type parameters and constrained to be compatible with the IComparer<Order> type. This generic
method is then used to sort orders, as described in the following code example:
class GenericSortMethod
{
static void Main(string[] args)
{
OrderContainer<Order> container = new OrderContainer<Order>();
//Sort By Instrument
SortByInstrument<Order> sortInst = new SortByInstrument<Order>();
container.SortOrder<SortByInstrument<Order>>(sortInst);
//Sort By Order ID
SortByOrderID<Order> sortID = new SortByOrderID<Order>();
container.SortOrder<SortByOrderID<Order>>(sortID);
}
}
The discussion on generics would be incomplete without talking about generic delegates.
You know delegates are managed function pointers and are used extensively in implementing event
notification features. A generic delegate shares the same spirit of a conventional delegate but proves
extremely useful in building generic event handling. For example, using a generic delegate, you can
build a generic event notification feature in the order container code that is capable of providing
a strongly typed item to its subscriber:
using System;
using System.Collections.Generic;
using System.Text;
public class Order
{}
C H A P T E R 9 ■ . N E T 2 . 0 455public class DayOrder
{}
public class OrderContainer<T>
{
//Generic Delegate Declaration
public delegate void InsertOrderDelegate<U>(U orderComparer);
public event InsertOrderDelegate<T> OrderInsert;
public void Add(T order)
{
//Notify Consumer of this event
if (OrderInsert != null)
{
OrderInsert(order);
}
}
}
class GenericDelegate
{
static void Main(string[] args)
{
OrderContainer<Order> orderCont= new OrderContainer<Order>();
orderCont.OrderInsert += new
OrderContainer<Order>.InsertOrderDelegate<Order>
(orderCont_OrderInsert);
OrderContainer<DayOrder> dayorderCont = new
OrderContainer<DayOrder>();
dayorderCont.OrderInsert += new
OrderContainer<DayOrder>.InsertOrderDelegate<DayOrder>
(dayorderCont_OrderInsert);
}
//Event notification for day orders
static void dayorderCont_OrderInsert(DayOrder orderComparer)
{
}
//Event notification for regular orders
static void orderCont_OrderInsert(Order orderComparer)
{
}
}
Generic Collections
Collections in .NET are the most commonly used types to store in-memory items. As highlighted in
Chapter 2, you know that there are various flavors of collections, and their characteristics are deter-
mined based on how individual items are stored and searched. Considering that data structures are
the most basic necessity, Microsoft released a new generic version of collection classes. This generic
version resides side by side with its nongeneric counterpart but is grouped in a different namespace.
The generic collection classes are defined in the System.Collections.Generic namespace. This includes
456C H A P T E R 9 ■ . N E T 2 . 0most of the familiar data structures such as implementing queues, stacks, dictionaries, and lists.
The primary benefit of using generic collections is it brings strong typing, which was badly required
in the pregeneric days:
using System;
using System.Collections.Generic;
using System.Text;
public class Order
{}
class GenericCollections
{
static void Main(string[] args)
{
//Generic Queue
Queue<Order> orderQueue = new Queue<Order>();
//Generic Stack
Stack<Order> orderStack = new Stack<Order>();
//Generic List
List<Order> orderList = new List<Order>();
//Generic Hashtable
Dictionary<string, Order> orderHashTable = new
Dictionary<string, Order>();
//Generic SortedList
SortedDictionary<string, Order> orderSortDict = new
SortedDictionary<string, Order>();
//Generic LinkedList
LinkedList<Order> linkList = new LinkedList<Order>();
}
}
Anonymous Methods
Anonymous methods aim to reduce the amount of code developers have to write to implement
event handlers or callbacks that are invoked through a delegate. This is a kind of code-inflator trick
employed by compilers to bring higher productivity to a developer’s desk. Anonymous methods
allow for the inline recruitment of code associated with a delegate, which is in direct contrast to the
conventional approach where a new instance of a delegate and a separate method handler are required.
For example, the following code is a conventional approach for offloading processing tasks using
a CLR thread-pool implementation:
using System;
using System.Text;
using System.Threading;
public class Order
{
public string OrderId;
}
C H A P T E R 9 ■ . N E T 2 . 0 457class NonAnonymousMethods
{
static void Main(string[] args)
{
//Create a new Order
Order newOrder = new Order();
newOrder.OrderId = "1";
ThreadPool.QueueUserWorkItem(new
WaitCallback(ProcessOrders),newOrder);
Console.ReadLine();
}
public static void ProcessOrders(object state)
{
Order curOrder = state as Order;
Console.WriteLine("Processing Order : " + curOrder.OrderId);
}
}
Using anonymous methods, Listing 9-4 appears in its condensed form, which is succinct when
compared to its conventional approach.
Listing 9-4. Anonymous Methods
using System;
using System.Text;
using System.Threading;
public class Order
{
public string OrderId;
}
class AnonymousMethods
{
static void Main(string[] args)
{
//Create a new Order
Order newOrder = new Order();
newOrder.OrderId = "1";
//Process this newly created order using ThreadPool
ThreadPool.QueueUserWorkItem
(delegate(object state)
{
Order curOrder = state as Order;
Console.WriteLine("Processing Order : " +curOrder.OrderId);
},newOrder
);
Console.ReadLine();
}
}
The code declaration of an anonymous method begins with the delegate keyword and an optional
parameter list. As you will notice, the actual method body is enclosed inside { and } delimiters, which
458C H A P T E R 9 ■ . N E T 2 . 0are also known as an anonymous method block. Code inside this block can declare variables similar
to local variables defined in the conventional method; the only twist is that the lifetime of such vari-
ables is limited to the execution of the anonymous method. Additionally, the code block can also
reference outer variables that are defined at the class level.
In Listing 9-4, we demonstrated how to create an anonymous method, and it can be used
wherever a delegate is expected. Even though it enjoys most of the benefits of the conventional
method, certain things are not permitted inside anonymous method blocks. One of a developer’s
favorite features is .NET attributes, and sadly it is not possible to annotate attributes over an anony-
mous method. Furthermore, an anonymous method cannot reference ref or out parameters except
those specified in an anonymous method signature. It is also not possible for an anonymous method
block to contain an unsafe/goto/break/continue statement. Despite such restrictions, you will find
the anonymous method to be useful in your day-to-day development.
Iterators
Iterators in C# provide a uniform way to iterate over various types of data structures using the
foreach keyword. They achieve this kind of standardization using the IEnumerable and IEnumerator
interfaces. These interfaces need to be implemented by a class in order to support the foreach itera-
tion. Although the implementation looks straightforward, to support a simple iteration, quite a large
amount of code needs to be written. Moreover, the development effort keeps on mounting with the
addition of iteration flavors such as top-to-bottom traversal and bottom-to-top traversal. To simplify
this task, C# 2.0 introduced iterators in which most of the work is lifted by compilers. Using this new
construct, there is no need to provide implementation for the entire IEnumerable interface; instead,
what is required is an iterator statement block, as shown in Listing 9-5.
Listing 9-5. Iterators
using System;
using System.Collections.Generic;
using System.Text;
public class Order {}
public class OrderContainer<T>
{
List<T> orderList = new List<T>();
//Default foreach Implementation
public IEnumerator<T> GetEnumerator()
{
for (int ctr = 0; ctr < orderList.Count; ctr++)
{
yield return orderList[ctr];
}
}
//Best Five Orders
public IEnumerable<T> BestFive()
{
for (int ctr= 0; ctr < orderList.Count; ctr++)
{
if (ctr > 4)
//Stop Iteration Phase
yield break;
C H A P T E R 9 ■ . N E T 2 . 0 459yield return orderList[ctr];
}
}
//Iteration of only limit orders
public IEnumerable<T> LimitOrders()
{
for (int ctr = 0; ctr < orderList.Count; ctr++)
{
//Check for limit order, and return
yield return orderList[ctr];
}
}
}
class Iterators
{
static void Main(string[] args)
{
OrderContainer<Order> orderContainer = new OrderContainer<Order>();
//Iterate all orders
foreach (Order curOrder in orderContainer)
{}
//Iterate Best Five
foreach (Order curOrder in orderContainer.BestFive())
{}
//Iterate limit order
foreach (Order curOrder in orderContainer.LimitOrders())
{}
}
}
In Listing 9-5, the iterator statement block is identified by the presence of yield statements
enclosed inside a method, and its return type is either IEnumerator<T> or IEnumerable<T>. It is com-
posed of two types of statement: yield return and yield break. The yield return indicates the
beginning of the iteration phase and dictates the iteration behavior by producing the next value in
the iteration. Similarly, yield break indicates the completion of the iteration phase. Based on this
keyword, the C# compiler under the hood generates classes (also known as compiler-generated
classes and hidden from developers) that maintain navigation information about the individual
iterator. As a result, you can have multiple iterators defined inside a class, and each of these individ-
ual iterators can slice and dice data from a different perspective.
Partial Types
Partial types enable the spanning of source code into multiple files. To be precise, they allow the
definition of a class, a structure, or an interface to split across multiple files that are later combined
as one large chunk of source code by the compilers. At a surface level, you may fail to recognize
the advantage of a code split, but if you flash back to Chapter 8 where we mentioned the different
types of code generators and their implementation tactics, then partial types prove to be a perfect
fit. For example, we discussed how the VS .NET Windows Form Designer automates the task of UI
development by autogenerating most of the code. The code generated by the designer resides side
by side with the user code and is differentiated by logically grouping it inside the Windows Form Designer
460C H A P T E R 9 ■ . N E T 2 . 0generated code region. However, using partial types, both the designer code and the user code are
now separated into two files. The advantage of such separation brings a tremendous amount of flex-
ibility to augment both the designer and user code.
A partial type is identified by the presence of the partial keyword, which appears immediately
before the class, struct, or interface keywords. For example, the following code illustrates a strategy
class that is separated into two parts. The first part represents code generated by a trading strategy tool,
and the second part represents code defined by traders:
//In the real world this class is generated by tool
public partial class TradingStrategy
{
public void InitializeStrategy()
{}
}
//In the real world this class is defined by traders
public partial class TradingStrategy
{
public void CalculateRisk()
{}
}
class PartialTypes
{
static void Main(string[] args)
{
TradingStrategy tradStrat = new TradingStrategy();
}
}
The benefit of using a partial type is twofold. First, it proves to be extremely useful in the auto-
matic code generation world where the majority of the code is generated by tools, and it provides an
intelligent approach of keeping system-generated code separate from user code and finally merging
them during the compilation stage. Second, it helps to further strengthen day-to-day version-control
activities. A large class can be easily shared with a group of developers by branching it into multiple
files; this allows them to work on it independently.
Nullable Types
In the computer programming world, the value null has always played a special role in defining
a state that is either unacceptable or unknown. For example, instances of reference types in .NET
are by default initialized to the null value to indicate that the instance is in an undefined state and
that attempting to perform any kind of operation on it will result in an exception. Similarly, you will
also find support for nullability in the relational database world, which denotes a column value and
is used to convey data that is either unknown or undefined. Over the years, null values have stretched
their wings in many other computing disciplines, but when it comes to the .NET value type, it seri-
ously lacks support for it. It is not possible to assign null values to value types; this leads to a serious
problem, particularly when data fetched from a database is mapped to the appropriate .NET value
type. This limitation of the value type was carefully given thought, and as a result nullable types were
introduced.
Nullable types provide the ability to store null values to value types. Additionally, this feature is
standardized and integrated as part of the language framework. A nullable type is a generic structure
and is represented by Nullable<T>. The internal implementation of Nullable<T> is composed of a value
type that is passed as a generic type argument and, more important, a flag variable that is a null
indicator. While it is true that to define a nullable value type you need to instantiate a new instance
C H A P T E R 9 ■ . N E T 2 . 0 461of Nullable<T>, different code syntax is available to achieve the same task. The new syntax allows
constructing nullable types simply by appending a question mark after the name of a value type.
For example, int? is the nullable representation of the int data type. In the following code, we
demonstrate how to use the nullable type by assigning the null value to the Quantity and Price
fields of the Order class:
using System;
public class Order
{
public string Instrument;
//Nullable Value type, null is assigned as default value
public int? Quantity = null;
public double? Price = null;
}
class NullableTypes
{
static void Main(string[] args)
{
Order newOrder = new Order();
//This will return true because quantity value is null
Console.WriteLine("Is Quantity Null : " + ( newOrder.Quantity == null ) );
//Null coalescing operator
//If quantity value is null, then by default assign value 10
newOrder.Quantity = newOrder.Quantity ?? 10;
Console.WriteLine("Quantity : " +newOrder.Quantity);
//Addition operator
newOrder.Quantity = newOrder.Quantity + 5;
Console.WriteLine("Quantity : " + newOrder.Quantity);
}
}
Counting Semaphore
The counting semaphore is a new addition to the existing list of managed synchronization objects
and is represented by System.Threading.Semaphore. It defines a threshold value on the number of
times a shared resource can be accessed. This resource-counting mechanism proves extremely
useful in multithreaded applications where a limit can be set on the number of threads allowed to
access a particular resource. Threads use the semaphore to create a pool of tokens that is issued
each time a thread enters the semaphore and is recycled back to the pool when the thread leaves
the semaphore. In the case of the unavailability of tokens, the thread requesting it is blocked until
other threads release the token back to the pool. Even though semaphores are similar to mutexes
and monitors, when it comes to ensuring the synchronization of shared resources, semaphores are
one step ahead; they enable the metering of shared resources. Additionally, mutexes and monitors
are meant to grant exclusive access on shared resources to only one thread at a time, which is in
contrast to semaphores, which grant access to multiple threads on shared resources. Listing 9-6
shows an example:
462C H A P T E R 9 ■ . N E T 2 . 0Listing 9-6. Semaphore
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
class Order
{}
class SemaphoreLock
{
static Semaphore orderSemaphore;
static void Main(string[] args)
{
ManualResetEvent waitEvent = new ManualResetEvent(false);
int initialTokens = 3;
int maxTokens = 3;
//Assume some sort of order container that stores the order
List<Order> orderContainer = new List<Order>();
//Create a new semaphore, which at any time allows
//only three concurrent threads to access the order container
//and process an individual order
//The first parameter represents initial tokens available in the pool
//and the last parameter represents the maximum available tokens
orderSemaphore = new Semaphore(initialTokens, maxTokens);
for (int ctr = 0; ctr <= 10; ctr++)
{
ThreadPool.QueueUserWorkItem(new WaitCallback(ProcessOrders),ctr);
}
//Prevent program from exiting
waitEvent.WaitOne();
}
public static void ProcessOrders(object state)
{
//Acquire the Semaphore lock
//If lock is successfully acquired then semaphore count is decremented
orderSemaphore.WaitOne();
//insert order into order book
Console.WriteLine("Order Processed : " +state);
Console.WriteLine("Press any key to Continue");
Console.ReadLine();
//Release the lock, which will increment the semaphore count
orderSemaphore.Release();
}
}
In Listing 9-6, notice how you can limit the number of threads that can access the order book con-
currently. You created a semaphore that can handle up to three concurrent requests, with an initial
count of three so it is immediately available on the pool. To process individual orders, you use worker
threads from the thread pool. A thread enters the semaphore by calling the WaitOne method and, after
inserting the order into the order book, releases the semaphore by calling the Release method.
C H A P T E R 9 ■ . N E T 2 . 0 463Memory Gate
The memory gate functions as a checkpoint in managed code and is used to ensure the availability
of sufficient memory before initiating any kind of memory-intensive operation. Although the
CLR is responsible for managing memory, sometimes it fails to satisfy memory requests issued by
an application. On such occasions, the failure result is notified to the application in the form of
OutOfMemoryException. This exception signifies that a disaster has already taken place, and most
of the times the application lands in an inconsistent state that is hard to recover from. Using the
memory gate, it is possible to minimize such incidents by doing upfront estimation of the memory
required, and if the specified amount of memory is not available, then it is notified in the form of
InsufficientMemoryException. Here’s an example:
using System;
using System.Runtime;
namespace MemoryGate
{
class Program
{
static void Main(string[] args)
{
//Check whether application can allocate 20MB of
//memory to perform file copy operation
using (new MemoryFailPoint(20))
{
//Perform File Copy Operation
}
}
}
}
Garbage Collector
The .NET Framework provides an end-to-end platform to build both client-side and server-side
applications. Client-side applications are generally GUI driven and intended to run on the desktop.
Server-side applications are computational intensive and usually require high-end servers. The per-
formance need of the client and server applications are different, so the CLR ships with two flavors
of the garbage collector: Workstation GC and Server GC. Workstation GC is the default collector
used by managed code. It is highly optimized for GUI-based applications to provide greater user
responsiveness. On the other hand, Server GC is optimized for multiprocessor machines and highly
suitable for server-side applications that need high throughput.
Both these GCs undertake a different strategy when it comes to the garbage collection process.
Workstation GC creates a single managed heap and a dedicated thread to perform garbage collec-
tion regardless of the number of processors available in the machine. This is in contrast to Server
GC where the number of managed heaps and threads created is equal to the number of processors
installed in the machine. This setup definitely boosts the performance because garbage collection
takes place in parallel on all available CPUs. Server GC is highly recommended for mission-critical
applications, and with the advent of .NET 2.0, it can be easily enabled by adding a new <gcServer>
element in an application configuration file:
<configuration>
<runtime>
<!-- Server GC Enabled -->
<gcServer enabled="true"/>
464C H A P T E R 9 ■ . N E T 2 . 0</runtime>
</configuration>
A new helper class, GCSettings, introduced in the .NET 2.0 specifies the garbage collection
settings. With the help of this class, you can find out the type of garbage collection used by the
currently running process:
using System;
using System.Runtime;
namespace GCConfig
{
class Program
{
static void Main(string[] args)
{
if (GCSettings.IsServerGC == true)
Console.WriteLine("Server GC enabled");
else
Console.WriteLine("Workstation GC enabled");
}
}
}
SGen
To boost the start-up performance of XMLSerializer, .NET 2.0 toolkits are packaged with a new tool
known as SGen. You learned in Chapter 3 about the capability of XMLSerializer to serialize and
deserialize objects into and from XML documents. In addition, you also understand its implemen-
tation technique that under the hood applies the code-generation technique to emit serialization
and deserialization code. The code generated is then compiled into an assembly and loaded into
the currently running process. That is the reason you always notice a delay when a new instance of
XMLSerializer is created. The magnitude of this delay depends upon the depth of the object graph.
To cut down on this start-up delay, SGen creates XML serialization and deserialization code in
advance. It generates an XML serialization assembly that is then referenced by applications. The
immediate advantage of statically linking serialization logic at compile time is that there is no code-
generation activity involved at runtime; this drastically reduces the application start-up cost. But it
doesn’t mean this approach is free of any side effects. You lose the flexibility offered by dynamic code
generation, particularly any kind of modification; for example, adding or removing the property/
field at the class level now requires a recompilation to keep the serialization assembly synchronized
with the XML serializable type. However, this additional step is amortized over the cost of generating
serialization code for a large number classes at runtime that is bit expensive.
SGen is a command-line tool that accepts the name of the assembly for which the serialization
and deserialization code is generated. By default, it generates the serialization code for all the classes
defined in the assembly, but using the /type switch, it is possible to generate serialization code for
only a particular class.
Assume the following code is compiled in the form of an executable assembly and is named
PreGenXMLSerializer.exe:
using System;
using System.Collections.Generic;
using System.Text;
C H A P T E R 9 ■ . N E T 2 . 0 465namespace PreGenXMLSerializer
{
public class Order
{
public string OrderID;
public int Quantity;
public double Price;
}
class Program
{
static void Main(string[] args)
{
}
}
}
To generate an XML serialization assembly, the following is the command to be executed in the
VS .NET 2005 command prompt window:
sgen /assembly:pregenxmlserializer.exe /type:Order
The output of the tool is a set of classes persisted in the PreGenXMLSerializer.XmlSerializers.
dll assembly that can be referenced from code that needs to serialize or deserialize the Order type.
The following code bypasses the conventional XML serialization path and uses the pregenerated
assembly to serialize and deserialize an instance of the Order type:
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
//Include namespace from the PreGenXMLSerializer.XMLSerializers assembly
using Microsoft.Xml.Serialization.GeneratedAssembly;
namespace PreGenXMLSerializer
{
public class Order
{
public string OrderID;
public int Quantity;
public double Price;
}
class Program
{
static void Main(string[] args)
{
Order dayOrder = new Order();
dayOrder.OrderID = "1";
dayOrder.Quantity = 50;
dayOrder.Price = 25;
//Serialize Order using pregenerated serializers
OrderSerializer orderSzer = new OrderSerializer();
XmlTextWriter txtWriter = new XmlTextWriter(
new StreamWriter(@"C:\Order.xml"));
466C H A P T E R 9 ■ . N E T 2 . 0orderSzer.Serialize(txtWriter, dayOrder);
txtWriter.Close();
//Deserialize Order using pregenerated deserializers
XmlTextReader txtReader = new XmlTextReader(
new StreamReader(@"C:\Order.xml"));
Order newOrder = orderSzer.Deserialize(txtReader) as Order;
Console.WriteLine(newOrder.OrderID);
}
}
}
Data Compression
In building networked applications, an important goal followed by developers is to ensure the efficient
utilization of network bandwidth. The success of a networked application depends upon various
factors; one of them is to apply a data compression technique to save network bandwidth, resulting
in the much faster transmission of data. Additionally, you can also apply a compression technique
to condense log files generated by the application. Nowadays, it is mandatory for an organization to
maintain an archive of application log files that is subject to a periodic internal audit check. In such
scenarios it is sensible to preserve the files in their compressed formats instead of their original for-
mats, which translates into a huge savings of disk space.
.NET 2.0 introduces a new System.IO.Compression namespace that provides exactly what you
need to do so. It provides basic compression and decompression services out of the box. The two
most important classes defined in this namespace are DeflateStream and GZipStream. DeflateStream
represents the industry-standard Deflate algorithm. GZipStream is a wrapper around the DeflateStream
class and defines additional meta-information around compressed data.
Here’s the code that demonstrates the compression and decompression of in-memory data:
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;
namespace IOCompression
{
class Program
{
static void Main(string[] args)
{
MemoryStream memStream = new MemoryStream();
string orderXml =
"<Order><OrderID>1</OrderID><Quantity>50</Quantity>"
+"<Price>25</Price></Order>";
byte[] data = Encoding.UTF8.GetBytes(orderXml);
//Data Compression
DeflateStream compressedStream =
new DeflateStream(memStream , CompressionMode.Compress,true);
compressedStream.Write(data, 0, data.Length);
compressedStream.Close();
//Reset seek pointer that is mandatory in order to decompress data
memStream.Position = 0;
C H A P T E R 9 ■ . N E T 2 . 0 467//Data Decompression
DeflateStream decompressedStream =
new DeflateStream(memStream, CompressionMode.Decompress);
byte[] decompBuffer = new byte[memStream.Length];
decompressedStream.Read(decompBuffer, 0, decompBuffer.Length);
string orgData = Encoding.UTF8.GetString(decompBuffer);
Console.WriteLine("Decompressed Data : " + orgData);
}
}
}
Network Information
.NET 1.1 had no easy way to gather information about the network traffic status at runtime. Developers
often would resort to P/Invoke or use the Windows Management Instrumentation (WMI) API to
incorporate this feature, resulting in an increase in the developer’s learning curve. But with .NET 2.0,
this has changed. A new namespace, System.Net.NetworkInformation, is dedicated solely to pro-
viding network-related information. It contains classes that enable querying information on almost
all layers of the TCP/IP core stack. In addition to gathering information about network traffic status,
it also provides the ability to query information about the underlying network adapter and allows
you to conduct standard tests for network connectivity. This offers a great advantage in the .NET
world, and taking into account the breadth and depth of individual classes defined in this namespace,
it is possible to develop a managed version of a commonly used network utility such as ping.exe,
ipconfig.exe, or netstat.exe. Furthermore, developers can tune their applications to sense network
behavior and accordingly react to it. For example, in distributed applications, there is often a need
to detect a disconnected network cable and accordingly preserve any further changes performed by
a user into the local database. Such kind of intelligence makes an application more reliable and
increases user confidence.
We will now explore some of the important classes available in the System.Net.NetworkInformation
namespace. We begin with some first trivial code that more or less covers the features of the netstat.
exe utility. You can use this utility to find out the following information:
  Active TCP connections, which includes the IP address and port number of the local and
foreign host
  A list of TCP and UDP connections configured in listening mode
  Statistical information about TCP, UDP, and IP
Here’s an example:
using System;
using System.Net;
using System.Net.NetworkInformation;
namespace NetStat
{
class Program
{
static void Main(string[] args)
{
IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
Console.WriteLine("Domain Name : " + properties.DomainName);
Console.WriteLine("Host Name : " + properties.HostName);
468C H A P T E R 9 ■ . N E T 2 . 0//Get Active TCP Connections
TcpConnectionInformation[] connections =
properties.GetActiveTcpConnections();
//Get Active TCP Listener
IPEndPoint[] endPointsTCP= properties.GetActiveTcpListeners();
//Get Active UDP Listener
IPEndPoint[] endPointsUDP = properties.GetActiveUdpListeners();
//Get IP statistics information
IPGlobalStatistics ipstat = properties.GetIPv4GlobalStatistics();
//Get TCP statistical information
TcpStatistics tcpstat = properties.GetTcpIPv4Statistics();
//Get UDP statistical information
UdpStatistics udpStat = properties.GetUdpIPv4Statistics();
}
}
}
The next step in the network data collection phase is to interact with the underlying network
adapter and retrieve interface-level information such as the physical address, the operational status
of the individual interface, the data transfer speed supported by the interface, and the logical IP address:
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.NetworkInformation;
namespace NetAdapterStat
{
class Program
{
static void Main(string[] args)
{
NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
foreach (NetworkInterface adapter in nics)
{
Console.WriteLine("Adapter Name : " +adapter.Name);
Console.WriteLine("Physical Address : "
+ adapter.GetPhysicalAddress().ToString());
Console.WriteLine("Data Transfer Speed :"
+ adapter.Speed +" bits per second ") ;
Console.WriteLine("Operational Status :"
+ adapter.OperationalStatus);
Console.WriteLine("");
}
}
}
}
C H A P T E R 9 ■ . N E T 2 . 0 469Up until now we have demonstrated features that focused on gathering statistical data infor-
mation about a network and its underlying transport. But the next topic we will discuss will prove
extremely useful in detecting network-related changes. In other words, a managed application can
incorporate a network detector that will sense the underlying network and raise notification when
the IP address or network adapter changes:
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.NetworkInformation;
namespace NetDetector
{
class Program
{
static void Main(string[] args)
{
//This event is raised when IP address of network is changed
NetworkChange.NetworkAddressChanged += NetworkChange_NetworkAddressChanged;
//This event is raised when network availability is changed
//For example, the application will be able to get notification about the
//network
//cable disconnect by subscribing to this event
NetworkChange.NetworkAvailabilityChanged +=
NetworkChange_NetworkAvailabilityChanged;
Console.ReadLine();
}
static void NetworkChange_NetworkAvailabilityChanged(object sender,
NetworkAvailabilityEventArgs e)
{
Console.WriteLine("Network Disconnected");
}
static void NetworkChange_NetworkAddressChanged(object sender, EventArgs e)
{
Console.WriteLine("IP Address Changed");
}
}
}
Another important class that brings tremendous value to the developer’s desk is Ping. This
class is a programmatic representation of the ping.exe command-line tool. ping.exe is one of the
most well-known network troubleshooting tools and is primarily used to conduct machine reacha-
bility tests. Additionally, it also enables you to perform various kinds of network diagnostic checks,
such as tracking the number of intermediate hops between the source and destination hosts and
measuring the total round-trip time. The benefit offered by ping.exe is tremendous, and there is
definitely a need for it in the managed programming world. The Ping class brings the same benefit
and features; applications can directly integrate it in their code to perform various kinds of network
diagnostic checks.
Using Ping, applications can implement a heartbeat between machines. It is also possible for
applications to determine the network round-trip time or the underlying network speed and accord-
ingly tune their communication strategies. For example, a distributed application, before establishing
communication with the server, can initiate a ping request to collect the round-trip time and
underlying network capacity. If the results of the round-trip time or network bandwidth are poor,
then the application can apply a data compression scheme to reduce the size of the data. For example:
470C H A P T E R 9 ■ . N E T 2 . 0using System;
using System.Collections.Generic;
using System.Text;
using System.Net.NetworkInformation;
namespace NetPing
{
class Program
{
static void Main(string[] args)
{
Ping pingSender = new Ping();
//Ping Apress Web site with timeout of 1 seconds (1,000 milliseconds)
//The result of ping is stored in instance of PingReply
PingReply reply = pingSender.Send("www.apress.com",1000);
//Analyze the result
if (reply.Status == IPStatus.Success)
{
Console.WriteLine("Roundtrip Time : " + reply.RoundtripTime);
}
}
}
}
The outcome of the ping request is checked with the help of the Status property defined in
Ping. Also keep in mind that because of security risks, most organizations configure their firewalls
or proxy servers to reject ICMP requests. In such situations, the ping request will definitely fail, so it
is always advisable to check the network environment before utilizing this class.
Remoting
The remoting framework in .NET 2.0 bundles a new communication channel, IpcChannel, which is
specifically targeted for remoting between application domains on the same computer. This new
channel is defined under the System.Runtime.Remoting.Channels.Ipc namespace. The primary
motive behind the design of this channel is to increase interprocess communication performance
on the same machine. Before IpcChannel, the highly recommended way is to follow the TCP channel
route. The problem with the TCP channel is regardless of where the data is destined, it will always
be processed by an individual layer of the TCP/IP core stack. So even though both the sending and
receiving applications are hosted on the same machines, the individual messages exchanged by them
will always incur additional TCP/IP overhead. The IPC channel addresses this problem by providing
a communication pipe that is free from any kind of network overhead, and it internally uses the
IPC system of the Windows operating system to enable the faster exchange of messages.
It is now possible for back-office applications to use the IPC channel to implement a market
information cache server. Usually, back-office GUI applications involve quite a large amount of data-
entry activity; to speed up the task, users are provided with a selection list such as combo boxes, grids,
or list boxes populated with information retrieved from the database or middle-tier components.
The information populated is huge in number, and usually they are cached during the application
start-up phase. But as soon as the user exits from the GUI application, the cached information is lost,
and it needs to be repopulated again, which increases the application loading time. By implementing
the information cache server that is running as a separate process, the overall performance of the
C H A P T E R 9 ■ . N E T 2 . 0 471GUI application increases tremendously because the information is locally cached by the server
and the GUI application retrieves it using the IPC channel.
We will now demonstrate the full-fledged remoting code that is based on the market information
example and that uses the IPC channel.
Shared Assembly
The following is the shared assembly referenced by the market information cache server and back-
office applications:
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
namespace Common
{
public interface ICacheInfo
{
DataSet RetrieveCache();
}
}
Implementation of Market Info Cache Server
The following is the code implementation of the market information cache server:
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Common;
namespace MktInfoCacheServer
{
public class MktInfoCacheImpl : MarshalByRefObject, ICacheInfo
{
public DataSet RetrieveCache()
{
Console.WriteLine("Request Received...");
return null;
}
}
}
Remoting Configuration of Market Info Cache Server
The following is the remoting configuration of the market information cache server:
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
<system.runtime.remoting>
<application>
<service>
<wellknown mode="SingleCall"
472C H A P T E R 9 ■ . N E T 2 . 0type="MktInfoCacheServer.MktInfoCacheImpl, MktInfoCacheServer"
objectUri="MktInfoCacheImpl.rem" />
</service>
<channels>
<channel ref="ipc" portName="InfoCacheServer" />
</channels>
</application>
</system.runtime.remoting>
</configuration>
Market Info Cache Server Host
The following code is the host market information cache server:
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
namespace MktInfoCacheServer
{
class Program
{
static void Main(string[] args)
{
RemotingConfiguration.Configure(@"MktInfoCacheServer.exe.config");
Console.WriteLine("Market Information Cache Server started.. ");
Console.WriteLine("Press enter to exit.");
Console.ReadLine();
}
}
}
Market Info Cache Client (Back-Office Applications)
The following code connects to the market information cache server and retrieves the cached
information:
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Common;
namespace InfoCacheClient
{
class Program
{
static void Main(string[] args)
{
//Retrieve Cached object from the market information cache server
//which is locally hosted
ICacheInfo remoteCache = (ICacheInfo)Activator.GetObject(typeof(ICacheInfo),
"ipc://InfoCacheServer/MktInfoCacheImpl.rem");
C H A P T E R 9 ■ . N E T 2 . 0 473DataSet cacheObj = remoteCache.RetrieveCache();
Console.WriteLine("Information Successfully Retrieved...");
Console.ReadLine();
}
}
}
Remoting and Generics
The remoting framework respects and recognizes generics and provides the necessary infrastructure
to allow developers to define generic-aware remote classes. The only prerequisite of generic-aware
remote classes is that the generic type parameters declared inside either must be a serializable type
or must be derived from MarshalByRefObject. To learn how generics can be applied in remoting
applications, consider a remote order container that allows you to store and retrieve the order of any
data type. This example is similar to one discussed in the “Generics” section of this chapter, but in
this case the order container is instantiated and updated on a remote machine.
Shared Assembly
The following is the shared assembly:
using System;
using System.Collections.Generic;
using System.Text;
namespace GenericsShared
{
[Serializable]
public class Order
{}
[Serializable]
public struct LimitOrder
{}
public interface IRemoteContainer<T>
{
void Add(T item);
T this[string id] { get;}
}
}
Generic-Aware Remote Order Container
The following is the generic-aware remote order container:
using System;
using System.Collections.Generic;
using System.Text;
using GenericsShared;
namespace RemoteServer
{
public class RemoteOrderContainer<T> : MarshalByRefObject,IRemoteContainer<T>
{
//Add a new item
474C H A P T E R 9 ■ . N E T 2 . 0public void Add(T newOrder)
{
Console.WriteLine("Order of Type " +newOrder.ToString() +" Added" );
}
//Retrieve a specific item
public T this[string orderId]
{
get { return default(T); }
}
}
}
Remoting Configuration of Remote Order Container
The following is the remote configuration of the remote order container:
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
<system.runtime.remoting>
<application>
<service>
<wellknown mode="SingleCall" type="RemoteServer.RemoteOrderContainer`1
[[GenericsShared.Order,GenericsShared]], RemoteServer"
objectUri="OrderContainer.rem" />
<wellknown mode="SingleCall" type="RemoteServer.RemoteOrderContainer`1
[[GenericsShared.LimitOrder,GenericsShared]], RemoteServer"
objectUri="LimitOrderContainer.rem" />
</service>
<channels>
<channel ref="tcp" port="17000">
<serverProviders>
<formatter ref="binary" typeFilterLevel="Low" />
</serverProviders>
</channel>
</channels>
</application>
</system.runtime.remoting>
</configuration>
Client Instantiating Remote Generic Type
The following is the client that is instantiating the remote generic type:
using System;
using System.Collections.Generic;
using System.Text;
using GenericsShared;
namespace RemoteClient
{
class Program
{
static void Main(string[] args)
{
//Instantiating remote container that allows only regular order
IRemoteContainer<Order> ordCont =
C H A P T E R 9 ■ . N E T 2 . 0 475Activator.GetObject(typeof(IRemoteContainer<Order>),
"tcp://localhost:17000/OrderContainer.rem") as IRemoteContainer<Order>;
Order newOrder = new Order();
ordCont.Add(newOrder);
//Instantiating remote container that allows only limit order
IRemoteContainer<LimitOrder> limitOrdCont =
Activator.GetObject(typeof(IRemoteContainer<LimitOrder>),
"tcp://localhost:17000/LimitOrderContainer.rem") as
IRemoteContainer<LimitOrder>;
LimitOrder newLimit= new LimitOrder();
limitOrdCont.Add(newLimit);
Console.ReadLine();
}
}
}
Summary
In this chapter, we provided an overview of some important features introduced by .NET 2.0. But
you will find a treasure of other exciting new features added in ADO.NET, Windows Forms, and
ASP.NET that we didn’t discussed. .NET 2.0 makes the development task much simpler and promises
some major improvements in the overall performance of managed applications. There is no doubt
that .NET 2.0 is going to be the future, and Microsoft has given you an easy migration path by pro-
viding backward compatibility with applications designed on the .NET 1.x Framework.
476C H A P T E R 9 ■ . N E T 2 . 0

