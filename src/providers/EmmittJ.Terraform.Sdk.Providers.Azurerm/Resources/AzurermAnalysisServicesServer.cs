using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for ipv4_firewall_rule in AzurermAnalysisServicesServer.
/// Nesting mode: set
/// </summary>
public class AzurermAnalysisServicesServerIpv4FirewallRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ipv4_firewall_rule";

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
    /// The range_end attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeEnd is required")]
    public required TerraformValue<string> RangeEnd
    {
        get => new TerraformReference<string>(this, "range_end");
        set => SetArgument("range_end", value);
    }

    /// <summary>
    /// The range_start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeStart is required")]
    public required TerraformValue<string> RangeStart
    {
        get => new TerraformReference<string>(this, "range_start");
        set => SetArgument("range_start", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermAnalysisServicesServer.
/// Nesting mode: single
/// </summary>
public class AzurermAnalysisServicesServerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_analysis_services_server Terraform resource.
/// Manages a azurerm_analysis_services_server resource.
/// </summary>
public partial class AzurermAnalysisServicesServer(string name) : TerraformResource("azurerm_analysis_services_server", name)
{
    /// <summary>
    /// The admin_users attribute.
    /// </summary>
    public TerraformSet<string>? AdminUsers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "admin_users").ResolveNodes(ctx));
        set => SetArgument("admin_users", value);
    }

    /// <summary>
    /// The backup_blob_container_uri attribute.
    /// </summary>
    public TerraformValue<string>? BackupBlobContainerUri
    {
        get => new TerraformReference<string>(this, "backup_blob_container_uri");
        set => SetArgument("backup_blob_container_uri", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The power_bi_service_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PowerBiServiceEnabled
    {
        get => new TerraformReference<bool>(this, "power_bi_service_enabled");
        set => SetArgument("power_bi_service_enabled", value);
    }

    /// <summary>
    /// The querypool_connection_mode attribute.
    /// </summary>
    public TerraformValue<string>? QuerypoolConnectionMode
    {
        get => new TerraformReference<string>(this, "querypool_connection_mode");
        set => SetArgument("querypool_connection_mode", value);
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
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
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
    /// The server_full_name attribute.
    /// </summary>
    public TerraformValue<string> ServerFullName
    {
        get => new TerraformReference<string>(this, "server_full_name");
    }

    /// <summary>
    /// Ipv4FirewallRule block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermAnalysisServicesServerIpv4FirewallRuleBlock>? Ipv4FirewallRule
    {
        get => GetArgument<TerraformSet<AzurermAnalysisServicesServerIpv4FirewallRuleBlock>>("ipv4_firewall_rule");
        set => SetArgument("ipv4_firewall_rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAnalysisServicesServerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAnalysisServicesServerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
