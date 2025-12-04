using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_grafana_workspace Terraform data source.
/// Retrieves information about a aws_grafana_workspace.
/// </summary>
public partial class AwsGrafanaWorkspaceDataSource(string name) : TerraformDataSource("aws_grafana_workspace", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The account_access_type attribute.
    /// </summary>
    public TerraformValue<string> AccountAccessType
        => AsReference("account_access_type");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The authentication_providers attribute.
    /// </summary>
    public TerraformList<string> AuthenticationProviders
        => AsReference("authentication_providers");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
        => AsReference("created_date");

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    public TerraformList<string> DataSources
        => AsReference("data_sources");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The grafana_version attribute.
    /// </summary>
    public TerraformValue<string> GrafanaVersion
        => AsReference("grafana_version");

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedDate
        => AsReference("last_updated_date");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The notification_destinations attribute.
    /// </summary>
    public TerraformList<string> NotificationDestinations
        => AsReference("notification_destinations");

    /// <summary>
    /// The organization_role_name attribute.
    /// </summary>
    public TerraformValue<string> OrganizationRoleName
        => AsReference("organization_role_name");

    /// <summary>
    /// The organizational_units attribute.
    /// </summary>
    public TerraformList<string> OrganizationalUnits
        => AsReference("organizational_units");

    /// <summary>
    /// The permission_type attribute.
    /// </summary>
    public TerraformValue<string> PermissionType
        => AsReference("permission_type");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
        => AsReference("role_arn");

    /// <summary>
    /// The saml_configuration_status attribute.
    /// </summary>
    public TerraformValue<string> SamlConfigurationStatus
        => AsReference("saml_configuration_status");

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    public TerraformValue<string> StackSetName
        => AsReference("stack_set_name");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

}
