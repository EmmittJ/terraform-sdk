using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in AwsAccessanalyzerAnalyzer.
/// Nesting mode: list
/// </summary>
public class AwsAccessanalyzerAnalyzerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration";

    /// <summary>
    /// InternalAccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InternalAccess block(s) allowed")]
    public TerraformList<AwsAccessanalyzerAnalyzerConfigurationBlockInternalAccessBlock>? InternalAccess
    {
        get => GetArgument<TerraformList<AwsAccessanalyzerAnalyzerConfigurationBlockInternalAccessBlock>>("internal_access");
        set => SetArgument("internal_access", value);
    }

    /// <summary>
    /// UnusedAccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UnusedAccess block(s) allowed")]
    public TerraformList<AwsAccessanalyzerAnalyzerConfigurationBlockUnusedAccessBlock>? UnusedAccess
    {
        get => GetArgument<TerraformList<AwsAccessanalyzerAnalyzerConfigurationBlockUnusedAccessBlock>>("unused_access");
        set => SetArgument("unused_access", value);
    }

}

/// <summary>
/// Block type for internal_access in AwsAccessanalyzerAnalyzerConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAccessanalyzerAnalyzerConfigurationBlockInternalAccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "internal_access";

    /// <summary>
    /// AnalysisRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnalysisRule block(s) allowed")]
    public TerraformList<AwsAccessanalyzerAnalyzerConfigurationBlockInternalAccessBlockAnalysisRuleBlock>? AnalysisRule
    {
        get => GetArgument<TerraformList<AwsAccessanalyzerAnalyzerConfigurationBlockInternalAccessBlockAnalysisRuleBlock>>("analysis_rule");
        set => SetArgument("analysis_rule", value);
    }

}

/// <summary>
/// Block type for analysis_rule in AwsAccessanalyzerAnalyzerConfigurationBlockInternalAccessBlock.
/// Nesting mode: list
/// </summary>
public class AwsAccessanalyzerAnalyzerConfigurationBlockInternalAccessBlockAnalysisRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "analysis_rule";

    /// <summary>
    /// Inclusion block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAccessanalyzerAnalyzerConfigurationBlockInternalAccessBlockAnalysisRuleBlockInclusionBlock>? Inclusion
    {
        get => GetArgument<TerraformList<AwsAccessanalyzerAnalyzerConfigurationBlockInternalAccessBlockAnalysisRuleBlockInclusionBlock>>("inclusion");
        set => SetArgument("inclusion", value);
    }

}

/// <summary>
/// Block type for inclusion in AwsAccessanalyzerAnalyzerConfigurationBlockInternalAccessBlockAnalysisRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsAccessanalyzerAnalyzerConfigurationBlockInternalAccessBlockAnalysisRuleBlockInclusionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inclusion";

    /// <summary>
    /// The account_ids attribute.
    /// </summary>
    public TerraformList<string>? AccountIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "account_ids").ResolveNodes(ctx));
        set => SetArgument("account_ids", value);
    }

    /// <summary>
    /// The resource_arns attribute.
    /// </summary>
    public TerraformList<string>? ResourceArns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_arns").ResolveNodes(ctx));
        set => SetArgument("resource_arns", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public TerraformList<string>? ResourceTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_types").ResolveNodes(ctx));
        set => SetArgument("resource_types", value);
    }

}

/// <summary>
/// Block type for unused_access in AwsAccessanalyzerAnalyzerConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAccessanalyzerAnalyzerConfigurationBlockUnusedAccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unused_access";

    /// <summary>
    /// The unused_access_age attribute.
    /// </summary>
    public TerraformValue<double>? UnusedAccessAge
    {
        get => new TerraformReference<double>(this, "unused_access_age");
        set => SetArgument("unused_access_age", value);
    }

    /// <summary>
    /// AnalysisRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnalysisRule block(s) allowed")]
    public TerraformList<AwsAccessanalyzerAnalyzerConfigurationBlockUnusedAccessBlockAnalysisRuleBlock>? AnalysisRule
    {
        get => GetArgument<TerraformList<AwsAccessanalyzerAnalyzerConfigurationBlockUnusedAccessBlockAnalysisRuleBlock>>("analysis_rule");
        set => SetArgument("analysis_rule", value);
    }

}

/// <summary>
/// Block type for analysis_rule in AwsAccessanalyzerAnalyzerConfigurationBlockUnusedAccessBlock.
/// Nesting mode: list
/// </summary>
public class AwsAccessanalyzerAnalyzerConfigurationBlockUnusedAccessBlockAnalysisRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "analysis_rule";

    /// <summary>
    /// Exclusion block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAccessanalyzerAnalyzerConfigurationBlockUnusedAccessBlockAnalysisRuleBlockExclusionBlock>? Exclusion
    {
        get => GetArgument<TerraformList<AwsAccessanalyzerAnalyzerConfigurationBlockUnusedAccessBlockAnalysisRuleBlockExclusionBlock>>("exclusion");
        set => SetArgument("exclusion", value);
    }

}

/// <summary>
/// Block type for exclusion in AwsAccessanalyzerAnalyzerConfigurationBlockUnusedAccessBlockAnalysisRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsAccessanalyzerAnalyzerConfigurationBlockUnusedAccessBlockAnalysisRuleBlockExclusionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclusion";

    /// <summary>
    /// The account_ids attribute.
    /// </summary>
    public TerraformList<string>? AccountIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "account_ids").ResolveNodes(ctx));
        set => SetArgument("account_ids", value);
    }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    public TerraformList<TerraformMap<string>>? ResourceTags
    {
        get => TerraformList<TerraformMap<string>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<string>>>(this, "resource_tags").ResolveNodes(ctx));
        set => SetArgument("resource_tags", value);
    }

}


/// <summary>
/// Represents a aws_accessanalyzer_analyzer Terraform resource.
/// Manages a aws_accessanalyzer_analyzer resource.
/// </summary>
public partial class AwsAccessanalyzerAnalyzer(string name) : TerraformResource("aws_accessanalyzer_analyzer", name)
{
    /// <summary>
    /// The analyzer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AnalyzerName is required")]
    public required TerraformValue<string> AnalyzerName
    {
        get => new TerraformReference<string>(this, "analyzer_name");
        set => SetArgument("analyzer_name", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// Configuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    public TerraformList<AwsAccessanalyzerAnalyzerConfigurationBlock>? Configuration
    {
        get => GetArgument<TerraformList<AwsAccessanalyzerAnalyzerConfigurationBlock>>("configuration");
        set => SetArgument("configuration", value);
    }

}
