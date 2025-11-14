using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermActiveDirectoryDomainServiceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_active_directory_domain_service.
/// </summary>
public class AzurermActiveDirectoryDomainServiceDataSource : TerraformDataSource
{
    public AzurermActiveDirectoryDomainServiceDataSource(string name) : base("azurerm_active_directory_domain_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermActiveDirectoryDomainServiceDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [TerraformArgument("deployment_id")]
    public TerraformValue<string> DeploymentId
    {
        get => new TerraformReference<string>(this, "deployment_id");
    }

    /// <summary>
    /// The domain_configuration_type attribute.
    /// </summary>
    [TerraformArgument("domain_configuration_type")]
    public TerraformValue<string> DomainConfigurationType
    {
        get => new TerraformReference<string>(this, "domain_configuration_type");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformArgument("domain_name")]
    public TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
    }

    /// <summary>
    /// The filtered_sync_enabled attribute.
    /// </summary>
    [TerraformArgument("filtered_sync_enabled")]
    public TerraformValue<bool> FilteredSyncEnabled
    {
        get => new TerraformReference<bool>(this, "filtered_sync_enabled");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The notifications attribute.
    /// </summary>
    [TerraformArgument("notifications")]
    public TerraformList<object> Notifications
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "notifications").ResolveNodes(ctx));
    }

    /// <summary>
    /// The replica_sets attribute.
    /// </summary>
    [TerraformArgument("replica_sets")]
    public TerraformList<object> ReplicaSets
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "replica_sets").ResolveNodes(ctx));
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformArgument("resource_id")]
    public TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
    }

    /// <summary>
    /// The secure_ldap attribute.
    /// </summary>
    [TerraformArgument("secure_ldap")]
    public TerraformList<object> SecureLdap
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "secure_ldap").ResolveNodes(ctx));
    }

    /// <summary>
    /// The security attribute.
    /// </summary>
    [TerraformArgument("security")]
    public TerraformList<object> Security
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "security").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
    }

    /// <summary>
    /// The sync_owner attribute.
    /// </summary>
    [TerraformArgument("sync_owner")]
    public TerraformValue<string> SyncOwner
    {
        get => new TerraformReference<string>(this, "sync_owner");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformArgument("tenant_id")]
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<double> Version
    {
        get => new TerraformReference<double>(this, "version");
    }

}
