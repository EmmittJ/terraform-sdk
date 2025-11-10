using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resource_configuration_definition in .
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeResourceConfigurationResourceConfigurationDefinitionBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpclatticeResourceConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
        this.WithOutput("arn");
        this.WithOutput("id");
        this.WithOutput("tags_all");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The port_ranges attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? PortRanges
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("port_ranges");
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
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
    /// Block for resource_configuration_definition.
    /// Nesting mode: list
    /// </summary>
    public List<AwsVpclatticeResourceConfigurationResourceConfigurationDefinitionBlock>? ResourceConfigurationDefinition
    {
        get => GetProperty<List<AwsVpclatticeResourceConfigurationResourceConfigurationDefinitionBlock>>("resource_configuration_definition");
        set => this.WithProperty("resource_configuration_definition", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpclatticeResourceConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVpclatticeResourceConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
