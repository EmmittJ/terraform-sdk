using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for staging_distribution_dns_names in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontContinuousDeploymentPolicyStagingDistributionDnsNamesBlock : TerraformBlockBase
{
    /// <summary>
    /// The items attribute.
    /// </summary>
    [TerraformProperty("items")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Items { get; set; }

    /// <summary>
    /// The quantity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Quantity is required")]
    [TerraformProperty("quantity")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Quantity { get; set; }

}

/// <summary>
/// Block type for traffic_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Manages a aws_cloudfront_continuous_deployment_policy resource.
/// </summary>
public partial class AwsCloudfrontContinuousDeploymentPolicy : TerraformResource
{
    public AwsCloudfrontContinuousDeploymentPolicy(string name) : base("aws_cloudfront_continuous_deployment_policy", name)
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// Block for staging_distribution_dns_names.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("staging_distribution_dns_names")]
    public TerraformList<TerraformBlock<AwsCloudfrontContinuousDeploymentPolicyStagingDistributionDnsNamesBlock>>? StagingDistributionDnsNames { get; set; }

    /// <summary>
    /// Block for traffic_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("traffic_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlock>>? TrafficConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    [TerraformProperty("last_modified_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModifiedTime { get; }

}
