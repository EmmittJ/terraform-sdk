using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_neptune_engine_version Terraform data source.
/// Retrieves information about a aws_neptune_engine_version.
/// </summary>
public partial class AwsNeptuneEngineVersionDataSource(string name) : TerraformDataSource("aws_neptune_engine_version", name)
{
    /// <summary>
    /// The default_only attribute.
    /// </summary>
    public TerraformValue<bool>? DefaultOnly
    {
        get => GetArgument<TerraformValue<bool>>("default_only");
        set => SetArgument("default_only", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string>? Engine
    {
        get => GetArgument<TerraformValue<string>>("engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The has_major_target attribute.
    /// </summary>
    public TerraformValue<bool>? HasMajorTarget
    {
        get => GetArgument<TerraformValue<bool>>("has_major_target");
        set => SetArgument("has_major_target", value);
    }

    /// <summary>
    /// The has_minor_target attribute.
    /// </summary>
    public TerraformValue<bool>? HasMinorTarget
    {
        get => GetArgument<TerraformValue<bool>>("has_minor_target");
        set => SetArgument("has_minor_target", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The latest attribute.
    /// </summary>
    public TerraformValue<bool>? Latest
    {
        get => GetArgument<TerraformValue<bool>>("latest");
        set => SetArgument("latest", value);
    }

    /// <summary>
    /// The parameter_group_family attribute.
    /// </summary>
    public TerraformValue<string> ParameterGroupFamily
    {
        get => GetArgument<TerraformValue<string>>("parameter_group_family") ?? AsReference("parameter_group_family");
        set => SetArgument("parameter_group_family", value);
    }

    /// <summary>
    /// The preferred_major_targets attribute.
    /// </summary>
    public TerraformList<string>? PreferredMajorTargets
    {
        get => GetArgument<TerraformList<string>>("preferred_major_targets");
        set => SetArgument("preferred_major_targets", value);
    }

    /// <summary>
    /// The preferred_upgrade_targets attribute.
    /// </summary>
    public TerraformList<string>? PreferredUpgradeTargets
    {
        get => GetArgument<TerraformList<string>>("preferred_upgrade_targets");
        set => SetArgument("preferred_upgrade_targets", value);
    }

    /// <summary>
    /// The preferred_versions attribute.
    /// </summary>
    public TerraformList<string>? PreferredVersions
    {
        get => GetArgument<TerraformList<string>>("preferred_versions");
        set => SetArgument("preferred_versions", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => GetArgument<TerraformValue<string>>("version") ?? AsReference("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The default_character_set attribute.
    /// </summary>
    public TerraformValue<string> DefaultCharacterSet
        => AsReference("default_character_set");

    /// <summary>
    /// The engine_description attribute.
    /// </summary>
    public TerraformValue<string> EngineDescription
        => AsReference("engine_description");

    /// <summary>
    /// The exportable_log_types attribute.
    /// </summary>
    public TerraformSet<string> ExportableLogTypes
        => AsReference("exportable_log_types");

    /// <summary>
    /// The supported_character_sets attribute.
    /// </summary>
    public TerraformSet<string> SupportedCharacterSets
        => AsReference("supported_character_sets");

    /// <summary>
    /// The supported_timezones attribute.
    /// </summary>
    public TerraformSet<string> SupportedTimezones
        => AsReference("supported_timezones");

    /// <summary>
    /// The supports_global_databases attribute.
    /// </summary>
    public TerraformValue<bool> SupportsGlobalDatabases
        => AsReference("supports_global_databases");

    /// <summary>
    /// The supports_log_exports_to_cloudwatch attribute.
    /// </summary>
    public TerraformValue<bool> SupportsLogExportsToCloudwatch
        => AsReference("supports_log_exports_to_cloudwatch");

    /// <summary>
    /// The supports_read_replica attribute.
    /// </summary>
    public TerraformValue<bool> SupportsReadReplica
        => AsReference("supports_read_replica");

    /// <summary>
    /// The valid_major_targets attribute.
    /// </summary>
    public TerraformSet<string> ValidMajorTargets
        => AsReference("valid_major_targets");

    /// <summary>
    /// The valid_minor_targets attribute.
    /// </summary>
    public TerraformSet<string> ValidMinorTargets
        => AsReference("valid_minor_targets");

    /// <summary>
    /// The valid_upgrade_targets attribute.
    /// </summary>
    public TerraformSet<string> ValidUpgradeTargets
        => AsReference("valid_upgrade_targets");

    /// <summary>
    /// The version_actual attribute.
    /// </summary>
    public TerraformValue<string> VersionActual
        => AsReference("version_actual");

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    public TerraformValue<string> VersionDescription
        => AsReference("version_description");

}
