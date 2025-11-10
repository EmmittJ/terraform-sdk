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
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The attached_channels attribute.
    /// </summary>
    [TerraformPropertyName("attached_channels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AttachedChannels => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "attached_channels");

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [TerraformPropertyName("destinations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Destinations => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "destinations");

    /// <summary>
    /// The input_class attribute.
    /// </summary>
    [TerraformPropertyName("input_class")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InputClass => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "input_class");

    /// <summary>
    /// The input_devices attribute.
    /// </summary>
    [TerraformPropertyName("input_devices")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> InputDevices => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "input_devices");

    /// <summary>
    /// The input_partner_ids attribute.
    /// </summary>
    [TerraformPropertyName("input_partner_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> InputPartnerIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "input_partner_ids");

    /// <summary>
    /// The input_source_type attribute.
    /// </summary>
    [TerraformPropertyName("input_source_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InputSourceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "input_source_type");

    /// <summary>
    /// The media_connect_flows attribute.
    /// </summary>
    [TerraformPropertyName("media_connect_flows")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MediaConnectFlows => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "media_connect_flows");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "role_arn");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SecurityGroups => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "security_groups");

    /// <summary>
    /// The sources attribute.
    /// </summary>
    [TerraformPropertyName("sources")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Sources => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "sources");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}
