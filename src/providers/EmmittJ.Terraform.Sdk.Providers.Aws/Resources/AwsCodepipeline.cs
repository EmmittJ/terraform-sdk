using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for artifact_store in AwsCodepipeline.
/// Nesting mode: set
/// </summary>
public class AwsCodepipelineArtifactStoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "artifact_store";

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// EncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionKey block(s) allowed")]
    public TerraformList<AwsCodepipelineArtifactStoreBlockEncryptionKeyBlock>? EncryptionKey
    {
        get => GetArgument<TerraformList<AwsCodepipelineArtifactStoreBlockEncryptionKeyBlock>>("encryption_key");
        set => SetArgument("encryption_key", value);
    }

}

/// <summary>
/// Block type for encryption_key in AwsCodepipelineArtifactStoreBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineArtifactStoreBlockEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_key";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for stage in AwsCodepipeline.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineStageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stage";

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
    /// Action block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    public required TerraformList<AwsCodepipelineStageBlockActionBlock> Action
    {
        get => GetRequiredArgument<TerraformList<AwsCodepipelineStageBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// BeforeEntry block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BeforeEntry block(s) allowed")]
    public TerraformList<AwsCodepipelineStageBlockBeforeEntryBlock>? BeforeEntry
    {
        get => GetArgument<TerraformList<AwsCodepipelineStageBlockBeforeEntryBlock>>("before_entry");
        set => SetArgument("before_entry", value);
    }

    /// <summary>
    /// OnFailure block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnFailure block(s) allowed")]
    public TerraformList<AwsCodepipelineStageBlockOnFailureBlock>? OnFailure
    {
        get => GetArgument<TerraformList<AwsCodepipelineStageBlockOnFailureBlock>>("on_failure");
        set => SetArgument("on_failure", value);
    }

    /// <summary>
    /// OnSuccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnSuccess block(s) allowed")]
    public TerraformList<AwsCodepipelineStageBlockOnSuccessBlock>? OnSuccess
    {
        get => GetArgument<TerraformList<AwsCodepipelineStageBlockOnSuccessBlock>>("on_success");
        set => SetArgument("on_success", value);
    }

}

/// <summary>
/// Block type for action in AwsCodepipelineStageBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineStageBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformValue<string> Category
    {
        get => new TerraformReference<string>(this, "category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformMap<string>? Configuration
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "configuration").ResolveNodes(ctx));
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// The input_artifacts attribute.
    /// </summary>
    public TerraformList<string>? InputArtifacts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "input_artifacts").ResolveNodes(ctx));
        set => SetArgument("input_artifacts", value);
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
    /// The namespace attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// The output_artifacts attribute.
    /// </summary>
    public TerraformList<string>? OutputArtifacts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "output_artifacts").ResolveNodes(ctx));
        set => SetArgument("output_artifacts", value);
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Owner is required")]
    public required TerraformValue<string> Owner
    {
        get => new TerraformReference<string>(this, "owner");
        set => SetArgument("owner", value);
    }

    /// <summary>
    /// The provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderAttribute is required")]
    public required TerraformValue<string> ProviderAttribute
    {
        get => new TerraformReference<string>(this, "provider");
        set => SetArgument("provider", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The run_order attribute.
    /// </summary>
    public TerraformValue<double> RunOrder
    {
        get => new TerraformReference<double>(this, "run_order");
        set => SetArgument("run_order", value);
    }

    /// <summary>
    /// The timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "timeout_in_minutes");
        set => SetArgument("timeout_in_minutes", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for before_entry in AwsCodepipelineStageBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineStageBlockBeforeEntryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "before_entry";

    /// <summary>
    /// Condition block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Condition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Condition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public required TerraformList<AwsCodepipelineStageBlockBeforeEntryBlockConditionBlock> Condition
    {
        get => GetRequiredArgument<TerraformList<AwsCodepipelineStageBlockBeforeEntryBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

}

/// <summary>
/// Block type for condition in AwsCodepipelineStageBlockBeforeEntryBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineStageBlockBeforeEntryBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// The result attribute.
    /// </summary>
    public TerraformValue<string>? Result
    {
        get => new TerraformReference<string>(this, "result");
        set => SetArgument("result", value);
    }

    /// <summary>
    /// Rule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Rule block(s) allowed")]
    public required TerraformList<AwsCodepipelineStageBlockBeforeEntryBlockConditionBlockRuleBlock> Rule
    {
        get => GetRequiredArgument<TerraformList<AwsCodepipelineStageBlockBeforeEntryBlockConditionBlockRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}

/// <summary>
/// Block type for rule in AwsCodepipelineStageBlockBeforeEntryBlockConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineStageBlockBeforeEntryBlockConditionBlockRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The commands attribute.
    /// </summary>
    public TerraformList<string>? Commands
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "commands").ResolveNodes(ctx));
        set => SetArgument("commands", value);
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformMap<string>? Configuration
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "configuration").ResolveNodes(ctx));
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// The input_artifacts attribute.
    /// </summary>
    public TerraformList<string>? InputArtifacts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "input_artifacts").ResolveNodes(ctx));
        set => SetArgument("input_artifacts", value);
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
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "timeout_in_minutes");
        set => SetArgument("timeout_in_minutes", value);
    }

    /// <summary>
    /// RuleTypeId block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleTypeId is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RuleTypeId block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuleTypeId block(s) allowed")]
    public required TerraformList<AwsCodepipelineStageBlockBeforeEntryBlockConditionBlockRuleBlockRuleTypeIdBlock> RuleTypeId
    {
        get => GetRequiredArgument<TerraformList<AwsCodepipelineStageBlockBeforeEntryBlockConditionBlockRuleBlockRuleTypeIdBlock>>("rule_type_id");
        set => SetArgument("rule_type_id", value);
    }

}

