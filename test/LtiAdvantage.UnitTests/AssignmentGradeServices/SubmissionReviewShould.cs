using System.Collections.Generic;
using System.Linq;
using LtiAdvantage.AssignmentGradeServices;
using Newtonsoft.Json;
using Xunit;

namespace LtiAdvantage.UnitTests.AssignmentGradeServices
{
    public class SubmissionReviewShould
    {
        /// <summary>
        /// Deserialize the example submission review from IMS documentation and check values.
        /// See https://www.imsglobal.org/spec/lti-sr/v1p0#availability-and-placement-of-submission-review-request-message
        /// </summary>
        [Fact]
        public void DeserializeFromValidJson()
        {
            var referenceJson = TestUtils.LoadReferenceJsonFile("SubmissionReview");
            var submissionReview = JsonConvert.DeserializeObject<SubmissionReview>(referenceJson);

            Assert.True(submissionReview.ReviewableStatus.SequenceEqual(new List<ActivityProgress>
            {
                ActivityProgress.InProgress, ActivityProgress.Submitted, ActivityProgress.Completed
            }));
            Assert.Equal("Open My Tool Viewer", submissionReview.Label);
            Assert.Equal("https://platform.example.com/act/849023/sub", submissionReview.Url);
            Assert.NotNull(submissionReview.Custom);
            Assert.Contains("action", (IDictionary<string, string>)submissionReview.Custom);
            Assert.Equal("review", submissionReview.Custom["action"]);
            Assert.Contains("a_id", (IDictionary<string, string>)submissionReview.Custom);
            Assert.Equal("23942", submissionReview.Custom["a_id"]);
        }

        /// <summary>
        /// Deserialize the example submission review from IMS documentation and then serialize back to JSON
        /// and compare JSON.
        /// </summary>
        [Fact]
        public void SerializeToValidJson()
        {
            var referenceJson = TestUtils.LoadReferenceJsonFile("SubmissionReview");
            var submissionReview = JsonConvert.DeserializeObject<SubmissionReview>(referenceJson);
            var submissionReviewJson = JsonConvert.SerializeObject(submissionReview);

            JsonAssertions.Equal(referenceJson, submissionReviewJson);
        }
    }
}
