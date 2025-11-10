using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for high_availability_config in .
/// Nesting mode: list
/// </summary>
public class AwsM2EnvironmentHighAvailabilityConfigBlock : TerraformBlock
{
    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredCapacity is required")]
    public required TerraformProperty<double> DesiredCapacity
    {
        get => GetRequiredProperty<TerraformProperty<double>>("desired_capacity");
        set => WithProperty("desired_capacity", value);
    }

}

/// <summary>
/// Block type for storage_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsM2EnvironmentStorageConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsM2EnvironmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_m2_environment resource.
/// </summary>
public class AwsM2Environment : TerraformResource
{
    public AwsM2Environment(string name) : base("aws_m2_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("environment_id");
        this.WithOutput("id");
        this.WithOutput("load_balancer_arn");
        this.WithOutput("tags_all");
    }

    /// <summary>
    /// The apply_changes_during_maintenance_window attribute.
    /// </summary>
    public TerraformProperty<bool>? ApplyChangesDuringMaintenanceWindow
    {
        get => GetProperty<TerraformProperty<bool>>("apply_changes_during_maintenance_window");
        set => this.WithProperty("apply_changes_during_maintenance_window", value);
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
    /// The engine_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineType is required")]
    public required TerraformProperty<string> EngineType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("engine_type");
        set => this.WithProperty("engine_type", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string>? EngineVersion
    {
        get => GetProperty<TerraformProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
    }

    /// <summary>
    /// The force_update attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceUpdate
    {
        get => GetProperty<TerraformProperty<bool>>("force_update");
        set => this.WithProperty("force_update", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredMaintenanceWindow
    {
        get => GetProperty<TerraformProperty<string>>("preferred_maintenance_window");
        set => this.WithProperty("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformProperty<bool>? PubliclyAccessible
    {
        get => GetProperty<TerraformProperty<bool>>("publicly_accessible");
        set => this.WithProperty("publicly_accessible", value);
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
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
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
    /// Block for high_availability_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsM2EnvironmentHighAvailabilityConfigBlock>? HighAvailabilityConfig
    {
        get => GetProperty<List<AwsM2EnvironmentHighAvailabilityConfigBlock>>("high_availability_config");
        set => this.WithProperty("high_availability_config", value);
    }

    /// <summary>
    /// Block for storage_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsM2EnvironmentStorageConfigurationBlock>? StorageConfiguration
    {
        get => GetProperty<List<AwsM2EnvironmentStorageConfigurationBlock>>("storage_configuration");
        set => this.WithProperty("storage_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsM2EnvironmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsM2EnvironmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    public TerraformExpression EnvironmentId => this["environment_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    public TerraformExpression LoadBalancerArn => this["load_balancer_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
