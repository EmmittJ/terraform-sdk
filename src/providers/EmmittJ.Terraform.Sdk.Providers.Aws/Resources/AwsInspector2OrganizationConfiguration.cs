using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_enable in .
/// Nesting mode: list
/// </summary>
public class AwsInspector2OrganizationConfigurationAutoEnableBlock : ITerraformBlock
{
    /// <summary>
    /// The code_repository attribute.
    /// </summary>
    [TerraformPropertyName("code_repository")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CodeRepository { get; set; }

    /// <summary>
    /// The ec2 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ec2 is required")]
    [TerraformPropertyName("ec2")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Ec2 { get; set; }

    /// <summary>
    /// The ecr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ecr is required")]
    [TerraformPropertyName("ecr")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Ecr { get; set; }

    /// <summary>
    /// The lambda attribute.
    /// </summary>
    [TerraformPropertyName("lambda")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Lambda { get; set; }

    /// <summary>
    /// The lambda_code attribute.
    /// </summary>
    [TerraformPropertyName("lambda_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LambdaCode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsInspector2OrganizationConfigurationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_inspector2_organization_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsInspector2OrganizationConfiguration : TerraformResource
{
    public AwsInspector2OrganizationConfiguration(string name) : base("aws_inspector2_organization_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for auto_enable.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AutoEnable block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoEnable block(s) allowed")]
    [TerraformPropertyName("auto_enable")]
    public TerraformList<TerraformBlock<AwsInspector2OrganizationConfigurationAutoEnableBlock>>? AutoEnable { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsInspector2OrganizationConfigurationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The max_account_limit_reached attribute.
    /// </summary>
    [TerraformPropertyName("max_account_limit_reached")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> MaxAccountLimitReached => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "max_account_limit_reached");

}
