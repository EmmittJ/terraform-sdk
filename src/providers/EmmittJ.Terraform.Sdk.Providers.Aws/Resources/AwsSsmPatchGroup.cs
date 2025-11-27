using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ssm_patch_group Terraform resource.
/// Manages a aws_ssm_patch_group resource.
/// </summary>
public partial class AwsSsmPatchGroup(string name) : TerraformResource("aws_ssm_patch_group", name)
{
    /// <summary>
    /// The baseline_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaselineId is required")]
    public required TerraformValue<string> BaselineId
    {
        get => new TerraformReference<string>(this, "baseline_id");
        set => SetArgument("baseline_id", value);
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
    /// The patch_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatchGroup is required")]
    public required TerraformValue<string> PatchGroup
    {
        get => new TerraformReference<string>(this, "patch_group");
        set => SetArgument("patch_group", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

}
