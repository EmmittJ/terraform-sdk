using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsEvidentlyFeature.
/// Nesting mode: single
/// </summary>
public class AwsEvidentlyFeatureTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for variations in AwsEvidentlyFeature.
/// Nesting mode: set
/// </summary>
public class AwsEvidentlyFeatureVariationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "variations";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Value block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Value block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Value block(s) allowed")]
    public required TerraformList<AwsEvidentlyFeatureVariationsBlockValueBlock> Value
    {
        get => GetRequiredArgument<TerraformList<AwsEvidentlyFeatureVariationsBlockValueBlock>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for value in AwsEvidentlyFeatureVariationsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEvidentlyFeatureVariationsBlockValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value";

    /// <summary>
    /// The bool_value attribute.
    /// </summary>
    public TerraformValue<string>? BoolValue
    {
        get => GetArgument<TerraformValue<string>>("bool_value");
        set => SetArgument("bool_value", value);
    }

    /// <summary>
    /// The double_value attribute.
    /// </summary>
    public TerraformValue<string>? DoubleValue
    {
        get => GetArgument<TerraformValue<string>>("double_value");
        set => SetArgument("double_value", value);
    }

    /// <summary>
    /// The long_value attribute.
    /// </summary>
    public TerraformValue<string>? LongValue
    {
        get => GetArgument<TerraformValue<string>>("long_value");
        set => SetArgument("long_value", value);
    }

    /// <summary>
    /// The string_value attribute.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

}


/// <summary>
/// Represents a aws_evidently_feature Terraform resource.
/// Manages a aws_evidently_feature resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AwsEvidentlyFeature(string name) : TerraformResource("aws_evidently_feature", name)
{
    /// <summary>
    /// The default_variation attribute.
    /// </summary>
    public TerraformValue<string> DefaultVariation
    {
        get => GetArgument<TerraformValue<string>>("default_variation") ?? CreateReference("default_variation");
        set => SetArgument("default_variation", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The entity_overrides attribute.
    /// </summary>
    public TerraformMap<string>? EntityOverrides
    {
        get => GetArgument<TerraformMap<string>>("entity_overrides");
        set => SetArgument("entity_overrides", value);
    }

    /// <summary>
    /// The evaluation_strategy attribute.
    /// </summary>
    public TerraformValue<string> EvaluationStrategy
    {
        get => GetArgument<TerraformValue<string>>("evaluation_strategy") ?? CreateReference("evaluation_strategy");
        set => SetArgument("evaluation_strategy", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => GetRequiredArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
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
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
        => CreateReference("created_time");

    /// <summary>
    /// The evaluation_rules attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> EvaluationRules
        => CreateReference("evaluation_rules");

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedTime
        => CreateReference("last_updated_time");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The value_type attribute.
    /// </summary>
    public TerraformValue<string> ValueType
        => CreateReference("value_type");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEvidentlyFeatureTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEvidentlyFeatureTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Variations block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Variations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Variations block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Variations block(s) allowed")]
    public required TerraformSet<AwsEvidentlyFeatureVariationsBlock> Variations
    {
        get => GetRequiredArgument<TerraformSet<AwsEvidentlyFeatureVariationsBlock>>("variations");
        set => SetArgument("variations", value);
    }

}
