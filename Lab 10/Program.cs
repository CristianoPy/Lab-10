
using Lab_10;

Money money = new Money();
Card card = new Card();
Contactless contactless = new Contactless();

Cash_Register cs = new Cash_Register();
cs.PayMoney(money);
cs.PayCard(card);
cs.PayContactless(contactless);
