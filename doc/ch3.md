# 第三章 数据转化引擎 The Data Conversion Engine
Parents are the real programmers who programmed us. It is because of their continuous refactoring
and unit testing effort that we turn out to live a bug-free life in this unmanaged world.
This chapter provides insight into the problems encountered during data conversion. Simply defined,
data conversion is the process of decomposing data structured in an incompatible data format and
recomposing it again using different semantics and a different data format. During this conversion,
data is structurally rearranged. Data conversion occupies a central place in organizations with busi-
ness goals that depend on the integration of multiple applications. These applications may be legacy
systems, homegrown applications, or vendor-based applications. In this chapter, we discuss the
various hurdles faced in the financial world during the data conversion process and how XML provides
a solution to these problems.
Introducing Data Management
Data originates from a variety of sources. Many times, the same data is presented in different for-
mats. Figure 3-1 illustrates how information is consumed from different newspapers. Although the
information produced in each of these newspapers is the same, the information differs in style, rep-
resentation, and structure. For example, the New York Times may publish sports news on page 16 in
a columnar format, the Star Ledger may produce the same information as a summary on page 1
with details on the last page of the paper, and Fox Magazine may publish the same information with
less verbiage and more emphasis on pictures and a small description at the bottom of each picture.
The primary objective of all these newspapers is to publish accurate information/data, but each
one adopts a totally different approach and style. This is called information enlargement where the
integrity of data is maintained but presented differently.
105106C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
A human brain weighs just 3.5 pounds, but it is one of the most complex organs and continu-
ously interprets data for us. In the computing world, however, things are different—machines lack
consciousness, intellect, and capacity for thought. Although computers are better than the human
brain in calculating speed and power, they have to be specifically instructed/coded to conduct/
perform/execute an activity. However, it will always be true no matter how much progress we make
in technology advancements that there is no substitute for human creativity, diligence, and judgment.
Thus, if Figure 3-1 is to be replicated in a computing environment, a new program has to be
developed to interpret the needs of the New York Times, the Star Ledger, and Fox Magazine. This trend
does not stop here; in the future, if a new newspaper comes into the market, then a new program
specifically to interpret the information published by this newspaper needs to be developed. The truth
is that every organization reinvests/mobilizes funds for “interpreting” already “interpreted” data.
In the financial world, various applications use a lot of data related to securities, prices, market
conditions, clients, and other entities for the fulfillment of trade. Applications do trade enrichment
on the basis of this data and also make a lot of decisions. Data comes from a variety of sources. Market
data, news, and analysis are bought from third-party content service providers such as Reuters, and
the institutions generate the rest themselves in the normal course of their day-to-day activities. The
latter relates to transaction- and settlement-related data. Institutions obtain some data from agencies
such as stock exchanges, clearing corporations, regulators, and so on, by virtue of being members of
those agencies. Maintaining this data is expensive. Some data has to be purchased, and some has to
be filtered (unnecessary data has to be removed), validated, and stored.
Understanding the Business Infoset
Business infoset is synonymous to information; it comprises a lot of data items in various forms. What
and how an organization decides on various issues largely depends upon the kind of data that is
presented to its business managers, including its presentation format and perspective. Business
infoset can be decomposed into granular data elements. Each data element has its own characteris-
tics and can be classified as one of the following:
  Reference data
  Variable data
  Derived data
  Computed data
  Static data
Figure 3-1. The same information originates from multiple sources and in a different format.C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 107
To understand this classification, let’s discuss various attributes of an order, as shown in
Table 3-1.
Table 3-1. Attributes of an Order
Order Attribute Description Type of Data
Market of operation Geography from where order is placed Static data
Client code Client placing the order Reference data
Exchange Stock exchange on which the order is being Reference data
placed
Traded asset/ISIN/SEDOL/ Security that needs to be transacted Reference data
scrip code
Company name Name of the company issuing shares Derived data
Order type Buy/sell Static data
Quantity Number of shares to be purchased Variable data
Order price Price at which the client expects his Variable data
order to get through
Currency Currency of transaction Reference data
Segment Exchange segment Reference data
Broker code/Counterparty Counterparty Reference data
Order validity Date and time conditions Variable data
Reference Data
Reference data is any data that is created and maintained outside the purview of the system but is
required by the system to meet business or computational needs. To meet these needs, systems
may decide to maintain a copy of reference data or have links to other systems and use the link to
access this data on an online or real-time basis. Reference data is used to categorize transactional
data and can be used to link to data from other organizations.
Variable Data
Data whose value changes over a period of time is called variable data. Variable data may or may
not lie in a fixed range, but its values can be random and unpredictable. A typical example is a stock
price. Stock prices depend upon the market perception of the earnings and on the cash flows a company
can generate, but the day-to-day price is impossible to predict. Prices also keep changing on a daily
basis. Hence, stock prices fall under variable data. Similarly, a company’s earnings keep changing
from quarter to quarter so can also be classified as variable data.
Derived Data
Derived data is any data that derives its value from any other data. For example, if you have a list of
countries and capitals and you try to access the capital using a country—say by retrieving the capi-
tal by using “United States of America” and getting the value “Washington DC”—then “Washington
DC” (capital) becomes derived data since its value is based on the value “United States of America”
(country). In this chapter’s example of order attributes (see Table 3-1), the company name becomes
derived data, because its value depends upon the International Securities Identification Number
(ISIN) code.Figure 3-2. Reference data plays a central role in all functions.
Computed Data
Any data that results from manipulating other data or another set of data is called computed data.
For example, if you attempt to calculate the average stock price quoted across the month, the
resulting average figure will be computed data because its value is derived using some computation
over some other set of base data.
Static Data
Static data is data whose value does not change over a period of time. In the order attribute example
in Table 3-1, the order type (that is, “buy” or “sell”) is an example of static data. Even if you revisit the
order type after a long time, each order will still be either “buy” or “sell.”
Introducing Reference Data
Data is the lifeblood of any organization. The success of an organization also depends on the quality
of data it possesses, because strategic decisions may be based on the data. Every act of an organiza-
tion requires input of data and generates (or enhances) data at the end of the activity. Financial
institutions and organizations are making a lot of investments in the area of reference data manage-
ment. Though institutions maintain reference data for their quick reference, they rely on other
agencies to create this data and supply it to them. They then upload a copy of this data in their sys-
tem and use it for quick reference to add value to their transactional data. Departments and operations
have traditionally been compartmentalized in the form of front, middle, and back offices, and each
department forms its own systems to cater to its needs. This results in the duplication of activity
because each operational area tends to replicate a lot of referential data within its own system to
reduce its interdependence on other systems. This also gives rise to another problem of having and
managing redundant reference data.
Note that even when institutions import required reference data in their systems, they also need
to convert it into a format defined in their systems and acceptable to it. This acceptable format and
content changes as data moves down from one link in the value chain to another. This calls for a lot
of conversion even during the life cycle of a single trade. Let’s examine the business need of convert-
ing this data using the trading value chain and examine this concept in more detail (see Figure 3-2).
108C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N EC H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 109
The trading value chain is divided into front office, middle office, and back office (described in
Chapter 1). We will look at these concepts in more detail here. An order is originated and is delivered
to the exchange by the front office. Dealers interact with investing institutions to get their orders,
and when the order is executed, they charge brokerage from those deals. The order flows through
a defined process (discussed in Chapter 1).
The middle office holds the reference data that is shared between the front office and the back
office. At most places, the middle office is also responsible for risk management on the orders that
hit the trading system and for orders getting converted into trades during the process. The middle
office conducts a lot of validations, checks limits, and validates the resulting trade values against the
ledger balances that clients hold with the broker, who is executing the order.
Once a trade gets generated and hits the trading system, it is routed to the back office for settle-
ment. On the basis of trades, the settlement obligation of every client is determined, and the payment/
receipts are generated and affect the settlements. Let’s revisit each of these steps to analyze the data
requirements and also examine why data conversion is necessary when organizations are forced to
maintain multiple copies of data. To illustrate these steps, we will use the example of an instrument
master that is extensively used in the trading chain.
When a client calls up the broker to place the order, he will either give the company name or
use a popular code to refer to the security. For example, if the customer wants to purchase Microsoft
shares, he will either say “Buy equity of Microsoft Corporation” or say “Buy MSFT.N.” If the order
originates from a different country, chances are that the institution placing the order will use a code
that is completely different from the code used by the exchange. Even though a standard unique code
called an ISIN code is associated with every security, each exchange (instead of adhering to this ISIN
code) devises its own local security code.
The ISIN code is a standard code for a security that is supposed to be unique across the world.
The ISIN for each security is generated by the regulatory body of a country or by any other agency
mandated by the regulatory agency. Though ISIN codes are standard codes that are supposed to be
used worldwide, trading systems rarely (almost never) use ISIN codes. Most settlements, however,
happen on ISIN codes. No specific reason exists for this anomaly. ISIN codes are longer to use and
confusing to type; hence, they are kept out of trading systems. Additionally, other codes such as the
Stock Exchange Daily Official List (SEDOL) have been popular for a long time among the dealing
circles. Dealers tend to understand each other without ambiguity when they use SEDOL codes while
referring to any security. A fixed format is defined for constructing an ISIN code. An ISIN code has
a 12-character structure in the following format: USAAAABBBCCD. The characters break down as
follows:
  The first two characters (“US” in this example) stand for the country code.
  The next four characters (represented by “AAAA”) are alphanumeric and represent the issuer.
  The next three characters (represented here as “BBB”) stand for the type of asset. The second
and third position can also be used as a running serial number.
  The next two characters (represented as “CC”) are alphanumeric and represent the type of
stock issued. These two are also used as the sequence number for every security issuance.
  The last character (represented as “D”) is a control digit.
It is not mandatory that the exchange where the transaction is routed uses the SEDOL or ISIN
code for its reference. Each exchange uses its own proprietary code for trading, and their systems
are designed to support their proprietary codes. In the front office itself, we come across the potential
to use three different codes while referring to one security. A data mapping mechanism will hence
be required to interpret these codes while the information passes on so that each entity understands
the information completely and without ambiguity, as shown in Figure 3-3.110C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
Now let’s examine where reference data comes into use in this entire order flow chain. The
institution placing the order will use a system to maintain a portfolio. Assuming a global investor,
the client holding the position will be maintained locally in different countries, and each will have
a local name and sometimes even different code for the same security. While placing the order, the
institution will reference its database to arrive at the exact name of the security to be transacted.
The institution will give the order as the name appears in its database. Assume that the database
lists “Microsoft Corporation equity shares” as “MICROSOFT EQ.” Thus, the order from the institution
to the brokerage house will look like this: Buy 10000 MICROSOFT EQ.
The dealer or sales desk person in the brokerage house will now enter the order in the broker’s
system. Let’s assume the broker’s system is configured using SEDOL. Hence, in this case, the system
will not understand “MICROSOFT EQ,” and therefore the broker will manually convert the order to
“2588173” (the SEDOL of Microsoft) and place the order. If the institution provided the order as a soft
copy, the order will get validated in the broker’s system, resulting in an exception stating that it does
not understand “MICROSOFT EQ.” The user will then override these cases and manually replace all
“MICROSOFT EQ” instances with “2588173.” If the broker does a lot of business with this institution
(and receives a lot of orders from it on a daily basis), it will not be long before someone realizes that
it will be worthwhile to maintain a mapping in the system to convert the institution’s codes to the
SEDOL codes, as shown in Table 3-2.
Table 3-2. Mapping Between Institution and SEDOL Code
Institution Code SEDOL Code
Microsoft EQ 2588173
INTEL EQ 2463247
The order for Microsoft EQ is now interpreted by the broker system. The issue, however, does
not get resolved here. As discussed, each exchange may use its own local code. To forward the order
to the exchange in a way that the exchange recognizes the order properly, it needs to provide the
exchange with its local code. This in turn means the broker system will have to maintain an additional
mapping between the SEDOL codes and the local codes understood by the exchange, as shown in
Table 3-3.
Table 3-3. Mapping Between SEDOL and Local Exchange Code
SEDOL Code Local Exchange Code (NASDAQ)
2588173 MSFT.O
2463247 INTC.O
The need for security code mapping does not end here. After the exchange confirms that orders
have been executed, the broker needs to send a trade confirmation to the institution and institution’s
custodian. The broker needs to remap the exchange codes to the language understood by the
institution. Additionally, to get the trades settled, the broker will have to interact with the clearing
Figure 3-3. Instrument mapping in the front officeFigure 3-4. The trade confirmation must happen in a language understood by the client, and the
settlement must happen in a language understood by the clearing corporation and depository.
C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 111
corporation and depository. Chances are that the clearing corporation and depository will commu-
nicate using ISIN codes. The broker will thus have to maintain an additional mapping of exchange
codes vis-à-vis ISIN codes in the back office system, as shown in Table 3-4.
Table 3-4. Exchange Code Mapped to ISIN Code for Settlement
Local Exchange Code (NASDAQ) ISIN Code
MSFT.O US5949181045
INTC.O US4581401001
Figure 3-4 shows the flow of the order confirmation back to the broker and from the broker back
to the client, clearing corporation, and depository.
All communication that the clearing corporation and depository has with the member will be
in ISIN codes. It is hence important for the broker’s system to understand and convert these codes
and then communicate this information to their clients.
Framework for Data Conversion
Data conversion means different things to different people and institutions. To a stock exchange, it
could mean converting very old prices into electronic format. To a museum, it could mean creating
a soft-copy repository of images of the priceless paintings it possesses. Whatever the notion, data
conversion involves taking data from one system (which could be any legacy system, hard copy, digital
media, analog device, and so on) and migrating to another. Usually the target system is a new system.
Getting a new system to accept any data is a big process, especially if the data is coming from
a legacy system and the target system is a new system built on more recent technologies and not
built with the thought that reference data would be coming from a legacy system. There is an
established methodology for migrating/importing this data in the new system. Of course, the first-
time migration/import takes a lot of time because of field-level mapping and the finalization of the
structure. However, once the structure is finalized, subsequent imports do not require this kind of
effort. Let’s examine the conversion methodology in some detail.112C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
The entire step of populating data from a legacy system to a new system comprises the follow-
ing two broad processes:
  Cleansing the data received from the source system
  Changing the data format to suit the new system and translating/integrating it into a structure
where it can be stored in the database of the new system
Data cleansing is a method or series of steps to address the cleaning of dirty data that is incon-
sistent, incomplete, and/or not uniform. Data could be dirty because of typing mistakes or missing
essential entries, or it could be inconsistently coded. Before data is converted and migrated in a new
system, it needs to be cleaned. It is not uncommon to see institutions maintaining several copies of
such data; unfortunately, this compounds creation, storage, and referring costs. Apart from actual
costs, this also creates the problem of duplication where the institution is really not sure which data
has to be used.
For example, assume that a client has specified two different addresses and phone numbers in
two different systems. Until the systems are integrated, both systems’ users are unaware of the exis-
tence of a different address and phone number in the other system. If the institution undertakes the
exercise of integrating the two systems, it will be meaningless to maintain two different sets of addresses
and phone numbers; if they decide to merge the data, they will be in a state of confusion as to which
address and phone number is correct, and a decision may be made to retain the more recent infor-
mation. This is a simple example. If this same thing is extrapolated over a number of instruments,
markets, trades, and settlement-related data, this problem tends to be overwhelming.
The presence of data in silos raises a number of issues:
  Institutions have to manage a lot of external vendors who manage/maintain external systems.
  Since data is parked in multiple systems, the institution may be forced to maintain a number
of licensed copies of software used for maintenance.
  A lot of storage space and hardware is utilized.
  Data definition standards are poor; hence, the same data cannot be referenced by multiple
systems.
  Trades have to be frequently corrected, leading to high operational costs.
  Making data corrections is time-consuming and expensive.
Recently, financial institutions and banks are under greater regulatory and market scrutiny
because of compliance requirements for the Sarbanes-Oxley and Patriot Acts. Market forces have
compelled institutions to take a consolidated view of risk management and other financial numbers.
Institutions are now trying to integrate all data that is present in silos. Reference data management
is a huge challenge for institutions that operate from multiple geographies and that trade in multiple
products.
Cleaning dirty reference data has its own methodology, and the approach depends purely on the
complexity of data and the extent of its inconsistency. Most cleansing processes and methodologies
use application programs to convert data from proprietary formats to standardized formats. Extensible
Markup Language (XML) is widely used in the cleansing process.
The deployment of XML for the data cleansing process provides speedy and effective resolution.
In its basic form, the data cleansing process has three stages, as shown in Figure 3-5:
  Import and conversion
  Cleansing
  EnrichmentC H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 113
