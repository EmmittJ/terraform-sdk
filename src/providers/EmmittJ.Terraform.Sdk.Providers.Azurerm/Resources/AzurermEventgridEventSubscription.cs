using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for advanced_filter in AzurermEventgridEventSubscription.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_filter";

    /// <summary>
    /// BoolEquals block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockBoolEqualsBlock>? BoolEquals
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockBoolEqualsBlock>>("bool_equals");
        set => SetArgument("bool_equals", value);
    }

    /// <summary>
    /// IsNotNull block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockIsNotNullBlock>? IsNotNull
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockIsNotNullBlock>>("is_not_null");
        set => SetArgument("is_not_null", value);
    }

    /// <summary>
    /// IsNullOrUndefined block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockIsNullOrUndefinedBlock>? IsNullOrUndefined
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockIsNullOrUndefinedBlock>>("is_null_or_undefined");
        set => SetArgument("is_null_or_undefined", value);
    }

    /// <summary>
    /// NumberGreaterThan block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberGreaterThanBlock>? NumberGreaterThan
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberGreaterThanBlock>>("number_greater_than");
        set => SetArgument("number_greater_than", value);
    }

    /// <summary>
    /// NumberGreaterThanOrEquals block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberGreaterThanOrEqualsBlock>? NumberGreaterThanOrEquals
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberGreaterThanOrEqualsBlock>>("number_greater_than_or_equals");
        set => SetArgument("number_greater_than_or_equals", value);
    }

    /// <summary>
    /// NumberIn block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberInBlock>? NumberIn
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberInBlock>>("number_in");
        set => SetArgument("number_in", value);
    }

    /// <summary>
    /// NumberInRange block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberInRangeBlock>? NumberInRange
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberInRangeBlock>>("number_in_range");
        set => SetArgument("number_in_range", value);
    }

    /// <summary>
    /// NumberLessThan block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberLessThanBlock>? NumberLessThan
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberLessThanBlock>>("number_less_than");
        set => SetArgument("number_less_than", value);
    }

    /// <summary>
    /// NumberLessThanOrEquals block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberLessThanOrEqualsBlock>? NumberLessThanOrEquals
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberLessThanOrEqualsBlock>>("number_less_than_or_equals");
        set => SetArgument("number_less_than_or_equals", value);
    }

    /// <summary>
    /// NumberNotIn block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberNotInBlock>? NumberNotIn
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberNotInBlock>>("number_not_in");
        set => SetArgument("number_not_in", value);
    }

    /// <summary>
    /// NumberNotInRange block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberNotInRangeBlock>? NumberNotInRange
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberNotInRangeBlock>>("number_not_in_range");
        set => SetArgument("number_not_in_range", value);
    }

    /// <summary>
    /// StringBeginsWith block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockStringBeginsWithBlock>? StringBeginsWith
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockStringBeginsWithBlock>>("string_begins_with");
        set => SetArgument("string_begins_with", value);
    }

    /// <summary>
    /// StringContains block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockStringContainsBlock>? StringContains
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockStringContainsBlock>>("string_contains");
        set => SetArgument("string_contains", value);
    }

    /// <summary>
    /// StringEndsWith block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockStringEndsWithBlock>? StringEndsWith
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockStringEndsWithBlock>>("string_ends_with");
        set => SetArgument("string_ends_with", value);
    }

    /// <summary>
    /// StringIn block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockStringInBlock>? StringIn
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockStringInBlock>>("string_in");
        set => SetArgument("string_in", value);
    }

    /// <summary>
    /// StringNotBeginsWith block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockStringNotBeginsWithBlock>? StringNotBeginsWith
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockStringNotBeginsWithBlock>>("string_not_begins_with");
        set => SetArgument("string_not_begins_with", value);
    }

    /// <summary>
    /// StringNotContains block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockStringNotContainsBlock>? StringNotContains
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockStringNotContainsBlock>>("string_not_contains");
        set => SetArgument("string_not_contains", value);
    }

    /// <summary>
    /// StringNotEndsWith block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockStringNotEndsWithBlock>? StringNotEndsWith
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockStringNotEndsWithBlock>>("string_not_ends_with");
        set => SetArgument("string_not_ends_with", value);
    }

    /// <summary>
    /// StringNotIn block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockStringNotInBlock>? StringNotIn
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlockStringNotInBlock>>("string_not_in");
        set => SetArgument("string_not_in", value);
    }

}

