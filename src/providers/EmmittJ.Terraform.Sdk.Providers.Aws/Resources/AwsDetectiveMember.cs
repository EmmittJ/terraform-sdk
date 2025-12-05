using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_detective_member Terraform resource.
/// Manages a aws_detective_member resource.
/// </summary>
public partial class AwsDetectiveMember(string name) : TerraformResource("aws_detective_member", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformValue<string> AccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The disable_email_notification attribute.
    /// </summary>
    public TerraformValue<bool>? DisableEmailNotification
    {
        get => GetArgument<TerraformValue<bool>>("disable_email_notification");
        set => SetArgument("disable_email_notification", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    public required TerraformValue<string> EmailAddress
    {
        get => GetRequiredArgument<TerraformValue<string>>("email_address");
        set => SetArgument("email_address", value);
    }

    /// <summary>
    /// The graph_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GraphArn is required")]
    public required TerraformValue<string> GraphArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("graph_arn");
        set => SetArgument("graph_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The message attribute.
    /// </summary>
    public TerraformValue<string>? Message
    {
        get => GetArgument<TerraformValue<string>>("message");
        set => SetArgument("message", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The administrator_id attribute.
    /// </summary>
    public TerraformValue<string> AdministratorId
        => CreateReference("administrator_id");

    /// <summary>
    /// The disabled_reason attribute.
    /// </summary>
    public TerraformValue<string> DisabledReason
        => CreateReference("disabled_reason");

    /// <summary>
    /// The invited_time attribute.
    /// </summary>
    public TerraformValue<string> InvitedTime
        => CreateReference("invited_time");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The updated_time attribute.
    /// </summary>
    public TerraformValue<string> UpdatedTime
        => CreateReference("updated_time");

    /// <summary>
    /// The volume_usage_in_bytes attribute.
    /// </summary>
    public TerraformValue<string> VolumeUsageInBytes
        => CreateReference("volume_usage_in_bytes");

}
