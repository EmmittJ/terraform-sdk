using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSourceControlTokenDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The token attribute.
    /// </summary>
    public TerraformValue<string> Token
        => CreateReference("token");

    /// <summary>
    /// The token_secret attribute.
    /// </summary>
    public TerraformValue<string> TokenSecret
        => CreateReference("token_secret");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSourceControlTokenDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSourceControlTokenDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
