using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for connect_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsDirectoryServiceDirectoryConnectSettingsBlock : TerraformBlockBase
{


    /// <summary>
    /// The customer_dns_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerDnsIps is required")]
    [TerraformProperty("customer_dns_ips")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> CustomerDnsIps { get; set; }

    /// <summary>
    /// The customer_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerUsername is required")]
    [TerraformProperty("customer_username")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CustomerUsername { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> SubnetIds { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformProperty("vpc_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VpcId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDirectoryServiceDirectoryTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for vpc_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsDirectoryServiceDirectoryVpcSettingsBlock : TerraformBlockBase
{

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> SubnetIds { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformProperty("vpc_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VpcId { get; set; }

}

/// <summary>
/// Manages a aws_directory_service_directory resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDirectoryServiceDirectory : TerraformResource
{
    public AwsDirectoryServiceDirectory(string name) : base("aws_directory_service_directory", name)
    {
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformProperty("alias")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Alias { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The desired_number_of_domain_controllers attribute.
    /// </summary>
    [TerraformProperty("desired_number_of_domain_controllers")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DesiredNumberOfDomainControllers { get; set; }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    [TerraformProperty("edition")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Edition { get; set; }

    /// <summary>
    /// The enable_sso attribute.
    /// </summary>
    [TerraformProperty("enable_sso")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableSso { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformProperty("password")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Password { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    [TerraformProperty("short_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ShortName { get; set; }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformProperty("size")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Size { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// Block for connect_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectSettings block(s) allowed")]
    [TerraformProperty("connect_settings")]
    public TerraformList<TerraformBlock<AwsDirectoryServiceDirectoryConnectSettingsBlock>>? ConnectSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsDirectoryServiceDirectoryTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vpc_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcSettings block(s) allowed")]
    [TerraformProperty("vpc_settings")]
    public TerraformList<TerraformBlock<AwsDirectoryServiceDirectoryVpcSettingsBlock>>? VpcSettings { get; set; }

    /// <summary>
    /// The access_url attribute.
    /// </summary>
    [TerraformProperty("access_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AccessUrl { get; }

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("dns_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> DnsIpAddresses { get; }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [TerraformProperty("security_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecurityGroupId { get; }

}
