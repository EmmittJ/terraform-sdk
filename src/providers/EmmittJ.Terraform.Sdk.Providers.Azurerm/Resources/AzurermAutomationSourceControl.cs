using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for security in AzurermAutomationSourceControl.
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSourceControlSecurityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security";

    /// <summary>
    /// The refresh_token attribute.
    /// </summary>
    public TerraformValue<string>? RefreshToken
    {
        get => GetArgument<TerraformValue<string>>("refresh_token");
        set => SetArgument("refresh_token", value);
    }

    /// <summary>
    /// The token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Token is required")]
    public required TerraformValue<string> Token
    {
        get => GetArgument<TerraformValue<string>>("token");
        set => SetArgument("token", value);
    }

    /// <summary>
    /// The token_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenType is required")]
    public required TerraformValue<string> TokenType
    {
        get => GetArgument<TerraformValue<string>>("token_type");
        set => SetArgument("token_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermAutomationSourceControl.
/// Nesting mode: single
/// </summary>
public class AzurermAutomationSourceControlTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_automation_source_control Terraform resource.
/// Manages a azurerm_automation_source_control resource.
/// </summary>
public partial class AzurermAutomationSourceControl(string name) : TerraformResource("azurerm_automation_source_control", name)
{
    /// <summary>
    /// The automatic_sync attribute.
    /// </summary>
    public TerraformValue<bool>? AutomaticSync
    {
        get => GetArgument<TerraformValue<bool>>("automatic_sync");
        set => SetArgument("automatic_sync", value);
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    public required TerraformValue<string> AutomationAccountId
    {
        get => GetArgument<TerraformValue<string>>("automation_account_id");
        set => SetArgument("automation_account_id", value);
    }

    /// <summary>
    /// The branch attribute.
    /// </summary>
    public TerraformValue<string>? Branch
    {
        get => GetArgument<TerraformValue<string>>("branch");
        set => SetArgument("branch", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FolderPath is required")]
    public required TerraformValue<string> FolderPath
    {
        get => GetArgument<TerraformValue<string>>("folder_path");
        set => SetArgument("folder_path", value);
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
    /// The publish_runbook_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublishRunbookEnabled
    {
        get => GetArgument<TerraformValue<bool>>("publish_runbook_enabled");
        set => SetArgument("publish_runbook_enabled", value);
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    public required TerraformValue<string> RepositoryUrl
    {
        get => GetArgument<TerraformValue<string>>("repository_url");
        set => SetArgument("repository_url", value);
    }

    /// <summary>
    /// The source_control_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceControlType is required")]
    public required TerraformValue<string> SourceControlType
    {
        get => GetArgument<TerraformValue<string>>("source_control_type");
        set => SetArgument("source_control_type", value);
    }

    /// <summary>
    /// Security block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Security is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Security block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Security block(s) allowed")]
    public required TerraformList<AzurermAutomationSourceControlSecurityBlock> Security
    {
        get => GetRequiredArgument<TerraformList<AzurermAutomationSourceControlSecurityBlock>>("security");
        set => SetArgument("security", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAutomationSourceControlTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAutomationSourceControlTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
