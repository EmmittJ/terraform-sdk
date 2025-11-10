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
    }

    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CustomerManagedKeyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("customer_managed_key_enabled");
        set => this.WithProperty("customer_managed_key_enabled", value);
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
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelLogAnalyticsWorkspaceOnboardingTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSentinelLogAnalyticsWorkspaceOnboardingTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
