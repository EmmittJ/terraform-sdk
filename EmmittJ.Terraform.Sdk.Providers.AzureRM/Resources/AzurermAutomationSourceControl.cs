using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_automation_source_control resource.
/// </summary>
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
    public bool? AutomaticSync
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("automatic_sync")?.Value;
        set => this.WithProperty("automatic_sync", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    public string? AutomationAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("automation_account_id")?.Value;
        set => this.WithProperty("automation_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The branch attribute.
    /// </summary>
    public string? Branch
    {
        get => GetProperty<TerraformLiteralProperty<string>>("branch")?.Value;
        set => this.WithProperty("branch", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    public string? FolderPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("folder_path")?.Value;
        set => this.WithProperty("folder_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The publish_runbook_enabled attribute.
    /// </summary>
    public bool? PublishRunbookEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("publish_runbook_enabled")?.Value;
        set => this.WithProperty("publish_runbook_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    public string? RepositoryUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_url")?.Value;
        set => this.WithProperty("repository_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_control_type attribute.
    /// </summary>
    public string? SourceControlType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_control_type")?.Value;
        set => this.WithProperty("source_control_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
