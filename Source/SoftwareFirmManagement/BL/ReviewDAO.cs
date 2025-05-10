using SoftwareFirmManagement.DL;
using System;

namespace SoftwareFirmManagement.BL
{
    class ReviewDAO
    {
        int _ReviewId;
        int _OrderId;
        string _ReviewerName;
        int _Stars;
        DateTime _Date;
        string _Description;

        public int ReviewId { get { return _ReviewId; } set { _ReviewId = value; } }
        public int OrderId { get { return _OrderId; } set { _OrderId = value; } }
        public string ReviewerName { get { return _ReviewerName; } set { _ReviewerName = value; } }
        public int Stars { get { return _Stars; } set { _Stars = value; } }
        public string Description { get { return _Description; } set { _Description = value; } }
        public DateTime Date { get { return _Date; } set { _Date = value; } }

        public ReviewDAO() { }

        public ReviewDAO(int review_id, int order_id, string reviewer_name, int stars, DateTime date, string description)
        {
            ReviewId = review_id;
            OrderId = order_id;
            ReviewerName = reviewer_name;
            Stars = stars;
            Date = date;
            Description = description;
        }
        public ReviewDAO(int order_id, string reviewer_name, int stars, DateTime date, string description)
        {
            OrderId = order_id;
            ReviewerName = reviewer_name;
            Stars = stars;
            Date = date;
            Description = description;
        }
        public ReviewDAO(string reviewer_name, int stars, DateTime date, string description)
        {
            ReviewerName = reviewer_name;
            Stars = stars;
            Date = date;
            Description = description;
        }
        public static bool Check(ReviewDAO review)
        {
            if (review == null)
            {
                throw new ArgumentNullException();
            }
            if (review.Stars < 1 && review.Stars > 5)
            {
                throw new Exception("Stars should be between 1 and 5");
            }
            if (review.Date != DateTime.Now)
            {
                throw new Exception("Date should be current date");
            }
            if (review.Description == null || review.Description == "" || review.Description == "Description")
            {
                throw new Exception("Description should not be empty");
            }
            if (review.ReviewerName == null || review.ReviewerName == "" || review.ReviewerName == "ReviewerName")
            {
                throw new Exception("Reviewer should not be empty");
            }
            return true;
        }
        public static bool AddReview(ReviewDAO review)
        {
            try
            {
                if (Check(review))
                {
                    ReviewDL.AddReviewToDatabase(review);
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error in adding review", e);
            }
            return false;

        }
        public static bool UpdateReview(ReviewDAO review)
        {
            try
            {
                if (Check(review))
                {
                    ReviewDL.UpdateReviewInDatabase(review);
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error in updating review", e);
            }
            return false;
        }
        public static bool DeleteReview(int reviewId)
        {
            try
            {
                ReviewDL.DeleteReviewFromDatabase(reviewId);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error in deleting review", e);
            }
            //return false;
        }
    }
}
