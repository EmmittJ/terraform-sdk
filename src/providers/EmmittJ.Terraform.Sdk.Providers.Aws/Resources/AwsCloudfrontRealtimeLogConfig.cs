using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontRealtimeLogConfigEndpointBlock : TerraformBlockBase
{
    /// <summary>
    /// The stream_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamType is required")]
    [TerraformProperty("stream_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StreamType { get; set; }

}

/// <summary>
/// Manages a aws_cloudfront_realtime_log_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudfrontRealtimeLogConfig : TerraformResource
{
    public AwsCloudfrontRealtimeLogConfig(string name) : base("aws_cloudfront_realtime_log_config", name)
    {
    }

    /// <summary>
    /// The fields attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fields is required")]
    [TerraformProperty("fields")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Fields { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The sampling_rate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SamplingRate is required")]
    [TerraformProperty("sampling_rate")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> SamplingRate { get; set; }

    /// <summary>
    /// Block for endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Endpoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Endpoint block(s) allowed")]
    [TerraformProperty("endpoint")]
    public TerraformList<TerraformBlock<AwsCloudfrontRealtimeLogConfigEndpointBlock>>? Endpoint { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
