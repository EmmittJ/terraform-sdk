using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudwatch_log_destination_policy Terraform resource.
/// Manages a aws_cloudwatch_log_destination_policy resource.
/// </summary>
public partial class AwsCloudwatchLogDestinationPolicy(string name) : TerraformResource("aws_cloudwatch_log_destination_policy", name)
{
    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPolicy is required")]
    public required TerraformValue<string> AccessPolicy
    {
        get => GetArgument<TerraformValue<string>>("access_policy");
        set => SetArgument("access_policy", value);
    }

    /// <summary>
    /// The destination_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationName is required")]
    public required TerraformValue<string> DestinationName
    {
        get => GetArgument<TerraformValue<string>>("destination_name");
        set => SetArgument("destination_name", value);
    }

    /// <summary>
    /// The force_update attribute.
    /// </summary>
    public TerraformValue<bool>? ForceUpdate
    {
        get => GetArgument<TerraformValue<bool>>("force_update");
        set => SetArgument("force_update", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

}
