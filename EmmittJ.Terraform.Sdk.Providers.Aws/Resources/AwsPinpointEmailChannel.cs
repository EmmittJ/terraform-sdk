using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_pinpoint_email_channel resource.
/// </summary>
public class AwsPinpointEmailChannel : TerraformResource
{
    public AwsPinpointEmailChannel(string name) : base("aws_pinpoint_email_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("messages_per_second");
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
    /// The configuration_set attribute.
    /// </summary>
    public string? ConfigurationSet
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration_set")?.Value;
        set => this.WithProperty("configuration_set", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The from_address attribute.
    /// </summary>
    public string? FromAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("from_address")?.Value;
        set => this.WithProperty("from_address", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The identity attribute.
    /// </summary>
    public string? Identity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity")?.Value;
        set => this.WithProperty("identity", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The orchestration_sending_role_arn attribute.
    /// </summary>
    public string? OrchestrationSendingRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("orchestration_sending_role_arn")?.Value;
        set => this.WithProperty("orchestration_sending_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The messages_per_second attribute.
    /// </summary>
    public TerraformExpression MessagesPerSecond => this["messages_per_second"];

}
