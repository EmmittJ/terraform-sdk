using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for audit_config in GoogleIamPolicyDataSource.
/// Nesting mode: set
/// </summary>
public class GoogleIamPolicyDataSourceAuditConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audit_config";

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// AuditLogConfigs block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuditLogConfigs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuditLogConfigs block(s) required")]
    public required TerraformSet<GoogleIamPolicyDataSourceAuditConfigBlockAuditLogConfigsBlock> AuditLogConfigs
    {
        get => GetRequiredArgument<TerraformSet<GoogleIamPolicyDataSourceAuditConfigBlockAuditLogConfigsBlock>>("audit_log_configs");
        set => SetArgument("audit_log_configs", value);
    }

}

/// <summary>
/// Block type for audit_log_configs in GoogleIamPolicyDataSourceAuditConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleIamPolicyDataSourceAuditConfigBlockAuditLogConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audit_log_configs";

    /// <summary>
    /// The exempted_members attribute.
    /// </summary>
    public TerraformSet<string>? ExemptedMembers
    {
        get => GetArgument<TerraformSet<string>>("exempted_members");
        set => SetArgument("exempted_members", value);
    }

    /// <summary>
    /// The log_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogType is required")]
    public required TerraformValue<string> LogType
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_type");
        set => SetArgument("log_type", value);
    }

}


/// <summary>
/// Block type for binding in GoogleIamPolicyDataSource.
/// Nesting mode: set
/// </summary>
public class GoogleIamPolicyDataSourceBindingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "binding";

    /// <summary>
    /// The members attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Members is required")]
    public required TerraformSet<string> Members
    {
        get => GetRequiredArgument<TerraformSet<string>>("members");
        set => SetArgument("members", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformValue<string> Role
    {
        get => GetRequiredArgument<TerraformValue<string>>("role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public TerraformList<GoogleIamPolicyDataSourceBindingBlockConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<GoogleIamPolicyDataSourceBindingBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

}

/// <summary>
/// Block type for condition in GoogleIamPolicyDataSourceBindingBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIamPolicyDataSourceBindingBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => GetRequiredArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

}


/// <summary>
/// Represents a google_iam_policy Terraform data source.
/// Retrieves information about a google_iam_policy.
/// </summary>
public partial class GoogleIamPolicyDataSource(string name) : TerraformDataSource("google_iam_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformValue<string> PolicyData
        => AsReference("policy_data");

    /// <summary>
    /// AuditConfig block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleIamPolicyDataSourceAuditConfigBlock>? AuditConfig
    {
        get => GetArgument<TerraformSet<GoogleIamPolicyDataSourceAuditConfigBlock>>("audit_config");
        set => SetArgument("audit_config", value);
    }

    /// <summary>
    /// Binding block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleIamPolicyDataSourceBindingBlock>? Binding
    {
        get => GetArgument<TerraformSet<GoogleIamPolicyDataSourceBindingBlock>>("binding");
        set => SetArgument("binding", value);
    }

}
