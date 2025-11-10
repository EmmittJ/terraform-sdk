using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dns_config in .
/// Nesting mode: list
/// </summary>
public class AwsServiceDiscoveryServiceDnsConfigBlock : TerraformBlock
{
    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceId is required")]
    public required TerraformProperty<string> NamespaceId
    {
        get => GetProperty<TerraformProperty<string>>("namespace_id");
        set => WithProperty("namespace_id", value);
    }

    /// <summary>
    /// The routing_policy attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingPolicy
    {
        get => GetProperty<TerraformProperty<string>>("routing_policy");
        set => WithProperty("routing_policy", value);
    }

}

/// <summary>
/// Block type for health_check_config in .
/// Nesting mode: list
/// </summary>
public class AwsServiceDiscoveryServiceHealthCheckConfigBlock : TerraformBlock
{
    /// <summary>
    /// The failure_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? FailureThreshold
    {
        get => GetProperty<TerraformProperty<double>>("failure_threshold");
        set => WithProperty("failure_threshold", value);
    }

    /// <summary>
    /// The resource_path attribute.
    /// </summary>
    public TerraformProperty<string>? ResourcePath
    {
        get => GetProperty<TerraformProperty<string>>("resource_path");
        set => WithProperty("resource_path", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for health_check_custom_config in .
/// Nesting mode: list
/// </summary>
public class AwsServiceDiscoveryServiceHealthCheckCustomConfigBlock : TerraformBlock
{
    /// <summary>
    /// The failure_threshold attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<double>? FailureThreshold
    {
        get => GetProperty<TerraformProperty<double>>("failure_threshold");
        set => WithProperty("failure_threshold", value);
    }

}

/// <summary>
/// Manages a aws_service_discovery_service resource.
/// </summary>
public class AwsServiceDiscoveryService : TerraformResource
{
    public AwsServiceDiscoveryService(string name) : base("aws_service_discovery_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    public TerraformProperty<string>? NamespaceId
    {
        get => GetProperty<TerraformProperty<string>>("namespace_id");
        set => this.WithProperty("namespace_id", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for dns_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    public List<AwsServiceDiscoveryServiceDnsConfigBlock>? DnsConfig
    {
        get => GetProperty<List<AwsServiceDiscoveryServiceDnsConfigBlock>>("dns_config");
        set => this.WithProperty("dns_config", value);
    }

    /// <summary>
    /// Block for health_check_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheckConfig block(s) allowed")]
    public List<AwsServiceDiscoveryServiceHealthCheckConfigBlock>? HealthCheckConfig
    {
        get => GetProperty<List<AwsServiceDiscoveryServiceHealthCheckConfigBlock>>("health_check_config");
        set => this.WithProperty("health_check_config", value);
    }

    /// <summary>
    /// Block for health_check_custom_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheckCustomConfig block(s) allowed")]
    public List<AwsServiceDiscoveryServiceHealthCheckCustomConfigBlock>? HealthCheckCustomConfig
    {
        get => GetProperty<List<AwsServiceDiscoveryServiceHealthCheckCustomConfigBlock>>("health_check_custom_config");
        set => this.WithProperty("health_check_custom_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
