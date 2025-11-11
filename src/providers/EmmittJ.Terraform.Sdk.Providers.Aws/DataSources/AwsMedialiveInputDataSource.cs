using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_medialive_input.
/// </summary>
public partial class AwsMedialiveInputDataSource : TerraformDataSource
{
    public AwsMedialiveInputDataSource(string name) : base("aws_medialive_input", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The attached_channels attribute.
    /// </summary>
    [TerraformProperty("attached_channels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AttachedChannels { get; }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [TerraformProperty("destinations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Destinations { get; }

    /// <summary>
    /// The input_class attribute.
    /// </summary>
    [TerraformProperty("input_class")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InputClass { get; }

    /// <summary>
    /// The input_devices attribute.
    /// </summary>
    [TerraformProperty("input_devices")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> InputDevices { get; }

    /// <summary>
    /// The input_partner_ids attribute.
    /// </summary>
    [TerraformProperty("input_partner_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> InputPartnerIds { get; }

    /// <summary>
    /// The input_source_type attribute.
    /// </summary>
    [TerraformProperty("input_source_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InputSourceType { get; }

    /// <summary>
    /// The media_connect_flows attribute.
    /// </summary>
    [TerraformProperty("media_connect_flows")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> MediaConnectFlows { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RoleArn { get; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SecurityGroups { get; }

    /// <summary>
    /// The sources attribute.
    /// </summary>
    [TerraformProperty("sources")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Sources { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

}
