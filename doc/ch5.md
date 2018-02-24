# 第五章 应用运行引擎 The Application Operation Engine
Struggles in life are like tight while loops; success comes only when you break this loop.
This chapter is devoted to the operational requirements of a trading system and is unlike other
chapters so far because it does not cover any hard-core business topics. Operational features such
as security, logging, configuration, and heartbeat checks are part of any good trading system. But they
are usually bundled with the real business component and executed within the same address space
of the business component. In this chapter, using the .NET Remoting framework, we will show how
to physically separate this operational need and construct a strong foundation to centralize the
monitoring and the management of subcomponents within trading systems.
Understanding the Trading Operational
Requirement
In bygone days, the design of a trading application was centered on the idea of a stand-alone archi-
tecture where the user interface, data store, and business logic were located on one computer. But
as business complexities started growing, the demand rose for breaking up these applications and
carving out distinct components for them. This led to a new component-oriented architecture.
Referring to the trading life cycle in Chapter 1 (Figure 1-6), you’ll see it is impossible to meet the
end-to-end business requirements if you shy away from a component-oriented architecture.
Returning to a real-life trading scenario, a system is partitioned into subcomponents, also called
the business component. A business component in this context is a unit of deployment that subsumes
a part of the business requirement and is heavily specialized to meet this business need. As a result
of this component-decomposing exercise, a system would have a number of business components,
and collaboration among these components is the primary key to successfully representing the system
as a single entity to the outside world. Hence, to facilitate this integration, a business component
needs to contain three types of channels: inbound, outbound, and operational channels. The com-
ponent listens on the inbound channel, and therefore requests from other components are directed
to this channel. Similarly, the business component uses the outbound channel to communicate with
other components. The intent of the operational channel is to allow the operational activity of a business
component (which is discussed later in this section).
Figure 5-1 provides an abstract view of a business component. From an implementation point
of view, you can implement both inbound and outbound channels using a fast enterprise messaging
bus. The most popular messaging backbones used in today’s Windows world are TIBCO-Rendezvous,
Microsoft MSMQ, and IBM MQ-Series.
235236C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
Figure 5-1. Business component
Figure 5-2. Operational service common across all business components
Clearly, modularizing trading applications in the form of components has some major benefits:
Scalability: The loose-coupling characteristic of a component makes it a perfect candidate to be
deployed on a dedicated high-end machine that would tremendously increase the performance
of the application. Moreover, this also opens the door to incorporating advanced capabilities, such
as load balancing and fault tolerance, which would further increase the application’s robustness.
Pluggability, extensibility, and reusability: A system is usually combined and built from both
homegrown and off-the-shelf components, and if an individual component based its communi-
cation strictly on the notion of inbound and outbound channels, then it could easily be replaced
with a new component without affecting the other dependent business components. Moreover,
a business component built in such a fashion will always promote heavy reusability across
organizations.
In the trading world, the most commonly found business components that religiously follow
these disciplines are the following:
  The order-matching system
  The order management system
  Market data
  Risk management
  The limit-monitoring system
  The position system
  The exchange gateway
  The settlement system
