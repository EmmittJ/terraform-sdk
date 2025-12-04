using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ami_launch_permission Terraform resource.
/// Manages a aws_ami_launch_permission resource.
/// </summary>
public partial class AwsAmiLaunchPermission(string name) : TerraformResource("aws_ami_launch_permission", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string>? AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public TerraformValue<string>? Group
    {
        get => GetArgument<TerraformValue<string>>("group");
        set => SetArgument("group", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageId is required")]
    public required TerraformValue<string> ImageId
    {
        get => GetArgument<TerraformValue<string>>("image_id");
        set => SetArgument("image_id", value);
    }

    /// <summary>
    /// The organization_arn attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationArn
    {
        get => GetArgument<TerraformValue<string>>("organization_arn");
        set => SetArgument("organization_arn", value);
    }

    /// <summary>
    /// The organizational_unit_arn attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationalUnitArn
    {
        get => GetArgument<TerraformValue<string>>("organizational_unit_arn");
        set => SetArgument("organizational_unit_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

}
