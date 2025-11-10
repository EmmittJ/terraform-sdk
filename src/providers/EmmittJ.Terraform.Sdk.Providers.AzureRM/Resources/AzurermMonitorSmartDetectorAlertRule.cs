using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for action_group in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorSmartDetectorAlertRuleActionGroupBlock : TerraformBlock
{
    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    public TerraformProperty<string>? EmailSubject
    {
        set => SetProperty("email_subject", value);
    }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ids is required")]
    public HashSet<TerraformProperty<string>>? Ids
    {
        set => SetProperty("ids", value);
    }

    /// <summary>
    /// The webhook_payload attribute.
    /// </summary>
    public TerraformProperty<string>? WebhookPayload
    {
        set => SetProperty("webhook_payload", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorSmartDetectorAlertRuleTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_monitor_smart_detector_alert_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMonitorSmartDetectorAlertRule : TerraformResource
{
    public AzurermMonitorSmartDetectorAlertRule(string name) : base("azurerm_monitor_smart_detector_alert_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("detector_type");
        SetOutput("enabled");
        SetOutput("frequency");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("scope_resource_ids");
        SetOutput("severity");
        SetOutput("tags");
        SetOutput("throttling_duration");
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
    /// The detector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorType is required")]
    public required TerraformProperty<string> DetectorType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("detector_type");
        set => SetProperty("detector_type", value);
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
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformProperty<string> Frequency
    {
        get => GetRequiredOutput<TerraformProperty<string>>("frequency");
        set => SetProperty("frequency", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The scope_resource_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeResourceIds is required")]
    public HashSet<TerraformProperty<string>> ScopeResourceIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("scope_resource_ids");
        set => SetProperty("scope_resource_ids", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    public required TerraformProperty<string> Severity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("severity");
        set => SetProperty("severity", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The throttling_duration attribute.
    /// </summary>
    public TerraformProperty<string> ThrottlingDuration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("throttling_duration");
        set => SetProperty("throttling_duration", value);
    }

    /// <summary>
    /// Block for action_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ActionGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActionGroup block(s) allowed")]
    public List<AzurermMonitorSmartDetectorAlertRuleActionGroupBlock>? ActionGroup
    {
        set => SetProperty("action_group", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorSmartDetectorAlertRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
