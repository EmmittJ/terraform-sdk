using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_realtime_log_config.
/// </summary>
public partial class AwsCloudfrontRealtimeLogConfigDataSource : TerraformDataSource
{
    public AwsCloudfrontRealtimeLogConfigDataSource(string name) : base("aws_cloudfront_realtime_log_config", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Endpoint { get; }

    /// <summary>
    /// The fields attribute.
    /// </summary>
    [TerraformProperty("fields")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> Fields { get; }

    /// <summary>
    /// The sampling_rate attribute.
    /// </summary>
    [TerraformProperty("sampling_rate")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SamplingRate { get; }

}
