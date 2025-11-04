using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_grafana_workspace_saml_configuration resource.
/// </summary>
public class AwsGrafanaWorkspaceSamlConfiguration : TerraformResource
{
    public AwsGrafanaWorkspaceSamlConfiguration(string name) : base("aws_grafana_workspace_saml_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The admin_role_values attribute.
    /// </summary>
    public List<string>? AdminRoleValues
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("admin_role_values")?.Value;
        set => this.WithProperty("admin_role_values", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The allowed_organizations attribute.
    /// </summary>
    public List<string>? AllowedOrganizations
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("allowed_organizations")?.Value;
        set => this.WithProperty("allowed_organizations", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The editor_role_values attribute.
    /// </summary>
    public List<string>? EditorRoleValues
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("editor_role_values")?.Value;
        set => this.WithProperty("editor_role_values", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The email_assertion attribute.
    /// </summary>
    public string? EmailAssertion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_assertion")?.Value;
        set => this.WithProperty("email_assertion", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The groups_assertion attribute.
    /// </summary>
    public string? GroupsAssertion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("groups_assertion")?.Value;
        set => this.WithProperty("groups_assertion", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The idp_metadata_url attribute.
    /// </summary>
    public string? IdpMetadataUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("idp_metadata_url")?.Value;
        set => this.WithProperty("idp_metadata_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The idp_metadata_xml attribute.
    /// </summary>
    public string? IdpMetadataXml
    {
        get => GetProperty<TerraformLiteralProperty<string>>("idp_metadata_xml")?.Value;
        set => this.WithProperty("idp_metadata_xml", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The login_assertion attribute.
    /// </summary>
    public string? LoginAssertion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("login_assertion")?.Value;
        set => this.WithProperty("login_assertion", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The login_validity_duration attribute.
    /// </summary>
    public double? LoginValidityDuration
    {
        get => GetProperty<TerraformLiteralProperty<double>>("login_validity_duration")?.Value;
        set => this.WithProperty("login_validity_duration", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name_assertion attribute.
    /// </summary>
    public string? NameAssertion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_assertion")?.Value;
        set => this.WithProperty("name_assertion", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The org_assertion attribute.
    /// </summary>
    public string? OrgAssertion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_assertion")?.Value;
        set => this.WithProperty("org_assertion", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_assertion attribute.
    /// </summary>
    public string? RoleAssertion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_assertion")?.Value;
        set => this.WithProperty("role_assertion", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
