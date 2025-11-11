using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGrafanaWorkspaceSamlConfigurationTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_grafana_workspace_saml_configuration resource.
/// </summary>
public class AwsGrafanaWorkspaceSamlConfiguration : TerraformResource
{
    public AwsGrafanaWorkspaceSamlConfiguration(string name) : base("aws_grafana_workspace_saml_configuration", name)
    {
    }

    /// <summary>
    /// The admin_role_values attribute.
    /// </summary>
    [TerraformPropertyName("admin_role_values")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AdminRoleValues { get; set; }

    /// <summary>
    /// The allowed_organizations attribute.
    /// </summary>
    [TerraformPropertyName("allowed_organizations")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AllowedOrganizations { get; set; }

    /// <summary>
    /// The editor_role_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EditorRoleValues is required")]
    [TerraformPropertyName("editor_role_values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? EditorRoleValues { get; set; }

    /// <summary>
    /// The email_assertion attribute.
    /// </summary>
    [TerraformPropertyName("email_assertion")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EmailAssertion { get; set; } = default!;

    /// <summary>
    /// The groups_assertion attribute.
    /// </summary>
    [TerraformPropertyName("groups_assertion")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GroupsAssertion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The idp_metadata_url attribute.
    /// </summary>
    [TerraformPropertyName("idp_metadata_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IdpMetadataUrl { get; set; }

    /// <summary>
    /// The idp_metadata_xml attribute.
    /// </summary>
    [TerraformPropertyName("idp_metadata_xml")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IdpMetadataXml { get; set; }

    /// <summary>
    /// The login_assertion attribute.
    /// </summary>
    [TerraformPropertyName("login_assertion")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LoginAssertion { get; set; } = default!;

    /// <summary>
    /// The login_validity_duration attribute.
    /// </summary>
    [TerraformPropertyName("login_validity_duration")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> LoginValidityDuration { get; set; } = default!;

    /// <summary>
    /// The name_assertion attribute.
    /// </summary>
    [TerraformPropertyName("name_assertion")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NameAssertion { get; set; } = default!;

    /// <summary>
    /// The org_assertion attribute.
    /// </summary>
    [TerraformPropertyName("org_assertion")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OrgAssertion { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role_assertion attribute.
    /// </summary>
    [TerraformPropertyName("role_assertion")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RoleAssertion { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformPropertyName("workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsGrafanaWorkspaceSamlConfigurationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
