using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for private_registry_access in .
/// Nesting mode: list
/// </summary>
public partial class AwsLightsailContainerServicePrivateRegistryAccessBlock() : TerraformBlock("private_registry_access")
{
}

/// <summary>
/// Block type for public_domain_names in .
/// Nesting mode: list
/// </summary>
public partial class AwsLightsailContainerServicePublicDomainNamesBlock() : TerraformBlock("public_domain_names")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsLightsailContainerServiceTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a aws_lightsail_container_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsLightsailContainerService : TerraformResource
{
    public AwsLightsailContainerService(string name) : base("aws_lightsail_container_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The is_disabled attribute.
    /// </summary>
    [TerraformProperty("is_disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsDisabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The power attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Power is required")]
    [TerraformProperty("power")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Power { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The scale attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scale is required")]
    [TerraformProperty("scale")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Scale { get; set; }

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
    /// Block for private_registry_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateRegistryAccess block(s) allowed")]
    [TerraformProperty("private_registry_access")]
    public TerraformList<AwsLightsailContainerServicePrivateRegistryAccessBlock> PrivateRegistryAccess { get; set; } = new();

    /// <summary>
    /// Block for public_domain_names.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicDomainNames block(s) allowed")]
    [TerraformProperty("public_domain_names")]
    public TerraformList<AwsLightsailContainerServicePublicDomainNamesBlock> PublicDomainNames { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsLightsailContainerServiceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailabilityZone { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The power_id attribute.
    /// </summary>
    [TerraformProperty("power_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PowerId { get; }

    /// <summary>
    /// The principal_arn attribute.
    /// </summary>
    [TerraformProperty("principal_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrincipalArn { get; }

    /// <summary>
    /// The private_domain_name attribute.
    /// </summary>
    [TerraformProperty("private_domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateDomainName { get; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformProperty("resource_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceType { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Url { get; }

}
