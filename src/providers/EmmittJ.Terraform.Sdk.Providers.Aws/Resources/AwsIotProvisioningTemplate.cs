using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for pre_provisioning_hook in .
/// Nesting mode: list
/// </summary>
public partial class AwsIotProvisioningTemplatePreProvisioningHookBlock : TerraformBlockBase
{
    /// <summary>
    /// The payload_version attribute.
    /// </summary>
    [TerraformProperty("payload_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PayloadVersion { get; set; }

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetArn is required")]
    [TerraformProperty("target_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TargetArn { get; set; }

}

/// <summary>
/// Manages a aws_iot_provisioning_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsIotProvisioningTemplate : TerraformResource
{
    public AwsIotProvisioningTemplate(string name) : base("aws_iot_provisioning_template", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The provisioning_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProvisioningRoleArn is required")]
    [TerraformProperty("provisioning_role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProvisioningRoleArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateBody is required")]
    [TerraformProperty("template_body")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TemplateBody { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for pre_provisioning_hook.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreProvisioningHook block(s) allowed")]
    [TerraformProperty("pre_provisioning_hook")]
    public TerraformList<TerraformBlock<AwsIotProvisioningTemplatePreProvisioningHookBlock>>? PreProvisioningHook { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The default_version_id attribute.
    /// </summary>
    [TerraformProperty("default_version_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DefaultVersionId { get; }

}
