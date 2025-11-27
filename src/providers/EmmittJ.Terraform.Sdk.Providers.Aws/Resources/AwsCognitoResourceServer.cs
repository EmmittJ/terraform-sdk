using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for scope in AwsCognitoResourceServer.
/// Nesting mode: set
/// </summary>
public class AwsCognitoResourceServerScopeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scope";

    /// <summary>
    /// The scope_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeDescription is required")]
    public required TerraformValue<string> ScopeDescription
    {
        get => new TerraformReference<string>(this, "scope_description");
        set => SetArgument("scope_description", value);
    }

    /// <summary>
    /// The scope_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeName is required")]
    public required TerraformValue<string> ScopeName
    {
        get => new TerraformReference<string>(this, "scope_name");
        set => SetArgument("scope_name", value);
    }

}


/// <summary>
/// Represents a aws_cognito_resource_server Terraform resource.
/// Manages a aws_cognito_resource_server resource.
/// </summary>
public partial class AwsCognitoResourceServer(string name) : TerraformResource("aws_cognito_resource_server", name)
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
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    public required TerraformValue<string> Identifier
    {
        get => new TerraformReference<string>(this, "identifier");
        set => SetArgument("identifier", value);
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
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformValue<string> UserPoolId
    {
        get => new TerraformReference<string>(this, "user_pool_id");
        set => SetArgument("user_pool_id", value);
    }

    /// <summary>
    /// The scope_identifiers attribute.
    /// </summary>
    public TerraformList<string> ScopeIdentifiers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "scope_identifiers").ResolveNodes(ctx));
    }

    /// <summary>
    /// Scope block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Scope block(s) allowed")]
    public TerraformSet<AwsCognitoResourceServerScopeBlock>? Scope
    {
        get => GetArgument<TerraformSet<AwsCognitoResourceServerScopeBlock>>("scope");
        set => SetArgument("scope", value);
    }

}
