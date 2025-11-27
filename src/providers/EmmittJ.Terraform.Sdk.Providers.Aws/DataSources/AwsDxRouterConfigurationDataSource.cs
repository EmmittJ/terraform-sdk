using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dx_router_configuration Terraform data source.
/// Retrieves information about a aws_dx_router_configuration.
/// </summary>
public partial class AwsDxRouterConfigurationDataSource(string name) : TerraformDataSource("aws_dx_router_configuration", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The router_type_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouterTypeIdentifier is required")]
    public required TerraformValue<string> RouterTypeIdentifier
    {
        get => new TerraformReference<string>(this, "router_type_identifier");
        set => SetArgument("router_type_identifier", value);
    }

    /// <summary>
    /// The virtual_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualInterfaceId is required")]
    public required TerraformValue<string> VirtualInterfaceId
    {
        get => new TerraformReference<string>(this, "virtual_interface_id");
        set => SetArgument("virtual_interface_id", value);
    }

    /// <summary>
    /// The customer_router_config attribute.
    /// </summary>
    public TerraformValue<string> CustomerRouterConfig
    {
        get => new TerraformReference<string>(this, "customer_router_config");
    }

    /// <summary>
    /// The router attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Router
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "router").ResolveNodes(ctx));
    }

    /// <summary>
    /// The virtual_interface_name attribute.
    /// </summary>
    public TerraformValue<string> VirtualInterfaceName
    {
        get => new TerraformReference<string>(this, "virtual_interface_name");
    }

}
