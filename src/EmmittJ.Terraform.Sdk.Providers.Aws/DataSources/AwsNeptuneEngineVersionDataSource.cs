using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_neptune_engine_version.
/// </summary>
public class AwsNeptuneEngineVersionDataSource : TerraformDataSource
{
    public AwsNeptuneEngineVersionDataSource(string name) : base("aws_neptune_engine_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("default_character_set");
        this.DeclareOutput("engine_description");
        this.DeclareOutput("exportable_log_types");
        this.DeclareOutput("supported_character_sets");
        this.DeclareOutput("supported_timezones");
        this.DeclareOutput("supports_global_databases");
        this.DeclareOutput("supports_log_exports_to_cloudwatch");
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
    public TerraformProperty<bool>? DefaultOnly
    {
        get => GetProperty<TerraformProperty<bool>>("default_only");
        set => this.WithProperty("default_only", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string>? Engine
    {
        get => GetProperty<TerraformProperty<string>>("engine");
        set => this.WithProperty("engine", value);
    }

    /// <summary>
    /// The has_major_target attribute.
    /// </summary>
    public TerraformProperty<bool>? HasMajorTarget
    {
        get => GetProperty<TerraformProperty<bool>>("has_major_target");
        set => this.WithProperty("has_major_target", value);
    }

    /// <summary>
    /// The has_minor_target attribute.
    /// </summary>
    public TerraformProperty<bool>? HasMinorTarget
    {
        get => GetProperty<TerraformProperty<bool>>("has_minor_target");
        set => this.WithProperty("has_minor_target", value);
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
    /// The latest attribute.
    /// </summary>
    public TerraformProperty<bool>? Latest
    {
        get => GetProperty<TerraformProperty<bool>>("latest");
        set => this.WithProperty("latest", value);
    }

    /// <summary>
    /// The parameter_group_family attribute.
    /// </summary>
    public TerraformProperty<string>? ParameterGroupFamily
    {
        get => GetProperty<TerraformProperty<string>>("parameter_group_family");
        set => this.WithProperty("parameter_group_family", value);
    }

    /// <summary>
    /// The preferred_major_targets attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PreferredMajorTargets
    {
        get => GetProperty<List<TerraformProperty<string>>>("preferred_major_targets");
        set => this.WithProperty("preferred_major_targets", value);
    }

    /// <summary>
    /// The preferred_upgrade_targets attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PreferredUpgradeTargets
    {
        get => GetProperty<List<TerraformProperty<string>>>("preferred_upgrade_targets");
        set => this.WithProperty("preferred_upgrade_targets", value);
    }

    /// <summary>
    /// The preferred_versions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PreferredVersions
    {
        get => GetProperty<List<TerraformProperty<string>>>("preferred_versions");
        set => this.WithProperty("preferred_versions", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
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
    /// The supported_character_sets attribute.
    /// </summary>
    public TerraformExpression SupportedCharacterSets => this["supported_character_sets"];

    /// <summary>
    /// The supported_timezones attribute.
    /// </summary>
    public TerraformExpression SupportedTimezones => this["supported_timezones"];

    /// <summary>
    /// The supports_global_databases attribute.
    /// </summary>
    public TerraformExpression SupportsGlobalDatabases => this["supports_global_databases"];

    /// <summary>
    /// The supports_log_exports_to_cloudwatch attribute.
    /// </summary>
    public TerraformExpression SupportsLogExportsToCloudwatch => this["supports_log_exports_to_cloudwatch"];

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
