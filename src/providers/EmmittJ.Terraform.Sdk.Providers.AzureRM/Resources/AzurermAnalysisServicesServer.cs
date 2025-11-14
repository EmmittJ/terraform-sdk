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
/// Block type for ipv4_firewall_rule in .
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
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The range_end attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeEnd is required")]
    [TerraformArgument("range_end")]
    public required TerraformValue<string> RangeEnd
    {
        get => new TerraformReference<string>(this, "range_end");
        set => SetArgument("range_end", value);
    }

    /// <summary>
    /// The range_start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeStart is required")]
    [TerraformArgument("range_start")]
    public required TerraformValue<string> RangeStart
    {
        get => new TerraformReference<string>(this, "range_start");
        set => SetArgument("range_start", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_analysis_services_server resource.
/// </summary>
public class AzurermAnalysisServicesServer : TerraformResource
{
    public AzurermAnalysisServicesServer(string name) : base("azurerm_analysis_services_server", name)
    {
    }

    /// <summary>
    /// The admin_users attribute.
    /// </summary>
    [TerraformArgument("admin_users")]
    public TerraformSet<string>? AdminUsers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "admin_users").ResolveNodes(ctx));
        set => SetArgument("admin_users", value);
    }

    /// <summary>
    /// The backup_blob_container_uri attribute.
    /// </summary>
    [TerraformArgument("backup_blob_container_uri")]
    public TerraformValue<string>? BackupBlobContainerUri
    {
        get => new TerraformReference<string>(this, "backup_blob_container_uri");
        set => SetArgument("backup_blob_container_uri", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The power_bi_service_enabled attribute.
    /// </summary>
    [TerraformArgument("power_bi_service_enabled")]
    public TerraformValue<bool>? PowerBiServiceEnabled
    {
        get => new TerraformReference<bool>(this, "power_bi_service_enabled");
        set => SetArgument("power_bi_service_enabled", value);
    }

    /// <summary>
    /// The querypool_connection_mode attribute.
    /// </summary>
    [TerraformArgument("querypool_connection_mode")]
    public TerraformValue<string>? QuerypoolConnectionMode
    {
        get => new TerraformReference<string>(this, "querypool_connection_mode");
        set => SetArgument("querypool_connection_mode", value);
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
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformArgument("sku")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for ipv4_firewall_rule.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("ipv4_firewall_rule")]
    public TerraformSet<AzurermAnalysisServicesServerIpv4FirewallRuleBlock> Ipv4FirewallRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAnalysisServicesServerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The server_full_name attribute.
    /// </summary>
    [TerraformArgument("server_full_name")]
    public TerraformValue<string> ServerFullName
    {
        get => new TerraformReference<string>(this, "server_full_name");
    }

}
