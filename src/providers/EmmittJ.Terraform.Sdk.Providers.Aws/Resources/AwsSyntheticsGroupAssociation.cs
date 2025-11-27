using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_synthetics_group_association Terraform resource.
/// Manages a aws_synthetics_group_association resource.
/// </summary>
public partial class AwsSyntheticsGroupAssociation(string name) : TerraformResource("aws_synthetics_group_association", name)
{
    /// <summary>
    /// The canary_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CanaryArn is required")]
    public required TerraformValue<string> CanaryArn
    {
        get => new TerraformReference<string>(this, "canary_arn");
        set => SetArgument("canary_arn", value);
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    public required TerraformValue<string> GroupName
    {
        get => new TerraformReference<string>(this, "group_name");
        set => SetArgument("group_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The group_arn attribute.
    /// </summary>
    public TerraformValue<string> GroupArn
    {
        get => new TerraformReference<string>(this, "group_arn");
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public TerraformValue<string> GroupId
    {
        get => new TerraformReference<string>(this, "group_id");
    }

}
