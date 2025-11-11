using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cache_behavior in .
/// Nesting mode: set
/// </summary>
public class AwsLightsailDistributionCacheBehaviorBlock
{
    /// <summary>
    /// The cache behavior for the specified path.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Behavior is required")]
    [TerraformPropertyName("behavior")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Behavior { get; set; }

    /// <summary>
    /// The path to a directory or file to cached, or not cache. Use an asterisk symbol to specify wildcard directories (path/to/assets/*), and file types (*.html, *jpg, *js). Directories and file paths are case-sensitive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformPropertyName("path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Path { get; set; }

}

/// <summary>
/// Block type for cache_behavior_settings in .
/// Nesting mode: list
/// </summary>
public class AwsLightsailDistributionCacheBehaviorSettingsBlock
{
    /// <summary>
    /// The HTTP methods that are processed and forwarded to the distribution&#39;s origin.
    /// </summary>
    [TerraformPropertyName("allowed_http_methods")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AllowedHttpMethods { get; set; }

    /// <summary>
    /// The HTTP method responses that are cached by your distribution.
    /// </summary>
    [TerraformPropertyName("cached_http_methods")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CachedHttpMethods { get; set; }

    /// <summary>
    /// The default amount of time that objects stay in the distribution&#39;s cache before the distribution forwards another request to the origin to determine whether the content has been updated.
    /// </summary>
    [TerraformPropertyName("default_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DefaultTtl { get; set; }

    /// <summary>
    /// The maximum amount of time that objects stay in the distribution&#39;s cache before the distribution forwards another request to the origin to determine whether the object has been updated.
    /// </summary>
    [TerraformPropertyName("maximum_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaximumTtl { get; set; }

    /// <summary>
    /// The minimum amount of time that objects stay in the distribution&#39;s cache before the distribution forwards another request to the origin to determine whether the object has been updated.
    /// </summary>
    [TerraformPropertyName("minimum_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinimumTtl { get; set; }

}

/// <summary>
/// Block type for default_cache_behavior in .
/// Nesting mode: list
/// </summary>
public class AwsLightsailDistributionDefaultCacheBehaviorBlock
{
    /// <summary>
    /// The cache behavior of the distribution.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Behavior is required")]
    [TerraformPropertyName("behavior")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Behavior { get; set; }

}

/// <summary>
/// Block type for origin in .
/// Nesting mode: list
/// </summary>
public class AwsLightsailDistributionOriginBlock
{
    /// <summary>
    /// The name of the origin resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The protocol that your Amazon Lightsail distribution uses when establishing a connection with your origin to pull content.
    /// </summary>
    [TerraformPropertyName("protocol_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProtocolPolicy { get; set; }

    /// <summary>
    /// The AWS Region name of the origin resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    [TerraformPropertyName("region_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RegionName { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLightsailDistributionTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_lightsail_distribution resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLightsailDistribution : TerraformResource
{
    public AwsLightsailDistribution(string name) : base("aws_lightsail_distribution", name)
    {
    }

    /// <summary>
    /// The bundle ID to use for the distribution.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    [TerraformPropertyName("bundle_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BundleId { get; set; }

    /// <summary>
    /// The name of the SSL/TLS certificate attached to the distribution, if any.
    /// </summary>
    [TerraformPropertyName("certificate_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificateName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The IP address type of the distribution.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IpAddressType { get; set; }

    /// <summary>
    /// Indicates whether the distribution is enabled.
    /// </summary>
    [TerraformPropertyName("is_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IsEnabled { get; set; }

    /// <summary>
    /// The name of the distribution.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for cache_behavior.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("cache_behavior")]
    public TerraformSet<TerraformBlock<AwsLightsailDistributionCacheBehaviorBlock>>? CacheBehavior { get; set; }

    /// <summary>
    /// Block for cache_behavior_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheBehaviorSettings block(s) allowed")]
    [TerraformPropertyName("cache_behavior_settings")]
    public TerraformList<TerraformBlock<AwsLightsailDistributionCacheBehaviorSettingsBlock>>? CacheBehaviorSettings { get; set; }

    /// <summary>
    /// Block for default_cache_behavior.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultCacheBehavior is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultCacheBehavior block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultCacheBehavior block(s) allowed")]
    [TerraformPropertyName("default_cache_behavior")]
    public TerraformList<TerraformBlock<AwsLightsailDistributionDefaultCacheBehaviorBlock>>? DefaultCacheBehavior { get; set; }

    /// <summary>
    /// Block for origin.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Origin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Origin block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Origin block(s) allowed")]
    [TerraformPropertyName("origin")]
    public TerraformList<TerraformBlock<AwsLightsailDistributionOriginBlock>>? Origin { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsLightsailDistributionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The alternate domain names of the distribution.
    /// </summary>
    [TerraformPropertyName("alternative_domain_names")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AlternativeDomainNames => new TerraformReference(this, "alternative_domain_names");

    /// <summary>
    /// The Amazon Resource Name (ARN) of the distribution.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The timestamp when the distribution was created.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The domain name of the distribution.
    /// </summary>
    [TerraformPropertyName("domain_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DomainName => new TerraformReference(this, "domain_name");

    /// <summary>
    /// An object that describes the location of the distribution, such as the AWS Region and Availability Zone.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The public DNS of the origin.
    /// </summary>
    [TerraformPropertyName("origin_public_dns")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OriginPublicDns => new TerraformReference(this, "origin_public_dns");

    /// <summary>
    /// The Lightsail resource type (e.g., Distribution).
    /// </summary>
    [TerraformPropertyName("resource_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceType => new TerraformReference(this, "resource_type");

    /// <summary>
    /// The status of the distribution.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The support code. Include this code in your email to support when you have questions about your Lightsail distribution. This code enables our support team to look up your Lightsail information more easily.
    /// </summary>
    [TerraformPropertyName("support_code")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SupportCode => new TerraformReference(this, "support_code");

}
