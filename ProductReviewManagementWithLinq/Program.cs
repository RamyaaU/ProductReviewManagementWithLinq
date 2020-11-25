﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductReviewManagementWithLinq
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Product review management!");

            //UC1
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 2, UserID = 1, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 3, UserID = 2, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 4, UserID = 2, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 5, UserID = 3, Rating = 2, Review = "nice", isLike = false },
                new ProductReview() { ProductID = 6, UserID = 4, Rating = 1, Review = "Bad", isLike = true },
                new ProductReview() { ProductID = 1, UserID = 3, Rating = 1.5, Review = "nice", isLike = false },
                new ProductReview() { ProductID = 11, UserID = 10, Rating = 4, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 10, UserID = 10, Rating = 4, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 12, UserID = 10, Rating = 4, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 13, UserID = 10, Rating = 4, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 14, UserID = 10, Rating = 4, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 15, UserID = 10, Rating = 4, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 16, UserID = 10, Rating = 4, Review = "nice", isLike = true },
            };

           // foreach (var list in productReviewList)
           // {
           //     Console.WriteLine("ProductID: " + list.ProductID + "UserId: " + list.UserID + "Rating: " + list.Rating
           //         + "Review: " + list.Review + "IsLike: " + list.isLike);
           // }

            //object of management class
            Management management = new Management();
            //calling top record and passing product review list
            management.TopRecords(productReviewList);
        }
    }
}
