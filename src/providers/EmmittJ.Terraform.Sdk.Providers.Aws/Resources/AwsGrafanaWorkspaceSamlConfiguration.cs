using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsGrafanaWorkspaceSamlConfigurationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_grafana_workspace_saml_configuration resource.
/// </summary>
public partial class AwsGrafanaWorkspaceSamlConfiguration : TerraformResource
{
    public AwsGrafanaWorkspaceSamlConfiguration(string name) : base("aws_grafana_workspace_saml_configuration", name)
    {
    }

    /// <summary>
    /// The admin_role_values attribute.
    /// </summary>
    [TerraformProperty("admin_role_values")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? AdminRoleValues { get; set; }

    /// <summary>
    /// The allowed_organizations attribute.
    /// </summary>
    [TerraformProperty("allowed_organizations")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? AllowedOrganizations { get; set; }

    /// <summary>
    /// The editor_role_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EditorRoleValues is required")]
    [TerraformProperty("editor_role_values")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? EditorRoleValues { get; set; }

    /// <summary>
    /// The email_assertion attribute.
    /// </summary>
    [TerraformProperty("email_assertion")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EmailAssertion { get; set; }

    /// <summary>
    /// The groups_assertion attribute.
    /// </summary>
    [TerraformProperty("groups_assertion")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? GroupsAssertion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The idp_metadata_url attribute.
    /// </summary>
    [TerraformProperty("idp_metadata_url")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IdpMetadataUrl { get; set; }

    /// <summary>
    /// The idp_metadata_xml attribute.
    /// </summary>
    [TerraformProperty("idp_metadata_xml")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IdpMetadataXml { get; set; }

    /// <summary>
    /// The login_assertion attribute.
    /// </summary>
    [TerraformProperty("login_assertion")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> LoginAssertion { get; set; }

    /// <summary>
    /// The login_validity_duration attribute.
    /// </summary>
    [TerraformProperty("login_validity_duration")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> LoginValidityDuration { get; set; }

    /// <summary>
    /// The name_assertion attribute.
    /// </summary>
    [TerraformProperty("name_assertion")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NameAssertion { get; set; }

    /// <summary>
    /// The org_assertion attribute.
    /// </summary>
    [TerraformProperty("org_assertion")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OrgAssertion { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_assertion attribute.
    /// </summary>
    [TerraformProperty("role_assertion")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RoleAssertion { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformProperty("workspace_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsGrafanaWorkspaceSamlConfigurationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
