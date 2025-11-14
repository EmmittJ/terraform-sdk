using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for security in .
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
    [TerraformArgument("refresh_token")]
    public TerraformValue<string>? RefreshToken
    {
        get => new TerraformReference<string>(this, "refresh_token");
        set => SetArgument("refresh_token", value);
    }

    /// <summary>
    /// The token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Token is required")]
    [TerraformArgument("token")]
    public required TerraformValue<string> Token
    {
        get => new TerraformReference<string>(this, "token");
        set => SetArgument("token", value);
    }

    /// <summary>
    /// The token_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenType is required")]
    [TerraformArgument("token_type")]
    public required TerraformValue<string> TokenType
    {
        get => new TerraformReference<string>(this, "token_type");
        set => SetArgument("token_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_automation_source_control resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermAutomationSourceControl : TerraformResource
{
    public AzurermAutomationSourceControl(string name) : base("azurerm_automation_source_control", name)
    {
    }

    /// <summary>
    /// The automatic_sync attribute.
    /// </summary>
    [TerraformArgument("automatic_sync")]
    public TerraformValue<bool>? AutomaticSync
    {
        get => new TerraformReference<bool>(this, "automatic_sync");
        set => SetArgument("automatic_sync", value);
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    [TerraformArgument("automation_account_id")]
    public required TerraformValue<string> AutomationAccountId
    {
        get => new TerraformReference<string>(this, "automation_account_id");
        set => SetArgument("automation_account_id", value);
    }

    /// <summary>
    /// The branch attribute.
    /// </summary>
    [TerraformArgument("branch")]
    public TerraformValue<string>? Branch
    {
        get => new TerraformReference<string>(this, "branch");
        set => SetArgument("branch", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FolderPath is required")]
    [TerraformArgument("folder_path")]
    public required TerraformValue<string> FolderPath
    {
        get => new TerraformReference<string>(this, "folder_path");
        set => SetArgument("folder_path", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The publish_runbook_enabled attribute.
    /// </summary>
    [TerraformArgument("publish_runbook_enabled")]
    public TerraformValue<bool>? PublishRunbookEnabled
    {
        get => new TerraformReference<bool>(this, "publish_runbook_enabled");
        set => SetArgument("publish_runbook_enabled", value);
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    [TerraformArgument("repository_url")]
    public required TerraformValue<string> RepositoryUrl
    {
        get => new TerraformReference<string>(this, "repository_url");
        set => SetArgument("repository_url", value);
    }

    /// <summary>
    /// The source_control_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceControlType is required")]
    [TerraformArgument("source_control_type")]
    public required TerraformValue<string> SourceControlType
    {
        get => new TerraformReference<string>(this, "source_control_type");
        set => SetArgument("source_control_type", value);
    }

    /// <summary>
    /// Block for security.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Security is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Security block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Security block(s) allowed")]
    [TerraformArgument("security")]
    public required TerraformList<AzurermAutomationSourceControlSecurityBlock> Security { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAutomationSourceControlTimeoutsBlock Timeouts { get; set; } = new();

}
