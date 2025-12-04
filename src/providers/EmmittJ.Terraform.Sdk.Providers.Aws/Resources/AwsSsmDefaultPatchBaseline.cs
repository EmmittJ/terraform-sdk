using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ssm_default_patch_baseline Terraform resource.
/// Manages a aws_ssm_default_patch_baseline resource.
/// </summary>
public partial class AwsSsmDefaultPatchBaseline(string name) : TerraformResource("aws_ssm_default_patch_baseline", name)
{
    /// <summary>
    /// The baseline_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaselineId is required")]
    public required TerraformValue<string> BaselineId
    {
        get => GetRequiredArgument<TerraformValue<string>>("baseline_id");
        set => SetArgument("baseline_id", value);
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
    /// The operating_system attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatingSystem is required")]
    public required TerraformValue<string> OperatingSystem
    {
        get => GetRequiredArgument<TerraformValue<string>>("operating_system");
        set => SetArgument("operating_system", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

}
