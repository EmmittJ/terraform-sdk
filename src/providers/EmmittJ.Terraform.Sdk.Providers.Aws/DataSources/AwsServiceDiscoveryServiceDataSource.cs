using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_service_discovery_service.
/// </summary>
public class AwsServiceDiscoveryServiceDataSource : TerraformDataSource
{
    public AwsServiceDiscoveryServiceDataSource(string name) : base("aws_service_discovery_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("description");
        SetOutput("dns_config");
        SetOutput("health_check_config");
        SetOutput("health_check_custom_config");
        SetOutput("id");
        SetOutput("name");
        SetOutput("namespace_id");
        SetOutput("region");
        SetOutput("tags");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceId is required")]
    public required TerraformProperty<string> NamespaceId
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The dns_config attribute.
    /// </summary>
    public TerraformExpression DnsConfig => this["dns_config"];

    /// <summary>
    /// The health_check_config attribute.
    /// </summary>
    public TerraformExpression HealthCheckConfig => this["health_check_config"];

    /// <summary>
    /// The health_check_custom_config attribute.
    /// </summary>
    public TerraformExpression HealthCheckCustomConfig => this["health_check_custom_config"];

}
