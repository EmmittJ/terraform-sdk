using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermCosmosdbPostgresqlFirewallRule.
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbPostgresqlFirewallRuleTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_cosmosdb_postgresql_firewall_rule Terraform resource.
/// Manages a azurerm_cosmosdb_postgresql_firewall_rule resource.
/// </summary>
public partial class AzurermCosmosdbPostgresqlFirewallRule(string name) : TerraformResource("azurerm_cosmosdb_postgresql_firewall_rule", name)
{
    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The end_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndIpAddress is required")]
    public required TerraformValue<string> EndIpAddress
    {
        get => new TerraformReference<string>(this, "end_ip_address");
        set => SetArgument("end_ip_address", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The start_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartIpAddress is required")]
    public required TerraformValue<string> StartIpAddress
    {
        get => new TerraformReference<string>(this, "start_ip_address");
        set => SetArgument("start_ip_address", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCosmosdbPostgresqlFirewallRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCosmosdbPostgresqlFirewallRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
