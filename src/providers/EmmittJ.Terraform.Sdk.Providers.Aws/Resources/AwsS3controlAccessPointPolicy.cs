using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_s3control_access_point_policy Terraform resource.
/// Manages a aws_s3control_access_point_policy resource.
/// </summary>
public partial class AwsS3controlAccessPointPolicy(string name) : TerraformResource("aws_s3control_access_point_policy", name)
{
    /// <summary>
    /// The access_point_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPointArn is required")]
    public required TerraformValue<string> AccessPointArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("access_point_arn");
        set => SetArgument("access_point_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    public required TerraformValue<string> Policy
    {
        get => GetRequiredArgument<TerraformValue<string>>("policy");
        set => SetArgument("policy", value);
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
    /// The has_public_access_policy attribute.
    /// </summary>
    public TerraformValue<bool> HasPublicAccessPolicy
        => AsReference("has_public_access_policy");

}
