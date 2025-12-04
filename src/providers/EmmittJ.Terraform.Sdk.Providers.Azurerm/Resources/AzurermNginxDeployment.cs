using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for auto_scale_profile in AzurermNginxDeployment.
/// Nesting mode: list
/// </summary>
public class AzurermNginxDeploymentAutoScaleProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_scale_profile";

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    public required TerraformValue<double> MaxCapacity
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformValue<double> MinCapacity
    {
        get => GetRequiredArgument<TerraformValue<double>>("min_capacity");
        set => SetArgument("min_capacity", value);
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

}


/// <summary>
/// Block type for frontend_private in AzurermNginxDeployment.
/// Nesting mode: list
/// </summary>
public class AzurermNginxDeploymentFrontendPrivateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frontend_private";

    /// <summary>
    /// The allocation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocationMethod is required")]
    public required TerraformValue<string> AllocationMethod
    {
        get => GetRequiredArgument<TerraformValue<string>>("allocation_method");
        set => SetArgument("allocation_method", value);
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddress is required")]
    public required TerraformValue<string> IpAddress
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip_address");
        set => SetArgument("ip_address", value);
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

}


/// <summary>
/// Block type for frontend_public in AzurermNginxDeployment.
/// Nesting mode: list
/// </summary>
public class AzurermNginxDeploymentFrontendPublicBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frontend_public";

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformList<string>? IpAddress
    {
        get => GetArgument<TerraformList<string>>("ip_address");
        set => SetArgument("ip_address", value);
    }

}


/// <summary>
/// Block type for identity in AzurermNginxDeployment.
/// Nesting mode: list
/// </summary>
public class AzurermNginxDeploymentIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for logging_storage_account in AzurermNginxDeployment.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermNginxDeploymentLoggingStorageAccountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_storage_account";

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    public TerraformValue<string>? ContainerName
    {
        get => GetArgument<TerraformValue<string>>("container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for network_interface in AzurermNginxDeployment.
/// Nesting mode: list
/// </summary>
public class AzurermNginxDeploymentNetworkInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_interface";

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermNginxDeployment.
/// Nesting mode: single
/// </summary>
public class AzurermNginxDeploymentTimeoutsBlock : TerraformBlock
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
/// Block type for web_application_firewall in AzurermNginxDeployment.
/// Nesting mode: list
/// </summary>
public class AzurermNginxDeploymentWebApplicationFirewallBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "web_application_firewall";

    /// <summary>
    /// The activation_state_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActivationStateEnabled is required")]
    public required TerraformValue<bool> ActivationStateEnabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("activation_state_enabled");
        set => SetArgument("activation_state_enabled", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Status
        => AsReference("status");

}


/// <summary>
/// Represents a azurerm_nginx_deployment Terraform resource.
/// Manages a azurerm_nginx_deployment resource.
/// </summary>
public partial class AzurermNginxDeployment(string name) : TerraformResource("azurerm_nginx_deployment", name)
{
    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    public TerraformValue<string>? AutomaticUpgradeChannel
    {
        get => GetArgument<TerraformValue<string>>("automatic_upgrade_channel");
        set => SetArgument("automatic_upgrade_channel", value);
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double>? Capacity
    {
        get => GetArgument<TerraformValue<double>>("capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The diagnose_support_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DiagnoseSupportEnabled
    {
        get => GetArgument<TerraformValue<bool>>("diagnose_support_enabled");
        set => SetArgument("diagnose_support_enabled", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string>? Email
    {
        get => GetArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
    /// The managed_resource_group attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> ManagedResourceGroup
    {
        get => GetArgument<TerraformValue<string>>("managed_resource_group") ?? AsReference("managed_resource_group");
        set => SetArgument("managed_resource_group", value);
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
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => GetRequiredArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
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
    /// The dataplane_api_endpoint attribute.
    /// </summary>
    public TerraformValue<string> DataplaneApiEndpoint
        => AsReference("dataplane_api_endpoint");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string> IpAddress
        => AsReference("ip_address");

    /// <summary>
    /// The nginx_version attribute.
    /// </summary>
    public TerraformValue<string> NginxVersion
        => AsReference("nginx_version");

    /// <summary>
    /// AutoScaleProfile block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermNginxDeploymentAutoScaleProfileBlock>? AutoScaleProfile
    {
        get => GetArgument<TerraformList<AzurermNginxDeploymentAutoScaleProfileBlock>>("auto_scale_profile");
        set => SetArgument("auto_scale_profile", value);
    }

    /// <summary>
    /// FrontendPrivate block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermNginxDeploymentFrontendPrivateBlock>? FrontendPrivate
    {
        get => GetArgument<TerraformList<AzurermNginxDeploymentFrontendPrivateBlock>>("frontend_private");
        set => SetArgument("frontend_private", value);
    }

    /// <summary>
    /// FrontendPublic block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrontendPublic block(s) allowed")]
    public TerraformList<AzurermNginxDeploymentFrontendPublicBlock>? FrontendPublic
    {
        get => GetArgument<TerraformList<AzurermNginxDeploymentFrontendPublicBlock>>("frontend_public");
        set => SetArgument("frontend_public", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermNginxDeploymentIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermNginxDeploymentIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// LoggingStorageAccount block (nesting mode: list).
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public TerraformList<AzurermNginxDeploymentLoggingStorageAccountBlock>? LoggingStorageAccount
    {
        get => GetArgument<TerraformList<AzurermNginxDeploymentLoggingStorageAccountBlock>>("logging_storage_account");
        set => SetArgument("logging_storage_account", value);
    }

    /// <summary>
    /// NetworkInterface block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermNginxDeploymentNetworkInterfaceBlock>? NetworkInterface
    {
        get => GetArgument<TerraformList<AzurermNginxDeploymentNetworkInterfaceBlock>>("network_interface");
        set => SetArgument("network_interface", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNginxDeploymentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNginxDeploymentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WebApplicationFirewall block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebApplicationFirewall block(s) allowed")]
    public TerraformList<AzurermNginxDeploymentWebApplicationFirewallBlock>? WebApplicationFirewall
    {
        get => GetArgument<TerraformList<AzurermNginxDeploymentWebApplicationFirewallBlock>>("web_application_firewall");
        set => SetArgument("web_application_firewall", value);
    }

}
