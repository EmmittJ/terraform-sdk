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
    public required TerraformValue<string> DirectoryId { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The access_url attribute.
    /// </summary>
    [TerraformPropertyName("access_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AccessUrl => new TerraformReference(this, "access_url");

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformPropertyName("alias")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Alias => new TerraformReference(this, "alias");

    /// <summary>
    /// The connect_settings attribute.
    /// </summary>
    [TerraformPropertyName("connect_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ConnectSettings => new TerraformReference(this, "connect_settings");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("dns_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> DnsIpAddresses => new TerraformReference(this, "dns_ip_addresses");

    /// <summary>
    /// The edition attribute.
    /// </summary>
    [TerraformPropertyName("edition")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Edition => new TerraformReference(this, "edition");

    /// <summary>
    /// The enable_sso attribute.
    /// </summary>
    [TerraformPropertyName("enable_sso")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableSso => new TerraformReference(this, "enable_sso");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The radius_settings attribute.
    /// </summary>
    [TerraformPropertyName("radius_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RadiusSettings => new TerraformReference(this, "radius_settings");

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecurityGroupId => new TerraformReference(this, "security_group_id");

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    [TerraformPropertyName("short_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ShortName => new TerraformReference(this, "short_name");

    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformPropertyName("size")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Size => new TerraformReference(this, "size");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

    /// <summary>
    /// The vpc_settings attribute.
    /// </summary>
    [TerraformPropertyName("vpc_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> VpcSettings => new TerraformReference(this, "vpc_settings");

}
