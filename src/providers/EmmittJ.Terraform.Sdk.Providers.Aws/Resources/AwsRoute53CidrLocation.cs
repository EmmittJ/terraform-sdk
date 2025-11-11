using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_cidr_location resource.
/// </summary>
public partial class AwsRoute53CidrLocation : TerraformResource
{
    public AwsRoute53CidrLocation(string name) : base("aws_route53_cidr_location", name)
    {
    }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrBlocks is required")]
    [TerraformProperty("cidr_blocks")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> CidrBlocks { get; set; }

    /// <summary>
    /// The cidr_collection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrCollectionId is required")]
    [TerraformProperty("cidr_collection_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CidrCollectionId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
