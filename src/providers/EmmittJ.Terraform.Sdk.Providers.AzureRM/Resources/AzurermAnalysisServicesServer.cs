using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ipv4_firewall_rule in .
/// Nesting mode: set
/// </summary>
public class AzurermAnalysisServicesServerIpv4FirewallRuleBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The range_end attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeEnd is required")]
    public required TerraformProperty<string> RangeEnd
    {
        set => SetProperty("range_end", value);
    }

    /// <summary>
    /// The range_start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeStart is required")]
    public required TerraformProperty<string> RangeStart
    {
        set => SetProperty("range_start", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAnalysisServicesServerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_analysis_services_server resource.
/// </summary>
public class AzurermAnalysisServicesServer : TerraformResource
{
    public AzurermAnalysisServicesServer(string name) : base("azurerm_analysis_services_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("server_full_name");
        SetOutput("admin_users");
        SetOutput("backup_blob_container_uri");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("power_bi_service_enabled");
        SetOutput("querypool_connection_mode");
        SetOutput("resource_group_name");
        SetOutput("sku");
        SetOutput("tags");
    }

    /// <summary>
    /// The admin_users attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AdminUsers
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("admin_users");
        set => SetProperty("admin_users", value);
    }

    /// <summary>
    /// The backup_blob_container_uri attribute.
    /// </summary>
    public TerraformProperty<string> BackupBlobContainerUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_blob_container_uri");
        set => SetProperty("backup_blob_container_uri", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The power_bi_service_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PowerBiServiceEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("power_bi_service_enabled");
        set => SetProperty("power_bi_service_enabled", value);
    }

    /// <summary>
    /// The querypool_connection_mode attribute.
    /// </summary>
    public TerraformProperty<string> QuerypoolConnectionMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("querypool_connection_mode");
        set => SetProperty("querypool_connection_mode", value);
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
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku");
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for ipv4_firewall_rule.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermAnalysisServicesServerIpv4FirewallRuleBlock>? Ipv4FirewallRule
    {
        set => SetProperty("ipv4_firewall_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAnalysisServicesServerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The server_full_name attribute.
    /// </summary>
    public TerraformExpression ServerFullName => this["server_full_name"];

}
