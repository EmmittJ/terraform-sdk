using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpclattice_resource_configuration resource.
/// </summary>
public class AwsVpclatticeResourceConfiguration : TerraformResource
{
    public AwsVpclatticeResourceConfiguration(string name) : base("aws_vpclattice_resource_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The allow_association_to_shareable_service_network attribute.
    /// </summary>
    public bool? AllowAssociationToShareableServiceNetwork
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_association_to_shareable_service_network")?.Value;
        set => this.WithProperty("allow_association_to_shareable_service_network", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The port_ranges attribute.
    /// </summary>
    public HashSet<string>? PortRanges
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("port_ranges")?.Value;
        set => this.WithProperty("port_ranges", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public string? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol")?.Value;
        set => this.WithProperty("protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_configuration_group_id attribute.
    /// </summary>
    public string? ResourceConfigurationGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_configuration_group_id")?.Value;
        set => this.WithProperty("resource_configuration_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_gateway_identifier attribute.
    /// </summary>
    public string? ResourceGatewayIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_gateway_identifier")?.Value;
        set => this.WithProperty("resource_gateway_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
