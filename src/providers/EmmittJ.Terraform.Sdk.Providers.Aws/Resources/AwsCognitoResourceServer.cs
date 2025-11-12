using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for scope in .
/// Nesting mode: set
/// </summary>
public partial class AwsCognitoResourceServerScopeBlock() : TerraformBlock("scope")
{
    /// <summary>
    /// The scope_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeDescription is required")]
    [TerraformProperty("scope_description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ScopeDescription { get; set; }

    /// <summary>
    /// The scope_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeName is required")]
    [TerraformProperty("scope_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ScopeName { get; set; }

}

/// <summary>
/// Manages a aws_cognito_resource_server resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCognitoResourceServer : TerraformResource
{
    public AwsCognitoResourceServer(string name) : base("aws_cognito_resource_server", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [TerraformProperty("identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Identifier { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformProperty("user_pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserPoolId { get; set; }

    /// <summary>
    /// Block for scope.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Scope block(s) allowed")]
    [TerraformProperty("scope")]
    public TerraformSet<AwsCognitoResourceServerScopeBlock> Scope { get; set; } = new();

    /// <summary>
    /// The scope_identifiers attribute.
    /// </summary>
    [TerraformProperty("scope_identifiers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ScopeIdentifiers { get; }

}
