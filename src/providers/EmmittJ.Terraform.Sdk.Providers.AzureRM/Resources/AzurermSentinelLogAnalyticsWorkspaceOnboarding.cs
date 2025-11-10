using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelLogAnalyticsWorkspaceOnboardingTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_sentinel_log_analytics_workspace_onboarding resource.
/// </summary>
public class AzurermSentinelLogAnalyticsWorkspaceOnboarding : TerraformResource
{
    public AzurermSentinelLogAnalyticsWorkspaceOnboarding(string name) : base("azurerm_sentinel_log_analytics_workspace_onboarding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("customer_managed_key_enabled");
        SetOutput("id");
        SetOutput("workspace_id");
    }

    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> CustomerManagedKeyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("customer_managed_key_enabled");
        set => SetProperty("customer_managed_key_enabled", value);
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
    public AzurermSentinelLogAnalyticsWorkspaceOnboardingTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
