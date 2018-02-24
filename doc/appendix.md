# 附录A .NET Tools
The following are .NET tools you may find useful.
Reflect Assemblies Using .NET Reflector http://www.aisto.com/roeder/dotnet/
.NET Reflector is an extremely valuable tool that allows you to examine various classes and
methods defined in .NET assemblies. The real strength of this tool resides in the automatic decom-
pilation of IL code into C# or VB .NET code.
Export Reverse-Engineered Source Code to a File Using Reflector.FileDisassembler
http://www.denisbauer.com/NETTools/FileDisassembler.aspx
Reflector.FileDisassembler is an add-on extension to .NET Reflector and is used to export the
content of a .NET assembly (binary form) into C# or VB .NET files.
Perform Code Obfuscation Using Dotfuscator http://www.gotdotnet.com/team/dotfuscator/
Code obfuscation is a technique applied to MSIL binaries to make the reverse-engineering task
extremely difficult. .NET assemblies are rich in metadata and contain information that can be easily
deciphered using various kinds of reflection tools, such as ILDASM. .NET Reflector is one of them.
Using these kinds of tools, anyone can reverse engineer the original source code, and to foil this
attempt, a code obfuscation technique is used.
Unit Test Source Code Using NUnit http://sourceforge.net/projects/nunit and http://sourceforge.
net/projects/nunitaddin
NUnit is an open source unit-testing framework that brings Test Driven Development (TDD)
practices to .NET.
Perform .NET Programming Compliance Checks Using FxCop http://www.gotdotnet.com/team/fxcop/
FxCop is a peer review tool for code that analyzes assemblies and checks them for compliance
using a number of rules. By default, it comes with predefined rules that check code for conformance
to the .NET Framework design guidelines.
Automate the Build Process Using NAnt http://sourceforge.net/projects/nant
NAnt is an open source framework tasked with the responsibility of automating the build
process of .NET projects using NAnt scripts defined in XML.
477478A P P E N D I X A ■ . N E T T O O L S
Produce Documentation of Source Code Automatically Using NDoc http://ndoc.sourceforge.net/
NDoc is an open source framework that generates code documentation from .NET assemblies
in MSDN-style Help format (.chm) or VS .NET Help format (HTML Help 2).
Build and Test Regular Expressions Using Regulator http://regex.osherove.com/
The Regulator tool makes creating and testing extremely complex regular expressions a breeze.
Build Networked Applications with Indy.Sockets http://www.indyproject.org/Sockets/index.en.iwp
Indy.Sockets is an open source .NET library that provides an exhaustive collection of various
communication protocols such as TCP, UDP, NNTP, HTTP, POP3, and SMTP.
Use the Centralized Connection Strings Database http://www.connectionstrings.com/
This site provides an excellent resource of database connection strings for all the available
database drivers.
Develop MMC Snap-ins Using MMC.NET Library http://sourceforge.net/projects/mmclibrary/
The MMC.NET Library provides a managed library that enables MMC snap-in–style development.
Understand P/Invoke Signatures Through P/Invoke .NET Wiki http://pinvoke.net
This site provides a repository that contains predefined P/Invoke signatures that can be used in
managed code in a copy-and-paste manner.
Explore Advanced Data Structures Using Power Collections for .NET http://www.wintellect.com/
powercollections/
Power Collections provides high-quality advanced data structures that use .NET 2.0 generic
features and is entirely developed in C#.
Measure the Quality of .NET Assemblies Using NDepend http://smacchia.chez-alice.fr/NDepend.html
The NDepend tool analyzes .NET assemblies and generates design-quality metric reports.
Build Grid Computing in .NET Using Alchemi http://www.alchemi.net/
Alchemi is an open source .NET-based grid computing framework that offers an infrastructure
to collaborate multiple computers on networks in order to execute large-scale computational tasks.
Provide Code Coverage Using CoverageEye.NET http://www.gotdotnet.com/Community/UserSamples/
Details.aspx?SampleGuid=881a36c6-6f45-4485-a94e-060130687151
CoverageEye.NET analyzes an assembly and generates reports about IL instructions that have
been executed. This tool will help discover the code coverage percentage of any .NET assembly.
Solve Complex Scientific Problems Using Math.NET http://www.cdrnet.net/projects/nmath/
default.asp
Math.NET is an open source library used to perform some highly advanced numerical
computations.
Harness the Power of log4Net http://logging.apache.org/log4net/
log4Net is a highly advanced logging and tracing framework that enables you to log/trace state-
ments to a variety of output targets.Profile Applications Using CLR Profiler http://www.microsoft.com/downloads/
details.aspx?FamilyId=86CE6052-D7F4-4AEB-9B7A-94635BEEBDDA&displaylang=en
CLR Profiler is one of the most well-known profiling tools for managed code available from
Microsoft. It includes a number of useful views of the allocation profile, including a histogram of
allocated types, allocation and call graphs, a timeline showing garbage collectors of various genera-
tions and the final state of the managed heap after those collections, and a call tree showing per-method
allocations and assembly loads.
Analyze Network Using Ethereal http://www.ethereal.com/
Ethereal is an open source network troubleshooting and protocol analyzer tool. It provides
a detailed analysis of low-level network protocols and several other features that are not available in
any other product.
Perform TCP Tunneling Using TCPTrace http://www.pocketsoap.com/tcptrace/
The TCPTrace tool is useful to debug socket/.NET remoting applications.
Source Code Metrics Using SourceMonitor http://www.campwoodsw.com/index.html
This tool measures source code metrics in terms of the number of classes, methods, and total
lines of code.
Explore the Enterprise Library for .NET Framework 1.1 http://msdn.microsoft.com/practices/
default.aspx?pull=/library/en-us/dnpag2/html/entlib.asp
The Enterprise Library contains application blocks such as a caching block, a configuration
block, a data access block, an exception management block, a cryptography block, and a security
block that are designed to solve basic development problems.
Use Windows System Utilities http://www.sysinternals.com
This site provides advanced low-level Windows utilities that are extremely helpful in diagnosing
performance-sensitive applications.
Build a Business Rule Engine http://sourceforge.net/projects/nxbre/
This is an open source framework for the .NET platform to build an XML-driven rule engine.
Use Advance .NET Assembly Instrumentation with the Runtime Assembly Instrumentation Library (RAIL)
http://rail.dei.uc.pt/
This framework provides a low-level hook that allows .NET assemblies to be manipulated and
instrumented before they are loaded and executed.
Use Spring.NET http://www.springframework.net
Spring.NET provides a framework to incorporate a dependency injection pattern in managed
applications.
Perform Advanced Debugging with Windows Debugger (WinDbg) http://www.microsoft.com/whdc/
devtools/debugging/installx86.mspx
WinDbg is the official Windows debugging tool that supports both user-mode and kernel-mode
debugging. It is a must-have tool for developers architecting server-side applications in order to
analyze low-level performance and hard-to-produce problems.
A P P E N D I X A ■ . N E T T O O L S 479Debug CLR Internals Using Son of Strike (SOS) http://www.microsoft.com/whdc/devtools/debugging/
default.mspx
Bundled with the Windows Debugger Package, SOS is a WinDbg extension that provides low-level
information about the CLR internal data structures and is extremely handy to detect problems related
to memory and thread deadlock issues. This tool is a must-have for managed developers designing
mission-critical applications.
Use .NET on Linux: Mono http://www.mono-project.com
Mono is an open source initiative that provides a complete end-to-end framework to run .NET
applications on the Linux and Solaris platforms.
480

