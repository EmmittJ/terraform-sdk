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
    public TerraformLiteralProperty<List<string>>? AdminRoleValues
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("admin_role_values");
        set => this.WithProperty("admin_role_values", value);
    }

    /// <summary>
    /// The allowed_organizations attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? AllowedOrganizations
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("allowed_organizations");
        set => this.WithProperty("allowed_organizations", value);
    }

    /// <summary>
    /// The editor_role_values attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? EditorRoleValues
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("editor_role_values");
        set => this.WithProperty("editor_role_values", value);
    }

    /// <summary>
    /// The email_assertion attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EmailAssertion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_assertion");
        set => this.WithProperty("email_assertion", value);
    }

    /// <summary>
    /// The groups_assertion attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GroupsAssertion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("groups_assertion");
        set => this.WithProperty("groups_assertion", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The idp_metadata_url attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IdpMetadataUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("idp_metadata_url");
        set => this.WithProperty("idp_metadata_url", value);
    }

    /// <summary>
    /// The idp_metadata_xml attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IdpMetadataXml
    {
        get => GetProperty<TerraformLiteralProperty<string>>("idp_metadata_xml");
        set => this.WithProperty("idp_metadata_xml", value);
    }

    /// <summary>
    /// The login_assertion attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LoginAssertion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("login_assertion");
        set => this.WithProperty("login_assertion", value);
    }

    /// <summary>
    /// The login_validity_duration attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? LoginValidityDuration
    {
        get => GetProperty<TerraformLiteralProperty<double>>("login_validity_duration");
        set => this.WithProperty("login_validity_duration", value);
    }

    /// <summary>
    /// The name_assertion attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NameAssertion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_assertion");
        set => this.WithProperty("name_assertion", value);
    }

    /// <summary>
    /// The org_assertion attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OrgAssertion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_assertion");
        set => this.WithProperty("org_assertion", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role_assertion attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RoleAssertion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_assertion");
        set => this.WithProperty("role_assertion", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
