using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMssqlServerDnsAlias.
/// Nesting mode: single
/// </summary>
public class AzurermMssqlServerDnsAliasTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azurerm_mssql_server_dns_alias Terraform resource.
/// Manages a azurerm_mssql_server_dns_alias resource.
/// </summary>
public partial class AzurermMssqlServerDnsAlias(string name) : TerraformResource("azurerm_mssql_server_dns_alias", name)
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
    /// The mssql_server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MssqlServerId is required")]
    public required TerraformValue<string> MssqlServerId
    {
        get => new TerraformReference<string>(this, "mssql_server_id");
        set => SetArgument("mssql_server_id", value);
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
    /// The dns_record attribute.
    /// </summary>
    public TerraformValue<string> DnsRecord
    {
        get => new TerraformReference<string>(this, "dns_record");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlServerDnsAliasTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlServerDnsAliasTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
