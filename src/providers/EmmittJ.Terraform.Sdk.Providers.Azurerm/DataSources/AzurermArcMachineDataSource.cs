using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermArcMachineDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermArcMachineDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_arc_machine Terraform data source.
/// Retrieves information about a azurerm_arc_machine.
/// </summary>
public partial class AzurermArcMachineDataSource(string name) : TerraformDataSource("azurerm_arc_machine", name)
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
    /// The active_directory_fqdn attribute.
    /// </summary>
    public TerraformValue<string> ActiveDirectoryFqdn
    {
        get => new TerraformReference<string>(this, "active_directory_fqdn");
    }

    /// <summary>
    /// The agent attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Agent
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "agent").ResolveNodes(ctx));
    }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public TerraformValue<string> AgentVersion
    {
        get => new TerraformReference<string>(this, "agent_version");
    }

    /// <summary>
    /// The client_public_key attribute.
    /// </summary>
    public TerraformValue<string> ClientPublicKey
    {
        get => new TerraformReference<string>(this, "client_public_key");
    }

    /// <summary>
    /// The cloud_metadata attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CloudMetadata
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cloud_metadata").ResolveNodes(ctx));
    }

    /// <summary>
    /// The detected_properties attribute.
    /// </summary>
    public TerraformMap<string> DetectedProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "detected_properties").ResolveNodes(ctx));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The dns_fqdn attribute.
    /// </summary>
    public TerraformValue<string> DnsFqdn
    {
        get => new TerraformReference<string>(this, "dns_fqdn");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The last_status_change_time attribute.
    /// </summary>
    public TerraformValue<string> LastStatusChangeTime
    {
        get => new TerraformReference<string>(this, "last_status_change_time");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The location_data attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LocationData
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "location_data").ResolveNodes(ctx));
    }

    /// <summary>
    /// The machine_fqdn attribute.
    /// </summary>
    public TerraformValue<string> MachineFqdn
    {
        get => new TerraformReference<string>(this, "machine_fqdn");
    }

    /// <summary>
    /// The mssql_discovered attribute.
    /// </summary>
    public TerraformValue<bool> MssqlDiscovered
    {
        get => new TerraformReference<bool>(this, "mssql_discovered");
    }

    /// <summary>
    /// The os_name attribute.
    /// </summary>
    public TerraformValue<string> OsName
    {
        get => new TerraformReference<string>(this, "os_name");
    }

    /// <summary>
    /// The os_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OsProfile
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "os_profile").ResolveNodes(ctx));
    }

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    public TerraformValue<string> OsSku
    {
        get => new TerraformReference<string>(this, "os_sku");
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformValue<string> OsType
    {
        get => new TerraformReference<string>(this, "os_type");
    }

    /// <summary>
    /// The os_version attribute.
    /// </summary>
    public TerraformValue<string> OsVersion
    {
        get => new TerraformReference<string>(this, "os_version");
    }

    /// <summary>
    /// The parent_cluster_resource_id attribute.
    /// </summary>
    public TerraformValue<string> ParentClusterResourceId
    {
        get => new TerraformReference<string>(this, "parent_cluster_resource_id");
    }

    /// <summary>
    /// The private_link_scope_resource_id attribute.
    /// </summary>
    public TerraformValue<string> PrivateLinkScopeResourceId
    {
        get => new TerraformReference<string>(this, "private_link_scope_resource_id");
    }

    /// <summary>
    /// The service_status attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceStatus
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "service_status").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vm_id attribute.
    /// </summary>
    public TerraformValue<string> VmId
    {
        get => new TerraformReference<string>(this, "vm_id");
    }

    /// <summary>
    /// The vm_uuid attribute.
    /// </summary>
    public TerraformValue<string> VmUuid
    {
        get => new TerraformReference<string>(this, "vm_uuid");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermArcMachineDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermArcMachineDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
