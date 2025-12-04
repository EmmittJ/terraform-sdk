using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for statement in AwsIamPolicyDocumentDataSource.
/// Nesting mode: list
/// </summary>
public class AwsIamPolicyDocumentDataSourceStatementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "statement";

    /// <summary>
    /// The actions attribute.
    /// </summary>
    public TerraformSet<string>? Actions
    {
        get => GetArgument<TerraformSet<string>>("actions");
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// The effect attribute.
    /// </summary>
    public TerraformValue<string>? Effect
    {
        get => GetArgument<TerraformValue<string>>("effect");
        set => SetArgument("effect", value);
    }

    /// <summary>
    /// The not_actions attribute.
    /// </summary>
    public TerraformSet<string>? NotActions
    {
        get => GetArgument<TerraformSet<string>>("not_actions");
        set => SetArgument("not_actions", value);
    }

    /// <summary>
    /// The not_resources attribute.
    /// </summary>
    public TerraformSet<string>? NotResources
    {
        get => GetArgument<TerraformSet<string>>("not_resources");
        set => SetArgument("not_resources", value);
    }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformSet<string>? Resources
    {
        get => GetArgument<TerraformSet<string>>("resources");
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// The sid attribute.
    /// </summary>
    public TerraformValue<string>? Sid
    {
        get => GetArgument<TerraformValue<string>>("sid");
        set => SetArgument("sid", value);
    }

    /// <summary>
    /// Condition block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIamPolicyDocumentDataSourceStatementBlockConditionBlock>? Condition
    {
        get => GetArgument<TerraformSet<AwsIamPolicyDocumentDataSourceStatementBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// NotPrincipals block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIamPolicyDocumentDataSourceStatementBlockNotPrincipalsBlock>? NotPrincipals
    {
        get => GetArgument<TerraformSet<AwsIamPolicyDocumentDataSourceStatementBlockNotPrincipalsBlock>>("not_principals");
        set => SetArgument("not_principals", value);
    }

    /// <summary>
    /// Principals block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIamPolicyDocumentDataSourceStatementBlockPrincipalsBlock>? Principals
    {
        get => GetArgument<TerraformSet<AwsIamPolicyDocumentDataSourceStatementBlockPrincipalsBlock>>("principals");
        set => SetArgument("principals", value);
    }

}

/// <summary>
/// Block type for condition in AwsIamPolicyDocumentDataSourceStatementBlock.
/// Nesting mode: set
/// </summary>
public class AwsIamPolicyDocumentDataSourceStatementBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// The test attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Test is required")]
    public required TerraformValue<string> Test
    {
        get => GetArgument<TerraformValue<string>>("test");
        set => SetArgument("test", value);
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

    /// <summary>
    /// The variable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Variable is required")]
    public required TerraformValue<string> Variable
    {
        get => GetArgument<TerraformValue<string>>("variable");
        set => SetArgument("variable", value);
    }

}

/// <summary>
/// Block type for not_principals in AwsIamPolicyDocumentDataSourceStatementBlock.
/// Nesting mode: set
/// </summary>
public class AwsIamPolicyDocumentDataSourceStatementBlockNotPrincipalsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "not_principals";

    /// <summary>
    /// The identifiers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifiers is required")]
    public required TerraformSet<string> Identifiers
    {
        get => GetArgument<TerraformSet<string>>("identifiers");
        set => SetArgument("identifiers", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for principals in AwsIamPolicyDocumentDataSourceStatementBlock.
/// Nesting mode: set
/// </summary>
public class AwsIamPolicyDocumentDataSourceStatementBlockPrincipalsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "principals";

    /// <summary>
    /// The identifiers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifiers is required")]
    public required TerraformSet<string> Identifiers
    {
        get => GetArgument<TerraformSet<string>>("identifiers");
        set => SetArgument("identifiers", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a aws_iam_policy_document Terraform data source.
/// Retrieves information about a aws_iam_policy_document.
/// </summary>
public partial class AwsIamPolicyDocumentDataSource(string name) : TerraformDataSource("aws_iam_policy_document", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The override_json attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? OverrideJson
    {
        get => GetArgument<TerraformValue<string>>("override_json");
        set => SetArgument("override_json", value);
    }

    /// <summary>
    /// The override_policy_documents attribute.
    /// </summary>
    public TerraformList<string>? OverridePolicyDocuments
    {
        get => GetArgument<TerraformList<string>>("override_policy_documents");
        set => SetArgument("override_policy_documents", value);
    }

    /// <summary>
    /// The policy_id attribute.
    /// </summary>
    public TerraformValue<string>? PolicyId
    {
        get => GetArgument<TerraformValue<string>>("policy_id");
        set => SetArgument("policy_id", value);
    }

    /// <summary>
    /// The source_json attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? SourceJson
    {
        get => GetArgument<TerraformValue<string>>("source_json");
        set => SetArgument("source_json", value);
    }

    /// <summary>
    /// The source_policy_documents attribute.
    /// </summary>
    public TerraformList<string>? SourcePolicyDocuments
    {
        get => GetArgument<TerraformList<string>>("source_policy_documents");
        set => SetArgument("source_policy_documents", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformValue<string> Json
        => AsReference("json");

    /// <summary>
    /// The minified_json attribute.
    /// </summary>
    public TerraformValue<string> MinifiedJson
        => AsReference("minified_json");

    /// <summary>
    /// Statement block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsIamPolicyDocumentDataSourceStatementBlock>? Statement
    {
        get => GetArgument<TerraformList<AwsIamPolicyDocumentDataSourceStatementBlock>>("statement");
        set => SetArgument("statement", value);
    }

}
