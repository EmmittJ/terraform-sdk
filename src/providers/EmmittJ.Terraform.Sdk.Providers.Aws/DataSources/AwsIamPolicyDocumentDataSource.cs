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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "actions").ResolveNodes(ctx));
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// The effect attribute.
    /// </summary>
    public TerraformValue<string>? Effect
    {
        get => new TerraformReference<string>(this, "effect");
        set => SetArgument("effect", value);
    }

    /// <summary>
    /// The not_actions attribute.
    /// </summary>
    public TerraformSet<string>? NotActions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "not_actions").ResolveNodes(ctx));
        set => SetArgument("not_actions", value);
    }

    /// <summary>
    /// The not_resources attribute.
    /// </summary>
    public TerraformSet<string>? NotResources
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "not_resources").ResolveNodes(ctx));
        set => SetArgument("not_resources", value);
    }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformSet<string>? Resources
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "resources").ResolveNodes(ctx));
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// The sid attribute.
    /// </summary>
    public TerraformValue<string>? Sid
    {
        get => new TerraformReference<string>(this, "sid");
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
        get => new TerraformReference<string>(this, "test");
        set => SetArgument("test", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

    /// <summary>
    /// The variable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Variable is required")]
    public required TerraformValue<string> Variable
    {
        get => new TerraformReference<string>(this, "variable");
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identifiers").ResolveNodes(ctx));
        set => SetArgument("identifiers", value);
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identifiers").ResolveNodes(ctx));
        set => SetArgument("identifiers", value);
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
/// Represents a aws_iam_policy_document Terraform data source.
/// Retrieves information about a aws_iam_policy_document.
/// </summary>
public partial class AwsIamPolicyDocumentDataSource(string name) : TerraformDataSource("aws_iam_policy_document", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The override_json attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? OverrideJson
    {
        get => new TerraformReference<string>(this, "override_json");
        set => SetArgument("override_json", value);
    }

    /// <summary>
    /// The override_policy_documents attribute.
    /// </summary>
    public TerraformList<string>? OverridePolicyDocuments
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "override_policy_documents").ResolveNodes(ctx));
        set => SetArgument("override_policy_documents", value);
    }

    /// <summary>
    /// The policy_id attribute.
    /// </summary>
    public TerraformValue<string>? PolicyId
    {
        get => new TerraformReference<string>(this, "policy_id");
        set => SetArgument("policy_id", value);
    }

    /// <summary>
    /// The source_json attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? SourceJson
    {
        get => new TerraformReference<string>(this, "source_json");
        set => SetArgument("source_json", value);
    }

    /// <summary>
    /// The source_policy_documents attribute.
    /// </summary>
    public TerraformList<string>? SourcePolicyDocuments
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "source_policy_documents").ResolveNodes(ctx));
        set => SetArgument("source_policy_documents", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformValue<string> Json
    {
        get => new TerraformReference<string>(this, "json");
    }

    /// <summary>
    /// The minified_json attribute.
    /// </summary>
    public TerraformValue<string> MinifiedJson
    {
        get => new TerraformReference<string>(this, "minified_json");
    }

    /// <summary>
    /// Statement block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsIamPolicyDocumentDataSourceStatementBlock>? Statement
    {
        get => GetArgument<TerraformList<AwsIamPolicyDocumentDataSourceStatementBlock>>("statement");
        set => SetArgument("statement", value);
    }

}
