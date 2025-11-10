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
        get => GetProperty<TerraformProperty<string>>("behavior");
        set => WithProperty("behavior", value);
    }

    /// <summary>
    /// The path to a directory or file to cached, or not cache. Use an asterisk symbol to specify wildcard directories (path/to/assets/*), and file types (*.html, *jpg, *js). Directories and file paths are case-sensitive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
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
        get => GetProperty<TerraformProperty<string>>("allowed_http_methods");
        set => WithProperty("allowed_http_methods", value);
    }

    /// <summary>
    /// The HTTP method responses that are cached by your distribution.
    /// </summary>
    public TerraformProperty<string>? CachedHttpMethods
    {
        get => GetProperty<TerraformProperty<string>>("cached_http_methods");
        set => WithProperty("cached_http_methods", value);
    }

    /// <summary>
    /// The default amount of time that objects stay in the distribution&#39;s cache before the distribution forwards another request to the origin to determine whether the content has been updated.
    /// </summary>
    public TerraformProperty<double>? DefaultTtl
    {
        get => GetProperty<TerraformProperty<double>>("default_ttl");
        set => WithProperty("default_ttl", value);
    }

    /// <summary>
    /// The maximum amount of time that objects stay in the distribution&#39;s cache before the distribution forwards another request to the origin to determine whether the object has been updated.
    /// </summary>
    public TerraformProperty<double>? MaximumTtl
    {
        get => GetProperty<TerraformProperty<double>>("maximum_ttl");
        set => WithProperty("maximum_ttl", value);
    }

    /// <summary>
    /// The minimum amount of time that objects stay in the distribution&#39;s cache before the distribution forwards another request to the origin to determine whether the object has been updated.
    /// </summary>
    public TerraformProperty<double>? MinimumTtl
    {
        get => GetProperty<TerraformProperty<double>>("minimum_ttl");
        set => WithProperty("minimum_ttl", value);
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
        get => GetProperty<TerraformProperty<string>>("behavior");
        set => WithProperty("behavior", value);
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
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The protocol that your Amazon Lightsail distribution uses when establishing a connection with your origin to pull content.
    /// </summary>
    public TerraformProperty<string>? ProtocolPolicy
    {
        get => GetProperty<TerraformProperty<string>>("protocol_policy");
        set => WithProperty("protocol_policy", value);
    }

    /// <summary>
    /// The AWS Region name of the origin resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    public required TerraformProperty<string> RegionName
    {
        get => GetProperty<TerraformProperty<string>>("region_name");
        set => WithProperty("region_name", value);
    }

    /// <summary>
    /// The resource type of the origin resource (e.g., Instance).
    /// </summary>
    public TerraformProperty<string>? ResourceType
    {
        get => GetProperty<TerraformProperty<string>>("resource_type");
        set => WithProperty("resource_type", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_lightsail_distribution resource.
/// </summary>
public class AwsLightsailDistribution : TerraformResource
{
    public AwsLightsailDistribution(string name) : base("aws_lightsail_distribution", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("alternative_domain_names");
        this.DeclareOutput("arn");
        this.DeclareOutput("created_at");
        this.DeclareOutput("domain_name");
        this.DeclareOutput("location");
        this.DeclareOutput("origin_public_dns");
        this.DeclareOutput("resource_type");
        this.DeclareOutput("status");
        this.DeclareOutput("support_code");
    }

    /// <summary>
    /// The bundle ID to use for the distribution.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    public required TerraformProperty<string> BundleId
    {
        get => GetProperty<TerraformProperty<string>>("bundle_id");
        set => this.WithProperty("bundle_id", value);
    }

    /// <summary>
    /// The name of the SSL/TLS certificate attached to the distribution, if any.
    /// </summary>
    public TerraformProperty<string>? CertificateName
    {
        get => GetProperty<TerraformProperty<string>>("certificate_name");
        set => this.WithProperty("certificate_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The IP address type of the distribution.
    /// </summary>
    public TerraformProperty<string>? IpAddressType
    {
        get => GetProperty<TerraformProperty<string>>("ip_address_type");
        set => this.WithProperty("ip_address_type", value);
    }

    /// <summary>
    /// Indicates whether the distribution is enabled.
    /// </summary>
    public TerraformProperty<bool>? IsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("is_enabled");
        set => this.WithProperty("is_enabled", value);
    }

    /// <summary>
    /// The name of the distribution.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for cache_behavior.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsLightsailDistributionCacheBehaviorBlock>? CacheBehavior
    {
        get => GetProperty<HashSet<AwsLightsailDistributionCacheBehaviorBlock>>("cache_behavior");
        set => this.WithProperty("cache_behavior", value);
    }

    /// <summary>
    /// Block for cache_behavior_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheBehaviorSettings block(s) allowed")]
    public List<AwsLightsailDistributionCacheBehaviorSettingsBlock>? CacheBehaviorSettings
    {
        get => GetProperty<List<AwsLightsailDistributionCacheBehaviorSettingsBlock>>("cache_behavior_settings");
        set => this.WithProperty("cache_behavior_settings", value);
    }

    /// <summary>
    /// Block for default_cache_behavior.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultCacheBehavior block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultCacheBehavior block(s) allowed")]
    public List<AwsLightsailDistributionDefaultCacheBehaviorBlock>? DefaultCacheBehavior
    {
        get => GetProperty<List<AwsLightsailDistributionDefaultCacheBehaviorBlock>>("default_cache_behavior");
        set => this.WithProperty("default_cache_behavior", value);
    }

    /// <summary>
    /// Block for origin.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Origin block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Origin block(s) allowed")]
    public List<AwsLightsailDistributionOriginBlock>? Origin
    {
        get => GetProperty<List<AwsLightsailDistributionOriginBlock>>("origin");
        set => this.WithProperty("origin", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLightsailDistributionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsLightsailDistributionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
