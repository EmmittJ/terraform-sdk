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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Endpoint => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The fields attribute.
    /// </summary>
    [TerraformPropertyName("fields")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Fields => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "fields");

    /// <summary>
    /// The sampling_rate attribute.
    /// </summary>
    [TerraformPropertyName("sampling_rate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SamplingRate => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "sampling_rate");

}
