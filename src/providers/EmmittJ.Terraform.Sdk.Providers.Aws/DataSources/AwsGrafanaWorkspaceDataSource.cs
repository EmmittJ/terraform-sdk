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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The account_access_type attribute.
    /// </summary>
    public TerraformValue<string> AccountAccessType
    {
        get => new TerraformReference<string>(this, "account_access_type");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The authentication_providers attribute.
    /// </summary>
    public TerraformList<string> AuthenticationProviders
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "authentication_providers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
    {
        get => new TerraformReference<string>(this, "created_date");
    }

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    public TerraformList<string> DataSources
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "data_sources").ResolveNodes(ctx));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The grafana_version attribute.
    /// </summary>
    public TerraformValue<string> GrafanaVersion
    {
        get => new TerraformReference<string>(this, "grafana_version");
    }

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedDate
    {
        get => new TerraformReference<string>(this, "last_updated_date");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The notification_destinations attribute.
    /// </summary>
    public TerraformList<string> NotificationDestinations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "notification_destinations").ResolveNodes(ctx));
    }

    /// <summary>
    /// The organization_role_name attribute.
    /// </summary>
    public TerraformValue<string> OrganizationRoleName
    {
        get => new TerraformReference<string>(this, "organization_role_name");
    }

    /// <summary>
    /// The organizational_units attribute.
    /// </summary>
    public TerraformList<string> OrganizationalUnits
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "organizational_units").ResolveNodes(ctx));
    }

    /// <summary>
    /// The permission_type attribute.
    /// </summary>
    public TerraformValue<string> PermissionType
    {
        get => new TerraformReference<string>(this, "permission_type");
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
    }

    /// <summary>
    /// The saml_configuration_status attribute.
    /// </summary>
    public TerraformValue<string> SamlConfigurationStatus
    {
        get => new TerraformReference<string>(this, "saml_configuration_status");
    }

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    public TerraformValue<string> StackSetName
    {
        get => new TerraformReference<string>(this, "stack_set_name");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
