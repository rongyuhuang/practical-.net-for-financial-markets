# 权益类资产套利 Equity Arbitrage
Dreams are the user interfaces of our goals.
In this chapter, we will explain the economics behind the arbitrage business. Arbitrage is a trading
tactic exploited to make profits based on the price differences of stock quotes at two or more
exchanges. The business-related sections of this chapter explain that price differences of stocks in
multiple exchanges are not sufficient to determine profitability; instead, additional procedures are
performed to arrive at a final decision. This chapter covers those additional steps. In the technical
sections, we explain code-generation concepts and then provide comprehensive coverage of the
CodeDOM framework. We also provide an outlook on .NET reflection features. This chapter is dif-
ferent from other chapters covered so far where we implemented a small prototype of the business
framework; here we will skip the implementation part because it requires a considerable amount
of effort that is simply outside the scope of this book. But our primary goal is to arm you with code-
generation tactics that will help you automate most of the redundant tasks and also establish a strong
foundation in building sophisticated arbitrage rule engines.
Introducing Arbitrage
Arbitrage is technically defined as profiting by buying something that is selling cheaper in one
market and selling it simultaneously in another market where it is selling higher. A person who does
arbitrage is called an arbitrageur.
Thus, every arbitrage has a buy leg and a sell leg, and in almost all cases they are executed simul-
taneously. The attempt is to lock and make profit on the price differential that the stock quotes at in
two or more exchanges. Arbitrages can range from simple to complex. For the purposes of this chapter,
we will discuss only the simple arbitrage strategy that involves equities traded on stock exchanges.
Assume an arbitrageur specializes in arbitrage in Advanced Micro Devices (AMD) shares. AMD
shares would normally be quoting at the same price; assume it’s trading at $40 in all exchanges where
it trades. For some reason—say because of excessive demand in one of the exchanges—the price hits
$40.25 while it continues to trade at $40 on all other exchanges. The arbitrageur tracking AMD will
immediately buy AMD shares from exchanges where it is still quoting at $40 and sell an equal quantity
of shares in the exchange where it is quoting at $40.25. By executing these two transactions simulta-
neously, the arbitrageur will make a neat profit of 25 cents per share.
However, even a price differential of $0.25 as cited in this example is rare, especially for highly
liquid stocks. When price differentials arise in markets because of skewed demand or supply in one
of the markets, arbitrageurs start selling where demand is more and start buying where demand is
less, which in the process causes the prices to stabilize and makes them equal at both places.
403404C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
Arbitrage is just another way of making money for market participants just as they make money
using trades and investments. In fact, certain professionals specialize in making money only through
arbitrage. Arbitrage opportunities in financial markets are rare; hence, specialized skills and special-
ized computer software are required to exploit them. Technically, regular retail investors can do
arbitrage, but because of limited skill sets and limited capital, they are not exactly the right people
to get into arbitrage. Arbitrageurs normally score over retail investors on arbitrage because of the
following reasons:
They possess far more trading skill: They understand the markets well and understand the
economics behind the price differentials. Sometimes price differentials are because of some
genuine reason, and they will never converge. Lay traders would be lulled into believing that
an arbitrage opportunity exists where actually there isn’t any. Skilled arbitrageurs understand
the precise risks associated and have access to vast pools of money and securities.
They have access to real-time information on multiple markets: The arbitrage business is all about
cashing in on market opportunities fast. Difference in prices really don’t exist for a long time,
and they get bridged very fast—in fact, in a matter of subseconds. If real-time access to market
data is not available, it is impossible to make decisions relating to arbitrage. Often, retail investors
don’t get ready access to real-time market data. Those retail investors who have regular jobs
don’t have the inclination to monitor the market on a subsecond basis. The arbitrage business
has thus remained confined to arbitrage specialists.
They have complex trading software: Since price differentials are rare and the numbers of scrips
listed on exchanges are high, arbitrageurs depend upon special arbitrage software that scours
market data from each exchange of the arbitrageur’s interests and keeps posting arbitrage
opportunities. Either arbitrageurs act on these opportunities directly or they make the arbitrage
systems interface with program trading systems that generate buy and sale orders automatically
whenever arbitrage opportunities arise.
Costs Involved in Arbitrage Transactions
All transactions involve costs. If a transaction takes place through a broker, it involves brokerage.
Otherwise, depending on the regulations, transactions include turnover taxes, transaction taxes,
and clearing and settlement fees just as they are levied on any normal transaction. These are direct
costs while doing any transaction. Then there are some indirect costs associated with such transac-
tions. In the context of arbitrage, the biggest indirect cost involved is the interest cost involved in
taking such arbitrage positions. One leg of arbitrage is a buy transaction. To execute such buy trans-
actions, traders are required to pay margins and in some cases the full value of the transaction. If
they pay the full value, a cost is associated with paying such money to the clearing corporation in
the form of interest the money would have otherwise earned if it were simply kept in a bank fixed
deposit. This interest is one component of the cost in arbitrage.
Similarly, the sale leg of the transaction has two scenarios. Either the arbitrageurs may have the
securities with them for delivery or they may not. If they have the deliveries, they can deliver them
at the time of pay-in. But if the arbitrage transaction is not completed and the arbitragers don’t even
have shares, they will have to borrow shares either privately or through established stock-lending
facilities. Stock lending is a facility where shares can be borrowed just like money by paying interest.
Institutions and individuals who have surplus shares try to generate interest income by lending their
shares to the general public and trading fraternities that are in need of these shares to meet their deliv-
ery obligations. Arbitrageurs whose positions result in delivery to clearing corporations may utilize
this facility by paying interest to the lender and using the securities for meeting delivery obligations.
The interest they pay adds to their total arbitrage costs.
The cost involved in any arbitrage will thus be as follows:
Arbitrage costs = Direct transaction costs + Interest costs on buy leg + Interest costs on sale legC H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 405
It follows that arbitrages will be profitable only if the profit from the difference in the prices of
the security at two places exceeds the cost of arbitrage. Otherwise, the arbitrage will be unviable. In
this chapter, we will refer to these costs as arbitrage cost and interest cost.
In the earlier AMD example, $0.25 is the profit per share that the arbitrageur is making. However,
this is the theoretical profit. In reality, several costs are associated with arbitrage. The arbitrageur will
have to bear the transaction costs and will have to deliver shares in one exchange and receive shares
from another exchange. There is a high chance that these will not be the same set of shares. Hence,
to meet the payment commitment on one exchange and the delivery commitment on another, the
arbitrageur will have to deploy cash on the exchange where the buy transaction was routed and give
shares where they were sold (at the time of pay-in), and he will have to receive shares from the exchange
where they were purchased and receive cash from where the shares were sold (at the time of pay-out).
Hence, this implies that the arbitrageur will have to maintain an inventory of cash as well as AMD
shares to complete this kind of transaction. Holding both cash and shares will involve interest cost.
Cash is normally available to such operators usually in unlimited supply (limited by interest payment
ability). Shares are in short supply because they are limited in numbers. Such arbitrage strategy will
hence become dangerous if shares are in limited supply. Usually, a good stock-lending mechanism
needs to be in place if these strategies have to be resolved.
Arbitrage and related operations have been criticized severely in the past, and many market
crashes have been attributed to the orders that have been generated automatically by their systems.
However, arbitrageurs benefit the market overall by bringing about liquidity where there is less liq-
uidity and by helping to stabilize prices.
Other Forms of Arbitrage
In the previous examples, the arbitrage discussed is for the same security. However, arbitrage may
happen on securities or assets that are either directly or inversely correlated with each other. Because
of the scope of this book, we will limit this discussion only to equities shares. For example, assume
there are two classes of shares issued by a company. Their prices must ideally move in tandem.
Berkshire Hathaway, for example, has two classes of stocks: Class A and Class B (listed as BRKA and
BRKB on the NYSE). A share of Class B common stock has 1/30th the right of a Class A stock. Holders
of Class A shares have the option of converting the stock to Class B shares at their discretion. Hold-
ers of Class B shares cannot get their shares converted to Class A. The ratio of rights implies that
Class B shares can never trade above a tiny fraction of 1/30th the price of a Class A share. Whenever
the price differential exceeds 1/30th, arbitrageurs get active selling Class B stock and buying Class A
stock, and this in turn pushes the prices of Class B stock back to 1/30th of the price of the Class A stock.
Another interesting issue applies here. Since Class B shares don’t hold the right to get their shares
converted into Class A shares, this implies that holders of Class B shares are at a disadvantage com-
pared to holders of Class A shares. This phenomenon may at times cause Class B shares to quote at
a discount to the usual 1/30th of the price of Class A shares. However, if the discount becomes too
large, once again the arbitrageurs will get active and bring the price differential close to 1/30th of
the price of Class A shares.
Table 8-1 shows the prices of Class A stock and Class B stock of Berkshire Hathaway.
Table 8-1. Prices of Class A and Class B Stocks of Berkshire Hathaway
Name Symbol Closing Price
Berkshire Hathaway BRKA $84,375
Berkshire Hathaway BRKB $2,807406C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
Here’s the price ratio:
Price ratio = 843,75 / 2,807 = $30.05
Thus, you can see that the price of Class B stock is almost equal to 1/30th of the price of Class A
stock.
This discussion showed a case of near-perfect price correlation between the two stocks. Arbitrage
can also take place on stocks that are not perfectly correlated with each other. Correlation in prices
means the prices of both move in tandem; a perfect positive correlation would mean that if one
stock rises x percent, then the other stock will also rise by the same x percent. A negative correlation
means the prices of both stocks are inversely related to each other. A perfect negative correlation
would mean that if the price of one stock rises by x percent, then the price of other stock will fall by
x percent. Stocks of different companies operating in the same economic environment could have
prices heavily correlated to each other. An example is a company that mines and produces gold and
a company that produces and sells gold jewelry. A large component of the value of stocks of these
two companies (and hence the price) would be coming from the inventory of gold that both com-
panies would be holding. The direction of the trend of the prices would be weighed heavily in favor
of the direction of gold prices. In other words, the prices of both stocks would rise when gold prices
rise, and the prices of both stocks would fall when prices of gold fall. A good demand of jewelry in
the market would mean fortune for both companies. Arbitrageurs following both these stocks would
be aware of the degree of correlation between the prices of stocks of both companies. When the prices
of these two companies deviate from each other beyond the usual degree of correlation and arbi-
trageurs are convinced that this price variation cannot be attributed to other economic factors
affecting the companies in isolation, they would get into it through arbitrage. This arbitrage will
push the prices of both stocks toward the usual correlation between them.
Some arbitrage takes place because of takeovers and the fixing of swap ratios. Say, for example,
company A is of interest to company B. Company A is quoting at $50. Company B thinks this price is
not a reflection of its fair value, and it wants to acquire company A, maybe because of strategic reasons.
Company B now makes an open offer to shareholders of company A to purchase shares of company
A for $60 per share. In this case, the market prices will rise, but it may not touch $60 (because of the
implicit fear that the takeover might fail). Assume it rises to $55. There is still a differential of $5. Any
trader can now buy company A shares from the market at $55, wait for some time, and sell them to
company B at $60 a share. However, traders encounter two risks here. One, which we have noted, is
the risk that the takeover may not succeed. Such takeovers are subject to shareholder and regulator
approval, and the risk that the takeover will not succeed is very high. Second, a longer-than-expected
waiting period could take place. These bids go through a lot of pricing, repricing, and negotiations,
which may take time.
Pure and Speculative Arbitrage
Arbitrage can be loosely divided into pure arbitrage and speculative arbitrage.
Pure arbitrage is where the arbitrageurs take a position, expecting prices to return to their fair
values. The fair value is the inherent value of the stock around which the market price must be quoted.
When a security trades at more than the fair value for some time, chances are high it will return to
its fair value. Similarly, when it has been trading at less than the fair value for a long time, chances
are its prices will rise. Arbitrageurs bet on this fact, and such arbitrage is pure arbitrage. An example
of fair-value arbitrage is in the arbitrage of Class A and Class B securities of Berkshire Hathaway.
Assume the price today of a Class A share is $84,375 and the price of a Class B share is $2,815. The
ratio discussed earlier of 1:30 indicates that the price of a Class A share should not be lower than
$2,815 × 30 = $84,450. This means that either Class A shares are undervalued or Class B shares are
overvalued. Traders investing in either of the stocks would be concerned to know whether a stock is
genuinely underpriced, overpriced, or correctly priced. An arbitrageur, on the other hand, works
only on the price differential. Hence, this issue will not bother the arbitrageurs much. They willC H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 407
simply buy a Class A stock at $84,375 and sell 30 shares of Class B stocks at $2,815 each. The two
positions completely hedge each other so there is not much of a price risk in this arbitrage. They
will wait for some time for the price ratio to hit 1:30 exactly. This phenomenon of prices returning to
their expected ratios is called a convergence of prices. Once such a price is reached, the arbitrageur
will quickly sell one Class A share and buy 30 Class B shares. This will close out their original arbitrage
position (this action is called winding up the arbitrage) and generate profits for them. This type of
arbitrage involving the simultaneous buy and sale of stocks that are highly correlated is covered (the
effect of the price rise/decline in one is offsetting the other) and is therefore not very risky in the long
term.
Speculative arbitrage is an arbitrage where the value of the hedge portfolio is not stationary.
This essentially means there is no fair value where the value of the portfolio is expected to converge.
The fair value estimate itself changes with time and in the environment under which the security
trades. Speculative arbitrage is considered risky in the long run because there is no fair value around
which the conversion will take place. Examples of speculative arbitrage include spreads, pair trading,
and risk arbitrage. Discussing these types of arbitrage is beyond the scope of this book.
Risks Associated in Arbitrage
Making money through arbitrage looks simple. However, it is one of the most risk-prone ways of
making profits. Arbitrageurs face several risks in implementing their arbitrage strategies. Some
of these are basis risk, model risk, and arbitrage cost risk.
Basis is the net difference in prices of the two stocks when the arbitrage is done. If a stock is
trading at $40 on one exchange and $40.10 on another exchange, the difference between the two
($0.10) is the basis. When an arbitrageur sells at $40.10 and buys simultaneously at $40, she assumes
that the price difference will converge, and she will reverse the deals to pocket the difference. If the
arbitrageur does not have much ability to carry forward the transaction, she will look forward to
reversing the transaction as early as possible. It could, however, be that instead of prices converging,
they diverge further and become $40 and $40.20. If the arbitrageur does not have the ability to carry for-
ward the positions to the next day, she will have to close the transaction by selling at $40 and buying
at $40.20. She will lose $0.10 in this entire arbitrage. The risk that the arbitrage position will move against
the arbitrageur and prices will not converge as expected is called basis risk. In the Berkshire Hathaway
example, the arbitrageur bought a Class A stock at $84,375 and sold 30 shares of Class B stocks at
$2,815 each. He is expecting the prices to converge to a 1:30 ratio. There is a remote chance that this
conversion might never take place. The prices could even diverge more. The conversion may finally
happen sometime but may not be before the settlement comes. Both the transactions will then have
to be settled individually by paying cash to take delivery on one exchange and deliver shares and
receive cash on the other exchange. In such cases, the arbitrageur faces basis risk because the basis
has gone against him.
Sometimes arbitrageurs have not understood the relative values and correlations of the instru-
ments used for arbitrage. At times, the best of arbitrageurs make mistakes in arbitrage when they
don’t understand all the risks associated or when they think there is arbitrage opportunity where
there is none. Such a risk is called model risk.
Arbitrage cost risk is risk that the cost of settling the arbitrage and the carrying costs associated
with it exceed the profit expected from that arbitrage. Some unexpected costs could come up all of
a sudden, or there could be a sudden increase in the margin that exposes the arbitrageur to more
than the expected costs and makes the arbitrageur suffer losses, especially when the margin in arbi-
trage is low.
Building an Equity Arbitrage Engine: Arbitrage in Equity Shares
Let’s build a case around five popular stocks traded in the United States. We will first try to fit in
logic for the arbitrage engine and then try to extend it to regular program trading to show how408C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
orders are generated to bring profit to the arbitrageur. An arbitrage system scours the market data of
multiple exchanges and markets and discovers arbitrage opportunities. A program trading system is
a system that accepts criteria for generating and executing orders from its users and keeps track of
the market. The moment the defined criteria are met, it automatically triggers orders in a relevant
exchange without any human intervention. In a typical dealing room setup, the arbitrage engine
would be set up to track data from multiple exchanges to look for arbitrage opportunities. Any
opportunity would then be passed to the program trading engine for the generation of orders. Deal-
ers themselves normally monitor these orders. However, in such cases, complexity of analysis and
speed is of the essence. With thousands of analysts and traders tracking the prices of every stock every
second, market opportunities due to price distortions are rare, and program trading engines coupled
with arbitrage engines are programmed to exploit such opportunities. Some program trading engines
are also programmed to look for arbitrage opportunities. In such cases the program trading engine itself
doubles as the arbitrage engine.
Arbitrageurs usually have arbitrage interest in multiple exchanges. Assume you are building
an arbitrage engine around such a case. The arbitrage engine will need to analyze data from these
exchanges. It would be extremely difficult for one human being to track several shares across exchanges
and keep a watch on prevailing prices on every exchange and differential in order to track arbitrage
opportunities. Good arbitrage opportunities are rare and happen mostly on not-so-popular securi-
ties. Hence, arbitrageurs need a sophisticated program that will help them track arbitrage opportunities.
These computer programs simultaneously read broadcasts across different exchanges and go
through an arbitrageur’s requirements to seek out arbitrage opportunities. On any normal day,
manually tracking five stocks may seem simple. But both these exchanges would have thousands
of listed stocks, and there would be good arbitrage opportunities in only a few of them. To arrive at
arbitrage opportunities across these five, the arbitrage engine would follow these steps:
1. Create a short list of securities of interest, and define the arbitrage costs and margin and the
minimum expected returns from arbitrage.
2. Scan the prices prevailing of securities the arbitrageur is interested in by reading continuously
available market data.
3. Arrive at price differentials between those stocks across various exchanges. These differentials
will determine the returns to the arbitrageur.
4. Compute the percentage returns.
5. Calculate the annualized percentage returns; as discussed earlier, the absolute returns will
not only determine whether the arbitrage opportunity is good or bad. They have to be
annualized in terms of percentage for a comparison to be possible.
6. Compare the annualized percentage returns with the prevailing arbitrage cost and expected
returns from the arbitrage; since a comparison has to be made, in most cases the arbitrage
cost is also expressed as a percentage and is annualized for the comparison to be more
meaningful.
7. Determine on which exchange to buy and on which exchange to sell. This depends upon
the relative prices in each exchange. Arbitrageurs need to buy on the exchange where the
stock is trading at a lower price and sell where it is trading at a higher price.
8. Present the opportunities to the arbitrageur in a meaningful form for them to take action.C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 409
When the arbitrage engine is interacting with a program trading engine, it will pass the details
of these arbitrage opportunities to the program trading engine, and the program trading engine will
generate orders to exploit these opportunities. We will run through the steps in the previous exam-
ple to give you more clarity on this.
For this example, assume an arbitrage opportunity is feasible only if it generates a return of
2 percent per annum over and above the arbitrage cost of 6 percent. We will call this figure of 2 percent
the arbitrage margin. The margin reflects a layer of safety over and above the arbitrage set-up costs.
The costs will barely cover our arbitrageur on the essentials that they will have to directly or indirectly
pay out for setting up the arbitrage. This arbitrage may have many other risks, as discussed earlier.
They need to be adequately covered and compensated for these risks. They will therefore not be
willing to look at an arbitrage opportunity where only the basic cost is met. Returns have to be a spe-
cific percentage over and above these costs. It is normal in such scenarios for the arbitrageur to say,
“I am interested in having a look at the opportunity only if the returns are 2 percent over and above
my costs.” Even if something goes wrong in the arbitrage, the cushion of margin is still there to prevent
the trader from going out of pocket.
The arbitrage cost of 6 percent assumed for this example is all inclusive of transaction costs,
costs associated on the buy leg, and costs associated on the sale leg. The 2 percent (arbitrage mar-
gin) and 6 percent (arbitrage cost) return also means that the arbitrageur is interested in doing an
arbitrage only if the return on it is 8 percent or higher.
These returns are normally quoted in two terms: for one particular arbitrage setup or on an
annualized basis. The arbitrage-level return being quoted in percentage is understandable. Arbitrageurs
would like to know how much return a particular arbitrage is giving them. Every arbitrage has a life
span after which it is wound up consciously or the market conditions force arbitrageurs to close the
arbitrage. Additionally, this life span is different for different arbitrage situations. Some may be closed
intraday, some may continue for two to three days, and some may even span weeks. If an arbitrageur’s
talk of returns on an arbitrage take place where there is no standardization on the number of days it
takes to generate the returns, comparison would be very difficult. Therefore, for a more standardized
comparison, these arbitrage-specific return figures are converted into an annualized return figure for
the purpose of comparison. When annualized figures are discussed, returns from every arbitrage can
be compared to each other meaningfully.
Returning to the example, for the sake of brevity assume our arbitrageurs are interested in only
two exchanges: the NYSE and Philadelphia Stock Exchange (PSE).
In any arbitrage, the choice of whether the arbitrage opportunity on a security will be acceptable
to the arbitrageur changes from security to security. Securities that enjoy very high liquidity are more
likely to be acceptable for arbitrage. Arbitrage on them normally comes at a low risk and a low cost.
These securities are widely available, and in the eventuality of the delivery requirement, they can be
sourced easily and delivered. The financials behind the companies are public domain information,
and most events in such companies and their stocks are predicted in advance; therefore, surprises
are rare. Although this level of transparency is welcome to the arbitrageur, this comfort usually comes
at a price. The more the market knows about a stock and the company behind it, the better the price
discovery process is in that particular stock across markets. Better price discovery and predictability
of events attracts more trading interest from market participants. This keeps prices in sync across
markets and makes arbitrage opportunities rare. To curtail the risk arbitrageurs face, they will nor-
mally create a short list of securities on which they will accept arbitrage opportunities and exploit
them.
Assume that the arbitrageurs have a clear and unlimited supply of the shares listed in Table 8-2
lying in their demat account and ready for delivery, and these are the only stocks on which they want
to accept arbitrage opportunities.410C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
Table 8-2. Short List of Securities of Interest for Arbitrage (Step 1)
Symbol Assumed Minimum Expected
Stock on NYSE Arbitrage Cost Arbitrage Margin* Return from Arbitrage**
The Coca-Cola KO 6% 2% 8%
Company
General Electric GE 6% 2% 8%
Company
Advanced AMD 6% 2% 8%
Micro Devices
The Walt Disney DIS 6% 2% 8%
Company
Wal-Mart Stores WMT 6% 2% 8%
*Over and Above Costs
**Assumed Arbitrage Cost + Arbitrage Margin
This kind of short list that the arbitrageurs have created to classify securities of their interest is
a good way to start because the arbitrage engine will now focus on market data available for only
these securities and will ignore market data for thousands of other securities. This will improve the
performance of the arbitrage engine tremendously.
We will now run through the steps listed earlier to show how the arbitrage engine works.
Step 1 has already been executed in Table 8-2; five securities are available, and a minimum
expectation of 8 percent has been set from the arbitrage. It is important to set the minimum expecta-
tion from the arbitrage because otherwise the arbitrageur will be flooded by arbitrage opportunities.
Notice that in arbitrage you are working on price differentials. Even though arbitrage opportunities
are rare, price differentials are bound to exist. However, it is not all differentials that interest arbi-
trageurs. It is only those differentials that are big enough to be translated into effective profits that
interest them.
Step 2 gets the latest prices on a real-time basis. Note that since the arbitrage opportunities will
finally translate into orders to be executed on a stock exchange, it is important that the arbitrage engine
works on absolute real-time prices. Stale prices will run a high risk of orders not getting through—or
worse, only one of the two sides (buy/sale) getting transacted.
Assume Table 8-3 shows the prices prevailing for these five shares on the NYSE and PSE.
Table 8-3. Current Market Prices in Exchanges of Interest (Step 2)
Stock NYSE PSE
The Coca-Cola Company $40 $40.05
General Electric Company $39.60 $39.80
Advanced Micro Devices $40 $41
The Walt Disney Company $28.20 $28
Wal-Mart Stores $46 $46C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 411
Step 3 involves computing price differentials. Here exchange pairs are created; one exchange is
taken as a base, and price differentials are computed with respect to that exchange (see Table 8-4).
Table 8-4. Price Differentials with Respect to NYSE (Step 3)
Stock Symbol NYSE PSE Price Differential
The Coca-Cola Company KO $40 $40.05 $0.05
General Electric Company GE $39.60 $39.80 $0.20
Advanced Micro Devices AMD $40 $41 $1
The Walt Disney Company DIS $28.20 $28 ($0.20)
Wal-Mart Stores WMT $46 $46 $0
In Table 8-4, the price differentials are computed with respect to the NYSE. Since prices on the
PSE are higher for the Coca-Cola Company, General Electric Company, and Advanced Micro Devices,
the price differentials are positive. However, in the case of the Walt Disney Company, the price dif-
ferential is negative because the price for the Walt Disney Company is higher on the NYSE than on
the PSE.
In step 4, the arbitrage engine would generate returns against these differentials. Percentage
returns are computed by dividing the price differential with prices prevailing on the base exchange
(the NYSE) and expressing them as percentages (see Table 8-5).
Table 8-5. Calculating Percentage Returns (Step 4)
Price Percentage Returns =
Stock NYSE PSE Differential (Price Differential / NYSE Prices) × 100
The Coca-Cola Company $40 $40.05 $0.05 0.125
General Electric Company $39.60 $39.80 $0.20 0.51
Advanced Micro Devices $40 $41 $1 2.50
The Walt Disney Company $28.2 $28 ($0.20) -0.71
Wal-Mart Stores $46 $46 $0 0
In step 5, returns will be computed on an annualized basis. Assume that the settlement for the
transactions in Table 8-5 is on a T+3 basis. No arbitrageur would want the arbitrage position to close
by going through settlements. They all aspire to close the arbitrage before settlements by reversing
the buy and sale positions in order to avoid the hassles and cost associated with settlements. In a T+3
environment, from setting up the arbitrage through winding up would take a maximum of three days.
For practical purposes, assume the channelization of funds and securities takes another four days
for every arbitrage. This would mean a total of about seven days is involved to generate the returns
in step 4. To annualize this, assuming 365 days a year, you need to multiply the returns by 365 / 7.
This will give the annualized returns shown in Table 8-6.412C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
Table 8-6. Calculating Annualized Percentage Returns (Step 5)
Price Percentage
Stock NYSE PSE Differential Returns Annualized Returns*
The Coca-Cola $40 $40.05 $0.05 0.12% 6.51%
Company
General Electric $39.60 $39.80 $0.20 0.51% 26.33%
Company
Advanced $40 $41 $1 2.50% 130.36%
Micro Devices
The Walt Disney $28.20 $28 ($0.20) -0.71% (36.98%)
Company
Wal-Mart Stores $46 $46 $0 0% 0%
*= Percentage Returns * 365 / Number of Days Arbitrage Position Is Kept Live
This tells you the relative returns on doing arbitrage on these securities; however, to find out
whether these deals will be profitable, they have to be validated against the cost of doing the arbi-
trage. More important, the interest level of the arbitrageur will be determined by the returns they
generate over and above the expected arbitrage returns.
The arbitrage engine in step 6 performs this comparison (see Table 8-7).
Table 8-7. Selecting Profitable Arbitrage (Step 6)
Returns from
Expectation Arbitrage Over
Price Percentage Annualized Arbitrage Arbitrage from and Above
Stock NYSE PSE Differential Returns Returns Cost Profitable? Arbitrage Expectations*
The Coca-Cola $40 $40.05 $0.05 0.12% 6.52% 6% Yes 8% -1.48%
Company
General Electric $39.60 $39.80 $0.20 0.51% 26.33% 6% Yes 8% 18.33%
Company
Advanced $40 $41 $1 2.50% 130.36% 6% Yes 8% 122.36%
Micro Devices
The Walt Disney $28.20 $28 ($0.20) -0.71% -36.98% 6% Yes 8% -44.98%
Company
Wal-Mart Stores $46 $46 $0 0% 0% 6% No 8% -8%
*Annualized Returns – Expectation from Arbitrage
As discussed earlier, arbitrage is profitable only if the returns from it exceed the costs. However,
even that does not ensure that such positions will be taken. Positions are most likely to be taken only
if annualized returns are over and above the expectation of arbitrage (the last column in Table 8-7
indicates positive returns). The figures show that three cases will generate negative returns. Let’s
examine them closely. Arbitrage on the Coca-Cola Company will be profitable but only marginally.
When compared with expected returns from the arbitrage, it does not generate positive returns. This
will thus be most likely dropped as a case for arbitrage or may be put in a watch list for the prices to
be watched more carefully just in case the price differentials widen and better the arbitrage oppor-
tunity available in this scrip. The Walt Disney Company is also showing huge negative returns, but
remember that this figure is negative because it is being measured with respect to the NYSE and theC H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 413
Returns from
Expectation Arbitrage Over
Percentage Annualized Arbitrage Arbitrage from and Above Case for
Stock NYSE PSE Returns Returns Cost Profitable? Arbitrage Expectations* Arbitrage
The Coca-Cola $40 $40.05 0.12% 6.52% 6% Yes 8% -1.48% No
Company
General Electric $39.60 $39.80 0.51% 26.33% 6% Yes 8% 18.33% Yes
Company
Advanced $40 $41 2.50% 130.36% 6% Yes 8% 122.36% Yes
Micro Devices
The Walt Disney $28.20 $28 -0.71% -36.98% 6% Yes 8% -44.98% Yes
Company
Wal-Mart Stores $46 $46 0% 0% 6% No 8% -8% No
differential was negative because prices on the PSE were lower than prices on the NYSE. This has to
be treated as a special case. This essentially means the arbitrage opportunity is very much there. Only
the order type (buy/sale) has to be reversed while hitting the exchanges. Finally, Wal-Mart Stores is
generating -8 percent over and above expectation, indicating that there is no arbitrage opportunity
here. This is not surprising given that there was no price differential in its prices to start.
The two cases yielding positive results—General Electric Company and Advanced Micro Devices—
are clear-cut cases for arbitrage and are likely to be taken up for execution.
Table 8-8 summarizes the cases.
Table 8-8. Arbitrage Opportunity (Step 7)
*Annualized Returns – Expectation from Arbitrage
However, to make these cases actionable, specific buy and sell recommendations have to be
generated as indicated in step 7.
For this, the arbitrage engine will have to refer to the prevailing prices and see in which exchange
the prices are high and in which exchange they are low. Following the principles of arbitrage, it will
recommend buying on the exchange where the prices are low and selling on the exchange where the
prices are high.
Table 8-9 shows the recommendations.
Table 8-9. Determine on Which Exchange to Buy and on Which Exchange to Sell (Step 8)
Price Case for
Stock NYSE PSE Differential Arbitrage Recommendations
The Coca-Cola $40 $40.05 $0.05 No No action to be taken.
Company
General Electric $39.60 $39.80 $0.20 Yes Buy on the NYSE, and sell on
Company the PSE.
Advanced $40 $41 $1 Yes Buy on the NYSE, and sell on
Micro Devices the PSE.
The Walt Disney $28.20 $28 ($0.20) Yes Buy on the PSE, and sell on the
Company NYSE.
Wal-Mart Stores $46 $46 $0 No No action to be taken.414C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
This is the usual information that any arbitrageur would want to see. Now let’s move on to pro-
gram trading and see how you can make the program trading engine use information generated by
the arbitrage engine to generate orders automatically.
Assume the arbitrageur is willing to commit money in lots of $10,000 per deal. The arbitrage
engine will have to refer to the market lot and prevailing prices to see how many shares can be bought
in one order. Assume that all these shares can be bought and sold in lots of one share each. The pro-
gram trading engine will arrive at the quantity of shares each order will contain. This will be equal to
$10,000 per current prevailing price. Table 8-10 shows the numbers.
Table 8-10. Orders Generated by Program Trading Engine
Price Number of Shares
Stock NYSE PSE Differential (Rounded Off) Recommendations
The Coca-Cola $40 $40.05 $0.05 No action to be taken.
Company
General Electric $39.60 $39.80 $0.20 252 Buy on the NYSE, and
Company sell on the PSE.
Advanced $40 $41 $1 250 Buy NYSE, and sell on
Micro Devices the PSE.
The Walt Disney $28.20 $28 ($0.20) 354 Buy on the PSE, and
Company sell on the NYSE
Wal-Mart Stores $46 $46 $0 No action to be taken.
The final orders that will be generated are as follows:
  Buy 252 of the General Electric Company on the NYSE.
  Sell 252 of the General Electric Company on the PSE.
  Buy 250 of Advanced Micro Devices on the NYSE.
  Sell 250 of Advanced Micro Devices on the PSE.
  Buy 354 of the Walt Disney Company on the PSE.
  Sell 354 of the Walt Disney Company on the NYSE.
