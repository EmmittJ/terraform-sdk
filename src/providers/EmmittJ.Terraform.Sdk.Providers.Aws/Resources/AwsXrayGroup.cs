using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for insights_configuration in AwsXrayGroup.
/// Nesting mode: list
/// </summary>
public class AwsXrayGroupInsightsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "insights_configuration";

    /// <summary>
    /// The insights_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InsightsEnabled is required")]
    public required TerraformValue<bool> InsightsEnabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("insights_enabled");
        set => SetArgument("insights_enabled", value);
    }

    /// <summary>
    /// The notifications_enabled attribute.
    /// </summary>
    public TerraformValue<bool> NotificationsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("notifications_enabled") ?? CreateReference("notifications_enabled");
        set => SetArgument("notifications_enabled", value);
    }

}


/// <summary>
/// Represents a aws_xray_group Terraform resource.
/// Manages a aws_xray_group resource.
/// </summary>
public partial class AwsXrayGroup(string name) : TerraformResource("aws_xray_group", name)
{
    /// <summary>
    /// The filter_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterExpression is required")]
    public required TerraformValue<string> FilterExpression
    {
        get => GetRequiredArgument<TerraformValue<string>>("filter_expression");
        set => SetArgument("filter_expression", value);
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    public required TerraformValue<string> GroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("group_name");
        set => SetArgument("group_name", value);
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// InsightsConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InsightsConfiguration block(s) allowed")]
    public TerraformList<AwsXrayGroupInsightsConfigurationBlock>? InsightsConfiguration
    {
        get => GetArgument<TerraformList<AwsXrayGroupInsightsConfigurationBlock>>("insights_configuration");
        set => SetArgument("insights_configuration", value);
    }

}
