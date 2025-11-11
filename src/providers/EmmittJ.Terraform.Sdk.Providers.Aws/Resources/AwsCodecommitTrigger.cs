using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for trigger in .
/// Nesting mode: set
/// </summary>
public partial class AwsCodecommitTriggerTriggerBlock : TerraformBlockBase
{
    /// <summary>
    /// The branches attribute.
    /// </summary>
    [TerraformProperty("branches")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Branches { get; set; }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    [TerraformProperty("custom_data")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CustomData { get; set; }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    [TerraformProperty("destination_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DestinationArn { get; set; }

    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    [TerraformProperty("events")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? Events { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Manages a aws_codecommit_trigger resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCodecommitTrigger : TerraformResource
{
    public AwsCodecommitTrigger(string name) : base("aws_codecommit_trigger", name)
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
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformProperty("repository_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RepositoryName { get; set; }

    /// <summary>
    /// Block for trigger.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Trigger is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Trigger block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Trigger block(s) allowed")]
    [TerraformProperty("trigger")]
    public TerraformSet<TerraformBlock<AwsCodecommitTriggerTriggerBlock>>? Trigger { get; set; }

    /// <summary>
    /// The configuration_id attribute.
    /// </summary>
    [TerraformProperty("configuration_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ConfigurationId { get; }

}
