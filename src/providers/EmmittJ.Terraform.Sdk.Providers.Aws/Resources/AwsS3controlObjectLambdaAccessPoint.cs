using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3controlObjectLambdaAccessPointConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The allowed_features attribute.
    /// </summary>
    [TerraformProperty("allowed_features")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AllowedFeatures { get; set; }

    /// <summary>
    /// The cloud_watch_metrics_enabled attribute.
    /// </summary>
    [TerraformProperty("cloud_watch_metrics_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CloudWatchMetricsEnabled { get; set; }

    /// <summary>
    /// The supporting_access_point attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SupportingAccessPoint is required")]
    [TerraformProperty("supporting_access_point")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SupportingAccessPoint { get; set; }

}

/// <summary>
/// Manages a aws_s3control_object_lambda_access_point resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsS3controlObjectLambdaAccessPoint : TerraformResource
{
    public AwsS3controlObjectLambdaAccessPoint(string name) : base("aws_s3control_object_lambda_access_point", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AccountId { get; set; }

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
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Configuration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Configuration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    [TerraformProperty("configuration")]
    public partial TerraformList<TerraformBlock<AwsS3controlObjectLambdaAccessPointConfigurationBlock>>? Configuration { get; set; }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformProperty("alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Alias { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
