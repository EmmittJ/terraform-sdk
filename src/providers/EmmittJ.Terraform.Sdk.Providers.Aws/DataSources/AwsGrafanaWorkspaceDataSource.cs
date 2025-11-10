using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_grafana_workspace.
/// </summary>
public class AwsGrafanaWorkspaceDataSource : TerraformDataSource
{
    public AwsGrafanaWorkspaceDataSource(string name) : base("aws_grafana_workspace", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformPropertyName("workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WorkspaceId { get; set; }

    /// <summary>
    /// The account_access_type attribute.
    /// </summary>
    [TerraformPropertyName("account_access_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccountAccessType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "account_access_type");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The authentication_providers attribute.
    /// </summary>
    [TerraformPropertyName("authentication_providers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AuthenticationProviders => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "authentication_providers");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_date");

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    [TerraformPropertyName("data_sources")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> DataSources => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "data_sources");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The grafana_version attribute.
    /// </summary>
    [TerraformPropertyName("grafana_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GrafanaVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "grafana_version");

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastUpdatedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_updated_date");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The notification_destinations attribute.
    /// </summary>
    [TerraformPropertyName("notification_destinations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> NotificationDestinations => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "notification_destinations");

    /// <summary>
    /// The organization_role_name attribute.
    /// </summary>
    [TerraformPropertyName("organization_role_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OrganizationRoleName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "organization_role_name");

    /// <summary>
    /// The organizational_units attribute.
    /// </summary>
    [TerraformPropertyName("organizational_units")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> OrganizationalUnits => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "organizational_units");

    /// <summary>
    /// The permission_type attribute.
    /// </summary>
    [TerraformPropertyName("permission_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PermissionType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "permission_type");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "role_arn");

    /// <summary>
    /// The saml_configuration_status attribute.
    /// </summary>
    [TerraformPropertyName("saml_configuration_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SamlConfigurationStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "saml_configuration_status");

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    [TerraformPropertyName("stack_set_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StackSetName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "stack_set_name");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
