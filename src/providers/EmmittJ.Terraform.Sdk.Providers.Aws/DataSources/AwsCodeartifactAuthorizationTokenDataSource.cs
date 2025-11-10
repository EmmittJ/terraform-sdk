using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_codeartifact_authorization_token.
/// </summary>
public class AwsCodeartifactAuthorizationTokenDataSource : TerraformDataSource
{
    public AwsCodeartifactAuthorizationTokenDataSource(string name) : base("aws_codeartifact_authorization_token", name)
    {
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformPropertyName("domain")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Domain { get; set; }

    /// <summary>
    /// The domain_owner attribute.
    /// </summary>
    [TerraformPropertyName("domain_owner")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DomainOwner { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_owner");

    /// <summary>
    /// The duration_seconds attribute.
    /// </summary>
    [TerraformPropertyName("duration_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DurationSeconds { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The authorization_token attribute.
    /// </summary>
    [TerraformPropertyName("authorization_token")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AuthorizationToken => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "authorization_token");

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    [TerraformPropertyName("expiration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Expiration => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expiration");

}
