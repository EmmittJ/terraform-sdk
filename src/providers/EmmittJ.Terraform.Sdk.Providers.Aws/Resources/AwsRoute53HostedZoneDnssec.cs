using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRoute53HostedZoneDnssecTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_route53_hosted_zone_dnssec resource.
/// </summary>
public partial class AwsRoute53HostedZoneDnssec : TerraformResource
{
    public AwsRoute53HostedZoneDnssec(string name) : base("aws_route53_hosted_zone_dnssec", name)
    {
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostedZoneId is required")]
    [TerraformProperty("hosted_zone_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HostedZoneId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The signing_status attribute.
    /// </summary>
    [TerraformProperty("signing_status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SigningStatus { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsRoute53HostedZoneDnssecTimeoutsBlock>? Timeouts { get; set; }

}