/// <summary>
/// Block type for bool_equals in AzurermEventgridEventSubscriptionAdvancedFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlockBoolEqualsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bool_equals";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<bool> Value
    {
        get => GetRequiredArgument<TerraformValue<bool>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for is_not_null in AzurermEventgridEventSubscriptionAdvancedFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlockIsNotNullBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "is_not_null";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for is_null_or_undefined in AzurermEventgridEventSubscriptionAdvancedFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlockIsNullOrUndefinedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "is_null_or_undefined";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for number_greater_than in AzurermEventgridEventSubscriptionAdvancedFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberGreaterThanBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "number_greater_than";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for number_greater_than_or_equals in AzurermEventgridEventSubscriptionAdvancedFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberGreaterThanOrEqualsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "number_greater_than_or_equals";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for number_in in AzurermEventgridEventSubscriptionAdvancedFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberInBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "number_in";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<double>? ValuesAttribute
    {
        get => GetArgument<TerraformList<double>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for number_in_range in AzurermEventgridEventSubscriptionAdvancedFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberInRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "number_in_range";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<TerraformList<double>>? ValuesAttribute
    {
        get => GetArgument<TerraformList<TerraformList<double>>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for number_less_than in AzurermEventgridEventSubscriptionAdvancedFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberLessThanBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "number_less_than";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for number_less_than_or_equals in AzurermEventgridEventSubscriptionAdvancedFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberLessThanOrEqualsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "number_less_than_or_equals";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for number_not_in in AzurermEventgridEventSubscriptionAdvancedFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberNotInBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "number_not_in";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<double>? ValuesAttribute
    {
        get => GetArgument<TerraformList<double>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for number_not_in_range in AzurermEventgridEventSubscriptionAdvancedFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlockNumberNotInRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "number_not_in_range";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<TerraformList<double>>? ValuesAttribute
    {
        get => GetArgument<TerraformList<TerraformList<double>>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for string_begins_with in AzurermEventgridEventSubscriptionAdvancedFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlockStringBeginsWithBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "string_begins_with";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for string_contains in AzurermEventgridEventSubscriptionAdvancedFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlockStringContainsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "string_contains";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for string_ends_with in AzurermEventgridEventSubscriptionAdvancedFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlockStringEndsWithBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "string_ends_with";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for string_in in AzurermEventgridEventSubscriptionAdvancedFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlockStringInBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "string_in";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for string_not_begins_with in AzurermEventgridEventSubscriptionAdvancedFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlockStringNotBeginsWithBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "string_not_begins_with";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for string_not_contains in AzurermEventgridEventSubscriptionAdvancedFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlockStringNotContainsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "string_not_contains";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for string_not_ends_with in AzurermEventgridEventSubscriptionAdvancedFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlockStringNotEndsWithBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "string_not_ends_with";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for string_not_in in AzurermEventgridEventSubscriptionAdvancedFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlockStringNotInBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "string_not_in";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for azure_function_endpoint in AzurermEventgridEventSubscription.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAzureFunctionEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_function_endpoint";

    /// <summary>
    /// The function_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionId is required")]
    public required TerraformValue<string> FunctionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("function_id");
        set => SetArgument("function_id", value);
    }

    /// <summary>
    /// The max_events_per_batch attribute.
    /// </summary>
    public TerraformValue<double>? MaxEventsPerBatch
    {
        get => GetArgument<TerraformValue<double>>("max_events_per_batch");
        set => SetArgument("max_events_per_batch", value);
    }

    /// <summary>
    /// The preferred_batch_size_in_kilobytes attribute.
    /// </summary>
    public TerraformValue<double>? PreferredBatchSizeInKilobytes
    {
        get => GetArgument<TerraformValue<double>>("preferred_batch_size_in_kilobytes");
        set => SetArgument("preferred_batch_size_in_kilobytes", value);
    }

}


/// <summary>
/// Block type for dead_letter_identity in AzurermEventgridEventSubscription.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionDeadLetterIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dead_letter_identity";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The user_assigned_identity attribute.
    /// </summary>
    public TerraformValue<string>? UserAssignedIdentity
    {
        get => GetArgument<TerraformValue<string>>("user_assigned_identity");
        set => SetArgument("user_assigned_identity", value);
    }

}


/// <summary>
/// Block type for delivery_identity in AzurermEventgridEventSubscription.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionDeliveryIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delivery_identity";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The user_assigned_identity attribute.
    /// </summary>
    public TerraformValue<string>? UserAssignedIdentity
    {
        get => GetArgument<TerraformValue<string>>("user_assigned_identity");
        set => SetArgument("user_assigned_identity", value);
    }

}


/// <summary>
/// Block type for delivery_property in AzurermEventgridEventSubscription.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionDeliveryPropertyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delivery_property";

    /// <summary>
    /// The header_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetRequiredArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    public TerraformValue<bool>? Secret
    {
        get => GetArgument<TerraformValue<bool>>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// The source_field attribute.
    /// </summary>
    public TerraformValue<string>? SourceField
    {
        get => GetArgument<TerraformValue<string>>("source_field");
        set => SetArgument("source_field", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for retry_policy in AzurermEventgridEventSubscription.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionRetryPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_policy";

    /// <summary>
    /// The event_time_to_live attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventTimeToLive is required")]
    public required TerraformValue<double> EventTimeToLive
    {
        get => GetRequiredArgument<TerraformValue<double>>("event_time_to_live");
        set => SetArgument("event_time_to_live", value);
    }

    /// <summary>
    /// The max_delivery_attempts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxDeliveryAttempts is required")]
    public required TerraformValue<double> MaxDeliveryAttempts
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_delivery_attempts");
        set => SetArgument("max_delivery_attempts", value);
    }

}


/// <summary>
/// Block type for storage_blob_dead_letter_destination in AzurermEventgridEventSubscription.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionStorageBlobDeadLetterDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_blob_dead_letter_destination";

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The storage_blob_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageBlobContainerName is required")]
    public required TerraformValue<string> StorageBlobContainerName
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_blob_container_name");
        set => SetArgument("storage_blob_container_name", value);
    }

}


