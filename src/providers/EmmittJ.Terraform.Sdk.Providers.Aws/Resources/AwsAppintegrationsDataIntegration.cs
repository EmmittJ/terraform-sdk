using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for schedule_config in AwsAppintegrationsDataIntegration.
/// Nesting mode: list
/// </summary>
public class AwsAppintegrationsDataIntegrationScheduleConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule_config";

    /// <summary>
    /// The first_execution_from attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirstExecutionFrom is required")]
    public required TerraformValue<string> FirstExecutionFrom
    {
        get => GetArgument<TerraformValue<string>>("first_execution_from");
        set => SetArgument("first_execution_from", value);
    }

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    public required TerraformValue<string> ScheduleExpression
    {
        get => GetArgument<TerraformValue<string>>("schedule_expression");
        set => SetArgument("schedule_expression", value);
    }

}


/// <summary>
/// Represents a aws_appintegrations_data_integration Terraform resource.
/// Manages a aws_appintegrations_data_integration resource.
/// </summary>
public partial class AwsAppintegrationsDataIntegration(string name) : TerraformResource("aws_appintegrations_data_integration", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The kms_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    public required TerraformValue<string> KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceUri is required")]
    public required TerraformValue<string> SourceUri
    {
        get => GetArgument<TerraformValue<string>>("source_uri");
        set => SetArgument("source_uri", value);
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
    /// ScheduleConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScheduleConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleConfig block(s) allowed")]
    public required TerraformList<AwsAppintegrationsDataIntegrationScheduleConfigBlock> ScheduleConfig
    {
        get => GetRequiredArgument<TerraformList<AwsAppintegrationsDataIntegrationScheduleConfigBlock>>("schedule_config");
        set => SetArgument("schedule_config", value);
    }

}