Figure 3-5. Steps in cleaning reference data
Import and Conversion
In the first step, data is extracted from multiple sources such as legacy applications, customer rela-
tionship management (CRM) applications, and current settlement systems. It is converted to basic
XML format. During the conversion process, care is exercised to see that no data is lost or dropped.
Converting data is a tedious process. A lot of data could be in an unorganized form. For example,
libraries could have data in the form of printed books. Stock exchanges could have stock rates in
magnetic tapes with defined reference structures. The reference structure itself could differ from
time to time. Analysts doing data-cleansing activities must refer to these structures and convert data
appropriately and carefully. After the conversion process is over, a warehouse of XML data is created.
Cleansing
In this step, imported data is verified for missing items, duplicates, and referential integrity. For
example, if you refer to the earlier ISIN master example where the following business rules must be
followed:
  All securities must have ISIN codes assigned.
  ISIN codes must be unique.
  ISIN codes must be 12 characters in length.
  The first two characters of the ISIN code must be a country-specific prefix.
In the cleansing process, if the system comes across cases where the ISIN code is not populated
against a security or is not 12 characters in length, or cases where the same ISIN code is allotted to
two securities, then the system needs to analyze such cases and correct them. All such cases are col-
lected, and correct codes are found by checking other systems, by contacting a third-party data service
provider, or by contacting the agency that generates ISIN codes in the specific country. Multiple scans
of the same data through the same business validations may be required to arrive at a correct and
clean repository.114C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
Enrichment
In this step, the existing data set is analyzed critically to see whether any further information needs
to be tagged along with the data that is being cleaned. For example, while compiling the ISIN-related
data, it could be beneficial to tag the face value of the securities along with the existing data (assuming
that the face value is not in the existing data). The face value will have to be extracted from a different
data source and updated along with current ISIN codes using a join or some other update method.
The presence of clean reference data can deliver the following benefits to the organization:
  It can help in the availability of accurate and timely data on which business decisions can be
based. Data forms the heart of all CRM activities. Good-quality data has a direct correlation
to customer satisfaction.
  It frees up software and hardware resources, thereby lowering operational costs.
  Software licenses can be used more effectively. Manual development and maintenance costs
are reduced.
  It requires less manual intervention, which results in fewer trade failures, which in turn
reduces the operational costs.
  Redundant operations can be combined, resulting in operational efficiency.
  Clean and accurate data benefits several downstream applications, ensuring their proper
functioning.
If these benefits were summarized, they would fall under the following headings:
Operational benefits: Helps in cost reduction, improves efficiency in operations, and removes
redundancy.
Technology benefits: Reduces total cost of ownership and reduces pain involved in maintaining
several applications and silos of data.
Organizational benefits: Improves risk management and compliance. Better performance leads
to greater client satisfaction.
Several vendors provide reference data solutions. Each vendor, however, has a different approach.
Whatever the method or approach, the following common threads run through a successful reference
data implementation:
  The underlying data needs to be clean. No amount of technical approach will help if the
underlying data is not clean. While implementing a reference data solution, care has to be
taken to clean the data and remove any format/version issues.
  Pareto’s 80-20 rule works here as well. This means that some steps will give magnified bene-
fits with small and incremental effort. Such steps have to be identified and implemented first.
  The build or buy dilemma is common in the case of reference data solutions. It is not a good
