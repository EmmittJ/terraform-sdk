using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_realtime_log_config.
/// </summary>
public class AwsCloudfrontRealtimeLogConfigDataSource : TerraformDataSource
{
    public AwsCloudfrontRealtimeLogConfigDataSource(string name) : base("aws_cloudfront_realtime_log_config", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The fields attribute.
    /// </summary>
    [TerraformPropertyName("fields")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Fields => new TerraformReference(this, "fields");

    /// <summary>
    /// The sampling_rate attribute.
    /// </summary>
    [TerraformPropertyName("sampling_rate")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SamplingRate => new TerraformReference(this, "sampling_rate");

}
