using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDevCenterNetworkConnection.
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterNetworkConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_dev_center_network_connection Terraform resource.
/// Manages a azurerm_dev_center_network_connection resource.
/// </summary>
public partial class AzurermDevCenterNetworkConnection(string name) : TerraformResource("azurerm_dev_center_network_connection", name)
{
    /// <summary>
    /// The domain_join_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainJoinType is required")]
    public required TerraformValue<string> DomainJoinType
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_join_type");
        set => SetArgument("domain_join_type", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string>? DomainName
    {
        get => GetArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The domain_password attribute.
    /// </summary>
    public TerraformValue<string>? DomainPassword
    {
        get => GetArgument<TerraformValue<string>>("domain_password");
        set => SetArgument("domain_password", value);
    }

    /// <summary>
    /// The domain_username attribute.
    /// </summary>
    public TerraformValue<string>? DomainUsername
    {
        get => GetArgument<TerraformValue<string>>("domain_username");
        set => SetArgument("domain_username", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The organization_unit attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationUnit
    {
        get => GetArgument<TerraformValue<string>>("organization_unit");
        set => SetArgument("organization_unit", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDevCenterNetworkConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDevCenterNetworkConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
