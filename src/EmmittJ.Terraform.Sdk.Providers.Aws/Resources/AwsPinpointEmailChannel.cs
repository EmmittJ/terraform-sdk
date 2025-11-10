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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
    }

    /// <summary>
    /// The configuration_set attribute.
    /// </summary>
    public TerraformProperty<string>? ConfigurationSet
    {
        get => GetProperty<TerraformProperty<string>>("configuration_set");
        set => this.WithProperty("configuration_set", value);
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
    /// The from_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromAddress is required")]
    public required TerraformProperty<string> FromAddress
    {
        get => GetProperty<TerraformProperty<string>>("from_address");
        set => this.WithProperty("from_address", value);
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
    /// The identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    public required TerraformProperty<string> Identity
    {
        get => GetProperty<TerraformProperty<string>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// The orchestration_sending_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? OrchestrationSendingRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("orchestration_sending_role_arn");
        set => this.WithProperty("orchestration_sending_role_arn", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The messages_per_second attribute.
    /// </summary>
    public TerraformExpression MessagesPerSecond => this["messages_per_second"];

}
