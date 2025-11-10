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
        set => SetProperty("prefix_list_ids", value);
    }

    /// <summary>
    /// The vpce_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpceIds is required")]
    public HashSet<TerraformProperty<string>>? VpceIds
    {
        set => SetProperty("vpce_ids", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
    }

}

/// <summary>
/// Manages a aws_grafana_workspace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGrafanaWorkspace : TerraformResource
{
    public AwsGrafanaWorkspace(string name) : base("aws_grafana_workspace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("endpoint");
        SetOutput("saml_configuration_status");
        SetOutput("account_access_type");
        SetOutput("authentication_providers");
        SetOutput("configuration");
        SetOutput("data_sources");
        SetOutput("description");
        SetOutput("grafana_version");
        SetOutput("id");
        SetOutput("name");
        SetOutput("notification_destinations");
        SetOutput("organization_role_name");
        SetOutput("organizational_units");
        SetOutput("permission_type");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("stack_set_name");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The account_access_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountAccessType is required")]
    public required TerraformProperty<string> AccountAccessType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_access_type");
        set => SetProperty("account_access_type", value);
    }

    /// <summary>
    /// The authentication_providers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationProviders is required")]
    public List<TerraformProperty<string>> AuthenticationProviders
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("authentication_providers");
        set => SetProperty("authentication_providers", value);
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformProperty<string> Configuration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("configuration");
        set => SetProperty("configuration", value);
    }

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    public List<TerraformProperty<string>> DataSources
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("data_sources");
        set => SetProperty("data_sources", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The grafana_version attribute.
    /// </summary>
    public TerraformProperty<string> GrafanaVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("grafana_version");
        set => SetProperty("grafana_version", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The notification_destinations attribute.
    /// </summary>
    public List<TerraformProperty<string>> NotificationDestinations
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("notification_destinations");
        set => SetProperty("notification_destinations", value);
    }

    /// <summary>
    /// The organization_role_name attribute.
    /// </summary>
    public TerraformProperty<string> OrganizationRoleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("organization_role_name");
        set => SetProperty("organization_role_name", value);
    }

    /// <summary>
    /// The organizational_units attribute.
    /// </summary>
    public List<TerraformProperty<string>> OrganizationalUnits
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("organizational_units");
        set => SetProperty("organizational_units", value);
    }

    /// <summary>
    /// The permission_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionType is required")]
    public required TerraformProperty<string> PermissionType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("permission_type");
        set => SetProperty("permission_type", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    public TerraformProperty<string> StackSetName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stack_set_name");
        set => SetProperty("stack_set_name", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for network_access_control.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAccessControl block(s) allowed")]
    public List<AwsGrafanaWorkspaceNetworkAccessControlBlock>? NetworkAccessControl
    {
        set => SetProperty("network_access_control", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGrafanaWorkspaceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfiguration block(s) allowed")]
    public List<AwsGrafanaWorkspaceVpcConfigurationBlock>? VpcConfiguration
    {
        set => SetProperty("vpc_configuration", value);
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
