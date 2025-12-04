using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermActiveDirectoryDomainServiceDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
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
    /// The deployment_id attribute.
    /// </summary>
    public TerraformValue<string> DeploymentId
        => AsReference("deployment_id");

    /// <summary>
    /// The domain_configuration_type attribute.
    /// </summary>
    public TerraformValue<string> DomainConfigurationType
        => AsReference("domain_configuration_type");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string> DomainName
        => AsReference("domain_name");

    /// <summary>
    /// The filtered_sync_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FilteredSyncEnabled
        => AsReference("filtered_sync_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The notifications attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Notifications
        => AsReference("notifications");

    /// <summary>
    /// The replica_sets attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReplicaSets
        => AsReference("replica_sets");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceId
        => AsReference("resource_id");

    /// <summary>
    /// The secure_ldap attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SecureLdap
        => AsReference("secure_ldap");

    /// <summary>
    /// The security attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Security
        => AsReference("security");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
        => AsReference("sku");

    /// <summary>
    /// The sync_owner attribute.
    /// </summary>
    public TerraformValue<string> SyncOwner
        => AsReference("sync_owner");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<double> Version
        => AsReference("version");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermActiveDirectoryDomainServiceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermActiveDirectoryDomainServiceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
