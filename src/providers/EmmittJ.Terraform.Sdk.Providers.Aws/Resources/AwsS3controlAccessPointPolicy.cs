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
        get => new TerraformReference<string>(this, "access_point_arn");
        set => SetArgument("access_point_arn", value);
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
    /// The policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    public required TerraformValue<string> Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
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
    /// The has_public_access_policy attribute.
    /// </summary>
    public TerraformValue<bool> HasPublicAccessPolicy
    {
        get => new TerraformReference<bool>(this, "has_public_access_policy");
    }

}
