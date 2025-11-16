using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSourceControlTokenDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_source_control_token Terraform data source.
/// Retrieves information about a azurerm_source_control_token.
/// </summary>
public partial class AzurermSourceControlTokenDataSource(string name) : TerraformDataSource("azurerm_source_control_token", name)
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The token attribute.
    /// </summary>
    public TerraformValue<string> Token
    {
        get => new TerraformReference<string>(this, "token");
    }

    /// <summary>
    /// The token_secret attribute.
    /// </summary>
    public TerraformValue<string> TokenSecret
    {
        get => new TerraformReference<string>(this, "token_secret");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSourceControlTokenDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSourceControlTokenDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
