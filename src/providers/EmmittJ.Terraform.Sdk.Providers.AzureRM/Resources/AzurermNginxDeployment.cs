using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for auto_scale_profile in .
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
        get => new TerraformReference<double>(this, "max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformValue<double> MinCapacity
    {
        get => new TerraformReference<double>(this, "min_capacity");
        set => SetArgument("min_capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for frontend_private in .
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
        get => new TerraformReference<string>(this, "allocation_method");
        set => SetArgument("allocation_method", value);
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddress is required")]
    public required TerraformValue<string> IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Block type for frontend_public in .
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ip_address").ResolveNodes(ctx));
        set => SetArgument("ip_address", value);
    }

}

/// <summary>
/// Block type for identity in .
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for logging_storage_account in .
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
        get => new TerraformReference<string>(this, "container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for network_interface in .
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
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for web_application_firewall in .
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
        get => new TerraformReference<bool>(this, "activation_state_enabled");
        set => SetArgument("activation_state_enabled", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Status
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "status").ResolveNodes(ctx));
    }

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
        get => new TerraformReference<string>(this, "automatic_upgrade_channel");
        set => SetArgument("automatic_upgrade_channel", value);
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double>? Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The diagnose_support_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DiagnoseSupportEnabled
    {
        get => new TerraformReference<bool>(this, "diagnose_support_enabled");
        set => SetArgument("diagnose_support_enabled", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string>? Email
    {
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_resource_group attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> ManagedResourceGroup
    {
        get => new TerraformReference<string>(this, "managed_resource_group");
        set => SetArgument("managed_resource_group", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

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
