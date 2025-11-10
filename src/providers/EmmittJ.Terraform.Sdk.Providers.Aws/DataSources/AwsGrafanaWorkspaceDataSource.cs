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
        this.DeclareOutput("account_access_type");
        this.DeclareOutput("arn");
        this.DeclareOutput("authentication_providers");
        this.DeclareOutput("created_date");
        this.DeclareOutput("data_sources");
        this.DeclareOutput("description");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("grafana_version");
        this.DeclareOutput("last_updated_date");
        this.DeclareOutput("name");
        this.DeclareOutput("notification_destinations");
        this.DeclareOutput("organization_role_name");
        this.DeclareOutput("organizational_units");
        this.DeclareOutput("permission_type");
        this.DeclareOutput("role_arn");
        this.DeclareOutput("saml_configuration_status");
        this.DeclareOutput("stack_set_name");
        this.DeclareOutput("status");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
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
