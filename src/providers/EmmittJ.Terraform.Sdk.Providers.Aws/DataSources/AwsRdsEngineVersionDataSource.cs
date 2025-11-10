using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsRdsEngineVersionDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
    }

}

/// <summary>
/// Retrieves information about a aws_rds_engine_version.
/// </summary>
public class AwsRdsEngineVersionDataSource : TerraformDataSource
{
    public AwsRdsEngineVersionDataSource(string name) : base("aws_rds_engine_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("default_character_set");
        SetOutput("engine_description");
        SetOutput("exportable_log_types");
        SetOutput("status");
        SetOutput("supported_character_sets");
        SetOutput("supported_feature_names");
        SetOutput("supported_modes");
        SetOutput("supported_timezones");
        SetOutput("supports_certificate_rotation_without_restart");
        SetOutput("supports_global_databases");
        SetOutput("supports_integrations");
        SetOutput("supports_limitless_database");
        SetOutput("supports_local_write_forwarding");
        SetOutput("supports_log_exports_to_cloudwatch");
        SetOutput("supports_parallel_query");
        SetOutput("supports_read_replica");
        SetOutput("valid_major_targets");
        SetOutput("valid_minor_targets");
        SetOutput("valid_upgrade_targets");
        SetOutput("version_actual");
        SetOutput("version_description");
        SetOutput("default_only");
        SetOutput("engine");
        SetOutput("has_major_target");
        SetOutput("has_minor_target");
        SetOutput("id");
        SetOutput("include_all");
        SetOutput("latest");
        SetOutput("parameter_group_family");
        SetOutput("preferred_major_targets");
        SetOutput("preferred_upgrade_targets");
        SetOutput("preferred_versions");
        SetOutput("region");
        SetOutput("version");
    }

    /// <summary>
    /// The default_only attribute.
    /// </summary>
    public TerraformProperty<bool> DefaultOnly
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("default_only");
        set => SetProperty("default_only", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    public required TerraformProperty<string> Engine
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine");
        set => SetProperty("engine", value);
    }

    /// <summary>
    /// The has_major_target attribute.
    /// </summary>
    public TerraformProperty<bool> HasMajorTarget
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("has_major_target");
        set => SetProperty("has_major_target", value);
    }

    /// <summary>
    /// The has_minor_target attribute.
    /// </summary>
    public TerraformProperty<bool> HasMinorTarget
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("has_minor_target");
        set => SetProperty("has_minor_target", value);
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
    /// The include_all attribute.
    /// </summary>
    public TerraformProperty<bool> IncludeAll
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("include_all");
        set => SetProperty("include_all", value);
    }

    /// <summary>
    /// The latest attribute.
    /// </summary>
    public TerraformProperty<bool> Latest
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("latest");
        set => SetProperty("latest", value);
    }

    /// <summary>
    /// The parameter_group_family attribute.
    /// </summary>
    public TerraformProperty<string> ParameterGroupFamily
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parameter_group_family");
        set => SetProperty("parameter_group_family", value);
    }

    /// <summary>
    /// The preferred_major_targets attribute.
    /// </summary>
    public List<TerraformProperty<string>> PreferredMajorTargets
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("preferred_major_targets");
        set => SetProperty("preferred_major_targets", value);
    }

    /// <summary>
    /// The preferred_upgrade_targets attribute.
    /// </summary>
    public List<TerraformProperty<string>> PreferredUpgradeTargets
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("preferred_upgrade_targets");
        set => SetProperty("preferred_upgrade_targets", value);
    }

    /// <summary>
    /// The preferred_versions attribute.
    /// </summary>
    public List<TerraformProperty<string>> PreferredVersions
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("preferred_versions");
        set => SetProperty("preferred_versions", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsRdsEngineVersionDataSourceFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// The default_character_set attribute.
    /// </summary>
    public TerraformExpression DefaultCharacterSet => this["default_character_set"];

    /// <summary>
    /// The engine_description attribute.
    /// </summary>
    public TerraformExpression EngineDescription => this["engine_description"];

    /// <summary>
    /// The exportable_log_types attribute.
    /// </summary>
    public TerraformExpression ExportableLogTypes => this["exportable_log_types"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The supported_character_sets attribute.
    /// </summary>
    public TerraformExpression SupportedCharacterSets => this["supported_character_sets"];

    /// <summary>
    /// The supported_feature_names attribute.
    /// </summary>
    public TerraformExpression SupportedFeatureNames => this["supported_feature_names"];

    /// <summary>
    /// The supported_modes attribute.
    /// </summary>
    public TerraformExpression SupportedModes => this["supported_modes"];

    /// <summary>
    /// The supported_timezones attribute.
    /// </summary>
    public TerraformExpression SupportedTimezones => this["supported_timezones"];

    /// <summary>
    /// The supports_certificate_rotation_without_restart attribute.
    /// </summary>
    public TerraformExpression SupportsCertificateRotationWithoutRestart => this["supports_certificate_rotation_without_restart"];

    /// <summary>
    /// The supports_global_databases attribute.
    /// </summary>
    public TerraformExpression SupportsGlobalDatabases => this["supports_global_databases"];

    /// <summary>
    /// The supports_integrations attribute.
    /// </summary>
    public TerraformExpression SupportsIntegrations => this["supports_integrations"];

    /// <summary>
    /// The supports_limitless_database attribute.
    /// </summary>
    public TerraformExpression SupportsLimitlessDatabase => this["supports_limitless_database"];

    /// <summary>
    /// The supports_local_write_forwarding attribute.
    /// </summary>
    public TerraformExpression SupportsLocalWriteForwarding => this["supports_local_write_forwarding"];

    /// <summary>
    /// The supports_log_exports_to_cloudwatch attribute.
    /// </summary>
    public TerraformExpression SupportsLogExportsToCloudwatch => this["supports_log_exports_to_cloudwatch"];

    /// <summary>
    /// The supports_parallel_query attribute.
    /// </summary>
    public TerraformExpression SupportsParallelQuery => this["supports_parallel_query"];

    /// <summary>
    /// The supports_read_replica attribute.
    /// </summary>
    public TerraformExpression SupportsReadReplica => this["supports_read_replica"];

    /// <summary>
    /// The valid_major_targets attribute.
    /// </summary>
    public TerraformExpression ValidMajorTargets => this["valid_major_targets"];

    /// <summary>
    /// The valid_minor_targets attribute.
    /// </summary>
    public TerraformExpression ValidMinorTargets => this["valid_minor_targets"];

    /// <summary>
    /// The valid_upgrade_targets attribute.
    /// </summary>
    public TerraformExpression ValidUpgradeTargets => this["valid_upgrade_targets"];

    /// <summary>
    /// The version_actual attribute.
    /// </summary>
    public TerraformExpression VersionActual => this["version_actual"];

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    public TerraformExpression VersionDescription => this["version_description"];

}
