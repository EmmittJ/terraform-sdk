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
        get => new TerraformReference<string>(this, "access_policy");
        set => SetArgument("access_policy", value);
    }

    /// <summary>
    /// The destination_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationName is required")]
    public required TerraformValue<string> DestinationName
    {
        get => new TerraformReference<string>(this, "destination_name");
        set => SetArgument("destination_name", value);
    }

    /// <summary>
    /// The force_update attribute.
    /// </summary>
    public TerraformValue<bool>? ForceUpdate
    {
        get => new TerraformReference<bool>(this, "force_update");
        set => SetArgument("force_update", value);
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

}
