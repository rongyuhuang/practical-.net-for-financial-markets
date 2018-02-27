# 第四章 广播引擎 The Broadcast Engine

*99 percent perspiration + 1 percent luck = 100 percent success*

In this chapter, we explain what market data is and its importance in the trading world. Market data reflects information about the performance of an organization as a whole; several actors in the trading world depend upon this information. The important fact about this information is that it is time critical. Furthermore, market data information requires no further intelligence or any kind of sophisticated processing; it just needs to be forwarded from one end to another. Such data forwarding demands a good amount of groundwork from systems that utilize a network communication library,which forms the basis of this chapter’s technical sections; we will discuss various aspects of the network programming model in detail.

## 4.1 什么是行情数据 What Is Market Data?

Financial engineers, dealers, and traders require timely and accurate information about the securities they trade in so they can arrive at a proper price for them. Changing market scenarios and world events keep altering perceptions about the value of financial assets, and hence these factors also change their prices. For most financial assets, these changes are so fast that they translate into price changes every second. Every change in price represents an opportunity for dealers to either buy these assets and build more positions or sell these assets and square these positions to book profit or loss.

Dealers and traders whose positions run into the millions of dollars pay special attention to these changing scenarios, which could change the prices of assets they hold or intend to trade in. The moment they see a rate favorable to them, they buy the asset and dispose of it when they have reasons to believe that they are overpriced. These perceptions and beliefs that dealers have about financial assets are made possible by the market data available to them (of course, their judgment is also a key contributor) through an exchange trading system or through other third-party market data service providers such as Reuters, Bloomberg, Moneyline Telerate, and so on.

Market data can be defined as information that traders need for analysis to make informed trading decisions while trading in a market. Since the scope of this book is equities only, we will cover the market data requirements and associated issues for equities. Going by the definition, you can classify the following information as market data:

  Quotes such as bid/offer rates for a particular financial instrument (including stocks, bonds,derivatives, and so on) that is either traded in a market such as an exchange or available for transaction in an interbank or other financial market

  News such as earnings reports, raw news, senior management speeches, and any other information that could impact the profitability and in turn stock prices

  Macro- and micro-economic data and related analysis relating to gross domestic product (GDP), gross national  product (GNP), employment ratios, import and export figures, fiscal deficit, and other economic data

  Analyst reports/opinions on stocks, bonds, and other investment instruments

  News about competitors and related information

 Market data is normally provided in the form of a broadcast to its subscribed recipients. This broadcast is provided either by exchanges or by third-party market data service providers. The timely receipt of market data is one of the highest priorities for any institution’s information technology (IT) and dealing rooms. Stale information could mean delayed action and missed opportunities for the institution; hence, a lot of emphasis is put on obtaining this data on a real-time basis.

### 4.1.1 行情数据行业的参与者 Participants in the Market Data Industry

The following are the participants in the market data industry:

Stock exchanges: Stock exchanges are one of the prime generators of market data. They constantly broadcast the prevailing rates of all securities traded on that exchange, as well as volume and depth information. Most exchanges also provide data about the total number of trades, the number of securities advanced in a day, the number of declines, the total volume of transactions,the total percentage of transactions that resulted in delivery, and so on. All this information is useful for traders, analysts, and brokers who have an interest in the securities listed and traded on that stock exchange. Most exchanges sell this data either directly or through other market
data service providers such as Reuters and Bloomberg. This is a major source of revenue for many exchanges. Some exchanges are known to earn about 35 percent of their annual revenues through the sale of market data. Since the generation of this data is continuous and a lot of trading interest is built on these exchanges, many firms subscribe to these data services.

Issuers: Since most trading interest is centered on corporate- and government-issued securities,
any news related to the performance of corporate changes in prices of their finished goods or
raw materials, the fiscal position of the country, and micro- and macro-economic issues forms
part of market data. Issuers do not sell market data proactively. Their actions—such as issuing
bonuses, issuing rights, consolidating/splitting shares, conducting mergers, and so on—become
news. Data related to these actions (also called corporate action) becomes relevant market data.
Market data providers: These are agencies/companies that collect data from various sources, do
some value addition on it, and send it as a broadcast to all subscribed recipients. Some exam-
ples of market data service providers are Reuters, Thomson Financials, Moneyline Telerate, and
Bloomberg. These service providers provide data in multiple formats: news broadcasts, streaming
quotes, messages, XML dumps, messages on mobile phones, messages on PDAs, and stream-
ing video. Data service providers normally have two kinds of services: delayed and real time.
Delayed data has multiple types; data with 5-minute, 10-minute, 15-minute, and 20-minute
delays is the most common. Real-time data is far more expensive than delayed data. This dis-
tinction exists to provide services at a lower cost to institutions that don’t need real-time data.

