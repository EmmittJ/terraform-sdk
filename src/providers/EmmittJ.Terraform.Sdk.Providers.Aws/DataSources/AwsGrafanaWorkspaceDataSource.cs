using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_grafana_workspace.
/// </summary>
public partial class AwsGrafanaWorkspaceDataSource : TerraformDataSource
{
    public AwsGrafanaWorkspaceDataSource(string name) : base("aws_grafana_workspace", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

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
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformProperty("workspace_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// The account_access_type attribute.
    /// </summary>
    [TerraformProperty("account_access_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AccountAccessType { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The authentication_providers attribute.
    /// </summary>
    [TerraformProperty("authentication_providers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AuthenticationProviders { get; }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformProperty("created_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedDate { get; }

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    [TerraformProperty("data_sources")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> DataSources { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The grafana_version attribute.
    /// </summary>
    [TerraformProperty("grafana_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GrafanaVersion { get; }

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    [TerraformProperty("last_updated_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastUpdatedDate { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The notification_destinations attribute.
    /// </summary>
    [TerraformProperty("notification_destinations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> NotificationDestinations { get; }

    /// <summary>
    /// The organization_role_name attribute.
    /// </summary>
    [TerraformProperty("organization_role_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OrganizationRoleName { get; }

    /// <summary>
    /// The organizational_units attribute.
    /// </summary>
    [TerraformProperty("organizational_units")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> OrganizationalUnits { get; }

    /// <summary>
    /// The permission_type attribute.
    /// </summary>
    [TerraformProperty("permission_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PermissionType { get; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RoleArn { get; }

    /// <summary>
    /// The saml_configuration_status attribute.
    /// </summary>
    [TerraformProperty("saml_configuration_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SamlConfigurationStatus { get; }

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    [TerraformProperty("stack_set_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StackSetName { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
