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
        set => SetProperty("refresh_token", value);
    }

    /// <summary>
    /// The token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Token is required")]
    public required TerraformProperty<string> Token
    {
        set => SetProperty("token", value);
    }

    /// <summary>
    /// The token_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenType is required")]
    public required TerraformProperty<string> TokenType
    {
        set => SetProperty("token_type", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("automatic_sync");
        SetOutput("automation_account_id");
        SetOutput("branch");
        SetOutput("description");
        SetOutput("folder_path");
        SetOutput("id");
        SetOutput("name");
        SetOutput("publish_runbook_enabled");
        SetOutput("repository_url");
        SetOutput("source_control_type");
    }

    /// <summary>
    /// The automatic_sync attribute.
    /// </summary>
    public TerraformProperty<bool> AutomaticSync
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("automatic_sync");
        set => SetProperty("automatic_sync", value);
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    public required TerraformProperty<string> AutomationAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("automation_account_id");
        set => SetProperty("automation_account_id", value);
    }

    /// <summary>
    /// The branch attribute.
    /// </summary>
    public TerraformProperty<string> Branch
    {
        get => GetRequiredOutput<TerraformProperty<string>>("branch");
        set => SetProperty("branch", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FolderPath is required")]
    public required TerraformProperty<string> FolderPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("folder_path");
        set => SetProperty("folder_path", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The publish_runbook_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublishRunbookEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("publish_runbook_enabled");
        set => SetProperty("publish_runbook_enabled", value);
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    public required TerraformProperty<string> RepositoryUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repository_url");
        set => SetProperty("repository_url", value);
    }

    /// <summary>
    /// The source_control_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceControlType is required")]
    public required TerraformProperty<string> SourceControlType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_control_type");
        set => SetProperty("source_control_type", value);
    }

    /// <summary>
    /// Block for security.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Security is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Security block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Security block(s) allowed")]
    public List<AzurermAutomationSourceControlSecurityBlock>? Security
    {
        set => SetProperty("security", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAutomationSourceControlTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
