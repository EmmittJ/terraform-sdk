using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for insights_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsXrayGroupInsightsConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The insights_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InsightsEnabled is required")]
    [TerraformProperty("insights_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> InsightsEnabled { get; set; }

    /// <summary>
    /// The notifications_enabled attribute.
    /// </summary>
    [TerraformProperty("notifications_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> NotificationsEnabled { get; set; }

}

/// <summary>
/// Manages a aws_xray_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsXrayGroup : TerraformResource
{
    public AwsXrayGroup(string name) : base("aws_xray_group", name)
    {
    }

    /// <summary>
    /// The filter_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterExpression is required")]
    [TerraformProperty("filter_expression")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FilterExpression { get; set; }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    [TerraformProperty("group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GroupName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// Block for insights_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InsightsConfiguration block(s) allowed")]
    [TerraformProperty("insights_configuration")]
    public partial TerraformList<TerraformBlock<AwsXrayGroupInsightsConfigurationBlock>>? InsightsConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
