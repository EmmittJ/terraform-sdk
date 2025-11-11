using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cognito_user_pool_clients.
/// </summary>
public partial class AwsCognitoUserPoolClientsDataSource : TerraformDataSource
{
    public AwsCognitoUserPoolClientsDataSource(string name) : base("aws_cognito_user_pool_clients", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformProperty("user_pool_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UserPoolId { get; set; }

    /// <summary>
    /// The client_ids attribute.
    /// </summary>
    [TerraformProperty("client_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ClientIds { get; }

    /// <summary>
    /// The client_names attribute.
    /// </summary>
    [TerraformProperty("client_names")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ClientNames { get; }

}
