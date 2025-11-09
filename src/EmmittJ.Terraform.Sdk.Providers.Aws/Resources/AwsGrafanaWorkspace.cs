using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_grafana_workspace resource.
/// </summary>
public class AwsGrafanaWorkspace : TerraformResource
{
    public AwsGrafanaWorkspace(string name) : base("aws_grafana_workspace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("saml_configuration_status");
    }

    /// <summary>
    /// The account_access_type attribute.
    /// </summary>
    public TerraformProperty<string>? AccountAccessType
    {
        get => GetProperty<TerraformProperty<string>>("account_access_type");
        set => this.WithProperty("account_access_type", value);
    }

    /// <summary>
    /// The authentication_providers attribute.
    /// </summary>
    public TerraformProperty<List<string>>? AuthenticationProviders
    {
        get => GetProperty<TerraformProperty<List<string>>>("authentication_providers");
        set => this.WithProperty("authentication_providers", value);
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformProperty<string>? Configuration
    {
        get => GetProperty<TerraformProperty<string>>("configuration");
        set => this.WithProperty("configuration", value);
    }

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    public TerraformProperty<List<string>>? DataSources
    {
        get => GetProperty<TerraformProperty<List<string>>>("data_sources");
        set => this.WithProperty("data_sources", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The grafana_version attribute.
    /// </summary>
    public TerraformProperty<string>? GrafanaVersion
    {
        get => GetProperty<TerraformProperty<string>>("grafana_version");
        set => this.WithProperty("grafana_version", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The notification_destinations attribute.
    /// </summary>
    public TerraformProperty<List<string>>? NotificationDestinations
    {
        get => GetProperty<TerraformProperty<List<string>>>("notification_destinations");
        set => this.WithProperty("notification_destinations", value);
    }

    /// <summary>
    /// The organization_role_name attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationRoleName
    {
        get => GetProperty<TerraformProperty<string>>("organization_role_name");
        set => this.WithProperty("organization_role_name", value);
    }

    /// <summary>
    /// The organizational_units attribute.
    /// </summary>
    public TerraformProperty<List<string>>? OrganizationalUnits
    {
        get => GetProperty<TerraformProperty<List<string>>>("organizational_units");
        set => this.WithProperty("organizational_units", value);
    }

    /// <summary>
    /// The permission_type attribute.
    /// </summary>
    public TerraformProperty<string>? PermissionType
    {
        get => GetProperty<TerraformProperty<string>>("permission_type");
        set => this.WithProperty("permission_type", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    public TerraformProperty<string>? StackSetName
    {
        get => GetProperty<TerraformProperty<string>>("stack_set_name");
        set => this.WithProperty("stack_set_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The saml_configuration_status attribute.
    /// </summary>
    public TerraformExpression SamlConfigurationStatus => this["saml_configuration_status"];

}