approach to implement both in isolation. Most of the time a mix of both is required. Many
financial institutions are looking at outsourcing the data management and exception-handling
process to further reduce costs.
■Note Vilfredo Pareto was an economist who during 1906 created a theory that 20 percent of the population in
his country owns 80 percent of the wealth. This principle was then followed in various other areas such as quality
management, marketing management, and business.C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 115
This brings an end to the business section, and we will continue the ISIN master example to
see how to do data conversion from a technical perspective. We will discuss the technical issues
encountered in each step so you can understand how the concepts are implemented in real life.
Entering the XML World
In the computing world, XML is a basic necessity. It is the equivalent of food, clothes, and shelter to
a human being; life would be crippled without it. Today millions of systems are using XML as their
basic foundation in one form or another. XML has established itself as the building block of a good
system design, and therefore every new system design built today is centered on XML.
XML is a markup language, and the success of XML is based primarily on its most important
quality—its ability to describe both the data and the intelligence behind the data. This ability to
model a data branch under the category of data-oriented language is the unique strength of XML.
An XML document is a new form of content extension that is similar to an executable file or
dynamic link library. But the comparison ends there; XML documents contain ordinary text that is
expressed using XML syntax instead of low-level machine instruction. The plain-text data is easy to
read and is primarily comprised of elements and attributes. Elements are represented in the form of
start and end angle brackets, and the data is enclosed between these angle brackets. Attributes are
the equivalent of a name-value pair, where the value represents the actual data. Both elements and
attributes are tagged with a meaningful name that is easy to understand. Although no cookbook rules
exist for naming conventions used in XML documents, it’s a basic tenet of good XML document design
that an element or attribute name must express the real hidden meaning of the data encapsulated
within the markup. The formation of an XML document is simple; the Notepad application is suffi-
cient for creating an XML-based document. No additional or special tools are required.
This innate ability of XML to engineer the information in a plain-text format has formed the
important glue in achieving integration among heterogeneous systems. The plain text is encoded
and decoded using ASCII standards. Data based on ASCII standards are understood by most of the
commercially available operating systems and applications. Such standardization of data emphasizes
an important fact: XML is platform neutral and a perfect candidate in achieving enterprise application
integration (EAI). Over the last decade, EAI has been in the limelight and has also become one of
the key factors in determining the growth of an organization. In a typical large-scale organization,
thousands of systems are hosted in a multiplatform environment. Most of these systems run inde-
pendently, catering to the needs of the individual departments/divisions within an organization.
The industry needed a universal language that would enable these systems to communicate with
each other. XML, with its innate characteristic of platform neutrality, bridges this gap. It has further
enlarged the scope of integration by crossing the periphery of organizational boundaries to establish
the free flow of information exchange with business partners as well.
To further illustrate the power of XML, let’s take the following real-life example of an ISIN master
file that also forms the basis of the discussion in the rest of this chapter. Listing 3-1 and Listing 3-2
represent different formats of the ISIN master. Listing 3-1 is an ordinary comma-delimited text file,
and Listing 3-2 is an XML file.
Listing 3-1. ISIN Master (CSV Format)
ISINMASTER12122004
US5949181045,MSFT,10,5,Active
EXCHANGE,NASDAQ,MSFT.O
EXCHANGE,NYSE,MSFT.N
ISINEOF116C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
Listing 3-2. ISIN Master (XML Format)
<ISINMaster>
<ISIN ISINCode="US5949181045"
Symbol="MSFT"
FaceValue="10"
MarketLot="5"
Status="Active" >
<Exchanges>
<Exchange Code="NASDAQ"
ScripCode="MSFT.O" />
<Exchange Code="NYSE"
ScripCode="MSFT.N" />
</Exchanges>
</ISIN>
</ISINMaster>
If you quickly compare these two versions, the XML version is an eye-catcher and is more
intuitive compared to the text-based version. In addition, the XML version also offers other important
characteristics, as described next.
Domain Knowledge
In the XML version of the ISIN master, the real content is enclosed between start and end tags. This
clearly helps you recognize both the content and the underlying domain knowledge supporting this
content. This is remarkable compared to the text version, which is not easy to understand unless it is
supplemented by some user documentation that describes the offset of every field and its business-
level interpretation. XML is called a self-describing document because of its unique ability to convey
both data and metadata (domain knowledge). This self-describing nature of the document breaks
all kinds of barriers arising in information sharing and makes it possible to share XML documents
with all types of audiences such as business analysts, developers, and users.
Data Arrangement Uniformity
The most noticeable difference between the CSV and XML versions is the arrangement of data. The
CSV version has a tabular arrangement with every field delimited by a comma. However, keep in
mind that text files have different structural representations as well, including tab-delimited, fixed-
delimited, and custom-delimited representations. Such structural-level inconsistency completely
shuts down the door to standardization. This is in direct contrast to the XML version where data is
arranged hierarchically and follows certain well-established vocabulary such as an element name
being represented inside angled brackets with every start tag having a corresponding end tag, and
so on. The XML version of the ISIN master can be categorized as a well-formed document because it
meets the structural criteria of an XML document. Such well-formed documents are boons because
several parser tools are currently available that can help you iterate, read, and easily understand any
XML document as long as it is well-formed.
Context-Oriented Data (COD)
Context-oriented data (COD) cannot be accessed on its own; it must be referenced from its context.
For example, referring to the CSV version of the ISIN master (in Listing 3-1), it would be difficult to
extract the data “MSFT” because multiple occurrences of “MSFT” exist. You can extract the data
only after providing the context in the form of row and column numbers. Hence, in this example,
you must provide row 2 and column 2 to obtain the data “MSFT” falling under this context. OnceC H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 117
again, keep in mind that this context may differ for different types of text files. For example, in
a fixed-based file format, you can extract the context by passing the offset position and length of the
data to be extracted. In an XML-based document, the context is provided in the form of an element
or attribute name. Such uniformity in the context allows a standard mechanism to programmatically
access the data.
Extensibility
The CSV version of the ISIN master is fragile—if you insert a new column at the beginning of a row,
then it will completely distort your interpretation. Starting from the user specification document
and continuing to the data converter program, everything will need to be fixed. Fixed-based file for-
mats are highly vulnerable to such changes because they completely break down the whole offset
number-crunching process. Such types of breaking changes are harmful to applications and leave
no room for extensibility. XML is free from such curse and provides complete freedom to mix new
elements or attributes with no side effects.
The previously mentioned benefits by themselves are sufficient to show the advantages of
using XML-based data; the rest of this chapter highlights the various XML-related features available
in the .NET Framework that will further encourage you to drive in the XML highway.
Reading and Writing Data
Data is valuable and precious. Hence, every effort must be undertaken to preserve and store data in
a data store. A data store is an abstract container that allows you to store and query data. A data
store can take the form of a file on disk or in memory. (In other words, data can be either saved as
a disk file or stored in memory or on a central Web site.) The underlying common storage denomi-
nator of any data is a collection of bits, but the retrieval implementation of the stored bits differs
based on the kind of data store used.
A stream is a generic wrapper around a data store. The rationale behind a stream is to abstract
the intricacies involved in handling data and also provide a uniform interface for all types of data
input- or output-related operations. The .NET Framework respects this uniformity by encapsulating
all read/write operations in a common Stream class. It is an abstract class and is packaged inside the
System.IO namespace. All concrete stream providers are inherited from this abstract class. Develop-
ers are not required to learn the know-how of the underlying storage devices. As long as they are
under the shelter of the Stream class, they can perform basic operations such as reading and writing
data. Table 3-5 describes the Stream subclasses.
Table 3-5. Stream Subclasses
Subclass Description
FileStream FileStream is the commonly used class for reading or writing data to a file. This
stream also supports the random seeking of data in the file. Furthermore, this
stream can operate on process standard input and output. By default, the keyboard
is the process standard input stream, and the monitor is the standard output
and error stream. You can use FileStream to redirect the standard input stream
(from a keyboard) and output stream (to a monitor) to a file.
MemoryStream MemoryStream is the equivalent of FileStream from the perspective of its
functionality. However, data is fetched/persisted solely in memory rather than
in a physical file on disk. MemoryStream is a perfect candidate for short-lived
temporary data that is generated on the fly and is accessed multiple times and
eventually discarded upon the termination of an application.
Continued118C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
Table 3-5. Continued
Subclass Description
BufferedStream Disk I/O–related operations, with their heavy-duty data spinning (reading or
writing operations), are the most expensive operations in an application. They
can easily bring down the performance of the application. In such a scenario it
is always advisable to perform read/write operations in a chunk of bytes instead
of an individual byte. BufferedStream is intended for this purpose and used in
conjunction with FileStream and MemoryStream to provide caching service. This
improves the read/write performance. FileStream is buffered internally, so there
is no need to wrap the BufferedStream shield around this class.
NetworkStream NetworkStream is specifically designed to handle the intercommunication aspects
between applications. It is used in network-related data I/O operations. This
class allows reading or writing data to or from a network pipe, which is usually
a Socket.
CryptoStream CryptoStream is the focal class of the .NET cryptography kingdom. This
stream is used in conjunction with any data stream to perform cryptographic
transformation (encryption or decryption).
The subclasses mentioned in Table 3-5 share the same goal—to provide uniform access to data.
But each stream’s underlying characteristics are different and tuned to meet specific data needs.
Table 3-6 describes some of the common properties and methods that Stream and its descendant
classes provide.
Table 3-6. Common Properties/Methods Provided by the Stream Class
Property/Method Description
Length This property returns the length of data.
Position The Position property allows you to get or set the seek pointer in the stream.
Even though the stream supports the random seeking of data; the seeking
behavior is not welcomed by all Stream subclasses, particularly the
NetworkStream class.
CanRead This property determines whether the stream supports read operations.
CanWrite This property determines whether the stream supports write operations.
CanSeek This property determines whether the stream supports seek operations.
Read This method reads raw bytes from a stream.
Write This method writes raw bytes to a stream.
Both the Read and Write methods allow the reading or writing of data in
chunks. You can do this by specifying the number of bytes to read/write
from/to a stream.
Close This method closes the stream and also reclaims the memory by releasing the
operating system resource used by the Stream class.
The Stream class also provides an asynchronous version of read and write operations.
Asynchronous-based operations are the building blocks for designing highly scalable applications.
These asynchronous flavors are available through the BeginRead and BeginWrite methods.
The Stream class is fairly simple to use from a coding perspective. To prove it, we will demonstrate
a code example that reads a comma-delimited text version of the ISIN master file from Listing 3-1.
Stream is an abstract class; therefore, you need to use the FileStream class to read the contents of
this file.C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 119
Listing 3-3 shows the example code.
Listing 3-3. Reading the Comma-Delimited Version of the ISIN Master
using System;
using System.IO;
using System.Text;
class StreamExample
{
[STAThread]
static void Main(string[] args)
{
//File to read
string csvFile = @"C:\CodeExample\Chpt3\StreamExample\CSVISINMaster.csv";
//Open a file stream in read/access mode
FileStream isinStream = new FileStream(csvFile,FileMode.Open,FileAccess.Read);
//allocate a byte array of size 10
byte[] byteBuffer = new byte[10];
//read until the stream pointer reaches the end of the file
while (isinStream.Position < isinStream.Length )
{
//read data
int byteRead= isinStream.Read(byteBuffer,0,byteBuffer.Length);
//display data
Console.Write(Encoding.ASCII.GetString(byteBuffer,0,byteRead));
}
//close stream
isinStream.Close();
}
}
The code shown in Listing 3-3 is pretty straightforward; you first allocate a byte array of size 10
and then enter a loop that reads raw bytes into this byte array with the help of the Read method. The
loop will terminate as soon as you have read all the bytes, which is determined with the help of the
Position and Length properties of a Stream class. To display this raw byte on the console, you need
to convert it into a string, which you do using the Encoding class available as part of the System.Text
namespace.
Introducing Specialized Streams
The .NET Framework provides special-purpose reader and writer classes whose inner workings are
specialized based on specific characteristics of data. These classes are not inherited from the Stream
class but are directly related to it when it comes to reading or writing data. The need for specializa-
tion arises from the byte-oriented nature—only bytes are used to push in or pull out from a stream.
Such flexibility of working at the byte level provides absolute power because it allows you to regulate
the flow of data. But this may not be feasible in certain scenarios. In Listing 3-3, while reading the
content of the ISIN master, you are forced to convert an array of bytes read from a FileStream to the
string data type before displaying it on the console.
Specialized stream classes are paired classes with the read and write operations decoupled and
placed in their own separate classes. This is in direct contrast to the Stream class, which provides both
the reads and writes under one roof. The following sections cover some common reader and writer
classes available within the .NET Framework.120C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
TextReader and TextWriter
Both TextReader and TextWriter classes are designed to read or write series of characters. The
TextReader class allows reading groups of characters from an underlying stream. This underlying
stream could fall under any one of the concrete stream classes such as MemoryStream or FileStream.
TextReader is intelligent enough to understand the semantics of a text file and is highly recommended
when it comes to reading data from an ordinary text file. It provides a ReadToEnd method that allows
reading the content of the entire text file in a single iteration.
It also provides a ReadLine method, which can be used to read a group of characters until
a carriage return is reached. TextReader is an abstract class and cannot be instantiated directly by
the code. It needs to be used in conjunction with StreamReader and StringReader, which are concrete
classes and are inherited from TextReader. The underlying data source of StreamReader is backed by
Stream, and similarly, the underlying data source of StringReader is backed by string.
The following code demonstrates how to use TextReader when reading the content of the CSV
version of the ISIN master:
using System;
using System.IO;
class TextStreamExample
{
[STAThread]
static void Main(string[] args)
{
string csvFile = @"C:\CodeExample\Chpt3\TextStreamExample\CSVISINMaster.csv";
//Open the CSV file
TextReader isinReader = new StreamReader(csvFile);
//read the entire content of the file
string content = isinReader.ReadToEnd();
//display content
Console.WriteLine(content);
//close the stream
isinReader.Close();
}
}
BinaryReader and BinaryWriter
Unlike TextReader and TextWriter, which were meant to handle ordinary text data, BinaryReader
and BinaryWriter are designed to read and write primitive data types. Both classes preserve the
encoding scheme, which is by default UTF-8, during read and write operations. BinaryReader and
BinaryWriter are recommended for reading and writing data where the underlying precision of the
data type in the data needs to be preserved.
This feature is implemented by providing a collection of ReadXXX and overloaded Write methods
that are specialized for reading or writing data of a particular data type. The following code demon-
strates how to read and write ISIN data in the form of binary values:
using System;
using System.IO;
namespace BinaryExample
{
struct ISINRecordC H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 121
{
public string isinCode;
public char securityType;
public double faceValue;
public long lotSize;
}
class BinaryExample
{
[STAThread]
static void Main(string[] args)
{
string filePath = @"C:\CodeExample\Chpt3\isin.dat";
//Initialize the ISIN data
ISINRecord newRecord = new ISINRecord();
newRecord.isinCode = "US5949181045";
newRecord.faceValue = 10;
newRecord.lotSize = 100;
//Open binary file for writing
FileStream fStream = new
FileStream(filePath,FileMode.CreateNew,FileAccess.Write);
//Create a binary writer
BinaryWriter bwrt = new BinaryWriter(fStream);
//write ISIN data
bwrt.Write(newRecord.isinCode);
bwrt.Write(newRecord.securityType);
bwrt.Write(newRecord.faceValue);
bwrt.Write(newRecord.lotSize);
//Close the stream
fStream.Close();
ISINRecord isinRecord;
//Open the binary file
fStream = new FileStream(filePath,FileMode.Open,FileAccess.Read);
//Create a binary reader
BinaryReader br = new BinaryReader(fStream);
//read ISIN code
isinRecord.isinCode= br.ReadString();
//read security type
isinRecord.securityType= br.ReadChar();
//read face value
isinRecord.faceValue= br.ReadDouble();
//read lot size
isinRecord.lotSize = br.ReadInt32();
}
}
}
XmlReader and XmlWriter
Considering the popularity of XML, the .NET Framework introduced two additional special-purpose
XML classes that understand the well-formed discipline of XML data. These classes have been designed
from the ground up to gain performance. The next sections discuss these classes and their important
members in detail.122C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
Looking at the Types of Parsers
The .NET Framework provides several ways to read an XML document by offering different types of
XML parsers. In the pre-.NET days, the only way to read an XML document was to install a separate
set of Microsoft XML libraries. With the advent of .NET, XML parsers are built in and bundled as part
of the framework, and hence no additional deployment is required. The core responsibility of these
parsers is to ensure that each document adheres to the XML discipline and vocabulary, mainly veri-
fying whether the document is well-formed. If the document fails to meet the well-formed criteria,
then it provides a detailed error message in the form of a .NET exception. These exceptions provide
the appropriate element name or attribute name in which the structural inconsistency was found.
The parsers are realized in a separate class altogether, and they provide rich functionality in the form
of members and properties that allow you to tweak every nook and cranny of an XML document.
XML parsers are broadly categorized into two forms, discussed in the following sections.
Tree-Based Parser
A tree-based parser is drawn upon a tree-based model. It loads an XML document as an in-memory
collection of objects that are arranged hierarchically. This parser is similar to the TreeView widget,
which we have all worked with in some form or the other. The TreeView widget provides a program-
matic way of traversing and manipulating every node in a tree. An XML document is intrinsically
structured in a tree form. Therefore, every element and attribute is accessible in the form of a con-
crete node object. An element may become a parent node or leaf node based on the number of child
elements. From an object-oriented perspective, an XML document represents a tree of objects. This
parser has both an upside and a downside. It is extremely unhealthy for the application if the XML
document is massive in size. The entire document needs to be flattened in memory, which means
that loading several large documents will tax both the memory and the efficiency of the application.
On a brighter side, this parser is highly suited for hosting a low-end mini–data store, thus avoiding
the need for a mid-scale database engine. Most commonly used application data is persisted in an
XML file and fetched into memory with the help of this parser. A tree-based parser is realized in the
form of an XML Document Object Model (XML DOM) parser. This parser is part of the .NET Frame-
work and available in the form of the System.Xml.XmlDocument class.
Fast-Forward Parser
This parser is the equivalent of a server-side fast-forward database cursor. The fast-forward nature
of the cursor makes it highly efficient when it comes to iterating a large number of records. The only
caveat is that it provides access to only one record at a time. A forward-only XML parser inherits the
same behavior of a database cursor. It too provides access to only one node at a time. This is in sharp
contrast to a tree-based parser, which allows free-flow navigation from the top to the bottom of
a tree, or vice versa. This stateless nature of parsers offloads the responsibility of retaining the state
of a document to the caller. The most unique benefit this parser offers is that it demands a slim
memory footprint, which makes it highly attractive when it comes to reading huge documents.
A forward-only parser is available in the following two flavors. These flavors are differentiated based
on how the data is made available to the application.
Push: A parser of this type publishes data to the application using a callback mechanism. Appli-
cations interested in reading XML documents must register a callback handler with a parser,
and this handler is invoked whenever a node in the document is visited. The parser controls
the modus operandi of reading the document. Hence, it is more parser driven than application
driven. Simple API for XML (SAX) parsers fall under this category and are designed specifically
to overcome problems faced in the DOM, primarily the memory issue. Even though the .NET
Framework has no direct support for SAX parsers, they are still available as part of the Microsoft
XML 4.0 COM Library.C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 123
Pull: Pull-based parsers are application driven and not parser driven. They provide unstinted
and unconditional control to applications. Only applications have the sole authority over inter-
ested elements or attributes and are free to discard the remaining unwanted information. The
.NET Framework bundles this type of parser in the form of the System.Xml.XmlReader class,
which is explained in detail later in this section.
Thus, .NET provides the best of both worlds; it has support for tree-based parsers (XmlDocument)
and fast-forward parsers (XmlReader). There are no hard-and-fast rules about which parser is good;
rather, the decision of which parser to apply is driven by the scenario because each parser has its
own unique selling points. Although there is no out-of-the-box support for the SAX parser in .NET,
given the extensibility mechanism the XmlReader class offers, it is easy to emulate SAX-based behavior.
Table 3-7 summarizes the important features each parser provides.
Table 3-7. Important Parser Features
Feature Tree-Based Parser (DOM) Push (SAX) Pull (XmlReader)
Memory footprint Fat Slim Slim
Cached? Yes No No
Navigation Free flow One-way (forward only) One-way (forward only)
Ownership Application driven Parser driven Application driven
W3C industry Yes Yes No
standard?
Functionality Rich Limited Limited
Read/write Read and write Read Read
Reading XML
The necessary ingredients required to read an XML document are enclosed in the XmlReader class.
XmlReader and all the other important classes related to XML are packaged inside the System.Xml
namespace. This is an abstract class that provides general-purpose functionality and delegates
other specific functionality to its descendants. This abstract class is interweaved with a common
set of methods and properties that allow the navigation and inspection of every node in an XML
document. XmlReader has three concrete inherited classes: XmlTextReader, XmlValidatingReader,
and XmlNodeReader. Each of these concrete classes is refined to meet the different goals of an XML
document.
XmlValidatingReader is used when a document needs to be validated with an XML Schema
Document (XSD); this is discussed later in the “Introducing XML Schema Document (XSD)” section.
XmlNodeReader reads XML content from XmlNode. XmlNode is a fragment that is extracted from a DOM-
based XML document. Similarly, XmlTextReader allows the reading of XML content from a stream or
file on a file system. It supports forward-only navigation and provides read-only access to a document.
This one-way, fast-forward nature makes XmlTextReader extremely lightweight in terms of memory
consumption and allows a large document to easily fit in. However, an inherent constraint at
the framework level restricts the size of the file to be smaller than 2GB. Besides this limitation,
XmlTextReader is ideal when the XML content needs to be processed quickly to extract data that in
turn must be provided to an intermediate in-memory data store.
We will now demonstrate how to write your first version of XML-aware code using XmlTextReader.
Listing 3-4 reads the XML version of the ISIN master file to populate an intermediate in-memory
data store.124C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
Listing 3-4. Reading the XML Version of the ISIN Master
using System;
using System.Collections;
using System.Xml;
class ReadXml
{
//ISIN Domain Model
public class ISINInfo
{
public string Symbol;
public double FaceValue;
public int MarketLot;
public ArrayList exchangeList = new ArrayList();
}
//Exchange Domain Model
//that holds exchange-specific instrument
//code for a particular ISIN
public class ExchangeInfo
{
public string ExchangeCode;
public string ScripCode;
}
[STAThread]
static void Main(string[] args)
{
//declare ArrayList for the in-memory data store
ArrayList isinDataStore = new ArrayList();
//ISINMaster XML path
string xmlPath = @"C:\CodeExample\Chpt3\ReadXml\ISINMaster.xml";
//Create Xml text reader
XmlTextReader txtReader = new XmlTextReader(xmlPath);
//loop until we have read the entire file
//returns true as long as there is content to be read
while ( txtReader.Read() )
{
//check the type of node that we just read to be an Element type
switch(txtReader.NodeType)
{
case XmlNodeType.Element:
//check the name of the current node being read
//If ISIN node is read
if ( txtReader.LocalName == "ISIN" )
{
//create an instance of the ISINInfo class, and
//assign various properties by querying attribute
//nodes of the ISIN element
ISINInfo isinInfo = new ISINInfo();
isinInfo.Symbol = txtReader.GetAttribute("Symbol");
isinInfo.FaceValue =
XmlConvert.ToDouble(txtReader.GetAttribute("FaceValue"));
isinInfo.MarketLot =
XmlConvert.ToInt32(txtReader.GetAttribute("MarketLot"));C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 125
isinDataStore.Add(isinInfo);
}
//If Exchange node is read
if ( txtReader.LocalName == "Exchange" )
{
//Get reference to latest isin instance added in arraylist
ISINInfo isinInfo =
isinDataStore[isinDataStore.Count - 1] as ISINInfo;
//create instance of exchange, and assign various
//properties by querying attribute node of exchange element
ExchangeInfo exchInfo = new ExchangeInfo();
exchInfo.ExchangeCode = txtReader.GetAttribute("Code");
exchInfo.ScripCode = txtReader.GetAttribute("ScripCode");
//add exchange instance into isin exchange list
//reflects isin-exchange mapping
isinInfo.exchangeList.Add(exchInfo);
}
break;
default:
break;
}
}
//close the text reader
txtReader.Close();
//Display the ISIN
foreach(ISINInfo isin in isinDataStore)
{
Console.WriteLine("ISIN :" +isin.Symbol);
//Display Exchange
foreach(ExchangeInfo exchange in isin.exchangeList)
{
Console.WriteLine("Exchange {0} Scrip Code {1} ",
exchange.ExchangeCode,exchange.ScripCode);
}
}
}
}
In Listing 3-4, the first line of code declares an ArrayList that represents an in-memory data
store. The array collection holds object instances of ISINInfo, which is basically an object-oriented
representation of the ISIN element, fetched from the XML file. ISINInfo also references the ExchangeInfo
class, which is an object-oriented representation of the Exchange element defined under the ISIN element.
The XML reading process starts with the instantiation of the XmlTextReader class, which accepts
a full path of the XML file. The next line of code is a while loop that gets triggered by invoking the Read
method of the XmlTextReader class. This method is the analog to a database cursor row pointer that
knows the current row position in a cursor; similarly, the internal implementation of the Read method
is such that it also knows the current node position. Thus, the repeated invocation of this method
increments its internal position pointer and moves it to the next node in the XML document. The
Read method returns a Boolean value to indicate whether a read request was successful in locating
the next node in the XML document. A return value of false indicates the end of the file and also
the criteria for exiting the loop. Also, an important point to note is that the Read method navigates
node by node, and the XML attributes are not considered to be nodes; instead, attributes are treated
as the auxiliary information of a node. Figure 3-6 depicts a graphical representation of a node vis-
ited in the while loop code.126C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
Figure 3-6. Graphical representation of while loop code
In Figure 3-6, both start and end tags are considered to be nodes and therefore must be excluded
from the evaluation logic. You can do this with the help of the NodeType property. This property returns
the type of the visited node, and a list of all possible node types is supplied by the XmlNodeType enu-
meration. Because you are interested only in the ISIN and Exchange elements that contain the required
domain information, you narrow the evaluation logic by favoring only the XmlNodeType.Element node
and specifically checking for the existence of both these elements by querying the LocalName property.
This property returns the name of the current node; in this example, it returns the name of the element.
So, when the code encounters ISIN and Exchange elements, it enters a conditional block of code
that instantiates an appropriate object based on the element name. Elements are just tags to the core
information that resides inside an XML attribute. The essential information in this case is stored inside
Symbol, FaceValue, and MarketLot attributes that are extracted with the help of the GetAttribute
method by passing the correct attribute name. The return value of the GetAttribute method is of
string type and needs to be converted to the object field’s underlying type. The type conversion takes
place with the help of the XmlConvert class. This class is introduced to achieve a locale-independent
conversion and to respect the XSD data type specification. With the help of the XmlConvert class, the
attribute value is converted to the appropriate underlying CLR type, is assigned to the newly instan-
tiated object field, and finally is inserted into an in-memory data store.
It is also essential to handle the whitespace encountered while reading an XML document.
Although in Figure 3-6 whitespace is not discussed explicitly, it is considered a distinct node and
therefore forms part of the read iteration process. If efficiency is the key goal of an application where
every bit of performance is counted, then it is recommended that you turn off the processing for
whitespace nodes using the WhiteSpaceHandling property.
The XmlTextReader class houses several other important members and properties that are useful
for handling XML documents from all dimensions. Most of the members and properties are bound
contextually, which means their values are dynamic and populated based on the current node.
Table 3-8 lists some of the important properties of the XmlTextReader class. Table 3-9 lists the impor-
tant methods supported by XmlTextReader, and Table 3-10 lists the navigation methods.
Table 3-8. Important Properties of the XmlTextReader Class
Properties Description
AttributeCount This property returns the total number of attributes in the current node.
BaseURI This property is useful for determining the location of an XML document.
Depth The XML document is structured in a tree-based fashion, and every element or
attribute in the tree belongs to a particular level in the tree. This property
returns the tree level of the current node.
EOF This is useful to determine whether the stream has finished reading the entire
document and its position pointer has reached the end of the file.
HasAttribute This property indicates whether the current node has any attributes.
IsEmptyElement This property comes in handy when you need to know whether the current
node is an empty element. For example, in the ISIN master, an occurrence of
text such as <ISIN/> represents an empty element.C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 127
Table 3-9. Important Methods of the XmlTextReader Class
Members Description
Skip When invoked, this method skips all the children in the current node, and the node
pointer is positioned on the next element in the tree level. For example, if the node
pointer was positioned on the Exchanges element and the Skip method was invoked,
the node pointer skips the entire children node branching under this element, thereby
skipping all Exchange elements. Therefore, the node pointer directly jumps to the end
node of the ISINMaster element.
Table 3-10. Navigation Methods of the XmlTextReader Class
Navigation Members Description
MoveToAttribute This is an overloaded method that allows navigation to a specific
attribute by passing its attribute name or attribute index position
within the element node.
MoveToFirstAttribute This moves to the first attribute in the element node.
MoveToNextAttribute This moves to the next attribute in the element node. Both
MoveToFirstAttribute and MoveToNextAttribute return a Boolean value
that indicates whether traversal to the next attribute was successful.
MoveToElement This method is useful to reset the navigation pointer to the element in
the current attribute node.
To further illustrate the application of navigation methods, we’ll show how to add some intelli-
gence to the parsing code. The current parsing code is well-crafted to read mandatory information;
ISIN-related information is built upon Symbol, FaceValue, and MarketLot attributes, and Exchange-
related information is built upon Code and ScripCode attributes. The following code introduces an
additional visual cue in the Exchange element-processing block that will display unwanted informa-
tion that surfaces in the form of unknown XML attributes:
using System;
using System.Xml;
class NodeNavigation
{
[STAThread]
static void Main(string[] args)
{
//ISINMaster Xml path
string xmlPath = @"C:\CodeExample\Chpt3\ReadXml\ISINMaster.xml";
//Create Xml text reader
XmlTextReader txtReader = new XmlTextReader(xmlPath);
//loop until we have read the entire file
//returns true as long as there is content to be read
while ( txtReader.Read() )
{
switch(txtReader.NodeType)
{
case XmlNodeType.Element:
//If Exchange node is read
if ( txtReader.LocalName == "Exchange" )
{
//Iterate through all attributes of the exchange element128C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
for(int ctr=0;ctr<=txtReader.AttributeCount-1;ctr++)
{
//Move to attribute with specified index
txtReader.MoveToAttribute(ctr);
//display additional unwanted attribute
if ( !(txtReader.Name == "Code" || txtReader.Name == "ScripCode"))
{
Console.WriteLine("Unknown Attribute Node "
+txtReader.Name +" Found ");
Console.WriteLine("Attribute Value : " +txtReader.Value);
}
}
}
break;
default:
break;
}
}
}
}
You have seen that XmlTextReader is XML-oriented and can extract XML-based data from any
given underlying file or stream. The only feature it does not support is writing XML data that is
separated in an XmlTextWriter class, as discussed in the next section.
Writing XML
We see two classifications of developers in our day-to-day work. The first category is adventurous and
is always in search of some new programming tools and techniques that will be eagerly implemented
in their day-to-day development routines. The second category is more narrow minded and reluctant
to adopt new approaches. This classification also applies to writing XML documents. XML docu-
ments, because of their text-centric characteristics, can be easily crafted by concatenating a bunch
of strings. Such an approach will be happily implemented by the second category of developers
using the StringBuilder class. With this approach, although it meets the goal of churning out a well-
formed XML document, in reality a lot of time and effort is invested in ensuring that the final output
adheres to the XML standards. There are high possibilities for errors, such as missing end tags, missing
quotes, and so on.
When adventurous developers look into the .NET Framework, they will discover a new
class—XmlWriter—as part of the System.Xml namespace. It is an abstract base class that provides
a forward-only and noncached way of generating XML documents. Using this class, developers no
longer have to worry about missing angled brackets or missing quotes. The XmlWriter class provides
the logic that will help build a well-formed XML document. It offers several versions of WriteXXX
methods for each possible XML node type.
XmlTextWriter is the immediate specialization of the XmlWriter class. This class writes XML
output to a stream or file in a file system. Listing 3-5 illustrates how to use this class by reading the
object-oriented format of ISIN data and persisting it in an XML document.
Listing 3-5. Writing the ISIN Master XML Document
using System;
using System.Collections;
using System.Xml;
using System.Text;C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 129
class WritingXml
{
public class ExchangeInfo
{
public string ExchangeCode;
public string ScripCode;
}
public class ISINInfo
{
public string Symbol;
public double FaceValue;
public int MarketLot;
public ArrayList exchangeList = new ArrayList();
}
[STAThread]
static void Main(string[] args)
{
//initialize in-memory isin data store
ArrayList isinList = new ArrayList();
//create isin
ISINInfo isinInfo = new ISINInfo();
isinInfo.Symbol ="MSFT";
isinInfo.FaceValue = 10;
isinInfo.MarketLot = 5;
//create exchange
ExchangeInfo nasdaqInfo = new ExchangeInfo();
nasdaqInfo.ExchangeCode = "NASDAQ";
nasdaqInfo.ScripCode = "MSFT.O";
//add exchange to isin exchange list
isinInfo.exchangeList.Add(nasdaqInfo);
//add isin to array list
isinList.Add(isinInfo);
//create XML text writer
XmlTextWriter xmlWriter = new
XmlTextWriter(@"C:\ISINMaster.xml",Encoding.UTF8);
xmlWriter.Formatting = Formatting.Indented;
//write the root element
xmlWriter.WriteStartElement("ISINMaster");
//iterate through individual isin
foreach(ISINInfo curIsin in isinList)
{
//write isin element
xmlWriter.WriteStartElement("ISIN");
//write attributes of isin
xmlWriter.WriteAttributeString("Symbol",curIsin.Symbol);
xmlWriter.WriteAttributeString("FaceValue",
XmlConvert.ToString(curIsin.FaceValue));
xmlWriter.WriteAttributeString("MarketLot",
XmlConvert.ToString(curIsin.MarketLot));
//write parent element of exchange130C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
xmlWriter.WriteStartElement("Exchanges");
//iterate through individual exchange
foreach(ExchangeInfo curExchange in curIsin.exchangeList)
{
//write exchange element
xmlWriter.WriteStartElement("Exchange");
//write attributes of exchange
xmlWriter.WriteAttributeString("Code",curExchange.ExchangeCode);
xmlWriter.WriteAttributeString("ScripCode",curExchange.ScripCode);
xmlWriter.WriteEndElement();
}
//exchange end tag
xmlWriter.WriteEndElement();
//exchanges end tag
xmlWriter.WriteEndElement();
}
//root end tag
xmlWriter.WriteEndElement();
//close xml text writer
xmlWriter.Close();
}
}
In Listing 3-5, first an XmlTextWriter object is instantiated by passing the path of the file to
which the XML output is redirected. The next line of code is where the XML writing journey begins;
first the root element of the document is written with the help of the WriteStartElement method.
The method name that starts with WriteStartXXX is called a paired method. The first leg of the
paired method represents the start of the node with WriteStartElement and WriteStartAttribute,
and the final leg indicates the end of the node with WriteEndElement and WriteEndAttribute. So,
every WriteStartXX method has a corresponding WriteEndXX method.
After generating an opening angled bracket for the ISINMaster element, the program enters
into a loop that reads the ISIN master from an in-memory ArrayList data store. The ISIN element is
emitted with the help of WriteStartElement. Information about ISIN—such as Symbol, FaceValue, and
MarketLot—forms part of the XML attribute, and this information is written out with the help of the
WriteAttributeString method.
You also use the same approach to generate the Exchange information that is inside a nested loop
associated with the current ISIN. When the code exits from the nested loop, the WriteEndElement
method is invoked two times. The first invocation is meant to close the Exchanges element, and the last
invocation is meant to close the ISIN element. The code also includes a final call to WriteEndElement
to close the root element.
Observe that the code described in Listing 3-5 does not concatenate the strings to generate the
XML document; instead, it leverages the XmlTextWriter class. This guarantees that the generated
final document adheres to the well-formed XML standard. Table 3-11 lists the important members
available in the XmlTextWriter class, and Table 3-12 lists the important formatting properties.C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 131
Table 3-11. Important Members of the XmlTextWriter Class
Members Description
WriteComment This member provides XML-style comments, such as <!--...-->. The
comments are passed as a string argument to this method.
WriteBase64 A Base64 encoding scheme is used to convert binary data into ASCII characters.
XML documents do not support raw binary data; only ASCII characters are allowed
as part of an element value or attribute value. The only mechanism to embed
binary data inside an XML document is to convert it into a Base64 encoding
scheme. The WriteBase64 method accepts a byte array as the method argument
and encodes this byte array to Base64 format.
Table 3-12. Important Formatting Properties of the XmlTextWriter Class
Formatting Properties Description
Formatting This property indicates how the XML output must be formatted, and an
appropriate value is assigned using the Formatting enumeration. The
possible Formatting enumeration values are None and Indented. By default
no formatting is performed, so when the document is opened in Notepad,
or any other text editor, the content is arranged in a series of lines instead
of in a hierarchical arrangement.
IndentChar This property defines the character used for indenting.
Indentation This property defines the number of IndentChar to be written at each
level in the hierarchy.
QuoteChar This defines the quotation mark character to be used to enclose the
attribute value.
XmlReader and XmlWriter form the core classes in the .NET Framework. Although they are inde-
pendent classes, encapsulating read and write operations in a distinct, separate class allows for the
cleaner separation of responsibilities. You can extend both of these classes to read and write non-XML
data. XmlReader and XmlWriter also provide a strong foundation for designing other XML-based services
such as XML integration in ADO.NET, XML serialization, and so on.
Introducing XML Serialization
Modern systems are modeled around the basic tenets of object-oriented programming where business
requirements are distilled into fine, granular objects. Undoubtedly, object-oriented programming
models are safe bets when the scope of communication is confined to the local periphery of an
application. But in today’s era, the automation of organizations is built upon disparate systems, and
exchanging data between such systems is a major bottleneck. The data required for the exchange
purpose is in place and also encapsulated inside an object, but the object itself is a runtime representa-
tion and affiliated to a specific runtime system and operating system. For example, an object instantiated
by a .NET system cannot be passed, as is, to a Java-based system. This demands a mechanism to
hydrate an in-memory representation of an object that can be easily understood by another system.
Serialization is the process of flattening the in-memory object state into a common representation
format that can be easily transferred over the wire or persisted to a stream. Similarly, deserialization
is the reverse ability to resurrect an in-memory object state from disk storage or any other in-memory
data source. The serialization and deserialization process is managed by the serialization engine,132C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
which defines the scope of the object to be serialized and the format of the serialized object. The
serialization engine not only provides the ability to serialize a given object but also conducts a deep
traversal of objects to flush out the entire object graph contents. The serialization engine primarily
operates in two modes:
Full-type fidelity mode: In this mode, the object’s state and its contextual information or object
identity information is serialized. For example, when a .NET type is serialized in full-type fidelity
mode, the object’s public and private fields—along with its assembly information such as the
assembly name, its version number, public key, and assembly culture—also get recorded. The
serialization engine enforces stringent norms during the deserialization phase in this mode.
An object serialized in one context can be resurrected only when the context at the deserializing
end matches the serialized context. Hence, the serialization engine in this mode (in such types)
is context-centric; therefore, even if there are no changes in the structure of an object, minor
assembly version number increments are sufficient to invalidate the deserialization process.
This mode is useful in a distributed environment where both the client and the server are physically
separated and the types shared between them demand a strict versioning policy.
Partial-type fidelity mode: In partial-type fidelity mode, only the object state is serialized;
contextual information is completely sidelined during the deserialization phase.
Three types of serialization engines are built in and readily available within the .NET Framework:
Binary serializer: The binary serializer is one of the fastest serializers that hydrates object state
into raw bytes, and vice versa. The raw bytes generated are compact in size and highly efficient
for transfer over the wire. Binary serialization is achieved with the help of the BinaryFormatter
class and is used heavily by the .NET Remoting Communication Infrastructure.
SOAP serializer: The SOAP serializer converts object state into SOAP messages that are designed
upon XML standards. The primary goal of this serializer is to achieve platform neutrality. SOAP
serialization is achieved with the help of the SoapFormatter class.
XML serializer: The XML serializer serializes object state into XML format. The behavior of this
serializer is controlled with the help of .NET attributes and has pioneered a new declarative
style of programming.
The declarative style of programming is a novel approach introduced in the C# programming
language. It allows annotating additional information called attributes. Attributes are simply infor-
mation markers or additional metadata associated with programming elements such as types, fields,
methods, and properties. This metadata augments the functionality of the entity to which it is applied.
With the help of the .NET reflection technique, these attributes can be easily queried or inspected,
and the appropriate interpretation of the attributes can be performed during either runtime or
compile time. Attributes complement the existing coding syntax by allowing a cleaner approach.
You do this by decoupling the core logic from the consumer class and allowing the consumer class
to consume this logic by explicitly expressing it in the form of attributes. Attributes are easy to debug
and locate because of their placement rule; they are allowed only before the declaration of any pro-
gramming element. Attributes are deeply rooted in the .NET Framework and can handle a variety of
tasks such as assembly versioning information, code access security, and so on.
Listing 3-6 demonstrates how to use attributes.
Listing 3-6. Using Attributes
[Serializable]
public class ISINInfo
{
public string Symbol;
public double FaceValue;C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 133
public int MarketLot;
public ArrayList exchangeList = new ArrayList();
}
In Listing 3-6, you will notice an attribute named Serializable annotated on the ISINInfo type.
By annotating this attribute, you augment the functionality of the ISINInfo type by allowing its object
instances to be serializable. Attributes themselves are object instances of the Attribute class. Attri-
butes are further classified into custom attributes and pseudo-attributes. Custom attributes are defined
by developers, and pseudo-attributes are system-level attributes defined by the CLR. Now that you
know about the fundamentals of attributes, you can look at the XmlSerializer class where attributes
play an important role in achieving serialization.
XmlSerializer is housed inside the System.Xml.Serialization namespace. It mediates between
a CLR type and an XML document and weaves some plumbing code that allows for the seamless
translation between a CLR type and an XML document, and vice versa. This plumbing code is gen-
erated based on a set of known mapping rules that are defined with the help of an XML serialization
attribute that is explained shortly. Attributes are placed on the class property or on fields. Once they
are defined, they form input to the XML serialization engine, which dictates how to persist the value
of the field or property in XML format—whether to represent the field or property as an XML element
or an attribute. Also, certain attributes are driven by the underlying data type of the field or property.
They provide additional hints to the XML serialization engine about how to handle a complex data
type associated with a field or property. To illustrate this mechanism, let’s return to the topic of
XML content being read using the XmlReader class. You can achieve the same task with the help
of XmlSerializer.
But before that, the following classes need to be persist aware, which is achieved with the help
of attributes:
public class ISINInfo
{
[XmlAttribute("Symbol")]
public string Symbol;
[XmlAttribute("FaceValue")]
public double FaceValue;
[XmlAttribute("MarketLot")]
public int MarketLot;
[XmlArray("Exchanges")]
[XmlArrayItem("Exchange",
typeof(ExchangeInfo))]
public ArrayList exchangeList =
new ArrayList();
}
public class ExchangeInfo
{
[XmlAttribute("Code")]
public string ExchangeCode;
[XmlAttribute("ScripCode")]
public string ScripCode;
}
[XmlRoot("ISINMaster")]
public class ISINDataStore
{
private ISINInfo[] isinStore;134C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
[XmlArray("ISINS")]
[XmlArrayItem("ISIN",typeof(ISINInfo))]
public ISINInfo[] Items
{
get{return isinStore;}
set{isinStore=value;}
}
}
The only noticeable change is the recruitment of appropriate attributes. You should note that
at this point no structural changes have been made to the class in any form either by injecting a new
method or by deriving from any existing base classes. Attributes were the only ingredients that were
needed to mix with your class to achieve XML serialization. Table 3-13 describes individual attributes
in detail.
Table 3-13. Attributes and Their Descriptions
Attribute Name Description
XmlRoot The valid programming element for this attribute is a CLR type. This attribute
represents the root element of an XML document. In the example, ISINMaster
is the root element, and therefore you declared this attribute on the
ISINDataStore type.
XmlAttribute This attribute is used on a class public field or property. It accepts the attribute
name as part of the argument and persists the value of the field or property to
an XML attribute node type. Referring to the previous ISINInfo class, the public
field is decorated with XmlAttribute, which in turn gets mapped to the attribute
node type when represented in the XML document form.
XmlElement This attribute maps the field or property value to an XML element node.
XmlIgnore This is a useful attribute, and it comes in handy when sensitive or unwanted
information needs to be excluded from getting serialized. When this attribute
is annotated on a public field or property, the serialization engine completely
ignores it, and the value of the field or property will not be serialized in any form.
XmlArray These two attributes go hand in hand and are promising when the field or
XmlArrayItem property to be serialized returns an array of objects. The definition of an array
in this context is any class that implements the IEnumerable interface. This
expands the list of classes that are serializable from a simple primitive array to
a complex collection of objects. If you look closely at the ISINDataStore and
ISINInfo classes, you will find the presence of these attributes declared on a field
of the ArrayList data type. We all know that there will be multiple occurrences
of ISIN, with each ISIN holding multiple Exchange records. Such one-to-many
mappings between ISIN and Exchange can be achieved in conjunction with the
XmlArray and XmlArrayItem attributes.
XmlArray also allows you to define the name of the parent element node, and
XmlArrayItem allows you to define the name of the inner child element node of
this parent node. The XmlArrayItem attribute also allows the mapping of the inner
child element node to the appropriate CLR type.
XmlEnum This attribute allows you to tweak the serialization of enumeration values.
XmlAnyAttribute This attribute is annotated on a field or property that returns an array of
XmlAttribute. This array acts as a generic container for storing all attributes
that do not have a corresponding mapped field or property.
XmlAnyElement This attribute is annotated on a field or property that returns an array of XmlNode
or XmlElement. The array acts as a generic container for storing all elements that
do not have a corresponding mapped field or property.C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 135
Now that you have a clear understanding of serialization attributes, let’s look at its application.
So far, you used XmlTextReader and XmlTextWriter for reading and writing XML-based data. Using
XmlTextReader, you read an XML document from a stream and traversed each node, and in the process
you extracted the appropriate node value and assigned it to an object public field. You did exactly
the reverse using XmlTextWriter, where object fields were assigned to an appropriate XML node,
and generated a well-formed XML document. The only downside with this approach is that you need
to manually hand-roll the code to “XMLify” object fields. With XmlSerializer in action, you are relieved
from having to write low-level parsing code; you can achieve the same task with a minimum amount
of code. The following snippet demonstrates both serialization and deserialization:
using System;
using System.Collections;
using System.Xml.Serialization;
using System.IO;
public class XmlPersist
{
[XmlRoot("ISINMaster")]
public class ISINDataStore
{
[XmlArray("ISINS")]
[XmlArrayItem("ISIN",typeof(ISINInfo))]
public ArrayList isinStore = new ArrayList();
}
public class ISINInfo
{
[XmlAttribute("Symbol")]
public string Symbol;
[XmlAttribute("FaceValue")]
public double FaceValue;
[XmlAttribute("MarketLot")]
public int MarketLot;
[XmlArray("Exchanges")]
[XmlArrayItem("Exchange",typeof(ExchangeInfo))]
public ArrayList exchangeList = new ArrayList();
}
public class ExchangeInfo
{
[XmlAttribute("Code")]
public string ExchangeCode;
[XmlAttribute("ScripCode")]
public string ScripCode;
}
[STAThread]
static void Main(string[] args)
{
string isinPath = @"C:\CodeExample\Chpt3\XmlSerialization\ISINMaster.xml";
//read isin content
StreamReader xmlDoc = new StreamReader(isinPath);
//create a new instance of XML serializer
XmlSerializer isinXml = new XmlSerializer(typeof(ISINDataStore));
//deserialize isin master136C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
ISINDataStore dataStore = isinXml.Deserialize(xmlDoc) as ISINDataStore;
//write isin content
StreamWriter newXmlDoc = new StreamWriter(@"C:\NewISINMaster.xml");
//serialize isin master
isinXml.Serialize(newXmlDoc,dataStore);
//close the stream
xmlDoc.Close();
newXmlDoc.Close();
}
}
The Serialize and DeSerialize methods of the XmlSerializer class dictate the serialization
and deserialization of any arbitrary type. The arbitrary type is supplied as a constructor argument to
the XmlSerializer class. Based on this arbitrary type, XmlSerializer implements a just-in-time
code-cutting technique that generates code by reflecting a class public field and property that need
to be serialized, and then XmlSerializer compiles this code into a .NET assembly that is loaded in
the program’s memory. Furthermore, the underlying source from which data is fetched during the
deserialization phase or persisted during the serialization phase could be any valid Stream object.
Chapter 8 describes the inner workings of the XmlSerializer class in detail.
The XmlSerializer class is a powerful weapon in a developer’s arsenal. Developers are often
faced with a requirement to sprinkle an XML layer over a runtime object, or vice versa. You can use
the XML serializer to achieve this layering by abstracting away the core complexities and not forcing
parsing code down the developer’s throat.
Introducing XML Schema Document (XSD)
Before getting into an explanation of XSD, we’ll cover the assumptions made in the ISIN master XML
document (refer to Listing 3-2). The XML version of the ISIN document poses some serious short-
comings that were overlooked during the parsing stage. Although you can overlook such negligence
in a perfect world where everything behaves in an expected manner, this is not true in the real com-
puting world. In the computing world, any action executed based on assumptions tends to be brittle
in nature. The following questions, when raised, are sufficient to cripple the strong assumptions used
to develop the parsing logic:
  What happens when an XML document deviates from the expected standard? For example,
