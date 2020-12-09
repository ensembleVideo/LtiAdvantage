using System.Collections.Generic;
using Newtonsoft.Json;

namespace LtiAdvantage.AssignmentGradeServices
{
    /// <summary>
    /// Indicator that submissions for a line item are reviewable.
    /// </summary>
    public class SubmissionReview
    {
        /// <summary>
        /// Required list of AGS activity progress statuses indicating when a submission review link should be displayed.
        /// </summary>
        [JsonProperty("reviewableStatus")]
        public IEnumerable<ActivityProgress> ReviewableStatus { get; set; }

        /// <summary>
        /// Optional label.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// Optional url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Key/value custom parameters.
        /// </summary>
        [JsonProperty("custom")]
        public Dictionary<string, string> Custom { get; set; }
    }
}
