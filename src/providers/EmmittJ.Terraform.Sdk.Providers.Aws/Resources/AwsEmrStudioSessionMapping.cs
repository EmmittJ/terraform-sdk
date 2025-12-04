using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_emr_studio_session_mapping Terraform resource.
/// Manages a aws_emr_studio_session_mapping resource.
/// </summary>
public partial class AwsEmrStudioSessionMapping(string name) : TerraformResource("aws_emr_studio_session_mapping", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    public TerraformValue<string> IdentityId
    {
        get => GetArgument<TerraformValue<string>>("identity_id") ?? AsReference("identity_id");
        set => SetArgument("identity_id", value);
    }

    /// <summary>
    /// The identity_name attribute.
    /// </summary>
    public TerraformValue<string> IdentityName
    {
        get => GetArgument<TerraformValue<string>>("identity_name") ?? AsReference("identity_name");
        set => SetArgument("identity_name", value);
    }

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityType is required")]
    public required TerraformValue<string> IdentityType
    {
        get => GetRequiredArgument<TerraformValue<string>>("identity_type");
        set => SetArgument("identity_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The session_policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SessionPolicyArn is required")]
    public required TerraformValue<string> SessionPolicyArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("session_policy_arn");
        set => SetArgument("session_policy_arn", value);
    }

    /// <summary>
    /// The studio_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StudioId is required")]
    public required TerraformValue<string> StudioId
    {
        get => GetRequiredArgument<TerraformValue<string>>("studio_id");
        set => SetArgument("studio_id", value);
    }

}