what if there is no occurrence of an ISINMaster element or one of its child elements?
  What happens when the necessary information in the document is arranged in an
unordered fashion? For example, what if Exchange elements are nested under ISIN elements
instead of the Exchanges element?
  What happens when partial information is received from the XML document? For example,
what if a Symbol attribute is missing from an ISIN element?
  What happens when there is a data type mismatch? For example, what if the FaceValue
attribute of the ISIN element contains a string value instead of a numeric value?
  What happens when the ISIN master document contains extraneous information that bloats
up the size of the document and the visible side effect of such large document is negatively
impacted performance?
The previous questions often lead to a common syndrome that is directly related to document
structure validation and integrity. To overcome such problems, developers start building a whole
suite of validation frameworks to function across different XML node touch points. The addition of
a validation framework further increases the development time, and above all it shifts the mainC H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 137
focus of a developer. Instead of concentrating on building core domain components, the developer
is actively engaged in building a validating parser component. XML Schema comes to the rescue to
alleviate this parsing problem. It is one step ahead of parsing.
XML Schema is analogous to a database table in a relational database system. A database table
encapsulates the structural information of a row in the form of column definitions and also allows
the enforcement of data-level validations, such as defining primary keys, constraints, rules, and so on.
In the XML world, XML Schema mimics the functionality of a database table and defines the structural
and content aspects of an element and attribute in an XML document.
XML Schema enriches the value of an XML document by mainly capturing three types of
information:
Structural information: XML Schema defines the hierarchical arrangement of elements in the
XML document. It captures the names of elements and attributes that are considered to be
valid nodes in the document.
Content information: In XML documents, node values are represented in text that defaults the
underlying data type to string. With the help of XML Schema, it is possible to define the under-
lying data type of a node. XML Schema supports several data types and includes all primitive
types such as string, int, long, datetime, and so on.
Content restriction: XML Schema, along with its ability to define data types, provides the facility
to define constraints on the data type. For example, an integer data type could be further cus-
tomized to create a user-defined data type that accepts a restricted range of numbers.
XML Schema is defined using XML vocabulary and therefore in itself is an XML document. This
means it is a well-formed document, and like other XML documents, it can be loaded and inspected
by any XML parser. The only striking difference is that XSD is built on a fixed set of XML vocabulary
that is leveraged to define the structural model of an XML document. This vocabulary comprises a fixed
number of XML elements and attributes, and each of these markup nodes has its own distinct meaning
when it comes to validating an XML document. Listing 3-7 is a full-blown XML Schema of the ISIN
master.
Listing 3-7. XML Schema of the ISIN Master
<xs:schema id="ISINSchema" xmlns=""
xmlns:mstns="http://tempuri.org/ISINSchema.xsd"
xmlns:xs="http://www.w3.org/2001/XmlSchema">
<xs:complexType name="ISINModel">
<xs:sequence>
<xs:element name="Exchanges" type="ExchangesModel" />
</xs:sequence>
<xs:attribute name="Symbol" type="xs:string" use="required" />
<xs:attribute name="FaceValue" type="IntDataType" use="required" />
<xs:attribute name="MarketLot" type="IntDataType" use="required" />
<xs:attribute name="Status" type="StatusDataType" use="required" />
<xs:attribute name="ISINCode" type="ISINCodeDataType" use="required" />
</xs:complexType>
<xs:simpleType name="StatusDataType">
<xs:restriction base="xs:string">
<xs:enumeration value="Active" />
<xs:enumeration value="InActive" />
</xs:restriction>
</xs:simpleType>
<xs:complexType name="ExchangeModel">
<xs:sequence />
<xs:attribute name="Code" type="xs:string" use="required" />138C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
<xs:attribute name="ScripCode" type="xs:string" use="required" />
</xs:complexType>
<xs:element name="ISINMaster">
<xs:complexType>
<xs:sequence>
<xs:element name="ISIN" type="ISINModel"
minOccurs="1" maxOccurs="unbounded"/>
</xs:sequence>
</xs:complexType>
<xs:key name="PrimaryKeyISINCode">
<xs:selector xpath=".//ISIN" />
<xs:field xpath="@ISINCode" />
</xs:key>
</xs:element>
<xs:complexType name="ExchangesModel">
<xs:sequence>
<xs:element name="Exchange" type="ExchangeModel"
minOccurs="1" maxOccurs="unbounded" />
</xs:sequence>
</xs:complexType>
<xs:simpleType name="IntDataType">
<xs:restriction base="xs:int">
<xs:minExclusive value="0" />
</xs:restriction>
</xs:simpleType>
<xs:simpleType name="ISINCodeDataType">
<xs:restriction base="xs:string">
<xs:pattern value="US[A-Z0-9]*" />
<xs:length value="12" />
</xs:restriction>
</xs:simpleType>
</xs:schema>
In Listing 3-7, the declaration of xs:schema defines the root element of the XML Schema docu-
ment. Primarily, three types of elements nest under this xs:schema element:
Complex type elements: A complex type element describes the structural characteristics of the
XML elements. It is represented by the xs:complextype element and is composed of the following
information:
  A list of all attributes housed inside an element that is defined by the xs:attribute element.
