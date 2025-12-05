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
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
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
    /// The account_access_type attribute.
    /// </summary>
    public TerraformValue<string> AccountAccessType
        => CreateReference("account_access_type");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The authentication_providers attribute.
    /// </summary>
    public TerraformList<string> AuthenticationProviders
        => CreateReference("authentication_providers");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
        => CreateReference("created_date");

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    public TerraformList<string> DataSources
        => CreateReference("data_sources");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => CreateReference("endpoint");

    /// <summary>
    /// The grafana_version attribute.
    /// </summary>
    public TerraformValue<string> GrafanaVersion
        => CreateReference("grafana_version");

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedDate
        => CreateReference("last_updated_date");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The notification_destinations attribute.
    /// </summary>
    public TerraformList<string> NotificationDestinations
        => CreateReference("notification_destinations");

    /// <summary>
    /// The organization_role_name attribute.
    /// </summary>
    public TerraformValue<string> OrganizationRoleName
        => CreateReference("organization_role_name");

    /// <summary>
    /// The organizational_units attribute.
    /// </summary>
    public TerraformList<string> OrganizationalUnits
        => CreateReference("organizational_units");

    /// <summary>
    /// The permission_type attribute.
    /// </summary>
    public TerraformValue<string> PermissionType
        => CreateReference("permission_type");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
        => CreateReference("role_arn");

    /// <summary>
    /// The saml_configuration_status attribute.
    /// </summary>
    public TerraformValue<string> SamlConfigurationStatus
        => CreateReference("saml_configuration_status");

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    public TerraformValue<string> StackSetName
        => CreateReference("stack_set_name");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

}
