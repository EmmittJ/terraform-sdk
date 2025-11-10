using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for identity_provider_details in .
/// Nesting mode: list
/// </summary>
public class AwsTransferWebAppIdentityProviderDetailsBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_transfer_web_app resource.
/// </summary>
public class AwsTransferWebApp : TerraformResource
{
    public AwsTransferWebApp(string name) : base("aws_transfer_web_app", name)
    {
    }

    /// <summary>
    /// The access_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("access_endpoint")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AccessEndpoint { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_endpoint");

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
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The web_app_endpoint_policy attribute.
    /// </summary>
    [TerraformPropertyName("web_app_endpoint_policy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> WebAppEndpointPolicy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "web_app_endpoint_policy");

    /// <summary>
    /// The web_app_units attribute.
    /// </summary>
    [TerraformPropertyName("web_app_units")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<object>>> WebAppUnits { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "web_app_units");

    /// <summary>
    /// Block for identity_provider_details.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("identity_provider_details")]
    public TerraformList<TerraformBlock<AwsTransferWebAppIdentityProviderDetailsBlock>>? IdentityProviderDetails { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The web_app_id attribute.
    /// </summary>
    [TerraformPropertyName("web_app_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WebAppId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "web_app_id");

}