This xs:attribute element also exposes a type attribute that allows you to associate the
underlying data type of the attribute value. The content of the attribute node can be
string, integer, or any custom data type.
  A list of all child elements defined with the help of compositor elements. Child elements
are represented by xs:element but are defined within the scope of the compositor element.
Compositors are also the driving force in ensuring elements are arranged in the appro-
priate order. Compositor elements are nested under the xs:complextype element. The
xs:sequence element is a commonly used compositor element, and it directs the order of
the nested child elements. Furthermore, xs:element also allows you to define the occur-
rence constraint that controls the minimum and maximum number of child elements. This
element range restriction is fed to the minOccurs and maxOccurs attributes of xs:element.C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 139
Simple type elements: Simple type elements provide the notion of user-defined data types. This
is inclined more toward content, unlike complex type elements that are centered on the structural
aspects of the content. Simple type elements are derivations of built-in data types, but they offer
additional flexibility to developers to customize this base data type to accept only a subset of
data. Such restriction on data is usually determined by business requirements. A simple type
element is analogous to a user-defined data type in a relational database and is represented by
the xs:simpletype element.
Document root elements: A root element is represented by xs:element, but it directly branches
as a child of the xs:schema element. This element determines the starting root element of the
underlying XML document.
Although manually designing XML Schema documents is time-consuming, this should not be
used as an excuse for not adopting this approach. The development community has addressed this
problem well, and hence you will find a plethora of XML Schema designing tools that make the job
easier by overcoming many challenges and drastically increasing productivity. The VS .NET IDE comes
with a sophisticated XML Schema designer tool. With a few clicks and a drag-and-drop interface, you
can quickly generate an XSD. In fact, the XML Schema described in Listing 3-7 was generated using
VS .NET Schema Designer.
We’ll now walk through the XML schema file described in Listing 3-8 and explain the one-to-one
mapping of individual schema elements with the ISIN XML document, which will further solidify your
understanding. The following is an XML fragment of the ISIN element described in Listing 3-2:
<ISIN ISINCode="US5949181045"
Symbol="MSFT"
FaceValue="10"
MarketLot="5"
Status="Active">
Listing 3-8. XML Schema of the ISIN Element
<xs:complexType name="ISINModel">
<xs:sequence>
<xs:element name="Exchanges" type="ExchangesModel" />
</xs:sequence>
<xs:attribute name="Symbol" type="xs:string" use="required"/>
<xs:attribute name="FaceValue" type="IntDataType" use="required"/>
<xs:attribute name="MarketLot" type="IntDataType" use="required"/>
<xs:attribute name="Status" type="StatusDataType" use="required"/>
<xs:attribute name="ISINCode" type="ISINCodeDataType"
use="required" />
<xs:simpleType name="StatusDataType">
<xs:restriction base="xs:string">
<xs:enumeration value="Active" />
<xs:enumeration value="InActive" />
</xs:restriction>
</xs:simpleType>
<xs:simpleType name="IntDataType">
<xs:restriction base="xs:int">
<xs:minExclusive value="0" />
</xs:restriction>
</xs:simpleType>
<xs:simpleType name="ISINCodeDataType">
<xs:restriction base="xs:string">140C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
<xs:pattern value="US[A-Z0-9]*" />
<xs:length value="12" />
</xs:restriction>
</xs:simpleType>
Listing 3-8 represents the structural model of the ISIN element. The ISIN element is defined as
a complex type and is named ISINModel. ISINModel also encloses mandatory attributes such as
FaceValue, Symbol, MarketLot, and Status. Also, notice the data type of the FaceValue, MarketLot, and
Status attributes. They are based on IntDataType and StatusDataType, which are simple types and are
customized to accept only restricted data.
Another good thing about the simple type is that it allows you to apply regular expressions on
data. The previous example, as part of the business validation check, defines a rule using the regular
expression syntax that states the ISIN code will always start with US as the first two characters and will
accept only uppercase characters along with numeric digits. The declaration of the attribute node is
further strengthened with the use attribute that instructs the schema parser to treat this attribute as
one of the mandatory attributes and also raise an exception when it fails to locate this attribute in the
XML document. You will also discover an element named Exchanges. The underlying complex type of
this element is ExchangesModel, which is as shown in Listing 3-9. Listing 3-10 represents the structural
model of the Exchange element that is enclosed inside the ExchangeModel complex type.
Listing 3-9. The Exchange Element
<Exchanges>
<Exchange
Code="NASDAQ"
ScripCode="NMSFT" />
Listing 3-10. XML Schema of the Exchange Element
<xs:complexType name="ExchangesModel">
<xs:sequence>
<xs:element name="Exchange" type="ExchangeModel"
minOccurs="1" maxOccurs="unbounded" />
</xs:sequence>
</xs:complexType>
<xs:complexType name="ExchangeModel">
<xs:sequence />
<xs:attribute name="Code" type="xs:string" use="required" />
<xs:attribute name="ScripCode" type="xs:string" use="required" />
</xs:complexType>
The Exchange element does not contain any child elements, so the only node it supports is Code
and the ScripCode attributes. Exchange elements are repeatable elements and hence appear multiple
times for a particular ISIN. Therefore, it is nested inside the Exchanges element that is schematically
mapped to the ExchangesModel complex style. The important attributes to observe are minOccurs and
maxOccurs associated with xs:element. These attributes control the minimum and maximum occur-
rences of the child elements. In Listing 3-10, we expressed a mandatory validation that there should
be at least one Exchange but no limit on the maximum number of Exchange. The next and final element
to be addressed is the root element, which is as follows:
<ISINMaster>
Listing 3-11 shows the XML Schema of the root element.C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 141
Listing 3-11. XML Schema of the Root Element
<xs:element name="ISINMaster">
<xs:complexType>
<xs:sequence>
<xs:element name="ISIN" type="ISINModel"
minOccurs="1" maxOccurs="unbounded" />
</xs:sequence>
</xs:complexType>
<xs:key name="PrimaryKeyISINCode">
<xs:selector xpath=".//ISIN" />
<xs:field xpath="@ISINCode" />
</xs:key>
</xs:element>
The root element of the XML document is ISINMaster, and in Listing 3-7 it is defined as a direct
descendant of the xs:schema element. The ISINMaster root element contains multiple ISIN elements,
and this arrangement is achieved with the help of xs:element named as ISIN, and the underlying
type of this element is mapped to ISINModel, which is a complex type. Another interesting thing to
note is that the validation of the XML document is further tightened by defining a primary key con-
straint on the ISIN code. The benefit of this constraint is reaped during the XML Schema validation
stage when the parser checks for the duplicate existence of the ISIN code.
This completes the discussion of the XML Schema. This discussion, so far, has focused on the
individual characteristics of both the XML and its underlying schema. In the following section, you
will see how to bring these two documents together. In addition, an XML document must satisfy
two important conditions. Along with its well-formed nature, it must also gain the status of a valid
document. You can accomplish this task by validating the document against the correct schema.
Thus, the desperate missing piece is the schema parser that carries an inherent knowledge of the
vocabulary in the XML Schema. The schema parser loads both the XML document and the schema
document in the memory. After loading, it reads each node from the document and validates both
the content and structure of this node against the schema document and ensures that the node is
not violating any rule and that it satisfies all the conditions expressed in the schema document. The
.NET Framework provides this kind of schema parser in the form of the XmlValidatingReader class.
XmlValidatingReader is also bundled in the System.Xml namespace along with the XmlReader
and XmlWriter classes. XmlValidatingReader is a direct descendant of the XmlReader class, and this
leaves no room for doubt that its data-reading tactics are based on the pull model. It reads data node
by node and then validates it against the specified schema specification. Such step-by-step validation
of each individual node, from a performance perspective, is highly rewarding. The following code
snippet represents the applicability of XmlValidatingReader that validates the ISIN master XML
document (see Listing 3-2) against the ISIN master schema file (see Listing 3-7):
using System;
using System.Xml;
using System.Xml.Schema;
class SchemaValidation
{
public static bool isDocumentValid=true;
[STAThread]
static void Main(string[] args)
{
string path = @"C:\CodeExample\Chpt3\SchemaValidation\";
//read ISIN XML
XmlTextReader reader = new XmlTextReader(path +"ISINMaster.xml");
//create schema validator
XmlValidatingReader validateReader = new XmlValidatingReader(reader);142C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
//associate validation event handler
validateReader.ValidationEventHandler +=new
System.Xml.Schema.ValidationEventHandler(ValidationEventHandler);
//add schema file path
validateReader.Schemas.Add("",path +"ISINSchema.xsd");
//validate the XML file with XSD
while(validateReader.Read())
{
if ( isDocumentValid == false )
break;
}
//check boolean value; the value of this variable
//is assigned in validation handler code
if ( isDocumentValid == true )
{
Console.WriteLine("Document is Valid...");
}
}
private static void ValidationEventHandler(object sender,
System.Xml.Schema.ValidationEventArgs e)
{
//error in XML document
isDocumentValid=false;
//display the error message
Console.WriteLine(e.Message);
}
}
XmlValidatingReader can read a schema document from a Stream or XmlTextReader. Since you
are already familiar with the XmlTextReader class, the previous code uses XmlTextReader, which maps
to the ISINMaster.xml file. This newly constructed XmlTextReader object is passed as a constructor
argument to the XmlValidatingReader class. The next line of code contains the error-handling code.
XmlValidatingReader exposes a ValidationEventHandler event that allows the chaining of a user-defined
method with the help of a delegate. This event gets bubbled up as soon as the XmlValidationReader
notices a structural ambiguity in the current processing node that does not adhere to a defined structure
or rules in the schema document. Because we have associated our own custom ValidationEventHandler
method with this event, we must have the necessary error handler code in place along with the correct
path of the XML document that needs to be validated. The only missing information is the path to
the schema file, and that is provided in the next line of code.
XmlValidatingReader provides a Schemas property. This property returns an XmlSchemaCollection
object, which is part of the System.Xml.Schema namespace. XmlSchemaCollection allows multiple
schema files to be inserted, and each of these schema files can be identified by a unique namespace.
In the previous code, the XML document does not contain a namespace; we have passed an empty
string as the namespace name along with an absolute path to the schema file. Once the necessary
information is provided to the XmlValidatingReader class, the document validation process starts
by declaring an empty body loop that traverses one node at a time. From each traversed node, the
XmlValidatingReader locates the structural information in the schema document and, if found, vali-
dates it for data sanctity. This happens even though you have not placed any code inside the read
loop. The exit criteria for this validating loop is reached either when the end of the file is encountered
or when a validation exception occurs because of a structural mismatch between the XML document
and schema document, which in turn raises the ValidationEventHandler and also internally triggersC H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 143
the registered error handler method. After exiting the loop, to indicate whether the document vali-
dation is successful, the value of the static Boolean variable is inspected. If the resulting value is true,
it indicates that no errors have been flagged by the parser, and hence the document can be considered
to be well-formed and valid. A false value assigned by the error-handling code indicates an invalid
XML document.
The XmlValidatingReader class and XML Schema addressed concerns relating to the data sanc-
tity of the ISIN master XML document. Looking closely at the previous code, notice that not even
a single line of code checks for node structural ambiguity or node content data type mismatch. You
have completely decoupled the data validation logic, expressed it in a schema document, and used
XmlValidatingReader to do the rest of the validation magic.
In summary, XML Schema is beneficial because it alleviates the need for programmatically val-
idating the content and structure of an XML document. The business community has adopted XML
Schema extensively; we all know that to trade, one party needs to sign a business contract with the
counterparty. In today’s information exchange world where most business is conducted electroni-
cally, it is important to have a data contract mutually agreed on by both parties. An XML Schema is
basically a kind of a data contract that is shared with all interested parties; based upon this contract,
information is prepared and exchanged.
Examining the Business-Technology Mapping
In this section, we will architect a data conversion framework to address the conversion needs. The
whole essence of this framework is to offer a service that is easy and friendly to use and brings higher
productivity to a developer. Developers no longer have to undergo the painful task of writing parsing
code to extract data from an unstructured file, which basically pollutes the code, losing code legibility,
and also becomes a daunting task to reverse engineer the logic from code. The most important goal
of the conversion framework is to weed out the parsing logic from the code and strongly motivate
developers to develop real code by applying the core domain knowledge on the parsed information.
In the financial world, information built on external data sources passes through the following
main stages:
Conversion: This is always the first stage and an entry point to this chain. This stage governs the
conversion rule that instructs how raw data needs to be managed. The input to this stage is the
raw data that is in an unstructured format, and the output from this stage is data in a structured
format that is mainly defined by the developer.
Cleansing: The primary responsibility of this layer is to perform data-level validation and fix
grammatical errors with the help of reference data. For example, consider the CSV version of
the ISIN master file (refer to Listing 3-1), which is converted to a user-defined format. During
this conversion process, the ISIN code is validated against the ISIN master repository. Assuming
that this repository is a table stored in a relational database and a query of ISIN code in this
central database results in an unsuccessful match, instead of completely grinding the process
to a halt at this stage by throwing an exception, developers can undertake an alternate route of
applying the cleansing technique. By adopting the cleansing path, the ISIN code can be closely
matched to the data in the central repository with the help of a pattern-matching algorithm to
find a similar ISIN code to replace the wrong ISIN code with the correct code. Additionally, the
cleansing process can also propose alternate values for a bad input value and demand user
intervention to ensure correct replacement.144C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
Enrichment: The enrichment layer goes hand in hand with the cleansing layer. But the separation
is important because the cleansing layer is meant to operate only on data originating from the
original source, but in the enrichment stage the information is further augmented by associating
additional missing information that did not originate from the actual data source. Using the ISIN
master example, if one of the secondary attributes of ISIN, such as the company name, is miss-
ing from the comma-delimited version of the file and is required by the business component in
the next stage, it can be fetched from the ISIN central repository, packaged with other primary
attributes of the ISIN, and dispatched to the final stage.
Business logic: This is the last stage and is the stage in which core business logic is executed.
The business logic component always acts on the finished data.
You saw how data passes through these four stages and how each stage morphs the intent of
the data in terms of its usage. Each stage, from a technical architecture view, could be realized as
independent subcomponents and later integrated to build a complete end-to-end data management
solution. Building such a solution is way beyond the scope of this chapter, and hence the scope of
this discussion is limited to how to handle the conversion stage, which provides the business logic
with the finished data and also introduces data uniformity.
The merit of using uniform data at the business logic layer is even if a new file format is intro-
duced whose data is structurally rearranged, the conversion layer takes care of this format, leaving
the business logic undisturbed. By providing uniform data, the business logic is completely oblivious
to the underlying data format and representation and can focus on application-centric concerns
instead of data-centric concerns.
It is important to clearly lay out the objectives that every framework must address. The following
is a list of the important goals of the conversion framework:
  Use XML as a strong foundation to define conversion rules.
  Act as integration middleware to enable EAI.
  Allow bidirectional data movement to facilitate data import and export activities.
  Provide for faster development time.
  Provide support for any arbitrary text file format, such as CSV, fixed length, SWIFT, EDI,
