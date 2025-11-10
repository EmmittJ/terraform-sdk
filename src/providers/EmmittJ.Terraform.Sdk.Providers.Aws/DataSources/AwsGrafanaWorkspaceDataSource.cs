using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_grafana_workspace.
/// </summary>
public class AwsGrafanaWorkspaceDataSource : TerraformDataSource
{
    public AwsGrafanaWorkspaceDataSource(string name) : base("aws_grafana_workspace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("account_access_type");
        SetOutput("arn");
        SetOutput("authentication_providers");
        SetOutput("created_date");
        SetOutput("data_sources");
        SetOutput("description");
        SetOutput("endpoint");
        SetOutput("grafana_version");
        SetOutput("last_updated_date");
        SetOutput("name");
        SetOutput("notification_destinations");
        SetOutput("organization_role_name");
        SetOutput("organizational_units");
        SetOutput("permission_type");
        SetOutput("role_arn");
        SetOutput("saml_configuration_status");
        SetOutput("stack_set_name");
        SetOutput("status");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("workspace_id");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
    /// The account_access_type attribute.
    /// </summary>
    public TerraformExpression AccountAccessType => this["account_access_type"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The authentication_providers attribute.
    /// </summary>
    public TerraformExpression AuthenticationProviders => this["authentication_providers"];

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    public TerraformExpression DataSources => this["data_sources"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The grafana_version attribute.
    /// </summary>
    public TerraformExpression GrafanaVersion => this["grafana_version"];

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformExpression LastUpdatedDate => this["last_updated_date"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The notification_destinations attribute.
    /// </summary>
    public TerraformExpression NotificationDestinations => this["notification_destinations"];

    /// <summary>
    /// The organization_role_name attribute.
    /// </summary>
    public TerraformExpression OrganizationRoleName => this["organization_role_name"];

    /// <summary>
    /// The organizational_units attribute.
    /// </summary>
    public TerraformExpression OrganizationalUnits => this["organizational_units"];

    /// <summary>
    /// The permission_type attribute.
    /// </summary>
    public TerraformExpression PermissionType => this["permission_type"];

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformExpression RoleArn => this["role_arn"];

    /// <summary>
    /// The saml_configuration_status attribute.
    /// </summary>
    public TerraformExpression SamlConfigurationStatus => this["saml_configuration_status"];

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    public TerraformExpression StackSetName => this["stack_set_name"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
