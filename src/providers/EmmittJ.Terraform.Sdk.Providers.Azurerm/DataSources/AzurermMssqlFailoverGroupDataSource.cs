using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMssqlFailoverGroupDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformValue<string> ServerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("server_id");
        set => SetArgument("server_id", value);
    }

    /// <summary>
    /// The databases attribute.
    /// </summary>
    public TerraformSet<string> Databases
        => CreateReference("databases");

    /// <summary>
    /// The partner_server attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PartnerServer
        => CreateReference("partner_server");

    /// <summary>
    /// The read_write_endpoint_failover_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReadWriteEndpointFailoverPolicy
        => CreateReference("read_write_endpoint_failover_policy");

    /// <summary>
    /// The readonly_endpoint_failover_policy_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ReadonlyEndpointFailoverPolicyEnabled
        => CreateReference("readonly_endpoint_failover_policy_enabled");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlFailoverGroupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlFailoverGroupDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