/// <summary>
/// Block type for storage_queue_endpoint in AzurermEventgridEventSubscription.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionStorageQueueEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_queue_endpoint";

    /// <summary>
    /// The queue_message_time_to_live_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? QueueMessageTimeToLiveInSeconds
    {
        get => GetArgument<TerraformValue<double>>("queue_message_time_to_live_in_seconds");
        set => SetArgument("queue_message_time_to_live_in_seconds", value);
    }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueName is required")]
    public required TerraformValue<string> QueueName
    {
        get => GetRequiredArgument<TerraformValue<string>>("queue_name");
        set => SetArgument("queue_name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

}


/// <summary>
/// Block type for subject_filter in AzurermEventgridEventSubscription.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionSubjectFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subject_filter";

    /// <summary>
    /// The case_sensitive attribute.
    /// </summary>
    public TerraformValue<bool>? CaseSensitive
    {
        get => GetArgument<TerraformValue<bool>>("case_sensitive");
        set => SetArgument("case_sensitive", value);
    }

    /// <summary>
    /// The subject_begins_with attribute.
    /// </summary>
    public TerraformValue<string>? SubjectBeginsWith
    {
        get => GetArgument<TerraformValue<string>>("subject_begins_with");
        set => SetArgument("subject_begins_with", value);
    }

    /// <summary>
    /// The subject_ends_with attribute.
    /// </summary>
    public TerraformValue<string>? SubjectEndsWith
    {
        get => GetArgument<TerraformValue<string>>("subject_ends_with");
        set => SetArgument("subject_ends_with", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermEventgridEventSubscription.
/// Nesting mode: single
/// </summary>
public class AzurermEventgridEventSubscriptionTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
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
/// Block type for webhook_endpoint in AzurermEventgridEventSubscription.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionWebhookEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "webhook_endpoint";

    /// <summary>
    /// The active_directory_app_id_or_uri attribute.
    /// </summary>
    public TerraformValue<string>? ActiveDirectoryAppIdOrUri
    {
        get => GetArgument<TerraformValue<string>>("active_directory_app_id_or_uri");
        set => SetArgument("active_directory_app_id_or_uri", value);
    }

    /// <summary>
    /// The active_directory_tenant_id attribute.
    /// </summary>
    public TerraformValue<string>? ActiveDirectoryTenantId
    {
        get => GetArgument<TerraformValue<string>>("active_directory_tenant_id");
        set => SetArgument("active_directory_tenant_id", value);
    }

    /// <summary>
    /// The base_url attribute.
    /// </summary>
    public TerraformValue<string> BaseUrl
        => AsReference("base_url");

    /// <summary>
    /// The max_events_per_batch attribute.
    /// </summary>
    public TerraformValue<double>? MaxEventsPerBatch
    {
        get => GetArgument<TerraformValue<double>>("max_events_per_batch");
        set => SetArgument("max_events_per_batch", value);
    }

    /// <summary>
    /// The preferred_batch_size_in_kilobytes attribute.
    /// </summary>
    public TerraformValue<double>? PreferredBatchSizeInKilobytes
    {
        get => GetArgument<TerraformValue<double>>("preferred_batch_size_in_kilobytes");
        set => SetArgument("preferred_batch_size_in_kilobytes", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetRequiredArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Represents a azurerm_eventgrid_event_subscription Terraform resource.
/// Manages a azurerm_eventgrid_event_subscription resource.
/// </summary>
public partial class AzurermEventgridEventSubscription(string name) : TerraformResource("azurerm_eventgrid_event_subscription", name)
{
    /// <summary>
    /// The advanced_filtering_on_arrays_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AdvancedFilteringOnArraysEnabled
    {
        get => GetArgument<TerraformValue<bool>>("advanced_filtering_on_arrays_enabled");
        set => SetArgument("advanced_filtering_on_arrays_enabled", value);
    }

    /// <summary>
    /// The event_delivery_schema attribute.
    /// </summary>
    public TerraformValue<string>? EventDeliverySchema
    {
        get => GetArgument<TerraformValue<string>>("event_delivery_schema");
        set => SetArgument("event_delivery_schema", value);
    }

    /// <summary>
    /// The eventhub_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string> EventhubEndpointId
    {
        get => GetArgument<TerraformValue<string>>("eventhub_endpoint_id") ?? AsReference("eventhub_endpoint_id");
        set => SetArgument("eventhub_endpoint_id", value);
    }

    /// <summary>
    /// The expiration_time_utc attribute.
    /// </summary>
    public TerraformValue<string>? ExpirationTimeUtc
    {
        get => GetArgument<TerraformValue<string>>("expiration_time_utc");
        set => SetArgument("expiration_time_utc", value);
    }

    /// <summary>
    /// The hybrid_connection_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string> HybridConnectionEndpointId
    {
        get => GetArgument<TerraformValue<string>>("hybrid_connection_endpoint_id") ?? AsReference("hybrid_connection_endpoint_id");
        set => SetArgument("hybrid_connection_endpoint_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The included_event_types attribute.
    /// </summary>
    public TerraformList<string> IncludedEventTypes
    {
        get => GetArgument<TerraformList<string>>("included_event_types") ?? AsReference("included_event_types");
        set => SetArgument("included_event_types", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformList<string>? Labels
    {
        get => GetArgument<TerraformList<string>>("labels");
        set => SetArgument("labels", value);
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
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => GetRequiredArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The service_bus_queue_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string>? ServiceBusQueueEndpointId
    {
        get => GetArgument<TerraformValue<string>>("service_bus_queue_endpoint_id");
        set => SetArgument("service_bus_queue_endpoint_id", value);
    }

    /// <summary>
    /// The service_bus_topic_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string>? ServiceBusTopicEndpointId
    {
        get => GetArgument<TerraformValue<string>>("service_bus_topic_endpoint_id");
        set => SetArgument("service_bus_topic_endpoint_id", value);
    }

    /// <summary>
    /// AdvancedFilter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedFilter block(s) allowed")]
    public TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlock>? AdvancedFilter
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAdvancedFilterBlock>>("advanced_filter");
        set => SetArgument("advanced_filter", value);
    }

    /// <summary>
    /// AzureFunctionEndpoint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureFunctionEndpoint block(s) allowed")]
    public TerraformList<AzurermEventgridEventSubscriptionAzureFunctionEndpointBlock>? AzureFunctionEndpoint
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionAzureFunctionEndpointBlock>>("azure_function_endpoint");
        set => SetArgument("azure_function_endpoint", value);
    }

    /// <summary>
    /// DeadLetterIdentity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterIdentity block(s) allowed")]
    public TerraformList<AzurermEventgridEventSubscriptionDeadLetterIdentityBlock>? DeadLetterIdentity
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionDeadLetterIdentityBlock>>("dead_letter_identity");
        set => SetArgument("dead_letter_identity", value);
    }

    /// <summary>
    /// DeliveryIdentity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryIdentity block(s) allowed")]
    public TerraformList<AzurermEventgridEventSubscriptionDeliveryIdentityBlock>? DeliveryIdentity
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionDeliveryIdentityBlock>>("delivery_identity");
        set => SetArgument("delivery_identity", value);
    }

    /// <summary>
    /// DeliveryProperty block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridEventSubscriptionDeliveryPropertyBlock>? DeliveryProperty
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionDeliveryPropertyBlock>>("delivery_property");
        set => SetArgument("delivery_property", value);
    }

    /// <summary>
    /// RetryPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public TerraformList<AzurermEventgridEventSubscriptionRetryPolicyBlock>? RetryPolicy
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionRetryPolicyBlock>>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

    /// <summary>
    /// StorageBlobDeadLetterDestination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageBlobDeadLetterDestination block(s) allowed")]
    public TerraformList<AzurermEventgridEventSubscriptionStorageBlobDeadLetterDestinationBlock>? StorageBlobDeadLetterDestination
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionStorageBlobDeadLetterDestinationBlock>>("storage_blob_dead_letter_destination");
        set => SetArgument("storage_blob_dead_letter_destination", value);
    }

    /// <summary>
    /// StorageQueueEndpoint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageQueueEndpoint block(s) allowed")]
    public TerraformList<AzurermEventgridEventSubscriptionStorageQueueEndpointBlock>? StorageQueueEndpoint
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionStorageQueueEndpointBlock>>("storage_queue_endpoint");
        set => SetArgument("storage_queue_endpoint", value);
    }

    /// <summary>
    /// SubjectFilter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectFilter block(s) allowed")]
    public TerraformList<AzurermEventgridEventSubscriptionSubjectFilterBlock>? SubjectFilter
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionSubjectFilterBlock>>("subject_filter");
        set => SetArgument("subject_filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEventgridEventSubscriptionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventgridEventSubscriptionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WebhookEndpoint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebhookEndpoint block(s) allowed")]
    public TerraformList<AzurermEventgridEventSubscriptionWebhookEndpointBlock>? WebhookEndpoint
    {
        get => GetArgument<TerraformList<AzurermEventgridEventSubscriptionWebhookEndpointBlock>>("webhook_endpoint");
        set => SetArgument("webhook_endpoint", value);
    }

}
