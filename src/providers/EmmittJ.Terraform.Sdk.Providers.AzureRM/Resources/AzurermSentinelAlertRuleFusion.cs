using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleFusionSourceBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleFusionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_sentinel_alert_rule_fusion resource.
/// </summary>
public class AzurermSentinelAlertRuleFusion : TerraformResource
{
    public AzurermSentinelAlertRuleFusion(string name) : base("azurerm_sentinel_alert_rule_fusion", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("alert_rule_template_guid");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("log_analytics_workspace_id");
        SetOutput("name");
    }

    /// <summary>
    /// The alert_rule_template_guid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlertRuleTemplateGuid is required")]
    public required TerraformProperty<string> AlertRuleTemplateGuid
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alert_rule_template_guid");
        set => SetProperty("alert_rule_template_guid", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
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
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformProperty<string> LogAnalyticsWorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_analytics_workspace_id");
        set => SetProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelAlertRuleFusionSourceBlock>? Source
    {
        set => SetProperty("source", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelAlertRuleFusionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
