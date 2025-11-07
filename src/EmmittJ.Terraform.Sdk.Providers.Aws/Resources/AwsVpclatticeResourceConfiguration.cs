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
    public TerraformProperty<bool>? AllowAssociationToShareableServiceNetwork
    {
        get => GetProperty<TerraformProperty<bool>>("allow_association_to_shareable_service_network");
        set => this.WithProperty("allow_association_to_shareable_service_network", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The port_ranges attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? PortRanges
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("port_ranges");
        set => this.WithProperty("port_ranges", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
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
    /// The resource_configuration_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceConfigurationGroupId
    {
        get => GetProperty<TerraformProperty<string>>("resource_configuration_group_id");
        set => this.WithProperty("resource_configuration_group_id", value);
    }

    /// <summary>
    /// The resource_gateway_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGatewayIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("resource_gateway_identifier");
        set => this.WithProperty("resource_gateway_identifier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
