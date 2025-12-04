using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for s3_job_definition in AwsMacie2ClassificationJob.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_job_definition";

    /// <summary>
    /// BucketCriteria block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BucketCriteria block(s) allowed")]
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlock>? BucketCriteria
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlock>>("bucket_criteria");
        set => SetArgument("bucket_criteria", value);
    }

    /// <summary>
    /// BucketDefinitions block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketDefinitionsBlock>? BucketDefinitions
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketDefinitionsBlock>>("bucket_definitions");
        set => SetArgument("bucket_definitions", value);
    }

    /// <summary>
    /// Scoping block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scoping block(s) allowed")]
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlock>? Scoping
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlock>>("scoping");
        set => SetArgument("scoping", value);
    }

}

/// <summary>
/// Block type for bucket_criteria in AwsMacie2ClassificationJobS3JobDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bucket_criteria";

    /// <summary>
    /// Excludes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Excludes block(s) allowed")]
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockExcludesBlock>? Excludes
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockExcludesBlock>>("excludes");
        set => SetArgument("excludes", value);
    }

    /// <summary>
    /// Includes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Includes block(s) allowed")]
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockIncludesBlock>? Includes
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockIncludesBlock>>("includes");
        set => SetArgument("includes", value);
    }

}

/// <summary>
/// Block type for excludes in AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockExcludesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "excludes";

    /// <summary>
    /// And block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockExcludesBlockAndBlock>? And
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockExcludesBlockAndBlock>>("and");
        set => SetArgument("and", value);
    }

}

/// <summary>
/// Block type for and in AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockExcludesBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockExcludesBlockAndBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "and";

    /// <summary>
    /// SimpleCriterion block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SimpleCriterion block(s) allowed")]
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockExcludesBlockAndBlockSimpleCriterionBlock>? SimpleCriterion
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockExcludesBlockAndBlockSimpleCriterionBlock>>("simple_criterion");
        set => SetArgument("simple_criterion", value);
    }

    /// <summary>
    /// TagCriterion block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TagCriterion block(s) allowed")]
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockExcludesBlockAndBlockTagCriterionBlock>? TagCriterion
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockExcludesBlockAndBlockTagCriterionBlock>>("tag_criterion");
        set => SetArgument("tag_criterion", value);
    }

}

/// <summary>
/// Block type for simple_criterion in AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockExcludesBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockExcludesBlockAndBlockSimpleCriterionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "simple_criterion";

    /// <summary>
    /// The comparator attribute.
    /// </summary>
    public TerraformValue<string> Comparator
    {
        get => GetArgument<TerraformValue<string>>("comparator") ?? AsReference("comparator");
        set => SetArgument("comparator", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key") ?? AsReference("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformList<string> ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values") ?? AsReference("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for tag_criterion in AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockExcludesBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockExcludesBlockAndBlockTagCriterionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_criterion";

    /// <summary>
    /// The comparator attribute.
    /// </summary>
    public TerraformValue<string> Comparator
    {
        get => GetArgument<TerraformValue<string>>("comparator") ?? AsReference("comparator");
        set => SetArgument("comparator", value);
    }

    /// <summary>
    /// TagValues block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockExcludesBlockAndBlockTagCriterionBlockTagValuesBlock>? TagValues
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockExcludesBlockAndBlockTagCriterionBlockTagValuesBlock>>("tag_values");
        set => SetArgument("tag_values", value);
    }

}

/// <summary>
/// Block type for tag_values in AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockExcludesBlockAndBlockTagCriterionBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockExcludesBlockAndBlockTagCriterionBlockTagValuesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_values";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key") ?? AsReference("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value") ?? AsReference("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for includes in AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockIncludesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "includes";

    /// <summary>
    /// And block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockIncludesBlockAndBlock>? And
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockIncludesBlockAndBlock>>("and");
        set => SetArgument("and", value);
    }

}

