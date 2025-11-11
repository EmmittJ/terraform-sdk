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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformPropertyName("workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// The account_access_type attribute.
    /// </summary>
    [TerraformPropertyName("account_access_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AccountAccessType => new TerraformReference(this, "account_access_type");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The authentication_providers attribute.
    /// </summary>
    [TerraformPropertyName("authentication_providers")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AuthenticationProviders => new TerraformReference(this, "authentication_providers");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedDate => new TerraformReference(this, "created_date");

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    [TerraformPropertyName("data_sources")]
    // Output-only attribute - read-only reference
    public TerraformList<string> DataSources => new TerraformReference(this, "data_sources");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The grafana_version attribute.
    /// </summary>
    [TerraformPropertyName("grafana_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GrafanaVersion => new TerraformReference(this, "grafana_version");

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastUpdatedDate => new TerraformReference(this, "last_updated_date");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The notification_destinations attribute.
    /// </summary>
    [TerraformPropertyName("notification_destinations")]
    // Output-only attribute - read-only reference
    public TerraformList<string> NotificationDestinations => new TerraformReference(this, "notification_destinations");

    /// <summary>
    /// The organization_role_name attribute.
    /// </summary>
    [TerraformPropertyName("organization_role_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OrganizationRoleName => new TerraformReference(this, "organization_role_name");

    /// <summary>
    /// The organizational_units attribute.
    /// </summary>
    [TerraformPropertyName("organizational_units")]
    // Output-only attribute - read-only reference
    public TerraformList<string> OrganizationalUnits => new TerraformReference(this, "organizational_units");

    /// <summary>
    /// The permission_type attribute.
    /// </summary>
    [TerraformPropertyName("permission_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PermissionType => new TerraformReference(this, "permission_type");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RoleArn => new TerraformReference(this, "role_arn");

    /// <summary>
    /// The saml_configuration_status attribute.
    /// </summary>
    [TerraformPropertyName("saml_configuration_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SamlConfigurationStatus => new TerraformReference(this, "saml_configuration_status");

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    [TerraformPropertyName("stack_set_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StackSetName => new TerraformReference(this, "stack_set_name");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
