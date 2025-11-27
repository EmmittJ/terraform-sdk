using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_pinpoint_email_channel Terraform resource.
/// Manages a aws_pinpoint_email_channel resource.
/// </summary>
public partial class AwsPinpointEmailChannel(string name) : TerraformResource("aws_pinpoint_email_channel", name)
{
    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => new TerraformReference<string>(this, "application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// The configuration_set attribute.
    /// </summary>
    public TerraformValue<string>? ConfigurationSet
    {
        get => new TerraformReference<string>(this, "configuration_set");
        set => SetArgument("configuration_set", value);
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
    /// The from_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromAddress is required")]
    public required TerraformValue<string> FromAddress
    {
        get => new TerraformReference<string>(this, "from_address");
        set => SetArgument("from_address", value);
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
    /// The identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    public required TerraformValue<string> Identity
    {
        get => new TerraformReference<string>(this, "identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// The orchestration_sending_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? OrchestrationSendingRoleArn
    {
        get => new TerraformReference<string>(this, "orchestration_sending_role_arn");
        set => SetArgument("orchestration_sending_role_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The messages_per_second attribute.
    /// </summary>
    public TerraformValue<double> MessagesPerSecond
    {
        get => new TerraformReference<double>(this, "messages_per_second");
    }

}
