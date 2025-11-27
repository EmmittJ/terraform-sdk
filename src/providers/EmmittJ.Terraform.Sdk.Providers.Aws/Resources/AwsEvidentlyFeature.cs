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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "name");
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
        get => new TerraformReference<string>(this, "bool_value");
        set => SetArgument("bool_value", value);
    }

    /// <summary>
    /// The double_value attribute.
    /// </summary>
    public TerraformValue<string>? DoubleValue
    {
        get => new TerraformReference<string>(this, "double_value");
        set => SetArgument("double_value", value);
    }

    /// <summary>
    /// The long_value attribute.
    /// </summary>
    public TerraformValue<string>? LongValue
    {
        get => new TerraformReference<string>(this, "long_value");
        set => SetArgument("long_value", value);
    }

    /// <summary>
    /// The string_value attribute.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => new TerraformReference<string>(this, "string_value");
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
        get => new TerraformReference<string>(this, "default_variation");
        set => SetArgument("default_variation", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The entity_overrides attribute.
    /// </summary>
    public TerraformMap<string>? EntityOverrides
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "entity_overrides").ResolveNodes(ctx));
        set => SetArgument("entity_overrides", value);
    }

    /// <summary>
    /// The evaluation_strategy attribute.
    /// </summary>
    public TerraformValue<string> EvaluationStrategy
    {
        get => new TerraformReference<string>(this, "evaluation_strategy");
        set => SetArgument("evaluation_strategy", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
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
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
    {
        get => new TerraformReference<string>(this, "created_time");
    }

    /// <summary>
    /// The evaluation_rules attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> EvaluationRules
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "evaluation_rules").ResolveNodes(ctx));
    }

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedTime
    {
        get => new TerraformReference<string>(this, "last_updated_time");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The value_type attribute.
    /// </summary>
    public TerraformValue<string> ValueType
    {
        get => new TerraformReference<string>(this, "value_type");
    }

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
