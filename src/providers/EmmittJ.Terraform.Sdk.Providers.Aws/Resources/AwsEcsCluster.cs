using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsClusterConfigurationBlock() : TerraformBlock("configuration")
{
}

/// <summary>
/// Block type for service_connect_defaults in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsClusterServiceConnectDefaultsBlock() : TerraformBlock("service_connect_defaults")
{
    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    [TerraformProperty("namespace")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Namespace { get; set; }

}

/// <summary>
/// Block type for setting in .
/// Nesting mode: set
/// </summary>
public partial class AwsEcsClusterSettingBlock() : TerraformBlock("setting")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Manages a aws_ecs_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEcsCluster : TerraformResource
{
    public AwsEcsCluster(string name) : base("aws_ecs_cluster", name)
    {
    }

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
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    [TerraformProperty("configuration")]
    public TerraformList<AwsEcsClusterConfigurationBlock> Configuration { get; set; } = new();

    /// <summary>
    /// Block for service_connect_defaults.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceConnectDefaults block(s) allowed")]
    [TerraformProperty("service_connect_defaults")]
    public TerraformList<AwsEcsClusterServiceConnectDefaultsBlock> ServiceConnectDefaults { get; set; } = new();

    /// <summary>
    /// Block for setting.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("setting")]
    public TerraformSet<AwsEcsClusterSettingBlock> Setting { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