# APPENDIX B References
The following are some useful references:
  MSDN (http://msdn.microsoft.com)
  MSDN Magazine (http://msdn.microsoft.com/msdnmag)
  MSDN Web Services and Other Distributed Technologies Developer Center
(http://msdn.microsoft.com/webservices)
  Microsoft Patterns & Practices (http://msdn.microsoft.com/practices)
  O’Reilly Network (http://www.oreillynet.com)
  Applied Microsoft .NET Framework Programming by Jeffrey Richter (0735614229; Microsoft
Press, 2002)
  Microsoft Windows Internals, Fourth Edition by Mark E. Russinovich and David A. Solomon
(0735619174; Microsoft Press, 2004)
  Professional XML by Mark Birbeck, Michael Kay, Steven Livingstone, Stephen F. Mohr,
Jonathan Pinnock, Brian Loesgen, Steven Livingston, Didier Martin, Nikola Ozu, Mark
Seabourne, and David Baliles (1861003110; Wrox, 2000)
  .NET and XML by Niel M. Bornstein (0596003978; O’Reilly, 2003)
  Pro .NET 1.1 Network Programming by Christian Nagel, Ajit Mungale, Vinod Kumar,
Nauman Laghari, Andrew Krowczyk, Tim Parker, Srinivasa Sivakumar, and Alexandru Serban
(1590593456; Apress, 2004)
  TCP/IP by Sidnie Feit (0070220697; McGraw-Hill, 1998)
  Pattern-Oriented Software Architecture by Douglas Schmidt, Michael Stal, Hans Rohnert,
and Frank Buschmann (0471606952; John Wiley & Sons, 2000)
  C++ Network Programming, Volume 1 by Douglas C. Schmidt and Stephen D. Huston
(0201604647; Addison-Wesley, 2010)
  TCP/IP Sockets in C# by David Makofske, Michael J. Donahoo, and Kenneth L. Calvert
(0124660517; Morgan Kaufmann, 2004)
  Advanced .NET Remoting by Ingo Rammer (1590590252; Apress, 2002)
  AspectJ in Action by Ramnivas Laddad (1930110936; Manning, 2003)
481482A P P E N D I X B ■ R E F E R E N C E S
  .NET Security and Cryptography by Peter Thorsteinson and G. Gnana Arun Ganesh
(013100851X; Prentice Hall, 2003)
  .NET Security by Jason Bock, Tom Fischer, Nathan Smith, and Pete Stromquist (1590590538;
Apress, 2002)
  Expert Service-Oriented Architecture in C# by Jeffrey Hasan (1590593901; Apress, 2004)
  Service-Oriented Architecture by Thomas Erl (0131858580; Prentice Hall, 2005)
  Code Generation in Action by Jack Herrington (1930110979; Manning, 2003)
  Code Generation in Microsoft .NET by Kathleen Dollard (1590591372; Apress, 2004)
  Essential .NET, Volume 1 by Don Box (0201734117; Addison Wesley, 2002)
  Distributed Systems by George Coulouris, Jean Dollimore, and Tim Kindberg (0321263545;
Addison Wesley, 2005)
  Security Engineering by Ross J. Anderson (0471389226; Wiley, 2001)
  Web Service Platform Architecture by Sanjiva Weerawarana, Francisco Curbera,
Frank Leymann, Tony Storey, and Donald F. Ferguson (0131488740; Prentice Hall, 2005)■


# Index

## Numbers
255.255.255.255 broadcast address,
significance of, 210
32-bit IP address, explanation of, 180

## Symbols
80-20 rule
applying to clean reference data, 114
applying to market capitalization, 13
abstract model, basing code on, 422
■A
abstract part of WSDL
explanation of, 354
representing, 356
abstraction, availability in SOA, 352
Accept, calling for market data producer
with TCP, 193
account activity statement, explanation
of, 22
accounts, availability from depositories, 16
activation mode, defining in RPC, 258
Activator class, creating instance of remote
object with, 260
active (pre-insert) order, explanation of, 88
Add method
overriding for collections and
multithreading, 78
using with Hashtable class, 57
addresses in IP header, explanations of, 182
addressing specification. See WS-Addressing
specification
ADO.NET DataSet, significance of, 423
Advanced Micro Devices
buying for arbitrage, 414
price differential for, 411
advice in AOP, explanation of, 279
affirmation and confirmation of trades,
processes of, 23–24
agent host code sample for trading
application, 297
agent remoting configuration code sample
for trading application, 296
agent-side services, relationship to
application operation engine, 284
AgentController class, using with application
operation engine, 294
AgentInfo class, implementing for
application operation engine,
292–293
Alchemi framework, description of, 478
algorithm efficiency, measuring via Big-O
novation, 48
algorithms
applying to collections of data elements,
48
determining efficiency of, 48
of thread pools, 59
relationship to data storage, 85
relationship to data structures, 48
allocation details, explanation of, 23
allocation process, relationship to STP, 304
AMD (Advanced Micro Devices) arbitrage
example, 403
AMD example, 405
AMEX (American Stock Exchange),
significance of, 8
analysis, role of market data in, 173
annualized percentage returns, calculating
for arbitrage, 412
anonymous methods, reducing amounts of
code with, 457, 459
AOP (aspect-oriented programming),
overview of, 275–276, 282
AopAlliance assembly, referencing, 279
APIs, invoking in UDDI, 371
AppDomain class, using with heartbeat
service, 247
AppDomain type, properties and events of,
253
AppDomainSetup class
storing binding information in, 252
using with shadow copying, 253
AppInfo class, using in application operation
engine, 287
AppInfo interface, using in application
operation engine, 288
application configuration details, defining,
250
application design, factors involved in, 36
Index
483application layer of TCP/IP, explanation of,
179
application management operational
component, description of, 237
application operation engine. See also
trading applications
assembly structure for, 285
class details for, 284, 290
class diagram for, 285
framework of, 283
implementing AgentInfo class for, 292–293
implementing LogManagement service
for, 293
implementing PrimaryController for, 290,
292
project structure of, 285
using AgentController class with, 294
application operator GUI, role in application
operation engine, 284
application processes, communication
between, 258
application-monitoring engine, significance
of, 39
ApplicationName property, using with
shadow copying, 253
applications
efficiency of, 35
measuring responsiveness of, 35
programmatic perspective of, 36
AppManagement agent-side service,
stopping and starting trading
application with, 295
AppSettings property, exposing with
ConfigurationSettings class, 251
arbitrage. See also equity arbitrage engine
definition of, 403
explanation of, 5
forms of, 405–406
overview of, 403–404
profitability of, 405, 412
pure arbitrage, 406
risks associated in, 407
speculative arbitrage, 407
arbitrage cost risk in arbitraged, explanation
of, 407
arbitrage margin, explanation of, 409
arbitrage model, building arbitrage engine
with, 443
arbitrage opportunities, examples of, 413
arbitrage system versus program trading
system, 408
arbitrage transactions, costs involved in,
404–405
arbitrageurs, reasons for success of, 404
architects, types of, 34
array of bytes, converting contract note
message into, 316
array lists
overcoming fixed-size problems with, 50
role in .NET collections, 49, 51
array size, problem associated with, 49
Array.BinarySearch static method, calling, 52
ArrayList
driving sort and search behaviors in, 87
properties of, 78–79
arrays
locating items in, 52
redimensioning, 49–50
role in .NET collections, 48–49
type coupleness behavior associated with,
50
using parametric polymorphism with, 447
using quick sort algorithm with, 51
using with market data producer, 187
ascending order, sorting orders in, 53–54
.asmx extension, using with Web services,
362
aspect in AOP, explanation of, 279
Aspect# assemblies
downloading, 278
referencing, 279
AspectEngine, injecting rules dynamically
with, 282
AspectLanguageEngineBuilder, injecting
rules dynamically with, 282
AspectSharp assembly, referencing, 279
assemblies. See also shared assembly for
remoting and generics code sample
definition of, 417
in-memory generation of, 433
assembly structure for sample RPC, 254
AssemblyCustomAttributes attribute, using
with CodeDOM, 429
asymmetric encryption
ridexamples of, 318
implementing for STP and Web services,
392–393
versus symmetric encryption, 322
asymmetric keys, using in STP-space
security, 317, 322
AsymmetricAlgorithm base abstract class,
explanation of, 318
AsyncCallback delegate, using in
asynchronous callback notification,
63
asynchronous delegate infrastructure,
relationship to multithreading,
60, 63
asynchronous market data producers and
consumers, overview of, 196, 200
AsyncWaitHandle property of IAsyncResult,
using with delegates, 62
atomic operation, relationship to
multithreading, 73
484■I N D E Xattributes
descriptions of, 134
support for, 132
authentication information, representing in
WS-Security, 384
authentication of data, explanation of, 307
Authorization advice, injecting in AOP, 281
Authorization aspect, defining in AOP,
280–281
AuthorizationAdvice class, constructing in
AOP, 279
automatic code generation, using partial
types for, 461
automatic deserialization, remoting support
for, 275
AutoResetEvent class, role in interthread
notification, 70
■B
back office
relationship to STP, 28
role of market data in, 175
routing trades to, 109
back-office applications, using IPC channel
with, 471
back-office systems
characteristics of, 30
design of, 30
Band class, using in data conversion
framework, 153–154
BandParser class, using in data conversion
framework, 158–159
bands in data conversion framework,
explanation of, 146
banks
versus depositories, 15
two roles of, 15
base types, forming for generic types, 451
basis risk in arbitrage, explanation of, 407
BCastPipe class, using with broadcast
engine, 229–230
BCL (base class library), significance of, 38
bearish trader, definition of, 4
BeginAccept, calling for market data
producer with TCP, 197
BeginInvoke method, using with delegates,
60–61
BeginInvoke thread-safe member, exposing
in Windows control collection, 82
BeginSend method, sending data
asynchronously with, 197–198
beneficiary accounts, availability from
depositories, 16
Berkshire Hathaway arbitrage example,
405
Berkshire Hathaway example, 407
bid price, relationship to two-way quote, 4
Big-O notation, representing algorithm
efficiency in, 48
binary formatter
description of, 258
serializing object graphs with, 202
binary search algorithm
availability of, 87
locating array items with, 52, 54
binary serializer, explanation of, 132
BinaryClientFormatter class, using in hosting
service controller, 260
BinaryFormatter, using as data-encoding
standard, 284
BinaryReader and BinaryWriter specialized
Stream classes, overview of, 120–121
BinaryServerFormatterSinkProvider class,
description of, 258
Bind method
using with market data consumer, 189
using with market data producer and TCP,
193
binding information, storing in
AppDomainSetup class, 252
<binding> element, using with WSDL
documents, 357
bits, role in networking, 179
BizDomain class of order-matching engine,
overview of, 100–101
block cipher, definition of, 309
BlockSize property, using with symmetric
classes, 315
bonds, definition of, 1
bookkeeping, performing with order
processor, 86
Boolean value, returning for
IsTransparentProxy static method,
261
BooleanCursor class, using in data
conversion framework, 156–157
boxing and unboxing operations,
considering for containers, 449
boxing process, relationship to array lists, 50
broadcast
relationship to networking, 209–210
unsolicited broadcast, 210, 213
broadcast engine
primary role of, 220
significance of, 39
broadcast engine class details
BCastPipe, 229–230
DataSerializerModule, 230–231
Dispatcher, 226
Host, 233
IBCastMessage, 222–224
IMessageStore, 224
IModule, 228
InMemoryStore, 224–225
■I N D E X 485
F
ndi
ti
asterf
a
t
utp:/shperinde
.aprx
s.com/eMktDataMessage, 231, 233
PipeContext, 228–229
RoundRobinDispatcher, 226–227
StoreCollection, 225–226
TransportModule, 231
broadcast engines, building, 221–222
broadcast event, launching with dispatcher,
222
broadcast message, receiving, 212
broadcast pipe component of broadcast
engine, description of, 222
broadcasts
relationship to market data, 172
solicited broadcasts, 213, 216
BrokerCertificate.cer, launching digital
certificate with, 329
brokers. See also stock-exchange members
definition of, 7
floor brokers, 8, 10
interactions with fund managers, 320
interactions with custodians, 305
role in order matching, 42–43
specialists, 10–11
brute-force attack, explanation of, 309
buckets, assigning for orders, 43
BufferedStream subclass of Stream class,
description of, 118
buffers, using with Socket, 219
bulk order upload forms, implementing
parallelism in, 81
BulkOrderUpload, executing, 82
bullish trader, definition of, 4
business components
abstract view of, 235
examples of, 236
versus operational components,
236–237
relationship to trading operational
requirement, 235
business concerns, separating with SOA, 351
business domain, explanation of, 85
business infoset
overview of, 106–107
reference data elements in, 107
business logic layer, uniformity of data at,
144
business requirements, significance of, 238
business rule engine, resource for building
of, 479
business-processing unit, role in Web-service
platforms, 360
business-technology mapping
BizDomain snippet for, 100
class details for, 284, 290
class details of, 88
Container snippet for, 92–93
ContainerCollection snippet for, 93–94
EquityMatchingLogic snippet for, 101–102
EquityOrder snippet for, 91
examining, 143, 148
for STP security, 331, 333
for Web services, 400
LeafContainer snippet for, 94, 96
of equity arbitrage, 442, 444
OMEHost snippet for, 102–103
Order snippet for, 89, 91
OrderBook snippet for, 96, 98
OrderEventArgs snippet for, 98
OrderProcessor snippet for, 99–100
overview of, 84, 88, 220, 222, 283–284
PriceTimePriority snippet for, 91–92
Buy and Sell, specifying nodes for, 87
buy or sell attribute of orders, explanation of,
89
buy orders
processing, 21
sorting in order matching, 42
bytes, extracting for market data consumer,
190
bytes array, converting contract note
information into, 321
■C
C/C++
bright and dark side of, 31
using with front-office systems, 30
CachePath property, using with shadow
copying, 253
callback method, execution of, 84
callback notification approach, using with
asynchronous operations, 62
CAOs (client-activated objects)
versus local objects, 243
role in .NET Remoting, 242
capital markets
definition of, 1
I’s (Intelligence) of performance in, 35, 38
proprietary class libraries provided for, 70
CAs (certificate authorities), issuing digital
certificates with, 327–328
CBC (Cipher Block Chaining) mode, using
with symmetric keys, 311
CellsAttribute abstract class, using in data
conversion framework, 152–153
central order book, example of, 86
centralized application controllers, building,
284
certificate store
installing certificate published by broker
in, 331
relationship to WS-Security, 385
certificates. See digital certificates
CFM (Cipher Feedback Mode), using with
symmetric keys, 311–312
486■I N D E Xchannel configuration, setting up in hosting
service controller, 260
channel information, separating remote
object registration from, 271
channel layer, relationship to proxy in .NET
Remoting, 242
<channel> element of remoting
configuration, explanation of, 271
channels in RPC, listening supported by, 259
cipher modes
behaviors of, 312
and Padding, 315
cipher text, producing, 308
ciphers, types of, 308–309
Class A stock and Class B stock of Berkshire
Hathaway, prices of, 405
Class A-C network addresses, explanations
of, 181
class details for application operation engine
AppInfo, 287–288
DomainApp, 288–289
IConfiguration, 289
IController, 286–287
ILogger, 289
overview of, 285
Service, 289–290
class details for STP security
ConfidentialAttribute class, 334
ContractNoteInfo class, 336
DataSecurity class, 342–343
DataSecurityManager class, 341–342
IntegrityAttribute class, 334
NonRepudiationAttribute class, 335
NonRepudiationProvider class, 340–341
NonRepudiationSection class, 339
ProfileInfo class, 336–337
Provider class, 339–340
SecrityProfileAttribute class, 336
SectionData class, 338–339
SecureEnvelope class, 337–338
class diagrams, of application operation
engine, 285
class generic type constraint, overview of,
452
class names, changing for Web services, 363
class search example using reflection,
435–436
classes, relationship to objects, 238
cleansing stage of information based on
external data sources, overview of,
143
clearing accounts, opening, 15
clearing and settlement, processes of, 24, 28
clearing banks, explanation of, 15, 26
clearing corporations, overview of, 14–15
CLI (Common Language Infrastructure),
significance of, 32
client configuration details, separating from
server in remoting, 273
<client> element of remoting configuration,
explanation of, 271
CLR (common language runtime)
explanation of, 32
role in remoting framework, 241
CLR Profiler tool, features of, 479
CLR thread-pool implementation, offloading
processing tasks with, 457–458
CLR types and an XML documents, using
XmlSerializer class with, 133
clubbing orders, explanation of, 7
Coca-Cola Company
arbitrage on, 412
price differential for, 411
COD (context-oriented data), relationship to
XML, 116
code, basing on abstract model, 422
code access security, significance of, code
documentation generators, features
of, 417, 420–422
code editor view, using with STP and Web
services, 362
code expressions, declaring in CodeDOM,
430–431
code generation
overview of, 415–416
with Reflection.Emit, 439, 442
code generation and reflection, overview of,
417–418
code generators, types of, 416–417
code inflator generators, features of, 417, 422
code splits, advantages of, 460
code synchronization, relationship to
manual thread management, 63, 65
code tags, boosting productivity with, 422
code templates, role in code generation, 416
code wizard generators, features of, 416, 420
code-generation process, triggering in
CodeDOM, 427–428
code-reentrancy problem, occurrence with
callback methods, 84
CodeCompileUnit instance, constructing
with CodeDOM of, 429
CodeDOM
declaring code expressions in, 430–431
overview of, 424, 433
CodeDOM classes, leveraging, 429
CodeDOM object graph
converting to text, 433
translating into compiled form, 433
CodeDOM providers, purpose of, 432
CodeMemberMethod, declaring Compare
method with, 430
CodeNameSpace, defining with CodeDOM,
429
■I N D E X 487
F
ndi
ti
asterf
a
t
utp:/shperinde
.aprx
s.com/eCodeStatement, classes derived from,
431–432
CodeStatementsCollections, returning in
CodeDOM, 431
CodeTypeDeclaration, defining SortCode
class with, 430
collections. See generic collections; .NET
collections
Column class, using in data conversion
framework, 155
ColumnParser class, using in data conversion
framework, 160–161
columns in data conversion framework,
explanation of, 147
COM (Component Object Model)
technology, introduction of, 31
communication handshaking, occurrence of,
260
communication services, providing with
middleware, 240
Compare method
adding parameter declaration for, 430
declaring with CodeMemberMethod, 430
CompileAssemblyFromDom, compiling
CodeDOM object graph with, 433
compiler-driven feature example of, 447
CompilerResults, using with CodeDOM
object graph, 433
complex type, example of, 141
complex type elements, nesting under
xs:schema element, 138
compressing in-memory data, 467–468
computed data element of business infoset,
overview of, 108
ComputeHash, invoking, 324
concrete part of WSDL, representing, 356
concurrency. See multithreading
ConfidentialAttribute class, using in STP
security, 334
confidentiality
of data, 307
in STP space, 308, 322
configuration file
composition of, 250
location of, 250
configuration framework, overview of,
250–251
configuration operational component,
description of, 237
configuration path, assigning to
ConfigurationFile property of
AppDomainSetup class, 252
ConfigurationFile property of
AppDomainSetup class, assigning
configuration path to, 252
ConfigurationSettings class, exposing
AppSettings property with, 251
Configure method of RemotingConfiguration
class, booting remoting
infrastructure with, 271
confirmation and affirmation of trades,
processes of, 23–24
constraints, using with generic code, 452
constraints and rules, associating with Web
services, 396
constructor method
updating LogicalProcess class with, 251
using with infrastructure services, 265
consumers, binding to Web services at
runtime, 371
Container class of order-matching engine,
overview of, 92
ContainerCollection class of order-matching
engine, overview of, 93
containers, tweaking storage
implementation for, 449
context switching, relationship to thread
scheduling, 74
contexts, relationship to objects, 239
contract note, explanation of, 22
contract note data
hash value computed for, 323–324
signing and verification of, 325–326
signing and verification with digital
certificates, 329–330
contract note functionality, enabling with
PostTradeService, 364
contract note information
converting into bytes array, 321
encrypting, 315
encrypting with STP-Provider A public
key, 392–393
exchanging with asymmetric algorithm,
318
securing, 386, 389
contract note message, converting into array
of bytes, 316
contract notes
digital signing of, 387, 389
encrypting and decrypting, 313–314
sending, 305
ContractNoteInfo class, using in STP security,
336
ContractNoteInfo type, representing in XSD
form, 367
conversion rule, producing XML output with,
167–168
conversion stage of information based on
external data sources, overview of,
143
Convert method, using in data conversion
example, 166
converter, role in data conversion
framework, 147
488■I N D E Xcore lookup service class, using with service
directory, 263–264
corporate stocks versus indexes, 12
correlation in prices, relationship to
arbitrage, 406
cost savings, realizing with STP, 301
costs of arbitrage transactions, 404–405
Count property, using with stacks, 56
counting semaphores, using with shared
resources, 462–463
CoverageEye.NET tool, features of, 478
Create method
using with NonRepudiationProvider class,
341
using with Provider class, 340
CreateApplication method, using with
AgentController class, 294
CreateDecryptor method, decrypting
contract notes with, 315
CreateEncryptor method, encrypting
contract notes with, 315
CreateInstanceAndUnwrap method, using
with heartbeat service, 247
credit checks, performance by clearing
corporations, 14
critical section, relationship to code
synchronization, 64
cryptography, definition of, 308
CryptoServiceProvider suffix, significance of,
312
CryptoStream, creating instance of, 316
CryptoStream subclass of Stream class,
description of, 118
CspParameters, contents of, 321
CSV conversion rule, using with data
conversion framework, 148, 151
CSV versus XML, 116
current time, checking for sponsors, 270
custodian, role in trading, 23–24
custodian service provider, relationship to
STP, 299
custodians
characteristics of, 305
interactions with brokers, 305
submissions of instruction initiated by,
306
custom sink layer, relationship to proxy in
.NET Remoting, 242
■D
data
authentication of, 307
confidentiality of, 307
defining security type for, 333
integrity of, 307, 322, 324
nonrepudiation of, 307
plotting in matrix, 145
reading and writing, 117, 119
receiving on separate thread, 200
data arrangement uniformity, relationship to
XML, 116
data cleansing, explanation of, 112
data compression, overview of, 467–468
data containers, design of, 84–85
data conversion
definition of, 105
definitions of, 111
example of, 166–167
data conversion example, XML output for,
167
data conversion framework
architecting, 143
Band class in, 153–154
BandParser class in, 158–159
bands in, 145–146
BooleanCursor class in, 156–157
CellsAttribute abstract class in, 152–153
Column class in, 155
ColumnParser class in, 160–161
columns in, 147
CSV conversion rule in, 148, 152
DataConverter class in, 162, 166
goals of, 144
IWriter class in, 161
Matrix class in, 155–156
Parser class in, 157–158
relationship to reference data, 111, 114
Row class in, 154
RowParser class in, 159
rows in, 146
rule schema in, 149
XmlDataWriter class in, 161–162
data elements, costs associated with location
of, 51
data elements of business infoset
computed data, 108
derived data, 107
reference data, 107–108, 115
relationship to order attributes, 106–107
static data, 108
variable data, 107
data in silos, issues related to, 112
data length in IP, significance of, 182
data management, overview of, 105–106
data management operational component,
description of, 237
data security, importance of, 39
data security versus code access security, 32
data store, explanation of, 117
data structures
relationship to algorithms, 48
relationship to order matching, 85
data type, defining for Web-service messages,
356
■I N D E X 489
F
ndi
ti
asterf
a
t
utp:/shperinde
.aprx
s.com/edata uniformity at business logic layer,
significance of, 144
data-quake, definition of, 37
data-quakes, relationship to broadcast
engines, 220
database connection string resource, 478
DataConverter class, using in data
conversion framework, 162, 166
datagrams, role in networking, 179
DataSecurity class, using in STP security,
342–343
DataSecurityManager class, using in STP
security, 341–342
DataSerializerModule class, using with
broadcast engine, 230–231
DataSet, internal structure of, 423
DataSet writer, role in data conversion
framework, 148
dates, pay-in and pay-out dates, 26
dce element, representing with Matrix class,
155
DCOM, relationship to .NET Remoting, 240
deadlock prevention, relationship to
multithreading, 65, 68
dealers versus investors and traders, 3
debit instructions, providing for depositories,
17
debugging, managing in remoting, 275
decompressing in-memory data, 467–468
Decrypt, using with asymmetric keys, 322
decryption of contract notes, 315
decryption process, explanation of, 308
DeflateStream class in
System.IO.Compression namespace,
definition of, 467
delegate execution, arranging on UI threads,
82
delegate keyword, using with anonymous
methods, 458
delegates, relationship to multithreading,
60
delegates, overview of, 456
delimited file format, example and
description of, 144
demutualization of exchanges, explanation
of, 8
depositories
overview of, 15, 17
risks eliminated by, 17
Dequeue methods, using with queues, 55
derived data element of business infoset,
overview of, 107
DES (Data Encryption Standard) symmetric
algorithm
key size of, 313
significance of, 310
descending order, sorting orders in, 53–54
deserialization
definition of, 131
example of, 135–136
in message framing, 207
process of, 202
remoting support for, 275
destination address in IP header, significance
of, 182
destination unreachable ICMP message,
description of, 183
development team, relationship to
operations team, 283
diagrams. See figures
digital certificates
generating, 328
inclusion in WS-Security, 385
role in STP-space security, 327, 331
verifying with WSE, 387
digital signatures
inclusion in WS-Security, 384
role in STP-space security, 324, 327
verifying, 326
verifying hash values with, 327
Dispatcher class, using with broadcast
engine, 226
dispatcher component of broadcast engine,
description of, 222
distributed garbage collection, overview of,
267, 270
distributed systems, relationship to
networking, 177
dividend, definition of, 2
DJIA (Dow Jones Industrial Average) index,
description of, 12
DLL locking problem, occurrence of, 252
DNS (Domain Name System), relationship to
TCP/IP, 183
document root elements, nesting under
xs:chema element, 139
documentation generators, features of, 421
domain intelligence, overview of, 37
domain knowledge, relationship to XML, 116
DomainApp class
description of, 284
using in application operation engine, 288
DomainApp interface, using in application
operation engine, 289
Dotfuscator tool, features of, 477
DTC (depository trust corporation),
significance of, 15
■E
EAI (enterprise application integration),
relationship to XML, 115
EASDAQ (European Association of Securities
Dealers Automated Quotation),
significance of, 8
490■I N D E XECB (Electronic Code Book) mode, using
with symmetric keys, 310
echo reply and request ICMP messages,
descriptions of, 183
Encoding
converting contract note information
with, 321
in System.Text namespace for market data
producer, 188
Encrypt, using with information in byte
array, 321
encryption
implementing asymmetric encryption for
STP and Web services, 392–393
of contract notes, 315
of keys, 321
encryption element, inclusion in WS-
Security, 384
encryption phase, initiating for symmetric
classes, 315
encryption process, explanation of, 308
EndInvoke method, using with delegates, 60,
62
EndPoint
defining for market data producer with
TCP, 193
resolving in market data producer, 188
EndSend, invoking to complete
asynchronous send operation,
198
Enqueue method, using with queues, 55
enrichment stage of information based on
external data sources, overview of,
144
Enterprise Library, description of, 479
entities for STP in equities trade, 302
enumeration of orders, problem associated
with, 79
envelope, object-oriented form of, 338
equilibrium position and price, explanations
of, 11
equities market, .NET in, 30, 34
equities market entities
banks, 15
clearing corporations, 14–15
depositories, 15, 17
indexes, 12–13
stock exchanges, 6, 8
equities trade, STP in, 302
equity and equity shares, overview of, 2
equity arbitrage, business-technology
mapping of, 442, 444
equity arbitrage engine, building, 407–408,
414. See also arbitrage
EquityMatchingLogic class of order-
matching engine, overview of,
101–102
EquityOrder class of order-matching engine,
overview of, 91
error handling, managing in remoting,
274–275
Ethereal tool, features of, 479
event, definition of, 83
<exception> XML tag for documentation
comments, description of, 421
exceptions, support in remoting, 274–275
Exchange element, XML Schema of, 140
Exchange information, generating, 130
exchange interactions, synchronizing with
Mutex, 71–72
exchange keys, using with digital certificate,
331
exchanges. See stock exchanges
ExchangesModel complex type, example of,
140
ExportParameters method
using with keys, 320
external STP
using with digital certificates, 331
■F
factory classes, using with symmetric classes,
314
fast-forward parsers, overview of, 122–123
fault isolation, achieving with CLR and
Win32 process, 241
field layout, rearranging with runtime, 204
field marshaling behavior, changing, 204
FIFO (first-in, first-out) data structures,
queues as, 54
FIFO manner, processing orders in, 55
Figures
Add Web Reference dialog box, 368
affirmation and confirmation process, 23
allocation and contract note, 305
AOP architecture, 279
application design versus time, 35
application operation engine, 283
arbitrage engine, 442
arbitrage engine based on arbitrage
models, 443
array lists used in linear arrangement of
heterogeneous order, 49
arrays used in linear arrangement of
homogeneous order, 48
asymmetric algorithm class hierarchy, 318
asymmetric key, 317
BCastServer console output, 234
bridging networks with routers, 180
broadcast engine class diagram, 223
broadcast engine implementation
overview, 222
broadcast engine project structure, 223
brokers help investors, 9
■I N D E X 491
F
ndi
ti
asterf
a
t
utp:/shperinde
.aprx
s.com/ebulk order upload form, 82
business component, 236
buy orders of retail clients, 21
byte ordering, 201
CBC (Cipher Block Chaining) mode, 311
central order book, 87
centralization of operational services, 238
certificate store, 386
CFM (Cipher Feedback Mode), 311
changing Web service class name and
filename, 364
cipher mode, 309
class search program using reflection, 436
cleansing reference data, 113
clearing process, 25
code editor view showing autogenerated
Web service code, 363
code generator components, 416
CodeDOM, 434
CodeDOM processes abstract code, 424
COM days, 31
communication with entities on one
network, 348
communication protocol, 349
console application demonstrates
invocation of STP-Provider A Web
service, 370
console output describing field
information embedded in digital
certificates, 331
console output of AOP-enabled heartbeat
service, 282
console output of hash algorithm
program, 324
console output of program using
asymmetric key, 322
console output of program using
symmetric key, 317
console output of service controller and
heartbeat service, 260–261
console output of service directory, 267
conversion framework, 147
data conversion framework class diagram,
151
data conversion framework project
structure, 151
Data Form Wizard, 420
data hashing, 323
digital certificate, 329
digital signature, 325
front, middle, and back offices, 29
HashAlgorithm class hierarchy, 323
information originating from multiple
sources in different formats, 106
instrument mapping in front office, 110
integrating operational and functional
requirements, 278
intelligence levels, 36
life cycle of a trade, 18
market data, 173
market data producers and consumers,
221
MCastClient console output, 216
MCastServer console output, 216
MDC (Async-TCP) console output, 200
MDC (UDP) console output, 190
MDP (Async-TCP) console output, 200
MDP (market data producer) and MDC
(market data consumer), 186
MDP (TCP) console output, 195
MDP (UDP) console output, 190
.NET days, 31
.NET Framework and solutions for
financial world, 38
network byte order console output, 202
object facets, 239
order management system components in
service-oriented design, 351
order processed in FIFO manner, 54
order processed in LIFO manner, 56
order submission and notice of execution,
304
order-matching engine, 86
order-matching engine class diagram, 88
order-matching engine VS.NET project
structure, 89
parsing console output for message
framing, 209
PING output, 183
pre-.NET days, 31
Provider registration page, 374
Providers tab for registering STP providers,
373
record represented as matrix, 145
reference data is central to all functions,
108
reflection used in path traversal, 435
remote proxies receiving remote calls, 261
remoting framework, 240
remoting object facets, 243
requirement distillation, 238
rule-based arbitrage engine, 444
securities clearing account, 27
security framework and class hierarchy,
333
security framework project structure, 334
sell orders are validated, 21
service consumer project created with
Visual Studio .NET, 367
service controller and heartbeat service,
244
service directory, 263
Service registration page with information
about PostTradeService, 377
492■I N D E Xsettlement comprises pay-in and pay-out, 28
SOAP envelope, 358
solicited broadcast, 213
Solution Explorer shows autogenerated
proxy class, 369
Solution Explorer view of consumer
application, 387
specialists provide quotes on request, 10
STP (straight through processing), 29
STP framework (post-trade), 306
STP participants, 302
STP Provider project structure, 362
STP security conceptual design, 332
STP space, 307
STP-Provider A Web service endpoint
information is retrieved, 379
STP-Provider B invokes STP-Provider
A Web service, 361
substitution cipher, 308
symmetric algorithm class hierarchy, 312
symmetric key, 310
TCP/IP layers, 179
thread scheduling, 74
trade confirmation, 111
trade with and without novation, 47
trades happen due to differences in
opinion, 4
transparent and real proxies, 261
transposition cipher, 309
two-way quote comprising bid price and
offer price, 4
UDDI repository finds STP-Provider A Web
service, 371
UDDI test Web site offered by Microsoft,
372
UI thread, 81
unicast communication model, 210
unsolicited broadcast, 211
UnsolicitedBCastClient console output,
213
UnsolicitedBCastServer console output,
213
Web service registration, 376
Web service stack, 380
Web services, 353
Web-service platform high-level
components, 359
Web-service project created with Visual
Studio .NET, 362
Web-STP, 401
while loop code, 126
Windows Form Designer, 419
WS-Addressing achieves transport
standardization, 398
WS-MetadataExchange, 399
WS-Policy enforces constraints and rules,
395
WS-Referral implements STP provider
hub, 399
WS-Security secures SOAP message, 385
WSE architecture, 381
WSE configuration configures Web service
policies, 397
WSE Configuration dialog box, 382
WSE set-up options, 382
WSE settings dialog box, 383
file formats, examples of, 144
filenames, changing for Web services, 364
FileStream subclass of Stream class,
description of, 117
fills, relationship to orders, 7
financial marketplace, primary objectives in,
41
financial markets, anonymity in, 42
finite state machine, components of, 444
firm quote, definition of, 10
FIX (Financial Information Exchange)
protocol
popularity of, 304
significance of, 19
flags, relationship to fragmentation and IP,
182
floor brokers, overview of, 8, 10
foreach keyword, using with iterators, 459
formatter configuration, setting up in
hosting service controller, 260
formatter layer, relationship to proxy in .NET
Remoting, 241
formatters. See remoting formatters
forward engineering, explanation of, 423
forward lookup, relationship to DNS, 184
forward-only parsers, types of, 122–123
fragment offset, relationship to IP, 182
fragmentation
disabling in IP, 217
relationship to IP (Internet protocol),
182
frames, role in networking, 179
front office
instrument mapping in, 109
origination of orders in, 109
relationship to STP, 28
front running, explanation of, 10
front-office systems
characteristics of, 30
using C/C++ with, 30
full-covered concept, relationship to risk
management, 20
full-duplex TCP connection, explanation of,
194
full-type fidelity mode of serialization
engine, explanation of, 132
functional requirements, integrating
operational requirements with, 277
■I N D E X 493
F
ndi
ti
asterf
a
t
utp:/shperinde
.aprx
s.com/efund managers
activities of, 303
interactions with brokers, 320
funds settlement, overview of, 26–27
FxCop tool, features of, 477
■G
garbage collection, automation in .NET, 32
GCs (garbage collectors), types of, 464
<gcServer> element, adding to configuration
file, 464
GCSettings helper class, example of, 465
General Electric Company
buying for arbitrage, 414
price differential for, 411
GenerateCodeFromCompileUnit, converting
object graph to text with, 433
generic classes versus generic methods, 454
generic collections, overview of, 456–457
See also .NET collections
generic delegates, overview of, 456
generic methods, overview of, 454, 456
generic type constraints
class constraint, 452–453
inheritance constraint, 454
interface constraint, 453
overview of, 452
parameterless constructor constraint,
453–454
reference constraint, 453
value type constraint, 453
generic type parameters
associating multiple constraints on,
453
associating rules with, 452
generic types
base class of, 451
creating instances of, 451
inheritance on, 451
generic-aware remote classes, prerequisite
for, 474
generic-aware remote order container code
sample, 474
generics
role in .NET 2.0, 447, 451
using with order container, 449–450
GetLifetimeService method, returning lease
objects with, 270
GetObject of Activator class, using with
instances of remote objects, 260
GetString method of Encoding.ASCII class,
extracting bytes with, 190
GTC (good till cancelled) order, explanation
of, 43
GTD (good till date) order, explanation of, 44
GZipStream class in System.IO.Compression
namespace, definition of, 467
■H
handshaking
occurrence of, 261
relationship to transport layer, 191
hardware components, role in networking,
178
hash algorithms
examples of, 323
passing data to, 322
hash tables, using, 57
hash values
generating, 323–324
verifying with digital signature, 327
Hashtable
creating proxy references in, 265
declaring for service directory, 264
head count, reducing with STP, 301
header checksum field, relationship to IP, 182
heartbeat, implementing between machines
with Ping, 470
heartbeat interval information, capturing in
key-value pair, 251
heartbeat messages
exchange of, 83
sending with server timer, 83
targeting to monitor NASDAQ exchange
gateway, 277
targeting to monitor NYSE exchange
gateway code sample, 276
heartbeat operational component,
description of, 237
heartbeat service
accessing core knowledge about, 260
connecting service controller to,
259–260
creating proxy instance for, 260
defining LogicalProcess class for, 246
enabling in AOP, 282
explanation of, 244–245
in AOP, 281
interaction with service controller, 265
modifying to demonstrate configuration
framework, 250
returning proxy reference to, 266
RPC version of, 255–256
URL location of, 260
HeartBeatService class, code for, 245–246
HeartBeatServiceInfo class, emitting
metadata information with, 256
HeartBeatServiceInfo type
description of, 260
registering in RPC, 258–259
hitting the bid, explanation of, 5
Host class
in hosting service controller, 260
using with broadcast engine, 233
using with infrastructure services, 257
494■I N D E Xusing with primary controller, 294
using with service directory, 263–264
host ID, relationship to IP addresses, 181
host name, resolving to IP address, 184
hosts in networks
identifying, 185
multihomed hosts, explanation of, 189
house accounts, explanation of, 9
HTTP, use by Web services, 353
HTTP channel, description of, 258
HttpServerChannel class, description of, 258
human intelligence, overview of, 37
HybridDictionary specialized collection,
overview of, 58
■I
I’s (Intelligence) of performance in capital
markets
domain intelligence, 37
human intelligence, 37
machine intelligence, 36
overview of, 35
IAsyncResult, using with delegates, 61
IBCastMessage class, using with broadcast
engine, 223–224
IBM UDDI repository website, 371
ICMP (Internet Control Message Protocol),
relationship to IP layer, 182
ICodeCompiler, implementing in CodeDOM,
432
ICodeGenerator interface, implementing in
CodeDOM, 432
IComparable interface, using generic types
with, 451
IComparer instance, returning with
CodeDOM, 428
IComparer interface, sorting with, 53
IConfiguration interface, using in application
operation engine, 289
IController interface
implementing with PrimaryController,
290, 292
using in application operation engine,
286–287
ICryptoTransform interface, implementing,
315
identification field, relationship to
fragmentation and IP, 182
identifier attribute
explanation of, 146
using in CSV conversion rule, 148
IGMP (Internet Group Management
Protocol), relationship to routers, 214
IIS, DLL locking problem associated with,
252
ILease interface, controlling Lease class with,
268
ILogger interface, using in application
operation engine, 289
ILookUp interface
implementing for service directory, 264
using with service directory, 263
IMessageStore class, using with broadcast
engine, 224
IMethodInterceptor interface, implementing
with AuthorizationAdvice class in
AOP, 280
IModule class, using with broadcast engine,
228
impact cost, relationship to stock exchanges,
6
ImportParameters functionality, using with
digital certificates, 331
in- versus out-memory matching, 85
in-memory data, compressing and
decompressing, 467– 468
in-memory generation of assemblies,
advantage of, 433
in-memory matching
explanation of, 85
options available for, 85
rationale for, 85
inactive (removed) order, explanation of, 88
indexes
computing, 12
overview of, 12–13
Indy.Sockets .NET library, features of, 478
information, relationship to transactions, 3
infrastructural services, providing with
middleware, 240
infrastructure components versus business
components, 237
infrastructure service controller, hosting, 266
infrastructure services
configuring, 250, 252
hosting, 257
operations supported by, 248
server-side implementation for, 255–256
shadow copying of, 252–253
storing proxy references of, 264
inheritance, performing on generic types,
451
inheritance generic constraint, overview of,
454
inheritance levels in cryptography,
explanations of, 312
InitializeLifetimeService class, invoking for
lease objects, 268
InitializeLifetimeService member, using with
RPC version of heartbeat service, 256
InMemoryStore class, using with broadcast
engine, 224
<input> construct, using with WSDL
documents, 357
■I N D E X 495
F
ndi
ti
asterf
a
t
utp:/shperinde
.aprx
s.com/einsider, definition of, 11
institutional investor, explanation of, 19
institutional transactions, using STP in, 303
institutions versus retail customers, 20
instrument attribute of orders, explanation
of, 89
instrument master, using in trading chain,
109
instrumentation operational component,
description of, 237
instruments, mapping trees to, 87
instruments. See stocks
InsufficientMemoryException, generating,
464
integrity of data
explanation of, 307
overview of, 322, 324
IntegrityAttribute class, using in STP security,
334
interdepository transfers, management by
depositories, 16
interface generic type constraints, overview
of, 452–453
Interlocked class, relationship to atomic
operation, 73
internal STP, explanation of, 29
Internet layer of TCP/IP, explanation of, 179
interop attributes, using with message
framing, 204
interoperability. See also STP interoperability
overview of, 347, 349
of service providers, explanation of, 300
interprocess communication performance,
creating on same machine, 471
interthread notification, relationship to
multithreading, 68, 70
investors versus traders and dealers, 3
Invoke method, calling for bulk order form,
82–83
Invoke thread-safe member, exposing in
Windows control collection, 82
IOC (immediate or cancel) order,
explanation of, 44
IP (Internet protocol)
addressing in, 182
data length field in, 182
fragmentation and reassembling process
related to, 182
maintaining message integrity in, 182, 185
overview of, 179, 181
tweaking, 217
IP addresses
resolving host name to, 184
significance of, 180
subnet IDs in, 181
IP fragmentation, disabling, 217
IP MulticastLoopback, tweaking, 218
IP TTL and multicast TTL, tweaking, 217–218
IpcChannel, relationship to remoting, 471
IPEndPoint instance, using with market data
consumer, 189
IPHostEntry class, relationship to DNS, 185
IPO (initial public offering), explanation of, 2
IService
declaring for RPC, 254
declaring in .NET Remoting, 245
IServiceInfo interface, using with RPC, 254
ISIN codes
exchange code mapped to, 111
significance of, 109
ISIN element, XML Schema of, 139–140
ISIN master
example of, 148, 152
reading XML version of, 124–125
using XML with, 115–116
XML Schema of, 137–138
ISIN master XML document
assumptions made in, 136
validating with XmlValidatingReader class,
141–142
writing, 128, 130
ISINInfo type, annotating Serializable
attribute on, 133
ISINMaster root element, contents of, 141
ISO file format, example and description of,
145
ISponsor interface, implementing, 270
issuers, participation in market data
industry, 172
IsTransparentProxy helper static method,
using with transparent proxies, 261
IT structure, decentralizing for STP, 303
iterators, using with data structures,
459–460
IVs (initialization vectors)
generating, 315
relationship to CBC, 311
IWriter class, using in data conversion
framework, 161
■J
JIT-CC (just-in-time code cutting), features
of, 417, 423
JUSTRIGHT
■K
key information, storing in instance of
RSAParameters, 326
key pairs, generating and executing, 320
Key property of X509Certificate, retrieving
public key with, 331
key sizes
determining, 315
of symmetric ciphers, 313
496■I N D E Xsupport by symmetric algorithms, 310
supported by Rijndael, 315
key-value pair, capturing heartbeat interval
information in, 251
keys
encrypting, 321
generating, 315, 320–321
role in encryption and decryption, 309
■L
language-specific code provider,
constructing with CodeDOM,
432–433
late binding, providing with reflection, 436
latency, definition of, 35
layers of TCP/IP, relationship to networking, 179
lazy-loading technique, implementation in
remoting framework, 275
lead manager, definition of, 2
LeafContainer class of order-matching
engine, overview of, 94, 96
lease behavior, overriding default for, 268
Lease class, controlling with ILease interface,
268
lease manager, registering lease objects with,
269
Lease objects
associating new instance of, 268
getting reference to, 270
invoking InitializeLifetimeService class
for, 268
returning with GetLifetimeService
method, 270
leases
preventing renewal of, 270
renewing for remote objects, 269
leasing architecture of remote object
destruction, illustration of, 267
legacy systems, populating data from, 112
LegalBlockSizes property, using with
symmetric classes, 315
LegalKeySizes property, using with
symmetric classes, 315
lifetime management, performing in
remoting, 273
<lifetime> element of remoting
configuration, explanation of, 271
LIFO (last-in, first-out) data structures, stacks
as, 55–56
limit price order, explanation of, 44
liquidity
definition of, 4
measurement of, 41
relationship to transactions, 3
liquidity providers, specialists as, 10
list data structure, relationship to collections
and multithreading, 78
ListDictionary specialized collection,
overview of, 58
Listen method, using with market data
producer and TCP, 193
listing securities, effect of, 2
Listings
anonymous methods, 458–459
AOP-based heartbeat service, 281
asynchronous market data consumer
using TCP, 198–199
asynchronous market data producer with
TCP, 196–197
attributes, 132
client receiving broadcast message, 212
configuration file, 251
contract note information encrypted and
decrypted, 313–314
contract note information digitally
verified, 390, 392
contract note information encrypted and
decrypted, 318, 320
digitally signing contract note
information, 387, 389
Exchange element, 140
generic method, 454
generics used with order container, 449–450
hash value computed for contract note
data, 323–324
heartbeat message targeted to monitor
NYSE exchange gateway, 276–277
heartbeat message targeted to monitor
NASDAQ exchange gateway, 277
heartbeat service (RPC version), 255–256
heartbeat service configuration settings, 251
heartbeat service meta-information, 256
Heratbeat service (LPC version), 245
host translator, 184
hosting infrastructure service controller, 266
hosting infrastructure services, 257
hosting of service directory, 265
hosting service controller, 259–260
infrastructure service lookup, 263–264
ISIN master, 115
ISIN master CSV conversion rule file, 149
iterators, 459–460
market data (stock price) class, 203–204
market data consumer, 188–189
market data producer using TCP, 192–193
market data producer using UDP, 186–187
message framing, 204, 206
message header, 203
meta-information about infrastructure
service, 255
operations supported by infrastructure
services, 248
order container example related to
generics, 448–449
■I N D E X 497
F
ndi
ti
asterf
a
t
utp:/shperinde
.aprx
s.com/eoverriding remote object lease time, 268
reading XML version of ISIN master, 124
semaphore, 463–464
service controller remoting configuration,
272
signing and verification of contract note
data, 325–326
signing and verification of contract note
data using digital certificates,
325–330
solicited broadcast of market data,
214
sorting stock data, 425–426
stock data sort order customization,
428
stock data sorted using reflection,
437–438
stock data sorted with Reflection.Emit,
439, 442
STP-Provider B invokes STP-Provider
A Web service, 369
UDDI API programmatically determines
STP-Provider A Web service location,
378–379
unsolicited broadcast of market data,
211–212
Web service exposed by STP-Provider A,
364
writing ISIN master XML document, 128,
130
WSDL document for order management
Web service, 354, 356
WSDL for Web service exposed by STP-
Provider A, 365, 367
XML Schema of Exchange element,
140
XML Schema of ISIN element, 139–140
XML Schema of ISIN master, 137–138
XML Schema of root element, 141
lists, locking to ensure thread-safety of, 79
little-endian machine, explanation of,
201
local broadcasts
overview of, 210, 213
versus solicited broadcasts, 213
local objects
versus CAO objects, 243
definition of, 239
Location field, including in infrastructure
service, 255
location transparency, relationship to proxy
serialization, 263
lock keyword, as compiler-drive feature,
447
lock statement
form of, 422
using in code synchronization, 65
locks
acquiring in multithreading, 66
acquiring with Mutex, 70
heavyweight and lightweight locks, 70
log4Net framework, description of, 478
logging operational component, description
of, 237
logging service, invoking with order-
matching application, 297
LogicalProcess class
defining for heartbeat service, 246–247
introducing shadow copying in, 252–253
updating with overloaded constructor
method, 251
using service controller with, 249
LogManagement service, implementing for
application operation engine, 293
LookUp method
invoking in infrastructure service
controller, 266
using with proxy cache container, 265
loop attribute, using in CSV conversion rule,
148
loop attribute of bands, explanation of, 146
loopback address, example of, 181
loose coupling, availability in SOA, 351
LPC (local process communication)
overview of, 244, 249
relationship to .NET Remoting, 241
LPC Assembly Structure, overview of,
244–245
LPC projects, descriptions of, 244
LSB (least significant byte), relationship to
Intel-based machines, 201
■M
machine intelligence, overview of, 36
machine.config file, location of, 250
makecert utility
generating self-signed certificate with, 385
using with digital certificates, 328
managed objects
computing unmanaged size of, 207
field layout of, 204
Managed suffix, using with class names,
312
manual thread management, relationship to
code synchronization, 63–65. See also
multithreading; threads
ManualResetEvent class
role in interthread notification, 70
using with OrderProcessor, 98
margin trading, explanation of, 9
margining, implementing risk management
by means of, 22
market capitalization, relationship to
indexes, 13
498■I N D E Xmarket data
availability of, 177
example of, 173
overview of, 171–172
role in financial trading value chain, 173,
175
sending to multicast groups, 215
serializing into raw bytes, 194
timeliness of, 175, 177
market data consumers
asynchronous type of, 200
building for unsolicited broadcast, 212
for market data on multicast addresses,
215–216
overview of, 188, 190
using multicast groups with, 214–215
using TCP with, 194–195
market data engine, explanation of, 221
market data farm, explanation of, 220
market data industry, participants in,
172–173
market data producers
asynchronous type of, 195, 200
using TCP with, 192–193
market data service code sample, 72
market data service providers
differentiators in, 175
participation in market data industry,
172
market data vendors, significance of, 221
market entities and STP providers, examples
of, 348
market info cache client code sample,
473–474
market info cache server host code sample,
473
market information cache server
code implementation of, 472
implementing with IPC channel, 471
remoting configuration of, 472
market makers, overview of, 10–11
market price order, explanation of, 44
market transfers, management by
depositories, 16
market width and depth, relationship to
liquidity, 4
MarshalByRefObject, inheritance by
HeartBeatService class, 246
marshaling byte array from unmanaged
section of memory, 208
master detail file format, example and
description of, 145
matching process. See order-matching
engines
Math.NET open source library, description
of, 478
matrix, plotting data in, 145
Matrix class, using in data conversion
framework, 155–156
MBR (marshal-by-reference) objects. See
remote objects
MBV (marshal-by-value) objects. See mobile
objects
MD5 algorithm, hash values produced by,
323
MDP (market data producer) and MDC
(market data consumer) example,
186, 190
members. See brokers; stock-exchange
members
memory gate, overview of, 464
MemoryStream subclass of Stream class,
description of, 117
merchant banker, definition of, 2
message digest
computing for digital signature, 325
relationship to data integrity, 322
message framing, relationship to networking,
202, 209
message integrity, maintaining in IP, 182, 185
<message> element looks like for the order
management Web service, 357
message-processing unit, role in Web-service
platforms, 360
message-routing capabilities, availability in
Web services, 399–400
messages
grouping with <operation> element,
357
in SOAP, 358–359
managing for STP and Web services, 401
representing in WSDL documents, 357
triggering in networks, 179
messaging backbones, examples of, 235
meta-information
about infrastructure service, 255
defining for RPC version of heartbeat
service, 256
metadata, role in code generation, 416
metadata specification, overview of, 398
Microsoft Corporation, arbitrage on, 413
Microsoft test registry database, using with
Web services, 372, 378
Microsoft UDDI repository website, 371
middle office
reference data held by, 109
relationship to STP, 29
middle-office systems, implementation of, 30
middleware
role in .NET Remoting, 240
services offered by, 240
MktDataMessage class, using with broadcast
engine, 231, 233
MMC.NET Library website, 478
■I N D E X 499
F
ndi
ti
asterf
a
t
utp:/shperinde
.aprx
s.com/emobile objects
definition of, 239
using in .NET Remoting, 248
mode attribute value in custom Errors
element, managing remoting error
handling with, 274
model risk in arbitrage, explanation of, 407
model-driven code generators, features of,
417, 422
Monitor class
ensuring thread-safe access to shared
resources with, 64
implementing order book with, 64–65
versus Mutex synchronization
mechanism, 70
solving deadlock problems with, 67
monitors and mutexes versus semaphores,
462
Mono implementation of CLR standard, web
resource for, 32
Mono initiative, description of, 480
MSB (most significant byte), relationship to
Intel-based machines, 201
MSFT order book processing, thread priority
of, 43, 75–76
MSIL, emitting with classes in
System.Reflection.Emit namespace,
439
MSS (maximum segment size), relationship
to TCP, 191
MTU (maximum transmission unit),
relationship to IP, 182
multibyte value, converting from host byte
order to network byte order, 201–202
multicast address, example of, 216
multicast groups
defining, 215
formation of, 214
receiving data published on, 216
sending market data to, 215
using with market data consumers,
214–215
multicast server and client, running, 216
multicast TTL scope, description of, 217
multicasts, overview of, 213, 216
multihomed host, explanation of, 189
multithreaded behavior, providing with
Socket, 196
multithreaded problems, guarding timer
code from, 84
multithreading. See also manual thread
management; threads
and asynchronous delegate infrastructure,
60, 63
and atomic operation, 73
and collections, 77–78, 80–81
and deadlock prevention, 65, 68
and interthread notification, 68
and manual thread management, 63, 84
and Mutex synchronization mechanism,
70, 72
and server timer, 83–84
and thread pools, 59–60
and thread scheduling, 74, 77–78
and UI widgets, 81, 83
overview of, 59
Mutex synchronization mechanism,
overview of, 70, 72
mutexes and monitors versus semaphores,
462
mutual fund managers, building of positions
in indexes by, 12
■N
Nagle algorithm, relationship to TCP, 220
namespaces
representing in CodeDOM, 429
System.Collection namespace, 85
System.Threading namespace, 83
NAnt tool, features of, 477
NASDAQ (National Association of Securities
Dealers Automated Quotation),
significance of, 8
NASDAQ exchange gateway, heartbeat
message targeted to monitoring of,
277
NASDAQHeartBeatService class
authorization logic in, 280
requirements for, 277
navigation methods, using with XML,
127–128
NDepend tool, features of, 478
NDoc tool, features of, 478
negative correlation in price, relationship to
arbitrage, 406
.NET
features of, 32, 34
in equities market, 30, 34
.NET 2.0
and generics, 447, 451
.NET collections. See also generic collections
and arrays, 48–49
and hash tables, 57
and multithreading, 78, 81
and queues, 54
and stacks, 55–56
overview of, 48
.NET Compact Framework, explanation of,
33
.NET executable, role in remoting
framework, 241
.NET Framework BCL (base class library),
significance of, 38
.NET objects. See objects
500■I N D E X.NET Reflector tool, features of, 477
.NET Remoting infrastructure, overview of,
240–242. See also remoting
framework
.NET specialized collections
HybridDictionary, 58
ListDictionary, 58
netstat.exe utility, features of, 468
network adapters, interacting with, 469
network address classes, list of, 181
network address type, defining for market
data producer, 188
network byte order, overview of, 201–202
network endpoint details, recording for Web
services, 185, 376
network hosts, identifying, 185
network information, gathering, 468, 471
network interface layer of TCP/IP,
explanation of, 179
network-related changes, detecting, 470
network-related problems, diagnosing with
PING, 183
networking
and broadcast, 209–210
and Internet protocol, 179–180, 185
and message framing, 202, 209
and transport layer, 185, 191, 195
overview of, 177, 179
networks, components of, 178
NetworkStream subclass of Stream class,
description of, 118
nodes
relationship to networks, 178
specifying for Buy and Sell, 87
NodeType property, using with XML, 126
nonrepudiation of data, explanation of, 307
NonRepudiationAttribute class, using in STP
security, 335
NonRepudiationProvider class, using in STP
security, 340–341
nonsignal state, relationship to interthread
notification, 70
notice of execution, issuing, 304
novation, relationship to order matching, 47
NSCC (National Securities Clearing
Corporation), relationship to NYUSE,
15
null values, returning for remoting classes,
269
nullable types, overview of, 461–462
NUnit tool, features of, 477
NYSE (New York Stock Exchange),
significance of, 8
NYSE arbitrage example, 409, 414
NYSE Composite Index, description of, 12
NYSE exchange gateway, heartbeat message
targeted to monitoring of, 276
NYSEHeartBeatService class, requirements
for, 277
■O
OAEP padding, using with asymmetric keys,
321
object endpoint information, assigning in
RPC, 259
object lifetime with leasing, 267
objects. See also remoting objects
characteristics of, 241
multiple facets of, 238–239
relationship to classes, 238
types of, 239
ObjRef class, relationship to proxy
serialization, 262
OBook.orderSync, requesting locks on, 67
off-market transfers, management by
depositories, 16
offer price, relationship to two-way quotes, 4
Office PIA (Primary Interop Assemblies),
defining arbitrage models with, 443
OMEHost class of order-matching engine,
overview of, 102–103
online trading, enablement by banks, 15
<operation> element, grouping messages
with, 357
operational components versus business
components, 237
operational requirements, integrating with
functional requirements, 277
operations team, importance of, 283
oral auction
explanation of, 42
order precedence rules for, 44
order, definition of, 42
order attributes, examples of, 107
order books
conceptualizing, 86
example of, 43
implementing with Monitor, 64–65
for matching, 46
versus position books, 66
pre-match version of, 45
segregating into tree structure, 87
Order class of order-matching engine,
overview of, 89–90
order containers
instantiating and updating on remote
machine, 474
providing, 449
using generics with, 449–450
order dispatcher, monitoring operations
performed by, 86
order ID
explanation of, 89
generating and assigning, 73
■I N D E X 501
F
ndi
ti
asterf
a
t
utp:/shperinde
.aprx
s.com/eorder initiation and delivery, process of,
19–20
order management Web service
mimicking functionality of, 71
WSDL document for, 354, 356
order matching
and containment of credit risk, 47
and conversion into trades, processes of,
22
and novation, 47
example of, 46
exchanges and brokers in, 42–43
in-memory matching, 85
logic of, 42–43
need for efficiency in, 41–42
order precedence rules related to,
44, 47
out-memory matching, 85
price priority rule in, 44
types of orders in, 43–44
order precedence ranking, example of, 45
order price, sorting, 53–55
order processors
foundation of, 86
performing bookkeeping with, 86
realizing queue of, 86
order routing and risk management,
processes of, 20, 22
order type attribute of orders, explanation of,
89
Order type instance, serializing and
deserializing, 466–467
data structures related to, 85
order-matching applications reference to
instance of DomainApp in, 297
order-matching engine classes
BizDomain class, 100–101
Container class, 92–93
ContainerCollection class, 93–94
EquityMatchingLogic class,
101–102
EquityOrder class, 91
LeafContainer class, 94, 96
OMEHost class, 102–103
Order class, 89–90
OrderBook class, 96, 98
PriceTimePriority class, 91–92
order-matching engines
designing for efficiency, 84
high-level implementation of, 86
Order class, 88
overview of, 38
VS .NET project structure of, 89
OrderBook class of order-matching engine,
overview of, 96, 98
OrderContainer<OrderObj>, instantiating,
451
OrderContainer<T> generic type,
significance of, 450
OrderEventArgs class of order-matching
engine, overview of, 98
OrderObj members, accessing inside generic
code, 452
OrderProcessor class of order-matching
engine, overview of, 98, 100
orders
adding, retrieving, and removing,
50–51
attributes of, 89
designing data containers for, 84
enumeration of, 79
generating with program trading engine,
414
matching component of, 88
originating in front office, 109
placing, 7
processing concurrently with thread
pools, 59
processing in FIFO manner, 55
ranking in order matching, 46
ranking with PriceTimePriority class,
91–92
sorting with generic method, 454
states of, 88
storing, 87
storing in hash tables, 57
orderSync, acquiring lock on, 66
out- versus in-memory matching, 85
out-memory matching, explanation of, 85
OutOfMemoryException, generating, 464
<output> construct, using with WSDL
documents, 357
■P
P/Invoke service, using with message
framing, 204
P/Invoke signatures website, 478
packets, determining ages of, 217
Padding, relationship to cipher mode, 315
padding information, including in
MessageHeader, 203
paired method, relationship to
XmlTextWriter object, 130
<param> XML tag for documentation
comments, description of, 421
parameterless constructor generic
constraint, overview of, 454
parametric polymorphism, relationship to
generics in .NET 2.0, 447
Parser class, using in data conversion
framework, 157–158
parsers. See XML parsers
parsing approach, implementing for
message framing, 204
502■I N D E Xpartial types, spanning source code into
multiple files with, 460
partial-type fidelity mode of serialization
engine, explanation of, 132
passive (insert) order, explanation of, 88
Passport credential, using to publish Web
services, 372
pay-in and pay-out, in settlement, 28
pay-in and pay-out dates, explanations of, 26
PBook.posSync, requesting lock on, 67
percentage returns, calculating for arbitrage,
411
performance of applications, importance of,
35, 38
PING (Packet Internet Groper) Utility,
features of, 183
ping request, checking outcome of, 471
ping.exe command-line tool, features of, 470
pipe, relationship to proxy in .NET Remoting,
242
PipeContext class, using with broadcast
engine, 228–229
PKCS padding, using with asymmetric keys,
321
pledges, management by depositories, 16
point-cut in AOP, explanation of, 279
point-cut methods, identifying in AOP, 281
policies, overview of, 395–396
polling value, changing for lease manager,
269
Pop methods, using with stacks, 56
port 12000, honoring service controller
request on, 265
<port> elements, using with WSDL
documents, 358
<portType> element, using with WSDL
documents, 357
position books versus order books, 66
positional file format, example and
description of, 145
positive correlation in price, relationship to
arbitrage, 406
posSync, acquiring lock on, 67
post-trade activity, explanation of, 19
PostTradeService, enabling contract note
functionality with, 364
Power Collections tool, features of, 478
power of attorney, requirement by brokers,
17
pre-opening session, explanation of, 8
pre-trade, explanation of, 19
PreGenXMLSerializer.exe code sample,
465–466
price and time, basing order-matching logic
on, 42
price attribute of orders, explanation of, 89
price conditions order, explanation of, 44
price differentials
computing in arbitrage, 410
exploiting with arbitrage, 414
price priority order precedence rule,
explanation of, 44
prices, touchline prices, 7, 43
PriceTimePriority class of order-matching
engine, overview of, 91–93
primary controller
code sample, 294
explanation of, 284
remoting configuration for, 293–294
role in application operation engine, 283
PrimaryController, implementing for
application operation engine, 290,
292
principal transactions, explanation of, 9
private keys
decrypting messages with, 321–322
versus public keys, 317
PrivateKey.xml, contents of, 320
ProcessInfo property of LogicalProcess class,
using ServiceHost with, 249–250
processing tasks, offloading with CLR thread-
pool implementation, 457–458
processor balance, establishing between
multiple threads, 76
ProcessOrder static method, using with
thread pools, 60
producer components of broadcast engines,
descriptions of, 221–222
profile binding, performing in STP security,
333
ProfileInfo class, using in STP security,
336–337
profitable arbitrage, selecting, 412
program execution, consistency of, 63
program trading, explanation of, 19
program trading engine versus arbitrage
engine, 414
program trading system versus arbitrage
system, 408
protocol tweaking
IP DontFragment, 217
IP MulticastLoopback, 218
IP TTL and multicast TTL, 217–218
overview of, 216
Socket buffers, 219
Socket ReuseAddress, 218
Socket timeout, 219
TCP NoDelay, 220
protocols
FIX (Financial Information Exchange), 304
importance of, 302
relationship to networks, 178
Provider class, using in STP security,
339–340
■I N D E X 503
F
ndi
ti
asterf
a
t
utp:/shperinde
.aprx
s.com/eproxies. See also real proxies; transparent
proxies
creating for remotable services, 260
overview of, 261, 266
real proxies, 261–262
role in caller interaction with remote
objects, 241–242
successful instantiation of, 260
transparent proxies, 261–262
proxy cache container, populating and
making available to service
controller, 265
proxy classes
using with WSE, 383
viewing code emitted by, 368
proxy instance, creating for heartbeat
service, 260
proxy objects, types of, 261
proxy references
returning to heartbeat service, 247, 266
returning to service controller, 263
storing for infrastructure services, 264
proxy serialization
secret behind, 262
significance of, 262
PSE (Philadelphia Stock Exchange) arbitrage
example, 409, 414
public key information, communicating, 327
public keys
initializing, 321
versus private keys, 317
retrieving with Key property of
X509Certificate, 331
public offering, definition of, 2
PublicKey.xml, contents of, 320
Pull forward-only parsers, description of, 123
pure arbitrage, explanation of, 406
Push forward-only parsers, description of, 122
Push method, using with stacks, 56
■Q
quantity attribute of orders, explanation of, 89
quantity precedence, role in order matching,
45
QueryServiceInfo method, using in .NET
Remoting, 249
queues, storing and retrieving data with,
54–55
QueueUserWorkItem static method, calling
for tasks in thread pools, 60
quick sort algorithm
availability of, 87
using with arrays, 51
quotes
receiving firm and soft quotes from
specialists, 10–11
receiving from specialists, 10
quotes for stock, two-way quotes, 4
quotes for stocks, referring to, 4
■R
race condition, explanation of, 64
RAIL (Runtime Assembly Instrumentation
Library) framework, description of,
479
RC2 symmetric algorithm, key sizes
supported by, 310, 313
Read method, using with XML, 125
reading comma-delimited version of ISIN
master, 119
real proxies, explanation of, 261–262. See also
proxies; transparent proxies
ReceiveFrom, invoking for market data
consumer, 189
recipients, participation in market data
industry, 173
refactoring, improving code readability and
maintainability with, 422
reference data
and framework for data conversion, 111,
115
cleaning, 112
overview of, 107–108, 115
role in order flow chain, 110
reference generic constraints, overview of,
453
reference types, using with containers, 449
ReferencedAssemblies attribute, using with
CodeDOM, 429
reflection
overview of, 434, 438
relationship to code generation, 417–418
Reflection API, definition of, 434
Reflection.Emit, code generation with, 439,
442
Reflector.FileDisassembler tool, features of, 477
Register method, using with sponsors, 270
RegisterChannel of ChannelServices class,
using in remoting infrastructure, 258
RegisterWellKnownServiceType static
member, using in RPC, 258
registry for STP provider consortium, using
UDDI as, 370
Regulator tool, features of, 478
remotable services, creating proxies for, 260
remotable type and channel, relationship
between, 259
remote generic type, client instantiation of,
475–476
remote object registration, separating from
channel information, 271
remote objects
controlling destruction of, 267
creating instance of, 260
504■I N D E Xdefault lease times assigned to, 268
definition of, 239
extending life of, 268
providing infinite lifetimes to, 269
registering, 258
renewing leases for, 269
remote order container, remoting
configuration of, 475
remoting
and debugging, 275
and error handling, 274–275
and lifetime management, 273
and security, 275
and versioning, 274
configuring, 271, 275
separating client and server configuration
details in, 273
remoting applications, applying generics in,
474
remoting architecture, extensibility of, 242
remoting channels, examples of, 258
remoting classes, packaging of, 257
remoting code
for configuration of market info cache
server, 472–473
for implementation of market info cache
server, 472
for market info cache client, 473
for market info cache server host, 473
shared assembly component of, 472
remoting components, identifying, 284
remoting configuration
code sample with service controller, 272
example of, 271
for primary controller, 293
remoting formatters, types of, 258
remoting framework, overview of, 471. See
also .NET Remoting infrastructure
remoting infrastructure, booting with
Configure method of
RemotingConfiguration class, 271
remoting objects, types of, 242–243. See also
objects
Remove method
overriding for collections and
multithreading, 79
using with Hashtable class, 57
Renewal method, using with ISponsor
interface, 270
repository for STP provider consortium,
using UDDI as, 370
requirement distillation, explanation of, 238
requirements. See business requirements
Resolve operation, using with DNS, 184
resources, relationship to networking, 178
responsiveness of applications,
measurement of, 35
retail customers
explanation of, 19
versus institutions, 20
retail transaction, process of, 20, 22
<return> XML tag for documentation
comments, description of, 421
returns on arbitrage, factors involved in,
409
reusability, availability in SOA, 352
reverse engineering, explanation of, 423
reverse lookup, relationship to DNS, 184
Rijndael symmetric algorithm
key sizes supported by, 310, 313, 315
listed features supported by, 314
using, 313–314
risk management
and order routing, processes of,
20, 22
role of market data in, 174–175
risks, for physical securities, 17
root element of XML Schema, example of,
141
round-turn transaction, relationship to
spread, 5
RoundRobinDispatcher class, using with
broadcast engine, 226–227
routers
relationship to multicast messages,
214
role in networks, 180
Row class, using in data conversion
framework, 154
RowParser class, using in data conversion
framework, 159
rows in data conversion framework,
explanation of, 146
RPC (remote process communication)
overview of, 254, 260
relationship to .NET Remoting, 241
RPC style, using with SOAP messages,
359
RPC.ServiceDirectory console project,
creating for service directory, 263
RPC.Services.exe.config configuration file,
creating, 272
RSACryptoServiceProvider
creating instance of, 321
creating new instance for digital
certificates, 331
creating new instance of, 320–321, 326
RSAParameters, storing key information in,
326
RTT (round-trip time (RTT), inclusion in
PING output, 183
rule file, role in data conversion framework,
147
rule schema, example of, 149, 151
■I N D E X 505
F
ndi
ti
asterf
a
t
utp:/shperinde
.aprx
s.com/erules
associating with generic type parameters, 452
capturing arbitrage strategies in form of,
443–444
rules and constraints, associating with Web
services, 396
■S
SAOs (server-activated objects), role in .NET
Remoting, 242
scalability, definition of, 35
scheduler, maintaining thread priority level
with, 75
Schemas property, using with
XmlValidatingReader class, 142
screen-based trading, explanation of, 7
search cost, reducing, 6
search costs, avoiding, 42
SectionData class, using in STP security,
338–339
SecureEnvelope class, using in STP security,
337–338
SecureSTPConsumer console application,
creating, 386
securities. See also stocks
considering in arbitrage, 410
examples of, 6
securities clearing account, logical
breakdown of, 27
securities obligation, overview of, 27–28
security. See also WS-Security specification
considering in remoting, 275
STP security, 39
types of, 32
security code mapping, examples of, 110
security framework code sample, 343–344
security in STP space. See STP-space security
security profile, role in STP security, 333
security type, defining for data, 333
SecurityProfileAttribute class, using in STP
security, 336
SEDOL (Stock Exchange Daily Official List)
codes, using, 109
SEDOL code mapping, example of, 110
segments, role in networking, 179
self-describing document, XML as, 116
Sell, specifying node for, 87
sell orders
processing, 21
sorting in order matching, 42
semaphores, counting semaphores,
462–463
SendData, completing asynchronous send
with, 198
Serializable attribute
annotating in .NET Remoting, 248
example of, 133
serialization
definition of, 131
example of, 135–136
serialization code for message framing, 206
serialization engines
modes of, 132
types of, 132
serialization logic, static linking of, 465
serialization process, explanation of, 202
server configuration details, separating from
client in remoting, 273
Server GC, description of, 464
server timers
enabling, 84
relationship to multithreading, 83–84
sending heartbeat messages with, 83
server-side implementation, defining for
infrastructure services, 255–256
server-side services, relationship to
application operation engine, 284
Service base class, using in application
operation engine, 289–290
service consumers, building with Visual
Studio .NET, 367
service controller and heartbeat service,
console output for, 260
service controller remoting configuration
code sample, 272
service controller request, honoring on port
12000, 265
service controllers
building, 244, 249
connecting to heartbeat service in RPC,
259–260
making proxy cache container available
to, 265
returning proxy reference to, 263
versus sponsorship, 270
updating to interact with heartbeat
service, 265
using LogicalProcess class with, 249
service directory
console output of, 267
hosting, 265
hosting as executable, 263
implementing functionality for, 263
interaction with heartbeat service, 265
relationship to proxy serialization, 263
service providers
custodian service provider, 299
STP service provider, 300
service proxies, using with STP and Web
services, 367
<service> element
explanation of, 271
using with WSDL documents, 358
ServiceHost, using with heartbeat service, 247
506■I N D E XServiceInfo class
using in .NET Remoting, 248
using in RPC, 254–255
ServiceLookUp class, creating instance of,
265
session key, explanation of, 322
SetSocketOption, using in unsolicited
broadcast, 212
settled transaction, explanation of, 28
settlement
between clearing members and clearing
corporations, 15
process of, 15
role of market data in, 175
settlement and clearing, processes of, 24, 28
settlement cycle, acceleration by
depositories, 17
settlement time
reducing with STP, 301
reduction by STP, 30
SGen tool, boosting start up performance of
XMLSerializer with, 465, 467
SHA algorithm, hash values produced by, 323
SHA1Managed, creating new instance of, 324
shadow copy mechanism, relationship to
infrastructure services, 252
share quantity, hiding, 44
shared assembly for remoting and generics
code sample, 474. See also
assemblies
shared keys. See symmetric keys
shared resources, using counting
semaphores with, 462–463
shareholders, definition of, 2
Shutdown, implementing with TCP half-
close feature, 194
signal state, relationship to interthread
notification, 70
signature keys, using with digital certificates,
331
SignData method, producing signature of
data with, 331
SignDataBroker method
invoking, 326
using with digital certificates, 330
verifying digital signatures with, 326
SignHash, passing hash value to, 327
simple type elements, nesting under
xs:schema element, 139
SingleCall objects, relationship to .NET
Remoting, 242
Singleton objects, role in .NET Remoting,
243–244
Singleton remotable classes, modeling
primary controller and agent as, 284
Singleton type, using in RPC, 258
size precedence, role in order matching, 45
SL (stop loss) order, explanation of, 44
smart card, explanation of, 332
SOA (service-oriented architecture)
and SOAP, 358–359
and Web services, 352–353
and WSDL, 354, 358
relationship to STP interoperability,
351–352
SOAP (Simple Object Access Protocol)
relationship to SOA, 358–359
relationship to Web services, 353
SOAP formatter, description of, 258
SOAP messages
processing by WSE, 381
securing with WS-Security, 385
SOAP serializer, explanation of, 132
SoapServerFormatterSinkProvider class,
description of, 258
Socket buffers, tweaking, 219
socket exception handler, including in
market data consumer, 189
Socket instance, creating for market data
producer, 187
Socket ReuseAddress, tweaking, 218
Socket timeout, tweaking, 219
Socket.Send, using with TCP, 202
Sockets
advisory about closing of, 188
creating for market data producer with
TCP, 193–194
providing multithreaded behavior with,
196
role in networking, 186
support for blocking and nonblocking
operations, 195
using asynchronous methods of, 197
soft quotes, receiving from specialists, 10
software components, role in networking,
178
solicited broadcasts, overview of, 213, 216
Sony Corporation, arbitrage on, 412
sort functionality, incorporating inside
generic order container, 454
SortCode class, defining in CodeDOM, 430
sorting
applying on user-defined attributes of
data elements, 52
data elements, 87
SOS (Son of Strike) WinDbg extension,
features of, 480
source address in IP header, significance of, 182
SourceMonitor tool, features of, 479
space, role in measuring algorithm efficiency,
48
specialists, overview of, 10–11
specialized class code generators, features of,
417, 423
■I N D E X 507
F
ndi
ti
asterf
a
t
utp:/shperinde
.aprx
s.com/especialized Stream classes. See also streams
BinaryReader and BinaryWriter, 120–121
TextReader and TextWriter, 120
XmlReader and XmlWriter, 122
specification, definition of, 359
speculative arbitrage, explanation of, 407
sponsors
building relative to current system time,
270
relationship to remote objects and leases,
269
using Register and Unregister methods
with, 270
spread
relationship to bid and offer prices, 5
relationship to stock exchanges, 6
Spring.NET framework, description of, 479
stacks, using, 55–56
Standard & Poor’s 500 index, description of,
12
standing instructions, providing for
depositories, 17
Start method
declaring virtual for
NASDAQHeartBeatService, 280
invoking for heartbeat service, 260
using with HeartBeatService class, 246
state-change event, explanation of, 83
stateful objects, description of, 243
stateless objects, description of, 242
static data element of business infoset,
overview of, 108
stock data
sorting, 424, 426
sorting with Reflection.Emit, 439, 442
stock exchanges
buying and selling on related to arbitrage,
413
examples of, 8
forms of trading supported by, 42
overview of, 6, 8
participation in market data industry, 172
role in order matching, 42–43
transitions in, 6
stock ownership, benefits of, 2
stock price custom class example of
CodeDOM, 424, 426
stock sort example using reflection,
37–438
stock-exchange members. See also brokers
becoming, 11–12
floor brokers, 8, 10
relationship to classes, 238
specialists, 10–11
trades between, 25
StockData, defining in shared assembly,
427
stocks. See also securities
versus bonds, 1
risks associated with, 17
Stop method, declaring virtual for
NASDAQHeartBeatService, 280
storage mechanism, considering for data
containers, 85
store component of broadcast engine,
description of, 222
StoreCollection class, using with broadcast
engine, 225–226
STP (straight through processing)
achieving, 303, 306
achieving internal STP, 332
and custodian service providers, 299
and single-point transaction fulfillment,
301
and Web services, 360, 370
cost savings associated with, 300
development of, 300
goal of, 331
implementing WS-Security in, 385
overview of, 28, 30
perspective of, 301, 303
reducing head count with, 301
reduction in settlement time associated
with, 301
standardizing interinstitution
communication with, 300
success of, 307
STP framework, illustration of, 306
STP interoperability. See also interoperability
challenges in achievement of, 350
overview of, 347
requirement of, 349
with several service providers, 348–349
STP marketplace, expectations related to, 348
STP process, enabling, 302–303
STP provider consortium
building, 372, 378
relationship to UDDI, 370, 379
STP provider hub, making available with WS-
Referral specification, 399
STP providers
activities of, 302
initiating communication with, 401
overview of, 300
registering, 373
STP security
conceptual design of, 332
importance of, 39
STP service provider network,
communication in, 305
STP settlements, significance of, 15
STP space
confidentiality in, 308, 322
illustration of, 307
508■I N D E XSTP-Provider A ASP.NET Web service project,
modifying to recognize digital
signature, 389–390
STP-space security
asymmetric keys in, 317, 322
confidentiality in, 308, 310
digital certificates in, 327, 331
digital signatures in, 324, 327
integrity in, 322, 324
overview of, 307–308
symmetric classes in, 312, 316
symmetric keys in, 310, 312
STPCertificateStore, installing certificate
published by broker in, 331
stream cipher, definition of, 309
Stream class, properties and methods
provided by, 118
streams, relationship to data stores, 117. See
also specialized Stream classes
subclasses as generic types, derivation of,
451
submission of instruction, initiation by
custodian, 306
SubmitContractNote operation, publishing
by Web service, 365
subnet ID in IP address, significance of, 181
substitution ciphers, strength of, 308
<summary> XML tag for documentation
comments, description of, 421
symmetric algorithms
examples of, 310
programmatic implementation of, 312
symmetric ciphers, key sizes of, 312
symmetric classes, relationship to STP-space
security, 312, 316
symmetric encryption versus asymmetric
encryption, 322
symmetric keys
in STP-space security, overview of, 310
using CBC (Cipher Block Chaining) mode
with, 311
using CFM (Cipher Feedback Mode) mode
with, 311–312
using ECB (Electronic Code Book) mode
with, 310
SymmetricAlgorithm class, subclassing and
extending, 312
SyncArrayList, deriving from ArrayList, 78
Synchronized static method defined in the
ArrayList class, using with thread-
safe lists, 78
SyncRoot property of ArrayList, relationship
to collections and multithreading, 79
System.Collections namespace data
structures
array lists, 49, 51
arrays, 48–49
hash tables, 56–57
and relationship to in-memory matching,
85
queues, 54–55
quick sort and binary search,
51, 54
stacks, 55–56
System.Collections.ArrayList, storing orders
in, 87
System.Collections.Generic namespace,
contents of, 456
System.IO.Compression namespace,
compressing data with, 467–468
System.Net.NetworkInformation namespace,
classes available in, 468
providing network-related information
with, 468
System.Object array, declaring for container,
449
System.Runtime.Remoting assembly,
remoting classes in, 257
System.Runtime.Remoting.ObjRef class,
relationship to proxy serialization,
262
System.Security.Cryptography namespace,
programmatic implementation of
symmetric algorithms in, 312
System.Threading namespace, Timer class
in, 83
System.Threading.ThreadPool class
functionality of, 74
representing thread pools in, 59
■T
T type parameter, replacing with OrderObj,
451
T+1 and T+2 settlements, prerequisite for,
17
T+1 initiative, significance of, 300
T+1 settlements
move toward, 29
significance of, 15
T+2 and T+3 environments, explanations of,
25
T+3 versus T+1, 349
T+3 to T+1 environment, relationship to STP,
302
taking the offer, explanation of, 5
TCP (Transmission Control Protocol)
using Socket.Send with, 202
using with asynchronous market data
consumer, 198–199
using with asynchronous market data
producers, 196–197
using with market data consumer,
194–195
using with market data producer, 192, 194
■I N D E X 509
F
ndi
ti
asterf
a
t
utp:/shperinde
.aprx
s.com/eTCP buffer, role as sender window size and
receive window size, 192
TCP channel
description of, 258
remoting-related problem with, 471
TCP half-close, implementing with
Shutdown, 194
TCP NoDelay, tweaking, 220
TCP/IP, relationship to DNS, 183–184
TCPChannel, using as primary
communication channel, 284
TcpClientChannel class, using in hosting
service controller, 260
TcpServerChannel class, description of, 258
TCPTrace tool, features of, 479
techno-domain architects, overview of, 34
TextReader and TextWriter specialized
Stream classes, overview of, 120
thread affinity, support for, 76
Thread class, instantiating instance of, 70
thread pools, overview of, 59
thread priority levels, examples of, 75
thread safety, ensuring, 79, 81
thread scheduling, overview of, 74, 78
thread-safe list, example of, 78
threads. See also manual thread
management; multithreading
execution of, 74
limiting access by, 463
use of counting semaphores by, 462
throughput, definition of, 35
ticker plant, market data farm as, 220
time, role in measuring algorithm efficiency,
48
time and price, basing order-matching logic
on, 42
time stamp attribute of orders, explanation
of, 89
time to live field, relationship to IP, 182
timer architecture, importance of, 83
Timer class defined in the System.Threading
namespace, using, 83–84
timer code, guarding from multithreaded
problems, 84
timer event, explanation of, 83
TimeSpan.Zero value, returning for leases,
270
top-five functionality orders, enumerating, 79
touchline price, explanation of, 7, 43
ToXmlString method, using with keys, 320
trade book, example of, 46
trade confirmation, process of, 111
trade guarantee funds, relationship to
clearing corporations, 14
trade life-cycle steps
affirmation and confirmation, 23
clearing and settlement, 24, 28
order initiation and delivery, 19–20
order matching and conversion into trade,
22
order matching and conversion into trade
step of, 22
overview of, 18–19
risk management and order routing, 20
trade reconciliation process, initiation of, 24
traders versus investors and dealers, 3
trades
back-office functions of, 18
between members, 25
front-office functions of, 18
notifying with callback mechanism, 62–63
pre- and post-trades, 19
trading, justifications for, 3, 5
trading applications. See also application
operation engine
launching, 284
modularizing, 236
stopping and starting, 295–296
trading chain, using instrument master in,
109
trading operation-related services, example
of, 244
trading operational requirement, overview
of, 235, 238
trading session, definition of, 8
trading terminals, using, 19
trading value chain, division of, 109
transactions
addressing exceptions related to, 301
factors related to, 3
management by depositories, 16
settlement of, 28
settling with depositories, 15
splitting via novation, 47
using STP in institutional transactions,
303
Transmission Control Protocol/Internet
Protocol (TCP/IP), relationship to
networks, 178
transmission media, role in networking,
178
transparent proxies. See also proxies; real
proxies
explanation of, 261–262
serializable nature of, 262
transport layer of TCP/IP, overview of, 179,
185–186, 190–191, 195
transport unit, role in Web-service platforms,
360
TransportModule class, using with broadcast
engine, 231
transposition cipher, explanation of, 309
tree structure, segregating order books into,
87
510■I N D E Xtree-based parsers
overview of, 122
support for, 123
trees, implementing, 87
TripleDES, key size of, 313
TryEnter, using with Monitor class and
deadlocks, 67
two-way quotes
explanation of, 4
receiving from specialists, 10
Type class, relationship to reflection, 434
type parameter in generics, explanation of,
450
type safety
providing to instances of generic types,
451
resolving with generics, 449
typed DataSet, explanation of, 423
TypeLoadException, throwing in remoting
framework, 274
types
nullable types, 461–462
using partial types, 461
<types> element, using with WSDL
documents, 356
■U
UDDI (Universal Description, Discovery, and
Integration), using with STP provider
consortium, 370, 379
UDDI .NET assembly, using, 377, 379
UDDI .NET SDK, description of, 377
UDDI repository, building, 371
UDP (User Datagram Protocol)
drawbacks of, 190–191
relationship to transport layer, 186
versus TCP, 191
using with market data consumer, 188,
190
using with market data producer, 187
using with market data producer, 186
UI actions, examples of, 81
UI messages, generating, 81
UI threads
explanation of, 81
receipt of messages by, 82
UI widgets
creating in Windows Form Designer,
418
relationship to multithreading, 81, 83
UML model-driven generator, description of,
422
unbound type, relationship to generic type
parameters, 452
unboxing process, relationship to array lists, 50
unicast communication model, example of,
209
UnRegister method, using with sponsors, 270
unsolicited broadcasts
overview of, 210, 213
versus solicited broadcasts, 213
upload activity, making interactive, 81
Upload button, clicking for bulk order
upload form, 82
URI (uniform resource identifier), defining in
RPC, 258
URL location of heartbeat service, storage of,
260
Use the Centralized Connection Strings
Database website, 478
user authentication and profile operational
component, description of, 237
user event, explanation of, 83
user interface code generators, features of,
416, 418
user requirements, relationship to
application design, 36
■V
value type generic constraints, overview of,
453
value types
allowing storage of, 451
using with containers, 449
variable data element of business infoset,
overview of, 107
variables, relationship to classes, 238
Verify method
using with NonRepudiationProvider class,
341
using with provider class, 340
VerifyData, invoking for digital certificates,
331
VerifySignFM
mimicking fund manager with, 327
using with digital certificates, 330
verifying digital signatures with, 326
versioning, relationship to remoting, 274
virtual methods, using with Service base
class, 289
Visual Studio .NET
creating service consumer with, 367
creating Web services with, 364
creating Web-service project with, 361
enabling WSE support in, 381
■W
WaitCallBack delegates, using with thread
pools, 60
Wal-Mart Stores, arbitrage on, 413
Walt Disney Company
arbitrage on, 413
buying for arbitrage, 414
price differential for, 411
■I N D E X 511
F
ndi
ti
asterf
a
t
utp:/shperinde
.aprx
s.com/eweaving rules, composing in AOP-based
heartbeat service, 280–281
Web References node, expanding, 368
Web service references, adding with wsdl
command-line tool, 367
Web service registration process, UDDI
information captured during, 371
Web services
addressing performance associated with,
400
and STP, 360, 370
associating rules and constraints to, 396
business-technology mapping for, 400
changing class names and filenames for,
363
creating with Visual Studio .NET, 364
expanding project hierarchy for, 368
fetching complete information about, 365
performance in financial market, 400
platform infrastructure for, 359–360
prerequisites for creation of, 361
publishing, 372
recording network endpoint details of, 376
relationship to SOA, 352–353
testing, 370
updating to verify digital signatures, 390,
392
Web-STP, requirements of, 400
websites
Alchemi framework, 478
Aspect#, 278
CLR Profiler tool, 479
CoverageEye.NET tool, 478
database connection strings, 478
Dotfuscator tool, 477
Enterprise Library, 479
Ethereal tool, 479
FxCop tool, 477
Indy.Sockets .NET library, 478
log4Net framework, 478
Math.NET open source library, 478
MMC.NET Library, 478
Mono CLR standard, 32
Mono initiative, 480
NAnt tool, 477
NDepend tool, 478
NDoc tool, 478
.NET Reflector, 477
NUnit tool, 477
P/Invoke signatures, 478
Power Collections tool, 478
RAIL (Runtime Assembly Instrumentation
Library), 479
Reflector.FileDisassembler, 477
Regulator tool, 478
SOS (Son of Strike)WinDbg extension, 480
SourceMonitor tool, 479
Spring.NET framework, 479
TCPTrace tool, 479
UDDI repositories, 371
Use the Centralized Connection Strings
Database, 478
WinDbg tool, 479
Windows System Utilities, 479
WS-Security, 384
WSDL specification, 354
well-formed document, example of, 116
“what” portion of the clearing problem,
answering, 25–26
“when” portion of the clearing problem,
answering, 25
where keyword, specifying code syntax of
generic constraints with, 452
“where” portion of the clearing problem,
answering, 25
while loop
using with Start method of
HeartBeatService class, 246
using with XML, 125
whitespace, managing in XML documents,
126
“whom” portion of the clearing problem,
answering, 25
Win32 process, role in remoting framework,
241
WinDbg tool, features of, 479
window size, relationship to TCP, 192
Windows Form Designer, code-generation
techniques in, 418
Windows scheduler, maintaining thread
priority level with, 75
Windows service manager versus service
controller, 244
Windows System Utilities website, 479
WinForm applications, bulkorder upload
form, 82
wizards, availability in VS .NET IDE, 420
worker threads
modifying UI widget properties from, 82
sending messages from, 82
Workstation GC, description of, 464
WrapClass factory method, using new
instance of
NASDAQHeartbeatService with, 282
writers in data conversion framework,
examples of, 148
WS-* specifications, overview of, 379–380
WS-Addressing specification, overview of,
397–398
WS-MetadataExchange specification,
overview of, 398
WS-Policy specification, overview of, 395–396
512■I N D E XWS-Referral specification, overview of,
399–400
WS-Security specification, overview of, 384,
392–393, 395. See also security
WS-SecurityPolicy, activating, 396
WSDL (Web Services Description Language)
explanation of, 353
relationship to SOA, 354, 358
wsdl command-line tool, adding Web service
references with, 367
WSDL document, retrieving for use with Web
services, 365
WSE (Web Services Enhancement)
framework
implementing WS-Security features with,
385
overview of, 380, 384
using with digital certificates, 328
verifying digital certificates, 387
■X
<x509> element, explanation of, 387
X509CertificateStore, returning instance of,
331
XML (eXtensible Markup Language)
and COD (context-oriented data),
116–117
versus CSV, 116
and data arrangement uniformity, 116
and domain knowledge, 116
extensibility of, 117
overview of, 115–116
reading, 123, 128
use in Web services, 353
writing, 128, 131
XML data cleansing stages
cleansing, 113
enrichment, 114
import and conversion, 113
XML data writer, role in data conversion
framework, 148
XML documents
requirements for, 141
validating, 141
XML documents and CLR types, using
XmlSerializer class with, 133
XML fragment of messages between broker
and trading partners, 357
XML output
for data conversion example, 167
for refined conversion rule, 167–168
XML parsers
fast-forward parsers, 122–123
features of, 123
forward-only parsers, 122–123
overview of, 122
tree-based parsers, 122
using with bands, rows, and columns,
148
XML Schema
information captured by, 137
relationship to WSDL, 354
XML serialization, overview of, 131, 136
XML serializer, explanation of, 132
XML tags for documentation comments,
examples of, 421
XmlAnyAttribute attribute, description of,
134
XmlAnyElement attribute, description of, 134
XmlArray attribute, description of, 134
XmlArrayItem attribute, description of, 134
XmlAttribute attribute, description of, 134
XmlDataWriter class, using in data
conversion framework, 161–162
XmlElement attribute, description of, 134
XmlEnum attribute, description of, 134
XmlIgnore attribute, description of, 134
XmlNodeReader inherited class, using with
XmlReader, 123
XmlReader and XmlWriter specialized
Stream classes, overview of, 121
XmlReader class
explanation of, 123
inherited classes of, 123
XmlRoot attribute, description of, 134
XmlSerializer class
boosting start up performance of, 465, 467
relationship to JIT-CC, 423
using attributes with, 133–134
XmlTextReader class
properties and methods of, 126–127
role in data conversion framework, 147
XmlTextReader inherited class
using with XmlReader, 123
writing XML-aware code with, 123, 125
XmlTextWriter class
description of, 128
members and properties of, 130–131
XmlTextWriter object, instantiating, 130
XmlValidatingReader class
role in data conversion framework, 147
validating ISIN master of XML document
with, 141–142
XmlValidatingReader inherited class, using
with XmlReader, 123
XOR operations, using with CFM (Cipher
Feedback Mode), 312
XSD (XML schema definition)
overview of, 136, 143
using with conversion rule file, 149, 151
XSD document, role in data conversion
framework, 147
■I N D E X 513
F
ndi
ti
asterf
a
t
utp:/shperinde
.aprx
s.com/eXSD form, representing ContractNoteInfo
type in, 367
XSD type system, using with WSDL
documents, 357
xs:schema element, elements nested under,
138–139
■Y
yield return and yield break statements, with
iterators, 460
514■I N D E XFIND IT FAST
with the
Apress SuperIndex
 
Quickly Find Out What the Experts Know
L
eading by innovation, Apress now offers you its SuperIndex , a turbocharged
companion to the fine index in this book. The Apress SuperIndex  is a keyword
and phrase-enabled search tool that lets you search through the entire Apress library.
Powered by dtSearch , it delivers results instantly.
Instead of paging through a book or a PDF, you can electronically access the topic
of your choice from a vast array of Apress titles. The Apress SuperIndex  is the
perfect tool to find critical snippets of code or an obscure reference. The Apress
SuperIndex  enables all users to harness essential information and data from the
best minds in technology.
No registration is required, and the Apress SuperIndex  is free to use.
1 Thorough and comprehensive searches of over 300 titles
2 No registration required
3 Instantaneous results
4 A single destination to find what you need
5 Engineered for speed and accuracy
6 Will spare your time, application, and anxiety level
Search now: http://superindex.apress.com