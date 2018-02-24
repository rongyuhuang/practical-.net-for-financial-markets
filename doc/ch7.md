                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                # 第七章 STP Interoperability
Activities undertaken in life are like a one-way transaction that has only a commit phase.
In the previous chapter, we discussed the role of an STP service provider. Each entity (such as the
broker, custodian, and fund manager) subscribes to the STP provider’s services, which use a prede-
fined format for communicating trade details. The entire trade takes place on the STP service provider’s
network. Several STP service providers exist in the settlement marketplace, and they compete with
each other for business. The challenging issue for the financial industry is to enable seamless inter-
operability between the various STP providers. To achieve this, you need a technology platform that
connects individual market participants and STP providers, understands their internal and external
business processes, and, most important, integrates their technologies. In this chapter, we will cover
how you can use Web services to enable STP, and we will briefly cover the various features of Web
services and how each of these components fits together to achieve interoperability in the STP world.
What Is Interoperability?
With the advent of multiple service providers, it becomes imperative that they communicate with
each other in an unbiased way so that trades originating in one network can be settled on a different
network if the entities involved in settling the trades are on different networks. The communication
between two or more service providers or components in an STP environment is called interoperability.
Regulators and industry associations ensure that seamless interoperability is in place in the interest
of brokers, custodians, and fund managers. In the absence of interoperability, only those networks
that had subscriptions from the largest and most influential institutions would attract more customers
and traffic. This would in turn create a vicious cycle, prevent competition from growing, and result
in a monopolistic situation. You can appreciate the need for interoperability by drawing an analogy
between STP service providers and mobile phone service providers in the telecom business. You
probably know that a single service provider in the mobile phone industry would not be a desirable
situation. Specifically, you wouldn’t have much choice over the services you get, the quality of services,
or even the rate at which you pay for services. It would be a take-it-or-leave-it kind of situation. Peo-
ple don’t like to be forced to subscribe to one service or continue to be associated with one service
provider. Therefore, having multiple service providers in the mobile phone industry is healthy for
subscribers. Now assume there was a constraint that subscribers from one network could not call
subscribers in other networks. This kind of restriction would be difficult to digest. In such situations,
though, multiple service providers would exist, but you would rarely get any choice. Whenever you
wanted a mobile telephone connection, you would have to see what service most of your contacts
used, and you would have to simply subscribe to that network. In this case, it is immediately obvious
that these networks should be in a position to talk to one another. Unless they talk to each other, you
would not be able to talk to all your contacts. And these conversations must be supported regardless
of which network the call originates from, which network the call utilizes as a mere carrier, and which
network the call finally terminates on. In this entire communication process, you would also expect
347348C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
Figure 7-1. Communication happens easily when all entities are on one network.
the call clarity to be intact, and as long as the conversation takes place effectively, you really wouldn’t
care which networks the call utilizes.
Similarly, in the STP marketplace, you expect the following:
Choice of service provider: As individuals we like to have control over who provides us with ser-
vice. We like to choose who provides us with a telephone connection and who provides us with
banking services. These choices are driven by parameters such as who is providing better services,
who guarantees deliveries, and which service provider is cost competitive. Institutions choose
their STP service providers in the same way. Some choose multiple service providers to have
a failover plan—just in case the services of one STP service provider is disrupted, the institution
can quickly switch to the other service provider without much loss in business. If interoperability
were not implemented, brokers/custodians would have to sign up with each service provider
and route the messages to the appropriate service provider where their final recipient resides.
Immediate delivery of trades: The timely delivery of trades is extremely crucial. Trades originating
from one network have to be delivered to the ultimate recipient such as the custodian/fund
manager immediately. The STP service provider has to ensure that congestions are forecasted
and managed efficiently.
Seamless communication: STP service providers have to talk to each other and exchange data
in a seamless way through predefined protocols. The user institution must not be saddled with
the responsibility of coding data in different formats and building additional logic for separate
networks. No additional service provider–specific hardware/software should be required.
Correct content delivery: Trades initiated from one network must be delivered to other networks
with correct content. Financial information is critical, and a small error can lead to a lot of losses
for the institutions involved.
In the examples discussed in the previous chapter about STP, we assumed only one service
provider. In such cases, it is simple to exchange messages between brokers, custodians, and fund
managers, because only one communication protocol is involved. The market entities’ back offices
are required to be configured to talk to only one STP service provider (see Figure 7-1).
We will now present another example that shows how STP interoperability works with several
service providers in place. Assume there are three STP service providers: A, B, and C. And assume
three market entities exist (see Table 7-1).
Table 7-1. Market Entities and Their STP Providers
Market Entity Classification Signed with Service Provider
X Fund Manager A
Y Broker B
Z Custodian CC H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 349
Figure 7-2. Communication flows freely with a communication protocol in place.
Also assume fund manager X gives orders for execution on the exchange to broker Y. Broker Y
will execute the order and will try to communicate the details to fund manager X. In this case, the
fund manager is with service provider A, and broker Y is with service provider B. If both service
providers don’t talk to each other, the message initiated by broker Y will not get delivered to fund
manager X.
Such an arrangement cannot work if there is no acceptable message format in which data will
be exchanged. In such cases, regulators and industry associations normally come forward to formu-
late messaging protocols that are followed by each entity in the market, including the STP service
providers. Once the messaging protocols get finalized, the market participants (brokers, fund man-
agers, and custodians) modify their back offices and make them capable for communication with
these protocols. Since all the entities understand these protocols, communication can take place
easily amongst various STP service providers (see Figure 7-2).
ISO 15022 is an acceptable communication protocol for achieving STP interoperability in several
countries.
Why Is Interoperability Required?
As discussed in Chapter 1, STP is an approach to settlement that will reduce the time taken for settling
transactions. Currently, settlements in U.S. equities markets happen on a T+3 basis. An ongoing effort
is taking place through STP to bring it down to T+1. This means if you trade today, your transactions
will get settled tomorrow. The task is enormous by any standard. STP will demand that a lot of the
manual processes be automated. Since the same trade needs to flow between the fund manager,
broker, and custodian and maybe even to the clearing corporation and depository, it is important
that all such entities connect to a common network.
A common network in turn raises a lot of issues. Who will own this network, who will set it up,
and who will manage it? Agencies such as exchanges or clearing corporations could be willing to set
it up, but they might not provide enough features to suit individual institutions. Just as in other
industries, having competition could be the answer. When multiple vendors exist, they will attempt
to provide superior services to attract customers. The STP network also needs to communicate with
the back offices of institutions; hence, it may also be desirable that one vendor provides a back office
as well as STP services.
This is the case for having multiple vendors providing STP services. But we actually argue for
having them on one network. Every vendor, however, has their own network. To achieve interoper-
ability, a protocol needs to exist that enables each STP network to communicate with other STP
networks.
Interoperability offers institutions the choice of having a preferred STP service provider. They
can also sign up with multiple vendors to have redundancy.350C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
Challenges in Achieving Interoperability
Although interoperability is highly desired, in many markets experience has shown that regulators
and industry associations have to make a large amount of effort to implement interoperability.
A variety of reasons exist for why interoperability does not take off on its own, especially in nonma-
ture markets:
High cost of enhancements/interface development: This problem arises in the early stages when
interoperability is implemented. Both STP service providers and their end customers have to make
a large amount of investments to achieve a common messaging protocol and handshaking. This is
more relevant for the first and early movers. A significant amount of investment is required for early
movers to establish policies and processes and put an infrastructure in place. Late adopters simply
learn from earlier adopters and hence have to invest less money. The entire industry thus adopts
a wait-and-watch policy for many initiatives, causing the initiative itself to not take off.
Lack of messaging protocol: Each STP service provider may have its own technology framework,
and there may not be any common protocol in which messaging takes place. Industry associa-
tions normally take the initiative in these cases, and they form committees to decide which
messaging protocol is best for that market. STP service providers in those markets then adopt
the decided messaging protocol as standard and implement interoperability using that standard.
Lack of common digital signature authentication process: When an STP service provider accepts
transactions to be delivered to someone in its network, it needs to be sure the transaction content
is digitally signed. Each STP service provider may sign up with a different certifying agency, giving
rise to a need for a common body that verifies these signatures and certifies that the messages are
genuine and can be accepted.
Other technology issues: Sometimes markets have agreed to a messaging protocol, but the back-
office solutions of brokers/custodians and fund managers are not compliant to the agreed
messaging formats. This gives rise to the need for the manual entry of data in such systems and
causes a break in the chain for STP, leading to errors and delays.
Poor service-level agreements and legal infrastructure: Every STP service provider enters into
a legal agreement with its customers for the delivery of messages. None of these service providers,
however, guarantees the delivery of messages terminating on other networks. Since a failure of
delivery means monetary loss that can at times be high, clients don’t accept the risk and con-
tinue to sign up with multiple service providers rather than signing up with one and risking the
delivery failure of a message and having no legal recourse.
High interconnectivity charges: Interconnectivity charges are charges that are levied to institutions
for messages they send that terminate on a network different from the network of origination.
Existing STP service providers levy high interconnect charges, especially to service providers that
are new to this business. This deters institutions from joining the new service provider. However,
strong regulatory guidelines exist for what interconnect charges can be levied and whether there
can be differential pricing in interconnectivity.
Vested interests: Large players in the STP space don’t want smaller vendors to come in and take
away their business.
Central to all of these problems is integration and interoperability between STP providers. To
resolve this, you need a computing platform that allows using industry standards but still takes advan-
tage of investments made in the existing system. Additionally, it must allow architecting systems in
a provider-neutral fashion where the external interface to the outside world is exposed using open
standard and protocols regardless of the operating system or programming environment used to
implement the core business logic. Such architectural style is important to survive in a highly dynamic
environment and also to expand the reach of the business, particularly when the activities inside
a business process demand a strong collaboration from its business partners. So, to meet this goal,
STP service providers must embrace service-oriented architecture (SOA) principles.C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 351
Figure 7-3. OMS components represented using service-oriented design
Introducing Service-Oriented Architecture
SOA represents an architectural style of identifying and packaging applications in the form of a service.
A service is an atomic processing unit that deals with a specific aspect of a business requirement.
Collectively, a service forms a service suite (services) that facilitates building an end-to-end business
solution. For example, Figure 7-3 identifies different pieces of an order management system and real-
izes them in the form of a service that is self-governed in nature. This idea of separating the business
concerns is not a new concept and already exists in the component programming world, but what
distinguishes the modern service-oriented approach (using Web services) is its ability to abstract
away the knowledge about the implementation platform, data format, or transport protocol used
by the service to communicate with its requestor. This is in contrast to the traditional distributed
architecture world where it is absolutely necessary to understand the platform-specific details in
order to leverage the functionality encapsulated inside a component. For example, if risk manage-
ment functionality is exposed as DCOM components, then it would be difficult for the Java world to
interoperate with it.
The modern SOA departs from the traditional architecture style and has characteristics that promote
the strong reuse of the existing application by wrapping it in the form of services. It also allows inter-
operability between services that are spread across different computing platforms. The following are
the important characteristics of SOA that make it so significant in today’s computing world:
Loose coupling: Loose coupling is one of the important characteristics of SOA; it means both
the service and its requestor are independent of each other’s implementation. The details of the
service are described through well-defined service metadata that outlines the business function-
ality, the structure of the message service’s send or receive, and the transport protocol used to
deliver messages. Furthermore, the content of the service description is laid out in a simple,
machine-readable format. Significantly, this means the service metadata is the glue that estab-
lishes the link between the service provider and its requestor and allows them to discover and
invoke functionality.352C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
Autonomous: SOA requires that an individual service be an autonomous application. It must
have complete control over its underlying processing logic. A service encapsulates logic that is
either a business task or some kind of computational-related task, but its requestor is always
shielded from its internal implementation. This proves to be highly flexible because it provides
room to evolve and grow the business logic without impacting its consumers. This concept of
autonomy is further applied to the message sent or received by the service. The service com-
municates using messages that are self-governed units and are platform agnostic. One valuable
aspect of message-level autonomy is it allows you to transparently introduce value-added fea-
tures such as message encryption, authentication, and so on.
Reusability: SOA promotes strong reusability both within the organization and outside the
organization. It is natural in the service-oriented world because of the individual service that is
designed to tackle a specific aspect of the business problem. Additionally, when an organization
starts bundling its existing system in the form of the services, this automatically results in wide-
spread reuse. So, by embracing SOA principles, an organization can easily integrate its modern
systems with existing legacy systems regardless of the underlying platform or implementation
language. This benefit of reuse will save organizations both time and money that otherwise
would have been mobilized in migrating this legacy system to a new platform.
Abstraction: A service describes its functionality using service metadata. Even though a service
internally must be using various business components that run on different platforms and
demand a strict formalism, all this complexity is totally hidden to the consumer of the service.
A service manages to abstract away the nitty-gritty details involved to achieve a specific busi-
ness goal and act as a facade to the outside world. This degree of abstraction establishes a new
service layer where the service acts as an entry point and coordinates among various internal
business processing components.
The characteristics highlighted previously are equally applicable to other distributed application
architectures; therefore, it is reasonable to wonder what makes SOA so different from the others.
The difference is that SOA (using Web services) is the first architecture to promote interoperability
from the inception stage. Moreover, SOA encourages organizations to leverage existing legacy systems,
which drastically reduces cost and yields higher productivity. The tenets of SOA are an abstract
architectural concept, and a technology implementation is needed that adheres to this principle
and allows organizations to design and build service-oriented systems. Web services are one such
implementation that lives up to the SOA expectation and provides a platform to build loosely cou-
pled business solutions.
Web Services
Web services represent a new paradigm for building distributed applications that use industry-
established open standards and protocols. They enable software components to be exposed as
services over standard communication protocols and use a standard data representation format to
exchange messages with consumers. They adopt XML as the key data exchange format and HTTP
as the data delivery protocol. Because of this ubiquitous infrastructure, Web services have attracted
the majority of organizations to follow the SOA path. With Web services, an organization can easily
achieve its EAI and business-to-business integration goals that were in the past always seen as major
hurdles. A much closer look at Web services will reveal that they provide the best of both the Web
and component-oriented worlds. They facilitate the seamless integration between applications that
are written in different languages and that run on different platforms. To fully understand Web services,
it is essential to first know its pillars, as depicted in Figure 7-4.C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 353
Figure 7-4. The pillars of Web services
The important characteristics of Web services are as follows:
Web services use XML as the data representation format: The simplicity of XML technologies not
only brought revolution in the Internet world but was also successful in establishing its place in
the service-oriented world. Its innate ability to capture both data and metadata in an ordinary
text format simplified the issues related to interoperability. It is through the use of XML that
Web services interact and exchange messages with consumers. This unique strength of XML
was soon realized by the industry, and it took the popularity of XML to a new height. Through
the use of XML, vendors authored several standard specifications that form a part of today’s
basic architecture of a Web service.
The Web service messaging framework is founded upon SOAP: SOA preaches a message-oriented
approach where the communication between a Web service and its consumer takes place by
sending messages to each other. A request message initiated by a Web service requestor includes
an action to be performed on the Web service along with the required data needed to support
this action. Similarly, a response message triggered by a Web service includes the result of the
action. To represent this interaction, a platform-agnostic messaging framework is required. As
a result, Simple Object Access Protocol (SOAP) was designed; it uses XML to structure and format
information. It is a highly extensible XML-based messaging framework designed to interoperate
with any computing platform.
Web services use WSDL to define service metadata: Web Services Description Language (WSDL)
is an XML document that defines the functionality offered by a Web service along with a list of
messages it sends and receives. WSDL is the heart of a Web service because it is the only source
of information provided to requestors in order to communicate with the service. Furthermore,
the information provided contains sufficient knowledge that enables the requester to know the
list of operations supported by the Web service, its physical location, the list of messages, and
its underlying data types.
Web services use HTTP as their primary transport protocol: With the advent of the Internet, we
were blessed with a new data delivery protocol that connected millions of systems across the
globe. HTTP is an Internet protocol that is simple and has been widely used. Web services use
HTTP to deliver SOAP messages. This combination of a ubiquitous Web protocol and language-
agnostic messaging framework provides a strong platform to build an interoperable solution.
Another important point is that the transport-level details are completely hidden from the Web
service; therefore, organizations are not restricted to HTTP. Instead, they can use any commu-
nication protocol that suits their business requirement. But the only reason proponents of Web
services advocate the use of HTTP is the inherent interoperability available off the shelf.354C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
WSDL
WSDL is the foundation of a Web service. It describes crucial information about the Web service
using XML vocabulary. The WSDL document contains the structure of messages, the data type of an
individual message, the order in which the messages are arranged and exchanged with consumers,
and the physical location of the Web service. Additionally, it contains details about the transport pro-
tocol used to deliver the message and the way messages are encoded over the wire. This aspect of WSDL
makes it possible for any consumer to establish communication with a Web service without even
knowing its internal implementation details. On the other hand, it achieves loose coupling and
interoperability between Web services and their consumers. From a consumer point of view, the
only critical information required is WSDL, which itself is described in a machine-readable format.
Furthermore, a deep dive into WSDL will disclose the important fact that it contains information
that is logically grouped into two parts: an abstract part and a concrete part.
The purpose of the abstract part is to define message-level characteristics that are independent
of any platform or language. Similarly, the concrete part binds the implementation-level details to the
abstract part; it describes the wire format of the message and the transport protocol used to deliver
it. This ability to describe the data used by the Web service without any reference to technology and
then dynamically bind it proves to be highly extensible. It provides multiple ways to interact with
a service. For instance, the same service can be exposed over the multiple communication channels
that are needed to achieve cross-platform interoperability.
■Note This section does not cover WSDL in detail, but the explanation is good enough for you to understand the
concept. Readers who want to further understand the nuts and bolts of individual elements can refer to the WSDL
specification at http://www.w3.org/TR/wsdl.
WSDL borrows from XML Schema, which makes it possible to define/validate it using any good
XML editor/parser. To give you a firsthand taste of WSDL, we have defined a WSDL document (see
Listing 7-1) that represents a slimmed-down feature of the order management system and exposes
the order submission functionality in the form of a Web service. This would enable a broker’s trad-
ing partners to connect their internal systems directly to the broker’s trading system.
Listing 7-1. WSDL Document for Order Management Web Service
<?xml version="1.0" encoding="utf-8"?>
<definitions xmlns:http="http://schemas.xmlsoap.org/wsdl/http/"
xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/"
xmlns:s="http://www.w3.org/2001/XMLSchema"
xmlns:s0="http://brokerxyz.com"
xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/"
xmlns:tm="http://microsoft.com/wsdl/mime/textMatching/"
xmlns:mime="http://schemas.xmlsoap.org/wsdl/mime/"
targetNamespace="http://brokerxyz.com" xmlns="http://schemas.xmlsoap.org/wsdl/">
<types>
<s:schema elementFormDefault="qualified"
targetNamespace="http://brokerxyz.com">
<s:element name="SubmitOrder">
<s:complexType>
<s:sequence>
<s:element minOccurs="0" maxOccurs="1" name="orderInfo"
type="s0:OrderInfo" />
</s:sequence>
</s:complexType>
</s:element>C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 355
<s:complexType name="OrderInfo">
<s:sequence>
<s:element minOccurs="0" maxOccurs="1" name="Instrument"
type="s:string" />
<s:element minOccurs="1" maxOccurs="1" name="BuySell"
type="s0:BuySellEnum" />
<s:element minOccurs="1" maxOccurs="1" name="Price" type="s:double" />
<s:element minOccurs="1" maxOccurs="1" name="Quantity" type="s:int" />
</s:sequence>
</s:complexType>
<s:simpleType name="BuySellEnum">
<s:restriction base="s:string">
<s:enumeration value="Buy" />
<s:enumeration value="Sell" />
</s:restriction>
</s:simpleType>
<s:element name="SubmitOrderResponse">
<s:complexType>
<s:sequence>
<s:element minOccurs="0" maxOccurs="1" name="SubmitOrderResult"
type="s:string" />
</s:sequence>
</s:complexType>
</s:element>
</s:schema>
</types>
<message name="SubmitOrderSoapIn">
<part name="parameters" element="s0:SubmitOrder" />
</message>
<message name="SubmitOrderSoapOut">
<part name="parameters" element="s0:SubmitOrderResponse" />
</message>
<portType name="OrderManagementServiceSoap">
<operation name="SubmitOrder">
<input message="s0:SubmitOrderSoapIn" />
<output message="s0:SubmitOrderSoapOut" />
</operation>
</portType>
<binding name="OrderManagementServiceSoap" type="s0:OrderManagementServiceSoap">
<soap:binding transport="http://schemas.xmlsoap.org/soap/http"
style="document" />
<operation name="SubmitOrder">
<soap:operation soapAction="http://brokerxyz.com/SubmitOrder"
style="document" />
<input>
<soap:body use="literal" />
</input>
<output>
<soap:body use="literal" />
</output>
</operation>
</binding>
<service name="OrderManagementService">
<port name="OrderManagementServiceSoap"
binding="s0:OrderManagementServiceSoap">
<soap:address
location="http://localhost/webservice3/OrderManagementService.asmx" />356C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
</port>
</service>
</definitions>
In Listing 7-1, the abstract part of WSDL is represented by the <types>, <message>, and <porttype>
elements, and the concrete portion is defined by the <binding>, <port>, and <service> elements.
The WSDL document describes the complete information about the Web service; in this case, it pro-
vides a business feature where any consumer (a broker’s trading partner) can directly submit an order
and in response get a unique order number that is later used to find out the status of the order. To
build this functionality, the first step is to define the structural characteristics of the message that
forms the abstract part of the service and is encapsulated inside the <types> element.
The <types> element defines the data type of the message sent or received by the Web service.
It relies on the grammar of the XML schema to define structural characteristics of the message, which
can range from a simple type element to a complex type element. This is a remarkable quality of
WSDL because instead of inventing its own type system, it directly adopted the industry-standard
XML Schema as its official type system language. The following XML fragment defines the structural
characteristics of the messages exchanged between a broker and his trading partners:
<types>
<s:schema elementFormDefault="qualified"
targetNamespace="http://brokerxyz.com">
<s:element name="SubmitOrder">
<s:complexType>
<s:sequence>
<s:element minOccurs="0" maxOccurs="1" name="orderInfo"
type="s0:OrderInfo" />
</s:sequence>
</s:complexType>
</s:element>
<s:complexType name="OrderInfo">
<s:sequence>
<s:element minOccurs="0" maxOccurs="1" name="Instrument"
type="s:string" />
<s:element minOccurs="1" maxOccurs="1" name="BuySell"
type="s0:BuySellEnum" />
<s:element minOccurs="1" maxOccurs="1" name="Price" type="s:double" />
<s:element minOccurs="1" maxOccurs="1" name="Quantity" type="s:int" />
</s:sequence>
</s:complexType>
<s:simpleType name="BuySellEnum">
<s:restriction base="s:string">
<s:enumeration value="Buy" />
<s:enumeration value="Sell" />
</s:restriction>
</s:simpleType>
<s:element name="SubmitOrderResponse">
<s:complexType>
<s:sequence>
<s:element minOccurs="0" maxOccurs="1" name="SubmitOrderResult"
type="s:string" />
</s:sequence>
</s:complexType>
</s:element>
</s:schema>
</types>C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 357
With the support of the XSD type system, we constructed the content of the request-response
message that will be accepted by the Web service. The request message maps to the structure of the
order, and its definition is enclosed inside the <SubmitOrder> element. Similarly, the response message
in this scenario represents a unique order number that is enclosed inside the <SubmitOrderResponse>
element. The elements declared inside <types> are then referenced by the <message> element, which
defines the actual composition of messages exchanged between a Web service and its consumer.
Here is what the <message> element looks like for the order management Web service:
<message name="SubmitOrderSoapIn">
<part name="parameters" element="s0:SubmitOrder" />
</message>
<message name="SubmitOrderSoapOut">
<part name="parameters" element="s0:SubmitOrderResponse" />
</message>
Messages represent abstract definitions of data and are composed of multiple parts. Individual
parts are described by one or more <part> child elements. Each <part> is tagged with a meaningful
name along with its underlying data type that references a simple or complex type defined under the
<types> element.
The next step is to group messages with the help of the <operation> element. This is analogous to
a method declaration in the object-oriented world. Each operation contains input and output messages
that are declared by the <input> and <output> constructs. The sequence in which the <input> and
<output> elements are laid out determines the message exchange pattern. For example, the SubmitOrder
operation described next represents a typical request-response message exchange pattern. An operation
that contains only <input> messages represents a one-way message exchange pattern.
With the help of the <operation> element, messages are grouped; the <operation> elements are
further grouped to form a <portType> element, which is the final leg of the abstract service definition.
The <portType> element, as follows, basically lists all the operations supported by the Web service:
<portType name="OrderManagementServiceSoap">
<operation name="SubmitOrder">
<input message="s0:SubmitOrderSoapIn" />
<output message="s0:SubmitOrderSoapOut" />
</operation>
</portType>
So far we have covered the abstract part of WSDL that represents Web service metadata in
a platform-agnostic fashion. But it is important to mention the implementation-level details about
how messages are formatted over the wire and the underlying transport protocol used to deliver the
message. This information is described inside a <binding> element. Here is what the <binding>
element looks like that uses SOAP to format messages and HTTP to deliver these messages:
<binding name="OrderManagementServiceSoap" type="s0:OrderManagementServiceSoap">
<soap:binding transport="http://schemas.xmlsoap.org/soap/http"
style="document" />
<operation name="SubmitOrder">
<soap:operation soapAction="http://brokerxyz.com/SubmitOrder"
style="document" />
<input>
<soap:body use="literal" />
</input>
<output>
<soap:body use="literal" />
</output>
</operation>
</binding>358C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
Figure 7-5. SOAP envelope
The final leg of a WSDL document is the declaration of the <service> element, which contains
<port> elements that supply the physical location of the Web service along with the appropriate
binding information:
<service name="OrderManagementService">
<port name="OrderManagementServiceSoap"
binding="s0:OrderManagementServiceSoap">
<soap:address
location="http://localhost/webservice3/OrderManagementService.asmx" />
</port>
</service>
This concludes the brief overview of various elements that collectively form a WSDL document.
It is interesting to see how WSDL is used to capture the structural aspect of the Web service purely in
terms of message interaction without disclosing any implementation-specific details; going further,
you will learn how tools are used by Web service consumers to read the service description and gen-
erate the appropriate implementation code to interact with the Web service.
SOAP
SOAP is the messaging communication framework used by Web services to send or receive messages.
The purpose of SOAP is to provide a standard wire format that allows binding on a variety of transport
protocols and is not tied to any particular language or platform. To meet this requirement, SOAP uses
XML technologies to construct messages. The key aspect of using SOAP is the simplicity it provides that
facilitates loose coupling between the Web service and its requestor. It achieves message-level autonomy
and provides a foundation to build higher-level application protocols. This results in the development of
other advanced features that are evidenced in various distributed systems such as encryption, authenti-
cation, and routing.
A SOAP message represents an interaction between a Web service and its requestor; both the
request and response messages use same SOAP structure. The structure of SOAP consists of a SOAP
envelope that contains three important elements: header, body, and fault (see Figure 7-5). Each message
contains a header element that is the primary driver behind SOAP extensibility. It records control infor-
mation about data; for instance, if the actual data is encrypted, then information about the encryption
algorithm such as its key size is recorded in the header. It is through the header element that Web ser-
vices are able to separate the infrastructure aspect from the functional part and modularize each in the
form of feature extensions that can then be composed by any Web service. The next element after the
header element is the body element. It is an XML container that stores the actual message payload. It is
a mandatory element, unlike the header element, that is optional. The last element is the fault element,
which provides a generic structure used by the Web service to notify the error information to the sender.C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 359
Although SOAP is able to codify messages with the help of header, body, and fault elements, two
important styles are prevalent in the SOAP messaging world. These styles dictate how to structure the
content enclosed inside these elements. The first style represents the traditional RPC style where
request-response messages are mapped in the form of a method name followed by method param-
eters. The second style represents modern document-style messages where the request-response
messages contain the actual XML document and whose format is defined by the sender and receiver.
The goal of the RPC style is to replace the proprietary protocol used by existing distributed applica-
tions and introduce a standard message format. But this initiative was not so widely welcomed and
also was complex to understand. Therefore, Web services adopted a document-centric approach
as its default style to exchange a message with its consumer.
Platform Infrastructure for Web Services
The concepts discussed so far regarding Web services such as SOAP and WSDL are specifications
and not technology platforms. A specification is a document that is jointly prepared by vendors in
order to achieve a common goal. The goal is to promote vendor-neutral communication and develop
systems using open protocols and standards. The benefits are that no single vendor has complete
control and that any significant changes in the specification require total consensus among vendors.
However, you need an infrastructure that understands this specification and provides both the
development and hosting platforms that would then allow you to build real-life business solutions
that are based on the tenets of SOA. The infrastructure must also provide a development tool to
build Web services using a suitable programming language. It must also have the ability to wrap the
existing business components and expose them in the form of Web services.
The Microsoft .NET Framework has been designed to support this kind of infrastructure and
offers strong development tools along with a reliable hosting platform. The framework provides
support for building Web services in any .NET-aware programming language such as Visual Basic,
C#, and so on. Furthermore, the CLR supplies so many goodies that it makes a developer’s life sim-
pler. The richness of the framework combined with the robustness provided by the CLR results in
a perfect platform to build Web services.
Figure 7-6 illustrates a high-level architecture view of the Web service platform implemented in
.NET. However, in reality there is no restriction on the selection of a platform; in other words, devel-
opers are free to choose any Web service platform.
Figure 7-6. High-level components of the Web service platform360C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
Regardless of which platform you select, you will always find the following basic software
components:
Transport unit: This component is responsible for all kinds of communication aspects associated
with Web services. It is bundled with various communication protocols that ensure the delivery
of messages from one endpoint to another. In the .NET world, this role is played by the IIS
server, and the communication between the Web service and its requestor is conducted using
HTTP.
Message-processing unit: This component is known as the message-handling engine because at
its core it is responsible for transforming and processing SOAP messages. It validates inbound
and outbound SOAP messages and ensures they adhere to SOAP standards. It is equally respon-
sible for dictating the wire-encoding format of the SOAP messages. In the .NET world, the Web
service framework provides this feature. Obviously, the framework does more than message
processing; one of the nice features it provides is an object-oriented abstraction over XML
messages. Developers never deal with the tedious task of framing SOAP messages; instead, with
the help of a declarative programming model, classes are decorated with the appropriate SOAP
serialization attributes. The goal of this framework is to hide most of the complexities involved
in creating a SOAP message. Additionally, the framework provides an extensibility hook that
further offers opportunities to construct various value-added services.
Business processing unit: This component houses the actual business logic that is executed on
receiving the request from the Web service consumer. There is no restriction on the use of the
technology, and the business logic implemented may be truly proprietary in nature.
By introducing the previous three units, we have explained the basic architectural foundation
of any Web service platform. Note that a vendor implementing such a platform may introduce addi-
tional layers, but the overall design characteristics will still revolve around the previously explained
software pieces. In the next section, we will show how to leverage the Microsoft Web service platform,
and you will see how easy it is to build your first Web service using Visual Studio .NET as the official
Web service development tool.
STP and Web Services
Web services will be the greatest catalyst for enabling STP in the financial industry. Today, most
financial firms depend upon both internal and external systems. Internal systems look after the
internal needs of the organization, and external systems look after the business-to-business inte-
gration aspects. Additionally, the implementations of systems are spread across various platforms.
So, in this scenario, the industry needs a platform that virtualizes all systems running inside and
outside an organization as one single coherent system. Web services address this need by providing
various industry standards that allow for the seamless integration between various systems. Using
Web services, organizations can easily integrate their existing and new systems with minimal devel-
opment effort; this will be the key incentive, and it will definitely entice a financial firm to participate
in STP. Essentially, STP will be realized only on a platform that connects individual organizations in
the financial industry, understands its internal and external business process, and integrates its
technology.C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 361
Figure 7-7. STP-Provider B invoking the STP-Provider A Web service
Now it is time to wet your hands with your first Web service code using Visual Studio .NET. Let’s
say you were assigned the responsibility of automating STP; mainly your goal is to establish a framework
to enable seamless, cross–STP provider integration. We already discussed the various problems
faced by STP providers in the absence of a common, standard communication protocol. From here
onward, we will show you step by step the implementation-level details, and at each step we will
discuss the features available in Web services and give you background information about how Web
services solve this problem.
The case study we will be explaining is based on Table 7-1 where the fund manager is registered
with STP-Provider A and the broker with STP-Provider B. In this scenario, both the fund manager
and the broker are registered with different STP providers. In order to enable seamless information
flow between the broker and the fund manager, both STP-Provider A and STP-Provider B need to
establish some form of communication medium. This will then allow the fund manager to submit
an order for execution on the exchange to the broker and similarly will allow the broker to commu-
nicate the execution details to the fund manager. The only way this flow will be successful is when
STP-Provider A (the fund manager’s STP provider) routes the order to STP-Provider B (the broker’s
STP provider), and this requires agreement between both these providers. So, we will demonstrate
how STP-Provider A and STP-Provider B use Web service technology to achieve this interoperability.
In Figure 7-7, you will notice post-execution interaction where the broker informs the fund man-
ager about the trade details in the form of a contract note. Although the market entities are omitted
in Figure 7-7, it is obvious that STP-Provider B, who is representing the broker, must somehow com-
municate the trade details to the fund manager via STP-Provider A. To support this interaction,
STP-Provider A will expose a Web service that allows sending contract note information to all mar-
ket entities falling under the STP-Provider A network in an interoperable fashion. This Web service
will then be invoked by STP-Provider B to submit contract note information destined for the fund
manager. STP-Provider A in Web service context is known as the service provider, and STP-Provider B
is known as the service consumer or service requestor.
To create a Web service, the first prerequisite is to install and start IIS from the Service Control
Panel. Keep in mind the steps we are discussing represent the activity performed by STP-Provider
A in order to expose the Web service. The next step is to launch Visual Studio .NET, and select File  
New   Project. This opens the New Project dialog box. Then, select ASP.NET Web Service in
the Templates area, as shown in Figure 7-8. Next, enter a suitable name for this project, such as
STPProvider. Click OK to create the project.362C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
By default Visual Studio .NET creates various files that make up the Web service; the most
important one to look at is the Web service file with the extension asmx (see Figure 7-9).
By double-clicking Service1.asmx, you will be provided with a code editor view, as depicted in
Figure 7-10.
Figure 7-9. STPProvider project structure
Figure 7-8. Web service project created using Visual Studio .NETC H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 363
You will now modify both the class name and filename so that they reflect the actual business
functionality they intend to offer to the consumer (see Figure 7-11).
Figure 7-10. Code editor view showing autogenerated Web service code364C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
Creating a Web service using Visual Studio .NET is easy; all you need to do is reference the
System.Web assembly and import the System.Web.Services namespace. Then, create a new class and
inherit it from System.Web.Services.WebService, which then automatically promotes it to a Web
service. After completing this step, the next procedure is to describe the functionality provided by
the service; you do this with the help of the WebMethod attribute decorated over the public method of the
class. Listing 7-2 shows the revised code of PostTradeService that enables the contract note
functionality.
Listing 7-2. Web Service Exposed by STP-Provider A
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
namespace STPProvider
{
public class ContractNoteInfo
{
public string Symbol;
public string Quantity;
Figure 7-11. Changing the Web service class name and filenameC H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 365
public string Price;
public BuySellEnum BuySell;
}
public enum BuySellEnum
{
Buy,
Sell
}
public class PostTradeService : System.Web.Services.WebService
{
public PostTradeService()
{
}
[WebMethod]
public int SubmitContractNote(ContractNoteInfo contractNote)
{
//Process the submitted information
return 0;
}
}
}
Notice that in Listing 7-2 a new operation, SubmitContractNote, is published by the Web service.
This method accepts the contract note information as an input message and returns an acknowl-
edgment number as an output message. ContractNoteInfo represents the contract note information.
You already know Web services communicate through XML messages, but Visual Studio .NET pro-
vides an object-centric approach to building Web services. To take advantage of this strong-typing
feature, Visual Studio .NET undertakes a lot of the complex steps and hides them from developers.
In simpler terms, with just a few lines of the previous code, you defined the WSDL document and
SOAP message structure. To construct this information, you need to compile the project by selecting
Build   Build Solution. The next step after compilation is to open Internet Explorer and retrieve the
WSDL document simply by visiting http://localhost/STPProvider/PostTradeService.asmx?wsdl.
This will fetch the complete information about the Web service, as shown in Listing 7-3.
Listing 7-3. WSDL for Web Service Exposed by STP-Provider A
<definitions xmlns:http="http://schemas.xmlsoap.org/wsdl/http/"
xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/"
xmlns:s="http://www.w3.org/2001/XMLSchema" xmlns:s0="http://tempuri.org/"
xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/"
xmlns:tm="http://microsoft.com/wsdl/mime/textMatching/"
xmlns:mime="http://schemas.xmlsoap.org/wsdl/mime/"
targetNamespace="http://tempuri.org/"
xmlns="http://schemas.xmlsoap.org/wsdl/">
<types>
<s:schema elementFormDefault="qualified"
targetNamespace="http://tempuri.org/">
<s:element name="SubmitContractNote">
<s:complexType>
<s:sequence>
<s:element minOccurs="0" maxOccurs="1" name="contractNote"
type="s0:ContractNoteInfo" />
</s:sequence>
</s:complexType>366C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
</s:element>
<s:complexType name="ContractNoteInfo">
<s:sequence>
<s:element minOccurs="0" maxOccurs="1" name="Symbol" type="s:string" />
<s:element minOccurs="1" maxOccurs="1" name="Quantity" type="s:int" />
<s:element minOccurs="1" maxOccurs="1" name="Price" type="s:double" />
<s:element minOccurs="1" maxOccurs="1" name="BuySell"
type="s0:BuySellEnum" />
</s:sequence>
</s:complexType>
<s:simpleType name="BuySellEnum">
<s:restriction base="s:string">
<s:enumeration value="Buy" />
<s:enumeration value="Sell" />
</s:restriction>
</s:simpleType>
<s:element name="SubmitContractNoteResponse">
<s:complexType>
<s:sequence>
<s:element minOccurs="1" maxOccurs="1" name="SubmitContractNoteResult"
type="s:int" />
</s:sequence>
</s:complexType>
</s:element>
</s:schema>
</types>
<message name="SubmitContractNoteSoapIn">
<part name="parameters" element="s0:SubmitContractNote" />
</message>
<message name="SubmitContractNoteSoapOut">
<part name="parameters" element="s0:SubmitContractNoteResponse" />
</message>
<portType name="PostTradeServiceSoap">
<operation name="SubmitContractNote">
<input message="s0:SubmitContractNoteSoapIn" />
<output message="s0:SubmitContractNoteSoapOut" />
</operation>
</portType>
<binding name="PostTradeServiceSoap" type="s0:PostTradeServiceSoap">
<soap:binding transport="http://schemas.xmlsoap.org/soap/http"
style="document" />
<operation name="SubmitContractNote">
<soap:operation soapAction="http://tempuri.org/SubmitContractNote"
style="document" />
<input>
<soap:body use="literal" />
</input>
<output>
<soap:body use="literal" />
</output>
</operation>
</binding>C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 367
<service name="PostTradeService">
<port name="PostTradeServiceSoap" binding="s0:PostTradeServiceSoap">
<soap:address location="http://localhost/STPProvider/PostTradeService.asmx" />
</port>
</service>
</definitions>
In Listing 7-3, notice how ContractNoteInfo type is represented in XSD form; similarly, employing
the WebMethod attribute over the SubmitContractNote method translates in the form of the <operation>
element, and arguments of this method are enclosed inside the <message> element. Certainly, you
can build the previous WSDL document by hand, but it would be lot of work and the chances of
human mistake are very high.
With the WSDL document in place, it can now be shared with the other STP providers
(STP-Provider B is one of them) who can then start building an appropriate interface to interact
with the Web service.
This completes the discussion of the STP-Provider A end; the next step is to build a service
consumer implementation that in this case is represented by STP-Provider B who will use the Web
service interface of STP-Provider A to submit contract note information received from the broker to
the fund manager.
In this example, we will assume both the Web service and its consumer are using the .NET
platform, and therefore STP-Provider B can use the wsdl command-line tool to generate what we
call a service proxy that emits a class based on a WSDL document. The proxy contains information
about the method and the type that is represented in the form of <operation> and <types> inside
WSDL. The intent of the proxy is to act as a mediator between the Web service and consumer and
hide the low-level details involved in composing the request or response message using SOAP.
To build a service consumer (STP-Provider B), you will create a new console project using
Visual Studio .NET, as illustrated in Figure 7-12.
After the project is successfully created, the next step is to add a Web service reference; you can
accomplish this task using the wsdl command-line tool. Alternatively, Visual Studio .NET provides
an easy-to-use wizard that automatically generates the proxy class that no doubt under the hood
Figure 7-12. Service consumer project created using Visual Studio .NET’s New Project dialog box368C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
uses the wsdl command-line tool. Additionally, the wizard also makes the necessary adjustments in
the existing project to add the newly created proxy class. Now to bring up the wizard, right-click the
project node, and select Add Web Reference. This opens the Search dialog box. In the Search dialog
box’s URL field, enter the physical location of the Web service, and click Go to continue. This will
display the list of operations supported by Web service, as depicted in Figure 7-13.
In Figure 7-13, after assigning a new Web reference name, you finally hook up this Web service
reference to your project. You must have figured it by now how simple it is to add Web service refer-
ences; it’s similar to adding a reference to a local assembly. But under the hood a new proxy class is
generated and included in the project. By default, the proxy class is hidden, but this doesn’t restrict
developers from looking at it. To view the code emitted by the proxy class, click the Show All Files
icon in Solution Explorer. This will expand the entire project hierarchy including the Web References
node, and you should see the proxy class beneath the individual Web references, as depicted in
Figure 7-14.
Figure 7-13. Add Web Reference dialog boxC H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 369
As you peek into the code of the proxy class, you will notice that it inherits from System.Web.
Services.Protocols.SoapHttpClientProtocol, which provides an object model to interact with the
Web service and also extend this model to programmatically manipulate SOAP request-response
messages. After the proxy is generated, the next step is to write the code to invoke the contract note
functionality exposed by the STP-Provider A Web service, as shown in Listing 7-4.
Listing 7-4. STP-Provider B Invoking STP-Provider A Web Service
using System;
namespace STPServiceConsumer
{
class ServiceConsumer
{
[STAThread]
static void Main(string[] args)
{
//instantiate Web service proxy
STPProvider.PostTradeService postTradeSvc = new
STPProvider.PostTradeService();
//prepare contract note information
STPProvider.ContractNoteInfo contractNote = new
STPProvider.ContractNoteInfo();
contractNote.Symbol = "MSFT";
contractNote.Price = 25;
contractNote.Quantity=100;
contractNote.BuySell = STPProvider.BuySellEnum.Buy;
//submit contract note information through Web service
int ackId =postTradeSvc.SubmitContractNote(contractNote);
//display the ack no. received from Web service
Console.WriteLine("Acknowledgement Id: " + ackId);
}
}
}
Figure 7-14. Solution Explorer showing the autogenerated proxy class created when adding a new
Web reference370C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
To test your first Web service, compile the code described in Listing 7-4 and then run the program.
You will see the output in Figure 7-15.
The program executed without any errors; STP-Provider B was able to submit a contract note
request to STP-Provider A and in response get an acknowledgment number. Clearly, with minimal
effort, you were able to build and test the Web service. The primary reason for this is the strong sup-
port provided by the .NET Framework and Visual Studio .NET. Without their support, it would have
been a difficult and time-consuming task.
STP Provider Consortium: Using UDDI
We demonstrated how STP-Provider A and STP-Provider B were able to shape and standardize both
the message and transport protocol details. Because of this, any consumer who understands WSDL
and SOAP can now directly communicate with STP-Provider A regardless of how proprietary the
STP-Provider A implementation platform is. So, for communication to take place, the first thing the
consumer must know is the exact location of the WSDL document. The example we illustrated
involved only two STP providers, but in reality there would be multiple STP providers offering the
same set of services in the STP space; it would be extremely difficult for the consumer to keep track
of the individual STP provider service descriptions and their Web service locations. To circumvent
this problem, you need a single well-known repository where information about the STP provider
and the services offered are published. It will support basic and advance search capability that will
be of tremendous value to consumers who can easily find a specific service that matches their busi-
ness requirement. Furthermore, you can think of the registry as an STP provider consortium where
the STP provider advertises itself along with its various service offerings.
To realize the STP provider consortium mission in the service-oriented world, what you need is
a registry that is based on service-oriented concepts. Universal Description, Discovery, and Integration
(UDDI) exactly fits this requirement (see Figure 7-16). It is a specification that describes a standard
way to publish, discover, and integrate Web services. It plays an important role in providing a reposi-
tory that not only contains technical information about Web services but also provides nontechnical
details. The nontechnical details consist of business addresses along with contact information,
geographic locations, and industry sectors. The role of the UDDI registry is just like a telephone
directory where information about businesses is registered, categorized, and finally made available
to the general public.
Figure 7-15. Console application demonstrating successful invocation of STP-Provider A Web serviceC H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 371
At a high level, UDDI captures the following information during the Web service registration
process:
Business entity: Represents Web service provider information that contains names, addresses,
and contact details
Business service: Represents services provided by the business entity
Binding template: Provides implementation-level information about how to initiate a commu-
nication with the Web service
One of the main benefits of using UDDI is that it facilitates the consumer to bind to Web ser-
vices at runtime simply by querying on any of the previous attributes, and on a successful match the
consumer will receive the Web service network endpoint. This behavior is possible because a cen-
tral repository exists, and one can use the UDDI API to find information by issuing an appropriate
query. The UDDI API is exposed in the form of a Web service, so it is clear that XML is the language
used to interact with the registry. Data structures are defined using XSD, and operations such as
service discovery and publishing are defined in terms of the SOAP message. Many APIs are available
in UDDI that are broadly classified under the discovery and publishing category. The discovery API is
intended to retrieve service information based on specific search criteria, and the publishing API
is intended to integrate service information with the registry. To invoke these APIs, you need to
understand and frame correct SOAP messages, but considering the scope of this section, it is not
possible to cover the individual message structure and operation of UDDI Web services. For readers
who want to gain further insight, visit www.uddi.org.
In a typical STP world, you will require a repository based on UDDI standards. Currently, you
have two options for building a UDDI repository. The first option is to host a private UDDI reposi-
tory, and in the Microsoft world only Windows 2003 servers natively support it. The second option is
to reserve a space in the public UDDI repository hosted by Microsoft (http://uddi.microsoft.com)
and IBM (http://www.ibm.com/services/uddi). There are no entry barriers, and any organization
can participate and register its Web services. Moreover, both IBM and Microsoft have provided a test
repository database that allows organizations to experiment before touching the real repository;
you can find these at http:/test.uddi.microsoft.com and https://uddi.ibm.com/testregistry/
registry.html. Figure 7-17 shows the Microsoft test site.
Figure 7-16. Illustrates how the UDDI repository is used by STP-Provider B to find the STP-Provider A Web
service372C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
With basic knowledge of UDDI, you are now ready to build the STP provider consortium, and
to achieve this, you will use the Microsoft test registry database. So, the first step is to publish the
Web service; to do this, you need to authenticate your identity using a Microsoft Passport account.
To ease this authentication process, we have created the following Passport credential especially for
this exercise:
  Passport account: stpinteroperability@hotmail.com
  Password: chapter7
To publish the Web service, click the Publish link; this will open the instruction page with a sign-in
icon; by clicking this icon, you will be redirected to the Passport login page. Enter the previous cre-
dential to get successfully authenticated. After you have been authenticated, you will be presented
with a page that enables you to register business- and service-related information, as shown in
Figure 7-18.
Figure 7-17. UDDI test Web siteC H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 373
The Providers tab is the starting point where individual STP providers are registered and are
asked to enter business and service details. Since you are using the test registry, you are allowed to
enter a maximum of only one provider, and it is created by default. Therefore, the only possible
option is to update the default provider details. To edit provider information, simply click View. You
will be presented with a new page, as shown in Figure 7-19.
Figure 7-18. Providers tab where new STP providers are registered374C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
Figure 7-20 reflects updated information about the provider.
Figure 7-19. Provider registration page with various other options represented in the form of tabsC H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 375
The important section of the provider information is the Services tab that exposes the service-
level details. It enables the STP providers to register Web service information along with the physical
location of the WSDL document. Also, there are no restrictions on the number of Web services that
are allowed to register. Figure 7-21 shows the details with a new service registered.
Figure 7-20. Provider registration page with updated details about STP-Provider A376C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
The Bindings tab records network endpoint details of the Web service and also a technical
description of the service including the WSDL document. For demonstration purposes, we entered
the URL of the PostTradeService Web service, as shown in Figure 7-22.
Figure 7-21. A new service registeredC H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 377
After entering binding information, you complete the service registration process and also
make this Web service endpoint information available to the outside world. Now, any consumer
who wants to know the Web service endpoint must first construct a proper query request and sub-
mit it to the registry. Even though the UDDI Web site provided by Microsoft and IBM already offers
a strong search capability that allows you to search for services based on business name, contact
details, and so on, it requires manual user intervention. What you need is a programmatic way of
integrating this search feature so that the application can dynamically select the implementation
of a service at runtime. To build this feature, it is simply a matter of understanding the UDDI request
and response XML structures and then using SOAP to submit them to the UDDI registry. There is
nothing wrong with this approach except it demands a precise understanding of the UDDI specifi-
cation. To simplify this task, Microsoft provides a managed .NET wrapper that ships with the UDDI
SDK; you can download it from http://msdn.microsoft.com.
The UDDI .NET SDK enables .NET applications to interact with the UDDI registry at runtime;
it also provides other goodies such as code samples and API documentation. The original motivation
of the UDDI SDK was to provide an object-oriented abstraction over UDDI messages, similar to the
one provided by Visual Studio .NET and the .NET Framework to create Web services. Using the UDDI
SDK, developers can perform both discover and publish Web services.
Now we will demonstrate an example of how to use the UDDI .NET assembly that will further
strengthen your understanding. In Listing 7-4, the location of the STP-Provider A Web service was
hard-coded inside the proxy file. Nowhere did you make a provision to read the Web service location
from an external source such as an application configuration file, which is the right way to do things.
But with the STP provider consortium in place, STP-Provider B knows a central repository exists that
Figure 7-22. Service registration page with updated information about PostTradeService378C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
provides all the necessary details required to handshake with the STP-Provider A Web service. Therefore,
the STP-Provider B program will directly use the UDDI SDK to retrieve this information, mainly the
network endpoint details of the Web service. Listing 7-5 illustrates how to handle this scenario.
Listing 7-5. STP-Provider B Using the UDDI API to Programmatically Determine STP-Provider A Web
Service Location
using System;
using Microsoft.Uddi;
using Microsoft.Uddi.Api;
using Microsoft.Uddi.Business;
using Microsoft.Uddi.Service;
using Microsoft.Uddi.Binding;
namespace STPConsortium
{
class ServiceConsumer
{
[STAThread]
static void Main(string[] args)
{
//instantiate Web service proxy
STPProvider.PostTradeService postTradeSvc = new
STPProvider.PostTradeService();
//prepare contract note information
STPProvider.ContractNoteInfo contractNote = new
STPProvider.ContractNoteInfo();
contractNote.Symbol = "MSFT";
contractNote.Price = 25;
contractNote.Quantity=100;
contractNote.BuySell = STPProvider.BuySellEnum.Buy;
//Fetch service endpoint information using UDDI
postTradeSvc.Url = GetServiceLocation();
//submit contract note through Web service
int contractNo =postTradeSvc.SubmitContractNote(contractNote);
//display contract no received from Web service
Console.WriteLine("Contract Note : " +contractNo);
}
public static string GetServiceLocation()
{
Console.WriteLine("Querying UDDI Registry...");
//Assign the network endpoint of UDDI Web services
Inquire.Url = "http://test.uddi.microsoft.com/inquire";
//Find the provider
FindBusiness findProvider = new FindBusiness();
findProvider.Names.Add("STP-Provider A");
BusinessList providerList = findProvider.Send();
BusinessInfo provider = providerList.BusinessInfos[0];
ServiceInfo providerService = provider.ServiceInfos[0];C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 379
//Find the service details
GetServiceDetail findService = new GetServiceDetail();
findService.ServiceKeys.Add(providerService.ServiceKey);
ServiceDetail sd = findService.Send();
BusinessService service = sd.BusinessServices[0];
BindingTemplate template = service.BindingTemplates[0];
//Retrieve the service URL
Console.WriteLine("Provider Endpoint : " +template.AccessPoint.Text);
return template.AccessPoint.Text;
}
}
}
To compile the program described in Listing 7-5, the UDDI .NET assembly needs to be referenced
from the GAC. Figure 7-23 displays the console output where the service endpoint information is
dynamically determined at runtime by querying the UDDI registry.
WS-Specification (WS-*)
You have learned how specifications such as WSDL, XML, XSD, SOAP, and UDDI offer a simple way
to build distributed applications and bring a sense of order and smoothness to envisioning an STP
platform where STP providers collaborate to offer various services in an interoperable fashion. Although
these basic Web service standards prove useful in addressing a simple business requirement, they
fail to handle a complex business scenario. For instance, the first concern raised by market partici-
pants who intend to transact in the Web service world is related to message security. Currently, you
can think of leveraging transport protocol security such as SSL or IPSec. This kind of transport-level
dependency will introduce a strong coupling between the Web service and its underlying transport,
but the truth of the matter is that the Web service technology is not affinitized to any particular trans-
port protocol. So, you require message-layer security that promises to bake security ingredients within
the actual message instead of wrapping them up, which is what SSL or IPSec does.
Currently, the basic Web Service stack depicted in Figure 7-24 faces several technology limita-
tions that restrict many financial organizations from embracing the Web service technology to its
fullest extent. Clearly, message security is one of them, but you will also notice lack of support for
problems that are linked to reliability and the transactional aspect of services. For the Web service
technology to make it into today’s STP mainstream, it is important that it addresses the QOS
Figure 7-23. Console application showing how STP-Provider A Web service endpoint information is
retrieved by querying the UDDI registry380C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
requirements needed to implement large-scale distributed systems. Furthermore, the goal must be
to define quality service requirements in a technology-neutral manner and enable organizations to
leverage them regardless of the underlying technology implementation. To address these requirements,
a team consisting of Microsoft, IBM, BEA Systems, and VeriSign was formed. The ultimate mission
of this team is to produce a set of specifications to incorporate various qualities of features required
to enable the widespread acceptance and implementation of Web services. WS-* was the output of
this collaboration effort.
WS-* is a collection of specifications that sit on top of the standard Web service specification.
WS-* is based on XML, SOAP, and WSDL and provides a first-class foundation to build such specifica-
tions in an interoperable and loosely coupled manner. WS-* is popularly known as second-generation
Web services because it extends the capabilities of basic Web service functionality to a new level
where it stands shoulder to shoulder with other popular distributed systems such as CORBA and
COM in terms of its feature set. The features offered by WS-* are already available in legacy distrib-
uted technology, but replicating this feature in the Web service world is a revolutionary step. WS-* is
composed of individual specifications, and each of these specifications is discrete and independent
of one another. For example, the WS-Security specification provides the building block for building
secure Web services. Similarly, the WS-Policy specification defines the rules and constraints of a Web
service. Each specification outlines a modular solution to a particular requirement of the business.
Web Services Enhancement (WSE) 2.0
Web Services Enhancement (WSE) is an add-on framework to the existing ASP.NET Web service platform
(see Figure 7-25). It is a development toolkit provided by Microsoft to integrate WS-* for building second-
generation Web services. It is similar to the ASP.NET Web service infrastructure that addresses the basic
requirement of Web services, but WSE is one step ahead and provides a programming model to use vari-
ous quality of service (QOS) features offered by WS-*. It is designed to be used with Visual Studio .NET,
which promises to bring higher productivity to a developer’s desk. Without the WSE toolkit, it would be
extremely time-consuming for developers to build WS-* features into an application; the developer
would first have to understand the minute details of each individual specification and then accordingly
build an implementation platform. WSE relieves developers from this effort by providing a developer-
friendly API and abstracts away the internal message-level complexities related to each specification.
Figure 7-24. Web service stackC H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 381
From an architectural perspective, WSE is a message-processing engine that can be used both
by the Web service and by its consumers. At the heart of the engine is the pipeline infrastructure that
orchestrates the processing of SOAP messages. The pipeline is constructed by chaining together
individual WSE filters. The idea behind filters is that they encapsulate the functionality of a particu-
lar specification of WS-*, which is then plugged into the pipeline. For example, WS-Security and
WS-Addressing will be realized in two separate filters. The work done by the filter mainly depends on
the direction of the message. For instance, if the nature of the message is inbound, then the respon-
sibility of processing is assigned to an inbound filter; similarly, if it is an outbound message, then it is
assigned to an outbound filter. The message processing and handling logic in both cases is completely
different. Inbound filters are dedicated to parsing incoming SOAP messages and then applying
specification-level processing. On other hand, outbound filters are dedicated to augmenting SOAP
messages with specification-level details. This also proves that each filter has complete control over
the message, and it can modify any part of a SOAP envelope. Often, a filter’s favorite shelter place is
the SOAP header where it records specification control information.
By modularizing specifications in the form of filters, WSE promotes higher extensibility because
filters can be easily added or removed from the pipeline. It also means as WS-* evolves there will be
new specifications rolled out, and to integrate them into the WSE platform, you need to develop an
appropriate filter and then integrate it with the pipeline. The overall goal of WSE is to provide develop-
ers with a lot of power to deal with individual specifications by using a set of classes instead of directly
interfacing with low-level message details that are cumbersome and prone to human error. However,
WSE currently doesn’t yet support the entire gamut of WS-*. One of the reasons is that most of the
specifications are still evolving, and there is a high possibility that WSE may undergo several rounds
of changes before it appears in the commercial world. Therefore, Microsoft bundled WSE with the
most popular specifications such as WS-Security, WS-Policy, WS-Addressing, WS-Attachments,
WS-Referral, WS-SecureConversation, and WS-Trust.
To start using WSE, you need to install the WSE 2.0 development kit, which is freely downloadable
from the MSDN Web Services Developer Center. During the installation phase, you will be provided
with various set-up types; you should choose the Visual Studio Developer option, which installs WSE
runtime files and documentation and integrates with the Visual Studio .NET IDE (see Figure 7-26).
Figure 7-25. WSE architecture382C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
Assuming installation went through successfully, then you can begin to set up the WSE develop-
ment environment. By choosing the Visual Studio Developer option during the installation stage, you
install an additional GUI tool exclusively meant to specify WSE settings. This tool is available inside
Visual Studio .NET and is activated by right-clicking the project in Solution Explorer and selecting
WSE Settings 2.0, as illustrated in Figure 7-27.
Figure 7-28 shows the WSE settings dialog box with the various configuration information
organized in tabs. Each tab relates to information specific to a particular Web service specification
supported by WSE. The most important one is the General tab, which is used to enable WSE support
Figure 7-26. WSE set-up options
Figure 7-27. Menu to invoke the WSE Configuration dialog boxC H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 383
in the project. To trigger this support, check the Enable This Project for Web Services Enhancements
box. After checking this box, the tool automatically reconfigures the project settings to reference the
Microsoft.Web.Services2 assembly from the GAC. Another immediate impact is a change in the
application configuration file: a new section, <microsoft.web.services2>, is added especially to
record WSE-related configuration settings.
We demonstrated how to enable WSE support in Visual Studio .NET, but you still need to do
a bit more tweaking. You need to marry the basic Web service infrastructure with the advanced
infrastructure provided by WSE. So, obviously, you would expect both the Web service and its con-
sumer to be affected by this change. Assuming the Web service is built on the ASP.NET infrastructure,
which is very true in this case, then it is mandatory to check the Enable Microsoft Web Services
Enhancement Soap Extensions box. This step integrates the WSE pipeline processing model with the
ASP.NET infrastructure, which allows WSE filters to intercept the inbound/outbound message and
perform the necessary actions on it. On the other hand, if WSE is enabled on the service consumer
end that interacts with the Web service using a proxy class, then you need to update the base class
of the proxy. As you are aware, the proxy class is generated whenever a new Web reference is added
to the project, so the proxy base class change discussed is not required in the case of a new Web refer-
ence because Visual Studio .NET automatically creates WSE-aware proxy classes. It is required only
when the existing proxy class needs to be changed. To implement this, you need to modify the base
Figure 7-28. WSE settings dialog box384C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
class, System.Web.Services.Protocols.SoapHttpClientProtocol, from which the proxy class inherits
to Microsoft.Web.Services2.WebServicesClientProtocol. After applying this modification, the service
consumer is fully compliant with WSE.
After making the changes recommended in this section, you are now ready to embrace the WSE
class library in your code. In fact, you will notice how easy it is to configure the project to use the
WSE framework both from the Web service and from its consumer. Going forward, you will also
observe how WSE has simplified many of the coding-related tasks with the help of wizards. There is
absolutely no doubt that WSE comes as a boon to organizations that intend to enter the Web service
world. Without WSE support, organizations would have shown a lukewarm response because in the
past couple of years there has been a huge surge in the number of Web service specifications proposed
by vendors. This raised fear among many organizations because there has not been a single imple-
mentation platform that supports this specification; but then Microsoft stepped in and showed its
commitment by periodically releasing new versions of WSE. In the upcoming section, we will dig in
further to the programming level and cover some of the popular specifications supported by WSE.
Although it is impossible to cover all aspects of individual specifications in detail, our goal is to give
you a basic understanding of the important specifications.
WS-Security
The biggest concern raised by financial organizations is how to protect the sanctity of information
exchanged with business partners. In broader terms, organizations want a guarantee that transactions
conducted over a public network are safe and protected from eavesdroppers’ eyes. Organizations
encounter many aspects of security such as integrity, confidentiality, and nonrepudiation when they
work across public networks. We have already covered this topic in Chapter 6; the domain problem
we are addressing here is different. What you need is an interoperable approach for integrating
security features. We already demonstrated the use of basic Web service technology to interconnect
various STP providers in the STP world, but the environment in which these STP providers live is com-
plex and hostile in nature. They need additional sophisticated QOS, and message security is one of
these attributes. You could propose or employ a transport-level security such as SSL or IPSec to
protect Web services, but this assumption breaks the fundamental rule of transport neutrality.
Although SSL and IPSec might provide in-transit integrity, they do not have the capability to provide
end-to-end message security. Additionally, for Web services to get maximum mileage, it is essential
that they support security as part of their basic technology infrastructure. As a result, Microsoft and
IBM collaborated and came up with the new WS-Security specification.
WS-Security provides a foundation to enable security in Web services. This specification aims
to integrate important attributes of security such as encryption, authentication, and digital signing
in an interoperable and technology-neutral manner. It provides a standard mechanism to package
and transport security-related information using SOAP and XML. Its goal is not to replace the existing
security infrastructure; instead, it provides a unified framework to leverage various security models
such as Kerberos and Public Key Infrastructure (PKI). The specification clearly outlines the list of
changes required for adding security to SOAP messages. Without going into too much detail, read-
ers interested to know more about WS-Security can refer to http://docs.oasis-open.org/wss/2004/
01/oasis-200401-wss-soap-message-security-1.0.pdf.
Returning to the WS-Security specification, you will notice three important XML elements that
form part of a WS-Security–enabled SOAP header. The first is the security token that represents
authentication information also known as a claim. The second is the signature element that contains
the digital signature of the message enclosed inside the body element of the SOAP envelope. The
final element is the encryption element that contains an encrypted version of the original message.
Together these three elements form the foundation of the WS-Security message structure (see
Figure 7-29).C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 385
The next step is to focus on how to implement WS-Security features using WSE. To date, WSE is
the first toolset to provide comprehensive support for implementing the WS-Security specification.
To drive WS-Security in the STP world, you have to leverage its digital signature and encryption capa-
bility. Assuming STP providers have adopted a common medium of information exchange using the
Web service platform, then the need for implementing digital certificates to meet authentication and
message integrity purposes becomes apparent. Therefore, the next example beginning with a digital
signature will show you how to implement this QOS in an interoperable manner using WSE 2.0.
The first prerequisite needed for the success of this scenario is a digital certificate. Digital
certificates, as explained in Chapter 6, are the most reliable way to prove one’s identity. Therefore, it
makes sense to make it part of regulatory rule that individual market participants and STP providers
in the STP world own a digital certificate that not only proves their identities but also is used to securely
protect the integrity of a message. Getting a certificate is a formal process that requires the approval
of a CA such as VeriSign. But for demonstration purposes, we will use the makecert tool to generate
a self-signed certificate:
makecert -n "CN=STP-Provider A" -ss My -sr currentuser
-sp "Microsoft Enhanced Cryptographic Provider v1.0" -sky exchange
-sk "STP-Provider A Key Container"
makecert -n "CN=STP-Provider B" -ss My -sr currentuser
-sp "Microsoft Enhanced Cryptographic Provider v1.0" -sky exchange
-sk "STP-Provider B Key Container"
Execute the previous command under the Visual Studio .NET command prompt. This will gen-
erate two certificates and store them in a central location known as a certificate store. The certificate
store is a physical repository that looks after the management of certificates. Each individual user or
Windows service or machine can have its own certificate store. Additionally, each store is logically
divided into a store category; there is always a Personal category, also known as a My category, used
to store personal certificates. The two certificates recently generated are stored under the current
user certificate store and available in the Personal category of that store. To view these certificates,
launch the MMC, and add the Certificates snap-in that displays certificates according to their storage
characteristics; in this case, it is the currently logged-in user. It also displays the category information
about the store. Figure 7-30 depicts the certificates snap-in, which is a GUI tool to store, enumerate,
delete, and verify certificates.
Figure 7-29. Using WS-Security to secure SOAP message386C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
This completes the certificate installation process. Both STP-Provider A and STP-Provider B
certificates are installed under the Personal category of the current user store. To reiterate, the STP-
Provider A is the actual service provider, and STP-Provider B, which is a service provider, in this context
plays the role of a service consumer that forwards the contract note information to STP-Provider A.
The next step is to write the code implemented on the service consumer end: STP-Provider B. The
overall goal of this code example is to secure the contract note information submitted by STP-Provider B
to STP-Provider A using a digital signature. To start, you need to perform the following steps:
1. Create a new console application called SecureSTPConsumer using Visual Studio .NET.
2. Enable WSE 2.0 support for this project using the WSE GUI tool. This will automatically add
a reference to the Microsoft.Web.Services2 assembly.
3. Add a Web reference to the STP-Provider A Web service at http://localhost/STPProvider/
PostTradeService.asmx. A WSE-aware proxy class will be automatically generated and
added to the project. The final project structure must look like Figure 7-31.
Figure 7-30. Certificate storeC H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 387
4. Update the application configuration file; the <x509> element specifies how WSE verifies the
certificate. Without this setting, WSE will raise an exception because a test root signs the test
certificates. To instruct WSE to honor the certificates signed by the test root, the following
changes are required:
<configuration>
<configSections>
<section name="microsoft.web.services2"
type="Microsoft.Web.Services2.Configuration.WebServicesConfiguration,
Microsoft.Web.Services2, Version=2.0.0.0, Culture=neutral,
PublicKeyToken=31bf3856ad364e35" />
</configSections>
<microsoft.web.services2>
<security>
<x509 allowTestRoot="true"/>
</security>
<diagnostics />
</microsoft.web.services2>
</configuration>
Now that you have completed the necessary configuration-related changes required on the
consumer (STP-Provider B) end, the final step is to write code that digitally signs the contract note,
as shown in Listing 7-6.
Listing 7-6. STP-Provider B Digitally Signing Contract Note Information, Before Forwarding to
STP-Provider A
using System;
using System.Net;
using Microsoft.Web.Services2;
using Microsoft.Web.Services2.Security;
using Microsoft.Web.Services2.Security.Tokens;
using Microsoft.Web.Services2.Security.X509;
Figure 7-31. Solution Explorer view of the consumer applicationnamespace SecureSTPConsumer
{
class ServiceConsumer
{
[STAThread]
static void Main(string[] args)
{
STPProvider.PostTradeServiceWse postTradeSvc= new
STPProvider.PostTradeServiceWse();
STPProvider.ContractNoteInfo contractNote = new
STPProvider.ContractNoteInfo();
//Digitally Sign the Contract Note
SignContractNote(postTradeSvc);
//Create new contract info, and submit it to the STP-Provider A Web service
contractNote.Symbol = "MSFT";
contractNote.Price = 25;
contractNote.Quantity=100;
contractNote.BuySell = STPProvider.BuySellEnum.Buy;
int ackId =postTradeSvc.SubmitContractNote(contractNote);
//Verify the response received from STP-Provider A
VerifyAckResponse(postTradeSvc);
Console.WriteLine("Acknowledgement ID : " +ackId);
}
public static bool VerifyAckResponse(STPProvider.PostTradeServiceWse
postTradeSvc)
{
SoapContext respCtx = postTradeSvc.ResponseSoapContext;
//Iterate through all Security elements
foreach(ISecurityElement secElement in respCtx.Security.Elements)
{
//Check whether message is digitally signed
if ( secElement is MessageSignature)
{
MessageSignature signature = (MessageSignature)secElement;
X509SecurityToken signingToken = signature.SigningToken
as X509SecurityToken;
//Authenticate the Sender using any one of the attributes of Certificate
//More secure way is to verify using the STP-Provider A public key
if ( signingToken != null &&
signingToken.Certificate.FriendlyDisplayName == "STP-Provider A" )
{
return true;
}
}
}
return false;
}
388C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Ypublic static void SignContractNote(STPProvider.PostTradeServiceWse
postTradeSvc)
{
//Open the current user certificate store, and look for Personal category
X509CertificateStore localStore =
X509CertificateStore.CurrentUserStore(X509CertificateStore.MyStore);
localStore.OpenRead();
//Find STP-Provider B Certificate
X509CertificateCollection certCollection =
localStore.FindCertificateBySubjectString("STP-Provider B");
X509Certificate provCert = certCollection[0];
//Create a new security token that is of X509 type
//Token represent claim (authentication information)
X509SecurityToken token = new X509SecurityToken(provCert);
postTradeSvc.RequestSoapContext.Security.Tokens.Add(token);
//Instruct WSE inbound filter to sign the message before it is transmitted
//over the wire
//The signature is computed based on a security token
postTradeSvc.RequestSoapContext.Security.Elements.Add(
new MessageSignature(token));
}
}
}
In Listing 7-6, you will notice how easy it is to integrate the digital signature functionality. The
important thing in Listing 7-6 is the namespaces that are imported in this project.
WSE outlines a straightforward approach by naming individual namespaces based upon the
specification supported by them. For instance, classes that correspond to WS-Security are grouped
under Microsoft.Web.Services2.Security. Stepping into the heart of the WSE class framework, you
will find SoapContext, which represents an object-oriented representation of the SOAP message. It
allows you to inspect the header and body of incoming SOAP messages. For outgoing SOAP messages,
it provides the capability to record specification-level information both at the header level and at
the body level.
Now that you have STP-Provider B that uses WS-Security to digitally sign the contract note
information, the next step is to reconfigure the STP-Provider A Web service to recognize this digital
signature and accordingly authenticate the sender of the message in addition to verifying the integrity
of the message. To incorporate these changes, you need to slightly modify the STP-Provider A ASP.NET
Web service project as follows:
1. Open the existing ASP.NET Web service project STPProvider (the STP-Provider A Web service)
using Visual Studio .NET.
2. Enable WSE 2.0 support for this project using the WSE GUI tool. Remember, this is an ASP.NET
Web service project, so you need to also enable Microsoft WSE SOAP extensions.
3. Update the web.config file; the <x509> element is added that specifies how WSE verifies the
certificate. Also, a few additional settings are specific to the authentication mechanism of
the ASP.NET application. By default, the ASP.NET application is executed under the security
context of the ASPNET user account, which has limited privileges. To get around this prob-
lem, you can tweak the configuration file to impersonate the currently logged-in user:
<?xml version="1.0" encoding="utf-8"?>
<configuration>
<configSections>
C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 389390C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
<section name="microsoft.web.services2"
type="Microsoft.Web.Services2.Configuration.WebServicesConfiguration,
Microsoft.Web.Services2, Version=2.0.0.0, Culture=neutral,
PublicKeyToken=31bf3856ad364e35" />
</configSections>
<system.web>
<identity userName=<Logged in user id> password=<Logged in user Password>
impersonate="true" >
</identity>
<webServices>
<soapExtensionTypes>
<add type="Microsoft.Web.Services2.WebServicesExtension,
Microsoft.Web.Services2, Version=2.0.0.0, Culture=neutral,
PublicKeyToken=31bf3856ad364e35" priority="1" group="0" />
</soapExtensionTypes>
</webServices>
</system.web>
<microsoft.web.services2>
<security>
<x509 allowTestRoot="true"/>
</security>
</microsoft.web.services2>
</configuration>
After the previous configuration changes have been updated successfully, then you are ready to
update the Web service that will verify the digital signature received from STP-Provider B. The code
will also include a modification to digitally sign the response message using the STP-Provider A cer-
tificate, which is then returned to STP-Provider B. Listing 7-7 shows how to achieve this functionality.
Listing 7-7. STP-Provider A Digitally Verifying the Contract Note Information Submitted by STP-
Provider B and Digitally Signing the Response Message Sent to STP-Provider B
using System;
using System.IO;
using System.Threading;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using Microsoft.Web.Services2;
using Microsoft.Web.Services2.Security;
using Microsoft.Web.Services2.Security.Tokens;
using Microsoft.Web.Services2.Security.X509;
namespace STPProvider
{
public class ContractNoteInfo
{
public string Symbol;
public int Quantity;
public double Price;
public BuySellEnum BuySell;
}
public enum BuySellEnum
{C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 391
Buy,
Sell
}
public class PostTradeService : System.Web.Services.WebService
{
public PostTradeService()
{
}
[WebMethod]
public int SubmitContractNote(ContractNoteInfo contractNote)
{
//Verify the Sender Information ( STP-Provider B)
VerifySignatureOrigin();
//Send the digitally signed response to STP-Provider B using STP-Provider A
//Certficate.
SignAckResponse();
return 1;
}
public void SignAckResponse()
{
//Open the current user certificate store, and look for Personal category
X509CertificateStore localStore =
X509CertificateStore.CurrentUserStore(X509CertificateStore.MyStore);
localStore.OpenRead();
//Find STP-Provider A Certificate
X509CertificateCollection certCollection =
localStore.FindCertificateBySubjectString("STP-Provider A");
X509Certificate provCert = certCollection[0];
//Create a new security token that is of X509 type
//Token represent claim (authentication information)
X509SecurityToken token = new X509SecurityToken(provCert);
ResponseSoapContext.Current.Security.Tokens.Add(token);
//Instruct WSE outbound filter to sign the message before it is transmitted
//over the wire
//The signature is computed based on a security token
ResponseSoapContext.Current.Security.Elements.Add(new
MessageSignature(token));
}
public bool VerifySignatureOrigin()
{
SoapContext reqCtx = RequestSoapContext.Current;
//Iterate through all Security elements
foreach(ISecurityElement secElement in reqCtx.Security.Elements)
{
//Check if message is digitally signed
if ( secElement is MessageSignature)
{MessageSignature signature = (MessageSignature)secElement;
X509SecurityToken signingToken = signature.SigningToken
as X509SecurityToken;
//Authenticate the Sender using any one of the attributes of Certificate
//More secure way is to verify using STP-Provider B public key
if ( signingToken != null &&
signingToken.Certificate.FriendlyDisplayName == "STP-Provider B" )
{
return true;
}
}
}
return false;
}
}
}
In Listing 7-7 not even a single line of code does the verification of the digital signature. This
verification process is automatically built into the WSE framework. As you might you have guessed,
the Web service doesn’t have to write any code to verify the signature, but it is definitely interested
in knowing the outcome of the verification process. First, if the signature is tampered with, it will
ultimately fail the verification process, and then WSE raises a SOAP exception and communicates to
the sender of the message. Otherwise, WSE populates the instance of SoapContext with the sender
certificate information and invokes the Web service method.
Clearly, WSE abstracts away most of the coding complexities usually encountered during the
message signing and verification process. In the absence of WSE, developers will be forced to
accomplish this task manually, which is certainly prone to human errors. Building on WS-Security,
WSE makes it easy to implement security. Digital signature capability is one aspect of WSE; it also
supports encryption technology. Using encryption technology, SOAP messages are protected from
prying eyes; this is a big leap from transport-level security to message-level security. Fortunately,
WSE supports asymmetric encryption, and you will see how easy it is to include it in the existing
code example.
For asymmetric encryption to work, STP-Provider B has to use the STP-Provider A public key to
encrypt the message. This will ensure that only STP-Provider A, who is in possession of the private
key, will be able to decrypt the message. On the Web service end, STP-Provider A, after the success-
ful decryption of the message, encrypts the response message using the STP-Provider B public key.
Again, only STP-Provider B, who owns the private key, will be able to interpret this message correctly.
The following code describes how STP-Provider B encrypts the contract note information using the
STP-Provider A public key:
using System;
using System.Net;
using Microsoft.Web.Services2;
using Microsoft.Web.Services2.Security;
using Microsoft.Web.Services2.Security.Tokens;
using Microsoft.Web.Services2.Security.X509;
namespace SecureSTPConsumer
{
class ServiceConsumer
{
[STAThread]
static void Main(string[] args)
{
392C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T YSTPProvider.PostTradeServiceWse postTradeSvc= new
STPProvider.PostTradeServiceWse();
STPProvider.ContractNoteInfo contractNote = new
STPProvider.ContractNoteInfo();
//Encrypt the Contract Note Information
EncryptContractNote(postTradeSvc);
//Create new contract info. and submit it to STP-Provider A Web service
contractNote.Symbol = "MSFT";
contractNote.Price = 25;
contractNote.Quantity=100;
contractNote.BuySell = STPProvider.BuySellEnum.Buy;
int ackId =postTradeSvc.SubmitContractNote(contractNote);
Console.WriteLine("Acknowledgement ID :" + ackId);
}
public static void EncryptContractNote(STPProvider.PostTradeServiceWse
postTradeSvc)
{
//Open the current user certificate store, and look for Personal category
X509CertificateStore localStore =
X509CertificateStore.CurrentUserStore(X509CertificateStore.MyStore);
localStore.OpenRead();
//Find STP-Provider A Certificate
X509CertificateCollection certCollection =
localStore.FindCertificateBySubjectString("STP-Provider A");
X509Certificate provCert = certCollection[0];
//Create a new security token that is of X509 type
//Token represent claim (authentication information)
X509SecurityToken token = new X509SecurityToken(provCert);
postTradeSvc.RequestSoapContext.Security.Tokens.Add(token);
//Instruct WSE inbound filter to encrypt the message before it is
//transmitted over the wire
postTradeSvc.RequestSoapContext.Security.Elements.Add(new
EncryptedData(token));
}
}
}
On the STP-Provider A end, when the Web service examines the SOAP header and determines
that the actual message is encrypted, it retrieves the correct private key associated with the certifi-
cate used by STP-Provider B to encrypt the message and finally decrypts the message. If decryption
happens successfully, then the Web service method is invoked. Otherwise, a SOAP fault is raised
and communicated to the sender. Assuming decryption went through without any problems, then
STP-Provider A constructs the acknowledgment confirmation message, encrypts it using the STP-
Provider B public key, and forwards it to STP-Provider B. The following are the code modifications
required on the STP-Provider A end:
using System;
using System.IO;
C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 393394C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
using System.Threading;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using Microsoft.Web.Services2;
using Microsoft.Web.Services2.Security;
using Microsoft.Web.Services2.Security.Tokens;
using Microsoft.Web.Services2.Security.X509;
namespace STPProvider
{
public class ContractNoteInfo
{
public string Symbol;
public int Quantity;
public double Price;
public BuySellEnum BuySell;
}
public enum BuySellEnum
{
Buy,
Sell
}
public class PostTradeService : System.Web.Services.WebService
{
public PostTradeService()
{
}
[WebMethod]
public int SubmitContractNote(ContractNoteInfo contractNote)
{
//Encrypt the Response
EncryptAckResponse();
return 1;
}
public void EncryptAckResponse()
{
//Open the current user certificate store, and look for Personal category
X509CertificateStore localStore =
X509CertificateStore.CurrentUserStore(X509CertificateStore.MyStore);
localStore.OpenRead();
//Find STP-Provider B Certificate
X509CertificateCollection certCollection =
localStore.FindCertificateBySubjectString("STP-Provider B");
X509Certificate provCert = certCollection[0];C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 395
//Create a new security token that is of X509 type
//Token represent claim (authentication information)
X509SecurityToken token = new X509SecurityToken(provCert);
ResponseSoapContext.Current.Security.Tokens.Add(token);
//Instruct WSE inbound filter to encrypt the message before it is
//transmitted over the wire
ResponseSoapContext.Current.Security.Elements.Add(new EncryptedData(token));
}
}
}
The code for encrypting/decrypting a SOAP message is no different from the digital signing/
verification code. Both share many similarities, mainly from a programmatic perspective; however,
when it comes to actual execution, they emit completely different behavior. The important thing to
take away from this brief tour of WS-Security is that it establishes a standard mechanism to protect
a SOAP message, and it is a big step forward in promoting Web services in the STP world.
WS-Policy
The interaction between a service provider and a service requestor is deemed successful only when
information provided by the requestor is complete and meets the provider expectation. The level of
expectation depends directly upon the level of information shared by the service provider to its
requestor. In a service-oriented environment, you already have WSDL that fleshes out the details of
the functional description of the Web service published by the service provider to its requestor. How-
ever, WSDL falls short when it comes to outlining the nonfunctional characteristics of a Web service. For
example, based on the STP-Provider A WSDL, you have no way to find out the quality of services,
such as message signing or encryption. Additionally, STP-Provider A will enforce its own domain-level
rules and constraints when accepting messages from other STP providers. This kind of information
can be communicated only through documentation or some other communication channel. To close
this gap, the specification WS-Policy was released (see Figure 7-32).
Figure 7-32. Using WS-Policy to enforce constraints and rulesWS-Policy allows you to associate rules and constraints to a Web service in an interoperable
manner. It complements WSDL by separating out the nonfunctional aspects of a Web service. It is
a general-purpose framework to formalize various kinds of policies within a Web service. Each of
these specific policies encodes a discipline that needs to be enforced during the message-processing
stage. For example, STP-Provider A may enforce digital signature technology, and any information
that is not digitally signed will be blatantly rejected. This kind of assertion check is documented in
the form of a policy. From a development perspective, WS-Policy is viewed as a declarative approach
in listing the preferences and limitations of a Web service. This greatly increases development pro-
ductivity because developers don’t need to worry about writing any kind of validation code. Much
of the grunt work is encapsulated inside a policy document, which is expressed using XML grammar.
WS-Policy represents a family of specifications that consists of WS-Policy, WS-PolicyAssertion,
and WS-PolicyAttachment:
WS-Policy: This provides a generic XML-based framework to author the Web service policy.
WS-PolicyAsssertion: This represents rules or constraints imposed on the Web service in the
form of individual policy assertions. These collections of policy assertions are implemented
inside a policy expression document that itself is an XML document.
WS-PolicyAttachment: This refers to the association of a policy expression with a policy subject.
Policy subject refers to any particular portion of a Web service; it can be the whole service,
a particular operation, or a particular message.
The purpose of the WS-Policy specification is to provide a standard policy framework based on
which specialized policies are defined. For example, the WS-SecurityPolicy specification extends
WS-Policy to define WS-Security–specific policy assertions. WSE 2.0 enables support for WS-Policy
by configuring and implementing various policy assertions in a configuration file. Furthermore,
WSE has built-in support for the WS-Security policy and provides a wizard interface to activate indi-
vidual policy assertions. WSE 2.0 also provides support for incorporating custom business validation
rules in the form of policy assertions, and to implement it, developers have to undertake quite an
amount of manual work. We clearly cannot explain the syntax-level functionality of WS-Policy within
this short section, but you can refer to the WSE online documentation for more details. The primary
focus of WS-Policy is to further enrich the metadata information of a Web service by documenting
the required QOS properties and make it available to the service requestor.
WSE 2.0 already provides a set of predefined policy assertions falling under WS-SecurityPolicy
and is integrated with VS .NET. To activate this policy, right-click the project node in VS .NET, and
select WSE Settings, which opens a multitab configuration dialog box. The Policy tab allows you to
configure security-related policy assertions such as that the body of SOAP messages must be digi-
tally signed or encrypted (see Figure 7-33). It is also important to note that these policy assertions
can be applied to both incoming and outgoing SOAP messages.
396C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T YWS-Addressing
In a classic request-reply message exchange pattern implemented between STP-Provider A and
STP-Provider B, there is strong dependency on HTTP as a default transport protocol. Because of
HTTP’s ubiquitous nature, it is highly favored over any other transport protocols. While this assump-
tion works fine as long as the service requestor and provider are using the same transport protocols,
in reality the message exchange may happen on protocols different from HTTP. For a message to
be routed in a multitransport environment, you need a uniform addressing mechanism. Currently,
the addressing information about the Web service is encoded inside the HTTP header, and the
actual SOAP message forms part of the HTTP payload. This transport-level dependency needs to be
removed in order to achieve transport standardization. Additionally, HTTP is a stateless protocol
and is not suitable for interactions that are long running and stateful in nature.
The WS-Addressing specification promotes transport standardization by defining a common
addressing mechanism and encapsulating it inside SOAP headers (see Figure 7-34). The attachment
of addressing information further strengthens the mobility of a message and can be carried over mul-
tiple transport protocols. It is extremely useful in handling a multihop scenario where the message
travels across multiple intermediaries before it reaches its final destination. The intent of this speci-
fication is to keep the original sender, destination, and reply address information intact. This
specification serves as a building block to incorporate asynchronous behavior between Web services.
C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 397
Figure 7-33. WSE configuration showing how to configure Web service policies398C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
For example, it is possible for STP-Provider B to send a one-way request to STP-Provider A using
HTTP. STP-Provider A, after processing the request, notifies STP-Provider B about the outcome
using TCP. As you can see, both STP-Provider A and STP-Provider B were completely decoupled
from each other, and the only piece of information STP-Provider A had is the original sender reply
address, which itself is sufficient for notification purposes. There is no doubt that many other speci-
fications such as WS-ReliableMessaging have been extended upon WS-Addressing. By associating
additional sets of addressing headers, a message completely turns out to be self-sufficient and transport
independent. Furthermore, it opens the door to implementing an asynchronous communication
pattern between the requestor and provider.
WS-MetadataExchange
Metadata is the key to enabling interaction between a service provider and requestor. Currently, the
service provider supplies three types of metadata. The first is WSDL, which describes the functional
characteristics of a Web service along with wire-level details. Next is the XSD Schema that describes
the structural aspect of the XML message. The final metadata information that further complements
WSDL is WS-Policy, which describes the nonfunctional characteristics of a Web service. Together this
metadata information plays an important role in enabling the loose-coupling behavior between the
service requestor and provider. The service requestor based on this metadata information begins
exchanging messages with the service provider. However, the key point here is before the real
interaction kicks off, the service requestor must have complete access to metadata, and there is no
standardized way to retrieve this information. Even though the provider may publish metadata
information using some other communication medium, again it becomes native to that provider.
What you really need is a standard way of accessing metadata-related information, and this is where
WS-MetadataExchange comes to the rescue.
The WS-MetadataExchange specification allows the requestor to query metadata information
directly from the service provider (see Figure 7-35). In other words, a bootstrap phase kicks off before
the real interaction takes place between the provider and requestor. During this phase, the requestor
can query the service metadata such as WSDL or WS-Policy directly from the service endpoint. This
allows the requestor to get hold of a fresh copy of information and then incorporate any required
modification. The dynamic retrieval of metadata also introduces run-time capabilities. For instance,
by default during the handshaking phase, the service requestor can reconcile and verify the planned
metadata with fresh metadata published by the service provider. Additionally, it also brings flexi-
bility on the service provider end because it now allows for the easy modification of metadata.
With WS-MetadataExchange it is possible for STP-Provider B to query the WS-Policy enforced by
STP-Provider A for their interaction and apply that same set of policies on the message sent by STP-
Provider B. Using this approach, exceptions can be easily caught on the requestor end instead of
leaking on the provider end.
Figure 7-34. Using WS-Addressing to achieve transport standardizationC H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 399
WS-Referral
The major advantage of a SOAP message is it is complete and self-governed from all dimensions. By
looking at the message, you can know its travel path and also the QOS applied on it. Furthermore,
the loose-coupling nature between the sender and receiver of the SOAP message allows further
message enrichment without any side effects on the sender or receiver. Keeping in mind this advan-
tage, a new specification called WS-Referral is geared toward dictating the travel path of the message
(see Figure 7-36). The WS-Referral specification transparently brings dynamic message-routing
capabilities to the Web service world. This opens the door to implementing advanced features such
as load balancing and content-based routing. Load balancing has been widely recognized and
implemented in today’s network topology; its important goal is to bring horizontal scalability by
offloading the work-processing load on multiple machines. Similarly, content-based routing shares
a similar spirit as load balancing, but its intention is different. The intent of content-based routing
is to redirect messages received from the original sender to a different destination based on certain
markups defined in message. This idea of content-based routing brings some elegant architectural
style to the STP world.
With WS-Referral in place, you can bring an additional important player known as an STP
provider hub to the STP world. Imagine this hub as a virtual face representing all STP providers.
STP providers will never directly communicate with each other; instead, all interaction will happen
through this hub. STP providers will send the message to the STP provider hub that will then be
routed automatically to the destined provider. This will definitely bring a major shift in the STP
Figure 7-35. Using WS-MetadataExchange to allow the consumer to query metadata information
directly from the Web service
Figure 7-36. Illustrates use of WS-Referral in implementing STP provider hubprovider mind-set because it is obvious that the role of a hub will be played by a regulatory board
that wants to oversee each transaction happening in the STP world and wants to maintain a healthy
market practice. The STP provider hub will be equipped with the necessary intelligence of maintaining
an audit of messages exchanged between different STP providers. Additionally, the hub can also act
as a first line of defense for a provider that has built-in support to verify a digital message received
from the sender. With a central hub in place, it brings an enormous amount of confidence to both
the STP provider and the individual market participants. Both are assured that the regulations are
fully followed and the regulatory board is in control of transactions occurring in the STP world.
Web Service Performance in the Financial Market
The performance of Web services is the most common concern in a capital market. However, there is
no doubt Web services are the ideal technology platform for enabling business-to-business integra-
tion. But when discussed in terms of speed and performance, some issues hinder their adoption in
real-time trading systems. In this chapter, we explained the benefit of Web services in the post-trade
phase of the trading life cycle. However, in the pre-trade and trade phases, where the timely delivery
of the data and the response is critical, it is essential to evaluate the suitability of Web services.
The primary issue with Web services is the large amount of XML data sent and received. XML
has its own advantages, but it also contributes to an increase in network utilization and processing
overhead, which is usually unacceptable in the pre-trade and trade phases of the trading life cycle.
Real-time trading systems are engineered from a high-throughput and low-latency perspective, and
the profit/loss of the trading desk to a large extent depends upon these systems.
Various strategies can address the performance problems of Web services, and they require
a good amount of planning and evaluation:
Use of network accelerators: The processing demands of XML can be addressed by using special-
ized hardware accelerators that provide the end-to-end processing of XML and include XML
schema validation, encryption, serialization, and so on.
XML compression: The higher network transmission cost associated with XML payload can be
reduced to a large extent by applying a compression/decompression scheme.
Binary XML: Binary XML is a new approach to compact XML-based data and is already being
used by the mobile industry. The WAP binary XML format is the standard officially recognized
by the W3C to transfer content to mobile devices.
Use of faster transport protocol: Because of the request-response nature of HTTP, it is extremely
difficult to introduce asynchronous communication. Therefore, it is always advisable to explore
other transport protocols in search of better performance.
Avoid RPC style of invocation: Always design Web services with a message-based programming
model in mind. This will result in fewer method calls and also reduce network round-trips.
Exploring the Business-Technology Mapping
Figure 7-37 represents the end-to-end interaction between market participants and the STP provider
in the new Web-STP world. It demonstrates how the various components of Web services discussed
so far fit together to streamline the overall process. The first and foremost requirement of Web-STP
is the presence of an STP directory. The directory should be UDDI compliant and will publish infor-
mation about the STP provider and market participants. With an STP directory in place, any market
participant using UDDI can access information about the various STP providers and their offerings.
Other prerequisites needed to complete this setup are an individual market participant and that the
STP provider must have a valid digital certificate.
400C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T YThe communication with the STP provider is first initiated by market participants. The interac-
tion involves a message sent by market participants to their registered STP providers through a Web
service. This message is triggered by systems on the market participant end that may not necessarily
be a Web service but that surely understands the protocols of Web services. The message is digitally
signed using WS-Security and sent to the STP provider. On receiving this message, the STP provider
verifies the signature and forwards it to the STP provider hub if the recipient of the message is regis-
tered with another STP provider. For instance, when the broker registered with STP-Provider B sends
a message to the fund manager who is registered with STP-Provider A, then the message is routed to
its final destination through the STP provider hub.
STP providers forward all messages meant for delivery with a different STP provider via the
central hub, which in turn forwards the message to the terminating STP provider. The STP provider
hub is a Web service that implements WS-Referral to incorporate smart routing logic. The role of hub
can be played by any public or private agency, but generally it is preferable to assign this responsibility
to a public agency. Additionally, the hub can act as a checkpoint where messages received from the STP
provider are verified and are again digitally signed using the STP provider hub digital certificate.
This step further strengthens the overall interaction because the recipient STP provider on receiving
the message could verify whether the message is legitimate and approved by the STP provider hub.
By wiring the individual STP provider and market participant using Web service technology and
other advanced WS-* specifications, we have illustrated the next-generation technology platform
for automating end-to-end transaction processing in the financial trading world. Although the nec-
essary infrastructure is in place, getting market participants and STP providers to come to this new
Web-STP world will take some time. However, it is possible to start leveraging this infrastructure in
a piece-by-piece manner. It is possible to start with WSDL, SOAP, and HTTPS and then slowly start
augmenting this basic functionality with the advanced features provided by WS-*. It is clear that
whatever strategy or vision the industry outlines, without reference to the Web service platform it
would be incomplete.
C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y 401
Figure 7-37. Web-STP402C H A P T E R 7 ■ S T P I N T E R O P E R A B I L I T Y
Summary
In this chapter, we discussed following points:
  We talked about the need for interoperability between STP providers and how it will benefit
business entities such as brokers, fund managers, and custodians in different ways.
  We discussed different types of challenges encountered in achieving interoperability.
  We covered the architecture of Web services and how the underlying principles ensure wide
reach and enable interoperability between STP providers.
  We gave a brief overview of the building blocks of Web services such as SOAP and WSDL.
  We implemented a simple Web service that supports sending contract note information
between STP providers in an interoperable fashion.
  We illustrated the advantage of a UDDI repository in establishing an STP provider consortium.
  We showed how WS-* extends the capabilities of basic Web service functionality by providing
advanced features such as security, routing, and policy enforcement.
  We depicted a blueprint of Web-STP that demonstrates various components of Web services
and how they connect an individual STP provider and market participants to represent the
next-generation platform for automating STP.

