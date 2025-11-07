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
    public TerraformLiteralProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
    }

    /// <summary>
    /// The configuration_set attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConfigurationSet
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration_set");
        set => this.WithProperty("configuration_set", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The from_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FromAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("from_address");
        set => this.WithProperty("from_address", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Identity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// The orchestration_sending_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OrchestrationSendingRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("orchestration_sending_role_arn");
        set => this.WithProperty("orchestration_sending_role_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The messages_per_second attribute.
    /// </summary>
    public TerraformExpression MessagesPerSecond => this["messages_per_second"];

}
