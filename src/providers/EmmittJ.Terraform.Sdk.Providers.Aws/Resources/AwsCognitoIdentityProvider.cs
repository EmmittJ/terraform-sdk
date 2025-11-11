using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_identity_provider resource.
/// </summary>
public partial class AwsCognitoIdentityProvider : TerraformResource
{
    public AwsCognitoIdentityProvider(string name) : base("aws_cognito_identity_provider", name)
    {
    }

    /// <summary>
    /// The attribute_mapping attribute.
    /// </summary>
    [TerraformProperty("attribute_mapping")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> AttributeMapping { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The idp_identifiers attribute.
    /// </summary>
    [TerraformProperty("idp_identifiers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? IdpIdentifiers { get; set; }

    /// <summary>
    /// The provider_details attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderDetails is required")]
    [TerraformProperty("provider_details")]
    // Required argument - source generator will implement get/set
    public required partial TerraformMap<string> ProviderDetails { get; set; }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderName is required")]
    [TerraformProperty("provider_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProviderName { get; set; }

    /// <summary>
    /// The provider_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderType is required")]
    [TerraformProperty("provider_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProviderType { get; set; }

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

}
