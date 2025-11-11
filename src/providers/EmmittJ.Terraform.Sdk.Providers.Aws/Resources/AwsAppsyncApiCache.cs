using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appsync_api_cache resource.
/// </summary>
public partial class AwsAppsyncApiCache : TerraformResource
{
    public AwsAppsyncApiCache(string name) : base("aws_appsync_api_cache", name)
    {
    }

    /// <summary>
    /// The api_caching_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiCachingBehavior is required")]
    [TerraformProperty("api_caching_behavior")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApiCachingBehavior { get; set; }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformProperty("api_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApiId { get; set; }

    /// <summary>
    /// The at_rest_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("at_rest_encryption_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> AtRestEncryptionEnabled { get; set; }

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
    /// The transit_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("transit_encryption_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> TransitEncryptionEnabled { get; set; }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ttl is required")]
    [TerraformProperty("ttl")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Ttl { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}
