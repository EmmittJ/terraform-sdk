using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public partial class AwsSecuritylakeAwsLogSourceSourceBlock() : TerraformBlock("source")
{
    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformProperty("accounts")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> Accounts { get; set; }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Regions is required")]
    [TerraformProperty("regions")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Regions { get; set; }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    [TerraformProperty("source_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceName { get; set; }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    [TerraformProperty("source_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SourceVersion { get; set; }

}

/// <summary>
/// Manages a aws_securitylake_aws_log_source resource.
/// </summary>
public partial class AwsSecuritylakeAwsLogSource : TerraformResource
{
    public AwsSecuritylakeAwsLogSource(string name) : base("aws_securitylake_aws_log_source", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("source")]
    public TerraformList<AwsSecuritylakeAwsLogSourceSourceBlock> Source { get; set; } = new();

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
