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
    public string? AccountAccessType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_access_type")?.Value;
        set => this.WithProperty("account_access_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The authentication_providers attribute.
    /// </summary>
    public List<string>? AuthenticationProviders
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("authentication_providers")?.Value;
        set => this.WithProperty("authentication_providers", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public string? Configuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration")?.Value;
        set => this.WithProperty("configuration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    public List<string>? DataSources
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("data_sources")?.Value;
        set => this.WithProperty("data_sources", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The grafana_version attribute.
    /// </summary>
    public string? GrafanaVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("grafana_version")?.Value;
        set => this.WithProperty("grafana_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The notification_destinations attribute.
    /// </summary>
    public List<string>? NotificationDestinations
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("notification_destinations")?.Value;
        set => this.WithProperty("notification_destinations", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The organization_role_name attribute.
    /// </summary>
    public string? OrganizationRoleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organization_role_name")?.Value;
        set => this.WithProperty("organization_role_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The organizational_units attribute.
    /// </summary>
    public List<string>? OrganizationalUnits
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("organizational_units")?.Value;
        set => this.WithProperty("organizational_units", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The permission_type attribute.
    /// </summary>
    public string? PermissionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("permission_type")?.Value;
        set => this.WithProperty("permission_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    public string? StackSetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stack_set_name")?.Value;
        set => this.WithProperty("stack_set_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
