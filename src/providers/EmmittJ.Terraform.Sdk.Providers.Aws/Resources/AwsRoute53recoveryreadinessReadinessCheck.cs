using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsRoute53recoveryreadinessReadinessCheck.
/// Nesting mode: single
/// </summary>
public class AwsRoute53recoveryreadinessReadinessCheckTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_route53recoveryreadiness_readiness_check Terraform resource.
/// Manages a aws_route53recoveryreadiness_readiness_check resource.
/// </summary>
public partial class AwsRoute53recoveryreadinessReadinessCheck(string name) : TerraformResource("aws_route53recoveryreadiness_readiness_check", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The readiness_check_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadinessCheckName is required")]
    public required TerraformValue<string> ReadinessCheckName
    {
        get => GetArgument<TerraformValue<string>>("readiness_check_name");
        set => SetArgument("readiness_check_name", value);
    }

    /// <summary>
    /// The resource_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceSetName is required")]
    public required TerraformValue<string> ResourceSetName
    {
        get => GetArgument<TerraformValue<string>>("resource_set_name");
        set => SetArgument("resource_set_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRoute53recoveryreadinessReadinessCheckTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRoute53recoveryreadinessReadinessCheckTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
