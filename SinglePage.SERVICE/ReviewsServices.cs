using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;
using SinglePage.DTO;
using SinglePage.ORM.Data;
using SinglePage.REPOSITORY;

namespace SinglePage.SERVICE
{
    public class ReviewsServices
    {
        ReviewsRepository reviewsRepository;

        public ReviewsServices()
        {
            if (reviewsRepository==null)
            {
                reviewsRepository = new ReviewsRepository();
            }
        }

        public void AddReviewsServices(ReviewsDTO entity)
        {
            Reviews reviews = new Reviews
            {
                ReviewName = entity.ReviewName,
                ReviewSurName = entity.ReviewSurName,
                Review = entity.Review
            };

            reviewsRepository.Add(reviews);
        }

        public void UpdateReviewsServices(ReviewsDTO entity)
        {
            var result = reviewsRepository.GetAll().Where(x => x.ReviewId == entity.ReviewId).FirstOrDefault();

            result.ReviewName = entity.ReviewName;
            result.ReviewSurName = entity.ReviewSurName;
            result.Review = entity.Review;

            reviewsRepository.Update(result);
        }

        public void DeleteReviewsServices(ReviewsDTO entity)
        {
            var result = reviewsRepository.GetAll().Where(x => x.ReviewId == entity.ReviewId).FirstOrDefault();

            result.ReviewName = entity.ReviewName;
            result.ReviewSurName = entity.ReviewSurName;
            result.Review = entity.Review;

            reviewsRepository.Delete(result);
        }
        public bool DeleteReviewsServicesByID(int id)
        {
            return reviewsRepository.DeletebyEntity(x => x.ReviewId == id);
        }

        public IEnumerable<ReviewsDTO> GetReviewsServices()
        {
            return reviewsRepository.GetAll().Select(x => new ReviewsDTO
            {
                ReviewId = x.ReviewId,
                ReviewName = x.ReviewName,
                ReviewSurName = x.ReviewSurName,
                Review = x.Review
            }).ToList();
        }
    }
}
