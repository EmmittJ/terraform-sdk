using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("default_character_set");
        this.DeclareOutput("engine_description");
        this.DeclareOutput("exportable_log_types");
        this.DeclareOutput("status");
        this.DeclareOutput("supported_character_sets");
        this.DeclareOutput("supported_feature_names");
        this.DeclareOutput("supported_modes");
        this.DeclareOutput("supported_timezones");
        this.DeclareOutput("supports_certificate_rotation_without_restart");
        this.DeclareOutput("supports_global_databases");
        this.DeclareOutput("supports_integrations");
        this.DeclareOutput("supports_limitless_database");
        this.DeclareOutput("supports_local_write_forwarding");
        this.DeclareOutput("supports_log_exports_to_cloudwatch");
        this.DeclareOutput("supports_parallel_query");
        this.DeclareOutput("supports_read_replica");
        this.DeclareOutput("valid_major_targets");
        this.DeclareOutput("valid_minor_targets");
        this.DeclareOutput("valid_upgrade_targets");
        this.DeclareOutput("version_actual");
        this.DeclareOutput("version_description");
    }

    /// <summary>
    /// The default_only attribute.
    /// </summary>
    public bool? DefaultOnly
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("default_only")?.Value;
        set => this.WithProperty("default_only", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public string? Engine
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine")?.Value;
        set => this.WithProperty("engine", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The has_major_target attribute.
    /// </summary>
    public bool? HasMajorTarget
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("has_major_target")?.Value;
        set => this.WithProperty("has_major_target", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The has_minor_target attribute.
    /// </summary>
    public bool? HasMinorTarget
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("has_minor_target")?.Value;
        set => this.WithProperty("has_minor_target", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The include_all attribute.
    /// </summary>
    public bool? IncludeAll
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_all")?.Value;
        set => this.WithProperty("include_all", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The latest attribute.
    /// </summary>
    public bool? Latest
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("latest")?.Value;
        set => this.WithProperty("latest", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The parameter_group_family attribute.
    /// </summary>
    public string? ParameterGroupFamily
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter_group_family")?.Value;
        set => this.WithProperty("parameter_group_family", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preferred_major_targets attribute.
    /// </summary>
    public List<string>? PreferredMajorTargets
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("preferred_major_targets")?.Value;
        set => this.WithProperty("preferred_major_targets", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The preferred_upgrade_targets attribute.
    /// </summary>
    public List<string>? PreferredUpgradeTargets
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("preferred_upgrade_targets")?.Value;
        set => this.WithProperty("preferred_upgrade_targets", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The preferred_versions attribute.
    /// </summary>
    public List<string>? PreferredVersions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("preferred_versions")?.Value;
        set => this.WithProperty("preferred_versions", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public string? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
