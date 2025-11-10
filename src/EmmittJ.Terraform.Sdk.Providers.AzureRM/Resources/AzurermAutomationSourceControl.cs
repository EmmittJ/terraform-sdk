using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for security in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSourceControlSecurityBlock : TerraformBlock
{
    /// <summary>
    /// The refresh_token attribute.
    /// </summary>
    public TerraformProperty<string>? RefreshToken
    {
        get => GetProperty<TerraformProperty<string>>("refresh_token");
        set => WithProperty("refresh_token", value);
    }

    /// <summary>
    /// The token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Token is required")]
    public required TerraformProperty<string> Token
    {
        get => GetProperty<TerraformProperty<string>>("token");
        set => WithProperty("token", value);
    }

    /// <summary>
    /// The token_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenType is required")]
    public required TerraformProperty<string> TokenType
    {
        get => GetProperty<TerraformProperty<string>>("token_type");
        set => WithProperty("token_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationSourceControlTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The automatic_sync attribute.
    /// </summary>
    public TerraformProperty<bool>? AutomaticSync
    {
        get => GetProperty<TerraformProperty<bool>>("automatic_sync");
        set => this.WithProperty("automatic_sync", value);
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    public required TerraformProperty<string> AutomationAccountId
    {
        get => GetProperty<TerraformProperty<string>>("automation_account_id");
        set => this.WithProperty("automation_account_id", value);
    }

    /// <summary>
    /// The branch attribute.
    /// </summary>
    public TerraformProperty<string>? Branch
    {
        get => GetProperty<TerraformProperty<string>>("branch");
        set => this.WithProperty("branch", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FolderPath is required")]
    public required TerraformProperty<string> FolderPath
    {
        get => GetProperty<TerraformProperty<string>>("folder_path");
        set => this.WithProperty("folder_path", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The publish_runbook_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublishRunbookEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("publish_runbook_enabled");
        set => this.WithProperty("publish_runbook_enabled", value);
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    public required TerraformProperty<string> RepositoryUrl
    {
        get => GetProperty<TerraformProperty<string>>("repository_url");
        set => this.WithProperty("repository_url", value);
    }

    /// <summary>
    /// The source_control_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceControlType is required")]
    public required TerraformProperty<string> SourceControlType
    {
        get => GetProperty<TerraformProperty<string>>("source_control_type");
        set => this.WithProperty("source_control_type", value);
    }

    /// <summary>
    /// Block for security.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Security block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Security block(s) allowed")]
    public List<AzurermAutomationSourceControlSecurityBlock>? Security
    {
        get => GetProperty<List<AzurermAutomationSourceControlSecurityBlock>>("security");
        set => this.WithProperty("security", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAutomationSourceControlTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAutomationSourceControlTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
