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
    public TerraformProperty<bool>? AutomaticSync
    {
        get => GetProperty<TerraformProperty<bool>>("automatic_sync");
        set => this.WithProperty("automatic_sync", value);
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AutomationAccountId
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
    public TerraformProperty<string>? FolderPath
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
    public TerraformProperty<string>? Name
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
    public TerraformProperty<string>? RepositoryUrl
    {
        get => GetProperty<TerraformProperty<string>>("repository_url");
        set => this.WithProperty("repository_url", value);
    }

    /// <summary>
    /// The source_control_type attribute.
    /// </summary>
    public TerraformProperty<string>? SourceControlType
    {
        get => GetProperty<TerraformProperty<string>>("source_control_type");
        set => this.WithProperty("source_control_type", value);
    }

}
