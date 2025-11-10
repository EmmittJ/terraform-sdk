using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermArcMachineDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_arc_machine.
/// </summary>
public class AzurermArcMachineDataSource : TerraformDataSource
{
    public AzurermArcMachineDataSource(string name) : base("azurerm_arc_machine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("active_directory_fqdn");
        SetOutput("agent");
        SetOutput("agent_version");
        SetOutput("client_public_key");
        SetOutput("cloud_metadata");
        SetOutput("detected_properties");
        SetOutput("display_name");
        SetOutput("dns_fqdn");
        SetOutput("domain_name");
        SetOutput("identity");
        SetOutput("last_status_change_time");
        SetOutput("location");
        SetOutput("location_data");
        SetOutput("machine_fqdn");
        SetOutput("mssql_discovered");
        SetOutput("os_name");
        SetOutput("os_profile");
        SetOutput("os_sku");
        SetOutput("os_type");
        SetOutput("os_version");
        SetOutput("parent_cluster_resource_id");
        SetOutput("private_link_scope_resource_id");
        SetOutput("service_status");
        SetOutput("status");
        SetOutput("tags");
        SetOutput("vm_id");
        SetOutput("vm_uuid");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermArcMachineDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The active_directory_fqdn attribute.
    /// </summary>
    public TerraformExpression ActiveDirectoryFqdn => this["active_directory_fqdn"];

    /// <summary>
    /// The agent attribute.
    /// </summary>
    public TerraformExpression Agent => this["agent"];

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public TerraformExpression AgentVersion => this["agent_version"];

    /// <summary>
    /// The client_public_key attribute.
    /// </summary>
    public TerraformExpression ClientPublicKey => this["client_public_key"];

    /// <summary>
    /// The cloud_metadata attribute.
    /// </summary>
    public TerraformExpression CloudMetadata => this["cloud_metadata"];

    /// <summary>
    /// The detected_properties attribute.
    /// </summary>
    public TerraformExpression DetectedProperties => this["detected_properties"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The dns_fqdn attribute.
    /// </summary>
    public TerraformExpression DnsFqdn => this["dns_fqdn"];

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformExpression DomainName => this["domain_name"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The last_status_change_time attribute.
    /// </summary>
    public TerraformExpression LastStatusChangeTime => this["last_status_change_time"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The location_data attribute.
    /// </summary>
    public TerraformExpression LocationData => this["location_data"];

    /// <summary>
    /// The machine_fqdn attribute.
    /// </summary>
    public TerraformExpression MachineFqdn => this["machine_fqdn"];

    /// <summary>
    /// The mssql_discovered attribute.
    /// </summary>
    public TerraformExpression MssqlDiscovered => this["mssql_discovered"];

    /// <summary>
    /// The os_name attribute.
    /// </summary>
    public TerraformExpression OsName => this["os_name"];

    /// <summary>
    /// The os_profile attribute.
    /// </summary>
    public TerraformExpression OsProfile => this["os_profile"];

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    public TerraformExpression OsSku => this["os_sku"];

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformExpression OsType => this["os_type"];

    /// <summary>
    /// The os_version attribute.
    /// </summary>
    public TerraformExpression OsVersion => this["os_version"];

    /// <summary>
    /// The parent_cluster_resource_id attribute.
    /// </summary>
    public TerraformExpression ParentClusterResourceId => this["parent_cluster_resource_id"];

    /// <summary>
    /// The private_link_scope_resource_id attribute.
    /// </summary>
    public TerraformExpression PrivateLinkScopeResourceId => this["private_link_scope_resource_id"];

    /// <summary>
    /// The service_status attribute.
    /// </summary>
    public TerraformExpression ServiceStatus => this["service_status"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The vm_id attribute.
    /// </summary>
    public TerraformExpression VmId => this["vm_id"];

    /// <summary>
    /// The vm_uuid attribute.
    /// </summary>
    public TerraformExpression VmUuid => this["vm_uuid"];

}
