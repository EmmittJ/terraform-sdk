using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_apprunner_default_auto_scaling_configuration_version Terraform resource.
/// Manages a aws_apprunner_default_auto_scaling_configuration_version resource.
/// </summary>
public partial class AwsApprunnerDefaultAutoScalingConfigurationVersion(string name) : TerraformResource("aws_apprunner_default_auto_scaling_configuration_version", name)
{
    /// <summary>
    /// The auto_scaling_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingConfigurationArn is required")]
    public required TerraformValue<string> AutoScalingConfigurationArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("auto_scaling_configuration_arn");
        set => SetArgument("auto_scaling_configuration_arn", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

}
