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
        get => GetArgument<TerraformValue<string>>("read");
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
    /// The active_directory_fqdn attribute.
    /// </summary>
    public TerraformValue<string> ActiveDirectoryFqdn
        => AsReference("active_directory_fqdn");

    /// <summary>
    /// The agent attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Agent
        => AsReference("agent");

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public TerraformValue<string> AgentVersion
        => AsReference("agent_version");

    /// <summary>
    /// The client_public_key attribute.
    /// </summary>
    public TerraformValue<string> ClientPublicKey
        => AsReference("client_public_key");

    /// <summary>
    /// The cloud_metadata attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CloudMetadata
        => AsReference("cloud_metadata");

    /// <summary>
    /// The detected_properties attribute.
    /// </summary>
    public TerraformMap<string> DetectedProperties
        => AsReference("detected_properties");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The dns_fqdn attribute.
    /// </summary>
    public TerraformValue<string> DnsFqdn
        => AsReference("dns_fqdn");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string> DomainName
        => AsReference("domain_name");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The last_status_change_time attribute.
    /// </summary>
    public TerraformValue<string> LastStatusChangeTime
        => AsReference("last_status_change_time");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The location_data attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LocationData
        => AsReference("location_data");

    /// <summary>
    /// The machine_fqdn attribute.
    /// </summary>
    public TerraformValue<string> MachineFqdn
        => AsReference("machine_fqdn");

    /// <summary>
    /// The mssql_discovered attribute.
    /// </summary>
    public TerraformValue<bool> MssqlDiscovered
        => AsReference("mssql_discovered");

    /// <summary>
    /// The os_name attribute.
    /// </summary>
    public TerraformValue<string> OsName
        => AsReference("os_name");

    /// <summary>
    /// The os_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OsProfile
        => AsReference("os_profile");

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    public TerraformValue<string> OsSku
        => AsReference("os_sku");

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformValue<string> OsType
        => AsReference("os_type");

    /// <summary>
    /// The os_version attribute.
    /// </summary>
    public TerraformValue<string> OsVersion
        => AsReference("os_version");

    /// <summary>
    /// The parent_cluster_resource_id attribute.
    /// </summary>
    public TerraformValue<string> ParentClusterResourceId
        => AsReference("parent_cluster_resource_id");

    /// <summary>
    /// The private_link_scope_resource_id attribute.
    /// </summary>
    public TerraformValue<string> PrivateLinkScopeResourceId
        => AsReference("private_link_scope_resource_id");

    /// <summary>
    /// The service_status attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceStatus
        => AsReference("service_status");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The vm_id attribute.
    /// </summary>
    public TerraformValue<string> VmId
        => AsReference("vm_id");

    /// <summary>
    /// The vm_uuid attribute.
    /// </summary>
    public TerraformValue<string> VmUuid
        => AsReference("vm_uuid");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermArcMachineDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermArcMachineDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
