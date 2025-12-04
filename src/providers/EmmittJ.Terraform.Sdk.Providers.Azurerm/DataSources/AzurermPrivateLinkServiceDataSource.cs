using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPrivateLinkServiceDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermPrivateLinkServiceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_private_link_service Terraform data source.
/// Retrieves information about a azurerm_private_link_service.
/// </summary>
public partial class AzurermPrivateLinkServiceDataSource(string name) : TerraformDataSource("azurerm_private_link_service", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformValue<string> Alias
        => AsReference("alias");

    /// <summary>
    /// The auto_approval_subscription_ids attribute.
    /// </summary>
    public TerraformList<string> AutoApprovalSubscriptionIds
        => AsReference("auto_approval_subscription_ids");

    /// <summary>
    /// The enable_proxy_protocol attribute.
    /// </summary>
    public TerraformValue<bool> EnableProxyProtocol
        => AsReference("enable_proxy_protocol");

    /// <summary>
    /// The load_balancer_frontend_ip_configuration_ids attribute.
    /// </summary>
    public TerraformList<string> LoadBalancerFrontendIpConfigurationIds
        => AsReference("load_balancer_frontend_ip_configuration_ids");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The nat_ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NatIpConfiguration
        => AsReference("nat_ip_configuration");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The visibility_subscription_ids attribute.
    /// </summary>
    public TerraformList<string> VisibilitySubscriptionIds
        => AsReference("visibility_subscription_ids");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPrivateLinkServiceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPrivateLinkServiceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
