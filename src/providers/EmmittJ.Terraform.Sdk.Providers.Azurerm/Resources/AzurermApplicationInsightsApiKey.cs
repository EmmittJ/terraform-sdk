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
        get => new TerraformReference<string>(this, "application_insights_id");
        set => SetArgument("application_insights_id", value);
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
    /// The read_permissions attribute.
    /// </summary>
    public TerraformSet<string>? ReadPermissions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "read_permissions").ResolveNodes(ctx));
        set => SetArgument("read_permissions", value);
    }

    /// <summary>
    /// The write_permissions attribute.
    /// </summary>
    public TerraformSet<string>? WritePermissions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "write_permissions").ResolveNodes(ctx));
        set => SetArgument("write_permissions", value);
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    public TerraformValue<string> ApiKey
    {
        get => new TerraformReference<string>(this, "api_key");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApplicationInsightsApiKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApplicationInsightsApiKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