/// <summary>
/// Block type for rule_type_id in AwsCodepipelineStageBlockBeforeEntryBlockConditionBlockRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineStageBlockBeforeEntryBlockConditionBlockRuleBlockRuleTypeIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule_type_id";

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformValue<string> Category
    {
        get => new TerraformReference<string>(this, "category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string>? Owner
    {
        get => new TerraformReference<string>(this, "owner");
        set => SetArgument("owner", value);
    }

    /// <summary>
    /// The provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderAttribute is required")]
    public required TerraformValue<string> ProviderAttribute
    {
        get => new TerraformReference<string>(this, "provider");
        set => SetArgument("provider", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for on_failure in AwsCodepipelineStageBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineStageBlockOnFailureBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_failure";

    /// <summary>
    /// The result attribute.
    /// </summary>
    public TerraformValue<string>? Result
    {
        get => new TerraformReference<string>(this, "result");
        set => SetArgument("result", value);
    }

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public TerraformList<AwsCodepipelineStageBlockOnFailureBlockConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<AwsCodepipelineStageBlockOnFailureBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// RetryConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryConfiguration block(s) allowed")]
    public TerraformList<AwsCodepipelineStageBlockOnFailureBlockRetryConfigurationBlock>? RetryConfiguration
    {
        get => GetArgument<TerraformList<AwsCodepipelineStageBlockOnFailureBlockRetryConfigurationBlock>>("retry_configuration");
        set => SetArgument("retry_configuration", value);
    }

}

/// <summary>
/// Block type for condition in AwsCodepipelineStageBlockOnFailureBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineStageBlockOnFailureBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// The result attribute.
    /// </summary>
    public TerraformValue<string>? Result
    {
        get => new TerraformReference<string>(this, "result");
        set => SetArgument("result", value);
    }

    /// <summary>
    /// Rule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Rule block(s) allowed")]
    public required TerraformList<AwsCodepipelineStageBlockOnFailureBlockConditionBlockRuleBlock> Rule
    {
        get => GetRequiredArgument<TerraformList<AwsCodepipelineStageBlockOnFailureBlockConditionBlockRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}

/// <summary>
/// Block type for rule in AwsCodepipelineStageBlockOnFailureBlockConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineStageBlockOnFailureBlockConditionBlockRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The commands attribute.
    /// </summary>
    public TerraformList<string>? Commands
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "commands").ResolveNodes(ctx));
        set => SetArgument("commands", value);
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformMap<string>? Configuration
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "configuration").ResolveNodes(ctx));
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// The input_artifacts attribute.
    /// </summary>
    public TerraformList<string>? InputArtifacts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "input_artifacts").ResolveNodes(ctx));
        set => SetArgument("input_artifacts", value);
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
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "timeout_in_minutes");
        set => SetArgument("timeout_in_minutes", value);
    }

    /// <summary>
    /// RuleTypeId block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleTypeId is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RuleTypeId block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuleTypeId block(s) allowed")]
    public required TerraformList<AwsCodepipelineStageBlockOnFailureBlockConditionBlockRuleBlockRuleTypeIdBlock> RuleTypeId
    {
        get => GetRequiredArgument<TerraformList<AwsCodepipelineStageBlockOnFailureBlockConditionBlockRuleBlockRuleTypeIdBlock>>("rule_type_id");
        set => SetArgument("rule_type_id", value);
    }

}

