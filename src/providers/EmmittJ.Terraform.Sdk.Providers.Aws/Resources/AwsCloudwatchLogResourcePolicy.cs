using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudwatch_log_resource_policy Terraform resource.
/// Manages a aws_cloudwatch_log_resource_policy resource.
/// </summary>
public partial class AwsCloudwatchLogResourcePolicy(string name) : TerraformResource("aws_cloudwatch_log_resource_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDocument is required")]
    public required TerraformValue<string> PolicyDocument
    {
        get => new TerraformReference<string>(this, "policy_document");
        set => SetArgument("policy_document", value);
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyName is required")]
    public required TerraformValue<string> PolicyName
    {
        get => new TerraformReference<string>(this, "policy_name");
        set => SetArgument("policy_name", value);
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
