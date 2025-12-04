using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApplicationInsightsApiKey.
/// Nesting mode: single
/// </summary>
public class AzurermApplicationInsightsApiKeyTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

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
/// Represents a azurerm_application_insights_api_key Terraform resource.
/// Manages a azurerm_application_insights_api_key resource.
/// </summary>
public partial class AzurermApplicationInsightsApiKey(string name) : TerraformResource("azurerm_application_insights_api_key", name)
{
    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    public required TerraformValue<string> ApplicationInsightsId
    {
        get => GetArgument<TerraformValue<string>>("application_insights_id");
        set => SetArgument("application_insights_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The read_permissions attribute.
    /// </summary>
    public TerraformSet<string>? ReadPermissions
    {
        get => GetArgument<TerraformSet<string>>("read_permissions");
        set => SetArgument("read_permissions", value);
    }

    /// <summary>
    /// The write_permissions attribute.
    /// </summary>
    public TerraformSet<string>? WritePermissions
    {
        get => GetArgument<TerraformSet<string>>("write_permissions");
        set => SetArgument("write_permissions", value);
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    public TerraformValue<string> ApiKey
        => AsReference("api_key");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApplicationInsightsApiKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApplicationInsightsApiKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
