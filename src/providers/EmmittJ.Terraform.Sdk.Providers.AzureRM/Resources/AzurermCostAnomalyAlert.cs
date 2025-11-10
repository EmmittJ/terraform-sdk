using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCostAnomalyAlertTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_cost_anomaly_alert resource.
/// </summary>
public class AzurermCostAnomalyAlert : TerraformResource
{
    public AzurermCostAnomalyAlert(string name) : base("azurerm_cost_anomaly_alert", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("display_name");
        SetOutput("email_addresses");
        SetOutput("email_subject");
        SetOutput("id");
        SetOutput("message");
        SetOutput("name");
        SetOutput("notification_email");
        SetOutput("subscription_id");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddresses is required")]
    public HashSet<TerraformProperty<string>> EmailAddresses
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("email_addresses");
        set => SetProperty("email_addresses", value);
    }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailSubject is required")]
    public required TerraformProperty<string> EmailSubject
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email_subject");
        set => SetProperty("email_subject", value);
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
    /// The message attribute.
    /// </summary>
    public TerraformProperty<string> Message
    {
        get => GetRequiredOutput<TerraformProperty<string>>("message");
        set => SetProperty("message", value);
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
    /// The notification_email attribute.
    /// </summary>
    public TerraformProperty<string> NotificationEmail
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notification_email");
        set => SetProperty("notification_email", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformProperty<string> SubscriptionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subscription_id");
        set => SetProperty("subscription_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCostAnomalyAlertTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
