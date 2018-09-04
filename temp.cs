using System;

namespace temp {
	//ITEMS
    class Item {																			//items data
    	public int itemID;
    	public int itemQuantity;
    	public float itemPrice;
    }

    //CART
    interface IShoppingCart {
    	public void AddToCart(item itemObj, int NoOfItems);
    	public void RemoveFromCart(item itemObj, int NoOfItems);
    	public void ShowCart();
    }
    class Cart : IShoppingCart{
    	public int totalItemsInCart;
    	public float totalPriceOfItemsInCart;
    	public bool IsCartEmpty;
    	public void AddToCart(item itemObj, int NoOfItems);
    	public void RemoveFromCart(item itemObj, int NoOfItems);
    	public void ShowCart();
    }

    //CHECKOUT
    interface ICheckout{
    	public bool ProceedToCheckOut(bool IsCartEmpty);
    }
	class Checkout : ICheckout{
		public bool ProceedToCheckOut(bool IsCartEmpty);
	}

	//PAYMENT
	class PaymentMethod {
		bool IfPaymentComplete;
		public bool IfPaymentComplete(bool IfPaymentComplete)
	}
    class PaymentMethodCOD : PaymentMethod {
    	public void CashOnDelivery(int totalItemsInCart, float totalPriceOfItemsInCart);
    }
	class PaymentMethodOnline : PaymentMethod {
		public void OnlinePayment(int totalItemsInCart, float totalPriceOfItemsInCart);
	}

	//ORDER
	interface IOrder{
		public bool OrderConfirmation(bool IfPaymentComplete);
	}
    class Order {
    	int OrderId;
    	public bool OrderConfirmation(bool IfPaymentComplete);
    }    
}
