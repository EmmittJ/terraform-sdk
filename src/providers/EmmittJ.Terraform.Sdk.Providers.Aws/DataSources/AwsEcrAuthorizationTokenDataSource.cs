using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecr_authorization_token.
/// </summary>
public class AwsEcrAuthorizationTokenDataSource : TerraformDataSource
{
    public AwsEcrAuthorizationTokenDataSource(string name) : base("aws_ecr_authorization_token", name)
    {
    }

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
    /// The registry_id attribute.
    /// </summary>
    [TerraformPropertyName("registry_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RegistryId { get; set; }

    /// <summary>
    /// The authorization_token attribute.
    /// </summary>
    [TerraformPropertyName("authorization_token")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AuthorizationToken => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "authorization_token");

    /// <summary>
    /// The expires_at attribute.
    /// </summary>
    [TerraformPropertyName("expires_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExpiresAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expires_at");

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Password => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "password");

    /// <summary>
    /// The proxy_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("proxy_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProxyEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "proxy_endpoint");

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [TerraformPropertyName("user_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_name");

}
