using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApplicationInsightsSmartDetectionRuleTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_application_insights_smart_detection_rule resource.
/// </summary>
public class AzurermApplicationInsightsSmartDetectionRule : TerraformResource
{
    public AzurermApplicationInsightsSmartDetectionRule(string name) : base("azurerm_application_insights_smart_detection_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("additional_email_recipients");
        SetOutput("application_insights_id");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("send_emails_to_subscription_owners");
    }

    /// <summary>
    /// The additional_email_recipients attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AdditionalEmailRecipients
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("additional_email_recipients");
        set => SetProperty("additional_email_recipients", value);
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    public required TerraformProperty<string> ApplicationInsightsId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_insights_id");
        set => SetProperty("application_insights_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The send_emails_to_subscription_owners attribute.
    /// </summary>
    public TerraformProperty<bool> SendEmailsToSubscriptionOwners
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("send_emails_to_subscription_owners");
        set => SetProperty("send_emails_to_subscription_owners", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApplicationInsightsSmartDetectionRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
