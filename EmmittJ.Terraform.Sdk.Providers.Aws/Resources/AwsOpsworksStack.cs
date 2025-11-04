using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_opsworks_stack resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AwsOpsworksStack : TerraformResource
{
    public AwsOpsworksStack(string name) : base("aws_opsworks_stack", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("stack_endpoint");
    }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public string? AgentVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_version")?.Value;
        set => this.WithProperty("agent_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The berkshelf_version attribute.
    /// </summary>
    public string? BerkshelfVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("berkshelf_version")?.Value;
        set => this.WithProperty("berkshelf_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The color attribute.
    /// </summary>
    public string? Color
    {
        get => GetProperty<TerraformLiteralProperty<string>>("color")?.Value;
        set => this.WithProperty("color", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The configuration_manager_name attribute.
    /// </summary>
    public string? ConfigurationManagerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration_manager_name")?.Value;
        set => this.WithProperty("configuration_manager_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The configuration_manager_version attribute.
    /// </summary>
    public string? ConfigurationManagerVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration_manager_version")?.Value;
        set => this.WithProperty("configuration_manager_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_json attribute.
    /// </summary>
    public string? CustomJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_json")?.Value;
        set => this.WithProperty("custom_json", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_availability_zone attribute.
    /// </summary>
    public string? DefaultAvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_availability_zone")?.Value;
        set => this.WithProperty("default_availability_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_instance_profile_arn attribute.
    /// </summary>
    public string? DefaultInstanceProfileArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_instance_profile_arn")?.Value;
        set => this.WithProperty("default_instance_profile_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_os attribute.
    /// </summary>
    public string? DefaultOs
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_os")?.Value;
        set => this.WithProperty("default_os", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_root_device_type attribute.
    /// </summary>
    public string? DefaultRootDeviceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_root_device_type")?.Value;
        set => this.WithProperty("default_root_device_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_ssh_key_name attribute.
    /// </summary>
    public string? DefaultSshKeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_ssh_key_name")?.Value;
        set => this.WithProperty("default_ssh_key_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_subnet_id attribute.
    /// </summary>
    public string? DefaultSubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_subnet_id")?.Value;
        set => this.WithProperty("default_subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hostname_theme attribute.
    /// </summary>
    public string? HostnameTheme
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hostname_theme")?.Value;
        set => this.WithProperty("hostname_theme", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The manage_berkshelf attribute.
    /// </summary>
    public bool? ManageBerkshelf
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("manage_berkshelf")?.Value;
        set => this.WithProperty("manage_berkshelf", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The region attribute.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    public string? ServiceRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_role_arn")?.Value;
        set => this.WithProperty("service_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The use_custom_cookbooks attribute.
    /// </summary>
    public bool? UseCustomCookbooks
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_custom_cookbooks")?.Value;
        set => this.WithProperty("use_custom_cookbooks", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The use_opsworks_security_groups attribute.
    /// </summary>
    public bool? UseOpsworksSecurityGroups
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_opsworks_security_groups")?.Value;
        set => this.WithProperty("use_opsworks_security_groups", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public string? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id")?.Value;
        set => this.WithProperty("vpc_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The stack_endpoint attribute.
    /// </summary>
    public TerraformExpression StackEndpoint => this["stack_endpoint"];

}
