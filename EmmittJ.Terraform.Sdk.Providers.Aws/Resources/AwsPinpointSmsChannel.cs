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
    public string? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id")?.Value;
        set => this.WithProperty("application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sender_id attribute.
    /// </summary>
    public string? SenderId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sender_id")?.Value;
        set => this.WithProperty("sender_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The short_code attribute.
    /// </summary>
    public string? ShortCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("short_code")?.Value;
        set => this.WithProperty("short_code", value == null ? null : new TerraformLiteralProperty<string>(value));
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
