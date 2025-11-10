using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cache_behavior in .
/// Nesting mode: set
/// </summary>
public class AwsLightsailDistributionCacheBehaviorBlock : TerraformBlock
{
    /// <summary>
    /// The cache behavior for the specified path.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Behavior is required")]
    public required TerraformProperty<string> Behavior
    {
        set => SetProperty("behavior", value);
    }

    /// <summary>
    /// The path to a directory or file to cached, or not cache. Use an asterisk symbol to specify wildcard directories (path/to/assets/*), and file types (*.html, *jpg, *js). Directories and file paths are case-sensitive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        set => SetProperty("path", value);
    }

}

/// <summary>
/// Block type for cache_behavior_settings in .
/// Nesting mode: list
/// </summary>
public class AwsLightsailDistributionCacheBehaviorSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The HTTP methods that are processed and forwarded to the distribution&#39;s origin.
    /// </summary>
    public TerraformProperty<string>? AllowedHttpMethods
    {
        set => SetProperty("allowed_http_methods", value);
    }

    /// <summary>
    /// The HTTP method responses that are cached by your distribution.
    /// </summary>
    public TerraformProperty<string>? CachedHttpMethods
    {
        set => SetProperty("cached_http_methods", value);
    }

    /// <summary>
    /// The default amount of time that objects stay in the distribution&#39;s cache before the distribution forwards another request to the origin to determine whether the content has been updated.
    /// </summary>
    public TerraformProperty<double>? DefaultTtl
    {
        set => SetProperty("default_ttl", value);
    }

    /// <summary>
    /// The maximum amount of time that objects stay in the distribution&#39;s cache before the distribution forwards another request to the origin to determine whether the object has been updated.
    /// </summary>
    public TerraformProperty<double>? MaximumTtl
    {
        set => SetProperty("maximum_ttl", value);
    }

    /// <summary>
    /// The minimum amount of time that objects stay in the distribution&#39;s cache before the distribution forwards another request to the origin to determine whether the object has been updated.
    /// </summary>
    public TerraformProperty<double>? MinimumTtl
    {
        set => SetProperty("minimum_ttl", value);
    }

}

/// <summary>
/// Block type for default_cache_behavior in .
/// Nesting mode: list
/// </summary>
public class AwsLightsailDistributionDefaultCacheBehaviorBlock : TerraformBlock
{
    /// <summary>
    /// The cache behavior of the distribution.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Behavior is required")]
    public required TerraformProperty<string> Behavior
    {
        set => SetProperty("behavior", value);
    }

}

/// <summary>
/// Block type for origin in .
/// Nesting mode: list
/// </summary>
public class AwsLightsailDistributionOriginBlock : TerraformBlock
{
    /// <summary>
    /// The name of the origin resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The protocol that your Amazon Lightsail distribution uses when establishing a connection with your origin to pull content.
    /// </summary>
    public TerraformProperty<string>? ProtocolPolicy
    {
        set => SetProperty("protocol_policy", value);
    }

    /// <summary>
    /// The AWS Region name of the origin resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    public required TerraformProperty<string> RegionName
    {
        set => SetProperty("region_name", value);
    }

    /// <summary>
    /// The resource type of the origin resource (e.g., Instance).
    /// </summary>
    public TerraformProperty<string>? ResourceType
    {
        set => SetProperty("resource_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLightsailDistributionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_lightsail_distribution resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLightsailDistribution : TerraformResource
{
    public AwsLightsailDistribution(string name) : base("aws_lightsail_distribution", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("alternative_domain_names");
        SetOutput("arn");
        SetOutput("created_at");
        SetOutput("domain_name");
        SetOutput("location");
        SetOutput("origin_public_dns");
        SetOutput("resource_type");
        SetOutput("status");
        SetOutput("support_code");
        SetOutput("bundle_id");
        SetOutput("certificate_name");
        SetOutput("id");
        SetOutput("ip_address_type");
        SetOutput("is_enabled");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The bundle ID to use for the distribution.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    public required TerraformProperty<string> BundleId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bundle_id");
        set => SetProperty("bundle_id", value);
    }

    /// <summary>
    /// The name of the SSL/TLS certificate attached to the distribution, if any.
    /// </summary>
    public TerraformProperty<string> CertificateName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_name");
        set => SetProperty("certificate_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The IP address type of the distribution.
    /// </summary>
    public TerraformProperty<string> IpAddressType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_address_type");
        set => SetProperty("ip_address_type", value);
    }

    /// <summary>
    /// Indicates whether the distribution is enabled.
    /// </summary>
    public TerraformProperty<bool> IsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_enabled");
        set => SetProperty("is_enabled", value);
    }

    /// <summary>
    /// The name of the distribution.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for cache_behavior.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsLightsailDistributionCacheBehaviorBlock>? CacheBehavior
    {
        set => SetProperty("cache_behavior", value);
    }

    /// <summary>
    /// Block for cache_behavior_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheBehaviorSettings block(s) allowed")]
    public List<AwsLightsailDistributionCacheBehaviorSettingsBlock>? CacheBehaviorSettings
    {
        set => SetProperty("cache_behavior_settings", value);
    }

    /// <summary>
    /// Block for default_cache_behavior.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultCacheBehavior is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultCacheBehavior block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultCacheBehavior block(s) allowed")]
    public List<AwsLightsailDistributionDefaultCacheBehaviorBlock>? DefaultCacheBehavior
    {
        set => SetProperty("default_cache_behavior", value);
    }

    /// <summary>
    /// Block for origin.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Origin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Origin block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Origin block(s) allowed")]
    public List<AwsLightsailDistributionOriginBlock>? Origin
    {
        set => SetProperty("origin", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLightsailDistributionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The alternate domain names of the distribution.
    /// </summary>
    public TerraformExpression AlternativeDomainNames => this["alternative_domain_names"];

    /// <summary>
    /// The Amazon Resource Name (ARN) of the distribution.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The timestamp when the distribution was created.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The domain name of the distribution.
    /// </summary>
    public TerraformExpression DomainName => this["domain_name"];

    /// <summary>
    /// An object that describes the location of the distribution, such as the AWS Region and Availability Zone.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The public DNS of the origin.
    /// </summary>
    public TerraformExpression OriginPublicDns => this["origin_public_dns"];

    /// <summary>
    /// The Lightsail resource type (e.g., Distribution).
    /// </summary>
    public TerraformExpression ResourceType => this["resource_type"];

    /// <summary>
    /// The status of the distribution.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The support code. Include this code in your email to support when you have questions about your Lightsail distribution. This code enables our support team to look up your Lightsail information more easily.
    /// </summary>
    public TerraformExpression SupportCode => this["support_code"];

}