Figure 4-1. Market data (Source: http://www.nyse.com; December 2, 2005)
Recipients: These are institutions/people who are the consumers of market data. They are normally
institutions that trade and maintain positions across various markets such as fixed-income secu-
rities, foreign exchanges, equities, commodities, and related derivatives. These institutions
normally trade across markets in several countries and hence look for service providers that
can give them data across various markets, exchanges, and countries. They either analyze raw
data mentally or put it through a system that analyzes raw market data and converts it to a mean-
ingful and usable form.

### 4.1.2 行情数据样例 Example of Market Data

Figure 4-1 could qualify as an example of market data.


### 4.1.3 行情数据规则 Role of Market Data

Market data has a lot of meaning and importance to professionals across the financial trading value
chain. An institution buys market data to support professionals employed in that institution and to
provide them with high-quality information that enables them to make informed decisions. Judg-
ments based on information that is derived from quality data could be superior when compared to
those based on low-quality data or data that is not timely in nature.
Market data is important for professionals engaged in the following areas:
  Analysis
  Trading and dealing
  Risk management
  Back office and settlement
Analysts need a lot of information for the valuation of a particular stock. They analyze past div-
idend statistics, latest earning figures, and news and couple all that with their own judgment about
the industry and company to arrive at the future cash flows of a company. Using this kind of market
data, they are in a reasonably informed position to arrive at the overall valuation of the company.
They also analyze information about the macro- and micro-economic position of the environment
under which a particular company is operating. They then refer to the current capital structure of
the company to arrive at the per-share net worth of the company and the projected net worth. Since
the market price of the company on a stock exchange depends upon the future earning potential
and the future net worth of the company, they are in a position to determine whether the company
is currently undervalued, overvalued, or reasonably valued on the stock exchange. Market data is
crucial in helping analysts decide on these valuations.
All the types of data discussed previously qualify as market data and are exceptionally important
for these kinds of analysis. Analysis and investment research are continuous activities. Once a particu-
lar valuation is arrived at, analysts keep track of all happenings in that sector through the constant
availability of market data.Once the analysts arrive at these future valuations, they circulate it amongst internal portfolio
managers, dealing rooms, private clients, and so on, and these analysis reports result in buy/sell or
hold calls for the institutions holding these shares or wanting to get into that security. Interestingly,
these analysis reports and buy/sell calls are also circulated as market data. Market data service providers
buy these research reports and distribution copyrights and then broadcast the analysts’ opinions to
their clients. Such types of market data form value-added information for other customers who would
have to otherwise process a lot of the raw data discussed earlier to arrive at these buy/sell calls.
On the basis of these reports (of course, the demand to purchase/sell originates from a variety
of sources; these reports are only one of them) and depending upon how much an institution needs
to invest/divest, the buy or sell order is given to the trading desk. Assume for the purpose of brevity
that the call is a purchase call. We will use this example to ascertain the need of market data for traders.
When a purchase order is given to the trading desk or brokerage desk, it is usually given along
with a limit within which all purchases have to be made. During trading hours, the trading desk
receives a continuous broadcast of bid and offer rates and a minimum volume available against
each rate. In this example, the trader has to purchase shares below a certain limit.
Market data received in the broadcast becomes crucial for this trader, too. This data is constantly
flashed on the trading terminal. Traders’ performance is monitored by their abilities to get the spec-
ified number of shares below the limit price (provided the share itself trades below this limit price on
that day after the trader has received the order). The share in question may trade below and above the
limit specified a number of times during the day. If the stock is relatively illiquid, a small buy order
from someone else may push the stock up, and vice versa. This may prove a bit tricky for a trader.
The market data about this stock related to the order book position will help the trader ascertain
how many of these shares they can get at a particular price (say at the limit price or lower).
Traders will also refer to the volume of shares already transacted during the day. This figure is
normally available as part of market data in terms of both the number of shares transacted during
the day and the value of shares transacted. Some market data providers also provide the weighted
average price for the day. This helps the trader know how far an order’s price is from the weighted
average price of the day. After knowing all this information, the trader will push through the purchase
order either in one go or in multiple lots during the day. The continuous broadcast of market data
relating to bid/offer prices, the volumes available, and the volume transacted become the lifeline
for such traders.
Subscribers normally call for market data for the same instruments from multiple exchanges
and markets. This data is routed in analysis systems to provide various kinds of analysis to help the
dealers. Suppose the sales desk receives a relatively large order, say, for the sale of 100,000 shares of
Microsoft Corporation. The client demands the best possible rate for this deal. Now, shares of Microsoft
Corporation are traded on a number of stock exchanges. Each exchange has its own bid/offer rates,
which will be different from each other (but not substantially different). This difference may be large
enough to tempt the trader to place the order on multiple exchanges, get it transacted, and get the
best available price for the placed order. Such kind of analysis is possible only when the trader has
access to a market data system that has the capability of providing real-time bid/offer rates for mul-
tiple exchanges. Arbitrageurs also use this kind of data to spot price differences for the same security
across markets and exploit these differences by buying on markets where prices are lower and sell-
ing simultaneously where prices are higher.
Risk managers who measure and manage risks on a continuous basis feed on market data. Every
order that can potentially be converted into a trade is taken, and the order quantity is multiplied by
the rates available in a real-time broadcast to arrive at the potential exposure this order would add
to the existing portfolio if it were to get transacted. Apart from the orders flowing in, even the existing
portfolio is valued constantly to arrive at an overall market-to-market profit/loss. For such computa-
tion, every security in the portfolio is chosen, and its valuation is calculated by multiplying the current
prevailing price by the number of shares held in the portfolio. Such analysis is required on a contin-
uous basis to take proactive steps for managing and minimizing risk, especially when the market is
volatile. Sophisticated risk management techniques such as Value at Risk use the data about prices prevailing in the past five years. Some use data such as current volatility, past volatility, and details
about the correlation of movement of the stock with the index, and so on. It is clear that market data
service providers cannot provide all these services. Institutions do a careful analysis to check what
data they can get ready from market data service providers and what they need to store in their existing
application repositories. Data from both sources (from repositories and from market data service
providers) is used with a good amount of computation to achieve business results.
A purchase order, once it is a transacted order, needs to be paid for and settled. (Chapter 1
discussed the entire cycle of payment and settlement.) Settlement and back office people require
a lot of market data such as ISIN codes, SEDOL codes, the pay-in/pay-out dates of the clearing
corporation, and so on, to complete the settlement of these trades. This is required to bring about
uniformity in communication.
Thus, you see that the market data service is crucial to everyone in the securities trading value
chain. However, most of the time data that is received from such service providers is in a raw form
and needs a good amount of cleaning, processing, and value adding before various consumers of
the data can use it.


### 4.1.4 行情数据服务 Market Data Service

Market data service providers usually provide the same set of information. This explains why you get the same news when you move from one financial portal to another (chances are they have subscribed to the same service provider). Key differentiators in market service providers revolve around the following:

Timeliness of data: This is whether data is coming real time or is delayed. If historical data is
also available, then how long is the history? We devote the next section of this chapter to
understanding why timeliness is important as far as market data is concerned.
Coverage of data: This means data is covered across markets such as forex, stocks, bonds,
derivatives, and so on. Some market data service providers provide more intensive coverage
about some classes of instruments than other service providers and provide preanalyzed
(value-added) data.
Geographical reach: Some service providers specialize in certain geographies such as North
America, Southeast Asia, Japan, and so on. Institutions that want more intensive coverage of
a particular geography subscribe to these services.
Institutional investors whose stakes are high in the market and who can bear the costs normally
subscribe to two or three service providers and use each of their strengths.
Why Is the Timeliness of Market Data Important?
Institutions ensure that the market data they receive is absolutely on time. At times, even delays of
a few milliseconds are undesirable and could lead to a lot of trading losses and missed opportunities.
Several institutions (the number runs into the thousands) have trading interests in financial assets
such as government-issued bonds, corporate fixed-income securities, foreign currencies, equities,
commodities, real estate, and their related derivatives. As discussed earlier, these institutions contin-
uously price these assets and generate buy/sell orders accordingly. Since so many interested parties
exist for any asset/security at any given time, people who have access to the latest or high-quality
information will be in a better position to arrive at a future valuation compared to those who receive
this information late. Assume that a fund manager sitting in the United States tracks a particular sec-
tor such as chemicals closely, has a good grip on the sector, and has been able to make reasonable
assessment of the sector and of the major companies in this sector.

The fund manager knows that a company registered in the United States and producing Polypthalic
Anhydride (PTA) is facing difficult times because one of its major raw materials, Dimethyl Terephthalate
(DMT), has gone up in price drastically. The jump in price is so much that it begins threatening theprofitability of the company. The fund manager also knows that the sales of the company are strong
but that the rise in raw material prices of DMT is hurting badly; therefore, the fund manager speaks
to experts in the chemical industry and finds out that prices of DMT are going to remain high for years
to come. In addition, a chance exists that DMT prices will remain high forever, and its consumers
must accept this fact. The company in question wants to take drastic steps.
Another company produces Naphtha and sells it in the market. The fund manager understands
the chemical business better than the rest of the market and understands well that PTA can also be
produced from Naphtha. He speaks to management and learns that management is determined to
cut raw material prices. He also comes to know that a series of meetings has been scheduled by the
company’s senior management with the senior management of the company producing Naphtha.
He quickly concludes that the company may be considering abandoning the DMT route to produce
PTA and take up the Naphtha route. He calculates the increase in the bottom line from switching
raw materials and also calculates the capital expenditure the company will have to undergo to make
this change. Finally, he arrives at a per-share rate of the post-change scenario. He can work out the
quick numbers on how much more the company could add to its bottom lines because of this change
in raw materials. He can then arrive at the change in the company’s valuations because of this
change. He will then be able to forecast how much change this news will bring to the company’s
share prices. If the change is large enough to trade on, he will call his broker and place a buy order
on this company’s shares.
Assume that his news was correct, and the next week the management announces this policy
change. Market data service providers will pick up this news and broadcast it worldwide. It will also
be reported in all the leading newspapers and broadcast as news on TV. Analysts will then place a buy
recommendation on the stock, and a lot of traders will buy. This surge in demand will cause the prices
to rise. In this entire euphoria, the biggest beneficiary will be the fund manager who deciphered this
vital piece of information and who acted on this news one week prior to the entire market. He ends
up making much more profit in percentage terms than any of his peers in the market. One day of lead
in getting this crucial information could mean a fortune to a lot of people like the fund manager. Of
course, in an attempt to get this kind of news directly from the issuing company (and at most times
before anyone else gets it), many operators jump the gun and commit insider trading, which is pun-
ishable by law in most countries. Insider trading is trading on price-sensitive information that is not
available simultaneously to all.
We will introduce another example where a delay of even seconds could mean losses to
institutions. As normal practice, institutional investors and fund managers talk to the sales desk in
a brokerage house continuously to get feedback on the prices, global and local trends, market outlook,
and investment opportunities. These discussions result in orders on securities that are then passed
to the brokerage firm, and the brokerage firm executes them. Assume that a sales desk in an institu-
tion does not have access to tick-by-tick real-time market data because of system or implementation
issues and is working on data that is delayed by a few milliseconds.
The sales desk, however, believes that the data available to them is real time (because they have
subscribed to real-time service) and doesn’t realize the potential damage the delayed feed can beget.
In the course of this discussion, assume that the sales desk convinces the institution that Microsoft
Corporation is a good stock to buy at the current trading prices. The institution asks about the pre-
vailing price of Microsoft stocks. The salesperson looks at her terminal and says $45.10. The institution
says, “Fine—buy 10,000 for me at $45.10.” Now this order can be executed in two ways. It can be sent
as a limit order with $45.10 as the limit, or if the salesperson is fast enough, she can risk sending
a market order to buy. In case the market price when the market order hits the exchange is still $45.10,
she will get the shares at $45.10.
Now assume the salesperson was working on data she thinks is real time but is actually delayed.
This means that on volatile days, the prices prevailing on the exchange at any given time are different
from the prices the salesperson is seeing on her terminal. In this example, if the salesperson sends
a market order to buy Microsoft Corporation stocks and the prices have actually moved to $46 by then, her order will get filled at $46. This could irk the institution on behalf of which the purchase was
made, and the salesperson will have to give a lot of explanation to explain this difference between
the asked price and the executed price. If the salesperson gives a limit order to curtail this risk of
overpriced execution, this order will not be executed since the market price has moved to $46.
Nonexecution could mean missed opportunity, which most institutions do not like. A couple of such
cases of this would be enough for the institution to start looking for another broker or another salesper-
son. Delayed market data can thus mean loss of trust, reputation, and eventually loss of business.
Sophisticated clients measure the performance of the executing brokers very closely. Their
consistent ability of getting shares/instruments below the specified price is rewarded by giving
more execution orders (which in turn means more brokerage). Similarly, those who consistently
underperform in terms of getting favorable rates or miss getting orders executed are relied less
upon and are not trusted with critical or voluminous orders.
Some market data is sold as delayed data. This comes in about 5 to 15 minutes delayed. Institu-
tions accept these delays because either their trading interest or position in these markets/instruments
is not very high or they don’t intend to trade in these markets/instruments in the near future. Or, maybe
they have subscribed direct services from the exchange that is also providing real-time data through
a separate channel and is being monitored by other dealers.

### 4.1.6 Level Playing Field

After this discussion on the timeliness of market data, you are now in a position to appreciate why
the availability of market data to all is important. This is to ensure that one recipient does not have
any edge over another in terms of the timeliness of data or its content. The timing of market data is
extremely crucial. Traders rely on its timing and accuracy to push through trades worth millions of
dollars. Every tick of data coming to them conveys something and means potential opportunity. If
market data service providers miss providing some ticks of information or if the tics get delayed, it
means loss of trade opportunity for the recipient institution. It is thus highly desirable that the service
provider offering the data services provide its direct recipients with a level playing field. This essentially
means that no preference must be given to any recipient over another for a particular level of service.
Normally market data service providers inform every recipient institution about their various
services and levels of service and provide them an equal opportunity to purchase them. Institutions
then purchase services depending upon the cost incurred and the benefits they yield. A particular
service could have multiple recipient institutions. Market data service providers ensure that no one
gets precedence over the other in terms of the quality of service, level of support and communication,
timing of data dissemination, data quality, and provision of data backup and recovery.
This brings an end to the business topics; in next section, we begin the journey into the network
programming world and explain the relevant area that plays an important role in realizing this busi-
ness case study.

## 4.2 网络简介 Introducing Networking

Networking between computers brought revolutionary changes both in the digital world and in the
human world. In the digital world, a new branch named distributed system was born. Distributed
systems are built around networks, and one of the real-life examples of such a system is the Internet.
The Internet is one of the largest distributed systems in the world; it interconnects computers all
around the globe using different types of networks, and it provides various other useful services such
as e-mail and file transfer. The availability of such services had a direct impact on the human world
by forming one of the basic necessities of today’s modern life. Moreover, network computing yielded
a major shift in software architecture and design space; it revolutionized the way we think about
computing by providing the following benefits:Resource sharing: Resource is a general term used to represent both software and hardware
resources inside a computer. A hard disk represents hardware resources. Software resources are
represented in the form of files, databases, and so on. Resources are scarce and also costly, but
with a communication backbone in place, both expensive software and hardware resources are
now easily shared with other computers in the network.
Connecting heterogeneous systems: Networks not only opened the communication door to personal
desktops but also allowed communications with heterogeneous systems of different breeds such
as mainframes, handheld devices, wireless devices, and so on.
Scalability: Software systems have fully embraced a distributed style of architecture, factoring
out the code in the form of network components, deploying it on a faster machine, and finally
sharing it among all clients.
When it comes to the implementation of a network, it is mainly three major components that
cohabit, and their sole interaction and coordination determines the success of the network:
Transmission media: Transmission media plays a pivotal role in a network; it connects media
devices such as computers, routers, and hubs to form a network. In a local network environment,
cable wire transmits messages from one device to another device. However, in a wide area network,
the transmission media could be a telephone device or a dedicated leased line.
Hardware components: Hardware components handle the complexities involved in interfacing
with transmission media; additionally, they contain sufficient knowledge to oil the raw messages
directly received from the transmission media, translate them to the correct encoding format,
and pass them to the software components. The most commonly found hardware components
in a network are routers, network interface cards (NICs), and so on.
Software components: Messages received from hardware components are forwarded to network
device drivers that reside in the kernel part of the operating system. This message, once processed
by the device driver, is then passed over a chain of software abstraction layers where multiple
software components employ further application-specific processing logic. Software components
such as the Windows socket library or remote procedure library are extensively utilized in build-
ing a networked software system. This library abstracts away the low-level network details and
provides developer-friendly network programming interfaces.
These three components play a major role by conducting a series of micro-operations under
the hood that are totally transparent; discussing each of these micro-operations is outside the scope
of this book. However, the software component is the primary target, and the rest of this chapter delves
into this topic in detail.
A protocol in general terms is an agreed method of exchanging views or opinions. In a network
world, identifying and defining a suitable protocol is important, and based on this agreed protocol,
the message will then be exchanged among nodes. A node is a device such as a computer, hub, router,
and so on, that is attached to a network. To meet this need, TCP/IP (Transmission Control Protocol/
Internet Protocol) was invented. TCP/IP is a ubiquitous protocol and is universally accepted as
a communication backbone of the Internet. TCP/IP is not a one-organization effort; it was the brain-
child of many researchers, universities, and organizations. It has been in existence for the last couple
of decades, and over this period, it has evolved to form one of the most robust communication
protocols.
Communication between two nodes in a network is established using TCP/IP, but TCP/IP is
not a single protocol; it is a suite of protocols where each protocol is layered one on top of another.
Figure 4-2 shows a condensed version of the most popular Open System Interconnection (OSI)
model.

Figure 4-2. TCP/IP layers


A message triggered from a client is received and processed by all four layers depicted in Figure 4-2.
An individual layer appends its own layer-specific information to the message before dispatching it
to the destination. A similar action is carried out on the receiving end (the server); the layer-specific
information padded by the client is stripped out as it is promoted to each layer, and finally the message
is submitted to the application layer. When an application message is passed from the application layer
to the transport layer, this message is padded with additional transport layer information, and the
newly formed message is known as a segment. A segment is then passed to the Internet layer that is
again appended with the Internet layer–specific information to form a datagram. The datagram is
passed to the final layer that transforms it to a frame and finally into bits (that is, 0 or 1) that are then
delivered over the transmission media. Such a layered architecture model is one of the distinct
strengths that singles out TCP/IP from the rest of the other communication protocols. Here are the
roles played by individual layers:
Network interface layer: This layer is primarily linked with the transmission media and hardware
component; it is responsible for decomposing the network packets into a common transmission
medium and recomposing them again on the receiving end.
Internet layer: The Internet layer is responsible for addressing a node on a network and routing
a network packet to the destination host in a network. Additionally, this layer also looks after
the diagnostic aspect in a network, such as conducting a node health check to find out whether
a specific node in a network is reachable.
Transport layer: The transport layer provides advanced functionality to the application layer, such
as handling sessions, delivering data reliably, regulating the flow of data on a network, ensuring
the ordering of the message during the sending and receiving phases, and so on.
Application layer: The application layer comprises applications that satisfy the network need of
the applications. This is the highest layer in the TCP/IP suite, and the most commonly used
applications in this layer are Simple Mail Transfer Protocol (SMTP) to exchange mails or File
Transfer Protocol (FTP) to upload a file to a remote machine.
Internet Protocol
The first common requirement in any type of communication is to have at least two entities; one is
the sender, and the other is the receiver. Both of these entities need to know each other’s address. A
real-life analogy is a postal mailing address; to deliver an important parcel, it is mandatory to know
the destination address as well as the source address, so in the case of a delivery failure, the parcel
will be returned to the sender. So, in a TCP/IP-based network world, you need a similar addressing
mechanism that allows the individual node to communicate with other nodes in a network. IP is responsible for addressing nodes in a network by assigning a unique 32-bit address known as an IP address. The IP address, along with the addressing, is also responsible for the movement of the network packet between nodes. Figure 4-3 depicts a common scenario of finding out the IP address of the local host in a network.

Figure 4-3. IPConfig output
Figure 4-4. Bridging networks with routers

In Figure 4-3, the IP address is denoted in four decimal-based integers, and each delimited
digit occupies 8 bits, so a binary representation of 10.255.243.51 is 11000000 10101000 00000000
01100100. A 32-bit IP address would theoretically allow 232 nodes in a network to be addressed, but
in reality this is not how it works. The IP address is broken down into two parts; the first part stores
the physical network ID, and the second part stores the unique ID of a node in that physical network.
Hosts on the same physical network can directly communicate with each other; however, when an
individual host wants to exchange data with another host on a different network, then the data
need to be handed over to a network router (see Figure 4-4).
A network router is a device that is connected to more than one network, and its primary job is
to route packets from one network to another network. So, a router bridges a path between two separate
networks, but the actual allotment of IP addresses in a network is implemented by following standard
rules established by the Internet community. Five predefined network address classes determine the
number of networks and number of hosts in a network (see Table 4-1).

Table 4-1. Network Address Classes
Bytes Bytes Binary Number of
Allocated Allocated Format Total Hosts per IP Address
Class (Network) (Host) (Network) Network Network Range
Class A 1 3 0xxxxxxx 126 16,777,214 1.x.x.x–126.x.x.x
Class B 2 2 10xxxxxx xxxxxxxx 16,384 65,534 128.x.x.x–
191.255.x.x
Class C 3 1 110xxxxx xxxxxxxx 2,097,152 254 192.x.x.x–
223.255.255.x
As you can see in Table 4-1, only the first three network classes are described because Class D is
explained in the “Broadcast” section of this chapter and Class E is used purely for experimentation
purposes. Class A has the maximum potential to address the large number of hosts per network com-
pared to Class C, which has a lower capacity to address hosts per network. Additionally, the total
number of bytes allocated to the network is not utilized to their full storage capacities; all three network
classes mandate a particular portion of high-order bits to follow a specific pattern. For example, in
a Class B network, the first two high-order bits are always set to binary 10.
Class A also contains a loopback address, 127.x.x.x, that is used mainly to test network applica-
tions that are detached from the physical network. This loopback address is a special-purpose IP
address similar to any other IP address; the only difference is that the processing of data terminates
at the IP layer instead of at the network layer. Besides the loopback address, there is also a specific
range of IP addresses assigned for multicast IP addresses; we cover them in more detail later in the
“Broadcast” section.
The IP address, besides containing the network ID and host ID, also contains the subnet ID.
With the help of the subnet ID, a large physical network is further partitioned into a logical subnet-
work and then accordingly groups relevant nodes in this newly created subnetwork. For example,
a small-scale firm assigned with a Class C IP address will allow 254 hosts per network, but in an effort
to create a smaller network, this firm can further adopt a strategy to subdivide its existing network
based on organizational divisions such as Marketing, HR, and so on. That is the reason you see a subnet
mask entry in Figure 4-3; a subnet mask determines the number of subnetworks and hosts inside
a network.
The host ID portion is used to create a subnet division, so in a Class C network where 1 byte is
assigned to an address host, a network administrator can assign 4 bits of this byte to a subnet ID and
the remaining 4 bytes to a host ID. Therefore, according to this new formula, given a single IP address
in a physical network, you can form 16 logical subnetworks and 16 hosts per logical subnetwork. The
representation format of a subnet mask is similar to the IP address format. For example, the default
subnet mask for a Class C address is 255.255.255.0, so to create 16 logical subnetworks and 16 hosts
per logical subnetwork, the new subnet mask would be 255.255.255.240. The mask contains 1s for
the subnet ID and 0s for the host ID, so the binary representation of this mask would be 11111111
11111111 11111111 11110000.
IP is an unreliable protocol even though it attempts a best-effort delivery service. It poses some
serious shortcomings such as it offers no guarantee that the packet will get delivered to the target host.
Furthermore, the packet may get delivered in a nonsequential manner; as a result, the target host will
notice messages are being received in an out-of-sequence order. Despite such problems, IP is still
a cornerstone of the TCP/IP communication backbone, and its limitations are nicely handled by its
upper layer.
The IP datagram, along with the actual message to be delivered, also contains its own header
fields that are required to properly route a message to the destination host. The following sections
describe the key fields of the IP header and are categorized according to their usage.

Addressing
The two most important fields of the IP header are the source address and destination address. Both
addresses represent the IP address of the sender and the destination host in a network, and each
field occupies 4 bytes of memory storage.
Data Length
This 2-byte field stores the total length of the IP datagram, which also includes the length of the
data. Based on this value, it would allow you to send 65,535 bytes of the IP datagram, but the actual
maximum size is determined based on the underlying network maximum transmission unit (MTU).
The MTU determines the maximum size of packet that could float on a network. The MTU of a network
is computed based on the end-to-end communication link of two hosts. For example, if a sending
host in a local area network communicates with a target host that is geographically distributed and
connected using telephone lines, then the smallest MTU between the two hosts is computed.
Fragmentation
When the IP datagram size exceeds the MTU capacity, it undertakes a fragmentation and reassem-
bling process. Fragmentation happens on the sender’s end, and during this stage, the IP datagram is
broken into a smaller datagram to fit within the range of the MTU. The IP datagram is then tagged
with the additional information, described as follows, that is important to successfully reassemble
the message on the receiving end:
Flags: Based on this field value, it is determined whether the IP datagram is fragmented.
Identification: A 2-byte autoincrement field used to uniquely identify the IP datagram. The IP
datagram constructed because of the fragmentation process shares the same identification
number; this allows the target host to know how to reassemble this fragmented packet into
original data.
Fragment offset: The fragment offset denotes the original position of the fragmented datagram
relative to the original unfragmented datagram.
Diagnostic
The following are the important fields that are used to maintain the integrity of a message:
Header checksum: This is a mathematical hashed value of an IP header computed to verify the
integrity of the IP datagram.
Time to live: The lifetime of the datagram wandering on a network is based on this value; every
time a datagram passes through the router, this value is decremented by a factor of one. When
it reaches zero, it is deemed to be a dead packet and finally discarded.
The IP layer is also responsible for monitoring the health status of the network and reporting
appropriate error messages or additional information in the case of a network outage. This functional-
ity is not part of IP; it is offloaded to Internet Control Message Protocol (ICMP), which is part of the
IP layer. ICMP acts as a messenger that reports errors and feedbacks about activity happening inside
a network. Activities such as a failure to transmit packets to a destination host are recorded and
encapsulated inside an ICMP message; the sender is then notified of this message using the IP
unreliable delivery service. ICMP messages are embedded inside the IP datagram and form part of
the data section. The following are some of the most commonly noticed ICMP messages:

Figure 4-5. Ping output
Echo request: An echo request message is generated to check the network availability of the
remote host
Echo reply: A message generated in response to the echo request message
Destination unreachable: A message generated by intermediate routers to notify the senders
about a failure to deliver the datagram to the designated host
The most popular program used by developers to diagnose network-related problems is the
Packet Internet Groper Utility (PING). The PING program is bundled with the operating system and
used to generate both the echo request and echo reply messages. When a sender initiates a ping to
the destination host, the PING program on the sender end generates an echo request message and
sends it to the destination host. On receiving this message successfully, the destination host generates
an echo reply message and transmits it to the sender. The output of the PING program also contains
the round-trip time (RTT) that forms a strong basis to find out the strength of the underlying network
(see Figure 4-5). The RTT value computed is the difference of time between the echo request message
and the echo reply message.
In Figure 4-5, the destination host is addressed using the IP address. There is no doubt that the
IP address directs the pathway of a network packet, but given the nature of the IP address, which is
encoded in numeric format, it is highly nonintuitive for a human to reckon it. To overcome this
problem, a new service, the Domain Name System (DNS), was implemented.
DNS is a set of protocols used in a TCP/IP network environment to assign a human-
understandable name to an individual host in a network. Each host name is then mapped to an IP
address, and this mapping information is centrally stored and maintained by the DNS server. DNS,
because of its mapping capabilities, is also popularly known as a name server. It is a central database
where the host name and its corresponding IP addresses are stored and retrieved on demand. DNS
also provides a bidirectional resolution capability to resolve a host name to an IP address, and vice
versa.

The database of DNS is distributed; multiple DNS servers exist and are hierarchically arranged,
and individual DNS servers know their parent DNS servers. When a DNS server receives a request to
resolve a host name, a search is first conducted against its own local database. If the local database
fails to satisfy the request, then DNS undertakes a “recursive resolution” mode where the request starts bubbling up to the parent DNS server. The immediate parent DNS then conducts a similar
search operation in its local database, and on failure it delegates to its parent. This escalation is
iterative in nature and terminates when it reaches the root DNS server where the final result is deter-
mined. To speed up the resolving request, DNS also maintains a cache database; this caching technique
is employed to decrease the search cost that is incurred when the recursive-resolution process triggers.
DNS along with the local database querying also enumerates the cache database before escalating
to its parent DNS.
To demonstrate the benefit provided by the DNS service, we will show the first code of this
chapter. The .NET Framework BCL provides a rich set of network class libraries; these libraries allow
you to design a highly robust and scalable network application and are available as part of the
System.Net and System.Net.Sockets namespaces.
Listing 4-1 shows how to resolve a host name to its IP address.
Listing 4-1. Host Translator

	using System;
	using System.Net;
	namespace HostTranslator
	{
		class Translator
		{
			[STAThread]
			static void Main(string[] args)
			{
				//Get Local Host Name
				string hostName = Dns.GetHostName();
				Console.WriteLine("Local HostName : " +hostName);
				//Ask user to enter IP address or host name
				Console.Write("Enter IP Address or Host Name : ");
				string hostOrip =Console.ReadLine();
				//Resolve the host/IP address
				IPHostEntry entry = Dns.Resolve(hostOrip );
				Console.WriteLine("HostName : " +entry.HostName);
				//Get the IP address list that resolves to the host names
				foreach(IPAddress address in entry.AddressList)
				{
					Console.WriteLine("IP Address : " +address.ToString());
					byte[] addressBytes = address.GetAddressBytes();
					for(int ctr=0;ctr<addressBytes.Length;ctr++)
					{
						Console.WriteLine("Byte : " +ctr +" : " +addressBytes[ctr]);
					}
				}
			}
		}
	}

In Listing 4-1, the program accepts either an IP address or a host name and then passes this infor-
mation to the DNS service to resolve it. The DNS resolution service from a programmatic perspective is
provided by the Dns class, and it supports both forward-lookup and reverse-lookup capabilities. When
resolving is performed using a host name, it is known as forward lookup; similarly, when resolving is
done using an IP address, it is known as reverse lookup. Both resolving techniques take place by
a Resolve of the Dns class. Resolve is a time-intensive operation, and keeping this aspect in mind, Dns
provides an asynchronous flavor of the Resolve method in the form of BeginResolve and EndResolve.

Figure 4-6. HostTranslator console output

The result returned by Resolve is encapsulated in an instance of the IPHostEntry class. The
IPHostEntry class provides both the host name and IP address information; the host name is displayed
by invoking the HostName property, and the IP address is displayed by accessing the AddressList
property, which returns an array of IPAddress.
IPAddress is a programmatic representation of the host IP address, and it wraps the dotted
quad notation IP address in a byte array and is accessed by invoking the GetAddressBytes method.
When the previous translator program is compiled and executed, it displays the output to the
console (see Figure 4-6); the input provided to the program is the host name of the local machine,
which returns the IP address.
Transport Layer (User Datagram Protocol)
The IP layer handles the communication between two hosts; similarly, the transport layer is responsible
for the communication between two networked applications. The transport layer provides a data
delivery service to the application layer. It is the network face to the applications, and the developer
invokes the appropriate API exposed by this layer in order to deliver a message to the destination host.
The host in a network is identified by a 4-byte IP address, and the message exchange between two
hosts is performed using this IP address. This addressing mechanism is useful only when the commu-
nication is between two hosts. When the communication is between applications and with multiple
applications running inside a host, you need a different addressing mechanism. To address this
requirement, the transport layer contains network port information; the network port (the transport
layer) and IP address (the IP layer) are combined to form a network endpoint that is associated with
an individual application.
A perfect example of an endpoint in the real world is the customer service care of a bank. It is
almost like a virtual bank that provides all kinds of support such as opening an account, transacting
an inquiry, and so on. Customers avail of this support by dialing a toll-free number provided by a bank;
after dialing this number, the customer is connected to the Interactive Voice Response System (IVRS)
that lists all the bank’s services and their corresponding extension numbers. The customer dials the
appropriate extension, and the call is transferred to a customer representative who is specifically
trained in the selected customer service area. The gist of this example is to further widen your under-
standing that in the computer network world, the toll-free number is the IP address, and the extension

Figure 4-7. Market data producer (MDP) and market data consumer (MDC)
number is the port number. Moreover, multiple applications are specialized to provide different
kinds of services. To avail of this service, it is mandatory to know both the IP address and the port
number.
The transport layer provides TCP and User Datagram Protocol (UDP), which encapsulates and
forwards messages from one network endpoint to another endpoint, and the existence of both of
these protocols is meant to cover different goals of the application.
UDP, unlike TCP (discussed in the next section), is a connectionless protocol; communication
between applications using UDP is simple and straightforward. There is no set-up cost involved in
setting up a UDP communication channel; instead, UDP-driven applications can directly exchange
messages with each other solely based on their endpoint information. The only major drawback with
UDP is that it provides no guarantee that a message will successfully reach its destination. To address
this limitation faced by UDP, applications at the application layer have to devise and implement their
own logic that ensures the successful delivery of messages. UDP is just an additional layer above the
IP layer, and it blindly forwards the message received from applications to the IP layer with no further
intelligence applied to it. This doesn’t mean UDP is singled out; UDP is still needed and plays an
important role in implementing the network broadcast, which is explained shortly.
UDP and TCP form the message delivery backbone of today’s modern distributed application,
and network programming using this protocol is fairly easy because of the abstraction provided by
the underlying network library; this abstraction is exposed in the form of a socket. A socket is a net-
work data conduit that allows the sending and receiving of raw bytes. A socket is similar to a stream
that hides the underlying storage details. A socket hides the implementation-level detail of the under-
lying network protocol such as IP, TCP, UDP, ICMP, and so on, and provides a uniform interface to
interact with them. Using a socket, we will show how to implement the first market data example
that uses UDP to deliver the message. This example represents a typical data producer and consumer
scenario, where there is a single producer and multiple consumers of the market data message (see
Figure 4-7).
Listing 4-2 shows the code for the market data producer service.
Listing 4-2. Market Data Producer (Using UDP)

	using System;
	using System.Collections.Specialized;
	using System.Collections;
	using System.Net.Sockets;
	using System.Net;
	using System.Text;
	namespace MDP
	{
		class MDP
		{
			[STAThread]
			static void Main(string[] args)
			{
				Console.WriteLine("Market-Data Producer Service Started");
				//Market Data
				string mktPrice = "MSFT;25,IBM;24";
				//Market Data Recipient List
				EndPoint[] mdcEndPointList = new EndPoint[]{new
				IPEndPoint(IPAddress.Loopback,30000)};
				//Build a network data conduit
				Socket mdpSocket = new
				Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
				//Convert the data into array of bytes
				byte[] sendBuffer = new byte[512];
				sendBuffer = Encoding.ASCII.GetBytes(mktPrice);
				//Iterate through recipient list, and transmit the data
				foreach(EndPoint mdcEndPoint in mdcEndPointList )
				{
				mdpSocket.SendTo(sendBuffer,mdcEndPoint);
				}
				Console.WriteLine("Market Data Sent to all Market-Data consumer clients");
				Console.ReadLine();
				//Free the resources
				mdpSocket.Close();
			}
		}
	}

The program described in Listing 4-2 plays the role of a market data producer (the server); it
internally maintains a list of clients with whom the market price information is shared. With this
code, you also mark the beginning of your journey into the socket programming world. The two
important namespaces to add in your mental toolkit are System.Net and System.Net.Sockets. Both
these namespaces provide a gamut of network classes.
The actual market data contains the name of the underlying and current price; a semicolon
concatenates this information. Also, it’s repeatable information, so we have used a comma charac-
ter as a record delimiter.
string mktPrice = "MSFT;25,IBM;24";
The information about the market data consumer (the clients) waiting to receive data is stored in
an array. The underlying type of array element is EndPoint. EndPoint is an abstract class that encap-
sulates the address of a network resource and is subclassed by IPEndPoint.
EndPoint[] mdcEndPointList = new EndPoint[]{new
IPEndPoint(IPAddress.Loopback,30000)};
IPEndPoint represents the address of a UDP- or TCP-based application and is created for indi-
vidual market data consumer clients by combining the IP address and the port number. The first
argument of the IPEndPoint constructor method expects an instance of IPAddress, and accordingly
IPAddress.Loopback value is passed. IPAddress.Loopback represents a loopback address. The second
argument represents the port number.
Next, you create a new instance of Socket. Socket builds a network data conduit that allows the
application to send or receive data across the network. Three pieces of information are required to
successfully start the data flow. These are the network address type, socket type, and protocol type,
as shown here:
Socket mdpSocket = new
Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);188C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
The network address type defines the addressing scheme to resolve an EndPoint, and the most
commonly used network address type is AddressFamily.InterNetwork that recognizes IPv4 addresses.
You then assign the socket type and protocol type; this information goes hand in hand and dictates
a strict combination. For instance, when the protocol type is ProtocolType.Udp, the only socket type
supported is SocketType.Dgram.
After instantiating a new instance of a Socket, the next step is to deliver data. The data is always
encapsulated in a strongly typed object, and it needs to be converted into raw bytes. This conversion
is achieved by the Encoding defined in the System.Text namespace. Encoding provides various types
of encoding implementations that support converting strings to and from array of bytes.
byte[] sendBuffer = new byte[512];
sendBuffer = Encoding.ASCII.GetBytes(mktPrice);
The most important code is where individual client endpoint information is retrieved from the
MDC recipient list; this information and actual data is then supplied to the SendTo method that finally
transmits data to the specified endpoint:
foreach(EndPoint mdcEndPoint in mdcEndPointList )
{
mdpSocket.SendTo(sendBuffer,mdcEndPoint);
}
In the final leg of the code, as follows, you close the socket connection, which also releases the
underlying memory allocated by Socket. A word of caution: Socket, once closed, can no longer be
used to either send or receive messages over a network.
Console.WriteLine("Market Data Sent to all Market-Data consumer clients");
Console.ReadLine();
mdpSocket.Close();
This brings an end to the market data producer aspect of this example. The next step is to look
at the market data consumer code; the main function of the code in Listing 4-3 is to receive data
published by the market data producer, so the technique employed is more or less similar to the
market data producer service.
Listing 4-3. Market Data Consumer (Using UDP)
using System;
using System.Collections.Specialized;
using System.Collections;
using System.Net.Sockets;
using System.Net;
using System.Text;
namespace MDC
{
class MDC
{
[STAThread]
static void Main(string[] args)
{
Console.WriteLine("Market-Data Consumer Service Started");
byte[] receiveBuffer = new byte[512];
EndPoint bindInfo = new IPEndPoint(IPAddress.Loopback,30000);
Socket mdcSocket = new
Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 189
try
{
//Associates socket with a particular local endpoint
mdcSocket.Bind(bindInfo);
EndPoint endPoint = new IPEndPoint(IPAddress.Any,0);
//receives a datagram, and the call blocks until data is received
int bytesReceived = mdcSocket.ReceiveFrom(receiveBuffer,ref endPoint);
//market data sender information is recorded
IPEndPoint mdpEndPoint = (IPEndPoint)endPoint;
string mktPrice = Encoding.ASCII.GetString(receiveBuffer,0,bytesReceived);
Console.WriteLine("Market-Data Received : " +mktPrice);
Console.WriteLine("Market Data Producer IP Address {0} Port {1} "
,mdpEndPoint.Address.ToString(), mdpEndPoint.Port);
}
catch(SocketException e)
{
Console.WriteLine(e.ToString());
}
Console.ReadLine();
mdcSocket.Close();
}
}
}
In Listing 4-3, we have explicitly added the socket exception handler that is excluded in the
market data producer code. By enclosing network-related operations inside a try-catch block, you
get the opportunity to catch SocketException. SocketException provides additional information
that is extremely valuable in troubleshooting network-related failures. The ErrorCode property of
SocketException returns a socket-specific code, and to correctly interpret it, you will have to refer to
Windows Socket Version 2 API error code documentation in MSDN.
Listing 4-3 contains a new instance of IPEndPoint and Socket. The arguments supplied to the
IPEndPoint constructor method must match the market data recipient list maintained by the market
data producer service.
EndPoint bindInfo = new IPEndPoint(IPAddress.Loopback,30000);
Socket mdcSocket = new
Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
After creating a socket, Bind is invoked, which associates a Socket instance with a particular
local endpoint:
mdcSocket.Bind(bindInfo);
A local endpoint contains both the IP address and the port number, but the IP address is sufficient
to identify the underlying NICs associated with it. Bind proves to be very nifty in a multihomed sce-
nario. A multihomed host is equipped with two or more NIC, and each NIC is assigned a different IP
address. A multihomed host provides multiple channels to communicate data, and by calling Bind,
you explicitly specify the channel from which data is communicated. It is absolutely necessary to call
Bind if the application is configured to receive data.
Bind is never called in the market data producer code because during the data delivery phase
you were not concerned with any specific local endpoint and instead delegated this task to the under-
lying network service provider that uses an appropriate local endpoint. But if a need arises to know
the local endpoint of a Socket, you can always get this information by accessing the LocalEndPoint
property of Socket.
The next step is to receive data, which is done by invoking ReceiveFrom. This method blocks
until data is received, so when new data arrives, the method unblocks and populates the byte array
and remote host information. The remote endpoint contains the IP address and port number used190C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
Figure 4-8. MDC (UDP) console output
Figure 4-9. MDP (UDP) console output
by the market data producer service to deliver this data. Additionally, this method also returns an
exact number of bytes read. Accordingly, you extract that number of bytes using the GetString
method of the Encoding.ASCII class.
EndPoint endPoint = new IPEndPoint(IPAddress.Any,0);
int bytesReceived = mdcSocket.ReceiveFrom(receiveBuffer,ref endPoint);
IPEndPoint mdpEndPoint = (IPEndPoint)endPoint;
string mktPrice = Encoding.ASCII.GetString(receiveBuffer,0,bytesReceived);
Console.WriteLine("Market-Data Received : " +mktPrice);
Console.WriteLine("Market Data Producer IP Address {0} Port {1} "
,mdpEndPoint.Address.ToString(), mdpEndPoint.Port);
Finally, the connection is closed, and the underlying memory used by Socket is released:
mdcSocket.Close();
With this code, you have completed the first example. Figure 4-8 and Figure 4-9 show the con-
sole output generated by the MDC and MDP.
This example provided a first-hand taste of socket programming in the .NET world, and you
implemented it using UDP. Although in reality UDP comes into action only in a specific scenario,
most of the time applications are designed using TCP. UDP undoubtedly is the fastest delivery
transport protocol, but it has some serious drawbacks:
Unreliable: UDP provides no guarantee that data will ever reach its destination; this means in
the previous example the market data information published may or may not reach the market
data consumer. If you are looking for this kind of reliability feature, then you have no other
choice but to hand-roll custom logic at the application level.
Unordered sequence: Consider an example where market data is continuously pumped by the
market data producer service, and in such cases the consumer will face a huge surge of data. If
you look at the pattern of information published, you will find a case where a price of a stock is
sent, and immediately an updated price for the same stock is delivered. In such cases UDP does
not guarantee that the updated price information will be delivered only after the old price infor-
mation is delivered. On the receiving end, you can imagine the impact on the application and
its downstream components when it first receives the updated price and when afterward it
receives the stale price.C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 191
Network congestion: A strong flow control is required that can sense the network, find out its
maximum capacity, and based on its current utilization throttle the amount of data pumped
on network. This will ensure the optimum utilization of the network, but UDP doesn’t support
such features, so it is pretty easy to choke the network by continuously generating and sending
messages.
UDP is a simple protocol, but it lacks many of the characteristics that are essential for conducting
reliable communication. To address the caveats faced by UDP, TCP was invented and is considered
to be the most robust transport protocol available for any type of internetwork communication.
Transport Layer (Transmission Control Protocol)
The most appealing features of TCP are its various out-of-band features that are offered to ensure
the reliable delivery of application data. The reliability service provided by TCP has strongly estab-
lished its presence in the Internet world where millions of systems exchange data using TCP. TCP is
a connection-oriented protocol; this means both the sender and the receiver must perform a hand-
shaking before exchanging data. After successful handshaking, a TCP connection is established
between the sender and the receiver; using this connection, the sending application sends data to
the destination application, or vice versa. Many popular protocols such as SMTP, FTP, and HTTP are
built on top of TCP. Some of the important features supported by TCP are as follows:
Reliable: TCP implements the reliability service by acknowledging each message sent to the
destination host, and the failure to receive an acknowledgment receipt from the destination
host within a predefined time will initiate a retransmission of the message. This mechanism is
implemented by tagging every TCP segment with a unique sequence number, and both the source
and destination applications know each other’s last sequence number received or sent by them.
Another benefit of the sequence number is it helps to detect and resolve the message duplication
or out-of-order issues. In a case where the TCP message arrives out of order, TCP waits for its
predecessor message to arrive and reassembles them in the correct order before passing them
to the application.
Handshaking: UDP is very informal when it comes to sending or receiving messages; besides
knowing each other’s endpoint information, no additional steps are needed either from the send-
ing host or from the receiving host. This is in contrast to TCP where before the data exchange
takes place, both the sender and the receiver first negotiate the protocol initialization information.
This includes information such as the sender and receiver starting sequence number, the TCP
window size, and the TCP maximum segment size (MSS). The MSS is equivalent to the MTU, but
the MTU represents a network; similarly, the MSS represents TCP. The MSS determines the largest
size of the TCP segment, and during the TCP connection set-up phase, both the sender and the
receiver announce their MSS values. Most of the time, the MSS mirrors the host MTU. The MSS
lessens message fragmentation happening at the IP layer. Fragmentation is an expensive operation
and seriously hampers the performance of the application.
TCP follows a similar negotiation technique when the connection is closed. During the connection
closing stage, TCP ensures that both the sending and receiving hosts don’t have pending data to
be delivered or received.192C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
Flow control: TCP handles a fast producer and slow consumer scenario well. In this scenario, the
producer generates the message and transmits to the consumer at a rate higher than the consumer
ability to consume it. To stop the sender from bursting messages to the receiver, TCP implements
an adaptive sliding window technique.
A data receive buffer, also known as window size, is allocated for the individual TCP connection
established between the client and server. This buffer acts as intermediate storage for the receiver
and represents the maximum capacity of data it can handle at one time from the sender. When
TCP data is received, it is first copied into this buffer and is emptied only when the application
makes an explicit request. Until that time, data is temporarily stored in this TCP buffer. So, if
the application is executing computational-intensive tasks in parallel, then it is quite possible
that it may not be able to read data in a timely manner, which will introduce a slow consumer
scenario. In such cases, the receive buffer will get quickly filled up, and the sender will immedi-
ately stop sending more data. Therefore, it is extremely important that the application quickly
read data from the TCP buffer and queue it in the application-maintained in-memory storage.
An application can request data from this buffer either in a large chunk or in a smaller chunk.
This TCP buffer from the sender point of view becomes the sender window size and from the
receiver point of view becomes the receiver window size. The window size is dynamic in nature
and mainly depends on how quickly the application is able to read data from this buffer. The
receiver window size value is always stored inside an acknowledgment message sent by the receiver
to the sender and forms the basis of implementing a strong flow control. The sender checks the
window size published by the receiver as part of the TCP acknowledgment message, and if its value
falls below zero, then the sender will stop sending any further data until it notices an increase in
window size.
Now we will show how to reimplement the earlier market data example (see Listing 4-2 and
Listing 4-3) using TCP. From a coding perspective, Listing 4-4 is more or less similar to its UDP coun-
terpart; however, certain prerequisite are required to be set up before the market data consumer (the
client) requests data from the market data producer (the server). The following code is the TCP version
of the market data producer (the server) and listens for a request from the market data consumer
(the client). As soon as the client connects, the data is prepared and delivered using TCP.
Listing 4-4. Market Data Producer (Using TCP)
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace TCPMDP
{
class MDP
{
[STAThread]
static void Main(string[] args)
{
IPEndPoint localEP = new IPEndPoint(IPAddress.Loopback,20000);
Console.WriteLine("Market-Data Producer Service Started - Using TCP");
//Market Data
string mktPrice = "MSFT;25,IBM;24";
//Create network data conduit
Socket mdpSocket = new
Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
//Associate socket with particular endpointC H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 193
mdpSocket.Bind(localEP);
//server starts listening for client connection
mdpSocket.Listen(10);
while(true)
{
//synchronously extracts the first pending connection request
Socket mdcSocket = mdpSocket.Accept();
IPEndPoint mdcRemoteEP = mdcSocket.RemoteEndPoint as IPEndPoint;
Console.WriteLine("MDC EndPoint Info {0} {1} :
",mdcRemoteEP.Address.ToString(),mdcRemoteEP.Port);
//data is flatted into array of bytes and
//dispatched to client
byte[] sendBuffer = new byte[512];
sendBuffer = Encoding.ASCII.GetBytes(mktPrice);
mdcSocket.Send(sendBuffer);
//client connection is closed
mdcSocket.Shutdown(SocketShutdown.Both);
mdcSocket.Close();
}
}
}
}
In the UDP version of the market data producer (described in Listing 4-2), you should have
observed the sender directly sending data to a particular endpoint, assuming the receiver on the
other end is waiting to receive it. There is no implicit way to determine whether the receiver has
successfully received the data. But in a connection-oriented world, it’s a different story; the receiver
beforehand must know the sender endpoint information and explicitly connect to this endpoint.
A connection is deemed to be successful only after the sender accepts it.
In Listing 4-4, the first step is to define a local endpoint to which the market data consumer
client will connect to receive market data. In this example, you identify the loopback address and
port number 20000. In the next step, a socket is created, the socket type passed is SocketType.Stream,
and the protocol type is ProtocolType.Tcp. This newly created Socket is then associated with the
local endpoint by invoking the Bind method.
IPEndPoint localEP = new IPEndPoint(IPAddress.Loopback,20000);
Console.WriteLine("Market-Data Producer Service Started - Using TCP");
string mktPrice = "MSFT;25,IBM;24";
Socket mdpSocket = new
Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
mdpSocket.Bind(localEP);
The Listen method, shown next, puts the Socket in listening mode. A Socket in listening mode
actively listens for an incoming client connection request. The argument passed to this method
determines the maximum number of entries in the TCP incoming connection request queue. When
a client connection request arrives, it is first placed in this connection request queue and is dequeued by
the application with a call to Accept. In a stress scenario where multiple connection requests arrive in
a concurrent fashion, it is important for the application to dequeue this connection request fast
enough so that the number of entries in the queue doesn’t exceed the maximum limit.
mdpSocket.Listen(10);
Socket mdcSocket = mdpSocket.Accept();
IPEndPoint mdcRemoteEP = mdcSocket.RemoteEndPoint as IPEndPoint;
Console.WriteLine("MDC EndPoint Info {0} {1} :
",mdcRemoteEP.Address.ToString(),mdcRemoteEP.Port);194C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
Accept drains the connection request queue in a FIFO fashion, and on finding no pending
connection request, it blocks until a new request gets enqueued. A successful return from Accept
establishes a connection between the client and the server. The Socket instance returned by the
method represents a client connection. The endpoint information of the client is available through
the RemoteEndPoint property.
Two types of Socket exist on the server side; the first one is the listening socket, and the other is
the client socket. The purpose of the listening socket is to honor the client connection request; it
doesn’t support any type of data exchange activity. The Socket returned by the Accept method repre-
sents the client socket, and data exchange is performed on this socket.
After the connection is established successfully, market data is serialized into raw bytes, and using
Send it is dispatched to the MDC client:
byte[] sendBuffer = new byte[512];
sendBuffer = Encoding.ASCII.GetBytes(mktPrice);
mdcSocket.Send(sendBuffer);
The TCP connection established between the client and server is full-duplex in nature. This
means data is allowed to flow from both directions of the connection. TCP provides a feature that
allows one end of the connection to disable its sending or receiving activity. For example, if a market
data consumer client is never going to send data and its only intention is to receive data, then it may
very well block the sending end of the connection. You can apply the same technique to the market
data producer server; if it is never going to receive data, then it can block the receiving end of the
connection. This feature is called TCP half-close, and you use Shutdown to implement it:
mdcSocket.Shutdown(SocketShutdown.Both);
Shutdown also takes care of any pending data that needs to be delivered or received and ensures
data on the connected Socket is flushed out before closing it down. The argument supplied to
Shutdown is one of these enumerated values of SocketShutdown:
SocketShutdown.Receive: Disables the receiving end of the Socket
SocketShutdown.Send: Disables the sending end of the Socket
SocketShutdown.Both: Disables both the sending and receiving ends of the Socket
Finally, the TCP connection is closed, and the underlying memory used by Socket is released:
mdcSocket.Close();
With the code example illustrated in Listing 4-4, you have completed the TCP version of the
market data producer service. The next step is to implement the TCP version of the market data
consumer service (see Listing 4-5).
Listing 4-5. Market Data Consumer (Using TCP)
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace TCPMDC
{
class MDC
{
[STAThread]
static void Main(string[] args)
{C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 195
Figure 4-10. MDP (TCP) console output
Figure 4-11. MDC (TCP) console output
Console.WriteLine("Market-Data Consumer Service Started - Using TCP");
IPEndPoint mdpEP = new IPEndPoint(IPAddress.Loopback,20000);
Socket mdcSocket = new
Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
//Establishes connection with market data server
mdcSocket.Connect(mdpEP);
byte[] receiveBuffer = new byte[512];
//Receive market data
int bytesReceived = mdcSocket.Receive(receiveBuffer);
string mktPrice = Encoding.ASCII.GetString(receiveBuffer,0,bytesReceived);
Console.WriteLine(mktPrice);
//Close connection
mdcSocket.Shutdown(SocketShutdown.Both);
mdcSocket.Close();
Console.ReadLine();
}
}
}
In Listing 4-5, the code works by first identifying the server endpoint information, which is
then fed to the Connect method that synchronously establishes a connection with the remote server.
After you are connected, the server immediately sends the data. The data is received and converted
into a readable format before being displayed on the console. After displaying the data, the connec-
tion is closed, and the underlying memory allocated is released. Figure 4-10 and Figure 4-11 show
the console output of both the market data producer and the consumer service.
Asynchronous Market Data Producer and Consumer
Socket supports both blocking and nonblocking operations. In blocking mode, the operation being
conducted on the socket (such as reading data, writing data, or connecting to the host) gets blocked
indefinitely until the requested operation completes successfully. For example, a read issued on a con-
nected socket that contains pending data will return immediately; however, if there is no data, then
the read operation is blocked until the arrival of new data. You noticed similar blocking behavior while
accepting the client connection; the Accept method blocks until a new connection is established.196C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
To build a scalable application, it is essential to adopt a concurrent programming path. By
adopting this path, you break a coarse-grained task into individual subtasks and offload processing
of these subtasks to a separate thread. If you implemented this during the design of networked
applications, then most of the operations, such as sending data to the client or accepting a client
connection, are forked on a separate thread.
To provide such multithreaded behavior, Socket provides both a synchronous and an asynchronous
version of the common operation performed on it. This common operation includes connecting to
the remote host, accepting the connection from the client, and sending or receiving the data. We
have already demonstrated the synchronous version of the market data producer and consumer. In
Listing 4-6, we show how to implement an asynchronous version of these services and perform most
of the time-consuming operations on a separate thread.
Listing 4-6. Asynchronous Market Data Producer (Using TCP)
using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace AsyncTCPMDP
{
public class AsyncStateInfo
{
public Socket socket;
public byte[] dataBuffer = new byte[512];
public AsyncStateInfo(Socket sock)
{
socket=sock;
}
}
class MDP
{
[STAThread]
static void Main(string[] args)
{
ManualResetEvent shutDownSignal = new ManualResetEvent(false);
IPEndPoint localEP = new IPEndPoint(IPAddress.Loopback,20000);
Console.WriteLine("Market-Data Producer Service Started –
Using TCP (Async Model)");
Console.WriteLine("Main Thread : " +Thread.CurrentThread.GetHashCode());
Socket mdpSocket = new
Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
mdpSocket.Bind(localEP);
mdpSocket.Listen(10);
//Starts listening to client connection in an asynchronous mode
mdpSocket.BeginAccept(new AsyncCallback(AcceptConnection),
new AsyncStateInfo(mdpSocket));
shutDownSignal.WaitOne();
}
//Method invoked to accept an incoming connection attempt
public static void AcceptConnection(IAsyncResult result)
{C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 197
Console.WriteLine("Connection Request Thread : "
+Thread.CurrentThread.GetHashCode());
AsyncStateInfo stateInfo = result.AsyncState as AsyncStateInfo;
//Accepts client connection
Socket mdcSocket = stateInfo.socket.EndAccept(result);
//Starts listening to client connection
stateInfo.socket.BeginAccept(new AsyncCallback(AcceptConnection),
new AsyncStateInfo(stateInfo.socket));
AsyncStateInfo mdcStateInfo = new AsyncStateInfo(mdcSocket);
string mktPrice = "MSFT;25,IBM;24";
stateInfo.dataBuffer = Encoding.ASCII.GetBytes(mktPrice);
//Sends data asynchronously
mdcSocket.BeginSend(mdcStateInfo.dataBuffer,0,512,SocketFlags.None,
new AsyncCallback(SendData),mdcStateInfo);
}
public static void SendData(IAsyncResult result)
{
Console.WriteLine("Data Sending Thread : "
+Thread.CurrentThread.GetHashCode());
AsyncStateInfo stateInfo = result.AsyncState as AsyncStateInfo;
//Completes asynchronous send
stateInfo.socket.EndSend(result);
}
}
}
The code described in Listing 4-6 is a rehash of the TCP version of the market data producer
service but uses asynchronous methods of Socket. Asynchronous methods, as explained in Chapter 2,
are paired methods. The execution of the method starts with a call to BeginXXX and ends with a call
to the EndXXX method. The logic implemented here is similar to the synchronous version of the mar-
ket data producer with the only difference being that tasks such as accepting the client connection
and sending data to the client are separated in AcceptConnection and the SendData method.
In Listing 4-6, BeginAccept asynchronously notifies the client connection request, the notification
happens on a separate thread, and the registered callback method is invoked. The registered callback
method is represented by an instance of the AsyncCallback delegate. This delegate expects a method
argument to be passed that is later referenced inside the callback method. The argument passed in
this case is an instance of AsyncStateInfo that encapsulates the listening socket instance:
mdpSocket.BeginAccept(new AsyncCallback(AcceptConnection),
new AsyncStateInfo(mdpSocket));
}
AcceptConnection completes the connection request received from the client by invoking the
EndAccept method. EndAccept returns a new Socket that is then used to send data to the client. Notice
that you again trigger a call to the BeginAccept method to process the remaining connection request.
After accepting the connection, the data is asynchronously sent using the BeginSend method:
public static void AcceptConnection(IAsyncResult result)
{
Console.WriteLine("Connection Request Thread : "
+Thread.CurrentThread.GetHashCode());
AsyncStateInfo stateInfo = result.AsyncState as AsyncStateInfo;
Socket mdcSocket = stateInfo.socket.EndAccept(result);
stateInfo.socket.BeginAccept(new AsyncCallback(AcceptConnection),
new AsyncStateInfo(stateInfo.socket));198C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
AsyncStateInfo mdcStateInfo = new AsyncStateInfo(mdcSocket);
string mktPrice = "MSFT;25,IBM;24";
stateInfo.dataBuffer = Encoding.ASCII.GetBytes(mktPrice);
mdcSocket.BeginSend(mdcStateInfo.dataBuffer,0,512,SocketFlags.None,
new AsyncCallback(SendData),mdcStateInfo);
Finally, SendData completes the asynchronous send operation by invoking EndSend:
public static void SendData(IAsyncResult result)
{
Console.WriteLine("Data Sending Thread : "
+Thread.CurrentThread.GetHashCode());
AsyncStateInfo stateInfo = result.AsyncState as AsyncStateInfo;
stateInfo.socket.EndSend(result);
}
The next step is to demonstrate the market data consumer end, which connects to the market
data producer and receives data in an asynchronous manner. Listing 4-7 represents the asynchronous
version of the market data consumer service.
Listing 4-7. Asynchronous Market Data Consumer (Using TCP)
using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace AsyncTCPMDC
{
public class AsyncStateInfo
{
public Socket socket;
public byte[] dataBuffer = new byte[512];
public AsyncStateInfo(Socket sock)
{
socket=sock;
}
}
class MDC
{
[STAThread]
static void Main(string[] args)
{
Console.WriteLine("Market-Data Consumer Service Started -
Using TCP(Async Model)");
Console.WriteLine("Main Thread : " +Thread.CurrentThread.GetHashCode());
IPEndPoint mdpEP = new IPEndPoint(IPAddress.Loopback,20000);
Socket mdcSocket = new
Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
AsyncStateInfo stateInfo = new AsyncStateInfo(mdcSocket);
//Begins an asynchronous connection request
mdcSocket.BeginConnect(mdpEP,new AsyncCallback(MDCConnected),stateInfo);
Console.ReadLine();C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 199
if ( mdcSocket.Connected == true )
{
mdcSocket.Shutdown(SocketShutdown.Both);
mdcSocket.Close();
}
}
//Callback method invoked as a result of asynchronous data receive request
public static void ReceiveData(IAsyncResult result)
{
Console.WriteLine("Receiving Thread : "
+Thread.CurrentThread.GetHashCode());
AsyncStateInfo stateInfo = result.AsyncState as AsyncStateInfo;
Socket mdcSocket = stateInfo.socket;
//Successfully accepts data
int bytesReceived = mdcSocket.EndReceive(result);
if ( bytesReceived > 0 )
{
string mktPrice =
Encoding.ASCII.GetString(stateInfo.dataBuffer,0,bytesReceived);
Console.WriteLine(mktPrice);
//Begins async. operation to receive more data sent by server
mdcSocket.BeginReceive(stateInfo.dataBuffer,0,512,SocketFlags.None,
new AsyncCallback(ReceiveData),stateInfo);
}
}
//Callback method invoked as a result of asynchronous connection request
public static void MDCConnected(IAsyncResult result)
{
Console.WriteLine("Connecting Thread : "
+Thread.CurrentThread.GetHashCode());
AsyncStateInfo stateInfo = result.AsyncState as AsyncStateInfo;
Socket mdcSocket = stateInfo.socket;
//Successfully connects to market data server
mdcSocket.EndConnect(result);
//Begins asynchronous data receive operation
mdcSocket.BeginReceive(stateInfo.dataBuffer,0,512,SocketFlags.None,
new AsyncCallback(ReceiveData),stateInfo);
}
}
}
In Listing 4-7, the connection request to the market data producer service is spawned on a sep-
arate thread that is achieved by BeginConnect. The connection to the remote host is successfully
established with EndConnect. After connecting, the next step is to receive the data published by the
server, and this task is again processed asynchronously with BeginReceive:
public static void MDCConnected(IAsyncResult result)
{
Console.WriteLine("Connecting Thread : "
+Thread.CurrentThread.GetHashCode());
AsyncStateInfo stateInfo = result.AsyncState as AsyncStateInfo;
Socket mdcSocket = stateInfo.socket;
mdcSocket.EndConnect(result);
mdcSocket.BeginReceive(stateInfo.dataBuffer,0,512,SocketFlags.None,
new AsyncCallback(ReceiveData),stateInfo);
}200C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
Figure 4-12. MDP (Async-TCP) console output
Figure 4-13. MDC (Async-TCP) console output
In the following code, ReceiveData is triggered by BeginReceive, which gives the ability to
receive data on a separate thread. The actual data is received only after a call to EndReceive.
EndReceive returns the total number bytes read, and this value determines any pending data that
needs to be read.
public static void ReceiveData(IAsyncResult result)
{
Console.WriteLine("Receiving Thread : "
+Thread.CurrentThread.GetHashCode());
AsyncStateInfo stateInfo = result.AsyncState as AsyncStateInfo;
Socket mdcSocket = stateInfo.socket;
int bytesReceived = mdcSocket.EndReceive(result);
if ( bytesReceived > 0 )
{
string mktPrice =
Encoding.ASCII.GetString(stateInfo.dataBuffer,0,bytesReceived);
Console.WriteLine(mktPrice);
mdcSocket.BeginReceive(stateInfo.dataBuffer,0,512,SocketFlags.None,
new AsyncCallback(ReceiveData),stateInfo);
}
}
Figure 4-12 and Figure 4-13 show the console output of the market data producer and the con-
sumer service.C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 201
Figure 4-14. Byte ordering
Network Byte Order
The standardization of data has always been a focal issue in achieving interoperability between
machines where the underlying hardware architecture or operating system is different from each
other. A common problem encountered in a network application is the arrangement of the bits of
multibyte numbers such as the short, integer, or long data types. The interpretation and packaging
of multibyte numbers are different for different types of CPU architecture. Intel-based machines are
known as little-endian machines where the least significant byte (LSB) is stored at a lower memory
address. This is in contrast to Motorola-based machines where the most significant byte (MSB) is
stored at a lower memory address. For instance, data triggered from Intel-based machines will be
interpreted differently when received by a Motorola machine. Figure 4-14 illustrates this problem
where the short value 99 defined by little-endian machines is interpreted wrongly by big-endian
machines.
To address this inconsistency, a common network representation format is defined that makes
no assumptions and ensures the portability of data across different CPU architectures. This format
is the same as big-endian. Therefore, both little-endian and big-endian machines, before sending
data, convert it to a network representation format. This kind of data portability is required only when
the applications communicating with each other use a different CPU architecture. But if they are built
on a similar architecture, then there is no need for any intermediate conversion step, and the data is
directly exchanged.
To convert a multibyte value from host byte order to network byte order, we will use the
NetworkToHostOrder defined in the IPAddress class in the following code. Similarly, HostToNetworkOrder
converts from network byte order to host byte order. Both HostToNetworkOrder and NetworkToHostOrder
are overloaded methods, and both take a multibyte value and convert it to an appropriate format.
using System;
using System.Net;
namespace NetworkByteOrder
{
class NBO
{
[STAThread]
static void Main(string[] args)202C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
{
short quantity = 99;
short networkOrder = IPAddress.NetworkToHostOrder(quantity);
Console.WriteLine("Quantity Converted to Network Byte Order :"
+networkOrder);
short hostOrder = IPAddress.HostToNetworkOrder(networkOrder);
Console.WriteLine("Quantity Converted to Host Byte Order :" +hostOrder );
}
}
}
The output in Figure 4-15 shows a multibyte value converted from a host format to a network
format, and vice versa.
Figure 4-15. Network byte order console output
Message Framing
The earlier code example highlighted the modus operandi of UDP- and TCP-based applications. The
data transmitted on the network is first serialized into a byte array of a fixed size. The receiving appli-
cation knows this fixed size and accordingly allocates a buffer before receiving the data. However, in
a real-world application, there are different types of application data, and you cannot expect their
data lengths to be the same. Also, both UDP and TCP exhibit a different behavior when it comes to
the data transmission stage.
When data is handed over to TCP using Socket.Send, it is first copied into TCP internal data
structures, and the control is immediately returned to the caller. In reality, TCP never immediately
sends data over the wire; it first buffers the data, so it is likely that a multiple call to Socket.Send will
batch the data, and TCP will then transmit this accumulated data in a single TCP segment. The side
effect of such optimization is that the receiving application now needs to apply enough intelligence
to dissect the correct message. On the other hand, UDP is pretty straightforward, and data dispatched
using Socket.Send is considered to be a unique UDP segment and is immediately transmitted over
the wire.
As you saw earlier, Socket uses a sequence of bytes when it comes to sending or receiving data.
But in reality applications work at a higher abstraction layer and are represented in the form of strongly
typed objects. So you need to serialize the actual data that is encapsulated inside a strongly typed
object into raw bytes before sending it over a network. The reverse process is applied on the receiv-
ing end where a strongly typed object is re-created from the bytes of an array. This process is known
as the serialization and deserialization of objects, as discussed in Chapter 3.
The .NET Framework already provides a binary formatter that serializes the entire object graph
into raw byte form. The truth of the matter is sometimes the performance of network applications
occupies center stage, and during that period you need to wet your hands with various otherC H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 203
alternative message encoding and decoding techniques and select the best that fits your requirement.
To demonstrate this alternative solution, we will show how to implement a real-world scenario where
market data is encapsulated inside a strongly typed class, as shown in the following code. The data
will then be translated into raw bytes and transmitted over a network. Here comes the real complexity;
on the receiving end, in order to translate a sequence of bytes into strongly object types, you need
to preserve the message boundary (see Listing 4-8).
Listing 4-8. Application Message Header
using System;
using System.Runtime.InteropServices;
namespace Parsing
{
public enum MessageHeaderType
{
MarketData,
OrderData,
TradeData
}
[StructLayout(LayoutKind.Sequential,Pack=1,CharSet=CharSet.Ansi)]
public class MessageHeader
{
public int MessageLength;
[MarshalAs(UnmanagedType.I4)]
public MessageHeaderType MessageType;
public MessageHeader()
{
}
}
}
In Listing 4-8, MessageHeader wraps the application-related message, and it contains padding
information (mainly the length of the message and the type of message). The intent of padding will
be revealed shortly. In the next section of code, you declare the market data class, which inherits from
MessageHeader and assigns a proper value to MessageType, as shown in Listing 4-9.
Listing 4-9. Market Data (Stock Price) Class
using System;
using System.Runtime.InteropServices;
namespace Parsing
{
[StructLayout(LayoutKind.Sequential,Pack=1,CharSet=CharSet.Ansi)]
public class MarketDataInfo : MessageHeader
{
[MarshalAs(UnmanagedType.ByValTStr,SizeConst=20)]
public string InstrumentName;
public double BidPrice;
public double AskPrice;204C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
public MarketDataInfo()
{}
public MarketDataInfo(string instrumentName,double bidPrice,double askPrice)
{
this.MessageType = MessageHeaderType.MarketData;
InstrumentName = instrumentName;
BidPrice = bidPrice;
AskPrice = askPrice;
}
}
}
By looking at the code described in Listing 4-9, you must have figured out the parsing approach
we will implement. We will be using the P/Invoke service provided by the CLR. P/Invoke itself is a vast
subject, and covering every aspect of it is beyond the scope of this book. In a nutshell, P/Invoke is
a mediator between managed and unmanaged code. It takes into account the difference between
managed and unmanaged code and allows managed code to directly invoke functionality provided
by unmanaged code. It is obvious that interoperating two different environments is not an easy task,
and it is primarily the managed environment where you play by the rules defined by the CLR.
If you glance at MarketDataInfo, you will notice that the class and some of the fields are annotated
with interop attributes. These interop attributes are defined in System.Runtime.InteropServices,
and basically they provide hints to the P/Invoke service about how to marshal the managed object
in an unmanaged environment.
In a managed world, the field layout of a managed object is not fixed; instead, it is dynamically
rearranged by the runtime. By annotating StructLayout attributes, you instruct the runtime to not
rearrange the field order. Moreover, you can also change the individual field marshaling behavior by
annotating them with the MarshalAs attribute. For example, if you look at MessageHeader, described
in Listing 4-8, the MessageType field is annotated with interop attributes that instruct the runtime to
marshal them as an integer type because in an unmanaged world there is no concept of enumerated
types.
The program shown in Listing 4-10 is a generic parser that translates a strongly typed object
into an array of bytes, and vice versa. It also implements a common logic for handling the message
boundary for all types of objects.
Listing 4-10. Message Framing
using System;
using System.Runtime.InteropServices;
using System.IO;
namespace Parsing
{
public delegate void MessageParsedHandler(MessageHeader header);
public class MessageParser
{
public event MessageParsedHandler MessageParsed;
bool newMsg=true;
int remainingByte;
MemoryStream memStream = new MemoryStream();
int msgLength;
//Message parsing notification
private void OnMessageParsed(MessageHeader msgHeader)
{C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 205
if ( MessageParsed != null )
MessageParsed(msgHeader);
}
//Serializes message into array of bytes
public byte[] Serialize(MessageHeader obj)
{
//Calculate size of object
int objectSize = Marshal.SizeOf(obj);
obj.MessageLength = objectSize;
//Serialize message into array of bytes
IntPtr memBuffer = Marshal.AllocHGlobal(objectSize);
Marshal.StructureToPtr(obj,memBuffer,false);
byte[] byteArray = new byte[objectSize];
Marshal.Copy(memBuffer,byteArray,0,objectSize);
Marshal.FreeHGlobal(memBuffer);
return byteArray;
}
//Convert array of bytes into a managed type
private void ConvertToObject(byte[] msgBytes)
{
//Extract the message type by reading from 4th position of byte array
//i.e MessageType field of MessageHeader.
int msgType = BitConverter.ToInt32(msgBytes,4);
Type objType = null;
//Based on the message type determine the underlying type
if ( msgType == (int) MessageHeaderType.MarketData)
{
objType = typeof(MarketDataInfo);
}
//Calculate the object size
int objectSize = Marshal.SizeOf(objType);
//Convert byte array into object
IntPtr memBuffer = Marshal.AllocHGlobal(objectSize);
Marshal.Copy(msgBytes,0,memBuffer,objectSize);
object obj = Marshal.PtrToStructure(memBuffer,objType);
Marshal.FreeHGlobal(memBuffer);
//Invoke the event to notify parsing of new message
//pass the concrete object instance
OnMessageParsed(obj);
}
public void DeSerialize(byte[] msgBytes)
{
AlignMessageBoundary(msgBytes,0);
}
//Code inside this method determines the correct message boundary
public void AlignMessageBoundary(byte[] recvByte,int offSet)
{
if ( offSet >= recvByte.Length ) return ;
//The logic has been branched for two types of scenarios
//first scenario is when framing of message is performed for a new message
//second scenario applies to messages received on a installment basis206C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
if ( newMsg == true )
{
//Get the length of message
msgLength = BitConverter.ToInt32(recvByte,offSet);
//Determine the message type
int msgType = BitConverter.ToInt32(recvByte,offSet + 4);
//If the length of byte array + offset is less than message length,
//then it indicates a partial message, and there are still
//remaining bytes pending to be read.
if ( msgLength > ( recvByte.Length - offSet ) + 1 )
{
newMsg=false;
remainingByte = msgLength - recvByte.Length;
memStream = new MemoryStream();
memStream.Write(recvByte,offSet,recvByte.Length);
}
else
{
//completes reading all pending bytes and converts
//it into concrete object
byte[] bytes = new byte[msgLength];
Array.Copy(recvByte,offSet,bytes,0,msgLength );
MessageHeader obj = this.ConvertToObject(bytes) as MessageHeader;
this.OnMessageParsed(obj);
//Recursive call
AlignMessageBoundary(recvByte,offSet + msgLength);
}
}
else
{
if ( remainingByte > recvByte.Length )
{
memStream.Write(recvByte,0,recvByte.Length);
remainingByte = remainingByte - recvByte.Length;
}
else
{
memStream.Write(recvByte,offSet,remainingByte);
byte[] bytes = new byte[msgLength];
memStream.Seek(0,SeekOrigin.Begin);
memStream.Read(bytes,0,msgLength);
memStream.Close();
MessageHeader obj = this.ConvertToObject(bytes) as MessageHeader;
this.OnMessageParsed(obj);
newMsg=true;
AlignMessageBoundary(recvByte,offSet + remainingByte + 1);
}
}
}
}
}
The parser program, along with the serialization and deserialization functionality, also looks
after the message boundary issue. The serialization code returns an array of bytes, but the deserial-
ization code never directly returns the object to the caller; instead, it notifies the caller by raising an
event. Let’s first get started with the serialization code:C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 207
public byte[] Serialize(MessageHeader obj)
{
int objectSize = Marshal.SizeOf(obj);
obj.MessageLength = objectSize;
IntPtr memBuffer = Marshal.AllocHGlobal(objectSize);
Serialize accepts an instance of MessageHeader that is then passed to Marshal.SizeOf. This
method computes the unmanaged size of a managed object. The size returned is then assigned to
MessageLength. The size also determines the memory required in unmanaged memory of the process
and is allocated by Marshal.AllocHGlobal. On successfully allocating memory, it returns a memory
pointer that is represented by IntPtr.
Next, Marshal.StructureToPtr flattens the data of the managed object into a continuous stream
of bytes and copies them into an allocated block of unmanaged memory. On successfully copying,
you invoke Marshal.Copy, which performs a reverse operation of copying data from unmanaged
memory to byte array.
Marshal.StructureToPtr(obj,memBuffer,false);
byte[] byteArray = new byte[objectSize];
Marshal.Copy(memBuffer,byteArray,0,objectSize);
Since you interacted with the unmanaged world where there is no concept of automatic garbage
collection to reclaim the memory, it is important to release all resources that were allocated using
AllocHGlobal and this is accomplished by Marshal.FreeHGlobal:
Marshal.FreeHGlobal(memBuffer);
Now comes the important part of the code where the actual message deserialization happens
inside ConvertToObject, and it works by first examining the message type:
private object ConvertToObject(byte[] msgBytes)
{
int msgType = BitConverter.ToInt32(msgBytes,4);
Type objType = null;
if ( msgType == (int) MessageHeaderType.MarketData)
{
objType = typeof(MarketDataInfo);
}
You already know that when an instance of MarketDataInfo is serialized, its field layout will not
be reorganized, and the defined order will be maintained. So, you can safely assume the position of
the field in a byte array based on its underlying data type and offset. By applying this pattern, you can
retrieve the message type from the byte array because you know it is the first field in MarketDataInfo,
and being an integer data type, its storage capacity will be exactly 4 bytes. Similarly, you can also retrieve
the message length, which is the next field, and its data type is also an integer. This means the offset
of the message length in a byte array will start from the fourth position; using this technique, you can
traverse the byte array and retrieve the values of all the fields. BitConverter comes in handy in this
scenario; it facilitates the easy conversion from a byte array to the appropriate value type.
Based on the message type, you computed the actual unmanaged size of a managed object. This
size is then supplied to AllocHGlobal, which finally allocates memory in unmanaged memory of the
process. The byte array received as a method argument is then copied into the unmanaged block of
memory.
int objectSize = Marshal.SizeOf(objType);
IntPtr memBuffer = Marshal.AllocHGlobal(objectSize);
Marshal.Copy(msgBytes,0,memBuffer,objectSize);208C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
The following is the important piece of code in which the byte array from the unmanaged sec-
tion of memory is marshaled and resurrected to a concrete managed object. After casting the object
to MessageHeader, it is appropriately notified to the caller by raising the event.
MessageHeader obj = Marshal.PtrToStructure(memBuffer,objType) as MessageHeader;
Marshal.FreeHGlobal(memBuffer);
if ( MessageParsed != null )
MessageParsed(obj);
DeSerialize is the method exposed to outside world; this method call is then routed to
AlignMessageBoundary, which properly frames the message before invoking ConvertToObject:
public void DeSerialize(byte[] msgBytes)
{
AlignMessageBoundary(msgBytes,0);
}
The following code is the last leg of the example; it conducts different types of tests that start
with a simple message and then simulates a multiple-message scenario nested in a large byte array:
using System;
using System.Runtime.InteropServices;
namespace Parsing
{
class ParsingExample
{
[STAThread]
static void Main(string[] args)
{
//Instantiate new instance of Message parser
//and also subscribe to its message parsing event
MessageParser msgParser = new MessageParser();
msgParser.MessageParsed +=new MessageParsedHandler(msgParser_MessageParsed);
MarketDataInfo msftData = new MarketDataInfo("MSFT",21.5,22.5);
MarketDataInfo ibmData = new MarketDataInfo("IBM",23.5,24.5);
MarketDataInfo geData = new MarketDataInfo("GE",25.5,26.5);
//Single Message Scenario
Console.WriteLine("Single Message Scenario");
byte[] buffer = msgParser.Serialize(msftData);
msgParser.DeSerialize(buffer);
//Large Buffer Scenario
Console.WriteLine("Large Buffer Scenario");
int typeSize = Marshal.SizeOf(typeof(MarketDataInfo));
byte[] largeBuffer = new byte[typeSize*3];
byte[] ibmBuffer = msgParser.Serialize(ibmData);
byte[] geBuffer = msgParser.Serialize(geData);
Array.Copy(buffer,0,largeBuffer,0,typeSize);
Array.Copy(ibmBuffer,0,largeBuffer,buffer.Length,typeSize);
Array.Copy(geBuffer,0,largeBuffer,buffer.Length +
ibmBuffer.Length,typeSize);
msgParser.DeSerialize(largeBuffer);C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 209
Figure 4-16. Parsing console output
//Small Buffer Scenario
Console.WriteLine("Small Buffer Scenario");
byte[] smallBuffer1= new byte[22];
byte[] smallBuffer2= new byte[22];
Array.Copy(buffer,0,smallBuffer1,0,22);
Array.Copy(buffer,22,smallBuffer2,0,22);
msgParser.DeSerialize(smallBuffer1);
msgParser.DeSerialize(smallBuffer2);
}
private static void msgParser_MessageParsed(MessageHeader header)
{
MarketDataInfo dataInfo = header as MarketDataInfo;
Console.WriteLine("{0} {1}
{2}",dataInfo.InstrumentName,dataInfo.BidPrice,dataInfo.AskPrice);
}
}
}
The code also demonstrates a small buffer case, and the parser is able to intelligently parse the
data. Figure 4-16 shows the parsing console output.
Broadcast
The examples demonstrated so far were based on a unicast communication model (see Figure 4-17).
In this model, the market data producer (the server) sent data to the individual market data consumer
(the client). In UDP, the market data server needs to constantly update its recipient list. However, in
the TCP world, the market data consumer explicitly initiates a connection with the server and gets the
required data. Regardless of which route you follow, the market data server always needs to know its
consumers (clients).210C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
Such one-to-one communication scales poorly, particularly when the number of clients inter-
acting with the server is huge. Consider for a moment you were given a design specification of a market
data service that should be capable of handling at least 1,000 clients. To implement this system, no
doubt you will require the backing of state-of-the-art hardware infrastructure, but one thing you
will definitely fall short on is network bandwidth. Network bandwidth in a local area network may
not look like a major problem; it is only when communication is spawned on limited-capacity
bandwidth that serving 1,000 clients is a different beast.
The server will be sending market data information to individual clients, and if you estimate the
size of market data to be around 1KB, then a total of 1MB (1,000 clients * 1KB) of data will be floated
on the network at any given point of time. If you extrapolate this equation specifically during peak
trading hours when stocks price are highly volatile, then the underlying network bandwidth will not
be able to cope with the amount of data produced by the market data service. This problem gets reflected
on the consumer end in the form of a market data latency issue. Fortunately, you have a way to resolve
this problem, and it is to implement the network broadcast feature.
Using a broadcast, a single copy of data is floated on the network, and this data is sent to all hosts
in a network. The immediate benefit reaped here is the optimum utilization of bandwidth; regardless
of the number of hosts in a network, data is transferred only once. The underlying network provides
two types of broadcasts: unsolicited and solicited. The underlying implementation of both these
broadcasts depends upon UDP, and this is where UDP wins over TCP.
Unsolicited Broadcast
Unsolicited broadcast is also known as local broadcast because of its limitation to broadcast data
only within the subnet of a network (see Figure 4-18). This restriction is inherent to a network where
data is never forwarded to another subnet by network routers. A local broadcast is quite useful when
both the server and client are located on the same subnet and the nature of information published
is the same across all clients.
The broadcast address 255.255.255.255 is a special-purpose address, and the network packet
directed toward this IP address is delivered to every host on the specified subnet of the host. From
a coding perspective, implementing a broadcast is a trivial task because under the hood it uses UDP
to deliver the data. So, the next task is to reimplement the market data solution; unlike in the earlier
code example where the server maintained a list of every clients’ endpoint information it intended
to send data to, in this version the server directly broadcasts data on the broadcast address, and the
consumer has to simply listen to this broadcast message.
Figure 4-17. Unicast communication modelC H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 211
Figure 4-18. Unsolicited broadcast
The server and client code shown in Listing 4-11 and Listing 4-12 requires the host to be
connected in a network, because the broadcast is a feature supported by the underlying network.
Listing 4-11. Unsolicited Broadcast of Market Data
using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
namespace UnSolicitedBcastServer
{
class MDP
{
[STAThread]
static void Main(string[] args)
{
Console.WriteLine("Market-Data Producer Service Started -
(Unsolicited Broadcast)");
string mktPrice = "MSFT;25,IBM;24";
Socket mdpSocket = new
Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
//Broadcast IP address
IPEndPoint bcastEndPoint = new IPEndPoint(IPAddress.Broadcast,30001);
//Set socket in broadcast mode
mdpSocket.SetSocketOption(
SocketOptionLevel.Socket,SocketOptionName.Broadcast, 1);
byte[] sendBuffer = new byte[512];
sendBuffer = Encoding.ASCII.GetBytes(mktPrice);
mdpSocket.SendTo(sendBuffer,bcastEndPoint);
mdpSocket.Close();
Console.WriteLine("Market Data Broadcasted");
Console.ReadLine();
}
}
}212C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
In Listing 4-11, the code introduces two important changes. The first visible change is that a list
of recipient endpoint information is missing; it is replaced by a broadcast address. This broadcast
address is readily made available by IPAddress.Broadcast, and the port number assigned is 30001.
The next important line of code is SetSocketOption. This method turns on or off some very low-
level options of network protocols that are not directly exposed in the form of a property or method.
We discuss the possible options supported by this method later in the “Protocol Tweaking” section.
Currently, using SetSocketOption, we have enabled the broadcast support that is by default disabled
on the socket. After applying this change, the rest of the code looks familiar and requires no further
explanation.
The next step is to build the market data consumer that consumes market data published on
the broadcast address. The code shown in Listing 4-12 achieves this.
Listing 4-12. Client Receiving Broadcast Message
using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
namespace UnSolicitedBcastClient
{
class MDC
{
[STAThread]
static void Main(string[] args)
{
Console.WriteLine("Market-Data Consumer Service Started -
(Unsolicited Broadcast)");
byte[] receiveBuffer = new byte[512];
IPHostEntry hostEntry = Dns.GetHostByName(Dns.GetHostName());
EndPoint bindInfo = new IPEndPoint(hostEntry.AddressList[0],30001);
Socket mdcSocket = new
Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
mdcSocket.Bind(bindInfo);
EndPoint endPoint = new IPEndPoint(IPAddress.Any,0);
int bytesReceived = mdcSocket.ReceiveFrom(receiveBuffer,ref endPoint);
IPEndPoint mdpEndPoint = (IPEndPoint)endPoint;
string mktPrice = Encoding.ASCII.GetString(receiveBuffer,0,bytesReceived);
Console.WriteLine("Market-Data Received : " +mktPrice);
Console.WriteLine("Market Data Producer IP Address {0} Port {1} "
,mdpEndPoint.Address.ToString(), mdpEndPoint.Port);
Console.ReadLine();
mdcSocket.Close();
}
}
}
There is hardly any difference in the code described in Listing 4-12 compared to the UDP uni-
cast version of this code (see Listing 4-3). The only point to keep in mind is that the local endpoint
on which the bind is performed belongs to the same subnet of server. Of course, the port number
needs to be the same, or the client will fail to receive the broadcast message. So now that both the
client and server are in place, let’s compile and run the client before running the server. Figure 4-19
shows the UnsolicitedBCastServer console output, and Figure 4-20 shows the UnsolicitedBCastClient
console output.C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 213
Figure 4-19. UnsolicitedBCastServer console output
Figure 4-20. UnsolicitedBCastClient console output
Figure 4-21. Solicited broadcast
However, the unsolicited broadcast introduces a performance hit on every host within the
subnet. A UDP datagram, when broadcast, is received and processed by all hosts in a subnet. This
additional processing performed by an individual host terminates at the transport layer when it
notices that no application has shown interest in receiving this broadcast message. From a per-
formance viewpoint, you are wasting a few CPU cycles, so you need to find a more elegant solution
where only the interested host receives the broadcast message. This is where solicited broadcast
comes to the rescue.
Solicited Broadcast
Solicited broadcast, popularly known as multicast, allows broadcasts within a group of hosts in
a network (see Figure 4-21). Multiple multicast groups may be formed, and each group is uniquely
identified. Based on this group identification, an individual host in a network joins or leaves the
groups. This is analogous to a publisher-subscriber model where the subscriber needs to register
with the publisher if it wants to be notified of a particular action.214C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
Another advantage of multicast over unsolicited broadcast is that routers recognize multicast
messages, and this allows messages to pass across different networks. On a surface level, this may
look like a major issue because it is easy for a malicious user to bombard the entire network by send-
ing a multicast message. But in reality, this is not how it works; a multicast message that originated
from a particular network is first received by a router. The router forwards this message to the desig-
nated network only if at least one host in that network has explicitly expressed an interest in receiving
this multicast message by joining the multicast group. Routers among themselves use Internet Group
Management Protocol (IGMP) to notify about a host joining or leaving a multicast group. IGMP forms
part of the IP layer and, like ICMP, is encapsulated inside an IP datagram.
Multicast groups are formed by selecting an IP address from a Class D address range. Class D
addresses are from 224.0.0.0 to 239.255.255.255 and are allocated especially for multicast-based
applications. However, a few multicast addresses, particularly the ones in the range from 224.0.0.0
to 224.0.0.255, are unusable. The multicast address acts as a unique group identifier, and any host in
a network can join a multicast group by providing the correct multicast address. This golden rule also
applies to a host located in a different network. Similarly, a host can also drop its membership at any
given time. Such dynamic group membership makes it highly favorable for building applications
where the number of subscribers is not predetermined.
The next task is to implement the same market data example (see Listing 4-13); however, remember
in this version, the market data consumer will be able to receive data only if it joins a multicast group to
which the server broadcasts data.
Listing 4-13. Solicited Broadcast of Market Data
using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
namespace MCastServer
{
class MDP
{
[STAThread]
static void Main(string[] args)
{
Console.WriteLine("Market-Data Producer Service Started -
(Using MultiCast)");
string mktPrice = "MSFT;25,IBM;24";
//IP Multicast address
IPAddress groupAddress =IPAddress.Parse("224.5.6.7");
IPEndPoint mcastEP = new IPEndPoint(groupAddress,30002);
Socket mdpSocket = new
Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
byte[] sendBuffer = new byte[512];
sendBuffer = Encoding.ASCII.GetBytes(mktPrice);
//Set multicast TTL
mdpSocket.SetSocketOption(SocketOptionLevel.IP,
SocketOptionName.MulticastTimeToLive, 3);
//Send data to multicast address
mdpSocket.SendTo(sendBuffer,mcastEP);
mdpSocket.Close();
Console.WriteLine("Market Data sent to group of consumers");
Console.ReadLine();
}
}
}C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 215
The first step in a multicast-based application is to define a multicast group, and in Listing 4-13
you perform this step by identifying 224.5.6.7 as the multicast address. However, in the real world,
this multicast group information must be made available to all interested hosts, and the mechanism
implemented to achieve this may vary. But usually this information is recorded in either a common
configuration file or a database. After defining the multicast address, you create a multicast endpoint
and port number, defined in this case as 30002.
The next line of code is important, especially when multicast data is suppose to span several
routers in a network; the importance of this value has been explained in the “Protocol Tweaking”
section of this chapter:
mdpSocket.SetSocketOption(SocketOptionLevel.IP,
SocketOptionName.MulticastTimeToLive, 3);
Market data is finally sent to multicast groups, and the market data consumers that have joined
this group will receive the data. The code to send this multicast data is as follows:
mdpSocket.SendTo(sendBuffer,mcastEP);
The final step is to build market data consumers that consume market data published on
a multicast address:
using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
namespace MCastClient
{
class MDC
{
[STAThread]
static void Main(string[] args)
{
Console.WriteLine("Market-Data Consumer Service Started -
(Using MultiCast)");
byte[] receiveBuffer = new byte[512];
IPHostEntry entry = Dns.GetHostByName(Dns.GetHostName());
EndPoint localEP = new IPEndPoint(entry.AddressList[0],30002);
Socket mdcSocket = new
Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
mdcSocket.Bind(localEP);
//Start receiving multicast data by subscribing
//to below multicast address
IPAddress groupAddress = IPAddress.Parse("224.5.6.7");
MulticastOption mcastOption = new MulticastOption(groupAddress);
mdcSocket.SetSocketOption(SocketOptionLevel.IP,
SocketOptionName.AddMembership,mcastOption);
EndPoint endPoint = new IPEndPoint(IPAddress.Any,0);
int bytesReceived = mdcSocket.ReceiveFrom(receiveBuffer,ref endPoint);
IPEndPoint mdpEndPoint = (IPEndPoint)endPoint;
string mktPrice = Encoding.ASCII.GetString(receiveBuffer,0,bytesReceived);
Console.WriteLine("Market-Data Received : " +mktPrice);
Console.WriteLine("Market Data Producer IP Address {0} Port {1} "
,mdpEndPoint.Address.ToString(), mdpEndPoint.Port);
mdcSocket.SetSocketOption(SocketOptionLevel.IP,
SocketOptionName.DropMembership,mcastOption);
mdcSocket.Close();
Console.ReadLine();216C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
Figure 4-22. MCastServer console output
Figure 4-23. MCastClient console output
}
}
}
Building a multicast client involves slightly more code than building a multicast server. The
first step is to define the multicast group address, and this address needs to be mutually agreed upon
and known to both the server and the client. In this case, the agreed multicast address is 224.5.6.7.
The multicast address is then wrapped inside MulticastOption. This information is then passed
to SetSocketOption, which announces the host group joining membership. After successful registra-
tion, the host is eligible to receive data published on this multicast group:
MulticastOption mcastOption = new MulticastOption(groupAddress);
mdcSocket.SetSocketOption(SocketOptionLevel.IP,
SocketOptionName.AddMembership,mcastOption);
Similarly, the host can leave a multicast group at any moment of time by invoking the
SetSocketOption method:
mdcSocket.SetSocketOption(SocketOptionLevel.IP,
SocketOptionName.DropMembership,mcastOption);
It is now time to run the multicast server and client. Note that despite the message originating
from the multicast group, the consumer is still able to know the originator of this information; this
is true for both unsolicited and solicited broadcasts. Figure 4-22 shows the MCastServer console output,
and Figure 4-23 shows the MCastClient console output.
Protocol Tweaking
You will always encounter edge cases during application development that require a deep dive into
the low-level details of a protocol. This means understanding and tweaking some of the important
fields of the protocol’s data structure. This is especially true for applications that are sensitive in
nature. Socket allows such mechanisms through SetSocketOption and GetSocketOption. Using these
methods, you can change the behavior of almost all protocols (including IP, TCP, and UDP). This
releases you from knowing the nitty-gritty of the field offset in the protocol structure, the number of
bytes, the possible values supported by field, and so on. However, it is essential to know the implica-
tion of these changes, and that is what we will cover in the next sections where we discuss some of
the important fields and the corresponding impacts on an application’s behavior.C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 217
IP: DontFragment
When the size of any IP datagram exceeds the underlying network MTU, then it undertakes a frag-
mentation process where the datagram is broken into small pieces that fit the network MTU capacity.
Applications using UDP are the victims of such problems because UDP directly forwards the data
received from the application layer to the IP layer. This means if applications pass data of a large buffer
size, then it is surely fragmented by the IP layer. However, such problems are not experienced if the
application is using TCP; remember, TCP creates a segment of a size equal to the MSS before forwarding
it to the IP layer. Using the DontFragment flag, you can instruct the IP layer whether it can fragment
a large datagram.
Here’s the code that disables IP fragmentation:
using System;
using System.Net;
using System.Net.Sockets;
class ProtocolTweaking
{
public void IPFragment(Socket sockInstance)
{
//Disable the Fragmentation
sockInstance.SetSocketOption(SocketOptionLevel.IP,
SocketOptionName.DontFragment,1);
//Get Assigned Fragmentation Value
int isFragmented = (int)
sockInstance.GetSocketOption(SocketOptionLevel.IP,
SocketOptionName.DontFragment);
Console.WriteLine(isFragmented);
}
}
IP: Time to Live (TTL) and Multicast TTL
The IP TTL determines the age of a packet in a network, and the routers on receiving these packets
decrement it by one. This prevents a dead packet from wandering in the network. On the other
hand, the multicast TTL restricts the scope of a multicast packet in a network. For instance, every
multicast-aware router in the network is configured with a TTL limit that determines the reach of
a multicast transmission. Table 4-2 shows the recommended threshold values and their scopes.
Table 4-2. Multicast TTL Scope
Scope Range Description
0 Interface
1–31 Subnet
32–63 Site
64–127 Region
127–255 Continent
So, based on Table 4-2, let’s say if a router is configured with a threshold value of 32, then when it
receives a multicast packet whose MulticastTTL value exceeds the threshold value, then this packet
will be discarded by the routers. Hence, it is important to know the scope of the multicast transmission.
Here’s the code that demonstrates how to configure both multicast and IP TTL:218C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
using System;
using System.Net;
using System.Net.Sockets;
class ProtocolTweaking
{
public void MultiCastTTL(Socket sockInstance)
{
//Subnet Scope
sockInstance.SetSocketOption(SocketOptionLevel.IP,
SocketOptionName.MulticastTimeToLive,3);
}
public void IPTTL(Socket sockInstance)
{
//Set the TTL to 4
sockInstance.SetSocketOption(SocketOptionLevel.IP,
SocketOptionName.IpTimeToLive,4);
int ipTTL= (int)sockInstance.GetSocketOption(SocketOptionLevel.IP,
SocketOptionName.IpTimeToLive);
Console.WriteLine(ipTTL);
}
}
IP: MulticastLoopback
This option comes in handy when both the multicast sender and receiver applications are installed
on the same host and when the receiver wants to loop back the multicast packet sent by the sender.
By default, MulticastLoopback is turned on, and the receiver application can turn it off by executing
the following command:
using System;
using System.Net;
using System.Net.Sockets;
class ProtocolTweaking
{
public void DisableMulticastLoopBack(Socket sockInstance)
{
//disable multicast loopback
sockInstance.SetSocketOption(SocketOptionLevel.IP,
SocketOptionName.MulticastLoopback,0);
}
}
Socket: ReuseAddress
A Socket, before binding (using Socket.Bind) to a particular endpoint, checks whether it is already
being used by an existing instance of Socket. An exception of Socket already in use is thrown if a match
is found. The most fertile source of such a problem is an application going into a hung state because
of which it fails to gracefully clean up the resources. However, the ReuseAddress option allows you to
override this behavior; it permits sockets to bind to an already existing endpoint without throwing
an exception:
using System;
using System.Net;C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 219
using System.Net.Sockets;
class ProtocolTweaking
{
public void ReuseSocket(Socket sockInstance)
{
sockInstance.SetSocketOption(SocketOptionLevel.Socket,
SocketOptionName.ReuseAddress,1);
}
}
Socket: Buffers
Socket maintains two kinds of buffers: a send buffer and a receive buffer. The data before delivering
to the destination host is first stored in the send buffer; similarly, the data received from the sender
is first stored in the receive buffer before it is submitted to the receiving application. The default size
of this buffer is 8KB, but when the application is sending or receiving a large amount of data, then it
is important to increase this buffer size to achieve a better throughput.
Here’s an example that reconfigures the sending and receiving buffer sizes:
using System;
using System.Net;
using System.Net.Sockets;
class ProtocolTweaking
{
public void SetBufferSize(Socket sockInstance,int recvBuffer,int sendBuffer)
{
sockInstance.SetSocketOption(SocketOptionLevel.Socket,
SocketOptionName.SendBuffer,sendBuffer);
sockInstance.SetSocketOption(SocketOptionLevel.Socket,
SocketOptionName.ReceiveBuffer,recvBuffer);
}
}
Socket: Timeout
By default, Socket in blocking mode blocks on a read or write operation. You can override this behavior
by assigning a timeout value with each operation. The timeout value determines the blocking time,
and on timeout expiry, it raises a SocketException.
Here’s an example that assigns a timeout value to the send and receive operations:
using System;
using System.Net;
using System.Net.Sockets;
class ProtocolTweaking
{
public void SetTimeOut(Socket sockInstance,int recvBuffer,int sendBuffer)
{
sockInstance.SetSocketOption(SocketOptionLevel.Socket,
SocketOptionName.SendTimeout,10);
sockInstance.SetSocketOption(SocketOptionLevel.Socket,
SocketOptionName.ReceiveTimeout,10);
}
}220C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
TCP: NoDelay
TCP implements the Nagle algorithm that throttles data before transmission over the wire. Such
low-level optimizations are extremely helpful in a low-bandwidth link where applications exchange
a TCP segment of a small size. With the help of this algorithm, data is held back for a particular time
period before transmitting on the network.
Here’s an example that disables the Nagle algorithm:
using System;
using System.Net;
using System.Net.Sockets;
class ProtocolTweaking
{
public void DisableNagle(Socket sockInstance)
{
sockInstance.SetSocketOption
(SocketOptionLevel.Tcp,SocketOptionName.NoDelay,1);
}
}
Exploring the Business-Technology Mapping
As you know, the primary role of the broadcast engine is to publish the latest price information about
a stock. It also provides ancillary services such as federal announcements, breaking news, and so on.
Such services are provided by market data vendors; they collect data from various exchanges and
provide this consolidated data to organizations. Because of this responsibility, they are often consid-
ered to be the information backbone of an organization, and this creates huge pressure on them to
meet their goal of timely delivery of data. While adhering to this goal, they often face two important
problems:
Data-quake: Data-quake erupts at a particular stage in trading hours where almost all stocks
undergo a price change. This change occurs as a result of some breaking news that directly/
indirectly impacts the economy of a country or the profitability of an organization or a particular
industry segment. But regardless of the source, the amount of data received by the market
data vendor is enormous in comparison to the data received during normal trading hours. The
equities market is in a much less controllable shape during this stage because of the number of
instruments transacted in the market; however, in the derivatives market, particularly the
option instrument, the amount of data received is sufficient to bring down the trading systems.
Network efficiency: It is expected that when the amount of data is huge, then the underlying
network link used to transfer it must be strong enough to cope with the speed at which data is
thrown over the wire. To handle such a massive load, many organizations use state-of-art network
infrastructure between the market data vendor system and the organization’s internal system.
Figure 4-24 represents a high-level overview of producers and consumers of market data infor-
mation. Let’s begin with systems that directly fall under the market data vendor domain. A market
data vendor creates a ticker plant, also known as a market data farm. It is actually from here that the
information is propagated to its premium subscribers. So, you should not be surprised when you
notice two different organizations subscribing to data from the same ticker plant.C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 221
Figure 4-24. Conceptual overview of market data producers and consumers
The market data farm connects to various exchanges and gathers data published by them. This
gathered data is then packaged in a suitable format and delivered to the market data engine. The market
data engine is the actual application that sits at the organization end and receives the data published
by its master. Also, the ticker plant falls outside the organization network periphery because the
network bandwidth available between the market data engine and its corresponding plant is usually
limited in nature.
The market data vendor considers the bandwidth constraint and diverts a major chunk of effort
to fine-tuning the interaction between the worker and master both from a message processing and
a communication perspective. Once the market data engine receives a message, the message is then
made available to internal applications inside the organization. Imagine for a moment what would
happen if individual applications inside an organization started requesting market data directly from
the market data engine. This would directly result in a tight coupling between the market data ven-
dor and the applications. Furthermore, the message format and communication style adopted by
an individual market data vendor is truly proprietary in nature and incompatible with other market
data vendors. (Standards such as Market Data Definition Language [MDDL] are defined by groups
of financial institutions, but they have yet to be fully embraced by the financial community.)
However, in the real word, the story is different. No organization depends upon a single market
data vendor; instead, they spread their risk by subscribing to services of at least two market data
vendors so in case of the nonavailability of data from one vendor, they can fall back on the other.
So how do you stop applications from directly communicating with the market data engine? The
solution to this problem is to introduce another entity market data hub that abstracts away vendor-
specific differences.
The market data hub directly speaks to the vendor market data engine and collects this data,
transforms it to a uniform format, and finally makes this information available to internal applica-
tions. The upside of such an implementation is that applications are completely immune to any new
changes implemented by vendors, and this responsibility shifts to the market data hub to accommo-
date such changes. Another benefit reaped by applications is they can enjoy the data streaming from
multiple vendors with just the flip of a switch. With the market data hub acting as an information
mediator, it is also possible to build sophisticated intelligence by consolidating data from multiple
data vendors, comparing individual stock prices and their arrival times with individual vendor data,
and then publishing the latest price information. In this way, applications can ensure that the price
information received is on par with the price published in the exchange at that particular time.
Now that we have covered both the business and technology topics, it is time to introduce the
solution. Building a broadcast engine generally involves two components; these are the producer
and consumer components. The real complexity lurks at the producer end, so we will not cover the
consumer end, which is relatively easy to build once you understand the design of the producer
component. Figure 4-25 shows the implementation overview.222C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
The components depicted in Figure 4-25 are as follows:
Store: The store is a repository where the actual market data messages are stored. Stores are
created for individual stocks, and the underlying nature of the store is such that it arranges
messages in a FIFO fashion. From an implementation point of view, you can materialize this
store either by using homegrown in-memory queues or by directly leveraging the Microsoft
Messaging Queue (MSMQ) service.
Dispatcher: The dispatcher first ignites the launch of the broadcast event. The dispatcher
retrieves an individual store and submits it to downstream components (the broadcast pipe)
for further processing. The strength of the dispatcher is its scheduling behavior. It schedules
the broadcast event on a defined time interval; this drastically decreases the number of messages
published on the network. The other important characteristic of the dispatcher is the strategy
implemented to dispatch the processing of the store. Processing stores in a round-robin fash-
ion is a simple strategy, but more complex strategies can be implemented, such as processing
stores based on the volatility of the underlying stock. This ensures that messages of highly
volatile stocks are first pushed on the network before all other stocks.
Broadcast pipe: The broadcast pipe is formed by chaining individual discrete components. The
first component in this chain is the rule engine. The rule engine allows subscribers to express
the subscription rule. Based on this rule, the rule engine examines an individual market data
message. If it finds a subscriber that satisfies the rules, then it forwards the message to the seri-
alizer component in the chain. The serializer converts the message to a byte array that is then
passed to the transport. The transport is the final component in the chain, and it transmits data
to its recipients.
In the following sections, we’ll cover the code that more or less illustrates these concepts. The
only component that is not covered is the rule engine.
Class Details
Figure 4-26 shows the broadcast engine class diagram, and Figure 4-27 shows the broadcast engine
project structure.
Figure 4-25. Implementation overviewC H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 223
Figure 4-26. Broadcast engine class diagram
Figure 4-27. Broadcast engine project structure
IBCastMessage
IBCastMessage defines the common behavior implemented by application messages and is required
for broadcast purposes.
Here’s the code:
using System;
namespace BCastServer
{224C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
public interface IBCastMessage
{
//Identifies broadcast message type
//for example market data broadcast, exchange bulletin broadcast
int MessageType{get;}
//Length of Message
int MessageLength{get;set;}
}
}
IMessageStore
The IMessageStore interface defines the common functionality implemented by concrete message
stores. This functionality includes inserting and removing messages, assigning store names, and
finding the run-time state of the store with the help of enumerated values.
Here’s the code:
using System;
namespace BCastServer
{
public enum StoreState
{
Idle,
Busy
}
public interface IMessageStore
{
//Enqueue broadcast message
void EnQueue(IBCastMessage bcastMessage);
//Dequeue broadcast message
IBCastMessage DeQueue();
StoreState State{get;set;}
//Total message in the store
int Count{get;}
//User friendly name of the store
string Name{get;}
}
}
InMemoryStore
InMemoryStore is an in-memory queue that uses System.Collections.Queue to store market data
messages. The store is created by accepting a unique user-friendly name that is easy to recall; addi-
tionally, it is used by the consumer of market data information during the subscriptions stage.
Here’s the code:
using System;
using System.Collections;
namespace BCastServer
{
public class InMemoryStore : IMessageStore
{
Queue msgStore = Queue.Synchronized(new Queue());C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 225
StoreState storeState;
string storeName;
public InMemoryStore(string name)
{
storeName = name;
}
public string Name
{
get{return storeName;}
}
public int Count
{
get{return msgStore.Count;}
}
public void EnQueue(IBCastMessage bcastMessage)
{
msgStore.Enqueue(bcastMessage);
}
public IBCastMessage DeQueue()
{
return msgStore.Dequeue() as IBCastMessage;
}
public StoreState State
{
get{return storeState;}
set{storeState=value;}
}
}
}
StoreCollection
StoreCollection represents collections of message stores. Multiple stores exist, and the convention
followed here is to create stores based on individual stock names.
Here’s the code:
using System;
using System.Collections;
namespace BCastServer
{
public class StoreCollection : IEnumerable
{
Hashtable storeTable = Hashtable.Synchronized(new Hashtable());
public StoreCollection()
{
}
public IMessageStore this[string storeName]226C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
{
get{return storeTable[storeName] as IMessageStore;}
}
public void CreateStore(string storeName)
{
storeTable[storeName] = new InMemoryStore(storeName);
}
public IEnumerator GetEnumerator()
{
return storeTable.Values.GetEnumerator();
}
}
}
Dispatcher
This is an abstract class. The most important method is Schedule, and its implementation is mainly
driven by the concrete dispatcher class:
using System;
using System.Threading;
namespace BCastServer
{
public abstract class Dispatcher
{
StoreCollection storeCollection;
public Dispatcher()
{
}
//Returns the store collection that is then iterated
//by dispatcher, dequeuing individual message from the store
//and dispatching it to its subscriber
public StoreCollection Stores
{
set{storeCollection=value;}
get{return storeCollection;}
}
//This is an abstract method that basically determines
//the strategy for dispatching broadcast data
public abstract void Schedule();
}
}
RoundRobinDispatcher
The code inside the RoundRobinDispatcher class triggers the actual broadcast of messages. The
strategy adopted by the dispatcher depends mainly upon the business scenario, but this dispatcher
schedules the broadcast of individual stores in a round-robin fashion.
Here’s the code:C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 227
using System;
using System.Threading;
namespace BCastServer
{
public class RoundRobinDispatcher : Dispatcher
{
Thread scheduleThread;
int sleepPeriod=100;
public RoundRobinDispatcher()
{
//A new schedule thread is created that starts the message-
//dispatching process.
scheduleThread = new Thread(new ThreadStart(MessageDispatch));
}
private void MessageDispatch()
{
//In this section of code, the message store is fetched
//from the store collection and processing of individual
//store is then offloaded on a dedicated thread made
//available from the thread pool. So effectively messages
//from individual stores are concurrently broadcasted to recipients.
//The schedule thread sleeps for 100ms before it again reschedules
//the broadcast. Before rescheduling takes place, we make sure that
//we don't face the reentrancy problem. This problem is tackled by
//associating a state to a store.
while(true)
{
foreach(IMessageStore store in Stores)
{
if ( store.State == StoreState.Idle )
{
store.State = StoreState.Busy;
ThreadPool.QueueUserWorkItem(new
WaitCallback(BCastPipe.Instance.ProcessModules),store);
}
}
Thread.Sleep(sleepPeriod);
}
}
public override void Schedule()
{
scheduleThread.Start();
}
}
}
IModule
In the “Examining the Business-Technology Mapping” section, we broadly discussed the broadcast
pipe and listed the components chained inside this pipe. Components are allowed to be chained
only when they implement the IModule interface.228C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
Here’s the code:
using System;
namespace BCastServer
{
public interface IModule
{
object Process(PipeContext pipeCtx);
}
}
PipeContext
The PipeContext class provides contextual information to an individual component in the chain. It
provides store information and the actual broadcast message. The component uses the Data prop-
erty to assign component-specific information that is required by the next component in the chain
to perform further processing on it.
Here’s the code:
using System;
using System.Collections.Specialized;
namespace BCastServer
{
public class PipeContext
{
object ctxData;
IMessageStore msgStore;
IBCastMessage message;
public PipeContext(IMessageStore store)
{
msgStore=store;
}
//Returns the current store
public IMessageStore Store
{
get{return msgStore;}
}
//Returns the current message
public IBCastMessage Message
{
get{return message;}
set{message=value;}
}
//Returns the contextual data
public object Data
{
get{return ctxData;}
set{ctxData=value;}
}
}
}C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 229
BCastPipe
BCastPipe does the work of chaining individual components, dequeuing the message from the
store, and handing over the message to the first component in the chain. This entire operation takes
place on a dedicated thread (from a thread pool) assigned by the dispatcher component.
Here’s the code:
using System;
using System.Collections;
namespace BCastServer
{
public class BCastPipe
{
ArrayList moduleChain = new ArrayList();
private static BCastPipe pipeInstance = new BCastPipe();
public static BCastPipe Instance
{
get{return pipeInstance;}
}
public BCastPipe()
{
//This is the chain formation code; in an ideal world
//the chain will be dynamically populated from an XML configuration file.
//Currently data serialization and data transport module are associated
//with this chain
moduleChain.Add(new DataSerializerModule());
moduleChain.Add(new TransportModule());
}
public void ProcessModules(object objState)
{
//A loop is carried out where messages are dequeued one by one
//and are submitted first to serializer component.
//Serializer component converts the message into raw bytes, and
//it is made available as part of return argument of Process.
//The returned information then becomes part of contextual information
//and is assigned to Data property, which is then passed to Transport
//component. Also after processing all messages inside the store, the state
//of store is reset to idle state.
IMessageStore store = objState as IMessageStore;
if ( store.Count > 0 )
Console.WriteLine("Dispatching Store : " +store.Count);
while(store.Count > 0 )
{
PipeContext pipeCtx = new PipeContext(store);
pipeCtx.Message = store.DeQueue();
for(int ctr=0;ctr<moduleChain.Count;ctr++)
{
IModule module = moduleChain[ctr] as IModule;
object ctxData = module.Process(pipeCtx);
pipeCtx.Data = ctxData;
}
}
store.State = StoreState.Idle;230C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
}
}
}
DataSerializerModule
The DataSerializerModule module serializes the message received into an array of bytes; the seriali-
zation technique used is the same as explained in the “Message Framing” section of this chapter.
The array of bytes is encapsulated in an instance of DataSerializerContext that is accessed by the
transport module.
Here’s the code:
using System;
using System.Runtime.InteropServices;
namespace BCastServer
{
public class DataSerializerContext
{
byte[] rawData;
public DataSerializerContext(byte[] data)
{
rawData = data;
}
public byte[] Data
{
get{return rawData;}
}
}
public class DataSerializerModule : IModule
{
public object Process(PipeContext pipeCtx)
{
//Receive the strongly typed broadcast message
IBCastMessage msg = pipeCtx.Message;
//Calculate the object size
int objectSize = Marshal.SizeOf(msg);
//Assign the length of message
msg.MessageLength= objectSize;
//convert the managed object into an array of bytes
IntPtr memBuffer = Marshal.AllocHGlobal(objectSize);
Marshal.StructureToPtr(msg,memBuffer,false);
byte[] byteArray = new byte[objectSize];
Marshal.Copy(memBuffer,byteArray,0,objectSize);
Marshal.FreeHGlobal(memBuffer);
//Return the byte array that will then be
//used by transport module to deliver to its destination
return new DataSerializerContext(byteArray);
}
}
}C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 231
TransportModule
The TransportModule is the final leg in the chain that uses multicast features to deliver data to the
consumer of this information.
Here’s the code:
using System;
using System.Net.Sockets;
using System.Net;
namespace BCastServer
{
public class TransportModule : IModule
{
Socket serverSocket;
IPEndPoint mcastEP;
public TransportModule()
{
//Create a multicast IP address
IPAddress bcastAddress =IPAddress.Parse("224.5.6.7");
mcastEP = new IPEndPoint(bcastAddress ,30002);
serverSocket = new
Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
serverSocket.SetSocketOption(SocketOptionLevel.IP,
SocketOptionName.MulticastTimeToLive, 3);
}
public object Process(PipeContext pipeCtx)
{
//data is broadcast after it is received
//from serializer module
DataSerializerContext szCtx = pipeCtx.Data as DataSerializerContext;
serverSocket.BeginSendTo(szCtx.Data,0,szCtx.Data.Length,
SocketFlags.None,mcastEP,new AsyncCallback(SendData),null);
return null;
}
private void SendData(IAsyncResult result)
{
serverSocket.EndSend(result);
}
}
}
MktDataMessage
The MktDataMessage is a concrete market data message class; we have annotated the fields with the
appropriate marshaling attributes.
Here’s the code:
using System;
using System.Runtime.InteropServices;
namespace BCastServer
{
[StructLayout(LayoutKind.Sequential,Pack=1,CharSet=CharSet.Ansi)]
public class MktDataMessage : IBCastMessage232C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
{
int msgLength;
[MarshalAs(UnmanagedType.ByValTStr,SizeConst=10)]
string underlyingName;
double askPrice;
int askSize;
double bidPrice;
int bidSize;
public string Underlying
{
get{return underlyingName;}
set{underlyingName=value;}
}
public double Ask
{
get{return askPrice;}
set{askPrice=value;}
}
public double Bid
{
get{return bidPrice;}
set{bidPrice=value;}
}
public int AskSize
{
get{return askSize;}
set{askSize=value;}
}
public int BidSize
{
get{return bidSize;}
set{bidSize=value;}
}
public MktDataMessage(string underlying,double ask,int askSz,
double bid,int bidSz)
{
underlyingName=underlying;
askPrice=ask;
askSize=askSz;
bidPrice=bid;
bidSize=bidSz;
}
public int MessageType
{
get{return 1;}
}
public int MessageLengthC H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E 233
{
get{return msgLength;}
set{msgLength=value;}
}
}
}
Host
The code inside the Host class creates stores, then initializes the dispatcher component, and finally
submits messages to stores that are then delivered to the final recipients.
Here’s the code:
using System;
namespace BCastServer
{
public class Host
{
public static void Main(string[] args)
{
StoreCollection storeCollection = new StoreCollection();
//Create a dedicated store for MSFT,YHOO,GE
storeCollection.CreateStore(@"store\MSFT");
storeCollection.CreateStore(@"store\YHOO");
storeCollection.CreateStore(@"store\GE");
//Create the Message Dispatching Scheduler
RoundRobinDispatcher dispatcher = new RoundRobinDispatcher();
dispatcher.Stores = storeCollection;
dispatcher.Schedule();
//Enqueue market data message in MSFT store
MktDataMessage mktData= new MktDataMessage("MSFT",24.5,100,50,25);
IMessageStore msgStore = storeCollection[@"store\" +mktData.Underlying];
msgStore.EnQueue(mktData);
//Enqueue market data message in GE store
mktData= new MktDataMessage("GE",24.5,100,50,25);
msgStore = storeCollection[@"store\" +mktData.Underlying];
msgStore.EnQueue(mktData);
}
}
}
Figure 4-28 shows the BCastServer console output.234C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E
Summary
The following are the key points covered in this chapter:
  We talked about the importance of market data and how it is consumed by market profes-
sionals across the financial trading value chain to arrive at informed trading decisions.
  We provided a basic overview of the important network concepts and protocols such as the
TCP/IP core stack, IP, and ICMP.
  We covered the advantages of using DNS, which provides better name resolution functionality.
  We demonstrated how to use UDP with the help of a market data producer and consumer
example.
  We discussed the advantages of using TCP over UDP.
  We discussed the types of conventions followed by computers when interpreting and pack-
aging multibyte numbers.
  We showed how to implement a generic code to preserve a message boundary.
  We covered the different types of network broadcast techniques: solicited and unsolicited
broadcast.
  Finally, we showed how to implement a prototype of a broadcast engine that uses a network
multicast feature to publish market data.
Figure 4-28. BCastServer console output