and so on.
  Provide a unified API.
  Bring down software maintenance costs.
It is wiser to solve a problem by first looking at it from a higher level and then slowly factoring
in each of the granular problems. Such an approach leads to a vivid and watertight design. As a first
step in this exercise, let’s analyze the various types of file formats described in Table 3-14 that are
normally encountered in the financial world. In Table 3-14, a record represents a unit of information
and is composed of rows and columns.
Table 3-14. Various Types of File Formats Encountered in the Financial World
Record-Row-Column
File Format Cardinality Example Description
Delimited 1-1-* US5949181045,10,10 A record is represented by
a single row and multiple
columns, but the length of
the column is dynamic and
determined by a delimiter,
which is usually a comma.C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 145
Record-Row-Column
File Format Cardinality Example Description
Positional 1-1-* US594918104500100010 A single row with multiple
columns representing
a record, but each column is
of fixed length, and the
column values are retrieved
by passing the offset
position and length of the
character that must be
extracted.
SWIFT 1-*-1 US5949181045 Multiple rows with a single
10 column representing
10 a record.
Master-detail 1-*-* US5949181045,00100010 A master-detail file format is
EXCHANGEASX,12 considered to be a complex
EXCHANGENASDAQ,13 file format when it comes
to parsing. A record in this
context is composed of
multiple rows and columns
with each row representing
a different aspect of the
information. For example,
ISIN information is defined
in the first row followed by
the local exchange mapping
information.
Having looked at the different file formats, you will see one common element; regardless of its rep-
resentation, every record finally comes down to a row and column matrix, as represented in Figure 3-7.
Data is plotted inside this matrix, and you need to know the proper coordinates—mainly, the
row and column position—to access this data. Figure 3-7 depicts a matrix, and each rectangular block
inside this matrix stores a series of characters. A row represents a collection of columns in a hori-
zontal order; similarly, a band represents a collection of rows in vertical order. It is necessary to get
well-versed with the terms row, column, and band because the following discussion on the framework
is based on this concept:
Figure 3-7. Representation of a record as a matrix146C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
Band: A band is the actual container, and it holds a collection of rows. The decision whether to
interpret a particular line in the data source file is determined by the criteria defined at the band
level. A band acts as an entry point to the underlying rows and columns; if the current line read
from the source file satisfies the band criteria, then the inner row and column is evaluated; else
the band is bypassed and skipped to the next band in the chain. The need for this extra shell
over rows and columns is to aggregate a collection of rows as a single row. This grouping at the
band level comes in handy when the file format is arcane in nature, such as the SWIFT standard,
where multiple sections are nested inside a row and each section is an elastic type, that is, it can
be expanded/collapsed based upon the presence of certain values. The following are important
attributes of a band:
  Identifier: This attribute is used to search text, which is in turn evaluated by the band to
decide whether the inner rows require processing.
  Loop: This attribute determines whether the current band supports iterations in the pres-
ence of a repetitive value. Iteration is achieved by checking the presence of the identifier
attribute value in the current processing line. This attribute is useful when the detail
rows need to be enumerated line by line. In the case of header and footer lines where
the occurrence is only once, the value will be single. To further simplify the loop and
identifier concept, let’s look at a CSV version of the ISIN master:
ISINMASTER12122004
US5949181045,MSFT,10,5,Active
EXCHANGE,NASDAQ,MSFT.O
EXCHANGE,NYSE,MSFT.N
ISINEOF
By looking at content, you can visualize four bands altogether. The first band represents
the header information, and it is identified by the presence of the ISINMASTER text, which
also forms the band identifier. Next, you need to find out the number of times the header
information is repeated; in this case it is repeated only once at the beginning of file, and
therefore the loop attribute value of this band needs to be single.
The second band represents ISIN information and contains attributes such as the ISIN
code, instrument name, market lot, face value, and instrument status. The ISIN infor-
mation is identified by the presence of the US text that forms the band identifier. Since
there will be multiple ISIN information, it is obvious that the loop attribute value of this
band will be repeatable.
Local exchange information comes under the jurisdiction of the third band, and it is
identified by the presence of the EXCHANGE text, which is also the band identifier. The
loop attribute value of this band will be repeatable.
The final band represents the footer information, which is identified by the presence of
the ISINEOF text. The loop attribute value of this band will be single.
  Start: This attribute provides the offset position to extract the value of the identifier.
  Length: This attribute provides the length of the value of the identifier.
  Suppress: A Boolean value of this attribute determines whether to include or exclude data.
Row: A row is similar to a band. Although it inherits all the properties of a band, it is a container
for a collection of columns or a child band. A child band provides enormous flexibility in the form
of recursiveness. It is a perfect candidate to cater to the complex requirements of a master-detail
file format. SWIFT-based formats contain various subsections that are a part of a distinct record
but are repetitive and dynamic in nature. The effectiveness of a child band is maximized in this
kind of scenario. The absence of this feature would have given rise to a lot of common inherent
problems associated with SWIFT formats.C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 147
Column: A column is the final element in the matrix. Rows and bands are the data pathways to
get to a column. Columns encapsulate the real field-level mapping that in turns yields the actual
data. The following are the important attributes of a column:
  Start: Provides offset position to extract the data.
  Length: Provides the length of the data.
  Suppress: A Boolean value of this attribute determines whether to include or exclude data.
