using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsWorkspaceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_log_analytics_workspace.
/// </summary>
public class AzurermLogAnalyticsWorkspaceDataSource : TerraformDataSource
{
    public AzurermLogAnalyticsWorkspaceDataSource(string name) : base("azurerm_log_analytics_workspace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("daily_quota_gb");
        this.WithOutput("location");
        this.WithOutput("primary_shared_key");
        this.WithOutput("retention_in_days");
        this.WithOutput("secondary_shared_key");
        this.WithOutput("sku");
        this.WithOutput("tags");
        this.WithOutput("workspace_id");
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogAnalyticsWorkspaceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermLogAnalyticsWorkspaceDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The daily_quota_gb attribute.
    /// </summary>
    public TerraformExpression DailyQuotaGb => this["daily_quota_gb"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The primary_shared_key attribute.
    /// </summary>
    public TerraformExpression PrimarySharedKey => this["primary_shared_key"];

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformExpression RetentionInDays => this["retention_in_days"];

    /// <summary>
    /// The secondary_shared_key attribute.
    /// </summary>
    public TerraformExpression SecondarySharedKey => this["secondary_shared_key"];

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformExpression Sku => this["sku"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformExpression WorkspaceId => this["workspace_id"];

}
