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
        get => new TerraformReference<string>(this, "first_execution_from");
        set => SetArgument("first_execution_from", value);
    }

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => new TerraformReference<string>(this, "object");
        set => SetArgument("object", value);
    }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    public required TerraformValue<string> ScheduleExpression
    {
        get => new TerraformReference<string>(this, "schedule_expression");
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
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The kms_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    public required TerraformValue<string> KmsKey
    {
        get => new TerraformReference<string>(this, "kms_key");
        set => SetArgument("kms_key", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The source_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceUri is required")]
    public required TerraformValue<string> SourceUri
    {
        get => new TerraformReference<string>(this, "source_uri");
        set => SetArgument("source_uri", value);
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
