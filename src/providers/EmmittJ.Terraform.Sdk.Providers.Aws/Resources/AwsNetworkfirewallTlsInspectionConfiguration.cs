using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsNetworkfirewallTlsInspectionConfigurationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for tls_inspection_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_networkfirewall_tls_inspection_configuration resource.
/// </summary>
public partial class AwsNetworkfirewallTlsInspectionConfiguration : TerraformResource
{
    public AwsNetworkfirewallTlsInspectionConfiguration(string name) : base("aws_networkfirewall_tls_inspection_configuration", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    [TerraformProperty("encryption_configuration")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<object> EncryptionConfiguration { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsNetworkfirewallTlsInspectionConfigurationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for tls_inspection_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("tls_inspection_configuration")]
    public TerraformList<TerraformBlock<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlock>>? TlsInspectionConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The certificate_authority attribute.
    /// </summary>
    [TerraformProperty("certificate_authority")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CertificateAuthority { get; }

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    [TerraformProperty("certificates")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Certificates { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The number_of_associations attribute.
    /// </summary>
    [TerraformProperty("number_of_associations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> NumberOfAssociations { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The tls_inspection_configuration_id attribute.
    /// </summary>
    [TerraformProperty("tls_inspection_configuration_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TlsInspectionConfigurationId { get; }

    /// <summary>
    /// The update_token attribute.
    /// </summary>
    [TerraformProperty("update_token")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateToken { get; }

}
