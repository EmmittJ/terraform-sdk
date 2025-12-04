using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermEventhubSasDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermEventhubSasDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_eventhub_sas Terraform data source.
/// Retrieves information about a azurerm_eventhub_sas.
/// </summary>
public partial class AzurermEventhubSasDataSource(string name) : TerraformDataSource("azurerm_eventhub_sas", name)
{
    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    public required TerraformValue<string> ConnectionString
    {
        get => GetArgument<TerraformValue<string>>("connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expiry is required")]
    public required TerraformValue<string> Expiry
    {
        get => GetArgument<TerraformValue<string>>("expiry");
        set => SetArgument("expiry", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The sas attribute.
    /// </summary>
    public TerraformValue<string> Sas
        => AsReference("sas");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEventhubSasDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventhubSasDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
