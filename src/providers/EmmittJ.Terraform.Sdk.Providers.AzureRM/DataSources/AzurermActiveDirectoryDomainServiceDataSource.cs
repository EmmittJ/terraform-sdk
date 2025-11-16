using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_active_directory_domain_service Terraform data source.
/// Retrieves information about a azurerm_active_directory_domain_service.
/// </summary>
public partial class AzurermActiveDirectoryDomainServiceDataSource(string name) : TerraformDataSource("azurerm_active_directory_domain_service", name)
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    public TerraformValue<string> DeploymentId
    {
        get => new TerraformReference<string>(this, "deployment_id");
    }

    /// <summary>
    /// The domain_configuration_type attribute.
    /// </summary>
    public TerraformValue<string> DomainConfigurationType
    {
        get => new TerraformReference<string>(this, "domain_configuration_type");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
    }

    /// <summary>
    /// The filtered_sync_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FilteredSyncEnabled
    {
        get => new TerraformReference<bool>(this, "filtered_sync_enabled");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The notifications attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Notifications
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "notifications").ResolveNodes(ctx));
    }

    /// <summary>
    /// The replica_sets attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReplicaSets
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "replica_sets").ResolveNodes(ctx));
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
    }

    /// <summary>
    /// The secure_ldap attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SecureLdap
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "secure_ldap").ResolveNodes(ctx));
    }

    /// <summary>
    /// The security attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Security
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "security").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
    }

    /// <summary>
    /// The sync_owner attribute.
    /// </summary>
    public TerraformValue<string> SyncOwner
    {
        get => new TerraformReference<string>(this, "sync_owner");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<double> Version
    {
        get => new TerraformReference<double>(this, "version");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermActiveDirectoryDomainServiceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermActiveDirectoryDomainServiceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
