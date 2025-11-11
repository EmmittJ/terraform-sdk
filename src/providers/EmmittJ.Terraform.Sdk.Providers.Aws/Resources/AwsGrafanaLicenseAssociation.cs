using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsGrafanaLicenseAssociationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_grafana_license_association resource.
/// </summary>
public partial class AwsGrafanaLicenseAssociation : TerraformResource
{
    public AwsGrafanaLicenseAssociation(string name) : base("aws_grafana_license_association", name)
    {
    }

    /// <summary>
    /// The grafana_token attribute.
    /// </summary>
    [TerraformProperty("grafana_token")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GrafanaToken { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseType is required")]
    [TerraformProperty("license_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LicenseType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformProperty("workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsGrafanaLicenseAssociationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The free_trial_expiration attribute.
    /// </summary>
    [TerraformProperty("free_trial_expiration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FreeTrialExpiration { get; }

    /// <summary>
    /// The license_expiration attribute.
    /// </summary>
    [TerraformProperty("license_expiration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LicenseExpiration { get; }

}
