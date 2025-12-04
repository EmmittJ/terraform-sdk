using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsGrafanaWorkspaceSamlConfiguration.
/// Nesting mode: single
/// </summary>
public class AwsGrafanaWorkspaceSamlConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_grafana_workspace_saml_configuration Terraform resource.
/// Manages a aws_grafana_workspace_saml_configuration resource.
/// </summary>
public partial class AwsGrafanaWorkspaceSamlConfiguration(string name) : TerraformResource("aws_grafana_workspace_saml_configuration", name)
{
    /// <summary>
    /// The admin_role_values attribute.
    /// </summary>
    public TerraformList<string>? AdminRoleValues
    {
        get => GetArgument<TerraformList<string>>("admin_role_values");
        set => SetArgument("admin_role_values", value);
    }

    /// <summary>
    /// The allowed_organizations attribute.
    /// </summary>
    public TerraformList<string>? AllowedOrganizations
    {
        get => GetArgument<TerraformList<string>>("allowed_organizations");
        set => SetArgument("allowed_organizations", value);
    }

    /// <summary>
    /// The editor_role_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EditorRoleValues is required")]
    public TerraformList<string>? EditorRoleValues
    {
        get => GetArgument<TerraformList<string>>("editor_role_values");
        set => SetArgument("editor_role_values", value);
    }

    /// <summary>
    /// The email_assertion attribute.
    /// </summary>
    public TerraformValue<string> EmailAssertion
    {
        get => GetArgument<TerraformValue<string>>("email_assertion") ?? AsReference("email_assertion");
        set => SetArgument("email_assertion", value);
    }

    /// <summary>
    /// The groups_assertion attribute.
    /// </summary>
    public TerraformValue<string>? GroupsAssertion
    {
        get => GetArgument<TerraformValue<string>>("groups_assertion");
        set => SetArgument("groups_assertion", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The idp_metadata_url attribute.
    /// </summary>
    public TerraformValue<string>? IdpMetadataUrl
    {
        get => GetArgument<TerraformValue<string>>("idp_metadata_url");
        set => SetArgument("idp_metadata_url", value);
    }

    /// <summary>
    /// The idp_metadata_xml attribute.
    /// </summary>
    public TerraformValue<string>? IdpMetadataXml
    {
        get => GetArgument<TerraformValue<string>>("idp_metadata_xml");
        set => SetArgument("idp_metadata_xml", value);
    }

    /// <summary>
    /// The login_assertion attribute.
    /// </summary>
    public TerraformValue<string> LoginAssertion
    {
        get => GetArgument<TerraformValue<string>>("login_assertion") ?? AsReference("login_assertion");
        set => SetArgument("login_assertion", value);
    }

    /// <summary>
    /// The login_validity_duration attribute.
    /// </summary>
    public TerraformValue<double> LoginValidityDuration
    {
        get => GetArgument<TerraformValue<double>>("login_validity_duration") ?? AsReference("login_validity_duration");
        set => SetArgument("login_validity_duration", value);
    }

    /// <summary>
    /// The name_assertion attribute.
    /// </summary>
    public TerraformValue<string> NameAssertion
    {
        get => GetArgument<TerraformValue<string>>("name_assertion") ?? AsReference("name_assertion");
        set => SetArgument("name_assertion", value);
    }

    /// <summary>
    /// The org_assertion attribute.
    /// </summary>
    public TerraformValue<string>? OrgAssertion
    {
        get => GetArgument<TerraformValue<string>>("org_assertion");
        set => SetArgument("org_assertion", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_assertion attribute.
    /// </summary>
    public TerraformValue<string>? RoleAssertion
    {
        get => GetArgument<TerraformValue<string>>("role_assertion");
        set => SetArgument("role_assertion", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsGrafanaWorkspaceSamlConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsGrafanaWorkspaceSamlConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
