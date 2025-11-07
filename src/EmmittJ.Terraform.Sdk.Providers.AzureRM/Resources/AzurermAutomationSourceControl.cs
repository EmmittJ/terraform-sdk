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
    public TerraformLiteralProperty<bool>? AutomaticSync
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("automatic_sync");
        set => this.WithProperty("automatic_sync", value);
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AutomationAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("automation_account_id");
        set => this.WithProperty("automation_account_id", value);
    }

    /// <summary>
    /// The branch attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Branch
    {
        get => GetProperty<TerraformLiteralProperty<string>>("branch");
        set => this.WithProperty("branch", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FolderPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("folder_path");
        set => this.WithProperty("folder_path", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The publish_runbook_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PublishRunbookEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("publish_runbook_enabled");
        set => this.WithProperty("publish_runbook_enabled", value);
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RepositoryUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_url");
        set => this.WithProperty("repository_url", value);
    }

    /// <summary>
    /// The source_control_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceControlType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_control_type");
        set => this.WithProperty("source_control_type", value);
    }

}
