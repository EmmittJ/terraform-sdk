using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_endpoint in .
/// Nesting mode: set
/// </summary>
public partial class AwsAppstreamImageBuilderAccessEndpointBlock() : TerraformBlock("access_endpoint")
{
    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    [TerraformProperty("endpoint_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EndpointType { get; set; }

    /// <summary>
    /// The vpce_id attribute.
    /// </summary>
    [TerraformProperty("vpce_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VpceId { get; set; }

}

/// <summary>
/// Block type for domain_join_info in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppstreamImageBuilderDomainJoinInfoBlock() : TerraformBlock("domain_join_info")
{
    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    [TerraformProperty("directory_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DirectoryName { get; set; }

    /// <summary>
    /// The organizational_unit_distinguished_name attribute.
    /// </summary>
    [TerraformProperty("organizational_unit_distinguished_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OrganizationalUnitDistinguishedName { get; set; }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppstreamImageBuilderVpcConfigBlock() : TerraformBlock("vpc_config")
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SubnetIds { get; set; }

}

/// <summary>
/// Manages a aws_appstream_image_builder resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAppstreamImageBuilder : TerraformResource
{
    public AwsAppstreamImageBuilder(string name) : base("aws_appstream_image_builder", name)
    {
    }

    /// <summary>
    /// The appstream_agent_version attribute.
    /// </summary>
    [TerraformProperty("appstream_agent_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AppstreamAgentVersion { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The enable_default_internet_access attribute.
    /// </summary>
    [TerraformProperty("enable_default_internet_access")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnableDefaultInternetAccess { get; set; }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [TerraformProperty("iam_role_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IamRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image_arn attribute.
    /// </summary>
    [TerraformProperty("image_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ImageArn { get; set; }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [TerraformProperty("image_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ImageName { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformProperty("instance_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceType { get; set; }

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
    /// Block for access_endpoint.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 AccessEndpoint block(s) allowed")]
    [TerraformProperty("access_endpoint")]
    public TerraformSet<AwsAppstreamImageBuilderAccessEndpointBlock> AccessEndpoint { get; set; } = new();

    /// <summary>
    /// Block for domain_join_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainJoinInfo block(s) allowed")]
    [TerraformProperty("domain_join_info")]
    public TerraformList<AwsAppstreamImageBuilderDomainJoinInfoBlock> DomainJoinInfo { get; set; } = new();

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    [TerraformProperty("vpc_config")]
    public TerraformList<AwsAppstreamImageBuilderVpcConfigBlock> VpcConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformProperty("created_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedTime { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
