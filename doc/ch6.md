# 第六章 STP 安全 STP Security
Money holds strong reference with the rich and weak reference with the poor.
We introduced the concept of STP in Chapter 1 and described it as moving trades right from the
order-entry stage to settlement without manual intervention. The explanation provided in Chapter 1
highlighted both the internal and external aspects of STP. In this chapter, we will cover the external
STP aspect in more detail and also explain what type of security aspects are required for the process.
Security in external STP becomes important because multiple entities are involved in moving every
trade from origination to settlement. This chapter kicks off its discussion with a detailed business
explanation and then slowly changes its rhythm to the technical side, which includes basic coverage
of the cryptography- and security-related programming features supported by the .NET Framework.
Exploring the Business Context
Participants in any trade are many, and all are geographically spread out. They all need to settle
trades in a time-bound manner. Hence, security in exchanging data becomes a key consideration.
There is normally no time for trade rectification, and the cost of repair in the later stage of trade set-
tlement is high. Chapter 1 covered the trading and settlement fundamentals. In this chapter, you will
see the steps involved in STP in more detail. This will complete your understanding of settlement in
the equities market. We will introduce two more entities here: custodian service providers and STP
service providers. They both play important roles in the overall settlement and STP process.
Custodian Service Provider
Investors trust fund managers with their money. But that does not give fund managers ownership
over an investor’s assets. They are just money managers. From a governance perspective, it is required
that a third-party entity holds securities in its name on behalf of the ultimate investors. This third-
party entity is called the custodian of the securities. A custodian is responsible for delivering and
receiving securities and cash on the instruction of the fund manager whenever a purchase or sale
transaction takes place. A fund that invests securities in multiple markets and asset classes needs
a custodian who can provide support in multiple locations and across asset classes. Custodians
normally have presence across major locations, and wherever they don’t, they enter into agreements
with other custodians to provide such services. The second-level custodians that serve the bigger
custodians are called subcustodians.
299300C H A P T E R 6 ■ S T P S E C U R I T Y
STP Service Provider
STP service providers have the responsibility of carrying and delivering STP-related instructions
and messages. They provide connectivity to market entities such as brokers, custodians, and fund
managers and bring them together in a common network. Once the entities enter the common net-
work, they communicate with each other using standard messaging protocols such as Swift 15022.
STP service providers invest in high-end fault-tolerant hardware and invest in creating a network
that becomes the backbone in such message-based communication. For an STP service to succeed,
it is important that it has a critical mass of institutions along with it. More institutions would mean
higher volumes, which in turn mean higher margins (assuming a fixed cost regardless of the num-
ber of institutions signing in). In most countries, more than one STP service provider exists. This is
to encourage competition so that users have a choice, which in turn yields better service for institu-
tions. This raises another challenge of interoperability.
In markets where more than one STP service provider exists, institutions have a choice. They
can sign up with one service provider after considering the cost structure, reliability, image, and reach
of the service provider. In such cases, a possibility is that the fund manager, custodian, and broker
involved in a particular transaction are on separate networks because they have subscribed to the
services of different service providers. To settle transactions in such cases, messages need to be
passed from one service provider (network) to another service provider (network). To achieve this,
connectivity needs to exist between the three competing networks, and they also need to either be
on the same protocol or understand the same protocols. This ability to seamlessly communicate
with each other across service provider networks and settle transactions is called interoperability.
Noncompliance to interoperability is an area of key concern for market participants, especially if
they have a large customer base. This will alienate institutions that are not with the same service
provider. Compliance to interoperability is normally monitored by the country’s regulators or industry
associations.
Driving Factors Behind STP
STP was initiated as part of the T+1 initiative by the equities market. Transactions are currently being
settled on a T+3 basis. Industry participants are keen to push efficiencies across their own organization
as well as in the overall markets. STP was the central theme around which the T+1 initiative rested.
The T+1 initiative would have resulted in less risk, better capital deployment, and an overall strength-
ening of the financial markets. In fact, an association called Global Straight-Through Processing
Association (GSTPA) was formed to drive the T+1 initiative. However, the initiative was abandoned
in November 2002 because it was met with an unenthusiastic response from industry participants.
Although the industry participants believe that STP is necessary, they were not convinced of T+1.
STP is driven by a couple of factors. We’ll cover some of them in the following sections.
Standardization
Institutions work on a variety of applications, which are themselves on different hardware and soft-
ware platforms. Different institutions work on different applications and used to communicate via
phone calls, faxes, e-mails, and file transfers. Apart from reading these communications and acting on
them, the recipient of these messages really did not have many other choices. There was no automa-
tion of processes. STP helps standardize the interinstitution communication in order to streamline
operations.
Reduction in Costs
Security trading has become a commodity business. This means customers don’t really perceive much
difference between getting their trades executed through broker X versus broker Y unless the quan-
tity of shares transacted (or their related value) is very large. This is much like buying an airlineticket today. For a 2-hour flight, passengers really don’t care whether they are flying carrier A or
carrier B as long as the services of both are reasonably comparable. This commoditization of services
has happened even in the securities industry, and when service levels are comparable, customers
really don’t care whether they route transactions through broker X or broker Y. With the differentiation
in service levels eroding, any differentiation with respect to cost leads to a comparative advantage
for the broker. Brokers are hence taking proactive steps to reduce overall transaction costs and pass
on the benefits in the form of a lower brokerage to customers. Moving toward STP has demonstrated
significant cost savings.
Reduction in Settlement Time
To improve capital allocation and to contain settlement risk, reducing the settlement time from T+5
to T+2 and any initiative toward T+1 will compress the window available for managing settlement-
related activities even further. This makes automation at all levels mandatory.
Reduction in Head Count
Traditional processes in settlements were such that institutions were forced to add staff with increas-
ing volumes. A fixed number of staff could not take on additional volumes when market activity
started to rise. With STP in place, an existing staff can manage even high volumes because the bulk
of transactions pass through and settle through an automated process.
Addressing Exceptions
The settlement process is changing. It is now increasingly being seen as a cost center. The earlier
approach was that every transaction was manually attended to for completing settlements, but now
it is only the problematic transactions to which settlement managers pay attention. All transactions
that don’t have any issues are just allowed to go through.
Single-Point Transaction Fulfillment
While institutions are constantly upgrading their operations, they realized that handling multiple
points of data entry, especially if they relate to the same transaction, is cumbersome and prone to
errors. STP ensures that all trade data enters the STP network only once, and then the same transac-
tion moves on. This results in a savings of effort and an error-free environment. Extensive manual
work was also being done in post-trade activities such as calculating average rates, taxes, and other
levies, and the level of accuracy that customers demanded was not possible in a manual environment.
A Perspective of STP
To appreciate the benefits of STP, you first need to understand the perspective under which STP
happens. Historically, the process of settlements was fairly manual and involved a lot of phone con-
versations, faxing, and e-mailing. The settlement departments of brokers and custodians had to ensure
that they met whatever their obligations were and met them on time. Despite this, trades used to
fail in settlement because of manual involvement, and worse is that all failures used to come to light
only after the process for settling all trades for that settlement were complete. The entire process of
settlements was time-consuming and fraught with a lot of problems and risk involving time delays,
failed settlements, and too much manual work.
To move toward STP, the two main challenges are getting all entities on a common platform so
that they can communicate with each other and having a common protocol to understand seamlessly
what others in the process are discussing. The STP service providers largely overcame this hurdle. It
is also important that a critical mass of institutions be on the STP network. Currently, most institutions
C H A P T E R 6 ■ S T P S E C U R I T Y 301302C H A P T E R 6 ■ S T P S E C U R I T Y
Figure 6-1. Block diagram of participants in STP
have adopted STP technology, and those who have not are running the risk of being alienated by
other institutions because everyone is looking to do business with tech-savvy institutions that don’t
pose a risk when becoming a counterpart.
STP in an equities trade involves the following entities (see Figure 6-1):
  Investing institutions (fund managers)
  Custodians
  Brokers
  STP service providers
The STP service provider sells its STP services to fund managers, brokers, and custodians and
expects them to join their service. Once they join, they are given a terminal through which they can
connect to the common network and communicate through a common and standard protocol such
as Swift 15022. Having a common protocol for communication is important. This ensures that from
day one each participant can understand what the others are saying and ensures that no one organi-
zation has an edge over the other in this entire framework. The entire network is also independent
of which systems or front/back office products the organizations are using. The network is platform
neutral. Once these organizations are on a common network and have the ability of processing trade-
related information electronically using the communication protocol, technically they are STP enabled.
Along with entities mentioned, the following also play a crucial role in enabling the STP process
in the market:
  Stock exchanges
  Clearing corporations
  Depositories
  Banks
