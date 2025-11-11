using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cache_behavior in .
/// Nesting mode: set
/// </summary>
public partial class AwsLightsailDistributionCacheBehaviorBlock : TerraformBlockBase
{
    /// <summary>
    /// The cache behavior for the specified path.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Behavior is required")]
    [TerraformProperty("behavior")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Behavior { get; set; }

    /// <summary>
    /// The path to a directory or file to cached, or not cache. Use an asterisk symbol to specify wildcard directories (path/to/assets/*), and file types (*.html, *jpg, *js). Directories and file paths are case-sensitive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Path { get; set; }

}

/// <summary>
/// Block type for cache_behavior_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsLightsailDistributionCacheBehaviorSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The HTTP methods that are processed and forwarded to the distribution&#39;s origin.
    /// </summary>
    [TerraformProperty("allowed_http_methods")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AllowedHttpMethods { get; set; }

    /// <summary>
    /// The HTTP method responses that are cached by your distribution.
    /// </summary>
    [TerraformProperty("cached_http_methods")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CachedHttpMethods { get; set; }

    /// <summary>
    /// The default amount of time that objects stay in the distribution&#39;s cache before the distribution forwards another request to the origin to determine whether the content has been updated.
    /// </summary>
    [TerraformProperty("default_ttl")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? DefaultTtl { get; set; }

    /// <summary>
    /// The maximum amount of time that objects stay in the distribution&#39;s cache before the distribution forwards another request to the origin to determine whether the object has been updated.
    /// </summary>
    [TerraformProperty("maximum_ttl")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaximumTtl { get; set; }

    /// <summary>
    /// The minimum amount of time that objects stay in the distribution&#39;s cache before the distribution forwards another request to the origin to determine whether the object has been updated.
    /// </summary>
    [TerraformProperty("minimum_ttl")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinimumTtl { get; set; }

}

/// <summary>
/// Block type for default_cache_behavior in .
/// Nesting mode: list
/// </summary>
public partial class AwsLightsailDistributionDefaultCacheBehaviorBlock : TerraformBlockBase
{
    /// <summary>
    /// The cache behavior of the distribution.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Behavior is required")]
    [TerraformProperty("behavior")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Behavior { get; set; }

}

/// <summary>
/// Block type for origin in .
/// Nesting mode: list
/// </summary>
public partial class AwsLightsailDistributionOriginBlock : TerraformBlockBase
{
    /// <summary>
    /// The name of the origin resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The protocol that your Amazon Lightsail distribution uses when establishing a connection with your origin to pull content.
    /// </summary>
    [TerraformProperty("protocol_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProtocolPolicy { get; set; }

    /// <summary>
    /// The AWS Region name of the origin resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    [TerraformProperty("region_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RegionName { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsLightsailDistributionTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_lightsail_distribution resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsLightsailDistribution : TerraformResource
{
    public AwsLightsailDistribution(string name) : base("aws_lightsail_distribution", name)
    {
    }

    /// <summary>
    /// The bundle ID to use for the distribution.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    [TerraformProperty("bundle_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BundleId { get; set; }

    /// <summary>
    /// The name of the SSL/TLS certificate attached to the distribution, if any.
    /// </summary>
    [TerraformProperty("certificate_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CertificateName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The IP address type of the distribution.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IpAddressType { get; set; }

    /// <summary>
    /// Indicates whether the distribution is enabled.
    /// </summary>
    [TerraformProperty("is_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IsEnabled { get; set; }

    /// <summary>
    /// The name of the distribution.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for cache_behavior.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("cache_behavior")]
    public TerraformSet<TerraformBlock<AwsLightsailDistributionCacheBehaviorBlock>>? CacheBehavior { get; set; }

    /// <summary>
    /// Block for cache_behavior_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheBehaviorSettings block(s) allowed")]
    [TerraformProperty("cache_behavior_settings")]
    public TerraformList<TerraformBlock<AwsLightsailDistributionCacheBehaviorSettingsBlock>>? CacheBehaviorSettings { get; set; }

    /// <summary>
    /// Block for default_cache_behavior.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultCacheBehavior is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultCacheBehavior block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultCacheBehavior block(s) allowed")]
    [TerraformProperty("default_cache_behavior")]
    public TerraformList<TerraformBlock<AwsLightsailDistributionDefaultCacheBehaviorBlock>>? DefaultCacheBehavior { get; set; }

    /// <summary>
    /// Block for origin.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Origin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Origin block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Origin block(s) allowed")]
    [TerraformProperty("origin")]
    public TerraformList<TerraformBlock<AwsLightsailDistributionOriginBlock>>? Origin { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsLightsailDistributionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The alternate domain names of the distribution.
    /// </summary>
    [TerraformProperty("alternative_domain_names")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AlternativeDomainNames { get; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the distribution.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The timestamp when the distribution was created.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The domain name of the distribution.
    /// </summary>
    [TerraformProperty("domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DomainName { get; }

    /// <summary>
    /// An object that describes the location of the distribution, such as the AWS Region and Availability Zone.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Location { get; }

    /// <summary>
    /// The public DNS of the origin.
    /// </summary>
    [TerraformProperty("origin_public_dns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OriginPublicDns { get; }

    /// <summary>
    /// The Lightsail resource type (e.g., Distribution).
    /// </summary>
    [TerraformProperty("resource_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceType { get; }

    /// <summary>
    /// The status of the distribution.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The support code. Include this code in your email to support when you have questions about your Lightsail distribution. This code enables our support team to look up your Lightsail information more easily.
    /// </summary>
    [TerraformProperty("support_code")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SupportCode { get; }

}