Although business components are essential, operational (infrastructure) components that look
after the operational requirements of the business components are equally important (see Figure 5-2).
These operational requirements are common among all business components and do not con-
sider any kind of business know-how in their implementation. The frequently needed operational
components encountered in day-to-day development are as follows:C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 237
Logging component: The role of the logging component is to provide a logging infrastructure that
allows an application to log its activity. Application logs play an important role in troubleshooting
hard-to-find failures. Additionally, they are also one of the mandatory audit requirements of an
organization.
Configuration component: Storing application-related settings in a configuration file is considered
a good development practice. Moreover, the configuration file can drive a system’s ability to
adapt to the external environment. The configuration component is tasked with the responsibility
of centralizing and bookkeeping the system’s related settings and providing a uniform way of
accessing these settings from all business components.
Heartbeat component: With so many critical business components running in a system and with
each component hosted on a dedicated machine, it becomes crucial to carefully watch the health
of these components. The first step to lessen this problem is to modify the business component
to continuously send a heartbeat message to the heartbeat component. This heartbeat message
is configured to trigger at predefined intervals, and a failure to receive this message will be raised
in the form of a red-flag alert by the heartbeat component.
Data management: The data management service provides a golden copy of static data that is
not updated on a regular basis. The data that falls under such a category is the ISIN master,
exchange master, client master, and so on. Most of the business components utilize these types
of data, and hence it is advisable to centralize this data under a data management service and
also provide a uniform data access mechanism.
User authentication and profile component: This component monitors all login requests by
performing password and user profile checks. It ensures that individual login requests are valid
and are originating from legitimate users. Similarly, it also monitors logout requests and invokes
all defined processes (such as saving user profile settings, writing session details to log files, and
so on) when a logout request is received.
Instrumentation component: It is absolutely necessary for critical applications to collect
performance-related data in the production environment and analyze this data to close any
missing gaps that are hard to trace in the development environment. With the instrumentation
component in place, the performance-related data collected by various business components
is stored and analyzed from a central place.
Application management component: The application management component is considered
to be the remote control of a business component mainly because of its ability to manage the
startup and shutdown of business components. Moreover, this operational service is further
augmented by introducing other value-added features such as the autodeployment of a business
component, the scheduling of the business component to start at a particular time, application
recoverability, and so on.
You can take many approaches to team operational components with business components,
and this depends mainly upon the nature of the system. But as mentioned earlier, a trading-based
system is composed of multiple business components. Hence, it becomes important to deviate from
the traditional approach. The most optimal way to integrate is to centralize all operational services and
host them on a dedicated machine. In a sense, you completely offload the infrastructure-processing
requirements of the business component, thus making them further scalable. Furthermore, it is now
possible to take a complete snapshot of the system. For example, by implementing a centralized
logging component, you can easily build a logging graphical user interface (GUI) that would display
the activity in the system in real time. You can also reap the same benefit from the configuration
component because now the application configuration information is also centralized in one place,
and therefore you can easily implement any changes to the application settings. So, how do the business
components communicate with the operational components? To answer this question, let’s revisit
Figure 5-1 where we talk about an operational channel. It is with the help of this channel that indi-
vidual business components communicate with the operational components.Figure 5-3. Centralization of operational services
Figure 5-4. Requirement distillation
Although there are various ways of technically implementing the conceptual model in Figure 5-3,
with the advent of .NET Remoting it is a piece of cake. .NET Remoting has modernized the concept
of interprocess communication. Considering the breadth and depth of features currently provided
by .NET Remoting, it would be extremely disappointing if we failed to leverage it in this scenario.
The rest of the chapter is devoted to exploring .NET Remoting and explaining other important topics
in detail.
238C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
Exploring the Multiple Facets of an Object
A business requirement is the raw material for software development that is gathered, analyzed, and
refined to build a system. Therefore, a well-defined business requirement is undoubtedly the first
step in any software development. Requirements fall under the user’s domain and are described in
plain and simple text. However, from a system implementation point of view, requirements need to
be translated into a language that is complex in nature and therefore demands a strict formalism.
This process of translation is called requirement distillation where requirements from the user
domain are condensed and mapped to fine-grained objects in the system domain (see Figure 5-4).
Requirements are high-level abstractions of objects; to be more precise, the collection of distinct
objects is closely collaborated on to meet the need of a requirement. This raises the question, what
is an object? An object is a run-time representation of a class. A class encapsulates the real intention
of a business requirement in the form of state and behavior. State and behavior are evidenced inside
a class in the form of variables and members, respectively. Members are the key drivers, and with the
help of variables they orchestrate a specific aspect of the requirement.Figure 5-5. Multiple facets of object
C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 239
An object is like a multifaceted actor who plays different roles based on the script and story. An
object is also bestowed with similar characteristics and sports new behavior based on its underlying
context (see Figure 5-5).
An object is incubated inside a context; a context in a broader sense provides services that are
availed by an object.
This includes the creation of the object, which costs few bytes of physical memory and allows
seamless access to other objects inside the context. Context is an abstract term, and in the comput-
ing world it materializes in the form of an application process, thread, or .NET application domain.
Based on the dynamics of the context, the object is classified into the following types:
Local object: An object earns the title of local object when both the caller and the real object
are citizens of the same context.
Remote object: An object is known as a remote object when its caller resides in a different context.
In spite of the context’s partition, the caller is able to access the object and leverage its services.
In a real world, this depicts interprocess communications where objects from one application
process invoke the services of another object hosted in a different application process. The caller
accesses the remote object using a proxy object that mimics a real object in the caller context
but in reality delegates the request to the actual object. This sort of transparent intercontext
communication is achieved by some sort of black-box component that hides the inherent
complexities involved in invoking methods on remote objects.
Mobile object: An object is known as a mobile object when it is instantiated in a context that is
different from the caller context, but subsequent method invocation on this object is served
from the caller context rather than the context in which it was created. This unique ability of
the object to package itself and resurrect in a caller context is a mobile object.
By default, objects are created as local objects. To promote them to a remote or mobile object,
you need an infrastructure that bridges the path and allows seamless communication between these
objects, regardless of the underlying context. The context could also be located in a different machine.
This means that the infrastructure should be intelligent enough to understand network quirks. Such
infrastructures are developed to link computing and communication in a revolutionary way. The
presence of such infrastructures leads to the design of distributed applications, and well-known
infrastructures such as DCOM, CORBA, DCE-RPC, and so on, have strong roots in today’s modern
distributed applications. These kinds of infrastructures have been instrumental in building highly
scalable architectures. With .NET Remoting joining this bandwagon, building distributed applications
in .NET is even simpler when compared to its predecessor, DCOM. The .NET Remoting Framework
removes all the hurdles usually faced in building distributed applications and provides a powerful
framework that is easily extensible to meet the needs of an application.240C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
Figure 5-6. High-level view of the remoting framework
Understanding .NET Remoting Infrastructure
In the preceding section, we discussed a black-box component/infrastructure that acts as the glue
to establish communication between objects, irrespective of their underlying context. This black-box
component is known as middleware. Middleware provides the scaffolding on which distributed
systems are designed and developed. In a distributed system, three components—namely, software,
hardware, and network components—are involved and closely work with each other. Massive com-
plexities are involved in interacting with hardware and network components. These complexities are
unpleasant and therefore result in restricting most software systems from adopting a distributed path.
With the advent of middleware, which by itself is a software framework, most of these complexities
are hidden, thereby providing an easy-to-use programming model with the necessary building blocks
for designing distributed systems.
The latitude of services offered by middleware is praiseworthy and can be categorized into the
following types:
Communication services: The communication service is the core and distinguishing feature that
all middleware implements. This service shields the application from knowing the underlying
raw communication protocol details such as TCP/IP, UDP, Named Pipes, and so on. Instead, it
provides applications with a cherry-picking feature—it allows the application to pick which
communication protocol to use to exchange messages with the other end of systems.
Infrastructural services: Middleware has further made inroads into the domain realm of systems.
The infrastructural service is geared toward providing domain-related features that are available
out of the box and directly consumed by applications. For example, services such as transactions,
security, and persistence are readily available in most of today’s modern middleware systems.
.NET Remoting is communication middleware designed to build .NET-based distributed systems.
Although it primarily provides communication services, it came as a bold stroke at the right time
when its predecessor, DCOM, was already in the stage of losing market share. The chronic problems
rooted in DCOM were carefully considered, and as a result, .NET Remoting was designed from scratch
to address all the issues faced in DCOM. The most important theme of .NET Remoting is its ease of
use and extensibility. It is so versatile that it allows developers to fine-tune practically every aspect
of its framework.
Figure 5-6 depicts a bird’s-eye view of the remoting framework. The framework is modeled
around the principle of layered architecture. Each layer provides a specific responsibility, which in
turn promotes loose coupling between layers. Such layer-wise separation provides complete flexi-
bility when it comes to extending each of these layers.C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 241
Note that in Figure 5-6, both the remote object and the caller are hosted inside a separate .NET
executable. A .NET executable is a Win32 process partially baked with Intermediate Language (IL)
code instead of native instruction and executed under the surveillance of the CLR. The Win32 process
is an environment provided by the operating system (OS) and is equipped with all the necessary
run-time facilities such as memory and other system-related resources. Another important feature
of the Win32 process is that it acts as a fault isolation gate; in other words, failure in one process will
not affect other processes running in the system.
The CLR extends the concept of the Win32 process one step further in the form of an application
domain. An application domain, which is the brainchild of the CLR, offers a fault isolation environ-
ment to managed applications. In a nutshell, managed applications are executed inside a default
application domain created by the CLR. The most striking feature is that the CLR allows the creation
of multiple application domains inside a single Win32 process and also treats each of these application
domains as a separate unit of processing. So, if multiple instances of the managed application are
executed in multiple application domains and if one application executes error-prone code resulting
in an unexpected crash, then only the crashed application domain is affected. The other application
domains are completely untouched. Previously, the only way to achieve such fault isolation was to
spawn each application as a separate, independent Win32 process. Although the Win32 process is
definitely the nicest thing available, it comes with a cost in terms of the additional processing over-
head. On the other hand, the application domain is very lightweight and consumes less memory.
The application domain is also touted for its dynamic capability to load and unload itself during the
execution of the program. Keep in mind that the application domain is an abstraction provided by
the CLR, and therefore to the OS it appears as a big chunk of the Win32 process. Hence, when a Win32
process is terminated, all application domains will be effectively terminated.
As depicted in Figure 5-5, an object is always incubated inside a context. In the .NET world, the
context is none other than the application domain. So, every object is affiliated with an application
domain. Also, no two objects instantiated on a different application’s domain running under the same
application process will be able to access each other’s methods or properties. This is similar to two
people living in two different rooms under the same roof but who are still strangers to each other.
So, how do these .NET objects communicate with each other? The answer is .NET Remoting, which
addresses the need of both local process communication (LPC) and remote process communication
(RPC). LPC is the communication between two application domains inside the same application
process, and RPC is when the communication spans two application domains hosted on a different
application process.
Let’s examine Figure 5-6 more closely using a detailed flow-wise explanation. You are aware of
how the caller interacts with a remote object with the help of a proxy that masquerades as a real object
in the caller application domain. The proxy, after intercepting calls from the caller, forwards them
to the next layer in the remoting framework, as described here:
Formatter layer: This layer is tasked with the responsibility of marshaling the intercepted message
from the proxy into a specific format. This message, along with the method name and arguments,
contains other remoting-specific information that identifies the target remote object on which
this method is invoked. The format type of this message could be a raw binary or XML or custom
format. By default, the remoting framework provides support for both binary format and SOAP
format. The binary formatter undoubtedly is the fastest formatter but when interoperability is
at stake, then SOAP is the way to go. The formatter plays a dual role. On the receiving end (the
server side), it unmarshals the message back to the appropriate CLR type; on the sending end,
it serializes the CLR type to the appropriate wire-encoding format.242C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
Custom sink layer: Compared to its predecessor, the remoting architecture provides a mind-blowing
level of extensibility. The custom sink layer allows developers to plug their custom logic. Such
custom logic provides the means to introduce additional features, be it business features or
infrastructure-related features. One of the most commonly used features is securing the message
by applying a strong encryption technique. A mind-numbing way to implement this feature is
to change both the proxy and the remote objects and inject additional security code into every
method. A much smarter way to achieve this is with the help of a custom sink that is transpar-
ently plugged, and then every message is passed through this custom sink layer, thus providing
complete liberty to sinks to further change the characteristics of the message.
Channel layer: The channel layer is the backbone for message delivery within the remoting
framework. This layer is responsible for transporting a message to its destination, which could
be a separate application domain hosted on either the same machine or a different machine.
The merits of decoupling transport-level details into a separate layer are that it allows developers
to experiment with a wide range of protocols, and both the caller (client) and the remote object
(server) are completely unaware of how messages are received and delivered to the destination.
By default, TCP and HTTP channels are bundled as part of the remoting framework.
Pipe: The pipe is an abstract wire that builds a data conduit between two applications, and data
is pushed in or out of this conduit. A pipe could be further classified as a logical and physical pipe.
A logical pipe is built when the scope of communication is confined within the same machine
and between two separate application domains. A physical pipe is implemented with network
cables that connect machines to form a network.
Exploring the Multiple Facets of a Remoting Object
The remoting infrastructure allows the creation of both mobile and remote objects. Mobile objects
and remote objects are also popularly known as marshal-by-value (MBV) and marshal-by-reference
(MBR) objects, respectively. MBR objects in the remoting platform are broadly categorized as server-
activated objects (SAOs) and client-activated objects (CAOs). Both SAOs and CAOs vary in how the
object state, lifetime, and activation are managed. The lifetime of an SAO-based object is directly
controlled by the context in which it is hosted (the server), and the lifetime of a CAO-based object
depends on the lifetime of the caller (the client).
We will now describe the two types of remoting objects:
Stateless object: In the remoting context, a stateless remote object is devoid of any state man-
agement features. The lifetime of a stateless remote object is very short. It begins with method
invocation and ends with the execution of the method. It also means that for every method invo-
cation received from the caller, a new instance of the remote object is created and finally
destroyed. Such immediate recycling of remote objects provides no room for preserving any
state that could later be accessed on a subsequent method invocation. Remoting supports state-
less objects in the form of SingleCall objects, which are categorized under SAO. In a SingleCall
object, every new request triggered from the caller is handled by a unique instance of the remote
object. This instance is constructed upon method request and is subject to garbage collection
upon the completion of the method execution.C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 243
Figure 5-7. Multiple facets of a remoting object
Stateful object: In the remoting context, a stateful remote object is provided with state manage-
ment features. It goes one step further by allowing the state of an object to be manipulated both
at the global level and at the session level. Remoting allows the construction of stateful objects
in the form of a Singleton or CAO object. Singleton objects, like SingleCall objects, are categorized
under SAO, but the similarities end there. Singleton objects are stateful objects, and this means
their state is preserved across method calls. Another important feature of Singleton objects is
that only a single instance of the remote object exists at any point of time. Figure 5-7 shows this
in action where a single instance of a remote object is served to multiple callers. A Singleton object
also allows for easy data sharing because a change in the state of a Singleton object is immediately
visible to the callers. On the other hand, CAO-based objects are the equivalent of local objects
whose lifetimes are directly controlled by the caller, but the instantiation still happens in the
context in which the CAO object is hosted, which is usually the server. CAO, unlike Singleton,
allows the creation of multiple instances, and each instance is uniquely distinguishable by the
caller.
The flexibility that remoting provides is evident in the different types of MBR objects described.
Merits and demerits are associated with the different types, but the decision to choose the correct one
is mainly an architectural decision.244C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
Figure 5-8. The service controller and heartbeat service are loaded in a different application domain;
communication between them takes place through remoting.
Introducing Local Process Communication (LPC)
In this section, we will demystify the process of how communication is established between two
application domains. To illustrate this, we will show how to build a service controller. A service controller
is the equivalent of a Windows service manager that controls the startup, shutdown, and other
maintenance-related activities of a service. The only difference between the Windows service man-
ager and the service controller is that although the former is meant to manage application process,
the latter is meant to control trading operation–related services. A real-life example of trading
operation–related services is the heartbeat service (see Figure 5-8). The heartbeat service periodically
monitors the heartbeat of the important trading components. For example, an order management
system depends upon several subcomponents such as a bookkeeping service, an exchange routing
gateway, and a market data service that are installed on a separate machine. In this type of environ-
ment, it is extremely important to keep a close watch on the health of all these services, and this is
where the heartbeat service plays an important role. The heartbeat service forms the basic requirement
of the trading operational requirements, and we will use this as the code example throughout the
chapter.
To build this example, you will need the three projects mentioned in Table 5-1.
Table 5-1. LPC assembly structure
Project Name Assembly Type Description
LPC.Common Class library The interdomain communication between two processes
or between two machines imposes a particular posture
toward the composition of the class (in other words, adopting
interface-based polymorphism). The interface defines
a contract that needs to be adhered to by the class implemen-
ting it. This contract does not provide core implementation;
rather, it defines a skeletal implementation of members
and properties. The advantage of using the interface is
that it decouples the caller from knowing the underlying class
implementation, allowing the caller to communicate to any
object instance of the class as long as it adheres to the
defined contract. This particular posture of programming
has already been well established and religiously followed
in other distributed programming environments such as
CORBA, DCOM, and so on.
This class library contains shared interfaces that are refer-
enced by both the service controller (LPC.ServiceHost) and
the service provider (LPC.Services).C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 245
Project Name Assembly Type Description
LPC.ServiceHost Executable This is the service controller application that is responsible
for managing various infrastructure-related services such
as the heartbeat service, instrumentation service, roles
entitlement service, and so on. The management task
includes starting a service, suspending a service, and stopping
a service.
LPC.Services Class library This library includes all the core infrastructure services such
as the heartbeat service, the instrumentation service, and so
on. Packaging core infrastructure services into a separate
class library allows the easy maintenance of code.
We begin our remoting journey with the declaration of IService. This interface defines two
important members that are implemented by the core infrastructure services:
using System;
namespace LPC.Common
{
public interface IService
{
void Start();
void Stop();
}
}
IService defines the skeletal implementation and is inherited by a concrete infrastructure
service, and the heartbeat service is one of them. The heartbeat service is a core infrastructure service
that continuously generates a heartbeat message. In reality, a lot of steps are involved before gener-
ating a heartbeat, but for demonstration purposes we have ignored those steps. Start and Stop are
the two important methods defined in the HeartBeatService class (see Listing 5-1).
Listing 5-1. Heartbeat Service (LPC Version)
using System;
using System.Configuration;
using System.Threading;
using LPC.Common;
namespace LPC.Services
{
public class HeartBeatService : MarshalByRefObject,IService
{
bool stopFlag=true;
int hbInterval;
public HeartBeatService()
{
//Configure this service to check for heartbeat messages
//at an interval of two seconds
hbInterval=2000;
}246C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
public void Start()
{
//This method triggers the heartbeat check activity at a predefined interval
while(stopFlag)
{
Console.WriteLine("Checking HeartBeat");
Thread.Sleep(hbInterval);
}
}
public void Stop()
{
stopFlag = false;
}
}
}
The Start method contains the while loop code that displays a message on the console every
two seconds. The loop termination logic is determined by the code inside the Stop method. Both these
methods adhere to the members defined in the IService interface by supplying a concrete code
implementation. The interesting piece of code to look at is MarshalByRefObject, which is inherited
by the HeartBeatService class. By inheriting from MarshalByRefObject, HeartBeatService is promoted
to a remotable class, and with the help of the remoting infrastructure, its public members can be
invoked remotely.
After finishing with the implementation of the heartbeat service, the next step is to spin off the
execution of this service in a separate application domain. In this way, individual infrastructure
services will be running in their own application domains. To achieve this, a new LogicalProcess
class is defined that provides an execution environment to the individual infrastructure service:
using System;
using System.Reflection;
using System.Runtime.Remoting;
using System.Threading;
using LPC.Common;
namespace LPC.ServiceHost
{
public class LogicalProcess
{
AppDomain appDomain;
Thread appThread;
IService serviceProxy;
public LogicalProcess(string serviceName)
{
//Derives type to be instantiated in a new appdomain
//It is important to specify type name along with its namespace
string typeName = "LPC.Services." +serviceName;
//Create a new application domain
appDomain = AppDomain.CreateDomain(serviceName);
//The next step is to load LPC.Services assembly in this newly created
//application domain and also instantiate the appropriate type.
//Both these tasks
//are achieved with the help of CreateInstanceAndUnwrap that returnsC H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 247
//a proxy reference that is cast back to the IService interface
IService serviceProxy =
appDomain.CreateInstanceAndUnwrap("LPC.Services",typeName) as IService;
//After instantiating the new service, the processing of service
//is offloaded to a new thread. This is similar to spawning
//a new Win32 process, which by default creates a new thread and executes
//the entry point method
appThread = new Thread(new ThreadStart(serviceProxy.Start));
}
public void Start()
{
//The newly created thread begins its execution
//i.e. invokes the Start method of the service
appThread.Start();
}
public void Stop()
{
}
}
}
The core implementation of LogicalProcess resides in the constructor method, where a new
application domain is created using the CreateDomain static method of the AppDomain class. The
AppDomain class represents the programming aspect of application domains and provides a broad
spectrum of features related to application domain management. One of the important features
AppDomain provides is the creation of a new application domain using the CreateDomain method.
This method returns a reference to the newly created AppDomain, which could then be used to load
assemblies. Assemblies, as you know, are either executables or dynamic link libraries, and AppDomain
supports loading both these assembly types.
In the constructor method of LogicalProcess, you create a new AppDomain by passing a friendly name
as the method argument. Once AppDomain is successfully created, the assembly is loaded, and an appro-
priate type is instantiated. Both these tasks are achieved with a call to the CreateInstanceAndUnwrap
method. This method accepts the assembly name as the first argument and the type’s full name as the
second argument. In this code, you pass both the infrastructure service assembly name (LPC.Services)
and the concrete service name (LPC.Services.HeartBeatService) to the CreateInstanceAndUnwrap
method, which in turn loads the assembly, instantiates the type, and finally returns a proxy reference
to the newly created service that is then cast back to the IService interface. The proxy reference then
paves the way to the real object hosted in a different AppDomain.
Finally, ServiceHost gives the finishing touch to this example. It is a console-based host appli-
cation that by default runs on an application domain created by the CLR during the initial loading
phase of the application. ServiceHost acts as a single point of management, and its primary respon-
sibilities include loading the individual infrastructure service in a separate application domain and
unloading it when not required.
using System;
using System.Reflection;
namespace LPC.ServiceHost
{
class ServiceHost
{
static void Main(string[] args)248C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
{
//The heartbeat service is launched in a new application domain
LogicalProcess serviceProcess = new LogicalProcess("HeartBeatService");
serviceProcess.Start();
Console.WriteLine("Press any key to Stop Service");
Console.ReadLine();
serviceProcess.Stop();
}
}
}
To compile and execute ServiceHost, you need to ensure the LPC.Services assembly is success-
fully copied into the service controller executable directory. With this example, you have scratched
the surface of .NET Remoting. To further expand this example, we will slightly modify the code to
demonstrate the appropriate fit for the mobile object (in other words, the MBV object). You know
that MBV objects are instantiated and serialized from one context to another context. So, to integrate
this flavor of communication, we will introduce a new class named ServiceInfo. This class captures
important attributes that provide additional information about the infrastructure service to the service
controller. Although the information inside this class will be populated in the callee’s context, being
an MBV object, the complete state of object is serialized and resurrected in the caller’s context. This
means ServiceInfo will be accessed both by the callee and by the caller, and hence it becomes a perfect
candidate to be part of the shared (LPC.Common) assembly.
using System;
using System.Collections;
namespace LPC.Common
{
[Serializable]
public class ServiceInfo
{
//User-Friendly Name of this service specifically used to
//uniquely identify this service
public string FriendlyName;
//A very detailed description of features offered by this service
public string Description;
//List of dependent services
public ArrayList DependentServices;
//Indicates the start date and time of the service useful for audit purpose
public DateTime StartDate;
}
}
Annotating the Serializable attribute indicates to the remoting infrastructure that the ServiceInfo
class needs to be marshaled by value instead of marshaled by reference. So, to access ServiceInfo,
the IService interface needs to be changed and is introduced in the form of an additional method
(see Listing 5-2).
Listing 5-2. Common Operations Supported by Infrastructure Services
using System;
namespace LPC.Common
{
public interface IService
{
void Start();C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 249
void Stop();
ServiceInfo QueryServiceInfo();
}
}
In Listing 5-2, a new QueryServiceInfo method was introduced. This method will then be
implemented by the infrastructure service (in other words, HeartBeatService) to furnish additional
information:
using System;
using System.Configuration;
using System.Threading;
using LPC.Common;
namespace LPC.Services
{
public class HeartBeatService : MarshalByRefObject,IService
{
public ServiceInfo QueryServiceInfo()
{
//This method publishes meta-information about service
ServiceInfo srvInfo = new ServiceInfo();
srvInfo.FriendlyName = "Service HeartBeat Service";
srvInfo.Description =
"Checks HeartBeat of services at a regular interval of 2 seconds";
return srvInfo;
}
}
}
The necessary modifications required to access the service information have been applied to
both the IService interface and the HeartBeatService class. So, the next task is to provide this infor-
mation to the service controller. However, the service controller never directly interacts with the
infrastructure service; it adopts an indirect route to communicate with the service with the help of
LogicalProcess. The following code modification in the LogicalProcess class is necessary to allow
the service controller to query the service information:
using System;
using System.Reflection;
using System.Threading;
using LPC.Common;
namespace LPC.ServiceHost
{
public class LogicalProcess
{
public ServiceInfo ProcessInfo
{
get{return serviceProxy.QueryServiceInfo();}
}
}
}
The updated ServiceHost now uses the ProcessInfo property of the LogicalProcess class to
retrieve and display the service information:
using System;
using System.Reflection;
using LPC.Common;250C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
namespace LPC.ServiceHost
{
class ServiceHost
{
static void Main(string[] args)
{
//The heartbeat service is launched in a new application domain
LogicalProcess serviceProcess = new LogicalProcess("HeartBeatService");
serviceProcess.Start();
//The meta-information about service is retrieved
//and stored in an instance of ServiceInfo. Although this call is processed
//in a callee application domain, the result is marshaled by value
//in a caller application domain
ServiceInfo srvInfo = serviceProcess.ProcessInfo;
//The meta-information about service is displayed
Console.WriteLine("Service Info");
Console.WriteLine("------------");
Console.WriteLine("Name : " +srvInfo.FriendlyName);
Console.WriteLine("Description : " +srvInfo.Description);
Console.WriteLine("Press any key to Stop Service");
Console.ReadLine();
serviceProcess.Stop();
}
}
}
Configuring Infrastructure Services
Application configuration files contain information such as database connection strings, application
run-time information, and so on, that is vital for building highly adaptive applications. In bygone
days, this information was stored in INI files or the Windows registry database. With the advent of
.NET, this practice has changed, and application configurations are stored in XML files. Furthermore,
the framework provides a special pack of configuration helper classes to read information from these
XML-based configuration files.
By default, .NET executables are mapped to a default configuration file. This default configura-
tion file is in the same directory as the application, and the name of the configuration file is derived
from the executable name and appended with the .config extension. For example, if the executable
name is LPC.ServiceHost.exe, then the name of its corresponding configuration file would be LPC.
ServiceHost.exe.config. In addition to the custom application configuration, the .NET Framework
provides a machine.config file installed under the C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\
CONFIG directory. The machine.config file contains settings that are globally applied to all .NET assemblies.
The configuration framework in .NET first probes into the machine configuration file, before looking
into the application configuration file. It is considered a best practice to separate global settings from
application-specific settings and store them in the machine configuration file. However, settings
defined in the custom application configuration can still override machine.config settings.
The configuration file is composed of information that is specific to both applications and the
CLR. The application configuration details are defined in the form of key-value pairs inside the
<appSettings> element of the configuration file.
To get a feel of the .NET configuration framework, we will modify the heartbeat service code
described in Listing 5-1. Currently, the heartbeat interval of the heartbeat service is configured to
two seconds and is hard-coded inside the code. Ideally, the configuration file should drive this
interval, and this is what the code in Listing 5-3 achieves.C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 251
Listing 5-3. Heartbeat Service Configuration Settings
<configuration>
<appSettings>
<add key="HeartBeatInterval" value="2000"/>
</appSettings>
</configuration>
The configuration information described in Listing 5-3 is saved in the LPC.Services.dll.config
file. It captures the heartbeat interval information in the form of a key-value pair. To access this
configuration information, you need to use the ConfigurationSettings class defined in the System.
Configuration namespace, and accordingly HeartBeatService is updated:
using System;
using System.Configuration;
using System.Threading;
using LPC.Common;
namespace LPC.Services
{
public class HeartBeatService : MarshalByRefObject,IService
{
public HeartBeatService()
{
//Heartbeat interval is read from an application configuration file
//i.e. the value is read from LPC.Services.dll.config
int hbInterval =
Convert.ToInt32(ConfigurationSettings.AppSettings["HeartBeatInterval"]);
}
}
}
ConfigurationSettings exposes the AppSettings property that is a run-time representation of
the <appSettings> element. The AppSettings property returns a NameValueCollection class populated
with a list of keys and values defined inside the <appSettings> element. The constructor method of
HeartBeatService is modified to read the heartbeat interval from the configuration file. Additionally,
you also need to update the LogicalPocess class with an additional overloaded constructor method,
as shown in Listing 5-4.
Listing 5-4. Assigning a Custom Configuration File
using System;
using System.Reflection;
using System.Threading;
using LPC.Common;
namespace LPC.ServiceHost
{
public class LogicalProcess
{
public LogicalProcess(string serviceName,string configurationFile)
{
//Binding decision of a new application domain is dictated by
//creating a new instance of AppDomainSetup
AppDomainSetup domainSetup = new AppDomainSetup();252C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
//Custom Configuration File Path
domainSetup.ConfigurationFile = configurationFile;
string typeName = "LPC.Services." +serviceName;
appDomain = AppDomain.CreateDomain(serviceName,null,domainSetup);
serviceProxy = appDomain.CreateInstanceAndUnwrap("LPC.Services",typeName)
as IService;
appThread = new Thread(new ThreadStart(serviceProxy.Start));
}
}
}
In Listing 5-4, the constructor method accepts the full path of the configuration file as an addi-
tional argument. This configuration path is then assigned to the ConfigurationFile property of the
AppDomainSetup class. The AppDomainSetup class stores information related to binding decisions in
an application domain. This binding information is then passed to the CreateDomain method.
With this example, we implemented an element of adaptiveness by separating the custom con-
figuration of an individual infrastructure service and driving its execution behavior based on values
defined in the configuration file.
Shadow Copying Infrastructure Services
Developers familiar with programming in ASP and IIS must have wrestled with the DLL locking problem.
This locking problem completely handcuffed developers from overwriting old files with new versions
because of IIS exclusively locking these files. This problem is exacerbated particularly when the IIS
service needs to be restarted in order to allow these DLLs to be overwritten. However, today’s .NET
landscape gives you new ammunition named shadow copy to battle this kind of problem.
Shadow copy is a mechanism where the libraries or executables are replicated from a launching
directory (the master directory) to a mirrored directory (the cache directory). This cache directory
then becomes the active location, and files from this location are served to the main memory. This
certainly eases the problem of deployment, and developers are now free to overwrite the files at any
point of time without bringing down the entire application. .NET supports shadow copying at the
application domain level. Assemblies loaded inside the shadow copy–enabled application domain
are copied into a cache directory and accessed from this new location. The following code introduces
this feature in the LogicalProcess class to support the shadow-copying infrastructure service assembly:
using System;
using System.Reflection;
using System.Threading;
using LPC.Common;
namespace LPC.ServiceHost
{
public class LogicalProcess
{
public LogicalProcess(string serviceName,bool shadowCopy)
{
AppDomainSetup domainSetup = new AppDomainSetup();
//Assign the list of directory from which the assemblies
//are shadow copied.
domainSetup.ShadowCopyDirectories = AppDomain.CurrentDomain.BaseDirectory;
//A boolean value that indicates whether all assemblies loaded in
//application domain are shadow copied
domainSetup.ShadowCopyFiles = shadowCopy.ToString();C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 253
//Service name by default represents application name
domainSetup.ApplicationName = serviceName;
//Cache Path represents the physical location where assemblies loaded
//inside application domain are mirrored and then executed from this
//directory. However, in reality the assemblies are copied into
//the CachePath\ApplicationName directory
domainSetup.CachePath = @"C:\CacheLocation";
string typeName = "LPC.Services." +serviceName;
appDomain = AppDomain.CreateDomain(serviceName,null,domainSetup);
serviceProxy = appDomain.CreateInstanceAndUnwrap("LPC.Services",typeName)
as IService;
appThread = new Thread(new ThreadStart(serviceProxy.Start));
}
}
}
The AppDomainSetup class provides four important properties that need to be correctly assigned in
order to turn on the shadow-copy feature. The ShadowCopyFiles property accepts a Boolean value of
true or false. Even though there is no support for shadow copying individual assemblies, with the
help of the ShadowCopyDirectories property developers can specify a list of directory names separated
by a semicolon, and assemblies loaded from this directory will be shadow copied. Both the CachePath
and ApplicationName properties indicate the name of a directory from which all assemblies loaded
in a shadow copy–enabled application domain will be copied. The assemblies are copied into the
CachePath\ApplicationName directory.
Finding the AppDomain Treasure
Along with the important features discussed in the previous section, the AppDomain type also provides
a handful of properties and events that prove extremely beneficial in day-to-day development
(see Table 5-2).
Table 5-2. Methods and Events of Application Domain
Method/Event Description
FriendlyName Returns a friendly name for the application domain.
GetAssemblies() Returns the list of assemblies loaded in the application domain.
ExecuteAssemblies() Executes the assembly in the application domain. This method is
invoked to launch .NET executables.
GetData() and SetData() The application domain provides a name-value pair data bag that
allows storing application-related custom data. This data bag is freely
accessible from other application domains. Most of the system-level
configuration data such as application directory, configuration file,
cache directory, and so on, are stored in this data bag.
AssemblyLoad This event is raised when the assembly is loaded.
AssemblyResolve This event occurs when the runtime fails to locate a particular assembly.
DomainUnload This event is raised when the application domain is about to shut
down. This event notification allows handlers of these events to
perform the final cleanup activities.
TypeResolve This event occurs when the runtime fails to resolve any types in an
application domain.
UnhandledException This event is the equivalent of a global exception handler but works
only in the default application domain.254C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
Introducing Remote Process Communication (RPC)
In this section, we will build a distributed version of the service controller example that will be grafted
on top of the remoting infrastructure. Both the infrastructure service and the service controller are
hosted on a separate machine, and this example is similar to a real-life environment where in fact
infrastructure services are distributed across several machines. This also leads to a client-server
architecture where the service controller is a client and the individual infrastructure service is a server.
As a first step, we have identified the required assemblies, as shown in Table 5-3.
Table 5-3. RPC Assembly Structure
Project Name Assembly Type Description
RPC.Common Class library This class library contains shared
interfaces that are referenced by both the
client (RPC.ServiceController) and the
server (RPC.Services).
RPC.ServiceController Executable This is the service controller (client)
application that controls the management
of infrastructure services.
RPC.Services Executable This is the application (server) that hosts
infrastructure services.
Now you will begin the journey in the distributed world with the declaration of the IService
interface that forms part of the shared RPC.Common class library. This exercise is similar to one we
presented in the “Introducing Local Process Communication (LPC)” section of this chapter.
using System;
namespace RPC.Common
{
public interface IService
{
void Start();
void Stop();
}
}
IService defines members that are supported by core infrastructure services. The only difference
you will notice is that it doesn’t support the QueryServiceInfo member. This has been separated into
the new interface IServiceInfo, as follows:
using System;
namespace RPC.Common
{
public interface IServiceInfo
{
ServiceInfo QueryServiceInfo{get;}
}
}
The final class in the shared library is ServiceInfo, as shown in Listing 5-5.C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 255
Listing 5-5. Meta-information About Infrastructure Service
using System;
using System.Collections;
namespace RPC.Common
{
[Serializable]
public class ServiceInfo
{
public string FriendlyName;
public string Description;
public ArrayList DependentServices;
public string Location;
}
}
In Listing 5-5, along with basic information, you will find a new Location field. We will explain
the intent of this field in a moment. With this class, we have completed the task of defining all
shared interfaces that will be used in this example. In the next step, we will define the server-side
implementation that hosts infrastructure services packaged inside the RPC.Services assembly (see
Listing 5-6).
Listing 5-6. Heartbeat Service (RPC Version)
using System;
using System.Threading;
using RPC.Common;
namespace RPC.Services
{
//By inheriting from MarshalByRefObject, we have made it a remotable class
//The heartbeart functionality defined here is more or less similar to
//its LPC version
public class HeartBeatService : MarshalByRefObject,IService
{
Thread serviceThread;
bool serviceStop;
public HeartBeatService()
{
}
public void Start()
{
Console.WriteLine("HeartBeat Service Started...");
serviceThread = new Thread(new ThreadStart(Run));
serviceStop=true;
serviceThread.Start();
}
public void Run()
{
while(serviceStop)
{
Console.WriteLine("Sending HeartBeat Message...");
Thread.Sleep(2000);
}
}256C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
public void Stop()
{
serviceStop=false;
}
public override object InitializeLifetimeService()
{
return null;
}
}
}
In Listing 5-6, HeartBeatService is inherited from MarshalByRefObject and also implements the
IService interface defined in the shared (RPC.Common) library. The code is more or less similar to the
HeartBeatService class defined in the cross-application domain example (see Listing 5-1), except
that in Listing 5-6 the service is responsible for spawning a thread and running its code in this new
thread. Also, a new overridden member, InitializeLifetimeService, relates to the object lifetime,
which is explained in detail in the “Understanding Distributed Garbage Collection” section. After
defining the heartbeat service, the next step is to define meta-information that provides the remote
location of the heartbeat service to the service controller (the client), as shown in Listing 5-7.
Listing 5-7. Heartbeat Service Meta-Information
using System;
using RPC.Common;
namespace RPC.Services
{
//This remote class provides meta-information about the heartbeart service
public class HeartBeatServiceInfo : MarshalByRefObject, IServiceInfo
{
ServiceInfo srvInfo = new ServiceInfo();
public HeartBeatServiceInfo()
{
srvInfo.FriendlyName = "Service HeartBeat Service";
srvInfo.Description =
"Checks HeartBeat of services at a regular interval of 2 seconds";
//This is an important attribute because it represents
//the remote location of the actual heartbeat service
srvInfo.Location = "tcp://localhost:15000/HeartBeatService.rem";
}
public ServiceInfo QueryServiceInfo
{
get{return srvInfo;}
}
}
}
In Listing 5-7, the HeartBeatServiceInfo class provides additional information about the heart-
beat service. This class is also inherited from MarshalByRefObject and implements the IServiceInfo
interface. The motive behind this class is to emit metadata information about the service. We could
have mixed this logic with the core service, but for demonstration purpose we factored it out as
a different class.C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 257
The last and the important leg of the server-side implementation is to pepper HeartBeatService
and HeartBeatServiceInfo with remoting ingredients so that they will be accessible from the service
controller. The code shown in Listing 5-8 achieves this objective.
Listing 5-8. Hosting Infrastructure Services
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
namespace RPC.Services
{
class Host
{
static void Main(string[] args)
{
Console.WriteLine("HeartBeat Service Console..");
//Identify the wire-encoding format; in this case we have selected
//BinaryFormatter
BinaryServerFormatterSinkProvider svrFormatter =
new BinaryServerFormatterSinkProvider();
//Identify the communication protocol used to deliver the data.
//The wire-encoding details are also specified here
TcpServerChannel svrChannel =
new TcpServerChannel("ServiceChannel",15000,svrFormatter);
//Registration of communication protocol and wire-encoding format to be used
//by the remoting infrastructure
ChannelServices.RegisterChannel(svrChannel);
//Registration of Singleton remote types
RemotingConfiguration.RegisterWellKnownServiceType(typeof(HeartBeatService),
"HeartBeatService.rem",WellKnownObjectMode.Singleton);
//Registration of singlecall remote types
RemotingConfiguration.RegisterWellKnownServiceType(
typeof(HeartBeatServiceInfo),
"HeartBeatServiceInfo.rem",WellKnownObjectMode.SingleCall);
Console.WriteLine("Infrastructure service host started...");
Console.ReadLine();
}
}
}
In Listing 5-8, the Host class defines the executable entry point method, and inside this method
we configure the various aspects of the remoting infrastructure and finally listen to the client request.
To provide better clarity, we will break each of these aspects down and explain them line by line.
Remoting classes are packaged inside the System.Runtime.Remoting assembly available from
the Global Assembly Cache (GAC). You need to reference this assembly in the current project, which
will then allow access to the whole suite of remoting classes:
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;258C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
Communication between two application processes located on different machines is a different
beast in comparison with communications on the same machine. The most notable problem that
arises in remote communication is how to package the data and deliver it to a remote host. A devel-
oper will be completely immersed in handling the low-level details. With remoting there is no need
to worry because it is a matter of selecting the appropriate formatter (the data packaging protocol)
and channel (the data delivery protocol). Remoting provides two types of formatters, namely, binary
and SOAP formatters. Both these formatters dictate the wire-encoding format and are designed to
meet the different needs of a requirement. Amongst the two, the binary formatter is the fastest formatter
but is strictly meant for when both the client and the server are running on the same platform, such
as Windows. The SOAP formatter targets the portability requirement of the application and is effective
only when both the client and the server are running on different platforms. The formatter solves half
of the equation; to solve the other half, remoting provides two types of channels: HTTP and TCP.
Both these channels support the reliable delivery of data, but usually the TCP channel is used with
the binary formatter, and the HTTP channel is used with the SOAP formatter.
BinaryServerFormatterSinkProvider svrFormatter =
new BinaryServerFormatterSinkProvider();
TcpServerChannel svrChannel =
new TcpServerChannel("ServiceChannel",15000,svrFormatter);
The .NET Framework is bundled with two predefined channels and formatter classes. The
classes are separated based on their usage (in other words, whether they are referenced by the
server or by the client). In Listing 5-8, the BinaryServerFormatterSinkProvider and TcpServerChannel
classes will serialize the message in binary format and deliver it using TCP. TcpServerChannel is
assigned a unique channel name and is configured to listen to client requests on port 15000. If you
happen to change our minds and favor the portability requirements of the application, then the
SoapServerFormatterSinkProvider and HttpServerChannel classes are your friends. Even though
both the binary and SOAP formatters are grouped under the System.Runtime.Remoting.Channels
namespace, in the case of channels both TCP and HTTP are grouped under the System.Runtime.
Remoting.Channels.Tcp and System.Runtime.Remoting.Channels.Http namespaces, respectively.
After the selection of the appropriate channel and formatter, the next step is to register this
information with the remoting infrastructure, and this is done with the help of RegisterChannel,
which is a static method of the ChannelServices class. This method enlists the channels with the
remoting infrastructure. Using this method, you can register multiple channels as long as they share
a unique channel name:
ChannelServices.RegisterChannel(svrChannel);
After successfully configuring the communication infrastructure, you then head to the registra-
tion of the remote object, and this is done with the help of RegisterWellKnownServiceType, which is
an important static member of the RemotingConfiguration class:
RemotingConfiguration.RegisterWellKnownServiceType(typeof(HeartBeatService),
"HeartBeatService.rem",WellKnownObjectMode.Singleton);
RegisterWellKnownServiceType exposes the type to the outside world, giving it a final remotable
touch. This remotable type, whose instance will be created on the server as a result of a remote object
creation request received from the client, is supplied as a first argument to the method. The next
argument defines the object uniform resource identifier (URI) that provides unique endpoint infor-
mation about an object. The last and important argument defines the activation mode, and the only
acceptable enumerated value in this case is SingleCall or Singleton. Because the HeartBeatService
type holds the state and you want to have only a single instance of this service running, the right
approach is to make it Singleton. A Singleton type will never have more than one instance created
on the server, and this single unique instance along with its state will be shared across all clients.
The next step is to register the HeartBeatServiceInfo type, also making it remotely accessible
by clients:C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 259
RemotingConfiguration.RegisterWellKnownServiceType(typeof(HeartBeatServiceInfo),
"HeartBeatServiceInfo.rem",WellKnownObjectMode.SingleCall);
HeartBeatServiceInfo provides additional information about the heartbeat service and is passed
as a first argument to RegisterWellKnownServiceType. Remember, because this type does not perform
any kind of state management features, the activation mode is defined as SingleCall. The second
argument assigns unique object endpoint information. It is with the help of this endpoint information
that the remoting infrastructure identifies and forwards the request received from clients to the correct
object instance. Another important fact is that there is a relaxed relationship between the remotable
type and channel. A single channel can support listening on multiple remotable types, or multi-
ple channels can listen on a single remotable type. In this example, both HeartBeatService and
HeartBeatServiceInfo are accepting requests on the same channel (that is, TCP port 15000).
The server application is now up and ready to service client requests:
Console.WriteLine("Infrastructure service host started...");
Console.ReadLine();
The next part of the code will demonstrate the second leg of this example (that is, the service
controller connecting to the heartbeat service), as shown in Listing 5-9.
Listing 5-9. Hosting Service Controller
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels.Http;
using RPC.Common;
namespace RPC.ServiceController
{
class Host
{
static void Main(string[] args)
{
Console.WriteLine("Service Controller Console..");
//Identify the wire-encoding format; in this case we have selected
//BinaryFormatter
BinaryClientFormatterSinkProvider cltFormatter =
new BinaryClientFormatterSinkProvider();
//Identify the communication protocol used to interact with server.
//The wire-encoding details are also specified here
TcpClientChannel cltChannel =
new TcpClientChannel("ControllerChannel",cltFormatter);
//Registration of communication protocol and wire-encoding format to be used
//by remoting infrastructure
ChannelServices.RegisterChannel(cltChannel);
//Instantiation of Remote type (Service MetaInformation)
IServiceInfo serviceInfo = Activator.GetObject(typeof(IServiceInfo),
"tcp://localhost:15000/HeartBeatServiceInfo.rem") as IServiceInfo;
//Service meta-information is retrieved to determine the actual
//location of the heartbeat service
ServiceInfo heartBeatInfo = serviceInfo.QueryServiceInfo;
Console.WriteLine("Starting Service : " +heartBeatInfo.FriendlyName);260C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
//Instantiation of heartbeat service
IService hbService = Activator.GetObject(typeof(IService),
heartBeatInfo.Location) as IService;
hbService.Start();
Console.ReadLine();
}
}
}
In Listing 5-9, the Host class represents the consumer end in the communication chain that
connects to the appropriate infrastructure service with the help of the remoting infrastructure and
invokes its members. You will notice that both the formatter and channel configurations are set up
with the help of the BinaryClientFormatter and TcpClientChannel classes:
BinaryClientFormatterSinkProvider cltFormatter =
new BinaryClientFormatterSinkProvider();
TcpClientChannel cltChannel =
new TcpClientChannel("ControllerChannel",cltFormatter);
ChannelServices.RegisterChannel(cltChannel);
To create an instance of a remote object, you need to use the Activator class, which is an
object factory that supports the creation of both local and remote objects:
IServiceInfo serviceInfo = Activator.GetObject(typeof(IServiceInfo),
"tcp://localhost:15000/HeartBeatServiceInfo.rem") as IServiceInfo;
The important method in Activator is GetObject, which is used to create a proxy for the remotable
service. This method accepts the type as the first argument for which a proxy will be created, and
the second argument indicates the URL of the remote object. The remote object URL follows a fixed
naming convention that captures three important attributes required to establish a communication
with the remote object. The important attributes are the transport protocol, the host name, and the
port number on which the remote object is listening. These values are concatenated with object
endpoint information.
As you know, the HeartBeatServiceInfo type acts as the information marker for the heartbeat
service, and the important information it encapsulates is the URL location of the heartbeat service.
This knowledge about the core service is packaged inside the ServiceInfo serializable class and is
accessible by invoking the QueryServiceInfo property. The URL location of the heartbeat service is
stored inside the Location property, and the value returned by this property is used to create a proxy
instance to the real heartbeat service.
ServiceInfo heartBeatInfo = serviceInfo.QueryServiceInfo;
Console.WriteLine("Starting Service : " +heartBeatInfo.FriendlyName);
IService hbService =
Activator.GetObject(typeof(IService),heartBeatInfo.Location) as IService;
By invoking the Start method, the heartbeat service on the remote machine starts:
hbService.Start();
Also an important fact of remoting is even though you are able to get the proxy instance on the
remotable type using the GetObject method of the Activator class, a successful instantiation of a proxy
is by no means a success indicator. In reality, the real communication handshaking between the client
and the server happens only when a method is called on the proxy. Figure 5-9 shows the console
output of the service controller and heartbeat service.C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 261
Understanding Proxies
Proxy objects act as mediators between clients and remote objects (see Figure 5-10). Their primary
responsibility is to honor the method invocation received from the client and transparently forward
it again to the remote object. In the .NET arena, the remoting infrastructure creates two types of proxy
objects when it receives a remote object creation request from a client. Transparent proxies and real
proxies are the two proxy objects created by the remoting framework. Both these proxies are instances
of the System.Runtime.Remoting.Proxies.__TransparentProxy and System.Runtime.Remoting.Proxies.
RealProxy classes.
Although dealing with two types looks like additional overhead imposed by the framework, in
reality both of these proxies undertake a different task.
When a client issues a request to create a remote instance object, it is returned with an instance
of a transparent proxy.
A transparent proxy is a special class that mimics all methods and properties defined in the
remote object and provides an illusion of the remote object residing within the client’s context. It is
also the first in the call chain to receive all method calls invoked by the client. The client is completely
unaware of the existence of a real proxy and always interacts with the transparent proxy. However,
the existence of a transparent proxy sometimes causes confusion because the application developer
is not able to make a distinction between the real object reference and proxy references. To solve
this problem, the framework provides a special helper static method, IsTransparentProxy, in the
RemotingServices class. This method, which is based on the object passed as an argument, returns
a Boolean value indicating whether the object is a real object or a transparent proxy object.
using System;
using System.Runtime.Remoting;
class TProxy
{
static void Main(string[] args)
{
object newObj= new object();
Figure 5-9. Console output of service controller and heartbeat service
Figure 5-10. Remote calls triggered by the client forwarded to a remote object via transparent and real
proxies262C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
bool isProxy = RemotingServices.IsTransparentProxy(newObj);
Console.WriteLine(isProxy);
}
}
A transparent proxy examines the method and its arguments, packages them in an IMessage
object, and hands them over to the real proxy. From here onward, the real proxy takes charge and
completes the rest of the operation, eventually delivering the message to the server. The real proxy
also looks after the extensibility aspects of the remoting framework. This is in contrast to the trans-
parent proxy, which allows no room for any sort of customization. Another important fact is that the
instance of the real proxy is housed inside the transparent proxy and is easily accessible with the
help of another helper method provided by the RemotingServices class, as shown here:
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Proxies;
class RProxy
{
static void Main(string[] args)
{
object mbrObj=null;
//Get a reference to mbrObj
//mbrObj = <MBR Object>
//Real Proxy instance
RealProxy rp=RemotingServices.GetRealProxy(mbrObj);
}
}
A transparent proxy is also serializable in nature. This allows a reference to the proxy to be
marshaled by value on different application domains located on different machines. This proxy-
forwarding approach proves to be nifty in a scenario where a client itself is playing the role of a server
to another client, which is explained later in the service directory code example. The secret behind
proxy serialization resides in the System.Runtime.Remoting.ObjRef class. The instance of this class
wraps bare-minimum information about the remotable type, which is sufficient for the remoting
infrastructure to create a suitable proxy. Under the hood, when a proxy is marshaled, it is the instance
of the ObjRef class that gets serialized and transferred over the wire. The CLR is intelligent enough
to understand the semantics of remoting, so during the deserialization phase, when it discovers an
instance of ObjRef, it immediately creates the transparent and real proxies. The most important
information stored inside ObjRef is as follows:
  Channel information that includes machine address and port number.
  Remote object endpoint information.
  Complete chain of type information including the assembly name, culture, version, and
