using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_appstream_fleet_stack_association Terraform resource.
/// Manages a aws_appstream_fleet_stack_association resource.
/// </summary>
public partial class AwsAppstreamFleetStackAssociation(string name) : TerraformResource("aws_appstream_fleet_stack_association", name)
{
    /// <summary>
    /// The fleet_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FleetName is required")]
    public required TerraformValue<string> FleetName
    {
        get => GetRequiredArgument<TerraformValue<string>>("fleet_name");
        set => SetArgument("fleet_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The stack_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackName is required")]
    public required TerraformValue<string> StackName
    {
        get => GetRequiredArgument<TerraformValue<string>>("stack_name");
        set => SetArgument("stack_name", value);
    }

}
