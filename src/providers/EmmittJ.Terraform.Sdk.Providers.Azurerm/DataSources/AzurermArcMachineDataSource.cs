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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
        => CreateReference("active_directory_fqdn");

    /// <summary>
    /// The agent attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Agent
        => CreateReference("agent");

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public TerraformValue<string> AgentVersion
        => CreateReference("agent_version");

    /// <summary>
    /// The client_public_key attribute.
    /// </summary>
    public TerraformValue<string> ClientPublicKey
        => CreateReference("client_public_key");

    /// <summary>
    /// The cloud_metadata attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CloudMetadata
        => CreateReference("cloud_metadata");

    /// <summary>
    /// The detected_properties attribute.
    /// </summary>
    public TerraformMap<string> DetectedProperties
        => CreateReference("detected_properties");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => CreateReference("display_name");

    /// <summary>
    /// The dns_fqdn attribute.
    /// </summary>
    public TerraformValue<string> DnsFqdn
        => CreateReference("dns_fqdn");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string> DomainName
        => CreateReference("domain_name");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => CreateReference("identity");

    /// <summary>
    /// The last_status_change_time attribute.
    /// </summary>
    public TerraformValue<string> LastStatusChangeTime
        => CreateReference("last_status_change_time");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The location_data attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LocationData
        => CreateReference("location_data");

    /// <summary>
    /// The machine_fqdn attribute.
    /// </summary>
    public TerraformValue<string> MachineFqdn
        => CreateReference("machine_fqdn");

    /// <summary>
    /// The mssql_discovered attribute.
    /// </summary>
    public TerraformValue<bool> MssqlDiscovered
        => CreateReference("mssql_discovered");

    /// <summary>
    /// The os_name attribute.
    /// </summary>
    public TerraformValue<string> OsName
        => CreateReference("os_name");

    /// <summary>
    /// The os_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OsProfile
        => CreateReference("os_profile");

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    public TerraformValue<string> OsSku
        => CreateReference("os_sku");

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformValue<string> OsType
        => CreateReference("os_type");

    /// <summary>
    /// The os_version attribute.
    /// </summary>
    public TerraformValue<string> OsVersion
        => CreateReference("os_version");

    /// <summary>
    /// The parent_cluster_resource_id attribute.
    /// </summary>
    public TerraformValue<string> ParentClusterResourceId
        => CreateReference("parent_cluster_resource_id");

    /// <summary>
    /// The private_link_scope_resource_id attribute.
    /// </summary>
    public TerraformValue<string> PrivateLinkScopeResourceId
        => CreateReference("private_link_scope_resource_id");

    /// <summary>
    /// The service_status attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceStatus
        => CreateReference("service_status");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The vm_id attribute.
    /// </summary>
    public TerraformValue<string> VmId
        => CreateReference("vm_id");

    /// <summary>
    /// The vm_uuid attribute.
    /// </summary>
    public TerraformValue<string> VmUuid
        => CreateReference("vm_uuid");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermArcMachineDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermArcMachineDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