/// <summary>
/// Block type for rule_type_id in AwsCodepipelineStageBlockOnFailureBlockConditionBlockRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineStageBlockOnFailureBlockConditionBlockRuleBlockRuleTypeIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule_type_id";

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformValue<string> Category
    {
        get => new TerraformReference<string>(this, "category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string>? Owner
    {
        get => new TerraformReference<string>(this, "owner");
        set => SetArgument("owner", value);
    }

    /// <summary>
    /// The provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderAttribute is required")]
    public required TerraformValue<string> ProviderAttribute
    {
        get => new TerraformReference<string>(this, "provider");
        set => SetArgument("provider", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for retry_configuration in AwsCodepipelineStageBlockOnFailureBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineStageBlockOnFailureBlockRetryConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_configuration";

    /// <summary>
    /// The retry_mode attribute.
    /// </summary>
    public TerraformValue<string>? RetryMode
    {
        get => new TerraformReference<string>(this, "retry_mode");
        set => SetArgument("retry_mode", value);
    }

}

/// <summary>
/// Block type for on_success in AwsCodepipelineStageBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineStageBlockOnSuccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_success";

    /// <summary>
    /// Condition block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Condition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Condition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public required TerraformList<AwsCodepipelineStageBlockOnSuccessBlockConditionBlock> Condition
    {
        get => GetRequiredArgument<TerraformList<AwsCodepipelineStageBlockOnSuccessBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

}

/// <summary>
/// Block type for condition in AwsCodepipelineStageBlockOnSuccessBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineStageBlockOnSuccessBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// The result attribute.
    /// </summary>
    public TerraformValue<string>? Result
    {
        get => new TerraformReference<string>(this, "result");
        set => SetArgument("result", value);
    }

    /// <summary>
    /// Rule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Rule block(s) allowed")]
    public required TerraformList<AwsCodepipelineStageBlockOnSuccessBlockConditionBlockRuleBlock> Rule
    {
        get => GetRequiredArgument<TerraformList<AwsCodepipelineStageBlockOnSuccessBlockConditionBlockRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}

/// <summary>
/// Block type for rule in AwsCodepipelineStageBlockOnSuccessBlockConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineStageBlockOnSuccessBlockConditionBlockRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The commands attribute.
    /// </summary>
    public TerraformList<string>? Commands
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "commands").ResolveNodes(ctx));
        set => SetArgument("commands", value);
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformMap<string>? Configuration
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "configuration").ResolveNodes(ctx));
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// The input_artifacts attribute.
    /// </summary>
    public TerraformList<string>? InputArtifacts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "input_artifacts").ResolveNodes(ctx));
        set => SetArgument("input_artifacts", value);
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
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "timeout_in_minutes");
        set => SetArgument("timeout_in_minutes", value);
    }

    /// <summary>
    /// RuleTypeId block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleTypeId is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RuleTypeId block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuleTypeId block(s) allowed")]
    public required TerraformList<AwsCodepipelineStageBlockOnSuccessBlockConditionBlockRuleBlockRuleTypeIdBlock> RuleTypeId
    {
        get => GetRequiredArgument<TerraformList<AwsCodepipelineStageBlockOnSuccessBlockConditionBlockRuleBlockRuleTypeIdBlock>>("rule_type_id");
        set => SetArgument("rule_type_id", value);
    }

}

