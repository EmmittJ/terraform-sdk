using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_glue_resource_policy Terraform resource.
/// Manages a aws_glue_resource_policy resource.
/// </summary>
public partial class AwsGlueResourcePolicy(string name) : TerraformResource("aws_glue_resource_policy", name)
{
    /// <summary>
    /// The enable_hybrid attribute.
    /// </summary>
    public TerraformValue<string>? EnableHybrid
    {
        get => new TerraformReference<string>(this, "enable_hybrid");
        set => SetArgument("enable_hybrid", value);
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

}