Moving one step further, it is time to compartmentalize your thought process and start mixing
the applicability of XML in the data conversion arena. Figure 3-8 depicts a conceptual end-to-end
flow of the conversion framework.
The central piece of this conceptual model is the converter that knows both sides of the environ-
ment. Mainly it has access to all the supporting artifacts that are within the internal conversion
framework and also accessible to the external user. External users interact with the converter by
feeding two input files. The first file is the primary data file that needs to be converted, and the sec-
ond file is the rule file that defines the structural representation of the primary file and is embedded
with the logic for demystifying the data scattered in the primary file. The rule file is based on the matrix
principle described previously. In other words, it contains band-, row-, and column-level information.
The rule file is an XML document, and it comprises a series of band, row, and column elements. Each
of these elements is further supported by attributes that capture mandatory information associated
with them. It is necessary for the rule file to be free from any ambiguous information because this
may negatively impact the parsing behavior, resulting in the wrong finished information.
To ensure that rule file is free from errors, an XSD document is created that forms a part of the
rule repository. This schema document exactly represents the structural content of the rule file and
sanitizes the data by enforcing all possible data-level validation. Both the rule file and the schema
document are brought together using the XmlTextReader and XmlValidatingReader classes to verify
whether the files are well-formed and valid. Using the schema document at this stage proves to be
nifty because it saves you from writing a whole bunch of validation code.
The next step is to blend the contents of the rule file in an object representation form so that it
can be accessed by the downstream components. The straightforward approach is to read the con-
tent using the XmlTextReader class and traverse each node to determine the appropriate node type
and assign its value to an object field or property. However, because this method involves writing
a large amount of code, you can use the XML serialization technique to achieve the same task. XML
Figure 3-8. End-to-end flow of a conversion framework148C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
serialization eases the coding burden when it comes to deserializing the XML content to an object
and provides for a declarative style of programming.
So far you have put all the necessary apparatus in place; you have passed through a battery of
checks such as ensuring that the rule file is well-formed and valid and also eventually serializing it
into an object. Next you step into the parsing stage, which plays an important role in breaking up the
unstructured data and providing it in the finished form. Parsing heavily relies upon the rule informa-
tion because it is just a driver that blindly drives based on the direction plotted inside the rule file.
Three types of parsers are specialized to meet the distinct needs of band, row, and column. The parser
reads raw data from the primary data file using the TextReader class and with the help of the rule
definition extracts the appropriate chunk of data. This extracted data is then handed over to the writer,
which is entrusted with the responsibility of creating the parsed information in a format that can be
easily understood by developers creating the business logic component. This extra layer helps devel-
opers take advantage of the fact that the final parsed information can be easily molded as per the needs
of the technology. The writer can be technically materialized in the following flavors:
XML data writer: This writer enriches the data by surrounding it with angle brackets like XML
attributes and elements. The business logic component then fully leverages the capabilities of
the built-in XML classes of the .NET Framework to operate on this data. We will bundle this as
the default writer of the conversion framework.
DataSet writer: This writer arranges the data in the form of relational table rows and columns,
packaging it in the form of a DataSet. The business logic component can then use most of the
ADO.NET features to access the data.
Because there are no limits to the different types of writers, the data conversion framework has
appropriately outsourced writers as pluggable components instead of providing them as built-in
functionality. This opens the door for developers to write their own custom writers that suit their
need. Once the writer finishes its job, the business logic can start to process the finished information,
completely unaware of the various cycles that the information has gone through to reach this stage.
It is time to use some real code to illustrate this. In the next section, we will use a comma-delimited
version of the ISIN master as a real-life example to write a conversion rule that will transform an
unstructured format to XML format. This XML format will be considered as the uniform format on
which the business logic will depend.
CSV Conversion Rule
The conversion rule described in Listing 3-12 embodies the structural description of the ISIN master
CSV file. This rule file is also the technical realization of the conceptual matrix depicted in Figure 3-7—it
flawlessly interprets the band, row, and column concept. A row is sandwiched between a band, and
a column is placed between rows. Both the header information and the footer information in the CSV
file are repeated once, so the loop attribute of their band is assigned a single value. The detail band
is interesting; its loop attribute is marked repeatable, and it nests both a row and a child band named
Exchanges. This child band iterates over all exchange-related rows. The identifier attribute available
at the band or row level acts as a marker, and with its help, the parser interprets information correctly
and knows where to draw an end-of-information (EOI) mark.
Listing 3-12. ISIN Master CSV Conversion Rule File
<?xml version="1.0" encoding="utf-8" ?>
<matrix>
<bands>
<band name="Header" identifier="ISINMASTER" start="0" loop="single">
<rows>
<row name="HeaderInfo" identifier="" length="0" coldelimeter="">C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 149
<cols>
<col name="InfoDateTime" length="7" start="11"/>
</cols>
</row>
</rows>
</band>
<band name="Detail" identifier="US" start="0" loop="repeatable">
<rows>
<row name="ISIN" identifier="" length="0" coldelimeter=",">
<cols>
<col name="ISINCode" length="12" start="0"/>
<col name="Symbol" length="12" start="0"/>
<col name="FaceValue" length="12" start="0"/>
<col name="MarketLot" length="12" start="0"/>
<col name="Status" length="12" start="0"/>
</cols>
</row>
<row>
<band name="Exchanges" identifier="EXCHANGE" start="0" loop="repeatable">
<rows>
<row name="Exchange" identifier="" length="0" coldelimeter=",">
<cols>
<col name="ExchangeTag" length="12" start="0"/>
<col name="Code" length="12" start="0"/>
<col name="ScripCode" length="12" start="0"/>
</cols>
</row>
</rows>
</band>
</row>
</rows>
</band>
<band name="Footer" identifier="ISINEOF" start="0" loop="single">
<rows>
<row name="FooterInfo" identifier="" length="0" coldelimeter="">
<cols>
<col name="FooterTag" length="7" start="0"/>
</cols>
</row>
</rows>
</band>
</bands>
</matrix>
Rule Schema
The following XSD dictates both the content and structural layout of the conversion rule file. Rule
files are first validated against this schema before forwarding it to the parsing stage.
<?xml version="1.0" encoding="UTF-8" ?>
<xs:schema xmlns:xs="http://www.w3.org/2001/XmlSchema"
elementFormDefault="qualified">
<xs:simpleType name="IntAttribute">
<xs:restriction base="xs:int" />
</xs:simpleType>
<xs:complexType name="bandType">
<xs:sequence>150C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
<xs:element name="rows" type="rowsType" />
</xs:sequence>
<xs:attribute name="name" type="xs:string" use="required" />
<xs:attribute name="identifier" type="xs:string" use="required" />
<xs:attribute name="start" type="IntAttribute" use="required" />
<xs:attribute name="loop" type="LoopDataType" use="required" />
<xs:attribute name="suppress" type="xs:boolean" use="optional" />
</xs:complexType>
<xs:simpleType name="LoopDataType">
<xs:restriction base="xs:string">
<xs:enumeration value="single" />
<xs:enumeration value="repeatable" />
</xs:restriction>
</xs:simpleType>
<xs:complexType name="bandsType">
<xs:sequence>
<xs:element name="band" type="bandType" maxOccurs="unbounded" />
</xs:sequence>
</xs:complexType>
<xs:complexType name="colType">
<xs:attribute name="name" type="xs:string" use="required" />
<xs:attribute name="length" type="IntAttribute" use="required" />
<xs:attribute name="start" type="IntAttribute" use="required" />
<xs:attribute name="suppress" type="xs:boolean" use="optional" />
</xs:complexType>
<xs:complexType name="colsType">
<xs:sequence>
<xs:element name="col" type="colType" maxOccurs="unbounded" />
</xs:sequence>
</xs:complexType>
<xs:element name="matrix">
<xs:complexType>
<xs:sequence>
<xs:element name="bands" type="bandsType" />
</xs:sequence>
</xs:complexType>
</xs:element>
<xs:complexType name="rowType">
<xs:choice>
<xs:element name="cols" type="colsType" />
<xs:element name="band" type="bandType" />
</xs:choice>
<xs:attribute name="name" type="xs:string" use="optional" />
<xs:attribute name="identifier" type="xs:string" use="optional" />
<xs:attribute name="length" type="IntAttribute" use="optional" />
<xs:attribute name="coldelimeter" type="xs:string" use="optional" />
<xs:attribute name="suppress" type="xs:boolean" use="optional" />
</xs:complexType>
<xs:complexType name="rowsType">
<xs:sequence>
<xs:element name="row" type="rowType" maxOccurs="unbounded" />
</xs:sequence>
</xs:complexType>
</xs:schema>C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 151
Class Details
Figure 3-9 shows the data conversion framework class diagram, and Figure 3-10 shows the data
conversion framework project structure.
Figure 3-9. Data conversion framework class diagram
Figure 3-10. Data conversion framework project structure152C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
CellsAttribute
CellsAttribute is an abstract class inherited by the Band, Row, and Column classes. The intent of this
abstract class is to group all common properties.
This is the CellsAttribute class:
using System;
using System.Xml.Serialization;
namespace DCE.Repository
{
public abstract class CellsAttribute
{
private string dataIdentifer;
private int offSet;
private string name;
private int index;
private int dataLength;
private CellsAttribute parentCell;
private bool isSuppressed;
[XmlIgnore]
public CellsAttribute ParentCell
{
get{return parentCell;}
set{ parentCell= value;}
}
[XmlIgnore]
public int Index
{
get{return index;}
set{ index=value;}
}
[XmlAttribute("name")]
public string Name
{
get{return name;}
set{ name= value;}
}
[XmlAttribute("identifier")]
public string Identifier
{
get{return dataIdentifer;}
set{ dataIdentifer=value;}
}
[XmlAttribute("start")]
public int Start
{
get{return offSet;}
set{ offSet= value;}
}C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 153
[XmlAttribute("length")]
public int Length
{
get{return dataLength;}
set{ dataLength = value;}
}
[XmlAttribute("suppress")]
public bool IsSuppressed
{
get{return isSuppressed;}
set{ isSuppressed= value;}
}
}
}
Band
The Band class is an object-oriented representation of the band element defined in the conversion
rule file. It is inherited from the CellsAttribute abstract class and introduces some additional
attributes specific to the band.
This is the Band class:
using System;
using System.Xml.Serialization;
namespace DCE.Repository
{
public enum LoopType
{
[XmlEnum("repeatable")]
Repeatable,
[XmlEnum("single")]
Single
}
public class Band : CellsAttribute
{
private Row[] rows = {};
private LoopType loopMode;
public Band()
{
}
[XmlAttribute("loop")]
public LoopType LoopMode
{
get{return loopMode;}
set{loopMode=value;}
}154C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
[XmlArray("rows")]
[XmlArrayItem("row",typeof(Row))]
public Row[] Rows
{
get{return rows;}
set{rows = value;}
}
}
}
Row
The Row class is an object-oriented representation of the row element defined in the conversion
rule file.
This is the Row class:
using System;
using System.Xml.Serialization;
namespace DCE.Repository
{
public class Row : CellsAttribute
{
private Column[] columns = {};
private Band childBand;
private string colDelimeter;
public Row()
{
}
[XmlAttribute("coldelimeter")]
public string ColDelimeter
{
get{return colDelimeter;}
set{colDelimeter=value;}
}
[XmlElement("band")]
public Band ChildBand
{
get{return childBand;}
set{childBand= value;}
}
[XmlArray("cols")]
[XmlArrayItem("col",typeof(Column))]
public Column[] Columns
{
get{return columns;}
set{columns= value;}
}
}
}C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 155
Column
The Column class is an object-oriented representation of the column element defined in the conver-
sion rule file.
This is the Column class:
using System;
using System.Xml.Serialization;
using System.Runtime.InteropServices;
namespace DCE.Repository
{
public class Column : CellsAttribute
{
private string dataPrefix;
public Column()
{
}
[XmlAttribute("prefix")]
public string Prefix
{
get{return dataPrefix;}
set{dataPrefix = value;}
}
}
}
Matrix
The Matrix class represents an object-oriented form of the dce element, which is a root container.
This class acts as a surrogate container for the collection of all bands, and therefore there is no need
to inherit it from the CellsAttribute class.
This is the Matrix class:
using System;
using System.Xml.Serialization;
namespace DCE.Repository
{
[XmlRoot("matrix")]
public class Matrix
{
private Band[] bands = {};
public Matrix()
{
}
[XmlArray("bands")]
[XmlArrayItem("band",typeof(Band))]
public Band[] Bands
{
get{return bands;}
set{bands = value;}
}
}
}156C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
All the classes discussed so far belong to the illustrated conceptual matrix depicted in Figure 3-7.
Each class maps to a particular section of the conversion rule file and is appropriately annotated with
a serialization attribute. Certain properties, specifically ParentCell and Index of the CellAttribute
class, are ignored during the serialization phase. The purpose of both these properties is explained
in the DataConverter class.
BooleanCursor
BooleanCursor is the internal data source reader class of the data conversion framework. This class
supplies unstructured data to the framework; basically, it reads data from the source file. BooleanCursor
is the equivalent of a Boolean variable that can hold two specific states. Thus, BooleanCursor also stores
two copies of data. The first copy represents the previously read data, and the final copy represents
the latest read data. Using such a caching technique is extremely beneficial and provides the in-memory
file-seeking capability.
This is the BooleanCursor class:
using System;
using System.Collections;
using System.IO;
namespace DCE
{
public class BooleanCursor
{
private TextReader _dataReader;
private string[] _data;
private int _readCounter = 0;
public BooleanCursor(TextReader dataSource)
{
_dataReader = dataSource;
_data = new string[2];
_readCounter = 1;
}
public TextReader BaseReader
{
get{return _dataReader;}
}
public string Previous()
{
_readCounter = 0 ;
return _data[_readCounter];
}
public string Next()
{
if ( _readCounter == 0 )
{
_readCounter = 1;
}
else
{
_readCounter = 1;
_data[0] = _data[1];C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 157
_data[1] = _dataReader.ReadLine();
}
return _data[_readCounter];
}
}
}
Parser
The Parser class groups all the common behavior that a parser should provide, specifically the abstract
Parse method. RowParser, ColumnParser, and BandParser are inherited from this abstract class and
override the Parse method by supplying a concrete implementation. The concrete Parser class is
driven by the information provided to them. This information is none other than the conversion rule
that is wrapped inside the Matrix class.
This is the Parser class:
using System;
using DCE.Repository;
using DCE;
namespace DCE.Parser
{
public abstract class Parser
{
private string data;
private BooleanCursor dataReader;
private CellsAttribute cellInfo;
public Parser(BooleanCursor reader)
{
dataReader = reader;
}
//The value of this property governs the entire parsing process.
//It represents the conversion rule and must be a Band or Row or Column class.
public CellsAttribute CellsAttribute
{
get{return cellInfo;}
set{cellInfo = value;}
}
//This property gives the parser class access to the
//underlying information data source.
public BooleanCursor Reader
{
get{return dataReader;}
}
//Parser needs to have access to the raw data before it
//could apply its parsing logic. It is with the help of this property that
//data is retrieved or assigned.
public string Data
{
get{return data;}
set{ data = value;}
}158C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
public abstract bool Parse();
}
}
BandParser
BandParser provides the concrete implementation of parsing the band section of the conversion
rule file.
This is the BandParser class:
using System;
using System.IO;
using DCE.Repository;
using DCE;
namespace DCE.Parser
{
public class BandParser : Parser
{
private int _iterationCount = 0;
public BandParser(BooleanCursor dataReader, string data,
CellsAttribute cellInfo) :base(dataReader)
{
this.Data = data;
this.CellsAttribute = cellInfo;
}
public override bool Parse()
{
//Retrieve the band information
Band curBand = (Band)CellsAttribute;
//If data to be processed is null, then terminate the parsing
if ( Data == null )
return false;
//Referring to the band section, specifically the loop attribute,
//if the current loop mode is single, then it needs to process
//only once for the current section.
if ( curBand.LoopMode == LoopType.Single)
{
if ( _iterationCount >= 1 )
{
_iterationCount = 0 ;
Reader.Previous();
return false;
}
else
{
_iterationCount++;
return true;
}
}C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 159
//If the loop attribute is of repeatable type, then it
//evaluates data for the presence of an identifier-defined band
//section of the conversion rule file. If parser is not able to
//locate the identifier in the data, then it resets the
//read pointer of the data source to its previous location by
//invoking the Previous member of the BooleanCursor class.
if ( curBand.LoopMode == LoopType.Repeatable)
{
if ( ( curBand.Identifier.Length <= Data.Length - curBand.Start ) &&
Data.Substring(curBand.Start,curBand.Identifier.Length) ==
curBand.Identifier )
{
return true;
}
Reader.Previous();
}
_iterationCount = 0 ;
return false;
}
}
}
RowParser
RowParser provides a concrete implementation of parsing the row section of the conversion rule file.
This is the RowParser class:
using System;
using DCE;
using DCE.Repository;
namespace DCE.Parser
{
public class RowParser : Parser
{
public RowParser(BooleanCursor dataReader,
string data, CellsAttribute cellInfo)
:base(dataReader)
{
this.Data = data;
this.CellsAttribute = cellInfo;
}
public override bool Parse()
{
//The parser checks for the presence of a identifier
//defined in the row section of rule file. If the parser is
//not able to locate the identifier in the data, then it
//resets the read pointer of the data source to its previous
//location by invoking the Previous member of the BooleanCursor class.
if ( CellsAttribute.Identifier.Length > 0 &&
Data.Substring(CellsAttribute.Start,CellsAttribute.Length) !=
CellsAttribute.Identifier )
{
Reader.Previous();
return false;
}160C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
return true;
}
}
}
ColumnParser
ColumnParser provides a concrete implementation of parsing the col section of the conversion
rule file.
This is the ColumnParser class:
using System;
using DCE.Repository;
using DCE;
namespace DCE.Parser
{
public class ColumnParser : Parser
{
private string[] splittedData;
public ColumnParser(BooleanCursor dataReader)
:base(dataReader)
{
}
public override bool Parse()
{
Row curRow = (Row)CellsAttribute.ParentCell;
//This is the final processing logic in the parsing chain.
//A check is performed to see whether a column delimiter has
//been specified. If a column delimiter is found, then a Split
//operation is performed that splits out an array of strings based
//on the character delimiter passed to it. The array of string returned
//from the Split operation is assigned to the array. This splitting process
//is conducted only once - during the parsing of first column - and
//subsequent access to data is retrieved from a cached array.
if (curRow.ColDelimeter.Length > 0 )
{
if ( this.CellsAttribute.Index == 1 )
splittedData = Data.Split(curRow.ColDelimeter.ToCharArray());
this.Data = splittedData[this.CellsAttribute.Index - 1];
}
else
{
//If there is no delimiter specified, then it is assumed that it is a
//fixed-length file format, and data is retrieved using the offset position
//and length of data.
this.Data =
this.Data.Substring(CellsAttribute.Start,CellsAttribute.Length);
}
return true;
}
}
}C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 161
IWriter
IWriter is the interface implemented by the concrete data writer class. The responsibility of this class
is to furnish finished information that is in turn submitted to the business logic component. Using
this interface ensures full cooperation by concrete classes that provide real code implementation.
This interface is referenced by the Parser class to invoke the appropriate operation during important
stages of parsing.
This is the IWriter class:
using System;
using System.IO;
using DCE.Repository;
using DCE.Parser;
namespace DCE.Writer
{
public interface IWriter
{
//This paired method is invoked by ColumnParser during the parsing phase
void WriteStartColumn(CellsAttribute metaDataInfo, string data);
void WriteEndColumn(CellsAttribute metaDataInfo);
//This paired method is invoked by RowParser during the parsing phase
void WriteStartRow(CellsAttribute metaDataInfo,string data);
void WriteEndRow(CellsAttribute metaDataInfo);
//This paired method is invoked by BandParser during the parsing phase
void WriteStartBand(CellsAttribute metaDataInfo,string data);
void WriteEndBand(CellsAttribute metaDataInfo);
TextWriter BaseWriter{get;}
}
}
XmlDataWriter
XmlDataWriter realizes a concrete XML writer and annotates semifinished data with elements and
attributes to produce the finished information.
This is the XmlDataWriter class:
using System;
using System.Xml;
using System.IO;
using DCE.Repository;
using DCE.Parser;
namespace DCE.Writer
{
public class XmlDataWriter: IWriter
{
private XmlTextWriter xmlWriter;
private TextWriter baseWriter;
public XmlDataWriter(TextWriter dataWriter)
{
xmlWriter = new XmlTextWriter(dataWriter);
xmlWriter.Formatting= Formatting.Indented;
xmlWriter.Indentation = 4;
baseWriter = dataWriter;
}162C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
public void WriteStartColumn(CellsAttribute metaDataInfo, string data)
{
if ( metaDataInfo.IsSuppressed == true ) return;
xmlWriter.WriteStartAttribute(metaDataInfo.Name,"");
xmlWriter.WriteString(data);
}
public void WriteEndColumn(CellsAttribute metaDataInfo)
{
if ( metaDataInfo.IsSuppressed == true ) return;
Row rowCell = metaDataInfo.ParentCell as Row;
xmlWriter.WriteEndAttribute();
}
public void WriteStartRow(CellsAttribute metaDataInfo, string data)
{
if ( metaDataInfo.IsSuppressed == true ) return;
xmlWriter.WriteStartElement(metaDataInfo.Name);
}
public void WriteEndRow(CellsAttribute metaDataInfo)
{
if ( metaDataInfo.IsSuppressed == true ) return;
xmlWriter.WriteEndElement();
}
public void WriteStartBand(CellsAttribute metaDataInfo, string data)
{
if ( metaDataInfo.IsSuppressed == true ) return;
xmlWriter.WriteStartElement(metaDataInfo.Name);
}
public void WriteEndBand(CellsAttribute metaDataInfo)
{
if ( metaDataInfo.IsSuppressed == true ) return;
xmlWriter.WriteEndElement();
}
public TextWriter BaseWriter
{
get{return baseWriter;}
}
}
}
DataConverter
DataConverter is the facade class that is visible to the outside world. The responsibility of this class
is to dovetail the classes discussed so far by instantiating them and initializing them with an appro-
priate state. The important member in this class is Convert, which kicks off the conversion stage.
On its successful completion, this method gathers the finished data with the help of an underlying
stream wrapped inside the XmlDataWriter class.
This is the DataConverter class:
using System;
using System.IO;
using System.Xml.Serialization;C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 163
using DCE.Repository;
using DCE.Parser;
using DCE;
using DCE.Writer;
using System.Xml;
using System.Xml.Schema;
using System.Configuration;
namespace DCE
{
public class DataConverter
{
private Matrix dceSchema;
private IWriter dataWriter;
private BooleanCursor dataReader;
private string ruleFile;
private string ruleSchema;
public DataConverter(string rulePath,string ruleSchemaPath)
{
//Rule file is validated with a framework schema file
//that checks for well-formed characteristics and conformity,
//ensuring that all mandatory attributes/elements are present
//and arranged in a defined order.
ruleFile = rulePath;
ruleSchema = ruleSchemaPath;
XmlTextReader xmlRule = new XmlTextReader(ruleFile);
XmlValidatingReader xsdSchema = new XmlValidatingReader(xmlRule);
xsdSchema.ValidationEventHandler +=new
ValidationEventHandler(xsdSchema_ValidationEventHandler);
xsdSchema.Schemas.Add("", ruleSchema);
while(xsdSchema .Read()){}
xsdSchema.Close();
xmlRule.Close();
//Rules stored in Xml file are dehydrated
//in an object representation format.
FileStream schemaStream = new FileStream(rulePath, FileMode.Open);
XmlSerializer schemaSz = new XmlSerializer(typeof(Matrix));
dceSchema = (Matrix)schemaSz.Deserialize(schemaStream );
schemaStream.Close();
//This loop invokes the AssignIndex function that
//assigns a running sequence number to every instance of the Band, Row, and
//Column objects. This sequence number is assigned recursively to the Index
//property of CellsAttribute. There is no way to capture this information
//during the deserialization stage; therefore, it needs to be manually assigned.
foreach ( Band curBand in dceSchema.Bands)
{
AssignIndex(curBand);
}
}164C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
public void Convert(BooleanCursor reader,IWriter writer)
{
dataWriter = writer;
dataReader = reader;
//Parsing kicks off with the invocation of this method.
//The parsing code has been packaged inside the ConvertBand, ConvertRow, and
//ConvertCol methods. These methods instantiate an appropriate parser, and
//based on the return value of Parse method, it invokes
//the Writer WriteXXX method.
foreach ( Band curBand in dceSchema.Bands )
{
ConvertBand(curBand, dataReader.Next());
}
//Close the underlying reader and writer
dataReader.BaseReader.Close();
dataWriter.BaseWriter.Close();
}
private void ConvertBand(Band band,string data)
{
//This method is responsible for the initiating parsing of the
//band section. A new instance of band parser is created
//by passing the current data and band information
BandParser bandParser;
bandParser = new BandParser( dataReader,data,band);
//loop until data contains the appropriate band identifer
while ( bandParser.Parse()== true )
{
//invoke the writer band start method
dataWriter.WriteStartBand(band,bandParser.Data);
//iterate through individual row of band
foreach ( Row row in band.Rows)
{
//a row can be a child band
//if it is, then a recursive call to CovertBand
//is triggered
if ( row.ChildBand != null )
ConvertBand(row.ChildBand,data);
else
ConvertRow(row,data);
//get the next data
data = dataReader.Next();
}
//invoke the writer band end method
dataWriter.WriteEndBand(band);
bandParser.Data = data;
}
}
private void ConvertRow(Row row,string data)
{
//This method is responsible for initiating the parsing of
//row section. A new instance of row parser is created
//by passing the current data and row informationC H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 165
RowParser rowParser = new RowParser( dataReader,data,row);
//invoke the writer band start method
dataWriter.WriteStartRow(row, rowParser.Data);
//invoke row parser
if ( rowParser.Parse() == false )
{
//if there is no matching data found based on the row identifier,
//then bypass the column processing and invoke
//the writer row end method
dataWriter.WriteEndRow(row);
return ;
}
//initiate the column parsing
ColumnParser colParser = new ColumnParser(dataReader);
//iterate through individual columns
//and process the column level information
foreach ( Column col in row.Columns)
{
colParser.Data = data;
colParser.CellsAttribute = col;
ConvertCol(row,col,data,colParser);
}
//invoke the writer row end method
dataWriter.WriteEndRow(row);
}
private void AssignIndex(Band curBand)
{
if ( curBand == null ) return ;
int rowIndex;
int colIndex;
rowIndex=1;
foreach(Row curRow in curBand.Rows)
{
curRow.Index = rowIndex;
curRow.ParentCell= curBand;
AssignIndex(curRow.ChildBand);
colIndex=1;
foreach(Column curCol in curRow.Columns)
{
curCol.Index = colIndex;
curCol.ParentCell= curRow;
colIndex++;
}
rowIndex++;
}
}
private void ConvertCol(Row row,Column col,string data,ColumnParser colParser)
{
//This method is responsible for initiating the parsing of
//column section
colParser.Parse();
//invoke writer column start and end method166C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
dataWriter.WriteStartColumn(col, colParser.Data);
dataWriter.WriteEndColumn(col);
}
private void xsdSchema_ValidationEventHandler(object sender,
ValidationEventArgs e)
{
throw new ApplicationException(e.Message);
}
}
}
Conversion Example
The following sample code illustrates a data conversion example. Before invoking the Convert
method of the DataConverter class, it instantiates an appropriate reader and writer object and
passes the newly created instance to the Convert method.
using System;
using System.IO;
using System.Configuration;
using System.Xml.Serialization;
using DCE.Repository;
using DCE.Parser;
using DCE.Writer;
using DCE;
namespace DCE
{
class DCEExample
{
[STAThread]
static void Main(string[] args)
{
string filePath = @"C:\CodeExample\Chpt3\Framework\";
//Assign the framework rule schema
string ruleSchema = filePath +"RuleSchema.xsd";
//ISIN Master - comma-separated
BooleanCursor dataRdr = new BooleanCursor(new
StreamReader(filePath +"CSVISINMaster.csv"));
//Create XML data writer
XmlDataWriter dataWrt= new XmlDataWriter(new StringWriter());
//Instantiate Data Converter passing the ISIN conversion rule file
DataConverter _dataConverter= new DataConverter(
filePath +"ISINConversionRule.xml",ruleSchema );
//Start of conversion phase
_dataConverter.Convert(dataRdr,dataWrt);
//Display XML output
Console.WriteLine(dataWrt.BaseWriter.ToString());
}
}
}C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 167
XML Output
The following is the finished data produced by the parser based on the rule defined in the conversion
rule file (see Listing 3-12):
<Header>
<HeaderInfo InfoDateTime="2122004" />
</Header>
<Detail>
<ISIN ISINCode="US5949181045" Symbol="MSFT" FaceValue="10"
MarketLot="5" Status="Active" />
<Exchanges>
<Exchange ExchangeTag="EXCHANGE" Code="NASDAQ" ScripCode="MSFT.O" />
</Exchanges>
<Exchanges>
<Exchange ExchangeTag="EXCHANGE" Code="NYSE" ScripCode="MSFT.N" />
</Exchanges>
</Detail>
<Footer>
<FooterInfo FooterTag="ISINEOF" />
</Footer>
The previous XML output doesn’t reproduce the ISIN master XML format described in Listing 3-2.
We did this for demonstration purposes. We purposely shaped our conversion rule file in such
a fashion where every section (that is, band, row, and col) can get its share of pie in the final gener-
ated XML document.
Refined Conversion Rule
The whole concept of a matrix upon which the conversion framework is cemented is so rigorous
that almost all kinds of file formats can be conceptualized and easily materialized. To prove this, we
paid a second visit to the conversion rule and refined it to produce XML output that matches the
format described in Listing 3-2.
Here’s the code:
<?xml version="1.0" encoding="utf-8" ?>
<matrix>
<bands>
<band name="ISINMaster" identifier="ISINMASTER" start="0" loop="single"
suppress="false">
<rows>
<row name="HeaderInfo" identifier="" length="0"
coldelimeter="" suppress="true">
<cols>
<col name="InfoDateTime" length="7" start="11" suppress="true"/>
</cols>
</row>
<row>
<band name="ISIN" identifier="US" start="0"
loop="repeatable" suppress="false">
<rows>
<row name="ISIN" identifier="" length="0"
coldelimeter="," suppress="true">
<cols>
<col name="ISINCode" length="12" start="0"/>
<col name="Symbol" length="12" start="0"/>
<col name="FaceValue" length="12" start="0"/>
<col name="MarketLot" length="12" start="0"/>168C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E
<col name="Status" length="12" start="0"/>
</cols>
</row>
<row>
<band name="Exchanges" identifier="EXCHANGE" start="0"
loop="repeatable" suppress="false">
<rows>
<row>
<band name="Exchanges" identifier="EXCHANGE" start="0"
loop="repeatable" suppress="true">
<rows>
<row name="Exchange" identifier=""
length="0" coldelimeter="," >
<cols>
<col name="ExchangeTag" length="12" start="0"/>
<col name="Code" length="12" start="0"/>
<col name="ScripCode" length="12" start="0"/>
</cols>
</row>
</rows>
</band>
</row>
</rows>
</band>
</row>
</rows>
</band>
</row>
</rows>
</band>
<band name="Footer" identifier="ISINEOF" start="0" loop="single"
suppress="true">
<rows>
<row name="FooterInfo" identifier="" length="0" coldelimeter=""
suppress="true">
<cols>
<col name="FooterTag" length="7" start="0" suppress="true"/>
</cols>
</row>
</rows>
</band>
</bands>
</matrix>
XML Output
Here’s the XML output:
<ISINMaster>
<ISIN ISINCode="US5949181045" Symbol="MSFT" FaceValue="10"
MarketLot="5" Status="Active">
<Exchanges>
<Exchange ExchangeTag="EXCHANGE" Code="NASDAQ" ScripCode="MSFT.O" />
<Exchange ExchangeTag="EXCHANGE" Code="NYSE" ScripCode="MSFT.N" />
</Exchanges>
</ISIN>
</ISINMaster>C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 169
Summary
In this chapter, we covered the following key points:
  Data is the lifeblood of an organization, and the success of an organization depends on the
