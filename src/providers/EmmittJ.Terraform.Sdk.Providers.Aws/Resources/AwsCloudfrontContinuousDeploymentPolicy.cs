using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for staging_distribution_dns_names in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontContinuousDeploymentPolicyStagingDistributionDnsNamesBlock : ITerraformBlock
{
    /// <summary>
    /// The items attribute.
    /// </summary>
    [TerraformPropertyName("items")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Items { get; set; }

    /// <summary>
    /// The quantity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Quantity is required")]
    [TerraformPropertyName("quantity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Quantity { get; set; }

}

/// <summary>
/// Block type for traffic_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Manages a aws_cloudfront_continuous_deployment_policy resource.
/// </summary>
public class AwsCloudfrontContinuousDeploymentPolicy : TerraformResource
{
    public AwsCloudfrontContinuousDeploymentPolicy(string name) : base("aws_cloudfront_continuous_deployment_policy", name)
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// Block for staging_distribution_dns_names.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("staging_distribution_dns_names")]
    public TerraformList<TerraformBlock<AwsCloudfrontContinuousDeploymentPolicyStagingDistributionDnsNamesBlock>>? StagingDistributionDnsNames { get; set; } = new();

    /// <summary>
    /// Block for traffic_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("traffic_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlock>>? TrafficConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModifiedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified_time");

}
