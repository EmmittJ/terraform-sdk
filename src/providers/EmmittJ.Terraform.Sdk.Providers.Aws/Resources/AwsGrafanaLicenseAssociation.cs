using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGrafanaLicenseAssociationTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a aws_grafana_license_association resource.
/// </summary>
public class AwsGrafanaLicenseAssociation : TerraformResource
{
    public AwsGrafanaLicenseAssociation(string name) : base("aws_grafana_license_association", name)
    {
    }

    /// <summary>
    /// The grafana_token attribute.
    /// </summary>
    [TerraformPropertyName("grafana_token")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GrafanaToken { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseType is required")]
    [TerraformPropertyName("license_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LicenseType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformPropertyName("workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsGrafanaLicenseAssociationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The free_trial_expiration attribute.
    /// </summary>
    [TerraformPropertyName("free_trial_expiration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FreeTrialExpiration => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "free_trial_expiration");

    /// <summary>
    /// The license_expiration attribute.
    /// </summary>
    [TerraformPropertyName("license_expiration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LicenseExpiration => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_expiration");

}
