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
        set => SetProperty("namespace_id", value);
    }

    /// <summary>
    /// The routing_policy attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingPolicy
    {
        set => SetProperty("routing_policy", value);
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
        set => SetProperty("failure_threshold", value);
    }

    /// <summary>
    /// The resource_path attribute.
    /// </summary>
    public TerraformProperty<string>? ResourcePath
    {
        set => SetProperty("resource_path", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("failure_threshold", value);
    }

}

/// <summary>
/// Manages a aws_service_discovery_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsServiceDiscoveryService : TerraformResource
{
    public AwsServiceDiscoveryService(string name) : base("aws_service_discovery_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("description");
        SetOutput("force_destroy");
        SetOutput("id");
        SetOutput("name");
        SetOutput("namespace_id");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("type");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> ForceDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_destroy");
        set => SetProperty("force_destroy", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    public TerraformProperty<string> NamespaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace_id");
        set => SetProperty("namespace_id", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for dns_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    public List<AwsServiceDiscoveryServiceDnsConfigBlock>? DnsConfig
    {
        set => SetProperty("dns_config", value);
    }

    /// <summary>
    /// Block for health_check_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheckConfig block(s) allowed")]
    public List<AwsServiceDiscoveryServiceHealthCheckConfigBlock>? HealthCheckConfig
    {
        set => SetProperty("health_check_config", value);
    }

    /// <summary>
    /// Block for health_check_custom_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheckCustomConfig block(s) allowed")]
    public List<AwsServiceDiscoveryServiceHealthCheckCustomConfigBlock>? HealthCheckCustomConfig
    {
        set => SetProperty("health_check_custom_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
