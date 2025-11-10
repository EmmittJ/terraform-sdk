using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_directory_service_directory.
/// </summary>
public class AwsDirectoryServiceDirectoryDataSource : TerraformDataSource
{
    public AwsDirectoryServiceDirectoryDataSource(string name) : base("aws_directory_service_directory", name)
    {
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    [TerraformPropertyName("directory_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DirectoryId { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The access_url attribute.
    /// </summary>
    [TerraformPropertyName("access_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccessUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_url");

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformPropertyName("alias")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Alias => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "alias");

    /// <summary>
    /// The connect_settings attribute.
    /// </summary>
    [TerraformPropertyName("connect_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ConnectSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "connect_settings");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("dns_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> DnsIpAddresses => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "dns_ip_addresses");

    /// <summary>
    /// The edition attribute.
    /// </summary>
    [TerraformPropertyName("edition")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Edition => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "edition");

    /// <summary>
    /// The enable_sso attribute.
    /// </summary>
    [TerraformPropertyName("enable_sso")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableSso => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_sso");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The radius_settings attribute.
    /// </summary>
    [TerraformPropertyName("radius_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RadiusSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "radius_settings");

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecurityGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "security_group_id");

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    [TerraformPropertyName("short_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ShortName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "short_name");

    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformPropertyName("size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Size => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "size");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// The vpc_settings attribute.
    /// </summary>
    [TerraformPropertyName("vpc_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> VpcSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "vpc_settings");

}
