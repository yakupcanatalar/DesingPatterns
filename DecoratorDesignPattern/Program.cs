using DecoratorDesignPattern;

public class Program
{
    public static void Main(string[] args)
    {
        Product book = new Book();
        Console.WriteLine($"{book.GetDescription()} costs ${book.GetCost()}");

        Product laptop = new Laptop();
        Console.WriteLine($"{laptop.GetDescription()} costs ${laptop.GetCost()}");

        Product watch = new Watch();
        Console.WriteLine($"{watch.GetDescription()} costs ${watch.GetCost()}");

        // Book with gift wrap
        Product giftWrappedBook = new GiftWrap(book);
        Console.WriteLine($"{giftWrappedBook.GetDescription()} costs ${giftWrappedBook.GetCost()}");

        // Book with gift wrap and express shipping
        Product expressGiftWrappedBook = new ExpressShipping(giftWrappedBook);
        Console.WriteLine($"{expressGiftWrappedBook.GetDescription()} costs ${expressGiftWrappedBook.GetCost()}");

        // Book with gift wrap, express shipping, and insured shipping
        Product insuredExpressGiftWrappedBook = new Insured(expressGiftWrappedBook);
        Console.WriteLine($"{insuredExpressGiftWrappedBook.GetDescription()} costs ${insuredExpressGiftWrappedBook.GetCost()}");

    }
}
