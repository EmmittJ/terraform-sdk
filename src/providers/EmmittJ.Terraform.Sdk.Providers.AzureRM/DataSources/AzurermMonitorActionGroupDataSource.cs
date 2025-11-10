using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorActionGroupDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_monitor_action_group.
/// </summary>
public class AzurermMonitorActionGroupDataSource : TerraformDataSource
{
    public AzurermMonitorActionGroupDataSource(string name) : base("azurerm_monitor_action_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arm_role_receiver");
        SetOutput("automation_runbook_receiver");
        SetOutput("azure_app_push_receiver");
        SetOutput("azure_function_receiver");
        SetOutput("email_receiver");
        SetOutput("enabled");
        SetOutput("event_hub_receiver");
        SetOutput("itsm_receiver");
        SetOutput("logic_app_receiver");
        SetOutput("short_name");
        SetOutput("sms_receiver");
        SetOutput("voice_receiver");
        SetOutput("webhook_receiver");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorActionGroupDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arm_role_receiver attribute.
    /// </summary>
    public TerraformExpression ArmRoleReceiver => this["arm_role_receiver"];

    /// <summary>
    /// The automation_runbook_receiver attribute.
    /// </summary>
    public TerraformExpression AutomationRunbookReceiver => this["automation_runbook_receiver"];

    /// <summary>
    /// The azure_app_push_receiver attribute.
    /// </summary>
    public TerraformExpression AzureAppPushReceiver => this["azure_app_push_receiver"];

    /// <summary>
    /// The azure_function_receiver attribute.
    /// </summary>
    public TerraformExpression AzureFunctionReceiver => this["azure_function_receiver"];

    /// <summary>
    /// The email_receiver attribute.
    /// </summary>
    public TerraformExpression EmailReceiver => this["email_receiver"];

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformExpression Enabled => this["enabled"];

    /// <summary>
    /// The event_hub_receiver attribute.
    /// </summary>
    public TerraformExpression EventHubReceiver => this["event_hub_receiver"];

    /// <summary>
    /// The itsm_receiver attribute.
    /// </summary>
    public TerraformExpression ItsmReceiver => this["itsm_receiver"];

    /// <summary>
    /// The logic_app_receiver attribute.
    /// </summary>
    public TerraformExpression LogicAppReceiver => this["logic_app_receiver"];

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    public TerraformExpression ShortName => this["short_name"];

    /// <summary>
    /// The sms_receiver attribute.
    /// </summary>
    public TerraformExpression SmsReceiver => this["sms_receiver"];

    /// <summary>
    /// The voice_receiver attribute.
    /// </summary>
    public TerraformExpression VoiceReceiver => this["voice_receiver"];

    /// <summary>
    /// The webhook_receiver attribute.
    /// </summary>
    public TerraformExpression WebhookReceiver => this["webhook_receiver"];

}
