using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for routing_strategy in .
/// Nesting mode: list
/// </summary>
public partial class AwsGameliftAliasRoutingStrategyBlock() : TerraformBlock("routing_strategy")
{
    /// <summary>
    /// The fleet_id attribute.
    /// </summary>
    [TerraformProperty("fleet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FleetId { get; set; }

    /// <summary>
    /// The message attribute.
    /// </summary>
    [TerraformProperty("message")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Message { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Manages a aws_gamelift_alias resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGameliftAlias : TerraformResource
{
    public AwsGameliftAlias(string name) : base("aws_gamelift_alias", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// Block for routing_strategy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingStrategy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RoutingStrategy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RoutingStrategy block(s) allowed")]
    [TerraformProperty("routing_strategy")]
    public required TerraformList<AwsGameliftAliasRoutingStrategyBlock> RoutingStrategy { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