/// <summary>
/// Block type for and in AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockIncludesBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockIncludesBlockAndBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "and";

    /// <summary>
    /// SimpleCriterion block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SimpleCriterion block(s) allowed")]
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockIncludesBlockAndBlockSimpleCriterionBlock>? SimpleCriterion
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockIncludesBlockAndBlockSimpleCriterionBlock>>("simple_criterion");
        set => SetArgument("simple_criterion", value);
    }

    /// <summary>
    /// TagCriterion block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TagCriterion block(s) allowed")]
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockIncludesBlockAndBlockTagCriterionBlock>? TagCriterion
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockIncludesBlockAndBlockTagCriterionBlock>>("tag_criterion");
        set => SetArgument("tag_criterion", value);
    }

}

/// <summary>
/// Block type for simple_criterion in AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockIncludesBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockIncludesBlockAndBlockSimpleCriterionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "simple_criterion";

    /// <summary>
    /// The comparator attribute.
    /// </summary>
    public TerraformValue<string> Comparator
    {
        get => GetArgument<TerraformValue<string>>("comparator") ?? AsReference("comparator");
        set => SetArgument("comparator", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key") ?? AsReference("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformList<string> ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values") ?? AsReference("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for tag_criterion in AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockIncludesBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockIncludesBlockAndBlockTagCriterionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_criterion";

    /// <summary>
    /// The comparator attribute.
    /// </summary>
    public TerraformValue<string> Comparator
    {
        get => GetArgument<TerraformValue<string>>("comparator") ?? AsReference("comparator");
        set => SetArgument("comparator", value);
    }

    /// <summary>
    /// TagValues block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockIncludesBlockAndBlockTagCriterionBlockTagValuesBlock>? TagValues
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockIncludesBlockAndBlockTagCriterionBlockTagValuesBlock>>("tag_values");
        set => SetArgument("tag_values", value);
    }

}

/// <summary>
/// Block type for tag_values in AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockIncludesBlockAndBlockTagCriterionBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockBucketCriteriaBlockIncludesBlockAndBlockTagCriterionBlockTagValuesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_values";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key") ?? AsReference("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value") ?? AsReference("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for bucket_definitions in AwsMacie2ClassificationJobS3JobDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockBucketDefinitionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bucket_definitions";

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformValue<string> AccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The buckets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Buckets is required")]
    public TerraformList<string>? Buckets
    {
        get => GetArgument<TerraformList<string>>("buckets");
        set => SetArgument("buckets", value);
    }

}

/// <summary>
/// Block type for scoping in AwsMacie2ClassificationJobS3JobDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scoping";

    /// <summary>
    /// Excludes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Excludes block(s) allowed")]
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockExcludesBlock>? Excludes
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockExcludesBlock>>("excludes");
        set => SetArgument("excludes", value);
    }

    /// <summary>
    /// Includes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Includes block(s) allowed")]
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockIncludesBlock>? Includes
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockIncludesBlock>>("includes");
        set => SetArgument("includes", value);
    }

}

/// <summary>
/// Block type for excludes in AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockExcludesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "excludes";

    /// <summary>
    /// And block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockExcludesBlockAndBlock>? And
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockExcludesBlockAndBlock>>("and");
        set => SetArgument("and", value);
    }

}

/// <summary>
/// Block type for and in AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockExcludesBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockExcludesBlockAndBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "and";

    /// <summary>
    /// SimpleScopeTerm block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SimpleScopeTerm block(s) allowed")]
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockExcludesBlockAndBlockSimpleScopeTermBlock>? SimpleScopeTerm
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockExcludesBlockAndBlockSimpleScopeTermBlock>>("simple_scope_term");
        set => SetArgument("simple_scope_term", value);
    }

    /// <summary>
    /// TagScopeTerm block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TagScopeTerm block(s) allowed")]
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockExcludesBlockAndBlockTagScopeTermBlock>? TagScopeTerm
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockExcludesBlockAndBlockTagScopeTermBlock>>("tag_scope_term");
        set => SetArgument("tag_scope_term", value);
    }

}

