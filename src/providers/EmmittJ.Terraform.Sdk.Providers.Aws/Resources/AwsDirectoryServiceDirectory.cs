using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for connect_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDirectoryServiceDirectoryConnectSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Computed attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> AvailabilityZones => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "availability_zones");

    /// <summary>
    /// The connect_ips attribute.
    /// </summary>
    [TerraformPropertyName("connect_ips")]
    // Computed attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> ConnectIps => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "connect_ips");

    /// <summary>
    /// The customer_dns_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerDnsIps is required")]
    [TerraformPropertyName("customer_dns_ips")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? CustomerDnsIps { get; set; }

    /// <summary>
    /// The customer_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerUsername is required")]
    [TerraformPropertyName("customer_username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CustomerUsername { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubnetIds { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformPropertyName("vpc_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VpcId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDirectoryServiceDirectoryTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for vpc_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDirectoryServiceDirectoryVpcSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Computed attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> AvailabilityZones => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "availability_zones");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubnetIds { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformPropertyName("vpc_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VpcId { get; set; }

}

/// <summary>
/// Manages a aws_directory_service_directory resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDirectoryServiceDirectory : TerraformResource
{
    public AwsDirectoryServiceDirectory(string name) : base("aws_directory_service_directory", name)
    {
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformPropertyName("alias")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Alias { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "alias");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The desired_number_of_domain_controllers attribute.
    /// </summary>
    [TerraformPropertyName("desired_number_of_domain_controllers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DesiredNumberOfDomainControllers { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "desired_number_of_domain_controllers");

    /// <summary>
    /// The edition attribute.
    /// </summary>
    [TerraformPropertyName("edition")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Edition { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "edition");

    /// <summary>
    /// The enable_sso attribute.
    /// </summary>
    [TerraformPropertyName("enable_sso")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableSso { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformPropertyName("password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Password { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    [TerraformPropertyName("short_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ShortName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "short_name");

    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformPropertyName("size")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Size { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "size");

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
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// Block for connect_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectSettings block(s) allowed")]
    [TerraformPropertyName("connect_settings")]
    public TerraformList<TerraformBlock<AwsDirectoryServiceDirectoryConnectSettingsBlock>>? ConnectSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDirectoryServiceDirectoryTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vpc_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcSettings block(s) allowed")]
    [TerraformPropertyName("vpc_settings")]
    public TerraformList<TerraformBlock<AwsDirectoryServiceDirectoryVpcSettingsBlock>>? VpcSettings { get; set; } = new();

    /// <summary>
    /// The access_url attribute.
    /// </summary>
    [TerraformPropertyName("access_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccessUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_url");

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("dns_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> DnsIpAddresses => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "dns_ip_addresses");

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecurityGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "security_group_id");

}
