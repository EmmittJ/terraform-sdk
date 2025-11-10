using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsWorkspaceTableTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_log_analytics_workspace_table resource.
/// </summary>
public class AzurermLogAnalyticsWorkspaceTable : TerraformResource
{
    public AzurermLogAnalyticsWorkspaceTable(string name) : base("azurerm_log_analytics_workspace_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("name");
        SetOutput("plan");
        SetOutput("retention_in_days");
        SetOutput("total_retention_in_days");
        SetOutput("workspace_id");
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
    /// The plan attribute.
    /// </summary>
    public TerraformProperty<string> Plan
    {
        get => GetRequiredOutput<TerraformProperty<string>>("plan");
        set => SetProperty("plan", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformProperty<double> RetentionInDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("retention_in_days");
        set => SetProperty("retention_in_days", value);
    }

    /// <summary>
    /// The total_retention_in_days attribute.
    /// </summary>
    public TerraformProperty<double> TotalRetentionInDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("total_retention_in_days");
        set => SetProperty("total_retention_in_days", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workspace_id");
        set => SetProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogAnalyticsWorkspaceTableTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
