# 第二章 订单撮合引擎

The beauty of time is that it controls the construction and destruction of each instance of the human type.
时间的优雅之处在于它可以掌控所有人类的生死

 
## 理解订单撮合的业务实体

下文将介绍订单撮合殷勤的业务实体。

### 高效订单撮合的需求

The two primary objectives in the financial marketplace are to keep transaction costs at a minimum and to avoid credit defaults. Although several market practices have been devised to fulfill these objectives, efficient order matching is an important factor for achieving these goals.
A market's liquidity is measured by how easily a trader can acquire (or dispose of) a financial asset and by the cost associated with each transaction. For example, if you wanted to sell a house,you could place an advertisement or go through a real estate agent. Both of these options have costs associated with them. It may also take a month to locate a buyer who is willing to match the price you desire. In this case, the house is considered to be relatively illiquid. But imagine a marketplace where all sellers and buyers of houses in the city came together in one area and tried to find a match-the search would be easier, the chances for finding a buyer would be greater, and the convergence of all buyers and sellers would result in price discovery and hence better prices. In this case, the house is considered highly liquid. If you extend this example to a marketplace where company instruments(shares and debt instruments) are traded, you get a stock exchange, as introduced in Chapter 1. To avoid search costs (and of course to enforce other legal statutes), buyers and sellers come together in a stock exchange on a common platform to transact. Since many buyers and sellers are present at any point in time, searching for a counterpart for an order is relatively easy.
An order is an intention to enter into a transaction. Each order has certain characteristics such as type of security, quantity, price, and so on. Initiators of orders notionally announce their willingness to transact with the specified parameters.
Each player in the market wants to get the best possible price. There is a huge scramble to get one's order executed at the right time and at the best available market price. Efficient order matching is thus a highly desirable tenet of an advanced market.
Also, anonymity is considered good for a financial market. This means traders do not know any information about the people with whom they are trading. This is desirable when the participants in the market do not have the same financial strength and when it becomes important for the market to protect the interests of the small players. Anonymity also prevents large players from exerting undue influence on the trade conditions. In such a situation, to protect the integrity of the market,precautions must be taken to ensure that no credit defaults take place. As mentioned in Chapter 1,this is the job of a clearing corporation, which takes away the credit risk concerns of large players through novation. This process also takes care of matching large orders with several potential small players.


金融市场两个主要的目标是保持交易成本的最小化和避免信用违约，


### 参与者：交易所和经纪商

让我们看看撮合过程中有哪些参与者。



### 订单类型

以下是最常见的订单类型：

* Good till cancelled(GTC):
* Good till date(GTD):
* Immediate or cancel(IOC):
* Price conditions/limit price order:限价单
* 市价单：这种订单允许以订单发出时的买卖最优价成交，
* 止损单：止损单允许交易者
* 
以上这些订单，其行为由一系列的属性确定

### 订单优先规则


 