/// <summary>
/// Block type for rule_type_id in AwsCodepipelineStageBlockOnSuccessBlockConditionBlockRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineStageBlockOnSuccessBlockConditionBlockRuleBlockRuleTypeIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule_type_id";

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformValue<string> Category
    {
        get => new TerraformReference<string>(this, "category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string>? Owner
    {
        get => new TerraformReference<string>(this, "owner");
        set => SetArgument("owner", value);
    }

    /// <summary>
    /// The provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderAttribute is required")]
    public required TerraformValue<string> ProviderAttribute
    {
        get => new TerraformReference<string>(this, "provider");
        set => SetArgument("provider", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for trigger in AwsCodepipeline.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger";

    /// <summary>
    /// The provider_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderType is required")]
    public required TerraformValue<string> ProviderType
    {
        get => new TerraformReference<string>(this, "provider_type");
        set => SetArgument("provider_type", value);
    }

    /// <summary>
    /// GitConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GitConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GitConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitConfiguration block(s) allowed")]
    public required TerraformList<AwsCodepipelineTriggerBlockGitConfigurationBlock> GitConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsCodepipelineTriggerBlockGitConfigurationBlock>>("git_configuration");
        set => SetArgument("git_configuration", value);
    }

}

/// <summary>
/// Block type for git_configuration in AwsCodepipelineTriggerBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineTriggerBlockGitConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "git_configuration";

    /// <summary>
    /// The source_action_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceActionName is required")]
    public required TerraformValue<string> SourceActionName
    {
        get => new TerraformReference<string>(this, "source_action_name");
        set => SetArgument("source_action_name", value);
    }

    /// <summary>
    /// PullRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 PullRequest block(s) allowed")]
    public TerraformList<AwsCodepipelineTriggerBlockGitConfigurationBlockPullRequestBlock>? PullRequest
    {
        get => GetArgument<TerraformList<AwsCodepipelineTriggerBlockGitConfigurationBlockPullRequestBlock>>("pull_request");
        set => SetArgument("pull_request", value);
    }

    /// <summary>
    /// Push block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 Push block(s) allowed")]
    public TerraformList<AwsCodepipelineTriggerBlockGitConfigurationBlockPushBlock>? Push
    {
        get => GetArgument<TerraformList<AwsCodepipelineTriggerBlockGitConfigurationBlockPushBlock>>("push");
        set => SetArgument("push", value);
    }

}

/// <summary>
/// Block type for pull_request in AwsCodepipelineTriggerBlockGitConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineTriggerBlockGitConfigurationBlockPullRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pull_request";

    /// <summary>
    /// The events attribute.
    /// </summary>
    public TerraformList<string>? Events
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "events").ResolveNodes(ctx));
        set => SetArgument("events", value);
    }

    /// <summary>
    /// Branches block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Branches block(s) allowed")]
    public TerraformList<AwsCodepipelineTriggerBlockGitConfigurationBlockPullRequestBlockBranchesBlock>? Branches
    {
        get => GetArgument<TerraformList<AwsCodepipelineTriggerBlockGitConfigurationBlockPullRequestBlockBranchesBlock>>("branches");
        set => SetArgument("branches", value);
    }

    /// <summary>
    /// FilePaths block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilePaths block(s) allowed")]
    public TerraformList<AwsCodepipelineTriggerBlockGitConfigurationBlockPullRequestBlockFilePathsBlock>? FilePaths
    {
        get => GetArgument<TerraformList<AwsCodepipelineTriggerBlockGitConfigurationBlockPullRequestBlockFilePathsBlock>>("file_paths");
        set => SetArgument("file_paths", value);
    }

}

/// <summary>
/// Block type for branches in AwsCodepipelineTriggerBlockGitConfigurationBlockPullRequestBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineTriggerBlockGitConfigurationBlockPullRequestBlockBranchesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "branches";

    /// <summary>
    /// The excludes attribute.
    /// </summary>
    public TerraformList<string>? Excludes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excludes").ResolveNodes(ctx));
        set => SetArgument("excludes", value);
    }

    /// <summary>
    /// The includes attribute.
    /// </summary>
    public TerraformList<string>? Includes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "includes").ResolveNodes(ctx));
        set => SetArgument("includes", value);
    }

}

/// <summary>
/// Block type for file_paths in AwsCodepipelineTriggerBlockGitConfigurationBlockPullRequestBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineTriggerBlockGitConfigurationBlockPullRequestBlockFilePathsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file_paths";

    /// <summary>
    /// The excludes attribute.
    /// </summary>
    public TerraformList<string>? Excludes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excludes").ResolveNodes(ctx));
        set => SetArgument("excludes", value);
    }

    /// <summary>
    /// The includes attribute.
    /// </summary>
    public TerraformList<string>? Includes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "includes").ResolveNodes(ctx));
        set => SetArgument("includes", value);
    }

}

