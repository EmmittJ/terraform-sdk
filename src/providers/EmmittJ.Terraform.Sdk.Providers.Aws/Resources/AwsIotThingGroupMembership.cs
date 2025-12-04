using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iot_thing_group_membership Terraform resource.
/// Manages a aws_iot_thing_group_membership resource.
/// </summary>
public partial class AwsIotThingGroupMembership(string name) : TerraformResource("aws_iot_thing_group_membership", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The override_dynamic_group attribute.
    /// </summary>
    public TerraformValue<bool>? OverrideDynamicGroup
    {
        get => GetArgument<TerraformValue<bool>>("override_dynamic_group");
        set => SetArgument("override_dynamic_group", value);
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
    /// The thing_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThingGroupName is required")]
    public required TerraformValue<string> ThingGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("thing_group_name");
        set => SetArgument("thing_group_name", value);
    }

    /// <summary>
    /// The thing_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThingName is required")]
    public required TerraformValue<string> ThingName
    {
        get => GetRequiredArgument<TerraformValue<string>>("thing_name");
        set => SetArgument("thing_name", value);
    }

}
