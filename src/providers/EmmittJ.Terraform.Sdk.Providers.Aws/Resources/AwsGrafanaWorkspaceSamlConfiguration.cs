using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGrafanaWorkspaceSamlConfigurationTimeoutsBlock : ITerraformBlock
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
    public TerraformProperty<List<TerraformProperty<string>>>? AdminRoleValues { get; set; }

    /// <summary>
    /// The allowed_organizations attribute.
    /// </summary>
    [TerraformPropertyName("allowed_organizations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AllowedOrganizations { get; set; }

    /// <summary>
    /// The editor_role_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EditorRoleValues is required")]
    [TerraformPropertyName("editor_role_values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? EditorRoleValues { get; set; }

    /// <summary>
    /// The email_assertion attribute.
    /// </summary>
    [TerraformPropertyName("email_assertion")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EmailAssertion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "email_assertion");

    /// <summary>
    /// The groups_assertion attribute.
    /// </summary>
    [TerraformPropertyName("groups_assertion")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GroupsAssertion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The idp_metadata_url attribute.
    /// </summary>
    [TerraformPropertyName("idp_metadata_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IdpMetadataUrl { get; set; }

    /// <summary>
    /// The idp_metadata_xml attribute.
    /// </summary>
    [TerraformPropertyName("idp_metadata_xml")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IdpMetadataXml { get; set; }

    /// <summary>
    /// The login_assertion attribute.
    /// </summary>
    [TerraformPropertyName("login_assertion")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LoginAssertion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "login_assertion");

    /// <summary>
    /// The login_validity_duration attribute.
    /// </summary>
    [TerraformPropertyName("login_validity_duration")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> LoginValidityDuration { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "login_validity_duration");

    /// <summary>
    /// The name_assertion attribute.
    /// </summary>
    [TerraformPropertyName("name_assertion")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NameAssertion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name_assertion");

    /// <summary>
    /// The org_assertion attribute.
    /// </summary>
    [TerraformPropertyName("org_assertion")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OrgAssertion { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The role_assertion attribute.
    /// </summary>
    [TerraformPropertyName("role_assertion")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RoleAssertion { get; set; }

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
    public TerraformBlock<AwsGrafanaWorkspaceSamlConfigurationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
