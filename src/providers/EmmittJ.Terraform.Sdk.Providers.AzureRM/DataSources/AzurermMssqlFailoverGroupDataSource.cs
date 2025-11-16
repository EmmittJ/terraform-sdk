using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_mssql_failover_group Terraform data source.
/// Retrieves information about a azurerm_mssql_failover_group.
/// </summary>
public partial class AzurermMssqlFailoverGroupDataSource(string name) : TerraformDataSource("azurerm_mssql_failover_group", name)
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
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformValue<string> ServerId
    {
        get => new TerraformReference<string>(this, "server_id");
        set => SetArgument("server_id", value);
    }

    /// <summary>
    /// The databases attribute.
    /// </summary>
    public TerraformSet<string> Databases
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "databases").ResolveNodes(ctx));
    }

    /// <summary>
    /// The partner_server attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PartnerServer
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "partner_server").ResolveNodes(ctx));
    }

    /// <summary>
    /// The read_write_endpoint_failover_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReadWriteEndpointFailoverPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "read_write_endpoint_failover_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The readonly_endpoint_failover_policy_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ReadonlyEndpointFailoverPolicyEnabled
    {
        get => new TerraformReference<bool>(this, "readonly_endpoint_failover_policy_enabled");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlFailoverGroupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlFailoverGroupDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
