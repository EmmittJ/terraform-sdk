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
        get => new TerraformReference<bool>(this, "insights_enabled");
        set => SetArgument("insights_enabled", value);
    }

    /// <summary>
    /// The notifications_enabled attribute.
    /// </summary>
    public TerraformValue<bool> NotificationsEnabled
    {
        get => new TerraformReference<bool>(this, "notifications_enabled");
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
        get => new TerraformReference<string>(this, "filter_expression");
        set => SetArgument("filter_expression", value);
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    public required TerraformValue<string> GroupName
    {
        get => new TerraformReference<string>(this, "group_name");
        set => SetArgument("group_name", value);
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

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

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
