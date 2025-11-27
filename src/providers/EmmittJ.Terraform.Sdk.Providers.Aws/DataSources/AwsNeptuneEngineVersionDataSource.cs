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
        get => new TerraformReference<bool>(this, "default_only");
        set => SetArgument("default_only", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string>? Engine
    {
        get => new TerraformReference<string>(this, "engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The has_major_target attribute.
    /// </summary>
    public TerraformValue<bool>? HasMajorTarget
    {
        get => new TerraformReference<bool>(this, "has_major_target");
        set => SetArgument("has_major_target", value);
    }

    /// <summary>
    /// The has_minor_target attribute.
    /// </summary>
    public TerraformValue<bool>? HasMinorTarget
    {
        get => new TerraformReference<bool>(this, "has_minor_target");
        set => SetArgument("has_minor_target", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The latest attribute.
    /// </summary>
    public TerraformValue<bool>? Latest
    {
        get => new TerraformReference<bool>(this, "latest");
        set => SetArgument("latest", value);
    }

    /// <summary>
    /// The parameter_group_family attribute.
    /// </summary>
    public TerraformValue<string> ParameterGroupFamily
    {
        get => new TerraformReference<string>(this, "parameter_group_family");
        set => SetArgument("parameter_group_family", value);
    }

    /// <summary>
    /// The preferred_major_targets attribute.
    /// </summary>
    public TerraformList<string>? PreferredMajorTargets
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "preferred_major_targets").ResolveNodes(ctx));
        set => SetArgument("preferred_major_targets", value);
    }

    /// <summary>
    /// The preferred_upgrade_targets attribute.
    /// </summary>
    public TerraformList<string>? PreferredUpgradeTargets
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "preferred_upgrade_targets").ResolveNodes(ctx));
        set => SetArgument("preferred_upgrade_targets", value);
    }

    /// <summary>
    /// The preferred_versions attribute.
    /// </summary>
    public TerraformList<string>? PreferredVersions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "preferred_versions").ResolveNodes(ctx));
        set => SetArgument("preferred_versions", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The default_character_set attribute.
    /// </summary>
    public TerraformValue<string> DefaultCharacterSet
    {
        get => new TerraformReference<string>(this, "default_character_set");
    }

    /// <summary>
    /// The engine_description attribute.
    /// </summary>
    public TerraformValue<string> EngineDescription
    {
        get => new TerraformReference<string>(this, "engine_description");
    }

    /// <summary>
    /// The exportable_log_types attribute.
    /// </summary>
    public TerraformSet<string> ExportableLogTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "exportable_log_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The supported_character_sets attribute.
    /// </summary>
    public TerraformSet<string> SupportedCharacterSets
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "supported_character_sets").ResolveNodes(ctx));
    }

    /// <summary>
    /// The supported_timezones attribute.
    /// </summary>
    public TerraformSet<string> SupportedTimezones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "supported_timezones").ResolveNodes(ctx));
    }

    /// <summary>
    /// The supports_global_databases attribute.
    /// </summary>
    public TerraformValue<bool> SupportsGlobalDatabases
    {
        get => new TerraformReference<bool>(this, "supports_global_databases");
    }

    /// <summary>
    /// The supports_log_exports_to_cloudwatch attribute.
    /// </summary>
    public TerraformValue<bool> SupportsLogExportsToCloudwatch
    {
        get => new TerraformReference<bool>(this, "supports_log_exports_to_cloudwatch");
    }

    /// <summary>
    /// The supports_read_replica attribute.
    /// </summary>
    public TerraformValue<bool> SupportsReadReplica
    {
        get => new TerraformReference<bool>(this, "supports_read_replica");
    }

    /// <summary>
    /// The valid_major_targets attribute.
    /// </summary>
    public TerraformSet<string> ValidMajorTargets
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "valid_major_targets").ResolveNodes(ctx));
    }

    /// <summary>
    /// The valid_minor_targets attribute.
    /// </summary>
    public TerraformSet<string> ValidMinorTargets
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "valid_minor_targets").ResolveNodes(ctx));
    }

    /// <summary>
    /// The valid_upgrade_targets attribute.
    /// </summary>
    public TerraformSet<string> ValidUpgradeTargets
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "valid_upgrade_targets").ResolveNodes(ctx));
    }

    /// <summary>
    /// The version_actual attribute.
    /// </summary>
    public TerraformValue<string> VersionActual
    {
        get => new TerraformReference<string>(this, "version_actual");
    }

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    public TerraformValue<string> VersionDescription
    {
        get => new TerraformReference<string>(this, "version_description");
    }

}
