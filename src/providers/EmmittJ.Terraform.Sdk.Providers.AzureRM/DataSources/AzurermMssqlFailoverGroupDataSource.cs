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
public class AzurermMssqlFailoverGroupDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_mssql_failover_group.
/// </summary>
public class AzurermMssqlFailoverGroupDataSource : TerraformDataSource
{
    public AzurermMssqlFailoverGroupDataSource(string name) : base("azurerm_mssql_failover_group", name)
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
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformArgument("server_id")]
    public required TerraformValue<string> ServerId
    {
        get => new TerraformReference<string>(this, "server_id");
        set => SetArgument("server_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMssqlFailoverGroupDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The databases attribute.
    /// </summary>
    [TerraformArgument("databases")]
    public TerraformSet<string> Databases
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "databases").ResolveNodes(ctx));
    }

    /// <summary>
    /// The partner_server attribute.
    /// </summary>
    [TerraformArgument("partner_server")]
    public TerraformList<object> PartnerServer
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "partner_server").ResolveNodes(ctx));
    }

    /// <summary>
    /// The read_write_endpoint_failover_policy attribute.
    /// </summary>
    [TerraformArgument("read_write_endpoint_failover_policy")]
    public TerraformList<object> ReadWriteEndpointFailoverPolicy
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "read_write_endpoint_failover_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The readonly_endpoint_failover_policy_enabled attribute.
    /// </summary>
    [TerraformArgument("readonly_endpoint_failover_policy_enabled")]
    public TerraformValue<bool> ReadonlyEndpointFailoverPolicyEnabled
    {
        get => new TerraformReference<bool>(this, "readonly_endpoint_failover_policy_enabled");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

}
