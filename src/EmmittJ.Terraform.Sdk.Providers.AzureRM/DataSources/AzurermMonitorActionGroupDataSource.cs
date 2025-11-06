using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("arm_role_receiver");
        this.DeclareOutput("automation_runbook_receiver");
        this.DeclareOutput("azure_app_push_receiver");
        this.DeclareOutput("azure_function_receiver");
        this.DeclareOutput("email_receiver");
        this.DeclareOutput("enabled");
        this.DeclareOutput("event_hub_receiver");
        this.DeclareOutput("itsm_receiver");
        this.DeclareOutput("logic_app_receiver");
        this.DeclareOutput("short_name");
        this.DeclareOutput("sms_receiver");
        this.DeclareOutput("voice_receiver");
        this.DeclareOutput("webhook_receiver");
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