These other entities also play an important role in enabling the STP process and will continue
to play a vital role, especially if the market again creates an initiative to move from T+3 to T+1. STP
also will not be achieved until both institutional and retail trades are brought into the STP framework.
In a T+3 to a T+1 environment, there is as much risk from retail trades as there is from institutional
trades. Though the value of retail trades is a lot less than institutional trades, a lot of discipline is
required on the retail side, especially when it comes to meeting commitments on time. Retail investorsC H A P T E R 6 ■ S T P S E C U R I T Y 303
are normally required to deliver the shares in a sale transaction and provide money to brokers to meet
their purchase commitments. This money ultimately has to move to the clearing corporation’s account
by T+3 (or T+1 as the case might be). Moving money normally happens through multiple accounts.
A retail investor will first write a check in favor of his broker. The broker in turn will write a check in
favor of the clearing corporation. Moving money may take time, especially when it is not the only
thing investors are doing. Banks must be geared up in terms of systems to meet these challenges
and move money fast.
Brokers and financial institutions have spent a lot of time, effort, and money on centralizing and
consolidating their IT operations. To achieve true STP, this IT structure, especially the part related to
decision making, will again have to be decentralized. This also means that just as fund managers,
brokers, and custodians use a mix of their systems and the STP service providers’ services, other
entities such as a broker’s franchises (if the broker operates on a franchise model), exchanges, and
depositories must also devise their operations and processes in such a way that they are able to
communicate and work effectively so that the market as a whole can come to the T+1 model. For
example, for retail transactions, instead of expecting delivery of shares from the broker, if the deposi-
tory also builds in the facility of accepting shares directly from the retail investor’s accounts, then
those investors who maintain their securities with a broker (other than the one who has executed
the transaction) can deliver the securities directly by the pay-in date. This transaction could be tagged
by the broker’s code so that the clearing corporation also knows the name of the broker against whose
obligations these securities could be deemed delivered. This will reduce the leg of investors first
transferring shares in the broker’s account and brokers in turn transferring them to the clearing cor-
poration’s account at the time of pay-in. Similarly, at the time of pay-out, the clearing corporation
could directly transfer the shares.
In fact, true STP can be achieved only when all these entities come forward and participate in
the STP process and only when interoperability issues have been addressed.
How Is STP Achieved?
We will attempt to explain STP with an example. Our emphasis in this example is on institutional
transactions rather than retail. This is because STP is more relevant for institutional transactions
because the number of entities and complexity involved in settling an institutional transaction is
greater than when settling a retail transaction. Let’s assume a buy transaction.
Fund managers run investment management services for individuals, governments, pension
trusts, corporations, and virtually everyone who has money and wants to deploy in the market in
search of returns. The complexity of the fund management process differs depending upon the
customer for which the fund is being managed, the type and objectives of the fund, the number
and category of securities the fund invests in, and the geographical diversification and investment
of the fund.
Fund managers buy or sell depending upon their perception of the market and underlying
securities. They buy when they are convinced the underlying securities will appreciate in value and
sell when they believe the underlying securities will decline in value. They benchmark their returns
with a broad-based index and also with other funds having a similar objective.
Fund managers route their orders through brokers. Fund managers try their best to keep the
composition of the fund’s portfolio aligned to the fund’s objectives. This alignment, realignment,
and fund manager’s changing perception of a stock’s value causes the purchase and sale of shares.
The sales desk staff of brokering companies looking for business also engages fund managers and
discusses the market trends and direction. They also discuss investment as well as divestment opportu-
nities. Normally such discussions result in the fund managers giving orders to buy or sell one or more
securities.Figure 6-2. The fund manager submits the order, and the broker sends a notice of execution.
When an order is given to the trading desk, the fund manager may consolidate orders from
multiple funds into one and forward it. This may happen frequently if the fund manager manages
assets for multiple portfolios and funds. When the order reaches the trading desk, the dealer may
aggregate those orders with orders from other clients/funds but put the same execution conditions
into a single block and then send the block for execution.
A lot of clients and fund managers use their own order management systems (OMSs) to connect
to the broker. They connect directly to the exchange where their orders are routed after passing risk
management checks laid down by the brokers, or these orders get delivered to the broker who in
turn enters the orders in the exchange trading system available. Establishing connectivity with bro-
kers is a key challenge in itself. Some countries have regulations on the amount of business that can
be passed to a single broker. Assuming regulators allow a maximum of 5 percent of transactions to be
given to one broker, it logically follows that each fund must at least maintain relations with a minimum
of 20 brokers. Establishing connectivity with each separately is impractical. Even if connectivity is
assumed, establishing connectivity alone is not enough to deliver orders. Orders must also be deliv-
ered in a format that brokers can understand. This format also has to be fairly standardized so that
all brokers understand it. The Financial Information Exchange (FIX) protocol has evolved as one of
the most popular protocols for the electronic exchange of securities information, especially on the
order delivery (front-office) side.
Returning to the example, execution on the exchange may or may not happen in the same
block of quantity. In fact, the order will most likely result in multiple fills and will hence result in
multiple trades. (Please refer to Chapter 2 to get more insight into this.)
The broker is required to regroup the executions and realign them according to the order. This
will most times require averaging out the trades and arriving at a common average price. Once the
average price is established, the broker will send out a “notice of execution” to the fund manager.
The notice of execution is sent through the STP service provider (see Figure 6-2). This notice of
execution is usually generated automatically by the broker’s system and passed to the STP service
provider’s system for further delivery.
304C H A P T E R 6 ■ S T P S E C U R I T Y
It could be possible that by looking at good prospects or a buoyant market, the fund manager
could have given a blanket buy order for multiple funds without disclosing the identity of individual
funds to the broker. Once the broker communicates that all execution is done, the fund manager can
then decide which part of execution will go into which fund. This information is returned to the bro-
ker through the STP service provider network. This process is called allocation. The broker uses the
allocation details to calculate the fees and taxes applicable and prepares the contract in the name ofFigure 6-3. The fund manager provides allocation, and the broker sends the contract note.
C H A P T E R 6 ■ S T P S E C U R I T Y 305
the individual fund for which the transactions were originally meant. Once these details are ready, the
broker forwards the contract to the fund manager through the STP service network (see Figure 6-3).
In absence of such a mechanism, the broker would have to generate the contract notes, take hard-
copy printouts, and fax them to fund managers and custodians. The fund managers and custodians
would have to then pick up this fax and manually enter all the information in their system. Imagine
the number of faxes that would have been required to send if the fund manger worked with 20 bro-
kers and the broker catered to 20 fund managers. With digital signatures in place, the delivery of such
digitally signed contracts is legally treated on par with the physical delivery that used to happen.
Once the confirmation is received by the fund managers, the fund’s respective custodians need
to be informed about the executions so they can be ready for settling the transaction.
The custodian receives transaction details from the fund manager and execution details from
the broker. The custodian matches the two and accepts the transaction from the broker if all the details
match. Once a custodian accepts a transaction, settling this transaction becomes the responsibility
of the custodian. Custodians are normally clearing members in the clearing corporations that clear
the trades for exchanges on which brokers transact on behalf of fund managers. In case the contract
parameters do not conform to what was expected to be executed by the fund manager, the custodian
rejects the contract, and the profit or loss arising from transactions forming the contract becomes the
liability of the broker. Normally the broker squares up such transactions on the same day by entering
a reverse transaction in the stock exchange. In case the rejection has happened because of something
minor like an erroneous calculation of commission or taxes, then the broker has the facility to correct
the contents of the contract note and resubmit it to the custodian for acceptance.
One big benefit that brokers derive from being on the same network as the custodians is that
they know their obligations in real time. This is because the moment custodians reject any contract,
a message is sent to the broker as well. The broker can immediately take steps to square up the
transactions or regenerate the contract note as the case may be. In addition to real-time clarity over
the fate of contracts, everyone is aware and in complete control of what’s happening and when. Such
clarity and control is not present in a fax-based scenario. In the fax era, brokers knew that a fax had
been received by the fund manager/custodian but didn’t know whether they had acted on it also.
All communication between fund manager, custodian, and broker also happens through the
STP service provider network (see Figure 6-4).306C H A P T E R 6 ■ S T P S E C U R I T Y
Once the custodian accepts the transaction, they submit an instruction for receipt (remember, it
was a buy transaction) of securities. Similarly, the counterparty of this transaction (who sold the shares)
would have submitted an instruction for the delivery of securities. The submission of instruction is
a confirmation that an institution is standing by the transaction and wants to receive/deliver securities
in order to complete the settlement. Such instructions enter a database called a Standing Instructions
Database (SID). Once both sides of instructions get matched, the depository will move securities from
the seller’s account to the buyer’s account through the clearing corporation. Figure 6-5 shows the
complete STP framework (post-trade).
The settlement of funds happens through the usual banking channels.
Figure 6-4. The broker sends the contract details to the custodian; the custodian matches the details
with transaction information submitted by the fund manager.
Figure 6-5. Complete STP framework (post-trade)C H A P T E R 6 ■ S T P S E C U R I T Y 307
Figure 6-6. The STP space
Implementing Security in the STP Space
In this entire STP process, the exchange of information is key. Multiple actors are involved in the
STP space, and an individual actor plays an important role in making a transaction successful (see
Figure 6-6). When so many institutions are trying to get onto the same network and exchange mes-
sages with each other, the security and the reliability of the service provider’s network become the
main concerns.
A quick flashback to bygone days will reveal that the primary communication mediums used to
exchange information were telephone or fax. This type of communication involved quite a large amount
of paperwork to be produced and exchanged on a regular basis. However, in today’s modern age
with the availability of advanced communication infrastructure, information exchange has become
blazingly fast. Zero paperwork is involved; instead, the majority of information is made available in
electronic form. This is certainly a boon, but unfortunately the electronic medium has the following
problems:
Confidentiality: Confidentiality is related to the privacy of data; for example, when the broker
sends a contract note to a fund manager, the information provided in the contract note (such
as the number of trades executed and the price of individual trade) is very sensitive in nature. If
this information is compromised during transit by a malicious user (a fund manager competitor),
then it is sufficient to create havoc in the trading community. By gaining access to such infor-
mation, the competitor can easily infer the trading strategy, which is the bread and butter of
a fund manager.
Integrity: Data integrity is an important aspect of a transaction. Consider an order initiated by
a fund manager to a broker to purchase 100 stocks of Microsoft Corporation. Before it is received
by the broker, this order is altered by an unauthorized user, and the number of stocks is changed
to 1,000. On receiving this order, the broker immediately transacts and sends a confirmation to
purchase 1,000 stocks to the fund manager. No doubt it will come as a big blow to the fund
manager, and the financial impact of such a transaction will be irrecoverable.
Authentication: In bygone days, trading usually happened over phones; fund managers used to
directly place a call to a broker and submit the order. The advantage of such an approach is that
both parties know each other’s identity, but in a faceless world when a broker receives an order
in an electronic form, it is important to know the sender information. It is equally important to
the fund manager to know the source of data when the broker sends an order confirmation.
Nonrepudiation: Financial transactions are highly vulnerable to legal problems; the most notable
is the sender denying performing an invalid operation. Consider the data integrity example where
the quantity attribute of an order is changed from 100 to 1,000. It is expected that the fund man-
ager will deny performing any such action, but without any strong evidence the broker has no
way to prove this in a court of law.
The success of STP is solely dependent upon the mechanism implemented to protect the infor-
mation: the security of the information. A weak security implementation will lose the credibility and
acceptance of the STP. Therefore, to prevent loss of trust and to provide a strong sense of safety and308C H A P T E R 6 ■ S T P S E C U R I T Y
privacy to an individual actor, a secure platform is required where information is safely exchanged.
This is where the field of cryptography comes into action. Cryptography is a set of mathematical
techniques implemented to protect information. It includes mechanisms that effectively solve
the majority of problems encountered during the electronic exchange of information. By applying
cryptography in the STP space, all kinds of data-sharing barriers are eliminated, and a secure envi-
ronment is erected to conduct business.
Confidentiality
Cryptography addresses the confidentiality aspect of information by concealing it. The act of conceal-
ment includes disguising the existence of the actual information by converting it into a gibberish
message that is hard to understand and doesn’t convey any meaningful sense to the human eye. This
process is called the encryption of a message; similarly, a reverse process is conducted where the
encrypted message is transformed to its original message, and this process is known as the decryption
of the message.
The secret of encryption/decryption lies in the algorithm that is devised based on the tenets of
mathematics. This algorithm in cryptographic terminology is known as a cipher. A cipher contains
a set of established rules that knows how to encrypt and decrypt a message. The rules depend upon
a cipher key that is selected from a possible set of key spaces and that dictates the encryption/
decryption process.
An important fact of cryptography is that ciphers should be publicly known, but cipher keys,
which contain the actual information that needs to be protected, should be private. The safety of
the data is ultimately dependent upon the safety of the key and not the cipher. If the safety of the
data depended upon the cipher, then imagine the consequences if the cipher was broken. By carving
out safety based on the cipher key, decrypting the message becomes complex and time-consuming
because the attacker now has to play with all possible cipher keys in order to deduce the original
message. This whole concept is explained clearly with the help of a simple substitution cipher (see
Figure 6-7).
The strength of the substitution cipher resides in replacing every character with a mapped charac-
ter. This mapping information represents the key that is fed to the substitution algorithm that swaps
the original character with another one. By swapping characters, you produce a new encrypted
message that is also popularly known as the cipher text. It is hard to weed out the original message
from the cipher text, and the only way to recover it is to know the mapping rules (that is, the key). By
feeding the correct key and cipher text back to the substitution cipher, you can generate the original
message.
Figure 6-7. Substitution cipherC H A P T E R 6 ■ S T P S E C U R I T Y 309
Figure 6-9. Cipher mode
This example clearly demonstrates that the strength of encryption and decryption depends
upon the key. Even though the inner workings of a cipher are straightforward, without a legitimate
key the fund manager will fail to decode the encrypted message sent by the broker. Furthermore,
the number of possible keys that could be envisaged is directly related to the possible number of
ways that both alphabets and numbers can be arranged. Thus, an attacker has to build an exhaus-
tive list of all possible combinations in order to recover the original message. This kind of attack is
called a brute-force attack.
Besides the substitution cipher, a transposition cipher re-orders the arrangement of a message.
For example, in Figure 6-8, when plain text is passed to the transposition cipher, it rearranges the
message in a matrix fashion where an individual row represents n characters of the message. This n
forms the key, and in this example we have arranged the message in a row of ten characters. If
a message size is not a multiple of ten, then it is padded with a hyphen character. After splitting the
message, another round of shuffling is conducted where the individual character is read from top to
bottom in a columnar fashion to form the cipher text.
In both the transposition and substitution cipher examples, the whole encryption and decryp-
tion scheme is applied over the entire message, but in reality ciphers operate in two modes: block
mode and stream mode (see Figure 6-9). Block ciphers divide a message in blocks of an appropriate
size, and then an individual block is encrypted or decrypted. Similarly, stream ciphers are suitable to
encrypt or decrypt a message of a smaller size where the encryption/decryption scheme is applied
at an individual byte or bit level.
Figure 6-8. Transposition cipher310C H A P T E R 6 ■ S T P S E C U R I T Y
Today’s modern ciphers implement both a transposition technique and a substitution technique,
which makes it harder for attackers to break the message. But it doesn’t means it is an impossible task.
With the help of an advanced processor, an attacker can easily crack messages that are founded upon
a weak cipher or key. Therefore, the only approach to thwart an attacker attempt is to have a watertight
cipher and a key of a large size. By increasing the length of the key, the number of possible combi-
nations increases, which makes the attacker’s job much tougher. It also means the security of data and
a strong cipher are mainly dependent upon the key, and hence it is absolutely necessary to safeguard
the key from prying eyes.
Symmetric Key
Symmetric keys are also called shared keys because they are known to both the sender and the receiver,
and both the encryption and decryption tasks are achieved using this single key (see Figure 6-10).
Security based on a symmetric key is considered to be a secret/private communication between the
sender and the receiver. For example, if a broker is conducting business with multiple fund managers,
then it involves generating multiple shared keys, and each key is unique and exclusive to a particular
fund manager. By assigning a dedicated key to an individual fund manager, the broker is able to meet
both the authentication and the confidentiality aspects of the data. Furthermore, the symmetric
key–based ciphers are very fast and support the encryption/decryption of a large block of data with-
out any hit on performance.
The most popular symmetric algorithms are Data Encryption Standard (DES), Triple-DES, RC2,
and Rijndael. These algorithms are extensively used in both the commercial and academic fields and
are a success story in the field of security. However, the strength of these algorithms is determined
by their key size, which is different for each individual algorithm. As a matter of fact, DES is almost
on the verge of losing its market share because it implements a 56-bit key size, which is relatively
small in comparison with Rijndael and RC2. Rijndael supports key sizes of 128, 196, and 256 bits;
similarly, RC2 supports variable key sizes ranging from 1 byte to 128 bytes. Another important fact
about symmetric algorithms is that different types of modes are available to encrypt or decrypt
a message. This mode determines the granularity of the message that is considered for the encryption/
decryption.
Electronic Code Book (ECB)
Electronic Code Book (ECB) is the simplest mode of all available modes (see Figure 6-11). Given plain
text, it divides the message into a fixed block of n size. Then each individual block is encrypted or
decrypted, and finally the output produced by an individual block is combined to form cipher text
or plain text.
Figure 6-10. Symmetric keyC H A P T E R 6 ■ S T P S E C U R I T Y 311
Cipher Block Chaining (CBC)
In Cipher Block Chaining (CBC) mode, the plain text is divided into a fixed block of n size, but each
block of plain text before being encrypted is XORed with the previous encrypted block, and encryp-
tion is performed on the output produced from this bitwise XOR operation (see Figure 6-12). There
is an exception that is applied only to the first block where the XORing operation is performed with
an initialization vector (IV). IV is random information generated to act as input to the first block of
plain text.
Cipher Feedback Mode (CFM)
Cipher Feedback Mode (CFM) is used to encrypt/decrypt data with a length smaller than block size
(see Figure 6-13). The characteristics of CFM make it look like a stream cipher and are highly suited
to encrypt a single byte or bit.
Figure 6-11. ECB mode
Figure 6-12. CBC mode
Figure 6-13. CFM312C H A P T E R 6 ■ S T P S E C U R I T Y
Figure 6-13 demonstrates the encryption of a single byte using CFM. The important element
that pumps this mode is the feedback register that is initially filled with the IV. The length of this
register is exactly equal to the underlying cipher block size; in this scenario, we have considered the
length of the block cipher to be 64 bits. Encryption is first performed on the feedback register, and
output produced from this operation is then XORed with the plain text. However, the number of bits
considered for the XORing operation depends upon the length of the input bits; for instance, if the
length of the plain text is 1 byte, then the leftmost 8 bits of output bit is XORed with 8 bit of input bits.
The output after the XORing operation is fed back to the feedback register; it involves shifting the
leftmost 8 bits. This entire operation is again repeated for the next stream of characters. A slight variant
of CFM is Output Feedback Mode (OFB). In this mode, the feedback register is populated with bits
that are produced after applying an encryption scheme, which is in contrast with CFM where the
feedback register is populated with bits produced after the XOR operation.
As you can see, the behavior of different cipher modes is fine-tuned for a specific scenario. For
example, if you come across an interactive-based application where every keystroke needs to be imme-
diately transmitted to its recipient, then CFM and OFB are much more secure than CBC.
Symmetric Classes
The programmatic implementation of symmetric algorithms is defined inside the System.Security.
Cryptography namespace. This namespace basically contains cryptographic classes related to sym-
metric algorithms, hashing, and asymmetric algorithms (discussed later in this chapter). Looking
more closely at the cryptography implementation in .NET mainly at the class level, you will find two
levels of inheritance followed. The first level is the abstract class that defines common operations.
This class is then derived by an algorithm-specific class, which is abstract, and a final-level concrete
class is defined that is used by the client to perform cryptographic operation.
Returning to the symmetric algorithms, the base class in which all common operations are
defined is SymmetricAlgorithm. This class is further subclassed by an algorithm-specific class that is
abstract and is further extended by the concrete class. The implementation of this final concrete class
is either managed or unmanaged and is easy to determine by its suffix. Class names that contain the
suffix CryptoServiceProvider are unmanaged implementations; similarly, class names that contain
the suffix Managed are pure managed implementations. Figure 6-14 shows a class diagram of symmetric
algorithms.
The individual symmetric algorithm is encapsulated in a separate class, and being inherited from
a common base class, it is relatively simple to change the algorithm implementation with the flip of
a switch. However, some exception cases exist where a particular feature is available in one algorithm
and not in others. The key differentiator among these algorithms is the key size supported and how
fast a message is encrypted or decrypted. Table 6-1 provides this information.
Figure 6-14. Symmetric algorithm class hierarchyC H A P T E R 6 ■ S T P S E C U R I T Y 313
Table 6-1. Key Sizes of Various Symmetric Ciphers
Algorithm Key Size
DES 56 bits
TripleDES Three different keys of 56-bit key size to encrypt and decrypt a message
Rijndael Variable key size (1 to 2,048 bits)
RC2 Supports 128-, 192-, and 256-bit key size only
The next step is to delve into the code-level implementation where a plain message is encrypted
and decrypted using the Rijndael algorithm. Let’s consider the interaction between the broker and
fund manager where the contract note defined using XML is encrypted into an unreadable content
and sent to the fund manager. The fund manager on receiving this encrypted information will be able
to decipher the message only if he knows the symmetric key. The code shown in Listing 6-1 demonstrates
both these scenarios. The code is broken down into two sections; the first section provides informa-
tion about underlying cipher strength, and the last section covers the encryption and decryption task.
Listing 6-1. Contract Note Information Encrypted by the Broker and Decrypted by the Fund Manager
Using the Symmetric Key
using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;
namespace SymmetricAlgo
{
class SymmetricExample
{
static void Main(string[] args)
{
//perform symmetric encryption using RijndaelManaged algorithm
SymmetricAlgorithm algoProvider = RijndaelManaged.Create();
Console.WriteLine("Crypto Provider Information");
Console.WriteLine("--------------------");
Console.WriteLine("Cipher Mode : " + algoProvider.Mode);
Console.WriteLine("Padding Mode : " +algoProvider.Padding);
Console.WriteLine("Block Size : " +algoProvider.BlockSize);
Console.WriteLine("Key Size : " +algoProvider.KeySize);
Console.WriteLine("Contract Note Encryption Stage - Broker end");
Console.WriteLine("-------------------------------------------");
//Generate Symmetric Key
algoProvider.GenerateKey();
//Generate IV
algoProvider.GenerateIV();
//create file that stores encrypted content of contract note
FileStream fileStream = new
FileStream(@"C:\ContractNote.enc",FileMode.Create);314C H A P T E R 6 ■ S T P S E C U R I T Y
//create symmetric encryptor object
ICryptoTransform cryptoTransform = algoProvider.CreateEncryptor();
//create cryptostream
CryptoStream cryptoStream = new
CryptoStream(fileStream,cryptoTransform,CryptoStreamMode.Write);
string contractNote = "<CONTRACTNOTE>"
+"<SYMBOL>MSFT</SYMBOL>"
+"<QUANTITY>100</QUANTITY>"
+"<PRICE>24</PRICE>"
+"</CONTRACTNOTE>";
byte[] contentBuffer = Encoding.ASCII.GetBytes(contractNote);
//write encrypted data
cryptoStream.Write(contentBuffer,0,contentBuffer.Length);
cryptoStream.Close();
fileStream.Close();
Console.WriteLine("Contract Note Decryption Stage - Fund Manager end");
Console.WriteLine("-------------------------------------------------");
//open encrypted content of contract note
fileStream = new FileStream(@"C:\ContractNote.enc",FileMode.Open);
//create symmetric decryptor object
cryptoTransform = algoProvider.CreateDecryptor();
cryptoStream = new
CryptoStream(fileStream,cryptoTransform,CryptoStreamMode.Read);
byte[] readBuffer = new byte[fileStream.Length];
//decrypt data
cryptoStream.Read(readBuffer,0,readBuffer.Length);
string decryptedText =
Encoding.ASCII.GetString(readBuffer,0,readBuffer.Length);
Console.WriteLine(decryptedText);
}
}
}
In Listing 6-1, a new instance of Rijndael is created that represents the Rijndael symmetric
algorithm. This newly returned instance is then assigned to a variable of the SymmetricAlgorithm
type. This cast operation is successfully executed without any errors because Rijndael is derived
from SymmetricAlgorithm. A more elegant approach is to create a factory class with a factory method
that returns the correct instance based on an argument passed to it. This way, the provider-level
class details are completely hidden in the factory class, and any new symmetric algorithms can be
easily introduced by modifying the factory class.
SymmetricAlgorithm algoProvider = RijndaelManaged.Create();
After constructing an instance of Rijndael, the next step is to list the features supported by the
algorithm, which includes the cipher mode, key size, block size, and padding mode. The default
cipher mode is CBC, and with the help of the Mode property, it can be changed; however, remember
that it is also important to verify that the underlying algorithm supports the other mode. An excep-
tion will be thrown if a particular cipher mode is not supported by the provider.C H A P T E R 6 ■ S T P S E C U R I T Y 315
Console.WriteLine("Crypto Provider Information");
Console.WriteLine("--------------------");
Console.WriteLine("Cipher Mode : " + algoProvider.Mode);
Console.WriteLine("Padding Mode : " +algoProvider.Padding);
Another important property that goes hand in hand with the cipher mode is Padding. Often,
when a message is broken down into a block of particular size, the last block is left behind with empty
bytes, and it needs to be padded. To address this problem, padding is performed, and three possible
values exist:
None: No padding is performed.
PKCS7: This padding scheme fills up the empty bytes with a value equal to the number of padding
bytes required.
Zeros: The value zero is padded.
The key and block size are determined with the help of the KeySize and BlockSize properties:
Console.WriteLine("Block Size : " +algoProvider.BlockSize);
Console.WriteLine("Key Size : " +algoProvider.KeySize);
You can change these values provided that they fall in a valid range, which is available in the form
of the LegalKeySizes and LegalBlockSizes properties. Both these properties return only the values
that are supported by the underlying algorithm provider. The default key size supported by Rijndael
is 256 bits, and the block size is 128 bits.
Next, you initiate the encryption phase; the first step in this phase is to generate a key and IV
that is used to encrypt the message:
Console.WriteLine("Contract Note Encryption Stage - Broker end");
Console.WriteLine("-------------------------------------------");
algoProvider.GenerateKey();
algoProvider.GenerateIV();
You can generate a key and IV in two ways. The first approach is let the user define the key and
IV, and this is possible by assigning a value to the Key and IV properties of the SymmetricAlgorithm
class. The major drawback of such an approach is it is very susceptible to brute-force attacks, and
we as human beings are weak when it comes to coining a message that is truly unique and random
in nature. The other approach is to rely on the underlying algorithm provider to produce a key auto-
matically. This way, a strong key is generated that is hard to guess.
In Listing 6-1, with the help of the GenerateKey and GenerateIV methods, both the key and IV
are autogenerated. This newly generated value is also assigned to the Key and IV properties. It is
important to preserve both these values on some persistent storage medium because the fund
manager on the other end will be able to decrypt the message only when the correct key and IV are
fed to the algorithm.
Next, a new file is created that is forwarded to the fund manager, and the content of this file
represents contract note information in encrypted form:
FileStream fileStream = new FileStream(@"C:\ContractNote.enc",FileMode.Create);
Once you have successfully created the file, the next task is to encrypt the contract note
information. The encryption and decryption task is achieved using the CreateEncryptor and
CreateDecryptor methods. Both these methods return an instance of a transform class that imple-
ments the ICryptoTransform interface. This newly returned instance contains logic to encrypt/
decrypt the message.
ICryptoTransform cryptoTransform = algoProvider.CreateEncryptor();316C H A P T E R 6 ■ S T P S E C U R I T Y
Next, we create an instance of CryptoStream that is used in conjunction with any data stream to
perform cryptographic transformation (encryption or decryption):
CryptoStream cryptoStream =
new CryptoStream(fileStream,cryptoTransform,CryptoStreamMode.Write);
CryptoStream is in line with a file or socket stream that supports reading or writing data in
a byte-oriented fashion. The same functionality is provided by CryptoStream; but instead of directly
reading or writing a chunk of bytes, it is first submitted to the transformer that performs the crypto-
graphic transformation (encryption/decryption), and then the output produced is chained with
another stream-based object. In Listing 6-1, you chain the cryptographic stream with a file stream and
configure it in a write mode, so any byte written through the cryptostream will get first encrypted,
and this encrypted message is then directly written to the file.
The actual contract note message, before passing to CryptoStream, is converted into an array of
bytes. Then the content is encrypted and finally redirected to a FileStream:
string contractNote = "<CONTRACTNOTE>"
+"<SYMBOL>MSFT</SYMBOL>"
+"<QUANTITY>100</QUANTITY>"
+"<PRICE>24</PRICE>"
+"</CONTRACTNOTE>";
byte[] contentBuffer = Encoding.ASCII.GetBytes(contractNote);
cryptoStream.Write(contentBuffer,0,contentBuffer.Length);
cryptoStream.Close();
fileStream.Close();
Finally, we cover the last leg of this code, which in the real world mimics the fund manager who
receives the encrypted content of the contract note and then uses the correct symmetric key to decrypt
it and read the original message:
Console.WriteLine("Contract Note Decryption Stage - Fund Manager end");
Console.WriteLine("-------------------------------------------------");
fileStream = new FileStream(@"C:\ContractNote.enc",FileMode.Open);
cryptoTransform = algoProvider.CreateDecryptor();
cryptoStream = new CryptoStream(fileStream,cryptoTransform,CryptoStreamMode.Read);
byte[] readBuffer = new byte[fileStream.Length];
cryptoStream.Read(readBuffer,0,readBuffer.Length);
string decryptedText = Encoding.ASCII.GetString(readBuffer,0,readBuffer.Length);
Console.WriteLine(decryptedText);
The decryption code (the fund manager end) is the same as the encryption code with the only
difference being that the data is read from CryptoStream. Another important point to note is that we
have reused the same instance of SymmetricAlgorithm in which both the key and IV are already
populated, but in the real world the fund manager will initialize these values. Of course, the fund
manager must know both the key and IV beforehand, and the broker must have communicated this
information through some secure communication channel or storage medium.
Figure 6-15 shows the console output of Listing 6-1; it also displays the content of the contract
note, which is in encrypted form.C H A P T E R 6 ■ S T P S E C U R I T Y 317
Asymmetric Key
An asymmetric key solves most of the problems in cryptography (see Figure 6-16). The most important
one it addresses is the key exchange issue; the way this algorithm works is that a key pair containing
a public key and private key is first generated. The public key, as the name indicates, is meant to be
distributed to the masses, and the private key is confidential information and is kept secret. Both
public and private keys generated are related to each other, and a message encrypted using a public
key can be decrypted only by its corresponding private key. This logic also holds true for a reverse
case where a message encrypted using a private key can be decrypted only with its corresponding
public key.
Using asymmetric algorithms, the fund manager generates a single key pair and distributes the
public key to the broker. The fund manager can also publish the public key on a Web site, allowing it
to be freely available for download. Now, when the broker sends a contract note to the fund manager,
the plain-text message is encrypted with a public key, and the fund manager upon receiving it decrypts
it with the private key. The decryption is performed successfully because only the fund manager is
in possession of the private key.
Figure 6-15. Console output of the program using the symmetric key
Figure 6- 16. Asymmetric key318C H A P T E R 6 ■ S T P S E C U R I T Y
Several asymmetric algorithms exist, but the most popular ones are RSA and DSA. (RSA stands
for Rivest Shamir Adleman, and DSA stands for Digital Signature Standard.) Both algorithms are
bundled inside the .NET Framework and have their own class hierarchy, as shown in Figure 6-17.
The depth of class hierarchy is similar to the symmetric algorithm’s class hierarchy consisting
of two levels of inheritance. AsymmetricAlgorithm is a base abstract class that is further extended by
an algorithm-specific abstract class. The common functionality (such as encryption and decryp-
tion, key import, and export) is all bundled in one pack and exposed in the form of members by
AsymmetricAlgorithm. You will look at this functionality with the help of the code shown in Listing 6-2,
which uses an asymmetric key to exchange contract note information between the fund manager
and the broker.
Listing 6-2. Contract Note Information Encrypted by the Broker and Decrypted by the Fund Manager
Using the Asymmetric Key
using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;
namespace AsymmetricAlgo
{
class Class1
{
static void Main(string[] args)
{
//Generate public and private key
GenerateKeyPair();
//encrypt contract note using fund manager's public key
ContractNoteBroker();
//decrypt contract note encrypted by the broker
//using the fund manager's private key
ContractNoteFM();
}
public static void GenerateKeyPair()
{
//perform asymmetric encryption and decryption using the RSA algorithm
RSACryptoServiceProvider cryptoProv = new RSACryptoServiceProvider();
//extract public key
string publicKey = cryptoProv.ToXmlString(false);
//extract private key
Figure 6- 17. Asymmetric algorithm class hierarchyC H A P T E R 6 ■ S T P S E C U R I T Y 319
string privateKey = cryptoProv.ToXmlString(true);
//persist private key
StreamWriter writer = new StreamWriter(@"C:\PrivateKey.xml");
writer.Write(privateKey);
writer.Close();
//persist public key
writer = new StreamWriter(@"C:\PublicKey.xml");
writer.Write(publicKey);
writer.Close();
}
public static void ContractNoteBroker()
{
Console.WriteLine("Contract Note Encryption Stage - Broker end");
//parameters passed to cryptographic service provider
CspParameters param = new CspParameters();
param.Flags = CspProviderFlags.UseMachineKeyStore;
//read public key, and initialize RSA with the fund manager's public key
RSACryptoServiceProvider cryptoProv = new RSACryptoServiceProvider(param);
StreamReader reader = new StreamReader(@"C:\PublicKey.xml");
cryptoProv.FromXmlString(reader.ReadToEnd());
string contractNote = "<CONTRACTNOTE>"
+"<SYMBOL>MSFT</SYMBOL>"
+"<QUANTITY>100</QUANTITY>"
+"<PRICE>24</PRICE>"
+"</CONTRACTNOTE>";
byte[] contentBuffer = Encoding.ASCII.GetBytes(contractNote);
//encrypt contract note using public key, and write it to a file
FileStream fileStream = new
FileStream(@"C:\ContractNote.enc",FileMode.Create);
byte[] encContent = cryptoProv.Encrypt(contentBuffer ,false);
fileStream.Write(encContent,0,encContent.Length);
fileStream.Close();
}
public static void ContractNoteFM()
{
Console.WriteLine("Contract Note Decryption Stage - Fund Manager end");
//parameters passed to cryptographic service provider
CspParameters param = new CspParameters();
param.Flags = CspProviderFlags.UseMachineKeyStore;
RSACryptoServiceProvider cryptoProv = new RSACryptoServiceProvider(param);
//initialize RSA with private key
StreamReader reader = new StreamReader(@"C:\PrivateKey.xml");
cryptoProv.FromXmlString(reader.ReadToEnd());
reader.Close();320C H A P T E R 6 ■ S T P S E C U R I T Y
//decrypt the encrypted contract note using private key
FileStream fileStream = new FileStream(@"C:\ContractNote.enc",FileMode.Open);
byte[] readBuffer = new byte[fileStream.Length];
fileStream.Read(readBuffer,0,readBuffer.Length);
byte[] decContent = cryptoProv.Decrypt(readBuffer,false);
string contractNote = Encoding.ASCII.GetString(decContent);
Console.WriteLine(contractNote);
}
}
}
In Listing 6-2, we have redefined the interaction between the fund manager and the broker
using an asymmetric key. The approach used here is that the individual fund manager generates
both the public and private keys and communicates only the public key to the broker. The broker
maintains a central database where public key information of an individual fund manager is stored.
Now whenever the broker wants to send a contract note to the fund manager, the first step is to retrieve
the correct public key belonging to that particular fund manager and then encrypt the message using
this key. Since you know both the public key and the private key are interrelated and a message
encrypted using the public key can be deciphered only by its private key, this means only the fund
manager will be able to decrypt the message.
The code described in Listing 6-2 has been divided into three phases, starting with generation
of key, and then the encryption phase, and finally the decryption phase. Here is the code that generates
a key pair that in the real world is executed on the fund manager end:
public static void GenerateKeyPair()
{
RSACryptoServiceProvider cryptoProv = new RSACryptoServiceProvider();
string publicKey = cryptoProv.ToXmlString(false);
string privateKey = cryptoProv.ToXmlString(true);
By creating a new instance of RSACryptoServiceProvider, you started your journey into the
asymmetric algorithm world. A parameterless constructor-based instantiation will automatically
generate both the public and private keys. Both these keys’ information is accessible with the help
of the ToXmlString and ExportParameters methods. Even though both methods provide the same
information, their purpose is different. ExportParameters is platform specific, and its usage is lim-
ited to the application level; when information needs to be exchanged across applications that are
hosted on different platforms, then the only platform-neutral format that comes to the rescue is
XML, and ToXmlString achieves it.
Both ExportParameters and ToXmlString expect a Boolean value that controls the amount of
information to be returned. By passing the value true, both public and private keys are exported;
the value false will return only the public key. In Listing 6-2, we have extracted this information
and stored it in a separate variable.
The key information retrieved is finally persisted on disk. PrivateKey.xml contains the public
key as well as the private key, and hence this file needs to be carefully guarded and protected against
falling into the hands of a malicious person. Similarly, PublicKey.xml contains public key informa-
tion and is meant to be distributed to brokers.
StreamWriter writer = new StreamWriter(@"C:\PrivateKey.xml");
writer.Write(privateKey);
writer.Close();
writer = new StreamWriter(@"C:\PublicKey.xml");
writer.Write(publicKey);
writer.Close();C H A P T E R 6 ■ S T P S E C U R I T Y 321
You have completed the key generation phase; next is the encryption stage where the broker
encrypts the message using the fund manager public key:
public static void ContractNoteBroker()
{
Console.WriteLine("Contract Note Encryption Stage - Broker end");
CspParameters param = new CspParameters();
param.Flags = CspProviderFlags.UseMachineKeyStore;
RSACryptoServiceProvider cryptoProv = new RSACryptoServiceProvider(param);
The big difference in the previous line of code is the way an instance of RSACryptoServiceProvider
is created. You already know that during the construction phase, key pairs are automatically generated,
but in the previous code we have overridden this behavior by passing an instance of CspParameters,
which contains cryptographic-specific information.
After successfully creating an instance of RSACryptoServiceProvider, we then initialized with
the public key that is uploaded from a file:
StreamReader reader = new StreamReader(@"C:\PublicKey.xml");
cryptoProv.FromXmlString(reader.ReadToEnd());
Next, the contract note information is converted into a byte array using Encoding:
string contractNote = "<CONTRACTNOTE>"
+"<SYMBOL>MSFT</SYMBOL>"
+"<QUANTITY>100</QUANTITY>"
+"<PRICE>24</PRICE>"
+"</CONTRACTNOTE>";
byte[] contentBuffer = Encoding.ASCII.GetBytes(contractNote);
Here comes the important part of code in which the information that is in byte array form is
encrypted using Encrypt. The encryption is performed using the public key, and the final encrypted
content is returned in the form of a byte array. Encrypt, along with the data that needs to be encrypted,
also accepts additional padding information. The default padding available is PKCS padding and is
used by passing the value false to this method. A value of true indicates a different padding scheme,
which in this case is OAEP padding and is available only on computers running Microsoft Windows
XP or later.
FileStream fileStream = new FileStream(@"C:\ContractNote.enc",FileMode.Create);
byte[] encContent = cryptoProv.Encrypt(contentBuffer ,false);
fileStream.Write(encContent,0,encContent.Length);
fileStream.Close();
Now you step into the last part of this example in which the fund manager decrypts the message
using the private key. This code is now familiar to you; a new instance of RSACryptoServiceProvider
is created, and both public and private keys are initialized:
public static void ContractNoteFM()
{
Console.WriteLine("Contract Note Decryption Stage - Fund Manager end");
CspParameters param = new CspParameters();
param.Flags = CspProviderFlags.UseMachineKeyStore;
RSACryptoServiceProvider cryptoProv = new RSACryptoServiceProvider(param);
StreamReader reader = new StreamReader(@"C:\PrivateKey.xml");
cryptoProv.FromXmlString(reader.ReadToEnd());
reader.Close();322C H A P T E R 6 ■ S T P S E C U R I T Y
Figure 6-18. Console output of a program using the asymmetric key
Let’s assume the broker sends contract note information through some communication medium.
After receiving it, the encrypted information is read and decrypted using the fund manager’s private
key. This is made possible by Decrypt, which accepts two arguments: data that needs to be decrypted
and the padding mode.
FileStream fileStream = new FileStream(@"C:\ContractNote.enc",FileMode.Open);
byte[] readBuffer = new byte[fileStream.Length];
fileStream.Read(readBuffer,0,readBuffer.Length);
byte[] decContent = cryptoProv.Decrypt(readBuffer,false);
string contractNote = Encoding.ASCII.GetString(decContent);
Console.WriteLine(contractNote);
After the successful decryption, the original message is displayed on the console, as depicted in
Figure 6-18.
The example used asymmetric keys to encrypt and decrypt the message. But in reality asymmetric
encryption when performed over large blocks of text is 1,000 times slower than symmetric encryption,
and therefore it is highly unsuitable for encrypting/decrypting a message of a large size. So, the most
well-known technique is to use the best of both asymmetric and symmetric algorithms. For example,
you can slightly tweak the example to generate a symmetric key that is also known as the session key
and use this key to encrypt the contract note information. The advantage gained is faster performance.
After encrypting the message, the next step is to use the asymmetric key to encrypt the session key
and send both the message and encrypted session key to the fund manager. To successfully decrypt
the message, the fund manager must first decrypt the session key using the private key and then
decrypt the encrypted message using the original session key.
Integrity
Data integrity refers to the consistency of data and that its content has not been compromised or
unknowingly altered by an unauthorized user. For example, imagine the consequences if critical
information such as quantity or price is tweaked, and the fund manager, based upon this manipu-
lated information, undertakes some aggressive action that leaves a devastating effect on an entire
business. The most effective way to deal with this problem is to calculate a cryptographic hash of
the information that is also known as a message digest. The way this is calculated depends upon the
underlying hashing algorithm, but in general a variable-length data is passed to a hash algorithm
that then produces a relatively small fixed-size hash value (see Figure 6-19). The value produced is
irreversible in nature and is considered a one-way function because it is impossible to reverse engi-
neer the original message based on just the hash value. Furthermore, two identical inputs will always
produce an identical hash value, but even a difference in bits is sufficient to create a distinct hash
value.C H A P T E R 6 ■ S T P S E C U R I T Y 323
Figure 6-19. Data hashing
Figure 6-20. HashAlgorithm class hierarchy
So, the way the broker achieves data integrity is by calculating a cryptographic hash and send-
ing it along with the original message. The fund manager on receiving it recalculates the hash value
based on the original message received and compares it to the hash value calculated on the broker
end. If there is a discrepancy found, then it confirms the message has been tampered with in transit.
Of course, you can further strengthen this by using a keyed hash algorithm that uses a symmetric
key to encrypt the hash value. The keyed hash algorithm provides both message authenticity and
integrity.
The popular hash algorithms that are provided by the .NET Framework are Message Digest (MD5)
and Secure Hash Algorithm (SHA). The MD5 algorithm produces a 128-bit hash value, whereas SHA
supports 160-, 256-, 384-, and 512-bit hash values. SHA provides the hash size of a different length,
and the greater the length of a hash size, the more difficult it is to break. Figure 6-20 shows the class
layout of hash algorithm classes. HashAlgorithm is the abstract base class that is then derived by
concrete classes.
Listing 6-3 shows the code that is used by the broker to generate a hash value, which is then
verified by the fund manager to ensure that the message has not been tampered with.
Listing 6-3. Hash Value Computed for Contract Note Data
using System;
using System.Text;
using System.Security.Cryptography;324C H A P T E R 6 ■ S T P S E C U R I T Y
Figure 6-21. Console output of hash algorithm program
namespace HashAlgo
{
class Class1
{
static void Main(string[] args)
{
//compute hash using SHA-1
HashAlgorithm hashAlgo = new SHA1Managed();
string contractNote = "<CONTRACTNOTE>"
+"<SYMBOL>MSFT</SYMBOL>"
+"<QUANTITY>100</QUANTITY>"
+"<PRICE>24</PRICE>"
+"</CONTRACTNOTE>";
byte[] contentBuffer = Encoding.ASCII.GetBytes(contractNote);
//compute contract note hash value
byte[] hashedData = hashAlgo.ComputeHash(contentBuffer);
Console.WriteLine("Data Length : " +contentBuffer.Length);
Console.WriteLine("Hashed Data Length : " +hashedData.Length);
}
}
}
As you can see, the code described in Listing 6-3 is pretty straightforward; the only missing
part is that you are not encrypting the hash value, which is ideally done in a realistic scenario. For
demonstration purposes, we have ignored those steps, so it is pretty simple to implement.
In Listing 6-3, a new instance of SHA1Managed is created, and then ComputeHash is invoked to
calculate the hash value. ComputeHash is an overloaded method that accepts either a byte array or
a Stream object and returns a fixed-size byte array. Since this code uses a 160-bit SHA algorithm, it is
obvious that the length of the hash value generated is 20 bytes. All this information is displayed in the
console output window, as shown in Figure 6-21.
Digital Signatures
You looked at how you can use hashing algorithms to achieve integrity; however, when combined
with asymmetric algorithms, you can also use it to create digital signatures of information. Digital
signatures are important aspects of a secure transaction and address authentication, integrity, and
nonrepudiation issues (see Figure 6-22). Both authentication and nonrepudiation are achieved by
asymmetric algorithms, and the integrity of data is achieved with the help of hashing algorithms.
Digital signatures are widely accepted in the commercial world and are one of the formal require-
ments for conducting any type of legal transaction. Additionally, it is also considered to be important
evidence and well respected in a court of law.C H A P T E R 6 ■ S T P S E C U R I T Y 325
Figure 6-22. Digital signature
The first step in digitally signing information is to compute a message digest or hash value of
the original message. The message digest is then encrypted with a private key to create a digital sig-
nature of the information. Remember, digital signatures can be created only by the individual who
is also the sole owner of the private key. Unless the private key is leaked somehow, there is no other
way to construct the digital signature. Both the original message and digital signature are then sent
to recipients. Upon receiving this information, the receiver performs similar steps by first calculating
the hash value of the original message. It is important that both the sender and receiver agree on
common hashing algorithms that are used during the signing and verification stages. The digital
signature is then decrypted by the corresponding public key; if decryption happens successfully,
then it confirms that the message indeed originated from the authentic sender. Next, the decrypted
hash value is then verified with the newly computed hash value; if both hash results differ, then it is
concluded that the information has been tampered with.
The beauty of digital signing is that only the individual who is in possession of the private key
will be able to create signed messages, so attackers can forge it only if they have access to a private
key. An attacker cannot even alter the message because it would need a recomputation of the hash
value. Similarly, a signature, once computed, can be verified by anyone who is in possession of only
the public key, which is made publicly available. Another important fact about digital signatures is
that only the hash value is encrypted, but the information is still retained in its original format. So,
when information secrecy takes higher precedence, it is important to encrypt the message using
symmetric algorithms.
Now let’s look at the requirement where the broker, instead of encrypting the contract note
information, agrees to digitally sign it before sending it to the fund manager. On receiving this infor-
mation, the fund manager verifies it by decrypting the hash value with the broker’s public key and
comparing it with the newly computed hash value. The code implementation is pretty simple and
uses both asymmetric and hash algorithm classes (see Listing 6-4).
Listing 6-4. Signing and Verification of Contract Note Data
using System;
using System.Text;
using System.Security.Cryptography;
namespace DigitalSignature
{
class DigSign
{
static void Main(string[] args)
{
string contractNote = "<CONTRACTNOTE>"
+"<SYMBOL>MSFT</SYMBOL>"
+"<QUANTITY>100</QUANTITY>"
+"<PRICE>24</PRICE>"
+"</CONTRACTNOTE>";
//perform digital signature using RSA326C H A P T E R 6 ■ S T P S E C U R I T Y
RSACryptoServiceProvider rsCrypto = new RSACryptoServiceProvider();
//export of private key
RSAParameters privateRSA = rsCrypto.ExportParameters(true);
//export of public key
RSAParameters publicRSA = rsCrypto.ExportParameters(false);
byte[] contentBuffer = Encoding.ASCII.GetBytes(contractNote);
//compute digital signature of contract note using the broker's private key
byte[] signedData = SignDataBroker(contentBuffer,privateRSA);
//verify digital signature
bool hashResult = VerifySignFM(contentBuffer,signedData,publicRSA) ;
Console.WriteLine ( "Hash Result : " + hashResult);
}
public static byte[] SignDataBroker(byte[] data,RSAParameters privateRSA)
{
//create RSA provider, and initialize it with the broker's private key
RSACryptoServiceProvider rsCrypto = new RSACryptoServiceProvider();
rsCrypto.ImportParameters(privateRSA);
//compute hash value of contract note
HashAlgorithm hashAlgo = new SHA1Managed();
byte[] hashedData = hashAlgo.ComputeHash(data);
//sign hash value using private key
string shaOID = CryptoConfig.MapNameToOID("SHA1");
return rsCrypto.SignHash(hashedData,shaOID);
}
public static bool VerifySignFM(byte[] data,
byte[] signedData,RSAParameters publicRSA)
{
//create RSA provider, and initialize it with the broker's public key
RSACryptoServiceProvider rsCrypto = new RSACryptoServiceProvider();
rsCrypto.ImportParameters(publicRSA);
//recompute hash value of contract note
HashAlgorithm hashAlgo = new SHA1Managed();
byte[] hashedData = hashAlgo.ComputeHash(data);
string shaOID = CryptoConfig.MapNameToOID("SHA1");
//verify the computed hash value with the digital signature
return rsCrypto.VerifyHash(hashedData,shaOID,signedData);
}
}
}
In Listing 6-4, the code has two facets, with the first part covering the digital signing aspect of
a transaction. The final phase is the verification process in which the signature is verified. Both these
functionalities are encapsulated in the SignDataBroker and VerifySignFM methods.
Before invoking SignDataBroker and VerifySignFM, a new instance of RSACryptoServiceProvider
is created that also creates the public and private keys. The key information is then stored in an
instance of RSAParameters. In a real-world scenario, the broker will be in possession of both the
public and private keys, but the fund manager will be aware of only the public key. Therefore, the key
information is exported once with the private key and again without the private key.
In the next step, you invoke SignDataBroker, which mimics the broker end:C H A P T E R 6 ■ S T P S E C U R I T Y 327
public static byte[] SignDataBroker(byte[] data,RSAParameters privateRSA)
{
RSACryptoServiceProvider rsCrypto = new RSACryptoServiceProvider();
rsCrypto.ImportParameters(privateRSA);
HashAlgorithm hashAlgo = new SHA1Managed();
byte[] hashedData = hashAlgo.ComputeHash(data);
string shaOID = CryptoConfig.MapNameToOID("SHA1");
return rsCrypto.SignHash(hashedData,shaOID);
}
The actual message is first flattened into bytes, and then its hash value is computed. The hash
value is then passed to SignHash, which encrypts it with a private key, and the final result, which is the
digital signature of the contract note itself, is returned in a byte array. SignHash accepts additional
mandatory arguments that represent hashing algorithm information. This information cannot be
passed directly; instead, its corresponding object identifier (OID) is supplied, which is located with
the help of the MapNameToOID static method of the CryptoConfig class.
After signing the message, both the contract note information and the digital signature are deliv-
ered to recipients. In this case, the recipient is the fund manager and is mimicked by VerifySignFM:
public static bool VerifySignFM(byte[] data,byte[] signedData,
RSAParameters publicRSA)
{
RSACryptoServiceProvider rsCrypto = new RSACryptoServiceProvider();
rsCrypto.ImportParameters(publicRSA);
HashAlgorithm hashAlgo = new SHA1Managed();
byte[] hashedData = hashAlgo.ComputeHash(data);
string shaOID = CryptoConfig.MapNameToOID("SHA1");
return rsCrypto.VerifyHash(hashedData,shaOID,signedData);
}
The fund manager, upon receiving this message, immediately recomputes the hash value. The
hash value is then verified with the digital signature by calling VerifyHash. During the verification
process, the public key is used to decrypt the digital signature to obtain the original hash value. The
original hash value is then compared with the newly computed hash value, and if both these hashes
match, then it proves that the message indeed came from a legitimate source and that the integrity
of information has not been compromised.
Digital Certificates
The first prerequisite before exchanging digital signature information is communicating the public
key information. This exchange of a public key may happen through multiple sources, such as send-
ing it through e-mail or downloading it from a public Web site. Multiple channels are available, but
each of them gives rise to the problem of how a person is assured that the public key published
belongs to the authentic party. A real-life example that addresses this concern is a passport issued
to a citizen of a country. This passport forms the basis for individuals to prove their identities. Before
issuing the passport to a person, a background check is conducted that includes the investigation
of a criminal record. Such types of procedures are sufficient to create a level of trust. Because every
country in the world honors passports, this provides a means to verify the identity of an individual.
In the digital world, a similar document is required that acts like a digital passport, and this is
where digital certificates are used. Digital certificates prove the identity of an individual or organi-
zation, and they form a strong basis of authentication. The primary purpose of a digital certificate is
to encapsulate the public key information that is then used to verify the digital signature. But how is
it different from transmitting public key information through e-mails or a Web download? The first
difference is that digital certificates are issued by a certificate authority (CA). A CA is an entity that
establishes trust between two parties in a communication chain. The CA fills the needs for a trusted328C H A P T E R 6 ■ S T P S E C U R I T Y
third party in an e-commerce world by verifying the identity of an individual or organization. Even
though the digital certificate issued by a CA is sufficient to assure the authenticity, the important thing
is that the CA must be reliable and well-known in the industry. CAs such as VeriSign and Thawte are
quite popular in the e-commerce world and are the main issuers of digital certificates.
Digital certificates adhere to X.509 format and contain the following important information:
  Name
  Organization
  Serial number
  Validity date
  Public key
  CA name
  CA digital signature
There are no limits on the amount of information that can be embedded into a certificate, but
the most important attribute is a CA digital signature that assures that the owner of the certificate is
in fact who say they are and has been verified by the CA. This signature is the electronic counterpart
to a signature signed by a legal authority on a legal paper. Remember, only the CA can generate the digital
signature because only the CA knows the private key, and for an attacker to impersonate a CA, they
need to have access to the private key. Furthermore, the CA public key is easily accessible, so anyone
can verify the integrity of the certificate before initiating a transaction with the owner of the certificate.
Now it is time to use a digital certificate in the STP world; to keep the example simple and
straightforward, we will rewrite the code described in Listing 6-4. The concept is the same; the only
difference is that the broker’s public key is published using a digital certificate. The information inside
the digital certificate, mainly the public key, is then read by the fund manager to verify the digital
signature of the contract note information received from the broker. Unfortunately, the .NET Frame-
work provides very lean support for dealing with digital certificates. Even though information stored
inside a certificate is readable with the help of the X509Certificate class defined in the System.Security.
Cryptography.X509Certificates namespace, there is no direct way to derive an appropriate crypto-
graphic class that can then verify the digital signature. Considering this drawback, we will introduce
the Web Services Enhancement (WSE) framework that forms an add-on to the .NET Framework. WSE
provides advanced features related to cryptography areas, and one of the important features directly
supported is reading both the certificate and the key information.
The first step is to generate a digital certificate, and in the real world this involves a lot of steps;
for testing purposes, there is a ready-to-use makecert utility, which is a certificate creation tool
available as part of the .NET Framework tools. This utility allows you to create a self-signed certificate
that is used by applications in development environments for testing purposes.
By executing the following command, a test certificate is created and persisted in
C:\BrokerCertificate.cer:
makecert –sk STPKeyStore –a sha1 –r C:\BrokerCertificate.cer
–ss STPCertificateStore –n "CN=Broker A"
The makecert utility includes various options, and discussing each of them is outside the scope
of this chapter. However, the essential information required for certification creation is as follows:
Key container name: The tool by default creates public and private keys and stores them in an
STPKeyStore container. This information is provided with the help of the –sk switch.
Hashing algorithm: The underlying hashing algorithm of a digital signature is specified using
the –a switch.C H A P T E R 6 ■ S T P S E C U R I T Y 329
Figure 6-23. Digital certificate
Certificate store: Certificates are usually managed through a central certificate store. Stores allow
the easy management of certificates and provide functionality to store and retrieve certificates.
This information is provided using the –ss switch.
Certificate subject: The information defined must conform to the X.500 standard.
Figure 6-23 is a graphical representation of a certificate launched by clicking
BrokerCertificate.cer.
The next step is to delve into the actual code that uses the digital certificate depicted in Figure 6-23
to verify the digital signature. Before compiling the code shown in Listing 6-5, ensure that the Microsoft.
Web.Services2 assembly is referenced properly.
Listing 6-5. Signing and Verification of Contract Note Data Using Digital Certificates
using System;
using System.Text;
using System.Security.Cryptography;
using Microsoft.Web.Services2.Security.X509;
namespace DigitalCertificate
{
class DigCert
{
static void Main(string[] args)
{
string contractNote = "<CONTRACTNOTE>"
+"<SYMBOL>MSFT</SYMBOL>"
+"<QUANTITY>100</QUANTITY>"
+"<PRICE>24</PRICE>"
+"</CONTRACTNOTE>";330C H A P T E R 6 ■ S T P S E C U R I T Y
byte[] contentBuffer = Encoding.ASCII.GetBytes(contractNote);
//compute digital signature using the broker's private key
byte[] signedData = SignDataBroker(contentBuffer);
//verify digital signature using the broker's public key
bool hashResult = VerifySignFM(contentBuffer,signedData) ;
Console.WriteLine("Verification Result : " +hashResult);
}
public static byte[] SignDataBroker(byte[] data)
{
//parameters passed to cryptographic service provider
CspParameters param = new CspParameters();
//assign the key store name generated by the makecert tool
param.KeyContainerName = "STPKeyStore";
//use the signature key pair
param.KeyNumber = 2;
//initialize RSA to use private key stored in STPKeyStore
RSACryptoServiceProvider rsCrypto = new RSACryptoServiceProvider(param);
//compute digital signature
return rsCrypto.SignData(data, new SHA1Managed());
}
public static bool VerifySignFM(byte[] data,byte[] signedData)
{
//Open STP certificate store
X509CertificateStore store =
X509CertificateStore.CurrentUserStore("STPCertificateStore");
store.OpenRead();
//retrieve broker certificate
X509Certificate brokerCertificate = store.Certificates[0];
Console.WriteLine("Certificate Subject :" +
brokerCertificate.FriendlyDisplayName);
Console.WriteLine("Valid From :" +
brokerCertificate.GetEffectiveDateString());
Console.WriteLine("Valid To :" +
brokerCertificate.GetExpirationDateString());
Console.WriteLine("Serial No:" + brokerCertificate.GetSerialNumberString());
//initialize RSA to use public key stored in broker certificate
RSAParameters publicParam = brokerCertificate.Key.ExportParameters(false);
RSACryptoServiceProvider rsCrypto = new RSACryptoServiceProvider();
rsCrypto.ImportParameters(publicParam);
//verify digital signature
return rsCrypto.VerifyData(data,new SHA1Managed(),signedData);
}
}
}
The code described in Listing 6-5 is more or less similar to Listing 6-4. Both the signing and
verification tasks are encapsulated inside SignDataBroker and VerifySignFM. Additionally, public
and private keys are already generated using the makecert utility, and therefore you need to ensure
that the appropriate keys are used during the signing and verification phases.
Let’s take a look at the SignDataBroker method. Since asymmetric keys are already generated
and stored in the STPKeyStore container, you directly assign it to the KeyContainerName property of
CspParameters. Then you assign the value 2 to the KeyNumber property, which retrieves the signature
key from the container.C H A P T E R 6 ■ S T P S E C U R I T Y 331
Figure 6-24. Console output describing various field information embedded inside digital certificates
This looks confusing, but the way the underlying cryptographic provider works is that two pairs
of keys are generated. The first pair is known as the exchange key, and the second pair is known as
the signature key. By default, the exchange key is used for encryption unless explicitly specified to
use the signature key. The problem comes during the digital signature verification phase when the
public key is directly read from the digital certificate. The public key embedded inside the digital
certificate belongs to the signature key pair, and if the digital signature is constructed using the exchange
key pair, then the verification of the signature will definitely fail.
Once you have populated CspParameters, you then create a new instance of
RSACryptoServiceProvider. Then the signature of the data is produced using SignData. SignData is
a dual-purpose method that computes the hash value of data and then signs it with the private key
to produce a digital signature.
Now let’s look at the verification process performed on the fund manager end. First, the digital
certificate published by the broker is installed in a certificate store; in this case you have already
installed it in STPCertificateStore, which is the custom certificate store. Then, the certificate store
is accessed using the static CurrentUserStore method of X509CertificateStore, which returns an
instance of X509CertificateStore that allows iterating through all stored certificates.
Then, the broker digital certificate is fetched from the store and is returned in the form of
X509Certificate, which contains essential information about the certificate. The important one is
the public key that is retrieved using the Key property of X509Certificate. This property returns
a ready-to-use instance of RSA that is already populated with the public key published with the cer-
tificate. Remember, all this functionality is available out of the box because of the WSE framework.
It is time to recall the ExportParameters and ImportParameters functionality supported by RSA.
With the help of these methods, you create a new instance of RSACryptoServiceProvider and initialize
it with the public key read from the digital certificate. Then, the digital signature is verified by invoking
VerifyData, which compares the signature by comparing it to the signature computed for the specified
data. Figure 6-24 depicts the output of this example.
Exploring the Business-Technology Mapping
It is clear from the earlier business sections that STP is not an individual effort; instead, to make this
initiative successful, it requires a collective effort from various entities. It is also a major paradigm
shift for the entire securities industry in which entities such as banks, clearing corporations, deposi-
tories, exchanges, brokers, and institutions converge toward one business goal. The goal is to reduce
transaction turn-around time by eliminating tasks that demand manual paperwork or human interven-
tion encountered during trade settlement and processing. STP, if properly planned and implemented,
will revolutionize the securities industry, and the key driving force behind this is a robust and reliable
infrastructure. This infrastructure is provided by the STP service provider that electronically connects
different entities, and information is exchanged using a common, agreed-upon protocol.332C H A P T E R 6 ■ S T P S E C U R I T Y
Figure 6-25. Conceptual design
The biggest challenge faced by a service provider is to safeguard the integrity of information
exchanged between entities. Furthermore, an organization will participate under this STP umbrella
only when various services offered by the service provider are secure and watertight. Therefore, most
providers strongly advocate the use of smart cards and digital certificates that handle both the
authentication and information-signing aspects of a transaction. A smart card is similar to a credit
card and has its own microprocessor and storage disk. The disk capacity of a smart card is limited
but sufficient enough to store private and confidential information. This storage characteristic of
a smart card offers a convenient and secured solution of storing private key information that is read
with the help of a smart card reader attached to a computer.
Although service providers are equipped with a strong infrastructure that tackles all the major
concerns faced in conducting electronic transactions, this addresses external STP and not internal
STP. To achieve internal STP, an organization needs to automate its internal business processes, and
this requires a fair amount of integration-level plumbing among applications, including both home-
grown and vendor-based applications. However, the truth of the matter is that regardless of which
part of STP is automated, there is still a need for a data security framework that must meet the
requirements of both internal and external STP.
The objective of this framework is to have a common security platform that is reused across a vari-
ety of applications inside an organization. Sometimes, the STP service provider bundles this framework
as part of their service offering and allows an organization to integrate it with their internal applica-
tions. Additionally, this framework looks after only the data security aspect of an application; other
features such as user authentication and role-based management that come under the purview of
application security are not implemented. So let’s start with the conceptual design, as depicted in
Figure 6-25, before drilling into the code-level implementation details.
Some of the salient features of this framework are as follows:
  This provides the ability to create a security profile that captures cryptographic-level details
and allows associating this profile with the data that needs to be secured.
  The ability to hide the algorithm level details inside a security profile provides total flexibility
when it comes to changing the implementation.
  Binding between security profiles and data is implemented using a declarative programming
approach.
  This provides a unified API.C H A P T E R 6 ■ S T P S E C U R I T Y 333
Figure 6-26. Security framework class hierarchy
The term data in this context reflects the custom business object, and the field encapsulated
inside it reflects the actual information. It is true that this information eventually needs to be converted
into a suitable format that will be easily transmitted over the wire. But before data transmission takes
place, the serialized data needs to be baked with security ingredients, and this is where you integrate
the data security framework.
As depicted in Figure 6-25, the important part of information that acts as fuel to this framework
is the security profile. There are multiple profiles created based on different types of requirements;
for example, if a fund manager is doing business with broker A and they both agree to use the DES
symmetric algorithm to encrypt/decrypt data, then this information forms a unique profile. If you
extrapolate this scenario where the fund manager is conducting business with ten other brokers and
each of them has distinct requirements, then this will result in the creation of ten additional types of
security profile. Once the profile is set up, the next step is to bind them to the custom business object
using a declarative programming technique. This binding is performed by annotating the class with
security profile attributes.
After the profile binding, the next thing to do is identify the type of data security required. This
means whether data needs to be encrypted (confidential), data needs to be digitally signed (nonre-
pudiation), or data needs to be verified for data integrity. To apply this option, special attributes are
annotated with the class. These special attributes dictate the type of data security required and are
directly related to information embedded inside the profiles. For example, if a class is decorated with
a confidential attribute, then the symmetric algorithm details are determined from the security pro-
file associated with it. This way, an individual will easily infer the security knowledge applied over this
data by looking at the list of attributes annotated with the class. However, attributes are just informa-
tion markers, and they still need to come with the proper implementation. This is where providers
are defined. Providers contain the code that, based on profile information and attributes, performs
the actual cryptographic task. The output produced by this task is a secure envelope that contains
data that is secure and can be safely exchanged with other parties in the communication chain.
Class Details
Figure 6-26 shows the class hierarchy, and Figure 6-27 shows the security framework project structure.
We describe the design approach in terms of the classes introduced in Figure 6-26.334C H A P T E R 6 ■ S T P S E C U R I T Y
Figure 6-27. Security framework project structure
ConfidentialAttribute
Here’s the code for ConfidentialAttribute:
using System;
namespace STP.Security
{
//This attribute is annotated at the class level
//to indicate that data needs to be encrypted
[AttributeUsage(AttributeTargets.Class)]
public class ConfidentialAttribute : Attribute
{
public ConfidentialAttribute()
{
}
}
}
This attribute indicates that data needs to be encrypted using appropriate symmetric algorithms
as described in the data security profile. It is annotated at the class level. Similarly, the integrity of
data and nonrepudiation are achieved using IntegrityAttribute and NonRepudiationAttribute.
IntegrityAttribute
Here’s the code for IntegrityAttribute:
using System;
namespace STP.Security
{
//This attribute is annotated at the class levelC H A P T E R 6 ■ S T P S E C U R I T Y 335
//to indicate data needs to be protected by
//computing a strong hash value
[AttributeUsage(AttributeTargets.Class)]
public class IntegrityAttribute : Attribute
{
public IntegrityAttribute()
{
}
}
}
NonRepudiationAttribute
Here’s the code for NonRepudiationAttribute:
using System;
namespace STP.Security
{
//This attribute is annotated at the class level
//to indicate data needs to be protected by
//applying a digital signature algorithm
[AttributeUsage(AttributeTargets.Class)]
public class NonRepudiationAttribute: Attribute
{
public NonRepudiationAttribute()
{
}
}
}
SecurityProfileAttribute
Here’s the code for SecurityProfileAttribute:
using System;
namespace STP.Security
{
//The information about cryptography implementation
//used to achieve data integrity, nonrepudiation, and confidential
//is stored in a XML file or database and is identified
//by profile name
[AttributeUsage(AttributeTargets.Class)]
public class SecurityProfileAttribute : Attribute
{
private string profileName;
public SecurityProfileAttribute(string name)
{
profileName=name;
}
public string Profile
{
get{return profileName;}
}
}
}336C H A P T E R 6 ■ S T P S E C U R I T Y
This is the most important attribute that is annotated on the class to capture the data security
profile information. It is a mandatory attribute because as you are aware the profile information not
only contains implementation-level algorithm information but also the source information of vari-
ous cryptographic keys.
ContractNoteInfo
Here’s the code for ContractNoteInfo:
using System;
namespace STP.Security
{
//A perfect example of applying cryptography infrastructure
//to contract note data. The important information required
//is profile name and type of protection we wanted to apply
//to this data. In this case we have expressed data needs
//to be digitally signed by annotating the NonRepudiation attribute.
[SecurityProfile("BrokerA")]
[NonRepudiation]
[Serializable]
public class ContractNoteInfo
{
public string Symbol;
public int Quantity;
public double Price;
public ContractNoteInfo(string symbol,int quantity,double price)
{
Symbol = symbol;
Quantity = quantity;
Price = price;
}
}
}
This is an object-oriented representation of a contract note, and as you can see, it is annotated
with NonRepudiation so the digital signature is computed based on the information encapsulated
inside this class. Additionally, with the help of SecurityProfile, it also mentions the data security
profile information to be used.
ProfileInfo
Here’s the code for ProfileInfo:
using System;
namespace STP.Security
{
public enum IntegrityAlgo
{
SHA1,
MD5
}
public enum ConfidentialAlgo
{
DES,C H A P T E R 6 ■ S T P S E C U R I T Y 337
Rijndael
}
//This class represents object-oriented representation
//of security profile information stored in XML configuration
//or database
public class ProfileInfo
{
IntegrityAlgo integrityAlgo;
ConfidentialAlgo confidentialAlgo;
string nonRepKeyPath;
string profileName;
public IntegrityAlgo Integrity
{
get{return integrityAlgo;}
}
public ConfidentialAlgo Confidential
{
get{return confidentialAlgo;}
}
public string ProfileName
{
get{return profileName;}
}
public string NonRepudiationKeyPath
{
get{return nonRepKeyPath;}
}
public ProfileInfo(ConfidentialAlgo confalgo,
IntegrityAlgo intalgo,string nonrepKey)
{
confidentialAlgo=confalgo;
integrityAlgo=intalgo;
nonRepKeyPath= nonrepKey;
}
}
}
This class provides information about various algorithms to be used that includes the hashing
algorithm (integrity), the symmetric algorithm (confidential), and the digital signature algorithm
(nonrepudiation). The information is populated from an XML-based configuration file or relational
database system. However, in a real-life scenario there is more information to be captured, such as
the cryptographic keys container name, certificate information, and so on; to keep the example simple,
we have ignored all those aspects.
SecureEnvelope
Here’s the code for SecureEnvelope:
using System;
using System.Collections;338C H A P T E R 6 ■ S T P S E C U R I T Y
namespace STP.Security
{
[Serializable]
//This class holds data produced by
//applying cryptographic transformation on original data
public class SecureEnvelope
{
string profileName;
Hashtable sectionList = new Hashtable();
public Hashtable Sections
{
get{return sectionList;}
}
public string Profile
{
get{return profileName;}
}
public SecureEnvelope(string profile)
{
profileName=profile;
}
}
}
SecureEnvelope is the object-oriented form of the envelope mentioned in Figure 6-25. The
body of this envelope is built by combining sections, and each individual section represents
information that is produced as a result of a provider-level transformation. For example, when
ConfidentialAttribute and NonRepudiationAttribute are applied over ContractNoteInfo, then two
types of information are generated. The first one is the encrypted content, and the second one is the
digital signature. Both types of information are distinct and are constructed by different underlying
providers; it is only during the consolidation phase that they are packaged inside a single envelope
but internally separated in the form of a section.
SectionData
Here’s the code for SectionData:
using System;
namespace STP.Security
{
//Secure envelope is composed of multiple sections,
//and each section is represented by this class.
//For example, if a data supports both encryption and
//a digital signature, then it will produce different output,
//and both these outputs will be stored in a distinct
//section of an envelope.
[Serializable]
public class SectionData
{
public byte[] secData;C H A P T E R 6 ■ S T P S E C U R I T Y 339
public byte[] Data
{
get{return secData;}
}
public SectionData(byte[] data)
{
secData=data;
}
}
}
SectionData represents a section of the secure envelope body.
NonRepudiationSection
Here’s the code for NonRepudiationSection:
using System;
namespace STP.Security
{
public class NonRepudiationSection : SectionData
{
byte[] signature;
public NonRepudiationSection(byte[] data,byte[] hashedData)
:base(data)
{
signature = hashedData;
}
public byte[] Signature
{
get{return signature;}
}
}
}
NonRepudiationSection is subclassed from SectionData to capture additional provider-specific
information. This provider-specific information is none other than the digital signature.
Provider
Here’s the code for Provider:
using System;
namespace STP.Security
{
//This class represents an abstract implementation
//of various cryptographic features the framework
//is going to support.
public abstract class Provider
{
ProfileInfo profileInfo;340C H A P T E R 6 ■ S T P S E C U R I T Y
public Provider(ProfileInfo profile)
{
profileInfo = profile;
}
//crytographic transformaton of outgoing data
public abstract void Create(byte[] originalData,SecureEnvelope envelope);
//crytographic transformaton of incoming data
public abstract bool Verify(SecureEnvelope envelope);
}
}
As you can see, Provider is declared as an abstract base class that is then inherited by concrete
providers that provide a correct implementation for security attributes defined at the class level. In the
same way, this abstract class is also given complete access to the underlying security profile information.
The two most important methods are Create and Verify. Create is invoked to construct a new cryp-
tographic message that is derived from the original message; similarly, Verify is invoked to verify or
unpack the message.
It is apparent that the number of concrete providers will be equal to the number of security
attributes supported. But for demonstration purposes, we have supplied concrete providers only for
NonRepudiationAttribute, which is explained in a moment.
NonRepudiationProvider
Here’s the code for NonRepudiationProvider:
using System;
using System.IO;
using System.Security.Cryptography;
namespace STP.Security
{
//Digital signature implementation
public class NonRepudiationProvider : Provider
{
RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider();
public NonRepudiationProvider(ProfileInfo profile)
:base(profile)
{
//Read digital certificate information
StreamReader reader = new StreamReader(profile.NonRepudiationKeyPath);
string xmlContent = reader.ReadToEnd();
rsaProvider.FromXmlString(xmlContent );
reader.Close();
}
public override void Create(byte[] originalData,SecureEnvelope envelope)
{
//create signature
byte[] signedData = rsaProvider.SignData(originalData,new SHA1Managed());
//insert digital signature in secure envelope
envelope.Sections.Add(typeof(NonRepudiationAttribute).ToString(),
new NonRepudiationSection(originalData,signedData));
}C H A P T E R 6 ■ S T P S E C U R I T Y 341
public override bool Verify(SecureEnvelope envelope)
{
//extract digital signature from secure envelope
NonRepudiationSection nonrepSection =
envelope.Sections[typeof(NonRepudiationAttribute).ToString()] as
NonRepudiationSection;
//verify digital signature
return rsaProvider.VerifyData(nonrepSection.Signature,
new SHA1Managed(),nonrepSection.Data);
}
}
}
The name itself indicates the functionality of this class, and it addresses the nonrepudiation
aspect by creating and verifying the digital signature. Both these requirements are encapsulated in
the Create and Verify methods. The most important line of code is the way the digital signature is
created and then encapsulated inside an instance of NonRepudiationSection and then finally appended
to SecureEnvelope. Similarly, in Verify the digital signature is verified by fetching the correct section
from SecureEnvelope. The result of this verification is then returned to the caller.
DataSecurityManager
Here’s the code for DataSecurityManager:
using System;
using System.Collections;
namespace STP.Security
{
//Class responsible for loading security profiles
//from XML configuration file or database
public class DataSecurityManager
{
Hashtable profileCollection = new Hashtable();
public DataSecurityManager()
{
profileCollection["BrokerA"] = new ProfileInfo(ConfidentialAlgo.Rijndael,
IntegrityAlgo.SHA1,@"C:\PubPrivKey.txt");
}
public Hashtable Profiles
{
get{return profileCollection;}
}
public DataSecurity Secure(Type objType)
{
return new DataSecurity(this,objType);
}
}
}342C H A P T E R 6 ■ S T P S E C U R I T Y
This class is exposed to the external world, and it is a gateway through which the initialization of
the security framework is performed. The first step is to initialize security profile information, and
in this case we have hard-coded it; however, remember in the real world it is usually populated from
an XML configuration file or database. Next, the most important method is Secure, which accepts the
type as a method argument and returns a new instance of DataSecurity.
DataSecurity
Here’s the code for DataSecurity:
using System;
namespace STP.Security
{
//Orchestrates the cryptography process
public class DataSecurity
{
Type objType;
DataSecurityManager securityMgr;
Provider nonrepProvider;
bool isConfidential;
bool isNonRepudiation;
bool isIntegrity;
ProfileInfo profInfo;
public DataSecurity(DataSecurityManager mgr, Type type)
{
objType = type;
securityMgr=mgr;
ExtractAttributes();
}
private void ExtractAttributes()
{
//Retrieve the security profile attribute
//to retrieve the name of the profile
object[] attributes =
objType.GetCustomAttributes(typeof(SecurityProfileAttribute),true);
SecurityProfileAttribute profAttr = attributes[0] as
SecurityProfileAttribute;
profInfo= securityMgr.Profiles[profAttr.Profile] as ProfileInfo;
//Check for confidential attribute
attributes =
objType.GetCustomAttributes(typeof(ConfidentialAttribute),true);
isConfidential = (attributes.Length == 0 ? false : true);
//Check for nonrepudiation attribute
attributes =
objType.GetCustomAttributes(typeof(NonRepudiationAttribute),true);
isNonRepudiation = (attributes.Length == 0 ? false : true);
//Check for integrity attribute
attributes = objType.GetCustomAttributes(typeof(IntegrityAttribute),true);
isIntegrity = (attributes.Length == 0 ? false : true);C H A P T E R 6 ■ S T P S E C U R I T Y 343
//Instantiate the nonrepudiation provider
//and pass on the profile information
nonrepProvider = new NonRepudiationProvider(profInfo);
}
public SecureEnvelope Create(byte[] data)
{
//Create a new secure envelope
SecureEnvelope envelope = new SecureEnvelope(profInfo.ProfileName);
//Based on attribute declared, we instantiate
//appropriate provider
if ( isNonRepudiation == true )
nonrepProvider.Create(data,envelope);
return envelope;
}
public bool Verify(SecureEnvelope envelope)
{
//invoke the appropriate provider to verify data
return nonrepProvider.Verify(envelope);
}
}
}
This class implements the core logic, which includes extracting security-related attributes from
a type, instantiating the appropriate provider, and finally providing a way to construct or verify
cryptographic messages.
Code Example
The following code demonstrates the usage of a security framework:
using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
namespace STP.Security
{
class CodeExample
{
static void Main(string[] args)
{
//An instance of ContractNoteInfo is created.
ContractNoteInfo noteInfo = new ContractNoteInfo("MSFT",100,24);
//ContractNoteInfo is decorated with the Serializable attribute,
//so the entire object graph with help of BinaryFormatter is
//flattened into raw bytes, and this task is achieved by
//with the help of the SerializeContractNote method
byte[] data = SerializeContractNote(noteInfo);//Generate public and private key for demonstration purpose
GenerateKey();
//Security Framework is initialized, a new instance of DataSecurity
//is created, and this instance returned by DataSecurityManager
//is exclusively meant for instances of ContractNoteInfo. This
//behavior is similar to XmlSerializer where there exists strong
//coupling between an object instance and the type associated with it.
DataSecurityManager secMgr = new DataSecurityManager();
DataSecurity dataSec = secMgr.Secure(typeof(ContractNoteInfo));
//The serialized byte array of ContractNoteInfo is then passed to
//Create method of DataSecurity that is then handed internally to
//NonRepudiationProvider, which creates a digital signature and
//associates it with SecureEnvelope. Also, the secure envelope itself
//is marked serializable so its entire object graph itself can now
//be serialized and transmitted over the wire.
SecureEnvelope secureEnvelope = dataSec.Create(data);
}
public static void GenerateKey()
{
RSACryptoServiceProvider rsaCrypto = new RSACryptoServiceProvider();
string pubprivKey = rsaCrypto.ToXmlString(true);
StreamWriter writer = new StreamWriter(@"C:\PubPrivKey.txt");
writer.WriteLine(pubprivKey);
writer.Close();
}
public static byte[] SerializeContractNote(ContractNoteInfo noteInfo)
{
MemoryStream memStream = new MemoryStream();
BinaryFormatter binaryFormatter = new BinaryFormatter();
binaryFormatter.Serialize(memStream,noteInfo);
int dataLength = (int)memStream.Length;
byte[] data = new byte[dataLength];
memStream.Position = 0;
memStream.Read(data,0,dataLength);
memStream.Close();
return data;
}
}
}
Summary
The following are the salient features covered in this chapter:
  We explained the various business entities involved in STP and how essential it is to secure
information exchanged between them in order to gain credibility and acceptance of STP.
  We highlighted the role played by the STP service provider in bringing all business entities to
a common platform.
  We briefly discussed the fundamental concepts of cryptography and also covered cryptography
terminology.
344C H A P T E R 6 ■ S T P S E C U R I T YC H A P T E R 6 ■ S T P S E C U R I T Y 345
  We explained both symmetric and asymmetric algorithms and how they can be used to protect
the confidential aspect of data.
  We demonstrated how integrity of data is achieved by calculating a cryptographic hash value
that is irreversible in nature.
  We introduced the concept of digital signatures that address nonrepudiation issues encoun-
tered in a high-risk transaction.
  We explained that the support of digital certificates in the STP world will act as a digital passport
to verify an individual business identity.
  We covered how the prototype of a security framework is implemented and is based on
a declarative programming approach to secure information.C H A P T E R 6 ■ S T P S E C U R I T Y 345
  We explained both symmetric and asymmetric algorithms and how they can be used to protect
the confidential aspect of data.
  We demonstrated how integrity of data is achieved by calculating a cryptographic hash value
that is irreversible in nature.
  We introduced the concept of digital signatures that address nonrepudiation issues encoun-
tered in a high-risk transaction.
  We explained that the support of digital certificates in the STP world will act as a digital passport
to verify an individual business identity.
  We covered how the prototype of a security framework is implemented and is based on
a declarative programming approach to secure information. ture and
//associates it with SecureEnvelope. Also, the secure envelope itself
//is marked serializable so its entire object graph itself can now
//be serialized and transmitted over the wire.
SecureEnvelope secureEnvelope = dataSec.Create(data);
}
public static void GenerateKey()
{
RSACryptoServiceProvider rsaCrypto = new RSACryptoServiceProvider();
string pubprivKey = rsaCrypto.ToXmlString(true);
StreamWriter writer = new StreamWriter(@"C:\PubPrivKey.txt");
writer.WriteLine(pubprivKey);
writer.Close();
}
public static byte[] SerializeContractNote(ContractNoteInfo noteInfo)
{
MemoryStream memStream = new MemoryStream();
BinaryFormatter binaryFormatter = new BinaryFormatter();
binaryFormatter.Serialize(memStream,noteInfo);
int dataLength = (int)memStream.Length;
byte[] data = new byte[dataLength];
memStream.Position = 0;
memStream.Read(data,0,dataLength);
memStream.Close();
return data;
}
}
}
Summary
The following are the salient features covered in this chapter:
  We explained the various business entities involved in STP and how essential it is to secure
