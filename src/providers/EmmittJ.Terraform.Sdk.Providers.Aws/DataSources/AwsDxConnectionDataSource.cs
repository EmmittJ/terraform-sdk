using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dx_connection.
/// </summary>
public partial class AwsDxConnectionDataSource : TerraformDataSource
{
    public AwsDxConnectionDataSource(string name) : base("aws_dx_connection", name)
    {
    }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    [TerraformProperty("aws_device")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AwsDevice { get; }

    /// <summary>
    /// The bandwidth attribute.
    /// </summary>
    [TerraformProperty("bandwidth")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Bandwidth { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [TerraformProperty("owner_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OwnerAccountId { get; }

    /// <summary>
    /// The partner_name attribute.
    /// </summary>
    [TerraformProperty("partner_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PartnerName { get; }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformProperty("provider_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ProviderName { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    [TerraformProperty("vlan_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> VlanId { get; }

}
