using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for custom_dns_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFinspaceKxEnvironmentCustomDnsConfigurationBlock() : TerraformBlock("custom_dns_configuration")
{
    /// <summary>
    /// The custom_dns_server_ip attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomDnsServerIp is required")]
    [TerraformProperty("custom_dns_server_ip")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CustomDnsServerIp { get; set; }

    /// <summary>
    /// The custom_dns_server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomDnsServerName is required")]
    [TerraformProperty("custom_dns_server_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CustomDnsServerName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsFinspaceKxEnvironmentTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for transit_gateway_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlock() : TerraformBlock("transit_gateway_configuration")
{
    /// <summary>
    /// The routable_cidr_space attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutableCidrSpace is required")]
    [TerraformProperty("routable_cidr_space")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoutableCidrSpace { get; set; }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayId is required")]
    [TerraformProperty("transit_gateway_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TransitGatewayId { get; set; }

}

/// <summary>
/// Manages a aws_finspace_kx_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsFinspaceKxEnvironment : TerraformResource
{
    public AwsFinspaceKxEnvironment(string name) : base("aws_finspace_kx_environment", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyId is required")]
    [TerraformProperty("kms_key_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for custom_dns_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("custom_dns_configuration")]
    public TerraformList<AwsFinspaceKxEnvironmentCustomDnsConfigurationBlock> CustomDnsConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsFinspaceKxEnvironmentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for transit_gateway_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TransitGatewayConfiguration block(s) allowed")]
    [TerraformProperty("transit_gateway_configuration")]
    public TerraformList<AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlock> TransitGatewayConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformProperty("availability_zones")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AvailabilityZones { get; }

    /// <summary>
    /// The created_timestamp attribute.
    /// </summary>
    [TerraformProperty("created_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedTimestamp { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The infrastructure_account_id attribute.
    /// </summary>
    [TerraformProperty("infrastructure_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InfrastructureAccountId { get; }

    /// <summary>
    /// The last_modified_timestamp attribute.
    /// </summary>
    [TerraformProperty("last_modified_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastModifiedTimestamp { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
