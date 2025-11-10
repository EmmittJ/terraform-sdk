using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_verifiedaccess_instance resource.
/// </summary>
public class AwsVerifiedaccessInstance : TerraformResource
{
    public AwsVerifiedaccessInstance(string name) : base("aws_verifiedaccess_instance", name)
    {
    }

    /// <summary>
    /// The cidr_endpoints_custom_subdomain attribute.
    /// </summary>
    [TerraformPropertyName("cidr_endpoints_custom_subdomain")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CidrEndpointsCustomSubdomain { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    [TerraformPropertyName("fips_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FipsEnabled { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_time");

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastUpdatedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_updated_time");

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    [TerraformPropertyName("name_servers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> NameServers => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "name_servers");

    /// <summary>
    /// The verified_access_trust_providers attribute.
    /// </summary>
    [TerraformPropertyName("verified_access_trust_providers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> VerifiedAccessTrustProviders => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "verified_access_trust_providers");

}
