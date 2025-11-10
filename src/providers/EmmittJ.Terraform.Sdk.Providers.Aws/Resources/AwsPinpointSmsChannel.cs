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
        this.DeclareOutput("promotional_messages_per_second");
        this.DeclareOutput("transactional_messages_per_second");
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The sender_id attribute.
    /// </summary>
    public TerraformProperty<string>? SenderId
    {
        get => GetProperty<TerraformProperty<string>>("sender_id");
        set => this.WithProperty("sender_id", value);
    }

    /// <summary>
    /// The short_code attribute.
    /// </summary>
    public TerraformProperty<string>? ShortCode
    {
        get => GetProperty<TerraformProperty<string>>("short_code");
        set => this.WithProperty("short_code", value);
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
