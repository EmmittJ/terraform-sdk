using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_quicksight_folder_membership Terraform resource.
/// Manages a aws_quicksight_folder_membership resource.
/// </summary>
public partial class AwsQuicksightFolderMembership(string name) : TerraformResource("aws_quicksight_folder_membership", name)
{
    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string> AwsAccountId
    {
        get => new TerraformReference<string>(this, "aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// The folder_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FolderId is required")]
    public required TerraformValue<string> FolderId
    {
        get => new TerraformReference<string>(this, "folder_id");
        set => SetArgument("folder_id", value);
    }

    /// <summary>
    /// The member_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberId is required")]
    public required TerraformValue<string> MemberId
    {
        get => new TerraformReference<string>(this, "member_id");
        set => SetArgument("member_id", value);
    }

    /// <summary>
    /// The member_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberType is required")]
    public required TerraformValue<string> MemberType
    {
        get => new TerraformReference<string>(this, "member_type");
        set => SetArgument("member_type", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

}
