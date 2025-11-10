using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_api_key.
/// </summary>
public class AwsApiGatewayApiKeyDataSource : TerraformDataSource
{
    public AwsApiGatewayApiKeyDataSource(string name) : base("aws_api_gateway_api_key", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_date");

    /// <summary>
    /// The customer_id attribute.
    /// </summary>
    [TerraformPropertyName("customer_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customer_id");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Enabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enabled");

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastUpdatedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_updated_date");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Value => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "value");

}
