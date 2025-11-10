using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for scope in .
/// Nesting mode: set
/// </summary>
public class AwsCognitoResourceServerScopeBlock : TerraformBlock
{
    /// <summary>
    /// The scope_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeDescription is required")]
    public required TerraformProperty<string> ScopeDescription
    {
        get => GetProperty<TerraformProperty<string>>("scope_description");
        set => WithProperty("scope_description", value);
    }

    /// <summary>
    /// The scope_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeName is required")]
    public required TerraformProperty<string> ScopeName
    {
        get => GetProperty<TerraformProperty<string>>("scope_name");
        set => WithProperty("scope_name", value);
    }

}

/// <summary>
/// Manages a aws_cognito_resource_server resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCognitoResourceServer : TerraformResource
{
    public AwsCognitoResourceServer(string name) : base("aws_cognito_resource_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("scope_identifiers");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    public required TerraformProperty<string> Identifier
    {
        get => GetProperty<TerraformProperty<string>>("identifier");
        set => this.WithProperty("identifier", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformProperty<string> UserPoolId
    {
        get => GetProperty<TerraformProperty<string>>("user_pool_id");
        set => this.WithProperty("user_pool_id", value);
    }

    /// <summary>
    /// Block for scope.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Scope block(s) allowed")]
    public HashSet<AwsCognitoResourceServerScopeBlock>? Scope
    {
        get => GetProperty<HashSet<AwsCognitoResourceServerScopeBlock>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// The scope_identifiers attribute.
    /// </summary>
    public TerraformExpression ScopeIdentifiers => this["scope_identifiers"];

}