public key. The type chain also includes information about base types.
The whole concept of proxy serialization falls squarely in line with the new service directory
example that sits between the service controller and the heartbeat service. In the heartbeat service
code example described in the “Introducing Remote Process Communication (RPC)” section, the
service controller could directly talk to the heartbeat service, but if you exaggerate the example a bit
by fanning out more services such as the instrumentation service, the configuration service, and so
on, then life gets tougher because now in order to connect to these services, the service controller
needs to know their physical locations, port numbers, and object endpoint information. So, byC H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 263
introducing a service directory, you are blending the location transparency feature that will relieve
the service controller from knowing the location details. With the help of the service directory, all
infrastructure service–related information will be tucked into a central place. This centralization
approach also allows for easy maintenance and migration of infrastructure services to another machine
without affecting the downstream components.
As illustrated in Figure 5-11, the service controller’s first request is targeted toward the service
directory, which in turn gets satisfied with the return of a proxy reference to the controller, and after
that, the controller directly starts interacting with the heartbeat service, bypassing the service direc-
tory route.
To implement the service directory functionality, we have determined a need for the new interface
ILookUp. Obviously, this interface will be included in the shared RPC.Common library and will be made
accessible to both the client and the server. The interface declaration code is as follows:
using System;
namespace RPC.Common
{
public interface ILookUp
{
IService LookUp(string serviceName);
}
}
The service directory is an independent service and is possibly hosted on the same machine
where infrastructure services are hosted or could be on a different machine. So, in this example, we
will host the service directory as an executable and, to accommodate this requirement, create the
new console project RPC.ServiceDirectory. This project is identical to the RPC.Services project and
is mainly composed of two classes: the core lookup service class and the host class that exposes the
lookup service to the outside world. The code snippet for the lookup service class is as shown in
Listing 5-10.
Listing 5-10. Infrastructure Service Lookup
using System;
using System.Collections;
using RPC.Common;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels.Http;
Figure 5-11. Service directory264C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
namespace RPC.ServiceDirectory
{
public class ServiceLookUp : MarshalByRefObject,ILookUp
{
Hashtable connectedServices = new Hashtable();
public ServiceLookUp()
{
BinaryClientFormatterSinkProvider cltFormatter =
new BinaryClientFormatterSinkProvider();
TcpClientChannel cltChannel =
new TcpClientChannel("ControllerChannel",cltFormatter);
ChannelServices.RegisterChannel(cltChannel);
//Instantiation of remote heartbeat service and its proxy reference
//is cached in a hash table, keyed by service name
IService hbService = Activator.GetObject(typeof(IService),
"tcp://localhost:15000/HeartBeatService.rem") as IService;
connectedServices.Add("HeartBeatService",hbService);
}
public override object InitializeLifetimeService()
{
return null;
}
public IService LookUp(string serviceName)
{
return connectedServices[serviceName] as IService;
}
}
}
In Listing 5-10, ServiceLookUp is derived from MarshalByRefObject, which makes it a perfect
remoting candidate; additionally, it implements the ILookUp interface by supplying a concrete method
body to the LookUp method. To gain a deeper understanding, let’s do a step-by-step walk-through of
the code described in Listing 5-10.
With the declaration of a Hashtable, you have built a cache container that stores proxy references
of infrastructure services:
Hashtable connectedServices = new Hashtable();
This container is populated only once, as demonstrated in the following constructor code:
public ServiceLookUp()
{
BinaryClientFormatterSinkProvider cltFormatter =
new BinaryClientFormatterSinkProvider();
TcpClientChannel cltChannel =
new TcpClientChannel("ControllerChannel",cltFormatter);
ChannelServices.RegisterChannel(cltChannel);
IService hbService = Activator.GetObject(typeof(IService),
"tcp://localhost:15000/HeartBeatService.rem") as IService;
connectedServices.Add("HeartBeatService",hbService);
}C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 265
Inside the constructor method, you connect to all the required infrastructure services and cache
their proxy references inside a Hashtable. Proxy references are identified by a suitable name, and based
on this service name, they are fetched from the Hashtable.
After populating the proxy cache container, the next step is to make it available to the service
controller, which is done using LookUp. This method is the one that will be invoked by external clients.
It peeks into the cached hash table to locate an appropriate proxy reference that matches the service
name passed as a method argument. On finding a successful match, it returns the proxy reference
to the caller. This proxy reference is then marshaled back to the client context. Remember, it is the
ObjRef that gets serialized over the wire.
public IService LookUp(string serviceName)
{
Console.WriteLine("Lookup Request Received For : " +serviceName);
return connectedServices[serviceName] as IService;
}
The final part of service directory is to honor the service controller request on port 12000
(see Listing 5-11).
Listing 5-11. Hosting of Service Directory
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels.Http;
namespace RPC.ServiceDirectory
{
class Host
{
static void Main(string[] args)
{
ServiceLookUp serviceLookUp = new ServiceLookUp();
BinaryServerFormatterSinkProvider svrFormatter =
new BinaryServerFormatterSinkProvider();
TcpServerChannel svrChannel =
new TcpServerChannel("ServiceChannel",12000,svrFormatter);
RemotingServices.Marshal(serviceLookUp,"ServiceDirectory.rem");
Console.WriteLine("LookUp Service Started...");
Console.ReadLine();
}
}
}
In Listing 5-11, you will notice that Host has not used the RemotingConfiguration.
RegisterWellKnownServiceType method to publish the objects. Instead, you use the RemotingServices.
Marshal method that registers the precreated instance of the ServiceLookUp instance. Even though
using this approach is the equivalent of registering a Singleton object, in this case the object needs
to be created beforehand. By hand-rolling the instance of the ServiceLookUp class, you ensure that
the service cache is populated completely before making it available to the external world.
The final and last piece of the code is to update the service controller to make it interact with
the heartbeat service via the service directory (see Listing 5-12).266C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
Listing 5-12. Hosting of Infrastructure Service Controller
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels.Http;
using RPC.Common;
namespace RPC.ServiceController
{
class Host
{
static void Main(string[] args)
{
Console.WriteLine("Service Controller Console..");
BinaryClientFormatterSinkProvider cltFormatter =
new BinaryClientFormatterSinkProvider();
TcpClientChannel cltChannel =
new TcpClientChannel("ControllerChannel",cltFormatter);
ChannelServices.RegisterChannel(cltChannel);
//Instantiation of lookup service that is then used to locate
//the heartbeat service
ILookUp serviceLookUp= Activator.GetObject(typeof(ILookUp),
"tcp://localhost:12000/ServiceDirectory.rem") as ILookUp;
//Retrieves the proxy reference of the heartbeat service
//In this case the proxy reference is marshaled by value
IService hbService = serviceLookUp.LookUp("HeartBeatService");
//Start the heartbeat service
hbService.Start();
Console.ReadLine();
}
}
}
When the code described in Listing 5-12 is compiled and executed, it will connect to the service
directory and invoke its LookUp method. This method will return a proxy reference to the heartbeat
service, and using this marshaled proxy reference, you start the heartbeat service as shown in the
output windows in Figure 5-12.C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 267
Figure 5-12. Console output of the service directory
Understanding Distributed Garbage Collection
The most touted feature of the CLR is the automatic reclamation of memory that frees developers
from memory-related wrinkles. However, when you step down to a distributed world, the fundamental
change you will notice is that both the client and server objects are no longer within the jurisdiction
of the same application process. They are separated into different application processes that are usually
running on different machines. It is quite common for complexities to increase when communication
spreads its wings, and techniques applied in a local environment may become invalidated in a dis-
tributed environment. In the case of garbage collection, the algorithm employed searches for reachable
objects, and if it finds some, it marks them as alive and discards the unreachable objects, eventually
reclaiming the memory. This logic works flawlessly because the garbage collector (GC) has complete
knowledge about its local environment; however, in the case of remoting where server objects are
hosted on different application processes or machines, the garbage collector has no way to determine
whether the server object is accessed by a client.
To circumvent this problem, .NET adopted a leasing approach that controls the destruction of
a remote object. By default, every remote object is assigned a lease. Upon expiration of this lease,
the remote object is considered to be garbage and handed over to the garbage collector. Figure 5-13
illustrates the leasing architecture.
Figure 5-13. Object lifetime with leasing268C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
On receiving an object creation request from a client, the remoting framework constructs a new
instance of the remote object. As part of this creation process, it also associates a new instance of
the Lease object defined in the System.Runtime.Remoting.Lifetime namespace. InitialLeaseTime
and RenewOnCallTime are the important properties provided by the Lease object, and the value
assigned to this property dictates the overall lifetime of a remote object. InitialLeaseTime assigns
the default initial lease time to the remote object, which is by default configured to five minutes,
and RenewOnCallTime defines the increment factor. Based on this value, the life of the remote object
is further extended. The default renewal time is two minutes. Also, a CurrentLeaseTime property is
defined in the Lease object that returns the remaining lease time of a remote object. The default
lease values provided by a Lease object can be easily customized on a per-remote-object basis. This
is possible by overriding the InitializeLifetimeService method of the MarshalRefObject class. The
InitializeLifetimeService method is automatically called by the remoting framework during the
remote object creation stage, and upon invoking this method, it returns a Lease object. Based on
these returned values, the object lifetime is determined. The code snippet shown in Listing 5-13
demonstrates how to override the default lease behavior.
Listing 5-13. Overriding Remote Object Lease Time
using System;
using System.Runtime.Remoting.Lifetime;
class MBRLease : MarshalByRefObject
{
public override object InitializeLifetimeService()
{
//Default lease associated with remote object is retrieved
ILease objLease = (ILease)base.InitializeLifetimeService();
//Initial Lease time is updated to three minutes
objLease.InitialLeaseTime=TimeSpan.FromMinutes(3);
//Renewal time is updated to one minute
objLease.RenewOnCallTime=TimeSpan.FromMinutes(1);
return objLease;
}
}
Lease is an internal class and hence not accessible to the outside world. So, the only mechanism
to control it is by casting it back to the ILease interface. It is also mandatory to invoke the base class
InitializeLifetimeService, which returns the lease object associated with the current instance of
the remote object. The instance is then cast back to the ILease interface, and both its initial lease time
and renewal time are overridden with new values. In Listing 5-13, the initial lease time is updated
from five minutes to three minutes and the renewal time from two minutes to one minute. Note that
lease renewal happens only when there is a subsequent method call received from the client and
the renewal time is added to the current lease time.
As already mentioned, each remote object is assigned a default lease time by the remoting frame-
work. These default values are easily modifiable with the help of the LifeTimeServices class grouped
under the System.Runtime.Remoting.Lifetime.LifetimeServices namespace. For example, the fol-
lowing code decreases the default initial lease time from five minutes to three minutes and increases the
renewal time from two minutes to four minutes. After executing the following code, all newly created
remote objects will inherit these values unless specifically overridden by their InitializeLifetimeService
methods.
using System;
using System.Runtime.Remoting.Lifetime;C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 269
class DefaultLease
{
static void Main(string[] args)
{
//Change the default lease time
LifetimeServices.LeaseTime = TimeSpan.FromMinutes(3);
//Change the default lease renewal time
LifetimeServices.RenewOnCallTime = TimeSpan.FromMinutes(4);
}
}
It is also possible to provide an infinite lifetime to a remote object, preventing it from being
garbage collected until the application domain in which it is created is unloaded. In the following
code, by returning null inside the InitializeLifetimeService method, you grant an infinite lifetime
to remote objects:
using System;
class ImmortalMBR : MarshalByRefObject
{
public override object InitializeLifetimeService()
{
//By returning null, we have granted infinite lifetime to remote object
return null;
}
}
If you look at the code of the remoting classes discussed so far—specifically the
HeartBeatService (see Listing 5-6) and ServiceLookUp (see Listing 5-10)—both these classes override
InitializeLifetimeService and return null values. This step is inevitable in this case where both
the remote objects are configured as a Singleton object.
Every lease object is registered with the lease manager. The lease manager is created for each
application domain and can be considered as a garbage collector for remote objects; however, it is
deterministic in nature. The implementation of the lease manager is straightforward. It internally
maintains a collection of Lease objects, and after every configured interval, it iterates through this
collection to check for expired leases. On the expiry of a lease, the lease manager simply removes
the Lease object from its collection, thus marking it unreachable; in the subsequent garbage collec-
tion, memory occupied by an instance of Lease, and its underlying remote object, is reclaimed. The
default polling time used by the lease manager to check for expired leases is configured to ten sec-
onds. You can change this default polling value with the help of the LeaseManagerPollTime property
defined in the LifeTimeServices class:
using System;
using System.Runtime.Remoting.Lifetime;
class LeasePollTime
{
static void Main(string[] args)
{
LifetimeServices.LeaseManagerPollTime=TimeSpan.FromSeconds(20);
}
}
The lease manager also provides one final chance to the remote objects to renew its lease
before it gets discarded completely. This opportunity is gifted in the form of sponsorship. A sponsor
is an entity that is given the final authority to decide whether an object is in need of additional lease
time. An affirmative reply from the sponsor at this final stage can extend the lifetime of the remote
object. Each sponsor is registered with the lease, and multiple sponsors can be registered at a time.270C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
From an implementation point of view, the sponsor itself is derived from MarshalByRefObject and
implements the ISponsor interface defined in System.Runtime.Remoting.Lifetime. The ISponsor
interface supports the Renewal method, which decides the fate of the remote object. This method is
invoked by the lease manager to get the additional lease time assigned by the sponsor to the remote
object.
The concept of sponsorship blends well with the service controller example. Although we have
assigned an infinite time-to-live lease to the remote service object (that is, HeartBeatService) by
returning a null value inside the InitializeLifetimeService method, you can adopt a different
approach, assuming the resource allocated by individual infrastructure services is expensive in nature.
Taking into account the limited hardware resources available, you need to ensure an optimum
utilization of it. In the world of the front office, most of the core system services are not expected to
run 24×7. Rather, the working hours of trading applications never exceed more than seven to eight
hours. Considering this, you need to build a sponsor that examines the current system time. If the
time computed is not between the start and end of the trading time, then it can be easily concluded
that there is no need to renew the lease, and thus the remote object will be freely discarded. For example,
the following code checks the current time, and if it doesn’t fall between the trading hours, it expresses
its clear intention to not renew the lease by returning the TimeSpan.Zero value:
using System;
using System.Runtime.Remoting.Lifetime;
namespace RPC.Services
{
public class BODEODSponsor : MarshalByRefObject, ISponsor
{
public BODEODSponsor()
{
}
public TimeSpan Renewal(ILease lease)
{
//The logic here clearly determines the object lifetime based on
//trading hours
int tradingBod=9;
int tradingEod=16;
DateTime bodTime = DateTime.Now;
if ( bodTime.Hour >= tradingBod && bodTime.Hour <= tradingEod)
{
DateTime eodTime =
new DateTime(bodTime.Year,bodTime.Month,bodTime.Day,tradingEod,5,0);
TimeSpan diffTime = eodTime-bodTime;
Console.WriteLine(diffTime.TotalMinutes);
return diffTime.TotalMinutes > 0 ? diffTime : TimeSpan.Zero;
}
return TimeSpan.Zero;
}
}
}
Note that because the registration of a sponsor takes place on a lease object, you need to get
a reference to the lease object. You do this with the help of the GetLifetimeService static method
defined in the RemotingServices class. The GetLifetimeService method returns the lease object
associated with the instance of MarshalByRefObject. This returned instance of Lease needs to be
cast to the ILease interface in order to access its member, specifically the Register and Unregister
methods. As the name indicates, the Register method is invoked to register a new sponsor, and the
UnRegister method is invoked to unregister an existing sponsor.C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 271
Configuring Remoting
So far you have learned the various features offered by the remoting framework and also have learned
how easy it is to customize each of the aspects supported by these features. But the truth of the mat-
ter is that the example adopted a programmatic path; to change the lease manager’s default poll time,
you hard-coded the values inside the code. The same problem applies to the registration of the remote
object, where you hard-coded the port number and channel information. From a deployment per-
spective, this is an unhealthy practice because even a simple change such as changing the port
number will demand a complete recompilation and deployment of the program. However, don’t get
disappointed—the remoting framework addresses these deployment issues by allowing developers
to tweak the remoting infrastructure through a configuration file. Almost every single aspect of the
remoting object can now be regulated using a configuration file. To boot the remoting infrastructure
using a configuration file, you need to use the Configure method provided by the RemotingConfiguration
class. This method, based on the name of the configuration file passed as the argument, reads the
contents and appropriately configures the remoting infrastructure:
using System;
using System.Runtime.Remoting;
class RemotingConfig
{
static void Main(string[] args)
{
string configFile = null;
//Assign valid name of the configuration file
//configFile = "C:\RemotingConfig.config"
//Configure the Remoting Infrastructure
RemotingConfiguration.Configure(configFile);
}
}
There is no restriction on the location of the configuration file. However, the contents arranged
inside this configuration file need to adhere to a predefined remoting schema layout. A skeletal view
of a typical remoting configuration file is as follows:
<configuration>
<system.runtime.remoting>
<application name="AppName">
<lifetime/>
<channels/>
<service/>
<client/>
</application>
</system.runtime.remoting>
</configuration>
Information about the remoting infrastructure is branched under the <system.runtime.remoting>
element, and each of the child elements map to a specific aspect of the infrastructure. The
<lifetime> element hosts information about the remote object’s lifetime. Similarly, the <service>
element provides the remote object’s registration information. The <client> element looks after the
connectivity information required to connect and instantiate an instance of a remote type. The last and
final element is the <channel> element, which defines the low-level transport and wire-encoding details.
Considering the infrastructure hosting code described in Listing 5-8, you will now revisit the
code and tailor it to use the configuration file. The first step in customizing the code is to separate
the remote object registration and channel information from the code and store this information in272C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
the configuration file. Assume that a new configuration file, RPC.Services.exe.config, is created and
located in the same folder where the actual executable is stored:
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
<system.runtime.remoting>
<application>
<service>
<!-- Registration of Singleton Remote Type (HeartBeatService) -->
<wellknown mode="Singleton" objectUri="HeartBeatService.rem"
type="RPC.Services.HeartBeatService, RPC.Services" />
<!-- Registration of SingleCall Remote Type
(HeartBeat Service Meta-Info) -->
<wellknown mode="SingleCall" objectUri="HeartBeatServiceInfo.rem"
type="RPC.Services.HeartBeatServiceInfo, RPC.Services" />
</service>
<channels>
<!-- Registration of TCP channel and binary encoding format -->
<channel ref="tcp" port="15000">
<formatter ref="binary"/>
</channel>
<!-- Registration of HTTP channel and SOAP encoding format -->
<channel ref="http" port="16000">
<formatter ref="soap"/>
</channel>
</channels>
</application>
</system.runtime.remoting>
</configuration>
The information captured in the XML fragment is the same as the actual code, but the infra-
structure service host code is much cleaner now and contains a single configuration statement, as
shown here:
using System;
using System.Runtime.Remoting;
using RPC.Common;
class HostUsingConfig
{
static void Main(string[] args)
{
RemotingConfiguration.Configure(@"RPC.Services.exe.config");
Console.WriteLine("Infrastructure service host Started...");
Console.ReadLine();
}
}
On the service controller end (see Listing 5-9), you will implement a similar configuration porting
exercise, as shown in Listing 5-14.
Listing 5-14. Service Controller Remoting Configuration
<configuration>
<system.runtime.remoting>
<application>
<channels>
<channel ref="tcp" port="0">
<formatter ref="binary"/>C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 273
</channel>
</channels>
<client>
<!-- Description of remote object information -->
<wellknown url="tcp://localhost:15000/HeartBeatService.rem"
type="RPC.Common.IService, RPC.Common" />
</client>
</application>
</system.runtime.remoting>
</configuration>
Assuming that the XML snippet described in Listing 5-14 is stored in the RPC.ServiceController.
exe.config file, you modify the client-side host code to use the information contained inside this
configuration file:
using System;
using System.Runtime.Remoting;
using RPC.Common;
class HostUsingConfig
{
static void Main(string[] args)
{
RemotingConfiguration.Configure(@"RPC.ServiceController.exe.config");
WellKnownClientTypeEntry[] clientEntry =
RemotingConfiguration.GetRegisteredWellKnownClientTypes();
IService hbService = Activator.GetObject(typeof(IService),
clientEntry[0].ObjectUrl) as IService;
}
}
By separating out the configuration details for both the client and the server, you have drastically
eased the deployment burden. Changes to the remoting behavior can now be heartily welcomed
because the only candidate that would be affected is the configuration file. There are other areas in
remoting such as lifetime management, versioning, error handling, security, debugging, and so on,
where the recruitment of a configuration file technique will further increase the efficiency of appli-
cation deployment.
Lifetime Management
Even if all the facets of a distributed garbage collection cannot be dictated through configuration
files, the object default lifetime and lease manager poll time are allowed to reside within the config-
uration file:
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
<system.runtime.remoting>
<application>
<lifetime
leaseTime="1S"
renewOnCallTime="1S"
leaseManagerPollTime="1S"/>
</application>
</system.runtime.remoting>
</configuration>274C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
Versioning
Versioning of an assembly plays an important role, especially in a distributed scenario where both the
client and the server are physically separated. In the service controller example, you saw the benefit
of a shared assembly, but envisage a scenario where a client and a server hold different versions of
the shared assembly. How would remoting handle this version mismatch when it receives a call from
the client to the server, or vice versa? Two attributes, includeVersions and strictBinding, are asso-
ciated with formatters to determine the version tolerant levels:
<configuration>
<system.runtime.remoting>
<application>
<channels>
<channel ref="tcp" port="15000">
<serverProviders>
<formatter ref="binary" includeVersions="false"
strictBinding="false"/>
</serverProviders>
</channel>
</channels>
</application>
</system.runtime.remoting>
</configuration>
A TypeLoadException is thrown if the remoting framework fails to load the type based on the
four conditions shown in Table 5-4.
Table 5-4. Versioning Parameters
includeVersions strictBinding
(Sending Formatter) (Receiving Formatter) Behavior
true true Exact type is loaded by the remoting framework.
false true Type is loaded using the type name and assembly
name.
true false The remoting framework first attempts to load
the exact type. If it fails to load, then it makes
a second attempt to load a type using the type
name and assembly name.
false false Type is loaded using the type name and assembly
name.
Error Handling
Remoting supports the propagation of exceptions raised on the server side back to the original
caller (the client). But the amount of information transferred to the caller is controlled by the mode
attribute value defined in the customErrors element:
<configuration>
<system.runtime.remoting>
<customErrors mode="off"/>
</system.runtime.remoting>
</configuration>
Table 5-5 lists the possible values that control the propagation of remoting exceptions from
server to client.C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 275
Table 5-5. Remoting Exceptions
Value Behavior
off Callers receive complete exception information including the server stack trace.
on Callers receive filtered exception information.
remoteOnly Local callers (a client running on the same machine as the server) receive
complete exception information, but remote callers receive filtered exception
information.
Security
To protect a system from unwarranted attacks, the remoting framework supports two levels of auto-
matic deserialization. These levels are defined at the formatter level, and by default they are configured
at restricted levels where only limited types required for basic remoting functionality are allowed to
serialize. To remove this restriction, the following entry must be present in the configuration file:
<configuration>
<system.runtime.remoting>
<application>
<channel ref="tcp" port="15000">
<serverProviders>
<formatter ref="binary" typeFilterLevel="Full"/>
</serverProviders>
</channel>
</application>
</system.runtime.remoting>
</configuration>
Debugging
By default, the remoting framework implements a lazy-loading technique, where the underlying
remote type on the server is brought into memory only when it receives the first call from the client.
But developers often tend to make typing errors while entering the type and assembly name. These
mistakes get manifested in the form of run-time exceptions. To avoid this and catch the exception
early during application startup time, you need to add a debug element in the configuration file, as
shown here:
<configuration>
<system.runtime.remoting>
<debug loadTypes="true"/>
</system.runtime.remoting>
</configuration>
Understanding Aspect-Oriented Programming
(AOP) in .NET
There is a popular quote that says, “Innovation is the creation of the new or the rearranging of the
old in a new way.” This statement gives you a good sense of the evolution evidenced in the field of
programming methodologies. In bygone days, procedural-oriented programming (POP) was con-
sidered to be the de facto programming methodology. Then came object-oriented programming
(OOP), which was a great boon and also forms the basis for today’s modern systems. The important
principle followed in both OOP and POP is to raise the level of abstractions and encourage developers276C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
to model applications from a particular viewpoint. In the POP world, the viewpoint is the functional
requirement itself from which the procedures are directly defined. This is in direct contrast to the OOP
world where functional requirements are decomposed into granular classes, and each individual
class then folds a specific aspect of the overall requirement by encapsulating both data and behavior.
OOP provided best-of-breed features such as encapsulation, inheritance, polymorphism, and so on,
that allowed for the efficient reuse of the code. However, currently the OOP world has some short-
comings, and this is where AOP comes to the rescue. AOP is not meant to replace OOP; instead, it is
considered to be a complementary programming technique to OOP.
Before delving into the explanation of AOP, refer to the following code (see Listing 5-15 and
Listing 5-16). This code is no different from the heartbeat service code described in Listing 5-6
except this version shields the start and stop functionality of the service with proper authorization
checks. Only users belonging to manager roles are allowed to start and stop the service. As you will
notice, this authorization code is spread in all of the infrastructure services executed under the con-
trol of the central service controller.
Listing 5-15. Heartbeat Message Targeted to Monitor NYSE Exchange Gateway
using System;
using System.Threading;
namespace AOP
{
public class NYSEHeartBeatService
{
public NYSEHeartBeatService()
{
}
public void Start()
{
if ( !Thread.CurrentPrincipal.IsInRole("Manager"))
throw new ApplicationException("Access Denied");
//Exchange-Specific Operation
}
public void Stop()
{
if ( !Thread.CurrentPrincipal.IsInRole("Manager"))
throw new ApplicationException("Access Denied");
//Exchange-Specific Operation
}
}
}C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 277
Listing 5-16. Heartbeat Message Targeted to Monitor NASDAQ Exchange Gateway
using System;
using System.Threading;
namespace AOP
{
public class NASDAQHeartBeatService
{
public NASDAQHeartBeatService()
{
}
public void Start()
{
if ( !Thread.CurrentPrincipal.IsInRole("Manager"))
throw new ApplicationException("Access Denied");
//Exchange-Specific Operation
}
public void Stop()
{
if ( !Thread.CurrentPrincipal.IsInRole("Manager"))
throw new ApplicationException("Access Denied");
//Exchange-Specific Operation
}
}
}
Both the NASDAQHeartBeatService and NYSEHeartBeatService classes are composed of two types
of requirements. The first and the most important is the functional requirement itself, which is satis-
fied by sending a heartbeat message to the exchange. The second type is the operational requirement,
which is sprinkled on top of the functional requirement. The most commonly found operational
requirement in enterprise-based applications are logging, exception handling, authorization, and
thread synchronization. These requirements are scattered inside the functional requirement, and
the code needed to perform its services are the same across all functional requirements. For example,
if you look at the NYSEHeartBeatService class, there is an explicit authorization check as a first line of
code inside the Start and Stop methods. This validation is also applied in the NASDAQHeartBeatService
class, and this doesn’t stop here. If a new exchange is introduced, then it also inherits this validation.
Operational requirements always tend to crosscut the functional requirement, resulting in the tight
coupling of functional and system classes. For example, if you need to introduce a new logging fea-
ture in Listing 5-15 and Listing 5-16, then you will face a swirl of change, and each of the functional
classes needs to be changed. Figure 5-14 shows the integration of operational requirements with
functional requirements.278C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
Figure 5-14. Integration of operational requirements with functional requirements
AOP promotes the cleaner responsibility of modules in the subsystem by identifying and separat-
ing crosscutting concerns (operational requirements) and then transparently injecting them inside
functional modules. This transparent injection technique removes the static dependency required
from the functional modules to the system modules. Furthermore, it is the power of AOP tools that
allows both the functional and system modules to adopt an independent development thread with-
out knowing the existence of each other and in the end transparently combines the features provided
by both these modules. To continue the journey with AOP, you need to first download Aspect# from
http://aspectsharp.sourceforge.net/. Aspect# is an open source AOP framework for .NET-based
applications. To demonstrate the power of AOP, we will show how to rewrite the NASDAQHeartBeatService
and NYSEHeartBeatService classes using the Aspect# framework. Figure 5-15 shows the AOP architecture.C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 279
Figure 5-15. AOP architecture
AOP has coined its own terminology, and understanding these terms and definitions is important
to becoming acquainted with the AOP-based programming environment:
Point-cut: The point-cut is the location in the code where the crosscutting concerns are injected.
The point-cut is technically represented in the form of a method, constructor, property, and
so on. For example, referring to the NASDAQHeartBeatService class, the point-cuts that can be
identified are the Start and Stop methods where the actual authorization check is performed.
Advice: The advice encapsulates logic that is transparently injected inside the code identified
by the point-cut. Advice is usually composed as a separate entity. For example, an authorization
advice is a different class that hosts the authorization logic.
Aspect: The aspect is the final unit of work in the AOP world. It declares the weaving rules by
combining the advice and point-cut.
Before we start, it is mandatory to reference two important assemblies of the Aspect# framework
inside the project. These two important assemblies are AspectSharp and AopAlliance. The next step
is to construct the AuthorizationAdvice class, which separates out the necessary authorization logic.
In the earlier OOP version, this logic was sprinkled all over the functional classes.
Here’s the code for AuthorizationAdvice:
using System;
using AopAlliance.Intercept;
using System.Threading;
using AOPServices.Services;
namespace AOPServices.Aspects
{
public class AuthorizationAdvice : IMethodInterceptor
{
public AuthorizationAdvice()
{
}280C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
public object Invoke(IMethodInvocation invocation)
{
//Perform Authorization Check
/*if ( !Thread.CurrentPrincipal.IsInRole("Manager"))
throw new ApplicationException("Access Denied");*/
Console.WriteLine("Pre-Authorization Code");
invocation.Proceed();
Console.WriteLine("Post-Authorization Code");
return null;
}
}
}
The AuthorizationAdvice class implements the IMethodInterceptor interface declared in the
AopAlliance assembly. The nice thing about the AuthorizationAdvice class is that it captures only
the functionality it is meant to capture. If you take a deep plunge into the class, specifically the
Invoke method, you will notice no other logic except the authorization check code. This authorization
logic will then be injected in the core functional class.
Next, you can rewrite the functional class, as shown here:
using System;
namespace AOPServices.Services
{
public class NASDAQHeartBeatService
{
public NASDAQHeartBeatService()
{
}
public virtual void Start()
{
//Exchange-Specific Operation
Console.WriteLine("Exchange Started");
}
public virtual void Stop()
{
//Exchange-Specific Operation
Console.WriteLine("Exchange Stopped");
}
}
}
The only difference you will notice in NASDAQHeartBeatService is that the authorization logic
code is removed from both the Start and Stop methods. Another important fact to note is that both
the Start and Stop methods are now declared virtual. This is a mandatory declaration required by
the Aspect# framework in order to successfully conduct its injection activity.
The next and final step of this program is to define the Authorization aspect that composes the
weaving rules (see Listing 5-17).C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 281
Listing 5-17. AOP-Based Heartbeat Service
using System;
using AspectSharp;
using AspectSharp.Builder;
using AOPServices.Services;
namespace AOPServices
{
class Class1
{
static void Main(string[] args)
{
String weavingRules =
" import AOPServices.Aspects " +
" " +
" aspect AuthorizationAspect for [ AOPServices.Services ] " +
" " +
" pointcut method(* Start())" +
" advice(AuthorizationAdvice)" +
" end" +
" " +
" pointcut method(* Stop())" +
" advice(AuthorizationAdvice)" +
" end" +
" " +
" end ";
AspectLanguageEngineBuilder builder =
new AspectLanguageEngineBuilder( weavingRules );
AspectEngine engine = builder.Build();
NASDAQHeartBeatService nasdaqService=
engine.WrapClass(typeof(NASDAQHeartBeatService)) as NASDAQHeartBeatService;
nasdaqService.Start();
Console.ReadLine();
}
}
}
Let’s do a step-by-step walk-through of the code described in Listing 5-17. The most interesting
and important piece of code is the weaving rules. The weaving rules are plain, ordinary text where the
source could be an XML file or a database. It is defined in accordance with the Aspect# framework,
and based on this rule definition, the framework initiates its code injection process.
The import section captures the required namespaces to be imported. This is required by the
framework to successfully resolve the advice and point-cut. The next section deals with the aspect
by declaring a friendly name and capturing the list of classes on which this aspect needs to be applied.
With the help of namespace features, you group the service and aspect classes. Hence, the rule defini-
tion states the intention of applying AuthorizationAspect on all classes grouped under the AOPServices.
Services namespace. The last section is a repeatable section composed of information related to the
point-cut and advice. The two methods identified as point-cut are the Start and Stop methods, and
at this point you inject the Authorization advice. This also marks the end of the rule definition step.282C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
Figure 5-16. Console output of AOP-enabled heartbeat service
String weavingRules =
" import AOPServices.Aspects " +
" " +
" aspect AuthorizationAspect for [ AOPServices.Services ] " +
" " +
" pointcut method(* Start())" +
" advice(AuthorizationAdvice)" +
" end" +
" " +
" pointcut method(* Stop())" +
" advice(AuthorizationAdvice)" +
" end" +
" " +
" end ";
The final phase of the code is to use AspectLanguageEngineBuilder and AspectEngine defined
in the Aspect# framework that will then dynamically inject these rules:
AspectLanguageEngineBuilder builder =
new AspectLanguageEngineBuilder( weavingRules );
AspectEngine engine = builder.Build();
Once the rules are fed to the Aspect#’s core engine, a new instance of NASDAQHeartBeatService
is created using the framework WrapClass factory method. If you compile and run this program, you
will see the output shown in Figure 5-16 displayed on the screen.
NASDAQHeartBeatService nasdaqService=
engine.WrapClass(typeof(NASDAQHeartBeatService)) as NASDAQHeartBeatService;
nasdaqService.Start();
This demonstrates the power of AOP. An important point to add to your knowledge bank is that
the advice has complete knowledge about its calling method execution context. For example, in the
AuthorizationAdvice class, you can easily examine and modify the injected method’s incoming
arguments by inspecting the appropriate properties of the IMethodInvocation interface.
AOP is not a new concept. The ideas adopted by AOP have been prevalent in the Microsoft world
for quite a while and can be tracked to the COM days when infrastructure services such as thread
safety, object pooling, transaction support, authentication, and authorization were provided by flip-
ping the appropriate switches in the component configuration UI window. AOP has recently started
gaining a lot of recognition as one of the techniques to further raise the level of abstraction in designing
an easy-to-maintain system. However, AOP is not a panacea to all problems. You must continue to
keep your foot in the OOP territory. But, with the passage of time, the adoption rate of AOP in real-life
applications will probably increase; we would not be surprised to see it prevailing in the mainstream
software development.C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 283
Figure 5-17. Application operation engine
Examining the Business-Technology Mapping
Before you step into the actual design, it is important to look at the important role played by the
operations team in an organization. Within most companies, a dedicated team known as the operations
team is appointed. The important task of continuously monitoring the activity of trading applications
in the production environment and raising an alarm in the case of abnormal behavior rests on their
shoulders. The development team relies on the information gathered by the operations team when
it comes to fixing bugs or fine-tuning application behavior. The existence of an operations team relieves
the development team from intervening in the day-to-day application hitches and allows them to
actively focus on their core task of designing and building applications.
It also means the development team needs to equip the operations team with a rich set of
information that will allow them to get thorough insight into the underpinnings of the applications.
This is where a need for implementing a centralized application operation engine that will allow the
operations team to monitor and administer applications running in an organization is determined.
The application operation engine will act as the eyes and ears of the trading applications, which
allows the operations team to watch the status of the application’s health and activity and also acts
as a central information repository for trading applications. From a features perspective, this engine
will support all kinds of operational features such as centralized logging, security, configuration, and
so on.
The framework of the application operation engine is pretty straightforward. It is similar to
the master-slave architecture style where there is one primary application controller and multiple
application agents. The primary controller is installed on a dedicated machine and separate from
the core trading applications. Agents are installed on the machine where the core trading applica-
tion resides, as depicted in Figure 5-17.
In Figure 5-17 both trading and market data agents are assigned the task of managing order-
matching and market data applications, respectively. The primary controller, besides being aware
of the active agents, also provides various services that are leveraged by applications controlled by
these agents. These services take the form of server-side services and agent-side services. Server-side284C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
services are those services that are executed under the context of the primary controller. Similarly,
agent-side services execute under the context of the agent. A typical example of agent-side services
is an application management service that includes logic to load and unload trading applications,
so it is quite obvious that such logic needs to be executed on the actual machine where the applica-
tions are installed. Services hosted by the primary controller include logging, instrumentation, health
monitoring, and so on, that is executed inside the context of the server. The final piece in Figure 5-17
is the application operator GUI, which is responsible for the visual representation of information
collected from the primary controller. In other words, it is through this GUI application that the
operator or development team will be able to watch and monitor the application’s activity.
.NET Remoting is the mainstream approach for building a centralized application controller. First
you must identify the important components of remoting, which are the server application and
client application, and finally you define a list of classes that needs to be exposed remotely. The first
step is to model both the primary controller and the agent as separate distinct Singleton remotable
classes that will be extended from MarshalByRefObject. Also, both the agent and primary controller
will be physically separated so you require a host application that will register the channel and for-
matting information. Hence, we have adopted TCPChannel as the primary communication channel
between the agent and the primary controller and BinaryFormatter as the data-encoding standard.
The next part of the implementation is to understand how you make the trading application aware
of the existence of a service controller and allow it to use the features provided by the controller.
The primary controller owns complete knowledge of trading applications to be monitored along
with its designated agent. Let’s assume that the mapping information between the agent and appli-
cation is recorded in an XML configuration file. After reading this mapping information, the primary
controller will notify agents with the list of trading applications assigned to it and also instructs them
to start the application. There is an initial handshake conducted between the agent and primary
controller, and during this handshaking phase both the agent and the primary controller create
a unique instance of DomainApp at their ends. DomainApp, also called the domain application, is our own
internal implementation and encapsulates the infrastructure services discussed previously such as
logging, configuration, and so on. To be more precise, an instance of DomainApp created by the primary
controller encapsulates the server-side services, and an instance of DomainApp created by the agent
encapsulates the agent-side services. For each trading application managed by a primary controller,
a unique instance of DomainApp is created on both sides, but the underlying class of this instance itself
is derived from MarshalByRefObject. So if a reference is passed outside its default application domain,
it will be passed as marshaled by reference, and this is what happens during the handshake stage.
Both the agent and primary controller receive proxy references to each other’s instance of DomainApp,
which in turn would allow them to invoke both server-side and agent-side services.
The next part is to launch trading applications, and this functionality is considered to be an agent-
side service, so you will package this logic in the form of an application management service. The
application management service creates a new application domain and executes the application
inside this newly created application domain. Before executing, it assigns a reference of DomainApp
to this newly created application domain using the SetData method of the AppDomain class. The trad-
ing application accesses this DomainApp reference using the GetData method defined in the AppDomain
class and starts using the services provided by the application controller engine.
The only missing part that we will not cover is the GUI portion of the application operation engine.
But once you get a strong understanding of the components implemented in the operation engine,
then it is just a question of invoking the appropriate calls from the GUI. Then, the rest of the job is
performed by the primary controller and the agents.
Class Details
In this section, you will develop a scaled-down version of an application operation engine. Although
it will not support all the operational features, the motive is to prove that remoting is an ideal fit for
building these kinds of monitoring applications. However, keep in mind that because the monitoringC H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 285
applications depend upon the nature of the requirement, in some exceptional cases remoting may
not look like a perfect fit. Before you start with the low-level code details, you need to be acquainted with
the project hierarchy (see Table 5-6).
Table 5-6. Application Operation Engine Assembly Structure
Assembly Type Project Name References Description
Console application AppController Common AppController is the primary
controller, so it contains the code
to connect to agents, to assign
agents a list of trading applications
to monitor, and also to provide
server-side services.
Console application AppAgent Common AppAgent is the agent that executes
the actions issued by the primary
controller.
Shared library Common The shared library contains both
classes and interfaces shared among
the primary controller, agents, and
domain applications.
Console application OrderMatching Common OrderMatching represents a real-life
trading application that will be under
the surveillance of an application
agent.
In this scenario, ideally, all console applications must be ported to a Windows service so that
they can be launched from the Windows startup without any user intervention. But for demonstra-
tion purposes, the console applications will always be our friend. Figure 5-18 shows the application
operation engine class diagram, and Figure 5-19 shows the application operation engine’s project
structure.
Figure 5-18. Application operation engine class diagram286C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
IController
The IController interface is shared between both the agent and the primary controller application.
A controller from a simple definition point of view is an entity that is assigned the task of controlling
or organizing something. So, in both the primary controller and the agent application, you need an
entity that will supervise and coordinate the application’s activity. IController defines a list of mem-
bers and properties that is implemented by the concrete controller class of the primary controller
and agent.
Here’s the code for IController:
using System;
using System.Collections;
namespace Common
{
public interface IController
{
//This method is invoked on the agent by the primary controller.
//It is with the help of this method that the primary controller empowers
//the agent by assigning a list of applications that directly fall
//under the agent's control.
DomainApp CreateApplication(AppInfo appInfo, DomainApp serverApp);
Figure 5-19. Application operation engine project structureC H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 287
//This property determines whether the controller
//is an agent or a primary controller.
bool IsAgent{get;}
//The concept of data bag is not unique. Its existence could be
//drawn from Windows OS that provides similar features in the form
//of environment variables. With the help of environment variables,
//important configuration information are shared among OS processes.
//We are following a similar path by introducing the data bag, but the
//information is shared among services. With the help of this method, the
//primary controller passes the information to the agent that is then
//shared with agent-side services.
void InitializeDataBag(Hashtable dataBag);
}
}
AppInfo
AppInfo is a serializable class that acts as an information holder for the primary controller and its
agents. We discussed the primary controller assigning a list of trading applications to the agent, so
this task is encapsulated inside an instance of the AppInfo class and passed to the agent. It contains
information such as the assembly path, assembly name, and so on, that is finally resolved by the agent.
Here’s the code for AppInfo:
using System;
using System.Collections;
namespace Common
{
[Serializable]
public class AppInfo
{
string appName, assemblyName;
string assemblyPath;
public string AssemblyPath
{
get{return assemblyPath;}
set{assemblyPath=value;}
}
public AppInfo(string name)
{
appName = name;
}
public string Name
{
get{return appName;}
set{appName=value;}
}
public string AssemblyName
{
get{return assemblyName;}288C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
set{assemblyName=value;}
}
}
}
DomainApp
DomainApp is an important class inside the applications operation framework because the various
services such as logging, configuration, application management, and so on, are made accessible
through the instance of this class. DomainApp is derived from the MarshalByRefObject type, and hence
its instance is also remotely accessible.
Here’s the code for DomainApp:
using System;
namespace Common
{
public class DomainApp: MarshalByRefObject
{
AppInfo appInfo;
ILogger logger;
IConfiguration configuration;
Service appMgmt;
//The underlying information about the actual application
//is available with the help of the AppInfo property.
public AppInfo Info
{
get{return appInfo;}
}
public DomainApp(AppInfo info)
{
appInfo = info;
}
//This property allows accessing the functionality provided
//by the Application management service.
public Service AppManagement
{
get{return appMgmt;}
set{appMgmt=value;}
}
//The Logger property encapsulates centralized logging features.
public ILogger Logger
{
get{return logger;}
set{logger =value;}
}
}
}C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 289
IConfiguration
The IConfiguration interface is implemented by the configuration management service. It contains
only one method, GetConfig, which is invoked to get configuration information about the application.
Here’s the code for IConfiguration:
using System;
using System.Xml;
namespace Common
{
public interface IConfiguration
{
XmlElement GetConfig();
}
}
ILogger
The ILogger interface defines the contract that every logging service must implement.
Here’s the code for ILogger:
using System;
namespace Common
{
public interface ILogger
{
void Log(string logMsg);
}
}
Service
Service is the common base class for all operational services and includes both agent-side and server-side
services. This class defines common behaviors that are applied to all services, and it includes
behavior to start and stop services or to suspend and resume services. The methods are marked
virtual, which would allow the concrete service class to override the default behavior to suit its custom
requirement.
Here’s the code for Service:
using System;
namespace Common
{
public abstract class Service : MarshalByRefObject
{
protected IController serviceController;
protected DomainApp domainApp;
//The overloaded constructor accepts two arguments;
//the first argument is an instance of IController, and the
//second argument is an instance of DomainApp. It is important
//to educate the service about the underlying controller (primary controller
//or agent) and domain application inside which it is hosted.//Effectively, by providing this hosting context information,
//we allow the service to directly interact with the controller or
//domain application and allow them to leverage other services
//provided by the domain application; to sum up, we are laying a strong
//foundation to achieve interservice communication.
public Service(IController controller,DomainApp app)
{
serviceController = controller;
domainApp=app;
}
public virtual void Start()
{
}
public virtual void Stop()
{
}
public virtual void Suspend()
{
}
public virtual void Resume()
{
}
}
}
PrimaryController
The first concrete implementation of the controller, PrimaryController is derived from
MarshalByRefObject and also implements the IController interface. This class contains the
most important logic of connecting to agents and loading the server-side services.
Here’s the code for PrimaryController:
using System;
using System.Runtime.Remoting;
using System.Collections;
using Common;
using AppController.Services;
namespace AppController
{
public class PrimaryController: MarshalByRefObject,IController
{
Hashtable agents = new Hashtable();
Hashtable dataBag = new Hashtable();
//The constructor method populates the data bag by
//invoking the InitializeDataBag method. The body of the method
//is empty, but ideally the data bag values will be fetched
//from the XML File or database or some other data source.
public PrimaryController()
{
290C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N EInitializeDataBag(dataBag);
}
public AgentInfo this[string agentName]
{
get{return agents[agentName] as AgentInfo;}
}
public void Start()
{
ConnectAgents();
}
public void InitializeDataBag(Hashtable data)
{
}
//The real handshaking among agents is performed inside this code.
//The list of agents, primarily their locations, is stored in a application
//configuration file as part of remoting section; after reading this
//location values with help of remoting helper method, we enter
//a foreach loop. It is inside this loop a remote instance
//of agent is created on remote server and its reference is stored for
//subsequent access. After successful creation of agent, the next step
//is to assign it the list of applications that are directly under its
//supervision.
public void ConnectAgents()
{
foreach(WellKnownClientTypeEntry clientEntry in
RemotingConfiguration.GetRegisteredWellKnownClientTypes())
{
Console.WriteLine("Connecting to Agent : " +clientEntry.ObjectUrl);
IController agent = Activator.GetObject(typeof(IController),
clientEntry.ObjectUrl) as IController;
agent.InitializeDataBag(dataBag);
AgentInfo agentInfo = new AgentInfo(agent);
agents[clientEntry.ObjectUrl] = agentInfo;
InitializeApplications(agentInfo);
}
}
//In this section of code both primary controller and agent
//creates an instance of domain applications and attach the
//list of services applicable on their end. Again for sake
//of simplicity, we have hardwired the application name,
//the application path, and the assembly name inside the code,
//but the best approach is to separate this information
//in a configuration file and also assign the agent controlling
//these applications. You will also notice a call to
//CreateApplication method happening on both the primary controller
//and agent; this method invocation will ensure that both agent and
//primary controller have performed the necessary required set-up.
//Another important section of code to look is the exchange of remote
//references, particularly an instance of the AppManagement class reference.
//When we invoke CreateApplication method on an instance of agent, we
//also pass a reference to server-side domain application, and on successful
C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 291//execution of this method it returns a reference to agent-side domain
//application, which itself is a remote reference. We know that both
//server-side and agent-side services are derived from the common base class
//Service, so by accessing the AppManagement property of remote instance of
//domain applications, we will be returned with proxy reference.
public void InitializeApplications(AgentInfo agentInfo)
{
AppInfo appInfo = new AppInfo("Order Matching");
appInfo.AssemblyName = "OrderMatching.exe";
appInfo.AssemblyPath = @"C:\CodeExample\Chpt5\SCE\OrderMatching\bin\Debug";
DomainApp omeServer= this.CreateApplication(appInfo,null);
DomainApp omeClient= agentInfo.Agent.CreateApplication(appInfo,omeServer);
omeServer.AppManagement = omeClient.AppManagement;
agentInfo.Applications.Add(omeServer.Info.Name,omeServer);
}
//The required initialization of domain application is performed
//inside this code, what we meant by initialization is configuring
//the services and assigning its reference back to the domain application.
public DomainApp CreateApplication(AppInfo appInfo, DomainApp serverApp)
{
DomainApp newApp = new DomainApp(appInfo);
LogManagement logMgmt = new LogManagement(this,newApp);
return newApp;
}
public bool IsAgent
{
get{return false;}
}
}
}
AgentInfo
The AgentInfo class stores information related to an agent. Besides storing agent remote references,
it also stores the instances of applications that are controlled by an agent.
Here’s the code for AgentInfo:
using System;
using System.Collections;
using Common;
namespace AppController
{
public class AgentInfo
{
IController agent;
Hashtable applications = new Hashtable();
public Hashtable Applications
{
get{return applications;}
}
292C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N Epublic IController Agent
{
get{return agent;}
}
public AgentInfo(IController controller)
{
agent=controller;
}
}
}
LogManagement
The LogManagement service addresses the logging aspect of a trading application and is categorized
under server-side services. The code is pretty straightforward and, depending upon the business
requirement implementation of the Log method, can be tweaked to suit the need of application:
using System;
using Common;
namespace AppController.Services
{
public class LogManagement : Service,ILogger
{
public LogManagement(IController controller,DomainApp app)
:base(controller,app)
{
app.Logger = this;
}
//Logging of Messages
public void Log(string logMsg)
{
Console.WriteLine(logMsg);
}
}
}
Primary Controller Remoting Configuration
This is the primary controller remoting configuration:
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
<system.runtime.remoting>
<application>
<channels>
<channel ref="tcp" port="20000">
<serverProviders>
<formatter ref="binary" typeFilterLevel="Full" />
</serverProviders>
</channel>
</channels>
<client>
<wellknown url="tcp://localhost:20001/TradingEngineAgent.rem"
C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 293type="Common.IController, Common" />
</client>
</application>
</system.runtime.remoting>
</configuration>
Primary Controller Host
The Host class launches the primary controller shell and also invokes the application management
service that is an agent-side service. The primary controller instructs this service to start the appli-
cation, which is equivalent to launching a remote application.
Here’s the code for the primary controller host:
using System;
using Common;
using System.Runtime.Remoting;
namespace AppController
{
class Host
{
static void Main(string[] args)
{
//Start Primary Controller
PrimaryController primaryController = new PrimaryController();
RemotingConfiguration.Configure(@"AppController.exe.config");
RemotingServices.Marshal(primaryController ,
"PrimaryController.ref",typeof(PrimaryController));
primaryController.Start();
Console.WriteLine("Primary Controller Started");
//Access trading agent, and invoke the application management service
Console.WriteLine("Starting App Management Service..");
AgentInfo agentInfo =
primaryController["tcp://localhost:20001/TradingEngineAgent.rem"];
DomainApp omeApp = agentInfo.Applications["Order Matching"] as DomainApp;
omeApp.AppManagement.Start();
Console.ReadLine();
}
}
}
AgentController
This class represents an agent-side controller, so the code of this class is more or less similar to the
server-side controller code. The important section in this class is the CreateApplication method;
inside its method body, a new instance of DomainApp class is created, and also agent-side services are
initialized. Remember, the CreateApplication method is invoked by the primary controller, which also
happens to pass its remote reference of DomainApp, so you assign the proxy reference of server-side
services to an instance of the agent-side DomainApp.
Here’s the code for AppController:
using System;
using System.Collections;
using Common;
using AppAgent.Services;
294C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N Enamespace AppAgent
{
public class AgentController : MarshalByRefObject,IController
{
Hashtable appCollections = new Hashtable();
Hashtable dataBag;
public AgentController ()
{
}
public void InitializeDataBag(Hashtable data)
{
dataBag = data;
}
public DomainApp CreateApplication(AppInfo appInfo, DomainApp serverApp)
{
Console.WriteLine("Creating Application : " +appInfo.Name);
DomainApp newApp = new DomainApp(appInfo);
AppManagement appMgmt = new AppManagement(this,newApp);
newApp.Logger = serverApp.Logger;
appCollections[appInfo.Name] = newApp;
return newApp;
}
public bool IsAgent
{
get{return true;}
}
}
}
AppManagement
AppManagement is an agent-side service that is responsible for launching and stopping the trading
application. It creates a new application domain and a new thread and executes the trading appli-
cation inside this newly created domain. Another interesting thing to note is that a reference to the
agent-side instance of DomainApp is passed using the SetData method of the AppDomain class.
Here’s the code for AppManagement:
using System;
using System.Threading;
using Common;
namespace AppAgent.Services
{
public class AppManagement : Service
{
AppDomain newDomain;
Thread newThread;
public AppManagement(IController controller, DomainApp app)
:base(controller,app)
{
app.AppManagement = this;
C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 295newThread = new Thread(new ThreadStart(LaunchApp));
}
public void LaunchApp()
{
newDomain = AppDomain.CreateDomain(domainApp.Info.Name);
string appFullPath= domainApp.Info.AssemblyPath +"\\"
+domainApp.Info.AssemblyName;
newDomain.SetData("SERVICE_DOMAINAPP",domainApp);
newDomain.ExecuteAssembly(appFullPath);
}
public override void Start()
{
newThread.Start();
}
public override void Stop()
{
}
public override void Resume()
{
}
public override void Suspend()
{
}
}
}
Agent Remoting Configuration
This is the agent remoting configuration:
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
<system.runtime.remoting>
<application>
<service>
<wellknown mode="Singleton" objectUri="TradingEngineAgent.rem"
type="AppAgent.AgentController, AppAgent" />
</service>
<channels>
<channel ref="tcp" port="20001">
<serverProviders>
<formatter ref="binary" typeFilterLevel="Full" />
</serverProviders>
</channel>
</channels>
</application>
</system.runtime.remoting>
</configuration>
296C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N EAgent Host
This is the agent host:
using System;
using System.Runtime.Remoting;
namespace AppAgent
{
class Host
{
static void Main(string[] args)
{
RemotingConfiguration.Configure(@"AppAgent.exe.config");
Console.WriteLine("Service Controller Agent Started...");
Console.ReadLine();
}
}
}
Order-Matching Application
If you peek at the primary controller code, you will see a reference to the order-matching application.
On further digging inside the host code of the primary controller, you will also discover a startup call
to the application management service, and you are already aware of the functionality provided by
this service. The code inside the order-matching application retrieves a reference to an instance of
DomainApp assigned by the application management service, and by using this instance, it invokes
logging service. The actual logging is performed on the server and not on the client as depicted in
the following program output:
using System;
using System.Threading;
using Common;
namespace OrderMatching
{
class Class1
{
static void Main(string[] args)
{
DomainApp serviceApp =
AppDomain.CurrentDomain.GetData("SERVICE_DOMAINAPP") as DomainApp;
serviceApp.Logger.Log("Order Matching Started");
}
}
}
Figure 5-20 shows the console output of the application operation engine.
C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E 297Summary
In this chapter, we explained and implemented the following:
  We achieved fault isolation in managed applications using application domains. We demon-
strated this concept by implementing a central service controller that is responsible for managing
trading operation–related services such as the heartbeat service.
  We explored the remoting communication framework by implementing a distributed version
of the central service controller example.
  We demystified the secrets behind the remoting proxy with the help of a service directory
lookup example.
  We covered the mechanics of distributed garbage collection and demonstrated how the leasing
and sponsorship feature is used in designing remote objects that are subject to garbage
collection only after trading hours.
  We explained the aspect-oriented programming concept that allows the separation of cross-
cutting concerns from the functional modules.
  Finally, we designed and developed a small prototype of an application operation engine
that enables the instrumentation and management of various subcomponents of a system.
298C H A P T E R 5 ■ T H E A P P L I C AT I O N O P E R AT I O N E N G I N E
Figure 5-20. Console output of the application operation engine
