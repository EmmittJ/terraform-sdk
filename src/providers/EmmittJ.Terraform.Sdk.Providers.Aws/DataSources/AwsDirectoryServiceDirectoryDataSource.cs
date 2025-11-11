using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_directory_service_directory.
/// </summary>
public partial class AwsDirectoryServiceDirectoryDataSource : TerraformDataSource
{
    public AwsDirectoryServiceDirectoryDataSource(string name) : base("aws_directory_service_directory", name)
    {
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    [TerraformProperty("directory_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DirectoryId { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The access_url attribute.
    /// </summary>
    [TerraformProperty("access_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AccessUrl { get; }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformProperty("alias")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Alias { get; }

    /// <summary>
    /// The connect_settings attribute.
    /// </summary>
    [TerraformProperty("connect_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ConnectSettings { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("dns_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> DnsIpAddresses { get; }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    [TerraformProperty("edition")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Edition { get; }

    /// <summary>
    /// The enable_sso attribute.
    /// </summary>
    [TerraformProperty("enable_sso")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableSso { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The radius_settings attribute.
    /// </summary>
    [TerraformProperty("radius_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RadiusSettings { get; }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [TerraformProperty("security_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecurityGroupId { get; }

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    [TerraformProperty("short_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ShortName { get; }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformProperty("size")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Size { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Type { get; }

    /// <summary>
    /// The vpc_settings attribute.
    /// </summary>
    [TerraformProperty("vpc_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> VpcSettings { get; }

}