quality of the data it possesses. Data related to securities, prices, market conditions, clients,
and trades is used by various trading applications for the fulfillment of trades. Data comes
from a variety of sources, and this leads to a data conversion problem where data taken from
one system needs to be migrated to another.
  We illustrated the power of XML and how it can act as the glue in enabling data integration
among heterogeneous systems.
  We covered the XML classes in the .NET Framework that allow the parsing, reading, and
writing of XML documents.
  We explained the benefit of XSD and how it can be used to define and validate the structure
of an XML document.
  We provided a basic overview of the declarative style of programming and how it is being lever-
aged by the XML serializer to convert in-memory objects to XML representation formats.
  We designed a data conversion framework that is built upon XML and supports the conversion
of an unstructured text file format to XML format.C H A P T E R 3 ■ T H E D ATA C O N V E R S I O N E N G I N E 169
Summary
In this chapter, we covered the following key points:
  Data is the lifeblood of an organization, and the success of an organization depends on the
quality of the data it possesses. Data related to securities, prices, market conditions, clients,
and trades is used by various trading applications for the fulfillment of trades. Data comes
from a variety of sources, and this leads to a data conversion problem where data taken from
one system needs to be migrated to another.
  We illustrated the power of XML and how it can act as the glue in enabling data integration
among heterogeneous systems.
  We covered the XML classes in the .NET Framework that allow the parsing, reading, and
writing of XML documents.
  We explained the benefit of XSD and how it can be used to define and validate the structure
of an XML document.
  We provided a basic overview of the declarative style of programming and how it is being lever-
aged by the XML serializer to convert in-memory objects to XML representation formats.
  We designed a data conversion framework that is built upon XML and supports the conversion
of an unstructured text file format to XML format. de="MSFT.N" />
</Exchanges>
</ISIN>
</ISINMaster> ng 3-2.
Here’s the code:
<?xml version="1.0" encoding="utf-8" ?>
<matrix>
<bands>
<band name="ISINMaster" identifier="ISINMASTER" start="0" loop="single"
suppress="false">
<rows>
<row name="HeaderInfo" identifier="" length="0"
coldelimeter="" suppress="true">
<cols>
<col name="InfoDateTime" length="7" start="11" suppress="true"/>
</cols>
</row>
<row>
<band name="ISIN" identifier="US" start="0"
loop="repeatable" suppress="false">
<rows>
<row name="ISIN" identifier="" length="0"
coldelimeter="," suppress="true">
<cols>
<col name="ISINCode" length="12" start="0"/>
<col name="Symbol" length="12" start="0"/>
<col name="FaceValue" length="12" start="0"/>
<col name="MarketLot" length="12" start="0"/> ounded" />
</xs:sequence>
</xs:complexType>
</xs:schema> sion framework has
appropriately outsourced writers as pluggable components instead of providing them as built-in
functionality. This opens the door for developers to write their own custom writers that suit their
need. Once the writer finishes its job, the business logic can start to process the finished information,
completely unaware of the various cycles that the information has gone through to reach this stage.
It is time to use some real code to illustrate this. In the next section, we will use a comma-delimited
version of the ISIN master as a real-life example to write a conversion rule that will transform an
unstructured format to XML format. This XML format will be considered as the uniform format on
which the business logic will depend.
CSV Conversion Rule
The conversion rule described in Listing 3-12 embodies the structural description of the ISIN master
CSV file. This rule file is also the technical realization of the conceptual matrix depicted in Figure 3-7—it
flawlessly interprets the band, row, and column concept. A row is sandwiched between a band, and
a column is placed between rows. Both the header information and the footer information in the CSV
file are repeated once, so the loop attribute of their band is assigned a single value. The detail band
is interesting; its loop attribute is marked repeatable, and it nests both a row and a child band named
Exchanges. This child band iterates over all exchange-related rows. The identifier attribute available
at the band or row level acts as a marker, and with its help, the parser interprets information correctly
and knows where to draw an end-of-information (EOI) mark.
Listing 3-12. ISIN Master CSV Conversion Rule File
<?xml version="1.0" encoding="utf-8" ?>
<matrix>
<bands>
<band name="Header" identifier="ISINMASTER" start="0" loop="single">
<rows>
<row name="HeaderInfo" identifier="" length="0" coldelimeter=""> n application
driven. Simple API for XML (SAX) parsers fall under this category and are designed specifically
to overcome problems faced in the DOM, primarily the memory issue. Even though the .NET
Framework has no direct support for SAX parsers, they are still available as part of the Microsoft
XML 4.0 COM Library.  and without ambiguity, as shown in Figure 3-3. is scenario is clearly depicted in the following code where the order management service
and the exchange market data service are running as two separate operating system processes. The
order management service is responsible for sending orders to the exchange, and the market data nless an institution specifically demands it, there is no standard practice of giving back-order . One trading mem-
ber who is a member of a clearing corporation may sometimes choose to route trades through other
clearing members because they have reached their clearing limits. day, and they allow all members to log in and trade during this    

