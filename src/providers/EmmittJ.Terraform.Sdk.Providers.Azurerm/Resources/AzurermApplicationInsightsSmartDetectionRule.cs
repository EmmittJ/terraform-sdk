using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApplicationInsightsSmartDetectionRule.
/// Nesting mode: single
/// </summary>
public class AzurermApplicationInsightsSmartDetectionRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_application_insights_smart_detection_rule Terraform resource.
/// Manages a azurerm_application_insights_smart_detection_rule resource.
/// </summary>
public partial class AzurermApplicationInsightsSmartDetectionRule(string name) : TerraformResource("azurerm_application_insights_smart_detection_rule", name)
{
    /// <summary>
    /// The additional_email_recipients attribute.
    /// </summary>
    public TerraformSet<string>? AdditionalEmailRecipients
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "additional_email_recipients").ResolveNodes(ctx));
        set => SetArgument("additional_email_recipients", value);
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    public required TerraformValue<string> ApplicationInsightsId
    {
        get => new TerraformReference<string>(this, "application_insights_id");
        set => SetArgument("application_insights_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The send_emails_to_subscription_owners attribute.
    /// </summary>
    public TerraformValue<bool>? SendEmailsToSubscriptionOwners
    {
        get => new TerraformReference<bool>(this, "send_emails_to_subscription_owners");
        set => SetArgument("send_emails_to_subscription_owners", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApplicationInsightsSmartDetectionRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApplicationInsightsSmartDetectionRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