/// <summary>
/// Block type for simple_scope_term in AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockExcludesBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockExcludesBlockAndBlockSimpleScopeTermBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "simple_scope_term";

    /// <summary>
    /// The comparator attribute.
    /// </summary>
    public TerraformValue<string> Comparator
    {
        get => GetArgument<TerraformValue<string>>("comparator") ?? AsReference("comparator");
        set => SetArgument("comparator", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key") ?? AsReference("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformList<string> ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values") ?? AsReference("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for tag_scope_term in AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockExcludesBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockExcludesBlockAndBlockTagScopeTermBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_scope_term";

    /// <summary>
    /// The comparator attribute.
    /// </summary>
    public TerraformValue<string> Comparator
    {
        get => GetArgument<TerraformValue<string>>("comparator") ?? AsReference("comparator");
        set => SetArgument("comparator", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key") ?? AsReference("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformValue<string> Target
    {
        get => GetArgument<TerraformValue<string>>("target") ?? AsReference("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// TagValues block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockExcludesBlockAndBlockTagScopeTermBlockTagValuesBlock>? TagValues
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockExcludesBlockAndBlockTagScopeTermBlockTagValuesBlock>>("tag_values");
        set => SetArgument("tag_values", value);
    }

}

/// <summary>
/// Block type for tag_values in AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockExcludesBlockAndBlockTagScopeTermBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockExcludesBlockAndBlockTagScopeTermBlockTagValuesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_values";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key") ?? AsReference("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value") ?? AsReference("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for includes in AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockIncludesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "includes";

    /// <summary>
    /// And block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockIncludesBlockAndBlock>? And
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockIncludesBlockAndBlock>>("and");
        set => SetArgument("and", value);
    }

}

/// <summary>
/// Block type for and in AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockIncludesBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockIncludesBlockAndBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "and";

    /// <summary>
    /// SimpleScopeTerm block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SimpleScopeTerm block(s) allowed")]
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockIncludesBlockAndBlockSimpleScopeTermBlock>? SimpleScopeTerm
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockIncludesBlockAndBlockSimpleScopeTermBlock>>("simple_scope_term");
        set => SetArgument("simple_scope_term", value);
    }

    /// <summary>
    /// TagScopeTerm block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TagScopeTerm block(s) allowed")]
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockIncludesBlockAndBlockTagScopeTermBlock>? TagScopeTerm
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockIncludesBlockAndBlockTagScopeTermBlock>>("tag_scope_term");
        set => SetArgument("tag_scope_term", value);
    }

}