These orders, once executed, will result in successful arbitrage positions. The arbitrageur will
later get the opportunity to unwind the arbitrage if the prices converge or proceed for settlements
in cases where the prices don’t converge until settlement. In both cases, the arbitrageur will make
a profit because the cost incurred in settlements was already factored in while calculating the costs
of settling the arbitrage.
Thus, you can see that arbitrage is an art of exploiting price differentials in multiple markets to
one’s advantage. Apart from making profits for the individual arbitrageur, it helps in the price discovery
process and brings prices in multiple markets closer to each other. This is an important economic
function that arbitrageurs fulfill.
This completes the business journey of arbitrage. The design of an arbitrage engine is mainly
centered on the functionality you want to provide to traders. The most sophisticated arbitrage engine
uses a rule engine to capture arbitrage rules defined by the traders. The rules are defined through
a trader-friendly language that is then processed by the rule engine, which translates the rules into
an appropriate language-level implementation. Automated code-generation tactics prove extremely
useful in this kind of scenario; in the rest of the chapter, we will discuss the code-generation topic in
detail.C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 415
Introducing Code Generation
Building good software involves a tremendous amount of planning, rock-solid architectural design,
efficient code, and a rigorous quality testing environment. Undoubtedly, each stage is time-consuming,
but the most important one—especially in large-scale projects—is the build phase in which code
is continuously churned out. The build phase accounts for the majority of the project time and
budget because the real work is performed in this stage; this includes writing real code, test cases,
database stored procedures, build scripts, and so on. However, this may not be true in other fields
of engineering; for instance, an automobile engineering’s development cycle is more or less aligned
with the software development life cycle, but the build time is shorter compared to the planning and
design time. The primary reason for such differences is because for a particular type of automobile
there is already a well-defined template that captures the detail specification of every component
of the automobile, which is then fed to sophisticated machines that understand and generate
components in accordance with the template. This kind of end-to-end automation is difficult to
implement in the software development world, particularly during the build phase, because the
nature of the business requirements is different for different customers. However, with the recent
advancement in software engineering, most of the repetitive tasks encountered during the software
construction stage are now automated, and this has deeply aided in speeding up the development
life cycle. Code generation is an advanced area that has evolved over a period of time, and in today’s
world it represents a novel way of building any type of application.
Code generation is the technique of producing language-specific code during either design
time or runtime based on some input information. This input information could be high-level code
or an abstract model defined using domain-oriented languages. Regardless of the type of input pro-
vided, the output produced is always program source code. This power to automatically generate source
code has greatly benefited developers and absolved them from writing repetitive and monotonous
code.
For example, consider back-office applications that are Online Transaction Processing (OLTP)
systems and contain hundreds of database tables. In such applications, a strong audit is required
that tracks changes applied to the underlying tables. To implement such requirements, developers
will first immerse themselves in creating triggers, and the number of triggers created in this case
will be exactly equal to the number of tables. Furthermore, the trigger logic formulated will be sim-
ple; it will contain a single-line SQL statement that copies rows from the original table to the audit
table. This same logic will get repeated and replicated across all tables. Now, such repetitive and menial
tasks when assigned to developers become a chore and can also be a source of frustration. To rescue
developers from such mundane tasks and to mobilize their efforts in building more productive parts
of the system, the development team must embrace automatic code-generation techniques. At
a surface level, such automation may not sound like an easy-to-achieve task, but we will show that
all that is required is a list of the table names and their underlying fields. This information is already
available and forms part of the database metadata that is separately stored in tables also known as
system tables. By writing the appropriate query, this information can then be retrieved and, with the
help of additional processing logic trigger code, can be automatically emitted. Such automation tasks
require a one-time investment in terms of development effort, but after that it forms part of the reusable
components and can be applied to other systems. There is no doubt that such automation when
implemented in the large scale will always lead to shipping great applications on schedule and on
budget.
Code generation is not a new concept and has been prevalent from the genesis of computing
days. It is rooted in high-level programming languages where code written in a user-friendly language
is compiled into low-level assembly instructions. This compilation process is a classic example of
automatic code generation that has consistently evolved from one generation to another, abstracting
away the complexities and layering another abstraction level that brings a higher degree of automa-
tion and consistency to day-to-day application development.416C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
Figure 8-1. Code generator components
The following are the three components required as the fuel to ignite the code-generation
process (see Figure 8-1):
Metadata: Metadata is a repository of information that describes application data. For example,
information about database tables and their field-level information forms part of metadata. This
information is stored in system tables and can be easily retrieved by framing and executing an
appropriate query.
Code generators: Code generators are key components that know the structure of the metadata,
understand the template, and weave this information together to produce program source code.
Code templates: Code templates represent the layout of the code and are composed of both
static and dynamic information. For example, in Figure 8-1, the trigger syntax forms part of the
static information, but the table name and list of fields form part of the dynamic information
that is populated by code generators during the code-generation phase.
Types of Code Generators
Automated code generation forms one of the powerful weapons in a developer’s arsenal. Its immediate
impact is a change in developer thinking when solving a complex problem, particularly during cases
where problems are repetitive in nature. Such a drastic shift in developer attitude has institutionalized
the concept of code generation in every phase of the software development life cycle, spanning from
the design to the deployment of systems. This has resulted in various forms of code generation that
are distinguished based on their applicability and which specific aspect of software development
they are trying to automate. The following are the most commonly used generators in day-to-day
application development:
Code wizards: Code generation using wizards is popular and also an important selling point of
any good IDE tools. Wizard-based techniques are commonly used to generate boilerplate code,
but they are also used to generate end-to-end full-blown code.
User interface: A user interface is certainly one of the most important parts of an application; it
is an external visual representation of the system to the outside world. The UI code generator
provides the developer with a novel way of designing UI-based applications. It allows develop-
ers to visually design the UI applications instead of understanding and writing the low-level
code details.C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 417
Specialized class: This type of generator is used to generate a highly specialized class that forms
the building blocks of the system. The specialized class generated is never compiled indepen-
dently; rather, it forms an important part of a larger set of classes and is included before building
the final executables.
Code inflator: A code inflator produces inline code based on a placeholder defined inside the
code. This kind of feature is mainly seen during the code-editing phase where the developer is
busy writing code and desperately looking for a shortcut to achieve a specific programming
goal such as writing safe multithreaded code, automatic resource cleanup, and so on.
Model-driven generator: Modeling plays an important role in the development of good software.
It captures and communicates the requirements and interaction between systems. With the help
of a model, individual components in the systems are visualized and represented in a domain-
specific language. Unified Modeling Language (UML) is a perfect example that is widely adopted
and is a graphical language for designing any kind of system. This visual model is fed to the
model-driven generator, which takes the responsibility of interpreting and producing language-
specific code.
Code documentation: Code documentation is not the most pleasant task encountered in
a day-to-day routine, but there is no way to escape it. It is a mandatory task because it captures
the design essence behind the code that is later used for reference. Therefore, both comments and
the actual code reside side by side, and with the help of the specialized code documentation
generator, the comments are extracted and polished into finished documentation represented
in .html, .doc, or .pdf format.
Just-in-time code cutting: Just-in-time code cutting is a modern way of generating code and
compiling it on the fly, and all this activity is executed during runtime, which is in contrast with
other types of code generators discussed so far that are meant to work during design time.
Code generation brings efficiency, agility, higher productivity, and consistency to software
development. Obviously, all this contributes to a lower maintenance cost. It is an extremely valuable
asset, and when properly leveraged, it provides a totally a new gear that boosts the application devel-
opment. That is why most of the components inside the .NET Framework and VS .NET leverage
code-generation techniques. We will discuss important areas where it is used in the subsequent section.
Code Generation and Reflection
In the .NET world, the assembly is a unit of deployment, and besides encapsulating IL code, it stores
complete metadata information about types and its members. This metadata information is emitted
by CLR-aware compilers during the compilation phase and seen as a major improvement over tra-
ditional compilers that used to capture limited information about the underlying types and their
dependencies. Such self-describing characteristics of an assembly provide complete information
about the program without needing the program source code, and retrieving this information at
runtime is made possible with reflection.
Reflection allows self-introspection of an assembly. Using reflection, you can examine classes
encapsulated inside assemblies and further drill down to the programming elements of a class, includ-
ing the properties, members, fields, and so on. Reflection works only with compiled code and is not
concerned with the programming language used to write the code. This ability has opened up a plethora
of opportunities and is utilized effectively by various tools such as visual designers, assembly inspec-
tors, class browsers, IntelliSense tools, and so on. Another interesting fact about reflection is that it
is not limited to examining type information and its underlying programming element; it is also capa-
ble of modifying the object state during runtime such as invoking a method, accessing a property
value, or directly modifying a field value. This type of dynamic behavior, when introduced, properly
saves tons of lines of code and motivates developers to design highly dynamic and extensible
applications.418C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
Reflection also enables building an assembly on the fly and allows loading it in memory; all this
is possible at runtime. This is a new development path available to developers that leads toward
code-generation techniques. Both code-generation and reflection share a bloodline relationship, and
nowadays it is certainly impossible to talk about code generation in isolation without discussing
reflection. Code generation is all about generating code, whereas reflection is about providing enough
information to produce this code, load it in memory, and then provide instant access to the function-
ality exposed by this code.
Certainly such a combination is considered an advanced programming technique mainly
practiced to implement programs whose behavior is dynamic in nature and hard to predict or cap-
ture its intent during design time. For example, highly complex trading algorithms are difficult to
specify and impossible both for traders and developers to document and implement inside code.
The various parameters used for algorithms tend to change frequently based on market conditions.
Often the most elegant solution to this problem is to capture the business input during runtime and
then dynamically emit code that is specific to a particular algorithm specification. This is definitely
a win-win deal to both traders and developers because developers now can mobilize their efforts in
producing a program that can not only understand business inputs fed by traders but also can reor-
ganize and retune the behavior of the program at runtime to suit this specific need.
User Interface
A user interface is one of the most visible parts of an application and directly gives a feel of how the
system works to users. A badly designed user interface can be a fertile source of frustration, and users
may even dislike the application despite its other components such as the database logic and middle
tier performing way beyond user expectations. It also means no matter how much effort is invested
in developing and fine-tuning the hidden part of the system, it is always the usability aspect that
determines the fate of the application. Therefore, it is important to provide a consistent and easy-to-
access user interface that is fairly intuitive and increases user efficiency in performing any complex task.
To keep up with this goal, developers always strive to provide a consistent look and feel across
the application. The whole point of a user interface is to capture the data from the users. To do this,
developers need to present the correct visual cues. From a UI development perspective, this task
involves identifying UI elements (UI widgets) and then rendering them on a UI canvas (UI form).
The final task is to apply finishing touches, which again require good aesthetic taste. All these tasks
demand a rigorous amount of coding, and handcrafting it manually can be a primary reason for
developers to avoid this task. But the Windows Form Designer built into the VS .NET IDE makes it
a breeze to do.
The Windows Form Designer internally uses code-generation techniques, but it provides a draw-
ing surface at design time and allows developers to place UI widgets directly onto it. Developers can
then control the aesthetic aspect of widgets by tweaking their properties through the Properties window.
Figure 8-2 depicts a Form Designer view with the left panel displaying the widget Toolbox window, the
center view displaying the drawing surface with various types of widgets rendered on it, and the
right panel representing the widget Properties window.
As you can see, developers do not have to write a single line of code in order to lay out and
configure widgets. Developers just have to drag and drop widgets onto the form and then use the
Properties window to tweak them. However, in reality, the Form Designer is churning out lots of
code in the background that is completely transparent to developers. In a broader sense, the Form
Designer is an additional resource provided for free that is 100 percent dedicated to UI development–
related tasks.
Fortunately, autogenerated code is not kept secret in some sort of opaque files; rather, it forms
part of the source code and is neatly grouped under the Windows Form Designer generated code
region. By expanding this code region, developers get an opportunity to take a closer look at the
code generated by the Windows Form Designer. Figure 8-3 represents the editor view of the auto-
generated source code.C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 419
Figure 8-2. Windows Form Designer
Figure 8-3. Windows Form Designer editor view420C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
Figure 8-4. Data Form Wizard
Code Wizards
Wizard-based development simplifies a complex task by breaking it down into a series of subtasks
that are simple and intuitive enough for the user to understand. At each step, enough information is
gathered that is then finally chained together to generate the final output. Similarly, a code wizard is
a special form of code-generation technique implemented to ease the coding task by breaking it
into a sequence of steps, and at each step developers are presented with a dialog box that collects
information required to produce the final code. Developers first seek the assistance of wizards in
establishing the foundation of complex code. This assistance leads to the formation of boilerplate
code, and developers then are absolutely free to modify the code to suit their specific needs. How-
ever, this form of code generation is different from UI designer–based code generation, because
once the boilerplate code is generated, the wizard is completely out of the picture, and there is no
relationship between code and wizards. Therefore, code wizards are sometimes known as jump-
starters because of their ability kick off any complex task.
Various wizards are available in the VS .NET IDE, but the most important one that is directly
related to the code-generation topic is the Data Form Wizard (see Figure 8-4). The Data Form Wizard
automates the task of creating a data-bound form. It runs through the entire procedure of loading
data from a database, displaying it on a grid, and updating the data back to the database. The wiz-
ard creates several files such as a typed dataset, a Windows form, and so on. It also constructs the
appropriate UI widgets, makes them data bound aware, and finally backs them with the appropriate
code logic.
Code Documentation
The purpose of getting code documentation from the developer is to mirror their ideas hatched
during the development stage on paper. It is only through documentation that developers demon-
strate the nuts and bolts of the system to the outside world. This initial effort proves to be extremely
handy and pays off during the maintenance stage when developers struggle to recollect a particularC H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 421
code trace or try to diagnose a peculiar system problem. Additionally, it helps newcomers quickly
get on board. Also, it helps other stakeholders of the system, such as quality assurance people and
technical writers, to get a better grip on the system. But it has always been hard to produce a single
and consistent copy of documentation that could then be shared with all interested parties. Much
of this can be attributed to the lack of strong tools that are not only difficult to use but also hard to
integrate with the existing development environment.
Even though developers happen to document their code using the language-specific code
inline documentation feature, this will not make other people in the team happy. To satisfy their
appetites, developers now need to undertake the same documentation task and present it in a nicer
format such as .html, .doc, .pdf, and so on. However, this solves the problem temporarily but leads
to another big problem—document synchronization. Developers now need to ensure that any change
in a comment at one place also is updated in another location. Keeping both copies synchronized is
sufficient to drive anyone crazy, and this is where documentation generators solve many of the prob-
lems faced during code documentation.
Documentation generators never produce code; instead, they parse the source code and extract
the comments embedded inside it to produce a finished, readable document. For example, the C#
language allows in-place code commenting using XML comments. Predefined tags supported by
XML comments are classified based on their usage and applicability. Tags are mainly applied over code
constructs such as types and type members. Table 8-11 describes a few important tags.
Table 8-11. XML Tags for Documentation Comments
Tag Description
<summary> This tag describes a type or type member.
<param> This tag describes a method parameter.
<return> This tag describes the return value of a method or property.
<exception> This tag is applied to a method, and it lists the exceptions a method can throw.
The following is an example of using these tags:
/// <summary>
/// Submits a limit price order to exchange
/// </summary>
/// <param name="instrument">Name of the underlying</param>
/// <param name="quantity">Total Quantity of the order</param>
/// <param name="price">Price at which this order is traded in the market</param>
public void SubmitOrder(string instrument,long quantity,double price)
{
}
As you can see, comments are nested inside XML tags, but an individual comment line begins
with three slashes. The documentation generator recognizes this as an XML comment identifier and
directly extracts the line into a separate file. This feature is already built into the C# compiler (csc.exe),
and with the help of the /doc switch, comments are extracted in an XML file. In this way, comments
are exported in a well-formed XML format, and now developers can easily produce any presenta-
tion format using XSLT. Using an XSLT template is the most common technique to read XML and
produce HTML pages. Open source tools such as NDoc (http://ndoc.sourceforge.net/) understand
these XML documentation tags and generate MSDN-style help documentation.
The advantage of a code documentation generator is that it allows both the code and the actual
documentation to reside in one central place and thus avoids the scattering of developer knowledge.
Furthermore, it provides the developer with a complete liberty to design a custom generator to suit
a particular need; for instance, quality assurance will demand documentation in test-plan format.422C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
Similarly, a technical manual writer will demand it in an API documentation format. Both of these
expectations can easily be met by creating two different types of XSLT while the actual documenta-
tion still resides inside the code.
Code Inflator
A code inflator is an inline expansion of code performed during the code compilation or editing
phase. The generator that does this code expansion basically reads a source file and looks for spe-
cial markup inside the code, and upon locating this markup, replaces it with the actual intended
code. This markup is called code tags. For developers, code tags are a way to boost productivity by
having their common programming task linked with keywords. This means a task that requires 20
lines of code can be represented by defining a code tag and then inserting it inside the code. The
beauty of a code tag is that it brings all the platinum quality that good code must possess such as
code clarity, readability, and simplicity. A good example is the use of the lock keyword used in the
C# programming language to ensure mutually exclusive access to a shared resource in a multi-
threaded environment. The lock statement takes the following form:
object lockObj = new object();
lock(lockObj)
{
//Thread-Safe Code
}
This is inflated by the compiler during the compilation phase into the following:
object lockObj = new object();
Monitor.Enter(lockObj);
try
{
//Thread-Safe Code
}
finally
{
Monitor.Exit(lockObj);
}
As you can see from the previous code, the lock keyword is a much cleaner and convenient
approach for writing thread-safe code compared to its expanded version. Another example of a code
inflator is the inherent refactoring support provided by VS .NET 2005 during the code-editing phase.
Refactoring is a technique adopted to modify the existing code structure, thus improving code read-
ability and maintainability. VS .NET 2005 supports many refactoring features, but the most useful
one is field-level refactoring. As part of good OO practices, we always adhere to its encapsulation
tenet where publicly accessible fields are not exposed directly to the external world; instead, they
are made available through a getter property and a setter property. Developers face this kind of
requirement in their day-to-day development routines, and they have to manually implement it.
But VS .NET 2005 automates this process with just a few mouse clicks, and the code for the get/set
method is automatically generated during design time.
Model-Driven Generator
Model-driven generators build code based on an abstract model. The abstract model represents
system requirements at a much higher abstraction layer. UML is a good example of a model-driven
generator in which the system is modeled using a graphical language. It enables the developer to
visualize and construct models in a manner that is easy to express and understand. The model rep-
resents the functional requirements of the system at a high level that is independent of the language
implementation. This kind of language-neutral model is precise enough to generate code. Furthermore,C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 423
code can be generated for any kind of programming language because UML decouples the imple-
mentation aspect from the model. Several UML-related commercial tools are available that allow
custom plug-ins of various types of code generators. Microsoft offers the Visio technology that facil-
itates end-to-end software modeling. Additionally, it is tightly integrated with VS .NET and provides
tight support for both forward and reverse engineering. Forward engineering refers to generating code
based on an abstract model; reverse engineering implies the construction of a model based on
source code.
Specialized Class
In this type of generator, code is generated based on metadata information that is defined in an
XML file. The metadata contains information that is mainly related to the type of application code
the generator is supposed to produce. For instance, if you need to autogenerate database triggers,
then all that is required is the name of the tables and type of trigger (insert, update, and delete) to
create. All this information then forms part of the metadata and is included in the XML file. Another
good example of this kind of generator is the ADO.NET strongly type DataSet. The ADO.NET DataSet
is a general-purpose in-memory container with a relational programming model flavor. The inter-
nal structure of a DataSet is organized in the form of rows and columns. It is mainly used to cache
rows populated from a database.
A typed DataSet is a sophisticated version of a dataset that provides strongly typed methods,
events, and properties. It means tables and columns are accessed by name instead of following
ordinal-based methods, thereby improving code readability. It is completely possible to construct
the entire relational database model inside a dataset, which includes tasks such as defining the primary
key, relations between tables using foreign keys, unique constraints, and so on. So, the foundation
for creating a typed dataset is the metadata information defined inside an XSD file. The structure of
this information is in accordance to the XSD standard, and it is then fed to an XSD tool (xsd.exe) that
generates a strongly typed dataset. The code inside this tool has sufficient knowledge to understand
and interpret the metadata and accordingly produce output.
Just-in-Time Code Cutting
Just-in-time code cutting (JIT-CC) is an ability to dynamically generate and compile code on the fly
at runtime. This behavior is different from other types of code generators discussed so far that gen-
erate code during design time and that are compiled later with another production set of classes.
Obviously, generating code on the fly at runtime requires support from the underlying execution
run-time system, and the CLR is well equipped to blend with such techniques. A perfect example
of it is the way XmlSerializer is designed.
As discussed in Chapter 3, XmlSerializer enables you to serialize and deserialize objects into
and from XML documents, but a deep dive into its internal implementation will reveal some cool
programming techniques. It allows you to work with strongly typed classes where an individual field
or property is mapped with elements or attributes of the XML document, and this mapping infor-
mation is controlled through a special set of XmlSerializer attributes. At the core implementation
level, every time a new instance of XmlSerializer is constructed, a new assembly and a new class
are dynamically created. This newly created class strictly contains type-specialized code to transfer
data between objects and XML and is determined at runtime. That is the reason why you notice
a slowness in execution whenever a new instance of XmlSerializer is created. The instantiation
process includes the dynamic generation and compilation of code, which chews a fair amount of
CPU cycles; therefore, it is always a good programming practice to cache the instance of XmlSeralizer
instead of re-creating it again and again.
With this example, we have completed the discussion of the various forms of code generators.
Now we will cover the real implementation technique that includes a code generator framework
available in the .NET Framework. The rest of the chapter will cover this topic in detail and lay
a strong foundation for building code generator–based solutions.424C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
Figure 8-5. Conceptual flow of how abstract code is processed using the CodeDOM framework
Introducing the CodeDOM
Code generators that possess the ability to generate code in a language-independent manner will
always earn the highest respect from the developers, and this is true with the Code Document Object
Model (CodeDOM) that is bundled with the .NET Framework. Using the CodeDOM, source code is
written in a language-neutral manner. This is possible because of its internal object model where there
is a one-to-one relationship between a language construct and its corresponding object-oriented
representation. This type of abstraction allows representing source code in an object-oriented fash-
ion, which results in a CodeDOM graph. The CodeDOM graph is analogous to a tree where multiple
nodes are linked with each other and also hierarchically arranged. Similarly, the CodeDOM graph is
a collection of objects arranged in a tree structure, and an individual object describes a language
structure in abstract terms. This abstract graph is then traversed and processed to generate source code
that is specific to a particular language implementation such as C#, VB .NET, JScript.NET, and so on.
Certainly, the CodeDOM is a promising framework available to a developer, and Microsoft has
shown its commitment to it by developing several of its tools based on it. However, developers will
face certain pitfalls when it comes to implementing a language construct that is specific to a particular
language. For instance, a conditional statement is a generic programming construct and is supported
by almost all modern programming languages. Hence, it makes sense to define an abstract repre-
sentation of this statement, but now let’s consider a fixed statement provided by C# used to prevent
the relocation of a variable by the garbage collector. This statement is not available in any other lan-
guage and hence would be difficult to generalize and consider it under a general-purpose code object
model. However, this shouldn’t be the bottleneck; if you look at the brighter side, the CodeDOM
provides a rich object model that is truly appealing and compels developers to integrate it in their
day-to-day tasks. Let’s walk through Figure 8-5 to see how.
Figure 8-5 represents a conceptual flow of generating and compiling source code using the
CodeDOM framework. At a high level, there are three stages, and each stage plays an important role
in the overall code-generation process. The first stage is to create the CodeDOM graph that is popu-
lated with objects defined in the System.CodeDOM namespace. This namespace contains classes used
to model the structure and elements of the source code. After successfully populating the object graph,
it is then fed to CodeDOM providers. CodeDOM providers are code generators that understand the
CodeDOM object graph and generate source code in a particular programming language. In this way,
the code-generation logic is encapsulated in its own component, and such flexibility allows repre-
senting code in any new language without undertaking any code rewriting. Additionally, it is possible
to directly compile the object graph into an executable form. Both the code generation and compi-
lation tasks are defined inside the System.CodeDom.Compiler namespace, and shortly we will discuss
this topic in detail.
To illustrate the implementation aspect of the CodeDOM, we will present the C# code in Listing 8-1,
which represents a custom class of a stock price. It contains attributes such as the name of the stock,
ask price, bid price, and so on. To keep the code simple, we have omitted most of the essential attri-
butes that usually form part of the stock information.C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 425
Listing 8-1. Sorting of Stock Data
using System;
using System.Collections;
//Stock Domain Model
public class StockData
{
public string Symbol;
public double AskPrice;
public double BidPrice;
}
//Custom Comparer to sort stock data
public class StockSorter : IComparer
{
string fldName;
public StockSorter(string fld)
{
//since we want to provide sorting on individual field
//of stock class, the name of the field on
//which the sort is performed is accepted as the constructor
//argument
fldName=fld;
}
public int Compare(object x, object y)
{
StockData leftObj= x as StockData;
StockData rightObj=y as StockData;
//If sorting is to be done on symbol field
if ( fldName == "Symbol" )
{
return leftObj.Symbol.CompareTo(rightObj.Symbol);
}
//If sorting is to be done on ask price field
if ( fldName == "AskPrice" )
{
return leftObj.AskPrice.CompareTo(rightObj.AskPrice);
}
return 1;
}
}
class SortNormal
{
[STAThread]
static void Main(string[] args)
{
//create stock list
ArrayList stockList = new ArrayList();
//create msft stock
StockData stkData1 = new StockData();
stkData1.Symbol = "MSFT";426C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
Figure 8-6. New assembly structure
//create ibm stock
StockData stkData2= new StockData();
stkData2.Symbol = "IBM";
//add both msft and ibm stock
stockList.Add(stkData1);
stockList.Add(stkData2);
while(true)
{
//prompt name of the field to sort
Console.WriteLine("Enter name of the field to sort on : ");
string fldName = Console.ReadLine();
//instantiate the custom comparer, passing the field name
StockSorter stockSorter = new StockSorter(fldName);
//sort the list
stockList.Sort(stockSorter);
//display the sorted stock item
Console.WriteLine(fldName +" -----------------------" );
foreach(StockData stkData in stockList)
{
Console.WriteLine("Symbol {0} AskPrice {1} BidPrice {2}
",stkData.Symbol,stkData.AskPrice,stkData.BidPrice);
}
Console.WriteLine("-------------------------------");
}
}
}
In Listing 8-1, particularly in the application entry point method, we have declared the StockData
class that represents stock information, and an individual instance of it is stored in an array. The
important section to explore is the loop code that prompts for a field name, based on which the ele-
ments stored in the array are sorted using quick-sort functionality, which was already discussed in
depth in Chapter 2. The trick in this code example is to provide sorting on any valid field; to accom-
plish this, we identified and defined all possible field lists in the Compare method of StockSorter.
However, the disadvantage of this approach is that the field list is defined during design time, and if
a new field is introduced in the class, then it will trigger a fair amount of modification in the imple-
mentation of the comparer class and also a recompilation of the program. To escape this problem,
we will demonstrate the practical use of both the CodeDOM and reflection. Before we proceed, we
need to slightly modify the code structure to suit this new example, as shown in Figure 8-6.C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 427
From Figure 8-6 it should be clear the kind of code refactoring we are envisaging. The compari-
son logic that was enclosed inside the main assembly (that is, StockSorter) will now be dynamically
generated using the CodeDOM. Similarly, the stock information is separated in a new shared assembly
and will be referenced by both the main and dynamically generated assemblies. The first installment
of this exercise is to define StockData in a shared assembly:
using System;
namespace SharedAssembly
{
public class StockData
{
public string Symbol;
public double AskPrice;
public double BidPrice;
}
}
The next installment is the revised code of the main assembly that triggers the code-generation
process:
using System;
using System.Collections;
using SharedAssembly;
class SortCodeDOM
{
static void Main(string[] args)
{
//create empty arraylist
ArrayList stockList = new ArrayList();
//create msft stock
StockData stkData1 = new StockData();
stkData1.Symbol = "MSFT";
stkData1.AskPrice = 10;
stkData1.BidPrice = 12;
//create ibm stock
StockData stkData2= new StockData();
stkData2.Symbol = "IBM";
stkData2.AskPrice = 12;
stkData2.BidPrice = 9;
//create GE stock
StockData stkData3 = new StockData();
stkData3.Symbol = "GE";
stkData3.AskPrice = 13;
stkData3.BidPrice = 10;
//add stock
stockList.Add(stkData1);
stockList.Add(stkData2);
stockList.Add(stkData3);
while(true)
{
//prompt name of the field to sort
Console.WriteLine("Enter name of the field to sort on : ");428C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
string fldName = Console.ReadLine();
//generate custom comparer code using CodeDOM
SortByCodeDOM sort = new SortByCodeDOM(fldName);
//sort the list
stockList.Sort(sort.GetComparer());
//display the sorted stock item
Console.WriteLine(fldName +" -----------------------" );
foreach(StockData stkData in stockList)
{
Console.WriteLine("Symbol {0} AskPrice {1} BidPrice {2}
",stkData.Symbol,stkData.AskPrice,stkData.BidPrice);
}
Console.WriteLine("-------------------------------");
}
}
}
There is nothing extraordinary in the previous code except that a new class, SortByCodeDOM, is
instantiated, and its GetComparer method is invoked, which returns an instance of IComparer, as
shown in Listing 8-2.
Listing 8-2. Sorting of Stock Data (Using the CodeDOM)
using System;
using System.Collections;
public class SortByCodeDOM
{
string fldName;
public SortByCodeDOM(string fld)
{
fldName=fld;
}
public IComparer GetComparer()
{
//Dynamic Generation of Code using CodeDOM
return null;
}
}
The real food will be cooked inside GetComparer, whose method body is currently empty. But
you are now going to populate this method with suitable logic to generate the correct sorting imple-
mentation that is based on a particular field of StockData. Listing 8-3 shows the code that will get
dynamically generated. This code will not get compiled; it is still in unfinished form, and we have
purposely described it to further strengthen your understanding.
Listing 8-3. Customizing the Sort Order of the Stock Data
using System;
using System.Collections;
using SharedAssembly;
namespace SorterAssembly
{
public class SortCode : IComparer
{C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 429
public int Compare(object x, object y)
{
StockData leftObj;
StockData rightObj;
leftObj= x as StockData;
rightObj=y as StockData;
return leftObj.<Field Name>.CompareTo(rightObj.<Field Name>);
}
}
}
If you were told to translate the code described in Listing 8-3 in a pseudo-code format, then it
is simply a matter of breaking up the code into fine-grained steps, as follows:
1. Reference SharedAssembly, which will allow you to access StockData.
2. Declare the new namespace SorterAssembly.
3. Import the System, System.Collections, and SharedAssembly namespaces.
4. Create a new class under the SorterAssembly namespace. Name this class SortCode. This
class will also implement the IComparer interface.
5. Create the new method Compare. The method return type is int, and it accepts two method
arguments of type Object.
6. Populate the method body. The first two lines of the body are to cast both input arguments
to StockData. The last line of the code is to invoke the CompareTo method on one of the input
parameters.
Now let’s look at how to leverage the CodeDOM classes with a step-by-step translation of the
previous pseudo-code into an abstract hierarchy of code elements.
The first and foremost requirement of the CodeDOM is to construct an instance of CodeCompileUnit,
which provides a container for the CodeDOM object graph and is a representation of an assem-
bly. The two most important attributes provided by this class are ReferencedAssemblies and
AssemblyCustomAttributes. ReferencedAssemblies is a string collection that contains the filenames of
the referenced assemblies. Similarly, the AssemblyCustomAttributes property represents custom
attributes of the assembly and is defined with the help of CodeAttributeDeclarationCollection.
For example:
CodeCompileUnit compileUnit = new CodeCompileUnit();
The next step after declaring the container is to define a new namespace, so accordingly you
use CodeNameSpace to represent a namespace:
//Step2 - create a new namespace
CodeNamespace newNameSpace = new CodeNamespace("SorterAssembly");
Next, you declare the list of namespaces referenced by the program, which is equivalent to the
using namespace directive in C#. The Imports property of CodeNameSpace represents namespaces
referenced by assembly. This property returns CodeNamespaceImportCollection, which represents
a collection of CodeNamespaceImport objects. After populating this namespace collection, the newly
created instance of CodeNameSpace is then added to CodeCompileUnit, like so:
//Step3 - Import namespaces
newNameSpace.Imports.Add(new CodeNamespaceImport("System"));
newNameSpace.Imports.Add(new CodeNamespaceImport("System.Collections"));
newNameSpace.Imports.Add(new CodeNamespaceImport("SharedAssembly"));
compileUnit.Namespaces.Add(newNameSpace);430C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
The next step is to define the SortCode class using CodeTypeDeclaration, which is also used to
represent the structure, interface, or enumeration. The IsClass, IsStruct, IsEnum, and IsInterface
methods of CodeTypeDeclaration indicate the underlying type. Additionally, you also derive the
SortCode class from IComparer by populating the BaseTypes property of CodeTypeDeclaration, and
finally you group it under the newly created namespace:
//Step4 - Defines new Type
CodeTypeDeclaration newType = new CodeTypeDeclaration("SortCode");
newType.BaseTypes.Add(typeof(IComparer));
newNameSpace.Types.Add(newType);
Next, you declare the Compare method using CodeMemberMethod. This class represents a declara-
tion for a method, and both the name of the method and its accessibility are assigned, respectively,
by setting the Name and Attributes properties. This newly created member is then added to the
SortCode class by populating the Members property of CodeTypeDeclaration:
//Step5 - Declare Method
CodeMemberMethod compareMethod = new CodeMemberMethod();
compareMethod.ReturnType = new CodeTypeReference(typeof(int));
compareMethod.Name = "Compare";
compareMethod.Attributes = MemberAttributes.Public | MemberAttributes.Final;
newType.Members.Add(compareMethod);
CodeMemberMethod is also extended by other classes:
  CodeConstructor: Represents a constructor member declaration
  CodeEntryPointMethod: Defines an executable entry point
  CodeTypeConstructor: Represents a static constructor member declaration
If you look at the code described in Listing 8-3, the Compare method accepts two input arguments,
and accordingly you define both these arguments with CodeParameterDeclarationExpression. This
class represents code that declares arguments for a method, property, or constructor. As you can guess,
the individual instance of CodeParameterDeclarationExpression is then added to the Parameters
collection of the CodeMemberMethod (the Compare method), which also completes the method decla-
ration step:
CodeParameterDeclarationExpression param1 = new
CodeParameterDeclarationExpression(typeof(object),"x");
CodeParameterDeclarationExpression param2 = new
CodeParameterDeclarationExpression(typeof(object),"y");
compareMethod.Parameters.Add(param1);
compareMethod.Parameters.Add(param2);
CodeParameterDeclarationExpression is derived from CodeExpression, which forms a base class
for declaring any type of code expression. The following are the derived classes that represent the
various types of code expression:
  CodeArgumentReferenceExpression: Represents a reference to the value of an argument
passed to a method
  CodeArrayCreateExpression: Represents an array creation expression
  CodeArrayIndexerExpression: Represents a reference to an index of an array
  CodeBaseReferenceExpression: Represents a reference to the base class
  CodeBinaryOperatorExpression: Represents a binary operation between two expressions
  CodeCastExpression: Represents a cast expression
  CodeDelegateCreateExpression: Represents an expression to create a delegateC H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 431
  CodeDelegateInvokeExpression: Represents an expression that raises an event
  CodeEventReferenceExpression: Represents a reference to an event
  CodeFieldReferenceExpression: Represents a reference to a field
  CodeMethodInvokeExpression: Represents an expression that invokes a method
  CodeObjectCreateExpression: Represents an expression that creates a new instance of a type
  CodeParameterDeclarationExpression: Represents a parameter declaration for a method,
property, or constructor
  CodePropertyReferenceExpression: Represents a reference to the value of a property
  CodePropertySetValueReferenceExpression: Represents the value argument of a property set
method call within a property set method
  CodeThisReferenceExpression: Represents a reference to the current local class instance
  CodeTypeOfExpression: Represents a typeof expression
  CodeTypeReferenceExpression: Represents a reference to a data type
  CodeVariableReferenceExpression: Represents a reference to a local variable
  CodeSnippetExpression: Represents a literal expression
After adding the parameter declaration for the Compare method, the next step is to populate
the body of the method; you do this using the Statements property of CodeMemberMethod. This prop-
erty returns CodeStatementsCollections, which represents a collection of CodeStatement objects.
CodeStatement represents individual code constructs that appear within method bodies, properties,
and so on. For instance, local variable declaration is one type of code statement, so to accommodate
different types of code statements, CodeStatement is further extended. In the following code, you
declare two local variables of type StockData using CodeVariableDeclarationStatement, which basi-
cally represents the first and second lines of code in the Compare method described in Listing 8-3:
//Step6 - Populate Method Body
//Declare the Variable
CodeVariableDeclarationStatement leftObj = new
CodeVariableDeclarationStatement("StockData","leftObj");
CodeVariableDeclarationStatement rightObj = new
CodeVariableDeclarationStatement("StockData","rightObj");
compareMethod.Statements.Add(leftObj);
compareMethod.Statements.Add(rightObj);
The following are the classes that directly derive from CodeStatement:
  CodeAssignStatement: Represents an assignment statement.
  CodeAttachEventStatement: Represents the attachment of an event handler.
  CodeCommentStatement: Represents a single-line comment statement.
  CodeConditionStatement: Represents a conditional branch statement.
  CodeExpressionStatement: Represents a statement that consists of a single expression.
  CodeGotoStatement: Represents a goto statement.
  CodeIterationStatement: Represents a loop statement.
  CodeMethodReturnStatement: Represents a return value statement.
  CodeRemoveEventStatement: Represents the removal of an event handler.
  CodeSnippetStatement: CodeSnippetStatement can represent a statement using a literal code
fragment that will be included directly in the source without modification.432C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
  CodeThrowExceptionStatement: Represents a statement that throws an exception.
  CodeTryCatchFinallyStatement: Represents a try-catch-finally statement.
  CodeVariableDeclarationStatement: Represents a variable declaration.
Next, a cast operation is performed on both input arguments, and the result of it is assigned to a local
variable. Another important thing is even though method bodies are populated using CodeStatement,
usually CodeStatement is composed from CodeExpression. This step represents the third and fourth
lines of code in the Compare method described in Listing 8-3:
//Cast x argument
CodeCastExpression leftcastExp = new
CodeCastExpression("StockData",new CodeVariableReferenceExpression("x"));
CodeAssignStatement leftcastStmt = new
CodeAssignStatement(new CodeVariableReferenceExpression("leftObj"),leftcastExp);
compareMethod.Statements.Add(leftcastStmt );
//Cast y argument
CodeCastExpression rightcastExp = new
CodeCastExpression("StockData",new CodeVariableReferenceExpression("y"));
CodeAssignStatement rightcastStmt = new
CodeAssignStatement(new
CodeVariableReferenceExpression("rightObj"),rightcastExp);
compareMethod.Statements.Add(rightcastStmt);
Finally, a closer look at the following code will reveal that the code generated is specialized to
access a particular field; to be precise, the field name mentioned refers to the argument supplied to
the SortByCodeDOM constructor:
//Compare both field value and return the result
CodePropertyReferenceExpression leftExp= new
CodePropertyReferenceExpression(new
CodeVariableReferenceExpression("leftObj"),fldName);
CodePropertyReferenceExpression rightExp = new
CodePropertyReferenceExpression(new
CodeVariableReferenceExpression("rightObj"),fldName);
CodeMethodInvokeExpression methodExp = new
CodeMethodInvokeExpression(leftExp,"CompareTo",rightExp);
CodeMethodReturnStatement retStmt = new
CodeMethodReturnStatement(methodExp);
compareMethod.Statements.Add(retStmt);
This brings an end to the population of the CodeDOM object graph. At this stage, the CodeDOM
object graph is populated in a language-neutral manner, and this tree is now ready for parsing in order
to produce language-specific code. The parsing functionality happens via CodeDOM providers.
CodeDOM providers are responsible for translating the CodeDOM tree into a language-specific
implementation. Since the multiple languages would result into multiple implementations of code
providers, each provider needs to inherit from CodeDOMProvider. CodeDOMProvider is the abstract
base class and provides interfaces for code generation and code compilation. The code-generation
feature is retrieved with a call to CreateGenerator, which returns an object that implements
the ICodeGenerator interface. Similarly, the code compilation feature is retrieved with a call to
CreateCompiler, which returns an object that implements ICodeCompiler. Microsoft.CSharp.
CSharpCodeProvider and Microsoft.VisualBasic.VBCodeProvider are the default CodeDOM providers
available in the .NET Framework.
So, the next step is to construct a language-specific code provider, which in this case is the C#
code provider itself, and transform the abstract code graph into C# source code. The following code
demonstrates this:C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 433
Console.WriteLine("Translating CodeDOM object graph into text...");
//create C# code provider
CodeDomProvider csharpProv = new CSharpCodeProvider();
ICodeGenerator csharpCodeGen = csharpProv.CreateGenerator();
StringBuilder builder = new StringBuilder();
StringWriter writer = new StringWriter(builder);
//code-generation option
CodeGeneratorOptions opt = new CodeGeneratorOptions();
//convert CodeDOM graph into source code
csharpCodeGen.GenerateCodeFromCompileUnit(compileUnit,writer,opt);
After getting an instance of ICodeGenerator, you then convert the object graph to text using
GenerateCodeFromCompileUnit. This method takes three arguments; the first argument is an instance
of CodeCompileUnit, the second argument refers to StringWriter into which the output is redirected,
and the third argument is an instance of CodeGeneratorOptions that allows modifying the output
format of the generated code.
The final phase is to translate the CodeDOM object graph into a compiled form, and you do
this with the help of CompileAssemblyFromDom defined in ICodeCompiler. CompileAssemblyFromDom is
supplied with an instance of CompilerParameters that provides various tweaking features required
during the compilation process. One of the features it provides is compiling the CodeDOM object
graph either into a class library or into an executable form. It also provides options to persist the
assembly either in memory or to disk. In the following code, the CodeDOM object graph is com-
piled in memory, and the result of the compilation is collected with the help of CompilerResults:
Console.WriteLine("Translating CodeDOM object graph into assembly...");
//create c-sharp compiler
ICodeCompiler csharpCompiler = csharpProv.CreateCompiler();
CompilerParameters param = new CompilerParameters(new
string[]{"System.dll","SharedAssembly.dll"});
param.GenerateExecutable=false;
param.GenerateInMemory=true;
//compile the source code
CompilerResults results =
csharpCompiler.CompileAssemblyFromDom(param,compileUnit);
foreach(CompilerError error in results.Errors)
{
Console.WriteLine(error.ErrorText);
}
//check for any errors
if ( results.Errors.Count > 0 ) return null;
The advantage of in-memory generation of an assembly is that a reference to the generated
assembly can be obtained from the CompiledAssembly property of CompilerResults. Similarly, if the
assembly is written to disk, then the path to the newly generated assembly is obtained from the
PathToAssembly property of CompilerResults. In both cases, the assembly is loaded into the current
application domain, and with the help of reflection you instantiate the new class that implements
the IComparer interface and contains comparison logic specific to a particular field of StockData:
IComparer comparer=
results.CompiledAssembly.CreateInstance("SorterAssembly.SortCode") as IComparer;
return comparer;
This completes the GetComparer implementation of SortByCodeDOM. Now let’s compile and run
the SortCodeDOM assembly. Figure 8-7 shows the console output of SortCodeDOM.434C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
Figure 8-7. Console output of sort-by-CodeDOM program
Introducing Reflection
As you are aware, reflection is about examining and querying type information at runtime. It provides
rich metadata that is available only during runtime, and based on this information, developers can
implement more advanced programming techniques. Developers often resort to writing tons of
code when implementing a complex feature, but in this section we will discuss the reflection class
library and also highlight the fact that you can develop some cool features using reflection.
The Reflection API is defined inside the System.Reflection namespace. It contains classes and
interfaces that provide an object-oriented representation of loaded assemblies, modules, types, and
methods. If you look at Figure 8-8, the individual types are organized in a hierarchy fashion, and
they depict a traversing path in which metadata is accessed. At the top of the hierarchy is AppDomain,
which provides information about the loaded assemblies in the form of Assembly. Assembly is com-
posed of multiple modules. A module is represented by Module, and it contains types and interfaces.
The most important element of reflection is a class and is represented by Type. With access to Type,
the entire information about a class including the list of fields, methods, properties, interfaces, nested
types, custom attributes, and so on, can be retrieved.C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 435
The following is a class search example that uses reflection to locate a class based on user
input. On a successful search, the program lists the class methods, fields, and properties.
using System;
using System.Reflection;
class Reflector
{
static void Main(string[] args)
{
Console.WriteLine("Enter name of the type to search for : " );
//Prompt for type name
string typeName = Console.ReadLine();
//Initiate the search
SearchType(typeName);
}
public static void SearchType(string typeName)
{
//iterate thru assembly
foreach(Assembly curAssem in AppDomain.CurrentDomain.GetAssemblies())
{
//iterate through module
foreach(Module curModule in curAssem.GetModules())
{
//iterate through type
foreach(Type curType in curModule.GetTypes())
{
if ( curType.Name == typeName )
{
Console.WriteLine("Found inside Assembly : " +curAssem.FullName);
//on successful search, display the type information
RetrieveTypeInfo(curType);
break;
}
}
}
}
}
Figure 8-8. Traversing path using reflection436C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
Figure 8-9. Console output of class search program
public static void RetrieveTypeInfo(Type type)
{
//display all methods defined in this type
Console.WriteLine("Type Full Name : " +type.FullName);
Console.WriteLine("List of Methods");
Console.WriteLine("----------------");
foreach(MethodInfo curMethod in type.GetMethods())
{
Console.WriteLine(curMethod.Name);
}
//display properties defined in this type
Console.WriteLine("List of Properties");
Console.WriteLine("------------------");
foreach(PropertyInfo propInfo in type.GetProperties())
{
Console.WriteLine(propInfo.Name);
}
//display fields defined in this type
Console.WriteLine("List of Fields");
Console.WriteLine("--------------");
foreach(FieldInfo fldInfo in type.GetFields())
{
Console.WriteLine(fldInfo.Name);
}
}
}
Figure 8-9 shows the console output of the class search program.
Another mechanism provided by reflection is late binding. Late binding is a technique in which
an instance of a class or a method invocation takes place at runtime instead of compile time. The
only downside to using late binding is that you lose the type safety–related checks done by compil-
ers. However, the upside is that this ability of reflection allows you to build a highly extensible andC H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 437
pluggable application. For instance, you can locate a specific method in a type, determine the number
of arguments required and their underlying types, and finally invoke this method. You can achieve
this entire task dynamically.
To give you an idea of what we are talking about, let’s rewrite the stock sort example using
reflection, as shown in Listing 8-4.
Listing 8-4. Sorting of Stock Data (Using Reflection)
using System;
using System.Reflection;
using SharedAssembly;
using System.Collections;
class ReflectionComparer : IComparer
{
string fldName;
public ReflectionComparer(string fld)
{
fldName = fld;
}
public int Compare(object x, object y)
{
StockData leftObj = x as StockData;
StockData rightObj = y as StockData;
//Retrieve field meta data
FieldInfo leftField= leftObj.GetType().GetField(fldName);
FieldInfo rightField= rightObj.GetType().GetField(fldName);
//Retrieve field value
object leftValue = leftField.GetValue(leftObj);
object rightValue = rightField.GetValue(rightObj);
//Retrieve method metadata
MethodInfo leftMethod = leftField.FieldType.GetMethod("CompareTo",new
Type[]{leftValue.GetType()});
//invoke the method
object retValue = leftMethod.Invoke(leftValue,new object[]{rightValue});
return (int)retValue;
}
}
public class SortByReflection
{
string fldName;
public SortByReflection(string fld)
{
fldName=fld;
}
public IComparer GetComparer()
{
return new ReflectionComparer(fldName);
}
}438C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
The corresponding impact in the main assembly now sorts the list using reflection:
using System;
using System.Collections;
using SharedAssembly;
class SortReflection
{
static void Main(string[] args)
{
ArrayList stockList = new ArrayList();
StockData stkData1 = new StockData();
stkData1.Symbol = "MSFT";
stkData1.AskPrice = 10;
stkData1.BidPrice = 12;
StockData stkData2= new StockData();
stkData2.Symbol = "IBM";
stkData2.AskPrice = 12;
stkData2.BidPrice = 9;
StockData stkData3 = new StockData();
stkData3.Symbol = "GE";
stkData3.AskPrice = 13;
stkData3.BidPrice = 10;
stockList.Add(stkData1);
stockList.Add(stkData2);
stockList.Add(stkData3);
while(true)
{
Console.WriteLine("Enter name of the field to sort on : ");
string fldName = Console.ReadLine();
SortByReflection sort = new SortByReflection(fldName);
stockList.Sort(sort.GetComparer());
Console.WriteLine(fldName +" -----------------------" );
foreach(StockData stkData in stockList)
{
Console.WriteLine("Symbol {0} AskPrice {1} BidPrice {2}
",stkData.Symbol,stkData.AskPrice,stkData.BidPrice);
}
Console.WriteLine("-------------------------------");
}
}
}
You have seen in Listing 8-4 how reflection is used to dynamically determine the field, query
the field, and then invoke the CompareTo method. Certainly, you can achieve this kind of flexibility
only using reflection, but it comes with a cost. The cost is impact both in performance and mainte-
nance. First, it is hard to debug code that uses reflection, and any errors produced as a result of dynamic
invocation are often not so friendly to diagnose. Second, this impacts performance; it is obvious that
early-binding method calls will always be faster than late-binding ones. But sometimes it is impos-
sible to escape using reflection. Reflection is a privilege offered by the .NET Framework, and a balanced
use of it will lead to the design of highly extensible applications.C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 439
Code Generation Using Reflection.Emit
Another approach to dynamically generating code is using Reflection.Emit, which is an extremely
powerful code-generation weapon that directly emits raw MSIL code. This is in contrast to the
CodeDOM, which has the ability to generate code in multiple languages such as C#, VB .NET, and so
on, which is then translated by compilers into low-level MSIL code. Using Reflection.Emit, you
avoid the intermediate compilation step because the code emitted is already in its lowest common
denominator form. This certainly boosts the code-generation time. But, the biggest problem is that
developers need to be proficient with MSIL instructions, and this restricts its usage to the hands of
a few developers. It also begs the question as to why anyone would want to dirty their hands with
Reflection.Emit. The primary reason is it provides tighter control to structure the IL code, which is
nearly impossible to achieve from high-level languages. This is similar to system programmers shy-
ing away from the C language and using low-level assembly code to achieve machine-specific
optimizations.
You will now see how classes defined in the System.Reflection.Emit namespace are used to
emit MSIL. We are assuming you are familiar with MSIL syntax. Based on this assumption, we will
now show how to rewrite the sort implementation. Before we delve into the code-level details,
though, the following are the important classes:
  AssemblyBuilder: Defines an assembly.
  ModuleBuilder: Defines a module.
  TypeBuilder: Defines a class.
  ConstructorBuilder: Defines a constructor for a class.
  FieldBuilder: Defines a field for a class.
  EventBuilder: Defines events for a class.
  MethodBuilder: Defines methods for a class.
  PropertyBuilder: Defines properties for a class.
  ILGenerator: Defines MSIL instructions. This class is referenced by both ConstructorBuilder
and MethodBuilder to implement the body of the method.
  OpCodes: Provides field representations of the MSIL instructions used by the ILGenerator
class members.
We will now show how to rewrite the sort example using Reflection.Emit. Listing 8-5 provides
you with the first taste of how to emit raw IL code at runtime.
Listing 8-5. Sorting of Stock Data (Using Reflection.Emit)
using System;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using SharedAssembly;
public class SortByReflectionEmit
{
string fldName;
public SortByReflectionEmit(string fld)
{
fldName = fld;
}440C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
public IComparer GetComparer()
{
AssemblyName asmName = new AssemblyName();
asmName.Name = "SorterAssembly";
//Define a new in-memory assembly
AssemblyBuilder asmBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly
(asmName,AssemblyBuilderAccess.Run);
//Define a new module
ModuleBuilder modBuilder = asmBuilder.DefineDynamicModule("SorterModule");
//Create a new Type, and implement IComparer interface
TypeBuilder typeBuilder = modBuilder.DefineType
("SortCode",TypeAttributes.Public);
typeBuilder.AddInterfaceImplementation(typeof(IComparer));
//Create Compare Method with 2 input arguments and also declare return type
//as int
MethodBuilder methodBuilder = typeBuilder.DefineMethod
("Compare",MethodAttributes.Public | MethodAttributes.Virtual,typeof(int),
new Type[] {typeof(object),typeof(object)});
//Implements IComparer Compare Method
MethodInfo compareMethod = typeof(IComparer).GetMethod("Compare");
typeBuilder.DefineMethodOverride(methodBuilder,compareMethod);
//Generate IL code for the above declared method
ILGenerator ilGenerator = methodBuilder.GetILGenerator();
//Declare two local variables i.e. leftObj and rightObj
ilGenerator.DeclareLocal(typeof(StockData));
ilGenerator.DeclareLocal(typeof(StockData));
//Declare local variable to hold result returned by CompareTo method
ilGenerator.DeclareLocal(typeof(int));
//Cast x object to StockData type, and store it inside local variable
ilGenerator.Emit(OpCodes.Ldarg_1);
ilGenerator.Emit(OpCodes.Isinst,typeof(StockData));
ilGenerator.Emit(OpCodes.Stloc_0);
//Cast y object to StockData type, and store it inside local variable
ilGenerator.Emit(OpCodes.Ldarg_2);
ilGenerator.Emit(OpCodes.Isinst,typeof(StockData));
ilGenerator.Emit(OpCodes.Stloc_1);
//Access field of x object using reflection
FieldInfo xField = typeof(StockData).GetField(fldName);
//Access the field of x object
ilGenerator.Emit(OpCodes.Ldloc_0);
if ( xField.FieldType.IsValueType == true )
ilGenerator.Emit(OpCodes.Ldflda,xField);
else
ilGenerator.Emit(OpCodes.Ldfld,xField);C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 441
//Access field of y object using reflection
FieldInfo yField = typeof(StockData).GetField(fldName);
//Access the field of y object
ilGenerator.Emit(OpCodes.Ldloc_1);
ilGenerator.Emit(OpCodes.Ldfld,yField);
//Boxing Operation in case field value returns a value type
if ( yField.FieldType.IsValueType == true )
{
ilGenerator.Emit(OpCodes.Box,yField.FieldType);
}
//Invoke Compare Method, and return the comparison result
MethodInfo invokeCompare = yField.FieldType.GetMethod("CompareTo",
new Type[]{typeof(object)});
ilGenerator.Emit(OpCodes.Call,invokeCompare);
ilGenerator.Emit(OpCodes.Stloc_2);
Label codeBranch = ilGenerator.DefineLabel();
ilGenerator.Emit(OpCodes.Br_S,codeBranch);
ilGenerator.MarkLabel(codeBranch);
ilGenerator.Emit(OpCodes.Ldloc_2);
ilGenerator.Emit(OpCodes.Ret);
//Create the Type
typeBuilder.CreateType();
//Instantiate the dynamic type
IComparer comparer= asmBuilder.CreateInstance("SortCode",true)
as IComparer;
return comparer;
}
}
The corresponding impact in the main assembly now sorts the list using Reflection.Emit:
using System;
using System.Collections;
using SharedAssembly;
class SortReflectionEmit
{
static void Main(string[] args)
{
ArrayList stockList = new ArrayList();
StockData stkData1 = new StockData();
stkData1.Symbol = "MSFT";
stkData1.AskPrice = 10;
stkData1.BidPrice = 12;
StockData stkData2= new StockData();
stkData2.Symbol = "IBM";
stkData2.AskPrice = 12;
stkData2.BidPrice = 9;442C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
Figure 8-10. Simple arbitrage engine
StockData stkData3 = new StockData();
stkData3.Symbol = "GE";
stkData3.AskPrice = 13;
stkData3.BidPrice = 10;
stockList.Add(stkData1);
stockList.Add(stkData2);
stockList.Add(stkData3);
while(true)
{
Console.WriteLine("Enter name of the field to sort on : ");
string fldName = Console.ReadLine();
SortByReflectionEmit sort = new SortByReflectionEmit(fldName);
stockList.Sort(sort.GetComparer());
Console.WriteLine(fldName +" -----------------------" );
foreach(StockData stkData in stockList)
{
Console.WriteLine("Symbol {0} AskPrice {1} BidPrice {2}
",stkData.Symbol,stkData.AskPrice,stkData.BidPrice);
}
Console.WriteLine("-------------------------------");
}
}
}
Examining the Business-Technology Mapping
The most important element in designing an arbitrage engine is the type of strategy with which the
market participant wants to experiment. The strategy can range from a simple one that has less risk
to a complex one. In either case, the goal is to make money and get the maximum mileage from this
short window of opportunity provided to the participant. Another interesting fact is only a few ven-
dors offer off-the-shelf products that address the arbitrage requirements of an organization. Such
limited support from commercial vendors is because each individual organization has its own require-
ments that are difficult to generalize. Therefore, organizations most of the times tend to settle on
building such engines in-house (see Figure 8-10).
As you know, arbitrage trading is another tactic to make money, but it can be exploited only by
automation. This may start with a simple arbitrage engine that tracks opportunities based on stock
price differences. The first prerequisite in this case is to subscribe to market data from various
exchanges; also, it is important that data is made available in a timely manner. The whole concept ofC H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 443
arbitrage is based on that there are imbalances in stock prices that will last for short period of times.
Therefore, even a fraction of a delay in receiving market data is sufficient to lose such opportunities.
Another way of building an arbitrage engine is by using various arbitrage models (see Figure 8-11).
An arbitrage model contains core logic that seeks out arbitrage opportunities. This logic is usually
complex in nature and is defined using mathematical models and analyzing historical data. The
engine provides a plug-and-play approach where traders have complete freedom to come out with
their own model and then associate it with the engine. Such flexibility often results in the creation
of various models specialized for a particular stock or event. These models are often coded in a pro-
gramming language that traders are comfortable with; most of the time it is C++, but this trend is
changing. Nowadays they are written in C#. Microsoft Excel is the favorite candidate and is an ideal
choice for building calculation-intensive applications.
Figure 8-11. Arbitrage engine architected based on different type of arbitrage models
Considering the popularity of the Office suite, Microsoft released Office Primary Interop Assemblies
(PIA), which allows the seamless integration of .NET applications with Microsoft Office. With the help
of Office PIA, it is possible to define arbitrage models using Excel macro programming features and
then integrate them with engines that are .NET applications. Such mix-and-match capability proves
to be extremely beneficial both to traders and to developers. Developers do not need to worry about
business logic and can concentrate on the infrastructure aspect of the engine such as the faster pro-
cessing of market data, multithreading, and so on. Similarly, traders are not dependent upon developers
and are in complete charge of the underlying business logic. No doubt such separation of responsi-
bility provides much tighter control to traders, but a word of caution is that the performance of the
application needs to be closely examined. As you know, an arbitrage opportunity exists for a very
short interval, so the system must not only capture this opportunity but must also undertake several
computation steps to determine whether this opportunity is favorable and healthy for the business.
This decision-making process needs to be highly optimized; therefore, the code written by traders
needs to be thoroughly reviewed before it is integrated with the system.
Another sophisticated version of an arbitrage engine is to provide a rule-driven interface to
traders (see Figure 8-12). This allows traders to capture all types of arbitrage strategies in the form
of rules. The rules defined are then interpreted by the rule engine, which serves as the execution
engine for the arbitrage strategy. They allow flexibility by externalizing the business logic from the
system logic and representing the logic with rules that are then easy to modify. Rules are defined from
business vocabulary definitions.444C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E
The rule engine consists of design and run-time components. Design-time components provide
the appropriate interface that allows the rules to be defined. These rules are then parsed and validated
to detect both syntax and semantic errors. On the other hand, run-time components look after the
execution aspect of rules, which is achieved by identifying the stock information that the rules are
processed against to produce the desired output. The motivation behind the rule engine is it avoids
the need of translating the business requirements in a procedural instructions language, which is
usually done by developers. With the help of the engine, the task is directly assigned to traders, and
they can directly define the rules in their own business language. Furthermore, to simplify such tasks,
traders are presented with an easy-to-use GUI-based rule management tool.
From an implementation perspective, the rule engine can leverage an automated code-generation
approach where the rules after interpretation are directly translated into a binary executable form.
This obviously results in the faster execution of rules and provides the best of both worlds. Developers
will concentrate on fine-tuning the code-generation aspect, and traders will mobilize their efforts in
defining business logic without knowing its language implementation details.
Automated code generation is a perfect implementation technique in designing and implement-
ing any type of business rule engine. Another area in the financial world where code-generation
techniques come in handy is when building a finite state machine compiler. A finite state machine
is composed of state, transition, and actions. A state represents information, a transition refers to
a change in state, and an action defines the activity that is executed because of a change in state.
Such information when graphically depicted results in a state diagram, and systems are then mod-
eled on this concept. State machine compilers provide GUI-based state modeling tools that allow
you to chart the system states, and then the compiler generates boilerplate code.
Code-generation techniques bring higher productivity to developers, but there is initial invest-
ment in terms of time and resources that need to be deployed. In most projects, it is hard to justify
their usage. Certainly this is true in small-scale projects where using code generation doesn’t seem
to be a viable solution because of the nature of the tasks. For instance, there is no need to consider
a code-generation technique when building a simple arbitrage engine. But when it comes to build-
ing a highly complex arbitrage engine, then the whole concept of code generation falls squarely in
line with a rule engine. Also, when the nature of the task is repetitive and exists in large numbers,
then code generation becomes an extremely useful tool.
Figure 8-12. Rule-based arbitrage engineC H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 445
Summary
In this chapter, we described the following topics:
  We explained the economics behind the equities arbitrage business and how an arbitrageur
attempts to lock and make profit by exploiting price differentials in multiple markets.
  We discussed the various forms of the arbitrage business and showed the basic mathematics
calculation applied to find out a profitable arbitrage.
  Next, we started the journey into various code-generation techniques and how they are
leveraged to automate day-to-day tasks.
  We explained the strengths offered by the CodeDOM framework in writing language-
independent code.
  We illustrated the advantage provided by Reflection.Emit over the .NET CodeDOM.
  We provided a brief overview of using reflection, which enables you to self-introspect .NET
assembly.C H A P T E R 8 ■ E Q U I T Y A R B I T R A G E 445
Summary
In this chapter, we described the following topics:
  We explained the economics behind the equities arbitrage business and how an arbitrageur
attempts to lock and make profit by exploiting price differentials in multiple markets.
  We discussed the various forms of the arbitrage business and showed the basic mathematics
calculation applied to find out a profitable arbitrage.
  Next, we started the journey into various code-generation techniques and how they are
leveraged to automate day-to-day tasks.
  We explained the strengths offered by the CodeDOM framework in writing language-
independent code.
  We illustrated the advantage provided by Reflection.Emit over the .NET CodeDOM.
  We provided a brief overview of using reflection, which enables you to self-introspect .NET
assembly. are presented with an easy-to-use GUI-based rule management tool.
From an implementation perspective, the rule engine can leverage an automated code-generation
approach where the rules after interpretation are directly translated into a binary executable form.
This obviously results in the faster execution of rules and provides the best of both worlds. Developers
will concentrate on fine-tuning the code-generation aspect, and traders will mobilize their efforts in
defining business logic without knowing its language implementation details.
Automated code generation is a perfect implementation technique in designing and implement-
ing any type of business rule engine. Another area in the financial world where code-generation
techniques come in handy is when building a finite state machine compiler. A finite state machine
is composed of state, transition, and actions. A state represents information, a transition refers to
a change in state, and an action defines the activity that is executed because of a change in state.
Such information when graphically depicted results in a state diagram, and systems are then mod-
eled on this concept. State machine compilers provide GUI-based state modeling tools that allow
you to chart the system states, and then the compiler generates boilerplate code.
Code-generation techniques bring higher productivity to developers, but there is initial invest-
ment in terms of time and resources that need to be deployed. In most projects, it is hard to justify
their usage. Certainly this is true in small-scale projects where using code generation doesn’t seem
to be a viable solution because of the nature of the tasks. For instance, there is no need to consider
a code-generation technique when building a simple arbitrage engine. But when it comes to build-
ing a highly complex arbitrage engine, then the whole concept of code generation falls squarely in
line with a rule engine. Also, when the nature of the task is repetitive and exists in large numbers,
then code generation becomes an extremely useful tool.
Figure 8-12. Rule-based arbitrage engine from the
system logic and representing the logic with rules that are then easy to modify. Rules are defined from
business vocabulary definitions.  to construct a language-specific code provider, which in this case is the C#
code provider itself, and transform the abstract code graph into C# source code. The following code
demonstrates this: are defined inside the System.CodeDom.Compiler namespace, and shortly we will discuss
this topic in detail.
To illustrate the implementation aspect of the CodeDOM, we will present the C# code in Listing 8-1,
which represents a custom class of a stock price. It contains attributes such as the name of the stock,
ask price, bid price, and so on. To keep the code simple, we have omitted most of the essential attri-
butes that usually form part of the stock information. ntiation
process includes the dynamic generation and compilation of code, which chews a fair amount of
CPU cycles; therefore, it is always a good programming practice to cache the instance of XmlSeralizer
instead of re-creating it again and again.
With this example, we have completed the discussion of the various forms of code generators.
Now we will cover the real implementation technique that includes a code generator framework
available in the .NET Framework. The rest of the chapter will cover this topic in detail and lay
a strong foundation for building code generator–based solutions. t an opportunity to take a closer look at the
code generated by the Windows Form Designer. Figure 8-3 represents the editor view of the auto-
generated source code. another abstraction level that brings a higher degree of automa-
tion and consistency to day-to-day application development. n operation engine. Although
it will not support all the operational features, the motive is to prove that remoting is an ideal fit for
building these kinds of monitoring applications. However, keep in mind that because the monitoring s to take proactive steps for managing and minimizing risk, especially when the market is
volatile. Sophisticated risk management techniques such as Value at Risk use the data about prices
174
