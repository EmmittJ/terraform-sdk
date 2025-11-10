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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.WithOutput("active_directory_fqdn");
        this.WithOutput("agent");
        this.WithOutput("agent_version");
        this.WithOutput("client_public_key");
        this.WithOutput("cloud_metadata");
        this.WithOutput("detected_properties");
        this.WithOutput("display_name");
        this.WithOutput("dns_fqdn");
        this.WithOutput("domain_name");
        this.WithOutput("identity");
        this.WithOutput("last_status_change_time");
        this.WithOutput("location");
        this.WithOutput("location_data");
        this.WithOutput("machine_fqdn");
        this.WithOutput("mssql_discovered");
        this.WithOutput("os_name");
        this.WithOutput("os_profile");
        this.WithOutput("os_sku");
        this.WithOutput("os_type");
        this.WithOutput("os_version");
        this.WithOutput("parent_cluster_resource_id");
        this.WithOutput("private_link_scope_resource_id");
        this.WithOutput("service_status");
        this.WithOutput("status");
        this.WithOutput("tags");
        this.WithOutput("vm_id");
        this.WithOutput("vm_uuid");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermArcMachineDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermArcMachineDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
