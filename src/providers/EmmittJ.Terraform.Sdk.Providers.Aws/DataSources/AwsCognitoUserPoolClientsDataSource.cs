using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cognito_user_pool_clients.
/// </summary>
public class AwsCognitoUserPoolClientsDataSource : TerraformDataSource
{
    public AwsCognitoUserPoolClientsDataSource(string name) : base("aws_cognito_user_pool_clients", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformPropertyName("user_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserPoolId { get; set; }

    /// <summary>
    /// The client_ids attribute.
    /// </summary>
    [TerraformPropertyName("client_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ClientIds => new TerraformReference(this, "client_ids");

    /// <summary>
    /// The client_names attribute.
    /// </summary>
    [TerraformPropertyName("client_names")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ClientNames => new TerraformReference(this, "client_names");

}
