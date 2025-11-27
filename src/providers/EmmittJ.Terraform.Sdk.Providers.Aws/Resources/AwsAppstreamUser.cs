using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_appstream_user Terraform resource.
/// Manages a aws_appstream_user resource.
/// </summary>
public partial class AwsAppstreamUser(string name) : TerraformResource("aws_appstream_user", name)
{
    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    public required TerraformValue<string> AuthenticationType
    {
        get => new TerraformReference<string>(this, "authentication_type");
        set => SetArgument("authentication_type", value);
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
    /// The first_name attribute.
    /// </summary>
    public TerraformValue<string>? FirstName
    {
        get => new TerraformReference<string>(this, "first_name");
        set => SetArgument("first_name", value);
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
    /// The last_name attribute.
    /// </summary>
    public TerraformValue<string>? LastName
    {
        get => new TerraformReference<string>(this, "last_name");
        set => SetArgument("last_name", value);
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
    /// The send_email_notification attribute.
    /// </summary>
    public TerraformValue<bool>? SendEmailNotification
    {
        get => new TerraformReference<bool>(this, "send_email_notification");
        set => SetArgument("send_email_notification", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformValue<string> UserName
    {
        get => new TerraformReference<string>(this, "user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
    {
        get => new TerraformReference<string>(this, "created_time");
    }

}
