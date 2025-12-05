using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_applicationinsights_application Terraform resource.
/// Manages a aws_applicationinsights_application resource.
/// </summary>
public partial class AwsApplicationinsightsApplication(string name) : TerraformResource("aws_applicationinsights_application", name)
{
    /// <summary>
    /// The auto_config_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutoConfigEnabled
    {
        get => GetArgument<TerraformValue<bool>>("auto_config_enabled");
        set => SetArgument("auto_config_enabled", value);
    }

    /// <summary>
    /// The auto_create attribute.
    /// </summary>
    public TerraformValue<bool>? AutoCreate
    {
        get => GetArgument<TerraformValue<bool>>("auto_create");
        set => SetArgument("auto_create", value);
    }

    /// <summary>
    /// The cwe_monitor_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CweMonitorEnabled
    {
        get => GetArgument<TerraformValue<bool>>("cwe_monitor_enabled");
        set => SetArgument("cwe_monitor_enabled", value);
    }

    /// <summary>
    /// The grouping_type attribute.
    /// </summary>
    public TerraformValue<string>? GroupingType
    {
        get => GetArgument<TerraformValue<string>>("grouping_type");
        set => SetArgument("grouping_type", value);
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
    /// The ops_center_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? OpsCenterEnabled
    {
        get => GetArgument<TerraformValue<bool>>("ops_center_enabled");
        set => SetArgument("ops_center_enabled", value);
    }

    /// <summary>
    /// The ops_item_sns_topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? OpsItemSnsTopicArn
    {
        get => GetArgument<TerraformValue<string>>("ops_item_sns_topic_arn");
        set => SetArgument("ops_item_sns_topic_arn", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
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

}
