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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
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
        SetOutput("status");
        SetOutput("admin_role_values");
        SetOutput("allowed_organizations");
        SetOutput("editor_role_values");
        SetOutput("email_assertion");
        SetOutput("groups_assertion");
        SetOutput("id");
        SetOutput("idp_metadata_url");
        SetOutput("idp_metadata_xml");
        SetOutput("login_assertion");
        SetOutput("login_validity_duration");
        SetOutput("name_assertion");
        SetOutput("org_assertion");
        SetOutput("region");
        SetOutput("role_assertion");
        SetOutput("workspace_id");
    }

    /// <summary>
    /// The admin_role_values attribute.
    /// </summary>
    public List<TerraformProperty<string>> AdminRoleValues
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("admin_role_values");
        set => SetProperty("admin_role_values", value);
    }

    /// <summary>
    /// The allowed_organizations attribute.
    /// </summary>
    public List<TerraformProperty<string>> AllowedOrganizations
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("allowed_organizations");
        set => SetProperty("allowed_organizations", value);
    }

    /// <summary>
    /// The editor_role_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EditorRoleValues is required")]
    public List<TerraformProperty<string>> EditorRoleValues
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("editor_role_values");
        set => SetProperty("editor_role_values", value);
    }

    /// <summary>
    /// The email_assertion attribute.
    /// </summary>
    public TerraformProperty<string> EmailAssertion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email_assertion");
        set => SetProperty("email_assertion", value);
    }

    /// <summary>
    /// The groups_assertion attribute.
    /// </summary>
    public TerraformProperty<string> GroupsAssertion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("groups_assertion");
        set => SetProperty("groups_assertion", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The idp_metadata_url attribute.
    /// </summary>
    public TerraformProperty<string> IdpMetadataUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("idp_metadata_url");
        set => SetProperty("idp_metadata_url", value);
    }

    /// <summary>
    /// The idp_metadata_xml attribute.
    /// </summary>
    public TerraformProperty<string> IdpMetadataXml
    {
        get => GetRequiredOutput<TerraformProperty<string>>("idp_metadata_xml");
        set => SetProperty("idp_metadata_xml", value);
    }

    /// <summary>
    /// The login_assertion attribute.
    /// </summary>
    public TerraformProperty<string> LoginAssertion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("login_assertion");
        set => SetProperty("login_assertion", value);
    }

    /// <summary>
    /// The login_validity_duration attribute.
    /// </summary>
    public TerraformProperty<double> LoginValidityDuration
    {
        get => GetRequiredOutput<TerraformProperty<double>>("login_validity_duration");
        set => SetProperty("login_validity_duration", value);
    }

    /// <summary>
    /// The name_assertion attribute.
    /// </summary>
    public TerraformProperty<string> NameAssertion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_assertion");
        set => SetProperty("name_assertion", value);
    }

    /// <summary>
    /// The org_assertion attribute.
    /// </summary>
    public TerraformProperty<string> OrgAssertion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("org_assertion");
        set => SetProperty("org_assertion", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The role_assertion attribute.
    /// </summary>
    public TerraformProperty<string> RoleAssertion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_assertion");
        set => SetProperty("role_assertion", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workspace_id");
        set => SetProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGrafanaWorkspaceSamlConfigurationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