information exchanged between them in order to gain credibility and acceptance of STP.
  We highlighted the role played by the STP service provider in bringing all business entities to
a common platform.
  We briefly discussed the fundamental concepts of cryptography and also covered cryptography
terminology.
344C H A P T E R 6 ■ S T P S E C U R I T Y  attributes are just informa-
tion markers, and they still need to come with the proper implementation. This is where providers
are defined. Providers contain the code that, based on profile information and attributes, performs
the actual cryptographic task. The output produced by this task is a secure envelope that contains
data that is secure and can be safely exchanged with other parties in the communication chain.
Class Details
Figure 6-26 shows the class hierarchy, and Figure 6-27 shows the security framework project structure.
We describe the design approach in terms of the classes introduced in Figure 6-26. ties. It is also a major paradigm
shift for the entire securities industry in which entities such as banks, clearing corporations, deposi-
tories, exchanges, brokers, and institutions converge toward one business goal. The goal is to reduce
transaction turn-around time by eliminating tasks that demand manual paperwork or human interven-
tion encountered during trade settlement and processing. STP, if properly planned and implemented,
will revolutionize the securities industry, and the key driving force behind this is a robust and reliable
infrastructure. This infrastructure is provided by the STP service provider that electronically connects
different entities, and information is exchanged using a common, agreed-upon protocol. h.
Hashing algorithm: The underlying hashing algorithm of a digital signature is specified using
the –a switch. ate authority (CA). A CA is an entity that
establishes trust between two parties in a communication chain. The CA fills the needs for a trusted  the fund’s objectives. This alignment, realignment,
and fund manager’s changing perception of a stock’s value causes the purchase and sale of shares.
The sales desk staff of brokering companies looking for business also engages fund managers and
discusses the market trends and direction. They also discuss investment as well as divestment opportu-
nities. Normally such discussions result in the fund managers giving orders to buy or sell one or more
securities. t that we will not cover is the GUI portion of the application operation engine.
But once you get a strong understanding of the components implemented in the operation engine,
then it is just a question of invoking the appropriate calls from the GUI. Then, the rest of the job is
performed by the primary controller and the agents.
Class Details
In this section, you will develop a scaled-down version of an application operation engine. Although
it will not support all the operational features, the motive is to prove that remoting is an ideal fit for
building these kinds of monitoring applications. However, keep in mind that because the monitoring s to take proactive steps for managing and minimizing risk, especially when the market is
volatile. Sophisticated risk management techniques such as Value at Risk use the data about prices
174C H A P T E R 4 ■ T H E B R O A D C A S T E N G I N E                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    