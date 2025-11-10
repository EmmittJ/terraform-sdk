using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appsync_api_key resource.
/// </summary>
public class AwsAppsyncApiKey : TerraformResource
{
    public AwsAppsyncApiKey(string name) : base("aws_appsync_api_key", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformPropertyName("api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApiId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The expires attribute.
    /// </summary>
    [TerraformPropertyName("expires")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Expires { get; set; }

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
    /// The api_key_id attribute.
    /// </summary>
    [TerraformPropertyName("api_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApiKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "api_key_id");

    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformPropertyName("key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Key => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key");

}
