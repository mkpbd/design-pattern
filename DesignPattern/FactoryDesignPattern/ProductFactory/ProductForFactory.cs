using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.ProductFactory
{
    /**
     * 
     * Factory design pattern একটি সফটওয়্যার ডিজাইন প্যাটার্ন যা ওপেন ক্লোজড প্রিন্সিপল অনুসরণ করে। 
     * এটি এমন একটি ডিজাইন প্যাটার্ন যা নতুন অবজেক্টগুলির তৈরি প্রক্রিয়াটি একটি স্যাবক্লাস থেকে বিচ্যুত করে এবং অবজেক্টগুলির প্রক্রিয়াটি সাবক্লাস দিয়ে বিশেষভাবে মান্যতা দেয়।
     * 
     * ProductFactory ক্লাস একটি ফ্যাক্টরি ক্লাস যা নতুন প্রোডাক্ট তৈরির জন্য CreateProduct মেথড সরবরাহ করে। 
     * মূল Product ক্লাসের নতুন অবজেক্টগুলি এই ফ্যাক্টরি ক্লাসের মাধ্যমে তৈরি হয় এবং প্রোডাক্টের নাম এবং মূল্য সেট করা হয়।
     * 
     * 
     */
    public class ProductForFactory
    {
        // একটি ফ্যাক্টরি মেথড যা নতুন প্রোডাক্ট তৈরি করে ফেরত দেয়
        public Product CreateProduct(string name, double price)
        {
            Product product = new Product
            {
                Name = name,
                Price = price
            };
            return product;
        }
    }
}
