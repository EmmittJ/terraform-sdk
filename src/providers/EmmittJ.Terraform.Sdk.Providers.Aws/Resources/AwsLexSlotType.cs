using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for enumeration_value in AwsLexSlotType.
/// Nesting mode: set
/// </summary>
public class AwsLexSlotTypeEnumerationValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enumeration_value";

    /// <summary>
    /// The synonyms attribute.
    /// </summary>
    public TerraformSet<string>? Synonyms
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "synonyms").ResolveNodes(ctx));
        set => SetArgument("synonyms", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsLexSlotType.
/// Nesting mode: single
/// </summary>
public class AwsLexSlotTypeTimeoutsBlock : TerraformBlock
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
/// Represents a aws_lex_slot_type Terraform resource.
/// Manages a aws_lex_slot_type resource.
/// </summary>
public partial class AwsLexSlotType(string name) : TerraformResource("aws_lex_slot_type", name)
{
    /// <summary>
    /// The create_version attribute.
    /// </summary>
    public TerraformValue<bool>? CreateVersion
    {
        get => new TerraformReference<bool>(this, "create_version");
        set => SetArgument("create_version", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The value_selection_strategy attribute.
    /// </summary>
    public TerraformValue<string>? ValueSelectionStrategy
    {
        get => new TerraformReference<string>(this, "value_selection_strategy");
        set => SetArgument("value_selection_strategy", value);
    }

    /// <summary>
    /// The checksum attribute.
    /// </summary>
    public TerraformValue<string> Checksum
    {
        get => new TerraformReference<string>(this, "checksum");
    }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
    {
        get => new TerraformReference<string>(this, "created_date");
    }

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedDate
    {
        get => new TerraformReference<string>(this, "last_updated_date");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

    /// <summary>
    /// EnumerationValue block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnumerationValue is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EnumerationValue block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10000, ErrorMessage = "Maximum 10000 EnumerationValue block(s) allowed")]
    public required TerraformSet<AwsLexSlotTypeEnumerationValueBlock> EnumerationValue
    {
        get => GetRequiredArgument<TerraformSet<AwsLexSlotTypeEnumerationValueBlock>>("enumeration_value");
        set => SetArgument("enumeration_value", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLexSlotTypeTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLexSlotTypeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
