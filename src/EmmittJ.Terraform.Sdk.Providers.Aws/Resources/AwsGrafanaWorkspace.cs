using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for network_access_control in .
/// Nesting mode: list
/// </summary>
public class AwsGrafanaWorkspaceNetworkAccessControlBlock : TerraformBlock
{
    /// <summary>
    /// The prefix_list_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrefixListIds is required")]
    public HashSet<TerraformProperty<string>>? PrefixListIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("prefix_list_ids");
        set => WithProperty("prefix_list_ids", value);
    }

    /// <summary>
    /// The vpce_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpceIds is required")]
    public HashSet<TerraformProperty<string>>? VpceIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vpce_ids");
        set => WithProperty("vpce_ids", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGrafanaWorkspaceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for vpc_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsGrafanaWorkspaceVpcConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => WithProperty("subnet_ids", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountAccessType is required")]
    public required TerraformProperty<string> AccountAccessType
    {
        get => GetProperty<TerraformProperty<string>>("account_access_type");
        set => this.WithProperty("account_access_type", value);
    }

    /// <summary>
    /// The authentication_providers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationProviders is required")]
    public List<TerraformProperty<string>>? AuthenticationProviders
    {
        get => GetProperty<List<TerraformProperty<string>>>("authentication_providers");
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
    public List<TerraformProperty<string>>? DataSources
    {
        get => GetProperty<List<TerraformProperty<string>>>("data_sources");
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
    public List<TerraformProperty<string>>? NotificationDestinations
    {
        get => GetProperty<List<TerraformProperty<string>>>("notification_destinations");
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
    public List<TerraformProperty<string>>? OrganizationalUnits
    {
        get => GetProperty<List<TerraformProperty<string>>>("organizational_units");
        set => this.WithProperty("organizational_units", value);
    }

    /// <summary>
    /// The permission_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionType is required")]
    public required TerraformProperty<string> PermissionType
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for network_access_control.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAccessControl block(s) allowed")]
    public List<AwsGrafanaWorkspaceNetworkAccessControlBlock>? NetworkAccessControl
    {
        get => GetProperty<List<AwsGrafanaWorkspaceNetworkAccessControlBlock>>("network_access_control");
        set => this.WithProperty("network_access_control", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGrafanaWorkspaceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsGrafanaWorkspaceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfiguration block(s) allowed")]
    public List<AwsGrafanaWorkspaceVpcConfigurationBlock>? VpcConfiguration
    {
        get => GetProperty<List<AwsGrafanaWorkspaceVpcConfigurationBlock>>("vpc_configuration");
        set => this.WithProperty("vpc_configuration", value);
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
