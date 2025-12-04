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
        get => GetArgument<TerraformList<string>>("account_ids");
        set => SetArgument("account_ids", value);
    }

    /// <summary>
    /// The resource_arns attribute.
    /// </summary>
    public TerraformList<string>? ResourceArns
    {
        get => GetArgument<TerraformList<string>>("resource_arns");
        set => SetArgument("resource_arns", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public TerraformList<string>? ResourceTypes
    {
        get => GetArgument<TerraformList<string>>("resource_types");
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
        get => GetArgument<TerraformValue<double>>("unused_access_age");
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
        get => GetArgument<TerraformList<string>>("account_ids");
        set => SetArgument("account_ids", value);
    }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    public TerraformList<TerraformMap<string>>? ResourceTags
    {
        get => GetArgument<TerraformList<TerraformMap<string>>>("resource_tags");
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
        get => GetArgument<TerraformValue<string>>("analyzer_name");
        set => SetArgument("analyzer_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

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
