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
    public TerraformLiteralProperty<string>? AccountAccessType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_access_type");
        set => this.WithProperty("account_access_type", value);
    }

    /// <summary>
    /// The authentication_providers attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? AuthenticationProviders
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("authentication_providers");
        set => this.WithProperty("authentication_providers", value);
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Configuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration");
        set => this.WithProperty("configuration", value);
    }

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? DataSources
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("data_sources");
        set => this.WithProperty("data_sources", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The grafana_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GrafanaVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("grafana_version");
        set => this.WithProperty("grafana_version", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The notification_destinations attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? NotificationDestinations
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("notification_destinations");
        set => this.WithProperty("notification_destinations", value);
    }

    /// <summary>
    /// The organization_role_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OrganizationRoleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organization_role_name");
        set => this.WithProperty("organization_role_name", value);
    }

    /// <summary>
    /// The organizational_units attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? OrganizationalUnits
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("organizational_units");
        set => this.WithProperty("organizational_units", value);
    }

    /// <summary>
    /// The permission_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PermissionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("permission_type");
        set => this.WithProperty("permission_type", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StackSetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stack_set_name");
        set => this.WithProperty("stack_set_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
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
