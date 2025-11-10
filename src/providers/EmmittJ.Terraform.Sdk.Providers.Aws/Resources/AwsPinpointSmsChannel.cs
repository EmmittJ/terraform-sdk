using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_pinpoint_sms_channel resource.
/// </summary>
public class AwsPinpointSmsChannel : TerraformResource
{
    public AwsPinpointSmsChannel(string name) : base("aws_pinpoint_sms_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("promotional_messages_per_second");
        SetOutput("transactional_messages_per_second");
        SetOutput("application_id");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("region");
        SetOutput("sender_id");
        SetOutput("short_code");
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_id");
        set => SetProperty("application_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The sender_id attribute.
    /// </summary>
    public TerraformProperty<string> SenderId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sender_id");
        set => SetProperty("sender_id", value);
    }

    /// <summary>
    /// The short_code attribute.
    /// </summary>
    public TerraformProperty<string> ShortCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("short_code");
        set => SetProperty("short_code", value);
    }

    /// <summary>
    /// The promotional_messages_per_second attribute.
    /// </summary>
    public TerraformExpression PromotionalMessagesPerSecond => this["promotional_messages_per_second"];

    /// <summary>
    /// The transactional_messages_per_second attribute.
    /// </summary>
    public TerraformExpression TransactionalMessagesPerSecond => this["transactional_messages_per_second"];

}
