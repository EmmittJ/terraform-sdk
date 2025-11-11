using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resources in .
/// Nesting mode: list
/// </summary>
public partial class AwsRoute53recoveryreadinessResourceSetResourcesBlock : TerraformBlockBase
{

    /// <summary>
    /// The readiness_scopes attribute.
    /// </summary>
    [TerraformProperty("readiness_scopes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ReadinessScopes { get; set; }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [TerraformProperty("resource_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResourceArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRoute53recoveryreadinessResourceSetTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_route53recoveryreadiness_resource_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsRoute53recoveryreadinessResourceSet : TerraformResource
{
    public AwsRoute53recoveryreadinessResourceSet(string name) : base("aws_route53recoveryreadiness_resource_set", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceSetName is required")]
    [TerraformProperty("resource_set_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceSetName { get; set; }

    /// <summary>
    /// The resource_set_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceSetType is required")]
    [TerraformProperty("resource_set_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceSetType { get; set; }

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
    /// Block for resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resources is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Resources block(s) required")]
    [TerraformProperty("resources")]
    public partial TerraformList<TerraformBlock<AwsRoute53recoveryreadinessResourceSetResourcesBlock>>? Resources { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsRoute53recoveryreadinessResourceSetTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
