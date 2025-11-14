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
public class AzurermArcMachineDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_arc_machine.
/// </summary>
public class AzurermArcMachineDataSource : TerraformDataSource
{
    public AzurermArcMachineDataSource(string name) : base("azurerm_arc_machine", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermArcMachineDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The active_directory_fqdn attribute.
    /// </summary>
    [TerraformArgument("active_directory_fqdn")]
    public TerraformValue<string> ActiveDirectoryFqdn
    {
        get => new TerraformReference<string>(this, "active_directory_fqdn");
    }

    /// <summary>
    /// The agent attribute.
    /// </summary>
    [TerraformArgument("agent")]
    public TerraformList<object> Agent
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "agent").ResolveNodes(ctx));
    }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    [TerraformArgument("agent_version")]
    public TerraformValue<string> AgentVersion
    {
        get => new TerraformReference<string>(this, "agent_version");
    }

    /// <summary>
    /// The client_public_key attribute.
    /// </summary>
    [TerraformArgument("client_public_key")]
    public TerraformValue<string> ClientPublicKey
    {
        get => new TerraformReference<string>(this, "client_public_key");
    }

    /// <summary>
    /// The cloud_metadata attribute.
    /// </summary>
    [TerraformArgument("cloud_metadata")]
    public TerraformList<object> CloudMetadata
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "cloud_metadata").ResolveNodes(ctx));
    }

    /// <summary>
    /// The detected_properties attribute.
    /// </summary>
    [TerraformArgument("detected_properties")]
    public TerraformMap<string> DetectedProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "detected_properties").ResolveNodes(ctx));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The dns_fqdn attribute.
    /// </summary>
    [TerraformArgument("dns_fqdn")]
    public TerraformValue<string> DnsFqdn
    {
        get => new TerraformReference<string>(this, "dns_fqdn");
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
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The last_status_change_time attribute.
    /// </summary>
    [TerraformArgument("last_status_change_time")]
    public TerraformValue<string> LastStatusChangeTime
    {
        get => new TerraformReference<string>(this, "last_status_change_time");
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
    /// The location_data attribute.
    /// </summary>
    [TerraformArgument("location_data")]
    public TerraformList<object> LocationData
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "location_data").ResolveNodes(ctx));
    }

    /// <summary>
    /// The machine_fqdn attribute.
    /// </summary>
    [TerraformArgument("machine_fqdn")]
    public TerraformValue<string> MachineFqdn
    {
        get => new TerraformReference<string>(this, "machine_fqdn");
    }

    /// <summary>
    /// The mssql_discovered attribute.
    /// </summary>
    [TerraformArgument("mssql_discovered")]
    public TerraformValue<bool> MssqlDiscovered
    {
        get => new TerraformReference<bool>(this, "mssql_discovered");
    }

    /// <summary>
    /// The os_name attribute.
    /// </summary>
    [TerraformArgument("os_name")]
    public TerraformValue<string> OsName
    {
        get => new TerraformReference<string>(this, "os_name");
    }

    /// <summary>
    /// The os_profile attribute.
    /// </summary>
    [TerraformArgument("os_profile")]
    public TerraformList<object> OsProfile
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "os_profile").ResolveNodes(ctx));
    }

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    [TerraformArgument("os_sku")]
    public TerraformValue<string> OsSku
    {
        get => new TerraformReference<string>(this, "os_sku");
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformArgument("os_type")]
    public TerraformValue<string> OsType
    {
        get => new TerraformReference<string>(this, "os_type");
    }

    /// <summary>
    /// The os_version attribute.
    /// </summary>
    [TerraformArgument("os_version")]
    public TerraformValue<string> OsVersion
    {
        get => new TerraformReference<string>(this, "os_version");
    }

    /// <summary>
    /// The parent_cluster_resource_id attribute.
    /// </summary>
    [TerraformArgument("parent_cluster_resource_id")]
    public TerraformValue<string> ParentClusterResourceId
    {
        get => new TerraformReference<string>(this, "parent_cluster_resource_id");
    }

    /// <summary>
    /// The private_link_scope_resource_id attribute.
    /// </summary>
    [TerraformArgument("private_link_scope_resource_id")]
    public TerraformValue<string> PrivateLinkScopeResourceId
    {
        get => new TerraformReference<string>(this, "private_link_scope_resource_id");
    }

    /// <summary>
    /// The service_status attribute.
    /// </summary>
    [TerraformArgument("service_status")]
    public TerraformList<object> ServiceStatus
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "service_status").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformArgument("status")]
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vm_id attribute.
    /// </summary>
    [TerraformArgument("vm_id")]
    public TerraformValue<string> VmId
    {
        get => new TerraformReference<string>(this, "vm_id");
    }

    /// <summary>
    /// The vm_uuid attribute.
    /// </summary>
    [TerraformArgument("vm_uuid")]
    public TerraformValue<string> VmUuid
    {
        get => new TerraformReference<string>(this, "vm_uuid");
    }

}
