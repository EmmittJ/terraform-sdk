using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_service_discovery_service Terraform data source.
/// Retrieves information about a aws_service_discovery_service.
/// </summary>
public partial class AwsServiceDiscoveryServiceDataSource(string name) : TerraformDataSource("aws_service_discovery_service", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceId is required")]
    public required TerraformValue<string> NamespaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace_id");
        set => SetArgument("namespace_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The dns_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DnsConfig
        => AsReference("dns_config");

    /// <summary>
    /// The health_check_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HealthCheckConfig
        => AsReference("health_check_config");

    /// <summary>
    /// The health_check_custom_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HealthCheckCustomConfig
        => AsReference("health_check_custom_config");

}
