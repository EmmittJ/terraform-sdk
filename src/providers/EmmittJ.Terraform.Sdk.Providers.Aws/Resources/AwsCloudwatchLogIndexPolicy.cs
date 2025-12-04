using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudwatch_log_index_policy Terraform resource.
/// Manages a aws_cloudwatch_log_index_policy resource.
/// </summary>
public partial class AwsCloudwatchLogIndexPolicy(string name) : TerraformResource("aws_cloudwatch_log_index_policy", name)
{
    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    public required TerraformValue<string> LogGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// Field index filter policy, in JSON
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDocument is required")]
    public required TerraformValue<string> PolicyDocument
    {
        get => GetRequiredArgument<TerraformValue<string>>("policy_document");
        set => SetArgument("policy_document", value);
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