/// <summary>
/// Block type for push in AwsCodepipelineTriggerBlockGitConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineTriggerBlockGitConfigurationBlockPushBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "push";

    /// <summary>
    /// Branches block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Branches block(s) allowed")]
    public TerraformList<AwsCodepipelineTriggerBlockGitConfigurationBlockPushBlockBranchesBlock>? Branches
    {
        get => GetArgument<TerraformList<AwsCodepipelineTriggerBlockGitConfigurationBlockPushBlockBranchesBlock>>("branches");
        set => SetArgument("branches", value);
    }

    /// <summary>
    /// FilePaths block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilePaths block(s) allowed")]
    public TerraformList<AwsCodepipelineTriggerBlockGitConfigurationBlockPushBlockFilePathsBlock>? FilePaths
    {
        get => GetArgument<TerraformList<AwsCodepipelineTriggerBlockGitConfigurationBlockPushBlockFilePathsBlock>>("file_paths");
        set => SetArgument("file_paths", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCodepipelineTriggerBlockGitConfigurationBlockPushBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCodepipelineTriggerBlockGitConfigurationBlockPushBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for branches in AwsCodepipelineTriggerBlockGitConfigurationBlockPushBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineTriggerBlockGitConfigurationBlockPushBlockBranchesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "branches";

    /// <summary>
    /// The excludes attribute.
    /// </summary>
    public TerraformList<string>? Excludes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excludes").ResolveNodes(ctx));
        set => SetArgument("excludes", value);
    }

    /// <summary>
    /// The includes attribute.
    /// </summary>
    public TerraformList<string>? Includes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "includes").ResolveNodes(ctx));
        set => SetArgument("includes", value);
    }

}

/// <summary>
/// Block type for file_paths in AwsCodepipelineTriggerBlockGitConfigurationBlockPushBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineTriggerBlockGitConfigurationBlockPushBlockFilePathsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file_paths";

    /// <summary>
    /// The excludes attribute.
    /// </summary>
    public TerraformList<string>? Excludes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excludes").ResolveNodes(ctx));
        set => SetArgument("excludes", value);
    }

    /// <summary>
    /// The includes attribute.
    /// </summary>
    public TerraformList<string>? Includes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "includes").ResolveNodes(ctx));
        set => SetArgument("includes", value);
    }

}

/// <summary>
/// Block type for tags in AwsCodepipelineTriggerBlockGitConfigurationBlockPushBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineTriggerBlockGitConfigurationBlockPushBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The excludes attribute.
    /// </summary>
    public TerraformList<string>? Excludes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excludes").ResolveNodes(ctx));
        set => SetArgument("excludes", value);
    }

    /// <summary>
    /// The includes attribute.
    /// </summary>
    public TerraformList<string>? Includes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "includes").ResolveNodes(ctx));
        set => SetArgument("includes", value);
    }

}


/// <summary>
/// Block type for variable in AwsCodepipeline.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineVariableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "variable";

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformValue<string>? DefaultValue
    {
        get => new TerraformReference<string>(this, "default_value");
        set => SetArgument("default_value", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Represents a aws_codepipeline Terraform resource.
/// Manages a aws_codepipeline resource.
/// </summary>
public partial class AwsCodepipeline(string name) : TerraformResource("aws_codepipeline", name)
{
    /// <summary>
    /// The execution_mode attribute.
    /// </summary>
    public TerraformValue<string>? ExecutionMode
    {
        get => new TerraformReference<string>(this, "execution_mode");
        set => SetArgument("execution_mode", value);
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
    /// The pipeline_type attribute.
    /// </summary>
    public TerraformValue<string>? PipelineType
    {
        get => new TerraformReference<string>(this, "pipeline_type");
        set => SetArgument("pipeline_type", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
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
    /// The trigger_all attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TriggerAll
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "trigger_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// ArtifactStore block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArtifactStore is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ArtifactStore block(s) required")]
    public required TerraformSet<AwsCodepipelineArtifactStoreBlock> ArtifactStore
    {
        get => GetRequiredArgument<TerraformSet<AwsCodepipelineArtifactStoreBlock>>("artifact_store");
        set => SetArgument("artifact_store", value);
    }

    /// <summary>
    /// Stage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 Stage block(s) required")]
    public TerraformList<AwsCodepipelineStageBlock>? Stage
    {
        get => GetArgument<TerraformList<AwsCodepipelineStageBlock>>("stage");
        set => SetArgument("stage", value);
    }

    /// <summary>
    /// Trigger block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Trigger block(s) allowed")]
    public TerraformList<AwsCodepipelineTriggerBlock>? Trigger
    {
        get => GetArgument<TerraformList<AwsCodepipelineTriggerBlock>>("trigger");
        set => SetArgument("trigger", value);
    }

    /// <summary>
    /// Variable block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCodepipelineVariableBlock>? Variable
    {
        get => GetArgument<TerraformList<AwsCodepipelineVariableBlock>>("variable");
        set => SetArgument("variable", value);
    }

}
