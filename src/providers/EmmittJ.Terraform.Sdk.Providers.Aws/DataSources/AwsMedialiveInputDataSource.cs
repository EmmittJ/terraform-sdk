using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_medialive_input.
/// </summary>
public class AwsMedialiveInputDataSource : TerraformDataSource
{
    public AwsMedialiveInputDataSource(string name) : base("aws_medialive_input", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The attached_channels attribute.
    /// </summary>
    [TerraformPropertyName("attached_channels")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AttachedChannels => new TerraformReference(this, "attached_channels");

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [TerraformPropertyName("destinations")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Destinations => new TerraformReference(this, "destinations");

    /// <summary>
    /// The input_class attribute.
    /// </summary>
    [TerraformPropertyName("input_class")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InputClass => new TerraformReference(this, "input_class");

    /// <summary>
    /// The input_devices attribute.
    /// </summary>
    [TerraformPropertyName("input_devices")]
    // Output-only attribute - read-only reference
    public TerraformList<object> InputDevices => new TerraformReference(this, "input_devices");

    /// <summary>
    /// The input_partner_ids attribute.
    /// </summary>
    [TerraformPropertyName("input_partner_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> InputPartnerIds => new TerraformReference(this, "input_partner_ids");

    /// <summary>
    /// The input_source_type attribute.
    /// </summary>
    [TerraformPropertyName("input_source_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InputSourceType => new TerraformReference(this, "input_source_type");

    /// <summary>
    /// The media_connect_flows attribute.
    /// </summary>
    [TerraformPropertyName("media_connect_flows")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MediaConnectFlows => new TerraformReference(this, "media_connect_flows");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RoleArn => new TerraformReference(this, "role_arn");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SecurityGroups => new TerraformReference(this, "security_groups");

    /// <summary>
    /// The sources attribute.
    /// </summary>
    [TerraformPropertyName("sources")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Sources => new TerraformReference(this, "sources");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

}
