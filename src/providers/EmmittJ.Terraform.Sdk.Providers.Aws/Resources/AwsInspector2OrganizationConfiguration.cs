using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_enable in .
/// Nesting mode: list
/// </summary>
public partial class AwsInspector2OrganizationConfigurationAutoEnableBlock : TerraformBlockBase
{
    /// <summary>
    /// The code_repository attribute.
    /// </summary>
    [TerraformProperty("code_repository")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CodeRepository { get; set; }

    /// <summary>
    /// The ec2 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ec2 is required")]
    [TerraformProperty("ec2")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Ec2 { get; set; }

    /// <summary>
    /// The ecr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ecr is required")]
    [TerraformProperty("ecr")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Ecr { get; set; }

    /// <summary>
    /// The lambda attribute.
    /// </summary>
    [TerraformProperty("lambda")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Lambda { get; set; }

    /// <summary>
    /// The lambda_code attribute.
    /// </summary>
    [TerraformProperty("lambda_code")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? LambdaCode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsInspector2OrganizationConfigurationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_inspector2_organization_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsInspector2OrganizationConfiguration : TerraformResource
{
    public AwsInspector2OrganizationConfiguration(string name) : base("aws_inspector2_organization_configuration", name)
    {
    }

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
    /// Block for auto_enable.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AutoEnable block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoEnable block(s) allowed")]
    [TerraformProperty("auto_enable")]
    public TerraformList<TerraformBlock<AwsInspector2OrganizationConfigurationAutoEnableBlock>>? AutoEnable { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsInspector2OrganizationConfigurationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The max_account_limit_reached attribute.
    /// </summary>
    [TerraformProperty("max_account_limit_reached")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> MaxAccountLimitReached { get; }

}