/// <summary>
/// Block type for simple_scope_term in AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockIncludesBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockIncludesBlockAndBlockSimpleScopeTermBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "simple_scope_term";

    /// <summary>
    /// The comparator attribute.
    /// </summary>
    public TerraformValue<string> Comparator
    {
        get => GetArgument<TerraformValue<string>>("comparator") ?? AsReference("comparator");
        set => SetArgument("comparator", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key") ?? AsReference("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformList<string> ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values") ?? AsReference("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for tag_scope_term in AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockIncludesBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockIncludesBlockAndBlockTagScopeTermBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_scope_term";

    /// <summary>
    /// The comparator attribute.
    /// </summary>
    public TerraformValue<string> Comparator
    {
        get => GetArgument<TerraformValue<string>>("comparator") ?? AsReference("comparator");
        set => SetArgument("comparator", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key") ?? AsReference("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformValue<string> Target
    {
        get => GetArgument<TerraformValue<string>>("target") ?? AsReference("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// TagValues block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockIncludesBlockAndBlockTagScopeTermBlockTagValuesBlock>? TagValues
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockIncludesBlockAndBlockTagScopeTermBlockTagValuesBlock>>("tag_values");
        set => SetArgument("tag_values", value);
    }

}

/// <summary>
/// Block type for tag_values in AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockIncludesBlockAndBlockTagScopeTermBlock.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlockScopingBlockIncludesBlockAndBlockTagScopeTermBlockTagValuesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_values";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key") ?? AsReference("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value") ?? AsReference("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for schedule_frequency in AwsMacie2ClassificationJob.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobScheduleFrequencyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule_frequency";

    /// <summary>
    /// The daily_schedule attribute.
    /// </summary>
    public TerraformValue<bool>? DailySchedule
    {
        get => GetArgument<TerraformValue<bool>>("daily_schedule");
        set => SetArgument("daily_schedule", value);
    }

    /// <summary>
    /// The monthly_schedule attribute.
    /// </summary>
    public TerraformValue<double> MonthlySchedule
    {
        get => GetArgument<TerraformValue<double>>("monthly_schedule") ?? AsReference("monthly_schedule");
        set => SetArgument("monthly_schedule", value);
    }

    /// <summary>
    /// The weekly_schedule attribute.
    /// </summary>
    public TerraformValue<string> WeeklySchedule
    {
        get => GetArgument<TerraformValue<string>>("weekly_schedule") ?? AsReference("weekly_schedule");
        set => SetArgument("weekly_schedule", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsMacie2ClassificationJob.
/// Nesting mode: single
/// </summary>
public class AwsMacie2ClassificationJobTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_macie2_classification_job Terraform resource.
/// Manages a aws_macie2_classification_job resource.
/// </summary>
public partial class AwsMacie2ClassificationJob(string name) : TerraformResource("aws_macie2_classification_job", name)
{
    /// <summary>
    /// The custom_data_identifier_ids attribute.
    /// </summary>
    public TerraformList<string> CustomDataIdentifierIds
    {
        get => GetArgument<TerraformList<string>>("custom_data_identifier_ids") ?? AsReference("custom_data_identifier_ids");
        set => SetArgument("custom_data_identifier_ids", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => GetArgument<TerraformValue<string>>("description") ?? AsReference("description");
        set => SetArgument("description", value);
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
    /// The initial_run attribute.
    /// </summary>
    public TerraformValue<bool>? InitialRun
    {
        get => GetArgument<TerraformValue<bool>>("initial_run");
        set => SetArgument("initial_run", value);
    }

    /// <summary>
    /// The job_status attribute.
    /// </summary>
    public TerraformValue<string> JobStatus
    {
        get => GetArgument<TerraformValue<string>>("job_status") ?? AsReference("job_status");
        set => SetArgument("job_status", value);
    }

    /// <summary>
    /// The job_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobType is required")]
    public required TerraformValue<string> JobType
    {
        get => GetRequiredArgument<TerraformValue<string>>("job_type");
        set => SetArgument("job_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix") ?? AsReference("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    public TerraformValue<double> SamplingPercentage
    {
        get => GetArgument<TerraformValue<double>>("sampling_percentage") ?? AsReference("sampling_percentage");
        set => SetArgument("sampling_percentage", value);
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The job_arn attribute.
    /// </summary>
    public TerraformValue<string> JobArn
        => AsReference("job_arn");

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    public TerraformValue<string> JobId
        => AsReference("job_id");

    /// <summary>
    /// The user_paused_details attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UserPausedDetails
        => AsReference("user_paused_details");

    /// <summary>
    /// S3JobDefinition block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3JobDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3JobDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3JobDefinition block(s) allowed")]
    public required TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlock> S3JobDefinition
    {
        get => GetRequiredArgument<TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlock>>("s3_job_definition");
        set => SetArgument("s3_job_definition", value);
    }

    /// <summary>
    /// ScheduleFrequency block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleFrequency block(s) allowed")]
    public TerraformList<AwsMacie2ClassificationJobScheduleFrequencyBlock>? ScheduleFrequency
    {
        get => GetArgument<TerraformList<AwsMacie2ClassificationJobScheduleFrequencyBlock>>("schedule_frequency");
        set => SetArgument("schedule_frequency", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMacie2ClassificationJobTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMacie2ClassificationJobTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
