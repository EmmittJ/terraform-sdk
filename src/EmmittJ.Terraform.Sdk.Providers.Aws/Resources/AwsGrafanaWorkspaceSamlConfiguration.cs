using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGrafanaWorkspaceSamlConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

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
    public List<TerraformProperty<string>>? AdminRoleValues
    {
        get => GetProperty<List<TerraformProperty<string>>>("admin_role_values");
        set => this.WithProperty("admin_role_values", value);
    }

    /// <summary>
    /// The allowed_organizations attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AllowedOrganizations
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_organizations");
        set => this.WithProperty("allowed_organizations", value);
    }

    /// <summary>
    /// The editor_role_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EditorRoleValues is required")]
    public List<TerraformProperty<string>>? EditorRoleValues
    {
        get => GetProperty<List<TerraformProperty<string>>>("editor_role_values");
        set => this.WithProperty("editor_role_values", value);
    }

    /// <summary>
    /// The email_assertion attribute.
    /// </summary>
    public TerraformProperty<string>? EmailAssertion
    {
        get => GetProperty<TerraformProperty<string>>("email_assertion");
        set => this.WithProperty("email_assertion", value);
    }

    /// <summary>
    /// The groups_assertion attribute.
    /// </summary>
    public TerraformProperty<string>? GroupsAssertion
    {
        get => GetProperty<TerraformProperty<string>>("groups_assertion");
        set => this.WithProperty("groups_assertion", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The idp_metadata_url attribute.
    /// </summary>
    public TerraformProperty<string>? IdpMetadataUrl
    {
        get => GetProperty<TerraformProperty<string>>("idp_metadata_url");
        set => this.WithProperty("idp_metadata_url", value);
    }

    /// <summary>
    /// The idp_metadata_xml attribute.
    /// </summary>
    public TerraformProperty<string>? IdpMetadataXml
    {
        get => GetProperty<TerraformProperty<string>>("idp_metadata_xml");
        set => this.WithProperty("idp_metadata_xml", value);
    }

    /// <summary>
    /// The login_assertion attribute.
    /// </summary>
    public TerraformProperty<string>? LoginAssertion
    {
        get => GetProperty<TerraformProperty<string>>("login_assertion");
        set => this.WithProperty("login_assertion", value);
    }

    /// <summary>
    /// The login_validity_duration attribute.
    /// </summary>
    public TerraformProperty<double>? LoginValidityDuration
    {
        get => GetProperty<TerraformProperty<double>>("login_validity_duration");
        set => this.WithProperty("login_validity_duration", value);
    }

    /// <summary>
    /// The name_assertion attribute.
    /// </summary>
    public TerraformProperty<string>? NameAssertion
    {
        get => GetProperty<TerraformProperty<string>>("name_assertion");
        set => this.WithProperty("name_assertion", value);
    }

    /// <summary>
    /// The org_assertion attribute.
    /// </summary>
    public TerraformProperty<string>? OrgAssertion
    {
        get => GetProperty<TerraformProperty<string>>("org_assertion");
        set => this.WithProperty("org_assertion", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role_assertion attribute.
    /// </summary>
    public TerraformProperty<string>? RoleAssertion
    {
        get => GetProperty<TerraformProperty<string>>("role_assertion");
        set => this.WithProperty("role_assertion", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGrafanaWorkspaceSamlConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsGrafanaWorkspaceSamlConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
